---
layout: post
title: Tooltip in .NET MAUI TreeMap Control | Syncfusion
description: Learn here all about how to customize the appearance of tooltip in Syncfusion .NET MAUI TreeMap control and more.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Tooltip in .NET MAUI TreeMap (SfTreeMap)

The tooltip provides information when hovering over or selecting items in the interactive TreeMap, displaying details about the values of each item.

## Enable tooltip

To enable the tooltip for the TreeMap control, utilize the [ShowToolTip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ShowToolTip) property of [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html). By default, the value of `ShowToolTip` is set to `false.` To provide users with additional information or context about specific treemap items, simply set this property to `true.`

{% tabs %}
{% highlight XAML hl_lines="4" %}

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
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="5" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.ShowToolTip = true;
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
{% highlight C# tabtitle="PopulationViewModel.cs" %}

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

## Customize tooltip appearance

The tooltip appearance customization can be achieved by using the [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_Stroke), [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_Duration), [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_TextStyle), and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html#Syncfusion_Maui_TreeMap_TreeMapToolTipSettings_Background) properties of [ToolTipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapToolTipSettings.html) in the `SfTreeMap.`

Additionally, you can achieve further appearance customization by using [ToolTipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ToolTipTemplate) of the `SfTreeMap.`

### Customize tooltip appearance using its properties

To customize the appearance of the tooltip in the `SfTreeMap` using `ToolTipSettings,` you can utilize the following properties:

* `Background`: This property allows you to change the background color of the tooltip.
* `Duration`: Specifies the duration in milliseconds, for which the tooltip will be displayed. This helps control how long the tooltip remains visible on the screen.
* `Stroke`: This property enables you to change the border color of the tooltip.
* `TextStyle`: This property is used to modify the appearance of the tooltip text. You can customize attributes such as `TextColor,` `FontSize,` `FontAttributes,` and `FontFamily.`

{% tabs %}
{% highlight XAML hl_lines="4 12 13 14 15 16 17 18 19 20 21 22" %}

<treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    ShowToolTip="True">
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.ToolTipSettings>
        <treemap:TreeMapToolTipSettings Background="Blue"
                                        Stroke="Red"
                                        Duration="0:0:10">
            <treemap:TreeMapToolTipSettings.TextStyle>
                <treemap:TreeMapTextStyle TextColor="White"
                                          FontSize="14"
                                          FontAttributes="Italic"/>
            </treemap:TreeMapToolTipSettings.TextStyle>
         </treemap:TreeMapToolTipSettings>                                     
    </treemap:SfTreeMap.ToolTipSettings>
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
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
treeMap.ToolTipSettings = new TreeMapToolTipSettings() { Background = Brush.Blue, Stroke = Brush.Red, Duration = new TimeSpan(0, 0, 10), TextStyle = new TreeMapTextStyle() { TextColor = Colors.White, FontSize = 14, FontAttributes = FontAttributes.Italic } };
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
{% highlight C# tabtitle="PopulationViewModel.cs" %}

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

N> This property will only be applicable when the `ShowToolTip` is enabled.

### Customize tooltip appearance using DataTemplate

You can customize the tooltip appearance by using the [ToolTipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ToolTipTemplate) property in the `SfTreeMap.`

The following code example shows the usage of DataTemplate.

{% tabs %}
{% highlight XAML hl_lines="4 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   ShowToolTip="True">
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.ToolTipTemplate>
        <DataTemplate>
            <StackLayout Orientation="Vertical">
                <StackLayout Orientation="Horizontal">
                    <Label Text="Country:"
                           TextColor="White"
                           Padding="5,0,0,0"
                           FontSize="Caption"
                           FontAttributes="Bold"/>
                    <Label Text="{Binding Item.Country}"
                           TextColor="White"
                           FontSize="Caption"
                           Padding="5,0,0,0"/>
                </StackLayout>
                <StackLayout Orientation="Horizontal"
                             Margin="0,3,0,0">
                    <Label Text="Continent:"
                           TextColor="White" 
                           Padding="5,0,0,0"
                           FontSize="Caption"
                           FontAttributes="Bold"/>
                    <Label Text="{Binding Item.Continent}"
                           TextColor="White"
                           FontSize="Caption"
                           Padding="5,0,0,0"/>
                </StackLayout>
                <StackLayout Orientation="Horizontal"
                             Margin="0,3,0,0">
                    <Label Text="Population:" 
                           TextColor="White"
                           FontSize="Caption"
                           Padding="5,0,0,0"
                           FontAttributes="Bold"/>
                    <Label Text="{Binding Item.Population}"
                           TextColor="White"
                           FontSize="Caption"
                           Padding="5,0,0,0"/>
                </StackLayout>
            </StackLayout>
        </DataTemplate>
    </treemap:SfTreeMap.ToolTipTemplate>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.ShowToolTip = true;
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
{% highlight C# tabtitle="PopulationViewModel.cs" %}

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

N> This property will only be applicable when the `ShowToolTip` is enabled.