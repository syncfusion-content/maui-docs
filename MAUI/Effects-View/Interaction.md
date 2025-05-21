---
layout: post
title: Interaction in .NET MAUI Effects View Control | Syncfusion®
description: Learn here all about interaction support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Interaction in .NET MAUI Effects View (SfEffectsView)

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) control supports various interactions through its properties. This section explains how to set effects on different interactions available in the Effects View.

## TouchDownEffects

The [TouchDownEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownEffects) property is used to render effects during a touch-down interaction.

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView TouchDownEffects="Ripple">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Ripple
};

{% endhighlight %}

{% endtabs %}

## LongPressEffects

The [LongPressEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressEffects) property is used to render effects during a long-press interaction.

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView LongPressEffects="Ripple">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    LongPressEffects = SfEffects.Ripple
};

{% endhighlight %}

{% endtabs %}

## TouchUpEffects

The [TouchUpEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpEffects) property is used to render effects during a touch-up interaction.

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView TouchUpEffects="Ripple">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    TouchUpEffects = SfEffects.Ripple
};

{% endhighlight %}

{% endtabs %}
