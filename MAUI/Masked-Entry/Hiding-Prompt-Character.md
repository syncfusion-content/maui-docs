---
layout: post
title: Hiding prompt characters in .NET MAUI Masked Entry control | Syncfusion
description: Learn about hiding prompt characters support in Syncfusion .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Hiding Prompt Characters in .NET MAUI Masked Entry (SfMaskedEntry)

When the HidePromptOnLeave property is set to true, prompt characters are ignored when the control loses focus. Again, the prompt characters are restored when the control is focused.

{% tabs %}

{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEdit" 
                       WidthRequest="200";
                       Placeholder="Enter here"
                       MaskType="Simple"
                       Mask="00/00/0000" 
                       PromptChar="#"
                       HidePromptOnLeave="True" />

{% endhighlight %}

{% highlight C# %}

SfMaskedEntry maskedEdit = new SfMaskedEntry();
maskedEdit.WidthRequest = 200;
maskedEdit.Placeholder="Enter here";
maskedEdit.MaskType = MaskedEntryMaskType.Simple;
maskedEdit.Mask = "00/00/0000";
maskedEdit.PromptChar = '#';
maskedEdit.HidePromptOnLeave = true;
Content=maskedEntry;

{% endhighlight %}

{% endtabs %}

![HidePromptOnLeave](MaskedEntry_Images/maui_masked_entry_HidePromptOnLeave.gif)