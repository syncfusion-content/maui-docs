---
layout: post
title: Methods in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the methods available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Methods

Effects can be applied and removed programmatically using the [ApplyEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_System_Nullable_System_Drawing_Point__System_Boolean_) and [Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset) methods.

> **Note**
>
> Effects applied through the `ApplyEffects` method are not removed automatically. Call `ResetEffects` to return the view to its rest state.

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` and `using Microsoft.Maui.Controls;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

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

#### XAML

```xaml
<VerticalStackLayout Padding="10" Spacing="10">
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
                    <GradientStop Color="#FF6B6B" Offset="0.0" />
                    <GradientStop Color="#4ECDC4" Offset="1.0" />
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
```

#### C#

```csharp

private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Ripple, rippleStartPosition: RippleStartPosition.TopLeft);
    }
}

```

### Apply a Ripple at a Custom Point

Use `rippleStartPoint` to start the ripple at specific coordinates inside the view.

#### XAML

```xaml
<VerticalStackLayout Padding="10" Spacing="10">
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
                    <GradientStop Color="#FF6B6B" Offset="0.0" />
                    <GradientStop Color="#4ECDC4" Offset="1.0" />
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
```

#### C#

```csharp
private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Ripple, rippleStartPoint: new System.Drawing.Point(50, 75));
    }
}
```

### Repeat the Ripple

Set `repeat: true` to keep the ripple animating until `ResetEffects` is called.

#### XAML

```xaml
<VerticalStackLayout Padding="10" Spacing="10">
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
                    <GradientStop Color="#FF6B6B" Offset="0.0" />
                    <GradientStop Color="#4ECDC4" Offset="1.0" />
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
```

#### C#

```csharp
private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Ripple, repeat: true);
    }
}
```

### Apply Multiple Effects

You can pass a bitwise combination of effects to apply more than one at a time.

#### XAML

```xaml
<VerticalStackLayout Padding="10" Spacing="10">
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
                    <GradientStop Color="#FF6B6B" Offset="0.0" />
                    <GradientStop Color="#4ECDC4" Offset="1.0" />
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
```

#### C#

```csharp
private void applyEffects_Button_Clicked(object sender, EventArgs e)
{
    if (effectsView != null)
    {
        effectsView.ApplyEffects(effects: SfEffects.Highlight | SfEffects.Ripple);
    }
}
```

## ResetEffects

The [Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset) method clears any effect previously applied through `ApplyEffects`, returning the `SfEffectsView` to its rest state. The method takes no parameters and returns `void`.

> **Note**
>
> `Reset` only clears effects started by `ApplyEffects`. Effects started by the touch triggers (`TouchDownEffects`, `TouchUpEffects`, `LongPressEffects`, `Effects`) and the persistent `Selection` state are not affected.

### Apply and Reset

#### XAML

```xaml
<VerticalStackLayout Padding="10" Spacing="10" >
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
                    <GradientStop Color="#FF6B6B" Offset="0.0" />
                    <GradientStop Color="#4ECDC4" Offset="1.0" />
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
```

#### C#

```csharp
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
```

## Troubleshooting

- If `ApplyEffects` has no visible effect, confirm the `SfEffectsView` has a non-zero `Width` and `Height` and that the effect's background brush (for example, `RippleBackground`) is set to a non-null `Brush`.
- If `repeat: true` does not loop the effect, ensure you are passing `SfEffects.Ripple`; other effects ignore the `repeat` parameter.
- If `ResetEffects` appears to do nothing, confirm the effect was originally started by `ApplyEffects`; `ResetEffects` does not clear `Selection` or touch-triggered effects.
- If you pass `effects: SfEffects.None`, no effect is applied and no error is raised.
