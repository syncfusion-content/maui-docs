---
layout: post
title: Events in .NET MAUI Image Editor Control | Syncfusion
description: Learn here all about the Events support in the Syncfusion<sup>&reg;</sup> .NET MAUI Image Editor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Events in the .NET MAUI Image Editor (SfImageEditor)

The `SfImageEditor` supports the [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) and [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) events to interact with the [.NET MAUI Image Editor](https://help.syncfusion.com/maui/imageeditor/overview).

## Image loaded event

The [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event occurs after the image is loaded. Use this event to add shapes or text over an image, or to crop an image during initial loading.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor x:Name="imageEditor"
                           Source="image.png"
                           ImageLoaded="OnImageLoaded" />

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnImageLoaded(object sender, EventArgs e)
{
    this.imageEditor.Rotate();
}

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/ImageLoadedSample)

## Annotations deserialized event

The [`AnnotationsDeserialized`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationsDeserialized) event occurs when the annotations are deserialized onto the image.

N> Serialization and deserialization are not applicable for custom annotation views.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<imageEditor:SfImageEditor x:Name="imageEditor"
                           Source="image.png"
                           AnnotationsDeserialized="OnAnnotationsDeserialized" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private async void OnAnnotationsDeserialized(object sender, EventArgs e)
{
    await DisplayAlert("", "Annotations are deserialized", "Ok");
}

{% endhighlight %}
{% endtabs %}

## Annotation selected event

The [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) event occurs when an annotation is selected.

N> This event is common for Shape and Text annotations.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png"
                           AnnotationSelected="OnAnnotationSelected" />

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ImageEditor;

private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
{
    if (e.AnnotationSettings is ImageEditorShapeSettings shapeSettings)
    {
        shapeSettings.Color = Colors.Black;
    }
}

{% endhighlight %}

{% endtabs %}

## Browse image event

The [`BrowseImage`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_BrowseImage) event occurs when the browse icon in the toolbar is clicked while browsing the image source.

#### Cancel

Restrict the default image browse picker from opening by setting the `Cancel` property to `true`.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png"
                           BrowseImage="OnImageBrowse" />

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

using System.ComponentModel;
using Syncfusion.Maui.ImageEditor;

private void OnImageBrowse(object sender, CancelEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}