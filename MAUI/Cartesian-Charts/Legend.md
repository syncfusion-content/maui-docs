---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to initialize legend and its customization in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Legend in .NET MAUI Chart

Legend is used to provide more information about the data point displayed in the chart.

## Define Legend

To define the legend in the chart, initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class and add it to the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend/>
        </chart:SfCartesianChart.Legend>
    </chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %}

## Legend visibility
To define the chart legend visibility using [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property. The default value of IsVisible property is `true`.

{% tabs %}

{% highlight xaml %}
    
    <chart:SfCartesianChart>
        <chart:SfCartesianChart.Legend>
        <chart:ChartLegend IsVisible = "True"/>
        </chart:SfCartesianChart.Legend>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend(){ IsVisible = true };

    PieSeries series = new PieSeries()
    {
    ItemsSource = viewModel.Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    };
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## LegendItems Visibility
To define the legend item visiblity at specific series using [IsVisibleOnLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend). The defualt value of the IsVisibleOnLegend property is `true`.

{% tabs %}

{% highlight xaml %}
    
    <chart:SfCartesianChart>
        <chart:SfCartesianChart.Legend>
        <chart:ChartLegend />
        </chart:SfCartesianChart.Legend>

        <chart:LineSeries ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        IsVisibleOnLegend="True"
                        YBindingPath="YValue"/>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend(){ };

    LineSeries series = new LineSeries()
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
To specify the legend icon based on associate series type using the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LegendIcon) and change its type using [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum values. The default value of the LegendIcon property is `Circle`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        <chart:SfCartesianChart.Legend>
           <chart:ChartLegend />
        </chart:SfCartesianChart.Legend>

         <chart:ColumnSeries ItemsSource="{Binding Data}"
                           XBindingPath="XValue"
                           YBindingPath="YValue"
                           LegendIcon = "Diamond"/>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.Legend = new ChartLegend();
    ViewModel viewModel = new ViewModel();

    ColumnSeries columnSeries = new ColumnSeries()
    {
          ItemsSource = viewModel.Data,
          XBindingPath = "XValue",
          YBindingPath = "YValue",
          LegendIcon = ChartLegendIconType.Diamond,
    };

    chart.Series.Add(columnSeries);

{% endhighlight %}

{% endtabs %}

## Placement
To place the legend view at left, right, top, or bottom around the chart area using [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement) property in ChartLegend class. The default value of the legend placement is `Top`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart >
        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend Placement="Bottom"  >
            </chart:ChartLegend>
      </chart:SfCartesianChart.Legend>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    ViewModel viewModel = new ViewModel();

    chart.Legend = new ChartLegend()
    { Placement = LegendPlacement.Bottom };

{% endhighlight %}

{% endtabs %}

## Toggle the series visibility
To visible or hide the cartesian series visibility by tapping the legend item using [ToggleSeriesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) property. The default value of ToggleSeriesVisibility property is `false`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart >
        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend           
              ToggleSeriesVisibility="True">
        </chart:ChartLegend>
      </chart:SfCartesianChart.Legend>
    </chart:SfCartesianChart>

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

## Items Layout
An [ItemsLayout]() property is used to customize the arrangement and posistion for each legend item. The default value is `null`. It accepts any layout type in ItemsLayout property.

For more details about the layout alignment refer to this [article].

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart >
        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend >
            <chart:ChartLegend.ItemsLayout>
              <FlexLayout Wrap="Wrap"
                          WidthRequest="400">
              </FlexLayout>
            </chart:ChartLegend.ItemsLayout>
        </chart:ChartLegend>
      </chart:SfCartesianChart.Legend>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
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

## Template

The [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) provides support to customize the appearance of the legend items by using the [ItemsTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-28%2Ctabid-5%2Ctabid-7#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property. The default value of the ItemsTemplate property is `null`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart >
        <chart:SfCartesianChart.Resources>
            <DataTemplate x:Key="legendTemplate">
            <StackLayout Orientation="Horizontal" >
                <Rectangle HeightRequest="12" 
                    WidthRequest="12" Margin="3"
                    Background="{Binding IconBrush}"/>
            <Label Text="{Binding Text}" 
                    Margin="3"/>
        </StackLayout>
    </DataTemplate>
    </chart:SfCartesianChart.Resources>  
    
    <chart:SfCartesianChart.Legend>
        <chart:ChartLegend    
               ItemTemplate="{StaticResource legendTemplate}">
        </chart:ChartLegend>
      </chart:SfCartesianChart.Legend>
    </chart:SfCartesianChart>

{% endhighlight %}


{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
     
    ChartLegend legend = new ChartLegend();
    legend.ItemTemplate = chart.Resources["legendTemplate"] as DataTemplate;
    ...
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

