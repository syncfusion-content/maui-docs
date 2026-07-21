---
layout: post
title: Events in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the events available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG

# Events

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) exposes events that fire when the user interacts with the view or when an animation completes. All events use the standard `EventHandler` signature with `sender` typed as `SfEffectsView`.

## Event Summary

| Event | Fires on | Applies to |
| --- | --- | --- |
| [AnimationCompleted](#animationcompleted-event) | When an effect's animation finishes. | All effects except `Selection`. |
| [SelectionChanged](#selectionchanged-event) | When the `IsSelected` state changes. | The `Selection` effect. |
| [LongPressed](#longpressed-event) | When the user long-presses the view. | Any configuration. |
| [TouchDown](#touchdown-event) | When the user presses the view. | Any configuration. |
| [TouchUp](#touchup-event) | When the user releases the press. | Any configuration. |

> **Note**
>
> The long-press duration is platform-defined and cannot be customized in the current version.

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` and `using Microsoft.Maui.Controls;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

## AnimationCompleted event

The [AnimationCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AnimationCompleted) event fires when an effect's animation has finished.

- When the effect is triggered by direct user interaction, the event fires on touch up.
- When the effect is applied programmatically (for example, with `ApplyEffects`), the event fires immediately on completion.

> **Note**
>
> The `AnimationCompleted` event is not raised for the `Selection` effect.

### XAML

```xaml
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
```

### C#

```csharp
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

void OnEffectsViewAnimationCompleted(object sender, EventArgs e)
{
    // Handle the animation completion here.
}
```

## SelectionChanged event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionChanged) event fires when the view's `IsSelected` state changes. It fires both when the `Selection` effect is triggered by user interaction and when the `IsSelected` property is changed in code.

The `EventArgs` does not include the new selection state; read it from the `SfEffectsView` sender via the `IsSelected` property.

> **Note**
>
> The example below sets `TouchDownEffects` and `TouchUpEffects` to `None` so the long-press triggers only the `Selection` effect, without an accompanying ripple or scale.

### XAML

```xaml
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
```

### C#

```csharp
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

void OnEffectsViewSelectionChanged(object sender, EventArgs e)
{
    var view = (SfEffectsView)sender;
    bool isNowSelected = view.IsSelected;
    // React to the new selection state here.
}
```

## LongPressed event

The [LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressed) event fires when the user presses and holds the view for the platform-defined long-press duration.

### XAML

```xaml
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
```

### C#

```csharp
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

void OnEffectsViewLongPressed(object sender, EventArgs e)
{
    // Handle the long-press here.
}
```

## TouchDown event

The [TouchDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDown) event fires when the user presses the view.

### XAML

```xaml
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
```

### C#

```csharp
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

void OnEffectsViewTouchDown(object sender, EventArgs e)
{
    // Handle the touch-down here.
}
```

## TouchUp event

The [TouchUp](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUp) event fires when the user releases the press.

### XAML

```xaml
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
```

### C#

```csharp
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

void OnEffectsViewTouchUp(object sender, EventArgs e)
{
    // Handle the touch-up here.
}
```

## Unsubscribing

Use the `-=` operator to remove an event handler when the subscription is no longer needed (for example, when the page is being torn down).

```csharp
effectsView.AnimationCompleted -= OnEffectsViewAnimationCompleted;
```

## Events vs. Commands

Each event has a corresponding command (`TouchDownCommand`, `TouchUpCommand`, `LongPressedCommand`) for view-model scenarios. Choose events for code-behind handlers and commands when you want to bind to a view-model `ICommand`.

## Troubleshooting

- If an event does not fire, confirm the `SfEffectsView` is added to the visual tree (for example, by assigning it to `Content` of a `ContentPage`) and that the corresponding trigger property (`TouchDownEffects`, `TouchUpEffects`, `LongPressEffects`) is set to a non-`None` value.
- If the `SelectionChanged` event fires but the new state is unclear, read `IsSelected` on the `sender` parameter.
- If the `AnimationCompleted` event never fires for a `Selection` effect, that is expected; the event is not raised for `Selection`.
- If you subscribe to the same event multiple times, the handler is called once per subscription; remember to unsubscribe with `-=` to avoid leaks.