---
layout: post
title: Migrate from Xamarin to .NET MAUI TreeMap (SfTreeMap) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms TreeMap control to .NET MAUI TreeMap (SfTreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# Migrate from Xamarin.Forms TreeMap to .NET MAUI TreeMap (SfTreeMap)

To make the migration from the [Xamarin SfTreeMap](https://www.syncfusion.com/xamarin-ui-controls/xamarin-treemap) to the [.NET MAUI SfTreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) easier, most of the APIs from the `Xamarin SfTreeMap` were kept in the `.NET MAUI SfTreeMap`. However, to maintain the consistency of API naming in the `.NET MAUI SfTreeMap`, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces

<table>
<tr>
<th>Xamarin SfTreeMap</th>
<th>.NET MAUI SfTreeMap</th></tr>
<tr>
<td>Syncfusion.Xamarin.SfTreeMap</td>
<td>Syncfusion.Maui.TreeMap</td></tr>
</table>

## Initialize Control

To initialize the control, import the treeMap control namespace and initialize the [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html) as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th></tr>
<tr>
<td>

{% tabs %}
{% highlight XAML hl_lines="3 5" %}

<ContentPage 
    ...
    xmlns:treemap="clr-namespace:Syncfusion.SfTreeMap.XForms;assembly=Syncfusion.SfTreeMap.XForms">

    <treemap:SfTreeMap x:Name="treeMap"/>
</ContentPage>

{% endhighlight %}

{% highlight C# hl_lines="1 4 5" %}

using Syncfusion.SfTreeMap.XForms;
...

SfTreeMap treeMap = new SfTreeMap();
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

</td>
<td>

{% tabs %}
{% highlight XAML hl_lines="3 5" %}

<ContentPage 
    ...
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">

    <treemap:SfTreeMap x:Name="treeMap"/>
</ContentPage>

{% endhighlight %}

{% highlight C# hl_lines="1 4 5" %}

using Syncfusion.Maui.TreeMap;
...

SfTreeMap treeMap = new SfTreeMap();
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[LeafItemSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html)'| markdownify }}</td>
<td>{{'[TreeMapLeafItemSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html)'| markdownify }}</td>
<td>Represents settings for customizing the appearance of leaf items in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[LegendSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html)'| markdownify }}</td>
<td>{{'[TreeMapLegendSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html)'| markdownify }}</td>
<td>Represents settings for customizing the appearance of legend items in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[ColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.ColorMapping.html)'| markdownify }}</td>
<td>{{'[TreeMapBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapBrushSettings.html)'| markdownify }}</td>
<td>Provides base settings for brushes used in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[UniColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.UniColorMapping.html)'| markdownify }}</td>
<td>{{'[TreeMapUniformBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapUniformBrushSettings.html)'| markdownify }}</td>
<td>Provides settings for assigning a single color to represent data uniformly in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[DesaturationColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html)'| markdownify }}</td>
<td>{{'[TreeMapDesaturationBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapDesaturationBrushSettings.html)'| markdownify }}</td>
<td>Represents the settings for desaturation in the SfTreeMap control, allowing customization of the background brush and desaturation range.</td>
</tr>
<tr>
<td>{{'[PaletteColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.PaletteColorMapping.html)'| markdownify }}</td>
<td>{{'[TreeMapPaletteBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapPaletteBrushSettings.html)'| markdownify }}</td>
<td>Provides settings for customizing the palette brushes in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[RangeColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.RangeColorMapping.html)'| markdownify }}</td>
<td>{{'[TreeMapRangeBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrushSettings.html)'| markdownify }}</td>
<td>Provides settings for defining range based brushes in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[Range](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html)'| markdownify }}</td>
<td>{{'[TreeMapRangeBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html)'| markdownify }}</td>
<td>Represents the settings for defining a range brush in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html)'| markdownify }}</td>
<td>{{'[TreeMapToolTipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html)'| markdownify }}</td>
<td>Provides settings for configuring tool tips in the SfTreeMap.</td>
</tr>
<tr>
<td>{{'[TreeMapLevel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html)'| markdownify }}</td>
<td>{{'[TreeMapLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html)'| markdownify }}</td>
<td>Represents a level in the hierarchical structure of the SfTreeMap.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[TreeMapItemInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapItemInfo.html)'| markdownify }}</td>
<td>Represents the collection of currently selected tree map items in the SfTreeMap control. The TreeMapItemInfo property is set as the binding context for tooltips and leaf item templates.</td>
</tr>
<tr>
<td>{{'[Style](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html)'| markdownify }}</td>
<td>{{'[TreeMapTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapTextStyle.html)'| markdownify }}</td>
<td> Gets or sets the style of tree map item text, that is used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
</table>

## Properties

### SfTreeMap

The following code example, explains how to initialize the properties of the .NET MAUI SfTreeMap class.

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

{% tabs %}
{% highlight XAML hl_lines="2 3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="3 4" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<tr>
<td>{{'[DataSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_DataSource)'| markdownify }}</td>
<td>{{'[DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DataSource)'| markdownify }}</td>
<td>Gets or sets a collection used to generate the item in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[WeightValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_WeightValuePath)'| markdownify }}</td>
<td>{{'[PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath)'| markdownify }}</td>
<td>Gets or sets the name of the property in the data object that provides the primary value for each item in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[ColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_ColorValuePath)'| markdownify }}</td>
<td>{{'[RangeColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_RangeColorValuePath)'| markdownify }}</td>
<td>Gets or sets the name of the property in the data object that provides the range color value for each item in the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[HightlightColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_HightlightColor)'| markdownify }}</td>
<td>{{'[SelectedItemStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectedItemStroke)'| markdownify }}</td>
<td>Gets or sets the stroke color for the selected item in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[HightlightBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_HightlightBorderWidth)'| markdownify }}</td>
<td>{{'[SelectedItemStrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectedItemStrokeWidth)'| markdownify }}</td>
<td>Gets or sets the stroke width for the selected item in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LayoutType)'| markdownify }}</td>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LayoutType)'| markdownify }}</td>
<td>Gets or sets the layout type used to arrange items using a specific layout algorithm.</td>
</tr>

<tr>
<td>{{'[ItemTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_ItemTemplate)'| markdownify }}</td>
<td>{{'[LeafItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemTemplate)'| markdownify }}</td>
<td>Gets or sets the data template to use for customizing the appearance of individual leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LeafItemSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LeafItemSettings)'| markdownify }}</td>
<td>{{'[LeafItemSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemSettings)'| markdownify }}</td>
<td>Gets or sets the settings for the leaf item, which is used to customize the stroke color, stroke width, text style, spacing between items, and text format option in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LeafItemColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LeafItemColorMapping)'| markdownify }}</td>
<td>{{'[LeafItemBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemBrushSettings)'| markdownify }}</td>
<td>Gets or sets the settings for the leaf item brush, which is used to customize the leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LegendSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LegendSettings)'| markdownify }}</td>
<td>{{'[LegendSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LegendSettings)'| markdownify }}</td>
<td>Gets or sets the settings for the legend, which is used to customize the icon size, text style, icon type, placement, show legend and legend size in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Levels](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_Levels)'| markdownify }}</td>
<td>{{'[Levels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_Levels)'| markdownify }}</td>
<td>Gets or sets the collection of levels defining the hierarchical structure for grouped visualization of data in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[SelectedItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_SelectedItems)'| markdownify }}</td>
<td>{{'[SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectedItems)'| markdownify }}</td>
<td>Gets or sets the collection of tree map item representing the currently selected items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_SelectionMode)'| markdownify }}</td>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectionMode)'| markdownify }}</td>
<td>Gets or sets the selection mode for the SfTreeMap. This property is used to customize the selection for tree map.</td>
</tr>

