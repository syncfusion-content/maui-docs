---
layout: post
title: Zoom an image in .NET MAUI Image Editor Control | Syncfusion®
description: Learn here all about how to zoom an image in the Syncfusion® .NET MAUI Image Editor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Image zooming in .NET MAUI Image Editor (SfImageEditor)

The .NET MAUI Image Editor supports zooming and panning actions on an image.

## Allow image zooming

Set the [`AllowZoom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AllowZoom) property to enable or disable the zooming functionality. By default, the [`AllowZoom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AllowZoom) value is `true`.

{% tabs %}

{% highlight XAML tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.jpeg" AllowZoom="False" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.jpeg");
imageEditor.AllowZoom = false;
this.Content = imageEditor;

{% endhighlight %}

{% endtabs %}

## Change the image zoom level

Zoom the loaded image programmatically without any interaction by setting the [`ZoomLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ZoomLevel) property.

{% tabs %}

{% highlight XAML tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.jpeg" ZoomLevel="2" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.jpeg");
imageEditor.ZoomLevel = 2;
this.Content = imageEditor;

{% endhighlight %}

{% endtabs %}

![Zooming in .NET MAUI Image Editor](images/zoom/imageeditor-zooming.gif)

### Change the maximum zoom level

Use the [`MaximumZoomLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_MaximumZoomLevel) property to define the maximum zoom level for the image.

{% tabs %}

{% highlight XAML tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.jpeg" MaximumZoomLevel="5" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.jpeg");
imageEditor.MaximumZoomLevel = 5;
this.Content = imageEditor;

{% endhighlight %}

{% endtabs %}