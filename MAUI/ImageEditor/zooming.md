---
layout: post
title: Zoom image using .NET MAUI Image Editor Control | Syncfusion®
description: Learn here all about how to zoom image in the Syncfusion<sup>&reg;</sup> .NET MAUI Image Editor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# The .NET MAUI Image Editor (SfImageEditor) Image Zooming

The image editor control in the .NET MAUI provides support for zooming and panning actions on an image.

## Allow image zooming

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

## Change the image zoom level

Programmatically, you can zoom the loaded image without any interaction by setting a value to the [`ZoomLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ZoomLevel) property. 

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

### Change the maximum zoom level

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