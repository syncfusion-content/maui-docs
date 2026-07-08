---
layout: post
title: Formatting Value in .NET MAUI Masked Entry control | Syncfusion®
description: Learn how to format the value in the Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control by including or excluding prompts and literals.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Formatting Value in .NET MAUI Masked Entry

The [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control allows you to format input values with prompt and literal characters defined in the mask expression by setting the [ValueMaskFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueMaskFormat) property. The default value of `ValueMaskFormat` is `MaskedEntryMaskFormat.IncludePromptAndLiterals`, which means the [Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Value) property of the control includes the characters typed by the user and any prompt or literal characters in the input.

The available formatting options are:

- `ExcludePromptAndLiterals` - Returns only the characters typed by the user.
- `IncludePrompt` - Returns the typed characters and the prompt characters, but excludes the literal characters.
- `IncludeLiterals` - Returns the typed characters and the literal characters, but excludes the prompt characters.
- `IncludePromptAndLiterals` - Returns the typed characters, prompt characters, and literal characters.

> **Note:** The `ValueMaskFormat` property applies to the `Simple` [MaskType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_MaskType). When using `RegEx`, the mask is treated as a regular expression and the formatting options do not apply.

## Prerequisites

Before using the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package in your .NET MAUI project.

For a step-by-step setup, refer to the [Getting Started](getting-started.md) documentation.

## Exclude prompts and literals

Configure the Masked Entry to exclude prompt and literal characters, preserving only the characters typed by the user. With this option, the resulting `Value` is `DF321SD1A` (the literals `-` and any unfilled prompt slots `_` are removed).

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                       MaskType="Simple"
                       ClearButtonVisibility="WhileEditing"
                       Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                       Value="DF321SD1A"
                       ValueMaskFormat="ExcludePromptAndLiterals"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
    Mask = ">AAAAA-AAAAA-AAAAA-AAAAA",
    Value = "DF321SD1A",
    ValueMaskFormat = MaskedEntryMaskFormat.ExcludePromptAndLiterals
};

{% endhighlight %}
{% endtabs %}

![ExcludePromptAndLiterals](MaskedEntry_Images/maui_masked_entry_exclude_prompts_and_literals.png)

## Include prompts

Configure the Masked Entry to preserve typed and prompt characters while excluding the literal characters. With this option, the resulting `Value` is `DF321SD1A`.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                       MaskType="Simple"
                       ClearButtonVisibility="WhileEditing"
                       Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                       Value="DF321SD1A"
                       ValueMaskFormat="IncludePrompt"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
    Mask = ">AAAAA-AAAAA-AAAAA-AAAAA",
    Value = "DF321SD1A",
    ValueMaskFormat = MaskedEntryMaskFormat.IncludePrompt
};

{% endhighlight %}
{% endtabs %}


![IncludePrompt](MaskedEntry_Images/maui_masked_entry_include_prompts.png)

## Include literals

Configure the Masked Entry to keep typed and literal characters while excluding prompt characters. With this option, the resulting `Value` is `DF321-SD1A` .

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                       MaskType="Simple"
                       ClearButtonVisibility="WhileEditing"
                       Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                       Value="DF321SD1A"
                       ValueMaskFormat="IncludeLiterals"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
    Mask = ">AAAAA-AAAAA-AAAAA-AAAAA",
    Value = "DF321SD1A",
    ValueMaskFormat = MaskedEntryMaskFormat.IncludeLiterals
};

{% endhighlight %}
{% endtabs %}

![IncludeLiterals](MaskedEntry_Images/maui_masked_entry_include_literals.png)

## Include prompts and literals

Configure the Masked Entry to maintain typed, prompt, and literal characters in the input. This is the default option. The resulting `Value` is `DF321-SD1A`.

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                       MaskType="Simple"
                       ClearButtonVisibility="WhileEditing"
                       Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                       Value="DF321SD1A"
                       ValueMaskFormat="IncludePromptAndLiterals"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    MaskType = MaskedEntryMaskType.Simple,
    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
    Mask = ">AAAAA-AAAAA-AAAAA-AAAAA",
    Value = "DF321SD1A",
    ValueMaskFormat = MaskedEntryMaskFormat.IncludePromptAndLiterals
};

{% endhighlight %}
{% endtabs %}

![IncludePromptAndLiterals](MaskedEntry_Images/maui_masked_entry_include_prompts-and_literals.png)

## See Also

* [Getting Started](getting-started.md)
* [Basic Features](basic-features.md)
* [Validation](validation.md)
