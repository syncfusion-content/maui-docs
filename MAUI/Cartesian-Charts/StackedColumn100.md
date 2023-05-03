---
layout: post
title: StackedColumn100 Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about StackedColumn100 chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# StackedColumn100 Chart in .NET MAUI Chart

The Stacked column 100 % series chart is type of Stacked chart that is used to display the proportion of different categories within a single column. The columns are stacked top of each other , and the total height of each column is always same, representing 100% of the categories.

## StackedColumn100 Chart

To render the StackedColumn100 chart,create an instance of [StackingColumn100Series](),and add it to the [Series]() collection property of [SfCartesianChart]().

N> The cartesian chart has [Series]() as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:StackingColumn100Series ItemSource="{Binding Data}"
                                   XBindingPath="Name"
                                   YBindingPath="Value"
                                   />

    <chart:StackingColumn100Series ItemSource="{Binding Data1}"
                                   XBindingPath="Name"
                                   YBindingPath="Value"
                                   />

    <chart:StackingColumn100Series ItemSource="{Binding Data2}"
                                   XBindingPath="Name"
                                   YBindingPath="Value"
                                   />

</chart:SfCartesianChart>

{% endhighlight xaml %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    StackingColumn100Series series = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Name",
        YBindingPath = "Value",
    };
    StackingColumn100Series series1 = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data1,
        XBindingPath = "Name",
        YBindingPath = "Value",
    };
    StackingColumn100Series series2 = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data2,
        XBindingPath = "Name",
        YBindingPath = "Value",
    };
 
    chart.Series.Add(series);
    chart.Series.Add(series1);
    chart.Series.Add(series2);
    this.Content = chart;

{% endhighlight C# %}

{% endtabs %}

![Stacking Column 100 Chart in MAUI](Chart-types_images/StackedColumn100Chart.png)

## Grouping Series 

We can group and stack the similar stacked column 100 series type using the [GroupingLabel]() property. 


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:StackingColumn100Series ItemSource="{Binding Data}"
                                   XBindingPath="XValue"
                                   YBindingPath="YValue"
                                   GroupingLabel="GroupOne"/>

    <chart:StackingColumn100Series ItemSource="{Binding Data1}"
                                   XBindingPath="XValue"
                                   YBindingPath="YValue"
                                   GroupingLabel="GroupOne"/>

    <chart:StackingColumn100Series ItemSource="{Binding Data2}"
                                   XBindingPath="XValue"
                                   YBindingPath="YValue"
                                   GroupingLabel="GroupTwo"/>

    <chart:StackingColumn100Series ItemSource="{Binding Data3}"
                                   XBindingPath="XValue"
                                   YBindingPath="YValue"
                                   GroupingLabel="GroupTwo"/>

</chart:SfCartesianChart>

{% endhighlight xaml %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    StackingColumn100Series series = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "XValue",
        YBindingPath = "YValue",
        GroupingLabel="GroupOne"
    };
    StackingColumn100Series series1 = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data1,
        XBindingPath = "XValue",
        YBindingPath = "YValue",
        GroupingLabel="GroupOne"
    };
    StackingColumn100Series series2 = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data2,
        XBindingPath = "XValue",
        YBindingPath = "YValue",
        GroupingLabel="GroupTwo"
    };
    StackingColumn100Series series3 = new StackingColumn100Series()
    {
        ItemsSource = new ViewModel().Data3,
        XBindingPath = "XValue",
        YBindingPath = "YValue",
        GroupingLabel="GroupTwo"
    };

    chart.Series.Add(series);
    chart.Series.Add(series1);
    chart.Series.Add(series2);
    chart.Series.Add(series3);
    this.Content = chart;

{% endhighlight C# %}

{% endtabs %}


