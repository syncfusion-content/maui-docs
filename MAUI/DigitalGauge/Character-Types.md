---
layout: post
title: Character Types in Maui Digital Gauge control | Syncfusion
description: Learn here all about Character Types support in Syncfusion Maui Digital Gauge (SfDigitalGauge) control and more.
platform: MAUI
control: DigitalGauge
documentation: ug
---

# Character Types in Maui Digital Gauge (SfDigitalGauge)

The digital characters can be drawn in the following four different segments:

•	Seven

•	Fourteen

•	Sixteen

•	EightCrossEightDotMatrix

## Seven segment

The seven-segment type is capable of displaying numbers and a few uppercase letters efficiently.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="1 2 3 4 5" StrokeWidth="5" 
                          HeightRequest="100"  WidthRequest="300"
                          DisabledSegmentAlpha="0.1" DisabledSegmentStroke="LightSkyBlue"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SevenSegment" 
                         CharacterStroke="#146CED"/>

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 300;

            this.BackgroundColor = Color.White;

            digital.Text = "1 2 3 4 5";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.StrokeWidth = 5;

            digital.CharacterType = DigitalGaugeCharacterType.SevenSegment;

            digital.DisabledSegmentAlpha = 0.1;

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.LightSkyBlue;

{% endhighlight %}

{% endtabs %}


## Fourteen segment

The fourteen-segment type is capable of displaying numbers and the alphabet efficiently.

## Sixteen segment

The sixteen-segment type is capable of displaying numbers and the alphabet clearly.

## EightCrossEightDotMatrix segment

The dot matrix segment type is capable of displaying numbers, the alphabet, and special characters efficiently.