<tr>
<td>{{'[ShowTooltip](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_ShowTooltip)'| markdownify }}</td>
<td>{{'[ShowToolTip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ShowToolTip)'| markdownify }}</td>
<td>Gets or sets a value indicating whether tool tips are displayed for items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[TooltipSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_TooltipSettings)'| markdownify }}</td>
<td>{{'[ToolTipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ToolTipSettings)'| markdownify }}</td>
<td>Gets or sets the settings for the tool tips, which is used to customize the background, duration, stroke, and text style in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[TooltipTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_TooltipTemplate)'| markdownify }}</td>
<td>{{'[ToolTipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ToolTipTemplate)'| markdownify }}</td>
<td>Gets or sets the data template to use for customizing the appearance of tool tips for items in the SfTreeMap.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[GroupItemBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_GroupItemBrushSettings)'| markdownify }}</td>
<td> Gets or sets the settings for the group item brush, which is used to customize the group items in the SfTreeMap.</td>
</tr>

</table>

### TreeMapItemInfo

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Item](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapItemInfo.html#Syncfusion_Maui_TreeMap_TreeMapItemInfo_Item)'| markdownify }}</td>
<td>Gets or sets the item associated with the TreeMapItemInfo.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[GroupLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapItemInfo.html#Syncfusion_Maui_TreeMap_TreeMapItemInfo_GroupLevel)'| markdownify }}</td>
<td>Gets or sets the group level of the item.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapItemInfo.html#Syncfusion_Maui_TreeMap_TreeMapItemInfo_Background)'| markdownify }}</td>
<td>Gets the background brush for the item.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[PrimaryValueText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapItemInfo.html#Syncfusion_Maui_TreeMap_TreeMapItemInfo_PrimaryValueText)'| markdownify }}</td>
<td>Gets the primary value text of the item.</td>
</tr>
</table>

### LeafItemSettings

The following code example, explains how to configure the leaf item settings in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="7 8 9 10" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="5" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = Brush.Orange };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_BorderColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color for the leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_BorderWidth)'| markdownify }}</td>
<td>{{'[StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_StrokeWidth)'| markdownify }}</td>
<td>Gets or sets the width of the stroke for the leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Gap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_Gap)'| markdownify }}</td>
<td>{{'[Spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_Spacing)'| markdownify }}</td>
<td>Gets or sets the spacing between the leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LabelPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_LabelPath)'| markdownify }}</td>
<td>{{'[LabelPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_LabelPath)'| markdownify }}</td>
<td>Gets or sets the path of the label for the leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_LabelStyle)'| markdownify }}</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_TextStyle)'| markdownify }}</td>
<td>Gets or sets the style of leaf item text, that is used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>{{'[OverflowMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_OverflowMode)'| markdownify }}</td>
<td>{{'[TextFormatOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_TextFormatOption)'| markdownify }}</td>
<td>Gets or sets the text format option for the leaf items in the SfTreeMap.</td>
</tr>

