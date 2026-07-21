---
layout: post
title: The .NET MAUI Selection Effect | Effects View Control | Syncfusion®
description: Learn about the selection effect in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Selection Effect

The [SfEffects.Selection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Selection) effect applies a smooth color transition to the background of the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) to indicate the selected or unselected state. Use it to give users clear visual feedback when an item is chosen, for example in a list or grid.

Unlike the `Highlight` effect, which is a transient response to a touch, the `Selection` effect reflects a persistent state that you set with the `IsSelected` property.

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` and `using Microsoft.Maui.Controls;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

## Selection Properties

The `Selection` effect is configured by the following properties on `SfEffectsView`:

| Property | Description | Default value |
| --- | --- | --- |
| `SelectionBackground` | The brush applied to the background when `IsSelected` is `true`. Accepts any `Brush` (for example, `SolidColorBrush`). | `SolidColorBrush(Color.FromArgb("#14000000"))` |
| `AutoResetEffects` | When `true`, the effect is reset automatically when the touch ends. | `true` |
| `ResetEffects` | Method invoked to reset the effect programmatically. | N/A |

For a list of all trigger properties that accept `SfEffects.Selection`, see [Combining Effects](Combinations.md).

## Setting the Selection Background

The example below applies a red background to the `SfEffectsView` when the user long-presses it (and `IsSelected` is set to `true`).

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
    <syncEffectsView:SfEffectsView LongPressEffects="Selection"
                                   SelectionBackground="Aqua">
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
    LongPressEffects = SfEffects.Selection,
    SelectionBackground = new SolidColorBrush(Colors.Aqua),
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

![Selection effect with a red background](Effects_images/net_maui_selection_effect.png)

## Troubleshooting

- If the selection persists after you set `IsSelected = false`, call `ResetEffects` manually.
- If you assign `SfEffects.Selection` to more than one trigger property, only the first assignment is applied.