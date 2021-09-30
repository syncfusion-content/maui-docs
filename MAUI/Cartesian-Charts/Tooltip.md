---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip and its customization in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Tooltip in .NET MAUI Chart (SfCartesianChart)

Tooltip is used to display any information over segments. It appears at the data point position when the mouse hovers over any series segment. It is set to display the metadata of the hovered segment or data point.

## Define Tooltip

To define the tooltip in the series, set the `ShowTooltip` property to true. The default value of `ShowTooltip` property is `false`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                ShowTooltip="True"/>

            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2011"
                                ShowTooltip="True"/>
        </chart:SfCartesianChart.Series>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ColumnSeries series1 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        ShowTooltip = true
    };

    ColumnSeries series2 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2011",
        ShowTooltip = true
    };

    chart.Series.Add(series1);
    chart.Series.Add(series2);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

The `ChartTooltipBehavior`) is used to customize the tooltip. For customizing the tooltip, create an instance `ChartTooltipBehavior` and add it to the `ChartBehaviors` collection of `SfCartesianChart`. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart.ChartBehaviors>
        <chart:ChartTooltipBehavior/>
    </chart:SfCartesianChart.ChartBehaviors>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ChartTooltipBehavior behavior = new ChartTooltipBehavior();
    chart.ChartBehaviors.Add(behavior);

{% endhighlight %}

{% endtabs %}

## Duration

The `Duration` property is used to specify the duration time in milliseconds for which tooltip will be displayed.

N> By default, the tooltip will be displayed for 1000 milliseconds.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartTooltipBehavior Duration="5000"/>
        </chart:SfCartesianChart.ChartBehaviors>

        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                ShowTooltip="True"/>
                    
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2011"
                                ShowTooltip="True"/>
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ChartTooltipBehavior tooltipBehavior = new ChartTooltipBehavior();
    tooltipBehavior.Duration = 5000;
    chart.ChartBehaviors.Add(tooltipBehavior);

    ColumnSeries series1 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        ShowTooltip = true
    };

    ColumnSeries series2 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2011",
        ShowTooltip = true
    };

    chart.Series.Add(series1);
    chart.Series.Add(series2);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}
