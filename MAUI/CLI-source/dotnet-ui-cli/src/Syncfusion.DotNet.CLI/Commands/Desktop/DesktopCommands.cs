using System.CommandLine;
using System.CommandLine.Parsing;
using System.Text.Json;
using System.Xml.Linq;
using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands.Options;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Commands.Parsing;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;

namespace Syncfusion.DotNet.CLI.Commands.Desktop;

/// <summary>Shared desktop command adapter; the CLI contains no desktop control or theme APIs.</summary>
internal static class DesktopCommands
{
    internal static IDesktopPlatformProvider? Provider(ParseResult parse, string firstName, string? secondName = null)
        => DesktopProviders.Find(parse.GetValue<string?>(firstName))
            ?? (secondName is null ? null : DesktopProviders.Find(parse.GetValue<string?>(secondName)))
            ?? DesktopProviders.Find(parse.GetValue(CommandOptions.FrameworkOption));

    internal static async Task<int> NewAsync(ParseResult parse, GlobalOptions globals, ConsolePresenter presenter,
        IDesktopPlatformProvider provider, CancellationToken token, bool showAction = true)
    {
        var frameworkError = FrameworkResolver.ValidateExplicit(parse.GetValue<string?>(NewCommand.FrameworkArg), parse.GetValue(CommandOptions.FrameworkOption));
        if (frameworkError is not null) return CommandOperations.WriteFailure(presenter, globals, frameworkError);
        var interactive = InteractivePrompt.CanPrompt(globals) && string.IsNullOrWhiteSpace(parse.GetValue(CommandOptions.NameOption));
        using var collecting = interactive ? ProjectWizardOutput.Begin(AnsiConsole.Console, presenter.NoColor) : null;
        var input = new InteractiveConsoleInput(presenter.NoColor);
        if (interactive && showAction)
        {
            if (!ProjectWizardOutput.HasCompletedValue("Action:")) input.WriteResult("Action", "Create a new project");
            if (!ProjectWizardOutput.HasCompletedValue("Platform:")) input.WriteResult("Platform", provider.DisplayName);
        }
        var language = DesktopConfiguration.CanonicalLanguage(parse.GetValue(CommandOptions.LanguageOption) ??
            (interactive ? Choose(input, "Language", provider.Languages, token) : provider.Languages[0]));
        if (!provider.Languages.Contains(language)) return CommandOperations.WriteFailure(presenter, globals, $"{provider.DisplayName} supports: {string.Join(", ", provider.Languages)}.");
        if (interactive && parse.GetResult(CommandOptions.LanguageOption) is not null) input.WriteResult("Language", language);
        var framework = parse.GetValue(CommandOptions.TargetFrameworkOption) ??
            (interactive ? ChooseFramework(input, provider, token) : provider.TargetFrameworks[0]);
        if (!provider.TargetFrameworks.Contains(framework)) return CommandOperations.WriteFailure(presenter, globals, $"Unsupported target framework '{framework}' for {provider.DisplayName}.");
        if (interactive && parse.GetResult(CommandOptions.TargetFrameworkOption) is not null) input.WriteResult("Target framework", FrameworkLabel(framework));
        var theme = ResolveTheme(provider, parse.GetValue(CommandOptions.ThemeOption) ??
            (interactive && provider.Platform != Framework.WPF ? Choose(input, "Theme", provider.Themes.Select(item => item.DisplayName).ToArray(), token) : provider.DefaultTheme));
        if (!provider.Themes.Any(item => item.Name == theme)) return CommandOperations.WriteFailure(presenter, globals, $"Unsupported theme '{theme}' for {provider.DisplayName}.");
        if (interactive && provider.Platform != Framework.WPF && parse.GetResult(CommandOptions.ThemeOption) is not null) input.WriteResult("Theme", provider.Themes.Single(item => item.Name == theme).DisplayName);
        var name = parse.GetValue(CommandOptions.NameOption);
        if (string.IsNullOrWhiteSpace(name) && !interactive) return CommandOperations.WriteFailure(presenter, globals, "Project name is required. Use --name.");
        var location = parse.GetValue(CommandOptions.PathOption);
        if (interactive)
            (location, name) = NewCommand.AskProjectLocationAndName(provider.Platform, location, presenter, input, token, DesktopConfiguration.ValidateProjectName);
        else location ??= DefaultLocation();
        var controls = CommandOptions.GetTemplateValues(parse).Select(value => value.ToLowerInvariant()).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
        if (interactive && parse.GetResult(CommandOptions.ControlOption) is null && parse.GetResult(CommandOptions.TemplateOption) is null)
            controls = AskSetupAndControls(input, provider, token).ToArray();
        if (controls.Length == 1 && controls[0] == "empty") controls = [];
        if (controls.Any(id => !provider.Controls.Any(item => item.Alias == id))) return CommandOperations.WriteFailure(presenter, globals, "Available controls: " + string.Join(", ", provider.Controls.Select(item => item.Alias)) + ".");
        if (interactive && (parse.GetResult(CommandOptions.ControlOption) is not null || parse.GetResult(CommandOptions.TemplateOption) is not null))
        {
            input.WriteResult("Setup", controls.Length == 0 ? "Empty project" : "Include Syncfusion controls");
            if (controls.Length > 0) input.WriteResult("Controls", string.Join(", ", provider.Controls.Where(item => controls.Contains(item.Alias)).Select(item => item.DisplayName)));
        }
        if (provider.Platform == Framework.WPF)
            theme = WpfThemeAfterControls(input, provider, controls, parse.GetValue(CommandOptions.ThemeOption), interactive, token);
        var post = parse.GetValue(CommandOptions.PostActionOption)?.ToLowerInvariant();
        if (post is not null && post is not ("generate" or "build")) return CommandOperations.WriteFailure(presenter, globals, "--post-action must be generate or build.");
        if (post is null && interactive) post = InteractivePrompt.AskPostCreationAction(false, input, token) == InteractivePrompt.PostCreationAction.Build ? "build" : "generate";
        if (post == "build" && parse.GetValue(CommandOptions.NoBuildOption)) return CommandOperations.WriteFailure(presenter, globals, "--post-action build conflicts with --no-build.");
        var build = post != "generate" && !parse.GetValue(CommandOptions.NoBuildOption);
        var request = new DesktopNewRequest(provider.Platform, name!, Path.GetFullPath(location), language, framework, theme, controls,
            ShouldRestore(post, parse.GetValue(CommandOptions.NoRestoreOption)), build, parse.GetValue(CommandOptions.DryRunOption),
            parse.GetValue(CommandOptions.VersionOption), parse.GetValue(CommandOptions.SourceOption), parse.GetValue(CommandOptions.ConfigFileOption));
        var validation = DesktopConfiguration.Validate(provider, request);
        if (validation is not null) return CommandOperations.WriteFailure(presenter, globals, validation);
        if (interactive)
        {
            ProjectWizardOutput.ReuseCompletedSteps(presenter, Review(provider, request));
            if (!InteractivePrompt.Confirm("Proceed with project creation?", true, cancellationToken: token, noColor: presenter.NoColor)) return ExitCodes.Cancelled;
        }
        if (!OperatingSystem.IsWindows() && !globals.Json)
            presenter.WriteWarning($"Building and running {provider.DisplayName} applications requires a supported Windows environment. File generation is available on this host.");
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        var result = await new OperationProgress(presenter.NoColor, globals.Json, showPending: false).RunAsync(progress =>
            new DesktopProjectService().CreateAsync(provider, request, progress, token)).ConfigureAwait(false);
        if (result.Success && !request.DryRun && result.ProjectPath is not null)
        {
            result = result with { NextCommands = ProjectNextCommands.Desktop(request, result.ProjectPath) };
        }
        return Report(presenter, globals, result);
    }
    internal static string WpfThemeAfterControls(InteractiveConsoleInput input, IDesktopPlatformProvider provider,
        IReadOnlyList<string> controls, string? suppliedTheme, bool interactive, CancellationToken token = default)
    {
        var theme = ResolveTheme(provider, suppliedTheme ?? provider.DefaultTheme);
        if (!interactive || controls.Count == 0) return theme;
        if (suppliedTheme is null)
            return ResolveTheme(provider, Choose(input, "Theme", provider.Themes.Select(item => item.DisplayName).ToArray(), token));
        input.WriteResult("Theme", provider.Themes.Single(item => item.Name == theme).DisplayName);
        return theme;
    }

