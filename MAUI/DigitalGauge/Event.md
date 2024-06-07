---
layout: post
title: About Maui Digital Gauge control | Syncfusion
description: Learn here all about introduction of Syncfusion Maui Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: MAUI
control: DigitalGauge
documentation: ug
---
## Events in MAUI DigitalGauge

# TextChanged

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