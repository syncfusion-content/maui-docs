using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WinUI;

internal static class WinUIWelcomeTemplate
{
    internal static string View(IReadOnlyList<string> controls, string rootNamespace)
    {
        var samples = controls.Count == 0
            ? "<TextBlock Text=\"You’re all set! Add a Syncfusion control with the sf CLI to see its sample here.\" TextWrapping=\"Wrap\" />"
            : "<ItemsControl><ItemsControl.ItemsPanel><ItemsPanelTemplate><VariableSizedWrapGrid Orientation=\"Horizontal\" ItemWidth=\"180\" ItemHeight=\"48\" /></ItemsPanelTemplate></ItemsControl.ItemsPanel>" + string.Join("\n", controls.Select(id => $"<Button Content=\"{new WinUIPlatformProvider().Packages.Single(package => package.Alias == id).DisplayName}\" Tag=\"{id}\" Click=\"OpenSample\" Margin=\"0,0,8,8\" HorizontalAlignment=\"Stretch\" />")) + "</ItemsControl>";
        string Link(string title, string url) => $"<HyperlinkButton Content=\"{title}\" NavigateUri=\"{url}\" Padding=\"0,10\" Margin=\"0,0,16,0\" AutomationProperties.HelpText=\"Opens in your default browser\" />";
        var resources = string.Join("\n", WelcomeContent.Resources("WinUI").Select(resource => $$"""
            <Border Padding="20" BorderThickness="1" CornerRadius="14" BorderBrush="{ThemeResource CardStrokeColorDefaultBrush}">
                <StackPanel Spacing="12">
                    <TextBlock Text="{{resource.Title}}" FontSize="18" FontWeight="SemiBold" TextWrapping="Wrap" />
                    <TextBlock Text="{{resource.Description}}" TextWrapping="Wrap" />
                    {{Link(resource.Title + " →", resource.Url)}}
                </StackPanel>
            </Border>
            """));
        return WelcomeContent.ReadTemplate(typeof(WinUIPlatformProvider), "WelcomeView.xaml")
            .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal)
            .Replace("__SAMPLES__", samples, StringComparison.Ordinal)
            .Replace("__RESOURCES__", resources, StringComparison.Ordinal)
            .Replace("__COPYRIGHT__", WelcomeContent.Copyright, StringComparison.Ordinal)
            .Replace("__FOOTER_LINKS__", string.Join("\n", WelcomeContent.FooterLinks.Select(link => Link(link.Title, link.Url))), StringComparison.Ordinal);
    }

    internal static string Code(string rootNamespace)
        => WelcomeContent.ReadTemplate(typeof(WinUIPlatformProvider), "WelcomeView.xaml.cs")
            .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal);
}
