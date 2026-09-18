---
layout: post
title: Hint View in .NET MAUI Text Input Layout | Syncfusion®
description: Learn how to use a custom MAUI view as the floating hint label in the Syncfusion® .NET MAUI Text Input Layout control.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui textinputlayout hintview, syncfusion text input layout custom hint, sftextinputlayout floating hint view, .net maui custom floating label
---

# Hint View in .NET MAUI Text Input Layout

The [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) control lets you display any .NET MAUI `View` as the floating hint label by using the `HintView` property. This enables richer hint content than a text-only [Hint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Hint), including styled text, icons, and other visual elements.

When `HintView` is assigned, it takes precedence over `Hint`. The custom view participates in the same floating behavior as the standard hint: it moves to the floating position when the input view receives focus or contains text, and returns to its resting position when appropriate.

## XAML example

The following example uses a styled label as the floating hint view.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout
    ContainerType="Outlined"
    EnableHintAnimation="True">

    <inputLayout:SfTextInputLayout.HintView>
        <Label
            Text="Premium User"
            FontSize="14"
            FontAttributes="Bold"
            TextColor="#512DA8"
            BackgroundColor="#EDE7F6"
            Padding="8,4"
            Margin="2" />
    </inputLayout:SfTextInputLayout.HintView>

    <Entry Placeholder="Enter your name" />

</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

var inputLayout = new SfTextInputLayout
{
    ContainerType = ContainerType.Outlined,
    EnableHintAnimation = true,
    HintView = new Label
    {
        Text = " Premium User",
        FontSize = 14,
        FontAttributes = FontAttributes.Bold,
        TextColor = Color.FromArgb("#512DA8"),
        BackgroundColor = Color.FromArgb("#EDE7F6"),
        Padding = new Thickness(8, 4),
        Margin = new Thickness(2)
    },
    Content = new Entry
    {
        Placeholder = "Enter your name"
    }
};

Content = new VerticalStackLayout
{
    Padding = 20,
    Children =
    {
        inputLayout
    }
};

{% endhighlight %}
{% endtabs %}

The `Hint` value is included as a fallback, but it is not displayed while `HintView` is assigned.