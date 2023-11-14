---
layout: post
title: Text Annotation in .NET MAUI Image Editor control | Syncfusion
description: Learn about the text annotation feature of Syncfusion .NET MAUI Image Editor(SfImageEditor) control.
platform: maui
control: SfImageEditor
documentation: ug
---

# Text Annotation in .NET MAUI Image Editor (SfImageEditor)

The ImageEditor control in .NET MAUI allows you to add text using the [`AddText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditorhtml#Syncfusion_Maui_ImageEditor_SfImageEditor_AddText_System_String_Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_) method with customizable settings.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="AddText"
                Clicked="OnAddTextClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAddTextClicked(object sender, EventArgs e)
    {
        this.imageEditor.AddText("Good morning");
    }

{% endhighlight %}
{% endtabs %}

![Shape annotation in .NET Maui ImageEditor](images/text/imageeditor-text-annotation.png)

## Customize text appearance

Customize the appearance of text annotation using the [`ImageEditorTextSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#).

* [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowDrag): Enables or disables the dragging of text annotation. The default value is `true`.
* [`AllowResize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowResize): Enables or disables the resizing of shape annotation. The default value is `true`.
* [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds): Specifies the bounds of the text view. Position the text wherever you want on the image. The value of the text bounds should fall between 0 and 1.
* [`Opacity`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Opacity): Specifies the opacity of shape annotation. The value should fall between 0 to 1.
* [`RotationAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_RotationAngle): Specifies the initial rotation angle of the text. The value should fall between 0 to 360.

* [`IsEditable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsEditable): Enables or disables text editing. The default value is `true`.
* [`IsRotatable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsRotatable): Enables or disables the text rotation. The default value is `true`.
* [`TextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextAlignment): Specifies the start, center, or end alignment of the text. The default value is `TextAlignment.Center`.
* [`TextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextStyle): Change the text appearance such as [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_TextColor), [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontSize), [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontAttributes), and [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontFamily) in the image editor using the [`ImageEditorTextSettings.TextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextStyle) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="AddText"
                Clicked="OnAddTextClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAddTextClicked(object sender, EventArgs e)
    {
        this.imageEditor.AddText("Good Day",
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
    }

{% endhighlight %}
{% endtabs %}

![Text annotation customization in .NET Maui ImageEditor](images/text/imageeditor-text-customization.png)

## Delete the text

Delete the selected text using either the toolbar or the [`DeleteAnnotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_DeleteAnnotation) method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="DeleteAnnotation"
                Clicked="OnDeleteAnnotationClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnDeleteAnnotationClicked(object sender, EventArgs e)
    {
        this.imageEditor.DeleteAnnotation();
    }

{% endhighlight %}
{% endtabs %}

## Clear all texts

Remove all the text annotations using the [`ClearAnnotations`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ClearAnnotations) method.

N> This removes shape and pen annotations as well.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="ClearAnnotations"
                Clicked="OnClearAnnotationsClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnClearAnnotationsClicked(object sender, EventArgs e)
    {
        this.imageEditor.ClearAnnotations();
    }

{% endhighlight %}
{% endtabs %}

## Annotation selected event

This [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) event occurs when the annotation is selected.

N> This is common for Shape and Text annotations.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" AnnotationSelected = "OnAnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

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

Add a text on image loading using the [`Imageloaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        this.imageEditor.AddText("Good morning");
    }

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/ImageLoadedSample)

### Add text with manual bounds

The text can be added with user-defined view bounds. The [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) are treated as ratio values of image width and height, so you have to specify bound's rectangle values in the range of 0 to 1.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        imageEditor.AddText("Good morning", new ImageEditorTextSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.5) });
    }

{% endhighlight %}
{% endtabs %}
