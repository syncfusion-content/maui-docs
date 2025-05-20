---
layout: post
title: The .NET MAUI Selection Effects | Effects View control | Syncfusion<sup>®</sup>
description: Learn all about selection effect support in Syncfusion<sup>®</sup> .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: Effects View
documentation: UG
---

# Selection Effect in .NET MAUI Effects View (SfEffectsView)

The [SfEffects.Selection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Selection) provides a smooth color transition to indicate whether the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) state is selected or not.

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    LongPressEffects="Selection"
    SelectionBackground="#FF0000">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView
{
    LongPressEffects = SfEffects.Selection,
    SelectionBackground = new SolidColorBrush(Colors.Aqua)
};

{% endhighlight %}

{% endtabs %}

![.net maui selection effect](Effects_images/net_maui_selection_effect.png)