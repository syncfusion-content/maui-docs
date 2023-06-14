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

### Handling the cropping tool

The [`Crop`]() method in the image editor control crop the image based on the [`ImageCropType`]. It allows users to enable or disable the cropping region displayed over the image, making it easier to visually choose the area for cropping.

    * ImageCropType - Specifies the selection type for cropping the image.

* The following code shows cropping the image to any desired size.

{% capture codesnippet1 %}

{% highlight C# %}

// To perform free-hand cropping:

imageEditor.Crop(ImageCropType.Free);    

{% endhighlight %}

{% endcapture %}

{{ codesnippet1 | UnOrderList_Indent_Level_1 }} 

* The following code shows cropping an image in square format.

{% capture codesnippet2 %}

{% highlight C# %}

// To crop an image as a square dimension.

imageEditor.Crop(1,1);

{% endhighlight %}

{% endcapture %}

{{ codesnippet2 | UnOrderList_Indent_Level_1 }} 

* To crop the image with a specific ratio (16:9):

{% capture codesnippet3 %}

{% highlight C# %}

// For cropping the image with ratio, x value as 16, and y value as 9.

imageEditor.Crop(16,9);    

{% endhighlight %} 

{% endcapture %}

{{ codesnippet3 | UnOrderList_Indent_Level_1 }} 

* To position the cropping window with custom location, pass the desired rectangle in [`Crop`]() method. Each value in the rectangle should be in offset value(0 to 100).

{% capture codesnippet4 %}

{% highlight C# %}

Rect rect = new Rect(20,20,50,50);

imageEditor.Crop(rect);    

{% endhighlight %} 

{% endcapture %}

{{ codesnippet4 | UnOrderList_Indent_Level_1 }} 

After the cropping area has been selected, the [`SaveEdits`]() method is called, which in turn crops the selected region and displays the cropped image on the image editor.

{% highlight C# %}

imageEditor.SaveEdits();

{% endhighlight %}

After selecting the cropping area, if you decide to cancel the edits and revert back to the original image, you can use the [`CancelEdits`]() method. It discard the changes made during the cropping process and restore the image to its initial state.

{% highlight C# %}

imageEditor.CancelEdits();

{% endhighlight %}

### Circle cropping

You can also crop an image in a circular or elliptical format, which is useful for profile pictures. Use the [`Crop`]() method with an empty Rect and set the isEllipse parameter to true.

{% highlight C# %}

{% endhighlight %}

![SfImageEditor](images/circle-crop-preview.jpg)

The following image show cases the circularly cropped image.

![SfImageEditor](images/circle-crop.jpg)

 The following code shows cropping an image in elliptical format.

{% highlight C# %}

// To crop an image as a elliptical dimension.

imageEditor.Crop(new Rect(), true);

{% endhighlight %}

### Entering the cropping area manually

To manually enter the cropping area without enabling the cropping functionality, use the overloaded [`Crop(Rect rect)`]() method. It can be done by simply define a rectangle and pass it to the [`Crop`]() method.

{% tabs %}

{% highlight C# %}

imageEditor.Crop(new Rect(100,100,150,200));

{% endhighlight %}

{% endtabs %}

![SfImageEditor](ImageEditor_images/cropaspect.png)

### Programmatically selecting the cropping ratio

Programmatically, you can select the desired cropping ratio from the various aspect ratios available in the built-in cropping toolbar by specifying the corresponding index of the toolbar item using the [`Crop`]() method.

The following code sample will add the cropping preview on the image in square shape.

{% tabs %}

{% highlight C# %}

 imageEditor.Crop(1, 1);

{% endhighlight %}

{% endtabs %}

* To crop an image in a circle or an ellipse with a specific ratio, use [`Crop`]() with a ratio argument and an optional parameter of true, which specifies whether the cropping panel should be added in an elliptical or rectangle shape. The default value is `false`.

{% capture codesnippet6 %}

{% highlight C# %}

imageEditor.Crop(new Rect(20,20,50,50), true);   

{% endhighlight %} 

{% endcapture %}

{{ codesnippet6 | UnOrderList_Indent_Level_1 }}
