namespace Syncfusion.DotNet.CLI.Wizard;

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
    Information,
    Help,
    Exit,
}

public sealed record MenuChoice(string Label, string? Command, MenuAction? Action);

public sealed record MenuCategory(string Name, IReadOnlyList<MenuChoice> Operations);

/// <summary>The typed operations and categories shown by the interactive menu.</summary>
public static class MenuItems
{
    public static readonly IReadOnlyList<MenuCategory> Categories =
    [
        new("Project creation",
        [
            new("Create a new project", "sf new", MenuAction.CreateProject),
        ]),
        new("Package management",
        [
            new("Add a package to an existing project", "sf add", MenuAction.AddPackage),
            // Improvement: Remove package from existing project is temporarily disabled for all platforms.
            // new("Remove a package from an existing project", "sf remove", MenuAction.RemovePackage),
            new("Update a package in an existing project", "sf update", MenuAction.UpdatePackages),
        ]),
        new("Discovery",
        [
            new("List available packages", "sf list <platform> packages", MenuAction.ListAvailablePackages),
            new("List installed packages in an existing project", "sf list <platform> installed", MenuAction.ListInstalledPackages),
            new("Search for packages", "sf search", MenuAction.SearchPackages),
        ]),
        new("Help and information",
        [
            new("View CLI information", "sf info", MenuAction.Information),
            new("Show help", "sf help", MenuAction.Help),
        ]),
    ];

    public static readonly IReadOnlyList<MenuChoice> Operations =
        Categories.SelectMany(category => category.Operations)
            .Append(new MenuChoice("Exit", "Ctrl+C", MenuAction.Exit))
            .ToArray();

    public static MenuChoice CreateCategoryChoice(MenuCategory category)
        => new(category.Name, null, null);
}
