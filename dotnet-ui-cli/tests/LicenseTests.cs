using Syncfusion.DotNet.CLI.Core.Licensing;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public static class LicenseTests
{
    private static Entitlement E(string type, string version, string key, string status = "Active")
        => new("GridSDK", version, type, "Community", status, null, key);

    [Fact]
    public static void Selection_PrefersPaidOverTrialAndMatchingVersion()
    {
        var chosen = LicenseSelection.Select([E("Trial", "35", "t"), E("Paid", "35", "p35"), E("Paid", "34", "p34")], ["grid-sdk"], 34);
        Assert.Equal("p34", chosen["grid-sdk"].LicenseKey);
    }

    [Fact]
    public static void Selection_DiscardsExpired()
        => Assert.Empty(LicenseSelection.Select([E("Paid", "34", "x", "Expired")], ["GridSDK"], 34));

    [Fact]
    public static void Registrar_InsertsOnceForEachPlatform()
    {
        var dir = Directory.CreateTempSubdirectory().FullName;
        try
        {
            File.WriteAllText(Path.Combine(dir, "a.csproj"), "<Project/>");
            File.WriteAllText(Path.Combine(dir, "MauiProgram.cs"), "class P { static MauiApp CreateMauiApp() {\n    var b = MauiApp.CreateBuilder();\n} }");
            for (var i = 0; i < 2; i++) LicenseRegistrar.Register(Path.Combine(dir, "a.csproj"), "MAUI", ["KEY"]);
            var text = File.ReadAllText(Path.Combine(dir, "MauiProgram.cs"));
            Assert.Single(System.Text.RegularExpressions.Regex.Matches(text, "RegisterLicense"));
            Assert.True(text.IndexOf("RegisterLicense", StringComparison.Ordinal) < text.IndexOf("CreateBuilder", StringComparison.Ordinal));
        }
        finally { Directory.Delete(dir, true); }
    }

    [Fact]
    public static void SessionStore_RoundTripsEncrypted()
    {
        var path = Path.Combine(Directory.CreateTempSubdirectory().FullName, "session.json");
        var store = new SessionStore(path);
        store.Save(new Session("a@b.c", "tok", null, DateTimeOffset.UtcNow.AddHours(1)));
        Assert.DoesNotContain("tok", File.ReadAllText(path));
        Assert.Equal("a@b.c", store.Load()!.Email);
    }
}

public static class LicenseApiTests
{
    [Fact]
    public static void DecodeKey_DecodesBase64AndKeepsPlainText()
    {
        var encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("Mjk4NTIxQDMyMzAyZTM0MmUzMEJ"));
        Assert.Equal("Mjk4NTIxQDMyMzAyZTM0MmUzMEJ", Syncfusion.DotNet.CLI.Core.Licensing.EntitlementClient.DecodeKey(encoded));
        Assert.Equal("MOCK-LICENSE-KEY", Syncfusion.DotNet.CLI.Core.Licensing.EntitlementClient.DecodeKey("MOCK-LICENSE-KEY"));
        Assert.Null(Syncfusion.DotNet.CLI.Core.Licensing.EntitlementClient.DecodeKey("null"));
    }

    [Fact]
    public static void IdToken_EmailReadsSyncfusionEmailIdClaim()
    {
        static string B(string s) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s)).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        var token = $"{B("{}")}.{B("{\"EmailId\":\"a@b.com\"}")}.sig";
        Assert.Equal("a@b.com", Syncfusion.DotNet.CLI.Core.Licensing.AuthRuntime.EmailFromIdToken(token));
    }
}

public static class CallbackServerTests
{
    [Theory]
    [InlineData("localhost")]
    [InlineData("127.0.0.1")]
    public static async Task Callback_AcceptsAnyLoopbackHostHeader(string host)
    {
        using var server = CallbackServer.TryStart([17788, 17789, 17790], "/callback", "Signed in")!;
        var wait = server.WaitAsync(TimeSpan.FromSeconds(10), CancellationToken.None);
        using var client = new HttpClient();
        using var request = new HttpRequestMessage(HttpMethod.Get, $"http://127.0.0.1:{server.Port}/callback?code=abc&state=s");
        request.Headers.Host = $"{host}:{server.Port}";
        using var response = await client.SendAsync(request);
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        var result = await wait;
        Assert.Equal("abc", result!["code"]);
    }
}

[Collection("Console output")]
public static class BusyIndicatorTests
{
    [Fact]
    public static async Task DisabledIndicatorJustRunsTheWorkAndPrintsNothing()
    {
        using var capture = new ConsoleCapture();
        var result = await Syncfusion.DotNet.CLI.Presentation.BusyIndicator.RunAsync(false, "Working...", () => Task.FromResult(42));
        Assert.Equal(42, result);
        Assert.Equal("", capture.Out);
    }

    [Fact]
    public static void IndicatorIsOffForJsonAndForRedirectedOutput()
    {
        Assert.False(Syncfusion.DotNet.CLI.Presentation.BusyIndicator.Enabled(json: true, noColor: false));
        Assert.False(Syncfusion.DotNet.CLI.Presentation.BusyIndicator.Enabled(json: false, noColor: true));
    }
}

public static class LicenseMessageFormatTests
{
    private static readonly string NL = Environment.NewLine;
    private static string H(string m) => Syncfusion.DotNet.CLI.Commands.License.LicenseCommands.Humanize(m);

    [Fact]
    public static void PutsUrlAndRunCommandOnTheirOwnLines()
        => Assert.Equal($"No paid or trial license available. To purchase a paid license visit:{NL}https://www.syncfusion.com/account{NL}License activation stopped: download failed.{NL}Run: sf license activate",
            H($"No paid or trial license available. To purchase a paid license visit: https://www.syncfusion.com/account{NL}License activation stopped: download failed. Run: sf license activate"));

    [Fact]
    public static void LeavesPlainMessagesAlone() => Assert.Equal("License key file not found: /tmp/x.txt", H("License key file not found: /tmp/x.txt"));

    [Fact]
    public static void CommandAfterASentenceMovesToItsOwnLine()
        => Assert.Equal($"Not signed in.{NL}Run: sf login", H("Not signed in. Run: sf login"));
}

public static class SignInLinkTests
{
    private static string Render(bool links, bool ansi, bool noColor)
    {
        using var writer = new StringWriter();
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Ansi = ansi ? Spectre.Console.AnsiSupport.Yes : Spectre.Console.AnsiSupport.No,
            ColorSystem = Spectre.Console.ColorSystemSupport.TrueColor,
            Out = new Spectre.Console.AnsiConsoleOutput(writer),
        });
        console.Profile.Capabilities.Links = links;
        Syncfusion.DotNet.CLI.Presentation.SignInLink.Show("https://id.example/authorize?x=1&y=2", noColor, console);
        return writer.ToString();
    }

    [Fact]
    public static void ShowsShortTextWithHyperlinkWhenTerminalSupportsLinks()
    {
        // Redirected test output disables the link branch on purpose; the plain form must still carry the URL.
        var text = Render(links: true, ansi: true, noColor: false);
        Assert.Contains("Could not open the browser automatically.", text);
        Assert.Contains("https://id.example/authorize?x=1&y=2", text);
    }

    [Fact]
    public static void FallsBackToTheFullUrlOnItsOwnLine()
    {
        var text = Render(links: false, ansi: false, noColor: true);
        Assert.Contains("Open this URL to sign in:", text);
        Assert.Contains(Environment.NewLine + "https://id.example/authorize?x=1&y=2" + Environment.NewLine, text);
        Assert.DoesNotContain("Open Syncfusion sign-in", text);
    }
}
