---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip and its customization in Syncfusion .NET MAUI Chart (SfCircularChart) control
platform: maui
control: SfCircularChart
documentation: ug
---

# Tooltip in .NET MAUI Chart (SfCircularChart)

SfCartesianChart provides tooltip support for all series. It is used to show information about the segment, when you tap on the segment. 

## Define Tooltip

To define the tooltip in the chart, set the `ShowTooltip` property of series to true. The default value of `ShowTooltip` property is false.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    . . .
        <chart:PieSeries ShowTooltip="True">
        </chart:PieSeries>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    PieSeries series = new PieSeries();
    series.ShowTooltip = true;
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

The `ChartTooltipBehavior` is used to customize the tooltip. For customizing the tooltip, create an instance `ChartTooltipBehavior` and add it to the `ChartBehaviors` collection of `SfCircularChart`. The following properties are used to customize the tooltip:

{% tabs %}

{% highlight xml %}

    <chart:SfCircularChart>
    . . .
    <chart:SfCircularChart.ChartBehaviors>
        <chart:ChartTooltipBehavior/>
    </chart:SfCircularChart.ChartBehaviors>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    ChartTooltipBehavior tooltip = new ChartTooltipBehavior();
    chart.ChartBehaviors.Add(tooltip);

{% endhighlight %}

{% endtabs %}

## Template

Circular chart provides support to customize the appearance of the tooltip by using the `TooltipTemplate` property.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    . . .
        <chart:SfCircularChart.Resources>
            <DataTemplate x:Key="tooltipTemplate">
                <StackLayout Orientation="Horizontal">
                    <Label Text="{Binding Item.Product}" TextColor="Black" FontAttributes="Bold" FontSize="12" HorizontalOptions="Center" VerticalOptions="Center"/>
                    <Label Text=" : " TextColor="Black" FontAttributes="Bold" FontSize="12" HorizontalOptions="Center" VerticalOptions="Center"/>
                    <Label Text="{Binding Item.SalesRate}" TextColor="Black" FontAttributes="Bold" FontSize="12" HorizontalOptions="Center" VerticalOptions="Center"/>
                </StackLayout>
            </DataTemplate>
        </chart:SfCircularChart.Resources>

        <chart:SfCircularChart.Series>
            <chart:PieSeries ShowTooltip="True"
                    ItemsSource="{Binding Data}" 
                    XBindingPath="Product" 
                    YBindingPath="SalesRate"
                    TooltipTemplate="{StaticResource tooltipTemplate}"/>
        </chart:SfCircularChart.Series>
        . . .
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    PieSeries series = new PieSeries();
    series.ShowTooltip = true;
    series.TooltipTemplate = chart.Resources["tooltipTemplate"] as DataTemplate;
    . . .     
{% endhighlight %}

{% endtabs %}

