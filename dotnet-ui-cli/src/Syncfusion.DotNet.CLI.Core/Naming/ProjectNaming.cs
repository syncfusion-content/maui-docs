using System.Globalization;
using System.Text;

namespace Syncfusion.DotNet.CLI.Core.Naming;

/// <summary>
/// Platform-neutral project naming. The directory a user selects (Project location) is never renamed;
/// the project name is derived from it only as a suggestion, and must satisfy <see cref="ValidateIdentifier"/>
/// for platforms whose project name doubles as assembly name and root namespace.
/// </summary>
public static class ProjectNaming
{
    public const string FallbackName = "App";

    private static readonly HashSet<string> ReservedNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "CON", "PRN", "AUX", "NUL", "CONIN$", "CONOUT$",
        "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
        "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9",
    };

    private static readonly HashSet<string> CSharpKeywords = new(StringComparer.Ordinal)
    {
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const",
        "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern",
        "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface",
        "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override",
        "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
        "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof",
        "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while",
    };

    /// <summary>Returns an error when <paramref name="name"/> cannot be a directory, assembly and C# root namespace name.</summary>
    public static string? ValidateIdentifier(string? name)
    {
        if (string.IsNullOrWhiteSpace(name)) return "A project name is required.";
        var value = name.Trim();
        if (ReservedNames.Contains(value)) return $"'{value}' is a reserved system name. Choose a different project name, for example '{Suggest(value)}'.";
        if (CSharpKeywords.Contains(value)) return $"'{value}' is a C# keyword. Choose a different project name, for example '{Suggest(value)}'.";
        if (!IsIdentifier(value))
            return $"Project name '{value}' is invalid. Use letters, digits and underscores, starting with a letter or underscore. Suggested: '{Suggest(value)}'.";
        return null;
    }

    /// <summary>
    /// Deterministically turns any text (usually a directory name) into a valid identifier project name:
    /// words are split on non-letter/digit characters, each word's first letter is upper-cased and the rest is preserved.
    /// </summary>
    public static string Suggest(string? raw)
    {
        var builder = new StringBuilder();
        var startOfWord = true;
        foreach (var rune in (raw ?? string.Empty).Trim().EnumerateRunes())
        {
            if (Rune.IsLetterOrDigit(rune) || (rune.Value == '_' && !startOfWord))
            {
                builder.Append((startOfWord && Rune.IsLetter(rune) ? Rune.ToUpperInvariant(rune) : rune).ToString());
                startOfWord = false;
            }
            else
            {
                startOfWord = true;
            }
        }

        var result = builder.ToString();
        if (result.Length == 0) return FallbackName;
        if (!IsIdentifierStart(result.EnumerateRunes().First())) result = FallbackName + result;
        if (ReservedNames.Contains(result) || CSharpKeywords.Contains(result)) result += FallbackName;
        return result;
    }

    /// <summary>Returns <paramref name="baseName"/> if free under <paramref name="parentDirectory"/>, otherwise the first free numeric suffix (1, 2, ...).</summary>
    public static string ResolveAvailableName(string baseName, string parentDirectory)
    {
        if (string.IsNullOrWhiteSpace(baseName)) throw new ArgumentException("Default project name cannot be empty.", nameof(baseName));
        var trimmed = baseName.Trim();
        if (!Exists(trimmed)) return trimmed;
        for (var suffix = 1; suffix < int.MaxValue; suffix++)
        {
            var candidate = $"{trimmed}{suffix}";
            if (!Exists(candidate)) return candidate;
        }

        throw new InvalidOperationException("Could not find an available default project name.");

        bool Exists(string candidate)
        {
            var path = Path.Combine(parentDirectory, candidate);
            return Directory.Exists(path) || File.Exists(path);
        }
    }

    private static bool IsIdentifier(string value)
    {
        var first = true;
        foreach (var rune in value.EnumerateRunes())
        {
            if (first ? !IsIdentifierStart(rune) : !(IsIdentifierStart(rune) || Rune.IsDigit(rune) || Rune.GetUnicodeCategory(rune) is UnicodeCategory.NonSpacingMark or UnicodeCategory.SpacingCombiningMark or UnicodeCategory.ConnectorPunctuation))
                return false;
            first = false;
        }

        return !first;
    }

    private static bool IsIdentifierStart(Rune rune) => rune.Value == '_' || Rune.IsLetter(rune);
}
