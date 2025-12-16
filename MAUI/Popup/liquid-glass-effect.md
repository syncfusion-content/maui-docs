---
layout: post
title: Liquid Glass Effect for .NET MAUI Popup | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Popup (SfPopup) control.
platform: MAUI
control: SfPopup
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Popup (SfPopup)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Popup (SfPopup) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Popup control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `Popup` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Popup

Set the `EnableLiquidGlassEffect` property to `true` in the `SfPopup` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Popup and its Toolbar control, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfPopup` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}
  <StackLayout x:Name="mainLayout" Padding="0,100,0,0">
     <popup:SfPopup x:Name="alertWithTitle" EnableLiquidGlassEffect="True" ShowHeader="True" ShowFooter="True" AppearanceMode="TwoButton" 
         WidthRequest="312" HeightRequest="232" HeaderHeight="104" FooterHeight="88" IsOpen="True"
         >
     </popup:SfPopup>
 </StackLayout>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}



using Microsoft.Maui.Controls;
using Syncfusion.Maui.Popup;

public class MainPage : ContentPage
{
    public MainPage()
    {
        // Create the main StackLayout
        var mainLayout = new StackLayout
        {
            Padding = new Thickness(0, 100, 0, 0)
        };

        // Create the SfPopup
        var alertWithTitle = new SfPopup
        {
            EnableLiquidGlassEffect = true,
            ShowHeader = true,
            ShowFooter = true,
            AppearanceMode = PopupAppearanceMode.TwoButton,
            WidthRequest = 312,
            HeightRequest = 232,
            HeaderHeight = 104,
            FooterHeight = 88,
            IsOpen = true
        };

        // Add popup to layout
        mainLayout.Children.Add(alertWithTitle);

        // Set the Content of the page
        Content = mainLayout;
    }
}


{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`