---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip and its customization in Syncfusion .NET MAUI Chart (SfCircularChart) control
platform: maui
control: SfCircularChart
documentation: ug
---

# Tooltip in .NET MAUI Chart (SfCircularChart)

Tooltip is used to display any information or metadata of the tapped segment. The SfCartesianChart provides tooltip support for all series. 

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

The `ChartTooltipBehavior` is used to customize the tooltip. For customizing the tooltip, create an instance `ChartTooltipBehavior` and add it to the `ChartBehaviors` collection of `SfCartesianChart`. The following properties are used to customize the tooltip:

* `Background` - Gets or sets the background color to the tooltip label.
* `FontAttributes` - Gets or sets the font style for the label.
* `FontFamily` - Gets or sets the font family name for the label.
* `FontSize` - Gets or sets the font size for the label.
* `Duration` - Gets or sets the duration of the tooltip text in seconds.
* `Margin` - Gets or sets the margin of the label to customize the appearance of label.
* `TextColor` - Used to set the color for the text of the label.

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

