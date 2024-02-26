---
layout: post
title: Data label in .NET MAUI Chart control | .NET MAUI | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Data Label in .NET MAUI Chart

Data labels are used to display values related to a chart segment. Values from data point(x, y) or other custom properties from a data source can be displayed. 

Each data label can be represented by the following:

* Label - displays the segment label content at the (X, Y) point.
* Connector line - used to connect the (X, Y) point and the label element.

## Enable Data Label 

[ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property of series is used to enable the data labels.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
. . .
<chart:PieSeries ShowDataLabels="True"
                ItemsSource="{Binding Data}"  
                XBindingPath="Product" 
                YBindingPath="SalesRate"/>
. . .
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.ShowDataLabels = true;
. . .
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %} 

Data labels can be customized by using the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_DataLabelSettings) property of chart series. For customizing, need to create an instance of [CircularDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html) and set to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_DataLabelSettings) property. Following properties are used to customize the data labels which are available in [CircularDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html).

* [ConnectorType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html#Syncfusion_Maui_Charts_CircularDataLabelSettings_ConnectorType) - Gets or sets the type of connector line to be drawn.
* [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelStyle) - Gets or sets the options for customizing the data labels. 
* [UseSeriesPalette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_UseSeriesPalette) - Gets or sets a value indicating whether the data label should reflect the series interior.

![Data label in MAUI chart](DataLabel_images/maui_chart_datalabels.png) 

## Applying Series Brush

[UseSeriesPalette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_UseSeriesPalette) property is used to set the interior of the series to the data label background. 

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
. . .
<chart:PieSeries ShowDataLabels="True">
    <chart:PieSeries.DataLabelSettings>
        <chart:CircularDataLabelSettings UseSeriesPalette="True"/>
    </chart:PieSeries.DataLabelSettings>
</chart:PieSeries>

</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.ShowDataLabels = true;
series.DataLabelSettings = new CircularDataLabelSettings()
{
    UseSeriesPalette = true,
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Applying series interior for data label in MAUI chart](DataLabel_images/maui_chart_datalabels_useseriespalette.png)

## Formatting label context

You can customize the content of the label using [LabelContext]() property. Following are the two options that are supported now,

* [Percentage]() - This will show the percentage value of corresponding data point Y value

* [YValue]() - This will show the corresponding Y value.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    
    <chart:PieSeries ItemsSource="{Binding Data1}" 
                     LabelContext="Percentage"
                     ShowDataLabels="True"
                     XBindingPath="Product" 
                    YBindingPath="SalesRate"/>  
    
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    ChartViewModel viewModel = new ChartViewModel();
    chart.BindingContext = viewModel;
    PieSeries series = new PieSeries();
    series.ItemsSource = viewModel.Data;
    ShowDataLabels = true;
    LabelContext = LabelContext.Percentage;
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";
    chart.Series.Add(series);
        
{% endhighlight %}

{% endtabs %}

![DataLabel context in MAUI Chart](DataLabel_images/maui_chart_datalabel_context.png)

## Template

The [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html?tabs=tabid-1) provides support to customize the appearance of the datalabel by using the [LabelTemplate]() property.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

    <chart:SfCircularChart.Resources>
        <DataTemplate x:Key="LabelTemplate1">
            <HorizontalStackLayout Spacing="5">
                <Label Text="{Binding Item.Product}"
                TextColor="White" 
                FontAttributes="Bold"
                FontSize="13"      
				HorizontalOptions="Center"
				VerticalOptions="Center"/>
                <Label Text=" : " 
				TextColor="White"
				FontAttributes="Bold"
				FontSize="13"
				HorizontalOptions="Center"
				VerticalOptions="Center"/>
                <Label Text="{Binding Item.SalesRate}"
				TextColor="White"
				FontAttributes="Bold"
				FontSize="13"
				HorizontalOptions="Center"
				VerticalOptions="Center"/>
            </HorizontalStackLayout>
        </DataTemplate>
    </chart:SfCircularChart.Resources>

    <chart:PieSeries ItemsSource="{Binding Data}" 
                     ShowDataLabels="True"
                     LabelTemplate="{StaticResource LabelTemplate1}"
                     XBindingPath="Product" 
                     YBindingPath="SalesRate">
    </chart:PieSeries>

</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    PieSeries series = new PieSeries();
    series.ItemsSource = viewModel.Data;
    series.ShowDataLabels = true;
    series.LabelTemplate1 = chart.Resources["LabelTemplate1"] as DataTemplate
    . . .
        
{% endhighlight %}

{% endtabs %}

![Label template in MAUI Chart](DataLabel_images/maui_chart_datalabel_template.png)