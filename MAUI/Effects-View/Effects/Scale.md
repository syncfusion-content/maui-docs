---
layout: post
title: The .NET MAUI Scale Animation | Effects View control | Syncfusion<sup>®</sup>
description: Learn all about scale effect support in Syncfusion<sup>®</sup> .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: Effects View
documentation: UG
---

# Scale Effect in .NET MAUI Effects View (SfEffectsView)

The [SfEffects.Scale](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Scale) provides a smooth transition in the size of the [SfEffectsView.Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Content), adjusting from its actual size to a new size based on the [ScaleFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ScaleFactor) specified in pixels.

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    ScaleFactor="0.85"
    TouchDownEffects="None"
    TouchUpEffects="None"
    LongPressEffects="Scale">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    ScaleFactor = 0.85,
    TouchDownEffects = SfEffects.None,
    TouchUpEffects = SfEffects.None,
    LongPressEffects = SfEffects.Scale
};

{% endhighlight %}

{% endtabs %}

![.net maui scale animation](Effects_images/net_maui_scale_animation.png)