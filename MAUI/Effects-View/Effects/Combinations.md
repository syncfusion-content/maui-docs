---
layout: post
title: The .NET MAUI Combination Effects | Effects View Control | Syncfusion®
description: Learn all about the combination of effects support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Combination of effects 

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) control supports applying multiple [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) in combination. Below are some valid combinations of [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html):

## Highlight and Ripple

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

## Highlight and Selection

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

## Ripple and Selection

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

## Highlight, Ripple, and Selection

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

## Scale and Selection

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