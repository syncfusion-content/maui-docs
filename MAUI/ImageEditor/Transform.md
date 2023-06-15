---
layout: post
title: Transform in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about Transform in Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Transform in .NET MAUI ImageEditor (SfImageEditor)

The Image Editor in .NET MAUI provides options for rotating and flipping images, along with the ability to add annotations.

## Rotate

The `Rotate` method is used to rotate images with annotations. Each rotation will rotate the image 90 degrees clockwise. You can rotate the image using either the toolbar or the `Rotate` method.

N> Angle cannot be specified in code to alter the rotation angle of the image.

{% highlight C# %}

              imageEditor.Rotate();

{% endhighlight %}

## Flip

The image editor control is capable of showing the mirror image. The `Flip` method allows you to flip the image horizontally or vertically based on the `ImageFlipDirection`. Flipping the image can be done by either using a toolbar or the `Flip` method.

    * ImageFlipDirection - Specifies the direction in which to flip the image.

In the following example, the `Flip` method is used to vertically flip the image.

{% highlight C# %}

              imageEditor.Flip(ImageFlipDirection.Vertical);

{% endhighlight %}