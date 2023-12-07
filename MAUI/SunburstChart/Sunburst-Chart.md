---
layout: post
title: Sunburst Chart in .NET MAUI Sunburst Chart control | Syncfusion
description: Learn here all about Sunburst Chart appearance in Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Sunburst Chart Appearance

The following code example gives you to customize the appearance of the sunburst chart.

## Angle

The start angle and end angle of the sunburst chart can be adjusted by using the [StartAngle]() and [EndAngle]() properties.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              StartAngle="180" 
                              EndAngle="360"
                              ValueMemberPath="EmployeesCount">
    . . .
    </sunburst:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.StartAngle = 180;
    sunburst.EndAngle = 360;
    . . .

{% endhighlight %}

{% endtabs %}

## Radius

The sunburst chart allows you to customize the radius by using the [Radius]() property. The default value of this property is 0.9, and the value ranges from 0 to 1.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              Radius="0.7"
                              ValueMemberPath="EmployeesCount">
    . . .
    </chart:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.Radius = 0.7;
    . . .

{% endhighlight %}

{% endtabs %}

## Inner radius

The sunburst chart allows you to customize the inner radius using the [InnerRadius]() property. The default value of this property is `0.25`, and the value ranges from 0 to 1.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              InnerRadius="0.5"
                              ValueMemberPath="EmployeesCount">
    . . .
    </sunburst:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.InnerRadius = 0.5;
    . . .

{% endhighlight %}

{% endtabs %}

## Stroke

Stroke color and stroke width of the sunburst chart can be customized using [Stroke]() and [StrokeWidth]() properties respectively.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              Stroke="Black" 
                              StrokeWidth="2"
                              ValueMemberPath="EmployeesCount">
    . . .
    </chart:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.Stroke = Colors.Black;
    sunburst.StrokeWidth = 2;
    . . .

{% endhighlight %}

{% endtabs %}
