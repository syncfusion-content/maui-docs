---
layout: post
title: Migrate from Xamarin to .NET MAUI TreeMap (SfTreeMap) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms TreeMap control to .NET MAUI TreeMap (SfTreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# Migrate from Xamarin.Forms TreeMap to .NET MAUI TreeMap (SfTreeMap)

To make the migration from the [Xamarin SfTreeMap](https://www.syncfusion.com/xamarin-ui-controls/xamarin-treemap) to the `.NET MAUI SfTreeMap` easier, most of the APIs from the `Xamarin SfTreeMap` were kept in the `.NET MAUI SfTreeMap`. However, to maintain the consistency of API naming in the `.NET MAUI SfTreeMap`, some of the APIs have been renamed. Please find the difference in the following topics.

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

To initialize the control, import the treeMap control namespace and initialize the `SfTreeMap` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th></tr>
<tr>
<td>

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:treemap="clr-namespace:Syncfusion.SfTreeMap.XForms;assembly=Syncfusion.SfTreeMap.XForms">
     <treemap:SfTreeMap x:Name="treeMap"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.TreeMap;
...

SfTreeMap treeMap = new SfTreeMap();
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

</td>
<td>

{% tabs %}
{% highlight XAML %}

<ContentPage 
...
xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"/>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TreeMap;
…

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
<td>{{'[SfTreeMap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html)'| markdownify }}</td>
<td>SfTreeMap</td>
<td>The SfTreeMap control that allows you to visually represent hierarchical data with nested rectangles, conveying quantitative information through variations in size and color.</td>
</tr>

<tr>
<td>Nil</td>
<td>TreeMapItemInfo</td>
<td>Contains item info for the selected item.</td>
</tr>

<tr>
<td>{{'[LeafItemSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html)'| markdownify }}</td>
<td>TreeMapLeafItemSettings</td>
<td>Represents settings for customizing the appearance of leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>Nil</td>
<td>LeafItemTemplate</td>
<td>Represents Leaf item template, for creating custom view for treemap leaf item.</td>
</tr>

<tr>
<td>Nil</td>
<td>ToolTipTemplate</td>
<td>Represents the tooltip template, for creating custom treemap tool tip template view.</td>
</tr>

<tr>
<td>{{'[LegendSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html)'| markdownify }}</td>
<td>TreeMapLegendSettings</td>
<td>Represents settings for customizing the appearance of legend items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[ColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.ColorMapping.html)'| markdownify }}</td>
<td>TreeMapBrushSettings</td>
<td>Provides base settings for brushes used in the SfTreeMap./></td>
</tr>

<tr>
<td>{{'[UniColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.UniColorMapping.html)'| markdownify }}</td>
<td>TreeMapUniformBrushSettings</td>
<td>Provides settings for assigning a single color to represent data uniformly in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[DesaturationColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html)'| markdownify }}</td>
<td>TreeMapDesaturationBrushSettings</td>
<td>Represents the settings for desaturation in the SfTreeMap control, allowing customization of the background brush and desaturation range.</td>
</tr>

<tr>
<td>{{'[PaletteColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.PaletteColorMapping.html)'| markdownify }}</td>
<td>TreeMapPaletteBrushSettings</td>
<td>Provides settings for customizing the palette brushes in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[RangeColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.RangeColorMapping.html)'| markdownify }}</td>
<td>TreeMapRangeBrushSettings</td>
<td>Provides settings for defining range based brushes in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Range](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html)'| markdownify }}</td>
<td>TreeMapRangeBrush</td>
<td>Represents the settings for defining a range brush in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html)'| markdownify }}</td>
<td>TreeMapToolTipSettings</td>
<td>Provides settings for configuring tool tips in the SfTreeMap./></td>
</tr>

<tr>
<td>{{'[TreeMapLevel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html)'| markdownify }}</td>
<td>TreeMapLevel</td>
<td>Represents a level in the hierarchical structure of the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[Style](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html)'| markdownify }}</td>
<td>TreeMapTextStyle</td>
<td> Gets or sets the style of SfTreeMap text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

</table> 


## Properties

### SfTreeMap

<table> 
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

