---
layout: post
title: The .NET MAUI Highlight Effects | Effects View control | Syncfusion<sup>®</sup>
description: Learn here all about highlight effect support in Syncfusion<sup>®</sup> .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: Effects View
documentation: UG
---

# Highlight Effect in .NET MAUI Effects View (SfEffectsView)

The [SfEffects.Highlight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Highlight) provides a smooth transition on the background color of the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html).

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    TouchDownEffects="Highlight"
    HighlightBackground="#FF0000">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Highlight,
    HighlightBackground = new SolidColorBrush(Colors.Aqua)
};

{% endhighlight %}

{% endtabs %}

![.net maui highlight effect](Effects_images/net_maui_highlight_effect.png)