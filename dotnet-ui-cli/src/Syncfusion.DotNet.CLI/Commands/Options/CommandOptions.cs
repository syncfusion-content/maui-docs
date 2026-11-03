using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Presentation;

namespace Syncfusion.DotNet.Cli.Commands.Options;

/// <summary>
/// The command-specific options shared across the Syncfusion .NET CLI
/// commands. Declared once here so command definitions stay readable and
/// validation stays in one place.
/// </summary>
public static class CommandOptions
{
    public static Option<string> LanguageOption { get; } = CreateString("--language", null, "Desktop project language: C# or VB (WinUI: C# only).");
    public static Option<string> ThemeOption { get; } = CreateString("--theme", null, "Desktop theme supported by the selected platform.");

    public static Option<string> NameOption { get; } = CreateString("--name", ["-n"], "Project name.");

    public static Option<string> PathOption { get; } = CreateString("--path", ["-p"], "Output directory (new) or project directory/csproj path (existing projects). Defaults to the current directory.");

    public static Option<string> TargetFrameworkOption { get; } = CreateString("--target-framework", ["-t"], "The .NET target framework, such as net10.0.");
    public static Option<string> BuildFrameworkOption { get; } = CreateString("--build-framework", null, "Build only this configured project target, such as net10.0-android. Defaults to all configured targets.");

    public static Option<string> VersionOption { get; } = CreateString("--version", ["-v"], "The Syncfusion NuGet package version for package operations or a new project.");

    public static Option<string> FrameworkOption { get; } = CreateString("--framework", ["-f"], "Alternative to the positional framework argument.");

    public static Option<string[]> ControlOption { get; } = CreateStringArray(
        "--control",
        "One or more available Syncfusion control IDs.");

    public static Option<string[]> TemplateOption { get; } = CreateTemplateOption();

    public static Option<bool> InstalledOption { get; } = CreateHiddenBool("--installed", "List installed items.");

    public static Option<string> ProjectTypeOption { get; } = CreateString("--project-type", null, "MAUI project type: app.");
    public static Option<string> AppTypeOption { get; } = CreateString("--app-type", null, "Blazor application type: web-app or webassembly-standalone.");
    public static Option<string> RenderModeOption { get; } = CreateString("--render-mode", null, "Blazor render mode: server, webassembly or auto.");
    public static Option<string> InteractivityOption { get; } = CreateString("--interactivity", null, "Blazor interactivity location: per-page or global.");
    public static Option<string> AuthOption { get; } = CreateString("--auth", null, "Blazor authentication: none or individual.");
    public static Option<string> HttpsOption { get; } = CreateString("--https", null, "Configure HTTPS: yes or no.");

    public static Option<string> SourceOption { get; } = CreateString("--source", null, "Package source; Syncfusion packages require https://api.nuget.org/v3/index.json.");

    public static Option<string> ConfigFileOption { get; } = CreateString("--configfile", null, "The NuGet configuration file to use.");

    public static Option<bool> DryRunOption { get; } = CreateBool("--dry-run", "Preview the action without making changes.");

    public static Option<bool> ForceOption { get; } = CreateBool("--force", "Allow supported overwrites. Edited control samples remain protected.");

    public static Option<string> PostActionOption { get; } = CreateString("--post-action", null, "Post-create: generate or build. Defaults to build for direct commands.");

    public static Option<bool> NoRestoreOption { get; } = CreateBool("--no-restore", "Skip dotnet restore after the action.");

    public static Option<bool> NoBuildOption { get; } = CreateBool("--no-build", "Skip dotnet build after the action.");
    public static Option<bool> BuildOption { get; } = CreateBool("--build", "Build the changed project before committing the operation.");

    private static Option<string> CreateString(string name, string[]? aliases, string description)
    {
        var option = aliases is null || aliases.Length == 0
            ? new Option<string>(name)
            : new Option<string>(name, aliases);
        option.Description = description;
        if (name == "--source") option.Validators.Add(result =>
        {
            try { NuGetSources.ResolveSource(result.GetValueOrDefault<string>()); }
            catch (ArgumentException exception) { result.AddError(exception.Message); }
        });
        return option;
    }

    private static Option<bool> CreateBool(string name, string description)
    {
        var option = new Option<bool>(name);
        option.Description = description;
        return option;
    }

    private static Option<bool> CreateHiddenBool(string name, string description)
    {
        var option = CreateBool(name, description);
        option.Hidden = true;
        return option;
    }

    private static Option<string[]> CreateTemplateOption()
    {
        var option = new Option<string[]>("--template")
        {
            Arity = ArgumentArity.ZeroOrMore,
            AllowMultipleArgumentsPerToken = true,
            Hidden = true,
        };
        option.Description = "Compatibility alias for --control.";
        return option;
    }

    private static Option<string[]> CreateStringArray(string name, string description)
    {
        var option = new Option<string[]>(name)
        {
            Arity = ArgumentArity.ZeroOrMore,
            AllowMultipleArgumentsPerToken = true,
        };
        option.Description = description;
        return option;
    }

    public static IReadOnlyList<string> GetTemplateValues(ParseResult parseResult)
        => (parseResult.GetValue(TemplateOption) ?? []).Concat(parseResult.GetValue(ControlOption) ?? []).ToArray();

    /// <summary>Creates an optional string argument with a description.</summary>
    public static Argument<string?> OptionalArg(string name, string description)
    {
        var arg = new Argument<string?>(name);
        arg.Description = description;
        // Without an explicit default the parser treats nullable arguments as
        // required; a null default makes them genuinely optional.
        arg.DefaultValueFactory = _ => null;
        return arg;
    }
}

/// <summary>
/// Reads the global options from a <see cref="ParseResult"/> by name, for use
/// in command actions. Kept here so each command does not duplicate the binding.
/// </summary>
internal static class GlobalsHelper
{
    public static GlobalOptions Bind(ParseResult parseResult)
        => new()
        {
            Interactive = parseResult.GetValue<bool>("--interactive") || !parseResult.GetValue<bool>("--no-interactive"),
            NoInteractive = parseResult.GetValue<bool>("--no-interactive"),
            Json = parseResult.GetValue<bool>("--json"),
            Verbose = parseResult.GetValue<bool>("--verbose"),
            NoColor = parseResult.GetValue<bool>("--no-color"),
        };

    /// <summary>
    /// Builds a <see cref="ConsolePresenter"/> honoring <c>--no-color</c> and
    /// <c>--verbose</c>. Centralizes presenter construction so every command
    /// respects the global flags uniformly.
    /// </summary>
    public static ConsolePresenter CreatePresenter(ParseResult parseResult)
        => new(
            parseResult.GetValue<bool>("--no-color"),
            parseResult.GetValue<bool>("--verbose"),
            json: parseResult.GetValue<bool>("--json"));
}
