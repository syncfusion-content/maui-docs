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

The following properites can be used to customize the appearance of the radial bar segment:

 * [Opacity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_OpacityProperty) - To control the transparency of the chart segments.

 * [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Stroke) - To customize the outer layer of the chart segments.

 * [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StrokeWidth) - To customize the width of the stroke in chart segments.

 * [GapRatio]() - To customize the spacing between each chart segments.

 * [MaximumValue]() - To represent the span of the segment-filled area in the radial bar track. The default value of this property is `double.NaN`.

 * [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) - To customize the appearance of the series.


{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" />
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart type in MAUI Chart](Chart-Types_images/maui_radialbar_chart.png)

## Changing the radial bar size

You can use the [Radius]() property to change the radial bar chart size. The default value of the radius is [0.8]().

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        Radius = "0.5"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.Radius = 0.5;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart radius size in MAUI Chart](Chart-Types_images/maui_radius.png)

## Changing the radial bar inner radius

The [InnerRadius]() property of radial bar series is used to define the inner circle. The default value of this property is `0.4`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        InnerRadius = "0.2"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.InnerRadius = 0.2;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart inner radius customization in MAUI Chart](Chart-Types_images/maui_inner_radius.png)

## CapStyle customization

The [CapStyle]() property of the radial bar series is used to specify the shape of the start and end points of the circular segment. The default value of this property is `Both.Flat`.

The following types are available for [CapStyle]() property.

 * [BothFlat]() - Indicates that a flat shape should appear at the start and end positions of the segment.

 * [BothCurve]() - Indicates that a curve shape should appear at the start and end positions of the segment. 

 * [StartCurve]() - Indicates that a curve shape should appear at the start position of the segment.

 * [EndCurve]() - Indicates that a curve shape should appear at the end position of the segment.

### BothFlat

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate"
                        CapStyle = "BothFlat"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.CapStyle = CapStyle.BothFlat;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart both flat cap style in MAUI Chart](Chart-Types_images/maui_radialbar_chart.png)

 ### BothCurve

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate"
                        CapStyle = "BothCurve"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
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
                        CapStyle = "StartCurve"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
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
                        CapStyle = "EndCurve"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.CapStyle = CapStyle.EndCurve;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart end curve cap style in MAUI Chart](Chart-Types_images/maui_endcurve.png)

## Segment spacing

The [GapRatio]() property of the radial bar series is used to define the spacing between each segments. The default value of this property is `0.2`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        InnerRadius = "0.2"
                        GapRatio = "0.4"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.InnerRadius = 0.2;
        series.GapRatio = 0.4;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart segment spacing in MAUI Chart](Chart-Types_images/maui_gapratio.png)

## Track customization

You can use the following properties to customize the appearance of the circular bar track.

 * [TrackStroke]() - To customize the circular bar border color.

  * [TrackStrokeWidth]() - To customize the border width of the circular bar.

  * [TrackFill]() - To customize the circular bar area which behind the radial bar segments.

### TrackStrokeWidth

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        TrackStrokeWidth = "1"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.TrackStrokeWidth = 1;

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart track stroke in MAUI Chart](Chart-Types_images/maui_trackstrokewidth.png)

### TrackFill

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        TrackFill="#FFF7ED" 
                        TrackStrokeWidth="1" 
                        TrackStroke="#FED7AA" />
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.TrackFill = new SolidColorBrush(Color.FromArgb("#FFF7ED"));
        series.TrackStrokeWidth = 1;
        series.TrackStroke = new SolidColorBrush(Color.FromArgb("#FED7AA"));

        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}


![Radial bar chart track fill in MAUI Chart](Chart-Types_images/maui_trackfill.png)

## CenterView

The view placed in the center of the radial bar chart is useful for sharing additional information about the radial bar chart. Any view can be added to the center of the radial bar chart using the [CenterView]() property of [RadialBarSeries](). The binding context of the [CenterView]() will be the respective radial bar series.

### CenterHoleSize

The [CenterHoleSize]() property of RadialBarSeries is used to get the diameter value of the center hole. Using the CenterHoleSize, we can protect the view in the radial bar center from overlapping with the series

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    <chart:RadialBarSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate" 
                        MaximumValue = 100;
                        CapStyle = "BothCurve">
                    <chart:RadialBarSeries.CenterView>
                        <StackLayout HeightRequest="{Binding CenterHoleSize}"
                                     WidthRequest="{Binding CenterHoleSize}">
                            <Image Source="person.png" />
                        </StackLayout>
                </chart:RadialBarSeries.CenterView>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

        RadialBarSeries series = new RadialBarSeries();
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.CapStyle = CapStyle.BothCurve;

        StackLayout layout = new StackLayout();
        Image image = new Image { Source = "person.png" };
        layout.SetBinding(HeightRequestProperty, nameof(RadialBarSeries.CenterHoleSize));
        layout.SetBinding(WidthRequestProperty, nameof(RadialBarSeries.CenterHoleSize));
        layout.Children.Add(image);       

        series.CenterView = image;
        chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Radial bar chart center view in MAUI Chart](Chart-Types_images/maui_radialbarchart_centerview.png)
