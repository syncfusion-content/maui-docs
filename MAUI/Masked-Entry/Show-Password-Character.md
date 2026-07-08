---
layout: post
title: Show Password Character in .NET MAUI Masked Entry control | Syncfusion®
description: Learn how to show password characters using the Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control with the PasswordChar and PasswordDelayDuration properties.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Show Password Character in .NET MAUI Masked Entry

The SfMaskedEntry control can be used as a password text box by setting a character for the [PasswordChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordChar) property. To improve the user experience, the most-recently typed character can remain visible briefly before being masked by using the [PasswordDelayDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordDelayDuration) property.

## Prerequisites

Before using the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package in your .NET MAUI project.

For a step-by-step setup, refer to the [Getting Started](getting-started.md) documentation.

## Password Char

The [PasswordChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordChar) property of type `char` defines the character that is displayed in place of each typed character. The default value is `'\0'`, which means the typed characters are shown normally. When set to any other value (for example, `*` or `•`), all typed characters are masked with that character, making the control behave like a password text box.

> **Note:** The `PasswordChar` is purely visual. Screen readers and accessibility tools typically still read the underlying value, so do not rely on the password mask as a security control.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="200"
                       Mask="\w+"
                       MaskType="RegEx"
                       PasswordChar="*"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.Mask = "\w+";
maskedEntry.MaskType = MaskedEntryMaskType.RegEx;
maskedEntry.PasswordChar = '*';

{% endhighlight %}
{% endtabs %}

In the example above, typing `secret` is rendered as `******`. The `Value` property still contains the string `secret`.

![Password Character](MaskedEntry_Images/MaskedEntry_PasswordChar.png)

## Password Delay Duration

The [PasswordDelayDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordDelayDuration) property of type `int` controls how long (in milliseconds) the most-recently typed character remains visible before being replaced by the [PasswordChar](#password-char). This provides brief visual confirmation to the user while preserving password privacy. The default value is `0`, which masks the character immediately. Set the value to a positive number to enable the delay.

When the control loses focus, the timer is canceled and the most-recently typed character is masked immediately. The delay is reset for each new character typed.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="passwordEntry"
                       WidthRequest="200"
                       Mask="(000)-000-000"
                       MaskType="Simple"
                       PasswordChar="*"
                       PasswordDelayDuration="2000"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry passwordEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    Mask = "(000)-000-000",
    MaskType = MaskedEntryMaskType.Simple,
    PasswordChar = '*',
    PasswordDelayDuration = 2000
};

{% endhighlight %}
{% endtabs %}

In the example above, each character is shown for 2000 milliseconds (2 seconds) before being replaced by `*`.

The following GIF demonstrates the password delay behavior: each typed character is briefly visible before being masked.

![Password Delay Duration](MaskedEntry_Images/PasswordDelayDuration.gif)

## See Also

* [Getting Started](getting-started.md)
* [Basic Features](basic-features.md)
* [Mask Types](Mask-Types.md)
* [Formatting Value](formatting-value.md)
* [Validation](validation.md)
