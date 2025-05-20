---
layout: post
title: The .NET MAUI Rotate Animation | Effects View control | Syncfusion<sup>®</sup>
description: Learn all about rotation effect support in Syncfusion<sup>®</sup> .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: Effects View
documentation: UG
---

# Rotation Effect in .NET MAUI Effects View (SfEffectsView)

The [SfEffects.Rotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Rotation) provides a circular movement to the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) around its center, based on the specified [Angle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Angle).

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    TouchDownEffects="Rotation"
    Angle="180">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Rotation,
    Angle = 180,
};

{% endhighlight %}

{% endtabs %}

![.net maui rotation animation](Effects_images/net_maui_rotation_animation.gif)