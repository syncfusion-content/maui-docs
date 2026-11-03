using System.CommandLine;
using System.Text.Json;
using System.Text.Json.Nodes;
using Syncfusion.DotNet.Cli.Commands.Options;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Core.Licensing;
using Syncfusion.DotNet.Cli.Presentation;

namespace Syncfusion.DotNet.Cli.Commands.License;

/// <summary>Defines <c>sfdotnet login</c>, <c>sfdotnet logout</c> and <c>sfdotnet license {view,activate}</c>.</summary>
public static class LicenseCommands
{
    private static readonly HttpClient Http = new() { Timeout = TimeSpan.FromSeconds(60) };
    private static readonly Option<bool> YesOption = new("--yes", ["-y"]) { Description = "Accept the trial EULA prompt automatically." };
    private static readonly Option<string?> FileOption = new("--file") { Description = "Activate from an existing key file (absolute path) or ./syncfusion-license.txt when no value is given.", Arity = ArgumentArity.ZeroOrOne };

    public static Command[] Create() => [CreateLogin(), CreateLogout(), CreateLicense()];

    private static AuthRuntime Runtime(ParseResult parse)
    {
        var busy = BusyIndicator.Enabled(parse.GetValue<bool>("--json"), parse.GetValue<bool>("--no-color"));
        var noColor = parse.GetValue<bool>("--no-color");
        return new(AuthConfig.Load(), new SessionStore(), Http)
        {
            WhileWaiting = busy ? (label, work) => BusyIndicator.RunAsync(true, label, work) : null,
            ShowSignInLink = url => SignInLink.Show(url, noColor),
        };
    }

