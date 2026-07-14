---
layout: post
title: Character Types in .NET MAUI Digital Gauge | Syncfusion
description: Learn here all about Character Types support in Syncfusion<sup>&reg;</sup> .NET MAUI Digital Gauge (SfDigitalGauge) control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---

# Character Types in .NET MAUI Digital Gauge

The digital characters can be displayed in the following four different segments by using the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property. The default value of the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property is [SevenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SevenSegment).

* [SevenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SevenSegment)
* [FourteenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_FourteenSegment)
* [SixteenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SixteenSegment)
* [EightCrossEightDotMatrix](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_EightCrossEightDotMatrix)

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfDigitalGauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/digitalgauge/getting-started)** guide.

## Seven segment

The seven-segment type is capable of displaying numbers and a few uppercase letters efficiently by setting the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property to [SevenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SevenSegment).
{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345" 
                      CharacterType = "SevenSegment"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.CharacterType = DigitalGaugeCharacterType.SevenSegment;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![seven-segment in .NET MAUI Digital Gauge](Images\seven-segment.png)

## Fourteen segment

The fourteen-segment type is capable of displaying numbers and the alphabet efficiently by setting the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property to [FourteenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_FourteenSegment).

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345" 
                      CharacterType = "FourteenSegment"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.CharacterType = DigitalGaugeCharacterType.FourteenSegment;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![fourteen-segment in .NET MAUI Digital Gauge](Images\fourteen-segment.png)

## Sixteen segment

The sixteen-segment type is capable of displaying numbers and the alphabet clearly by setting the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property to [SixteenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SixteenSegment).

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345" 
                      CharacterType = "SixteenSegment"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.CharacterType = DigitalGaugeCharacterType.SixteenSegment;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![sixteen-segment in .NET MAUI Digital Gauge](Images\sixteen-segment.png)

## EightCrossEightDotMatrix segment

The dot matrix segment type is capable of displaying numbers, the alphabet, and special characters efficiently by setting the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property to [EightCrossEightDotMatrix](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_EightCrossEightDotMatrix).

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345" 
                      CharacterType = "EightCrossEightDotMatrix"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![eightcrosseightdotmatrix-segment in .NET MAUI Digital Gauge](Images\eightcrosseightdotmatrix-segment.png)
