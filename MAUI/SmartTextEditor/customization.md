---
layout: post
title: Customizations in .NET MAUI Smart Text Editor control | Syncfusion®
description: Learn here all about Customizations features of Syncfusion<sup>&reg;</sup> .NET MAUI Smart Text Editor (SfSmartTextEditor) control. 
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Customizations in .NET MAUI Smart Text Editor (SfSmartTextEditor)
This section explains how to change the Smart Text Editor’s appearance and suggestion behavior. You can set text styles, placeholder options, and customize how suggestions are shown.

## Text customization
Set or bind the smart text editor’s text using the Text property. You can use this to preload content or bind it to a field in your view model for data binding.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ste:SfSmartTextEditor
    Text="Thank you for contacting us." />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var ste = new SfSmartTextEditor
{
    Text = "Thank you for contacting us."
};

{% endhighlight %}
{% endtabs %}

## Text style customization
You can change the text style and font using the TextStyle property to make the editor look the way you want.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:ste="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <ste:SfSmartTextEditor>
        <ste:SfSmartTextEditor.TextStyle>
            <ste:SmartTextEditorStyle
                FontSize="16"
                TextColor="Skyblue" />
        </ste:SfSmartTextEditor.TextStyle>
    </ste:SfSmartTextEditor>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.SmartComponents;

var ste = new SfSmartTextEditor
{
    TextStyle = new SmartTextEditorStyle
    {
        FontSize = 16,
        TextColor = Colors.Skyblue,
    }
};

{% endhighlight %}
{% endtabs %}

## Placeholder text and color customization
Add a helpful placeholder to guide users and use PlaceholderColor to make sure the text is easy to read.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ste:SfSmartTextEditor
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
Customize the color of the suggestion text so it fits your theme and improves readability.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ste:SfSmartTextEditor
    SuggestionTextColor="Goldenrod" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var ste = new SfSmartTextEditor
{
    SuggestionTextColor = Colors.Goldenrod
};

{% endhighlight %}
{% endtabs %}

## Suggestion popup background
Change the background color of the suggestion popup when using Popup mode to match your app’s design.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ste:SfSmartTextEditor
    SuggestionDisplayMode="Popup"
    SuggestionPopupBackground="LightYellow" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var ste = new SfSmartTextEditor
{
    SuggestionDisplayMode = SuggestionDisplayMode.Popup,
    SuggestionPopupBackground = new SolidColorBrush(Colors.LightYellow)
};

{% endhighlight %}
{% endtabs %}

## Maximum input length
Set a limit on the number of characters the user can enter in the smart text editor using the MaxLength property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ste:SfSmartTextEditor
    MaxLength="500" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

var ste = new SfSmartTextEditor
{
    MaxLength = 500
};

{% endhighlight %}
{% endtabs %}