    internal static bool ShouldRestore(string? postAction, bool noRestore)
        => postAction != "generate" && !noRestore;

    internal static IReadOnlyList<string> AskSetupAndControls(InteractiveConsoleInput input, IDesktopPlatformProvider provider, CancellationToken token = default)
        => InteractivePrompt.AskProjectSetup(input, token, "Empty project", "Include Syncfusion controls")
            ? input.SelectControls(provider.Controls.Select(item => new ControlSelectionItem(item.Alias, item.DisplayName)).ToArray(), token)
            : [];

    internal static IReadOnlyList<(string Label, string Value)> Review(IDesktopPlatformProvider provider, DesktopNewRequest request)
    {
        var rows = new List<(string Label, string Value)>
        {
            ("Action:", "Create a new project"), ("Platform:", provider.DisplayName), ("Language:", request.Language),
            ("Target framework:", FrameworkLabel(request.TargetFramework)),
            ("Project location:", request.Location), ("Project name:", request.Name),
            ("Setup:", request.Controls.Count == 0 ? "Empty project" : "Include Syncfusion controls"),
        };
        if (provider.Platform != Framework.WPF)
            rows.Insert(4, ("Theme:", provider.Themes.Single(theme => theme.Name == request.Theme).DisplayName));
        if (request.Controls.Count > 0) rows.Add(("Controls:", string.Join(", ", provider.Controls.Where(control => request.Controls.Contains(control.Alias)).Select(control => control.DisplayName))));
        if (provider.Platform == Framework.WPF && request.Controls.Count > 0)
            rows.Add(("Theme:", provider.Themes.Single(theme => theme.Name == request.Theme).DisplayName));
        rows.Add(("Post-create:", request.Build ? "Build project" : "Generate only"));
        return rows;
    }
    internal static string ResolveTheme(IDesktopPlatformProvider provider, string theme)
    {
        var selected = provider.Themes.FirstOrDefault(item => item.Name.Equals(theme, StringComparison.OrdinalIgnoreCase) || item.DisplayName.Equals(theme, StringComparison.OrdinalIgnoreCase));
        if (selected is not null) return selected.Name;
        var family = theme.ToLowerInvariant() switch { "windows11" => "Windows11Light", "material3" => "Material3Light", "office2019" => "Office2019Colorful", _ => theme };
        return family;
    }
    private static string FrameworkLabel(string framework) => framework switch
    {
        "net462" => ".NET Framework 4.6.2", "net47" => ".NET Framework 4.7", "net48" => ".NET Framework 4.8",
        _ => InteractivePrompt.FrameworkLabel(framework),
    };
    private static string ChooseFramework(InteractiveConsoleInput input, IDesktopPlatformProvider provider, CancellationToken token)
    {
        var selected = Choose(input, "Target framework", provider.TargetFrameworks.Select(FrameworkLabel).ToArray(), token);
        return provider.TargetFrameworks.Single(framework => FrameworkLabel(framework) == selected);
    }
    private static string Choose(InteractiveConsoleInput input, string label, IReadOnlyList<string> choices, CancellationToken token)
    {
        if (choices.Count == 1) { input.WriteResult(label, choices[0]); return choices[0]; }
        var prompt = new WizardSelectionPrompt<string> { Title = label + ":", PageSize = choices.Count, WrapAround = true };
        prompt.AddChoices(choices);
        InteractivePrompt.ConfigureSelectionPrompt(prompt, choices.Count);
        return input.PromptSingle(prompt, token, label);
    }
    internal static string DefaultLocation() => ProjectCreationDirectory.DefaultParent();

