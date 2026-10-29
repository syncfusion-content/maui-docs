namespace Syncfusion.DotNet.CLI.Core.AI;

public sealed record AiPlatform(string Name, string McpPackage, string ServerName, string ToolCommand, string SkillsRepository);

public sealed record AiClient(string Name, string DisplayName, string Agent, string ConfigDirectory, string ConfigFile, string ServerProperty, bool ExplicitStdio);

/// <summary>Official platform packages and project-local client configuration formats.</summary>
public static class AiCatalog
{
    public static IReadOnlyList<AiPlatform> Platforms { get; } =
    [
        new("maui", "Syncfusion.Maui.MCP", "sf-maui-mcp", "syncfusion-maui-mcp", "syncfusion/maui-ui-components-skills"),
        new("blazor", "Syncfusion.Blazor.MCP", "sf-blazor-mcp", "syncfusion-blazor-mcp", "syncfusion/blazor-ui-components-skills"),
        new("wpf", "Syncfusion.WPF.MCP", "sf-wpf-mcp", "syncfusion-wpf-mcp", "syncfusion/wpf-ui-components-skills"),
        new("winforms", "Syncfusion.WinForms.MCP", "sf-winforms-mcp", "syncfusion-winforms-mcp", "syncfusion/winforms-ui-components-skills"),
        new("winui", "Syncfusion.WinUI.MCP", "sf-winui-mcp", "syncfusion-winui-mcp", "syncfusion/winui-ui-components-skills"),
    ];

    public static IReadOnlyList<AiClient> Clients { get; } =
    [
        new("vscode", "VS Code / GitHub Copilot", "github-copilot", ".vscode", "mcp.json", "servers", true),
        new("cursor", "Cursor", "cursor", ".cursor", "mcp.json", "mcpServers", false),
        new("codestudio", "Syncfusion Code Studio", "codestudio", ".codestudio", "mcp.json", "servers", true),
        new("claude-code", "Claude Code", "claude-code", "", ".mcp.json", "mcpServers", false),
    ];

    public static AiPlatform Platform(string name)
        => Platforms.FirstOrDefault(platform => platform.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            ?? throw new ArgumentException("Choose a platform: maui, blazor, wpf, winforms or winui.");

    public static AiClient Client(string name)
        => Clients.FirstOrDefault(client => client.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            ?? throw new ArgumentException("Choose a client: vscode, cursor, codestudio or claude-code.");
}
