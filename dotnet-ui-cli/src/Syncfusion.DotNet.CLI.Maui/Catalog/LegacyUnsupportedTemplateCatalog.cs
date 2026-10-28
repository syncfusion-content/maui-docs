namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// Identifies template IDs that older CLI releases could have written to a
/// project manifest but which are no longer available for new operations.
/// This compatibility metadata is deliberately separate from the template catalog.
/// </summary>
public static class LegacyUnsupportedTemplateCatalog
{
    private static readonly IReadOnlyDictionary<string, string> Templates =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["badge-view"] = "BadgeView",
            ["button"] = "Button",
            ["slider"] = "Slider",
            ["switch"] = "Switch",
            ["tab-view"] = "TabView",
        };

    /// <summary>The IDs recognized in manifests created by older CLI releases.</summary>
    public static IEnumerable<string> Ids => Templates.Keys;

    /// <summary>Returns whether <paramref name="id"/> is a known unsupported legacy template.</summary>
    public static bool Contains(string? id)
        => !string.IsNullOrWhiteSpace(id) && Templates.ContainsKey(id.Trim());

    /// <summary>Resolves the display name for a known unsupported legacy template.</summary>
    public static bool TryResolve(string? id, out string displayName)
    {
        if (!string.IsNullOrWhiteSpace(id) && Templates.TryGetValue(id.Trim(), out var resolvedDisplayName))
        {
            displayName = resolvedDisplayName;
            return true;
        }

        displayName = string.Empty;
        return false;
    }
}
