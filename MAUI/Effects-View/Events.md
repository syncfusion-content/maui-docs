---
layout: post
title: Events in .NET MAUI Effects View Control | Syncfusion®
description: Learn here all about events support in Syncfusion® .NET Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
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

## LongPressed event

The [LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressed)  event occurs when the user presses and holds within the bounds of the SfEffectsView for the configured long‑press duration.

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
    TouchDownEffects="Ripple"
    TouchUpEffects="Scale"
    LongPressed="EffectsView_LongPressed">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;
public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        var effectsView = new SfEffectsView
        {
            TouchDownEffects = SfEffects.Ripple,
            TouchUpEffects   = SfEffects.Scale
        };

        effectsView.LongPressed += EffectsView_LongPressed;
        ...
    }

    private void EffectsView_LongPressed(object sender, EventArgs e)
    {
        ...
    }
}

{% endhighlight %}

{% endtabs %}

## TouchDown event

The [TouchDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDown) event occurs when the user touches and presses down within the bounds of the SfEffectsView. 

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
        TouchDownEffects="Ripple"
        TouchDown="EffectsView_TouchDown">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;
public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        var effectsView = new SfEffectsView
        {
            TouchDownEffects = SfEffects.Ripple,
        };

        effectsView.TouchDown += EffectsView_TouchDown;
        ...
    }

    private void EffectsView_TouchDown(object sender, EventArgs e)
    {
        ...
    }
}

{% endhighlight %}

{% endtabs %}

## TouchUp event

The [TouchUp](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUp)  event occurs when the user releases the touch within the bounds of the SfEffectsView.

{% tabs %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView
        TouchUpEffects="Scale"
        TouchUp="EffectsView_TouchUp">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;
public partial class MainPage : ContentPage
{
    
    public MainPage()
    {
        InitializeComponent();
        var effectsView = new SfEffectsView
        {
            TouchDownEffects = SfEffects.Ripple,
        };

        effectsView.TouchUp += EffectsView_TouchUp;
        ...
    }

   private void EffectsView_TouchUp(object sender, EventArgs e)
   {
        ...
   }

}

{% endhighlight %}

{% endtabs %}