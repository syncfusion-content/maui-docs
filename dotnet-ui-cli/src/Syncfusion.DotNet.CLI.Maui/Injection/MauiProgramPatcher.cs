using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Maui.Injection;

/// <summary>
/// Adds and removes the shared Syncfusion MAUI registration call in
/// <c>MauiProgram.cs</c>. Every supported control requires the single shared
/// call <c>builder.ConfigureSyncfusionCore();</c> (namespace
/// <c>Syncfusion.Maui.Core.Hosting</c>), so the patcher is idempotent: it
/// adds the using directive and the registration call exactly once, and only
/// removes them when no installed control still requires them.
/// </summary>
public static class MauiProgramPatcher
{
    private const string _registrationUsing = "Syncfusion.Maui.Core.Hosting";
    private const string _registrationCall = "builder.ConfigureSyncfusionCore();";

    /// <summary>
    /// The path to <c>MauiProgram.cs</c> inside <paramref name="projectRoot"/>.
    /// The MAUI template places the file at the project root.
    /// </summary>
    public static string ResolveMauiProgramPath(string projectRoot)
        => Path.Combine(projectRoot, "MauiProgram.cs");

    /// <summary>True when the registration call is already present.</summary>
    public static bool IsRegistered(string projectRoot)
    {
        var path = ResolveMauiProgramPath(projectRoot);
        if (!File.Exists(path))
        {
            return false;
        }

        return HasRegistrationCall(File.ReadAllText(path));
    }

    /// <summary>True when applying shared registration would modify MauiProgram.cs.</summary>
    public static bool WouldModifyRegistration(string projectRoot)
    {
        var path = ResolveMauiProgramPath(projectRoot);
        if (!File.Exists(path))
        {
            return false;
        }

        var text = File.ReadAllText(path);
        return !HasUsing(text, _registrationUsing) || !HasRegistrationCall(text);
    }

    /// <summary>
    /// Adds the using directive and the registration call when missing.
    /// Returns a list of relative paths that were modified (at most
    /// <c>MauiProgram.cs</c>), for manifest tracking. Idempotent: a second
    /// call does nothing.
    /// </summary>
    public static IReadOnlyList<string> EnsureRegistered(string projectRoot)
    {
        var path = ResolveMauiProgramPath(projectRoot);
        if (!File.Exists(path))
        {
            return [];
        }

        var modified = new List<string>();
        var text = File.ReadAllText(path);
        var changed = false;

        if (!HasUsing(text, _registrationUsing))
        {
            text = InsertUsing(text, _registrationUsing);
            changed = true;
        }

        if (!HasRegistrationCall(text))
        {
            text = InsertRegistrationCall(text, _registrationCall);
            changed = true;
        }

        if (changed)
        {
            File.WriteAllText(path, text);
            modified.Add("MauiProgram.cs");
        }

        return modified;
    }

    /// <summary>
    /// Removes the registration call and using directive when no remaining
    /// control requires them. Pass <paramref name="installedCount"/> as the
    /// number of controls still installed after the current operation. When
    /// it is zero, the shared registration is removed; otherwise it is kept.
    /// Returns the relative paths that were modified.
    /// </summary>
    public static IReadOnlyList<string> RemoveWhenUnused(
        string projectRoot,
        int installedCount,
        bool registrationOwned = true)
    {
        if (installedCount > 0 || !registrationOwned)
        {
            return [];
        }

        var path = ResolveMauiProgramPath(projectRoot);
        if (!File.Exists(path))
        {
            return [];
        }

        var text = File.ReadAllText(path);
        var changed = false;

        if (text.Contains("<sf-cli:core-registration>", StringComparison.Ordinal))
        {
            text = GeneratedCodeBlocks.Remove(text, "core-registration");
            changed = true;
        }

        if (text.Contains("<sf-cli:core-using>", StringComparison.Ordinal))
        {
            text = GeneratedCodeBlocks.Remove(text, "core-using");
            changed = true;
        }

        if (changed)
        {
            File.WriteAllText(path, text);
            return ["MauiProgram.cs"];
        }

        return [];
    }

    private static string InsertUsing(string text, string usingNamespace)
    => InsertUsingAfterLastGlobalOrSystemUsing(text,
        GeneratedCodeBlocks.Wrap("core-using", $"using {usingNamespace};").TrimEnd('\n'));

    private static string InsertUsingAfterLastGlobalOrSystemUsing(string text, string usingLine)
    {
        var newline = GetNewLine(text);
        var lines = text.Replace("\r\n", "\n").Split('\n');
        var insertAt = -1;

        for (var i = 0; i < lines.Length; i++)
        {
            var trimmed = lines[i].TrimStart();
            if (trimmed.StartsWith("using ", System.StringComparison.Ordinal))
            {
                insertAt = i + 1;
            }
            else if (trimmed.Length > 0 && !trimmed.StartsWith("//", System.StringComparison.Ordinal) && insertAt >= 0)
            {
                break;
            }
        }

        if (insertAt < 0)
        {
            // No using block found; place at the top.
            return usingLine + newline + text;
        }

        var result = new System.Collections.Generic.List<string>(lines);
        result.Insert(insertAt, usingLine);
        return string.Join(newline, result);
    }

    private static string InsertRegistrationCall(string text, string call)
    {
        var newline = GetNewLine(text);
        // Insert immediately after the builder creation line so the call runs
        // during host construction. Fall back to appending before CreateMauiApp.
        var lines = text.Replace("\r\n", "\n").Split('\n');
        for (var i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains("MauiApp.CreateBuilder", System.StringComparison.Ordinal))
            {
                var indent = ExtractIndent(lines[i]);
                var insertAt = i + 1;
                // Skip blank/brace lines that follow the builder line.
                while (insertAt < lines.Length && string.IsNullOrWhiteSpace(lines[insertAt]))
                {
                    insertAt++;
                }

                var list = new System.Collections.Generic.List<string>(lines);
                list.Insert(insertAt, GeneratedCodeBlocks.Wrap("core-registration", indent + call, indent: indent).TrimEnd('\n'));
                return string.Join(newline, list);
            }
        }

        // Fallback: insert just before builder.Build().
        for (var i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(".Build()", System.StringComparison.Ordinal))
            {
                var indent = ExtractIndent(lines[i]);
                var list = new System.Collections.Generic.List<string>(lines);
                list.Insert(i, GeneratedCodeBlocks.Wrap("core-registration", indent + call, indent: indent).TrimEnd('\n'));
                return string.Join(newline, list);
            }
        }

        return text;
    }

    private static bool HasRegistrationCall(string text)
        => Regex.IsMatch(
            text,
            @"(?m)^\s*builder\.ConfigureSyncfusionCore\(\);\s*(?://.*)?$",
            RegexOptions.CultureInvariant);

    private static bool HasUsing(string text, string usingNamespace)
        => text.Replace("\r\n", "\n").Split('\n')
            .Any(line => line.Trim().Equals($"using {usingNamespace};", StringComparison.Ordinal));

    private static string GetNewLine(string text)
        => text.Contains("\r\n", StringComparison.Ordinal) ? "\r\n" : "\n";

    private static string ExtractIndent(string line)
    {
        var sb = new StringBuilder();
        foreach (var c in line)
        {
            if (c == ' ' || c == '\t')
            {
                sb.Append(c);
            }
            else
            {
                break;
            }
        }

        return sb.ToString();
    }
}