</table>

### LegendSettings

The following code example, explains how to configure the legend settings in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="12 13 14 15" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LegendSettings>
    <treemap:TreeMapLegendSettings ShowLegend="True">
    </treemap:TreeMapLegendSettings>
    </treemap:SfTreeMap.LegendSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:TreeMapRangeBrushSettings>
        <treemap:TreeMapRangeBrushSettings.RangeBrushes>
            <treemap:TreeMapRangeBrush LegendLabel="50M - 1B"
                                       From="50000000"
                                       To="1000000000" 
                                       Brush ="#F0A868" />
            <treemap:TreeMapRangeBrush LegendLabel="10M - 50M"
                                       From="10000000"
                                       To="50000000" 
                                       Brush ="#F3BC8B" />
            <treemap:TreeMapRangeBrush LegendLabel="0.1M - 10M"
                                       From="100000" 
                                       To="10000000"  
                                       Brush= "#F8D7B9" />
        </treemap:TreeMapRangeBrushSettings.RangeBrushes>
      </treemap:TreeMapRangeBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="7" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.RangeColorValuePath = "Population";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
{
    RangeBrushes = new List<TreeMapRangeBrush>()
    {
        new TreeMapRangeBrush { LegendLabel = "50M - 1B", From = 50000000, To = 1000000000, Brush = new SolidColorBrush(Color.FromArgb("#F0A868")) },
        new TreeMapRangeBrush { LegendLabel = "10M - 50M", From = 10000000, To = 50000000, Brush = new SolidColorBrush(Color.FromArgb("#F3BC8B")) },
        new TreeMapRangeBrush { LegendLabel = "0.1M - 10M", From = 100000, To = 10000000, Brush = new SolidColorBrush(Color.FromArgb("#F8D7B9")) },
    }
};

