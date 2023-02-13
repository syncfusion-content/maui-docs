---
layout: post
title: Radial Bar chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about radial bar chart and its features in Syncfusion .NET MAUI Chart Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Radial Bar Chart in .NET MAUI Chart

[RadialBarSeries]() is a type of doughnut chart that represents each segment as a separate circle. It is used to compare values between various categories. To render a [RadialBarSeries]() in circular chart, create an instance of the [RadialBarSeries]() and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection property of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

N> The circular chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" />
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart type in MAUI Chart](Chart-Types_images/maui_radialbar_chart.png)

## Track Stroke

You can use the following properties to customize the appearance of the circular bar track.

 * [TrackStroke]() - To customize the circular bar border color.

  * [TrackStrokeWidth]() - To customize the border width of the circular bar.

  * [TrackFill]() - To customize the ciruclar bar area which behind the radial bar segments.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" 
                        TrackStrokeWidth = "1"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;
        series.TrackStrokeWidth = 1;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart track stroke in MAUI Chart](Chart-Types_images/maui_trackstrokewidth.png)

## CapStyle

The [CapStyle]() property of the radial bar series is used to specify the shape of the start and end points of the circular segment. The default value of this property is [Both.Flat]().

The following types are available for [CapStyle]() property.

 * [BothFlat]() - Indicates that a flat shape should appear at the start and end positions of the segment.

 * [BothCurve]() - Indicates that a curve shape should appear at the start and end positions of the segment. 

 * [StartCurve]() - Indicates that a curve shape should appear at the start position of the segment.

 * [EndCurve]() - Indicates that a curve shape should appear at the end position of the segment.

 ### BothCuve

 {% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" 
                        CapStyle = "BothCurve"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;
        series.CapStyle = CapStyle.BothCurve;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart both curve cap style in MAUI Chart](Chart-Types_images/maui_bothcurve.png)

### StartCurve

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" 
                        CapStyle = "StartCurve"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;
        series.CapStyle = CapStyle.StartCurve;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart start curve cap style in MAUI Chart](Chart-Types_images/maui_startcurve.png)

### EndCurve

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" 
                        CapStyle = "EndCurve"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;
        series.CapStyle = CapStyle.EndCurve;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart both curve cap style in MAUI Chart](Chart-Types_images/maui_endcurve.png)

## Inner Radius and Gap Ratio

The following properties are customize the size of the radial bar chart.

 * The [InnerRadius]() property of radial bar series is used to define the inner circle. The default value of this property is `0.4`.

  * The [GapRatio]() property of the radial bar series is used to define the spacing between each segments. The default value of this property is `0.2`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" 
                        InnerRadius = "0.2"
                        GapRatio = "0.4"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;
        series.InnerRadius = 0.2;
        series.GapRatio = 0.4;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart both curve cap style in MAUI Chart](Chart-Types_images/maui_innerradius_gapratio.png)

## Maximum Value

The [MaximumValue]() property of the radial bar series is used to define the span of the segment-filled area in the radial bar track. The default value of this property is `double.NaN`.

## CenterView

The view placed in the center of the radial bar chart is useful for sharing additional information about the radial bar chart. Any view can be added to the center of the doughnut chart using the [CenterView]() property of [RadialBarSeries](). The binding context of the [CenterView]() will be the respective radial bar series.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        StartAngle = "-90"
                        EndAngle = "270" 
                        MaximumValue = 100;
                        CapStyle = "BothCurve">
                    <chart:RadialBarSeries.CenterView>
                        <Image Source="person.png"      
                            HeightRequest="200" 
                            WidthRequest="150"
                            HorizontalOptions="Center" 
                            VerticalOptions="Center"/>
                </chart:RadialBarSeries.CenterView>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.StartAngle = -90;
        series.EndAngle = 270;
        series.CapStyle = CapStyle.BothCurve;

        Image image = new Image();
        image.Source = "person.png";
        image.HeightRequest = 200;
        image.WeightRequest = 150;
        image.HorizontalOptions = LayoutOptions.Center;
        image.VerticalOptions = LayoutOptions.Center;        

        series.CenterView = image;
        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart both curve cap style in MAUI Chart](Chart-Types_images/maui_radialbarchart_centerview.png)
