---
layout: post
title: Right to left (RTL) support in .NET MAUI TreeMap Control | Syncfusion®
description: Learn here all about the flow direction feature of Syncfusion® .NET MAUI TreeMap (SfTreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Right To Left in .NET MAUI TreeMap (SfTreeMap)

SfTreeMap supports changing the flow to the right-to-left direction by setting the `FlowDirection` to RightToLeft.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **TreeMap** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/treemap/getting-started)** guide.

{% tabs %}
{% highlight xaml hl_lines="4" %}

<treemap:SfTreeMap FlowDirection="RightToLeft"/>

{% endhighlight %}
{% highlight c# hl_lines="5" %}

SfTreeMap treeMap = new SfTreeMap();
treeMap.FlowDirection = RightToLeft;

{% endhighlight %}
{% endtabs %}
