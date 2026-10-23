namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Shared copy and official destinations for newly generated welcome pages.</summary>
public static class WelcomeContent
{
    public const string Copyright = "Copyright © 2001 - 2026 Syncfusion®, Inc. All Rights Reserved";
    public static IReadOnlyList<(string Title, string Url)> FooterLinks { get; } =
    [
        ("Privacy Policy", "https://www.syncfusion.com/legal/privacy-policy/"),
        ("Terms of Service", "https://www.syncfusion.com/legal/website-terms-of-use/"),
        ("Contact Us", "https://www.syncfusion.com/company/contact-us"),
    ];

    public static IReadOnlyList<(string Title, string Description, string Url)> Resources(string platform)
    {
        var documentation = platform == "WinForms" ? "windowsforms/overview" : platform == "WPF" ? "wpf/introduction/overview" : "winui/overview";
        return
        [
            ("Explore Demos", $"See what you can build with interactive {platform} demos.", $"https://www.syncfusion.com/demos/{platform.ToLowerInvariant()}"),
            ("Explore Docs", "Find guides and examples for your next feature.", platform == "Blazor" ? "https://blazor.syncfusion.com/documentation/introduction" : $"https://help.syncfusion.com/{documentation}"),
            ("AI Coding Guidance", "Get practical guidance for building with AI coding assistants.", "https://www.syncfusion.com/blogs/post/syncfusion-ai-coding-assistant"),
            ($"{platform} Controls", $"Discover the full collection of Syncfusion {platform} controls.", $"https://www.syncfusion.com/{platform.ToLowerInvariant()}-controls"),
        ];
    }
    public static string ReadTemplate(Type provider, string filename)
    {
        var assembly = provider.Assembly;
        var name = assembly.GetName().Name + ".Templates.Welcome." + filename;
        using var stream = assembly.GetManifestResourceStream(name)
            ?? throw new InvalidOperationException($"Missing embedded welcome template: {name}");
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }

    public static string IndentContinuation(string source, int spaces)
        => source.Replace("\n", "\n" + new string(' ', spaces), StringComparison.Ordinal);
}
