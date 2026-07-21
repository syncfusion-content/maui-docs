---
layout: post
title: Features in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the features available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Features

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) control provides the following additional features that complement the built-in effects.

## Feature Summary

| Property | Type | Default | Description |
| --- | --- | --- | --- |
| [FadeOutRipple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_FadeOutRipple) | `bool` | `false` | Fades the ripple to opacity 0 as it grows. |
| [IsSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_IsSelected) | `bool` | `false` | Marks the view as selected. Read by the `Selection` effect. |
| [ShouldIgnoreTouches](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ShouldIgnoreTouches) | `bool` | `false` | Stops the view from handling touches itself. |
| [AutoResetEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AutoResetEffects) | `AutoResetEffects` flags | All supported effects | Selects which effects automatically return to rest after the touch ends. |

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` and `using Microsoft.Maui.Controls;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

## FadeOutRipple

When `FadeOutRipple` is `true`, the ripple fades to opacity 0 as it grows, producing a softer animation. The optional `RippleAnimationDuration` property controls how long the ripple animation runs, in milliseconds. The default value is `400`.

### XAML

```xaml
<Border HorizontalOptions="Center" VerticalOptions="Center">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="18" />
    </Border.StrokeShape>
    <Border.Background>
        <LinearGradientBrush EndPoint="1,0">
            <GradientStop Color="#FFCDCDD2" Offset="0.0" />
            <GradientStop Color="#FFCDCDD2" Offset="1.0" />
        </LinearGradientBrush>
    </Border.Background>
    <syncEffectsView:SfEffectsView FadeOutRipple="True"
                                   RippleAnimationDuration="1000">
        <Grid>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="90" />
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <Image Source="laura.png" 
                   Margin="7" 
                   VerticalOptions="Center"
                   WidthRequest="72" 
                   HeightRequest="72" />
                <StackLayout Grid.Column="1" VerticalOptions="Center">
                    <Label Text="Laura Steffi" Margin="10,0,10,0" FontSize="18" />
                    <Label Text="Data Science Analyst" Margin="10,0,10,0" FontSize="12"/>
                </StackLayout>
        </Grid>
    </syncEffectsView:SfEffectsView>
</Border>
```

### C#

```csharp
var grid = new Grid
{
    ColumnDefinitions =
    {
        new ColumnDefinition { Width = 90 },
        new ColumnDefinition { Width = GridLength.Star }
    }
};

var image = new Image
{
    Source = "laura.png",
    Margin = new Thickness(7),
    VerticalOptions = LayoutOptions.Center,
    WidthRequest = 72,
    HeightRequest = 72
};

var nameLabel = new Label
{
    Text = "Laura Steffi",
    Margin = new Thickness(10, 0),
    FontSize = 18
};

var roleLabel = new Label
{
    Text = "Data Science Analyst",
    Margin = new Thickness(10, 0),
    FontSize = 12
};

var stackLayout = new StackLayout
{
    VerticalOptions = LayoutOptions.Center,
    Children = { nameLabel, roleLabel }
};

grid.Add(image);
grid.Add(stackLayout, 1, 0);

var effectsView = new SfEffectsView
{
    FadeOutRipple = true,
    RippleAnimationDuration = 1000,
    Content = grid
};

var border = new Border
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = 18
    },
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 0),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FFCDCDD2"), 0.0f),
            new GradientStop(Color.FromArgb("#FFCDCDD2"), 1.0f)
        }
    },
    Content = effectsView
};

this.Content = border;
```

![Ripple fading out as it grows](Features_images/EffectsView_Fadeout_Ripple.gif)

## IsSelected

Setting `IsSelected` to `true` marks the `SfEffectsView` as selected. The `Selection` effect reads this property and applies the `SelectionBackground` brush.

### XAML

```xaml
<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               IsSelected="True">
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
    IsSelected = true,
    Content = grid
};

this.Content = effectsView;
```

## ShouldIgnoreTouches

When `ShouldIgnoreTouches` is `true`, the `SfEffectsView` does not handle touches itself. Use it when the view is hosted inside a scroll view, carousel, or other container that needs to receive the gesture, while still allowing the visual effects to fire.

### XAML

```xaml
<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               ShouldIgnoreTouches="True">
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
<syncEffectsView:SfEffectsView ShouldIgnoreTouches="True">
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
    ShouldIgnoreTouches = true,
    Content = grid
};

this.Content = effectsView;
```

## AutoResetEffects

`AutoResetEffects` is a flags enum that selects which effects automatically return to their rest state when the touch ends. By default, all supported effects auto-reset. Pass a combination of values to limit the auto-reset behavior to specific effects.

Supported values include `Highlight`, `Ripple`, `Scale`, and `Selection`. Combine them with the bitwise `|` operator in C# or with a comma-separated list in XAML.

### XAML

```xaml
<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               AutoResetEffects="Highlight,Ripple">
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
    AutoResetEffects = AutoResetEffects.Highlight | AutoResetEffects.Ripple,,
    Content = grid
};

this.Content = effectsView;
```

> **Note**
>
> The C# example disambiguates between the property name `AutoResetEffects` and the nested enum type by using the full type path `SfEffectsView.AutoResetEffects.Highlight`. In XAML, the parser resolves the string `"Highlight"` to the matching enum member.

## Troubleshooting

- If `FadeOutRipple` has no visible effect, confirm the `Ripple` effect is applied to one of the trigger properties (`TouchDownEffects`, `TouchUpEffects`, or `LongPressEffects`) or started through `ApplyEffects`.
- If setting `IsSelected` does not show a selection, confirm the `Selection` effect is assigned to a trigger property and that `SelectionBackground` is set to a non-null `Brush`.
- If touches still reach the `SfEffectsView` after setting `ShouldIgnoreTouches`, check that no parent container is re-dispatching the events.
- If an effect does not auto-reset, confirm its value is included in the `AutoResetEffects` flags.