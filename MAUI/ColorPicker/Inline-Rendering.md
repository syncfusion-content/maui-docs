---
layout: post
title: Inline Support in .NET MAUI Color Picker Control | Syncfusion®
description: Learn all about Inline support in the Syncfusion® .NET MAUI Color Picker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, .net maui color picker control, maui color picker control, .net maui color picker inline, maui color picker inline
---

# Inline Rendering in .NET MAUI Color Picker (SfColorPicker)

The [.NET MAUI Color Picker]() provides an inline support feature, which determines how the color picker is embedded directly within the UI layout, rather than appearing in a popup or flyout. By default, this feature is set to `False`, meaning that the color picker is not initially embedded inline within the layout.

To enable inline rendering, you can set the [IsInline]() property to `True` in your XAML or C# code, as demonstrated below:

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker IsInline="True"/>          

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    IsInline = true
};

{% endhighlight %}

{% endtabs %}