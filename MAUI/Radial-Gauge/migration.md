---
layout: post
title: Migrate from Xamarin to .NET MAUI Radial Gauge | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin SfCircularGauge to Syncfusion<sup>&reg;</sup> .NET MAUI SfRadialGauge control and more.
platform: MAUI
control: SfRadialGauge
documentation: ug
---  

# Migrate from Xamarin.Forms SfCircularGauge to .NET MAUI SfRadialGauge

To make the migration from the [Xamarin SfCircularGauge](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfCircularGauge.html) to [.NET MAUI SfRadialGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html) easier, most of the APIs from the Xamarin SfCircularGauge were kept in the.NET MAUI SfRadialGauge. However, to maintain the consistency of API naming in the.NET MAUI SfRadialGauge, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the gauge namespace and initialize SfRadialGauge as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:gauge="clr-namespace:Syncfusion.SfGauge.XForms;assembly=Syncfusion.SfGauge.XForms">

    <gauge:SfCircularGauge/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfGauge.XForms;
...

SfCircularGauge circularGauge = new SfCircularGauge ();
this.Content = circularGauge;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

    <gauge:SfRadialGauge />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Gauges;
…

SfRadialGauge sfRadialGauge = new SfRadialGauge();
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[Scales](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfCircularGauge.html#Syncfusion_SfGauge_XForms_SfCircularGauge_Scales)'| markdownify }}</td>
<td>{{'[Axes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html#Syncfusion_Maui_Gauges_SfRadialGauge_Axes)'| markdownify }}</td>
<td>Gets or sets a collection of RadialAxis.</td>
</tr>
<tr>
<td>{{'[Scale](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html)'| markdownify }}</td>
<td>{{'[RadialAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html)'| markdownify }}</td>
<td>It is a circular arc in which a set of values are displayed along a linear or custom scale based on the design requirements.</td>
</tr>
</table>

## Axis

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[StartValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_StartValue)'| markdownify }}</td>
<td>{{'[Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Minimum)'| markdownify }}</td>
<td>Gets or sets the minimum value of the axis.</td>
</tr>
<tr>
<td>{{'[EndValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_EndValue)'| markdownify }}</td>
<td>{{'[Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Maximum)'| markdownify }}</td>
<td>Gets or sets the maximum value of the axis.</td>
</tr>
<tr>
<td>{{'[ShowRim](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_ShowRim)'| markdownify }}</td>
<td>{{'[ShowAxisLine](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowAxisLine)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to shows or hides the axis line.</td>
</tr>
<tr>
<td>{{'[SweepAngle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_SweepAngle)'| markdownify }}</td>
<td>{{'[EndAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_EndAngle)'| markdownify }}</td>
<td>Gets or sets a value that specifies the EndAngle of the axis.</td>
</tr>
<tr>
<td>{{'[EnableAutoAngle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_EnableAutoAngle)'| markdownify }}</td>
<td>{{'[CanRotateLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_CanRotateLabels)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to rotate the labels or not.</td>
</tr>
<tr>
<td>{{'[MaximumLabels](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_MaximumLabels)'| markdownify }}</td>
<td>{{'[MaximumLabelsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MaximumLabelsCount)'| markdownify }}</td>
<td>Gets or sets the maximum number of labels to be displayed in an axis in 100 logical pixels.</td>
</tr>
<tr>
<td>{{'[Direction](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_Direction)'| markdownify }}</td>
<td>{{'[IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_IsInversed)'| markdownify }}</td>
<td>Gets or sets a value indicating whether it inverts the axis from right to left.</td>
</tr>
<tr>
<td>{{'[MajorTickSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_MajorTickSettings)'| markdownify }}</td>
<td>{{'[MajorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MajorTickStyle)'| markdownify }}</td>
<td>Gets or sets RadialTickStyle, which is used to customize major ticks.</td>
</tr>
<tr>
<td>{{'[MinorTickSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_MinorTickSettings)'| markdownify }}</td>
<td>{{'[MinorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MinorTickStyle)'| markdownify }}</td>
<td>Gets or sets RadialTickStyle, which is used to customize minor ticks.</td>
</tr>
<tr>
<td>{{'[UseRangeColorForLabels](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Scale.html#Syncfusion_SfGauge_XForms_Scale_UseRangeColorForLabels)'| markdownify }}</td>
<td>{{'[UseRangeColorForAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_UseRangeColorForAxis)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to use the range color for axis elements such as labels and ticks.</td>
</tr>
</table>

The following code example, explains how to initialize the axis in Xamarin SfCircularGauge and .NET MAUI SfRadialGauge.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfCircularGauge>
    <gauge:SfCircularGauge.Scales>
        <gauge:Scale StartValue="0"
                     EndValue="12"
                     Interval="1"
                     StartAngle="270"
                     SweepAngle="360"
                     ShowFirstLabel="False"/>
    </gauge:SfCircularGauge.Scales>
</gauge:SfCircularGauge>

{% endhighlight %}

{% highlight C# %}

SfCircularGauge circularGauge = new SfCircularGauge();

ObservableCollection<Scale> scales = new ObservableCollection<Scale>();
Scale scale = new Scale();
scale.StartValue = 0;
scale.EndValue = 12;
scale.Interval = 1;
scale.StartAngle = 270;
scale.SweepAngle = 360;
scale.ShowFirstLabel = false;
scales.Add(scale);
circularGauge.Scales = scales;

this.Content = circularGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Minimum="0"
                          Maximum="12"
                          Interval="1"
                          StartAngle="270"
                          EndAngle="270"
                          ShowFirstLabel="False" />
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
radialAxis.Minimum = 0;
radialAxis.Maximum = 12;
radialAxis.Interval = 1;
radialAxis.StartAngle = 270;
radialAxis.EndAngle = 270;
radialAxis.ShowFirstLabel = false;
sfRadialGauge.Axes.Add(radialAxis);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Range

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[Range](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Range.html)'| markdownify }}</td>
<td>{{'[RadialRange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html)'| markdownify }}</td>
<td>Create the range to add a color bar in the gauge. RadialRange is a visual that helps to quickly visualize where a value falls on the axis.</td>
</tr>
<tr>
<td>{{'[Offset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Range.html#Syncfusion_SfGauge_XForms_Range_Offset)'| markdownify }}</td>
<td>{{'[RangeOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_RangeOffset)'| markdownify }}</td>
<td>Gets or sets the value that specifies the range position. You can specify value either in logical pixel or radius factor using the OffsetUnit property.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.Range.html#Syncfusion_SfGauge_XForms_Range_Color)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_Fill)'| markdownify }}</td>
<td>Gets or sets the color that paints the interior area of the range.</td>
</tr>
</table>

The following code example, explains how to initialize the range in Xamarin SfCircularGauge and .NET MAUI SfRadialGauge.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfCircularGauge>
    <gauge:SfCircularGauge.Scales>
        <gauge:Scale>
            <gauge:Scale.Ranges>
                <gauge:Range StartValue="10"
                             EndValue="80"
                             InnerStartOffset = "0.83"
                             InnerEndOffset = "0.6"
                             OuterStartOffset = "0.85"
                             OuterEndOffset =" 0.8"/>
            </gauge:Scale.Ranges>
        </gauge:Scale>
    </gauge:SfCircularGauge.Scales>
</gauge:SfCircularGauge>

{% endhighlight %}

{% highlight C# %}

SfCircularGauge circularGauge = new SfCircularGauge();

ObservableCollection<Scale> scales = new ObservableCollection<Scale>();
Scale scale = new Scale();
scales.Add(scale);

Range range = new Range();
range.StartValue = 10;
range.EndValue = 80;
range.InnerStartOffset = 0.83;
range.InnerEndOffset = 0.6;
range.OuterStartOffset = 0.85;
range.OuterEndOffset = 0.8;
scale.Ranges.Add(range);

circularGauge.Scales = scales;
this.Content = circularGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Ranges>
                <gauge:RadialRange StartValue="10"
                                   EndValue="80"
                                   OffsetUnit="Factor"
                                   RangeOffset="0.3"
                                   StartWidth="5"
                                   EndWidth="30" />
            </gauge:RadialAxis.Ranges>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RadialRange gaugeRange = new RadialRange();
gaugeRange.StartValue = 10;
gaugeRange.EndValue = 80;
gaugeRange.OffsetUnit = SizeUnit.Factor;
gaugeRange.RangeOffset = 0.3;
gaugeRange.StartWidth = 5;
gaugeRange.EndWidth = 30;
radialAxis.Ranges.Add(gaugeRange);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Pointers

In Xamarin SfCircularGauge and .NET MAUI SfRadialGauge, pointers can be classified as mentioned in the following table.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[MarkerPointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.MarkerPointer.html)'| markdownify }}</td>
<td>Divided into {{'[ShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html)'| markdownify }} and {{'[ContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ContentPointer.html)'| markdownify }}</td>
<td>Represents the pointer that is used to indicate the value with any visual content or with built-in shapes.</td>
</tr>
<tr>
<td>{{'[NeedlePointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html)'| markdownify }}</td>
<td>{{'[NeedlePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html)'| markdownify }}</td>
<td>Create the pointer to indicate the value with a needle or arrow shape.</td>
</tr>
<tr>
<td>{{'[RangePointer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.RangePointer.html)'| markdownify }}</td>
<td>{{'[RangePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html)'| markdownify }}</td>
<td>Create the pointer to indicate the value with a rounded range bar arc.</td>
</tr>
</table>

N> In .NET MAUI SfRadialGauge [MarkerPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html) have been divided into two types. They are [ShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html) and [ContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ContentPointer.html).

### Marker pointer

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[MarkerHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.MarkerPointer.html#Syncfusion_SfGauge_XForms_MarkerPointer_MarkerHeight)'| markdownify }}</td>
<td>{{'[ShapeHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html#Syncfusion_Maui_Gauges_ShapePointer_ShapeHeight)'| markdownify }} in {{'[ShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html)'| markdownify }} class</td>
<td>Gets or sets a value that specifies the shape height in logical pixels.</td>
</tr>
<tr>
<td>{{'[MarkerWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.MarkerPointer.html#Syncfusion_SfGauge_XForms_MarkerPointer_MarkerWidth)'| markdownify }}</td>
<td>{{'[ShapeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html#Syncfusion_Maui_Gauges_ShapePointer_ShapeWidth)'| markdownify }} in {{'[ShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html)'| markdownify }} class</td>
<td>Gets or sets a value that specifies the shape width in logical pixels.</td>
</tr>
<tr>
<td>{{'[MarkerShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.MarkerPointer.html#Syncfusion_SfGauge_XForms_MarkerPointer_MarkerShape)'| markdownify }}</td>
<td>{{'[ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html#Syncfusion_Maui_Gauges_ShapePointer_ShapeType)'| markdownify }} in {{'[ShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html)'| markdownify }} class</td>
<td>Gets or sets a value that specifies the shape type for the pointer.</td>
</tr>
<tr>
<td>{{'[EnableDragging](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.MarkerPointer.html#Syncfusion_SfGauge_XForms_MarkerPointer_EnableDragging)'| markdownify }}</td>
<td>{{'[IsInteractive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html#Syncfusion_Maui_Gauges_RadialPointer_IsInteractive)'| markdownify }} in {{'[ShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html)'| markdownify }} class</td>
<td>Gets or sets a value that allows pointer value change by interaction.</td>
</tr>
</table>

The following code example, explains how to initialize the marker pointer in Xamarin SfCircularGauge and .NET MAUI SfRadialGauge.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfCircularGauge>
    <gauge:SfCircularGauge.Scales>
        <gauge:Scale>
            <gauge:Scale.Pointers>
                <gauge:MarkerPointer Value="70"
                                     Color="Pink"
                                     MarkerHeight="20"
                                     MarkerWidth="20"
                                     EnableDragging="True"
                                     Offset="1"/>
            </gauge:Scale.Pointers>
        </gauge:Scale>
    </gauge:SfCircularGauge.Scales>
</gauge:SfCircularGauge>

{% endhighlight %}

{% highlight C# %}

SfCircularGauge circularGauge = new SfCircularGauge();

ObservableCollection<Scale> scales = new ObservableCollection<Scale>();
Scale scale = new Scale();
scales.Add(scale);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 70;
markerPointer.Color = Color.Pink;
markerPointer.MarkerHeight = 20;
markerPointer.MarkerWidth = 20;
markerPointer.EnableDragging = true;
markerPointer.Offset = 1;
scale.Pointers.Add(markerPointer);

circularGauge.Scales = scales;
this.Content = circularGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:ShapePointer Value="70"
                                    Fill="Pink"
                                    IsInteractive="True"
                                    ShapeHeight="20"
                                    ShapeWidth="20"
                                    Offset="-20"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

ShapePointer markerPointer = new ShapePointer();
markerPointer.Value = 70;
markerPointer.IsInteractive = true;
markerPointer.Fill = new SolidColorBrush(Colors.Pink);
markerPointer.Offset = -20;
markerPointer.ShapeWidth = 20;
markerPointer.ShapeHeight = 20;
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Content pointer

The ContentPointer in SfRadialGauge allows to using of any content or image or text as a pointer. In Xamarin, you can add an image as a pointer through the [ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.MarkerPointer.html#Syncfusion_SfGauge_XForms_MarkerPointer_ImageSource) property, and in MAUI, you can directly add an image control as a pointer in the content pointer.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td> - </td>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ContentPointer.html#Syncfusion_Maui_Gauges_ContentPointer_Content)'| markdownify }}</td>
<td>Gets or sets the content of a ContentPointer.</td>
</tr>
</table>

The following code example, explains how to initialize content pointer .NET MAUI SfRadialGauge. The content pointer feature is not applicable in the Xamarin SfCircularGauge.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis >
            <gauge:RadialAxis.Pointers>
                <gauge:ContentPointer  Value="45" Offset="-20">
                    <gauge:ContentPointer.Content>
                        <Grid HeightRequest="37" WidthRequest="37" >
                            <RoundRectangle  Fill="White"
                                             CornerRadius="8"
                                             Stroke="Black" 
                                             StrokeThickness="2" />
                            <VerticalStackLayout>
                                <Label Text="45°F" 
                                       HorizontalOptions="Center"
                                       TextColor="Black" 
                                       FontAttributes="Bold"
                                       FontSize="10"/>
                            </VerticalStackLayout>
                        </Grid>
                    </gauge:ContentPointer.Content>
                </gauge:ContentPointer>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

ContentPointer pointer = new ContentPointer();
pointer.Value = 45;
pointer.Offset = -20;

Grid grid = new Grid();
grid.HeightRequest = 37;
grid.WidthRequest = 37;
grid.Children.Add(new RoundRectangle()
{
    Fill = new SolidColorBrush(Colors.White),
    CornerRadius = 8,
    Stroke = new SolidColorBrush(Colors.Black),
    StrokeThickness = 2,
});

VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
verticalStackLayout.Children.Add(new Label()
{
    Text = "45°F",
    HorizontalOptions = LayoutOptions.Center,
    TextColor = Colors.Black,
    FontAttributes = FontAttributes.Bold,
    FontSize = 10
});

grid.Children.Add(verticalStackLayout);
pointer.Content = grid;

radialAxis.Pointers.Add(pointer);
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

### Needle pointer

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[KnobColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_KnobColor)'| markdownify }}</td>
<td>{{'[KnobFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the knob.</td>
</tr>
<tr>
<td>{{'[KnobStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_KnobStrokeColor)'| markdownify }}</td>
<td>{{'[KnobStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobStroke)'| markdownify }}</td>
<td>Gets or sets a value that specifies the knob border color.</td>
</tr>
<tr>
<td>{{'[KnobStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_KnobStrokeWidth)'| markdownify }}</td>
<td>{{'[KnobStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the width of the knob stroke outline.</td>
</tr>
<tr>
<td>{{'[LengthFactor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_LengthFactor)'| markdownify }}</td>
<td>{{'[NeedleLength](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLength)'| markdownify }}</td>
<td>Gets or sets a value that specifies the length of the needle pointer.</td>
</tr>
<tr>
<td>{{'[TailColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_TailColor)'| markdownify }}</td>
<td>{{'[TailFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the tail shape.</td>
</tr>
<tr>
<td>{{'[TailLengthFactor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_TailLengthFactor)'| markdownify }}</td>
<td>{{'[TailLength](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLength)'| markdownify }}</td>
<td>Gets or sets a value that specifies the needle pointer tail length.</td>
</tr>
<tr>
<td>{{'[EnableDragging](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.NeedlePointer.html#Syncfusion_SfGauge_XForms_NeedlePointer_EnableDragging)'| markdownify }}</td>
<td>{{'[IsInteractive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html#Syncfusion_Maui_Gauges_RadialPointer_IsInteractive)'| markdownify }}</td>
<td>Gets or sets a value that allows pointer value change by interaction.</td>
</tr>
</table>

The following code example explains how to initialize the needle pointer in Xamarin SfCircularGauge and .NET MAUI SfRadialGauge.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfCircularGauge>
    <gauge:SfCircularGauge.Scales>
        <gauge:Scale>
            <gauge:Scale.Pointers>
                <gauge:NeedlePointer  Value="60"
                                      Color="DeepSkyBlue"
                                      LengthFactor="0.7"
                                      Thickness="7"/>
            </gauge:Scale.Pointers>
        </gauge:Scale>
    </gauge:SfCircularGauge.Scales>
</gauge:SfCircularGauge>

{% endhighlight %}

{% highlight C# %}

SfCircularGauge circularGauge = new SfCircularGauge();

ObservableCollection<Scale> scales = new ObservableCollection <Scale>();
Scale scale = new Scale();

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.Color = Color.DeepSkyBlue;
needlePointer.Thickness = 7;
needlePointer.LengthFactor = 0.7;
scale.Pointers.Add(needlePointer);

scales.Add(scale);
circularGauge.Scales = scales;
this.Content = circularGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value="60"
                                     NeedleFill="DeepSkyBlue"
                                     NeedleLengthUnit="Factor"
                                     NeedleLength="0.7"
                                     NeedleStartWidth="0.1"
                                     NeedleEndWidth="10"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.NeedleFill = new SolidColorBrush(Colors.DeepSkyBlue);
needlePointer.NeedleLengthUnit = SizeUnit.Factor;
needlePointer.NeedleLength = 0.7;
needlePointer.NeedleStartWidth = 0.1;
needlePointer.NeedleEndWidth = 10;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Range pointer

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[Offset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.RangePointer.html#Syncfusion_SfGauge_XForms_RangePointer_Offset)'| markdownify }}</td>
<td>{{'[PointerOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset)'| markdownify }}</td>
<td>Gets or sets the value that specifies the position value for the pointer.</td>
</tr>
<tr>
<td>{{'[RangeCap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.RangePointer.html#Syncfusion_SfGauge_XForms_RangePointer_RangeCap)'| markdownify }}</td>
<td>{{'[CornerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_CornerStyle)'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the range pointer.</td>
</tr>
<tr>
<td>{{'[Thickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.RangePointer.html#Syncfusion_SfGauge_XForms_RangePointer_Thickness)'| markdownify }}</td>
<td>{{'[PointerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth)'| markdownify }}</td>
<td>Gets or sets the width of the knob stroke outline.</td>
</tr>
</table>

The following code example explains how to initialize the range pointer in Xamarin SfCircularGauge and .NET MAUI SfRadialGauge.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfCircularGauge>
    <gauge:SfCircularGauge.Scales>
        <gauge:Scale>
            <gauge:Scale.Pointers>
                <gauge:RangePointer Value="50"
                                    RangeCap="Both"
                                    Offset="0.7"
                                    Thickness = "30"/>
            </gauge:Scale.Pointers>
        </gauge:Scale>
    </gauge:SfCircularGauge.Scales>
</gauge:SfCircularGauge>

{% endhighlight %}

{% highlight C# %}

SfCircularGauge circularGauge = new SfCircularGauge();

ObservableCollection<Scale> scales = new ObservableCollection<Scale>();
Scale scale = new Scale();

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 50;
rangePointer.RangeCap = RangeCap.Both;
rangePointer.Offset = 0.7;
rangePointer.Thickness = 30;
scale.Pointers.Add(rangePointer);

scales.Add(scale);
circularGauge.Scales = scales;
this.Content = circularGauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value="50"
                                    CornerStyle="BothCurve"
                                    OffsetUnit="Factor"
                                    PointerOffset="0.3"
                                    PointerWidth="30"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 30;
rangePointer.CornerStyle = CornerStyle.BothCurve;
rangePointer.OffsetUnit = SizeUnit.Factor;
rangePointer.PointerOffset = 0.3;
rangePointer.PointerWidth = 10;
radialAxis.Pointers.Add(rangePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Annotation

Annotations in Xamarin can only be set for circular gauge and cannot be defined for axis/scale. However, with .NET MAUI, you can set annotations on each axis.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[View](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.GaugeAnnotation.html#Syncfusion_SfGauge_XForms_GaugeAnnotation_View)'| markdownify }}</td>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_Content)'| markdownify }}</td>
<td>Gets or sets the value that represents annotation's content.</td>
</tr>
<tr>
<td>{{'[Angle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.GaugeAnnotation.html#Syncfusion_SfGauge_XForms_GaugeAnnotation_Angle)'| markdownify }}</td>
<td>{{'[DirectionValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionValue)'| markdownify }} and {{'[DirectionUnit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionUnit)'| markdownify }} is Angle.</td>
<td>Gets or sets the value to adjusts the annotation distance from center. You can specify value either in axis value or angle using the {{'[DirectionUnit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionUnit)'| markdownify }} property.</td>
</tr>
<tr>
<td>{{'[Offset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.GaugeAnnotation.html#Syncfusion_SfGauge_XForms_GaugeAnnotation_Offset)'| markdownify }}</td>
<td>{{'[PositionFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_PositionFactor)'| markdownify }}</td>
<td>Gets or sets a value that specifies the position of annotation in radius factor.</td>
</tr>
</table>

The following code example explains how to initialize the range pointer in Xamarin SfCircularGauge and .NET MAUI SfRadialGauge.

<table>
<tr>
<th>Xamarin SfCircularGauge</th>
<th>.NET MAUI SfRadialGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfCircularGauge>
    <gauge:SfCircularGauge.Scales>
        <gauge:Scale/> 
    </gauge:SfCircularGauge.Scales>
    <gauge:SfCircularGauge.Annotations>
        <gauge:GaugeAnnotation>
            <gauge:GaugeAnnotation.View>
                <Label Text="128 GB" 
                       FontSize="20" />
            </gauge:GaugeAnnotation.View>
        </gauge:GaugeAnnotation>
    </gauge:SfCircularGauge.Annotations>
</gauge:SfCircularGauge>

{% endhighlight %}

{% highlight C# %}

SfCircularGauge gauge = new SfCircularGauge();

ObservableCollection<Scale> scales = new ObservableCollection<Scale>();
Scale scale = new Scale();
scales.Add(scale);
gauge.Scales = scales;

GaugeAnnotation annotation = new GaugeAnnotation();
Label label = new Label();
label.Text = "128 GB";
label.FontSize = 20;
annotation.View = label;
gauge.Annotations.Add(annotation);

this.Content = gauge;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Annotations>
                <gauge:GaugeAnnotation>
                    <gauge:GaugeAnnotation.Content>
                        <Label Text="256 GB"
                               FontSize="20" />
                    </gauge:GaugeAnnotation.Content>
                </gauge:GaugeAnnotation>
            </gauge:RadialAxis.Annotations>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>


{% endhighlight %}

{% highlight C# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
gaugeAnnotation.Content = new Label
{
    Text = "128 GB",
    FontSize = 20
};
radialAxis.Annotations.Add(gaugeAnnotation);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>
