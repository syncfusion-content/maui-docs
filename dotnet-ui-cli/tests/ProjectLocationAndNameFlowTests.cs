using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Commands.Desktop;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Core.Naming;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>
/// Observable behaviour of the shared "Project location -> Project name" wizard steps on every platform.
/// HOME/USERPROFILE point at a temp directory so the real default location (~/Projects) is exercised without touching the user's files.
/// The working directory is a folder named <c>dotnet-ui-cli</c> throughout, to prove it is never used as a default.
/// </summary>
[Collection("Console output")]
public sealed class ProjectLocationAndNameFlowTests : IDisposable
{
    private readonly string _original = Directory.GetCurrentDirectory();
    private readonly string _base = Directory.CreateTempSubdirectory("sf flow").FullName;
    private readonly string? _home = Environment.GetEnvironmentVariable("HOME");
    private readonly string? _profile = Environment.GetEnvironmentVariable("USERPROFILE");
    private readonly string _cwd;
    private readonly string _defaultLocation;

    public ProjectLocationAndNameFlowTests()
    {
        var home = Directory.CreateDirectory(Path.Combine(_base, "home")).FullName;
        Environment.SetEnvironmentVariable("HOME", home);
        Environment.SetEnvironmentVariable("USERPROFILE", home);
        _cwd = Directory.CreateDirectory(Path.Combine(_base, "dotnet-ui-cli")).FullName;
        Directory.SetCurrentDirectory(_cwd);
        _defaultLocation = ProjectDefaults.Location();
    }

    public void Dispose()
    {
        Directory.SetCurrentDirectory(_original);
        Environment.SetEnvironmentVariable("HOME", _home);
        Environment.SetEnvironmentVariable("USERPROFILE", _profile);
        Directory.Delete(_base, true);
    }

    public static TheoryData<Framework, string> Platforms => new()
    {
        { Framework.Maui, "SyncfusionMauiApp" }, { Framework.WPF, "SyncfusionWpfApp" }, { Framework.WinForms, "SyncfusionWinFormsApp" },
        { Framework.WinUI, "SyncfusionWinUIApp" }, { Framework.Blazor, "SyncfusionBlazorApp" },
    };

    private static ConsoleKeyInfo Key(ConsoleKey key) => new(key == ConsoleKey.Enter ? '\r' : '\0', key, false, false, false);
    private static IEnumerable<ConsoleKeyInfo> Line(string text)
        => text.Select(c => new ConsoleKeyInfo(c, ConsoleKey.A, false, false, false)).Append(Key(ConsoleKey.Enter));

