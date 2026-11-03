using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.WinUI;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

public sealed class WinUIControlTemplateTests
{
    [Fact]
    public void CatalogOffersCartesianAndCircularChartSamples()
    {
        IDesktopPlatformProvider provider = new WinUIPlatformProvider();
        Assert.True(provider.SupportsControlTemplates);
        Assert.Equal(new[] { "AIAssistView", "CartesianChart", "CircularChart", "DataGrid", "DockingManager", "Kanban", "MarkdownViewer", "Ribbon", "Scheduler", "TreeGrid", "TreeView" }, provider.Controls.Select(item => item.DisplayName));
        Assert.Equal("Syncfusion.Chart.WinUI", provider.Controls.Single(item => item.Alias == "cartesian-chart").Id);
        Assert.Equal("Syncfusion.Chart.WinUI", provider.Controls.Single(item => item.Alias == "circular-chart").Id);
    }
    [Theory]
    [InlineData("net8.0")]
    [InlineData("net9.0")]
    [InlineData("net10.0")]
    public void EveryControlCombinationHasCompleteViewsAndNavigation(string framework)
    {
        IDesktopPlatformProvider provider = new WinUIPlatformProvider();
        var controls = provider.Controls.ToArray();
        XNamespace x = "http://schemas.microsoft.com/winfx/2006/xaml";
        for (var mask = 0; mask < 1 << controls.Length; mask++)
        {
            var selected = controls.Where((_, index) => (mask & (1 << index)) != 0).ToArray();
            var request = new DesktopNewRequest(provider.Platform, "SampleApp", Path.GetTempPath(), "C#",
                framework, "Native", selected.Select(item => item.Alias).ToArray(), false, false);
            Assert.Null(DesktopConfiguration.Validate(provider, request));
            var files = provider.Generate(request);
            var host = XDocument.Parse(files["MainWindow.xaml"]);
            var items = host.Descendants().Where(item => item.Name.LocalName == "PivotItem" && item.Attribute("Tag") is not null).ToArray();
            Assert.Equal(selected.Length, items.Length);
            Assert.Equal(selected.Select(item => item.Alias).Order(), items.Select(item => (string)item.Attribute("Tag")!).Order());
            foreach (var item in items)
            {
                var view = Assert.Single(item.Elements());
                var file = files.Single(pair => pair.Key.EndsWith("/" + view.Name.LocalName + ".xaml", StringComparison.Ordinal));
                var page = XDocument.Parse(file.Value);
                Assert.Equal(view.Name.NamespaceName["using:".Length..] + "." + view.Name.LocalName, (string?)page.Root!.Attribute(x + "Class"));
                Assert.Contains(file.Key + ".cs", files.Keys);
                var welcome = XDocument.Parse(files["Welcome/WelcomeView.xaml"]);
                Assert.Contains(welcome.Descendants(), element => (string?)element.Attribute("Tag") == (string?)item.Attribute("Tag"));
            }
            Assert.DoesNotContain(files.Values, source => source.Contains("__", StringComparison.Ordinal));
            foreach (var page in files.Where(pair => pair.Key.EndsWith(".xaml", StringComparison.Ordinal)))
                _ = XDocument.Parse(page.Value);
            Assert.Equal(provider.RequiredPackages(request).Count, provider.RequiredPackages(request).Distinct().Count());
            if (selected.Length == 0)
            {
                Assert.DoesNotContain(files.Keys, path => path.EndsWith("Page.xaml", StringComparison.Ordinal));
                Assert.Equal(new[] { "Microsoft.WindowsAppSDK" }, provider.RequiredPackages(request));
            }
        }
    }
}
