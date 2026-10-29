namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// Categories for the <c>sf list</c> command.
/// </summary>
public enum ListCategory
{
    /// <summary>Available Syncfusion packages.</summary>
    Packages,

    /// <summary>Packages installed in the current project.</summary>
    Installed,

    /// <summary>Available project templates.</summary>
    Templates,

    /// <summary>Templates recorded as installed by the CLI manifest.</summary>
    InstalledTemplates,

}
