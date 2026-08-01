---
layout: post
title: Right-to-Left in .NET MAUI Switch | Syncfusion®
description: Learn how to enable right-to-left (RTL) layout in the Syncfusion® .NET MAUI Switch (SfSwitch) control.
platform: MAUI
control: SfSwitch
documentation: UG
keywords : .net maui switch, maui switch, .net maui switch rtl, maui switch flow direction.
---

# Right-to-Left in .NET MAUI Switch (SfSwitch)

The [.NET MAUI Switch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) control supports a right-to-left (RTL) layout direction. Use the `FlowDirection` property to control the layout direction of the Switch. The following example sets `FlowDirection` directly on the Switch:

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch x:Name="sfSwitch" 
                     FlowDirection="RightToLeft" />

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.FlowDirection = FlowDirection.RightToLeft;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The following image shows the Switch in RTL mode.

![RTL flow direction](Images/RTL/RTL_Switch.png)

## See Also

- [Customization in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/customization)
- [States in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/states)
- [Visual state manager in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/visual-state-manager)