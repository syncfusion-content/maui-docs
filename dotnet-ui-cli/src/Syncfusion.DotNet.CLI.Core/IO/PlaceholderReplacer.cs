using System.Collections.Generic;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// Replaces the small, fixed set of template placeholders supported by the
/// CLI. There is no custom template language; only these five tokens are
/// substituted, and they are matched case-sensitively as written.
/// </summary>
public static class PlaceholderReplacer
{
    /// <summary>The supported placeholder tokens, in stable order.</summary>
    public static readonly IReadOnlyList<string> Tokens =
    [
        "__PROJECT_NAME__",
        "__ROOT_NAMESPACE__",
        "__CONTROL_NAME__",
        "__VIEW_NAME__",
        "__VIEW_MODEL_NAME__",
    ];

    /// <summary>
    /// Replaces every supported placeholder in <paramref name="input"/> using
    /// the values in <paramref name="values"/>. Unknown keys are ignored.
    /// </summary>
    public static string Replace(string input, IReadOnlyDictionary<string, string> values)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        var result = input;
        foreach (var token in Tokens)
        {
            if (values.TryGetValue(token, out var value) && !string.IsNullOrEmpty(value))
            {
                result = result.Replace(token, value);
            }
        }

        return result;
    }

    /// <summary>
    /// Builds a placeholder value dictionary from the common generation
    /// inputs. Derives <c>__VIEW_NAME__</c> and <c>__VIEW_MODEL_NAME__</c>
    /// from the control name when they are not supplied explicitly.
    /// </summary>
    public static Dictionary<string, string> BuildValues(
        string projectName,
        string rootNamespace,
        string controlName,
        string? viewName = null,
        string? viewModelName = null)
    {
        return new Dictionary<string, string>(System.StringComparer.Ordinal)
        {
            ["__PROJECT_NAME__"] = projectName ?? string.Empty,
            ["__ROOT_NAMESPACE__"] = rootNamespace ?? string.Empty,
            ["__CONTROL_NAME__"] = controlName ?? string.Empty,
            ["__VIEW_NAME__"] = viewName ?? controlName + "View",
            ["__VIEW_MODEL_NAME__"] = viewModelName ?? controlName + "ViewModel",
        };
    }

    /// <summary>
    /// Normalizes a project namespace into valid C# identifier segments.
    /// Explicit project root namespaces should be passed when available.
    /// </summary>
    public static string NormalizeRootNamespace(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("A project root namespace is required.", nameof(value));
        }

        var segments = value.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (segments.Length == 0)
        {
            throw new ArgumentException("The project root namespace has no valid identifier segments.", nameof(value));
        }

        return string.Join('.', segments.Select(NormalizeIdentifier));
    }

    private static string NormalizeIdentifier(string value)
    {
        var chars = value.Select((character, index) =>
            (char.IsLetter(character) || character == '_' || (index > 0 && char.IsDigit(character)))
                ? character
                : '_').ToArray();
        if (chars.Length == 0 || char.IsDigit(chars[0]))
        {
            return "_" + new string(chars);
        }

        return new string(chars);
    }
}
