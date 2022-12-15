---
layout: post
title: Waterfall Series Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the Waterfall Series chart and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Waterfall Series Chart in .NET MAUI Chart

## Waterfall Series Chart

[WaterfallSeries]() clarifies the cumulative effect of set of provided positive and negative values. The series is represented by a rectangle and a connector between the rectangles.

The following code illustrates how to use the series in chart.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries ItemsSource="{Binding RevenueDetails}"  
                           XBindingPath="Category" 
                           YBindingPath="Value">
    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries waterfallSeries = new WaterfallSeries();
    waterfallSeries.ItemsSource = new ViewModel().RevenueDetails;
    waterfallSeries.XBindingPath = "Category";
    waterfallSeries.YBindingPath = "Value";
    chart.Series.Add(waterfallSeries);

{% endhighlight %}

{% endtabs %}

![Waterfall Chart in MAUI Chart](WaterfallOutput_Images/Main.png)

### SummarySegmentPath and SummarySegmentBrush

[SummaryBindingPath]() gets or sets the string value that indicates the sum of previous segments in series.

The summary segment can be differentiated by applying the [SummarySegmentBrush]() in series.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries ItemsSource="{Binding RevenueDetails}"  
                                    XBindingPath="Category"
                                    YBindingPath="Value" 
                                    Interior="Gray"
                                    SummaryBindingPath="IsSummary"
                                    SummarySegmentBrush="RoyalBlue">
    </chart:WaterfallSeries>
{% endhighlight %}

{% highlight c# %}

    WaterfallSeries waterfallSeries = new WaterfallSeries();
    waterfallSeries.ItemsSource = new ViewModel().RevenueDetails;
    waterfallSeries.XBindingPath = "Category";
    waterfallSeries.YBindingPath = "Value";
    waterfallSeries.SummaryBindingPath = "IsSummary";
    waterfallSeries.SummarySegmentBrush = new SolidColorBrush(Colors.RoyalBlue);
    chart.Series.Add(waterfallSeries);
{% endhighlight %}

{% endtabs %}

![Summary Segment Path in Waterfall Chart](WaterfallOutput_Images/SummaryBindingPath.png)

### NegativeSegmentBrush

The appearance of the negative segment can be changed by using the [NegativeSegmentBrush]() property of series.

The following code illustrates how to change the appearance of the negative segment.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries NegativeSegmentBrush="Red">

    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries waterfallSeries = new WaterfallSeries();
    waterfallSeries.NegativeSegmentBrush = new SolidColorBrush(Colors.Red);

{% endhighlight %}

{% endtabs %}


![Negative Segment Brush in Waterfall Chart](WaterfallOutput_Images/NegativeSegmentBrush.png)


### AllowAutoSum

The summary segment calculation can be changed by using the [AllowAutoSum]() property. By default, the property is true. When disabling this property, it renders the segment by using the y value of provided ItemsSource collection.

The following code example illustrates how the AllowAutoSum property value can be set.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries AllowAutoSum="False"        
                        SummaryBindingPath="IsSummary"
                        SummarySegmentBrush="RoyalBlue">
    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries waterfallSeries = new WaterfallSeries();
    waterfallSeries.AllowAutoSum = true;
    waterfallSeries.SummaryBindingPath = "IsSummary";
    waterfallSeries.SummarySegmentBrush = new SolidColorBrush(Colors.RoyalBlue);
    chart.Series.Add(waterfallSeries);

{% endhighlight %}

{% endtabs %}


![Allow Auto Sum in Waterfall Chart](WaterfallOutput_Images/AllowAutoSum.png)

### ConnectorLine

The connector line of series can be enabled or disabled by using its [ShowConnector]() line property. By default, the property value is true.
The following code example illustrates how the AllowAutoSum property value can be set.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries ShowConnector="False">
    </chart:WaterfallSeries>

{% endhighlight %}

{% highlight c# %}

    WaterfallSeries waterfallSeries = new WaterfallSeries();
    waterfallSeries.ShowConnector = false;

{% endhighlight %}

{% endtabs %}

![Connector Line in Waterfall Chart](WaterfallOutput_Images/ShowConnectorLines.png)

### Connector line customization

The connector line can be customized by applying [ConnectorLineStyle]() property of the series. The following code example illustrates how to apply style for connector line.

{% tabs %}

{% highlight xaml %}

    <chart:WaterfallSeries.ConnectorLineStyle>
    <Style TargetType="Line">
    <Setter Property="Stroke" Value="Red"/>
    <Setter Property="StrokeDashArray" Value="1"/>
    <Setter Property="StrokeThickness" Value="2"/>
    </Style>
    </chart:WaterfallSeries.ConnectorLineStyle>

{% endhighlight %}

{% highlight c# %}

    Style style = new Style(typeof(Line));
    style.Setters.Add(new Setter(Line.StrokeProperty, new SolidColorBrush(Colors.Red)));
    style.Setters.Add(new Setter(Line.StrokeDashArrayProperty, new DoubleCollection() { 1 }));
    style.Setters.Add(new Setter(Line.StrokeThicknessProperty, 2));
    WaterfallSeries series = new WaterfallSeries();
    series.ConnectorLineStyle = style;

{% endhighlight %}

{% endtabs %}


![Connector line customization in Waterfall Chart](WaterfallOutput_Images/ConnectorCustomise.png)

N> You can explore our [WPF Waterfall Chart]() feature tour page for its groundbreaking features. You can also explore our [WPF Waterfall Chart]() example to know how to represent time-dependent data, showing trends in data at equal intervals.