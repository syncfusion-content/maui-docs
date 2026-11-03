namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>The shared value column for creation prompts, answers, and review rows.</summary>
internal static class ProjectFlowLayout
{
    internal static readonly IReadOnlyList<string> Labels =
    [
        "Action:", "Platform:", "Template:", "Framework:", "Project location:",
        "Project name:", "Setup:", "Controls:", "Post-create:",
        "Language:", "Target framework:", "Theme:",
        "Project file:", "Package:", "Packages:", "Version:", "Post-add:",
        "Application type:", "Render mode:", "Interactivity:",
        "Authentication:", "HTTPS:", "Components:",
    ];

    internal static int ValueColumn => Labels.Max(label => label.Length) + 2;
    internal static bool Contains(string label) => Labels.Contains(label);
}
