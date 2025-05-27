---
layout: post
title: Character Types in .NET MAUI Digital Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn here all about Character Types support in Syncfusion<sup>&reg;</sup> .NET MAUI Digital Gauge (SfDigitalGauge) control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character displayed types
---

# Character Types in .NET MAUI Digital Gauge (SfDigitalGauge)

The digital characters can be displayed in the following four different segments:

•	SevenSegment
•	FourteenSegment
•	SixteenSegment
•	EightCrossEightDotMatrix

## Seven-Segment

The seven-segment type is capable of displayeding numbers and a few uppercase letters effectively.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="12345" 
                          CharacterType="SevenSegment" 
                         />

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "12345";

            digital.CharacterType = DigitalGaugeCharacterType.SevenSegment;

{% endhighlight %}

{% endtabs %}

![seven-segment](Images\seven-segment.png)

## Fourteen-Segment

The fourteen-segment type is capable of displayeding numbers and the alphabet effectively.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="12345" 
                          CharacterType="FourteenSegment" 
                         />

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "12345";

            digital.CharacterType = DigitalGaugeCharacterType.FourteenSegment;

{% endhighlight %}

{% endtabs %}

![fourteen-segment](Images\fourteen-segment.png)

## Sixteen-Segment

The sixteen-segment type is capable of displayeding numbers and the alphabet clearly.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="12345" 
                          CharacterType="SixteenSegment" 
                         />

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "12345";

            digital.CharacterType = DigitalGaugeCharacterType.SixteenSegment;

{% endhighlight %}

{% endtabs %}

![sixteen-segment](Images\sixteen-segment.png)

## Eight-Cross-Eight-Dot-Matrix Segment

The dot matrix segment type is capable of displayeding numbers, the alphabet, and special characters effectively.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="12345" 
                          CharacterType="EightCrossEightDotMatrix" 
                         />

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "12345";

            digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;

{% endhighlight %}

{% endtabs %}

![eightcrosseightdotmatrix-segment](Images\eightcrosseightdotmatrix-segment.png)
