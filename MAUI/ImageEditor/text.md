---
layout: post
title: Text Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the text annotation feature of Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Text Annotation in .NET MAUI ImageEditor (SfImageEditor)

The ImageEditor control in .NET MAUI allows you to add text with customizable settings.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.AddText("Good morning");

{% endhighlight %}
{% endtabs %}

## Customize text settings

The text annotation can be customized using common annotation customization properties:

* `Bounds`: Specifies the bounds of the annotation view.
* `AllowDrag`: Enables or disables dragging for annotations.
* `AllowResize`: Enables or disables resizing for annotations.
* `Opacity`: Specifies the opacity of annotations.

The text annotation can be inserted and customized by changing its color, font family, font size, and font styles such as bold and italic. You can create text annotations using either a toolbar or the `AddText` method.

The `ImageEditorTextSettings` consists of the following properties:

* `RotationAngle`: Changes the angle of text.
* `IsEditable`: Enables or disables the text editing.
* `IsRotatable`: Enables or disables the text rotation.
* `TextAlignment`: Specifies the alignment of the text.
* `TextStyle`: Change the text appearance such as `TextColor`, `FontSize`, `FontAttributes`, and `FontFamily` in image editor using the `ImageEditorTextSettings.TextStyle` property.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.AddText("Good Day", new ImageEditorTextSettings() { RotationAngle=90, IsRotatable=true, IsEditable=true, TextAlignment=TextAlignment.Start, TextStyle= new ImageEditorTextStyle() { FontSize=14, TextColor=Colors.Black, FontFamily="Arial", FontAttributes=FontAttributes.Italic } }); 

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

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.ClearAnnotations();

{% endhighlight %}
{% endtabs %}

## AnnotationSelected event

This `AnnotationSelected` event occurs when the annotation is selected.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

    <imageEditor:SfImageEditor Source="{Binding Image}" AnnotationSelected = "imageEditor_AnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

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

This `ImageLoaded` event occurs when the image is loaded.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

    <imageEditor:SfImageEditor Source="{Binding Image}" ImageLoaded="imageEditor_ImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

    imageEditor.ImageLoaded += imageEditor_ImageLoaded;
    private void imageEditor_ImageLoaded(object sender, EventArgs e)
    {
        editor1.AddText("Good morning");
    }

{% endhighlight %}

{% endtabs %}

## Add text with manual bounds

The text can be added with user-defined view bounds.

{% tabs %}
{% highlight C# tabtitle="C#" %}

   imageEditor.AddText("Good morning", new ImageEditorTextSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.5) });

{% endhighlight %}
{% endtabs %}