this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[ShowLegend](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_ShowLegend)'| markdownify }}</td>
<td>{{'[ShowLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_ShowLegend)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the legend is enabled in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[IconSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_IconSize)'| markdownify }}</td>
<td>{{'[IconSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_IconSize)'| markdownify }}</td>
<td>Gets or sets the size of the legend icons in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LegendIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_LegendIcon)'| markdownify }}</td>
<td>{{'[IconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_IconType)'| markdownify }}</td>
<td>Gets or sets the type of icons to be used for the legend in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LegendPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_LegendPosition)'| markdownify }}</td>
<td>{{'[Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_Placement)'| markdownify }}</td>
<td>Gets or sets the placement of the legend with in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Size](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_Size)'| markdownify }}</td>
<td>{{'[Size](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_Size)'| markdownify }}</td>
<td>Gets or sets the size of the legend layout in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_LabelStyle)'| markdownify }}</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_TextStyle)'| markdownify }}</td>
<td>Gets or sets the style of legend item text, that is used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

</table>

### UniformBrushSettings

The following code example, explains how to configure the uniform brush settings in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="11 12 13" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="5" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = Brush.Orange };
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.UniColorMapping.html#Syncfusion_SfTreeMap_XForms_UniColorMapping_Color)'| markdownify }}</td>
<td>{{'[Brush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapUniformBrushSettings.html#Syncfusion_Maui_TreeMap_TreeMapUniformBrushSettings_Brush)'| markdownify }}</td>
<td>Gets or sets the background brush for the tree map leaf items in the SfTreeMap.</td>
</tr>

</table>

### DesaturationBrushSettings

The following code example, explains how to configure the desaturation brush settings in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="11 12 13" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
    </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapDesaturationBrushSettings Brush="BlueViolet" From="1" To="0.2"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="6" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.LeafItemBrushSettings = new TreeMapDesaturationBrushSettings() { Brush = Brush.BlueViolet, From = 1, To = 0.2 };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html#Syncfusion_SfTreeMap_XForms_DesaturationColorMapping_Color)'| markdownify }}</td>
<td>{{'[Brush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapDesaturationBrushSettings.html#Syncfusion_Maui_TreeMap_TreeMapDesaturationBrushSettings_Brush)'| markdownify }}</td>
<td>Gets or sets the background brush for the desaturation in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html#Syncfusion_SfTreeMap_XForms_DesaturationColorMapping_From)'| markdownify }}</td>
<td>{{'[From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapDesaturationBrushSettings.html#Syncfusion_Maui_TreeMap_TreeMapDesaturationBrushSettings_From)'| markdownify }}</td>
<td>Gets or sets the starting value for the desaturation range in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html#Syncfusion_SfTreeMap_XForms_DesaturationColorMapping_To)'| markdownify }}</td>
<td>{{'[To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapDesaturationBrushSettings.html#Syncfusion_Maui_TreeMap_TreeMapDesaturationBrushSettings_To)'| markdownify }}</td>
<td>Gets or sets the ending value for the desaturation range in the SfTreeMap.</td>
</tr>

</table>

### PaletteBrushSettings

The following code example, explains how to configure the palette brush settings in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="12 13 14 15 16 17 18 19 20 21 22 23" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapPaletteBrushSettings>
            <treemap:TreeMapPaletteBrushSettings.Brushes>
                <SolidColorBrush>#116DF9</SolidColorBrush>
                <SolidColorBrush>#9215F3</SolidColorBrush>
                <SolidColorBrush>#F4890B</SolidColorBrush>
                <SolidColorBrush>#D21243</SolidColorBrush>
                <SolidColorBrush>#E2227E</SolidColorBrush>
                <SolidColorBrush>#9215F3</SolidColorBrush>
            </treemap:TreeMapPaletteBrushSettings.Brushes>
        </treemap:TreeMapPaletteBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="7 8 9 10 11 12 13 14 15 16 17 18" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.RangeColorValuePath = "Population";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.LeafItemBrushSettings = new TreeMapPaletteBrushSettings()
{
    Brushes = new List<Brush>()
    {
        new SolidColorBrush(Color.FromArgb("#116DF9")),
        new SolidColorBrush(Color.FromArgb("#9215F3")),
        new SolidColorBrush(Color.FromArgb("#F4890B")),
        new SolidColorBrush(Color.FromArgb("#D21243")),
        new SolidColorBrush(Color.FromArgb("#E2227E")),
        new SolidColorBrush(Color.FromArgb("#9215F3")),
    }
};

