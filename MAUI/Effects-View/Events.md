---
layout: post
title: Events in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the events available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG

# Events in .NET MAUI Effects View

## Prerequisites

Before using the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/effects-view/getting-started) documentation.

The `SfEffectsView` exposes events that fire when the user interacts with the view or when an animation completes. All events use the standard `EventHandler` signature with `sender` typed as `SfEffectsView`.

## AnimationCompleted event

The [AnimationCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AnimationCompleted) event fires when an effect's animation has finished.

- When the effect is triggered by direct user interaction, the event fires on touch up.
- When the effect is applied programmatically (for example, with `ApplyEffects`), the event fires immediately on completion.

N> The `AnimationCompleted` event is not raised for the `Selection` effect.

{% tabs %} 

{% highlight xaml hl_lines="6" %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Ripple"
                               AnimationCompleted="OnEffectsViewAnimationCompleted">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="28" %}

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Ripple,
    Content = grid
};

effectsView.AnimationCompleted += OnEffectsViewAnimationCompleted;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

The `AnimationCompleted` event can be handled in C# as follows:

{% tabs %} 

{% highlight c# %}

void OnEffectsViewAnimationCompleted(object sender, EventArgs e)
{
    // Handle the animation completion here.
}

{% endhighlight %}

{% endtabs %}

## SelectionChanged event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionChanged) event fires when the view's `IsSelected` state changes. It fires both when the `Selection` effect is triggered by user interaction and when the `IsSelected` property is changed in code.

The `EventArgs` does not include the new selection state; read it from the `SfEffectsView` sender via the `IsSelected` property.

{% tabs %} 

{% highlight xaml hl_lines="8" %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Selection"
                               TouchDownEffects="None"
                               TouchUpEffects="None"
                               SelectionChanged="OnEffectsViewSelectionChanged">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="30" %}

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.None,
    TouchUpEffects = SfEffects.None,
    Content = grid
};

effectsView.SelectionChanged += OnEffectsViewSelectionChanged;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

The `SelectionChanged` event can be handled in C# as follows:

{% tabs %} 

{% highlight c# %}

void OnEffectsViewSelectionChanged(object sender, EventArgs e)
{
    var view = (SfEffectsView)sender;
    bool isNowSelected = view.IsSelected;
    // React to the new selection state here.
}

{% endhighlight %}

{% endtabs %}

## LongPressed event

The [LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressed) event fires when the user presses and holds the view for the platform-defined long-press duration.

{% tabs %} 

{% highlight xaml hl_lines="7" %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Ripple"
                               TouchUpEffects="Scale"
                               LongPressed="OnEffectsViewLongPressed">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="29" %}

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Ripple,
    TouchUpEffects = SfEffects.Scale,
    Content = grid
};

effectsView.LongPressed += OnEffectsViewLongPressed;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

The `LongPressed` event can be handled in C# as follows:

{% tabs %} 

{% highlight c# %}

void OnEffectsViewLongPressed(object sender, EventArgs e)
{
    // Handle the long-press here.
}

{% endhighlight %}

{% endtabs %}

## TouchDown event

The [TouchDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDown) event fires when the user presses the view.

{% tabs %} 

{% highlight xaml hl_lines="6" %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Ripple"
                               TouchDown="OnEffectsViewTouchDown">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="28" %}

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Ripple,
    Content = grid
};

effectsView.TouchDown += OnEffectsViewTouchDown;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

The `TouchDown` event can be handled in C# as follows:

{% tabs %} 

{% highlight c# %}

void OnEffectsViewTouchDown(object sender, EventArgs e)
{
    // Handle the touch-down here.
}

{% endhighlight %}

{% endtabs %}

## TouchUp event

The [TouchUp](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUp) event fires when the user releases the press.

{% tabs %} 

{% highlight xaml hl_lines="6" %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchUpEffects="Scale"
                               TouchUp="OnEffectsViewTouchUp">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="28" %}

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchUpEffects = SfEffects.Scale,
    Content = grid
};

effectsView.TouchUp += OnEffectsViewTouchUp;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

The `TouchUp` event can be handled in C# as follows:

{% tabs %} 

{% highlight c# %}

void OnEffectsViewTouchUp(object sender, EventArgs e)
{
    // Handle the touch-up here.
}

{% endhighlight %}

{% endtabs %}

## Unsubscribe

Use the `-=` operator to remove an event handler when the subscription is no longer needed (for example, when the page is being torn down).

{% tabs %} 

{% highlight c# %}

effectsView.AnimationCompleted -= OnEffectsViewAnimationCompleted;

{% endhighlight %}

{% endtabs %}

## Events vs. Commands

Each event has a corresponding command (`TouchDownCommand`, `TouchUpCommand`, `LongPressedCommand`) for view-model scenarios. Choose events for code-behind handlers and commands when you want to bind to a view-model `ICommand`.

## See also

- [Commands](https://help.syncfusion.com/maui/effects-view/commands) covers the `ICommand`-based counterpart of these events for view-model scenarios.  
- [Interaction](https://help.syncfusion.com/maui/effects-view/interaction) documents the trigger properties (`TouchDownEffects`, `TouchUpEffects`, `LongPressEffects`) that play effects in response to these events.  
- [Methods](https://help.syncfusion.com/maui/effects-view/methods) shows how to start and stop effects programmatically, which also raises `AnimationCompleted`.