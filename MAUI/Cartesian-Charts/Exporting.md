---
layout: post
title: Exporting in .NET MAUI Chart control | Syncfusion
description: Learn here how to export the chart view as an image and stream in the Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart exporting, maui chart exporting, .net maui chart exporting options, syncfusion maui chart exporting, .net maui chart exporting visualization, .net maui chart save as.
---

# Exporting in .NET MAUI Chart

## Export as an image

You can export the chart view as an image in the desired file format using the [SaveAsImage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SaveAsImage_System_String_) method of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). The supported image formats are **JPEG and PNG**. By default, i.e., if you didn’t mention any image format with the filename, the chart view will be exported as an image in the PNG format.

N> The chart view can be exported as an image only when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

 SfCartesianChart chart = new SfCartesianChart();
 ...
 chart.SaveAsImage("ChartSample.jpeg");

this.Content = chart;

{% endhighlight %}

{% endtabs %}

T> We can change the image formats in above code by changing its extension as .jpg, .png.

The exported image will be saved in the different location across the platforms.

**Windows Phone, Android and MAC** – The image will be saved inside the 'Pictures' directory of the file system.

**iOS** – The image will be saved inside the 'Photos/Album' directory of the file system.

To save the image on Android and Windows Phone devices, you must enable file writing permissions on the device storage.

To save the image in the photo album on iOS devices, you must enable permission to access the device storage in the "Info" file. 

Add the following code snippet to the "Info" file:

{% tabs %}

{% highlight xaml %}

<dict>
...    
<key>NSPhotoLibraryUsageDescription</key>    
<string>This App needs permission to access the Photos</string>    
<key>NSPhotoLibraryAddUsageDescription</key>    
<string>This App needs permission to access the Photos</string> 
...
</dict>

{% endhighlight %}

{% endtabs %}

## Get the stream of Chart

The [GetStreamAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_) method of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) is used to asynchronously get the chart view as a stream in the desired ImageFileFormat. The output stream can be passed as an input to other components that accept streams, such as PDF, Excel, and Word. The supported image file formats are **JPEG and PNG**.

N> The charts stream can only be rendered when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

 SfCartesianChart chart = new SfCartesianChart();
 ...
 await chart.GetStreamAsync(ImageFileFormat.Jpeg);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

N> You can refer to our [.NET MAUI Charts](https://www.syncfusion.com/maui-controls) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Charts example](https://github.com/syncfusion/maui-demos) to knows various chart types and how to easily configured with built-in support for creating stunning visual effects.



