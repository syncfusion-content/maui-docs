using System.CommandLine;
using System.CommandLine.Parsing;
using System.Text.Json;
using Spectre.Console;
using Syncfusion.DotNet.Cli.Blazor;
using Syncfusion.DotNet.Cli.Commands.Desktop;
using Syncfusion.DotNet.Cli.Commands.Operations;
using Syncfusion.DotNet.Cli.Commands.Options;
using Syncfusion.DotNet.Cli.Commands.Parsing;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Commands.Blazor;

internal static class BlazorCommands
{
    internal static BlazorPlatformProvider Provider { get; } = new();
    internal static bool IsSelected(ParseResult parse, params string[] arguments)
        => arguments.Select(argument => parse.GetValue<string?>(argument)).Append(parse.GetValue(CommandOptions.FrameworkOption))
            .Any(value => value?.Equals("blazor", StringComparison.OrdinalIgnoreCase) == true);

    internal static async Task<int> NewAsync(ParseResult parse, GlobalOptions globals, ConsolePresenter presenter,
        CancellationToken token, bool showAction = true)
    {
        var frameworkError = FrameworkResolver.ValidateExplicit(parse.GetValue<string?>(NewCommand.FrameworkArg), parse.GetValue(CommandOptions.FrameworkOption));
        if (frameworkError is not null) return CommandOperations.WriteFailure(presenter, globals, frameworkError);
        var interactive = InteractivePrompt.CanPrompt(globals) && string.IsNullOrWhiteSpace(parse.GetValue(CommandOptions.NameOption));
        using var collecting = interactive ? ProjectWizardOutput.Begin(AnsiConsole.Console, presenter.NoColor) : null;
        var input = new InteractiveConsoleInput(presenter.NoColor);
        if (interactive && showAction)
        {
            if (!ProjectWizardOutput.HasCompletedValue("Action:")) input.WriteResult("Action", "Create a new project");
            if (!ProjectWizardOutput.HasCompletedValue("Platform:")) input.WriteResult("Platform", "Blazor");
        }
        var appType = ParseAppType(parse.GetValue(CommandOptions.AppTypeOption), out var appError);
        if (appError is not null) return CommandOperations.WriteFailure(presenter, globals, appError);
        if (interactive && parse.GetResult(CommandOptions.AppTypeOption) is null)
            appType = Choose(input, "Application type", [("Blazor Web App", BlazorAppType.WebApp), ("Blazor WebAssembly Standalone", BlazorAppType.WebAssemblyStandalone)], token);
        else if (interactive) input.WriteResult("Application type", AppTypeLabel(appType));
        var language = parse.GetValue(CommandOptions.LanguageOption) ?? "C#";
        if (!DesktopConfiguration.CanonicalLanguage(language).Equals("C#", StringComparison.Ordinal))
            return CommandOperations.WriteFailure(presenter, globals, "Blazor supports: C#.");
        IReadOnlyList<string> frameworks;
        try { frameworks = await new BlazorTemplateCapabilities().FrameworksAsync(appType, token).ConfigureAwait(false); }
        catch (InvalidOperationException exception) { return CommandOperations.WriteFailure(presenter, globals, exception.Message); }
        var target = parse.GetValue(CommandOptions.TargetFrameworkOption);
        if (target is null && interactive)
        {
            var labels = frameworks.Select(InteractivePrompt.FrameworkLabel).ToArray();
            var selected = Choose(input, "Target framework", labels.Select((label, index) => (label, frameworks[index])).ToArray(), token);
            target = selected;
        }
        target ??= frameworks.FirstOrDefault() ?? "net10.0";
        if (interactive && parse.GetResult(CommandOptions.TargetFrameworkOption) is not null) input.WriteResult("Target framework", InteractivePrompt.FrameworkLabel(target));
        var suppliedRenderMode = parse.GetValue(CommandOptions.RenderModeOption);
        if (appType == BlazorAppType.WebAssemblyStandalone && suppliedRenderMode is not null
            && !suppliedRenderMode.Equals("webassembly", StringComparison.OrdinalIgnoreCase))
            return CommandOperations.WriteFailure(presenter, globals, "Standalone WebAssembly supports only --render-mode webassembly.");
        if (appType == BlazorAppType.WebAssemblyStandalone && parse.GetResult(CommandOptions.InteractivityOption) is not null)
            return CommandOperations.WriteFailure(presenter, globals, "--interactivity applies only to Blazor Web App projects.");
        string? renderError = null;
        var render = appType == BlazorAppType.WebAssemblyStandalone ? BlazorRenderMode.WebAssembly
            : ParseEnum(suppliedRenderMode, BlazorRenderMode.Server, "--render-mode", out renderError);
        if (renderError is not null) return CommandOperations.WriteFailure(presenter, globals, renderError);
        if (interactive && appType == BlazorAppType.WebApp && parse.GetResult(CommandOptions.RenderModeOption) is null)
            render = Choose(input, "Render mode", [("Server", BlazorRenderMode.Server), ("WebAssembly", BlazorRenderMode.WebAssembly), ("Auto", BlazorRenderMode.Auto)], token);
        else if (interactive && appType == BlazorAppType.WebApp) input.WriteResult("Render mode", render.ToString());
        var interactivity = ParseInteractivity(parse.GetValue(CommandOptions.InteractivityOption), out var interactivityError);
        if (interactivityError is not null) return CommandOperations.WriteFailure(presenter, globals, interactivityError);
        var auth = ParseEnum(parse.GetValue(CommandOptions.AuthOption), BlazorAuthentication.None, "--auth", out var authError);
        if (authError is not null) return CommandOperations.WriteFailure(presenter, globals, authError);
        var httpsFixed = false;
        if (interactive)
        {
            if (appType == BlazorAppType.WebApp && parse.GetResult(CommandOptions.InteractivityOption) is null)
                interactivity = Choose(input, "Interactivity", [("Per page/component", BlazorInteractivity.PerPage), ("Global", BlazorInteractivity.Global)], token);
            else if (appType == BlazorAppType.WebApp) input.WriteResult("Interactivity", InteractivityLabel(interactivity));
            if (appType == BlazorAppType.WebApp && parse.GetResult(CommandOptions.AuthOption) is null)
                auth = Choose(input, "Authentication", [("None", BlazorAuthentication.None), ("Individual accounts", BlazorAuthentication.Individual)], token);
            else input.WriteResult("Authentication", auth == BlazorAuthentication.None ? "None" : "Individual accounts");
            if (auth == BlazorAuthentication.Individual && parse.GetResult(CommandOptions.HttpsOption) is null) httpsFixed = true;
        }
        var https = ParseYesNo(parse.GetValue(CommandOptions.HttpsOption), true, out var httpsError);
        if (httpsError is not null) return CommandOperations.WriteFailure(presenter, globals, httpsError);
        if (httpsFixed || (auth == BlazorAuthentication.Individual && parse.GetResult(CommandOptions.HttpsOption) is null))
        {
            https = true;
            if (interactive) input.WriteResult("HTTPS", "Yes (required by Individual accounts)");
        }
        else if (interactive && parse.GetResult(CommandOptions.HttpsOption) is null)
            https = Choose(input, "HTTPS", [("Yes", true), ("No", false)], token);
        else if (interactive) input.WriteResult("HTTPS", https ? "Yes" : "No");
        var name = parse.GetValue(CommandOptions.NameOption);
        var location = parse.GetValue(CommandOptions.PathOption);
        (location, name) = ResolveLocationAndName(interactive, location, name,
            supplied => NewCommand.AskProjectLocationAndName(Framework.Blazor, supplied, presenter, input, token, DesktopConfiguration.ValidateProjectName));
        var suppliedControls = CommandOptions.GetTemplateValues(parse);
        var demo = !(suppliedControls.Count == 1 && suppliedControls[0].Equals("empty", StringComparison.OrdinalIgnoreCase));
        IReadOnlyList<string> controls = demo ? suppliedControls.Where(value => !value.Equals("empty", StringComparison.OrdinalIgnoreCase)).ToArray() : [];
        if (interactive && parse.GetResult(CommandOptions.ControlOption) is null && parse.GetResult(CommandOptions.TemplateOption) is null)
        {
            demo = InteractivePrompt.AskProjectSetup(input, token, "Empty project", "Include Syncfusion controls");
        }
        var theme = parse.GetValue(CommandOptions.ThemeOption) ?? Provider.DefaultTheme;
        var selectedTheme = BlazorCatalog.Themes.FirstOrDefault(item => item.Id.Equals(theme, StringComparison.OrdinalIgnoreCase) || item.DisplayName.Equals(theme, StringComparison.OrdinalIgnoreCase));
        if (selectedTheme is null) return CommandOperations.WriteFailure(presenter, globals, $"Unknown Blazor theme '{theme}'.");
        theme = selectedTheme.Id;
        if (interactive && demo && parse.GetResult(CommandOptions.ControlOption) is null && parse.GetResult(CommandOptions.TemplateOption) is null)
            controls = input.SelectControls(Provider.Controls.Select(item => new ControlSelectionItem(item.Alias, item.DisplayName)).ToArray(), token,
                title: "Which Syncfusion components would you like to include?", initiallySelected: []);
        if (controls.Count == 0) demo = false;
        if (interactive && demo && parse.GetResult(CommandOptions.ThemeOption) is null)
            theme = Choose(input, "Theme", BlazorCatalog.Themes.Select(item => (item.DisplayName, item.Id)).ToArray(), token);
        else if (interactive && demo) input.WriteResult("Theme", selectedTheme.DisplayName);
        var post = parse.GetValue(CommandOptions.PostActionOption)?.ToLowerInvariant();
        if (post is not null && post is not ("generate" or "build")) return CommandOperations.WriteFailure(presenter, globals, "--post-action must be generate or build.");
        if (post is null && interactive) post = InteractivePrompt.AskPostCreationAction(false, input, token) == InteractivePrompt.PostCreationAction.Build ? "build" : "generate";
        var build = post != "generate" && !parse.GetValue(CommandOptions.NoBuildOption);
        var request = new BlazorNewRequest(name!, Path.GetFullPath(location), appType, target, render, interactivity, auth, https,
            demo, theme, controls, Restore: post != "generate" && !parse.GetValue(CommandOptions.NoRestoreOption), Build: build,
            parse.GetValue(CommandOptions.DryRunOption), parse.GetValue(CommandOptions.VersionOption), parse.GetValue(CommandOptions.SourceOption), parse.GetValue(CommandOptions.ConfigFileOption));
        var validation = BlazorConfiguration.Validate(request, frameworks);
        if (validation is not null) return CommandOperations.WriteFailure(presenter, globals, validation);
        if (interactive)
        {
            ProjectWizardOutput.ReuseCompletedSteps(presenter, Review(request));
            if (!InteractivePrompt.Confirm("Proceed with project creation?", true, cancellationToken: token, noColor: presenter.NoColor)) return ExitCodes.Cancelled;
        }
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        var result = await new OperationProgress(presenter.NoColor, globals.Json, showPending: false).RunAsync(progress =>
            new BlazorProjectService().CreateAsync(request, progress, token)).ConfigureAwait(false);
        if (result.Success && !request.DryRun && result.ProjectPath is not null)
            result = result with { NextCommands = ProjectNextCommands.Blazor(request, result.ProjectPath) };
        return Report(presenter, globals, result);
    }

