---
layout: post
title: Show Password Character in .NET MAUI MaskedEntry control | Syncfusion
description: Learn here all about Show Password Character support iin Syncfusion .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug 
---

# Show Password Character in .NET MAUI MaskedEntry (SfMaskedEntry)

## Password Char

The SfMaskedEntry control supports to work as a password text box when setting a character to the `PasswordChar`property.

{% tabs %}
{% highlight xaml %}
 <editors:SfMaskedEntry x:Name="maskedEntry"
                        WidthRequest="200"
                        Mask="\w+" 
                        MaskType="RegEx" 
                        PasswordChar="*"/>
{% endhighlight %}

{% highlight c# %}
maskedEntry.PasswordChar = '*';
{% endhighlight %}
{% endtabs %}

![Show Password Char](MaskedEntry_Images/MaskedEntry_PasswordChar.png)