    internal static async Task<int> PackageAsync(ParseResult parse, string action, GlobalOptions globals,
        ConsolePresenter presenter, IDesktopPlatformProvider provider, CancellationToken token)
    {
        var first = parse.GetValue<string?>("package");
        var second = parse.GetValue<string?>("framework");
        var primary = DesktopProviders.Find(first) is not null;
        var error = FrameworkResolver.ValidateExplicit(primary ? first : second, parse.GetValue(CommandOptions.FrameworkOption));
        if (error is not null) return CommandOperations.WriteFailure(presenter, globals, error);
        if (parse.GetResult(CommandOptions.ControlOption) is not null || parse.GetResult(CommandOptions.TemplateOption) is not null)
            return CommandOperations.WriteFailure(presenter, globals, "Existing-project package commands do not accept --control; use the package alias or ID.");
        var package = primary ? second : first;
        IReadOnlyList<string> selectedPackages = package is null ? [] : [package];
        var path = parse.GetValue(CommandOptions.PathOption);
        var version = parse.GetResult(CommandOptions.VersionOption) is null ? null : parse.GetValue(CommandOptions.VersionOption);
        var restore = !parse.GetValue(CommandOptions.NoRestoreOption);
        var build = parse.GetResult(CommandOptions.BuildOption) is not null && parse.GetValue(CommandOptions.BuildOption);
        if (build && parse.GetValue(CommandOptions.NoBuildOption)) return CommandOperations.WriteFailure(presenter, globals, "--build conflicts with --no-build.");
        using var collecting = InteractivePrompt.CanPrompt(globals) ? ProjectWizardOutput.Begin(AnsiConsole.Console, presenter.NoColor) : null;
        if (InteractivePrompt.CanPrompt(globals))
        {
            var input = new InteractiveConsoleInput(presenter.NoColor);
            if (!ProjectWizardOutput.HasCompletedValue("Action:")) input.WriteResult("Action", action == "add" ? "Add a package to an existing project" : action == "remove" ? "Remove a package from an existing project" : "Update a package in an existing project");
            if (!ProjectWizardOutput.HasCompletedValue("Platform:")) input.WriteResult("Platform", provider.DisplayName);
            path ??= InteractivePrompt.AskString("Project file:", Directory.GetCurrentDirectory(), input, token, compactDefault: true);
            var selectedProject = DesktopProjectFiles.ResolveProject(path, provider.Platform);
            if (package is null)
            {
                var choices = PackageSelectionState.MarkInstalled(provider.Packages.Select(item => new PackageSelectionItem(item.Alias, item.DisplayName, PackageId: item.Id)).ToArray(), selectedProject);
                selectedPackages = action == "add" ? input.SelectPackages(choices, token)
                    : [input.SelectPackage(choices, token, $"Which package would you like to {action}?", retainAnswer: true)];
                if (selectedPackages.Count == 0) return ExitCodes.Success;
                package = selectedPackages[0];
            }
            if (restore && action != "remove" && parse.GetResult(CommandOptions.BuildOption) is null && !parse.GetValue(CommandOptions.NoBuildOption))
                build = Choose(input, "Post-add", ["Restore only", "Restore and build"], token) == "Restore and build";
            ProjectWizardOutput.ReplaceCompletedSteps();
            SummaryRows.Write(presenter, SummaryRows.PackageReview([("Action:", action == "add" ? "Add a package to an existing project" : action == "remove" ? "Remove a package from an existing project" : "Update a package in an existing project"),
                ("Platform:", provider.DisplayName), ("Project file:", selectedProject), (selectedPackages.Count > 1 ? "Packages:" : "Package:",
                    string.Join(", ", selectedPackages.Select(id => provider.Packages.FirstOrDefault(item => item.Alias == id || item.Id == id) is { } item
                        ? InteractiveConsoleInput.FormatPackageChoice(new(item.Alias, item.DisplayName)) : id))),
                ("Version:", version ?? "Latest available"), ("Post-add:", build ? "Restore and build" : restore ? "Restore only" : "Skip restore")], version), ProjectFlowLayout.ValueColumn);
            if (!InteractivePrompt.Confirm($"Proceed to {action} packages?", true, cancellationToken: token, noColor: presenter.NoColor)) return ExitCodes.Cancelled;
        }
        if (package is null) return CommandOperations.WriteFailure(presenter, globals, "Package name is required.");
        try
        {
            presenter.ProtectNuGetConfiguration(parse.GetValue(CommandOptions.SourceOption), parse.GetValue(CommandOptions.ConfigFileOption));
            return await CommandOperations.RunPackageSelectionAsync(selectedPackages, async (selectedPackage, last) =>
            {
                var result = await new OperationProgress(presenter.NoColor, globals.Json, showPending: false).RunAsync(progress => new DesktopPackageService().ExecuteAsync(provider, action, path ?? Directory.GetCurrentDirectory(), selectedPackage,
                    version, restore, build && last, parse.GetValue(CommandOptions.DryRunOption),
                    parse.GetValue(CommandOptions.SourceOption), parse.GetValue(CommandOptions.ConfigFileOption), token, progress)).ConfigureAwait(false);
                return Report(presenter, globals, result);
            }).ConfigureAwait(false);
        }
        catch (Exception exception) when (exception is ArgumentException or InvalidOperationException)
        { return CommandOperations.WriteFailure(presenter, globals, exception.Message); }
    }
    internal static int Discover(ParseResult parse, string action, GlobalOptions globals, ConsolePresenter presenter,
        IDesktopPlatformProvider provider, string? target, CancellationToken cancellationToken = default)
    {
        var first = parse.GetValue<string?>(action == "list" ? ListCommand.CategoryArg : SearchCommand.TextArg);
        var second = parse.GetValue<string?>("framework");
        var primary = DesktopProviders.Find(first) is not null;
        var frameworkError = FrameworkResolver.ValidateExplicit(primary ? first : second, parse.GetValue(CommandOptions.FrameworkOption));
        if (frameworkError is not null) return CommandOperations.WriteFailure(presenter, globals, frameworkError);
        if (action == "search" && string.IsNullOrWhiteSpace(target)) return CommandOperations.WriteFailure(presenter, globals, "Search text is required.");
        if (action == "list") target = target?.ToLowerInvariant();
        if (action == "list" && parse.GetValue(CommandOptions.InstalledOption)) target = "installed";
        if (action == "list" && target == "installed")
        {
            try
            {
                var path = DesktopProjectFiles.ResolveProject(parse.GetValue(CommandOptions.PathOption) ?? Directory.GetCurrentDirectory(), provider.Platform);
                var packages = XDocument.Load(path).Descendants().Where(element => element.Name.LocalName == "PackageReference"
                        && ((string?)element.Attribute("Include"))?.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase) == true)
                    .Select(element => new { Id = (string)element.Attribute("Include")!, Version = InstalledVersion(path, element) })
                    .OrderBy(package => package.Id, StringComparer.OrdinalIgnoreCase).ToArray();
                if (globals.Json) presenter.WriteInfo(JsonSerializer.Serialize(packages));
                else InstalledPackageRenderer.Write(presenter, provider.DisplayName, packages.Select(package =>
                    new InstalledPackageRenderer.Entry(
                        provider.Packages.FirstOrDefault(item => item.Id.Equals(package.Id, StringComparison.OrdinalIgnoreCase))?.Alias,
                        package.Id, package.Version)).ToArray());
                return 0;
            }
            catch (Exception exception) when (exception is ArgumentException or IOException or InvalidOperationException or System.Xml.XmlException)
            { return CommandOperations.WriteFailure(presenter, globals, exception.Message); }
        }
        if (action == "list" && target is not ("packages" or null)) return CommandOperations.WriteFailure(presenter, globals, "Available desktop list categories: packages, installed.");
        var query = action == "search" ? target : parse.GetValue(ListCommand.SearchOption);
        query = query?.Trim();
        var matches = provider.Packages.Where(item => string.IsNullOrWhiteSpace(query) || item.Alias.Contains(query, StringComparison.OrdinalIgnoreCase)
            || item.Id.Contains(query, StringComparison.OrdinalIgnoreCase) || item.DisplayName.Contains(query, StringComparison.OrdinalIgnoreCase)
            || item.Description.Contains(query, StringComparison.OrdinalIgnoreCase)).ToArray();
        if (globals.Json) presenter.WriteInfo(JsonSerializer.Serialize(matches.Select(package =>
            new { package.Alias, package.DisplayName, package.Id, package.HasTemplate })));
        else PackageListRenderer.Write(presenter, matches.Select(package => new PackageListRenderer.Entry(
            package.Alias, package.DisplayName, package.Id, package.Category, package.Classification,
            [$"{package.Alias}: {package.Description}",
             $"Release status: {package.Status}",
             $"CLI setup support: {(package.HasTemplate ? "generated control sample and package operations" : "package operations; no generated control sample")}"])).ToArray(),
            globals, provider.DisplayName, parse.GetValue(ListCommand.DetailsOption), cancellationToken);
        return 0;
    }
    private static string? InstalledVersion(string project, XElement reference)
    {
        var version = (string?)reference.Attribute("VersionOverride") ?? (string?)reference.Attribute("Version")
            ?? reference.Elements().FirstOrDefault(element => element.Name.LocalName == "Version")?.Value;
        if (version is not null) return version;
        var id = (string?)reference.Attribute("Include");
        for (var directory = Path.GetDirectoryName(project); directory is not null; directory = Path.GetDirectoryName(directory))
        {
            var central = Path.Combine(directory, "Directory.Packages.props");
            if (!File.Exists(central)) continue;
            return XDocument.Load(central).Descendants().Where(element => element.Name.LocalName == "PackageVersion")
                .Where(element => string.Equals((string?)element.Attribute("Include") ?? (string?)element.Attribute("Update"), id, StringComparison.OrdinalIgnoreCase))
                .Select(element => (string?)element.Attribute("Version") ?? element.Elements().FirstOrDefault(child => child.Name.LocalName == "Version")?.Value).FirstOrDefault();
        }
        return reference.Elements().FirstOrDefault(element => element.Name.LocalName == "Version")?.Value;
    }

    private static int Report(ConsolePresenter presenter, GlobalOptions globals, DesktopResult result)
    {
        if (globals.Json) presenter.WriteInfo(JsonSerializer.Serialize(result, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));
        else
        {
            if (result.ExitCode == 0) presenter.WriteInfo(result.Message); else presenter.WriteError(result.Message);
            foreach (var error in result.Errors ?? []) presenter.WriteError(error);
            if (result.NextCommands is not null)
            {
                if (result.NextCommands.Any(command => command.StartsWith("msbuild ", StringComparison.Ordinal)))
                    presenter.WriteInfo("Use a Visual Studio Developer PowerShell for the .NET Framework build command.");
                ProjectNextCommands.Write(presenter, result.NextCommands, powerShell: true);
            }
            if (result.Message.Contains("--dry-run")) foreach (var file in result.Files ?? []) presenter.WriteInfo("  + " + file);
        }
        return result.ExitCode;
    }
}
