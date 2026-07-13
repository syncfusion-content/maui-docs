---
layout: post
title: Labels in .NET MAUI Linear Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn here all about adding and customizing Labels of Syncfusion<sup>&reg;</sup> .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Labels in .NET MAUI Linear Gauge (SfLinearGauge)

The default style of gauge labels is as follows.

![Default .NET MAUI Linear Gauge labels](images/getting-started/default_linear_gauge.PNG)

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the [.NET MAUI Linear Gauge](https://help.syncfusion.com/maui/linear-gauge/getting-started) control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/linear-gauge/getting-started)** guide.

## Customize label styles

Scale labels can be customized using the [`LabelStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelStyle) property of [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html). The [`LabelStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelStyle) property has the following properties to customize the scale labels.

* [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html#Syncfusion_Maui_Gauges_GaugeLabelStyle_TextColor) – Allows you to customize the color of the labels.
* [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html#Syncfusion_Maui_Gauges_GaugeLabelStyle_FontFamily) – Allows you to specify the font family for labels.
* [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html#Syncfusion_Maui_Gauges_GaugeLabelStyle_FontAttributes) – Allows you to specify the font weight for labels.
* [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html#Syncfusion_Maui_Gauges_GaugeLabelStyle_FontSize) – Allows you to specify the font size for labels.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
    <gauge:SfLinearGauge.LabelStyle>
        <gauge:GaugeLabelStyle FontAttributes="Bold" FontSize="15" 
                               TextColor="Red" 
                               FontFamily="TimesNewRoman"/>
    </gauge:SfLinearGauge.LabelStyle>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.LabelStyle.FontSize = 15;
gauge.LabelStyle.FontFamily = "TimesNewRoman";
gauge.LabelStyle.TextColor = Colors.Red;
gauge.LabelStyle.FontAttributes = FontAttributes.Bold;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize .NET MAUI Linear Gauge axis label style](images/axis-labels/customize_label_style.PNG)

## Change visibility

The [`ShowLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowLabels) property of [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html) allows you to show or hide the visibility of scale labels. The default value of this property is true.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge ShowLabels="False"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.ShowLabels = false;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change label visibility in .NET MAUI Linear Gauge](images/axis-labels/axis_label_visibility.PNG)

## Customize interval between labels

The interval between labels can be customized using the [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Interval) property of [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1). By default, the interval is auto-calculated. The major ticks are generated based on this [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Interval) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge Interval="20"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.Interval = 20;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set label interval in .NET MAUI Linear Gauge axis track](images/axis-labels/axis_label_interval.PNG)

## Change label position

The linear gauge allows you to position the labels either [`Inside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelsPosition.html#Syncfusion_Maui_Gauges_GaugeLabelsPosition_Inside) or [`Outside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelsPosition.html#Syncfusion_Maui_Gauges_GaugeLabelsPosition_Outside) the gauge track using the [`LabelPosition`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelPosition) property. By default, labels are positioned [`Inside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelsPosition.html#Syncfusion_Maui_Gauges_GaugeLabelsPosition_Inside) the gauge track.

{% tabs %}

{% highlight xaml %}

  <gauge:SfLinearGauge LabelPosition="Outside"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.LabelPosition = GaugeLabelsPosition.Outside;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set .NET MAUI Linear Gauge label position](images/axis-labels/label-placement.PNG)

## Change label offset

The [`LabelOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelOffset) property allows you to adjust the distance between the tick-end and the labels. The default [`LabelOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelOffset) value is 0.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge LabelOffset="20"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.LabelOffset = 20;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set .NET MAUI Linear Gauge label offset](images/axis-labels/label_offset.PNG)

## Customize maximum number of visible labels

By default, a maximum of three labels is displayed for every 100 logical pixels in a scale. The maximum number of labels that should be present within 100 logical pixels length can be customized using the [`MaximumLabelsCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MaximumLabelsCount) property of the scale. The default value is 3.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge MaximumLabelsCount="1"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.MaximumLabelsCount = 1;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set maximum number of labels in .NET MAUI Linear Gauge axis track](images/axis-labels/axis_maximum_labels.PNG)

## Customize label text

You can format or change the entire numeric label text using the [`LabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelCreated) event. The event provides a [`LabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LabelCreatedEventArgs.html) parameter containing the label's [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LabelCreatedEventArgs.html#Syncfusion_Maui_Gauges_LabelCreatedEventArgs_Text) property, which can be modified to customize the displayed text.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge LabelCreated="Gauge_LabelCreated"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.LabelCreated += Gauge_LabelCreated;
this.Content = gauge;

//code omitted for brevity

private void Gauge_LabelCreated(object sender, LabelCreatedEventArgs e)
{
    if (e.Text == "0")
        e.Text = "Start";
    else if (e.Text == "50")
        e.Text = "Mid";
    else if (e.Text == "100")
        e.Text = "End";
}

{% endhighlight %}

{% endtabs %}

![Customize label text in .NET MAUI Linear Gauge axis track](images/axis-labels/custom_label_text.PNG)

## Label format

The [`LabelFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelFormat) property is used to format the numeric labels using standard .NET numeric format strings (e.g., `C` for currency, `N` for number, `P` for percent). The default value of this property is null.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge LabelFormat="C"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.LabelFormat = "C";
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize label format in .NET MAUI Linear Gauge axis label](images/axis-labels/axis_label_number_format.PNG)