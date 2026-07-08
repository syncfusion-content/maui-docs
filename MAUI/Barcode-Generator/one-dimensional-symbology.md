---
layout: post
title: One-dimensional symbology in .NET MAUI Barcodes | Syncfusion®
description: Learn here all about one dimensional symbology of Syncfusion<sup>&reg;</sup> .NET MAUI Barcodes(SfBarcodeGenerator) control with key features and more.
platform: maui
control: SfBarcodeGenerator
documentation: ug
---

# One-dimensional symbology in .NET MAUI Barcode Generator

The one-dimensional [.NET MAUI Barcode Generator](https://www.syncfusion.com/maui-controls/maui-barcodes) represents the data by varying the widths and spacings of the parallel lines. These barcode types are also known as linear barcode types. The Syncfusion<sup>&reg;</sup> .NET MAUI barcode generator supports the following one-dimensional barcode types:

* [`Codabar`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Codabar.html)
* [`Code39`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html)
* [`Code39Extended`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39Extended.html)
* [`Code93`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code93.html)
* [`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html)
* [`Code128A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128A.html)
* [`Code128B`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128B.html)
* [`Code128C`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128C.html)
* [`UPCA`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html)
* [`UPCE`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCE.html)
* [`EAN8`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN8.html)
* [`EAN13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html)

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Barcode Generator** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/barcode-generator/getting-started)** guide.

N> All one-dimensional symbologies support the [`Module`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SymbologyBase.html#Syncfusion_Maui_Barcode_SymbologyBase_Module) property, which defines the size of the smallest bar line of the barcode. By default, `Module` is not set; the smallest bar line size is automatically calculated based on the available size and the total number of bars for the provided input value.

## Codabar

* [`Codabar`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Codabar.html) is a discrete numeric symbology that is used in libraries, blood banks and a variety of other information processing applications.
* Encodes only numeric characters and some special characters such as dash (-), colon (:), slash (/), and plus (+).
* Each character has three bars and four spaces.
* Uses the characters A, B, C, and D as start and stop characters.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="123456789"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Codabar Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "123456789";
barcode.Symbology = new Codabar() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Codabar Symbology](images/one-dimensional-symbology/maui-codabar-symbology.png)

## Code39

[`Code39`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html) is a discrete, variable-length symbology that encodes alphanumeric characters into a series of bars. Each barcode begins and ends with special start and stop characters. Code39 is self-checking; a check digit is not usually required for common use. For applications requiring high accuracy, a checksum digit may be added.

* Allows character set of digits (0-9), upper case alphabets (A-Z), and symbols like space, minus (-), plus (+), period (.), dollar sign ($), slash (/), and percent (%).
* Each character is encoded with five bars and four spaces where three are wide and six are narrow.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="CODE39"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code39 Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "CODE39";
barcode.Symbology = new Code39() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code39 Symbology](images/one-dimensional-symbology/maui-code39-symbology.png)

The [`EnableCheckSum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html#Syncfusion_Maui_Barcode_Code39_EnableCheckSum) property of [`Code39`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html) barcode allows you to add the check digit along with the input value. The default value of the [`EnableCheckSum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html#Syncfusion_Maui_Barcode_Code39_EnableCheckSum) property is `true`.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="CODE39"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code39 Module="2" EnableCheckSum="False" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "CODE39";
barcode.Symbology = new Code39() { Module = 2, EnableCheckSum = false };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

## Code39Extended

* [`Code39Extended`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39Extended.html) symbology is an extended version of Code39 that supports the full 128-character ASCII set. So, it encodes lower case alphabets (a-z) as well as special characters.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="051091"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code39Extended Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "051091";
barcode.Symbology = new Code39Extended() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code39 Extended Symbology](images/one-dimensional-symbology/maui-code39-extended-symbology.png)

As with [`Code39`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html), [`Code39Extended`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39Extended.html) supports the [`EnableCheckSum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html#Syncfusion_Maui_Barcode_Code39_EnableCheckSum) property inherited from the `Code39` base type.

## Code93

[`Code93`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code93.html) is designed to complement and enhance [`Code39`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html). It represents the complete ASCII character set by using a combination of 2 characters. It is a continuous, variable-length symbology that produces a denser code.

* Encodes character set of upper case alphabets (A-Z), digits (0-9), and special characters such as asterisk (*), dash (-), dollar ($), percent (%), space, dot (.), slash (/), plus (+), and so on.
* The asterisk (*) is not a true encoding character, but it is the start and stop symbol for [`Code93`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code93.html) symbology.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="01234567"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>  
        <barcode:Code93 Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "01234567";
barcode.Symbology = new Code93() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code93 Symbology](images/one-dimensional-symbology/maui-code93-symbology.png)

## Code128

[`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html) is a highly efficient, high-density linear barcode symbology that allows the encoding of alphanumeric data. It is capable of encoding full ASCII character sets and extended character sets. This symbology contains the checksum digit for verification and the barcode can also be verified character-by-character for the parity of each data byte.

The [`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html) symbology encodes the input symbols supported by [`Code128A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128A.html), [`Code128B`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128B.html), [`Code128C`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128C.html). The default symbology type of barcode generator is [`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html).

### Code128 special characters

The last seven characters of Code Sets A and B (character values 96 - 102) and the last three characters of Code Set C (character values 100 - 102) are special non-data characters with no ASCII character equivalents that have a particular significance to the barcode reading device.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="CODE128"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
            <barcode:Code128 Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "CODE128";
barcode.Symbology = new Code128() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code128 Symbology](images/one-dimensional-symbology/maui-code128-symbology.png)

## Code128A

[`Code128A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128A.html) (or Code Set A) includes all the standard upper case U.S. alphanumeric keyboard characters and punctuation characters, as well as the control characters (characters with ASCII values from 0 to 95 inclusive) and seven special characters.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="CODE128A"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code128A Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "CODE128A";
barcode.Symbology = new Code128A() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code128A Symbology](images/one-dimensional-symbology/maui-code128a-symbology.png)

