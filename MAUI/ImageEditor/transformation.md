---
layout: post
title: Transform in .NET MAUI Image Editor Control | Syncfusion®
description: Learn here all about how to Transform in Syncfusion<sup>&reg;</sup> .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Transform in .NET MAUI Image Editor (SfImageEditor)

The Image Editor in .NET MAUI provides options for rotating and flipping images, along with the ability to add annotations.

## Rotate

The [Rotate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Rotate) method is used to rotate images with annotations. Each rotation will rotate the image 90 degrees clockwise. You can rotate the image using either the toolbar or the [Rotate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Rotate) method.

N> Angle cannot be specified in the code to alter the rotation angle of the image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Rotate"
                Clicked="OnRotateImageClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnRotateImageClicked(object sender, EventArgs e)
    {
        this.imageEditor.Rotate();
    }

{% endhighlight %}
{% endtabs %}

![Image Rotation in .NET Maui ImageEditor](images/transformation/imageeditor-rotate.png)

## Flip

The image editor control is capable of showing the mirror image. The [Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_) method allows you to flip the image horizontally or vertically based on the [ImageFlipDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFlipDirection.html). Flipping the image can be done by either using a toolbar or the [Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_) method.

* ImageFlipDirection - Specifies the direction in which to flip the image.

In the following example, the [Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_) method is used to vertically flip the image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Flip"
                Clicked="OnFlipImageClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnFlipImageClicked(object sender, EventArgs e)
    {
        this.imageEditor.Flip(ImageFlipDirection.Vertical);
    }

{% endhighlight %}
{% endtabs %}

![Image Flip in .NET Maui ImageEditor](images/transformation/imageeditor-flip.png)