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

The characters of a digital gauge can be customized in terms of `CharacterWidth`, `CharacterHeight`, `CharacterSpacing`, and `CharacterStrokeColor`.

## customize character size

The values of digital characters are scaled by altering the height and width of digital characters. This is achieved by setting the `CharacterHeight` and `CharacterWidth` properties in the digital gauge. The default value of `CharacterHeight` is 60 and `CharacterWidth` is 40.
`
{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="SYNCFUSION" 
                          CharacterHeight="60" CharacterWidth="40" 
                          CharacterStroke="#146CED"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "SYNCFUSION";

            digital.CharacterHeight = 117;

            digital.CharacterWidth = 25;

{% endhighlight %}

{% endtabs %}


## Setting character spacing

The values of digital characters are spaced by altering the space between digital characters. This is achieved by setting the `CharacterSpacing` property.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="01-01-24" 
                           CharacterType="EightCrossEightDotMatrix"
                           CharacterSpacing="10"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Time = "01-01-18";

            digital.CharacterSpacing = 10;

            digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;

{% endhighlight %}

{% endtabs %}


## Customize character segment stroke

The values of digital characters color can be customized using the `CharacterStrokeColor` property.

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

## Customize character segment width

The width of the digital character value can be customized using the `StrokeWidth` property.

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


## Customize disabled segment

You can customize the color and opacity of disabled segments using the `DisabledSegmentStroke` and `DisabledSegmentAlpha` properties.

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