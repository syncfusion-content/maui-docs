using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands.Desktop;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class PackageWizardSelectionTests
{
    public static IEnumerable<object[]> Platforms()
    {
        foreach (var platform in new[] { "maui", "blazor", "wpf", "winforms", "winui" })
        foreach (var width in new[] { 40, 200 })
            yield return [platform, width];
    }

    [Theory]
    [InlineData("maui")]
    [InlineData("blazor")]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public void AllPlatformPackagesShowOnlyConciseDisplayNames(string platform)
    {
        var packages = Packages(platform);
        foreach (var package in packages)
        {
            var row = InteractiveConsoleInput.FormatPackageChoice(package);
            Assert.DoesNotContain("Syncfusion ", row);
            Assert.DoesNotContain(" for .NET MAUI", row);
            Assert.DoesNotContain(Environment.NewLine, row);
            Assert.False(string.IsNullOrWhiteSpace(row));
        }
    }

    [Theory]
    [InlineData("Syncfusion A2UI for .NET MAUI", "A2UI")]
    [InlineData("Syncfusion® DataGrid for .NET MAUI", "DataGrid")]
    [InlineData("DataGrid", "DataGrid")]
    [InlineData("Syncfusion Tools for WPF", "Tools")]
    public void PickerNamesOmitBrandPlatformAndAlias(string displayName, string expected)
        => Assert.Equal(expected, InteractiveConsoleInput.FormatPackageChoice(new("internal-alias", displayName)));

    [Theory]
    [MemberData(nameof(Platforms))]
    public void PackageSelectionRetainsAlignedSummaryAndReturnsCatalogId(string platform, int width)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        using var region = ProjectWizardOutput.Begin(console, true);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(Key(ConsoleKey.Enter)), true);
        input.WriteResult("Action", "Add a package to an existing project");
        input.WriteResult("Platform", platform);
        var packages = Packages(platform);
        Assert.Equal(packages[0].Id, input.SelectPackage(packages, default, retainAnswer: true));
        Assert.True(ProjectWizardOutput.HasCompletedValue("Action:"));
        Assert.True(ProjectWizardOutput.HasCompletedValue("Platform:"));
        Assert.True(ProjectWizardOutput.HasCompletedValue("Package:"));
        Assert.Contains("Package:", writer.ToString());
        if (width == 200)
            Assert.Contains("Package:".PadRight(ProjectFlowLayout.ValueColumn) + InteractiveConsoleInput.FormatPackageChoice(packages[0]), writer.ToString());
    }

    [Fact]
    public void AddActionRemainsInSummaryAfterLeavingTheInitialMenu()
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 200);
        using var region = ProjectWizardOutput.Begin(console, true);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(Key(ConsoleKey.Enter)), true);
        var add = MenuItems.Operations.Single(choice => choice.Action == MenuAction.AddPackage);
        Assert.Equal(MenuAction.AddPackage, input.SelectMenu([add], default).Action);
        Assert.True(ProjectWizardOutput.HasCompletedValue("Action:"));
        Assert.Contains("Action:".PadRight(ProjectFlowLayout.ValueColumn) + add.Label, writer.ToString());
    }

    [Fact]
    public void SelectedControlsRemainInTheCompletedSummary()
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 200);
        using var region = ProjectWizardOutput.Begin(console, true);
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
        var provider = new MauiControlSelectionProvider(MauiProjectType.App);
        Assert.Equal(new[] { provider.Controls[0].Id }, InteractivePrompt.AskAddControls(provider, true, default, input));
        Assert.True(ProjectWizardOutput.HasCompletedValue("Controls:"));
        Assert.Contains("Controls:".PadRight(ProjectFlowLayout.ValueColumn) + provider.Controls[0].DisplayName, writer.ToString());
    }

    [Fact]
    public void PackageIdentityDoesNotDependOnDisplayNameUniqueness()
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 200);
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
        Assert.Equal("second", input.SelectPackage([new("first", "Same name"), new("second", "Same name")], default));
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void CheckboxPickerReturnsMultiplePackagesAcrossAllPlatforms(string platform, int width)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        using var region = ProjectWizardOutput.Begin(console, true);
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.Spacebar), Key(ConsoleKey.DownArrow), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
        var packages = Packages(platform);
        Assert.Equal(packages.Take(2).Select(package => package.Id), input.SelectPackages(packages, default));
        Assert.Contains("[x]", writer.ToString());
        Assert.Contains("Selected: 2", writer.ToString());
        Assert.True(ProjectWizardOutput.HasCompletedValue("Packages:"));
    }

    [Fact]
    public async Task PackageBatchExecutesEverySelectionAndMarksOnlyTheLastForBuild()
    {
        var calls = new List<(string Package, bool Last)>();
        Assert.Equal(0, await CommandOperations.RunPackageSelectionAsync(["first", "second", "FIRST"], (package, last) =>
        {
            calls.Add((package, last));
            return Task.FromResult(0);
        }));
        Assert.Equal(new[] { ("first", false), ("second", true) }, calls);
    }

    [Fact]
    public async Task PackageBatchStopsAtFirstFailure()
    {
        var calls = new List<string>();
        Assert.Equal(1, await CommandOperations.RunPackageSelectionAsync(["first", "second", "third"], (package, last) =>
        {
            calls.Add(package);
            return Task.FromResult(package == "second" ? 1 : 0);
        }));
        Assert.Equal(new[] { "first", "second" }, calls);
    }

    [Fact]
    public async Task EmptyPackageBatchCannotReportSuccess()
        => await Assert.ThrowsAsync<ArgumentException>(() => CommandOperations.RunPackageSelectionAsync([], (_, _) => Task.FromResult(0)));

    [Theory]
    [InlineData("maui")]
    [InlineData("blazor")]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public void SavedPackageReferencesAreMarkedAddedForEveryPlatform(string platform)
    {
        var path = Path.Combine(Path.GetTempPath(), "sf-package-state-" + Guid.NewGuid().ToString("N") + ".csproj");
        try
        {
            File.WriteAllText(path, "<Project><ItemGroup><PackageReference Include=\"Installed.Package\" /></ItemGroup></Project>");
            var choices = Packages(platform).Take(2).Select((package, index) => package with
                { PackageId = index == 0 ? "installed.package" : "Missing.Package" }).ToArray();
            var marked = PackageSelectionState.MarkInstalled(choices, path);
            Assert.True(marked[0].Added);
            Assert.False(marked[1].Added);
            using var writer = new StringWriter();
            var console = ConsoleFor(writer, 200);
            var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]);
            var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
            Assert.Equal(new[] { marked[1].Id }, input.SelectPackages(marked, default));
            Assert.Contains("[Added]", writer.ToString());
        }
        finally { File.Delete(path); }
    }

    public static IEnumerable<object[]> ConfirmationCases()
    {
        foreach (var prompt in new[] { "Proceed with project creation?", "Proceed to add packages?",
            "Proceed to update packages?", "Proceed to remove packages?", "Proceed to add control samples?",
            "More packages? (Enter = more)" })
        foreach (var accepted in new[] { false, true })
        foreach (var reviewCompleted in new[] { false, true })
            yield return [prompt, accepted, reviewCompleted];
    }

    [Theory]
    [MemberData(nameof(ConfirmationCases))]
    public void ConfirmationRetainsItsActionAndAnswer(string prompt, bool accepted, bool reviewCompleted)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 200);
        using var region = ProjectWizardOutput.Begin(console, true);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(Key(ConsoleKey.Enter)), true);
        if (reviewCompleted) ProjectWizardOutput.ReplaceCompletedSteps();
        Assert.Equal(accepted, InteractivePrompt.Confirm(prompt, accepted, input));
        var label = prompt.TrimEnd('?', ':') + ":";
        if (!reviewCompleted) Assert.True(ProjectWizardOutput.HasCompletedValue(label));
        Assert.Contains(label + (accepted ? " y" : " n"), writer.ToString());
        Assert.DoesNotContain("Confirmation:", writer.ToString());
    }

    private static PackageSelectionItem[] Packages(string platform)
        => platform == "maui" ? new MauiControlSelectionProvider(MauiProjectType.App).Packages.ToArray()
            : DesktopProviders.Find(platform)!.Packages.Select(package => new PackageSelectionItem(package.Alias, package.DisplayName)).ToArray();

    private static IAnsiConsole ConsoleFor(StringWriter writer, int width)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = width;
        console.Profile.Height = 60;
        return console;
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
}
