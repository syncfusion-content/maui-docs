---
layout: post
title: Mask formats in .NET MAUI MaskedEntry control | Syncfusion®
description: Learn how to set the mask format for the value in the MaskedEntry (SfMaskedEntry) control with prompts and literals.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Formatting Value in .NET MAUI MaskedEntry

The [MaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control enables you to format input values using prompt and literal characters defined in the mask expression. This is done by setting the [ValueMaskFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskFormat.html) property. By default, the [Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Value) property includes characters typed by the user, as well as any prompt or literal characters. The control offers several formatting options as listed below:

1. ExcludePromptAndLiterals
2. IncludePrompt
3. IncludeLiterals
4. IncludePromptAndLiterals

## Exclude Prompts and Literals

Configure the MaskedEntry to exclude prompt and literal characters, maintaining only the characters typed by the user.

{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                            MaskType="Simple"
                            ClearButtonVisibility="WhileEditing"
                            Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                            Value="DF321SD1A"
                            ValueMaskFormat="ExcludePromptAndLiterals"/>

{% endhighlight %}
{% highlight C# %}

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

![MAUI MaskedEntry excludes prompts and literals](MaskedEntry_Images/maui_masked_entry_exclude_prompts_and_literals.png)

## Include Prompts

Set up the MaskedEntry to retain typed and prompt characters while excluding literals.

{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                            MaskType="Simple"
                            ClearButtonVisibility="WhileEditing"
                            Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                            Value="DF321SD1A"
                            ValueMaskFormat="IncludePrompt"/>

{% endhighlight %}
{% highlight C# %}

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

![MAUI MaskedEntry includes prompts](MaskedEntry_Images/maui_masked_entry_include_prompts.png)

## Include Literals

Preserve typed and literal characters in the input while excluding prompt characters.

{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                            MaskType="Simple"
                            ClearButtonVisibility="WhileEditing"
                            Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                            Value="DF321SD1A"
                            ValueMaskFormat="IncludeLiterals"/>

{% endhighlight %}
{% highlight C# %}

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

![MAUI MaskedEntry includes literals](MaskedEntry_Images/maui_masked_entry_include_literals.png)

## Include Prompts and Literals

Maintain the input inclusive of typed, prompt, and literal characters.
{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry x:Name="maskedEntry" WidthRequest="200"
                            MaskType="Simple"
                            ClearButtonVisibility="WhileEditing"
                            Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                            Value="DF321SD1A"
                            ValueMaskFormat="IncludePromptAndLiterals"/>

{% endhighlight %}
{% highlight C# %}

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

![MAUI MaskedEntry includes prompts and literals](MaskedEntry_Images/maui_masked_entry_include_prompts-and_literals.png)