{% tabs %}
{% highlight XAML hl_lines="5 6 7" %}
<ContentPage 
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="10" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.Content = treeMap;
    }
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
{% highlight C# tabtitle="PopulationDetails.cs"%}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}

<tr>
<td>{{'[DataSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_DataSource)'| markdownify }}</td>
<td>DataSource</td>
<td>Gets or sets the DataSource property. This property is used to retrieving data.</td>
</tr>

<tr>
<td>{{'[WeightValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_WeightValuePath)'| markdownify }}</td>
<td>PrimaryValuePath</td>
<td>Gets or sets the PrimaryValuePath property. This property is used to set the value path based on data item.</td>
</tr>

<tr>
<td>{{'[ColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_ColorValuePath)'| markdownify }}</td>
<td>RangeColorValuePath</td>
<td>Gets or sets the RangeColorValuePath property. This property is used to set the value path based on color value.</td>
</tr>

<tr>
<td>{{'[HightlightColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_HightlightColor)'| markdownify }}</td>
<td>SelectedItemStroke</td>
<td>Gets or sets the Selected Item Stroke property. This property is used to set the color to highlight the items.</td>
</tr>

<tr>
<td>{{'[HightlightBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_HightlightBorderWidth)'| markdownify }}</td>
<td>SelectedItemStrokeWidth</td>
<td>Gets or sets the Selected ItemStrokeThickness property. This property is used to customize the width of highlighted stroke.</td>
</tr>

<tr>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LayoutType)'| markdownify }}</td>
<td>LayoutType</td>
<td>Gets or sets the layoutType property. This property is used to customize the layout for tree map.</td>
</tr>

<tr>
<td>{{'[ItemTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_ItemTemplate)'| markdownify }}</td>
<td>LeafItemTemplate</td>
<td>Gets or sets the LeafItemtemplate property. This property is used to set data template.</td>
</tr>

<tr>
<td>{{'[LeafItemSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LeafItemSettings)'| markdownify }}</td>
<td>LeafItemSettings</td>
<td>Gets or sets the LeafItemSettings property. This property is used to customize the settings for leaf level.</td>
</tr>

<tr>
<td>{{'[LeafItemColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LeafItemColorMapping)'| markdownify }}</td>
<td>LeafItemBrushSettings</td>
<td>Gets or sets the LeafItemColorSettings property. This property is used to set color settings for leaf items.</td>
</tr>

<tr>
<td>{{'[LegendSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_LegendSettings)'| markdownify }}</td>
<td>LegendSettings</td>
<td>Gets or sets the Legendsettings property. This property is used to customize the settings for legend.</td>
</tr>

<tr>
<td>{{'[Levels](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_Levels)'| markdownify }}</td>
<td>Levels</td>
<td>Gets or sets the levels property. This property is an list collection of TreeMaplevel.</td>
</tr>

<tr>
<td>{{'[SelectedItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_SelectedItems)'| markdownify }}</td>
<td>SelectedItems</td>
<td>Gets the selected items property. This property is an collection of object.</td>
</tr>

<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_SelectionMode)'| markdownify }}</td>
<td>SelectionMode</td>
<td>Gets or sets the selection mode property. This property is used to customize the selection for tree map.</td>
</tr>

<tr>
<td>{{'[ShowTooltip](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_ShowTooltip)'| markdownify }}</td>
<td>ShowToolTip</td>
<td>Gets or sets a value indicating whether the tooltip should be enabled for tree map.</td>
</tr>

<tr>
<td>{{'[TooltipSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.html#Syncfusion_SfTreeMap_XForms_SfTreeMap_TooltipSettings)'| markdownify }}</td>
<td>ToolTipSettings</td>
<td>Gets or sets the tooltipsettings value to treemap.</td>
</tr>

<tr>
<td>{{'[TooltipTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_TooltipTemplate)'| markdownify }}</td>
<td>ToolTipTemplate</td>
<td>Gets or sets the tooltip template.</td>
</tr>

<tr>
<td>Nil</td>
<td>GroupItemBrushSettings</td>
<td>Gets or sets the settings for the group item brush, which is used to customize the group items in the SfTreeMap.</td>
</tr>

</table>

#### TreeMapItemInfo

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

<tr>
<td>Nil</td>
<td>Item</td>
<td>Gets or sets the item associated with the TreeMapItemInfo.</td>
</tr>

<tr>
<td>Nil</td>
<td>GroupLevel</td>
<td>Gets or sets the group level of the item.</td>
</tr>

<tr>
<td>Nil</td>
<td>Background</td>
<td>Gets the background brush for the item.</td>
</tr>

