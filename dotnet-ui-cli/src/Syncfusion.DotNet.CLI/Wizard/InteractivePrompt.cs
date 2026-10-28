using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Maui.Manifest;
using Syncfusion.DotNet.CLI.Presentation;

namespace Syncfusion.DotNet.CLI.Wizard;

internal sealed class InteractivePromptCancelledException : Exception
{
}

/// <summary>
/// Interactive prompts for missing required values. Prompts only run when
/// the terminal is interactive and <c>--no-interactive</c> was not supplied.
/// Spectre.Console and line-input prompts receive the command cancellation token.
/// </summary>
internal static class InteractivePrompt
{
    internal const string NewProjectControlChoiceTitle = "Select project setup:";
    internal const string ControlFamilyQuestion = "Which control families would you like to use?";
    internal const string ChartControlQuestion = "Which chart controls would you like to add?";
    internal static readonly IReadOnlyList<string> ProjectTypeChoices =
    [
        ".NET MAUI App",
        // Improvement: .NET MAUI Blazor Hybrid project creation is temporarily disabled.
        // ".NET MAUI Blazor Hybrid",
    ];
    internal const string SingleSelectionGuidance = "↑/↓: navigate | Enter: continue | Esc: cancel | Ctrl+C: exit";
    internal const string MultiSelectionGuidance = "↑/↓/Tab: navigate | Space: toggle | Enter: continue | Esc: cancel | Ctrl+C: exit";
    internal const string TextEntryGuidance = "Enter: continue | Esc: cancel | Ctrl+C: exit";
    internal const string ProjectNameGuidance = TextEntryGuidance;

    /// <summary>True when prompting is allowed for the given global options.</summary>
    public static bool CanPrompt(GlobalOptions options)
    {
        return options.IsInteractiveEffective
            && !options.Json
            && !System.Console.IsInputRedirected
            && AnsiConsole.Profile.Capabilities.Interactive
            && AnsiConsole.Profile.Capabilities.Ansi;
    }

    /// <summary>
    /// Keeps synchronous request builders compatible with Spectre's
    /// cancellation-aware asynchronous prompt API.
    /// </summary>
    internal static T RunPrompt<T>(
        Func<CancellationToken, Task<T>> prompt,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        return prompt(cancellationToken).GetAwaiter().GetResult();
    }

    internal static void WriteCompletedSelection(string label, string value, bool noColor = false)
    {
        ProjectWizardOutput.WriteAutomaticResult(label, value, noColor);
    }

    /// <summary>
    /// Writes the user's answer indented under the question that was
    /// just shown. Used by selection prompts where Spectre's prompt
    /// clears the question and the choices after submission; the answer
    /// is then written on the next line so the user has a visible
    /// record of what they picked. Text inputs do not need this
    /// because the Live display already shows the value.
    /// </summary>
    internal static void WriteAnswer(string answer, bool noColor = false)
    {
        new ConsolePresenter(noColor).WriteAnswerLine("  " + answer, 2);
    }

    /// <summary>
    /// Writes the question for the next prompt above the prompt UI so it
    /// remains visible. Text coloring is intentionally avoided so the
    /// captured shell scrollback stays readable when the output is
    /// piped to a file; the flag is kept for API compatibility.
    /// </summary>
    internal static void WriteQuestion(string question, bool noColor = false)
    {
        _ = noColor;
        if (!string.IsNullOrEmpty(question))
        {
            System.Console.Out.WriteLine(question);
        }
    }

    public static string AskString(
        string prompt,
        string? defaultValue = null,
        CancellationToken cancellationToken = default,
        bool noColor = false)
        => AskString(prompt, defaultValue, new InteractiveConsoleInput(AnsiConsole.Console, noColor), cancellationToken);

    public static string AskProjectName(
        ConsolePresenter presenter,
        CancellationToken cancellationToken = default)
        => AskProjectName(
            presenter,
            new InteractiveConsoleInput(AnsiConsole.Console, presenter.NoColor),
            cancellationToken);

    internal static string AskProjectName(
        ConsolePresenter presenter,
        InteractiveConsoleInput input,
        CancellationToken cancellationToken = default)
    {
        while (true)
        {
            var value = input.ReadLine(
                "What would you like to name the project?",
                defaultValue: null,
                cancellationToken,
                dimSuffix: null);
            if (value is null)
            {
                throw new InteractivePromptCancelledException();
            }

            value = value.Trim();
            var error = NewProjectScaffolder.ValidateProjectName(value);
            if (error is null)
            {
                return value;
            }

            ProjectWizardOutput.WriteError(AnsiConsole.Console, presenter, error);
        }
    }

