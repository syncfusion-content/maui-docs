---
layout: post
title: Customize Character Segments in Maui Digital Gauge | Syncfusion
description: Learn here all about Customize Character Segments support in Syncfusion Maui Digital Gauge (SfDigitalGauge) control and more.
platform: maui 
control: DigitalGauge
documentation: ug
---

# Customize Character Segments in Maui Digital Gauge (SfDigitalGauge)

The characters of a digital gauge can be customized in terms of `CharacterWidth`, `CharacterHeight`, `CharacterSpacing`, and `CharacterStrokeColor`.

## customize character size

The values of digital characters are scaled by altering the height and width of digital characters. It is achieved by setting the `CharacterHeight`and `CharacterWidth` properties in the digital gauge. Default value of `CharacterHeight` and `CharacterWidth` is 25.

{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="SYNCFUSION" StrokeWidth="4" 
                          HeightRequest="120"  WidthRequest="330" 
                          BackgroundColor="Black"
                          DisabledSegmentAlpha="0.1" DisabledSegmentStroke="#146CED"
                          CharacterHeight="117" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SevenSegment" 
                          CharacterStroke="#146CED"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 120;

            digital.WidthRequest = 330;

            digital.Text = "SYNCFUSION";

            digital.CharacterHeight = 117;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.StrokeWidth = 4;

            digital.CharacterType = DigitalGaugeCharacterType.SevenSegment;

            digital.DisabledSegmentAlpha = 0.1;

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.FromRgb(20, 108, 237);

{% endhighlight %}

{% endtabs %}


## Setting character spacing

The values of digital characters are spaced by altering the space of digital characters. It is achieved by setting the `CharacterSpacing` property.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="01-01-24" StrokeWidth="3" 
                          HeightRequest="100"  WidthRequest="360" CharacterSpacing="10"
                          DisabledSegmentAlpha="0.1" DisabledSegmentStroke="#146CED"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="EightCrossEightDotMatrix"                
                          CharacterStroke="#146CED"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 360;

            digital.Time = "01-01-18";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.StrokeWidth = 3;

            digital.CharacterSpacing = 10;

            digital.CharacterType = DigitalGaugeCharacterType.EightCrossEightDotMatrix;

            digital.DisabledSegmentAlpha = 0.1;

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.FromRgb(20, 108, 237);

{% endhighlight %}

{% endtabs %}


## Customize character segment stroke

The values of digital characters color can be customized using the `CharacterStrokeColor` property.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge Text="1 2 3 4 5" StrokeWidth="3" 
                          HeightRequest="100"  WidthRequest="300"
                          DisabledSegmentAlpha="0.1" DisabledSegmentStroke="#146CED"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SevenSegment" 
                          CharacterStroke="Purple"/>
{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 300;

            digital.Text = "1 2 3 4 5";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.StrokeWidth = 3;

            digital.CharacterType = DigitalGaugeCharacterType.SevenSegment;

            digital.DisabledSegmentAlpha = 0.1;

            digital.CharacterStroke = Color.Purple;

            digital.DisabledSegmentStroke = Color.FromRgb(20, 108, 237);

{% endhighlight %}

{% endtabs %}


## Customize disabled segment

You can customize the color and opacity of disabled segments using the `DisabledSegmentStroke` and `DisabledSegmentStroke`properties. The width of the digital character value can be customized using the `StrokeWidth` property.

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

            digital.DisabledSegmentAlpha = 0.1

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.LightSkyBlue;

{% endhighlight %}

{% endtabs %}

## Customize background color of digital gauge

You can customize the background color of the digital gauge using the `BackgroundColor` property.


{% tabs %}

{% highlight xaml %}

    <gauge:SfDigitalGauge Text="1 2 3 4 5" StrokeWidth="5" 
                          HeightRequest="100"  WidthRequest="300"
                          DisabledSegmentAlpha="0.1" DisabledSegmentStroke="LightSkyBlue"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SevenSegment" BackgroundColor="LightPink"
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

            digital.DisabledSegmentAlpha = 0.1;

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.LightSkyBlue;

{% endhighlight %}

{% endtabs %}
