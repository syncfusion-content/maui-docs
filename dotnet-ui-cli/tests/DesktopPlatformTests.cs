using System.Text.Json;
using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Commands.Desktop;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Hosting;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class DesktopPlatformTests
{
    public static IEnumerable<object[]> WizardSetups()
    {
        foreach (var platform in new[] { "wpf", "winui", "winforms" })
        foreach (var selection in new[] { "empty", "cartesian-chart", "datagrid", "both", "cancel" })
            yield return [platform, selection];
    }

    [Theory]
    [MemberData(nameof(WizardSetups))]
    public void EachDesktopPlatformSupportsSetupAndConditionalControls(string platform, string selection)
    {
        using var writer = new StringWriter();
        var keys = new List<ConsoleKeyInfo>();
        if (selection == "cancel") keys.Add(Key(ConsoleKey.Escape));
        else if (selection == "empty") keys.Add(Key(ConsoleKey.Enter));
        else
        {
            keys.AddRange([Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)]);
            // The picker lists controls in display order, so navigation distance is platform-dependent.
            var controls = DesktopProviders.Find(platform)!.Controls.Select(item => item.Alias).ToArray();
            var cartesianChart = Array.IndexOf(controls, "cartesian-chart");
            var datagrid = Array.IndexOf(controls, "datagrid");
            var target = selection == "datagrid" ? datagrid : cartesianChart;
            keys.AddRange(Enumerable.Repeat(Key(ConsoleKey.DownArrow), target));
            keys.Add(Key(ConsoleKey.Spacebar));
            if (selection == "both") keys.AddRange(Enumerable.Repeat(Key(ConsoleKey.DownArrow), datagrid - cartesianChart).Append(Key(ConsoleKey.Spacebar)));
            keys.Add(Key(ConsoleKey.Enter));
        }
        var input = WizardInput(writer, keys);
        if (selection == "cancel")
            Assert.Throws<Syncfusion.DotNet.CLI.Wizard.InteractivePromptCancelledException>(() => DesktopCommands.AskSetupAndControls(input, DesktopProviders.Find(platform)!));
        else
        {
            var controls = DesktopCommands.AskSetupAndControls(input, DesktopProviders.Find(platform)!);
            Assert.Equal(selection switch { "empty" => [], "cartesian-chart" => ["cartesian-chart"], "datagrid" => ["datagrid"], _ => new[] { "cartesian-chart", "datagrid" } }, controls);
            Assert.Equal(selection != "empty", writer.ToString().Contains("Select Syncfusion controls:"));
        }
    }

    [Theory]
    [InlineData(0, "cartesian-chart")]
    [InlineData(1, "circular-chart")]
    [InlineData(2, "datagrid")]
    [InlineData(3, "docking-manager")]
    [InlineData(4, "ribbon")]
    [InlineData(5, "treegrid")]
    [InlineData(0, "chart")]
    [InlineData(1, "datagrid")]
    [InlineData(2, "docking-manager")]
    [InlineData(3, "kanban")]
    [InlineData(4, "ribbon")]
    [InlineData(5, "scheduler")]
    [InlineData(6, "treegrid")]
    public void WinUIControlPickerStartsEmptyAndSelectsOnlyTheRequestedControl(int downs, string expected)
    {
        using var writer = new StringWriter();
        var keys = new List<ConsoleKeyInfo> { Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter) };
        keys.AddRange(Enumerable.Repeat(Key(ConsoleKey.DownArrow), downs));
        keys.AddRange([Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]);
        var controls = DesktopCommands.AskSetupAndControls(WizardInput(writer, keys), DesktopProviders.Find("winui")!);
        Assert.Equal(new[] { expected }, controls);
        Assert.Contains("Selected: 0", writer.ToString());
    }

    [Theory]
    [InlineData("wpf", false)]
    [InlineData("wpf", true)]
    [InlineData("winui", false)]
    [InlineData("winui", true)]
    [InlineData("winforms", false)]
    [InlineData("winforms", true)]
    public void EachDesktopPlatformReusesUniqueNamesAndCollisionReentry(string platform, bool file)
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var suggested = Syncfusion.DotNet.CLI.Core.Naming.ProjectDefaults.BaseName(provider.Platform);
        Directory.CreateDirectory(Path.Combine(directory.Root, suggested));
        File.WriteAllText(Path.Combine(directory.Root, suggested + "1"), "keep");
        using var writer = new StringWriter();
        var keys = Type(directory.Root).Concat(new[] { Key(ConsoleKey.Enter) });
        var selected = NewCommand.AskProjectLocationAndName(provider.Platform, null, new Syncfusion.DotNet.CLI.Presentation.ConsolePresenter(true), WizardInput(writer, keys), additionalNameValidation: DesktopConfiguration.ValidateProjectName);
        Assert.Equal(suggested + "2", selected.Name);
        Assert.True(writer.ToString().IndexOf("Project location:") < writer.ToString().IndexOf("Project name:"));
        writer.GetStringBuilder().Clear();
        selected = NewCommand.AskProjectLocationAndName(provider.Platform, directory.Root, new Syncfusion.DotNet.CLI.Presentation.ConsolePresenter(true), WizardInput(writer, Type(file ? suggested + "1" : suggested).Concat(Type("Fresh"))), additionalNameValidation: DesktopConfiguration.ValidateProjectName);
        Assert.Equal("Fresh", selected.Name);
        Assert.DoesNotContain("Project name:      " + (file ? suggested + "1" : suggested) + Environment.NewLine, writer.ToString());
        Assert.EndsWith("Project name:      Fresh" + Environment.NewLine, writer.ToString());
        Assert.False(Directory.Exists(Path.Combine(directory.Root, "Fresh")));
        Assert.Equal("keep", File.ReadAllText(Path.Combine(directory.Root, suggested + "1")));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winui")]
    [InlineData("winforms")]
    public void DesktopReviewUsesWizardOrderAndOmitsEmptyControls(string platform)
    {
        var provider = DesktopProviders.Find(platform)!;
        var request = new DesktopNewRequest(provider.Platform, "App", Path.GetTempPath(), provider.Languages[0], provider.TargetFrameworks[0], provider.DefaultTheme, [], false, false);
        var rows = DesktopCommands.Review(provider, request);
        Assert.Equal(platform == "wpf"
            ? ["Action:", "Platform:", "Language:", "Target framework:", "Project location:", "Project name:", "Setup:", "Post-create:"]
            : new[] { "Action:", "Platform:", "Language:", "Target framework:", "Theme:", "Project location:", "Project name:", "Setup:", "Post-create:" }, rows.Select(row => row.Label));
        Assert.Equal("Empty project", rows.Single(row => row.Label == "Setup:").Value);
        rows = DesktopCommands.Review(provider, request with { Controls = [platform == "winui" ? "cartesian-chart" : "chart", "datagrid"], Restore = true, Build = true });
        var controlIndex = platform == "wpf" ? rows.Count - 3 : rows.Count - 2;
        Assert.Equal("Controls:", rows[controlIndex].Label);
        Assert.Equal(platform == "winui" ? "CartesianChart, DataGrid" : "Chart, DataGrid", rows[controlIndex].Value);
        if (platform == "wpf") Assert.Equal("Theme:", rows[^2].Label);
        Assert.Equal("Build project", rows[^1].Value);
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
    private static IEnumerable<ConsoleKeyInfo> Type(string text)
        => text.Select(character => new ConsoleKeyInfo(character, ConsoleKey.A, false, false, false)).Append(Key(ConsoleKey.Enter));
    private static Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput WizardInput(StringWriter writer, IEnumerable<ConsoleKeyInfo> keys)
    {
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings { Ansi = Spectre.Console.AnsiSupport.Yes, Interactive = Spectre.Console.InteractionSupport.Yes, Out = new Spectre.Console.AnsiConsoleOutput(writer) });
        console.Profile.Width = 160;
        var queue = new Queue<ConsoleKeyInfo>(keys);
        return new Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(queue.Dequeue()), true);
    }

    [Theory]
    [InlineData("generate", false, false)]
    [InlineData("generate", true, false)]
    [InlineData("build", false, true)]
    [InlineData(null, false, true)]
    [InlineData("build", true, false)]
    public void PostCreationRestoreMatchesSelectedAction(string? post, bool noRestore, bool expected)
        => Assert.Equal(expected, DesktopCommands.ShouldRestore(post, noRestore));

    [Theory]
    [InlineData(0, "maui")]
    [InlineData(1, "blazor")]
    [InlineData(2, "winforms")]
    [InlineData(3, "winui")]
    [InlineData(4, "wpf")]
    public void PlatformPickerUsesSharedKeyboardSelection(int downs, string expected)
    {
        using var writer = new StringWriter();
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Out = new Spectre.Console.AnsiConsoleOutput(writer),
            Ansi = Spectre.Console.AnsiSupport.Yes,
            Interactive = Spectre.Console.InteractionSupport.Yes,
        });
        var keys = new Queue<ConsoleKeyInfo>();
        for (var i = 0; i < downs; i++) keys.Enqueue(new ConsoleKeyInfo('\0', ConsoleKey.DownArrow, false, false, false));
        keys.Enqueue(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));
        var input = new Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput(console,
            _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
        Assert.Equal(expected, Syncfusion.DotNet.CLI.Wizard.InteractivePrompt.AskFramework(input, true));
    }

    [Fact]
    public void DesktopEmptySetupSkipsTheControlPicker()
    {
        using var writer = new StringWriter();
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Out = new Spectre.Console.AnsiConsoleOutput(writer),
            Ansi = Spectre.Console.AnsiSupport.Yes,
            Interactive = Spectre.Console.InteractionSupport.Yes,
        });
        var input = new Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput(console,
            _ => Task.FromResult<ConsoleKeyInfo?>(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false)), true);
        Assert.Empty(DesktopCommands.AskSetupAndControls(input, DesktopProviders.Find("wpf")!));
        Assert.Contains("Setup: Empty project", writer.ToString());
        Assert.DoesNotContain("Select Syncfusion controls", writer.ToString());
    }

    [Theory]
    [InlineData("C#", false)]
    [InlineData("VB", false)]
    [InlineData("C#", true)]
    [InlineData("VB", true)]
    public void WinFormsWelcomeKeepsEmptyStateSampleNavigationAndAllFooterLinks(string language, bool samples)
    {
        var provider = DesktopProviders.Find("winforms")!;
        var ids = samples ? provider.Controls.Select(control => control.Alias).ToArray() : [];
        var request = new DesktopNewRequest(provider.Platform, "WelcomeCheck", Path.GetTempPath(), language,
            "net10.0", provider.DefaultTheme, ids, false, false);
        var files = provider.Generate(request);
        var source = files["Welcome/WelcomeView." + (language == "VB" ? "vb" : "cs")];
        Assert.DoesNotContain("__", source);
        Assert.Equal(samples, source.Contains("Select a control to explore its sample.", StringComparison.Ordinal));
        Assert.Equal(!samples, source.Contains("You’re all set!", StringComparison.Ordinal));
        foreach (var id in ids) Assert.Contains("FindSample(tabs, \"" + id + "\")", source);
        foreach (var (title, url) in WelcomeContent.FooterLinks)
        {
            Assert.Single(System.Text.RegularExpressions.Regex.Matches(source, System.Text.RegularExpressions.Regex.Escape(url)));
            Assert.Contains(title, source);
        }
    }

    public static IEnumerable<object[]> Configurations()
    {
        foreach (var provider in DesktopProviders.All)
        foreach (var language in provider.Languages)
        foreach (var framework in provider.TargetFrameworks)
        foreach (var theme in provider.Themes)
        {
            var chartControl = provider.Platform == Framework.WinUI ? "cartesian-chart" : "chart";
            foreach (var controls in new[] { Array.Empty<string>(), new[] { chartControl }, new[] { "datagrid" }, new[] { chartControl, "datagrid" } })
                yield return [Frameworks.Name(provider.Platform), language, framework, theme.Name, controls];
        }
    }

    [Theory]
    [MemberData(nameof(Configurations))]
    public void EveryAdvertisedConfigurationGeneratesNativeSourcesAndCorrectProjectFormat(string platform,
        string language, string framework, string theme, string[] controls)
    {
        var provider = DesktopProviders.Find(platform)!;
        var request = new DesktopNewRequest(provider.Platform, "SampleApp", Path.GetTempPath(), language, framework, theme, controls, false, false);
        Assert.Null(DesktopConfiguration.Validate(provider, request));
        var files = provider.Generate(request);
        var project = XDocument.Parse(files["SampleApp" + DesktopConfiguration.ProjectExtension(language)]);
        Assert.Equal(DesktopConfiguration.IsLegacy(framework), project.Root!.Attribute("Sdk") is null);
        Assert.Equal(provider.Platform, DesktopProjectFiles.Detect(project));
        foreach (var file in files.Where(file => file.Key.EndsWith(".xaml") || file.Key.EndsWith(".manifest"))) _ = XDocument.Parse(file.Value);
        Assert.DoesNotContain(files.Values, source => source.Contains("MauiProgram") || source.Contains("Syncfusion.Maui"));
        var welcomePath = provider.Platform == Framework.WinForms ? "Welcome/WelcomeView." : "Welcome/WelcomeView.xaml.";
        Assert.Contains(welcomePath + (language == "VB" ? "vb" : "cs"), files.Keys);
        if (provider.Platform != Framework.WinForms)
        {
            Assert.Contains("Welcome/WelcomeView.xaml", files.Keys);
            Assert.Contains("<welcome:WelcomeView", files["MainWindow.xaml"]);
            Assert.DoesNotContain("Copyright", files["MainWindow.xaml"]);
        }
        var generated = string.Join("\n", files.Values);
        Assert.DoesNotContain("__ROOT_NAMESPACE__", generated);
        if (provider.Platform == Framework.WPF && language == "VB")
            Assert.Contains("OpenSampleAction.Invoke", files["Welcome/WelcomeView.xaml.vb"]);
        Assert.Contains("Welcome to Your New", generated);
        Assert.Contains("Your application is running successfully.", generated);
        Assert.Contains("Your control samples", generated);
        Assert.Contains("Build something great", generated);
        Assert.Contains(WelcomeContent.Copyright, generated);
        foreach (var (title, url) in WelcomeContent.FooterLinks)
        {
            Assert.Contains(title, generated);
            Assert.Contains(url, generated);
        }
        Assert.DoesNotContain("https://www.syncfusion.com/support", generated);
        if (controls.Length == 0) Assert.Contains("You’re all set!", generated);
        if (provider.Platform == Framework.WinUI)
            Assert.Contains("Grid.SetRow((Microsoft.UI.Xaml.FrameworkElement)WelcomeResources.Children[index]", generated);
        Assert.Equal(controls.Length, provider.Controls.Count(control => controls.Contains(control.Alias)));
        Assert.Equal(provider.RequiredPackages(request).Count, provider.RequiredPackages(request).Distinct().Count());
        if (provider.Platform == Framework.WinUI) Assert.DoesNotContain(provider.RequiredPackages(request), id => id.EndsWith(".WPF") || id.EndsWith(".WinForms"));
    }

    [Theory]
    [InlineData("C#", "net48")]
    [InlineData("VB", "net48")]
    [InlineData("C#", "net47")]
    [InlineData("VB", "net47")]
    [InlineData("C#", "net462")]
    [InlineData("VB", "net462")]
    public void LegacyWinFormsNavigationDrawerReferencesSystemXml(string language, string framework)
    {
        var provider = DesktopProviders.Find("winforms")!;
        var request = new DesktopNewRequest(provider.Platform, "SampleApp", Path.GetTempPath(), language,
            framework, provider.DefaultTheme, ["navigation-drawer"], false, false);
        var files = provider.Generate(request);
        var project = XDocument.Parse(files["SampleApp" + DesktopConfiguration.ProjectExtension(language)]);
        var ns = project.Root!.Name.Namespace;

        Assert.Contains("NavigationDrawer/NavigationDrawerPage." + (language == "VB" ? "vb" : "cs"), files.Keys);
        Assert.Single(project.Root.Elements(ns + "ItemGroup").Elements(ns + "Reference"),
            reference => (string?)reference.Attribute("Include") == "System.Xml");
    }

    [Fact]
    public void VbWPFUsesApplicationDefinitionAndLegacyTypeInference()
    {
        var provider = DesktopProviders.Find("wpf")!;
        var request = new DesktopNewRequest(provider.Platform, "SampleApp", Path.GetTempPath(), "VB", "net48", "Windows11Light", [], false, false);
        var files = provider.Generate(request);
        Assert.Contains("Application.xaml", files.Keys);
        Assert.DoesNotContain("App.xaml", files.Keys);
        var project = XDocument.Parse(files["SampleApp.vbproj"]);
        Assert.Contains(project.Descendants(), element => element.Name.LocalName == "ApplicationDefinition" && (string?)element.Attribute("Include") == "Application.xaml");
        Assert.Equal("On", project.Descendants().Single(element => element.Name.LocalName == "OptionInfer").Value);
    }

    [Fact]
    public void InvalidLanguageFrameworkThemeAndControlAreRejectedWithoutSubstitution()
    {
        var provider = DesktopProviders.Find("winui")!;
        var valid = new DesktopNewRequest(provider.Platform, "SampleApp", Path.GetTempPath(), "C#", "net10.0", "Native", [], false, false);
        Assert.NotNull(DesktopConfiguration.Validate(provider, valid with { Language = "VB" }));
        Assert.NotNull(DesktopConfiguration.Validate(provider, valid with { TargetFramework = "net462" }));
        Assert.NotNull(DesktopConfiguration.Validate(provider, valid with { Theme = "Office2019" }));
        Assert.NotNull(DesktopConfiguration.Validate(provider, valid with { Controls = ["invalid-control"] }));
        Assert.Equal("Windows", DesktopCommands.ResolveTheme(DesktopProviders.Find("wpf")!, "Windows"));
    }

    [Theory]
    [InlineData("wpf", "C#")]
    [InlineData("wpf", "VB")]
    [InlineData("winforms", "C#")]
    [InlineData("winforms", "VB")]
    [InlineData("winui", "C#")]
    public async Task CreateAndDetectDesktopProjectTracksOwnership(string platform, string language)
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var chartControl = platform == "winui" ? "cartesian-chart" : "chart";
        var request = new DesktopNewRequest(provider.Platform, "SampleApp", directory.Root, language, "net10.0", provider.DefaultTheme, [chartControl, "datagrid"], false, false);
        var result = await new DesktopProjectService(new FakeTools()).CreateAsync(provider, request);
        Assert.True(result.Success, string.Join('\n', result.Errors ?? []));
        var project = Path.Combine(result.ProjectPath!, "SampleApp" + DesktopConfiguration.ProjectExtension(language));
        Assert.Equal(project, DesktopProjectFiles.ResolveProject(project, provider.Platform));
        var manifest = JsonSerializer.Deserialize<DesktopManifest>(File.ReadAllText(Path.Combine(result.ProjectPath!, DesktopProjectService.ManifestName)))!;
        Assert.Equal(2, manifest.Controls.Count);
        Assert.All(manifest.OriginalHashes, file => Assert.Equal(file.Value, FileRollback.ComputeHash(Path.Combine(result.ProjectPath!, file.Key))));
        var again = await new DesktopProjectService(new FakeTools()).CreateAsync(provider, request);
        Assert.False(again.Success);
        Assert.Contains("already exists", again.Message);
    }

    [Fact]
    public async Task FailedRestoreAndCancellationRemoveOnlyTheOwnedProject()
    {
        using var directory = new Temp();
        File.WriteAllText(Path.Combine(directory.Root, "customer.txt"), "keep");
        var provider = DesktopProviders.Find("winforms")!;
        var request = new DesktopNewRequest(provider.Platform, "RollbackApp", directory.Root, "C#", "net10.0", provider.DefaultTheme, ["chart"]);
        var result = await new DesktopProjectService(new FakeTools { FailRestore = true }).CreateAsync(provider, request);
        Assert.False(result.Success);
        Assert.True(result.RolledBack);
        Assert.False(Directory.Exists(Path.Combine(directory.Root, "RollbackApp")));
        Assert.Equal("keep", File.ReadAllText(Path.Combine(directory.Root, "customer.txt")));
        using var cancellation = new CancellationTokenSource(); cancellation.Cancel();
        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => new DesktopProjectService(new FakeTools()).CreateAsync(provider, request, cancellationToken: cancellation.Token));
        Assert.False(Directory.Exists(Path.Combine(directory.Root, "RollbackApp")));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public async Task GenerateOnlyWritesControlsWithoutRestoreOrBuild(string platform)
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var tools = new FakeTools();
        var chartControl = platform == "winui" ? "cartesian-chart" : "chart";
        var request = new DesktopNewRequest(provider.Platform, "GeneratedApp", directory.Root, provider.Languages[0], "net10.0", provider.DefaultTheme, [chartControl], Restore: false, Build: false);
        var result = await new DesktopProjectService(tools).CreateAsync(provider, request);
        Assert.True(result.Success);
        Assert.DoesNotContain("restore", tools.Commands);
        Assert.DoesNotContain("build", tools.Commands);
        Assert.True(File.Exists(Path.Combine(result.ProjectPath!, "GeneratedApp.csproj")));
    }

    [Fact]
    public async Task WinUiFileGenerationDoesNotRequireAnInstalledSdk()
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find("winui")!;
        var request = new DesktopNewRequest(provider.Platform, "FilesOnly", directory.Root, "C#", "net10.0", provider.DefaultTheme, [], Restore: false, Build: false);
        var result = await new DesktopProjectService(new FakeTools { SdkOutput = "" }).CreateAsync(provider, request);
        Assert.True(result.Success);
        Assert.True(File.Exists(Path.Combine(result.ProjectPath!, "FilesOnly.csproj")));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task DesktopProgressCompletesOnlySuccessfulOperations(bool failRestore)
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find("wpf")!;
        var stages = new StageTracker();
        var request = new DesktopNewRequest(provider.Platform, "ProgressApp", directory.Root, "C#", "net10.0", provider.DefaultTheme, []);
        var result = await new DesktopProjectService(new FakeTools { FailRestore = failRestore }).CreateAsync(provider, request, stages);
        Assert.Equal(!failRestore, result.Success);
        Assert.Contains("Creating project", stages.Done);
        if (failRestore)
        {
            Assert.Contains("Restoring packages", stages.Failures);
            Assert.DoesNotContain("Restoring packages", stages.Done);
            Assert.DoesNotContain("Building project", stages.Done);
        }
        else Assert.Contains("Building project", stages.Done);
    }

    private sealed class StageTracker : IOperationStageProgress
    {
        public List<string> Done { get; } = [];
        public List<string> Failures { get; } = [];
        public void Completed(string label) => Done.Add(label);
        public void Failed(string label) => Failures.Add(label);
        public void Plan(IEnumerable<string> labels) { }
        public void Started(string label) { }
        public void Advanced(string label, int completed, int total) { }
        public void Report(string label) { }
    }

    [Fact]
    public async Task MissingSdkAndFailedBuildDoNotLeaveAProjectBehind()
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find("winforms")!;
        var request = new DesktopNewRequest(provider.Platform, "FailureApp", directory.Root, "C#", "net10.0", provider.DefaultTheme, ["chart"]);
        var missing = await new DesktopProjectService(new FakeTools { SdkOutput = "8.0.100 [sdk]" }).CreateAsync(provider, request);
        Assert.False(missing.Success);
        Assert.Contains("SDK 10", missing.Message);
        Assert.False(Directory.Exists(Path.Combine(directory.Root, "FailureApp")));
        var failed = await new DesktopProjectService(new FakeTools { FailBuild = true }).CreateAsync(provider, request);
        Assert.False(failed.Success);
        Assert.True(failed.RolledBack);
        Assert.Contains(failed.Errors!, error => error.Contains("building project"));
        Assert.False(Directory.Exists(Path.Combine(directory.Root, "FailureApp")));
    }

    [Fact]
    public async Task CentralPackageManagementKeepsExistingVersionsAndRollsBackSharedFile()
    {
        using var directory = new Temp();
        var central = Path.Combine(directory.Root, "Directory.Packages.props");
        const string original = "<Project><PropertyGroup><ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally></PropertyGroup><ItemGroup><PackageVersion Include=\"Syncfusion.Chart.Windows\" Version=\"35.1.40\" /></ItemGroup></Project>";
        File.WriteAllText(central, original);
        var provider = DesktopProviders.Find("winforms")!;
        var request = new DesktopNewRequest(provider.Platform, "CentralApp", directory.Root, "C#", "net10.0", provider.DefaultTheme, ["chart"]);
        var result = await new DesktopProjectService(new FakeTools { Central = true, FailRestore = true }).CreateAsync(provider, request);
        Assert.False(result.Success);
        Assert.Equal(original, File.ReadAllText(central));
        result = await new DesktopProjectService(new FakeTools { Central = true }).CreateAsync(provider, request with { Restore = false, Build = false });
        Assert.True(result.Success);
        Assert.All(XDocument.Load(Path.Combine(result.ProjectPath!, "CentralApp.csproj")).Descendants().Where(element => element.Name.LocalName == "PackageReference"), element => Assert.Null(element.Attribute("Version")));
        Assert.Single(XDocument.Load(central).Descendants("PackageVersion"), element => (string?)element.Attribute("Include") == "Syncfusion.Chart.Windows");
    }

    [Fact]
    public async Task PackageRemovalProtectsGeneratedDependenciesAndOrdinaryFailuresRollback()
    {
        using var directory = new Temp();
        var provider = DesktopProviders.Find("winforms")!;
        var request = new DesktopNewRequest(provider.Platform, "PackagesApp", directory.Root, "VB", "net10.0", provider.DefaultTheme, ["datagrid"], false, false);
        var created = await new DesktopProjectService(new FakeTools()).CreateAsync(provider, request);
        var project = Path.Combine(created.ProjectPath!, "PackagesApp.vbproj");
        var blocked = await new DesktopPackageService(new FakeNuGet(), new FakeTools()).ExecuteAsync(provider, "remove", project, "office2019");
        Assert.False(blocked.Success);
        Assert.Contains("required", blocked.Message);
        var before = File.ReadAllText(project);
        var failed = await new DesktopPackageService(new FakeNuGet { Fail = true }, new FakeTools()).ExecuteAsync(provider, "add", project, "chart");
        Assert.False(failed.Success);
        Assert.Equal(before, File.ReadAllText(project));
        Assert.NotNull(DesktopProjectService.ValidateLocation(Path.GetPathRoot(directory.Root)!));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public async Task DirectCommandsUseProviderValidationAndJson(string platform)
    {
        using var capture = new ConsoleCapture();
        var chartControl = platform == "winui" ? "cartesian-chart" : "chart";
        var result = await CliApp.Build().RunAsync(["new", platform, "--name", "DirectApp", "--control", chartControl, "datagrid", "--dry-run", "--json", "--no-interactive"]);
        Assert.Equal(0, result);
        using var json = JsonDocument.Parse(capture.Out);
        Assert.True(json.RootElement.GetProperty("success").GetBoolean());
    }

    private sealed class FakeTools : ToolRunner
    {
        public bool FailRestore { get; init; }
        public List<string> Commands { get; } = [];
        public bool Central { get; init; }
        public bool FailBuild { get; init; }
        public string SdkOutput { get; init; } = "10.0.100 [sdk]";
        public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null, CancellationToken cancellationToken = default, string? executable = null)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ToolResult(0, PackageSearchFixture.Response(args[2], "35.1.40"), ""));
            cancellationToken.ThrowIfCancellationRequested();
            Commands.Add(args[0]);
            if (args[0] == "new") Directory.CreateDirectory(args[args.ToList().IndexOf("-o") + 1]);
            return Task.FromResult((FailRestore && args[0] == "restore") || (FailBuild && args[0] == "build") ? new ToolResult(1, "", "restore failed")
                : new ToolResult(0, args[0] == "--list-sdks" ? SdkOutput : args.Contains("-getProperty:ManagePackageVersionsCentrally") ? Central.ToString().ToLowerInvariant() : "", ""));
        }
    }
    private sealed class FakeNuGet : NuGetRunner
    {
        public bool Fail { get; init; }
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
        {
            File.AppendAllText(operation.ProjectPath, "changed");
            return Task.FromResult(new NuGetCommandResult { ExitCode = Fail ? 1 : 0, StandardOutput = "", StandardError = "package failed" });
        }
    }
    private sealed class Temp : IDisposable
    {
        public string Root { get; } = Path.Combine(Path.GetTempPath(), "sf-desktop-test-" + Guid.NewGuid().ToString("N"));
        public Temp() => Directory.CreateDirectory(Root);
        public void Dispose() => Directory.Delete(Root, true);
    }
}
