---
layout: post
title: Liquid Glass Effect in .NET MAUI ComboBox | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, liquid glass combobox, maui glass effect, acrylic combobox.
---

# Liquid Glass Effect in .NET MAUI ComboBox

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control.

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later and the .NET MAUI workload. The Liquid Glass Effect is supported only on .NET 10 or later. For setup details, see [Install .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-10.0).
2. The Liquid Glass Effect is supported only on iOS 26 and macOS 26 or later. Android and Windows are not supported; the effect is ignored on those platforms.
3. Create a [.NET MAUI project](Getting-Started.md#step-1-create-a-new-net-maui-project).
4. Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package (version 26.1.35 or later) in your .NET MAUI project.
5. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs`:

    ```csharp
    using Syncfusion.Maui.Core.Hosting;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
    ```

6. Add the following namespace declarations to your XAML page and `using` directives to your C# files:

    ```xml
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    ```

    ```csharp
    using Syncfusion.Maui.Core;
    using Syncfusion.Maui.Inputs;
    ```

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation. For more details on the Liquid Glass Effect, see [Liquid Glass UI Overview](../Liquid-Glass-UI/Overview.md).

## Apply Liquid Glass Effect

Follow these steps to enable and configure the Liquid Glass Effect in the ComboBox control.

### Step 1: Wrap the control inside SfGlassEffectView

To apply the Liquid Glass Effect to the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control, wrap it inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class. The glass effect is applied to the wrapped content and any popups it opens (such as the drop-down).

For more details, see [Liquid Glass UI Overview](../Liquid-Glass-UI/Overview.md).

### Step 2: Enable the Liquid Glass Effect on the ComboBox

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_EnableLiquidGlassEffect) `bool` property to `true` on the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control. The default value is `false`. When enabled, the effect is also applied to the drop-down popup for a consistent glass-like appearance.

### Step 3: Customize the background

To achieve a glass-like background, set the `Background` and `DropDownBackground` properties of the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) to `Transparent`. The background is then treated as a tinted color, ensuring a consistent glass effect across the editor and the drop-down.

## Define the model and view model

The samples below use the `SocialMedia` model and `SocialMediaViewModel` defined in [Getting Started](Getting-Started.md#step-4-define-model-and-view-model). Add an image named `Wallpaper.png` to your project resources to use as the background.

## Example

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid BackgroundColor="Transparent">
    <Image Source="Wallpaper.png"
           Aspect="AspectFill" />

    <core:SfGlassEffectView EffectType="Regular"
                            CornerRadius="20">
        <editors:SfComboBox x:Name="comboBox"
                            Background="Transparent"
                            DropDownBackground="Transparent"
                            EnableLiquidGlassEffect="True"
                            ItemsSource="{Binding SocialMedias}">
            <editors:SfComboBox.BindingContext>
                <local:SocialMediaViewModel />
            </editors:SfComboBox.BindingContext>
        </editors:SfComboBox>
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Inputs;

// Run this code in a ContentPage code-behind file.
SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

var grid = new Grid
{
    BackgroundColor = Colors.Transparent,
};

var image = new Image
{
    Source = "Wallpaper.png",
    Aspect = Aspect.AspectFill,
};
grid.Children.Add(image);

var glass = new SfGlassEffectView
{
    EffectType = LiquidGlassEffectType.Regular,
    CornerRadius = 20,
};

var comboBox = new SfComboBox
{
    Background = Colors.Transparent,
    DropDownBackground = Colors.Transparent,
    EnableLiquidGlassEffect = true,
    ItemsSource = socialMediaViewModel.SocialMedias,
    BindingContext = socialMediaViewModel,
};

glass.Content = comboBox;
grid.Children.Add(glass);
Content = grid;

{% endhighlight %}
{% endtabs %}

The following image illustrates the SfComboBox inside an acrylic container, with the drop-down using the glass effect.

![.NET MAUI ComboBox with Liquid Glass Effect](Images/UICustomization/Combobox_liquidglass.png)

N> The Liquid Glass Effect is supported only on .NET 10 or later, iOS 26 or later, and macOS 26 or later. On unsupported platforms, the effect is ignored and the ComboBox renders with its default appearance.

N> If `Background` or `DropDownBackground` is not set to `Transparent`, the glass effect may not render correctly. Both must be `Transparent` for the underlying content to show through the tinted glass.

## See Also

* [Liquid Glass UI Overview](../Liquid-Glass-UI/Overview.md)
* [Header and footer in .NET MAUI ComboBox](Header-and-Footer.md)
* [UI customization in .NET MAUI ComboBox](UI-Customization.md)
* [Overview of .NET MAUI ComboBox](Overview.md)
* [SfComboBox API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html)