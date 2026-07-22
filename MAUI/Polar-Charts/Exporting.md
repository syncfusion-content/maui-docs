---
layout: post
title: Exporting in .NET MAUI Polar Chart Control | Syncfusion
description: Learn here how to export the chart view as an image and stream in the Syncfusion® .NET MAUI Polar Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Exporting in .NET MAUI Polar Chart

## Export as an image

You can export the chart view as an image in the desired file format using the [SaveAsImage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SaveAsImage_System_String_) method of [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html). The supported image formats are **JPEG and PNG**. By default, if you don't mention any image format with the filename, the chart view will be exported as an image in the PNG format.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfPolarChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/polar-charts/getting-started)** guide.

N> The chart view can be exported as an image only when the chart view is added to the visual tree.

The following code sample demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
// code omitted for brevity 
this.Content = chart;
chart.SaveAsImage("ChartSample.jpeg");

{% endhighlight %}

{% endtabs %}

T> We can change the image formats in the above code by changing their extensions to .jpg or .png.

The exported image will be saved in different locations across platforms:

- **Windows and Android** – The image will be saved in the device's Pictures directory.
- **iOS** – The image will be saved in the Photos/Album directory.
- **macOS** – The image will be saved in the designated Pictures folder.

To save images on Android and Windows devices, enable file writing permissions in the device storage.

To save images in the photo album on iOS devices, enable photo library access by adding the following keys to the **Info.plist** file:

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

## Get the stream of Chart

The [GetStreamAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_) method of [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html) is used to asynchronously get the chart view as a stream in the desired ImageFileFormat. The output stream can be passed as an input to other components that accept streams, such as PDF, Excel, and Word. The supported image file formats are **JPEG and PNG**.

N> The charts stream can only be rendered when the chart view is added to the visual tree.

The following code sample demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
// code omitted for brevity 
this.Content = chart;
await chart.GetStreamAsync(ImageFileFormat.Jpeg);

{% endhighlight %}

{% endtabs %}

N> You can refer to our [.NET MAUI Charts](https://www.syncfusion.com/maui-controls) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Charts example](https://github.com/syncfusion/maui-demos) to knows various chart types and how to easily configured with built-in support for creating stunning visual effects.