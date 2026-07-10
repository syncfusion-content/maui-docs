---
layout: post
title: Customize Character Segments in in .NET MAUI Digital Gauge | Syncfusion
description: Learn here all about Customize Character Segments support in Syncfusion<sup>&reg;</sup> .NET MAUI Digital Gauge (SfDigitalGauge) control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---

# Customize Character Segments in .NET MAUI Digital Gauge

The characters of a digital gauge can be customized in terms of [CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth), [CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight), [CharacterSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing), and [CharacterStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke).

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfDigitalGauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/digitalgauge/getting-started)** guide.

## Customize character size

The height and width of the digital characters can be altered using the [CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight) and [CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth) properties of the digital gauge. The default value of [CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight) is 60 and [CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth) is 40.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "SYNCFUSION"
                      CharacterHeight = "117"
                      CharacterWidth = "25"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "SYNCFUSION";
digital.CharacterHeight = 117;
digital.CharacterWidth = 25;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![height-width-for-text in .NET MAUI Digital Gauge](Images\height-width-for-text.png)

## Setting character spacing

The spacing between digital characters can be customized using the [CharacterSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "01-01-24"
                      CharacterType = "EightCrossEightDotMatrix"
                      CharacterSpacing = "10"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "01-01-24";
digital.CharacterSpacing = 10;
digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![character-spacing-digitalgauge in .NET MAUI Digital Gauge](Images\character-spacing-digitalgauge.png)

## Customize character segment stroke

The color of the digital character segments can be customized using the [CharacterStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345"
                      CharacterStroke = "Purple"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.CharacterStroke = Color.Purple;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![characterstroke-digitalgauge in .NET MAUI Digital Gauge](Images\characterstroke-digitalgauge.png)

## Customize character segment width

The stroke width of the digital character segments can be customized using the [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_StrokeWidth) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345"
                      StrokeWidth = "3"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.StrokeWidth = 3;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![characterwidth-digitalgauge in .NET MAUI Digital Gauge](Images\characterwidth-digitalgauge.png)

## Customize disabled segment

The color and opacity of the disabled segments can be customized using the [DisabledSegmentStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentStroke) and [DisabledSegmentAlpha](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentAlpha) properties.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345"
                      DisabledSegmentAlpha = "0.1"
                      DisabledSegmentStroke = "LightSkyBlue"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.Text = "12345";
digital.DisabledSegmentAlpha = 0.1;
digital.DisabledSegmentStroke = Color.LightSkyBlue;
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![disabled-segment-stroke-digitalgauge in .NET MAUI Digital Gauge](Images\disabled-segment-stroke-digitalgauge.png)

## Customize background color of digital gauge

The background color of the digital gauge can be customized using the `BackgroundColor` property.


{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "12345"
                      BackgroundColor = "Blue"/>

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();
digital.BackgroundColor = Colors.Blue;
digital.Text = "12345";
this.Content = digital;

{% endhighlight %}

{% endtabs %}

![backgroundcolor-digitalgauge in .NET MAUI Digital Gauge](Images\backgroundcolor-digitalgauge.png)
