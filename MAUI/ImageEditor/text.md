---
layout: post
title: Text Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the text annotation feature of Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Text Annotation in .NET MAUI ImageEditor (SfImageEditor)

The ImageEditor control in .NET MAUI allows you to add text using the [`AddText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditorhtml#Syncfusion_Maui_ImageEditor_SfImageEditor_AddText_System_String_Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_) method with customizable settings.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.AddText("Good morning");

{% endhighlight %}
{% endtabs %}

## Customize text appearance

You can customize the appearance of text annotation using [`ImageEditorTextSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#).

* [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowDrag): Enables or disables the dragging of text annotation. The default value is `true`.
* [`AllowResize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowResize): Enables or disables the resizing of shape annotation. The default value is `true`.
* [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds): Specifies the bounds of the text view. You can position the text wherever you want on the image. The value of the text bounds should fall between 0 and 1.
* [`Opacity`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Opacity): Specifies the opacity of shape annotation. The value should fall between 0 to 1.
* [`RotationAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_RotationAngle): Specifies the initial rotation angle of the text. The value should fall between 0 to 360.

* [`IsEditable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsEditable): Enables or disables text editing. The default value is `true`.
* [`IsRotatable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsRotatable): Enables or disables the text rotation. The default value is `true`.
* [`TextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextAlignment): Specifies the start, center, or end alignment of the text. The default value is `TextAlignment.Center`.
* [`TextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextStyle): Change the text appearance such as [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_TextColor), [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontSize), [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontAttributes), and [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontFamily) in the image editor using the [`ImageEditorTextSettings.TextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextStyle) property.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.AddText("Good Day",
    new ImageEditorTextSettings() 
    { 
        RotationAngle = 90, 
        IsRotatable = true, 
        IsEditable = true, 
        TextAlignment = TextAlignment.Start, 
        TextStyle = new ImageEditorTextStyle() 
        { 
            FontSize = 14,
            TextColor = Colors.Black, 
            FontFamily = "Arial", 
            FontAttributes = FontAttributes.Italic 
        } 
    }); 

{% endhighlight %}
{% endtabs %}

## Delete the text

You can delete the selected text using either the toolbar or the [`DeleteAnnotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_DeleteAnnotation) method.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.DeleteAnnotation();

{% endhighlight %}
{% endtabs %}

## Clear all texts

You can remove all the text annotations using the [`ClearAnnotations`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ClearAnnotations) method.

N> This removes shape and pen annotations as well.

{% tabs %}
{% highlight C# tabtitle="C#" %}

    imageEditor.ClearAnnotations();

{% endhighlight %}
{% endtabs %}

## AnnotationSelected event

This [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) event occurs when the annotation is selected.

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

You can add a text on image loading using the [`Imageloaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        this.imageEditor.AddText("Good morning");
    }

{% endhighlight %}

{% endtabs %}

## Add text with manual bounds

The text can be added with user-defined view bounds. The [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) are treated as ratio values of image width and height, so you have to specify bound's rectangle values in the range of 0 to 1

{% tabs %}
{% highlight C# tabtitle="C#" %}

   imageEditor.AddText("Good morning", new ImageEditorTextSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.5) });

{% endhighlight %}
{% endtabs %}
