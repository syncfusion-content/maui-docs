---
layout: post
title: Right To Left in .NET MAUI Switch Control | Syncfusion®
description: Learn here all about Right To Left support in Syncfusion®.NET MAUI Switch (SfSwitch) control, and more.
platform: maui
control: SfSwitch
documentation: ug
keywords : .net maui switch, maui switch, .net maui switch rtl, maui switch flow direction.
---

# Right To Left in .NET MAUI Switch (SfSwitch)

The .NET MAUI Switch supports changing the layout direction of the control in the right-to-left direction by setting the `FlowDirection` to RightToLeft or by changing the device language.

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

![SfSwitch with RTL flowdirection](images/RTL/RTL_Switch.png)