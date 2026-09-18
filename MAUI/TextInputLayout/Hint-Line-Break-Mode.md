---
layout: post
title: Hint Line Break Mode in .NET MAUI Text Input Layout | Syncfusion®
description: Learn how to control the display of long hint text in the Syncfusion® .NET MAUI Text Input Layout control.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui textinputlayout hintlinebreakmode, syncfusion text input layout hint wrapping, sftextinputlayout hint truncation, .net maui line break mode hint
---

# Hint Line Break Mode in .NET MAUI Text Input Layout

## Overview

The [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) control provides the `HintLineBreakMode` property to control how long hint text is displayed when the available space is limited. It uses the standard .NET MAUI [LineBreakMode](https://learn.microsoft.com/dotnet/api/microsoft.maui.linebreakmode) values to wrap, truncate, or otherwise constrain the hint text.

## XAML Example

The following example wraps a long hint across multiple lines.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Business registration identification number"
                               HintLineBreakMode="WordWrap"
                               ContainerType="Outlined">
    <Entry Keyboard="Numeric" />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

var inputLayout = new SfTextInputLayout
{
    Hint = "Business registration identification number",
    HintLineBreakMode = LineBreakMode.TailTruncation,
    ContainerType = ContainerType.Outlined,
    Content = new Entry { Keyboard = Keyboard.Numeric }
};

Content = inputLayout;

{% endhighlight %}
{% endtabs %}