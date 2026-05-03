---
layout: post
title: Saving and Retrieving Barcode Images and Streams .NET MAUI Barcode Generator | Syncfusion
description: This section explains how to save the barcode control as an image and retrieve it as a stream in the .NET MAUI SfBarcodeGenerator.
platform: maui
control: SfBarcodeGenerator
documentation: ug
---

# Save Barcode as Image
 
The [SaveAsImage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_SaveAsImage_System_String_) method is used to save the barcode view as an image in the desired file format. The following image formats are currently supported:
 
* PNG (default)
* JPEG
  
You can save the barcode view by passing the file name to the `SaveAsImage` method.
 
{% tabs %}

{% highlight xaml %}

        <barcode:SfBarcodeGenerator x:Name="barcode"
                                    Value="https://www.syncfusion.com/" 
                                    HorizontalOptions="Center" 
                                    HeightRequest="250" 
                                    WidthRequest="250">
            <barcode:SfBarcodeGenerator.Symbology>
                 <barcode:QRCode />
            </barcode:SfBarcodeGenerator.Symbology>
        </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# %}

  barcode.SaveAsImage("Test");

{% endhighlight %}

{% endtabs %}
 
By default, the barcode is saved in **PNG** format when no file extension is specified.
 
To explicitly specify the image format, include the appropriate file extension:
 
### Save as PNG:
 
{% tabs %}

{% highlight C# %}

  barcode.SaveAsImage("Test.png");

{% endhighlight %}

{% endtabs %}
 
### Save as JPEG:

{% tabs %}

{% highlight C# %}

  barcode.SaveAsImage("Test.jpeg");

{% endhighlight %}

{% endtabs %}
 
## Saved Location
 
The saved location varies based on the platform:
 
* **Windows, Android, and macOS**: The image is saved in the **Pictures** folder.
* **iOS**: The image is saved in the **Photos Album**.
 
## File Replacement Behavior
 
The behavior when saving a file with an existing name differs by platform:
 
* **Windows and macOS**: The existing file is replaced with the new file while retaining the same file name.
 
* **Android**
 
  * When saving the same view with an existing file name, the new image is saved with a number appended (for example, `Test(1).jpeg`), and the existing file (`Test.jpeg`) is removed.
  * When saving a different view with the same file name, the new image is saved with a number appended (for example, `Test(1).jpeg`), and the existing file remains unchanged.
 
* **iOS**: Due to platform limitations, the image is saved with a system-generated file name (for example, `IMG_001.jpeg`, `IMG_002.png`).
 
N> The barcode view can be saved as an image only when it is added to the **visual tree**.
  
# Get Barcode as Stream
 
The [GetStreamAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_) method is used to convert the barcode view into a stream. The following file formats are currently supported:
 
* PNG
* JPEG
  
You can retrieve the barcode stream by specifying the required file format.
 
### Get stream in PNG format:

{% tabs %}

{% highlight C# %}

  var stream = await barcode.GetStreamAsync(ImageFileFormat.Png);

{% endhighlight %}

{% endtabs %}
  
### Get stream in JPEG format:

{% tabs %}

{% highlight C# %}

  var stream = await barcode.GetStreamAsync(ImageFileFormat.Jpeg);

{% endhighlight %}

{% endtabs %}

N> The barcode stream can be generated only when the barcode view is added to the **visual tree**.