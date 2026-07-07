---
layout: post
title: Hiding Prompt Characters in .NET MAUI Masked Entry | Syncfusion®
description: Learn about hiding prompt characters support in Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Hiding Prompt Characters in .NET MAUI Masked Entry

## Prerequisites

Before using the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), ensure the following are set up:

1. Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package in your .NET MAUI project.
2. Register the Syncfusion license in your application. Refer to the [Syncfusion licensing documentation](https://help.syncfusion.com/maui/licensing/overview) for more details.

    ```csharp
    using Syncfusion.Licensing;

    public class App : Application
    {
        public App()
        {
            // Replace the license key with your own.
            SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
            InitializeComponent();
        }
    }
    ```

3. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs`:

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

4. Add the following namespace declaration to your XAML page and `using` directive to your C# files:

    ```xml
    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    ```

    ```csharp
    using Syncfusion.Maui.Inputs;
    ```

For a step-by-step setup, refer to the [Getting Started](getting-started.md) documentation.

## Overview

The [HidePromptOnLeave](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HidePromptOnLeave) property of type `bool` controls whether unfilled prompt positions are displayed when the control does not have focus. The default value is `false`, which means prompt characters are always shown. When set to `true`, prompt characters are hidden when the control loses focus and restored when the control regains focus.

The control is considered to have lost focus when the user taps outside the entry, navigates to another input, or moves focus programmatically via the `Unfocused` event. To programmatically focus the entry and restore the prompt, call `maskedEntry.Focus()`.

> **Note:** Unlike setting [PromptChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PromptChar) to a space character, `HidePromptOnLeave` only hides the prompt when the control is unfocused and does not affect the value of the unfilled positions.

## Setting HidePromptOnLeave

The following example demonstrates how to hide prompt characters when the Masked Entry control loses focus:

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       Placeholder="Enter here"
                       MaskType="Simple"
                       Mask="00/00/0000"
                       PromptChar="#"
                       HidePromptOnLeave="True"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    Placeholder = "Enter here",
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "00/00/0000",
    PromptChar = '#',
    HidePromptOnLeave = true
};

{% endhighlight %}
{% endtabs %}

The following GIF shows the `HidePromptOnLeave` behavior: prompt characters are visible while the control is focused, and hidden when the control loses focus.

![HidePromptOnLeave](MaskedEntry_Images/maui_masked_entry_HidePromptOnLeave.gif)

## See Also

* [Getting Started with .NET MAUI Masked Entry](getting-started.md)
* [Basic Features in .NET MAUI Masked Entry](basic-features.md)
* [Formatting Value in .NET MAUI Masked Entry](formatting-value.md)
* [Events in .NET MAUI Masked Entry](events.md)
* [SfMaskedEntry API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html)