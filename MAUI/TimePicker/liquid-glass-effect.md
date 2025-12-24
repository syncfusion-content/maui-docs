---
layout: post
title: Liquid Glass Support for .NET MAUI Time Picker | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Time Picker using SfGlassEffectsView.
platform: MAUI
control: SfTimePicker
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Time Picker (SfTimePicker)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Time Picker (SfTimePicker) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Time Picker control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI [Time Picker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) control, wrap the control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.

For more details, refer to the [Liquid Glass Getting Started documentation](https://help.syncfusion.com/maui/liquid-glass-ui/getting-started).

### Step 2: Enable the liquid glass effect on Time Picker

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLiquidGlassEffect) property to `true` in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Time Picker, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:timepicker="clr-namespace:Syncfusion.Maui.TimePicker;assembly=Syncfusion.Maui.TimePicker"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicTimePickerPage">
    <Grid>
        <Grid.Background>
            <LinearGradientBrush StartPoint="0,0"
                                 EndPoint="0,1">
                <GradientStop Color="#0F4C75"
                              Offset="0.0"/>
                <GradientStop Color="#3282B8"
                              Offset="0.5"/>
                <GradientStop Color="#1B262C"
                              Offset="1.0"/>
            </LinearGradientBrush>
        </Grid.Background>
        <Grid>
            <core:SfGlassEffectView
                EffectType="Regular"
                CornerRadius="20"
                WidthRequest="350"
                HeightRequest="350">
                <picker:SfTimePicker x:Name="picker"
                                     EnableLiquidGlassEffect="True"
                                     Background="Transparent">
                    <picker:SfTimePicker.ColumnHeaderView>
                        <picker:TimePickerColumnHeaderView Background="Transparent"/>
                    </picker:SfTimePicker.ColumnHeaderView>
                </picker:SfTimePicker>
            </core:SfGlassEffectView>
        </Grid>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

// Outer grid with gradient background
var mainGrid = new Grid()
{
    Background = new LinearGradientBrush()
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(0, 1),
        GradientStops =
        {
            new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0f },
            new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5f },
            new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0f }
        }
    }
};

// Inner grid container
var innerGrid = new Grid();

var glassView = new SfGlassEffectView()
{
    EffectType = GlassEffectType.Regular,
    CornerRadius = 20,
    WidthRequest = 350,
    HeightRequest = 350
};

var timePicker = new SfTimePicker()
{
    EnableLiquidGlassEffect = true,
    Background = Colors.Transparent,
    WidthRequest = 350,
    HeightRequest = 350,
    ColumnHeaderView = new TimePickerColumnHeaderView()
    {
        Background = Colors.Transparent
    }
};

glassView.Content = timePicker;
innerGrid.Children.Add(glassView);
mainGrid.Children.Add(innerGrid);
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![Liquid glass effect in .NET MAUI Time Picker](images/liquid-glass/maui-time-picker-liquid-glass.webp)

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
