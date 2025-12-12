---
layout: post
title: Customization in AI-Powered Text Editor control | Syncfusion®
description: Learn here all about Customization features of Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Text Editor (SfSmartTextEditor) control. 
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Customization in .NET MAUI AI-Powered Text Editor (SfSmartTextEditor)
This section explains how to change the AI-Powered Text Editor’s appearance and suggestion behavior. You can set text styles, placeholder options, and customize how suggestions are shown.

## Text customization
Set or bind the smart text editor’s text using the [Text]() property. You can use this to preloaded content or bind it to a field in your view model for data binding.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<smarttexteditor:SfSmartTextEditor
    Text="Thank you for contacting us." />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var smarttexteditor = new SfSmartTextEditor
{
    Text = "Thank you for contacting us."
};

{% endhighlight %}
{% endtabs %}

## Text style customization
You can change the text style and font using the [TextStyle]() property to make the editor look the way you want.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:smarttexteditor="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <smarttexteditor:SfSmartTextEditor>
        <smarttexteditor:SfSmartTextEditor.TextStyle>
            <smarttexteditor:SmartTextEditorStyle
                FontSize="16"
                TextColor="Blue" />
        </smarttexteditor:SfSmartTextEditor.TextStyle>
    </smarttexteditor:SfSmartTextEditor>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.SmartComponents;

var smarttexteditor = new SfSmartTextEditor
{
    TextStyle = new SmartTextEditorStyle
    {
        FontSize = 16,
        TextColor = Colors.Blue,
    }
};

{% endhighlight %}
{% endtabs %}

![Text Style in .NET MAUI Smart Text Editor.](images/customization/maui-smarttexteditor-textcolor.gif)

## Placeholder text and color customization
Add a helpful placeholder to guide users and use [PlaceholderColor]() to make sure the text is easy to read.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<smarttexteditor:SfSmartTextEditor
    Placeholder="Type your message..."
    PlaceholderColor="#49454F" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var editor = new SfSmartTextEditor
{
    Placeholder = "Type your message...",
    PlaceholderColor = Color.FromArgb("#49454F")
};

{% endhighlight %}
{% endtabs %}

## Suggestion text color
Customize the color of the suggestion text using the [SuggestionTextColor]() property to match your theme and improves readability.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<smarttexteditor:SfSmartTextEditor
    SuggestionTextColor="Skyblue" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var smarttexteditor = new SfSmartTextEditor
{
    SuggestionTextColor = Colors.Skyblue
};

{% endhighlight %}
{% endtabs %}

![Suggestion Text Color in .NET MAUI Smart Text Editor.](images/customization/maui-smarttexteditor-textcolor.gif)

## Suggestion popup background
Change the background color of the suggestion popup using the [SuggestionPopupBackground]() property in Popup mode to align with your app's design.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<smarttexteditor:SfSmartTextEditor
    SuggestionDisplayMode="Popup"
    SuggestionPopupBackground="#0078D4" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var smarttexteditor = new SfSmartTextEditor
{
    SuggestionDisplayMode = SuggestionDisplayMode.Popup,
    SuggestionPopupBackground = Color.FromArgb("#0078D4"),
};

{% endhighlight %}
{% endtabs %}

![Customization in .NET MAUI Smart Text Editor.](images/customization/maui-smarttexteditor-customization.gif)

## Maximum input length
Set a limit on the number of characters the user can enter in the smart text editor using the [MaxLength]() property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<smarttexteditor:SfSmartTextEditor
    MaxLength="500" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var smarttexteditor = new SfSmartTextEditor
{
    MaxLength = 500
};

{% endhighlight %}
{% endtabs %}