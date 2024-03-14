---
layout: post
title: Understanding Levels in .NET MAUI TreeMap | Syncfusion
description: Learn about the levels within Syncfusion .NET MAUI TreeMap control, exploring its fundamental features and functionalities for effective treemap visualization.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# Levels in .NET MAUI TreeMap (SfTreeMap)
Levels in .NET MAUI TreeMap allow for hierarchical data visualization, enabling multi-level categorization and exploration of complex datasets. You can seamlessly navigate through different levels of data hierarchy, facilitating comprehensive understanding and analysis.

## TreeMap Level
Using `Levels` property of `SfTreeMap` you can integrate multiple hierarchical data levels to the TreeMap. The `GroupPath` property of `TreeMapLevel` specifies the name of the property in the data object that determines how items in the tree map are grouped. The grouping is based on the values of this property in the data source, which splits the level into distinct groups.

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
    <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent">
    </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent"});
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Level customization
The .NET MAUI TreeMap control allows you to customize the background, text style, spacing, and more.

### Customize the levels spacing
Customize the spacing between the tree map header items using the `Spacing` property of `TreeMapLevel`. The default value of `Spacing` property is `1`.

{% tabs %}
{% highlight XAML hl_lines="12 13 14" %}

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
    <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent"
                              Spacing="1">
        </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", Spacing = 1 });
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

### Customize the header height
Customize the height of the header for each level using the `HeaderHeight` property of `TreeMapLevel`. The default value of `HeaderHeight` property is `24`.

{% tabs %}
{% highlight XAML hl_lines="12 13 14" %}

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
    <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent"
                              HeaderHeight="20">
        </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", HeaderHeight = 20 });
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

### Customize the background 
Customize the background brush for the tree map header items using the `Background` property of `TreeMapLevel`.

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
    <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent"
                              Background="LightGrey">
        </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", Background = Brush.LightGrey   });
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

### Customize the border color
Customize the border color of the each level using the `Stroke` property of `TreeMapLevel`.

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
    <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent"
                              Stroke="Black">
        </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", Stroke = Brush.Black });
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

### Customize the border thickness
Customize the border thickness for each level using the `StrokeWidth` property of `TreeMapLevel`. The default value of `StrokeWidth` is `1`.

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
        <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent"
                              StrokeWidth="2">
        </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", StrokeWidth = 2 });
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

### Customize the text style of each level
Customize the style of header item text using the `TextStyle` property of `TreeMapLevel`, which is used to customize the `TextColor`, `FontSize`, `FontFamily` and `FontAttributes`.

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
        <treemap:SfTreeMap.Levels>
        <treemap:TreeMapLevel GroupPath="Continent">
            <treemap:TreeMapLevel.TextStyle>
                <treemap:TreeMapTextStyle TextColor="Red" 
                                          FontSize="12"/>
            </treemap:TreeMapLevel.TextStyle>
        </treemap:TreeMapLevel>
    </treemap:SfTreeMap.Levels>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="3 4"  %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", TextStyle = new TreeMapTextStyle() { TextColor = Colors.Red, FontSize = 12 } });
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

