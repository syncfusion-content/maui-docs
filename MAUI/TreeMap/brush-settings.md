---
layout: post
title: Enhancing visuals with Brush Settings in .NET MAUI TreeMap | Syncfusion
description: Learn how to enhance visual appeal and data interpretation with versatile brush settings of Syncfusion .NET MAUI TreeMap(STreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# TreeMap leaf item brush settings
Customize fill colors for leaf items based on ranges or values, using the `LeafItemBrushSettings` property within `SfTreeMap`. This property offers four distinct brush settings: `TreeMapUniformBrushSettings`, `TreeMapRangeBrushSettings`, `TreeMapDesaturationBrushSettings`, and `TreeMapPaletteBrushSettings`. Each setting provides unique options for defining and applying color schemes to enhance your TreeMap visualization.

## TreeMapUniformBrushSettings
Use `TreeMapUniformBrushSettings` for assigning a single color to represent data uniformly. Use the `Brush` property of `TreeMapUniformBrushSettings` set the background brush for the tree map leaf items.

{% tabs %}
{% highlight XAML hl_lines="12 13" %}

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
        <treemap:TreeMapUniformBrushSettings Brush="#F8D7B9"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = new SolidColorBrush(Color.FromArgb("#F8D7B9")) };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## TreeMapRangeBrushSettings
Use `TreeMapRangeBrushSettings` for assigning the collection of range based brushes for the `SfTreeMap`. Use the `RangeBrushes` property of `TreeMapRangeBrushSettings` to specify a list of `TreeMapRangeBrush` instances, where each instance defines a specific range and its associated background brush.

The `TreeMapRangeBrush` contains the following properties:
* `Brush` - Sets the background brush for the range in the `SfTreeMap`.
* `From` - Sets the starting value of the range for the background brush in the `SfTreeMap`.
* `To` - Sets the ending value of the range for the background brush in the `SfTreeMap`.
* `LegendLabel` - Sets the text for the legend item associated with the range in the `SfTreeMap`.


{% tabs %}
{% highlight XAML hl_lines="12 13" %}

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
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

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

{% endhighlight %}
{% endtabs %}

## TreeMapDesaturationBrushSettings
The `TreeMapDesaturationBrushSettings` modifies color saturation based on data values, emphasizing differences. The `TreeMapDesaturationBrushSettings` contains the following properties:
* `Brush` - Sets the background brush for the desaturation in the `SfTreeMap`.
* `From` - Sets the starting value for the desaturation range in the `SfTreeMap`.
* `To` - Sets the ending value for the desaturation range in the `SfTreeMap`.

{% tabs %}
{% highlight XAML hl_lines="12 13" %}

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
        <treemap:TreeMapDesaturationBrushSettings Brush="BlueViolet" From="1" To="0.2"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemBrushSettings = new TreeMapDesaturationBrushSettings() { Brush = Brush.BlueViolet, From = 1, To = 0.2 };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## TreeMapPaletteBrushSettings
Use `Brushes` property of `TreeMapPaletteBrushSettings` for a predefined color palette to assign colors to distinct data categories based on their assigned group items or leaf items determined by the `PrimaryValuePath` mapped value.

{% tabs %}
{% highlight XAML hl_lines="12 13" %}

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
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
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
{% endtabs %}