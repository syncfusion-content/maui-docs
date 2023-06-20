---
layout: post
title: Text Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the text annotation feature of Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Text Annotation in .NET MAUI ImageEditor (SfImageEditor)

The image editor control allows you to adding a text with customizable settings.

{% highlight C# %}

    imageEditor.AddText("Good morning");

{% endhighlight %}


## Customize text settings

The text annotation can be customized by following common annotation customizing properties.

* `Bounds`: Specifies the annotation view bounds.
* `AllowDrag`: Enable or disable the dragging for annotations.
* `AllowResize`: Enable or disable the resizing for annotations.
* `Opacity`: Specifies the opacity of annotations.

The Text annotation can be inserted and customized by changing its color, font family, font size, and font styles such as bold and italic. The text annotation can be made by either using a toolbar or `AddText` method.

The `ImageEditorTextSettings` consists of the following properties:

* `RotationAngle`: Changes the angle of text.
* `IsEditable`: Enable or disable the text editing.
* `IsRotatable`: Enable or disable the text rotation.
* `TextAlignment`: Specifies the alignment of the text.
* `TextStyle`: Change the text appearance such as `TextColor`, `FontSize`, `FontAttributes`, and `FontFamily` in image editor using the ImageEditorTextSettings.TextStyle property.

{% highlight C# %}

    imageEditor.AddText("Good Day", new ImageEditorTextSettings() { RotationAngle=90, IsRotatable=true, IsEditable=true, TextAlignment=TextAlignment.Start, TextStyle= new ImageEditorTextStyle() { FontSize=14, TextColor=Colors.Black, FontFamily="Arial", FontAttributes=FontAttributes.Italic } }); 

{% endhighlight %}

## Delete the text

You can delete the selected text by either using the toolbar or the `DeleteAnnotation` method.

{% highlight C# %}

    imageEditor.DeleteAnnotation();

{% endhighlight %}

## Clear all texts

You can remove all the texts using `ClearAnnotations` method.

{% highlight C# %}

    imageEditor.ClearAnnotations();

{% endhighlight %}

## AnnotationSelected event

This event Occurs when the annotation is selected.

{% tabs %}

{% highlight xaml %}

    <imageEditor:SfImageEditor Source="{Binding Image}" AnnotationSelected = "imageEditor_AnnotationSelected" />

{% endhighlight %}

{% highlight C# %}

    this.imageEditor.AnnotationSelected += this.OnAnnotationSelected;
    private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
    {
        if (e.AnnotationSettings is ImageEditorTextSettings textSettings)
        {
            textSettings.RotationAngle = 90;
        }
    }

{% endhighlight %}

{% endtabs %}

## Add shape using ImageLoaded event

This event Occurs when the image is loaded.

{% tabs %}

{% highlight xaml %}

    <imageEditor:SfImageEditor Source="{Binding Image}" ImageLoaded="imageEditor_ImageLoaded" />

{% endhighlight %}

{% highlight C# %}

    imageEditor.ImageLoaded += imageEditor_ImageLoaded;
    private void imageEditor_ImageLoaded(object sender, EventArgs e)
    {
        editor1.AddText("Good morning");
    }

{% endhighlight %}

{% endtabs %}

## Add text with manual bounds

The text can be added by user defined view bounds.

{% highlight C# %}

   imageEditor.AddText("Good morning", new ImageEditorTextSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.5) });

{% endhighlight %}


