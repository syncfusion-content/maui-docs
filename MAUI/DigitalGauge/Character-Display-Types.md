---
layout: post
title: Character Display Types in .NET MAUI Digital Gauge | Syncfusion<sup>&reg;</sup>
description: Learn here all about Display Types support in Syncfusion<sup>&reg;</sup> .NET MAUI Digital Gauge (SfDigitalGauge) control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---

# Character Display Types in .NET MAUI Digital Gauge

The digital gauge displays numbers, the alphabet, and special characters, which are given in the [text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_Text) property.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfDigitalGauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/digitalgauge/getting-started)** guide.

## Display numbers

Numbers can be displayed in a digital gauge in different formats using the [CharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12 34 56"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12 34 56";
this.Content = digital;

{% endhighlight %}

{% endtabs %}

c#display-number in .NET MAUI Digital Gauge](Images\display-number.png)


## Display alphabets

Alphabets can be displayed in a digital gauge using any one of the character format types.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "SYNCFUSION" 
                      CharacterType = "SixteenSegment"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "SYNCFUSION";
digital.CharacterType = DigitalGaugeCharacterType.SixteenSegment;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

c#display-character in .NET MAUI Digital Gauge](Images\display-character.png)

## Display special characters

Special characters can also be displayed in digital gauge using the [EightCrossEightDotMatrix](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_EightCrossEightDotMatrix) character format type.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "@ # $ % *"
                      CharacterType = "EightCrossEightDotMatrix"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "@ # $ % *";
digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![display-special-character in .NET MAUI Digital Gauge](Images\display-special-character.png)