<tr>
<td>Nil</td>
<td>PrimaryValueText</td>
<td>Gets the primary value text of the item.</td>
</tr>

</table>

### TreeMapLeafItemSettings

{% tabs %}
{% highlight XAML hl_lines="11 12 13" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                                 Stroke="Black">
                </treemap:TreeMapLeafItemSettings>
            </treemap:SfTreeMap.LeafItemSettings>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country", Stroke = Brush.Black };
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th></tr>

<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_BorderColor)'| markdownify }}</td>
<td>Stroke</td>
<td>Gets or sets the stroke property. This property is used to set the leaf level item border color.</td>
</tr>

<tr>
<td>{{'[BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_BorderWidth)'| markdownify }}</td>
<td>StrokeWidth</td>
<td>Gets or sets the StrokeThickness property. This property is used to customize the width of tree map item.</td>
</tr>

<tr>
<td>{{'[Gap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_Gap)'| markdownify }}</td>
<td>Spacing</td>
<td>Gets or sets the Gap property. This property is used to set padding between leaf level items.</td>
</tr>

<tr>
<td>{{'[LabelPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_LabelPath)'| markdownify }}</td>
<td>LabelPath</td>
<td>Gets or sets the data label path property. This property is used to set in which path label should be applied</td>
</tr>

