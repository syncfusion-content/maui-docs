---
layout: post
title: Display Types in Maui Digital Gauge control | Syncfusion
description: Learn here all about Display Types support in Syncfusion Maui Digital Gauge (SfDigitalGauge) control and more.
platform: MAUI
control: DigitalGauge
documentation: ug
---

# Display Types in Maui Digital Gauge (SfDigitalGauge)

The digital gauge displays numbers, alphabet, and special characters, which are given in the text property.

## Setting value to number

Numbers can be displayed in digital gauge in different formats using the `CharacterType`property.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="12 34 56" StrokeWidth="5" 
                          HeightRequest="100"  WidthRequest="300"
                          DisabledSegmentAlpha="25" DisabledSegmentStroke="LightSkyBlue"
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

            digital.CharacterType = CharacterType.SevenSegment;

            digital.DisabledSegmentAlpha = 25;

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.LightSkyBlue;


{% endhighlight %}

{% endtabs %}

## Setting value to alphabet

Alphabet can be displayed in digital gauge using any one of the character format types.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="SYNCFUSION" StrokeWidth="3" 
                          HeightRequest="100"  WidthRequest="340"
                          DisabledSegmentAlpha="25" DisabledSegmentStroke="Green"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SixteenSegment" 
                          CharacterStroke="Green"/>

{% endhighlight %}

{% highlight c# %}

           SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 340;

            digital.Text = "SYNCFUSION";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.StrokeWidth = 3;

            digital.CharacterType = CharacterType.SixteenSegment;

            digital.DisabledSegmentAlpha = 25;

            digital.CharacterStroke = Color.Green;

            digital.DisabledSegmentStroke = Color.Green;

{% endhighlight %}

{% endtabs %}

## Setting value to special characters

Special characters can also be displayed in digital gauge using the EightCrossEightDotMatrix character format type.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="@ # $ % *" StrokeWidth="3" 
                          HeightRequest="100"  WidthRequest="350"
                          DisabledSegmentAlpha="25" DisabledSegmentStroke="Red"
                          CharacterHeight="90" CharacterWidth="30" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="EightCrossEightDotMatrix" 
                          CharacterStroke="Red"/>

{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 350;

            digital.Text = "@ # $ % *";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 30;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.StrokeWidth = 3;

            digital.CharacterType = CharacterType.EightCrossEightDotMatrix;

            digital.DisabledSegmentAlpha = 25;

            digital.CharacterStroke = Color.Red;

            digital.DisabledSegmentStroke = Color.Red;

{% endhighlight %}

{% endtabs %}

