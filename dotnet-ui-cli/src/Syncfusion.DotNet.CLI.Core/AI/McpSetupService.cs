using System.Text;
using System.Text.Json;

namespace Syncfusion.DotNet.Cli.Core.AI;

public sealed record McpSetupRequest(string Platform, string Client, string Workspace, string KeyFile,
    string Runner = "auto", bool Force = false, bool DryRun = false);

public sealed record McpSetupResult(string Platform, string Client, string Package, string ConfigurationPath,
    string Runner, bool DryRun, bool? Changed, bool ConnectionVerified = false);

public sealed class AiToolException(string operation, ToolResult result)
    : InvalidOperationException($"{operation} failed (exit {result.ExitCode}). {result.Error}".Trim())
{
    public int ExitCode => result.ExitCode;
}

public sealed class McpSetupService(ToolRunner runner)
{
    public async Task<McpSetupResult> SetupAsync(McpSetupRequest request, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var platform = AiCatalog.Platform(request.Platform);
        var client = AiCatalog.Client(request.Client);
        var workspace = WorkspaceDirectory(request.Workspace);
        var keyFile = ValidateKeyFile(workspace, request.KeyFile);
        var mode = request.Runner.ToLowerInvariant();
        if (mode is not ("auto" or "dnx" or "local"))
            throw new ArgumentException("Choose --runner auto, dnx or local.");
        var path = Path.Combine(workspace, client.ConfigDirectory, client.ConfigFile);
        RejectLinkedTarget(workspace, path);
        var original = File.Exists(path) ? File.ReadAllText(path) : null;
        // Validate JSONC and conflicts before installing anything. Auto is resolved only on execution.
        var preview = McpConfiguration.Merge(original ?? "{}", client, platform.ServerName,
            McpConfiguration.Server(platform, client, keyFile, mode == "local"), request.Force || mode == "auto");
        if (request.DryRun)
            return new(platform.Name, client.Name, platform.McpPackage, path, mode, true,
                mode == "auto" ? null : preview.Changed);

        var sdkResult = await runner.RunAsync(["--version"], workspace, cancellationToken).ConfigureAwait(false);
        EnsureSuccess("Reading the selected .NET SDK", sdkResult);
        var versionText = sdkResult.Output.Trim().Split('-')[0];
        if (!Version.TryParse(versionText, out var sdk) || sdk.Major < 8)
            throw new InvalidOperationException("MCP setup requires a .NET SDK 8 or later selected in this workspace.");
        if (mode == "auto") mode = sdk.Major >= 10 ? "dnx" : "local";
        if (mode == "dnx" && sdk.Major < 10)
            throw new InvalidOperationException("The dnx runner requires .NET SDK 10 or later. Use --runner local on SDK 8/9.");
        var change = McpConfiguration.Merge(original ?? "{}", client, platform.ServerName,
            McpConfiguration.Server(platform, client, keyFile, mode == "local"), request.Force);
        if (mode == "local")
            await InstallLocalToolAsync(workspace, platform, cancellationToken).ConfigureAwait(false);
        cancellationToken.ThrowIfCancellationRequested();
        if (change.Changed) WriteConfiguration(workspace, path, original, change.Content);
        return new(platform.Name, client.Name, platform.McpPackage, path, mode, false, change.Changed);
    }

    public static string WorkspaceDirectory(string value)
    {
        var path = Path.GetFullPath(value);
        if (!Directory.Exists(path)) throw new ArgumentException("The --path workspace directory must already exist.");
        if (IsSystemDirectory(path))
            throw new ArgumentException($"'{path}' is a system folder, not a project workspace. Run from your project folder or pass --path <project folder>.");
        return path;
    }

