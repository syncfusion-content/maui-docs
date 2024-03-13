---
layout: post
title: Layout types in .NET MAUI TreeMap | Syncfusion
description: Learn here all about adding different layouts of the Syncfusion .NET MAUI TreeMap(STreeMap) control and more.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# Layouts in .NET MAUI TreeMap (SfTreeMap)

The Tree Map control provides multiple layout types for organizing hierarchical data effectively. You can utilize the `LayoutType` property within the SfTreeMap to switch between four distinct layouts: `Squarified,` `SliceAndDiceAuto,` `SliceAndDiceHorizontal,` and `SliceAndDiceVertical.`

## Squarified

The `Squarified` layout visualizes data in square-like rectangles with an optimal aspect ratio. It divides rectangles considering both the height and width of the parent view. This layout is the default rendering type for TreeMap.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   LayoutType="Squarified"
                   RangeColorValuePath="Population"
                   PrimaryValuePath="Population"
                   ShowToolTip="True">
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="#D21243" />
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LayoutType = LayoutType.Squarified;
treeMap.LegendSettings.ShowLegend = true;
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

/// <summary>    
/// Represents the custom data properties.
/// </summary>
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public double Population { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="PopulationViewModel.cs" %}

/// <summary>    
/// Represents demographic information for population data for a specific country.
/// </summary>
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

## SliceAndDiceAuto

The `SliceAndDiceAuto` layout visualizes data using long, thin rectangles arranged vertically or horizontally with a high aspect ratio, thereby offering a comprehensive view of the data.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   LayoutType="SliceAndDiceAuto"
                   RangeColorValuePath="Population"
                   PrimaryValuePath="Population"
                   ShowToolTip="True">
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="#D21243" />
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LayoutType = LayoutType.SliceAndDiceAuto;
treeMap.LegendSettings.ShowLegend = true;
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

/// <summary>    
/// Represents the custom data properties.
/// </summary>
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public double Population { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="PopulationViewModel.cs" %}

/// <summary>    
/// Represents demographic information for population data for a specific country.
/// </summary>
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

## SliceAndDiceHorizontal

The `SliceAndDiceHorizontal` layout arranges data into horizontal rectangles with a high aspect ratio and displays them sorted horizontally.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   LayoutType="SliceAndDiceHorizontal"
                   RangeColorValuePath="Population"
                   PrimaryValuePath="Population"
                   ShowToolTip="True">
     <treemap:SfTreeMap.LeafItemSettings>
         <treemap:TreeMapLeafItemSettings LabelPath="Country">
         </treemap:TreeMapLeafItemSettings>
     </treemap:SfTreeMap.LeafItemSettings>
     <treemap:SfTreeMap.LeafItemBrushSettings>
         <treemap:TreeMapUniformBrushSettings Brush="#D21243" />
     </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LayoutType = LayoutType.SliceAndDiceHorizontal;
treeMap.LegendSettings.ShowLegend = true;
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

/// <summary>    
/// Represents the custom data properties.
/// </summary>
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public double Population { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="PopulationViewModel.cs" %}

/// <summary>    
/// Represents demographic information for population data for a specific country.
/// </summary>
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

## SliceAndDiceVertical

The `SliceAndDiceVertical` layout organizes data into vertical rectangles with a high aspect ratio and displays them sorted vertically.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   LayoutType="SliceAndDiceVertical"
                   RangeColorValuePath="Population"
                   PrimaryValuePath="Population"
                   ShowToolTip="True">
     <treemap:SfTreeMap.LeafItemSettings>
         <treemap:TreeMapLeafItemSettings LabelPath="Country">
         </treemap:TreeMapLeafItemSettings>
     </treemap:SfTreeMap.LeafItemSettings>
     <treemap:SfTreeMap.LeafItemBrushSettings>
         <treemap:TreeMapUniformBrushSettings Brush="#D21243" />
     </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.LayoutType = LayoutType.SliceAndDiceVertical;
treeMap.LegendSettings.ShowLegend = true;
this.Content = treeMap;

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

/// <summary>    
/// Represents the custom data properties.
/// </summary>
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public double Population { get; set; }
}

{% endhighlight %}
{% highlight C# tabtitle="PopulationViewModel.cs" %}

/// <summary>    
/// Represents demographic information for population data for a specific country.
/// </summary>
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