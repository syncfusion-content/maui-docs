using System.Text.Json;
using Syncfusion.DotNet.Cli.Blazor;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class ProjectNextCommandsTests
{
    [Theory]
    [InlineData(ProjectNextCommands.Host.Windows, "net10.0-windows10.0.19041.0", false)]
    [InlineData(ProjectNextCommands.Host.Windows, "net10.0-windows10.0.19041.0", true)]
    [InlineData(ProjectNextCommands.Host.MacOS, "net10.0-maccatalyst", false)]
    [InlineData(ProjectNextCommands.Host.MacOS, "net10.0-maccatalyst", true)]
    [InlineData(ProjectNextCommands.Host.Linux, "net10.0-android", false)]
    [InlineData(ProjectNextCommands.Host.Linux, "net10.0-android", true)]
    internal void MauiCommandsSelectHostTargetAndRespectBuildOutcome(ProjectNextCommands.Host host, string target, bool built)
    {
        using var temp = new Temp();
        File.WriteAllText(Path.Combine(temp.Root, "App.csproj"), "<Project><PropertyGroup><UseMaui>true</UseMaui><TargetFrameworks>net10.0-android;net10.0-ios;net10.0-maccatalyst;net10.0-windows10.0.19041.0</TargetFrameworks></PropertyGroup></Project>");
        var request = Maui(temp.Root, built);
        var commands = ProjectNextCommands.Maui(request, temp.Root, built, host);
        Assert.Equal(built ? 2 : 3, commands.Count);
        Assert.StartsWith("cd ", commands[0]);
        Assert.Contains("-t:Run", commands[^1]);
        Assert.Contains(target, commands[^1]);
        if (!built) Assert.Equal("dotnet build 'App.csproj' -f '" + target + "'", commands[1]);
    }

    [Fact]
    public void ExplicitMauiTargetAndDeclaredWindowsVersionArePreserved()
    {
        using var temp = new Temp();
        File.WriteAllText(Path.Combine(temp.Root, "App.csproj"), "<Project><PropertyGroup><UseMaui>true</UseMaui><TargetFrameworks>net9.0-android;net9.0-windows10.0.22621.0</TargetFrameworks></PropertyGroup></Project>");
        var request = Maui(temp.Root, true);
        Assert.Contains("net9.0-windows10.0.22621.0", ProjectNextCommands.Maui(request, temp.Root, true, ProjectNextCommands.Host.Windows)[^1]);
        request = request with { BuildFramework = " net9.0-android " };
        Assert.Contains("net9.0-android", ProjectNextCommands.Maui(request, temp.Root, true, ProjectNextCommands.Host.MacOS)[^1]);
    }

    [Fact]
    public void ExplicitIosRunUsesASimulatorRuntimeOnMac()
    {
        var request = Maui("parent", true) with { BuildFramework = "net10.0-ios" };
        var commands = ProjectNextCommands.Maui(request, "parent/App", true, ProjectNextCommands.Host.MacOS);
        Assert.Contains("-f 'net10.0-ios'", commands[^1]);
        Assert.Contains("-p:RuntimeIdentifier=iossimulator-", commands[^1]);
    }

    [Theory]
    [InlineData(Framework.WPF, "C#", "net10.0", false)]
    [InlineData(Framework.WPF, "VB", "net8.0", true)]
    [InlineData(Framework.WinForms, "C#", "net9.0", true)]
    [InlineData(Framework.WinForms, "VB", "net10.0", false)]
    [InlineData(Framework.WinUI, "C#", "net10.0", false)]
    [InlineData(Framework.WinUI, "C#", "net8.0", true)]
    [InlineData(Framework.WPF, "VB", "net462", false)]
    [InlineData(Framework.WPF, "C#", "net48", true)]
    [InlineData(Framework.WinForms, "C#", "net47", false)]
    [InlineData(Framework.WinForms, "VB", "net48", true)]
    public void DesktopCommandsUseCorrectProjectLanguageAndLegacyBuildTool(Framework platform, string language, string target, bool built)
    {
        var request = new DesktopNewRequest(platform, "App", "parent", language, target, "Native", [], false, built);
        var commands = ProjectNextCommands.Desktop(request, "parent with spaces/App");
        Assert.Equal(built ? 2 : 3, commands.Count);
        var project = "App" + (language == "VB" ? ".vbproj" : ".csproj");
        if (DesktopConfiguration.IsLegacy(target))
        {
            if (!built) Assert.StartsWith("msbuild '" + project + "' /restore", commands[1]);
            Assert.Equal("& '.\\bin\\Debug\\App.exe'", commands[^1]);
        }
        else
        {
            if (!built) Assert.Equal("dotnet build '" + project + "'", commands[1]);
            Assert.Equal("dotnet run --project '" + project + "' --no-build", commands[^1]);
        }
    }

    [Theory]
    [InlineData(BlazorAppType.WebApp, BlazorRenderMode.Server, false)]
    [InlineData(BlazorAppType.WebApp, BlazorRenderMode.Server, true)]
    [InlineData(BlazorAppType.WebApp, BlazorRenderMode.WebAssembly, false)]
    [InlineData(BlazorAppType.WebApp, BlazorRenderMode.WebAssembly, true)]
    [InlineData(BlazorAppType.WebApp, BlazorRenderMode.Auto, false)]
    [InlineData(BlazorAppType.WebApp, BlazorRenderMode.Auto, true)]
    [InlineData(BlazorAppType.WebAssemblyStandalone, BlazorRenderMode.WebAssembly, false)]
    [InlineData(BlazorAppType.WebAssemblyStandalone, BlazorRenderMode.WebAssembly, true)]
    public void BlazorCommandsRunTheHostOrStandaloneProject(BlazorAppType type, BlazorRenderMode render, bool built)
    {
        using var temp = new Temp();
        var nested = type == BlazorAppType.WebApp && render != BlazorRenderMode.Server;
        var project = nested ? "App/App.csproj" : "App.csproj";
        Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(temp.Root, project))!);
        File.WriteAllText(Path.Combine(temp.Root, project), "<Project />");
        var request = new BlazorNewRequest("App", temp.Root, type, "net10.0", render, BlazorInteractivity.PerPage,
            BlazorAuthentication.None, false, false, "fluent2", [], false, built);
        var commands = ProjectNextCommands.Blazor(request, temp.Root);
        Assert.Equal(built ? 2 : 3, commands.Count);
        Assert.Equal("dotnet run --project '" + project + "' --no-build", commands[^1]);
        Assert.DoesNotContain(".Client", string.Join("\n", commands));
    }

    [Fact]
    public void ShellQuotesPreserveSpacesApostrophesAndExpansionCharacters()
    {
        const string path = "parent with $dollar `ticks` and O'Brien/App";
        Assert.Equal("'parent with $dollar `ticks` and O''Brien/App'", ProjectNextCommands.Quote(path, ProjectNextCommands.Host.Windows));
        Assert.Equal("'parent with $dollar `ticks` and O'\"'\"'Brien/App'", ProjectNextCommands.Quote(path, ProjectNextCommands.Host.MacOS));
    }

    [Fact]
    public void OptionalJsonCommandsDoNotChangeOtherOperationPayloads()
    {
        var result = new DesktopResult(0, "done");
        Assert.DoesNotContain("NextCommands", JsonSerializer.Serialize(result));
        result = result with { NextCommands = ["cd 'App'", "dotnet run --no-build"] };
        Assert.Equal(2, JsonDocument.Parse(JsonSerializer.Serialize(result)).RootElement.GetProperty("NextCommands").GetArrayLength());
    }

    private static NewProjectRequest Maui(string parent, bool built)
        => new(Framework.Maui, "App", parent, "net10.0", "empty", MauiProjectType.App, false, built, false, false);

    private sealed class Temp : IDisposable
    {
        public string Root { get; } = Path.Combine(Path.GetTempPath(), "sf-next-commands-" + Guid.NewGuid().ToString("N"));
        public Temp() => Directory.CreateDirectory(Root);
        public void Dispose() => Directory.Delete(Root, true);
    }
}
