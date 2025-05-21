---
layout: post
title: Validation in .NET MAUI MaskedEntry control | Syncfusion®
description: Learn all about validation support in Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug 
---
# Validation in .NET MAUI Masked Entry (SfMaskedEntry)

## Validation Mode

Input validation is determined by the [ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValidationMode) property. The possible enum values are:

* KeyPress
* LostFocus

The default value for validation mode is [KeyPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html#Syncfusion_Maui_Inputs_InputValidationMode_KeyPress).

{% tabs %}
{% highlight xaml %}
<editors:SfMaskedEntry x:Name="maskedEntry"
                        WidthRequest="200"
                        MaskType="Simple" Mask="00/00/0000" ValidationMode="KeyPress"/>
{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.ValidationMode = InputValidationMode.KeyPress;

{% endhighlight %}
{% endtabs %}

When `ValidationMode` is set to [LostFocus](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html#Syncfusion_Maui_Inputs_InputValidationMode_LostFocus), validation occurs when the control loses focus. With [KeyPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html#Syncfusion_Maui_Inputs_InputValidationMode_KeyPress), validation triggers on each key press.

## HasError

The `HasError` property is read-only and used to verify if validation is successful. It returns `true` if validation succeeds; otherwise, it returns `false`. The following code demonstrates the usage of the [HasError](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HasError) property.

{% tabs %}
{% highlight c# %}
SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.ValidationMode = InputValidationMode.LostFocus;
maskedEntry.ValueChanged += maskedEntry_ValueChanged;

 private void maskedEntry_ValueChanged(object sender, Syncfusion.Maui.Inputs.MaskedEntryValueChangedEventArgs e)
 {
     SfMaskedEntry maskedEntry = sender as SfMaskedEntry;
     if (maskedEntry.HasError)
     {
         DisplayAlert("Alert", "Please enter valid details", "OK");
     }
 }
{% endhighlight %}
{% endtabs %}

![HasError](MaskedEntry_Images/MaskedEntry_HasError.png)