this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[Colors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.PaletteColorMapping.html#Syncfusion_SfTreeMap_XForms_PaletteColorMapping_Colors)'| markdownify }}</td>
<td>{{'[Brushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapPaletteBrushSettings.html#Syncfusion_Maui_TreeMap_TreeMapPaletteBrushSettings_Brushes)'| markdownify }}</td>
<td>Gets or sets the list of brushes used for the palette in the SfTreeMap.</td>
</tr>

</table>

### RangeBrushSettings

To categorize leaf items in a TreeMap according to different ranges of background color values, use [TreeMapRangeBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrushSettings.html). Define the upper and lower limits of each range using the [To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_To) and [From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_From) properties of [TreeMapRangeBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html).

#### RangeBrush

The following code example explains how to configure the range brush in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapRangeBrushSettings>
            <treemap:TreeMapRangeBrushSettings.RangeBrushes>
                <treemap:TreeMapRangeBrush LegendLabel="50M - 1B"
                                           From="50000000"
                                           To="1000000000" 
                                           Brush ="#F0A868" />
                <treemap:TreeMapRangeBrush LegendLabel="10M - 50M"
                                           From="10000000"
                                           To="50000000" 
                                           Brush ="#F3BC8B" />
                <treemap:TreeMapRangeBrush LegendLabel="0.1M - 10M"
                                           From="100000" 
                                           To="10000000"  
                                           Brush= "#F8D7B9" />
            </treemap:TreeMapRangeBrushSettings.RangeBrushes>
        </treemap:TreeMapRangeBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.LegendSettings>
        <treemap:TreeMapLegendSettings ShowLegend="True">
        </treemap:TreeMapLegendSettings>
    </treemap:SfTreeMap.LegendSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="7 8 9 10 11 12 13 14 15" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.RangeColorValuePath = "Population";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
{
    RangeBrushes = new List<TreeMapRangeBrush>()
    {
        new TreeMapRangeBrush() { LegendLabel="50M - 1B", From=50000000, To=1000000000, Brush = new SolidColorBrush(Color.FromArgb("#F0A868")) },
        new TreeMapRangeBrush() { LegendLabel="10M - 50M", From=10000000, To=50000000, Brush = new SolidColorBrush(Color.FromArgb("#F3BC8B")) },
        new TreeMapRangeBrush() { LegendLabel="0.1M - 10M", From=100000, To=10000000, Brush = new SolidColorBrush(Color.FromArgb("#F8D7B9")) },
    }
};

treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[LegendLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_LegendLabel)'| markdownify }}</td>
<td>{{'[LegendLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_LegendLabel)'| markdownify }}</td>
<td>Gets or sets the text for the legend item associated with the range in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_Color)'| markdownify }}</td>
<td>{{'[Brush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_Brush)'| markdownify }}</td>
<td>Gets or sets the background brush for the range in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_From)'| markdownify }}</td>
<td>{{'[From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_From)'| markdownify }}</td>
<td>Gets or sets the starting value of the range for the background brush in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_To)'| markdownify }}</td>
<td>{{'[To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_To)'| markdownify }}</td>
<td>Gets or sets the ending value of the range for the background brush in the SfTreeMap.</td>
</tr>

</table>

### ToolTipSettings

The following code example, explains how to configure the tooltip setting in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="4 15 16 17" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   ShowToolTip="True">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
    </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.ToolTipSettings >
        <treemap:TreeMapToolTipSettings Background = "Red" />
    </treemap:SfTreeMap.ToolTipSettings >
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="5 8" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.ShowToolTip = true;
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = Brush.Orange };
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.ToolTipSettings = new TreeMapToolTipSettings() { Background = Brush.Red };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_BackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_Background)'| markdownify }}</td>
<td>Gets or sets the background brush for tool tips in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Duration](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_Duration)'| markdownify }}</td>
<td>{{'[Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_Duration)'| markdownify }}</td>
<td>Gets or sets the duration for which tool tips are displayed in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_TextColor)'| markdownify }}</td>
<td>{{'[TextColor (From TextStyle of ToolTipSettings class)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_TextStyle)'| markdownify }}</td>
<td>Gets or sets the style of tool tips text, that is used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_StrokeColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_Duration)'| markdownify }}</td>
<td>Gets or sets the stroke color for the tool tips in the SfTreeMap.</td>
</tr>

