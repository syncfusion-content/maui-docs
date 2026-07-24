---
layout: post
title: Methods in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the methods available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Methods in .NET MAUI Effects View

## Prerequisites

Before using the [`SfEffectsView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/effects-view/getting-started) documentation.

Effects can be applied and removed programmatically using the [ApplyEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_System_Nullable_System_Drawing_Point__System_Boolean_) and [Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset) methods.

## ApplyEffects

The [ApplyEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_System_Nullable_System_Drawing_Point__System_Boolean_) method starts an effect on the `SfEffectsView`, optionally repeating it. The method returns `void`.

### Parameters

| Parameter | Type | Default | Description |
| --- | --- | --- | --- |
| `effects` | [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) | `SfEffects.Ripple` | The effect to apply. Pass a single value or a bitwise combination (for example, `SfEffects.Highlight \| SfEffects.Ripple`). |
| `rippleStartPosition` | [RippleStartPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.RippleStartPosition.html) | `RippleStartPosition.Default` | The starting edge or corner of the ripple. One of `Left`, `Top`, `Right`, `Bottom`, `TopLeft`, `TopRight`, `BottomLeft`, `BottomRight`, or `Default`. |
| `rippleStartPoint` | `Microsoft.Maui.Graphics.Point?` | `null` | The point at which the ripple animation starts. When `null`, the ripple starts from the position determined by `rippleStartPosition`. |
| `repeat` | `bool` | `false` | Indicates whether to repeat the effect. Only `SfEffects.Ripple` can be repeated; other effects ignore this value. |



### Apply a Ripple from a Button

The example below triggers a ripple from the top-left corner when the user clicks a button.

#{% tabs %} 

{% highlight xaml %}

<VerticalStackLayout Padding="10" 
                     Spacing="10">
    <syncEffectsView:SfEffectsView x:Name="effectsView"
                                   HorizontalOptions="Center" 
                                   VerticalOptions="Center"
                                   RippleBackground="Red">
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

    <Button x:Name="applyEffects_Button"
            Text="Apply Effect" 
            WidthRequest="120"
            HeightRequest="40"
            Clicked="applyEffects_Button_Clicked"/>
</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Ripple, rippleStartPosition: RippleStartPosition.TopLeft);
    }
}

{% endhighlight %}

{% endtabs %}

### Apply a Ripple at a Custom Point

Use `rippleStartPoint` to start the ripple at specific coordinates inside the view.

#{% tabs %} 

{% highlight xaml %}

<VerticalStackLayout Padding="10" 
                     Spacing="10">
    <syncEffectsView:SfEffectsView x:Name="effectsView"
                                   HorizontalOptions="Center" 
                                   VerticalOptions="Center"
                                   RippleBackground="Red">
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

    <Button x:Name="applyEffects_Button"
            Text="Apply Effect" 
            WidthRequest="120"
            HeightRequest="40"
            Clicked="applyEffects_Button_Clicked"/>
</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Ripple, rippleStartPoint: new System.Drawing.Point(50, 75));
    }
}

{% endhighlight %}

{% endtabs %}

### Repeat the Ripple

Set `repeat: true` to keep the ripple animating until `ResetEffects` is called.

#{% tabs %} 

{% highlight xaml %}

<VerticalStackLayout Padding="10" 
                     Spacing="10">
    <syncEffectsView:SfEffectsView x:Name="effectsView"
                                   HorizontalOptions="Center" 
                                   VerticalOptions="Center"
                                   RippleBackground="Red">
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

    <Button x:Name="applyEffects_Button"
            Text="Apply Effect" 
            WidthRequest="120"
            HeightRequest="40"
            Clicked="applyEffects_Button_Clicked"/>
</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Ripple, repeat: true);
    }
}

{% endhighlight %}

{% endtabs %}

### Apply Multiple Effects

You can pass a bitwise combination of effects to apply more than one at a time.

#{% tabs %} 

{% highlight xaml %}

<VerticalStackLayout Padding="10" 
                     Spacing="10">
    <syncEffectsView:SfEffectsView x:Name="effectsView"
                                   HorizontalOptions="Center" 
                                   VerticalOptions="Center"
                                   RippleBackground="Red">
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

    <Button x:Name="applyEffects_Button"
            Text="Apply Effect" 
            WidthRequest="120"
            HeightRequest="40"
            Clicked="applyEffects_Button_Clicked"/>
</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Highlight | SfEffects.Ripple);
    }
}

{% endhighlight %}

{% endtabs %}

## ResetEffects

The [Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset) method clears any effect previously applied through `ApplyEffects`, returning the `SfEffectsView` to its rest state. The method takes no parameters and returns `void`.

N> `Reset` only clears effects started by `ApplyEffects`. Effects started by the touch triggers (`TouchDownEffects`, `TouchUpEffects`, `LongPressEffects`, `Effects`) and the persistent `Selection` state are not affected.

### Apply and Reset

#{% tabs %} 

{% highlight xaml %}

<VerticalStackLayout Padding="10" 
                     Spacing="10" >
    <syncEffectsView:SfEffectsView x:Name="effectsView"
                                   HorizontalOptions="Center" 
                                   VerticalOptions="Center"
                                   RippleBackground="Red">
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
    <HorizontalStackLayout Spacing="8"
                           HorizontalOptions="Center">
        <Button x:Name="applyEffects_Button"
                Text="Apply Effect" 
                WidthRequest="120"
                HeightRequest="40"
                Clicked="applyEffects_Button_Clicked"/>
        <Button x:Name="reset_Button"
                Text="Reset"
                WidthRequest="80"
                HeightRequest="40"
                Clicked="reset_Button_Clicked"/>
    </HorizontalStackLayout>
</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

private void reset_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.Reset();
    }
}

private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects( effects: SfEffects.Ripple, repeat: true );
    }
}

{% endhighlight %}

{% endtabs %}

## See also

- [Events](https://help.syncfusion.com/maui/effects-view/events) covers the `AnimationCompleted` event that signals when a programmatically applied effect finishes.  
- [Commands](https://help.syncfusion.com/maui/effects-view/commands) shows the `ICommand` properties that can also be used to react to user interactions.  
- [Interaction](https://help.syncfusion.com/maui/effects-view/interaction) explains the trigger properties that determine when an effect runs without calling `ApplyEffects` directly.