    internal static string AskString(
        string prompt,
        string? defaultValue,
        InteractiveConsoleInput input,
        CancellationToken cancellationToken = default, bool compactDefault = false)
    {
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var value = input.ReadLine(prompt, defaultValue, cancellationToken, dimSuffix: null, compactDefault: compactDefault);
            if (value is null)
            {
                throw new InteractivePromptCancelledException();
            }

            if (value.Length > 0)
            {
                return value;
            }

            if (defaultValue is not null)
            {
                return defaultValue;
            }
        }
    }

    /// <summary>
    /// Prompts for a platform. Always shows every framework returned by
    /// <see cref="Frameworks.All"/>, with planned frameworks suffixed by
    /// "(planned)" so the user can see which options are not yet
    /// implemented. Returns the canonical lowercase name of the chosen
    /// framework (e.g. <c>maui</c>). Throws
    /// <see cref="InteractivePromptCancelledException"/> on cancel.
    /// </summary>
    public static string AskFramework(bool noColor = false, CancellationToken cancellationToken = default)
    {
        return AskFramework(new InteractiveConsoleInput(noColor), noColor, cancellationToken);
    }

    internal static string AskFramework(InteractiveConsoleInput input, bool noColor = false, CancellationToken cancellationToken = default)
    {
        var choices = BuildFrameworkChoices();
        if (choices.Count == 1)
        {
            cancellationToken.ThrowIfCancellationRequested();
            WriteCompletedSelection("Platform:", choices[0], noColor);
            return ParseFrameworkChoice(choices[0]);
        }
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = "Select a platform:",
            PageSize = choices.Count,
            WrapAround = true,
        };
        prompt.AddChoices(choices);
        ConfigureSelectionPrompt(prompt, choices.Count);
        var label = input.PromptSingle(prompt, cancellationToken, "Platform");
        return ParseFrameworkChoice(label);
    }

    /// <summary>
    /// Prompts for a platform. Returns the chosen <see cref="Framework"/>,
    /// or <see langword="null"/> when the user chose a planned framework so
    /// the caller can route to the planned-notice path. The
    /// <paramref name="plannedLabel"/> receives the human-readable label of
    /// the planned choice so the caller can include it in the planned
    /// message.
    /// </summary>
    public static Framework? TryAskImplementedFramework(
        bool noColor,
        out string? plannedLabel,
        CancellationToken cancellationToken = default)
    {
        _ = noColor;
        var input = new InteractiveConsoleInput(noColor);
        var choices = BuildFrameworkChoices();
        if (choices.Count == 1)
        {
            cancellationToken.ThrowIfCancellationRequested();
            WriteCompletedSelection("Platform:", choices[0], noColor);
            var automatic = ParseFrameworkChoice(choices[0]);
            if (Frameworks.TryParse(automatic, out var implemented) && !Frameworks.IsPlanned(implemented))
            {
                plannedLabel = null;
                return implemented;
            }
            plannedLabel = choices[0];
            return null;
        }
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = "Select a platform:",
            PageSize = choices.Count,
            WrapAround = true,
        };
        prompt.AddChoices(choices);
        ConfigureSelectionPrompt(prompt, choices.Count);
        var label = input.PromptSingle(prompt, cancellationToken, "Platform");
        var canonical = ParseFrameworkChoice(label);
        if (Frameworks.TryParse(canonical, out var framework)
            && !Frameworks.IsPlanned(framework))
        {
            plannedLabel = null;
            return framework;
        }

        plannedLabel = label;
        return null;
    }

    private static IReadOnlyList<string> BuildFrameworkChoices()
    {
        return Frameworks.All.Select(name => name switch { "maui" => ".NET MAUI", "wpf" => "WPF", "winforms" => "WinForms", "winui" => "WinUI", "blazor" => "Blazor", _ => name }).OrderBy(label => label, StringComparer.OrdinalIgnoreCase).ToArray();
    }

    private static string ParseFrameworkChoice(string label)
        => label == ".NET MAUI" ? "maui" : label.Split(' ')[0].ToLowerInvariant();

    internal static string FrameworkLabel(string framework)
        => framework.StartsWith("net", StringComparison.OrdinalIgnoreCase)
            ? $".NET {framework[3..].Split('.')[0]} ({framework})"
            : framework;

    /// <summary>The .NET target frameworks supported by the current MAUI scaffolder.</summary>
    public static readonly IReadOnlyList<string> SupportedTargetFrameworks = ["net10.0", "net9.0"];

    /// <summary>Prompts for a .NET target framework supported by the selected platform.</summary>
    public static string AskTargetFramework(
        IReadOnlyList<string> supportedFrameworks,
        bool noColor = false,
        CancellationToken cancellationToken = default)
    {
        _ = noColor;
        if (supportedFrameworks.Count == 0)
        {
            throw new InvalidOperationException("No target frameworks are available for the selected platform.");
        }

        if (supportedFrameworks.Count == 1)
        {
            cancellationToken.ThrowIfCancellationRequested();
            WriteCompletedSelection("Framework:", FrameworkLabel(supportedFrameworks[0]), noColor);
            return supportedFrameworks[0];
        }

        var input = new InteractiveConsoleInput(noColor);
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = "Select a framework:",
            PageSize = supportedFrameworks.Count,
            WrapAround = true,
        };
        prompt.AddChoices(supportedFrameworks.Select(FrameworkLabel));
        ConfigureSelectionPrompt(prompt, supportedFrameworks.Count);
        var selected = input.PromptSingle(prompt, cancellationToken, "Framework");
        return supportedFrameworks.Single(framework => FrameworkLabel(framework) == selected);
    }

    /// <summary>Prompts for an optional project output path. Empty input accepts the displayed parent.</summary>
    public static string AskOutputPath(
        string defaultParent,
        bool noColor = false,
        CancellationToken cancellationToken = default)
    {
        return AskOutputPath(defaultParent, new InteractiveConsoleInput(noColor), cancellationToken);
    }

    internal static string AskOutputPath(string defaultParent, InteractiveConsoleInput input,
        CancellationToken cancellationToken = default, bool useSuppliedParent = false)
    {
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var value = useSuppliedParent ? defaultParent : input.ReadLine(
                "Project location:", defaultParent, cancellationToken,
                guidance: "Project will be created in <location>/<name>.",
                compactDefault: true, retainAnswer: false);
            if (value is null) throw new InteractivePromptCancelledException();
            try
            {
                var prepared = ProjectCreationDirectory.Prepare(value);
                input.WriteResult("Project location", prepared, alignValues: true);
                return prepared;
            }
            catch (Exception ex) when (ex is ArgumentException or NotSupportedException or IOException or UnauthorizedAccessException)
            {
                ProjectWizardOutput.WriteAutomaticResult($"Warning: Project location cannot be used: {ex.Message}");
                useSuppliedParent = false;
            }
        }
    }

    /// <summary>The post-creation actions offered by the project creation flow.</summary>
    public enum PostCreationAction
    {
        /// <summary>Generate the project without building or running it.</summary>
        None,

        /// <summary>Generate the project and run <c>dotnet build</c> afterwards.</summary>
        Build,

        /// <summary>Reserved for a future "Run" action that is not yet implemented.</summary>
        Run,
    }

    /// <summary>Prompts for the post-creation action. Run is reported as deferred when it is not yet supported.</summary>
    public static PostCreationAction AskPostCreationAction(
        bool runSupported,
        bool noColor = false,
        CancellationToken cancellationToken = default, bool generateRequiresRestore = false, string? buildSummary = null)
    {
        return AskPostCreationAction(runSupported, new InteractiveConsoleInput(noColor), cancellationToken, generateRequiresRestore, buildSummary);
    }

    internal static PostCreationAction AskPostCreationAction(
        bool runSupported, InteractiveConsoleInput input, CancellationToken cancellationToken = default, bool generateRequiresRestore = false, string? buildSummary = null)
    {
        var options = PostCreationActionOptions(runSupported);
        var count = options.Count;
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = "Post-create:",
            PageSize = count,
            WrapAround = true,
        };
        prompt.AddChoices(options);
        ConfigureSelectionPrompt(prompt, count);
        var optionWidth = options.Max(option => option.Length);
        prompt.Converter = option => option switch
        {
            "Generate only" => option.PadRight(optionWidth) + (generateRequiresRestore ? "   (create files, restore required packages, skip build)" : "   (create files, skip build)"),
            "Build project" => option.PadRight(optionWidth) + "   (create files, then restore and build)",
            _ => option,
        };
        var selected = input.PromptSingle(prompt, cancellationToken, "Post-create", resultFormatter: option => option == "Generate only" && generateRequiresRestore ? "Generate only (restore required for selected setup)" : option == "Build project" && buildSummary is not null ? $"Build project ({buildSummary})" : option);
        return selected switch
        {
            "Build project" => PostCreationAction.Build,
            "Run" => PostCreationAction.Run,
            _ => PostCreationAction.None,
        };
    }

    /// <summary>The label list offered by <see cref="AskPostCreationAction"/> for the given support state.</summary>
    public static IReadOnlyList<string> PostCreationActionOptions(bool runSupported)
        => runSupported
            ? (IReadOnlyList<string>)["Generate only", "Build project", "Run"]
            : ["Generate only", "Build project"];

    /// <summary>Prompts for the project name using the platform-specific default when input is empty.</summary>
    public static string AskProjectNameWithDefault(
        ConsolePresenter presenter,
        string defaultName,
        bool noColor = false,
        CancellationToken cancellationToken = default)
    {
        return AskProjectNameSelection(presenter, defaultName,
            new InteractiveConsoleInput(presenter.NoColor), cancellationToken).Name;
    }

    internal static (string Name, bool UsedDefault) AskProjectNameSelection(
        ConsolePresenter presenter, string defaultName, InteractiveConsoleInput input,
        CancellationToken cancellationToken = default, Func<string, string?>? validateDestination = null)
    {
        string? conflict = null;
        while (true)
        {
            var value = input.ReadLine(conflict ?? "Project name:", conflict is null ? defaultName : null,
                cancellationToken, compactDefault: true, resultLabel: "Project name", retainAnswer: false);
            if (value is null) { throw new InteractivePromptCancelledException(); }
            var name = value.Trim();
            conflict = null;
            var error = NewProjectScaffolder.ValidateProjectName(name);
            if (error is null)
            {
                conflict = validateDestination?.Invoke(name);
                if (conflict is not null) continue;
            }
            if (error is null) { input.WriteResult("Project name", name, alignValues: true); return (name, input.LastUsedDefault); }
            ProjectWizardOutput.WriteError(AnsiConsole.Console, presenter, error);
        }
    }

    public static string AskListCategory(CancellationToken cancellationToken = default)
    {
        var input = new InteractiveConsoleInput();
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = "What would you like to list?",
            PageSize = 4,
            WrapAround = true,
        };
        prompt.AddChoices(["Available packages", "Installed packages"]);
        ConfigureSelectionPrompt(prompt, 2);
        return input.PromptSingle(prompt, cancellationToken, "List") switch
        {
            "Available packages" => "packages",
            "Installed packages" => "installed",
            _ => throw new InvalidOperationException("The selected list category is not available."),
        };
    }

    public static bool AskTemplateOperation(
        string operation = "add",
        CancellationToken cancellationToken = default)
    {
        var action = operation.Equals("remove", StringComparison.OrdinalIgnoreCase) ? "remove" : "add";
        var input = new InteractiveConsoleInput();
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = $"What would you like to {action}?",
            PageSize = 2,
            WrapAround = true,
        };
        prompt.AddChoices(["Package", "Control"]);
        ConfigureSelectionPrompt(prompt, 2);
        return string.Equals(
            input.PromptSingle(prompt, cancellationToken, "Operation"),
            "Control",
            StringComparison.Ordinal);
    }

    public static string AskPackage(
        IReadOnlyList<MauiPackageDefinition> packages,
        CancellationToken cancellationToken = default)
    {
        if (packages.Count == 0)
        {
            throw new InvalidOperationException("No recommended packages are available for interactive selection.");
        }

        var choices = packages.OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase)
            .Select(package => new PackageSelectionItem(package.Alias, package.DisplayName)).ToArray();
        return new InteractiveConsoleInput().SelectPackage(choices, cancellationToken, retainAnswer: true);
    }

    public static string AskInstalledPackage(
        string title,
        IReadOnlyList<DiscoveryService.InstalledPackage> installedPackages,
        CancellationToken cancellationToken = default)
    {
        if (installedPackages.Count == 0)
        {
            throw new InvalidOperationException("No installed packages are available for interactive selection.");
        }

        var options = installedPackages
            .Select(package =>
            {
                var alias = package.Alias ?? package.PackageId;
                var version = package.Version ?? "not specified";
                return (Label: $"{alias} (version: {version})", Alias: alias);
            })
            .OrderBy(package => package.Label, StringComparer.OrdinalIgnoreCase)
            .ToList();
        var input = new InteractiveConsoleInput();
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = title.EndsWith("?", StringComparison.Ordinal) ? title : $"{title}?",
            PageSize = Math.Min(options.Count, 12),
            WrapAround = true,
        };
        prompt.AddChoices(options.Select(option => option.Label));
        ConfigureSelectionPrompt(prompt, options.Count);
        var selected = input.PromptSingle(prompt, cancellationToken, "Package");
        return options.Single(option => option.Label == selected).Alias;
    }

    public static ProjectDetector.ProjectInfo SelectMauiProject(
        IReadOnlyList<ProjectDetector.ProjectInfo> projects,
        CancellationToken cancellationToken = default, bool retainSelection = true)
    {
        var options = projects
            .OrderBy(project => Path.GetRelativePath(Environment.CurrentDirectory, project.CsprojPath), StringComparer.OrdinalIgnoreCase)
            .ThenBy(project => Path.GetRelativePath(Environment.CurrentDirectory, project.CsprojPath), StringComparer.Ordinal)
            .Select(project => (
                Project: project,
                Label: Path.GetRelativePath(Environment.CurrentDirectory, project.CsprojPath)))
            .ToList();
        var input = new InteractiveConsoleInput();
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = MauiPackageAddPresentationProvider.ProjectSelectionTitle,
            PageSize = Math.Min(options.Count, 12),
            WrapAround = true,
        };
        prompt.AddChoices(options.Select(option => option.Label));
        ConfigureSelectionPrompt(prompt, options.Count);
        var selected = input.PromptSingle(prompt, cancellationToken, "Project", retainAnswer: retainSelection);
        return options.Single(option => string.Equals(option.Label, selected, StringComparison.Ordinal)).Project;
    }

    internal static bool AskPostAdd(bool build, bool noColor, CancellationToken cancellationToken)
    {
        var choices = new[] { "Restore only", "Restore and build" };
        var prompt = new WizardSelectionPrompt<string> { Title = "Post-add:", PageSize = choices.Length };
        prompt.AddChoices(build ? choices.Reverse() : choices);
        ConfigureSelectionPrompt(prompt, choices.Length);
        var selected = new InteractiveConsoleInput(noColor).PromptSingle(prompt, cancellationToken,
            "Post-add", retainAnswer: true);
        return selected == "Restore and build";
    }

    public static bool Confirm(
        string prompt,
        bool defaultValue = true,
        CancellationToken cancellationToken = default,
        bool noColor = false,
        bool retainAnswer = true)
        => Confirm(prompt, defaultValue, new InteractiveConsoleInput(noColor), cancellationToken, retainAnswer);

    internal static bool Confirm(
        string prompt,
        bool defaultValue,
        InteractiveConsoleInput input,
        CancellationToken cancellationToken = default,
        bool retainAnswer = true)
    {
        _ = prompt;
        _ = defaultValue;
        var defaultText = defaultValue ? "y" : "n";
        var choices = defaultValue ? "[Y/n]" : "[y/N]";
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var value = input.ReadLine(
                prompt,
                defaultText,
                cancellationToken,
                dimSuffix: $" {choices}:", retainAnswer: false);
            if (value is null)
            {
                throw new InteractivePromptCancelledException();
            }

            if (value.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                if (retainAnswer) input.WriteResult(prompt.TrimEnd('?', ':'), "y");
                return true;
            }

            if (value.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                if (retainAnswer) input.WriteResult(prompt.TrimEnd('?', ':'), "n");
                return false;
            }

            if (value.Equals(defaultText, StringComparison.OrdinalIgnoreCase))
            {
                return defaultValue;
            }
        }
    }

    /// <summary>Records the sole MAUI template automatically, or prompts when multiple templates are enabled.</summary>
    public static string AskProjectType(bool noColor = false, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        if (ProjectTypeChoices.Count == 1)
        {
            WriteCompletedSelection("Template:", ProjectTypeChoices[0], noColor);
            return ProjectTypeChoices[0];
        }
        var input = new InteractiveConsoleInput(noColor);
        var prompt = new WizardSelectionPrompt<string>
        {
            Title = "Select a project template:",
            PageSize = ProjectTypeChoices.Count,
            WrapAround = true,
        };
        prompt.AddChoices(ProjectTypeChoices);
        ConfigureSelectionPrompt(prompt, ProjectTypeChoices.Count);
        return input.PromptSingle(prompt, cancellationToken, "Template");
    }

    /// <summary>
    /// Prompts for a control family and, when needed, its concrete control.
    /// </summary>
    public static string AskTemplate(CancellationToken cancellationToken = default)
        => AskTemplates(cancellationToken).First();

    public static IReadOnlyList<string> AskTemplates(CancellationToken cancellationToken = default, bool noColor = false)
    {
        _ = noColor;
        return AskTemplates(TemplateCatalog.Operable, cancellationToken);
    }

    private static IReadOnlyList<string> AskTemplates(
        IReadOnlyList<ControlCatalogEntry> availableTemplates,
        CancellationToken cancellationToken)
    {
        var input = new InteractiveConsoleInput();
        var families = availableTemplates
            .GroupBy(template => template.Family, StringComparer.OrdinalIgnoreCase)
            .OrderBy(group => group.Key, StringComparer.OrdinalIgnoreCase)
            .ToList();
        if (families.Count == 0)
        {
            throw new InvalidOperationException("No verified control families are available.");
        }

        var familyOptions = families
            .Select(group => (Family: group.Key, Label: GetTemplateFamilyDisplayName(group.Key)))
            .ToList();
        var familyPrompt = new MultiSelectionPrompt<string>
        {
            Title = ControlFamilyQuestion,
            PageSize = Math.Min(familyOptions.Count, 12),
            Required = true,
        };
        ConfigureMultiSelectionPrompt(familyPrompt);
        familyPrompt.AddChoices(familyOptions.Select(option => option.Label));
        var selectedFamilyLabels = input.PromptMultiple(familyPrompt, cancellationToken, "Control families");
        if (selectedFamilyLabels.Count == 0)
        {
            throw new InvalidOperationException("Select at least one control family.");
        }

        var selections = new List<string>();
        foreach (var selectedFamilyLabel in selectedFamilyLabels)
        {
            var selectedFamily = familyOptions.Single(option => option.Label == selectedFamilyLabel).Family;
            var templates = availableTemplates
                .Where(template => template.Family.Equals(selectedFamily, StringComparison.OrdinalIgnoreCase))
                .OrderBy(template => template.DisplayName, StringComparer.OrdinalIgnoreCase)
                .ToList();
            if (templates.Count == 1)
            {
                input.WriteResult("Controls", templates[0].DisplayName);
                selections.Add(templates[0].Id);
                continue;
            }

            var templateOptions = templates
                .Select(template => (Label: template.DisplayName, template.Id))
                .ToList();
            var templatePrompt = new MultiSelectionPrompt<string>
            {
                Title = GetFamilyTemplateQuestion(selectedFamily),
                PageSize = Math.Min(templates.Count, 12),
                Required = true,
            };
            ConfigureMultiSelectionPrompt(templatePrompt);
            templatePrompt.AddChoices(templateOptions.Select(option => option.Label));
            var selectedTemplates = input.PromptMultiple(templatePrompt, cancellationToken);
            if (selectedTemplates.Count == 0)
            {
                throw new InvalidOperationException(
                    $"Select at least one {GetTemplateFamilyDisplayName(selectedFamily)} control.");
            }

            selections.AddRange(selectedTemplates.Select(label =>
                templateOptions.Single(option => option.Label == label).Id));
        }

        return selections;
    }

    public static IReadOnlyList<string> AskNewProjectTemplates(
        MauiProjectType projectType,
        bool noColor = false,
        CancellationToken cancellationToken = default)
    {
        _ = noColor;
        var input = new InteractiveConsoleInput(noColor);
        var availableTemplates = new MauiControlSelectionProvider(projectType).Controls;

        if (!AskProjectSetup(input, cancellationToken)) return ["empty"];

        if (availableTemplates.Count == 0)
        {
            throw new InvalidOperationException("No verified controls are available for selection.");
        }

        return input.SelectControls(availableTemplates, cancellationToken);
    }

    internal static bool AskProjectSetup(InteractiveConsoleInput input, CancellationToken cancellationToken = default,
        string emptyLabel = "Blank app", string controlsLabel = "Include Syncfusion controls", bool controlsFirst = false)
    {
        var prompt = new WizardSelectionPrompt<string> { Title = NewProjectControlChoiceTitle, PageSize = 2, WrapAround = true };
        prompt.AddChoices(controlsFirst ? [controlsLabel, emptyLabel] : [emptyLabel, controlsLabel]);
        ConfigureSelectionPrompt(prompt, 2);
        return input.PromptSingle(prompt, cancellationToken, "Setup") == controlsLabel;
    }

    internal const string OtherPackagesId = "other-packages";
    internal const string AddControlSelectionGuidance = "↑/↓/Tab: navigate | Space: select | Enter: continue | Esc: cancel | Ctrl+C: exit";

    internal static IReadOnlyList<string> AskAddControls(IControlSelectionProvider provider, bool noColor,
        CancellationToken cancellationToken, InteractiveConsoleInput? input = null)
    {
        var choices = provider.Controls.Append(new ControlSelectionItem(OtherPackagesId, "Other packages...", OtherPackages: true)).ToArray();
        return (input ?? new InteractiveConsoleInput(noColor)).SelectControls(choices, cancellationToken,
            "Which controls would you like to add?", AddControlSelectionGuidance, retainAnswer: true);
    }

    internal static IReadOnlyList<string> AskOtherPackages(IControlSelectionProvider provider, bool noColor, CancellationToken cancellationToken)
    {
        return new InteractiveConsoleInput(noColor).SelectPackages(provider.Packages, cancellationToken);
    }

    public static IReadOnlyList<string> AskInstalledTemplates(
        IReadOnlyList<InstalledTemplateRecord> templates,
        CancellationToken cancellationToken = default)
    {
        if (templates.Count == 0)
        {
            throw new InvalidOperationException("No installed controls are available for selection.");
        }

        var input = new InteractiveConsoleInput();
        var options = templates
            .Select(template =>
            {
                var displayName = TemplateCatalog.TryResolveOperableTemplate(template.Id, out var entry)
                    ? entry.DisplayName
                    : LegacyUnsupportedTemplateCatalog.TryResolve(template.Id, out var legacyDisplayName)
                        ? $"{legacyDisplayName} (unsupported legacy control)"
                        : template.Id;
                return (Label: displayName, template.Id);
            })
            .OrderBy(option => option.Label, StringComparer.OrdinalIgnoreCase)
            .ToList();
        var prompt = new MultiSelectionPrompt<string>
        {
            Title = "Which installed controls would you like to remove?",
            PageSize = Math.Min(options.Count, 12),
            Required = true,
        };
        ConfigureMultiSelectionPrompt(prompt);
        prompt.AddChoices(options.Select(option => option.Label));
        var selected = input.PromptMultiple(prompt, cancellationToken);
        if (selected.Count == 0)
        {
            throw new InvalidOperationException("Select at least one installed control.");
        }

        return selected.Select(label => options.Single(option => option.Label == label).Id).ToList();
    }

    private static string GetTemplateFamilyDisplayName(string family)
        => MauiControlSelectionProvider.GetTemplateFamilyDisplayName(family);

    private static string GetFamilyTemplateQuestion(string family)
        => family.Equals("charts", StringComparison.OrdinalIgnoreCase)
            ? ChartControlQuestion
            : $"Which {GetTemplateFamilyDisplayName(family)} controls would you like to add?";

    internal static readonly Style SelectionStyle = PresentationStyles.Selection;

    internal static void ConfigureSelectionPrompt<T>(WizardSelectionPrompt<T> prompt, int choiceCount)
        where T : notnull
    {
        // Show every choice by default. The caller can still override
        // PageSize before calling this method to opt into a smaller
        // scrollable window; here we default to the full count so short
        // lists are visible without needing to scroll.
        if (prompt.PageSize <= 0 || prompt.PageSize > choiceCount)
        {
            prompt.PageSize = Math.Max(1, choiceCount);
        }
        prompt.MoreChoicesText = SingleSelectionGuidance;
        prompt.HighlightStyle = SelectionStyle;
        prompt.CancelResult = () => throw new InteractivePromptCancelledException();
    }

    internal static void ConfigureMultiSelectionPrompt<T>(MultiSelectionPrompt<T> prompt)
        where T : notnull
    {
        prompt.InstructionsText = MultiSelectionGuidance;
        prompt.HighlightStyle = SelectionStyle;
        prompt.CancelResult = () => throw new InteractivePromptCancelledException();
    }

}
