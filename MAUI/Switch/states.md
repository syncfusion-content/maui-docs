---
layout: post
title: States in .NET MAUI Switch Control | Syncfusion®
description: Learn all about the state support in the Syncfusion® .NET MAUI Switch (SfSwitch) control, its elements, and more.
platform: MAUI
control: SfSwitch
documentation: UG
keywords : .net maui switch, maui switch, .net maui switch states, maui switch state.
---

# States in .NET MAUI Switch (SfSwitch)

The .NET MAUI Switch allows you to configure various states as explained in the following sections.

## On state

You can switch to the "On" state by tapping the .NET MAUI Switch button or by setting a value, as demonstrated in the following code example.

{% tabs %}

{% highlight xaml %}

    <syncfusion:SfSwitch IsOn="True" />

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch=new SfSwitch();
sfSwitch.IsOn=true;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![On state.](images/States/net-maui-switch-state-on.png)

## Off state

This is the default state. You can switch to the "Off" state by tapping the .NET MAUI Switch button or by defining it, as demonstrated in the following code example.

{% tabs %}

{% highlight xaml %}

    <syncfusion:SfSwitch IsOn="False" />

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![Off state.](images/States/net-maui-switch-state-off.png)

## Indeterminate state

The indeterminate state can be enabled by using the [AllowIndeterminateState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState) property when you need to display the work progress. The following code example demonstrates how to load the .NET MAUI Switch in an Indeterminate state by setting the [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to null.

{% tabs %}

{% highlight xaml %}

    <syncfusion:SfSwitch IsOn="{x:Null}" AllowIndeterminateState="True" />    

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = null;
this.Content = sfSwitch;

sfSwitch.AllowIndeterminateState = true;

{% endhighlight %}

{% endtabs %}

![Indeterminate state.](images/States/net-maui-switch-indeterminate.png)

N> By default, the switch control has only two states: on and off.

## Disabled On state

You can switch to the disabled "On" state by setting the [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to true and the [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled) property to false.

{% tabs %}

{% highlight xaml %}

    <syncfusion:SfSwitch IsOn="True" IsEnabled="False" />

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = true;
sfSwitch.IsEnabled = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![Disabled On state.](images/States/net-maui-switch-disabled-on.png)

## Disabled Off state

You can switch to the disabled "Off" state by setting the [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property to false and the [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled) property to false.

{% tabs %}

{% highlight xaml %}

    <syncfusion:SfSwitch IsOn="False" IsEnabled="False" />

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.IsOn = false;
sfSwitch.IsEnabled = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![Disabled off state.](images/States/net-maui-switch-disabled-off.png)

## Disabled indeterminate state

The disabled indeterminate state can be enabled when you need to display the work progress. The below code example demonstrates loading the switch in a disabled indeterminate state by setting the [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property value to null and the [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled) property to false.

{% tabs %}

{% highlight xaml %}

    <syncfusion:SfSwitch AllowIndeterminateState="True" IsOn="{x:Null}" IsEnabled="False"/>      

{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.AllowIndeterminateState = true;
sfSwitch.IsOn = null;          
sfSwitch.IsEnabled = false;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![Disabled indeterminate state.](images/States/net-maui-switch-disabled-indeterminate.png)
