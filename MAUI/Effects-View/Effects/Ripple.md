---
layout: post
title: The .NET MAUI Ripple Effect | Effects View Control | Syncfusion®
description: Learn about the ripple effect in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Ripple Effect

The [SfEffects.Ripple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Ripple) is an expandable circle that originates at the touch point and grows until the entire `SfEffectsView` is filled. Use it to provide Material-style touch feedback on any view.

The size of the ripple at the start of the animation is controlled by the [InitialRippleFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_InitialRippleFactor) property. The ripple is drawn inside the bounds of the `SfEffectsView`, not the parent layout.

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` and `using Microsoft.Maui.Controls;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

## Ripple Properties

The `Ripple` effect is configured by the following properties on `SfEffectsView`:

| Property | Description | Default value | Valid range |
| --- | --- | --- | --- |
| `RippleBackground` | The brush used to fill the ripple. Accepts any `Brush` (for example, `SolidColorBrush`). | `SolidColorBrush(Color.FromArgb("#22FFFFFF"))` | Any valid `Brush` |
| `InitialRippleFactor` | The starting size of the ripple as a fraction of the view's smaller dimension. | `0.1` | `0` to `1` |
| `RippleDuration` | The duration of the ripple animation, in milliseconds. | `400` | Positive integer |
| `AutoResetEffects` | When `true`, the effect resets automatically when the touch ends. | `true` | `true` / `false` |
| `ResetEffects` | Method invoked to reset the effect programmatically. | N/A | N/A |

For a list of all trigger properties that accept `SfEffects.Ripple`, see [Combining Effects](Combinations.md).

## Adding a Basic Ripple

The example below applies a ripple to the `SfEffectsView` while the user is touching it.

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
    <syncEffectsView:SfEffectsView TouchDownEffects="Ripple">
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
    TouchDownEffects = SfEffects.Ripple,
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

![Ripple effect expanding from the touch point](Effects_images/net_maui_ripple_effect.gif)

## Customizing the Ripple

The example below sets a custom ripple color and an initial factor of `0.25` (one quarter of the view's smaller dimension).

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
    <syncEffectsView:SfEffectsView TouchDownEffects="Ripple"
                                   RippleBackground="Red"
                                   InitialRippleFactor="0.25">
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
    TouchDownEffects = SfEffects.Ripple,
    RippleBackground = new SolidColorBrush(Colors.Red),
    InitialRippleFactor = 0.25,
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

The XAML example uses the string `"Red"` (a named color), and the C# example uses `SolidColorBrush(Colors.Red)`. Both forms are equivalent.

## Troubleshooting

- If the ripple is not visible, confirm `RippleBackground` is set to a non-null `Brush` and that the view has a non-zero `Width` and `Height`.
- If the ripple is too small, increase `InitialRippleFactor` toward `1`.
- If the ripple persists after the user releases the touch, set `AutoResetEffects="True"` or call `ResetEffects` manually.
- If you assign `SfEffects.Ripple` to more than one trigger property, only the first assignment is applied.