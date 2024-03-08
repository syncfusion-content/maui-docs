---
layout: post
title: Migrate from Xamarin to .NET MAUI TreeMap (SfTreeMap) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms TreeMap to .NET MAUI TreeMap.
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
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapItemInfo</td>
<td>Contains item info for the selected item.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapLeafItemSettings</td>
<td>Represents settings for customizing the appearance of leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapLegendSettings</td>
<td>Represents settings for customizing the appearance of legend items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapBrushSettings</td>
<td>Provides base settings for brushes used in the SfTreeMap./></td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapUniformBrushSettings</td>
<td>Provides settings for assigning a single color to represent data uniformly in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapDesaturationBrushSettings</td>
<td>Represents the settings for desaturation in the SfTreeMap control, allowing customization of the background brush and desaturation range.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapPaletteBrushSettings</td>
<td>Provides settings for customizing the palette brushes in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapRangeBrushSettings</td>
<td>Provides settings for defining range based brushes in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapRangeBrush</td>
<td>Represents the settings for defining a range brush in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapToolTipSettings</td>
<td>Provides settings for configuring tool tips in the SfTreeMap./></td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapLevel</td>
<td>Represents a level in the hierarchical structure of the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TreeMapGroupBrushSettings</td>
<td>Provides settings for customizing brush colors used in the SfTreeMap for group items.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
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
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight C# %}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>DataSource</td>
<td>Gets or sets the DataSource property. This property is used to retrieving data.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>PrimaryValuePath</td>
<td>Gets or sets the PrimaryValuePath property. This property is used to set the value path based on data item.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>RangeColorValuePath</td>
<td>Gets or sets the RangeColorValuePath property. This property is used to set the value path based on color value.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>SelectedItemStroke</td>
<td>Gets or sets the Selected Item Stroke property. This property is used to set the color to highlight the items.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>SelectedItemStrokeWidth</td>
<td>Gets or sets the Selected ItemStrokeThickness property. This property is used to customize the width of highlighted stroke.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LayoutType</td>
<td>Gets or sets the layoutType property. This property is used to customize the layout for tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LeafItemTemplate</td>
<td>Gets or sets the LeafItemtemplate property. This property is used to set data template.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LeafItemSettings</td>
<td>Gets or sets the LeafItemSettings property. This property is used to customize the settings for leaf level.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LeafItemBrushSettings</td>
<td>Gets or sets the LeafItemColorSettings property. This property is used to set color settings for leaf items.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LegendSettings</td>
<td>Gets or sets the Legendsettings property. This property is used to customize the settings for legend.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Levels</td>
<td>Gets or sets the levels property. This property is an list collection of TreeMapleve.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>SelectedItems</td>
<td>Gets the selected items property. This property is an collection of object.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>SelectionMode</td>
<td>Gets or sets the selection mode property. This property is used to customize the selection for tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>ShowToolTip</td>
<td>Gets or sets a value indicating whether the tooltip should be enabled for tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>ToolTipSettings</td>
<td>Gets or sets the tooltipsettings value to treemap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>ToolTipTemplate</td>
<td>Gets or sets the tooltip template.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
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
<td>{{'[]()'| markdownify }}</td>
<td>Item</td>
<td>Gets or sets the item associated with the TreeMapItemInfo.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>GroupLevel</td>
<td>Gets or sets the group level of the item.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Background</td>
<td>Gets the background brush for the item.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>PrimaryValueText</td>
<td>Gets the primary value text of the item.</td>
</tr>

</table>

### TreeMapLeafItemSettings

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>Stroke</td>
<td>Gets or sets the stroke property. This property is used to set the leaf level item border color.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>StrokeWidth</td>
<td>Gets or sets the StrokeThickness property. This property is used to customize the width of tree map item.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Spacing</td>
<td>Gets or sets the Gap property. This property is used to set padding between leaf level items.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LabelPath</td>
<td>Gets or sets the data label path property. This property is used to set in which path label should be applied</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets the text style property. This is used to set different style labels.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TextFormatOption</td>
<td>Gets or sets the TextFormatOption.</td>
</tr>

</table>

