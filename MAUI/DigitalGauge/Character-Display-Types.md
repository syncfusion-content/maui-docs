---
layout: post
title: Character Display Types in .NET MAUI Digital Gauge | Syncfusion
description: Learn here all about Display Types support in Syncfusion .NET MAUI Digital Gauge (SfDigitalGauge) control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---

# Character Display Types in .NET MAUI Digital Gauge (SfDigitalGauge)

The digital gauge displays numbers, the alphabet, and special characters, which are given in the text property.

## Setting value to Display number Character

Numbers can be displayed in a digital gauge in different formats using the `CharacterType` property.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="12 34 56"/>

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "12 34 56";

{% endhighlight %}

{% endtabs %}

## Setting value to Display alphabets

Alphabet can be displayed in a digital gauge using any one of the character format types.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="SYNCFUSION" 
                          CharacterType="SixteenSegment"/>

{% endhighlight %}

{% highlight c# %}

           SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "SYNCFUSION";

            digital.CharacterType = DigitalGaugeCharacterType.SixteenSegment;

{% endhighlight %}

{% endtabs %}

## Setting value to display special characters

Special characters can also be displayed in digital gauge using the EightCrossEightDotMatrix character format type.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="@ # $ % *"
                          CharacterType="EightCrossEightDotMatrix" />

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Text = "@ # $ % *";

            digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;

{% endhighlight %}

{% endtabs %}
