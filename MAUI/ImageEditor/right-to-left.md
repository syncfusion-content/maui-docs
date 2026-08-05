---
layout: post
title: Right To Left in .NET MAUI Image Editor | Syncfusion®
description: Learn about Right To Left flow direction support and rendering content in Syncfusion® .NET MAUI Image Editor control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Right To Left in .NET MAUI Image Editor

The [SfImageEditor](https://www.syncfusion.com/maui-controls/maui-image-editor) supports rendering content in right-to-left order by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

    <imageEditor:SfImageEditor Source="image.jpeg" FlowDirection="RightToLeft" />

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.jpeg");
imageEditor.FlowDirection = FlowDirection.RightToLeft;
this.Content = imageEditor;

{% endhighlight %}

{% endtabs %}

![Right to left in .NET MAUI Image Editor](images/right-to-left/right-to-left.png)
