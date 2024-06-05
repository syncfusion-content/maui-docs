---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to initialize legend and its customization in Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Legend in .NET MAUI Chart (SfPolarChart)
The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) provides a list of cartesian series, helping to identify the corresponding data series in the chart. Here's a detailed guide on how to define and customize the legend in the polar chart.

## Defining the legend
To define the legend in the chart, initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class and assign it to the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property.


{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart >
    . . .
    <chart:SfPolarChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPolarChart.Legend>
    . . .
    </chart:SfPolarChart>


{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %}

## Legend visibility
The visibility of the chart legend can be controlled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property. By default, the IsVisible property is set to `true`.


{% tabs %}

{% highlight xaml %}
    
    <chart:SfPolarChart>
        ...
        <chart:SfPolarChart.Legend>
        <chart:ChartLegend IsVisible = "True"/>
        </chart:SfPolarChart.Legend>
        ...
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    chart.Legend = new ChartLegend()
    { 
        IsVisible = true 
    };

{% endhighlight %}

{% endtabs %}

## LegendItems Visibility
Legend item visibility
The visibility of individual legend items for specific series can be controlled using the [IsVisibleOnLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend) property of the series. The default value for IsVisibleOnLegend is `true`.


{% tabs %}

{% highlight xaml %}
    
    <chart:SfPolarChart>
      ...

        <chart:SfPolarChart.Legend>
            <chart:ChartLegend/>
        </chart:SfPolarChart.Legend> 
    
        <chart:PolarAreaSeries 
            ItemsSource="{Binding  PlantDetails}" 
            IsVisibleOnLegend="True"  Label="Tree"
            XBindingPath="Direction" YBindingPath="Tree" />

        <chart:PolarAreaSeries 
            ItemsSource="{Binding PlantDetails}" 
            XBindingPath="Direction" YBindingPath="Weed" IsVisibleOnLegend="False" Label="Weed"/>

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    this.BindingContext = new ViewModel();
    PolarViewModel polarViewModel = new PolarViewModel();
    chart.Legend = new ChartLegend();

    PolarAreaSeries series1 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Tree",
    };

    PolarAreaSeries series2 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Weed",
    };

    chart.Series.Add(series1);
    chart.Series.Add(series2);

    this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Legend Icon
To specify the legend icon based on the associated series type, use the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LegendIcon) property and change its type using the [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum values. The default value of the LegendIcon property is `Circle`.


{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart>
      ...

        <chart:SfPolarChart.Legend>
            <chart:ChartLegend/>
        </chart:SfPolarChart.Legend> 
    
        <chart:PolarAreaSeries 
            ItemsSource="{Binding  PlantDetails}" 
            LegendIcon = "Diamond" Label="Tree"
            XBindingPath="Direction" 
            YBindingPath="Tree" />

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    this.BindingContext = new ViewModel();
    PolarViewModel polarViewModel = new PolarViewModel();
    chart.Legend = new ChartLegend();

    PolarAreaSeries series1 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Tree",
        LegendIcon = ChartLegendIconType.Diamond,
    };

    chart.Series.Add(series1);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Placement
The legend can be positioned to the left, right, top, or bottom of the chart area using the [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement) property in the ChartLegend class. The default placement is `Top`.


{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart>
        ...
        <chart:SfPolarChart.Legend>
        <chart:ChartLegend IsVisible = "True"/>
        </chart:SfPolarChart.Legend>
        ...
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();

    chart.Legend = new ChartLegend()
    { 
        Placement = LegendPlacement.Bottom
    };

{% endhighlight %}

{% endtabs %}

## Toggle the series visibility
The visibility of polar series can be controlled by tapping the legend item using the [ToggleSeriesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) property. The default value of ToggleSeriesVisibility is `false`.

{% tabs %}

{% highlight xaml %}
    
    <chart:SfPolarChart>
      ...

        <chart:SfPolarChart.Legend>
            <chart:ChartLegend ToggleSeriesVisibility="True"/>
        </chart:SfPolarChart.Legend> 
    
        <chart:PolarAreaSeries 
            ItemsSource="{Binding  PlantDetails}" 
            IsVisibleOnLegend="True"  Label="Tree"
            XBindingPath="Direction" YBindingPath="Tree" />

        <chart:PolarAreaSeries 
            ItemsSource="{Binding PlantDetails}" 
            XBindingPath="Direction" YBindingPath="Weed" IsVisibleOnLegend="False" Label="Weed"/>

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    this.BindingContext = new ViewModel();
    PolarViewModel polarViewModel = new PolarViewModel();
    chart.Legend = new ChartLegend()
    { 
        ToggleSeriesVisibility = true 
    };

    PolarAreaSeries series1 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Tree",
    };

    PolarAreaSeries series2 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Weed",
    };

    chart.Series.Add(series1);
    chart.Series.Add(series2);

    this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Legend maximum size request
