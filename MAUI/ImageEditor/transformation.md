---
layout: post
title: Transformation in .NET MAUI Image Editor Control | Syncfusion®
description: Learn here all about Transformation support in Syncfusion® .NET MAUI Image Editor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Transformation in .NET MAUI Image Editor (SfImageEditor)

The .NET MAUI Image Editor provides options for rotating and flipping images.

## Rotate

The [Rotate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Rotate) method rotates the image by 90 degrees clockwise on each invocation. You can rotate the image by using either the built-in toolbar or the [Rotate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Rotate) method.

N> The rotation angle cannot be specified in code.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Rotate"
            Clicked="OnRotateImageClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnRotateImageClicked(object sender, EventArgs e)
{
    this.imageEditor.Rotate();
}

{% endhighlight %}
{% endtabs %}

![Image rotation in .NET MAUI Image Editor](images/transformation/imageeditor-rotate.png)

## Flip

The [Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_) method creates a mirror image by flipping the image horizontally or vertically based on the [ImageFlipDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFlipDirection.html) enum. You can flip the image by using either the built-in toolbar or the [Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_) method.

* **ImageFlipDirection** - Specifies the direction in which to flip the image.

The following example uses the [Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_) method to flip the image vertically.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Flip"
            Clicked="OnFlipImageClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnFlipImageClicked(object sender, EventArgs e)
{
    this.imageEditor.Flip(ImageFlipDirection.Vertical);
}

{% endhighlight %}
{% endtabs %}

![Image flip in .NET MAUI Image Editor](images/transformation/imageeditor-flip.png)