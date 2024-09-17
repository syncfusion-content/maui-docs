---
layout: post
title: Getting Started with .NET MAUI Barcode Generator control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Barcode Generator(SfBarcodeGenerator) control and more.
platform: maui
control: SfBarcodeGenerator
documentation: ug
---

# Getting Started with .NET MAUI Barcode Generator

This section explains the steps required to add the [`.NET MAUI Barcode Generator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.html) control. This section explains the steps required to add the barcode and set its symbology. This section covers only basic features needed to get started with Syncfusion barcode generator control. Follow the steps below to add a .NET MAUI Barcode generator to your project.

To get start quickly with our .NET MAUI Barcode Generator, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=WwdtIotODpE"%}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press enter.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion MAUI Barcode NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Barcode](https://www.nuget.org/packages/Syncfusion.Maui.Barcode/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI Barcode generator 

Add the following namespace to add .NET MAUI Barcode Generator.

{% tabs %}

{% highlight xaml %}

    xmlns:barcode="clr-namespace:Syncfusion.Maui.Barcode;assembly=Syncfusion.Maui.Barcode"

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Barcode;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight xaml hl_lines="1" %}

<barcode:SfBarcodeGenerator Value="http://www.syncfusion.com" 
                            HeightRequest="150"/>

{% endhighlight %}

{% highlight c# hl_lines="1" %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "http://www.syncfusion.com";
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Intialize Barcode](images/getting-started/maui-intialize-barcode.png)

N> The default symbology of SfBarcodeGenerator is [`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html).

## Initialize QR Code symbology

You can set the required symbology type to the barcode generator based on input value by initializing the [`Symbology`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_Symbology) property. In the following code sample, the QR code is set as the barcode symbology.

{% tabs %}

{% highlight xaml hl_lines="5" %}

        <barcode:SfBarcodeGenerator Value="https://www.syncfusion.com/" 
                                    HeightRequest="350" 
                                    WidthRequest="350">
            <barcode:SfBarcodeGenerator.Symbology>
                <barcode:QRCode />
            </barcode:SfBarcodeGenerator.Symbology>
        </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# hl_lines="5" %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 350;
barcode.WidthRequest = 350;
barcode.Value = "https://www.syncfusion.com/";
barcode.Symbology = new QRCode();
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Intialize QR Code Symbology](images/getting-started/maui-symbology-qrcode.png)

## Display input value

The provided input value can be displayed below the barcode by enabling the ShowText property of barcode as shown in the following code sample.

{% tabs %}

{% highlight xaml hl_lines="2" %}

        <barcode:SfBarcodeGenerator Value="https://www.syncfusion.com/" 
                                    ShowText="True" 
                                    TextSpacing="15" 
                                    HeightRequest="350" 
                                    WidthRequest="350">
            <barcode:SfBarcodeGenerator.Symbology>
                <barcode:QRCode />
            </barcode:SfBarcodeGenerator.Symbology>
        </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# hl_lines="6" %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 350;
barcode.WidthRequest = 350;
barcode.Value = "https://www.syncfusion.com/";
barcode.Symbology = new QRCode();
barcode.ShowText = true;
barcode.TextSpacing = 15;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Display Input Value](images/getting-started/maui-display-input-value.png)

N> You can refer to our [.NET MAUI Barcode Generator](https://www.syncfusion.com/maui-controls/maui-barcodes) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Barcode Generator example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Barcode) that shows you how to render the Barcode Generator in .NET MAUI.
