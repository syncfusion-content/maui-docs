using System.Reflection;
using Syncfusion.DotNet.CLI.Commands.Blazor;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class BlazorWizardRoutingTests
{
    [Fact]
    public void PlatformMenuShowsCapitalizedBlazorAndRoundTrips()
    {
        var method = typeof(InteractivePrompt).GetMethod("BuildFrameworkChoices", BindingFlags.NonPublic | BindingFlags.Static)!;
        var choices = (IReadOnlyList<string>)method.Invoke(null, null)!;
        Assert.Contains("Blazor", choices);
        var parse = typeof(InteractivePrompt).GetMethod("ParseFrameworkChoice", BindingFlags.NonPublic | BindingFlags.Static)!;
        Assert.Equal("blazor", parse.Invoke(null, ["Blazor"]));
    }

    [Fact]
    public void MainMenuCreateProjectRoutesBlazorToBlazorWizard()
    {
        var source = File.ReadAllText(Path.Combine(FindRoot(), "src", "Syncfusion.DotNet.CLI", "Wizard", "InteractiveMenu.cs"));
        var create = source.IndexOf("case MenuAction.CreateProject", StringComparison.Ordinal);
        var blazor = source.IndexOf("BlazorCommands.NewAsync", create, StringComparison.Ordinal);
        var generic = source.IndexOf("NewCommand.BuildInteractive", create, StringComparison.Ordinal);
        Assert.True(blazor > create && blazor < generic, "Blazor must be routed before the generic MAUI wizard.");
    }

    [Fact]
    public void BlazorReviewListsEverySelectedField()
    {
        var request = new Syncfusion.DotNet.CLI.Blazor.BlazorNewRequest("App", "/tmp", Syncfusion.DotNet.CLI.Blazor.BlazorAppType.WebApp, "net10.0",
            Syncfusion.DotNet.CLI.Blazor.BlazorRenderMode.Server, Syncfusion.DotNet.CLI.Blazor.BlazorInteractivity.PerPage,
            Syncfusion.DotNet.CLI.Blazor.BlazorAuthentication.None, true, true, "fluent2", ["grid"], false, false);
        var labels = BlazorCommands.Review(request).Select(row => row.Label).ToArray();
        foreach (var expected in new[] { "Application type:", "Render mode:", "Interactivity:", "Authentication:", "HTTPS:", "Setup:", "Theme:", "Components:" })
            Assert.Contains(expected, labels);
        Assert.DoesNotContain("Language:", labels);
        Assert.True(Array.IndexOf(labels, "Components:") < Array.IndexOf(labels, "Theme:"));
        Assert.Equal("Include Syncfusion controls", BlazorCommands.Review(request).Single(row => row.Label == "Setup:").Value);
    }

    private static string FindRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null && !File.Exists(Path.Combine(dir.FullName, "sf-net-cli.slnx"))) dir = dir.Parent;
        return dir!.FullName;
    }
}
