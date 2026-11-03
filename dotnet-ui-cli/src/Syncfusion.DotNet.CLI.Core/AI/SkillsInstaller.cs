namespace Syncfusion.DotNet.Cli.Core.AI;

public sealed record SkillsInstallRequest(string Platform, string Workspace, IReadOnlyList<string> Agents,
    IReadOnlyList<string> Skills, bool All = false, bool Global = false, bool Yes = false,
    bool List = false, bool DryRun = false, bool Interactive = false);

public sealed record SkillsInstallResult(string Platform, string Repository, IReadOnlyList<string> Arguments,
    bool DryRun, string Status, string Output, string Error);

public sealed record NodeTools(string Node, string NpxScript)
{
    public static NodeTools Locate()
    {
        var paths = (Environment.GetEnvironmentVariable("PATH") ?? "").Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries)
            .Select(path => path.Trim('"')).Where(Directory.Exists).ToArray();
        var node = paths.Select(path => Path.Combine(path, OperatingSystem.IsWindows() ? "node.exe" : "node")).FirstOrDefault(File.Exists)
            ?? throw new InvalidOperationException("Install Node.js 22.20 or later with npm, then restart your terminal.");
        foreach (var directory in paths.Prepend(Path.GetDirectoryName(node)!))
        {
            var script = Path.Combine(directory, "node_modules", "npm", "bin", "npx-cli.js");
            if (File.Exists(script)) return new(node, script);
            var npx = Path.Combine(directory, "npx");
            if (File.Exists(npx))
            {
                var target = File.ResolveLinkTarget(npx, returnFinalTarget: true);
                if (target is not null && target.FullName.EndsWith(".js", StringComparison.Ordinal))
                    return new(node, target.FullName);
            }
        }
        throw new InvalidOperationException("Cannot locate npm's npx-cli.js. Install npm alongside Node.js and add it to PATH.");
    }
}

/// <summary>Runs the official Skills CLI without shell quoting or inherited telemetry settings.</summary>
public sealed class SkillsInstaller(ToolRunner runner, Func<NodeTools>? locateNode = null)
{
    public const string SkillsPackage = "skills@1.7.4";
    private static readonly IReadOnlyDictionary<string, string> ChildEnvironment = new Dictionary<string, string>
    {
        ["DISABLE_TELEMETRY"] = "1", ["DO_NOT_TRACK"] = "1",
    };

    public static IReadOnlyList<string> BuildArguments(SkillsInstallRequest request)
    {
        var platform = AiCatalog.Platform(request.Platform);
        McpSetupService.WorkspaceDirectory(request.Workspace);
        if (request.All && request.Skills.Count > 0) throw new ArgumentException("Use --all or --skill, not both.");
        foreach (var agent in request.Agents)
            if (!AiCatalog.Clients.Any(client => client.Agent == agent))
                throw new ArgumentException("Choose an agent: github-copilot, cursor, codestudio or claude-code.");
        foreach (var skill in request.Skills)
            if (string.IsNullOrWhiteSpace(skill) || skill.StartsWith('-') || skill.Any(char.IsControl))
                throw new ArgumentException("Each --skill must be a nonempty exact skill name, not an option.");
        if (!request.Interactive && !request.List && (request.Agents.Count == 0 || (!request.All && request.Skills.Count == 0) || !request.Yes))
            throw new ArgumentException("Noninteractive installation requires --agent, --skill (or --all), and --yes. Use --list to discover skill names.");
        var args = new List<string> { "--yes", SkillsPackage, "add", platform.SkillsRepository };
        if (request.List) args.Add("--list");
        if (request.Agents.Count > 0) { args.Add("--agent"); args.AddRange(request.Agents); }
        if (request.All) args.AddRange(["--skill", "*"]);
        else if (request.Skills.Count > 0) { args.Add("--skill"); args.AddRange(request.Skills); }
        if (request.Global) args.Add("--global");
        if (request.Yes) args.Add("--yes");
        args.Add("--copy");
        return args;
    }

    public async Task<SkillsInstallResult> InstallAsync(SkillsInstallRequest request, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var args = BuildArguments(request);
        var platform = AiCatalog.Platform(request.Platform);
        if (request.DryRun) return new(platform.Name, platform.SkillsRepository, args, true, "planned", "", "");
        var tools = (locateNode ?? NodeTools.Locate)();
        var version = await runner.RunAsync(["--version"], request.Workspace, cancellationToken, tools.Node).ConfigureAwait(false);
        McpSetupService.EnsureSuccess("Reading Node.js version", version);
        if (!Version.TryParse(version.Output.Trim().TrimStart('v'), out var nodeVersion) || nodeVersion < new Version(22, 20, 0))
            throw new InvalidOperationException($"{SkillsPackage} requires Node.js 22.20 or later.");
        // npm's .cmd shim is not a native executable on Windows. Run its JS entry point through node.
        var result = await runner.RunProcessAsync([tools.NpxScript, .. args], Path.GetFullPath(request.Workspace),
            cancellationToken, tools.Node, inheritConsole: request.Interactive, environment: ChildEnvironment).ConfigureAwait(false);
        McpSetupService.EnsureSuccess("Skills CLI", result);
        return new(platform.Name, platform.SkillsRepository, args, false, request.List ? "listed" : "completed", result.Output, result.Error);
    }
}
