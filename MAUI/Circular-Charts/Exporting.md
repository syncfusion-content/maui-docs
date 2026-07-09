---
layout: post
title: Exporting in .NET MAUI Circular Chart control | Syncfusion
description: Learn here how to export the chart view as an image and stream in the Syncfusion® .NET MAUI Circular Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Exporting in .NET MAUI Circular Chart

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCircularChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/circularchart/getting-started)** guide.

## Export as an image

You can export the chart view as an image in the desired file format using the [SaveAsImage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SaveAsImage_System_String_) method of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html). The supported image formats are **JPEG (.jpeg, .jpg) and PNG (.png)**. By default, if no format is specified with the filename, the chart view will be exported as a PNG image.

N> The chart view can be exported as an image only when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
// code omitted for brevity
this.Content = chart;
chart.SaveAsImage("ChartSample.jpeg");

{% endhighlight %}

{% endtabs %}

T> Change the file extension (.jpg, .jpeg, or .png) to export in a different image format.

The exported image will be saved in different locations across platforms:

* **Windows and Android** — The image is saved in the Pictures directory.
* **macOS and iOS** — The image is saved in the Photos/Album directory.

### Platform-specific permissions

**Windows and Android**

To save the image on Android and Windows devices, you must enable file writing permissions on the device storage.

**iOS**

To save the image to the photo album on iOS devices, add the following permissions to the `Info.plist` file:

{% tabs %}

{% highlight xaml %}

<dict>
    <key>NSPhotoLibraryUsageDescription</key>    
    <string>This app needs permission to access your photos</string>    
    <key>NSPhotoLibraryAddUsageDescription</key>    
    <string>This app needs permission to save to your photo library</string> 
</dict>

{% endhighlight %}

{% endtabs %}

If permission is denied by the user, the `SaveAsImage` method will fail silently. Consider implementing permission handling to notify users of the result.

## Get the chart as a stream

The [GetStreamAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_) method of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html) asynchronously returns the chart view as a `Stream` in the desired [ImageFileFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ImageFileFormat.html). The output stream can be passed to other components that accept streams, such as PDF, Excel, and Word. The supported image file formats are **JPEG (.jpeg, .jpg) and PNG (.png)**.

N> The chart stream can only be rendered when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
// code omitted for brevity
this.Content = chart;
Stream stream = await chart.GetStreamAsync(ImageFileFormat.Jpeg);

{% endhighlight %}

{% endtabs %}

## Related resources

* [.NET MAUI Charts feature tour](https://www.syncfusion.com/maui-controls) — Explore groundbreaking features and capabilities.
* [.NET MAUI Charts examples](https://github.com/syncfusion/maui-demos) — Discover various chart types and their configurations.



