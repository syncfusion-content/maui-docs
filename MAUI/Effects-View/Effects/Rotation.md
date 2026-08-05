---
layout: post
title: Rotation Effect in .NET MAUI Effects View  | Syncfusion®
description: Learn about the rotation effect in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Rotation Effect in .NET MAUI Effects View

The [SfEffects.Rotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Rotation) effect rotates the `Effects View` around its center by the specified [Angle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Angle). Positive angles rotate clockwise; negative angles rotate counter-clockwise.

## Adding a Basic Rotation

The example below rotates the `Effects View` by 180 degrees when the user presses it.

{% tabs %} 

{% highlight xaml hl_lines="10 11" %}

<Border WidthRequest="36"
        HeightRequest="36"
        HorizontalOptions="Center"
        VerticalOptions="Center"
        StrokeThickness="0">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="10" />
    </Border.StrokeShape>
    <syncEffectsView:SfEffectsView Angle="180"
                                   TouchDownEffects="Rotation"
                                   HorizontalOptions="Center">
        <HorizontalStackLayout Spacing="-4">
            <Label Text="↑"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="Start" />
            <Label Text="↓"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="End"
                   Margin="0,8,0,0" />
        </HorizontalStackLayout>
    </syncEffectsView:SfEffectsView>
</Border>

{% endhighlight %}

{% highlight c# hl_lines="17 18" %}

var border = new Border
{
    WidthRequest = 36,
    HeightRequest = 36,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeThickness = 0,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = new CornerRadius(10)
    }
};

var effectsView = new SfEffectsView
{
    Angle = 180,
    TouchDownEffects = SfEffects.Rotation,
    HorizontalOptions = LayoutOptions.Center
};

var stackLayout = new HorizontalStackLayout
{
    Spacing = -4,
    Children =
    {
        new Label
        {
            Text = "↑",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Start
        },

        new Label
        {
            Text = "↓",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.End,
            Margin = new Thickness(0, 8, 0, 0)
        }
    }
};

effectsView.Content = stackLayout;
border.Content = effectsView;
this.Content = border;

{% endhighlight %}

{% endtabs %}

![Rotation effect rotating the view 180 degrees](Effects_images/net_maui_rotation_animation.gif)

## Customizing the Duration

The example below slows the rotation to 800 milliseconds.

{% tabs %} 

{% highlight xaml hl_lines="10 11 12" %}

<Border WidthRequest="36"
        HeightRequest="36"
        HorizontalOptions="Center"
        VerticalOptions="Center"
        StrokeThickness="0">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="10" />
    </Border.StrokeShape>
    <syncEffectsView:SfEffectsView TouchDownEffects="Rotation"
                                   Angle="360"
                                   RotationAnimationDuration="800"
                                   HorizontalOptions="Center">
        <HorizontalStackLayout Spacing="-4">
            <Label Text="↑"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="Start" />
            <Label Text="↓"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="End"
                   Margin="0,8,0,0" />
        </HorizontalStackLayout>
    </syncEffectsView:SfEffectsView>
</Border>

{% endhighlight %}

{% highlight c# hl_lines="17 18 19" %}

var border = new Border
{
    WidthRequest = 36,
    HeightRequest = 36,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeThickness = 0,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = new CornerRadius(10)
    }
};

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Rotation,
    Angle = 360,
    RotationAnimationDuration = 800,
    HorizontalOptions = LayoutOptions.Center
};

var stackLayout = new HorizontalStackLayout
{
    Spacing = -4,
    Children =
    {
        new Label
        {
            Text = "↑",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Start
        },

        new Label
        {
            Text = "↓",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.End,
            Margin = new Thickness(0, 8, 0, 0)
        }
    }
};

effectsView.Content = stackLayout;
border.Content = effectsView;
this.Content = border;

{% endhighlight %}

{% endtabs %}

## Combining with Other Effects

`Rotation` cannot share a trigger property with other effects. Place another effect on a different trigger property so the two effects can play independently.

{% tabs %} 

{% highlight xaml hl_lines="10 11 12" %}

<Border WidthRequest="36"
        HeightRequest="36"
        HorizontalOptions="Center"
        VerticalOptions="Center"
        StrokeThickness="0">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="10" />
    </Border.StrokeShape>
    <syncEffectsView:SfEffectsView TouchDownEffects="Rotation"
                                   LongPressEffects="Ripple"
                                   Angle="180"
                                   HorizontalOptions="Center">
        <HorizontalStackLayout Spacing="-4">
            <Label Text="↑"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="Start" />
            <Label Text="↓"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="End"
                   Margin="0,8,0,0" />
        </HorizontalStackLayout>
    </syncEffectsView:SfEffectsView>
</Border>

{% endhighlight %}

{% highlight c# hl_lines="17 18 19" %}

var border = new Border
{
    WidthRequest = 36,
    HeightRequest = 36,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeThickness = 0,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = new CornerRadius(10)
    }
};

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Rotation,
    LongPressEffects = SfEffects.Ripple,
    Angle = 180,
    HorizontalOptions = LayoutOptions.Center
};

var stackLayout = new HorizontalStackLayout
{
    Spacing = -4,
    Children =
    {
        new Label
        {
            Text = "↑",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Start
        },

        new Label
        {
            Text = "↓",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.End,
            Margin = new Thickness(0, 8, 0, 0)
        }
    }
};

effectsView.Content = stackLayout;
border.Content = effectsView;
this.Content = border;

{% endhighlight %}

{% endtabs %}

## See also

- [Scale](https://help.syncfusion.com/maui/effects-view/effects/scale) 
- [Highlight](https://help.syncfusion.com/maui/effects-view/effects/highlight) 
- [Combining Effects](https://help.syncfusion.com/maui/effects-view/effects/combinations)