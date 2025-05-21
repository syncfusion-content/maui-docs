---
layout: post
title: Hiding prompt characters in .NET MAUI Masked Entry | Syncfusion®
description: Learn about hiding prompt characters support in Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Hiding Prompt Characters in .NET MAUI Masked Entry (SfMaskedEntry)

The `HidePromptOnLeave` property allows prompt characters to be hidden when the control loses focus. The prompt characters are restored when the control regains focus.

{% tabs %}

{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEntry" 
                       Placeholder="Enter here"
                       MaskType="Simple"
                       Mask="00/00/0000" 
                       PromptChar="#"
                       HidePromptOnLeave="True" />

{% endhighlight %}

{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.Placeholder="Enter here";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.PromptChar = '#';
maskedEntry.HidePromptOnLeave = true;

{% endhighlight %}

{% endtabs %}

![HidePromptOnLeave](MaskedEntry_Images/maui_masked_entry_HidePromptOnLeave.gif)