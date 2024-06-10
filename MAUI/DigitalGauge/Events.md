---
layout: post
title: About .NET MAUI Digital Gauge control | Syncfusion
description: Learn here all about introduction of Syncfusion .NET MAUI Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---
# Events in .NET MAUI DigitalGauge

## TextChanged

The `TextChanged` event is triggered when the text is changed. The associated argument contains the following information.

* sender - Gets details of a sender.
* DigitalGaugeTextChangedEventArgs - Holds the text changed event arguments.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Grid.Row="3" Text="syncfusion" 
                        TextChanged="SfDigitalGauge_TextChanged"
                        StrokeWidth="3" CharacterSpacing="23"
                        CharacterHeight="90" 
                        CharacterWidth="70" 
                        CharacterType="EightCrossEightDotMatrix" 
                        CharacterStroke="Orange" />
            
{% endhighlight %}

{% highlight c# %}

private void SfDigitalGauge_TextChanged(object sender, Syncfusion.Maui.Gauges.DigitalGaugeTextChangedEventArgs e)
{
    // Handle event action
}

{% endhighlight %}

{% endtabs %}