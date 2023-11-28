---
layout: post
title: Animation in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable animation in Syncfusion .NET MAUI Chart (SfSunburstChart) control
platform: maui
control: SfSunburstChart
documentation: ug
---

## Animation in .NET MAUI Chart

The sunburst chart provides animation on loading and whenever the item source changes. Animation can be enabled by setting the EnableAnimation property to true.

The following code shows enabling animation.

{% tabs %} 

{% highlight xaml %}

    <chart:SfSunburstChart  ItemsSource="{Binding DataSource}" 
                            EnableAnimation="True"
                            ValueMemberPath="EmployeesCount">
    . . .
    </chart:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    . . .
    SfSunburstChart chart = new SfSunburstChart();
    chart.ItemsSource = viewModel.DataSource;
    chart.EnableAnimation = true;
    chart.ValueMemberPath = "EmployeesCount";
    . . .
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Duration

Animation duration can be controlled using the [AnimationDuration]() property.

{% tabs %} 

{% highlight xaml %}

    <chart:SfSunburstChart  ItemsSource="{Binding DataSource}" 
                            EnableAnimation="True"
                            AnimationDuration="2"
                            ValueMemberPath="EmployeesCount">
    . . .
    </chart:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    . . .
    SfSunburstChart chart = new SfSunburstChart();
    chart.ItemsSource = viewModel.DataSource;
    chart.EnableAnimation = true;
    chart.AnimationDuration = 2;
    chart.ValueMemberPath = "EmployeesCount";
    . . .
    this.Content = chart;
          
{% endhighlight %}

{% endtabs %}

![Animation support in MAUI chart]()