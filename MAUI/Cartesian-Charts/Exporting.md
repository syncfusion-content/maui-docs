---
layout: post
title: Exporting in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here how to export the chart view as an image and stream in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart exporting, maui chart exporting, .net maui chart exporting options, syncfusion maui chart exporting, .net maui chart exporting visualization, .net maui cartesian chart export support.
---

# Exporting in .NET MAUI Cartesian Chart

## Export as an image

You can export the chart view as an image in the desired file format using the [SaveAsImage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SaveAsImage_System_String_) method of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). The supported image formats are **JPEG and PNG**. By default, if you don't mention any image format with the filename, the chart view will be exported as an image in the PNG format.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

N> The chart view can be exported as an image only when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
//code omitted for brevity
this.Content = chart;
chart.SaveAsImage("ChartSample.jpeg");

{% endhighlight %}

{% endtabs %}

T> You can change the image format in the above code by changing the extension to `.jpg` or `.png`.

The exported image will be saved in different locations across platforms.

**Windows and Android** – The image will be saved inside the 'Pictures' directory of the file system.

**macOS** – The image will be saved inside the 'Pictures' directory of the file system.

**iOS** – The image will be saved inside the 'Photos/Album' directory of the file system.

To save the image on Android devices, you must enable file writing permissions on the device storage.

To save the image in the photo album on iOS devices, you must enable permission to access the device storage in the `Info.plist` file. 

Add the following code snippet to the `Info.plist` file:

{% tabs %}

{% highlight xaml %}

<dict>
    <!-- code omitted for brevity -->    
    <key>NSPhotoLibraryUsageDescription</key>    
    <string>This App needs permission to access the Photos</string>    
    <key>NSPhotoLibraryAddUsageDescription</key>    
    <string>This App needs permission to access the Photos</string> 
    <!-- code omitted for brevity -->
</dict>

{% endhighlight %}

{% endtabs %}

## Get the stream of chart

The [GetStreamAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_) method of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) is used to asynchronously get the chart view as a stream in the desired `ImageFileFormat`. The output stream can be passed as an input to other components that accept streams, such as PDF, Excel, and Word. The supported image file formats are **JPEG and PNG**.

N> The chart stream can only be rendered when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
//code omitted for brevity
this.Content = chart;
await chart.GetStreamAsync(ImageFileFormat.Jpeg);

{% endhighlight %}

{% endtabs %}

N> You can refer to our [.NET MAUI Charts](https://www.syncfusion.com/maui-controls) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Charts example](https://github.com/syncfusion/maui-demos) to know various chart types and how to easily configure them with built-in support for creating stunning visual effects.



