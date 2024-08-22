---
layout: post
title: Drilldown in .NET MAUI TreeMap Control | Syncfusion
description: Learn here all about drilldown support in Syncfusion .NET MAUI TreeMap control and more.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Right To Left in .NET MAUI TreeMap (SfTreeMap)

SfTreeMap supports changing the flow to the right-to-left direction by setting the FlowDirection to RightToLeft. TreeMap supports RTL when the flow direction of the device is changed.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<treemap:SfTreeMap FlowDirection="RightToLeft"/>

{% endhighlight %}
{% highlight C# hl_lines="5" %}

SfTreeMap treeMap = new SfTreeMap();
treeMap.FlowDirection = RightToLeft;

{% endhighlight %}
{% endtabs %}
