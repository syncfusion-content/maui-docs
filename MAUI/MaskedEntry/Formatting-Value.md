---
layout: post
title: Mask formats in MAUI MaskedEntry control | Syncfusion
description: Learn all about how to set the mask format for the value in the MaskedEntry (SfMaskedEntry) control with prompts and literals.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Formatting value in MAUI MaskedEntry

The `MaskedEntry` control allows you to format input values with prompt and literal characters which are defined in the mask expression by setting the [ValueMaskFormat] property. By default, the [Value] property of the control includes the characters typed by the user, as well as any prompt or literal characters in the input. The control provides several formatting options, which are listed below.

1. ExcludePromptAndLiterals
2. IncludePrompt
3. IncludeLiterals
4. IncludePromptAndLiterals

## Exclude prompts and literals

Set up the MaskedTextBox to exclude prompt and literal characters, preserving only the typed characters.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry   Width="200"
                            MaskType="Simple"
                            Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                            Value="DF321SD1A"
                            ValueMaskFormat="ExcludePromptAndLiterals"/>

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry;
public MainPage()
{
    InitializeComponent();
    maskedEntry.Width = "200";
    maskedEntry.MaskType = MaskedTextBoxMaskType.Simple;
    maskedEntry.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA";
    maskedEntry.Value = "DF321SD1A";
    maskedEntry.ValueMaskFormat = MaskedEntryMaskFormat.ExcludePromptAndLiterals;
} 

{% endhighlight %}
{% endtabs %}

![MAUI MaskedEntry excludes prompts and literals](MaskedTextBox_Images/winui_masked_textbox_exclude_prompts_and_literals.png)

## Include prompts

Set up the MaskedEntry to preserve typed and prompt characters, excluding literals.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry Width="200"
                          MaskType="Simple"
                          Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                          Value="DF321SD1A"
                          ValueMaskFormat="IncludePrompt"/>

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry;
public MainPage()
{
    InitializeComponent();
    maskedEntry.Width = "200";
    maskedEntry.MaskType = MaskedTextBoxMaskType.Simple;
    maskedEntry.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA";
    maskedEntry.Value = "DF321SD1A";
    maskedEntry.ValueMaskFormat = MaskedEntryMaskFormat.IncludePrompt;
}

{% endhighlight %}
{% endtabs %}

![MAUI MaskedEntry includes prompts](MaskedTextBox_Images/winui_masked_textbox_include_prompts.png)

## Include literals

Keep typed and literal characters in the input but exclude prompt characters.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry Width="200"
                          MaskType="Simple"
                          Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                          Value="DF321SD1A"
                          ValueMaskFormat="IncludeLiterals"/>

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry;
public MainPage()
{
    InitializeComponent();
    maskedEntry.Width = "200";
    maskedEntry.MaskType = MaskedTextBoxMaskType.Simple;
    maskedEntry.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA";
    maskedEntry.Value = "DF321SD1A";
    maskedEntry.ValueMaskFormat = MaskedEntryMaskFormat.IncludeLiterals;
}

{% endhighlight %}
{% endtabs %}

![MAUI MaskedEntry includes literals](MaskedTextBox_Images/winui_masked_textbox_include_literals.png)

## Include prompts and literals

Maintain typed, prompt, and literal characters in the input.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry Width="200"
                          MaskType="Simple"
                          Mask=">AAAAA-AAAAA-AAAAA-AAAAA"
                          Value="DF321SD1A"
                          ValueMaskFormat="IncludePromptAndLiterals"/>

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry;
public MainPage()
{
    InitializeComponent();
    maskedEntry.Width = "200";
    maskedEntry.MaskType = MaskedEntryMaskType.Simple;
    maskedEntry.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA";
    maskedEntry.Value = "DF321SD1A";
    maskedEntry.ValueMaskFormat = MaskedEntryMaskFormat.IncludePromptAndLiterals;
}

{% endhighlight %}
{% endtabs %}

![MAUI MaskedEntry includes prompts and literals](MaskedTextBox_Images/winui_masked_textbox_include_prompts-and_literals.png)