---
layout: post
title: Features in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the features available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Features in .NET MAUI Effects View

## Prerequisites

Before using the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/effects-view/getting-started) documentation.

The `SfEffectsView` control provides the following additional features that complement the built-in effects.

## FadeOutRipple

When `FadeOutRipple` is `true`, the ripple fades to opacity 0 as it grows, producing a softer animation. The optional `RippleAnimationDuration` property controls how long the ripple animation runs, in milliseconds. The default value is `400`.

{% tabs %} 

{% highlight xaml hl_lines="15" %}

<Border HorizontalOptions="Center" 
        VerticalOptions="Center">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="18" />
    </Border.StrokeShape>
    <Border.Background>
        <LinearGradientBrush EndPoint="1,0">
            <GradientStop Color="#FFCDCDD2" 
                          Offset="0.0" />
            <GradientStop Color="#FFCDCDD2" 
                          Offset="1.0" />
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
                <StackLayout Grid.Column="1" 
                             VerticalOptions="Center">
                    <Label Text="Laura Steffi" 
                           Margin="10,0,10,0" 
                           FontSize="18" />
                    <Label Text="Data Science Analyst" 
                           Margin="10,0,10,0" 
                           FontSize="12"/>
                </StackLayout>
        </Grid>
    </syncEffectsView:SfEffectsView>
</Border>

{% endhighlight %}

{% highlight c# hl_lines="45" %}

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

{% endhighlight %}

{% endtabs %}

![Ripple fading out as it grows](Features_images/EffectsView_Fadeout_Ripple.gif)

## IsSelected

Setting `IsSelected` to `true` marks the `SfEffectsView` as selected. The `Selection` effect reads this property and applies the `SelectionBackground` brush.

{% tabs %} 

{% highlight xaml hl_lines="5" %}

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
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="24" %}

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

{% endhighlight %}

{% endtabs %}

## ShouldIgnoreTouches

When `ShouldIgnoreTouches` is `true`, the `SfEffectsView` does not handle touches itself. Use it when the view is hosted inside a scroll view, carousel, or other container that needs to receive the gesture, while still allowing the visual effects to fire.

{% tabs %} 

{% highlight xaml hl_lines="5" %}

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
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>
<syncEffectsView:SfEffectsView ShouldIgnoreTouches="True">
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="24" %}

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

{% endhighlight %}

{% endtabs %}

## AutoResetEffects

`AutoResetEffects` is a flags enum that selects which effects automatically return to their rest state when the touch ends. By default, all supported effects auto-reset. Pass a combination of values to limit the auto-reset behavior to specific effects.

Supported values include `Highlight`, `Ripple`, `Scale`, and `Selection`. Combine them with the bitwise `|` operator in C# or with a comma-separated list in XAML.

{% tabs %} 

{% highlight xaml hl_lines="5" %}

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
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="24" %}

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

{% endhighlight %}

{% endtabs %}

## See also

- [Customization](https://help.syncfusion.com/maui/effects-view/customization) describes the duration, size, and color properties that tune the built-in effects.  
- [Effects](https://help.syncfusion.com/maui/effects-view/effects/overview) lists the highlight, ripple, scale, selection, and rotation effects that these features control.  
- [Interaction](https://help.syncfusion.com/maui/effects-view/interaction) explains the trigger properties that play an effect when the user touches the view.