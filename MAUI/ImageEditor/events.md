---
layout: post
title: Events in .NET MAUI Image Editor Control | Syncfusion<sup>&reg;</sup>
description: Learn here all about the Events support in the Syncfusion<sup>&reg;</sup> .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Events in the .NET MAUI Image Editor (SfImageEditor)

The SfImageEditor supports the [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) and [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) events to interact with [.NET MAUI Image Editor](https://help.syncfusion.com/maui/imageeditor/overview).

## Image loaded event

This [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event will be triggered after the image has been loaded. By this event, you can add any shapes or text over an image or crop an image while initially loading the image.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.png"
                           ImageLoaded = "OnImageLoaded"/>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
private void OnImageLoaded(object sender, EventArgs e)
{
    this.imageEditor.Rotate();
}

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/ImageLoadedSample)

## Annotations deserialized event

This [AnnotationsDeserialized](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationsDeserialized) event occurs when the annotations are deserialized onto the image.

N> `Serialization` and `deserialization` are not applicable for custom annotation views. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<imageEditor:SfImageEditor x:Name="imageEditor" 
                           Source="image.png" 
                           AnnotationsDeserialized="OnAnnotationsDeserialized"/>
 
{% endhighlight %}
{% highlight C# tabtitle="MainPage.xaml.cs" %}

private async void OnAnnotationsDeserialized(object? sender, EventArgs e)
{
    await DisplayAlert("", "Annotations are deserialized", "Ok");
}

{% endhighlight %}
{% endtabs %}

## Annotation selected event

This [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) event occurs when the annotation is selected.

N> This is common for Shape and Text annotations.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.png"
                           AnnotationSelected = "OnAnnotationSelected"/>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

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

The [`BrowseImage`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_BrowseImage) event occurs when you click the browse icon in the toolbar while browsing the image source.
`Cancel`: Restrict the default image browse picker opening by setting the `Cancel` argument `true`.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.png"
                           BrowseImage = "OnImageBrowse"/>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
private void OnImageBrowse(object sender, CancelEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}