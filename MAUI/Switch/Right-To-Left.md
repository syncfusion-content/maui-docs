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

## Prerequisites

Before using the [`SfSwitch`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/switch/getting-started) documentation.

The .NET MAUI Switch (SfSwitch) control supports a right-to-left (RTL) layout direction. Use the `FlowDirection` property to control the layout direction of the Switch.

The `FlowDirection` property accepts the following values:

* `LeftToRight` — The default value; renders the Switch in the conventional left-to-right direction.
* `RightToLeft` — Renders the Switch with the thumb on the left and the track progressing right-to-left.
* `MatchParent` — Inherits the `FlowDirection` from the parent layout or page.

## Setting FlowDirection on a Control

The following example sets `FlowDirection` directly on the Switch:

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch x:Name="sfSwitch" FlowDirection="RightToLeft" />

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.FlowDirection = FlowDirection.RightToLeft;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

## Platform notes

* **Android** — Ensure that `android:supportsRtl="true"` is set in the `AndroidManifest.xml` (the default MAUI template already includes this attribute).
* **iOS and macOS** — No additional configuration is required beyond setting the `FlowDirection` property.
* **Windows** — The `FlowDirection` property is honored, but some Windows UI elements may not fully reflect RTL layout.

## Behavior

* The `FlowDirection` property only affects the layout direction of the Switch. The visual appearance, colors, and `SwitchSettings` (such as `ThumbWidthRequest` or `CustomPath`) remain unchanged.
* Setting `FlowDirection` to `RightToLeft` on a Switch inside a `HorizontalStackLayout` will also reverse the layout flow of the parent layout's children.

The following image shows the Switch in RTL mode.

![RTL flow direction](Images/RTL/RTL_Switch.png)