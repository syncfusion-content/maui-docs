---
layout: post
title: Events in .NET MAUI Masked Entry control | Syncfusion®
description: Learn about the events available in Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control, including ValueChanging, ValueChanged, Completed, and ClearButtonClicked.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Events in .NET MAUI Masked Entry

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

This section provides information about the events available in the .NET MAUI Masked Entry control. Events are typically subscribed in the page constructor or in code-behind, and are raised on the UI thread.

The events fire in the following order when the user enters a value:

1. `ValueChanging` — raised before the value is committed, and is cancelable.
2. `ValueChanged` — raised after the value is committed.
3. `Completed` — raised when the user finalizes text by pressing the return key.
4. `ClearButtonClicked` — raised when the user taps the clear button.

## ValueChanging Event

The [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueChanging) event is raised when the `Value` property is about to change in the Masked Entry control, for example on each keystroke that modifies the value. The event handler receives a [MaskedEntryValueChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryValueChangingEventArgs.html) instance that provides the following properties:

* `NewValue` (`object`): Gets the newly entered value that is about to be committed.
* `OldValue` (`object`): Gets the previous value before the change.
* `IsValid` (`bool`): Gets a boolean value indicating whether the input is considered valid based on the mask completion.
* `Cancel` (`bool`): Gets or sets a value indicating whether the change should be canceled. When set to `true`, the `Value` property is not updated.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="200"
                       MaskType="Simple"
                       Mask="(000) 000-0000"
                       ValueChanging="MaskedEntry_ValueChanging"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "(000) 000-0000"
};
maskedEntry.ValueChanging += MaskedEntry_ValueChanging;

{% endhighlight %}
{% endtabs %}

The `ValueChanging` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void MaskedEntry_ValueChanging(object sender, MaskedEntryValueChangingEventArgs e)
{
    // Access the new and old values
    string newValue = e.NewValue?.ToString();
    string oldValue = e.OldValue?.ToString();

    // Check the validity of the input
    bool isValid = e.IsValid;

    // Cancel the event if the new value is not allowed
    if (!e.IsValid)
    {
        e.Cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}

## ValueChanged Event

The [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueChanged) event is raised after the `Value` property is changed in the Masked Entry control. The event handler receives a [MaskedEntryValueChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryValueChangedEventArgs.html) instance that provides the following properties:

* `IsMaskCompleted` (`bool`): Gets a boolean value indicating whether all the required inputs for the mask are completed.
* `NewValue` (`object`): Gets the newly committed value.
* `OldValue` (`object`): Gets the previous value before the change.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="200"
                       MaskType="Simple"
                       Mask="(000) 000-0000"
                       ValueChanged="MaskedEntry_ValueChanged"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "(000) 000-0000"
};
maskedEntry.ValueChanged += MaskedEntry_ValueChanged;

{% endhighlight %}
{% endtabs %}

The `ValueChanged` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void MaskedEntry_ValueChanged(object sender, MaskedEntryValueChangedEventArgs e)
{
    // Access the new and old values
    string maskNewValue = e.NewValue?.ToString();
    string maskOldValue = e.OldValue?.ToString();
    if (e.IsMaskCompleted)
    {
        // Handle the case when the mask is completed
    }
}

{% endhighlight %}
{% endtabs %}

## Completed Event

The [Completed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Completed) event is raised when the user finalizes the text in the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) editable mode by pressing the return key on the keyboard. The handler for the event is a generic `EventHandler`, taking the `sender` and `EventArgs` (the `EventArgs` value is `EventArgs.Empty`):

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="200"
                       MaskType="Simple"
                       Mask="(000) 000-0000"
                       Completed="MaskedEntry_Completed"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "(000) 000-0000"
};
maskedEntry.Completed += MaskedEntry_Completed;

{% endhighlight %}
{% endtabs %}

The `Completed` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void MaskedEntry_Completed(object sender, EventArgs e)
{
    // Place this handler in the code-behind of a ContentPage,
    // or resolve the current page via Application.Current?.Windows[0]?.Page.
    var page = Application.Current?.Windows[0]?.Page;
    page?.DisplayAlert("Message", "Text entering Completed", "ok");
}

{% endhighlight %}
{% endtabs %}


## ClearButtonClicked Event

The [ClearButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ClearButtonClicked) event is raised when the user activates the clear button in the `SfMaskedEntry` editable mode by tapping the clear button. The handler for the event is a generic `EventHandler`, taking the `sender` and `EventArgs`.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="200"
                       MaskType="Simple"
                       Mask="(000) 000-0000"
                       ClearButtonVisibility="WhileEditing"
                       ClearButtonClicked="MaskedEntry_ClearButtonClicked"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "(000) 000-0000",
    ClearButtonVisibility = ClearButtonVisibility.WhileEditing
};
maskedEntry.ClearButtonClicked += MaskedEntry_ClearButtonClicked;

{% endhighlight %}
{% endtabs %}

The `ClearButtonClicked` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void MaskedEntry_ClearButtonClicked(object sender, EventArgs e)
{
    // Place this handler in the code-behind of a ContentPage,
    // or resolve the current page via Application.Current?.Windows[0]?.Page.
    var page = Application.Current?.Windows[0]?.Page;
    page?.DisplayAlert("Message", "Clear Button Clicked", "ok");
}

{% endhighlight %}
{% endtabs %}

## See Also

* [Getting Started with .NET MAUI Masked Entry](getting-started.md)
* [Basic Features in .NET MAUI Masked Entry](basic-features.md)
* [SfMaskedEntry API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html)
