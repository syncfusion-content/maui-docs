---
layout: post
title: Customize Character Segments in .NET MAUI Digital Gauge | Syncfusion
description: Learn here all about Customize Character Segments support in Syncfusion .NET MAUI Digital Gauge (SfDigitalGauge) control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---

# Customize Character Segments in .NET MAUI Digital Gauge

The characters of a digital gauge can be customized in terms of [CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth), [CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight), [CharacterSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing), and [CharacterStrokeColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke).

## Customize character size

The values of digital characters are scaled by altering the height and width of digital characters. This is achieved by setting the [CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight) and [CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth) properties in the digital gauge. The default value of [CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight) is 60 and [CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth) is 40.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="SYNCFUSION" 
                          CharacterHeight="60" CharacterWidth="40"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "SYNCFUSION";

            digital.CharacterHeight = 117;

            digital.CharacterWidth = 25;

{% endhighlight %}

{% endtabs %}

![height-width-for-text](Images\height-width-for-text.png)

## Setting character spacing

The values of digital characters are spaced by altering the space between digital characters. This is achieved by setting the [CharacterSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing) property.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="01-01-24" 
                           CharacterType="EightCrossEightDotMatrix"
                           CharacterSpacing="10"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Time = "01-01-24";

            digital.CharacterSpacing = 10;

            digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;

{% endhighlight %}

{% endtabs %}

![character-spacing-digitalgauge](Images\character-spacing-digitalgauge.png)

## Customize character segment stroke

The values of digital characters color can be customized using the [CharacterStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke) property.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="1 2 3 4 5" "
                          CharacterStroke="Purple"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "1 2 3 4 5";

            digital.CharacterStroke = Color.Purple;

{% endhighlight %}

{% endtabs %}

![characterstroke-digitalgauge](Images\characterstroke-digitalgauge.png)

## Customize character segment width

The width of the digital character value can be customized using the [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_StrokeWidth) property.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="1 2 3 4 5" 
                           StrokeWidth="3"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "1 2 3 4 5";

            digital.StrokeWidth = 3;

{% endhighlight %}

{% endtabs %}

![characterwidth-digitalgauge](Images\characterwidth-digitalgauge.png)

## Customize disabled segment

You can customize the color and opacity of disabled segments using the [DisabledSegmentStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentStroke) and [DisabledSegmentAlpha](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentAlpha) properties.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="1 2 3 4 5" 
                          DisabledSegmentAlpha="0.1" DisabledSegmentStroke="LightSkyBlue"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "1 2 3 4 5";

            digital.DisabledSegmentAlpha = 0.1

            digital.DisabledSegmentStroke = Color.LightSkyBlue;

{% endhighlight %}

{% endtabs %}

![disabled-segment-stroke-digitalgauge](Images\disabled-segment-stroke-digitalgauge.png)

## Customize background color of digital gauge

You can customize the background color of the digital gauge using the `BackgroundColor` property.


{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="1 2 3 4 5" 
                          BackgroundColor="Blue"/>

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            this.BackgroundColor = Colors.Blue;

            digital.Text = "1 2 3 4 5";

{% endhighlight %}

{% endtabs %}

![backgroundcolor-digitalgauge](Images\backgroundcolor-digitalgauge.png)
