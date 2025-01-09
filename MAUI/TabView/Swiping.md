---
layout: post
title: About .NET MAUI Tab View (SfTabView) control | Syncfusion®
description: Learn here all about the swiping support in Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# Swiping in .NET MAUI Tab View (SfTabView)

The `EnableSwiping` property of `SfTabView` allows users to switch between tab contents by swiping. By default, the `EnableSwiping` property is set to `false.`

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView EnableSwiping="True">
{% endhighlight %}

{% highlight C# %}
     tabView.EnableSwiping = true;
{% endhighlight %}

{% endtabs %}

![TabView EnableSwiping](images/tabview-swiping.gif)

### Limitations

* Interference Between Child Controls and TabView Swiping: When a child control within a TabView supports horizontal swiping or interaction (e.g., a horizontal ScrollView, a custom swipe-enabled control, or a carousel), it can interfere with the TabView's touch gesture. This may result in unintended behavior, such as the TabView swiping when the child control is meant to handle the gesture, or vice versa. The overlapping gestures can cause confusion and disrupt the expected user experience, leading to a less intuitive interface.

