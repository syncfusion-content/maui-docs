---
layout: post
title: Show Password Character in .NET MAUI MaskedEntry control | Syncfusion®
description: Learn all about Show Password Character support in the Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug 
---

# Show Password Character in .NET MAUI Masked Entry (SfMaskedEntry)

## Password Character

The SfMaskedEntry control can function as a password text box by setting a character to the [PasswordChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordChar) property.

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

![Show Password Char](MaskedEntry_Images/MaskedEntry_PasswordChar.png)

