---
layout: post
title: Zooming in .NET MAUI ImageEditor Control | Syncfusion
description: Learn here all about how to Zooming in Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Zooming in .NET MAUI ImageEditor (SfImageEditor)

The image editor control in .NET MAUI provides support for zooming and panning actions on an image.

The following properties are used for zooming feature of the image editor control:

* EnableZooming
* ZoomLevl
* Maximum ZoomLevel

## Enable zooming

To enable or disable the zooming functionality, set the value of the [`AllowZoom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AllowZoom) property to true or false. By default, the [`AllowZoom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AllowZoom) value is set to `true`.

{% tabs %}

{% highlight XAML %}
  <ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="image.jpeg" AllowZoom="False"/>

   </ContentPage>
     
{% endhighlight %}

{% highlight C# %}
   
     SfImageEditor imageEditor = new SfImageEditor();
     imageEditor.Source = "image.jpeg";
     imageEditor.AllowZoom = false;
     this.content = imageEditor;

{% endhighlight %}

{% endtabs %}

### Zoom level

Programmatically, you can zoom the loaded image without any interaction by setting a value to [`ZoomLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ZoomLevel) property. 

{% tabs %}

{% highlight XAML %}
  <ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="image.jpeg" ZoomLevel="2"/>

   </ContentPage>
     
{% endhighlight %}

{% highlight C# %}
   
     SfImageEditor imageEditor = new SfImageEditor();
     imageEditor.Source = "image.jpeg";
     imageEditor.ZoomLevel = 2;
     this.content = imageEditor;

{% endhighlight %}

{% endtabs %}

![Zooming in .NET Maui ImageEditor](images/zoom/imageeditor-zooming.gif)

## Maximum zoom level

To define the maximum zoom level for the image, make use of the [`MaximumZoomLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_MaximumZoomLevel) property.

{% tabs %}

{% highlight XAML %}
  <ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="image.jpeg" MaximumZoomLevel="5"/>

   </ContentPage>
     
{% endhighlight %}

{% highlight C# %}
   
     SfImageEditor imageEditor = new SfImageEditor();
     imageEditor.Source = "image.jpeg";
     imageEditor.MaximumZoomLevel = 5;
     this.content = imageEditor;

{% endhighlight %}

{% endtabs %}