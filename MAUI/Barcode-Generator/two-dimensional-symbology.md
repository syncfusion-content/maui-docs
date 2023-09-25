---
layout: post
title: 2D symbology in .NET MAUI Barcodes (SfBarcodeGenerator) | Syncfusion
description: Learn here all about two dimensional symbology of Syncfusion .NET MAUI Barcodes(SfBarcodeGenerator) control with key features and more.
platform: maui
control: SfBarcodeGenerator
documentation: ug
---

# Two-dimensional symbology in .NET MAUI Barcodes (SfBarcodeGenerator)

Two-dimensional [.NET MAUI Barcode Generator](https://www.syncfusion.com/maui-controls/maui-barcodes) is a way to represent information by using the two-dimensional approach. It is similar to one-dimensional barcode, but it can represent more data per unit area. The barcode generator control supports the following two-dimensional symbology:

* [`QR Code`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html)
* [`Data Matrix`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrix.html)

## QR Code

A [`QR Code`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html) is a two-dimensional barcode that consists of a grid of dark and light dots or blocks that form a square. The data encoded in the barcode can be numeric, alphanumeric, or Shift JIS characters.

* The QR Code uses versions from 1 to 40. Version 1 measures 21 modules x 21 modules, Version 2 measures 25 modules x 25 modules, and so on. The number of modules increases in steps of 4 modules per side up to Version 40, which measures 177 modules x 177 modules.
* Each version has its own capacity. By default, the barcode control automatically sets the version according to the length of the input text.
* The QR Barcodes are designed for industrial uses and also commonly used in consumer advertising.

{% tabs %}

{% highlight xaml hl_lines="6" %}

   <barcode:SfBarcodeGenerator Value="www.syncfusion.com"
                               ShowText="True"
                               HeightRequest="300"
                               WidthRequest="300">
        <barcode:SfBarcodeGenerator.Symbology>
            <barcode:QRCode />
        </barcode:SfBarcodeGenerator.Symbology>
    </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# hl_lines="5" %}

    SfBarcodeGenerator barcode = new SfBarcodeGenerator();
    barcode.HeightRequest = 300;
    barcode.WidthRequest = 300;
    barcode.Value = "www.syncfusion.com";
    barcode.Symbology = new QRCode();
    barcode.ShowText = true;
    this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator QR Code Symbology](images/two-dimensional-symbology/maui-qr-code-symbology.png)

The data that can be stored in the QR code depends upon the following property:

* [`Error correction level`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_ErrorCorrectionLevel)
* [`QR code version`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCodeVersion.html)
* [`Input mode`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_InputMode)

As like one dimensional symbology, the two dimensional symbology also supports the [`Module`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SymbologyBase.html#Syncfusion_Maui_Barcode_SymbologyBase_Module) property.
The property is used to define the size of the smallest line or dot of the barcode. If this property is not set, the size of the smallest dot of the barcode is calculated based on the available size.

### Error correction level

The [`ErrorCorrectionLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_ErrorCorrectionLevel) property employs error correction to generate a series of error correction code words that are added to the data code word sequence in order to enable the symbol to withstand damage without loss of data. By default, its value is set as [`Auto`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.ErrorCorrectionLevel.html#Syncfusion_Maui_Barcode_ErrorCorrectionLevel_Auto).

Low - it recovers the data up to 7%.
Medium - it recovers the data up to 15%.
Quartile - it recovers the data up to 25%.
High - it recovers the data up to 30%.
Auto - it calculates error correction level automatically based on [`InputMode`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_InputMode) and [`CodeVersion`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_CodeVersion).

{% tabs %}

{% highlight xaml hl_lines="6" %}

    <barcode:SfBarcodeGenerator Value="www.syncfusion.com"
                                ShowText="True"
                                HeightRequest="300" 
                                WidthRequest="300">
        <barcode:SfBarcodeGenerator.Symbology>
            <barcode:QRCode ErrorCorrectionLevel="High"/>          
        </barcode:SfBarcodeGenerator.Symbology>
    </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# hl_lines="7" %}

    SfBarcodeGenerator barcode = new SfBarcodeGenerator();
    barcode.HeightRequest = 300;
    barcode.WidthRequest = 300;
    barcode.Value = "www.syncfusion.com";
    barcode.Symbology = new QRCode() 
    { 
        ErrorCorrectionLevel = ErrorCorrectionLevel.High 
    };

    barcode.ShowText = true;
    this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator QR Code error correction level high](images/two-dimensional-symbology/maui-qr-code-error-correction-level-high.png)

The data can be read from the damaged image based on the error correction level.

![.NET MAUI Barcode Generator QR Code damaged](images/two-dimensional-symbology/maui-qr-code-damaged.png)

### Input mode

The [`InputMode`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_InputMode) property allows you to select a specific set of input characters. You can select the most suitable input mode. By default, its value is set as [`Auto`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRInputMode.html#Syncfusion_Maui_Barcode_QRInputMode_Auto).

Numeric - supports from 0 to 9.
AlphaNumeric - supports 0 to 9, A to Z, space, $, %, *, +, -,., /, :.
Binary - supports Shift JIS characters.
Auto - it calculates input mode automatically based on [`CodeVersion`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_CodeVersion) and [`ErrorCorrectionLevel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_ErrorCorrectionLevel).

{% tabs %}

{% highlight xaml hl_lines="6" %}

   <barcode:SfBarcodeGenerator Value="1263438892737643894930872"
                               ShowText="True"
                               HeightRequest="300"
                               WidthRequest="300">
        <barcode:SfBarcodeGenerator.Symbology>
            <barcode:QRCode InputMode="Numeric"/>
        </barcode:SfBarcodeGenerator.Symbology>
    </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# hl_lines="7" %}

    SfBarcodeGenerator barcode = new SfBarcodeGenerator();
    barcode.HeightRequest = 300;
    barcode.WidthRequest = 300;
    barcode.Value = "1263438892737643894930872";
    barcode.Symbology = new QRCode() 
    { 
        InputMode = QRInputMode.Numeric 
    };

    barcode.ShowText = true;
    this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator QR Code Input Mode As Numeric](images/two-dimensional-symbology/maui-qr-code-input-mode-numeric.png)

