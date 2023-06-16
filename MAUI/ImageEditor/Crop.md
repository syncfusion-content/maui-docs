---
layout: post
title: Crop in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about Crop support in Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Crop in .NET MAUI ImageEditor (SfImageEditor)

You can use the cropping tool in the Image Editor to select and crop a specific portion of an image.

## Image cropping ratio

The Image Editor control provides various selection options for cropping images, including custom, square, circle, and customized to various aspects ratios. You can drag and resize the selection region to crop the desired area of an image.

Cropping operation can be done in the following two ways:

* Enable cropping and visually select the crop region.
* Manually entering the cropping area.

N> You can also crop the image at a specific position with annotations. 

## Handling the cropping tool

The `Crop` method in the image editor control crop the image based on the `ImageCropType`. It allows users to enable or disable the cropping region displayed over the image, making it easier to visually choose the area for cropping.

    * ImageCropType - Specifies the selection type for cropping the image.

* The following code shows cropping the image to any desired size.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Free);

{% endhighlight %}

After the cropping area has been selected, the `SaveEdits` method is called, which in turn crops the selected region and displays the cropped image on the image editor.

{% highlight C# %}

imageEditor.SaveEdits();

{% endhighlight %}

After selecting the cropping area, if you decide to cancel the edits and revert back to the original image, you can use the `CancelEdits` method. It discard the changes made during the cropping process and restore the image to its initial state.

{% highlight C# %}

imageEditor.CancelEdits();

{% endhighlight %}

## Freehand Crop

This type of crop allows you to freely select and crop a region of the image. You can manually outline the desired area using your cursor or touch input.The selection region can be customized by dragging and resizing an image.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Free);

{% endhighlight %}

## Original Crop

With the original crop, the image is cropped to its original dimensions. This means that no aspect ratio and the cropped image retains its original width and height.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Original);

{% endhighlight %}

## Square Crop

The square crop option allows you to crop the image into a perfect square shape. This is useful when you want to create square thumbnails or profile pictures.

{% highlight C# %}

imageEditor.Crop(1,1);

{% endhighlight %}

## Ratio Crop

The ratio crop enables you to crop the image with a specific aspect ratio. You can specify the desired ratio using the width and height values. For example, setting the ratio to 16:9 will result in a crop with a width-to-height ratio of 16:9.

{% highlight C# %}

imageEditor.Crop(16,9);

{% endhighlight %}

## Circle cropping

You can also crop an image in a circular or elliptical format, which is useful for profile pictures. Use the `Crop` method with an empty Rect and set the isEllipse parameter to true.

{% highlight C# %}

{% endhighlight %}

The following image show cases the circularly cropped image.

 The following code shows cropping an image in elliptical format.

{% highlight C# %}

// To crop an image as a elliptical dimension.

imageEditor.Crop(new Rect(20,20,50,50), true);

{% endhighlight %}

### Entering the cropping area manually

To manually enter the cropping area without enabling the cropping functionality, use the overloaded `Crop(Rect rect)` method. It can be done by simply define a rectangle and pass it to the `Crop` method.

{% tabs %}

{% highlight C# %}

imageEditor.Crop(new Rect(50,50,150,200));

{% endhighlight %}

{% endtabs %}

### Programmatically selecting the cropping ratio

Programmatically, you can select the desired cropping ratio from the various aspect ratios available in the built-in cropping toolbar by specifying the corresponding index of the toolbar item using the `Crop` method.

The following code sample will add the cropping preview on the image in square shape.

{% tabs %}

{% highlight C# %}

 imageEditor.Crop(1, 1);

{% endhighlight %}

{% endtabs %}

* To crop an image in a circle or an ellipse with a specific ratio, use `Crop` with a ratio argument and an optional parameter of true, which specifies whether the cropping panel should be added in an elliptical or rectangle shape. The default value is `false`.

{% capture codesnippet6 %}

{% highlight C# %}

imageEditor.Crop(new Rect(20,20,50,50), true);   

{% endhighlight %} 

{% endcapture %}

{{ codesnippet6 | UnOrderList_Indent_Level_1 }}