    private static bool IsSystemDirectory(string path)
    {
        var comparison = OperatingSystem.IsWindows() ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
        var trimmed = Path.TrimEndingDirectorySeparator(path);
        if (Path.GetPathRoot(path) is { } root && string.Equals(Path.TrimEndingDirectorySeparator(root), trimmed, comparison))
            return true;
        string[] protectedRoots = OperatingSystem.IsWindows()
            ? [Environment.GetFolderPath(Environment.SpecialFolder.Windows), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
               Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)]
            : ["/bin", "/sbin", "/usr", "/etc", "/System", "/Library"];
        return protectedRoots.Where(value => !string.IsNullOrEmpty(value)).Select(Path.TrimEndingDirectorySeparator).Any(value =>
            string.Equals(trimmed, value, comparison) || trimmed.StartsWith(value + Path.DirectorySeparatorChar, comparison));
    }

    private static string ValidateKeyFile(string workspace, string value)
    {
        var path = Path.GetFullPath(value);
        if (!File.Exists(path) || Path.GetExtension(path).ToLowerInvariant() is not (".txt" or ".key"))
            throw new ArgumentException("--key-file must reference an existing .txt or .key file containing your MCP API key.");
        var relative = Path.GetRelativePath(workspace, path);
        if (relative != ".." && !relative.StartsWith(".." + Path.DirectorySeparatorChar, StringComparison.Ordinal) && !Path.IsPathRooted(relative))
            throw new ArgumentException("Keep the API-key file outside the workspace to avoid committing credentials.");
        if ((File.GetAttributes(path) & FileAttributes.ReparsePoint) != 0)
            throw new ArgumentException("Use the real API-key file path, not a symbolic link.");
        return path;
    }

    internal static void RejectLinkedTarget(string workspace, string path)
    {
        for (var current = path; current != workspace && current is not null; current = Path.GetDirectoryName(current))
        {
            if (Path.Exists(current) && (File.GetAttributes(current) & FileAttributes.ReparsePoint) != 0)
                throw new InvalidOperationException("Refusing to modify a linked MCP configuration or tool-manifest path.");
        }
    }

    private async Task InstallLocalToolAsync(string workspace, AiPlatform platform, CancellationToken cancellationToken)
    {
        var manifest = Path.Combine(workspace, ".config", "dotnet-tools.json");
        RejectLinkedTarget(workspace, manifest);
        if (!File.Exists(manifest))
        {
            var create = await runner.RunAsync(["new", "tool-manifest", "--output", workspace], workspace, cancellationToken).ConfigureAwait(false);
            EnsureSuccess("Creating the local tool manifest", create);
        }
        using var document = JsonDocument.Parse(File.ReadAllText(manifest));
        if (!document.RootElement.TryGetProperty("tools", out var tools) || tools.ValueKind != JsonValueKind.Object)
            throw new InvalidOperationException("The local tool manifest must contain a 'tools' object.");
        var installed = tools.EnumerateObject().Any(tool => tool.Name.Equals(platform.McpPackage, StringComparison.OrdinalIgnoreCase));
        string[] args = installed
            ? ["tool", "restore", "--tool-manifest", manifest]
            : ["tool", "install", platform.McpPackage, "--tool-manifest", manifest];
        EnsureSuccess(installed ? "Restoring the local MCP tool" : "Installing the local MCP tool",
            await runner.RunAsync(args, workspace, cancellationToken).ConfigureAwait(false));
    }

    private static void WriteConfiguration(string workspace, string path, string? original, string content)
    {
        RejectLinkedTarget(workspace, path);
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        var temporary = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try
        {
            File.WriteAllText(temporary, content, new UTF8Encoding(false));
            if ((File.Exists(path) ? File.ReadAllText(path) : null) != original)
                throw new InvalidOperationException("The MCP configuration changed during setup; retry after reviewing it.");
            RejectLinkedTarget(workspace, path);
            File.Move(temporary, path, overwrite: original is not null);
        }
        finally
        {
            if (File.Exists(temporary)) File.Delete(temporary);
        }
    }

    internal static void EnsureSuccess(string operation, ToolResult result)
    {
        if (!result.Success) throw new AiToolException(operation, result);
    }
}
