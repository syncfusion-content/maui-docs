---
layout: post
title: StepLine Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about stepline chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# StepLine Chart in .NET MAUI Chart

StepLine chart is used to display the data showing changes in values over time by connecting points on plots with a combination of horizontal and vertical lines.

## StepLine Chart

To render the StepLine chart,create an instance of [StepLineSeries](),and add it to the [Series]() collection property of [SfCartesianChart]().

N> The cartesian chart has [Series]() as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DatetimeAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:StepLineSeries ItemSource="{Binding Data}"
                          XBindingPath="Date"
                          YBindingPath="Value"
                          />

    <chart:StepLineSeries ItemSource="{Binding Data1}"
                          XBindingPath="Date"
                          YBindingPath="Value"
                          />

</chart:SfCartesianChart>

{% endhighlight xaml %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    DatetimeAxis primaryAxis = new DatetimeAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    StepLineSeries series = new StepLineSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Date",
        YBindingPath = "Value",
    };

    StepLineSeries series1 = new StepLineSeries()
    {
        ItemsSource = new ViewModel().Data1,
        XBindingPath = "Date",
        YBindingPath = "Value",
    };

    chart.Series.Add(series);
    chart.Series.Add(series1);
    this.Content = chart;

{% endhighlight C# %}

{% endtabs %}

![StepLine Chart in MAUI](Chart-types_images/StepLineChart.png)

## Dashed StepLine Chart

The [StrokeDashArray]() property of [StepLineSeries]() is used to render the StepLine series with dashes. Odd value considered as rendering size and Even value considered as gap.

{% tabs %}

{% highlight xaml %}

<Chart:SfCartesianChart>

    <chart:SfCartesianChart.Resource>
        <DoubleCollection x:Key="DashArray">
            <x:Double>5</x:Double>
            <x:Double>2</x:Double>
        </DoubleCollection>
    </chart:SfCartesianChart.Resource>

    <chart:SfCartesianChart.XAxes>
        <chart:DatetimeAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:StepLineSeries ItemsSource="{Binding Data}"
                          StrokeDashArray="DashArray"
                          XBindingPath="Date"
                          YBindingPath="Value"
                        
                        />

    <Chart:SfCartesianChart>

{% endhighlight xaml %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();

    DatetimeAxis primaryAxis = new DatetimeAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    DoubleCollection doubleCollection = new DoubleCollection();
    doubleCollection.Add(5);
    doubleCollection.Add(2);

    StepLineSeries steplineSeries = new StepLineSeries()
    {
        itemSource = new ViewModel().Data;
        XBindingPath = "Date";
        YBindingPath = "Value";
        StrokeDashArray = doubleCollection;
    }

    chart.Series.Add(steplineSeries);
    this.Content = chart;

{% endhighlight C# %}

{% endtabs %}

## Vertical StepLine Chart 

The [isTransposed]() property of [SfCartesianChart]() is used to render the StepLine series in vertically.To enable the StepLine series in vertically , set the [isTransposed]() property to true.  

{% tabs %}

{% highlight xaml %}

<Chart:SfCartesianChart isTransposed="True">

    <chart:SfCartesianChart.XAxes>
        <chart:DatetimeAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:StepLineSeries ItemSource=""{Binding Data}
                          XBindingPath="Year"
                          YBindingPath="Value"
                          />
    <chart:StepLineSeries ItemSource="{Binding Data1}"
                          XBindingPath="Year"
                          YBindingPath="Value"
                          />

    <Chart:SfCartesianChart>

{% endhighlight xaml %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();

    chart.isTransposed = True;

    DatetimeAxis primaryAxis = new DatetimeAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    StepLineSeries steplineSeries = new StepLineSeries()
    {
        itemSource = new ViewModel().Data;
        XBindingPath = "Year";
        YBindingPath = "Value";
    };

    StepLineSeries steplineSeries1 = new StepLineSeries()
    {
        itemSource = new ViewModel().Data;
        XBindingPath = "Year";
        YBindingPath = "Value";
    };

    chart.Series.Add(steplineSeries);
    chart.Series.Add(steplineSeries1);
    this.Content = chart;

{% endhighlight C# %}

{% endtabs %}

![StepLine Chart in MAUI](Chart-types_images/VerticalStepLine.png)