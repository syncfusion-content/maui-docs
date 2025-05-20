---
layout: post
title: Right To Left in .NET MAUI Switch Control | Syncfusion®
description: Learn all about Right To Left support in the Syncfusion®.NET MAUI Switch (SfSwitch) control, and more.
platform: MAUI
control: SfSwitch
documentation: UG
keywords : .NET MAUI Switch, MAUI Switch, .NET MAUI Switch RTL, MAUI Switch Flow Direction.
---

# Right To Left in .NET MAUI Switch (SfSwitch)

The .NET MAUI Switch supports changing the layout direction to a right-to-left (RTL) orientation. This can be achieved by setting the `FlowDirection` property to `RightToLeft`, or by changing the device's language to one that uses an RTL script.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch FlowDirection="RightToLeft" />
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.FlowDirection = FlowDirection.RightToLeft;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![SfSwitch with RTL flow direction](images/RTL/RTL_Switch.png)