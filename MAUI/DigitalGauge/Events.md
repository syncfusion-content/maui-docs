---
layout: post
title: Events in .NET MAUI Digital Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn about events in the Syncfusion® .NET MAUI Digital Gauge (SfDigitalGauge) control, its introduction, elements, and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---

# Events in .NET MAUI Digital Gauge

The [SfDigitalGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html) control provides events that notify when the text value changes, allowing you to perform custom actions.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfDigitalGauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/digitalgauge/getting-started)** guide.

## TextChanged

The [TextChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_TextChanged) event is triggered when the text is changed. The associated argument contains the following properties:

* `sender` - Gets details of the sender.
* [DigitalGaugeTextChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeTextChangedEventArgs.html) - Holds the text changed event arguments.

{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text = "syncfusion"
                      TextChanged = "SfDigitalGauge_TextChanged"
                      StrokeWidth = "3"
                      CharacterSpacing = "23"
                      CharacterHeight = "90"
                      CharacterWidth = "70"
                      CharacterType = "EightCrossEightDotMatrix"
                      CharacterStroke = "Orange"/>

{% endhighlight %}

{% highlight c# %}

private void SfDigitalGauge_TextChanged(object sender, Syncfusion.Maui.Gauges.DigitalGaugeTextChangedEventArgs e)
{
    // Handle event action
}

{% endhighlight %}

{% endtabs %}