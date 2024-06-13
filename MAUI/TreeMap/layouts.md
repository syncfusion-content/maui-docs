---
layout: post
title: Layout types in .NET MAUI TreeMap Control | Syncfusion
description: Learn here all about adding different layouts of the Syncfusion .NET MAUI TreeMap (STreeMap) control and more.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# Layouts in .NET MAUI TreeMap (SfTreeMap)

The TreeMap control provides multiple layout types for organizing hierarchical data effectively. You can utilize the [LayoutType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LayoutType) property within the [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html) to switch between four distinct layouts: [Squarified](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_Squarified), [SliceAndDiceAuto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_SliceAndDiceAuto), [SliceAndDiceHorizontal](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_SliceAndDiceHorizontal), and [SliceAndDiceVertical](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_SliceAndDiceVertical).

## Squarified

The [Squarified](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_Squarified) layout visualizes data in square-like rectangles with an optimal aspect ratio. It divides rectangles considering both the height and width of the parent view. This layout, which is the default rendering type for TreeMap, determines the size of each rectangle will be calculated based on the [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath) property value and the available size.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding AirportDetails}"
                   LayoutType="Squarified"
                   PrimaryValuePath="Count"
                   RangeColorValuePath="Count">
    <treemap:SfTreeMap.BindingContext>
        <local:ViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="State">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapRangeBrushSettings>
            <treemap:TreeMapRangeBrushSettings.RangeBrushes>
                <treemap:TreeMapRangeBrush LegendLabel="32"
                                                From="32"
                                                To="32"
                                                Brush="#35D2E5" />
                <treemap:TreeMapRangeBrush LegendLabel="31"
                                                From="27"
                                                To="31"
                                                Brush="#84D592" />
                <treemap:TreeMapRangeBrush LegendLabel="26"
                                                From="8"
                                                To="26"
                                                Brush="#C8DA3F" />
                <treemap:TreeMapRangeBrush LegendLabel="7"
                                                From="6"
                                                To="7"
                                                Brush="#53D4BB" />
                <treemap:TreeMapRangeBrush LegendLabel="5"
                                                From="4"
                                                To="5"
                                                Brush="#F1C17A" />
                <treemap:TreeMapRangeBrush LegendLabel="3"
                                                From="3" 
                                                To="3" 
                                                Brush ="#F79EE3" />
                <treemap:TreeMapRangeBrush LegendLabel="2"
                                                From="2" 
                                                To="2" 
                                                Brush ="#A39EE4"/>
                <treemap:TreeMapRangeBrush LegendLabel="1"
                                                From="0"
                                                To="1"
                                                Brush="#F6989B"/>
            </treemap:TreeMapRangeBrushSettings.RangeBrushes>
        </treemap:TreeMapRangeBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.LegendSettings>
        <treemap:TreeMapLegendSettings ShowLegend="True" />
    </treemap:SfTreeMap.LegendSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
ViewModel viewModel = new ViewModel();
treeMap.DataSource = viewModel.AirportDetails;
treeMap.LayoutType = LayoutType.Squarified;
treeMap.PrimaryValuePath = "Count";
treeMap.RangeColorValuePath = "Count";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "State" };
treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
{
    RangeBrushes = new List<TreeMapRangeBrush>()
    {
        new TreeMapRangeBrush() { LegendLabel="32", From=32, To=32, Brush = new SolidColorBrush(Color.FromArgb("#35D2E5")) },
        new TreeMapRangeBrush() { LegendLabel="31", From=27, To=31, Brush = new SolidColorBrush(Color.FromArgb("#84D592")) },
        new TreeMapRangeBrush() { LegendLabel="26", From=8, To=26, Brush = new SolidColorBrush(Color.FromArgb("#C8DA3F")) },
        new TreeMapRangeBrush() { LegendLabel="7", From=6, To=7, Brush = new SolidColorBrush(Color.FromArgb("#53D4BB")) },
        new TreeMapRangeBrush() { LegendLabel="5", From=4, To=5, Brush = new SolidColorBrush(Color.FromArgb("#F1C17A")) },
        new TreeMapRangeBrush() { LegendLabel="3", From=3, To=3, Brush = new SolidColorBrush(Color.FromArgb("#F79EE3")) },
        new TreeMapRangeBrush() { LegendLabel="2", From=2, To=2, Brush = new SolidColorBrush(Color.FromArgb("#A39EE4")) },
        new TreeMapRangeBrush() { LegendLabel="1", From=0, To=1, Brush = new SolidColorBrush(Color.FromArgb("#F6989B")) },
    }
};

treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="AirportDetails.cs" %}

public class AirportDetails
{
    public string State { get; set; }
    public int Count { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    public ViewModel()
    {
        this.AirportDetails = new ObservableCollection<AirportDetails>()
        {
            new AirportDetails { State = "Brazil", Count = 31 },
            new AirportDetails { State = "Colombia", Count = 32 },
            new AirportDetails { State = "Argentina", Count = 26 },
            new AirportDetails { State = "Ecuador", Count = 7 },
            new AirportDetails { State = "Chile", Count = 5 },
            new AirportDetails { State = "Peru", Count = 3 },
            new AirportDetails { State = "Venezuela", Count = 3 },
            new AirportDetails { State = "Bolivia", Count = 3 },
            new AirportDetails { State = "Paraguay", Count = 2 },
            new AirportDetails { State = "Uruguay", Count = 3 },
            new AirportDetails { State = "Falkland Islands", Count = 1 },
            new AirportDetails { State = "French Guiana", Count = 1 },
            new AirportDetails { State = "Guyana", Count = 1 },
            new AirportDetails { State = "Suriname", Count = 1 },
        };
    }

    public ObservableCollection<AirportDetails> AirportDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

![squarified-layout-type-in-maui-treemap](images/layouts/squarified-layout-type-in-maui-treemap.jpeg){:width="313" height="444" .lazy .shadow-effect}

## Slice and dice auto

The  [SliceAndDiceAuto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_SliceAndDiceAuto) layout visualizes data using long, thin rectangles arranged vertically or horizontally with a high aspect ratio, thereby offering a comprehensive view of the data. This layout will start to arrange each rectangle in a horizontal or vertical direction, and the size of the rectangle will be calculated based on the [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath) property value.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding AirportDetails}"
                   LayoutType="SliceAndDiceAuto"
                   PrimaryValuePath="Count"
                   RangeColorValuePath="Count">
    <treemap:SfTreeMap.BindingContext>
        <local:ViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="State">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapRangeBrushSettings>
            <treemap:TreeMapRangeBrushSettings.RangeBrushes>
                <treemap:TreeMapRangeBrush LegendLabel="32"
                                                From="32"
                                                To="32"
                                                Brush="#35D2E5" />
                <treemap:TreeMapRangeBrush LegendLabel="31"
                                                From="27"
                                                To="31"
                                                Brush="#84D592" />
                <treemap:TreeMapRangeBrush LegendLabel="26"
                                                From="8"
                                                To="26"
                                                Brush="#C8DA3F" />
                <treemap:TreeMapRangeBrush LegendLabel="7"
                                                From="6"
                                                To="7"
                                                Brush="#53D4BB" />
                <treemap:TreeMapRangeBrush LegendLabel="5"
                                                From="4"
                                                To="5"
                                                Brush="#F1C17A" />
                <treemap:TreeMapRangeBrush LegendLabel="3"
                                                From="3" 
                                                To="3" 
                                                Brush ="#F79EE3" />
                <treemap:TreeMapRangeBrush LegendLabel="2"
                                                From="2" 
                                                To="2" 
                                                Brush ="#A39EE4"/>
                <treemap:TreeMapRangeBrush LegendLabel="1"
                                                From="0"
                                                To="1"
                                                Brush="#F6989B"/>
            </treemap:TreeMapRangeBrushSettings.RangeBrushes>
        </treemap:TreeMapRangeBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.LegendSettings>
        <treemap:TreeMapLegendSettings ShowLegend="True" />
    </treemap:SfTreeMap.LegendSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
ViewModel viewModel = new ViewModel();
treeMap.DataSource = viewModel.AirportDetails;
treeMap.LayoutType = LayoutType.SliceAndDiceAuto;
treeMap.PrimaryValuePath = "Count";
treeMap.RangeColorValuePath = "Count";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "State" };
treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
{
    RangeBrushes = new List<TreeMapRangeBrush>()
    {
        new TreeMapRangeBrush() { LegendLabel="32", From=32, To=32, Brush = new SolidColorBrush(Color.FromArgb("#35D2E5")) },
        new TreeMapRangeBrush() { LegendLabel="31", From=27, To=31, Brush = new SolidColorBrush(Color.FromArgb("#84D592")) },
        new TreeMapRangeBrush() { LegendLabel="26", From=8, To=26, Brush = new SolidColorBrush(Color.FromArgb("#C8DA3F")) },
        new TreeMapRangeBrush() { LegendLabel="7", From=6, To=7, Brush = new SolidColorBrush(Color.FromArgb("#53D4BB")) },
        new TreeMapRangeBrush() { LegendLabel="5", From=4, To=5, Brush = new SolidColorBrush(Color.FromArgb("#F1C17A")) },
        new TreeMapRangeBrush() { LegendLabel="3", From=3, To=3, Brush = new SolidColorBrush(Color.FromArgb("#F79EE3")) },
        new TreeMapRangeBrush() { LegendLabel="2", From=2, To=2, Brush = new SolidColorBrush(Color.FromArgb("#A39EE4")) },
        new TreeMapRangeBrush() { LegendLabel="1", From=0, To=1, Brush = new SolidColorBrush(Color.FromArgb("#F6989B")) },
    }
};

treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="AirportDetails.cs" %}

public class AirportDetails
{
    public string State { get; set; }
    public int Count { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    public ViewModel()
    {
        this.AirportDetails = new ObservableCollection<AirportDetails>()
        {
            new AirportDetails { State = "Brazil", Count = 31 },
            new AirportDetails { State = "Colombia", Count = 32 },
            new AirportDetails { State = "Argentina", Count = 26 },
            new AirportDetails { State = "Ecuador", Count = 7 },
            new AirportDetails { State = "Chile", Count = 5 },
            new AirportDetails { State = "Peru", Count = 3 },
            new AirportDetails { State = "Venezuela", Count = 3 },
            new AirportDetails { State = "Bolivia", Count = 3 },
            new AirportDetails { State = "Paraguay", Count = 2 },
            new AirportDetails { State = "Uruguay", Count = 3 },
            new AirportDetails { State = "Falkland Islands", Count = 1 },
            new AirportDetails { State = "French Guiana", Count = 1 },
            new AirportDetails { State = "Guyana", Count = 1 },
            new AirportDetails { State = "Suriname", Count = 1 },
        };
    }

    public ObservableCollection<AirportDetails> AirportDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

![slice-and-dice-auto-layout-type-in-maui-treemap](images/layouts/slice-and-dice-auto-layout-type-in-maui-treemap.jpeg){:width="313" height="444" .lazy .shadow-effect}

## Slice and dice horizontal

The [SliceAndDiceHorizontal](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_SliceAndDiceHorizontal) layout arranges data into horizontal rectangles with a high aspect ratio and displays them sorted horizontally. This layout will start to arrange each rectangle in a horizontal direction, and the size of the rectangle will be calculated based on the [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath) property value.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding AirportDetails}"
                   LayoutType="SliceAndDiceHorizontal"
                   PrimaryValuePath="Count"
                   RangeColorValuePath="Count">
    <treemap:SfTreeMap.BindingContext>
        <local:ViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="State">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapRangeBrushSettings>
            <treemap:TreeMapRangeBrushSettings.RangeBrushes>
                <treemap:TreeMapRangeBrush LegendLabel="32"
                                                From="32"
                                                To="32"
                                                Brush="#35D2E5" />
                <treemap:TreeMapRangeBrush LegendLabel="31"
                                                From="27"
                                                To="31"
                                                Brush="#84D592" />
                <treemap:TreeMapRangeBrush LegendLabel="26"
                                                From="8"
                                                To="26"
                                                Brush="#C8DA3F" />
                <treemap:TreeMapRangeBrush LegendLabel="7"
                                                From="6"
                                                To="7"
                                                Brush="#53D4BB" />
                <treemap:TreeMapRangeBrush LegendLabel="5"
                                                From="4"
                                                To="5"
                                                Brush="#F1C17A" />
                <treemap:TreeMapRangeBrush LegendLabel="3"
                                                From="3" 
                                                To="3" 
                                                Brush ="#F79EE3" />
                <treemap:TreeMapRangeBrush LegendLabel="2"
                                                From="2" 
                                                To="2" 
                                                Brush ="#A39EE4"/>
                <treemap:TreeMapRangeBrush LegendLabel="1"
                                                From="0"
                                                To="1"
                                                Brush="#F6989B"/>
            </treemap:TreeMapRangeBrushSettings.RangeBrushes>
        </treemap:TreeMapRangeBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.LegendSettings>
        <treemap:TreeMapLegendSettings ShowLegend="True" />
    </treemap:SfTreeMap.LegendSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
ViewModel viewModel = new ViewModel();
treeMap.DataSource = viewModel.AirportDetails;
treeMap.LayoutType = LayoutType.SliceAndDiceHorizontal;
treeMap.PrimaryValuePath = "Count";
treeMap.RangeColorValuePath = "Count";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "State" };
treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
{
    RangeBrushes = new List<TreeMapRangeBrush>()
    {
        new TreeMapRangeBrush() { LegendLabel="32", From=32, To=32, Brush = new SolidColorBrush(Color.FromArgb("#35D2E5")) },
        new TreeMapRangeBrush() { LegendLabel="31", From=27, To=31, Brush = new SolidColorBrush(Color.FromArgb("#84D592")) },
        new TreeMapRangeBrush() { LegendLabel="26", From=8, To=26, Brush = new SolidColorBrush(Color.FromArgb("#C8DA3F")) },
        new TreeMapRangeBrush() { LegendLabel="7", From=6, To=7, Brush = new SolidColorBrush(Color.FromArgb("#53D4BB")) },
        new TreeMapRangeBrush() { LegendLabel="5", From=4, To=5, Brush = new SolidColorBrush(Color.FromArgb("#F1C17A")) },
        new TreeMapRangeBrush() { LegendLabel="3", From=3, To=3, Brush = new SolidColorBrush(Color.FromArgb("#F79EE3")) },
        new TreeMapRangeBrush() { LegendLabel="2", From=2, To=2, Brush = new SolidColorBrush(Color.FromArgb("#A39EE4")) },
        new TreeMapRangeBrush() { LegendLabel="1", From=0, To=1, Brush = new SolidColorBrush(Color.FromArgb("#F6989B")) },
    }
};

treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="AirportDetails.cs" %}

public class AirportDetails
{
    public string State { get; set; }
    public int Count { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    public ViewModel()
    {
        this.AirportDetails = new ObservableCollection<AirportDetails>()
        {
            new AirportDetails { State = "Brazil", Count = 31 },
            new AirportDetails { State = "Colombia", Count = 32 },
            new AirportDetails { State = "Argentina", Count = 26 },
            new AirportDetails { State = "Ecuador", Count = 7 },
            new AirportDetails { State = "Chile", Count = 5 },
            new AirportDetails { State = "Peru", Count = 3 },
            new AirportDetails { State = "Venezuela", Count = 3 },
            new AirportDetails { State = "Bolivia", Count = 3 },
            new AirportDetails { State = "Paraguay", Count = 2 },
            new AirportDetails { State = "Uruguay", Count = 3 },
            new AirportDetails { State = "Falkland Islands", Count = 1 },
            new AirportDetails { State = "French Guiana", Count = 1 },
            new AirportDetails { State = "Guyana", Count = 1 },
            new AirportDetails { State = "Suriname", Count = 1 },
        };
    }

    public ObservableCollection<AirportDetails> AirportDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

![slice-and-dice-horizontal-layout-type-in-maui-treemap](images/layouts/slice-and-dice-horizontal-layout-type-in-maui-treemap.jpeg){:width="313" height="444" .lazy .shadow-effect}

## Slice and dice vertical

The [SliceAndDiceVertical](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.LayoutType.html#Syncfusion_Maui_TreeMap_LayoutType_SliceAndDiceVertical) layout organizes data into vertical rectangles with a high aspect ratio and displays them sorted vertically. This layout will start to arrange each rectangle in a vertical direction, and the size of the rectangle will be calculated based on the [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath) property value.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding AirportDetails}"
                    LayoutType="SliceAndDiceVertical"
                    PrimaryValuePath="Count"
                    RangeColorValuePath="Count">
    <treemap:SfTreeMap.BindingContext>
        <local:ViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="State">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapRangeBrushSettings>
            <treemap:TreeMapRangeBrushSettings.RangeBrushes>
                <treemap:TreeMapRangeBrush LegendLabel="32"
                                                From="32"
                                                To="32"
                                                Brush="#35D2E5" />
                <treemap:TreeMapRangeBrush LegendLabel="31"
                                                From="27"
                                                To="31"
                                                Brush="#84D592" />
                <treemap:TreeMapRangeBrush LegendLabel="26"
                                                From="8"
                                                To="26"
                                                Brush="#C8DA3F" />
                <treemap:TreeMapRangeBrush LegendLabel="7"
                                                From="6"
                                                To="7"
                                                Brush="#53D4BB" />
                <treemap:TreeMapRangeBrush LegendLabel="5"
                                                From="4"
                                                To="5"
                                                Brush="#F1C17A" />
                <treemap:TreeMapRangeBrush LegendLabel="3"
                                                From="3" 
                                                To="3" 
                                                Brush ="#F79EE3" />
                <treemap:TreeMapRangeBrush LegendLabel="2"
                                                From="2" 
                                                To="2" 
                                                Brush ="#A39EE4"/>
                <treemap:TreeMapRangeBrush LegendLabel="1"
                                                From="0"
                                                To="1"
                                                Brush="#F6989B"/>
            </treemap:TreeMapRangeBrushSettings.RangeBrushes>
        </treemap:TreeMapRangeBrushSettings>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.LegendSettings>
        <treemap:TreeMapLegendSettings ShowLegend="True" />
    </treemap:SfTreeMap.LegendSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
ViewModel viewModel = new ViewModel();
treeMap.DataSource = viewModel.AirportDetails;
treeMap.LayoutType = LayoutType.SliceAndDiceVertical;
treeMap.PrimaryValuePath = "Count";
treeMap.RangeColorValuePath = "Count";
treeMap.LeafItemSettings = new TreeMapLeafItemSettings() { LabelPath = "State" };
treeMap.LeafItemBrushSettings = new TreeMapRangeBrushSettings()
{
    RangeBrushes = new List<TreeMapRangeBrush>()
    {
        new TreeMapRangeBrush() { LegendLabel="32", From=32, To=32, Brush = new SolidColorBrush(Color.FromArgb("#35D2E5")) },
        new TreeMapRangeBrush() { LegendLabel="31", From=27, To=31, Brush = new SolidColorBrush(Color.FromArgb("#84D592")) },
        new TreeMapRangeBrush() { LegendLabel="26", From=8, To=26, Brush = new SolidColorBrush(Color.FromArgb("#C8DA3F")) },
        new TreeMapRangeBrush() { LegendLabel="7", From=6, To=7, Brush = new SolidColorBrush(Color.FromArgb("#53D4BB")) },
        new TreeMapRangeBrush() { LegendLabel="5", From=4, To=5, Brush = new SolidColorBrush(Color.FromArgb("#F1C17A")) },
        new TreeMapRangeBrush() { LegendLabel="3", From=3, To=3, Brush = new SolidColorBrush(Color.FromArgb("#F79EE3")) },
        new TreeMapRangeBrush() { LegendLabel="2", From=2, To=2, Brush = new SolidColorBrush(Color.FromArgb("#A39EE4")) },
        new TreeMapRangeBrush() { LegendLabel="1", From=0, To=1, Brush = new SolidColorBrush(Color.FromArgb("#F6989B")) },
    }
};

treeMap.LegendSettings = new TreeMapLegendSettings() { ShowLegend = true };
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="AirportDetails.cs" %}

public class AirportDetails
{
    public string State { get; set; }
    public int Count { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    public ViewModel()
    {
        this.AirportDetails = new ObservableCollection<AirportDetails>()
        {
            new AirportDetails { State = "Brazil", Count = 31 },
            new AirportDetails { State = "Colombia", Count = 32 },
            new AirportDetails { State = "Argentina", Count = 26 },
            new AirportDetails { State = "Ecuador", Count = 7 },
            new AirportDetails { State = "Chile", Count = 5 },
            new AirportDetails { State = "Peru", Count = 3 },
            new AirportDetails { State = "Venezuela", Count = 3 },
            new AirportDetails { State = "Bolivia", Count = 3 },
            new AirportDetails { State = "Paraguay", Count = 2 },
            new AirportDetails { State = "Uruguay", Count = 3 },
            new AirportDetails { State = "Falkland Islands", Count = 1 },
            new AirportDetails { State = "French Guiana", Count = 1 },
            new AirportDetails { State = "Guyana", Count = 1 },
            new AirportDetails { State = "Suriname", Count = 1 },
        };
    }

    public ObservableCollection<AirportDetails> AirportDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

![slice-and-dice-vertical-layout-type-in-maui-treemap](images/layouts/slice-and-dice-vertical-layout-type-in-maui-treemap.jpeg){:width="313" height="444"}