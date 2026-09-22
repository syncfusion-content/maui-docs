---
layout: post
title: Right To Left in .NET MAUI TreeMap | Syncfusion®
description: Right To Left in .NET MAUI TreeMap supports RTL layouts for hierarchical data visualization, improving usability for right-to-left language users.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Right To Left in .NET MAUI TreeMap

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
