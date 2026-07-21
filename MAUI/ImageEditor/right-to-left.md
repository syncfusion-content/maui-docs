---
layout: post
title: FlowDirection in .NET MAUI Image Editor | Syncfusion<sup>&reg;</sup>
description: Learn about Right To Left support in Syncfusion<sup>&reg;</sup> .NET MAUI Image Editor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Right To Left Flow Direction in .NET MAUI Image Editor (SfImageEditor)

The [SfImageEditor](https://www.syncfusion.com/maui-controls/maui-image-editor) supports rendering content in right-to-left order by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    <imageEditor:SfImageEditor Source="image.jpeg" FlowDirection="RightToLeft" />
    . . .
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.jpeg");
imageEditor.FlowDirection = FlowDirection.RightToLeft;
this.Content = imageEditor;

{% endhighlight %}

{% endtabs %}

![Right to left in .NET MAUI Image Editor](images/right-to-left/right-to-left.png)
