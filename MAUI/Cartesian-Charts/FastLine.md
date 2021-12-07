---
layout: post
title: FastLine Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about fast line series support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Fast Line Chart in MAUI (SfCartesianChart)

## Fast Line Chart

The `FastLineSeries` is a special kind of line series that can render a collection with huge number of datapoints.

{% tabs %}

{% highlight xaml %}

 <chart:SfCartesianChart x:Name="chart">

            <chart:SfCartesianChart.PrimaryAxis>
                <chart:DateTimeAxis />
            </chart:SfCartesianChart.PrimaryAxis>

            <chart:SfCartesianChart.SecondaryAxis>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.SecondaryAxis>

            <chart:SfCartesianChart.Series>
                
            <chart:FastLineSeries XBindingPath="Date"
                                  YBindingPath="YValue"
                                  ItemsSource="{Binding Data}"/>
            </chart:SfCartesianChart.Series>
            
        </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

 SfCartesianChart chart = new SfCartesianChart();
            chart.PrimaryAxis = new DateTimeAxis();
            chart.SecondaryAxis = new NumericalAxis();

            FastLineSeries series = new FastLineSeries()
            {
                ItemsSource = new FastLineChartViewModel().Data,
                XBindingPath = "Date",
                YBindingPath = "YValue",
            };

            chart.Series.Add(series);

            this.Content = chart;

{% endhighlight %}

{% endtabs %}

![FastLine Chart in MAUI](Chart-types_images/maui_fastline_chart.png)

### Dashed fast line

The `StrokeDashArray` property of `FastLineSeries` is used to render the line with dashes. Odd value is considered as rendering size and even value is considered as gap.

{% tabs %}

{% highlight xaml %}

 <chart:FastLineSeries x:Name="series" XBindingPath="Name" 
                            YBindingPath="Height"
                            ItemsSource="{Binding Data}"
                            StrokeDashArray="4,8"/>

{% endhighlight %}

{% highlight c# %}

 FastLineSeries series = new FastLineSeries()
			{
				ItemsSource = new FastLineChartViewModel().Data,
				XBindingPath = "Date",
				YBindingPath = "YValue",
				StrokeDashArray=new DoubleCollection() { 4,8}
			};

{% endhighlight %}

{% endtabs %}

![FastLine Chart in MAUI](Chart-types_images/maui_dashed_fastline_chart.png)

### Anti-aliasing

There might be some jagged lines at the edges. This is can be reduced using the `EnableAntiAliasing` property.

{% tabs %}

{% highlight xaml %}

<chart:FastLineSeries XBindingPath="Date"
                                  YBindingPath="YValue"
                                  EnableAntiAliasing="True"
                                  ItemsSource="{Binding Data}"/>

{% endhighlight %}

{% highlight c# %}

 FastLineSeries series = new FastLineSeries()
			{
				ItemsSource = new FastLineChartViewModel().Data,
				XBindingPath = "Date",
				YBindingPath = "YValue",
				EnableAntiAliasing = true
			};

{% endhighlight %}

{% endtabs %}