    private static Command CreateLogin()
    {
        var command = new Command("login", "Sign in to Syncfusion in the browser (the URL is also printed).");
        command.SetAction(async (parse, ct) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parse);
            return await Guard(presenter, false, "sfdotnet login", async () =>
            {
                var session = await Runtime(parse).EnsureAuthenticatedAsync(true, ct).ConfigureAwait(false);
                presenter.WriteSuccess(HasEmail(session) ? $"Authenticated as: {session.Email}" : "Authenticated.");
                return ExitCodes.Success;
            }).ConfigureAwait(false);
        });
        return command;
    }

    private static Command CreateLogout()
    {
        var command = new Command("logout", "Sign out of Syncfusion and clear the local session.");
        command.SetAction(async (parse, ct) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parse);
            await Runtime(parse).LogoutAsync(ct).ConfigureAwait(false);
            presenter.WriteSuccess("Signed out successfully.");
            return ExitCodes.Success;
        });
        return command;
    }

    private static Command CreateLicense()
    {
        var license = new Command("license", "Download, register and view Syncfusion licenses.");
        var activate = new Command("activate", "Sign in, download the license for the project's packages and register it in the project's startup code.");
        activate.Add(YesOption);
        activate.Add(FileOption);
        activate.Add(CommandOptions.PathOption);
        activate.SetAction((parse, ct) => ActivateAsync(parse, ct));
        var view = new Command("view", "Show the licenses cached for this project (no network).");
        view.Add(CommandOptions.PathOption);
        view.SetAction(parse => View(parse));
        license.Add(activate);
        license.Add(view);
        license.SetAction(parse =>
        {
            GlobalsHelper.CreatePresenter(parse).WriteInfo("Usage: sfdotnet license <activate|view>" + Environment.NewLine + "  activate  Download and register the license for this project" + Environment.NewLine + "  view      Show cached licenses");
            return ExitCodes.Success;
        });
        return license;
    }

    private static bool HasEmail(Session s) => s.Email.Length > 0 && !s.Email.Equals("unknown@example.com", StringComparison.OrdinalIgnoreCase);

    private static async Task<int> ActivateAsync(ParseResult parse, CancellationToken ct)
    {
        var presenter = GlobalsHelper.CreatePresenter(parse);
        var json = parse.GetValue<bool>("--json");
        var stages = new JsonObject();
        string? usedPath = null;
        if (!json)
        {
            // The interactive menu has already shown the Action line; a direct `sfdotnet license activate` shows it here.
            if (!ProjectWizardOutput.HasCompletedValue("Action:")) presenter.WriteAnswerLine("Action: Activate license", "Action: ".Length);
            Console.Out.WriteLine();
        }

        return await Guard(presenter, json, "sfdotnet license activate", async () =>
        {
            var cwd = PathNormalizer.Normalize(parse.GetValue(CommandOptions.PathOption) ?? ".");
            var scan = ProjectScanner.Scan(cwd);
            var root = scan.ProjectDirectory;
            var keyFile = Path.Combine(root, LicenseWriter.KeyFileName);
            var vb = scan.ProjectFile.EndsWith(".vbproj", StringComparison.OrdinalIgnoreCase);
            IReadOnlyList<string> keys;
            if (parse.GetResult(FileOption) is { } fileResult)
            {
                var value = parse.GetValue(FileOption);
                stages["login"] = new JsonObject { ["exitCode"] = 0, ["skipped"] = "by --file" };
                stages["download"] = new JsonObject { ["exitCode"] = 0, ["skipped"] = "by --file" };
                if (string.IsNullOrWhiteSpace(value))
                {
                    if (!File.Exists(keyFile)) throw new LicenseException(LicenseExitCodes.KeyFileMissing, "syncfusion-license.txt file is not found, Run: sfdotnet license activate to download and activate the key.");
                    usedPath = keyFile;
                }
                else
                {
                    if (!Path.IsPathRooted(value)) throw new LicenseException(LicenseExitCodes.ServiceUnavailable, $"License key file path must be absolute: {value}");
                    if (File.Exists(keyFile)) throw new LicenseException(LicenseExitCodes.ConflictingKeySource, $"License key already exists at '{keyFile}'. Delete the file to activate using a custom path.");
                    if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE"))) throw new LicenseException(LicenseExitCodes.ConflictingKeySource, "A Syncfusion license key is already provided via the SYNCFUSION_LICENSE environment variable. Unset it to activate using a custom path.");
                    if (!File.Exists(value)) throw new LicenseException(LicenseExitCodes.ServiceUnavailable, $"License key file not found: {value}");
                    usedPath = value;
                }

                keys = LicenseWriter.ReadKeys(usedPath);
                if (keys.Count == 0) throw new LicenseException(LicenseExitCodes.KeyFileMissing, "License key txt file is not found. Run: sfdotnet license activate");
            }
            else
            {
                var runtime = Runtime(parse);
                var signedInShown = false;
                var session = runtime.Store.Load();
                if (session is not null && HasEmail(session))
                {
                    if (!json) { presenter.WriteSuccess($"Signed in as: {session.Email}"); signedInShown = true; }
                    stages["login"] = new JsonObject { ["exitCode"] = 0, ["skipped"] = true, ["email"] = session.Email };
                }
                else
                {
                    try { session = await runtime.EnsureAuthenticatedAsync(true, ct).ConfigureAwait(false); }
                    catch (LicenseException ex) { throw new LicenseException(LicenseExitCodes.SignInFailed, $"{ex.Message}{Environment.NewLine}License activation stopped: sign-in failed. Run: sfdotnet login"); }
                    stages["login"] = new JsonObject { ["exitCode"] = 0, ["email"] = session.Email };
                }

                var (code, message) = await DownloadAsync(parse, presenter, json, scan, session, runtime, signedInShown, ct).ConfigureAwait(false);
                stages["download"] = new JsonObject { ["exitCode"] = code, ["message"] = message };
                if (code is not 0 and not LicenseExitCodes.Partial)
                    throw new LicenseException(code, $"{message}{Environment.NewLine}License activation stopped: download failed. Run: sfdotnet license activate");
                var partial = code == LicenseExitCodes.Partial;
                keys = LicenseWriter.ReadKeys(keyFile);
                if (keys.Count == 0) throw new LicenseException(LicenseExitCodes.KeyFileMissing, "License key txt file is not found. Run: sfdotnet license activate");
                var result = LicenseRegistrar.Register(scan.ProjectFile, scan.Platform, keys);
                stages["activate"] = new JsonObject { ["exitCode"] = partial ? LicenseExitCodes.Partial : 0, ["message"] = $"License registered in {Path.GetFileName(result.File)}" };
                return Finish(presenter, json, partial ? LicenseExitCodes.Partial : 0, stages, usedPath, result.File, hadOutput: true);
            }

            var registered = LicenseRegistrar.Register(scan.ProjectFile, scan.Platform, keys);
            stages["activate"] = new JsonObject { ["exitCode"] = 0, ["message"] = $"License registered in {Path.GetFileName(registered.File)}" };
            return Finish(presenter, json, 0, stages, usedPath, registered.File);
        }).ConfigureAwait(false);
    }

    private static int Finish(ConsolePresenter presenter, bool json, int exit, JsonObject stages, string? usedPath, string registeredFile, bool hadOutput = false)
    {
        if (json) WriteEnvelope(presenter, "sfdotnet license activate", exit, new JsonObject { ["stages"] = stages, ["usedPath"] = usedPath }, [], []);
        else
        {
            // Separate the result from the sign-in / license table printed above it, but not when it is the first line.
            if (hadOutput) System.Console.Out.WriteLine();
            presenter.WriteSuccess($"License registered in {registeredFile}");
            if (exit == 0) presenter.WriteInfo("Note: Rebuild the application so the newly registered license is applied.");
        }

        return exit;
    }

    private static async Task<(int Code, string Message)> DownloadAsync(ParseResult parse, ConsolePresenter presenter, bool json, ProjectScan scan, Session session, AuthRuntime runtime, bool leadingBlank, CancellationToken ct)
    {
        var config = AuthConfig.Load();
        var client = new EntitlementClient(config, Http, session.Email, (force, token) => runtime.MintApiTokenAsync(session.Email, force, token));
        var products = scan.Products.ToList();
        var busy = BusyIndicator.Enabled(json, presenter.NoColor);
        var entitlements = await BusyIndicator.RunAsync(busy, "Checking your Syncfusion licenses...", () => client.FetchEntitlementsAsync(scan.Platform, scan.Major, products, ct)).ConfigureAwait(false);
        var chosen = LicenseSelection.Select(entitlements, products, scan.Major);
        var missing = products.Where(p => !chosen.ContainsKey(p)).ToList();
        var partial = false;
        const string Purchase = "To purchase a paid license visit: https://www.syncfusion.com/account";
        if (missing.Count > 0)
        {
            var nothing = chosen.Count == 0;
            if (json)
                return nothing
                    ? (LicenseExitCodes.NoEntitlement, $"No paid or trial license available for: {string.Join(", ", products)}. {Purchase}")
                    : (LicenseExitCodes.NoEntitlement, $"These product licenses are not available: {string.Join(", ", missing)}.");

            // The affected packages are listed once, before the trial question; nothing below repeats them.
            if (leadingBlank) Console.Out.WriteLine();
            presenter.WriteInfo(nothing ? "No paid or trial license available for:" : "These product licenses are not available for:");
            foreach (var product in missing) presenter.WriteInfo("  " + product);
            Console.Out.WriteLine();
            var accepted = OfferTrial(parse);
            if (accepted)
            {
                var trials = await BusyIndicator.RunAsync(busy, "Requesting trial license...", () => client.FetchTrialAsync(scan.Platform, scan.Major, missing, ct)).ConfigureAwait(false);
                foreach (var kv in LicenseSelection.Select(trials, missing, scan.Major)) chosen[kv.Key] = kv.Value;
            }

            partial = products.Any(p => !chosen.ContainsKey(p));
            if (chosen.Count == 0) return (LicenseExitCodes.NoEntitlement, $"No paid or trial license available. {Purchase}");
        }

        var keys = LicenseWriter.DedupeKeys(products.Where(chosen.ContainsKey).Select(p => chosen[p]));
        if (keys.Count == 0) return (LicenseExitCodes.ServiceUnavailable, "License server returned entitlements without a key. Try again later.");
        LicenseWriter.Write(scan.ProjectDirectory, LicenseWriter.Build(session.Email, scan.Platform, products, chosen, keys), keys);
        if (!json) PrintTable(presenter, LicenseWriter.Read(scan.ProjectDirectory, out _)!, scan.Major);
        return (partial ? LicenseExitCodes.Partial : 0, "Licenses downloaded.");
    }

    private const string EulaUrl = "https://www.syncfusion.com/eula/es/";

    private static bool OfferTrial(ParseResult parse)
    {
        if (parse.GetValue(YesOption)) return true;
        if (Console.IsInputRedirected) return false;
        Console.Out.WriteLine("Setup Trial License and accept the Syncfusion EULA?");
        Console.Out.WriteLine(EulaUrl);
        Console.Out.WriteLine();
        Console.Out.Write("[y/N]: ");
        var answer = Console.In.ReadLine()?.Trim();
        return answer is not null && (answer.Equals("y", StringComparison.OrdinalIgnoreCase) || answer.Equals("yes", StringComparison.OrdinalIgnoreCase));
    }

    private static int View(ParseResult parse)
    {
        var presenter = GlobalsHelper.CreatePresenter(parse);
        var json = parse.GetValue<bool>("--json");
        var path = PathNormalizer.Normalize(parse.GetValue(CommandOptions.PathOption) ?? ".");
        var root = Directory.Exists(path) ? path : Path.GetDirectoryName(Path.GetFullPath(path))!;
        var warnings = new List<string>();
        int? projectMajor = null;
        var meta = LicenseWriter.Read(root, out var corrupted);
        if (meta is null)
        {
            var message = corrupted ? "Local cache is corrupted. Please re-download licenses. Run: sfdotnet license activate" : "No licenses downloaded. Run: sfdotnet license activate";
            if (json) WriteEnvelope(presenter, "sfdotnet license view", 0, new JsonObject { ["licenses"] = null }, [message], []);
            else presenter.WriteInfo(message);
            return ExitCodes.Success;
        }

        try
        {
            var scan = ProjectScanner.Scan(path);
            projectMajor = scan.Major;
            var covered = meta.Licenses.Where(l => l.Status != "NotAvailable").Select(l => l.Product).ToList();
            var missing = scan.Products.Except(covered, StringComparer.OrdinalIgnoreCase).ToList();
            if (missing.Count > 0) warnings.Add($"Partial coverage: {string.Join(", ", covered)} covered. Missing: {string.Join(", ", missing)}. Run: sfdotnet license activate");
            var cached = meta.Licenses.Select(l => l.Version).Where(v => v is not null && v != "*").Select(v => v!.Split('.')[0]).Distinct().ToList();
            if (cached.Count > 0 && !cached.Contains(scan.Major.ToString(System.Globalization.CultureInfo.InvariantCulture)) && !meta.Licenses.Any(l => l.Version == "*"))
                warnings.Add($"Warning: cached license is for v{cached[0]} but project requires v{scan.Major}. Run: sfdotnet license activate");
        }
        catch (LicenseException) { }

        if (json)
        {
            var rows = new JsonArray(meta.Licenses.Select(l => (JsonNode)new JsonObject { ["product"] = l.Product, ["platform"] = meta.Platform, ["version"] = l.Version ?? "*", ["type"] = l.Type, ["status"] = l.Status, ["expiresAt"] = l.ExpiresAt }).ToArray());
            WriteEnvelope(presenter, "sfdotnet license view", 0, new JsonObject { ["licenses"] = rows }, warnings, []);
            return ExitCodes.Success;
        }

        PrintTable(presenter, meta, projectMajor);
        foreach (var w in warnings) presenter.WriteInfo(w);
        return ExitCodes.Success;
    }

    // The header shows the project's own Syncfusion version. Trial licenses are stored as "*" (valid for the
    // latest release), so the license rows are only a fallback and "*" is never shown as the project version.
    private static void PrintTable(ConsolePresenter presenter, LicenseMetadata meta, int? projectMajor)
    {
        var major = projectMajor?.ToString(System.Globalization.CultureInfo.InvariantCulture)
            ?? meta.Licenses.Select(l => l.Version).FirstOrDefault(v => v is not null && v != "*");
        presenter.WriteInfo($"Email: {meta.Email}");
        presenter.WriteInfo($"Platform: {meta.Platform}");
        if (major is not null) presenter.WriteInfo($"Version: {major.Split('.')[0]}.*.*");
        presenter.WriteInfo(Environment.NewLine + "Licenses");
        var rows = meta.Licenses.Select(l => new[] { l.Product, l.Type ?? "—", l.Status == "NotAvailable" ? "N/A" : l.Status, l.ExpiresAt ?? "—" }).Prepend(["Product", "Type", "Status", "Expires"]).ToList();
        var widths = Enumerable.Range(0, 4).Select(i => rows.Max(r => r[i].Length)).ToArray();
        foreach (var r in rows) presenter.WriteInfo("  " + string.Join(" | ", r.Select((c, i) => c.PadRight(widths[i]))).TrimEnd());
    }

    /// <summary>Human-readable form of a message: a "Run: <command>" and any URL each start their own line.</summary>
    public static string Humanize(string message)
    {
        var text = System.Text.RegularExpressions.Regex.Replace(message, @"([.,])?[ \t]+Run: ",
            m => (m.Groups[1].Success ? "." : "") + Environment.NewLine + "Run: ");
        return System.Text.RegularExpressions.Regex.Replace(text, @"[ \t]+(https?://\S*?)(?=[.,]?(\s|$))", Environment.NewLine + "$1");
    }

    private static async Task<int> Guard(ConsolePresenter presenter, bool json, string command, Func<Task<int>> action)
    {
        try { return await action().ConfigureAwait(false); }
        catch (LicenseException ex)
        {
            if (json) WriteEnvelope(presenter, command, ex.ExitCode, null, [], ex.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries));
            else presenter.WriteError(Humanize(ex.Message));
            return ex.ExitCode;
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException or System.Text.Json.JsonException or KeyNotFoundException or InvalidOperationException)
        {
            var message = ex is HttpRequestException or TaskCanceledException
                ? $"Could not reach the Syncfusion license service ({ex.Message}). Check your network connection and the SF_AUTH_AUTHORITY / SF_LICENSE_API_URL settings."
                : $"Unexpected response from the Syncfusion service: {ex.Message}";
            const int code = LicenseExitCodes.ServiceUnavailable;
            if (json) WriteEnvelope(presenter, command, code, null, [], [message]);
            else presenter.WriteError(Humanize(message));
            presenter.WriteVerbose(ex.ToString());
            return code;
        }
    }

    private static void WriteEnvelope(ConsolePresenter presenter, string command, int exit, JsonObject? data, IEnumerable<string> warnings, IEnumerable<string> errors)
        => presenter.WriteInfo(new JsonObject
        {
            ["exitCode"] = exit,
            ["status"] = exit == 0 ? "success" : exit == LicenseExitCodes.Partial ? "partial" : "failure",
            ["command"] = command,
            ["data"] = data,
            ["warnings"] = new JsonArray(warnings.Select(w => (JsonNode)JsonValue.Create(w)!).ToArray()),
            ["errors"] = new JsonArray(errors.Select(e => (JsonNode)JsonValue.Create(e)!).ToArray()),
        }.ToJsonString(new JsonSerializerOptions { WriteIndented = false }));
}
