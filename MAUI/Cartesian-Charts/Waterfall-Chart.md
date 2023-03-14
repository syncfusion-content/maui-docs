---
layout: post
title: Waterfall Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the Waterfall Series chart and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Waterfall Series in .NET MAUI Chart

## Waterfall Series

[WaterfallSeries]() clarifies the cumulative effect of a set of provided positive and negative values. The series is represented by a rectangle and a connector between the rectangles. To render a waterfall chart, create an instance of [WaterfallSeries](), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1)

The following code illustrates how to use the series in chart.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis/>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.YAxes>
    
        <chart:SfCartesianChart.Series>
            <chart:WaterfallSeries ItemsSource="{Binding Sales}"
                                   XBindingPath="Department"
                                   YBindingPath="Value"/>
             </chart:SfCartesianChart.Series>   
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    NumericalAxis xAxis = new CategoryAxis();
    NumericalAxis yAxis = new NumericalAxis();
    chart.XAxes.Add(xAxis);
    chart.YAxes.Add(yAxis);
   
    ViewModel viewModel = new ViewModel();

    WaterfallSeries series = new WaterfallSeries();
    series.ItemsSource =new viewModel().Sales;
    series.XBindingPath = "Department";
    series.YBindingPath = "Value";
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Waterfall Chart in MAUI Chart](Chart-types_images/BasicRendering.png)

### SummarySegmentPath and SummaryPointsBrush

[SummaryBindingPath]() gets or sets the string value that indicates the sum of previous segments in the series.

The summary segment can be differentiated by applying the [SummaryPointsBrush]() in series.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries ItemsSource="{Binding Sales}"  
                           XBindingPath="Department" 
                           YBindingPath="Value"
                           Interior="Blue"
                           SummaryBindingPath="IsSummary"
                           SummaryPointsBrush="RoyalBlue">
    </chart:WaterfallSeries>
{% endhighlight %}

{% highlight c# %}

    WaterfallSeries waterfallSeries = new WaterfallSeries();
    waterfallSeries.ItemsSource =new ViewModel().RevenueDetails;

    waterfallSeries.XBindingPath = "Department";
    waterfallSeries.YBindingPath = "Value";
    waterfallSeries.SummaryBindingPath = "IsSummary";
    waterfallSeries.SummaryPointsBrush = new SolidColorBrush(Colors.Blue);
    chart.Series.Add(waterfallSeries);
{% endhighlight %}

{% endtabs %}

![Summary Segment Path and SummaryPointsBrush in Waterfall Chart](Chart-types_images/SummaryBindingPath.png)

### NegativePointsBrush

The appearance of the negative segment can be changed by using the [NegativePointsBrush]() property of series.

The following code illustrates how to change the appearance of the negative segment.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries NegativePointsBrush="Red">
    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries series = new WaterfallSeries();
    series.NegativePointsBrush = new SolidColorBrush(Colors.Red);

{% endhighlight %}

{% endtabs %}


![Negative Points Brush in Waterfall Chart](Chart-types_images/NegativePointsBrush.png)


### AllowAutoSum

The summary segment calculation can be changed by using the [AllowAutoSum]() property. By default, the property is true. When disabling this property, it renders the segment by using the y value of provided ItemsSource collection.

The following code example illustrates how the AllowAutoSum property value can be set.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries  AllowAutoSum="False"
                            SummaryBindingPath="IsSummary"
                            SummarySegmentBrush="Blue">
    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries series = new WaterfallSeries();
    series.AllowAutoSum = true;
    series.SummaryBindingPath = "IsSummary";
    series.SummarySegmentBrush = new SolidColorBrush(Colors.Blue);
    chart.Series.Add(waterfallSeries);

{% endhighlight %}

{% endtabs %}


![Allow Auto Sum in Waterfall Chart](Chart-types_images/AllowAutoSum.png)

### ConnectorLine

The connector line of series can be enabled or disabled by using its [ShowConnectorLine]() line property. By default, the property value is true.
The following code example illustrates how the ShowConnectorLine value can be set.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries ShowConnectorLine="False">
    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries series = new WaterfallSeries();
    series.ShowConnectorLine = false;

{% endhighlight %}

{% endtabs %}

![Connector Line in Waterfall Chart](Chart-types_images/ShoeConnectorLine.png)

### Connector line customization

The connector line can be customized by applying the[ConnectorLineStyle]() property of the series. The following code example illustrates how to apply style for connector line.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries.ConnectorLineStyle>
    <chart:ChartLineStyle Stroke="Green"
                          StrokeWidth=2>
    </chart:WaterfallSeries.ConnectorLineStyle>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries.ConnectorLineStyle = new ChartLineStyle
    {
        Stroke = Brushes.Green,
        StrokeThickness = 2
    };
    
{% endhighlight %}

{% endtabs %}


![Connector line customization in Waterfall Chart](Chart-types_images/ConnectorLineStyle.png)
