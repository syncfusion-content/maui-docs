---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to initialize legend and its customization in Syncfusion .NET MAUI Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Legend in .NET MAUI Chart (SfCircularChart)
The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) provides a list of cartesian series, helping to identify the corresponding data series in the chart. Here's a detailed guide on how to define and customize the legend in the circular chart.

## Defining the legend
To define the legend in the chart, initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class and assign it to the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property.


{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
        <chart:SfCircularChart.Legend>
            <chart:ChartLegend/>
        </chart:SfCircularChart.Legend>
    </chart:SfCircularChart>


{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %}

## Legend visibility
The visibility of the chart legend can be controlled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property. By default, the IsVisible property is set to `true`.

{% tabs %}

{% highlight xaml %}
    
    <chart:SfCircularChart>
        <chart:SfCircularChart.Legend>
        <chart:ChartLegend IsVisible = "True"/>
        </chart:SfCircularChart.Legend>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend(){ IsVisible = true };


{% endhighlight %}

{% endtabs %}

## LegendItems Visibility
Legend item visibility
The visibility of individual legend items for specific series can be controlled using the [IsVisibleOnLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend) property of the series. The default value for IsVisibleOnLegend is `true`.


{% tabs %}

{% highlight xaml %}
    
    <chart:SfCircularChart>
        <chart:SfCircularChart.Legend>
        <chart:ChartLegend />
        </chart:SfCircularChart.Legend>

        <chart:PieSeries ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        IsVisibleOnLegend="True"
                        YBindingPath="YValue"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend(){ };

    PieSeries series = new PieSeries()
    {
    ItemsSource = viewModel.Data,
    XBindingPath = "XValue",
    IsVisibleOnLegend = true,
    YBindingPath = "YValue",
    };
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Legend Icon
To specify the legend icon based on the associated series type, use the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LegendIcon) property and change its type using the [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum values. The default value of the LegendIcon property is `Circle`.


{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Legend>
           <chart:ChartLegend />
        </chart:SfCircularChart.Legend>

         <chart:PieSeries ItemsSource="{Binding Data}"
                           XBindingPath="XValue"
                           YBindingPath="YValue"
                           LegendIcon = "Diamond"/>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    chart.Legend = new ChartLegend();
    ViewModel viewModel = new ViewModel();

    PieSeries pieSeries = new PieSeries()
    {
          ItemsSource = viewModel.Data,
          XBindingPath = "XValue",
          YBindingPath = "YValue",
          LegendIcon = ChartLegendIconType.Diamond,
    };

    chart.Series.Add(pieSeries);

{% endhighlight %}

{% endtabs %}

## Placement
The legend can be positioned to the left, right, top, or bottom of the chart area using the [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement) property in the ChartLegend class. The default placement is `Top`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart >
        <chart:SfCircularChart.Legend>
            <chart:ChartLegend Placement="Bottom"  >
            </chart:ChartLegend>
      </chart:SfCircularChart.Legend>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend()
    { Placement = LegendPlacement.Bottom };

{% endhighlight %}

{% endtabs %}

## Toggle the series visibility
The visibility of circular series data points can be controlled by tapping the legend item using the [ToggleSeriesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) property. The default value of ToggleSeriesVisibility is `false`.


{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart >
        <chart:SfCircularChart.Legend>
            <chart:ChartLegend           
              ToggleSeriesVisibility="True">
        </chart:ChartLegend>
      </chart:SfCircularChart.Legend>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend()
    { 
        ToggleSeriesVisibility = true 
    };

{% endhighlight %}

{% endtabs %}

## Legend maximum size request
To set the maximum size request for the legend view, override the [GetMaximumSizeCoefficient]() protected method in [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class. The value should be between 0 and 1, representing the maximum size request, not the desired size for the legend items layout.

{% highlight xaml %}
    
    <chart:SfCircularChart >
    . . .
    <chart:SfCircularChart.Legend>
        <chart:LegendExt/>
    </chart:SfCircularChart.Legend>
    . . .
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.7;
        }
    }

    SfCircularChart chart = new SfCircularChart();
    chart.Legend = new LegendExt();

{% endhighlight %}

{% endtabs %}

## Items Layout
 Items layout
The [ItemsLayout]() property is used to customize the arrangement and position of each legend item. The default value is `null`. This property accepts any layout type.

For more details about the layout alignment refer to this [article].


{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart >
        <chart:SfCircularChart.Legend>
            <chart:ChartLegend >
            <chart:ChartLegend.ItemsLayout>
              <FlexLayout Wrap="Wrap"
                          WidthRequest="400">
              </FlexLayout>
            </chart:ChartLegend.ItemsLayout>
        </chart:ChartLegend>
      </chart:SfCircularChart.Legend>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    ChartLegend legend = new ChartLegend();
    legend.Placement = LegendPlacement.Bottom;

    legend.ItemsLayout = new FlexLayout()
    {
        Wrap = FlexWrap.Wrap,
        WidthRequest = 400
    };

    chart.Legend = legend;
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## Item template
The [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) supports customizing the appearance of legend items using the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property. The default value of ItemsTemplate is `null`.

N> The BindingContext of the template is the corresponding underlying legend item provided in the ChartLegendItem class.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart >
        <chart:SfCircularChart.Resources>
            <DataTemplate x:Key="legendTemplate">
            <StackLayout Orientation="Horizontal" >
                <Rectangle HeightRequest="12" 
                    WidthRequest="12" Margin="3"
                    Background="{Binding IconBrush}"/>
            <Label Text="{Binding Text}" 
                    Margin="3"/>
        </StackLayout>
    </DataTemplate>
    </chart:SfCircularChart.Resources>  
    
    <chart:SfCircularChart.Legend>
        <chart:ChartLegend    
               ItemTemplate="{StaticResource legendTemplate}">
        </chart:ChartLegend>
      </chart:SfCircularChart.Legend>
    </chart:SfCircularChart>

{% endhighlight %}


{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
     
    ChartLegend legend = new ChartLegend();
    legend.ItemTemplate = chart.Resources["legendTemplate"] as DataTemplate;
    ...
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## Limitations
* Do not add items explicitly.
* When using BindableLayouts, do not bind ItemsSource explicitly.
* For better UX, arrange items vertically for left and right dock positions, and horizontally for top and bottom dock positions.
* If the layout's measured size is larger than the MaximumHeightRequest, scrolling will be enabled.
* If MaximumHeightRequest is set to 1 and the chart's available size is smaller than the layout's measured size, the series may not have enough space to draw properly.


