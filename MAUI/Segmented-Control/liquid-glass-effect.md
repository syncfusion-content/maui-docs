---
layout: post
title: Liquid Glass Support for .NET MAUI Segmented control | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI Segmented control.
platform: maui
control: SfSegmentedControl
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Segmented control (SfSegmentedControl)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® [.NET MAUI Segmented control (SfSegmentedControl)](https://www.syncfusion.com/maui-controls/maui-segmented-control) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Segmented control control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® [.NET MAUI Segmented control (SfSegmentedControl)](https://www.syncfusion.com/maui-controls/maui-segmented-control) control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Segmented control

Set the `EnableLiquidGlassEffect` property to `true` in the [SfSegmentedControl](https://www.syncfusion.com/maui-controls/maui-segmented-control) control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Segmented Control, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfSegmentedControl` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                 EndPoint="0,1">
            <GradientStop Color="#0F4C75"
              Offset="0.0" />
            <GradientStop Color="#3282B8"
              Offset="0.5" />
            <GradientStop Color="#1B262C"
              Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
    <StackLayout>
        <core:SfGlassEffectView HeightRequest="18"
                    CornerRadius="9"
                    EffectType="Clear">
            <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    EnableLiquidGlassEffect="True"
                                    Margin="5"
                                    BackgroundColor="Transparent" >
                <buttons:SfSegmentedControl.ItemsSource>
                    <x:Array Type="{x:Type x:String}">
                        <x:String>Day</x:String>
                        <x:String>Week</x:String>
                        <x:String>Month</x:String>
                        <x:String>Year</x:String>
                    </x:Array>
                </buttons:SfSegmentedControl.ItemsSource>
            </buttons:SfSegmentedControl>
        </core:SfGlassEffectView>
    </StackLayout>
</Grid>
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

var gradientBrush = new LinearGradientBrush
{
    StartPoint = new Point(0, 0),
    EndPoint = new Point(0, 1),
    GradientStops = new GradientStopCollection
    {
        new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0f },
        new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5f },
        new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0f }
    }
};

var grid = new Grid
{
    Background = gradientBrush
};

var stackLayout = new StackLayout();
var glassView = new SfGlassEffectView
{
    CornerRadius = 9,
    EffectType = LiquidGlassEffectType.Clear
};

var segmentedControl = new SfSegmentedControl
{
    Margin = new Thickness(5),
    BackgroundColor = Colors.Transparent,
    ItemsSource = new List<SfSegmentItem>
    {
        new SfSegmentItem() {Text = "Day"},
        new SfSegmentItem() {Text = "Week"},
        new SfSegmentItem() {Text = "Month"},
        new SfSegmentItem() {Text = "Year"},
    }
};

glassView.Content = segmentedControl;
stackLayout.Children.Add(glassView);
grid.Children.Add(stackLayout);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