    internal static Task<int> PackageAsync(ParseResult parse, string action, GlobalOptions globals, ConsolePresenter presenter, CancellationToken token)
        => DesktopCommands.PackageAsync(parse, action, globals, presenter, Provider, token);
    internal static int Discover(ParseResult parse, string action, GlobalOptions globals, ConsolePresenter presenter, string? target)
        => DesktopCommands.Discover(parse, action, globals, presenter, Provider, target);

    internal static IReadOnlyList<(string Label, string Value)> Review(BlazorNewRequest request)
    {
        var rows = new List<(string, string)>
        {
            ("Action:", "Create a new project"), ("Platform:", "Blazor"), ("Application type:", AppTypeLabel(request.AppType)),
            ("Target framework:", InteractivePrompt.FrameworkLabel(request.TargetFramework)),
        };
        if (request.AppType == BlazorAppType.WebApp)
        {
            rows.Add(("Render mode:", request.RenderMode.ToString()));
            rows.Add(("Interactivity:", InteractivityLabel(request.Interactivity)));
        }
        rows.AddRange([
            ("Authentication:", request.Authentication == BlazorAuthentication.None ? "None" : "Individual accounts"),
            ("HTTPS:", request.Https ? "Yes" : "No"), ("Project location:", request.Location), ("Project name:", request.Name),
            ("Setup:", request.DemoPages ? "Include Syncfusion controls" : "Empty project"),
        ]);
        if (request.DemoPages)
        {
            rows.Add(("Components:", string.Join(", ", Provider.Controls.Where(control => request.Controls.Contains(control.Alias)).Select(control => control.DisplayName))));
            rows.Add(("Theme:", BlazorCatalog.Themes.Single(theme => theme.Id == request.Theme).DisplayName));
        }
        rows.Add(("Post-create:", request.Build ? "Build project" : "Generate only"));
        return rows;
    }

