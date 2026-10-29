using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WinForms;

internal static class WinFormsWelcomeTemplate
{
    internal static string Code(bool vb, IReadOnlyList<string> controls, string rootNamespace)
    {
        var resources = WelcomeContent.Resources("WinForms");
        if (vb)
        {
            var cards = string.Join("\n", resources.Select(r => $"AddWelcomeResource(resourceCards, \"{r.Title}\", \"{r.Description}\", \"{r.Url}\")"));
            var links = string.Join("\n", WelcomeContent.FooterLinks.Select(l => $"AddWelcomeLink(links, \"{l.Title}\", \"{l.Url}\")"));
            var samples = string.Join("\n", controls.Select(id => $"Dim {WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}Button = New Syncfusion.WinForms.Controls.SfButton() With {{.Text = \"{WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}\", .AutoSize = True, .Padding = New Padding(12, 8, 12, 8), .MinimumSize = New System.Drawing.Size(0, 44)}}\nAddHandler {WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}Button.Click, Sub(sender, e) tabs.SelectedIndex = FindSample(tabs, \"{id}\")\nsampleLinks.Controls.Add({WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}Button)"));
            return WelcomeContent.ReadTemplate(typeof(WinFormsPlatformProvider), "WelcomeView.vb")
                .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal)
                .Replace("__COPYRIGHT__", WelcomeContent.Copyright, StringComparison.Ordinal)
                .Replace("__SAMPLES__", WelcomeContent.IndentContinuation(samples, 12), StringComparison.Ordinal)
                .Replace("__RESOURCES__", WelcomeContent.IndentContinuation(cards, 12), StringComparison.Ordinal)
                .Replace("__FOOTER_LINKS__", WelcomeContent.IndentContinuation(links, 12), StringComparison.Ordinal)
                .Replace("__SAMPLE_HINT__", controls.Count > 0 ? "AddWelcomeText(sampleBox, \"Select a control to explore its sample.\", 12)" : "", StringComparison.Ordinal)
                .Replace("__EMPTY_STATE__", controls.Count == 0 ? "AddWelcomeText(sampleBox, \"You’re all set! Add a Syncfusion control with the sf CLI to see its sample here.\", 12)" : "", StringComparison.Ordinal);
        }
        var csCards = string.Join("\n", resources.Select(r => $"AddWelcomeResource(resourceCards, \"{r.Title}\", \"{r.Description}\", \"{r.Url}\");"));
        var csLinks = string.Join("\n", WelcomeContent.FooterLinks.Select(l => $"AddWelcomeLink(links, \"{l.Title}\", \"{l.Url}\");"));
        var csSamples = string.Join("\n", controls.Select(id => $"var {WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}Button = new Syncfusion.WinForms.Controls.SfButton {{ Text = \"{WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}\", AutoSize = true, Padding = new Padding(12, 8, 12, 8), MinimumSize = new System.Drawing.Size(0, 44) }};\n{WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}Button.Click += (sender, e) => tabs.SelectedIndex = FindSample(tabs, \"{id}\");\nsampleLinks.Controls.Add({WinFormsControlCatalog.All.Single(template => template.Alias == id).Name}Button);"));
        return WelcomeContent.ReadTemplate(typeof(WinFormsPlatformProvider), "WelcomeView.cs")
                .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal)
                .Replace("__COPYRIGHT__", WelcomeContent.Copyright, StringComparison.Ordinal)
                .Replace("__SAMPLES__", WelcomeContent.IndentContinuation(csSamples, 12), StringComparison.Ordinal)
                .Replace("__RESOURCES__", WelcomeContent.IndentContinuation(csCards, 12), StringComparison.Ordinal)
                .Replace("__FOOTER_LINKS__", WelcomeContent.IndentContinuation(csLinks, 12), StringComparison.Ordinal)
                .Replace("__SAMPLE_HINT__", controls.Count > 0 ? "AddWelcomeText(sampleBox, \"Select a control to explore its sample.\", 12);" : "", StringComparison.Ordinal)
                .Replace("__EMPTY_STATE__", controls.Count == 0 ? "AddWelcomeText(sampleBox, \"You’re all set! Add a Syncfusion control with the sf CLI to see its sample here.\", 12);" : "", StringComparison.Ordinal);
    }
}
