namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// Central registry of the frameworks the Syncfusion .NET CLI recognizes.
/// Parsing and "implemented vs planned" status are resolved here so the
/// command surface stays consistent with <see cref="Framework"/>.
/// </summary>
public static class Frameworks
{
    /// <summary>The framework names currently implemented by this CLI.</summary>
    public static readonly string[] All =
    [
        "maui", "wpf", "winforms", "winui", "blazor",
    ];

    /// <summary>The frameworks that are currently implemented and usable.</summary>
    public static readonly string[] Implemented = All;

    /// <summary>Parses a framework name case-insensitively.</summary>
    /// <returns><see langword="true"/> when the name is recognized.</returns>
    public static bool TryParse(string? value, out Framework framework)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            var match = All.FirstOrDefault(f => string.Equals(f, value, StringComparison.OrdinalIgnoreCase));
            if (match is not null)
            {
                framework = Enum.Parse<Framework>(match, ignoreCase: true);
                return true;
            }
        }

        framework = default;
        return false;
    }

    /// <summary>True when the framework is recognized but not yet implemented.</summary>
    public static bool IsPlanned(Framework framework)
        => !Implemented.Any(f => string.Equals(f, framework.ToString(), StringComparison.OrdinalIgnoreCase));

    /// <summary>The canonical lowercase name for a framework value.</summary>
    public static string Name(Framework framework)
        => framework.ToString().ToLowerInvariant();
}