    /// <summary>Explicit --path/--name always win; otherwise the shared defaults apply (the wizard prompts for both, the non-interactive path uses them directly).</summary>
    internal static (string Location, string Name) ResolveLocationAndName(bool interactive, string? location, string? name,
        Func<string?, (string Location, string Name)> askInteractively)
    {
        if (interactive) return askInteractively(location);
        var resolvedLocation = location ?? ProjectCreationDirectory.DefaultParent();
        return (resolvedLocation, name ?? Core.Naming.ProjectDefaults.Name(Framework.Blazor, Path.GetFullPath(resolvedLocation)));
    }

    private static T Choose<T>(InteractiveConsoleInput input, string label, IReadOnlyList<(string Label, T Value)> choices, CancellationToken token)
    {
        if (choices.Count == 1) { input.WriteResult(label, choices[0].Label); return choices[0].Value; }
        var prompt = new WizardSelectionPrompt<string> { Title = label + ":", PageSize = choices.Count, WrapAround = true };
        prompt.AddChoices(choices.Select(choice => choice.Label));
        InteractivePrompt.ConfigureSelectionPrompt(prompt, choices.Count);
        var selected = input.PromptSingle(prompt, token, label);
        return choices.Single(choice => choice.Label == selected).Value;
    }
    private static BlazorAppType ParseAppType(string? value, out string? error)
    {
        error = null;
        if (value is null || value.Equals("web-app", StringComparison.OrdinalIgnoreCase) || value.Equals("blazor", StringComparison.OrdinalIgnoreCase)) return BlazorAppType.WebApp;
        if (value.Equals("webassembly-standalone", StringComparison.OrdinalIgnoreCase) || value.Equals("wasm", StringComparison.OrdinalIgnoreCase)) return BlazorAppType.WebAssemblyStandalone;
        error = "--app-type must be web-app or webassembly-standalone."; return default;
    }
    private static T ParseEnum<T>(string? value, T fallback, string option, out string? error) where T : struct, Enum
    { error = null; if (value is null) return fallback; if (Enum.TryParse<T>(value.Replace("-", ""), true, out var parsed)) return parsed; error = $"{option} must be one of: {string.Join(", ", Enum.GetNames<T>().Select(name => name.ToLowerInvariant()))}."; return fallback; }
    private static BlazorInteractivity ParseInteractivity(string? value, out string? error)
    { error = null; if (value is null || value.Equals("per-page", StringComparison.OrdinalIgnoreCase) || value.Equals("per-page/component", StringComparison.OrdinalIgnoreCase)) return BlazorInteractivity.PerPage; if (value.Equals("global", StringComparison.OrdinalIgnoreCase)) return BlazorInteractivity.Global; error = "--interactivity must be per-page or global."; return default; }
    private static bool ParseYesNo(string? value, bool fallback, out string? error)
    { error = null; if (value is null) return fallback; if (value.Equals("yes", StringComparison.OrdinalIgnoreCase) || value.Equals("true", StringComparison.OrdinalIgnoreCase)) return true; if (value.Equals("no", StringComparison.OrdinalIgnoreCase) || value.Equals("false", StringComparison.OrdinalIgnoreCase)) return false; error = "--https must be yes or no."; return fallback; }
    private static string AppTypeLabel(BlazorAppType type) => type == BlazorAppType.WebApp ? "Blazor Web App" : "Blazor WebAssembly Standalone";
    private static string InteractivityLabel(BlazorInteractivity value) => value == BlazorInteractivity.Global ? "Global" : "Per page/component";
    private static int Report(ConsolePresenter presenter, GlobalOptions globals, DesktopResult result)
    {
        if (globals.Json)
            presenter.WriteInfo(JsonSerializer.Serialize(result, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));
        else
        {
            if (result.Success) presenter.WriteInfo(result.Message); else presenter.WriteError(result.Message);
            foreach (var error in result.Errors ?? []) presenter.WriteError(error);
            if (result.NextCommands is not null) ProjectNextCommands.Write(presenter, result.NextCommands);
        }
        return result.ExitCode;
    }
}
