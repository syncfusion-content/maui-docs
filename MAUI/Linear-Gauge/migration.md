---
layout: post
title: Migrate from Xamarin to .NET MAUI SfLinearGauge | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SfLinearGauge to Syncfusion .NET MAUI SfLinearGauge control and more.
platform: MAUI
control: SfLinearGauge
documentation: ug
---  

# Migrate from Xamarin.Forms SfLinearGauge to .NET MAUI SfLinearGauge

To migrate easier from [Xamarin SfLinearGauge](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfLinearGauge.html) to [.NET MAUI SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html), we kept most of the APIs from Xamarin SfLinearGauge in .NET MAUI SfLinearGauge. However, to maintain the consistency of API naming in .NET MAUI SfLinearGauge, we renamed some of the APIs. The APIs that have been changed in MAUI SfLinearGauge from Xamarin SfLinearGauge are detailed as follows.

## Adding Reference

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>Syncfusion.SfGauge.XForms</td>
<td>Syncfusion.Maui.Gauges</td></tr>
</table>

To initialize the control, import the gauge namespace and Initialize SfLinearGauge as per the following code snippet.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:gauge="clr-namespace:Syncfusion.SfGauge.XForms;assembly=Syncfusion.SfGauge.XForms">

        <gauge:SfLinearGauge/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfGauge.XForms;
...

SfLinearGauge linearGauge = new SfLinearGauge();
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage …
xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

<gauge:SfLinearGauge />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Gauges;
…

