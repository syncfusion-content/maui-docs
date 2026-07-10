---
layout: post
title: Doughnut chart in .NET MAUI Circular Chart control | Syncfusion
description: Learn here all about doughnut chart and its features in Syncfusion® .NET MAUI Circular Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Doughnut Chart in .NET MAUI Circular Chart

[DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) is similar to [PieSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html). It is used to show the relationship between parts of data and whole data. To render a [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) in circular chart, create an instance of the [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection property of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCircularChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/circular-charts/getting-started)** guide.

N> The circular chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:DoughnutSeries ItemsSource="{Binding Data}" 
                          XBindingPath="Product" 
                          YBindingPath="SalesRate"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DoughnutSeries series = new DoughnutSeries(); 
series.ItemsSource = (new SalesViewModel()).Data;
series.XBindingPath = "Product"; 
series.YBindingPath = "SalesRate"; 

chart.Series.Add(series); 
this.Content = chart; 

{% endhighlight %}

{% endtabs %}

![Doughnut chart type in .NET MAUI Circular Chart](Chart-Types_images/maui_doughnut_chart.png)

## Inner Radius

The [InnerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_InnerRadius) property of [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) controls the size of the inner hole of the doughnut. It accepts a coefficient value from `0` to `1`, where `0` renders a full pie and `1` renders an empty ring. The default value is `0.4`.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:DoughnutSeries ItemsSource="{Binding Data}"
                          XBindingPath="Product"
                          YBindingPath="SalesRate"
                          InnerRadius="0.7"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DoughnutSeries series = new DoughnutSeries();
series.ItemsSource = (new SalesViewModel()).Data;
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
series.InnerRadius = 0.7; 

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Inner radius doughnut chart in .NET MAUI Circular Chart](Chart-Types_images/maui_doughnut_chart_doughnutcoefficient.png)

## Semi Doughnut

By using the [StartAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle) properties, you can draw the doughnut series in different shapes such as a semi-doughnut or quarter-doughnut. Both properties accept values in **degrees** (0 to 360), where a full doughnut is drawn from `StartAngle="0"` to `EndAngle="360"`.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:DoughnutSeries ItemsSource="{Binding Data}"
                          XBindingPath="Product" 
                          YBindingPath="SalesRate"
                          StartAngle="180" EndAngle="360"/>
</chart:SfCircularChart>
    
{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DoughnutSeries series = new DoughnutSeries();
series.ItemsSource = (new SalesViewModel()).Data;
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
series.StartAngle = 180; 
series.EndAngle = 360; 

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Semi doughnut chart in .NET MAUI Circular Chart](Chart-Types_images/maui_semi_doughnut_chart.png)

## Center View

The view placed in the center of the doughnut chart is useful for sharing additional information about the doughnut chart. Any view can be added to the center of the doughnut chart using the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) property of [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html). The binding context of the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) is the respective doughnut series, so properties such as [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize) can be bound directly against the series to size the center view container.

### Center Hole Size

The [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize) property of [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) returns the **diameter of the center hole, in pixels (px)**. Bind the `HeightRequest` and `WidthRequest` of the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) container to [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize) to prevent the center view from overlapping with the doughnut segments.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>    
    <chart:DoughnutSeries ItemsSource="{Binding Data}" XBindingPath="Product" YBindingPath="SalesRate"/>
        <chart:DoughnutSeries.CenterView>
            <Border HeightRequest="{Binding CenterHoleSize}" WidthRequest="{Binding CenterHoleSize}">
                <Border.StrokeShape>
                    <RoundRectangle CornerRadius="200"/>
                </Border.StrokeShape>
                <VerticalStackLayout>
                    <Label Text="Total :"/>
                    <Label Text="357,580 km²"/>
                </VerticalStackLayout>
            </Border>
        </chart:DoughnutSeries.CenterView>
    </chart:DoughnutSeries>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();  

DoughnutSeries series = new DoughnutSeries();
series.ItemsSource = new SalesViewModel().Data;
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";

Border border = new Border(); 

Label name = new Label();
name.Text = "Total :";

Label value = new Label();
value.Text = "357,580 km²";

VerticalStackLayout layout = new VerticalStackLayout();
layout.Add(name);
layout.Add(value);
border.Content = layout;

series.CenterView = border; 

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Center view in .NET MAUI Circular Chart](Chart-Types_images/maui_center_View.png)
