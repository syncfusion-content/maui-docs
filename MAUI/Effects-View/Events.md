---
layout: post
title: Events in .NET MAUI Effects View control | Syncfusion®
description: Learn here all about Events support in Syncfusion® .NET Effects View (SfEffectsView) control and more.
platform: Maui
control: Effects View
documentation: ug
---

# Events in .NET MAUI Effects View (SfEffectsView)

## AnimationCompleted event

The [AnimationCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AnimationCompleted) event occurs when the rendered effects have been completed.

{% tabs %} 

{% highlight xaml %} 

    <syncEffectsView:SfEffectsView
    TouchDownEffects="Ripple"
    AnimationCompleted="AnimationCompleted">
    </syncEffectsView:SfEffectsView>
  
{% endhighlight %}

{% highlight C# %} 

    public partial class MainPage : ContentPage
    {

    public MainPage()
    {
        InitializeComponent();
        var effectsView = new SfEffectsView
        {
            TouchDownEffects = SfEffects.Ripple
        };

        effectsView.AnimationCompleted += AnimationCompleted;
        ...
    }

    private void AnimationCompleted(object sender, EventArgs e)
    {
        ...
    }
    }

{% endhighlight %}

{% endtabs %}

N> When the effects are rendered on direct interaction, the [AnimationCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AnimationCompleted) event occurs on touch up, and when it is applied programmatically, it is triggered immediately on completion of effects.

N> The [AnimationCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AnimationCompleted) event is not applicable for [SfEffects.Selection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Selection).

## SelectionChanged event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionChanged) event occurs when [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) is selected or unselected.

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView
    LongPressEffects="Selection"
    SelectionChanged="SelectionChanged"
    TouchDownEffects="None"
    TouchUpEffects="None">
</syncEffectsView:SfEffectsView>
  
{% endhighlight %}

{% highlight C# %} 

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        var effectsView = new SfEffectsView
        {
            LongPressEffects = SfEffects.Selection,
            TouchDownEffects = SfEffects.None,
            TouchUpEffects = SfEffects.None
        };

        effectsView.SelectionChanged += SelectionChanged;
        ...
    }

    private void SelectionChanged(object sender, EventArgs e)
    {
        ...
    }
}

{% endhighlight %}

{% endtabs %}

N> The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionChanged) event triggers both on rendering [SfEffects.Selection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Selection) by direct interaction and on changing the [IsSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_IsSelected) property of [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html).
