---
layout: post
title: Features in .NET MAUI Effects View control | Syncfusion
description: Learn here all about Features support in Syncfusion .NET MAUI Effects View (SfEffectsView) control and more.
platform: maui
control: Effects View
documentation: ug
---

# Features in .NET MAUI Effects View (SfEffectsView)

The `SfEffectsView` control provides the following additional features to enhance the effects:

## FadeOutRipple

By enabling the `FadeOutRipple` property of `SfEffectsView`, the growable circle will lose its opacity to 0 on growing.

{% tabs %} 

{% highlight xaml %} 

    <syncEffectsView:SfEffectsView
    FadeOutRipple="True"
    RippleAnimationDuration="1000">
    </syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

     var effectsView = new SfEffectsView
    {
    FadeOutRipple = true,
    RippleAnimationDuration = 1000
    };
            
{% endhighlight %}

{% endtabs %}

![.NET MAUI Effects View FadeOutRipple](Features_images/EffectsView_Fadeout_Ripple.gif)

## IsSelected

Enabling the `IsSelected` property of `SfEffectsView` sets the view state as selected.

{% tabs %} 

{% highlight xaml %} 

    <syncEffectsView:SfEffectsView
    IsSelected="true">
    </syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

    var effectsView = new SfEffectsView
    {
    IsSelected = true,
    };

{% endhighlight %}

{% endtabs %}

## ShouldIgnoreTouches

Enabling the `ShouldIgnoreTouches` property of `SfEffectsView` cancels the direct interaction of the `SfEffectsView`.

{% tabs %} 

{% highlight xaml %} 

     <syncEffectsView:SfEffectsView ShouldIgnoreTouches="true">
     </syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %} 

    var effectsView = new SfEffectsView
    {
      ShouldIgnoreTouches = true
    };

{% endhighlight %}

{% endtabs %}

