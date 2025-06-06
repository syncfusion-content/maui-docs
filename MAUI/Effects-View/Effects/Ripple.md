---
layout: post
title: The .NET MAUI Ripple Effects | Effects View Control | Syncfusion®
description: Learn all about ripple effect support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Ripple Effect in .NET MAUI Effects View (SfEffectsView)

The [SfEffects.Ripple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Ripple) is an expandable circle that is initially placed at the tapped location and grows until the whole layout is filled. The effect is rendered based on the [InitialRippleFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_InitialRippleFactor).

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView TouchDownEffects="Ripple">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView()
{
    TouchDownEffects = SfEffects.Ripple
};

{% endhighlight %}

{% endtabs %}

![Ripple effect](Effects_images/net_maui_ripple_effect.gif)