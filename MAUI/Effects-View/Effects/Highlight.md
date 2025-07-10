---
layout: post
title: The .NET MAUI Highlight Effects | Effects View Control | Syncfusion®
description: Learn about highlight effect support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
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

![Highlight effect](Effects_images/net_maui_highlight_effect.png)