</table>

### Levels

The following code example, explains how to configure the tree map level in .NET MAUI SfTreeMap control.

{% tabs %}
{% highlight XAML hl_lines="14 15 16" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.Levels>
       <treemap:TreeMapLevel GroupPath="Continent"/>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="7" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = Brush.Orange };
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent"});
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[LabelPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapLevel_LabelPath)'| markdownify }}</td>
<td>{{'[GroupPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_GroupPath)'| markdownify }}</td>
<td>Gets or sets the property path used for grouping tree map items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[GroupBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupBackground)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_Background)'| markdownify }}</td>
<td>Gets or sets the background brush for the tree map header items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[GroupBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupBorderColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color for the tree map header items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[GroupBorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupBorderThickness)'| markdownify }}</td>
<td>{{'[StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_StrokeWidth)'| markdownify }}</td>
<td>Gets or sets the width of the stroke for the tree map header items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[GroupGap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupGap)'| markdownify }}</td>
<td>{{'[Spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_Spacing)'| markdownify }}</td>
<td>Gets or sets the spacing between the tree map header items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[HeaderStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapLevel_HeaderStyle)'| markdownify }}</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_TextStyle)'| markdownify }}</td>
<td>Gets or sets the style of header item text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapLevel_HeaderHeight)'| markdownify }}</td>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLevel.html#Syncfusion_Maui_TreeMap_TreeMapLevel_HeaderHeight)'| markdownify }}</td>
<td>Gets or sets the height of the header for each level in the SfTreeMap.</td>
</tr>

</table>

### TextStyle

The `FontColor`, `FontSize`, `FontFamily`, and `FontAttributes` properties of the `SfTreeMap` is grouped to [TreeMapTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapTextStyle.html).

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_Color)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapTextStyle.html#Syncfusion_Maui_TreeMap_TreeMapTextStyle_TextColor)'| markdownify }}</td>
<td>Gets or sets the text color for the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapTextStyle.html#Syncfusion_Maui_TreeMap_TreeMapTextStyle_FontSize)'| markdownify }}</td>
<td>Gets or sets the double value that represents the font size of the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapTextStyle.html#Syncfusion_Maui_TreeMap_TreeMapTextStyle_FontFamily)'| markdownify }}</td>
<td>Gets or sets the string, that represents font family of the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapTextStyle.html#Syncfusion_Maui_TreeMap_TreeMapTextStyle_FontAttributes)'| markdownify }}</td>
<td>Gets or sets the FontAttributes of the SfTreeMap.</td>
</tr>

</table>

## Enum

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[LabelOverflowMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LabelOverflowMode.html)'| markdownify }}</td>
<td>{{'[TextFormatOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TextFormatOption.html)'| markdownify }}</td>
<td>Specifies text formatting options for tree map leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LayoutTypes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LayoutTypes.html)'| markdownify }}</td>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html)'| markdownify }}</td>
<td>Specifies the layout type of algorithm used to arrange the items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LegendPositions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendPositions.html)'| markdownify }}</td>
<td>{{'[LegendPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LegendPlacement.html)'| markdownify }}</td>
<td>Represents the legend placement to customize the legend position.</td>
</tr>

<tr>
<td>{{'[LegendIcons](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendIcons.html)'| markdownify }}</td>
<td>{{'[LegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LegendIconType.html)'| markdownify }}</td>
<td>Specifies the shape of icons used in legends for the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SelectionMode.html)'| markdownify }}</td>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SelectionMode.html)'| markdownify }}</td>
<td>Specifies the selection mode for the tree map items in the SfTreeMap.</td>
</tr>

</table>

## Event

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[ItemSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.TreeMapItemSelectedEventHandler.html)'| markdownify }}</td>
<td>SelectionChanged</td>
<td>Occurs when the selection within the tree map item is changed.</td>
</tr>
</table>

## Upcoming features

* Legend template support.
* Drill down support.
* RTL support.