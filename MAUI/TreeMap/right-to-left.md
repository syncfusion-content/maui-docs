---
layout: post
title: Right to left (RTL) support in .NET MAUI TreeMap Control | Syncfusion<sup>&reg;</sup>
description: Learn here all about the flow direction feature of Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap (SfTreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Right To Left in .NET MAUI TreeMap (SfTreeMap)

SfTreeMap supports changing the flow to the right-to-left direction by setting the `FlowDirection` to RightToLeft.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<treemap:SfTreeMap FlowDirection="RightToLeft"/>

{% endhighlight %}
{% highlight C# hl_lines="5" %}

SfTreeMap treeMap = new SfTreeMap();
treeMap.FlowDirection = RightToLeft;

{% endhighlight %}
{% endtabs %}
