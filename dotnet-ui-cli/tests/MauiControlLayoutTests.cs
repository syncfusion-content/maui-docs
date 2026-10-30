using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Maui;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

public sealed class MauiControlLayoutTests
{
    [Fact]
    public void EverySampleFillsABoundedGridWithoutOverridingThemeColors()
    {
        foreach (var entry in TemplateCatalog.Operable)
        {
            var file = Assert.Single(entry.GeneratedFiles, file => file.Destination.EndsWith(".xaml", StringComparison.Ordinal));
            var source = EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource));
            var page = XDocument.Parse(source).Root!;
            var layout = Assert.Single(page.Elements(), element => element.Name.LocalName == "Grid");
            Assert.EndsWith("*", (string?)layout.Attribute("RowDefinitions"));
            Assert.Equal("*", (string?)layout.Attribute("ColumnDefinitions"));
            var control = Assert.Single(layout.Elements(), element => element.Name.LocalName.StartsWith("Sf", StringComparison.Ordinal));
            Assert.Equal("Fill", (string?)control.Attribute("HorizontalOptions"));
            Assert.Equal("Fill", (string?)control.Attribute("VerticalOptions"));
            Assert.DoesNotContain(page.DescendantsAndSelf().Attributes(), attribute =>
                attribute.Name.LocalName.Contains("Color", StringComparison.OrdinalIgnoreCase)
                || attribute.Name.LocalName is "Background" or "Brush" or "Fill" or "Stroke" or "PaletteBrushes" or "HeightRequest" or "WidthRequest");
            Assert.DoesNotContain(layout.AncestorsAndSelf(), element => element.Name.LocalName is "ScrollView" or "StackLayout" or "VerticalStackLayout");
        }
    }

    [Fact]
    public void ControlSourcesDoNotCreateCustomColorsOrBrushes()
    {
        foreach (var entry in TemplateCatalog.Operable)
        {
            foreach (var file in entry.GeneratedFiles.Where(file => file.Destination.EndsWith(".cs", StringComparison.Ordinal)))
            {
                var source = EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource));
                Assert.DoesNotMatch(@"\b(?:Colors|Brush|Brushes)\s*\.|\bColor\.From\w+|\bnew\s+(?:Color|SolidColorBrush|LinearGradientBrush|RadialGradientBrush)\b", source);
            }
        }
    }

    [Theory]
    [InlineData("cartesian-chart")]
    [InlineData("circular-chart")]
    public void ChartHeadingsAreCenteredAcrossThePageWithoutColorOverrides(string id)
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate(id, out var entry));
        var file = Assert.Single(entry.GeneratedFiles, file => file.Destination.EndsWith(".xaml", StringComparison.Ordinal));
        var page = XDocument.Parse(EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource)));
        var layout = Assert.Single(page.Root!.Elements(), element => element.Name.LocalName == "Grid");
        Assert.Equal("Auto,*", (string?)layout.Attribute("RowDefinitions"));
        var title = Assert.Single(layout.Elements(), element => element.Name.LocalName == "Label");
        Assert.Equal("Fill", (string?)title.Attribute("HorizontalOptions"));
        Assert.Equal("Center", (string?)title.Attribute("HorizontalTextAlignment"));
        Assert.Equal("24", (string?)title.Attribute("FontSize"));
        Assert.Equal("1", (string?)Assert.Single(layout.Elements(), element => element.Name.LocalName.StartsWith("Sf", StringComparison.Ordinal)).Attribute("Grid.Row"));
    }

    [Fact]
    public void GridColumnsFillAvailableWidthAndHaveReadableMinimumSizes()
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("datagrid", out var entry));
        var file = Assert.Single(entry.GeneratedFiles, file => file.Destination.EndsWith(".xaml", StringComparison.Ordinal));
        var page = XDocument.Parse(EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource)));
        var grid = Assert.Single(page.Descendants(), element => element.Name.LocalName == "SfDataGrid");
        Assert.Equal("Fill", (string?)grid.Attribute("ColumnWidthMode"));
        var columns = grid.Elements().Single(element => element.Name.LocalName == "SfDataGrid.Columns").Elements().ToArray();
        Assert.Equal(10, columns.Length);
        Assert.All(columns, column => Assert.True(double.Parse(column.Attribute("MinimumWidth")!.Value, System.Globalization.CultureInfo.InvariantCulture) >= 100));
    }

    [Fact]
    public void ListRowsUseCompiledBindingsAndWrapTextForNarrowScreens()
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("listview", out var entry));
        var file = Assert.Single(entry.GeneratedFiles, file => file.Destination.EndsWith(".xaml", StringComparison.Ordinal));
        var page = XDocument.Parse(EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource)));
        var template = Assert.Single(page.Descendants(), element => element.Name.LocalName == "DataTemplate");
        Assert.Equal("local:ListViewModel", (string?)template.Attribute(XName.Get("DataType", "http://schemas.microsoft.com/winfx/2009/xaml")));
        var list = Assert.Single(page.Descendants(), element => element.Name.LocalName == "SfListView");
        Assert.Equal("DynamicHeight", (string?)list.Attribute("AutoFitMode"));
        Assert.Null(list.Attribute("ItemSize"));
        Assert.All(template.Descendants().Where(element => element.Name.LocalName == "Label"), label =>
        {
            Assert.Null(label.Attribute("MaxLines"));
            Assert.Equal("WordWrap", (string?)label.Attribute("LineBreakMode"));
        });
    }
}
