---
layout: post
title: OHLC Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about ohlc chart and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui ohlc chart, .net maui chart ohlc type, ohlc chart customization .net maui, syncfusion maui ohlc chart, .net maui chart ohlc visualization, .net maui bear and bull ohlc chart.
---

# OHLC Chart in .NET MAUI Chart

## OHLC Chart

OHLC (Open-High-Low-Close) charts are the type of financial charts used to represent the price movement of an asset over a specific period. OHLC charts consist of four data points: the opening price, the high price, the low price, and the closing price for each period. To render an OHLC chart, create an instance of [HiLoOpenCloseSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HiLoOpenCloseSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

A collection of five values is required to plot a point on an OHLC chart, including the X-value, open value, high value, low value, and close value. Use the following collection.

{% tabs %}

{% highlight c# %}

ObservableCollection<Model> StockData = new ObservableCollection<Model>();
StockData.Add(new Model { Year = "2000", High = 50, Low = 40, Open = 47, Close = 45 });
StockData.Add(new Model { Year = "2001", High = 50, Low = 35, Open = 45, Close = 40 });
StockData.Add(new Model { Year = "2002", High = 40, Low = 30, Open = 37, Close = 40 });
StockData.Add(new Model { Year = "2003", High = 50, Low = 35, Open = 40, Close = 45 });
StockData.Add(new Model { Year = "2004", High = 45, Low = 30, Open = 35, Close = 32 });
StockData.Add(new Model { Year = "2005", High = 50, Low = 35, Open = 40, Close = 45 });
StockData.Add(new Model { Year = "2006", High = 40, Low = 31, Open = 36, Close = 34 });
StockData.Add(new Model { Year = "2007", High = 48, Low = 38, Open = 43, Close = 40 });
StockData.Add(new Model { Year = "2008", High = 55, Low = 45, Open = 48, Close = 50 });
StockData.Add(new Model { Year = "2009", High = 45, Low = 30, Open = 35, Close = 40 });
StockData.Add(new Model { Year = "2010", High = 50, Low = 40, Open = 40, Close = 35 });

{% endhighlight %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>   

    <chart:HiLoOpenCloseSeries ItemsSource="{Binding StockData}"
                               XBindingPath="Year"
                               Open="Open"
                               High="High"
                               Low="Low"
                               Close="Close"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

HiLoOpenCloseSeries series = new HiLoOpenCloseSeries()
{
    ItemsSource = new ViewModel().StockData,
    XBindingPath = "Year",
    Open = "Open",
    High = "High",
    Low = "Low",
    Close = "Close",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![OHLC chart type in MAUI Chart](Chart-types-images/OHLCBasicRendering.png)

## Bull and Bear Color

In the OHLC chart, the [BullishFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FinancialSeriesBase.html#Syncfusion_Maui_Charts_FinancialSeriesBase_BullishFill) property is used to specify a fill color for the segments that indicates an increase in the stock price in the measured time interval, and the [BearishFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FinancialSeriesBase.html#Syncfusion_Maui_Charts_FinancialSeriesBase_BearishFill) property is used to specify a fill color for the segments that indicates a decrease in the stock price in the measured time interval.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>   

    <chart:HiLoOpenCloseSeries ItemsSource="{Binding StockData}"
                               XBindingPath="Year"
                               Open="Open"
                               High="High"
                               Low="Low"
                               Close="Close"
                               BullishFill="Blue"
                               BearishFill="Orange"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

HiLoOpenCloseSeries series = new HiLoOpenCloseSeries()
{
    ItemsSource = new ViewModel().StockData,
    XBindingPath = "Year",
    Open = "Open",
    High = "High",
    Low = "Low",
    Close = "Close",
    BullishFill = Colors.Blue,
    BearishFill = Colors.Orange,
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![OHLC chart fill color in MAUI Chart](Chart-types-images/OhlcFillColor.png)
