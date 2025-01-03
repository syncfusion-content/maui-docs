---
layout: post
title: Hiding prompt characters in .NET MAUI Masked Entry control | Syncfusion®
Description: Learn about hiding prompt characters support in Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Hiding Prompt Characters in .NET MAUI Masked Entry (SfMaskedEntry)

When the HidePromptOnLeave property is set to true, prompt characters are ignored when the control loses focus. Again, the prompt characters are restored when the control is focused.

{% tabs %}

{% highlight XAML %}

<syncmaskededit:SfMaskedEdit x:Name="maskedEdit" 
                             MaskType="Text" 
                             Mask="00/00/0000" 
                             HidePromptOnLeave="True" />

{% endhighlight %}

{% highlight C# %}

SfMaskedEdit maskedEdit = new SfMaskedEdit();
maskedEdit.MaskType = MaskType.Text;
maskedEdit.Mask = "00/00/0000";
maskedEdit.HidePromptOnLeave = true;

{% endhighlight %}

{% endtabs %}

![HidePromptOnLeave](MaskedEntry_Images/maui_masked_entry_HidePromptOnLeave.gif)