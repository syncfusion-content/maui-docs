---
layout: post
title: Right To Left in .NET MAUI Switch Control | Syncfusion
description: Learn about the comprehensive support for right-to-left (RTL) directionality within the Syncfusion .NET MAUI Button, also known as the SfButton control.
platform: maui
control: SfSwitch
documentation: ug
---

# Right To Left in .NET MAUI Switch (SfSwitch)

SfSwitch supports changing the layout direction of the control in the right-to-left direction by setting the FlowDirection to RightToLeft or by changing the device language.

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