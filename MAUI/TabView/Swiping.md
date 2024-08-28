---
layout: post
title: About .NET MAUI Tab View (SfTabView) control | Syncfusion
description: Learn here all about the swiping support in Syncfusion .NET MAUI Tab View (SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# Swiping in .NET MAUI Tab View (SfTabView)

The `EnableSwiping` property of `SfTabView` allows users to switch between tab contents by swiping. By default, the `EnableSwiping` property is set to `true.`

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView EnableSwiping="True">
{% endhighlight %}

{% highlight C# %}
     tabView.EnableSwiping = true;
{% endhighlight %}

{% endtabs %}

![TabView EnableSwiping](images/tabview-swiping.gif)