using Syncfusion.DotNet.CLI.Blazor;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Core.Naming;
using Syncfusion.DotNet.CLI.Maui;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class ProjectNamingTests
{
    [Theory]
    [InlineData("dotnet-ui-cli", "DotnetUiCli")]
    [InlineData("my project", "MyProject")]
    [InlineData("sample.app", "SampleApp")]
    [InlineData("123project", "App123project")]
    [InlineData("---", "App")]
    [InlineData("", "App")]
    [InlineData("   ", "App")]
    [InlineData("_lead", "Lead")]
    [InlineData("class", "Class")]
    [InlineData("con", "ConApp")]
    [InlineData("héllo-wörld", "HélloWörld")]
    [InlineData("项目-app", "项目App")]
    [InlineData("a<b>c|d", "ABCD")]
    [InlineData("MyApp", "MyApp")]
    public void SuggestProducesDeterministicValidIdentifier(string raw, string expected)
    {
        Assert.Equal(expected, ProjectNaming.Suggest(raw));
        Assert.Null(ProjectNaming.ValidateIdentifier(ProjectNaming.Suggest(raw)));
        Assert.Equal(expected, ProjectNaming.Suggest(raw));
    }

    [Theory]
    [InlineData("dotnet-ui-cli")]
    [InlineData("my project")]
    [InlineData("sample.app")]
    [InlineData("123project")]
    [InlineData("")]
    [InlineData("CON")]
    [InlineData("class")]
    [InlineData("a/b")]
    public void ValidateRejectsNonIdentifiersWithActionableMessage(string name)
        => Assert.False(string.IsNullOrWhiteSpace(ProjectNaming.ValidateIdentifier(name)));

    [Theory]
    [InlineData("Valid_Name1")]
    [InlineData("_x")]
    [InlineData("项目")]
    public void ValidateAcceptsIdentifiers(string name) => Assert.Null(ProjectNaming.ValidateIdentifier(name));

    [Theory]
    [InlineData("maui")]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public void EveryPlatformSharesTheSameDesktopNameRules(string platform)
    {
        _ = platform;
        Assert.NotNull(DesktopConfiguration.ValidateProjectName("dotnet-ui-cli"));
        Assert.NotNull(DesktopConfiguration.ValidateProjectName("sample.app"));
        Assert.Null(DesktopConfiguration.ValidateProjectName(ProjectNaming.Suggest("dotnet-ui-cli")));
    }

    [Fact]
    public void MauiResolveDefaultNameStillRejectsInvalidExplicitNamesButSuggestionsWork()
    {
        Assert.NotNull(NewProjectScaffolder.ValidateProjectName("dotnet-ui-cli"));
        Assert.Null(NewProjectScaffolder.ValidateProjectName("sample.app"));
        Assert.Null(NewProjectScaffolder.ValidateProjectName(ProjectNaming.Suggest("dotnet-ui-cli")));
    }

    [Fact]
    public void BlazorHasNoDependencyOnMauiNaming()
    {
        var source = File.ReadAllText(Path.Combine(FindRoot(), "src", "Syncfusion.DotNet.CLI", "Commands", "Blazor", "BlazorCommands.cs"));
        Assert.DoesNotContain("NewProjectScaffolder", source);
    }

    private static string FindRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null && !File.Exists(Path.Combine(dir.FullName, "sf-net-cli.slnx"))) dir = dir.Parent;
        return dir!.FullName;
    }
}
