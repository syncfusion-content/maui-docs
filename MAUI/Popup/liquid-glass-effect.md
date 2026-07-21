---
layout: post
title: Liquid Glass Effect for .NET MAUI Popup | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Popup (SfPopup) control.
platform: MAUI
control: SfPopup
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Popup (SfPopup)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Popup (SfPopup) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Popup control:

### Step 1: Enable the liquid glass effect on Popup

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_EnableLiquidGlassEffect) property to `true` on the [SfPopup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html) control to apply the Liquid Glass Effect. When enabled, the effect is also applied to popup view and dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 2: Customize the background

To achieve a glass-like popup background, the popup becomes transparent by default when the Liquid Glass Effect is enabled. The background is then treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to configure the `SfPopup` with the Liquid Glass Effect enabled:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:popup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="LiquidGlassPopupSample.MainPage">
    <StackLayout x:Name="mainLayout" Padding="0,100,0,0">
        <popup:SfPopup x:Name="alertWithTitle"
                       EnableLiquidGlassEffect="True"
                       ShowHeader="True"
                       ShowFooter="True"
                       AppearanceMode="TwoButton"
                       WidthRequest="312"
                       HeightRequest="232"
                       HeaderHeight="104"
                       FooterHeight="88">
        </popup:SfPopup>
    </StackLayout>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="17" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Popup;

public class MainPage : ContentPage
{
    private readonly SfPopup alertWithTitle;

    public MainPage()
    {
        // Create the main StackLayout
        var mainLayout = new StackLayout
        {
            Padding = new Thickness(0, 100, 0, 0)
        };

        // Create the SfPopup
        alertWithTitle = new SfPopup
        {
            EnableLiquidGlassEffect = true,
            ShowHeader = true,
            ShowFooter = true,
            AppearanceMode = PopupButtonAppearanceMode.TwoButton,
            WidthRequest = 312,
            HeightRequest = 232,
            HeaderHeight = 104,
            FooterHeight = 88
        };

        // Add popup to layout
        mainLayout.Children.Add(alertWithTitle);

        // Set the Content of the page
        Content = mainLayout;
    }

    // Open the popup once the page is shown
    protected override void OnAppearing()
    {
        base.OnAppearing();
        alertWithTitle.IsOpen = true;
    }
}

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10`.