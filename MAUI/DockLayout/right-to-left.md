---
layout: post
title: Right-to-Left (RTL) Support in .NET MAUI DockLayout Control | Syncfusion®
description: Learn right-to-left (RTL) layout direction in the Syncfusion® .NET MAUI DockLayout (SfDockLayout) control.
platform: MAUI
control: SfDockLayout
documentation: ug
---

# Right To Left in .NET MAUI DockLayout

The .NET MAUI DockLayout control supports Right-to-Left (RTL) layout direction. When the `FlowDirection` property is set to `RightToLeft`, the docking positions are mirrored to align with RTL language standards.

You can enable RTL either by setting `FlowDirection` directly on the DockLayout, or by changing the device language to one that uses an RTL script.


{% tabs %}

{% highlight xaml %}

 <dx:SfDockLayout FlowDirection="RightToLeft">
    ...
 </dx:SfDockLayout>
 {% endhighlight %}

{% highlight c# %}
SfDockLayout dockLayout = new SfDockLayout()
{
    FlowDirection = FlowDirection.RightToLeft,
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI Docklayout with RTL support](DockLayout-Images/maui-docklayout-right-to-left.png)