using System.Net;
using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Blazor;

internal static class BlazorWelcomeTemplate
{
    internal static void Install(string root, IReadOnlyList<string> controls, bool hasShell = true)
    {
        var pages = Directory.GetFiles(root, "*.razor", SearchOption.AllDirectories)
            .Where(path => Path.GetFileName(path) is "Home.razor" or "Index.razor")
            .Where(path => File.ReadAllText(path).Contains("@page \"/\"", StringComparison.Ordinal)).ToArray();
        if (pages.Length == 0) throw new InvalidOperationException("The official Blazor template did not create a home page.");
        foreach (var page in pages)
        {
            var projectRoot = Path.GetDirectoryName(page)!;
            while (Directory.GetFiles(projectRoot, "*.csproj").Length == 0 && projectRoot != root)
                projectRoot = Path.GetDirectoryName(projectRoot)!;
            var project = Directory.GetFiles(projectRoot, "*.csproj").FirstOrDefault();
            var rootNamespace = project is null ? "App" : Path.GetFileNameWithoutExtension(project);
            var welcome = Path.Combine(projectRoot, "Welcome");
            Directory.CreateDirectory(welcome);
            File.WriteAllText(Path.Combine(welcome, "WelcomeView.razor"), Page(controls, rootNamespace));
            File.WriteAllText(Path.Combine(welcome, "WelcomeView.razor.css"), hasShell ? Css : Css.Replace("100vh - 5rem", "100dvh - 1rem", StringComparison.Ordinal));
            File.WriteAllText(page, $"@page \"/\"\n@using {rootNamespace}.Welcome\n<WelcomeView />\n");
        }
    }

    internal static string Page(IReadOnlyList<string> controls, string rootNamespace)
    {
        var samples = controls.Count == 0
            ? "<p>You’re all set! Add a Syncfusion control with the sfdotnet CLI to see its sample here.</p>"
            : "<p>Select a control to explore its sample.</p><nav class=\"sample-links\" aria-label=\"Control samples\">" + string.Join("\n", controls.Select(id => $"<a href=\"{id}\">{WebUtility.HtmlEncode(BlazorDemoTemplates.Display(id))}</a>")) + "</nav>";
        var cards = string.Join("\n", WelcomeContent.Resources("Blazor").Select(resource => $$"""
            <article class="resource-card">
                <h3>{{resource.Title}}</h3>
                <p>{{resource.Description}}</p>
                <a href="{{resource.Url}}" target="_blank" rel="noopener noreferrer" aria-label="{{resource.Title}} (opens in a new tab)">{{resource.Title}} →</a>
            </article>
            """));
        var links = string.Join("\n", WelcomeContent.FooterLinks.Select(link => $"<a href=\"{link.Url}\" target=\"_blank\" rel=\"noopener noreferrer\" aria-label=\"{link.Title} (opens in a new tab)\">{link.Title}</a>"));
        return WelcomeContent.ReadTemplate(typeof(BlazorProjectService), "WelcomeView.razor")
            .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal)
            .Replace("__SAMPLES__", samples, StringComparison.Ordinal)
            .Replace("__RESOURCES__", cards, StringComparison.Ordinal)
            .Replace("__FOOTER_LINKS__", links, StringComparison.Ordinal)
            .Replace("__COPYRIGHT__", WelcomeContent.Copyright, StringComparison.Ordinal);
    }

    internal static string Css => WelcomeContent.ReadTemplate(typeof(BlazorProjectService), "WelcomeView.razor.css");
}
