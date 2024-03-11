---
layout: post
title: Getting Started with .NET MAUI TreeMap | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI TreeMap (SfTreeMap) in mobile and desktop applications from a single shared codebase.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Getting Started with .NET MAUI TreeMap (SfTreeMap)

This section provides a quick overview of how to get started with the `.NET MAUI TreeMap (SfTreeMap)` for .NET MAUI and a walk-through to configure the .NET MAUI TreeMap in a real-time scenario.

## Creating an Application using the .NET MAUI TreeMap

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add the SfTreeMap to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.TreeMap`, then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.TreeMap` in XAML or C# code.

4. Initialize `SfTreeMap`.


{% tabs %}
{% highlight XAML %}

<ContentPage
        xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
        <treemap:SfTreeMap />
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
        this.Content = treeMap;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The [Syncfusion.Maui.Core](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.html) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

    
    using Syncfusion.Maui.Core.Hosting;
    public static class MauiProgram
    {
	    public static MauiApp CreateMauiApp()
	    {
	        var builder = MauiApp.CreateBuilder();
		    builder
			    .ConfigureSyncfusionCore()
			    .UseMauiApp<App>()
			    .ConfigureFonts(fonts =>
			    {
				    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			    });

		    return builder.Build();
	    }
    }

{% endhighlight %}
{% endtabs %}

## Populating treemap items

#### Create a data model for treemap 

Create a simple data model in a new class file as shown in the following example code.

{% tabs %}
{% highlight C# %}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}

#### Create view model

Create a view model class to set values for the properties listed in the model class as shown in the following example code.

{% tabs %}
{% highlight C# %}
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

#### Bind data source for TreeMap

You can use `DataSource` property of SfTreeMap to populate the treemap items. The `PrimaryValuePath` specifies the name of the property in the data object that provides the primary value used to determine the size of each item in the tree map. The primary value typically represents the main quantitative data associated with each item.

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
{% endtabs %}

## Add labels

You can use `LabelPath` property of SfTreeMap `LeafItemSettings` to display text for the leaf items.

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
{% highlight C# %}
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
{% highlight C# %}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}

## Apply brush settings

You can use `LeafItemBrushSettings` property of SfTreeMap to customize fill colors for leaf items based on ranges or values. The TreeMap control offers four distinct brush settings: `TreeMapUniformBrushSettings`, `TreeMapRangeBrushSettings`, `TreeMapDesaturationBrushSettings`, and `TreeMapPaletteBrushSettings`. 

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
{% highlight C# %}
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
{% highlight C# %}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}


## Enable tooltip

You can use `ShowToolTip` property of SfTreeMap to enable tooltip for the treemap control. The default value of `ShowToolTip` is `false`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfTreeMapSample"
    xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap x:Name="treeMap"
                    DataSource="{Binding PopulationDetails}"
                    PrimaryValuePath="Population"
                    RangeColorValuePath="Population"
                    ShowToolTip="True">
        <treemap:SfTreeMap.BindingContext>
            <local:PopulationViewModel />
        </treemap:SfTreeMap.BindingContext>
            <treemap:SfTreeMap.LeafItemSettings>
                <treemap:TreeMapLeafItemSettings LabelPath="Country" 
                                                 Stroke="Black">
                    <treemap:TreeMapLeafItemSettings.TextStyle>
                    <treemap:TreeMapTextStyle TextColor="Black" />
                    </treemap:TreeMapLeafItemSettings.TextStyle>
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
{% highlight C# %}
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
{% highlight C# %}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}

## Add legend

You can use `ShowLegend` property of `TreeMapLegendSettings` to enable legend for the treemap control.  However, legend support is specifically applicable to `TreeMapRangeBrushSettings` of SfTreeMap. You can customize legend label text using the `LegendLabel` property within `RangeBrushes` of `TreeMapRangeBrushSettings`.

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
            <treemap:TreeMapLeafItemSettings LabelPath="Country"/>
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
{% highlight C# %}
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
{% highlight C# %}
public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}
{% endhighlight %}
{% endtabs %}