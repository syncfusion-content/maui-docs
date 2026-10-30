using Spectre.Console;
using Syncfusion.DotNet.Cli.Commands.Desktop;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Presentation;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class WpfThemeFlowTests
{
    public static IEnumerable<object[]> Cases()
    {
        foreach (var controls in new[] { false, true })
        foreach (var interactive in new[] { false, true })
        foreach (var theme in new string?[] { null, "Material3Dark" })
            yield return [controls, interactive, theme!];
    }

    [Theory]
    [MemberData(nameof(Cases))]
    public void ThemeIsPromptedOnlyAfterControlsAreChosen(bool controls, bool interactive, string? suppliedTheme)
    {
        var provider = DesktopProviders.Find("wpf")!;
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 160;
        console.Profile.Height = 40;
        using var region = ProjectWizardOutput.Begin(console, true);
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)]);
        var reads = 0;
        var input = new InteractiveConsoleInput(console, _ =>
        {
            Assert.True(controls && interactive && suppliedTheme is null, "Unexpected theme prompt");
            reads++;
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        }, true);
        input.WriteResult("Setup", controls ? "Include Syncfusion controls" : "Empty project");
        if (controls) input.WriteResult("Controls", "DataGrid");
        var selected = DesktopCommands.WpfThemeAfterControls(input, provider, controls ? ["datagrid"] : [], suppliedTheme, interactive);
        var shouldPrompt = controls && interactive && suppliedTheme is null;
        Assert.Equal(suppliedTheme ?? (shouldPrompt ? "Windows11Dark" : provider.DefaultTheme), selected);
        Assert.Equal(shouldPrompt ? 2 : 0, reads);
        Assert.Equal(controls && interactive, ProjectWizardOutput.HasCompletedValue("Theme:"));
        if (controls && interactive)
            Assert.True(writer.ToString().IndexOf("Controls:", StringComparison.Ordinal) < writer.ToString().IndexOf("Theme:", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("C#", "net48")]
    [InlineData("VB", "net48")]
    [InlineData("C#", "net10.0")]
    [InlineData("VB", "net10.0")]
    public void ExplicitThemeStillDrivesGeneratedSourcesAndDependencies(string language, string framework)
    {
        var provider = DesktopProviders.Find("wpf")!;
        var request = new DesktopNewRequest(provider.Platform, "ThemeCheck", Path.GetTempPath(), language,
            framework, "Material3Dark", ["datagrid"], false, false);
        Assert.Null(DesktopConfiguration.Validate(provider, request));
        Assert.Contains("Syncfusion.Themes.Material3Dark.WPF", provider.RequiredPackages(request));
        Assert.Contains("Material3Dark", string.Join('\n', provider.Generate(request).Values));
        var rows = DesktopCommands.Review(provider, request).Select(row => row.Label).ToArray();
        Assert.True(Array.IndexOf(rows, "Controls:") < Array.IndexOf(rows, "Theme:"));
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
}
