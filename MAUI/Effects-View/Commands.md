---
layout: post
title: Commands in .NET MAUI Effects View Control | Syncfusion®
description: Learn about Commands support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Commands and CommandParameter in .NET MAUI Effects View (SfEffectsView)

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) control provides the following additional Commands and CommandParameter :

## LongPressedCommand

The [LongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommand) property enables executing a command when the user performs a long‑press gesture on the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html).

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
    LongPressedCommand="{Binding LongPressedCommand}">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

var effectsView = new SfEffectsView
{
LongPressedCommand = ViewModel.LongPressedCommand
};

{% endhighlight %}
{% endtabs %}

## LongPressedCommandParameter

The [LongPressedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommandParameter) property allows you to pass a parameter to the LongPressedCommand when the long‑press gesture occurs.

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
        LongPressedCommand="{Binding LongPressedCommand}"
        LongPressedCommandParameter="{x:Reference sfEffectsView}">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

var effectsView = new SfEffectsView
{
    LongPressedCommand = ViewModel.LongPressedCommand,
    LongPressedCommandParameter = effectsView
};

{% endhighlight %}
{% endtabs %}

## TouchDownCommand

The [TouchDownCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommand) property executes a command when the user touches and presses down within the bounds of the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html).

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
TouchDownCommand="{Binding TouchDownCommand}">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

var effectsView = new SfEffectsView
{
TouchDownCommand = ViewModel.TouchDownCommand
};

{% endhighlight %}

{% endtabs %}

## TouchDownCommandParameter

The [TouchDownCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommandParameter) property allows you to pass a parameter to the TouchDownCommand when the touch‑down interaction occurs.

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
    TouchDownCommand="{Binding TouchDownCommand}"
    TouchDownCommandParameter="{x:Reference sfEffectsView}">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

var effectsView = new SfEffectsView
{
    TouchDownCommand = ViewModel.TouchDownCommand,
    TouchDownCommandParameter = effectsView
};

{% endhighlight %}

{% endtabs %}

## TouchUpCommand

The [TouchUpCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommand) property executes a command when the user releases the touch within the bounds of the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html).

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
    TouchUpCommand="{Binding TouchUpCommand}">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

var effectsView = new SfEffectsView
{
TouchUpCommand = ViewModel.TouchUpCommand
};

{% endhighlight %}

{% endtabs %}

## TouchUpCommandParameter

Enabling the [TouchUpCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommandParameter) property allows you to pass a parameter to the TouchUpCommand when the touch‑up interaction occurs.

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
        TouchUpCommand="{Binding TouchUpCommand}"
        TouchUpCommandParameter="{x:Reference sfEffectsView}">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

var effectsView = new SfEffectsView
{
TouchUpCommand = ViewModel.TouchUpCommand,
TouchUpCommandParameter = effectsView
};

{% endhighlight %}

{% endtabs %}