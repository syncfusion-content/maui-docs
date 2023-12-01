---
layout: post
title: Animation in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains about how to enable animation in Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

## Animation in .NET MAUI Sunburst Chart

The sunburst chart provides animation on loading and whenever the item source changes. Animation can be enabled by setting the EnableAnimation property to true.

The following code shows enabling animation.

{% tabs %} 

{% highlight xaml %}

    . . .
    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              EnableAnimation="True"
                              ValueMemberPath="EmployeesCount">
    . . .
    </sunburst:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    . . .
    SfSunburstChart sunburst = new SfSunburstChart();
    sunburst.ItemsSource = viewModel.DataSource;
    sunburst.EnableAnimation = true;
    sunburst.ValueMemberPath = "EmployeesCount";
    . . .
    this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

## Duration

Animation duration can be controlled using the [AnimationDuration]() property.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              EnableAnimation="True"
                              AnimationDuration="2"
                              ValueMemberPath="EmployeesCount">
    . . .
    </sunburst:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    . . .
    SfSunburstChart sunburst = new SfSunburstChart();
    sunburst.ItemsSource = viewModel.DataSource;
    sunburst.EnableAnimation = true;
    sunburst.AnimationDuration = 2;
    sunburst.ValueMemberPath = "EmployeesCount";
    . . .
    this.Content = sunburst;
          
{% endhighlight %}

{% endtabs %}

![Animation support in .NET MAUI Sunburst Chart]()