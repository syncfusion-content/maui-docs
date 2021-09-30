---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip and its customization in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Tooltip in .NET MAUI Chart (SfCartesianChart)

`SfCartesianChart` provides tooltip support for all series. It is used to show information about the segment, when you tap on the segment. 

## Define Tooltip

To define the tooltip in the series, set the `ShowTooltip` property to true. The default value of `ShowTooltip` property is `false`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                ShowTooltip="True"/>

            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2011"
                                ShowTooltip="True"/>
        </chart:SfCartesianChart.Series>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ColumnSeries series1 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        ShowTooltip = true
    };

    ColumnSeries series2 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2011",
        ShowTooltip = true
    };

    chart.Series.Add(series1);
    chart.Series.Add(series2);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

The `ChartTooltipBehavior` is used to customize the tooltip. For customizing the tooltip, create an instance `ChartTooltipBehavior` and add it to the `ChartBehaviors` collection of `SfCartesianChart`. The following properties are used to customize the tooltip:

* `Background` - Used to customize the fill and stroke of the tooltip.
* `Duration` - Used to set the amount of time that the tooltip remains visible in milliseconds.
* `TextColor` - Used to set the color for the text of the label.
* `Margin` - Used to set the margin of the label to customize the appearance of label.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart.ChartBehaviors>
        <chart:ChartTooltipBehavior/>
    </chart:SfCartesianChart.ChartBehaviors>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ChartTooltipBehavior behavior = new ChartTooltipBehavior();
    chart.ChartBehaviors.Add(behavior);

{% endhighlight %}

{% endtabs %}

## Duration

The `Duration` property is used to specify the duration time in milliseconds for which tooltip will be displayed.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartTooltipBehavior Duration="5000"/>
        </chart:SfCartesianChart.ChartBehaviors>

        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                ShowTooltip="True"/>
                    
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2011"
                                ShowTooltip="True"/>
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ChartTooltipBehavior tooltipBehavior = new ChartTooltipBehavior();
    tooltipBehavior.Duration = 5000;
    chart.ChartBehaviors.Add(tooltipBehavior);

    ColumnSeries series1 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        ShowTooltip = true
    };

    ColumnSeries series2 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2011",
        ShowTooltip = true
    };

    chart.Series.Add(series1);
    chart.Series.Add(series2);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Template

The `SfCartesianChart` provides support to customize the appearance of the tooltip by using the `TooltipTemplate` property.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart >
        <chart:SfCartesianChart.Resources>
            <DataTemplate x:Key="tooltipTemplate1">
                <StackLayout Orientation="Horizontal">
                    <Label Text="{Binding Item.Category}" TextColor="Black" FontAttributes="Bold" FontSize="12" HorizontalOptions="Center" VerticalOptions="Center"/>
                    <Label Text=" : " TextColor="Black" FontAttributes="Bold" FontSize="12" HorizontalOptions="Center" VerticalOptions="Center"/>
                    <Label Text="{Binding Item.Value}" TextColor="Black" FontAttributes="Bold" FontSize="12" HorizontalOptions="Center" VerticalOptions="Center"/>
                </StackLayout>
            </DataTemplate>
            . . .
                
        </chart:SfCartesianChart.Resources>
    . . .
        <chart:SfCartesianChart.Behaviors>
            <chart:ChartTooltipBehavior/>
        </chart:SfCartesianChart.Behaviors>

        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" TooltipTemplate="{StaticResource tooltipTemplate1}"
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                ShowTooltip="True"/>
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ColumnSeries series1 = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        ShowTooltip = true,
        TooltipTemplate = chart.Resources["tooltipTemplate1"] as DataTemplate
    };

    chart.Series.Add(series1);
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}