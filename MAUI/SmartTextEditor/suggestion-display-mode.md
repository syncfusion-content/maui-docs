---
layout: post
title: Suggestion Mode in .NET MAUI Smart Text Editor | Syncfusion
description: Learn about suggestion mode with Syncfusion<sup>&reg;</sup> Smart Text Editor (SfSmartTextEditor) control and its basic features.
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Choose how suggestions are displayed
The Smart Text Editor supports two display modes for showing completions as you type: `Inline` and `Popup`.

- [Inline]: Renders the predicted text in place after the caret, matching your text style.
- [Popup]: Shows a compact hint near the caret that you can tap or accept via key press.

N>
- Windows and Mac Catalyst default to **Inline**; Android and iOS default to **Popup**.
- Suggestions can be applied using the **Tab** or **Right Arrow** keys in both modes.
- Applying inline suggestions with the **Tab** key is not supported on Android and iOS.

## Inline suggestion mode
Inline mode displays the suggested text directly within the editor, seamlessly continuing your typing flow. This approach is ideal for desktop environments where uninterrupted input feels natural and efficient.

{% tabs %}
{% highlight C# tabtitle="XAML" hl_lines="9" %}

<ContentPage  
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:smarttexteditor="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <smarttexteditor:SfSmartTextEditor
        Placeholder="Start typing..."
        UserRole="Email author responding to inquiries"
        SuggestionDisplayMode="Inline" />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="6" %}

using Syncfusion.Maui.SmartComponents;

var smarttexteditor = new SfSmartTextEditor
{
    Placeholder = "Start typing...",
    UserRole = "Email author responding to inquiries",
    SuggestionDisplayMode = SuggestionDisplayMode.Inline
};

{% endhighlight %}
{% endtabs %}

## Popup suggestion mode
Popup mode displays the suggested text in a small overlay near the caret, making it easy to review and accept without interrupting your typing. This mode is especially useful on touch based devices where tapping the suggestion feels natural and convenient.

{% tabs %}
{% highlight C# tabtitle="XAML" hl_lines="9" %}

<ContentPage  
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:smarttexteditor="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <smarttexteditor:SfSmartTextEditor
        Placeholder="Start typing..."
        UserRole="Email author responding to inquiries"
        SuggestionDisplayMode="Popup" />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="6" %}

using Syncfusion.Maui.SmartComponents;

var smarttexteditor = new SfSmartTextEditor
{
    Placeholder = "Start typing...",
    UserRole = "Email author responding to inquiries",
    SuggestionDisplayMode = SuggestionDisplayMode.Popup
};

{% endhighlight %}
{% endtabs %}