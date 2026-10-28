using System.Security;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WPF;

internal static class WpfWelcomeTemplate
{
    internal static string View(IReadOnlyList<string> controls, bool dark, string rootNamespace)
    {
        var samples = controls.Count == 0
            ? "<TextBlock Text=\"You’re all set! Add a Syncfusion control with the sf CLI to see its sample here.\" TextWrapping=\"Wrap\" />"
            : "<WrapPanel>" + string.Join("\n", controls.Select(id => $"<Button Content=\"{WPFControlCatalog.All.Single(template => template.Alias == id).Name}\" Tag=\"{id}\" Click=\"OpenSample\" Margin=\"0,0,8,8\" Padding=\"18,12\" />")) + "</WrapPanel>";
        string Link(string title, string url) => $"<TextBlock TextWrapping=\"Wrap\" Margin=\"0,14,16,14\"><Hyperlink NavigateUri=\"{url}\" RequestNavigate=\"OpenLink\" Foreground=\"{{DynamicResource {{x:Static SystemColors.HotTrackBrushKey}}}}\" ToolTip=\"Opens in your default browser\">{SecurityElement.Escape(title)}</Hyperlink></TextBlock>";
        var resources = string.Join("\n", WelcomeContent.Resources("WPF").Select(resource => $$$"""
            <Border Width="250" Padding="20" Margin="0,0,16,16" BorderThickness="1" CornerRadius="14"
                    BorderBrush="{DynamicResource {x:Static SystemColors.ActiveBorderBrushKey}}">
                <StackPanel>
                    <TextBlock Text="{{{resource.Title}}}" FontSize="18" FontWeight="Bold" TextWrapping="Wrap" />
                    <TextBlock Text="{{{resource.Description}}}" Margin="0,12" TextWrapping="Wrap" />
                    {{{Link(resource.Title + " →", resource.Url)}}}
                </StackPanel>
            </Border>
            """));
        var palette = dark ? "<Grid.Resources><SolidColorBrush x:Key=\"{x:Static SystemColors.WindowBrushKey}\" Color=\"#1F1F1F\" /><SolidColorBrush x:Key=\"{x:Static SystemColors.WindowTextBrushKey}\" Color=\"White\" /><SolidColorBrush x:Key=\"{x:Static SystemColors.HotTrackBrushKey}\" Color=\"#AC99EA\" /></Grid.Resources>" : "";
        return WelcomeContent.ReadTemplate(typeof(WPFPlatformProvider), "WelcomeView.xaml")
            .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal)
            .Replace("__PALETTE__", palette, StringComparison.Ordinal)
            .Replace("__SAMPLES__", samples, StringComparison.Ordinal)
            .Replace("__RESOURCES__", resources, StringComparison.Ordinal)
            .Replace("__COPYRIGHT__", WelcomeContent.Copyright, StringComparison.Ordinal)
            .Replace("__FOOTER_LINKS__", string.Join("\n", WelcomeContent.FooterLinks.Select(link => Link(link.Title, link.Url))), StringComparison.Ordinal);
    }

    internal static string Code(bool vb, string rootNamespace)
        => WelcomeContent.ReadTemplate(typeof(WPFPlatformProvider), vb ? "WelcomeView.xaml.vb" : "WelcomeView.xaml.cs")
            .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal);
}
