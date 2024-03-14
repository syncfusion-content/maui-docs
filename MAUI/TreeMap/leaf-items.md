---
layout: post
title: Leaf item settings in .NET MAUI TreeMap | Syncfusion
description: Learn about the Leaf item settings of Syncfusion .NET MAUI TreeMap(STreeMap) control, its basic features, and the functionalities of treemap.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# TreeMap Leaf item settings
The `LabelPath` property within the `TreeMapLeafItemSettings` is used to display text for the leaf items. This property allows you to specify the path to the data property containing the text you want to display. The `TreeMapLeafItemSettings` also allows you to customize the spacing between items, stroke color, stroke width, text style, and text format option in the TreeMap control.

{% tabs %}
{% highlight XAML hl_lines="9" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
    <treemap:TreeMapLeafItemSettings LabelPath="Country" />
    </treemap:SfTreeMap.LeafItemSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country" };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Customize the leaf items spacing
Customize the the spacing between the leaf items using `Spacing` of `TreeMapLeafItemSettings`. The default value of `Spacing` is `1`.

{% tabs %}
{% highlight XAML hl_lines="9" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
    <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                     Spacing="1" />
    </treemap:SfTreeMap.LeafItemSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country", Spacing = 1 };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Customize the border color
Customize the border color for the leaf items using the `Stroke` property of `TreeMapLeafItemSettings`. The default value of `Stroke` property is `Transparent`.

{% tabs %}
{% highlight XAML hl_lines="9" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
    <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                     Stroke="Red" />
    </treemap:SfTreeMap.LeafItemSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country", Stroke = Brush.Red };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Customize the border thickness
Customize the border thickness for the leaf items using `StrokeWidth` property of `TreeMapLeafItemSettings`. The default value of `StrokeWidth` is `1`.

{% tabs %}
{% highlight XAML hl_lines="9" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
    <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                     StrokeWidth="2"/>
    </treemap:SfTreeMap.LeafItemSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country", StrokeWidth = 2 };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Customize the text format option
Customize the text format option for the leaf items using the `TextFormatOption` property of `TreeMapLeafItemSettings`. This property is applicable only when the `LabelPath` is specified. The default value is `TextFormatOption.Trim`. You can also change the `TextFormatOption` to `TextFormatOption.Wrap` or `TextFormatOption.Hide`.

{% tabs %}
{% highlight XAML hl_lines="9" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
    <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                     TextFormatOption="Wrap" />
    </treemap:SfTreeMap.LeafItemSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "Country", TextFormatOption = TextFormatOption.Wrap };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Customize the text style
Customize the style of leaf item text using the `TextStyle` property of `TreeMapLeafItemSettings`, which is used to customize the `TextColor`, `FontSize`, `FontFamily` and `FontAttributes`.

{% tabs %}
{% highlight XAML hl_lines="9" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   RangeColorValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
    <treemap:TreeMapLeafItemSettings LabelPath="Country" />
        <treemap:TreeMapLeafItemSettings.TextStyle>
            <treemap:TreeMapTextStyle TextColor="Red" 
                                      FontSize="13" 
                                      FontAttributes="Italic" />
        </treemap:TreeMapLeafItemSettings.TextStyle>
    </treemap:SfTreeMap.LeafItemSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() 
{ 
    LabelPath = "Country", 
    TextStyle = new TreeMapTextStyle() { TextColor = Colors.Red, FontSize = 13, FontAttributes = FontAttributes.Italic },
};
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}