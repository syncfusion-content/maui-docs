---
layout: post
title: Data label in .NET MAUI Sunburst Chart control | .NET MAUI | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Sunburst Chart.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Data labels in .NET MAUI Sunburst Chart
Data labels are used to display information about segments at the (X, Y) point.

## Enable Data Label 
Data labels are enabled and disabled using the [ShowLabels]() property. The default value of the ShowLabel property is `False`.

The following code explains how to initialize data labels. 

{% tabs %}

{% highlight xaml %}

    <sunburst:SfSunburstChart ShowLabels="True"/>
    . . .
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.ShowLabels = true;

{% endhighlight %}

{% endtabs %} 

## Overflow Mode

When the data labels are large in text size, they will overlap each other. To avoid overlapping, trim or hide the data labels using the OverflowMode property. By default, the OverFlow mode is `Trim`.

The following code shows hide the data labels.

{% tabs %}

{% highlight xaml %}

    <sunburst:SfSunburstChart ShowLabels="True">
    . . .
        <sunburst:SfSunburstChart.DataLabelSettings>
            <sunburst:SunburstDataLabelSettings OverFlowMode="Hide"/>
        </sunburst:SfSunburstChart.DataLabelSettings>
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.ShowLabels = true;
    sunburst.DataLabelSettings = new SunburstDataLabelSettings()
    {
        OverFlowMode = SunburstLabelOverflowMode.Hide
    };

{% endhighlight %}

{% endtabs %} 

## Rotation Mode

The view of data labels can be customized using the [RotationMode]() property. Data labels can be rotated to a angle for better readability. By default, the rotation mode is `Angle`.

The following code shows normal mode of data labels.

{% tabs %}

{% highlight xaml %}

    <sunburst:SfSunburstChart ShowLabels="True">
    . . .
        <sunburst:SfSunburstChart.DataLabelSettings>
            <sunburst:SunburstDataLabelSettings RotationMode="Normal"/>
        </sunburst:SfSunburstChart.DataLabelSettings>
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.ShowLabels = true;
    sunburst.DataLabelSettings = new SunburstDataLabelSettings()
    {
        RotationMode = SunburstLabelRotationMode.Normal     
    };

{% endhighlight %}

{% endtabs %} 

## Customization

 Data labels can be customized by using the [DataLabelSettings]() property of the chart. For customizing, need to create an instance of [SunburstDataLabelSettings]() and set to the [DataLabelSettings]() property.The following properties, which are available in [SunburstDataLabelSettings](), are used to customise the data labels. 

* [FontAttributes]() of type `FontAttributes`, indicates the font style of * the label.
* [FontFamily]() of type `string`, indicates the font family for the label.
* [FontSize]() of type `float`, indicates the font size.
* [TextColor]() of type `Color`, indicates the color of the displayed text.

{% tabs %}

{% highlight xaml %}

    <sunburst:SfSunburstChart ShowDataLabels="True">
    . . .
        <sunburst:SfSunburstChart.DataLabelSettings>
            <sunburst:SunburstDataLabelSettings     
                TextColor="Red"   
                FontSize="10"    
                FontAttributes="Bold"/>
        </sunburst:SfSunburstChart.DataLabelSettings>
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.ShowLabels = true;
    sunburst.DataLabelSettings = new SunburstDataLabelSettings()
    {
        TextColor = Colors.Red,
        FontSize = 10,
        FontAttributes = FontAttributes.Bold
    };

{% endhighlight %}

{% endtabs %} 