### TreeMapLegendSettings

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>ShowLegend</td>
<td>Gets or sets a value indicating whether the legend should be visible for tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>IconSize</td>
<td>Gets or sets the IconSize property. This property is used to set size for the legend Icons.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>IconType</td>
<td>Gets or sets the icon type property. This property is used to customize the icons.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Placement</td>
<td>Gets or sets the LegendPlacement property. This property is used to customize the position for legends.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Size</td>
<td>Gets or sets the size property. This method is used to set the legend size.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets the text style property. This is used to set different style labels.</td>
</tr>

</table>

### TreeMapUniformBrushSettings

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>Brush</td>
<td>Gets or sets the color value for tree map item. This is used to set color for each tree map item.</td>
</tr>

</table>

### TreeMapDesaturationBrushSettings

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>Brush</td>
<td>Gets or sets the color value for the tree map item. This is used to set color for each tree map item.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>From</td>
<td>Gets or sets the from value for desaturation. The From value is used to point where the desaturation starts.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>To</td>
<td>Gets or sets the two values for desaturation. The To value is used to point where the desaturation ends.</td>
</tr>

</table>

### TreeMapPaletteBrushSettings

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>Brushes</td>
<td>Gets or sets the color value for the tree map item. The Colors is a collection of colors.</td>
</tr>

</table>

### TreeMapRangeBrushSettings
#### TreeMapRangeBrush
{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>LegendLabel</td>
<td>Gets or sets the legend label for the tree map. This is used to describe the range of values.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Brush</td>
<td>Gets or sets the Color value for range. This is used to set color for each range.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>From</td>
<td>Gets or sets the from value for Range. The From value is used to point where the range starts.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>To</td>
<td>Gets or sets the to value for Range. The To value is used to point where the range ends.</td>
</tr>

</table>


### TreeMapToolTipSettings

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>Background</td>
<td>Gets or sets the background color.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Duration</td>
<td>Gets or sets a value to specify the duration time in seconds for which tooltip will be displayed.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets to customize the text style.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Stroke</td>
<td>Gets or sets the stroke color.</td>
</tr>

</table>

### TreeMapLevel

{% tabs %}
{% highlight XAML %}
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

{% highlight C# %}

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

{% highlight c# tabtitle="ViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
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
{% highlight c# tabtitle="Model.cs" %}

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
<td>{{'[]()'| markdownify }}</td>
<td>GroupPath</td>
<td>Gets or sets the Header path property. This property is used to set the path for header of the tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Background</td>
<td>Gets or sets the Group Background color property. This property is used to set the backround</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Stroke</td>
<td>Gets or sets the Group Border Color property. This property is used to set color for the group of the tree map. This is a bindable property.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>StrokeWidth</td>
<td>Gets or sets the Group Border Thickness property. This property is used to set thickness for the groups of the tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>Spacing</td>
<td>Gets or sets the Group Gap property. This property is used to customize the gap between the groups of the tree map.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>TextStyle</td>
<td>Gets or sets the customize the text property.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
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
<td>{{'[FontColor]()'| markdownify }}</td>
<td>TextColor</td>
<td>Gets or sets the text color for the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[FontSize]()'| markdownify }}</td>
<td>FontSize</td>
<td>Gets or sets the double value that represents the font size of the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[FontFamily]()'| markdownify }}</td>
<td>FontFamily</td>
<td>Gets or sets the string, that represents font family of the SfTreeMap control.</td>
</tr>

<tr>
<td>{{'[FontAttributes]()'| markdownify }}</td>
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
<td>{{'[]()'| markdownify }}</td>
<td>TextFormatOption</td>
<td>Specifies text formatting options for tree map leaf items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LayoutType</td>
<td>Specifies the layout type of algorithm used to arrange the items in the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LegendPlacement</td>
<td>Represents the legend placement to customize the legend position.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
<td>LegendIconType</td>
<td>Specifies the shape of icons used in legends for the SfTreeMap.</td>
</tr>

<tr>
<td>{{'[]()'| markdownify }}</td>
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
<td>{{'[]()'| markdownify }}</td>
<td>SelectionChanged</td>
<td>Provides data for the event when the selection is changed in the SfTreeMap.</td>
</tr>
</table>

## Upcoming features

* Drill down support.
