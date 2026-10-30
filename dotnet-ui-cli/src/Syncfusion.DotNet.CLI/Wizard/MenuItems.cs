namespace Syncfusion.DotNet.Cli.Wizard;

public enum MenuAction
{
    CreateProject,
    AddPackage,
    // Improvement: Remove package from existing project is temporarily disabled for all platforms.
    // RemovePackage,
    UpdatePackages,
    ListAvailablePackages,
    ListInstalledPackages,
    SearchPackages,
    SetupMcp,
    InstallSkills,
    ActivateLicense,
    ViewLicenses,
    SignIn,
    SignOut,
    Information,
    Help,
    Exit,
}

public sealed record MenuChoice(string Label, string? Command, MenuAction? Action)
{
    internal string? Icon { get; init; }
}

public sealed record MenuCategory(string Name, IReadOnlyList<MenuChoice> Operations)
{
    internal string? Icon { get; init; }
}

/// <summary>The typed operations and categories shown by the interactive menu.</summary>
public static class MenuItems
{
    public static readonly IReadOnlyList<MenuCategory> Categories =
    [
        new("Project creation",
        [
            new("Create a new project", "sfdotnet new", MenuAction.CreateProject),
        ]) { Icon = "📦" },
        new("Package management",
        [
            new("Add a package to an existing project", "sfdotnet add", MenuAction.AddPackage),
            // Improvement: Remove package from existing project is temporarily disabled for all platforms.
            // new("Remove a package from an existing project", "sfdotnet remove", MenuAction.RemovePackage),
            new("Update a package in an existing project", "sfdotnet update", MenuAction.UpdatePackages),
        ]) { Icon = "🛠️" },
        new("Discovery",
        [
            new("List available packages", "sfdotnet list <platform> packages", MenuAction.ListAvailablePackages),
            new("List installed packages in an existing project", "sfdotnet list <platform> installed", MenuAction.ListInstalledPackages),
            new("Search for packages", "sfdotnet search", MenuAction.SearchPackages),
        ]) { Icon = "🔎" },
        new("AI & Skills",
        [
            new("Setup Model Context Protocol (MCP)", "sfdotnet mcp init", MenuAction.SetupMcp),
            new("Add component skills to AI Agent", "sfdotnet skills install", MenuAction.InstallSkills),
        ]) { Icon = "🤖" },
        new("License management",
        [
            new("Activate license", "sfdotnet license activate", MenuAction.ActivateLicense),
            new("View installed licenses", "sfdotnet license view", MenuAction.ViewLicenses),
            new("Sign in to Syncfusion", "sfdotnet login", MenuAction.SignIn),
            new("Sign out", "sfdotnet logout", MenuAction.SignOut),
        ]) { Icon = "🔑" },
        new("Help and information",
        [
            new("View CLI information", "sfdotnet info", MenuAction.Information),
            new("Show help", "sfdotnet help", MenuAction.Help),
        ]) { Icon = "ℹ️" },
    ];

    public static readonly IReadOnlyList<MenuChoice> Operations =
        Categories.SelectMany(category => category.Operations)
            .Append(new MenuChoice("Exit", "Ctrl+C", MenuAction.Exit))
            .ToArray();

    public static MenuChoice CreateCategoryChoice(MenuCategory category)
        => new(category.Name, null, null) { Icon = category.Icon };
}
