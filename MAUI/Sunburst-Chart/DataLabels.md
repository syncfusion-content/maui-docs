---
layout: post
title: Data label in .NET MAUI Chart control | .NET MAUI | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Chart (SfSunburstChart).
platform: maui
control: SfSunburstChart
documentation: ug
---

# Data Label in .NET MAUI Chart

## Enable Data Label 

Data labels are used to display information about segments. Data labels are enabled and disabled using the [ShowLabels]() property. The default value of the ShowLabel property is false.

The following code explains how to initialize data labels. 

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart ShowLabels="True"/>
    . . .
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.ShowLabels = true;

{% endhighlight %}

{% endtabs %} 

## Overflow Mode

When the data labels are large in size, they will overlap each other. To avoid overlapping, trim or hide the data labels using the OverflowMode property.

## Trim

The following code shows trimming the data labels.

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart ShowLabels="True">
    . . .
        <chart:SfSunburstChart.DataLabelSettings>
            <chart:SunburstDataLabelSettings OverFlowMode="Trim"/>
        </chart:SfSunburstChart.DataLabelSettings>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.ShowLabels = true;
    Chart.DataLabelSettings = new SunburstDataLabelSettings()
    {
        OverFlowMode = SunburstLabelOverflowMode.Trim
    };

{% endhighlight %}

{% endtabs %} 

![Overflow Mode Trim]()

## Hide

The following code shows hiding the data labels.

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart ShowLabels="True">
    . . .
        <chart:SfSunburstChart.DataLabelSettings>
            <chart:SunburstDataLabelSettings OverFlowMode="Hide"/>
        </chart:SfSunburstChart.DataLabelSettings>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.ShowLabels = true;
    Chart.DataLabelSettings = new SunburstDataLabelSettings()
    {
        OverFlowMode = SunburstLabelOverflowMode.Hide
    };

{% endhighlight %}

{% endtabs %} 

![Overflow Mode Hide]()

## Rotation Mode

The view of data labels can be customized using the [RotationMode]() property. Data labels can be rotated to a angle for better readability. By default, the rotation mode is angle

## Angle

The following code shows rotating a data label to an angle.

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart ShowLabels="True">
    . . .
        <chart:SfSunburstChart.DataLabelSettings>
            <chart:SunburstDataLabelSettings RotationMode="Angle"/>
        </chart:SfSunburstChart.DataLabelSettings>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.ShowLabels = true;
    Chart.DataLabelSettings = new SunburstDataLabelSettings()
    {
        RotationMode = SunburstLabelRotationMode.Angle     
    };

{% endhighlight %}

{% endtabs %} 

![Rotation Mode Angle]()

## Normal

The following code shows normal mode of data labels.

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart ShowLabels="True">
    . . .
        <chart:SfSunburstChart.DataLabelSettings>
            <chart:SunburstDataLabelSettings RotationMode="Normal"/>
        </chart:SfSunburstChart.DataLabelSettings>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.ShowLabels = true;
    Chart.DataLabelSettings = new SunburstDataLabelSettings()
    {
        RotationMode = SunburstLabelRotationMode.Normal     
    };

{% endhighlight %}

{% endtabs %} 

![Rotation Mode Normal]()

## Data label customization

 Data labels can be customized by using the [DataLabelSettings]() property of the chart. For customizing, need to create an instance of [SunburstDataLabelSettings]() and set to the [DataLabelSettings]() property.The following properties, which are available in [SunburstDataLabelSettings](), are used to customise the data labels. 

* [FontAttributes]() of type `FontAttributes`, indicates the font style of * the label.
* [FontFamily]() of type `string`, indicates the font family for the label.
* [FontSize]() of type `float`, indicates the font size.
* [TextColor]() of type `Color`, indicates the color of the displayed text.

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart ShowDataLabels="True">
    . . .
        <chart:SfSunburstChart.DataLabelSettings>
            <chart:SunburstDataLabelSettings TextColor="Black"
                                            FontSize="10"
                                            FontAttributes="Bold"/>
        </chart:SfSunburstChart.DataLabelSettings>
        <chart:SfSunburstChart.TooltipSettings>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.ShowLabels = true;
    Chart.DataLabelSettings = new SunburstDataLabelSettings()
    {
        TextColor = Colors.Black,
        FontSize = 10,
        FontAttributes = FontAttributes.Bold
    };

{% endhighlight %}

{% endtabs %} 

![Data label customization]()