To set the maximum size request for the legend view, override the [GetMaximumSizeCoefficient]() protected method in [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class. The value should be between 0 and 1, representing the maximum size request, not the desired size for the legend items layout.

{% highlight xaml %}

    <chart:SfPolarChart >
    . . .
    <chart:SfPolarChart.Legend>
        <chart:LegendExt/>
    </chart:SfPolarChart.Legend>
    . . .
    </chart:SfPolarChart>


{% endhighlight %}

{% highlight c# %}

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.7;
        }
    }


    SfPolarChart chart = new SfPolarChart();
    chart.Legend = new LegendExt();

{% endhighlight %}

{% endtabs %}


## Items Layout
An [ItemsLayout]() property is used to customize the arrangement and posistion for each legend item. The default value is `null`. It accepts any layout type in ItemsLayout property.

For more details about the layout alignment refer to this [article].

{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart>
    ...
        <chart:SfPolarChart.Legend>
            <chart:ChartLegend >
            <chart:ChartLegend.ItemsLayout>
               <chart:ChartLegend.ItemsLayout>
                    <FlexLayout 
                        HorizontalOptions="Start" 
                        Margin="10"
                        WidthRequest="{Binding Width,
                        Source={x:Reference Chart1}}">
                    </FlexLayout>
                </chart:ChartLegend.ItemsLayout>
            </chart:ChartLegend.ItemsLayout>
            </chart:ChartLegend>
        </chart:SfPolarChart.Legend>

        <chart:PolarAreaSeries 
            ItemsSource="{Binding  PlantDetails}" 
            Label="Tree"
            XBindingPath="Direction"
            YBindingPath="Tree" />

        <chart:PolarAreaSeries 
            ItemsSource="{Binding PlantDetails}" 
            XBindingPath="Direction" 
            YBindingPath="Weed" 
            Label="Weed"/>

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    this.BindingContext = new ViewModel();
    PolarViewModel polarViewModel = new PolarViewModel();
    
    ChartLegend legend = new ChartLegend();

    FlexLayout layout = new FlexLayout();
    layout.Wrap = FlexWrap.Wrap;
    layout.HorizontalOptions = LayoutOptions.Start;
    layout.SetBinding(WidthRequestProperty, nameof(SfPolarChart.WidthProperty));
    legend.ItemsLayout = layout;

    PolarAreaSeries series1 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Tree",
    };

    PolarAreaSeries series2 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Weed",
    };

    chart.Legend = legend;
    chart.Series.Add(series1);
    chart.Series.Add(series2);

    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## Item template
The [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) supports customizing the appearance of legend items using the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property. The default value of ItemsTemplate is `null`.

N> The BindingContext of the template is the corresponding underlying legend item provided in the ChartLegendItem class.


{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart >
        <chart:SfPolarChart.Resources>
            <DataTemplate x:Key="legendTemplate">
            <StackLayout Orientation="Horizontal" >
                <Rectangle HeightRequest="12" 
                    WidthRequest="12" Margin="3"
                    Background="{Binding IconBrush}"/>
            <Label Text="{Binding Text}" 
                    Margin="3"/>
        </StackLayout>
    </DataTemplate>
    </chart:SfPolarChart.Resources>  
    
    <chart:SfPolarChart.Legend>
        <chart:ChartLegend    
               ItemTemplate="{StaticResource legendTemplate}">
        </chart:ChartLegend>
      </chart:SfPolarChart.Legend>
    </chart:SfPolarChart>

    <chart:PolarAreaSeries 
            ItemsSource="{Binding  PlantDetails}" 
            Label="Tree"
            XBindingPath="Direction"
            YBindingPath="Tree" />

        <chart:PolarAreaSeries 
            ItemsSource="{Binding PlantDetails}" 
            XBindingPath="Direction" 
            YBindingPath="Weed" 
            Label="Weed"/>

{% endhighlight %}


{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ...
    SfPolarChart chart = new SfPolarChart();
    this.BindingContext = new ViewModel();
    PolarViewModel polarViewModel = new PolarViewModel();
    
    ChartLegend legend = new ChartLegend();
    legend.ItemTemplate = chart.Resources["legendTemplate"] as DataTemplate;

    FlexLayout layout = new FlexLayout();
    layout.Wrap = FlexWrap.Wrap;
    layout.HorizontalOptions = LayoutOptions.Start;
    layout.SetBinding(WidthRequestProperty, nameof(SfPolarChart.WidthProperty));
    legend.ItemsLayout = layout;

    PolarAreaSeries series1 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Tree",
    };

    PolarAreaSeries series2 = new PolarAreaSeries()
    {
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ItemsSource = polarViewModel.PlantDetails,
        Label = "Weed",
    };

    chart.Legend = legend;
    chart.Series.Add(series1);
    chart.Series.Add(series2);

    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## Limitations
* Do not add items explicitly.
* When using BindableLayouts, do not bind ItemsSource explicitly.
* For better UX, arrange items vertically for left and right dock positions, and horizontally for top and bottom dock positions.
* If the layout's measured size is larger than the MaximumHeightRequest, scrolling will be enabled.
* If MaximumHeightRequest is set to 1 and the chart's available size is smaller than the layout's measured size, the series may not have enough space to draw properly.