SfLinearGauge linearGauge = new SfLinearGauge();
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Scale

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
<td>Gets or sets a value indicating whether inverts the axis from right to left for a horizontal linear gauge or top to bottom for a vertical linear gauge.</td>
</tr>
<tr>
<td>{{'[OpposedPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearScale.html#Syncfusion_SfGauge_XForms_LinearScale_OpposedPosition)'| markdownify }}</td>
<td>{{'[IsMirrored](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to mirror the linear gauge.</td>
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
</table>

The below code example, explains how to initialize axis in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

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

{% highlight C# %}

SfLinearGauge linearGauge = new SfLinearGauge();

LinearScale linearScale = new LinearScale();
linearScale.ScaleBarSize = 20;
linearScale.CornerRadiusType = CornerRadiusType.Both;
linearScale.CornerRadius = 10;
linearScale.ScaleBarSize = 20;
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
                               Fill="Blue"
                               CornerStyle="BothCurve"/>
    </gauge:SfLinearGauge.LineStyle>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

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
</table>

The below code example, explains how to initialize range in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

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
        <gauge:LinearScale ScaleBarColor="#e0e0e0" 
                           LabelColor="#424242" 
                           Interval="5" 
                           MinorTicksPerInterval ="0">
            <gauge:LinearScale.Ranges>
                <gauge:LinearRange StartValue="0" 
                                   EndValue="33" 
                                   Color="#ffF45656"
                                   Offset="-40"/>
                <gauge:LinearRange StartValue="33" 
                                   EndValue="66" 
                                   Color="#ffFFC93E"
                                   Offset="-40"/>
                <gauge:LinearRange StartValue="66" 
                                   EndValue="100" 
                                   Color="#ff0DC9AB"
                                   Offset="-40"/>
            </gauge:LinearScale.Ranges>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

SfLinearGauge linearGauge = new SfLinearGauge();

LinearScale linearScale = new LinearScale();
linearScale.ScaleBarColor = Color.FromHex("#e0e0e0");
linearScale.LabelFontSize = 14;
linearScale.LabelColor = Color.FromHex("#424242");
linearScale.Interval = 5;
linearScale.MinorTicksPerInterval = 0;

LinearRange linearRange = new LinearRange();
linearRange.StartValue = 0;
linearRange.EndValue = 33;
linearRange.Offset = -40;
linearRange.Color = Color.FromHex("#ffF45656");
linearScale.Ranges.Add(linearRange);

LinearRange linearRange1 = new LinearRange();
linearRange1.StartValue = 33;
linearRange1.EndValue = 66;
linearRange1.Offset = -40;
linearRange1.Color = Color.FromHex("#ffFFC93E");
linearScale.Ranges.Add(linearRange1);

LinearRange linearRange2 = new LinearRange();
linearRange2.StartValue = 66;
linearRange2.EndValue = 100;
linearRange2.Offset = -40;
linearRange2.Color = Color.FromHex("#ff0DC9AB");

linearScale.Ranges.Add(linearRange2);
linearGauge.Scales.Add(linearScale);
this.Content = linearGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge x:Name="gauge">
    <gauge:SfLinearGauge.Ranges>
        <gauge:LinearRange StartValue="0" EndValue="33" 
                                   Fill="#ffF45656" Position="Cross"/>
        <gauge:LinearRange StartValue="33" EndValue="66" 
                                   Fill="#ffFFC93E" Position="Cross"/>
        <gauge:LinearRange StartValue="66" EndValue="100" 
                                   Fill="#ff0DC9AB" Position="Cross"/>
    </gauge:SfLinearGauge.Ranges>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.Ranges.Add(new LinearRange()
{
    StartValue = 0,
    EndValue = 33,
    Fill = new SolidColorBrush(Color.FromArgb("ffF45656")),
    Position = GaugeElementPosition.Outside
});
gauge.Ranges.Add(new LinearRange()
{
    StartValue = 33,
    EndValue = 66,
    Fill = new SolidColorBrush(Color.FromArgb("ffFFC93E")),
    Position = GaugeElementPosition.Outside
});
gauge.Ranges.Add(new LinearRange()
{
    StartValue = 66,
    EndValue = 100,
    Fill = new SolidColorBrush(Color.FromArgb("ff0DC9AB")),
    Position = GaugeElementPosition.Outside
});
this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Pointers

In Xamarin SfLinearGauge and .NET MAUI SfLinearGauge, pointers can be classified as mentioned in below table.

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[BarPointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.BarPointer.html)'| markdownify }}</td>
<td>{{'[BarPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html)'| markdownify }}</td>
<td>Create the pointer to indicate the value with needle or arrow shape.</td>
</tr>
<tr>
<td>{{'[SymbolPointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html)'| markdownify }}</td>
<td>{{'[LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html)'| markdownify }} and {{'[LinearContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html)'| markdownify }}</td>
<td>Represents the pointer that is used to indicate the value with any visual content and with built-in shape.</td>
</tr>
</table>

N> In .NET MAUI SfLinearGauge [SymbolPointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html) have been divided into two types. They are [LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html) and [LinearContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html).

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
<td>Gets or sets the value that specifies the height of BarPointer for a horizontal linear gauge, or to the width of BarPointer for a vertical linear gauge.</td>
</tr>
</table>

The below code example, explains how to initialize bar pointer in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

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
        <gauge:LinearScale ScaleBarColor="#e0e9f9" 
                           LabelColor="#424242" 
                           ScaleBarSize = "20"
                           LabelFontSize ="14"
                           MinorTicksPerInterval ="0">
            <gauge:LinearScale.MajorTickSettings>
                <gauge:LinearTickSettings Thickness="1" 
                                          Color ="#9E9E9E"
                                          Length = "10"/>
            </gauge:LinearScale.MajorTickSettings>
            <gauge:LinearScale.Pointers>
                <gauge:BarPointer  Value="75" 
                                   EnableAnimation = "false"
                                   Color = "#36d1dc" />
            </gauge:LinearScale.Pointers>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

SfLinearGauge linearGauge = new SfLinearGauge();

LinearScale linearScale = new LinearScale();
linearScale.ScaleBarColor = Color.FromHex("#e0e9f9");
linearScale.LabelColor = Color.FromHex("#424242");
linearScale.ScaleBarSize = 20;
linearScale.LabelFontSize = 14;
linearScale.MinorTicksPerInterval = 0;
linearScale.MajorTickSettings.Color = Color.FromHex("#9E9E9E");
linearScale.MajorTickSettings.Thickness = 1;
linearScale.MajorTickSettings.Length = 10;

BarPointer barPointer = new BarPointer();
barPointer.Value = 75;
barPointer.EnableAnimation = false;
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

<gauge:SfLinearGauge MinorTicksPerInterval="0"
                     Interval="10">
    <gauge:SfLinearGauge.LineStyle>
        <gauge:LinearLineStyle Fill="#e0e9f9"
                               Thickness="20"/>
    </gauge:SfLinearGauge.LineStyle>
    <gauge:SfLinearGauge.LabelStyle>
        <gauge:GaugeLabelStyle FontSize="14" 
                               TextColor="#424242"/>
    </gauge:SfLinearGauge.LabelStyle>
    <gauge:SfLinearGauge.MajorTickStyle>
        <gauge:LinearTickStyle Length="10" 
                               Stroke="#9E9E9E" 
                               StrokeThickness="1" />
    </gauge:SfLinearGauge.MajorTickStyle>
    <gauge:SfLinearGauge.BarPointers>
        <gauge:BarPointer Value="75" 
                          PointerSize="10"
                          EnableAnimation="False" 
                          Fill="#36d1dc"/>
    </gauge:SfLinearGauge.BarPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.MinorTicksPerInterval = 0;
gauge.Interval = 10;
gauge.LineStyle.Fill = Color.FromHex("#e0e9f9");
gauge.LineStyle.Thickness = 20;
gauge.LabelStyle.FontSize = 14;
gauge.LabelStyle.TextColor = Color.FromHex("#424242");
gauge.MajorTickStyle.Length = 10;
gauge.MajorTickStyle.Stroke = Color.FromHex("#9E9E9E");
gauge.MajorTickStyle.StrokeThickness = 1;

gauge.BarPointers.Add(new BarPointer
{
    Value =75,
    PointerSize=10,
    EnableAnimation=false,
    Fill = Color.FromHex("#36d1dc"),
});

this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Shape pointer

<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[MarkerShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SymbolPointer.html#Syncfusion_SfGauge_XForms_SymbolPointer_MarkerShape)'| markdownify }}</td>
<td>{{'[ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html#Syncfusion_Maui_Gauges_LinearShapePointer_ShapeType)'| markdownify }}</td>
<td>Gets or sets a value that specifies the default shape type of the pointer.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.LinearPointer.html#Syncfusion_SfGauge_XForms_LinearPointer_Color)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html#Syncfusion_Maui_Gauges_LinearShapePointer_Fill)'| markdownify }}</td>
<td>Gets or sets a value that indicates the brush used to paint the pointer interior.</td>
</tr>
</table>

The below code example, explains how to initialize shape pointer in Xamarin SfLinearGauge and .NET MAUI SfLinearGauge.

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
        <gauge:LinearScale ScaleBarColor="#e0e9f9" 
                           LabelColor="#424242" 
                           ScaleBarSize = "20"
                           LabelFontSize ="14"
                           MinorTicksPerInterval ="0">
            <gauge:LinearScale.MajorTickSettings>
                <gauge:LinearTickSettings Thickness="1" 
                                          Color ="#9E9E9E" 
                                          Length = "10"/>
            </gauge:LinearScale.MajorTickSettings>
            <gauge:LinearScale.Pointers>
                <gauge:BarPointer  Value="75" 
                                   EnableAnimation = "false" 
                                   Color = "#36d1dc" />
                <gauge:SymbolPointer Value ="30" 
                                     EnableAnimation ="False"
                                     Color= "#5b86e5"/>
            </gauge:LinearScale.Pointers>
        </gauge:LinearScale>
    </gauge:SfLinearGauge.Scales>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

SfLinearGauge linearGauge = new SfLinearGauge();
LinearScale linearScale = new LinearScale();
linearScale.ScaleBarColor = Color.FromHex("#e0e9f9");
linearScale.LabelColor = Color.FromHex("#424242");
linearScale.ScaleBarSize = 20;
linearScale.LabelFontSize = 14;
linearScale.MinorTicksPerInterval = 0;
linearScale.MajorTickSettings.Color = Color.FromHex("#9E9E9E");
linearScale.MajorTickSettings.Thickness = 1;
linearScale.MajorTickSettings.Length = 10;

BarPointer barPointer = new BarPointer();
barPointer.Value = 75;
barPointer.EnableAnimation = false;
barPointer.Color = Color.FromHex("#36d1dc");
linearScale.Pointers.Add(barPointer);

SymbolPointer symbolPointer = new SymbolPointer();
symbolPointer.Value = 30;
symbolPointer.EnableAnimation = false;
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

<gauge:SfLinearGauge MinorTicksPerInterval="0"
                     Interval="10">
    <gauge:SfLinearGauge.LineStyle>
        <gauge:LinearLineStyle Fill="#e0e9f9"
                               Thickness="20"/>
    </gauge:SfLinearGauge.LineStyle>
    <gauge:SfLinearGauge.LabelStyle>
        <gauge:GaugeLabelStyle FontSize="14" 
                               TextColor="#424242"/>
    </gauge:SfLinearGauge.LabelStyle>
    <gauge:SfLinearGauge.MajorTickStyle>
        <gauge:LinearTickStyle Length="10" 
                               Stroke="#9E9E9E" 
                               StrokeThickness="1" />
    </gauge:SfLinearGauge.MajorTickStyle>
    <gauge:SfLinearGauge.BarPointers>
        <gauge:BarPointer Value="75" 
                          PointerSize="10"
                          EnableAnimation="False"
                          Fill="#36d1dc"/>
    </gauge:SfLinearGauge.BarPointers>
    <gauge:SfLinearGauge.MarkerPointers>
        <gauge:LinearShapePointer Value="30"
                                  Fill="#5b86e5"
                                  ShapeType="Triangle"
                                  EnableAnimation="False"
                                  Position="Inside"/>
    </gauge:SfLinearGauge.MarkerPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight C# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.MinorTicksPerInterval = 0;
gauge.Interval = 10;

gauge.LineStyle.Fill = Color.FromHex("#e0e9f9");
gauge.LineStyle.Thickness = 20;

gauge.LabelStyle.FontSize = 14;
gauge.LabelStyle.TextColor = Color.FromHex("#424242");

gauge.MajorTickStyle.Length = 10;
gauge.MajorTickStyle.Stroke = Color.FromHex("#9E9E9E");
gauge.MajorTickStyle.StrokeThickness = 1;

gauge.BarPointers.Add(new BarPointer
{
    Value =75,
    PointerSize=10,
    EnableAnimation=false,
    Fill = Color.FromHex("#36d1dc"),
});

gauge.MarkerPointers.Add(new LinearShapePointer
{
    Value = 30,
    EnableAnimation = false,
    Fill = Color.FromHex("#5b86e5"),
    ShapeType = ShapeType.Triangle,
    Position = GaugeElementPosition.Inside
});

this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Content pointer

The ContentPointer in .NET MAUI SfLinearGauge allows to use any .NET MAUI content as pointer.
<table>
<tr>
<th>Xamarin SfLinearGauge</th>
<th>.NET MAUI SfLinearGauge</th>
<th>Description</th></tr>
<tr>
<td> - </td>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html#Syncfusion_Maui_Gauges_LinearContentPointer_Content)'| markdownify }}</td>
<td>Gets or sets the any visual content of a LinearContentPointer.</td>
</tr>
</table>

The below code example, explains how to initialize content pointer .NET MAUI SfLinearGauge. Content pointer feature is not applicable in Xamarin SfLinearGauge.

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

{% highlight C# %}

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

N> In .NET MAUI SfLinearGauge there is no support for annotation like Xamarin SfLinearGauge. So, you can use the content pointer as annotation in .NET MAUI SfLinearGauge.
