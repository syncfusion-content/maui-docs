---
layout: post
title: States in .NET MAUI Switch Control | Syncfusion®
description: Learn about the available states in the Syncfusion® .NET MAUI Switch (SfSwitch) control.
platform: MAUI
control: SfSwitch
documentation: UG
keywords : .net maui switch, maui switch, .net maui switch states, maui switch state.
---

# States in .NET MAUI Switch (SfSwitch)

The .NET MAUI Switch (SfSwitch) supports the following states: `On`, `Off`, `Indeterminate`, `Disabled On`, `Disabled Off`, and `Disabled Indeterminate`.

N> Before proceeding, ensure that the Syncfusion<sup>®</sup> MAUI Buttons package is installed and the required namespace is registered. For more information, refer to the [Getting Started](Getting-Started.md) documentation.

The state of the Switch is controlled by the following properties:

* [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn): A `bool?` property that sets the current state. The default value is `false` (`Off`).
* [`AllowIndeterminateState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState): A `bool` property that allows the Switch to display the `Indeterminate` state when `IsOn` is `null`. The default value is `false`.
* [`IsEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled): A `bool` property that controls whether the Switch is interactive. The default value is `true`.

N> The [`StateChanged`](Events.md) and [`StateChanging`](Events.md) events are raised when the `IsOn` property changes.

## On state

Set the [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to `true` or tap the Switch to put it in the `On` state.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfSwitch x:Name="sfSwitch" IsOn="true" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Buttons;

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = true;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The Switch rendered in the `On` state.

![On state.](Images/States/net-maui-switch-state-on.png)

## Off state

Set the [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to `false` or tap the Switch to put it in the `Off` state. This is the default state.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfSwitch x:Name="sfSwitch" IsOn="false" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Buttons;

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The Switch rendered in the `Off` state.

![Off state.](Images/States/net-maui-switch-state-off.png)

## Indeterminate state

Use the `Indeterminate` state to display in-progress work, such as a partially completed task. Enable it by setting [`AllowIndeterminateState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState) to `true` and [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) to `null`.

N> The `Indeterminate` state requires the `AllowIndeterminateState` property to be set to `true` before the Switch is added to the visual tree, otherwise the Switch will fall back to the `Off` state.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">
    <syncfusion:SfSwitch x:Name="sfSwitch" IsOn="{x:Null}" AllowIndeterminateState="True" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Buttons;

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.AllowIndeterminateState = true;
sfSwitch.IsOn = null;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The Switch rendered in the `Indeterminate` state.

![Indeterminate state.](Images/States/net-maui-switch-indeterminate.png)

## Disabled On state

Set the [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to `true` and the [`IsEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled) property to `false` to put the Switch in the disabled `On` state.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfSwitch x:Name="sfSwitch" IsOn="true" IsEnabled="false" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Buttons;

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = true;
sfSwitch.IsEnabled = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The Switch rendered in the disabled `On` state.

![Disabled On state.](Images/States/net-maui-switch-disabled-on.png)

## Disabled Off state

Set the [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to `false` and the [`IsEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled) property to `false` to put the Switch in the disabled `Off` state.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfSwitch x:Name="sfSwitch" IsOn="false" IsEnabled="false" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Buttons;

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = false;
sfSwitch.IsEnabled = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The Switch rendered in the disabled `Off` state.

![Disabled Off state.](Images/States/net-maui-switch-disabled-off.png)

## Disabled Indeterminate state

Set [`AllowIndeterminateState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState) to `true`, [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) to `null`, and [`IsEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled) to `false` to put the Switch in the disabled `Indeterminate` state.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">
    <syncfusion:SfSwitch x:Name="sfSwitch" AllowIndeterminateState="True" IsOn="{x:Null}" IsEnabled="False" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Buttons;

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.AllowIndeterminateState = true;
sfSwitch.IsOn = null;
sfSwitch.IsEnabled = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The Switch rendered in the disabled `Indeterminate` state.

![Disabled Indeterminate state.](Images/States/net-maui-switch-disabled-indeterminate.png)
