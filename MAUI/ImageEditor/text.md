---
layout: post
title: Text Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the text annotation feature of Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Text Annotation in .NET MAUI ImageEditor (SfImageEditor)

The ImageEditor control in .NET MAUI allows you to add text using the `AddText` method with customizable settings.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.AddText("Good morning");

{% endhighlight %}
{% endtabs %}

## Customize text settings

You can customize the appearance of text annotation using `ImageEditorTextSettings`.

* `AllowDrag`: Enables or disables the dragging of text annotation.
* `AllowResize`: Enables or disables the resizing of shape annotation.
* `Bounds`: Specifies the bounds of the text view. You can position the text wherever you want on the image. The value of the text bounds should fall between 0 and 1.
* `Opacity`: Specifies the opacity of shape annotation. This value ranges from 0 to 1.
* `RotationAngle`: Specifies the initial rotation angle of the text. The value should fall between 0 to 360.

* `IsEditable`: Enables or disables text editing.
* `IsRotatable`: Enables or disables the text rotation.
* `TextAlignment`: Specifies the start, center, or end alignment of the text.
* `TextStyle`: Change the text appearance such as `TextColor`, `FontSize`, `FontAttributes`, and `FontFamily` in the image editor using the `ImageEditorTextSettings.TextStyle` property.

{% tabs %}
{% highlight C# tabtitle="C#" %}

     imageEditor.AddText("Good Day", new ImageEditorTextSettings() { 
            RotationAngle = 90, 
            IsRotatable = true, 
            IsEditable = true, 
            TextAlignment = TextAlignment.Start, 
            TextStyle = new ImageEditorTextStyle() { 
                FontSize = 14,
                TextColor = Colors.Black, 
                FontFamily = "Arial", 
                FontAttributes = FontAttributes.Italic } }); 

{% endhighlight %}
{% endtabs %}

## Delete the text

You can delete the selected text using either the toolbar or the `DeleteAnnotation` method.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.DeleteAnnotation();

{% endhighlight %}
{% endtabs %}

## Clear all texts

You can remove all the texts using the `ClearAnnotations` method.

N> This removes shape and pen annotations as well.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.ClearAnnotations();

{% endhighlight %}
{% endtabs %}

## AnnotationSelected event

This `AnnotationSelected` event occurs when the annotation is selected.

N> This is common for Shape and Text annotations.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

    <imageEditor:SfImageEditor Source="image.png" AnnotationSelected = "OnAnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

    private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
    {
        if (e.AnnotationSettings is ImageEditorTextSettings textSettings)
        {
            textSettings.RotationAngle = 90;
        }
    }

{% endhighlight %}

{% endtabs %}

## Add text on initial loading

This `ImageLoaded` event occurs when the image is loaded.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

    <imageEditor:SfImageEditor Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        imageEditor.AddText("Good morning");
    }

{% endhighlight %}

{% endtabs %}

## Add text with manual bounds

The text can be added with user-defined view bounds. The bounds are treated as ratio values of image width and height, so you have to specify bound's rectangle values in the range of 0 to 1

{% tabs %}
{% highlight C# tabtitle="C#" %}

   imageEditor.AddText("Good morning", new ImageEditorTextSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.5) });

{% endhighlight %}
{% endtabs %}
