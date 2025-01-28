---
layout: post
title: The .NET MAUI Scale Animation | Effects View control | Syncfusion<sup>®</sup>
description: Learn here all about scale effect support in Syncfusion<sup>®</sup> .NET MAUI Effects View (SfEffectsView) control and more.
platform: maui
control: Effects View
documentation: ug
---

# Scale Effect in .NET MAUI Effects View (SfEffectsView)

[SfEffects.Scale](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Scale) is a smooth transition on the size of the [SfEffectsView.Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Content) from its actual size to the size calculated based on [ScaleFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ScaleFactor) in pixels.

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