using System.CommandLine;
using System.ComponentModel;
using System.Text.Json;
using Syncfusion.DotNet.Cli.Commands.Options;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Core.AI;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Commands;

public static class AiCommands
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true };

    public static Command CreateMcp()
    {
        var root = new Command("mcp", "Configure an official Syncfusion MCP server.");
        var command = new Command("init", "Set up a project-local MCP client configuration.");
        var platform = CommandOptions.OptionalArg("platform", "maui, blazor, wpf, winforms or winui.");
        var client = new Option<string>("--client") { Description = "vscode, cursor, codestudio or claude-code." };
        var keyFile = new Option<string>("--key-file") { Description = "Existing API-key .txt/.key file outside the workspace (not a product license key)." };
        var runner = new Option<string>("--runner") { Description = "auto (SDK 10+: dnx; SDK 8/9: local), dnx or local.", DefaultValueFactory = _ => "auto" };
        command.Add(platform);
        command.Add(client);
        command.Add(keyFile);
        command.Add(runner);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.DryRunOption);
        command.Add(CommandOptions.ForceOption);
        command.SetAction((parse, cancellationToken) => SetupMcpAsync(
            GlobalsHelper.Bind(parse), GlobalsHelper.CreatePresenter(parse), cancellationToken,
            new(parse.GetValue(platform) ?? "", parse.GetValue(client) ?? "",
                parse.GetValue(CommandOptions.PathOption) ?? Directory.GetCurrentDirectory(), parse.GetValue(keyFile) ?? "",
                parse.GetValue(runner) ?? "auto", parse.GetValue(CommandOptions.ForceOption), parse.GetValue(CommandOptions.DryRunOption))));
        root.Add(command);
        return root;
    }

    public static Command CreateSkills()
    {
        var root = new Command("skills", "Install official Syncfusion component skills for AI agents.");
        var command = new Command("install", "Choose and install component skills using the Skills CLI.");
        var platform = CommandOptions.OptionalArg("platform", "maui, blazor, wpf, winforms or winui.");
        var agents = new Option<string[]>("--agent") { Description = "github-copilot, cursor, codestudio or claude-code.",
            Arity = ArgumentArity.OneOrMore, AllowMultipleArgumentsPerToken = true };
        var skills = new Option<string[]>("--skill") { Description = "Exact skill names; discover with --list.",
            Arity = ArgumentArity.OneOrMore, AllowMultipleArgumentsPerToken = true };
        var all = new Option<bool>("--all") { Description = "Install all skills for the selected agents, not all agents." };
        var global = new Option<bool>("--global") { Description = "Install skills in the user's global agent directories." };
        var yes = new Option<bool>("--yes") { Description = "Confirm noninteractive installation." };
        var list = new Option<bool>("--list") { Description = "List repository skill names without installing." };
        command.Add(platform);
        command.Add(agents);
        command.Add(skills);
        command.Add(all);
        command.Add(global);
        command.Add(yes);
        command.Add(list);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.DryRunOption);
        command.SetAction((parse, cancellationToken) => InstallSkillsAsync(
            GlobalsHelper.Bind(parse), GlobalsHelper.CreatePresenter(parse), cancellationToken,
            new(parse.GetValue(platform) ?? "", parse.GetValue(CommandOptions.PathOption) ?? Directory.GetCurrentDirectory(),
                parse.GetValue(agents) ?? [], parse.GetValue(skills) ?? [], parse.GetValue(all), parse.GetValue(global),
                parse.GetValue(yes), parse.GetValue(list), parse.GetValue(CommandOptions.DryRunOption))));
        root.Add(command);
        return root;
    }

    internal static Task<int> SetupMcpAsync(GlobalOptions globals, ConsolePresenter presenter, CancellationToken cancellationToken,
        McpSetupRequest? request = null, ToolRunner? runner = null)
        => ExecuteAsync(globals, presenter, async () =>
        {
            var platform = SelectPlatform(request?.Platform, globals, cancellationToken);
            var workspace = request?.Workspace ?? InteractivePrompt.AskString("Workspace directory:", Directory.GetCurrentDirectory(), cancellationToken, globals.NoColor);
            McpSetupService.WorkspaceDirectory(workspace);
            var client = request?.Client;
            if (string.IsNullOrWhiteSpace(client))
            {
                RequirePrompt(globals, "Specify --client vscode, cursor, codestudio or claude-code.");
                var prompt = new WizardSelectionPrompt<string> { Title = "Which MCP client would you like to configure?", WrapAround = true };
                prompt.AddChoices(AiCatalog.Clients.Select(value => value.DisplayName));
                var label = new InteractiveConsoleInput(globals.NoColor).PromptSingle(prompt, cancellationToken, "Client");
                client = AiCatalog.Clients.Single(value => value.DisplayName == label).Name;
            }
            AiCatalog.Client(client);
            var keyFile = request?.KeyFile;
            if (string.IsNullOrWhiteSpace(keyFile))
            {
                RequirePrompt(globals, "Specify --key-file pointing to an API-key .txt/.key file outside the workspace.");
                presenter.WriteInfo("MCP uses a separate API key, not your product license or sfdotnet login session.");
                presenter.WriteInfo("Get a key: https://www.syncfusion.com/account/api-key. Save it outside your workspace; do not paste it here.");
                keyFile = InteractivePrompt.AskString("API-key file path:", Environment.GetEnvironmentVariable("Syncfusion_API_Key_Path"),
                    cancellationToken, globals.NoColor);
            }
            return await new McpSetupService(runner ?? new ToolRunner()).SetupAsync(
                new(platform, client, workspace, keyFile, request?.Runner ?? "auto", request?.Force ?? false, request?.DryRun ?? false),
                cancellationToken).ConfigureAwait(false);
        }, result =>
        {
            if (result.DryRun)
                presenter.WriteInfo($"MCP setup preview: {result.ConfigurationPath} (runner: {result.Runner}). No files or tools changed.");
            else
                presenter.WriteSuccess($"MCP configuration {(result.Changed == true ? "saved" : "already up to date")}: {result.ConfigurationPath}");
            Console.Out.WriteLine();
            presenter.WriteInfo("Connection not verified. Open/reload the workspace in your client, start the server, and confirm its tools are listed.");
            presenter.WriteInfo("Then ask a Syncfusion documentation question. MCP requires an API key and an active Syncfusion license.");
        });

    internal static Task<int> InstallSkillsAsync(GlobalOptions globals, ConsolePresenter presenter, CancellationToken cancellationToken,
        SkillsInstallRequest? request = null, ToolRunner? runner = null, Func<NodeTools>? locateNode = null)
        => ExecuteAsync(globals, presenter, async () =>
        {
            var platform = SelectPlatform(request?.Platform, globals, cancellationToken);
            var workspace = request?.Workspace ?? InteractivePrompt.AskString("Workspace directory:", Directory.GetCurrentDirectory(), cancellationToken, globals.NoColor);
            var input = (request ?? new(platform, workspace, [], [])) with
            {
                Platform = platform, Workspace = workspace, Interactive = InteractivePrompt.CanPrompt(globals),
            };
            if (input.Interactive && !input.DryRun)
                presenter.WriteInfo("The Skills CLI will let you choose component skills, agents and project/global scope. No API key is required.");
            return await new SkillsInstaller(runner ?? new ToolRunner(), locateNode).InstallAsync(input, cancellationToken).ConfigureAwait(false);
        }, result =>
        {
            if (result.DryRun) presenter.WriteInfo("Planned command: npx " + string.Join(" ", result.Arguments.Select(argument => JsonSerializer.Serialize(argument))));
            else presenter.WriteInfo($"Skills CLI {result.Status}: {result.Repository}");
            presenter.WriteInfo(result.Output);
            if (!string.IsNullOrWhiteSpace(result.Error)) presenter.WriteWarning(result.Error);
        });

    private static string SelectPlatform(string? value, GlobalOptions globals, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            RequirePrompt(globals, "Specify a platform: maui, blazor, wpf, winforms or winui.");
            value = InteractivePrompt.AskFramework(globals.NoColor, cancellationToken);
        }
        return AiCatalog.Platform(value).Name;
    }

    private static void RequirePrompt(GlobalOptions globals, string message)
    {
        if (!InteractivePrompt.CanPrompt(globals)) throw new ArgumentException(message);
    }

    private static async Task<int> ExecuteAsync<T>(GlobalOptions globals, ConsolePresenter presenter, Func<Task<T>> execute, Action<T> write)
    {
        try
        {
            var result = await execute().ConfigureAwait(false);
            if (globals.Json) presenter.WriteInfo(JsonSerializer.Serialize(result, JsonOptions));
            else write(result);
            return ExitCodes.Success;
        }
        catch (OperationCanceledException)
        {
            if (globals.Json) presenter.WriteInfo(JsonSerializer.Serialize(new { success = false, cancelled = true, error = "The operation was canceled." }, JsonOptions));
            else presenter.WriteInfo("The operation was canceled.");
            return ExitCodes.Cancelled;
        }
        catch (Exception exception) when (exception is ArgumentException or InvalidOperationException or IOException or UnauthorizedAccessException or JsonException or Win32Exception)
        {
            var message = exception is JsonException ? "The MCP configuration or tool manifest contains invalid JSON. Correct it before retrying." : exception.Message;
            if (globals.Json) presenter.WriteInfo(JsonSerializer.Serialize(new { success = false, error = message }, JsonOptions));
            presenter.WriteError(message);
            return exception is AiToolException tool ? tool.ExitCode : ExitCodes.Error;
        }
    }
}
