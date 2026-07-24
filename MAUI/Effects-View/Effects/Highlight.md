---
layout: post
title: The .NET MAUI Highlight Effect | Effects View Control | Syncfusion®
description: Learn about the highlight effect support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Highlight Effect in .NET MAUI Effects View

## Prerequisites

Before using the [`SfEffectsView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/effects-view/getting-started) documentation.

The [SfEffects.Highlight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Highlight) effect applies a smooth color transition to the background of the `SfEffectsView` when the user touches the view. Use it to give users visual feedback for taps, long presses, and other interactions.

## Setting the Highlight Background

The example below applies a red background to the `SfEffectsView` while the user is touching it.

{% tabs %} 

{% highlight xaml hl_lines="15 16" %}

<Border HorizontalOptions="Center" 
        VerticalOptions="Center">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="18" />
    </Border.StrokeShape>
    <Border.Background>
        <LinearGradientBrush EndPoint="1,0">
            <GradientStop Color="#FFCDCDD2" 
                          Offset="0.0" />
            <GradientStop Color="#FFEEEEF5" 
                          Offset="1.0" />
        </LinearGradientBrush>
    </Border.Background>
    <syncEffectsView:SfEffectsView TouchDownEffects="Highlight"
                                   HighlightBackground="Red">
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

{% highlight c# hl_lines="44 45" %}

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
    TouchDownEffects = SfEffects.Highlight,
    HighlightBackground = new SolidColorBrush(Colors.Red),
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

The XAML example uses the string `"Red"` (a named color), and the C# example uses `SolidColorBrush(Colors.Aqua)`. Both forms are equivalent; pick whichever matches your styling preference.

![Highlight effect with a custom background](Effects_images/net_maui_highlight_effect.png)

## See also

- [Ripple](https://help.syncfusion.com/maui/effects-view/effects/ripple) covers the expandable circle effect that often pairs with `Highlight` on touch down.  
- [Selection](https://help.syncfusion.com/maui/effects-view/effects/selection) describes the persistent background effect that uses a similar `Brush` property for a different purpose.  
- [Combining Effects](https://help.syncfusion.com/maui/effects-view/effects/combinations) shows how to assign `Highlight` together with other effects across the trigger properties.