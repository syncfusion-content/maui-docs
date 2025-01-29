---
layout: post
title: Migrate from Xamarin to .NET MAUI Barcode Generator | Syncfusion<sup>&reg;</sup>
description: Learn here all about Migrating from Syncfusion<sup>&reg;</sup> Xamarin SfBarcode to Syncfusion<sup>&reg;</sup> .NET MAUI SfBarcodeGenerator control and more.
platform: MAUI
control: SfBarcodeGenerator
documentation: ug
---  

# Migrate from Xamarin.Forms SfBarcode to .NET MAUI SfBarcodeGenerator

To make the migration from the [Xamarin SfBarcode](https://www.syncfusion.com/xamarin-ui-controls/xamarin-barcode) to [.NET MAUI SfBarcodeGenerator](https://www.syncfusion.com/maui-controls/maui-barcodes) easier, most of the APIs from the Xamarin SfBarcode were kept in the.NET MAUI SfBarcodeGenerator. However, to maintain the consistency of API naming in the .NET MAUI SfBarcodeGenerator, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the Barcode namespace and initialize SfBarcodeGenerator as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfBarcode</th>
<th>.NET MAUI SfBarcodeGenerator</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:syncfusion="clr-namespace:Syncfusion.SfBarcode.XForms;assembly=Syncfusion.SfBarcode.XForms">

        <syncfusion:SfBarcode/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfBarcode.XForms;
...

SfBarcode barcode = new SfBarcode();
...

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:barcode="clr-namespace:Syncfusion.Maui.Barcode;assembly=Syncfusion.Maui.Barcode">

        <barcode:SfBarcodeGenerator/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Barcode;
...

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
...

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Initialize Symbology

<table>
<tr>
<th>Xamarin SfBarcode</th>
<th>.NET MAUI SfBarcodeGenerator</th>
<th>Description</th></tr>
<tr>
<td>{{'[CodaBarSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.CodaBarSettings.html)'| markdownify }}</td>
<td>{{'[Codabar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Codabar.html)'| markdownify }}</td>
<td>It is used to configure the Codabar barcode.</td></tr>
<tr>
<td>{{'[Code39Settings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.Code39Settings.html)'| markdownify }}</td>
<td>{{'[Code39](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html)'| markdownify }}</td>
<td>It is used to configure the Code39 barcode.</td></tr>
<tr>
<td>{{'[Code39ExtendedSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.Code39ExtendedSettings.html)'| markdownify }}</td>
<td>{{'[Code39Extended](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39Extended.html)'| markdownify }}</td>
<td>It is used to configure the Code39Extended barcode.</td></tr>
<tr>
<td>{{'[Code93Settings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.Code93Settings.html)'| markdownify }}</td>
<td>{{'[Code93](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code93.html)'| markdownify }}</td>
<td>It is used to configure the Code93 barcode.</td></tr>
<tr>
<td>{{'[Code128ASettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.Code128ASettings.html)'| markdownify }}</td>
<td>{{'[Code128A](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128A.html)'| markdownify }}</td>
<td>It is used to configure the Code128A barcode.</td></tr>
<tr>
<td>{{'[Code128BSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.Code128BSettings.html)'| markdownify }}</td>
<td>{{'[Code128B](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128B.html)'| markdownify }}</td>
<td>It is used to configure the Code128B barcode.</td></tr>
<tr>
<td>{{'[Code128CSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.Code128CSettings.html)'| markdownify }}</td>
<td>{{'[Code128C](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128C.html)'| markdownify }}</td>
<td>It is used to configure the Code128C barcode.</td></tr>
<tr>
<td>{{'[QRBarcodeSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.QRBarcodeSettings.html)'| markdownify }}</td>
<td>{{'[QRCode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html)'| markdownify }}</td>
<td>It is used to configure the QRCode barcode.</td></tr>
<tr>
<td>{{'[DataMatrixEncoding](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.DataMatrixEncoding.html)'| markdownify }}</td>
<td>{{'[DataMatrix](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrix.html)'| markdownify }}</td>
<td>It is used to configure the DataMatrix barcode.</td></tr>
</table>

The following code example, explains how to initialize symbology and customize symbology settings in Xamarin SfBarcode and .NET MAUI SfBarcodeGenerator.

<table>
<tr>
<th>Xamarin SfBarcode</th>
<th>.NET MAUI SfBarcodeGenerator</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<syncfusion:SfBarcode Text="http://www.syncfusion.com"
                      BackgroundColor="Gray"
                      Symbology="QRCode">
    <syncfusion:SfBarcode.SymbologySettings>
        <syncfusion:QRBarcodeSettings XDimension="6" 
                                      ErrorCorrectionLevel="High"
                                      InputMode="BinaryMode" 
                                      Version="VersionAuto"/>
    </syncfusion:SfBarcode.SymbologySettings>
</syncfusion:SfBarcode>

{% endhighlight %}

{% highlight C# %}

SfBarcode barcode = new SfBarcode();
barcode.BackgroundColor = Color.Gray;
barcode.Text = "http://www.syncfusion.com";
barcode.Symbology = BarcodeSymbolType.QRCode;
QRBarcodeSettings settings = new QRBarcodeSettings();
settings.XDimension = 6;
settings.ErrorCorrectionLevel = ErrorCorrectionLevel.High;
settings.InputMode = InputMode.BinaryMode;
settings.Version = QRVersion.VersionAuto;
barcode.SymbologySettings = settings;
this.Content = barcode;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<barcode:SfBarcodeGenerator Value="http://www.syncfusion.com"
                            ShowText="True"
                            BackgroundColor="Gray">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:QRCode Module="2"
                        ErrorCorrectionLevel="High"
                        InputMode="Binary" 
                        CodeVersion="Auto"/>
    </barcode:SfBarcodeGenerator.Symbology>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# %}

 SfBarcodeGenerator barcode = new SfBarcodeGenerator();
 barcode.Value = "http://www.syncfusion.com";
 barcode.BackgroundColor = Colors.Gray;
 barcode.ShowText = true;
 barcode.Symbology = new QRCode() 
 { 
   Module = 2,
   InputMode = QRInputMode.Binary,
   ErrorCorrectionLevel = ErrorCorrectionLevel.High,
   CodeVersion = QRCodeVersion.Auto, 
 };
 this.Content = barcode;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Properties

<table>
<tr>
<th>Xamarin SfBarcode</th>
<th>.NET MAUI SfBarcodeGenerator</th>
<th>Description</th></tr>
<tr>
<td>{{'[Text](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.SfBarcode.html#Syncfusion_SfBarcode_XForms_SfBarcode_Text)'| markdownify }}</td>
<td>{{'[Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_Value)'| markdownify }}</td>
<td>Gets or sets the value of the SfBarcodeGenerator to be rendered, which is displayed below the Barcode element when the ShowText property is enabled.</td></tr>
<tr>
<td>{{'[TextGapHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.SfBarcode.html#Syncfusion_SfBarcode_XForms_SfBarcode_TextGapHeight)'| markdownify }}</td>
<td>{{'[TextSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextSpacing)'| markdownify }}</td>
<td>Gets or sets a value to specify the space between the text and the barcode.</td></tr>
<tr>
<td>{{'[DarkBarColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.SfBarcode.html#Syncfusion_SfBarcode_XForms_SfBarcode_DarkBarColor)' | markdownify }}</td>
<td>{{'[ForegroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_ForegroundColor)'| markdownify }}</td>
<td>Gets or sets the value that represents the color of barcode elements.</td></tr>
<tr>
<td>{{'[LightBarColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.SfBarcode.html#Syncfusion_SfBarcode_XForms_SfBarcode_LightBarColor)' | markdownify }}</td>
<td>BackgroundColor</td>
<td>Gets or sets the value that represents the background color of barcode elements.</td></tr>
<tr>
<td>{{'[Version](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBarcode.XForms.QRBarcodeSettings.html#Syncfusion_SfBarcode_XForms_QRBarcodeSettings_Version)' | markdownify }}</td>
<td>{{'[CodeVersion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html#Syncfusion_Maui_Barcode_QRCode_CodeVersion)'| markdownify }}</td>
<td>Gets or sets a value to define the version that is used to encode the amount of data.</td></tr>
</table>

## Barcode customization

The following code example explains how to customize barcode and text in Xamarin SfBarcode and .NET MAUI SfBarcodeGenerator.

In .NET MAUI SfBarcodeGenerator, text customization is achieved by using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextStyle) property of the barcode generator as follows.

<table>
<tr>
<th>Xamarin SfBarcode</th>
<th>.NET MAUI SfBarcodeGenerator</th></tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

 <syncfusion:SfBarcode Text="123456789" 
                       Symbology="Code128A"
                       TextColor="Red"
                       TextFont="16"
                       TextGapHeight="25"
                       TextLocation="Bottom"
                       TextAlignment="Center">
 </syncfusion:SfBarcode>

{% endhighlight %}

{% highlight C# %}

SfBarcode barcode = new SfBarcode(); 
barcode.Text = "123456789"; 
barcode.Symbology = BarcodeSymbolType.Code128A;
barcode.TextColor = Color.Red;
barcode.TextFont = Font.SystemFontOfSize(16);
Typeface textStyle = Typeface.create("Times new roman",1); 
barcode.TextFont = textStyle**;** 
barcode.TextGapHeight = 25;
barcode.TextLocation = BarcodeTextLocation.Bottom;
barcode.TextAlignment = BarcodeTextAlignment.Center;
this.Content = barcode; 

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %} 

{% highlight xaml %}

<barcode:SfBarcodeGenerator Value="123456789"
                            TextSpacing="25"
                            TextAlignment="Center">
    <barcode:SfBarcodeGenerator.Symbology>
        <barcode:Code128A Module="2"/>
    </barcode:SfBarcodeGenerator.Symbology>
    <barcode:SfBarcodeGenerator.TextStyle>
        <barcode:BarcodeTextStyle FontSize="16"
                                  TextColor="Red"/>
    </barcode:SfBarcodeGenerator.TextStyle>
</barcode:SfBarcodeGenerator>

{% endhighlight %}

{% highlight C# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator();
barcode.Value = "123456789";
barcode.TextAlignment = TextAlignment.End;
barcode.TextSpacing = 25;
barcode.TextStyle = new BarcodeTextStyle()
{
    FontSize = 16,
    TextColor = Colors.Red
};

barcode.Symbology = new Code128A() { Module = 2 };
this.Content = barcode;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>
