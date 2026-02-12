---
layout: post
title: Liquid Glass Support for AI-Powered Text Editor | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI AI-Powered Text Editor using SfGlassEffectsView.
platform: MAUI
control: SfSmartTextEditor
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Smart Text Editor

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI AI-Powered Text Editor control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the AI-Powered Text Editor control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI [SfSmartTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html) control, wrap the control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.

For more details, refer to the [Liquid Glass Getting Started documentation](https://help.syncfusion.com/maui/liquid-glass-ui/getting-started).

### Step 2: Enable the liquid glass effect on Smart Text Editor

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_EnableLiquidGlassEffect) property to `true` in the [SfSmartTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html) control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Smart Text Editor, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfSmartTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html) control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:smarttexteditor="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicSmartTextEditorPage">
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
                CornerRadius="15"
                WidthRequest="350"
                HeightRequest="200">
                <smarttexteditor:SfSmartTextEditor
                    x:Name="smartTextEditor"
                    EnableLiquidGlassEffect="True"
                    Background="Transparent"
                    SuggestionDisplayMode="Popup"
                    Placeholder="Type your reply..."
                    UserRole="Support engineer responding to customer tickets">
                    <smarttexteditor:SfSmartTextEditor.UserPhrases>
                        <x:String>Thanks for reaching out.</x:String>
                        <x:String>Please share a minimal reproducible sample.</x:String>
                        <x:String>We’ll update you as soon as we have more details.</x:String>
                    </smarttexteditor:SfSmartTextEditor.UserPhrases>
                </smarttexteditor:SfSmartTextEditor>
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

var glassView = new SfGlassEffectsView()
{
    CornerRadius = 15,
    EffectType = LiquidGlassEffectType.Regular,
    WidthRequest = 350;
    HeightRequest = 200;
};

var smartTextEditor = new SfSmartTextEditor();
smartTextEditor.EnableLiquidGlassEffect = true;
smartTextEditor.Background = Colors.Transparent;
smartTextEditor.SuggestionDisplayMode = SuggestionDisplayMode.Popup;
smartTextEditor.UserRole = "Support engineer responding to customer tickets";

glassView.Content = smartTextEditor;
innerGrid.Children.Add(glassView);
mainGrid.Children.Add(innerGrid);
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`