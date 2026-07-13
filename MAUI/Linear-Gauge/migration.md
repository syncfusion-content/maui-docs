---
layout: post
title: Migrate from Xamarin to .NET MAUI SfLinearGauge | Syncfusion<sup>&reg;</sup> 
description: Learn here all about Migrating from Syncfusion<sup>&reg;</sup> Xamarin SfLinearGauge to Syncfusion<sup>&reg;</sup> .NET MAUI SfLinearGauge control and more.
platform: MAUI
control: SfLinearGauge
documentation: ug
---  

# Migrate from Xamarin.Forms SfLinearGauge to .NET MAUI SfLinearGauge

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the [.NET MAUI Linear Gauge](https://help.syncfusion.com/maui/linear-gauge/getting-started) control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/linear-gauge/getting-started)** guide.

To make the migration from the [Xamarin SfLinearGauge](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfLinearGauge.html) to the [.NET MAUI SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html) easier, most of the similar APIs from the Xamarin [SfLinearGauge](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfLinearGauge.html) were kept in the .NET MAUI [SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html). Also, the APIs have been restructured by considering various use cases and maintaining API consistency. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the gauge namespace and initialize SfLinearGauge as shown in the following code sample. In .NET MAUI, you also need to register the Syncfusion core handler by calling `builder.ConfigureSyncfusionCore()` in the `MauiProgram.cs` file. For more information, refer to the [Getting Started](https://help.syncfusion.com/maui/linear-gauge/getting-started) guide.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:gauge="clr-namespace:Syncfusion.SfGauge.XForms;assembly=Syncfusion.SfGauge.XForms">

        <gauge:SfLinearGauge/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfGauge.XForms;
//code omitted for brevity

SfLinearGauge linearGauge = new SfLinearGauge();
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

        <gauge:SfLinearGauge/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;
//code omitted for brevity

SfLinearGauge linearGauge = new SfLinearGauge();
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Scale

In the .NET MAUI linear gauge, we do not expose APIs for adding [scale](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html) objects and their collections, like in the Xamarin linear gauge. You can add scale element settings such as axis line, ticks, labels, ranges, and pointers directly to the linear gauge. Also, for creating multiple scales in .NET MAUI, you can use multiple linear gauge objects, since control measures are based on their inner elements.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[MinimumValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_MinimumValue)'| markdownify }}</td>
<td>{{'[Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Minimum)'| markdownify }}</td>
<td>Gets or sets the minimum value of the axis.</td>
</tr>
<tr>
<td>{{'[MaximumValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_MaximumValue)'| markdownify }}</td>
<td>{{'[Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Maximum)'| markdownify }}</td>
<td>Gets or sets the maximum value of the axis.</td>
</tr>
<tr>
<td>{{'[ScalePosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_ScalePosition)'| markdownify }}</td>
<td>{{'[IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsInversed)'| markdownify }}</td>
<td>Gets or sets a value indicating whether it inverts the axis from right to left for a horizontal linear gauge or top to bottom for a vertical linear gauge.</td>
</tr>
<tr>
<td>{{'[OpposedPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_OpposedPosition)'| markdownify }}</td>
<td>{{'[IsMirrored](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the linear gauge should be mirrored.</td>
</tr>
<tr>
<td>{{'[MajorTickSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_MajorTickSettings)'| markdownify }}</td>
<td>{{'[MajorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MajorTickStyle)'| markdownify }}</td>
<td>Gets or sets a value to customize the style of default major ticks.</td>
</tr>
<tr>
<td>{{'[MinorTickSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_MinorTickSettings)'| markdownify }}</td>
<td>{{'[MinorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTickStyle)'| markdownify }}</td>
<td>Gets or sets a value to customize the style of default minor ticks.</td>
</tr>
<tr>
<td>{{'[MaximumLabels](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_MaximumLabels)'| markdownify }}</td>
<td>{{'[MaximumLabelsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MaximumLabelsCount)'| markdownify }}</td>
<td>Gets or sets the maximum number of labels to be displayed in 100 logical pixels.</td>
</tr>
<tr>
<td>{{'[ScaleBarSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_ScaleBarSize)'| markdownify }}</td>
<td>{{'[Thickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html#Syncfusion_Maui_Gauges_LinearLineStyle_Thickness)'| markdownify }} in [LinearLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html)</td>
<td>Gets or sets the thickness of the axis line.</td>
</tr>
<tr>
<td>{{'[ScaleBarColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_ScaleBarColor)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html#Syncfusion_Maui_Gauges_LinearLineStyle_Fill)'| markdownify }} in [LinearLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html)</td>
<td>Gets or sets the brush that paints the axis line.</td>
</tr>
<tr>
<td>{{'[CornerRadiusType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_CornerRadiusType)'| markdownify }}</td>
<td>{{'[CornerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html#Syncfusion_Maui_Gauges_LinearLineStyle_CornerStyle)'| markdownify }} in [LinearLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html)</td>
<td>Gets or sets the corner style of the axis line.</td>
</tr>
<tr>
<td>{{'[Interval](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_Interval)'| markdownify }}</td>
<td>{{'[Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Interval)'| markdownify }}</td>
<td>Gets or sets the interval value for the axis labels and major ticks.</td>
</tr>
</table>

The following code example explains how to initialize the axis in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.Scales>
        <gauge:LinearScale ScaleBarSize="20" 
                           CornerRadiusType="Both"
                           ScaleBarColor="Blue"
                           MinimumValue="0"
                           MaximumValue="100"
                           Interval="10"
                           OpposedPosition="True"
                           ScalePosition="BackWard">
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge linearGauge = new SfLinearGauge();

LinearScale linearScale = new LinearScale();
linearScale.ScaleBarSize = 20;
linearScale.CornerRadiusType = CornerRadiusType.Both;
linearScale.CornerRadius = 10;
linearScale.ScaleBarColor = Color.Blue;
linearScale.MinimumValue = 0;
linearScale.MaximumValue = 100;
linearScale.Interval = 10;
linearScale.OpposedPosition = true;
linearScale.ScalePosition = ScalePosition.BackWard;
linearGauge.Scales.Add(linearScale);

this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge IsInversed="True"
                     IsMirrored="True"
                     Minimum="0"
                     Maximum="100"
                     Interval="10">
    <gauge:SfLinearGauge.LineStyle>
        <gauge:LinearLineStyle Thickness="20"
                               CornerStyle="BothCurve"/>
    </gauge:SfLinearGauge.LineStyle>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.IsInversed = true;
gauge.IsMirrored = true;
gauge.Minimum = 0;
gauge.Maximum = 100;
gauge.Interval = 10;
gauge.LineStyle.Thickness = 20;
gauge.LineStyle.Fill = new SolidColorBrush(Colors.Blue);
gauge.LineStyle.CornerStyle = CornerStyle.BothCurve;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Range

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearRange.html#Syncfusion_SfGauge_XForms_LinearRange_Color)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_Fill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the range.</td>
</tr>
<tr>
<td>{{'[Offset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearRange.html#Syncfusion_SfGauge_XForms_LinearRange_Offset)'| markdownify }}</td>
<td>{{'[Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_Position)'| markdownify }}</td>
<td>Gets or sets the value that indicates the position of the range inside, or cross, or outside the axis line.</td>
</tr>
<tr>
<td>{{'[StartValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearRange.html#Syncfusion_SfGauge_XForms_LinearRange_StartValue)'| markdownify }}</td>
<td>{{'[StartValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_StartValue)'| markdownify }}</td>
<td>Gets or sets the start value of the range.</td>
</tr>
<tr>
<td>{{'[EndValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearRange.html#Syncfusion_SfGauge_XForms_LinearRange_EndValue)'| markdownify }}</td>
<td>{{'[EndValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_EndValue)'| markdownify }}</td>
<td>Gets or sets the end value of the range.</td>
</tr>
</table>

The following code example explains how to initialize the range in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.Scales>
        <gauge:LinearScale >
            <gauge:LinearScale.Ranges>
                <gauge:LinearRange StartValue="0" 
                                   EndValue="33" 
                                   Color="#ffF45656"
                                   Offset="-40"/>
            </gauge:LinearScale.Ranges>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge linearGauge = new SfLinearGauge();

LinearScale linearScale = new LinearScale();

LinearRange linearRange = new LinearRange();
linearRange.StartValue = 0;
linearRange.EndValue = 33;
linearRange.Offset = -40;
linearRange.Color = Color.FromHex("#ffF45656");
linearScale.Ranges.Add(linearRange);

linearGauge.Scales.Add(linearScale);
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.Ranges>
        <gauge:LinearRange StartValue="0" EndValue="33" 
                           Fill="#ffF45656" Position="Cross"/>
    </gauge:SfLinearGauge.Ranges>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.Ranges.Add(new LinearRange()
{
    StartValue = 0,
    EndValue = 33,
    Fill = new SolidColorBrush(Color.FromArgb("ffF45656")),
    Position = GaugeElementPosition.Cross
});
this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Pointers

In Xamarin SfLinearGauge and .NET MAUI SfLinearGauge, pointers can be classified as mentioned in the following table.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[BarPointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.BarPointer.html)'| markdownify }}</td>
<td>{{'[BarPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html)'| markdownify }}</td>
<td>Creates the pointer to indicate the value with a shaded bar.</td>
</tr>
<tr>
<td>{{'[SymbolPointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html)'| markdownify }}</td>
<td>Divided into {{'[LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html)'| markdownify }} and {{'[LinearContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html)'| markdownify }}</td>
<td>Represents the pointer that is used to indicate the value with any visual content or with built-in shapes.</td>
</tr>
</table>

Also, in .NET MAUI, the bar pointer can be added to the [BarPointers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_BarPointers) collection, and the shape and content pointers can be added to the [MarkerPointers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MarkerPointers) collection.

### Bar pointer

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[CornerRadiusType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.BarPointer.html#Syncfusion_SfGauge_XForms_BarPointer_CornerRadiusType)'| markdownify }}</td>
<td>{{'[CornerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_CornerStyle)'| markdownify }}</td>
<td>Gets or sets a CornerStyle enumeration value that describes the corner/edge style of the BarPointer.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearPointer.html#Syncfusion_SfGauge_XForms_LinearPointer_Color)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_Fill)'| markdownify }}</td>
<td>Gets or sets a value that indicates the brush used to paint the pointer interior.</td>
</tr>
<tr>
<td>{{'[Thickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearPointer.html#Syncfusion_SfGauge_XForms_LinearPointer_Thickness)'| markdownify }}</td>
<td>{{'[PointerSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_PointerSize)'| markdownify }}</td>
<td>Gets or sets the value that specifies the height of BarPointer for a horizontal linear gauge, or the width of BarPointer for a vertical linear gauge.</td>
</tr>
</table>

The following code example, explains how to initialize the bar pointer in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.Scales>
        <gauge:LinearScale >
            <gauge:LinearScale.Pointers>
                <gauge:BarPointer  Value="75" 
                                   Color = "#36d1dc" />
            </gauge:LinearScale.Pointers>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge linearGauge = new SfLinearGauge();

LinearScale linearScale = new LinearScale();

BarPointer barPointer = new BarPointer();
barPointer.Value = 75;
barPointer.Color = Color.FromHex("#36d1dc");

linearScale.Pointers.Add(barPointer);
linearGauge.Scales.Add(linearScale);
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.BarPointers>
        <gauge:BarPointer Value="75" 
                          PointerSize="10"
                          Fill="#36d1dc"/>
    </gauge:SfLinearGauge.BarPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();

gauge.BarPointers.Add(new BarPointer
{
    Value = 75,
    PointerSize = 10,
    Fill = new SolidColorBrush(Color.FromHex("#36d1dc")),
});

this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Symbol pointer

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[MarkerShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html#Syncfusion_SfGauge_XForms_SymbolPointer_MarkerShape)'| markdownify }}</td>
<td>{{'[ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html#Syncfusion_Maui_Gauges_LinearShapePointer_ShapeType)'| markdownify }} in {{'[LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html)'| markdownify }} class</td>
<td>Gets or sets a value that specifies the default shape type of the pointer.</td>
</tr> 
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearPointer.html#Syncfusion_SfGauge_XForms_LinearPointer_Color)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html#Syncfusion_Maui_Gauges_LinearShapePointer_Fill)'| markdownify }} in {{'[LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html)'| markdownify }}</td>
<td>Gets or sets a value that indicates the brush used to paint the pointer interior.</td>
</tr>
<tr>
<td>{{'[SymbolPointerPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html#Syncfusion_SfGauge_XForms_SymbolPointer_SymbolPointerPosition)'| markdownify }}</td>
<td>{{'[Alignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearMarkerPointer.html#Syncfusion_Maui_Gauges_LinearMarkerPointer_Alignment)'| markdownify }} in {{'[LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html)'| markdownify }}</td>
<td>Gets or sets the placement (start, center or end) of the marker pointer relative to its position.</td>
</tr>
</table>

The following code example, explains how to initialize the shape pointer in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.Scales>
        <gauge:LinearScale>
            <gauge:LinearScale.Pointers>
                <gauge:SymbolPointer Value ="30" 
                                     Color= "#5b86e5"/>
            </gauge:LinearScale.Pointers>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge linearGauge = new SfLinearGauge();
LinearScale linearScale = new LinearScale();

SymbolPointer symbolPointer = new SymbolPointer();
symbolPointer.Value = 30;
symbolPointer.Color = Color.FromHex("#5b86e5");
linearScale.Pointers.Add(symbolPointer);

linearGauge.Scales.Add(linearScale);
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.MarkerPointers>
        <gauge:LinearShapePointer Value="30"
                                  Fill="#5b86e5"
                                  ShapeType="Triangle"
                                  Position="Inside"/>
    </gauge:SfLinearGauge.MarkerPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();

gauge.MarkerPointers.Add(new LinearShapePointer
{
    Value = 30,
    Fill = new SolidColorBrush(Color.FromHex("#5b86e5")),
    ShapeType = ShapeType.Triangle,
    Position = GaugeElementPosition.Inside
});

this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Content pointer

The [LinearContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html) in the .NET MAUI SfLinearGauge allows using any content, image, or text as a pointer. In Xamarin, you can add an image as a pointer through the [ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html#Syncfusion_SfGauge_XForms_SymbolPointer_ImageSource) property of the SymbolPointer, and in .NET MAUI, you can directly add an image control as a pointer in the content pointer. The Xamarin `ImageSource` property maps to using a `LinearContentPointer` with an `Image` control as its `Content`.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html#Syncfusion_SfGauge_XForms_SymbolPointer_ImageSource)'| markdownify }}</td>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html#Syncfusion_Maui_Gauges_LinearContentPointer_Content)'| markdownify }}</td>
<td>Gets or sets any visual content of a LinearContentPointer, such as an image, text, or custom view.</td>
</tr>
</table>

The following code example explains how to initialize the content pointer in .NET MAUI SfLinearGauge. The full content pointer feature is not applicable in the Xamarin SfLinearGauge; however, the Xamarin `ImageSource` approach for image pointers is shown alongside for comparison.

<table>
<tr>
<th>Xamarin SfLinearGauge (ImageSource)</th>
<th>.NET MAUI SfLinearGauge (LinearContentPointer)</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.Scales>
        <gauge:LinearScale>
            <gauge:LinearScale.Pointers>
                <gauge:SymbolPointer Value="50" 
                                     ImageSource="pin.png"/>
            </gauge:LinearScale.Pointers>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge linearGauge = new SfLinearGauge();
LinearScale linearScale = new LinearScale();

SymbolPointer symbolPointer = new SymbolPointer();
symbolPointer.Value = 50;
symbolPointer.ImageSource = "pin.png";
linearScale.Pointers.Add(symbolPointer);

linearGauge.Scales.Add(linearScale);
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
    <gauge:SfLinearGauge.MarkerPointers>
        <gauge:LinearContentPointer Value="50" Alignment="End">
            <gauge:LinearContentPointer.Content>
                <Grid HeightRequest="25" WidthRequest="25">
                    <RoundRectangle CornerRadius="5" 
                                    Fill="#ff0074E3"/>
                    <Label Text="50" HorizontalOptions="Center"
                           VerticalOptions="Center" TextColor="White"/>
                </Grid>
            </gauge:LinearContentPointer.Content>
        </gauge:LinearContentPointer>
    </gauge:SfLinearGauge.MarkerPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();

Grid views = new Grid() { HeightRequest = 25, WidthRequest = 25 };
views.Add(new RoundRectangle()
{
    Fill = new SolidColorBrush(Color.FromArgb("#ff0074E3")),
    CornerRadius = 5
});
views.Add(new Label()
{
    Text = "50",
    TextColor = Colors.White,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center
});

LinearContentPointer contentPointer = new LinearContentPointer();
contentPointer.Value = 50;
contentPointer.Alignment = GaugeAlignment.End;
contentPointer.Content = views;
gauge.MarkerPointers.Add(contentPointer);
this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Unsupported feature

The [Annotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearGaugeAnnotation.html) feature in the Xamarin SfLinearGauge allowed adding custom views (such as text or images) at specific positions over the gauge. This feature cannot be supported in the .NET MAUI SfLinearGauge, because this requirement can be met using the [content pointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html#Syncfusion_Maui_Gauges_LinearContentPointer_Content) support itself. So, you can use the content pointer as an annotation in .NET MAUI SfLinearGauge.