### QR code version

The [`CodeVersion`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_CodeVersion) property allows you to set various types of version for QR code from QRVersion enumeration. By default, its value is set as auto.

The QR Code uses version from 1 to 40. Version 1 measures 21 modules x 21 modules, Version 2 measures 25 modules x 25 modules, and so on.

The number of modules increases in steps of 4 modules per side up to Version 40, which measures 177 modules x 177 modules.

{% tabs %}

{% highlight xaml hl_lines="6" %}

    <barcode:SfBarcodeGenerator Value="www.syncfusion.com"
                                ShowText="True"
                                HeightRequest="300" 
                                WidthRequest="300">
        <barcode:SfBarcodeGenerator.Symbology>
            <barcode:QRCode CodeVersion="Version09"/>
        </barcode:SfBarcodeGenerator.Symbology>
     </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# hl_lines="7" %}

    SfBarcodeGenerator barcode = new SfBarcodeGenerator();
    barcode.HeightRequest = 300;
    barcode.WidthRequest = 300;
    barcode.Value = "www.syncfusion.com";
    barcode.Symbology = new QRCode() 
    { 
        CodeVersion = QRCodeVersion.Version09 
    };

    barcode.ShowText = true;
    this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator QR Code Version09](images/two-dimensional-symbology/maui-qr-code-version09.png)

## Data Matrix

[`Data Matrix`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrix.html) barcode is a two dimensional barcode that consists of a grid of dark and light dots or blocks forming a square or rectangular symbol. The data encoded in the barcode can either be numbers or alphanumeric characters. They are widely used in printed media such as labels and letters. You can read it easily with the help of a barcode reader and mobile phones.

{% tabs %}

{% highlight xaml hl_lines="6" %}

    <barcode:SfBarcodeGenerator Value="www.syncfusion.com"
                                ShowText="True"
                                HeightRequest="300" 
                                WidthRequest="300">
        <barcode:SfBarcodeGenerator.Symbology>
            <barcode:DataMatrix/>
        </barcode:SfBarcodeGenerator.Symbology>
    </barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# hl_lines="5" %}

    SfBarcodeGenerator barcode = new SfBarcodeGenerator();
    barcode.HeightRequest = 300;
    barcode.WidthRequest = 300;
    barcode.Value = "www.syncfusion.com";
    barcode.Symbology = new DataMatrix();
    barcode.ShowText = true;
    this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Data Matrix Symbology](images/two-dimensional-symbology/maui-data-matrix.png)

### Data Matrix format

Length - Data Matrix can store up to 2335 alphanumeric characters or 3116 numbers from the ASCII range.

Type - Data Matrix supports the following data types:

* [`Numeric`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRInputMode.html#Syncfusion_Maui_Barcode_QRInputMode_Numeric)
* [`Alpha Numeric`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRInputMode.html#Syncfusion_Maui_Barcode_QRInputMode_AlphaNumeric)
* [`Binary`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRInputMode.html#Syncfusion_Maui_Barcode_QRInputMode_Binary)

The [`Size`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrix.html#Syncfusion_Maui_Barcode_DataMatrix_Size) depends upon the length and data type of provided input values.

### Encoding methods

Data Matrix supports following [`Encoding`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrix.html#Syncfusion_Maui_Barcode_DataMatrix_Encoding) types:

* [`Auto`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_Auto)
* [`ASCII`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_ASCII)
* [`ASCIINumeric`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_ASCIINumeric)
* [`Base256`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_Base256)

By default, the encoding types is [`Auto`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_Auto).

When the encoding type is [`ASCII`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_ASCII), the code word will be calculated as like follows,

Code word = ASCII value + 1.

The ASCII value ranges from 0 to 127.

When the encoding type is [`Base256`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_Base256), then the first code word is calculated with the value 235, and the second code value is calculated with the ASCII value - 127.

The [`Base256`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_Base256) value ranges from 128 to 255.

When the encoding type is [`ASCIINumeric`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrixEncoding.html#Syncfusion_Maui_Barcode_DataMatrixEncoding_ASCIINumeric), then the code word will be calculated as follows.

Code word = numerical value pair + 130.

The numerical value pair will be like 00, 01, 02,…..99.
