---
layout: post
title: Validation in .NET MAUI Masked Entry control | Syncfusion®
description: Learn about the validation support in the Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control, including ValidationMode and HasError.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Validation in .NET MAUI Masked Entry

The [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control validates user input against the configured `Mask` and exposes the result through the [HasError](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HasError) property. Use the [ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValidationMode) property to choose when validation is performed.

## Prerequisites

Before using the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/masked-entry/getting-started) documentation.

## Validation Mode

Use the [ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValidationMode) property of type [InputValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html) to choose when the input is validated. The available enum values are:

- [`KeyPress`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html#Syncfusion_Maui_Inputs_InputValidationMode_KeyPress): validation is triggered for each key press.
- [`LostFocus`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html#Syncfusion_Maui_Inputs_InputValidationMode_LostFocus): validation is performed only when the control loses focus.

The default value is `KeyPress`. The selected mode works the same for both `Simple` and `RegEx` [MaskType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_MaskType) values.

{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="200"
                       MaskType="Simple"
                       Mask="00/00/0000"
                       ValidationMode="KeyPress"/>

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "00/00/0000",
    ValidationMode = InputValidationMode.KeyPress
};

{% endhighlight %}
{% endtabs %}

## HasError

The [HasError](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HasError) property of type `bool` indicates the result of the most recent validation. It is a read-only property that returns `true` when validation **fails** and `false` when validation succeeds. The property is updated only after a `ValueChanged` event, so check it inside the event handler (or use a `Binding` to react to the change in MVVM scenarios).

The following example shows how to surface the validation result in the UI.

{% tabs %}
{% highlight XAML %}
<VerticalStackLayout>
    <editors:SfMaskedEntry x:Name="maskedEntry"
                           WidthRequest="200"
                           MaskType="Simple"
                           Mask="00/00/0000"
                           ValueChanged = "MaskedEntry_ValueChanged"
                           ValidationMode="LostFocus"/>
    <Label Text="Please enter a valid date."
           TextColor="Red"
           IsVisible="{Binding HasError, Source={x:Reference maskedEntry}}"/>
</VerticalStackLayout>
{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    Mask = "00/00/0000",
    ValidationMode = InputValidationMode.LostFocus
};

maskedEntry.ValueChanged += MaskedEntry_ValueChanged;

{% endhighlight %}
{% endtabs %}

{% tabs %}

The ValueChanged event can be handled in C# as follows:

{% highlight C# %}

private void MaskedEntry_ValueChanged(object sender, MaskedEntryValueChangedEventArgs e)
{
    if (sender is SfMaskedEntry entry && entry.HasError)
    {
        var page = Application.Current?.Windows[0]?.Page;
        page?.DisplayAlert("Alert", "Please enter valid details", "OK");
    }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates an invalid input that triggers `HasError = true`:

![HasError](MaskedEntry_Images/MaskedEntry_HasError.png)

## See Also

* [Getting Started](https://help.syncfusion.com/maui/masked-entry/getting-started)
* [Basic Features](https://help.syncfusion.com/maui/masked-entry/basic-features)
* [Mask Types](https://help.syncfusion.com/maui/masked-entry/mask-types)
* [Formatting Value](https://help.syncfusion.com/maui/masked-entry/formatting-value)
