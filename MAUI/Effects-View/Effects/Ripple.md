---
layout: post
title: The .NET MAUI Ripple Effect | Effects View Control | Syncfusion®
description: Learn about the ripple effect in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Ripple Effect in .NET MAUI Effects View

## Prerequisites

Before using the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/effects-view/getting-started) documentation.

The [SfEffects.Ripple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Ripple) is an expandable circle that originates at the touch point and grows until the entire `SfEffectsView` is filled. Use it to provide Material-style touch feedback on any view.

The size of the ripple at the start of the animation is controlled by the [InitialRippleFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_InitialRippleFactor) property. The ripple is drawn inside the bounds of the `SfEffectsView`, not the parent layout.

## Adding a Basic Ripple

The example below applies a ripple to the `SfEffectsView` while the user is touching it.

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

{% endhighlight %}

{% endtabs %}

![Ripple effect expanding from the touch point](Effects_images/net_maui_ripple_effect.gif)

## Customizing the Ripple

The example below sets a custom ripple color and an initial factor of `0.25` (one quarter of the view's smaller dimension).


{% tabs %} 

{% highlight xaml hl_lines="15 16 17" %}

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

{% highlight c# hl_lines="44 45 46" %}

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

{% endhighlight %}

{% endtabs %}

## See also

- [Selection](https://help.syncfusion.com/maui/effects-view/effects/selection) describes the persistent background effect often combined with `Scale` on long-press.   
- [Highlight](https://help.syncfusion.com/maui/effects-view/effects/highlight) describes the color-transition effect that can be placed on a different trigger while rotation runs.  
- [Combining Effects](https://help.syncfusion.com/maui/effects-view/effects/combinations) explains the rules for placing `Rotation` alongside other effects.