## Code128B

[`Code128B`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128B.html) (or Code Set B) includes all the standard upper case alphanumeric keyboard characters and punctuation characters, as well as the lower case alphabetic characters (characters with ASCII values from 32 to 127 inclusive) and seven special characters.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="CODE128B"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code128B Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "CODE128B";
barcode.Symbology = new Code128B() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code128B Symbology](images/one-dimensional-symbology/maui-code128b-symbology.png)

## Code128C

[`Code128C`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128C.html) (or Code Set C) includes a set of 100 digit pairs from 00 to 99 inclusive, as well as three special characters. This allows numeric data to be encoded as two data digits per symbol character, effectively twice the density of standard data.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="1234567890"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code128C Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "1234567890";   
barcode.Symbology = new Code128C() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Code128C Symbology](images/one-dimensional-symbology/maui-code128c-symbology.png)

## UPCA

[`UPC-A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html) symbology supports only numeric characters. It encodes 11 digits of provided numeric input (0 to 9) along with a check digit at its end, for a total of 12 digits of input data. If you give 11 numeric inputs, the check digit should automatically calculate at the end, and if you give 12 numeric inputs, the last digit should be check digit, otherwise the input will be rejected.

* This type is mainly used for worldwide retail.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="72527273070"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:UPCA Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "72527273070";
barcode.Symbology = new UPCA() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator UPC-A Symbology](images/one-dimensional-symbology/maui-upca-symbology.png)

## UPCE

Like [`UPC-A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html), the [`UPC-E`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCE.html) symbology supports only numeric characters. It is a zero-suppressed version of the [`UPC-A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html) symbology where it uses only 6 digits of product code and does not use the middle guard. By default, the number system (0) will be added at the front and the check digit at the end, along with 6 digits of the input product code.

* This type is mainly used on products with very small packaging details.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="310194"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:UPCE Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "310194";
barcode.Symbology = new UPCE() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator UPC-E Symbology](images/one-dimensional-symbology/maui-upce-symbology.png)

## EAN8

[`EAN8`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN8.html) is equivalent to the [`UPCE`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCE.html) for small packaging details. It is shorter than the [`EAN13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html) barcode and it is longer than [`UPCE`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCE.html).

Like [`EAN13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html) and [`UPCE`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCE.html), it encodes 7 digits of numeric data with the check digit at its end.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="11223344"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:EAN8 Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "11223344";
barcode.Symbology = new EAN8() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator EAN-8 Symbology](images/one-dimensional-symbology/maui-ean8-symbology.png)

## EAN13

The [`EAN-13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html) standard is based on the [`UPC-A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html) standard. Like [`UPC-A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html), it supports only numeric characters. It encodes 12 digits of input data with the check digit at its end.

* The difference between [`UPCA`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html) and [`EAN13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html) is that the number system used in [`EAN13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html) is a 2-digit number ranging from 00 to 99, whereas the number system used in [`UPCA`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html) is a single digit ranging from 0 to 9.

{% tabs %}

{% highlight xml %}

<barcode:SfBarcodeGenerator Value="9735940564824"
                            ShowText="True"
                            HeightRequest="150">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:EAN13 Module="2" />
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.HeightRequest = 150;
barcode.Value = "9735940564824";
barcode.Symbology = new EAN13() { Module = 2 };
barcode.ShowText = true;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator EAN-13 Symbology](images/one-dimensional-symbology/maui-ean13-symbology.png)
