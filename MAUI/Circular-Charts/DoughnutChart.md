---
layout: post
title: Doughnut chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about doughnut chart and its features in Syncfusion .NET MAUI Chart Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Doughnut Chart in .NET MAUI Chart

[DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) is similar to [PieSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html). It is used to show the relationship between parts of data and whole data. To render a [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) in circular chart, create an instance of the [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection property of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

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
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Doughnut chart type in MAUI Chart](Chart-Types_images/maui_doughnut_chart.png)

## Inner Radius

The [InnerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_InnerRadius) property of doughnut series is used to define the inner circle.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:DoughnutSeries ItemsSource="{Binding Data}"
                          InnerRadius="0.7"	
                          XBindingPath="Product"
                          YBindingPath="SalesRate"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
DoughnutSeries series = new DoughnutSeries();
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
series.InnerRadius = 0.7;

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Doughnut chart with coefficient in MAUI Chart](Chart-Types_images/maui_doughnut_chart_doughnutcoefficient.png)

## Semi Doughnut

By using the [StartAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle) properties, you can draw doughnut series in different shapes such as semi-doughnut or quarter doughnut series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:DoughnutSeries StartAngle="180" EndAngle="360"
                          ItemsSource="{Binding Data}"
                          XBindingPath="Product" 
                          YBindingPath="SalesRate"/>
</chart:SfCircularChart>
    
{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
DoughnutSeries series = new DoughnutSeries();
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
series.StartAngle = 180;
series.EndAngle = 360;

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Semi doughnut chart in MAUI Chart](Chart-Types_images/maui_semi_doughnut_chart.png)

## Center View

The view placed in the center of the doughnut chart is useful for sharing additional information about the doughnut chart. Any view can be added to the center of the doughnut chart using the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) property of [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html). The binding context of the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) will be the respective doughnut series.

### Center Hole Size

The [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize) property of [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) is used to get the diameter value of the center hole. Using the [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize), we can protect the view in the doughnut center from overlapping with the series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>    
    <chart:DoughnutSeries ItemsSource="{Binding Data}" XBindingPath="Name" YBindingPath="Value"/>
        <chart:DoughnutSeries.CenterView>
            <Border HeightRequest="{Binding CenterHoleSize}" WidthRequest="{Binding CenterHoleSize}">
                <Border.StrokeShape>
                    <RoundRectangle CornerRadius="200"/>
                </Border.StrokeShape>
                <StackLayout>
                    <Label Text="Total :"/>
                    <Label Text="357,580 km²"/>
                </StackLayout>
            </Border>
        </chart:DoughnutSeries.CenterView>
    </chart:DoughnutSeries>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();       
DoughnutSeries series = new DoughnutSeries()
series.XBindingPath = "Name";
series.YBindingPath = "Value";

Border border = new Border();  
Label name = new Label();
name.Text = "Total :";
Label value = new Label()
value.Text = "357,580 km²";
StackLayout layout = new StackLayout();

border.Content = layout;
series.CenterView = border;
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Center View in MAUI doughnut Chart](Chart-Types_images/maui_center_View.png)