    private static (InteractiveConsoleInput Input, StringWriter Output) Wizard(IEnumerable<ConsoleKeyInfo> keys)
    {
        var writer = new StringWriter();
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Ansi = Spectre.Console.AnsiSupport.Yes,
            Interactive = Spectre.Console.InteractionSupport.Yes,
            Out = new Spectre.Console.AnsiConsoleOutput(writer),
        });
        console.Profile.Width = 160;
        var queue = new Queue<ConsoleKeyInfo>(keys);
        return (new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(queue.Dequeue()), true), writer);
    }

    private static (string Parent, string Name) Run(Framework platform, InteractiveConsoleInput input, string? suppliedParent = null)
        => NewCommand.AskProjectLocationAndName(platform, suppliedParent, new ConsolePresenter(true), input,
            additionalNameValidation: platform == Framework.Maui ? null : DesktopConfiguration.ValidateProjectName);

    [Theory]
    [MemberData(nameof(Platforms))]
    public void FirstRunDefaultsAreHomeProjectsAndPlatformName(Framework platform, string expectedName)
    {
        var (input, output) = Wizard([Key(ConsoleKey.Enter), Key(ConsoleKey.Enter)]);

        var (parent, name) = Run(platform, input);

        Assert.Equal(Path.Combine(Environment.GetEnvironmentVariable("HOME")!, "Projects"), parent);
        Assert.NotEqual(_cwd, parent);
        Assert.Equal(expectedName, name);
        var text = output.ToString();
        Assert.True(text.IndexOf("Project location:", StringComparison.Ordinal) < text.IndexOf("Project name:", StringComparison.Ordinal));
        Assert.Contains($"[{parent}]", text);
        Assert.Contains($"[{expectedName}]", text);
        Assert.Empty(Directory.GetFileSystemEntries(_cwd));
        Assert.Empty(Directory.GetFileSystemEntries(parent));
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void DefaultNameDoesNotDependOnLocationFolder(Framework platform, string expectedName)
    {
        foreach (var folder in new[] { "dotnet-ui-cli", "my project", "sample.app", "123project", "项目", "---" })
        {
            var location = Directory.CreateDirectory(Path.Combine(_base, folder)).FullName;
            var (input, _) = Wizard([.. Line(location), Key(ConsoleKey.Enter)]);
            Assert.Equal((location, expectedName), Run(platform, input));
        }
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void ExistingDefaultNameGetsIncrementingSuffix(Framework platform, string expectedName)
    {
        Directory.CreateDirectory(Path.Combine(_defaultLocation, expectedName));
        var (first, _) = Wizard([Key(ConsoleKey.Enter), Key(ConsoleKey.Enter)]);
        Assert.Equal(expectedName + "1", Run(platform, first).Name);

        File.WriteAllText(Path.Combine(_defaultLocation, expectedName + "1"), "file");
        var (second, _) = Wizard([Key(ConsoleKey.Enter), Key(ConsoleKey.Enter)]);
        Assert.Equal(expectedName + "2", Run(platform, second).Name);
        Assert.Equal("file", File.ReadAllText(Path.Combine(_defaultLocation, expectedName + "1")));
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void WorkingDirectoryNamedDotnetUiCliNoLongerThrowsOrLeaksIntoDefaults(Framework platform, string expectedName)
    {
        Assert.Equal("dotnet-ui-cli", Path.GetFileName(Directory.GetCurrentDirectory()));
        var (input, _) = Wizard([Key(ConsoleKey.Enter), Key(ConsoleKey.Enter)]);
        var (parent, name) = Run(platform, input);
        Assert.Equal(expectedName, name);
        Assert.DoesNotContain("dotnet-ui-cli", parent);
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void InvalidNameKeepsUserInPromptShowsErrorThenAcceptsCorrection(Framework platform, string _)
    {
        var (input, output) = Wizard([Key(ConsoleKey.Enter), .. Line("bad-name!"), .. Line("Good_Name")]);

        using var capture = new ConsoleCapture();
        var (parent, name) = Run(platform, input);

        Assert.Equal((_defaultLocation, "Good_Name"), (parent, name));
        Assert.Contains("invalid", capture.Error + capture.Out + output, StringComparison.OrdinalIgnoreCase);
        Assert.Equal(1, CountOccurrences(output.ToString(), "Project location:  " + _defaultLocation));
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void ExistingFolderCollisionReprompts_AndNothingOnDiskChanges(Framework platform, string _)
    {
        Directory.CreateDirectory(Path.Combine(_defaultLocation, "Taken"));
        File.WriteAllText(Path.Combine(_defaultLocation, "TakenFile"), "keep");
        var (input, output) = Wizard([Key(ConsoleKey.Enter), .. Line("Taken"), .. Line("TakenFile"), .. Line("Fresh")]);

        Assert.Equal((_defaultLocation, "Fresh"), Run(platform, input));

        Assert.Contains("already exists", output.ToString());
        Assert.Equal("keep", File.ReadAllText(Path.Combine(_defaultLocation, "TakenFile")));
        Assert.False(Directory.Exists(Path.Combine(_defaultLocation, "Fresh")));
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void CustomLocationWithSpacesAndCustomNameAreUsedAsTyped(Framework platform, string _)
    {
        var custom = Path.Combine(_base, "my custom dir");
        var (input, _) = Wizard([.. Line(custom), .. Line("My_App")]);

        Assert.Equal((custom, "My_App"), Run(platform, input));
        Assert.Empty(Directory.GetFileSystemEntries(custom));
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void SuppliedPathSkipsLocationPromptButStillAsksForNameWithPlatformDefault(Framework platform, string expectedName)
    {
        var supplied = Directory.CreateDirectory(Path.Combine(_base, "supplied dir")).FullName;
        var (input, output) = Wizard([Key(ConsoleKey.Enter)]);

        // One queued Enter: had the location been prompted it would consume it and the name prompt would run out of keys.
        Assert.Equal((supplied, expectedName), Run(platform, input, supplied));
        Assert.Contains($"[{expectedName}]", output.ToString());
    }

    [Theory]
    [MemberData(nameof(Platforms))]
    public void EscapeAtNameCancelsWithoutCreatingAnything(Framework platform, string _)
    {
        var (input, _) = Wizard([Key(ConsoleKey.Enter), Key(ConsoleKey.Escape)]);

        Assert.Throws<InteractivePromptCancelledException>(() => Run(platform, input));
        Assert.Empty(Directory.GetFileSystemEntries(_cwd));
        Assert.Empty(Directory.GetFileSystemEntries(_defaultLocation));
    }

    [Theory]
    [InlineData(true, @"C:\Users\alice", @"C:\Users\alice\source\repos")]
    [InlineData(false, "/Users/alice", "/Users/alice/Projects")]
    [InlineData(false, "/home/alice", "/home/alice/Projects")]
    public void DefaultLocationPerOperatingSystem(bool windows, string home, string expected)
    {
        var actual = ProjectDefaults.Location(home, windows);
        Assert.Equal(expected, windows ? actual.Replace('/', '\\') : actual.Replace('\\', '/'));
    }

    [Fact]
    public void DefaultLocationUsesTheLiveUserHomeNotAHardcodedOne()
        => Assert.StartsWith(Environment.GetEnvironmentVariable("HOME")!, ProjectDefaults.Location());

    [Fact]
    public void DefaultNamesAreExactlyThePlatformNames()
    {
        Assert.Equal("SyncfusionWpfApp", ProjectDefaults.BaseName(Framework.WPF));
        Assert.Equal("SyncfusionWinUIApp", ProjectDefaults.BaseName(Framework.WinUI));
        Assert.Equal("SyncfusionWinFormsApp", ProjectDefaults.BaseName(Framework.WinForms));
        Assert.Equal("SyncfusionMauiApp", ProjectDefaults.BaseName(Framework.Maui));
        Assert.Equal("SyncfusionBlazorApp", ProjectDefaults.BaseName(Framework.Blazor));
    }

    private static int CountOccurrences(string text, string value)
    {
        var count = 0;
        for (var i = text.IndexOf(value, StringComparison.Ordinal); i >= 0; i = text.IndexOf(value, i + value.Length, StringComparison.Ordinal)) count++;
        return count;
    }
}

[Collection("Console output")]
public sealed class BlazorLocationAndNameResolutionTests
{
    [Fact]
    public void NonInteractiveWithoutPathOrNameUsesSharedDefaults()
    {
        var root = Directory.CreateTempSubdirectory("blazor-resolve").FullName;
        try
        {
            var (location, name) = Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.ResolveLocationAndName(false, root, null, _ => throw new InvalidOperationException());
            Assert.Equal((root, "SyncfusionBlazorApp"), (location, name));
            Directory.CreateDirectory(Path.Combine(root, "SyncfusionBlazorApp"));
            Assert.Equal("SyncfusionBlazorApp1", Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.ResolveLocationAndName(false, root, null, _ => throw new InvalidOperationException()).Name);
        }
        finally { Directory.Delete(root, true); }
    }

    [Fact]
    public void ExplicitPathAndNameArePreserved()
        => Assert.Equal(("/some path/x", "My_App"), Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.ResolveLocationAndName(false, "/some path/x", "My_App", _ => throw new InvalidOperationException()));

    [Fact]
    public void NoPathUsesHomeProjects()
        => Assert.Equal(ProjectDefaults.Location(), Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.ResolveLocationAndName(false, null, "A", _ => throw new InvalidOperationException()).Location);

    [Fact]
    public void InteractiveDelegatesToTheWizardAndPassesTheSuppliedPath()
    {
        string? seen = "unset";
        var result = Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.ResolveLocationAndName(true, "/p", null, supplied => { seen = supplied; return ("/p", "Chosen"); });
        Assert.Equal(("/p", "Chosen"), result);
        Assert.Equal("/p", seen);
    }
}

[Collection("Console output")]
public sealed class BlazorNewCommandDefaultsTests
{
    [Fact]
    public async Task DryRunWithoutPathOrNameResolvesHomeProjectsAndSyncfusionBlazorApp()
    {
        var home = Directory.CreateTempSubdirectory("sf home").FullName;
        var oldHome = Environment.GetEnvironmentVariable("HOME");
        Environment.SetEnvironmentVariable("HOME", home);
        try
        {
            using var capture = new ConsoleCapture();
            var parse = NewCommand.Create().Parse(["blazor", "--dry-run", "--no-interactive", "--json"]);
            var code = await Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.NewAsync(parse, new GlobalOptions { NoInteractive = true, Json = true }, new ConsolePresenter(true), default, showAction: false);
            var output = capture.Out + capture.Error;
            Assert.True(code == 0, output);
            using var json = System.Text.Json.JsonDocument.Parse(capture.Out);
            Assert.Equal(Path.Combine(home, "Projects", "SyncfusionBlazorApp"), json.RootElement.GetProperty("projectPath").GetString());
            Assert.False(Directory.Exists(Path.Combine(home, "Projects")), "dry run must not create anything");
        }
        finally
        {
            Environment.SetEnvironmentVariable("HOME", oldHome);
            Directory.Delete(home, true);
        }
    }
}
