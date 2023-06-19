---
layout: post
title: Crop in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about crop support in Syncfusion .NET MAUI ImageEditor (SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Crop in .NET MAUI ImageEditor (SfImageEditor)

Using the Image Editor's cropping tool, you can select and crop a particular section of an image.

## Image cropping ratio

The Image Editor control provides a range of selection choices for cropping images, such as custom, square, circle, and different aspect ratios. To crop a specific area of an image, simply drag and resize the selection region.

There are two methods to perform the cropping operation:

* Enable cropping and visually choose the cropping area.
* Input the cropping region manually.

## Handling the cropping tool

The `Crop` method in the image editor control crops the image based on the `ImageCropType`. It allows users to enable or disable the cropping region displayed over the image, making it easier to visually choose the area for cropping.

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

The selection region can be customized by dragging and resizing an image.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Free);

{% endhighlight %}

## Original Crop

With the original crop, the image is cropped to its original dimensions. This means that no aspect ratio and the cropped image retains its original width and height.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Original);

{% endhighlight %}

## Square Crop

The square crop option allows you to crop the image into a perfect square shape.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Square);

{% endhighlight %}

## Ratio Crop

The ratio crop enables you to crop the image with a specific aspect ratio. You can specify the desired ratio using the width and height values. The default ratio is 4:3 when using `ImageCropType.Ratio`, but you can change it by using the `Crop` method with the ratio parameter.  

{% highlight C# %}

imageEditor.Crop(16,9);

{% endhighlight %}

## Circle crop

You can crop an image in a circular format using the `ImageCropType.Circle` crop type. This method ensures that the image is cropped into a perfect circle with a 1:1 ratio.

* The following code shows cropping an image in circle format.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Circle);

{% endhighlight %}

## Ellipse crop

To crop an image in an elliptical format you can use the `ImageCropType.Ellipse` crop type. This allows for free-style cropping in an elliptical shape.

 * The following code shows cropping an image in elliptical format.

{% highlight C# %}

imageEditor.Crop(ImageCropType.Ellipse);

{% endhighlight %}

## Entering the cropping area manually

To manually enter the cropping area use the `Crop(Rect rect)` method. It can be done by simply define a rectangle and pass it to the `Crop` method. If the `isEllipse` parameter is set to true, it will perform an elliptical crop. The default value of `isEllipse` parameter is `false`.

{% highlight C# %}

imageEditor.Crop(new Rect(50,50,150,200));
imageEditor.SaveEdits();

{% endhighlight %}

* To crop an image in an ellipse with a specific rectangle, use `Crop` with a rectangle value and an optional parameter of true, which specifies whether the cropping panel should be added in an elliptical or rectangle shape.

{% highlight C# %}

imageEditor.Crop(new Rect(20,20,50,50), true);
imageEditor.SaveEdits();   

{% endhighlight %} 

## Programmatically selecting the cropping ratio

Programmatically, you can select the desired cropping ratio from the various aspect ratios available in the built-in cropping toolbar by specifying the corresponding index of the toolbar item using the `Crop` method.

The following code sample will add the cropping preview on the image in square shape.

{% highlight C# %}

 imageEditor.Crop(1, 1);

{% endhighlight %}