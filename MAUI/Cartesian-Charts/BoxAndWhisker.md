---
layout: post
title: BoxAndWhisker Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about BoxAndWhisker chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Box And Whisker Chart in .NET MAUI Chart

BoxAndWhisker chart is used to show the distribution of data within a population. To render a BoxAndWhisker chart, create an instance of [BoxAndWhiskerSeries](), and add it to the [Series]() collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).The following code illustrates how to define the series in chart.

N> The cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

N> By default,the BoxPlotMode property value is Exclusive.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:BoxAndWhiskerSeries ItemsSource="{Binding BoxWhiskerData}"
                               XBindingPath="Department"
                               YBindingPath="Age"/>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    BoxAndWhiskerSeries series = new BoxAndWhiskerSeries()
    {
        ItemsSource = new ViewModel().BoxWhiskerData,
        XBindingPath = "Department",
        YBindingPath = "Age",
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![BoxAndWhisker chart type in MAUI Chart](Chart-Types_images/BasicRendering.png)

## Customize the series BoxPlot mode

The series box plotting mode can be changed by using [BoxPlotMode]() property of [BoxAndWhiskerSeries](). The plotting mode of series can be calculated as follows:

*`Exclusive`-The quartile values are calculated by using the formula (N+1) * P (N count, P percentile) and its index value starts from 1 in the list.

*`Inclusive`- The quartile values are calculated by using the formula (N−1) * P (N count, P percentile) and its index value starts from 0 in the list.

*`Normal`-The quartile values are calculated by splitting the list and getting the median values.

## Normal

The following code illustrate how to define property [BoxPlotMode] value as Normal.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>  

    <chart:BoxAndWhiskerSeries ItemsSource="{Binding BoxWhiskerData}"
                               XBindingPath="Department"
                               YBindingPath="Age"
                               BoxPlotMode="Normal"/>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    BoxAndWhiskerSeries series = new BoxAndWhiskerSeries()
    {
        ItemsSource = new ViewModel().BoxWhiskerData,
        XBindingPath = "Department",
        YBindingPath = "Age",
        BoxPlotMode="Normal"/>
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![BoxPlotMode Normal in MAUI Chart](Chart-Types_images/BoxPlotModeNormal.png)

## Inclusive

The following code illustrate how to define property [BoxPlotMode] value as Inclusive.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>  

    <chart:BoxAndWhiskerSeries ItemsSource="{Binding BoxWhiskerData}"
                               XBindingPath="Department"
                               YBindingPath="Age"
                               BoxPlotMode="Inclusive"/>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    BoxAndWhiskerSeries series = new BoxAndWhiskerSeries()
    {
        ItemsSource = new ViewModel().BoxWhiskerData,
        XBindingPath = "Department",
        YBindingPath = "Age",
        BoxPlotMode="Normal"/>
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![BoxPlotMode Inclusive in MAUI Chart](Chart-types_images/BoxPlotModeInclusive.png)

## Outlier

The outlier is used to display the outlier point that lies either below the lower whisker or above the upper whisker line and it is an observation that is numerically distant from the rest of the data.

## ShowOutlier

The outlier value in the box plot can be viewed by enabling the [ShowOutlier]() property of [BoxAndWhiskerSeries].The following code demonstrates how to disable the [ShowOutlier]() property.

N> By default, [ShowOutlier] value is true.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>  

    <chart:BoxAndWhiskerSeries ItemsSource="{Binding BoxWhiskerData}"
                                XBindingPath="Department"
                                YBindingPath="Age"
                                ShowOutlier="False"/>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    BoxAndWhiskerSeries series = new BoxAndWhiskerSeries()
    {
        ItemsSource = new ViewModel().BoxWhiskerData,
        XBindingPath = "Department",
        YBindingPath = "Age",
        ShowOutlier="False"/>
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Outlier Segment in MAUI chart](Chart-types_images/ShowOutlierFalse.png)

