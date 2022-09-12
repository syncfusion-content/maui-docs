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
                        YBindingPath="SalesRate" />
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DoughnutSeries series = new DoughnutSeries();
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Doughnut chart type in MAUI Chart](Chart-Types_images/maui_doughnut_chart.png)

## Inner Radius

The [InnerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_InnerRadius) property of doughnut series is used to define the inner circle.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:DoughnutSeries ItemsSource="{Binding Data}" InnerRadius="0.7" XBindingPath="Product" YBindingPath="SalesRate" />
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
DoughnutSeries series = new DoughnutSeries();
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
series.InnerRadius = 0.7;

chart.Series.Add(series);

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
                    YBindingPath="SalesRate" />
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

{% endhighlight %}

{% endtabs %}

![Semi doughnut chart in MAUI Chart](Chart-Types_images/maui_semi_doughnut_chart.png)

## Center View

Any view can be added to the center of doughnut chart using the [CenterView] property of DoughnutSeries. The binding context of the [CenterView] will be the respective DoughnutSeries.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.BindingContext>
        <local:DoughnutSeriesViewModel/>
    </chart:SfCircularChart.BindingContext>    
    <chart:SfCircularChart.Series>
        <chart:DoughnutSeries ItemsSource="{Binding DoughnutSeriesData}" XBindingPath="Name" YBindingPath="Value"/>
            <chart:DoughnutSeries.CenterView>
                <StackLayout x:Name="layout" HeightRequest="{Binding CenterHoleSize}" WidthRequest="{Binding CenterHoleSize}">
                    <Label Text = "{Binding Name,Source={x:Reference doughnutViewModel}}"/>
                    <Label Text = "{Binding Value,Source={x:Reference doughnutViewModel},StringFormat='{0} %'}"/>
                </StackLayout>
            </chart:DoughnutSeries.CenterView>
    </chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DoughnutSeriesViewModel viewModel = new DoughnutSeriesViewModel();
chart.BindingContext = viewModel;
        
DoughnutSeries series = new DoughnutSeries()
{
    ItemsSource = viewmodel.DoughnutSeriesData,
    XBindingPath = "Name",
    YBindingPath = "Value",
};
  
Label name = new Label();
Label value = new Label(); 
StackLayout layout = new StackLayout();
layout.Children.Add(name);
layout.Children.Add(value);
          
name.SetBinding(Label.TextProperty, nameof(doughnutViewModel.Name));
value.SetBinding(Label.TextProperty, new Binding(nameof(doughnutViewModel.Value),default,null,null,"0%"));
layout.SetBinding(StackLayout.HeightRequestProperty, nameof(DoughnutSeries.CenterHoleSize));
layout.SetBinding(StackLayout.WidthRequestProperty, nameof(DoughnutSeries.CenterHoleSize));
          
series.CenterView = layout;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Center View in MAUI doughnut Chart](Chart-Types_images/maui_center_View.png)

## Center Hole Size

The [CenterHoleSize] property of [DoughnutSeries] is used to get only the inner diameter. Using this [CenterHoleSize] value, you can provide [CentreView] for series to avoid the view from being cropped outside the series.