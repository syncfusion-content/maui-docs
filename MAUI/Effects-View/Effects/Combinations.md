---
layout: post
title: The .NET MAUI Combination Effects | Effects View control | Syncfusion<sup>®</sup>
description: Learn here all about the combination of effects support in Syncfusion<sup>®</sup> .NET MAUI Effects View (SfEffectsView) control and more.
platform: maui
control: Effects View
documentation: ug
---

# Combination of Effects 

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) control provides support to apply multiple [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) in combination. The following are some valid combinations of [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html):

## Highlight and ripple

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView TouchDownEffects="Highlight,Ripple">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView()
{
    TouchDownEffects = SfEffects.Highlight | SfEffects.Ripple
};

{% endhighlight %}

{% endtabs %}

## Highlight and selection

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    LongPressEffects="Selection"
    TouchDownEffects="Highlight">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView()
{
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.Highlight
};

{% endhighlight %}

{% endtabs %}

## Ripple and selection

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    TouchDownEffects="Ripple"
    TouchUpEffects="Selection">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView()
{
    TouchDownEffects = SfEffects.Ripple,
    TouchUpEffects = SfEffects.Selection
};

{% endhighlight %}

{% endtabs %}

## Highlight, ripple, and selection

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    LongPressEffects="Selection"
    TouchDownEffects="Highlight,Ripple">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView()
{
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.Highlight | SfEffects.Ripple
};

{% endhighlight %}

{% endtabs %}

## Scale and selection

{% tabs %} 

{% highlight xaml %} 

 <syncEffectsView:SfEffectsView LongPressEffects="Scale,Selection">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

var effectsView = new SfEffectsView()
{
    LongPressEffects = SfEffects.Scale | SfEffects.Selection
};

{% endhighlight %}

{% endtabs %}