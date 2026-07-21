---
layout: post
title: The .NET MAUI Combination Effects | Effects View Control | Syncfusion®
description: Learn all about the combination of effects support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Combining Effects

The [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) control supports applying multiple [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) in combination on a single view.

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

## Trigger Properties

The `SfEffectsView` exposes four properties that accept one or more `SfEffects` flags. The trigger property you assign determines when each effect runs:

| Property | Triggered on |
| --- | --- |
| `Effects` | Loaded automatically without user interaction. |
| `TouchDownEffects` | When the user presses the view. |
| `TouchUpEffects` | When the user releases the press. |
| `LongPressEffects` | When the user long-presses the view. |

## Combination Rules

The following rules govern which effects can be combined and where:

- Each `SfEffect` value can be assigned to only one trigger property per view.
- `SfEffects.Rotation` cannot be combined with other effects.
- The other effects (`Highlight`, `Ripple`, `Scale`, and `Selection`) can be combined freely across the trigger properties, as shown in the examples below.

## Examples

The examples below use the XAML and C# tab pair to demonstrate each valid combination.

## Highlight and Ripple on TouchDown

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Highlight,Ripple">
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

{% highlight c# %} 

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
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Highlight | SfEffects.Ripple
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Highlight on TouchDown with Selection on LongPress

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Selection"
                               TouchDownEffects="Highlight">
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

{% highlight c# %} 

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
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.Highlight
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Ripple on TouchDown with Selection on TouchUp

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Ripple"
                               TouchUpEffects="Selection">
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

{% highlight c# %} 

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
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Ripple,
    TouchUpEffects = SfEffects.Selection
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Highlight, Ripple on TouchDown with Selection on LongPress

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Selection"
                               TouchDownEffects="Highlight,Ripple">
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

{% highlight c# %} 

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
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.Highlight | SfEffects.Ripple
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Scale and Selection on LongPress

{% tabs %} 

{% highlight xaml %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Scale,Selection">
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

{% highlight c# %} 

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
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Scale | SfEffects.Selection
};

this.Content = effectsView;

{% endhighlight %}
{% endtabs %}

## Troubleshooting

- If no effect is visible, confirm the `SfEffectsView` has a non-zero `Width` and `Height` and is hosted inside a `ContentPage`.
- If you assign the same `SfEffect` value to more than one trigger property, only the first assignment is applied. Reset by calling `ResetEffects` on the view.
- Combined effects remain in their final state until the view is released; use `AutoResetEffects` to control the auto-reset behavior.