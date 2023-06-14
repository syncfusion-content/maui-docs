---
layout: post
title: Transform in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about Transform in Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Transform in .NET MAUI ImageEditor (SfImageEditor)

The Image Editor has the rotate and flip transformation options and it transforms the image editor with annotations.

## Rotate

The [`Rotate`]() method is used to rotate images with annotation. For each rotation, image will be rotated to 90 degrees towards clockwise direction.
Rotating the image can be done by either using a toolbar or [`Rotate`]() method.

N> Angle cannot be specified in code to alter the rotation angle of the image.

{% highlight C# %}

              imageEditor.Rotate();

{% endhighlight %}

![ImageEditor Sample](images/image-editor-rotate.jpg)

## Flip

The image editor control is capable of showing the mirror image. The [`Flip`]() method flips the image with annotations horizontally/vertically based on the [`ImageFlipDirection`]. Flipping the image can be done by either using a toolbar or the [`Flip`]() method.

    * ImageFlipDirection - Specifies the direction to flip the image.

In the following example, the [`Flip`]() method is used to flip the image.

{% highlight C# %}

              imageEditor.Flip(ImageFlipDirection.Vertical);

{% endhighlight %}

![ImageEditor Sample](images/image-editor-flip.jpg)