<tr>
<td>{{'[LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_LabelStyle)'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets the text style property. This is used to set different style labels.</td>
</tr>

<tr>
<td>{{'[OverflowMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LeafItemSettings.html#Syncfusion_SfTreeMap_XForms_LeafItemSettings_OverflowMode)'| markdownify }}</td>
<td>TextFormatOption</td>
<td>Gets or sets the TextFormatOption.</td>
</tr>

</table>

### TreeMapLegendSettings

{% tabs %}
{% highlight XAML hl_lines="15 16" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                                 Stroke="Black">
        </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
        <treemap:SfTreeMap.LegendSettings>
            <treemap:TreeMapLegendSettings ShowLegend="True">
            </treemap:TreeMapLegendSettings>
        </treemap:SfTreeMap.LegendSettings>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>ShowLegend</td>
<td>Gets or sets a value indicating whether the legend should be visible for tree map.</td>
</tr>

<tr>
<td>{{'[IconSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_IconSize)'| markdownify }}</td>
<td>IconSize</td>
<td>Gets or sets the IconSize property. This property is used to set size for the legend Icons.</td>
</tr>

<tr>
<td>{{'[LegendIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_LegendIcon)'| markdownify }}</td>
<td>IconType</td>
<td>Gets or sets the icon type property. This property is used to customize the icons.</td>
</tr>

<tr>
<td>{{'[LegendPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_LegendPosition)'| markdownify }}</td>
<td>Placement</td>
<td>Gets or sets the LegendPlacement property. This property is used to customize the position for legends.</td>
</tr>

<tr>
<td>{{'[Size](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_Size)'| markdownify }}</td>
<td>Size</td>
<td>Gets or sets the size property. This method is used to set the legend size.</td>
</tr>

<tr>
<td>{{'[LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendSettings.html#Syncfusion_SfTreeMap_XForms_LegendSettings_LabelStyle)'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets the text style property. This is used to set different style labels.</td>
</tr>

</table>

### TreeMapUniformBrushSettings

{% tabs %}
{% highlight XAML hl_lines="13 14" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country">
                    <treemap:SfTreeMap.LeafItemBrushSettings>
                    <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
                    </treemap:SfTreeMap.LeafItemBrushSettings>
        </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = Brush.Orange };
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>Brush</td>
<td>Gets or sets the color value for tree map item. This is used to set color for each tree map item.</td>
</tr>

</table>

### TreeMapDesaturationBrushSettings

{% tabs %}
{% highlight XAML hl_lines="13 14" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country">
                    <treemap:SfTreeMap.LeafItemBrushSettings>
                        <treemap:TreeMapDesaturationBrushSettings Brush="BlueViolet" From="1" To="0.2"/>
                    </treemap:SfTreeMap.LeafItemBrushSettings>
        </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.LeafItemBrushSettings = new TreeMapDesaturationBrushSettings() { Brush = Brush.BlueViolet, From = 1, To = 0.2 };
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>Brush</td>
<td>Gets or sets the color value for the tree map item. This is used to set color for each tree map item.</td>
</tr>

<tr>
<td>{{'[From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html#Syncfusion_SfTreeMap_XForms_DesaturationColorMapping_From)'| markdownify }}</td>
<td>From</td>
<td>Gets or sets the from value for desaturation. The From value is used to point where the desaturation starts.</td>
</tr>

<tr>
<td>{{'[To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.DesaturationColorMapping.html#Syncfusion_SfTreeMap_XForms_DesaturationColorMapping_To)'| markdownify }}</td>
<td>To</td>
<td>Gets or sets the two values for desaturation. The To value is used to point where the desaturation ends.</td>
</tr>

</table>

### TreeMapPaletteBrushSettings

{% tabs %}
{% highlight XAML hl_lines="14 15 16 17 18 19 20 21" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country">
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
        </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.LeafItemBrushSettings = new TreeMapPaletteBrushSettings()
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
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>Brushes</td>
<td>Gets or sets the color value for the tree map item. The Colors is a collection of colors.</td>
</tr>

</table>

### TreeMapRangeBrushSettings
To categorize leaf nodes in a TreeMap according to different ranges of background color values, use `TreeMapRangeBrushSettings`. Define the upper and lower limits of each range using the `To` and `From` properties of `TreeMapRangeBrush`.

#### TreeMapRangeBrush
{% tabs %}
{% highlight XAML hl_lines="14 15 16" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
        <treemap:SfTreeMap.LeafItemSettings>
            <treemap:TreeMapLeafItemSettings LabelPath="Country">
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
            </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
        <treemap:SfTreeMap.LegendSettings>
            <treemap:TreeMapLegendSettings ShowLegend="True">
            </treemap:TreeMapLegendSettings>
        </treemap:SfTreeMap.LegendSettings>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
        {
            RangeBrushes = new List<TreeMapRangeBrush>()
                {
                new TreeMapRangeBrush() { LegendLabel="50M - 1B", From=50000000, To=1000000000, Brush = new SolidColorBrush(Color.FromArgb("#F0A868")) },
                new TreeMapRangeBrush() { LegendLabel="10M - 50M", From=10000000, To=50000000, Brush = new SolidColorBrush(Color.FromArgb("#F3BC8B")) },
                new TreeMapRangeBrush() { LegendLabel="0.1M - 10M", From=100000, To=10000000, Brush = new SolidColorBrush(Color.FromArgb("#F8D7B9")) },
                }
        };
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>LegendLabel</td>
<td>Gets or sets the legend label for the tree map. This is used to describe the range of values.</td>
</tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_Color)'| markdownify }}</td>
<td>Brush</td>
<td>Gets or sets the Color value for range. This is used to set color for each range.</td>
</tr>

<tr>
<td>{{'[From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_From)'| markdownify }}</td>
<td>From</td>
<td>Gets or sets the from value for Range. The From value is used to point where the range starts.</td>
</tr>

<tr>
<td>{{'[To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Range.html#Syncfusion_SfTreeMap_XForms_Range_To)'| markdownify }}</td>
<td>To</td>
<td>Gets or sets the to value for Range. The To value is used to point where the range ends.</td>
</tr>

</table>


### TreeMapToolTipSettings

{% tabs %}
{% highlight XAML hl_lines="14 15" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    ShowToolTip="True"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country">
                    <treemap:SfTreeMap.LeafItemBrushSettings>
                    <treemap:TreeMapUniformBrushSettings Brush="#F8D7B9"/>
                    </treemap:SfTreeMap.LeafItemBrushSettings>
        </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
        <treemap:SfTreeMap.ToolTipSettings >
            <treemap:TreeMapToolTipSettings Background = "Red" />
        </treemap:SfTreeMap.ToolTipSettings >
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.ToolTipSettings = new TreeMapToolTipSettings() { Background = Brush.Red };
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>Background</td>
<td>Gets or sets the background color.</td>
</tr>

<tr>
<td>{{'[Duration](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_Duration)'| markdownify }}</td>
<td>Duration</td>
<td>Gets or sets a value to specify the duration time in seconds for which tooltip will be displayed.</td>
</tr>

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_TextColor)'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets to customize the text style.</td>
</tr>

<tr>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TooltipSetting.html#Syncfusion_SfTreeMap_XForms_TooltipSetting_StrokeColor)'| markdownify }}</td>
<td>Stroke</td>
<td>Gets or sets the stroke color.</td>
</tr>

</table>

### TreeMapLevel

{% tabs %}
{% highlight XAML hl_lines="18 19" %}
<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country">
                    <treemap:SfTreeMap.LeafItemBrushSettings>
                    <treemap:TreeMapUniformBrushSettings Brush="#F8D7B9"/>
                    </treemap:SfTreeMap.LeafItemBrushSettings>
            </treemap:TreeMapLeafItemSettings>
        </treemap:SfTreeMap.LeafItemSettings>
        <treemap:SfTreeMap.Levels>
            <treemap:TreeMapLevel GroupPath="Continent"/>
        </treemap:SfTreeMap.Levels>
    </treemap:SfTreeMap>
</ContentPage>
{% endhighlight %}

{% highlight C# hl_lines="11" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        PopulationViewModel viewModel = new PopulationViewModel();
        treeMap.DataSource = viewModel.PopulationDetails;
        this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent"});
        this.Content = treeMap;
    }
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
{% highlight c# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
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
<td>GroupPath</td>
<td>Gets or sets the Header path property. This property is used to set the path for header of the tree map.</td>
</tr>

<tr>
<td>{{'[GroupBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupBackground)'| markdownify }}</td>
<td>Background</td>
<td>Gets or sets the Group Background color property. This property is used to set the backround</td>
</tr>

<tr>
<td>{{'[GroupBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupBorderColor)'| markdownify }}</td>
<td>Stroke</td>
<td>Gets or sets the Group Border Color property. This property is used to set color for the group of the tree map. This is a bindable property.</td>
</tr>

<tr>
<td>{{'[GroupBorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupBorderThickness)'| markdownify }}</td>
<td>StrokeWidth</td>
<td>Gets or sets the Group Border Thickness property. This property is used to set thickness for the groups of the tree map.</td>
</tr>

<tr>
<td>{{'[GroupGap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapFlatLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapFlatLevel_GroupGap)'| markdownify }}</td>
<td>Spacing</td>
<td>Gets or sets the Group Gap property. This property is used to customize the gap between the groups of the tree map.</td>
</tr>

<tr>
<td>{{'[HeaderStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapLevel_HeaderStyle)'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets the customize the text property.</td>
</tr>

<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.TreeMapLevel.html#Syncfusion_SfTreeMap_XForms_TreeMapLevel_HeaderHeight)'| markdownify }}</td>
<td>HeaderHeight</td>
<td>Gets or sets the HeaderHeight property. This property is used to set the height of the header for the tree map.</td>
</tr>

</table>

### TreeMapTextStyle
The `FontColor`, `FontSize`, `FontFamily`, and `FontAttributes` properties of the `SfTreeMap` is grouped to `TreeMapTextStyle`.

<table>
<tr>
<th>Xamarin SfTreeMap control</th>
<th>.NET MAUI SfTreeMap control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_Color)'| markdownify }}</td>
<td>TextColor</td>
<td>Gets or sets the text color for the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_FontSize)'| markdownify }}</td>
<td>FontSize</td>
<td>Gets or sets the double value that represents the font size of the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_FontFamily)'| markdownify }}</td>
<td>FontFamily</td>
<td>Gets or sets the string, that represents font family of the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.Style.html#Syncfusion_SfTreeMap_XForms_Style_FontAttributes)'| markdownify }}</td>
<td>FontAttributes</td>
<td>Gets or sets the FontAttributes of the SfTreeMap control.</td>
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
<td>TextFormatOption</td>
<td>Specifies text formatting options for tree map leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LayoutTypes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LayoutTypes.html)'| markdownify }}</td>
<td>LayoutType</td>
<td>Specifies the layout type of algorithm used to arrange the items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[LegendPositions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendPositions.html)'| markdownify }}</td>
<td>LegendPlacement</td>
<td>Represents the legend placement to customize the legend position.</td>
</tr>

<tr>
<td>{{'[LegendIcons](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.LegendIcons.html)'| markdownify }}</td>
<td>LegendIconType</td>
<td>Specifies the shape of icons used in legends for the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SelectionMode.html)'| markdownify }}</td>
<td>SelectionMode</td>
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
<td>{{'[TreeMapItemSelectedEventHandler](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeMap.XForms.SfTreeMap.TreeMapItemSelectedEventHandler.html)'| markdownify }}</td>
<td>SelectionChanged</td>
<td>Provides data for the event when the selection is changed in the SfTreeMap.</td>
</tr>
</table>

## Upcoming features

* Drill down support.
* RTL support.
* Legend template support.
