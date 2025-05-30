---
layout: post
title: Migrate from Xamarin to .NET MAUI SfDigitalGauge | Syncfusion<sup>&reg;</sup> 
description: Learn here all about Migrating from Syncfusion<sup>&reg;</sup> Xamarin SfDigitalGauge to Syncfusion<sup>&reg;</sup> .NET MAUI SfDigitalGauge control and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .NET MAUI, .NET MAUI digital gauge, digital gauge, character segments, digital character, character types, character display types
---  

# Migrate from Xamarin.Forms SfDigitalGauge to .NET MAUI SfDigitalGauge

To make the migration from the [Xamarin SfDigitalGauge](https://www.nuget.org/packages/Syncfusion.Xamarin.SfGauge) to the [.NET MAUI SfDigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) easier, most of the similar APIs from the [Xamarin SfDigitalGauge](https://www.nuget.org/packages/Syncfusion.Xamarin.SfGauge) were kept in the [.NET MAUI SfDigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge). Also, the APIs have been restructured by considering various use cases and maintaining API consistency. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the gauge namespace and initialize SfDigitalGauge as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:gauge="clr-namespace:Syncfusion.SfGauge.XForms;assembly=Syncfusion.SfGauge.XForms">

        <gauge:SfDigitalGauge/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfGauge.XForms;
...

SfDigitalGauge digitalGauge = new SfDigitalGauge();
this.Content = digitalGauge;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

        <gauge:SfDigitalGauge/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Gauges;
...

SfDigitalGauge digitalGauge = new SfDigitalGauge();
this.Content = digitalGauge;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Properties

The following code example, explains how to initialize the properties of the `Xamarin SfDigitalGauge` and `.NET MAUI SfDigitalGauge`.

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_Value)'| markdownify }}</td>
<td>{{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_Text)'| markdownify }}</td>
<td>Gets or sets the value of the text of the digital gauge.</td>
</tr>
<tr>
<td>{{'[SegmentStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_SegmentStrokeWidth)'| markdownify }}</td>
<td>{{'[StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_StrokeWidth)'| markdownify }}</td>
<td>Gets or sets the value stroke width of the segment.</td>
</tr>
<tr>
<td>{{'[DisabledSegmentColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_DisabledSegmentColor)'| markdownify }}</td>
<td>{{'[DisabledSegmentStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentStroke)'| markdownify }}</td>
<td>Gets or sets a color for the disabled segment of the digital gauge</td>
</tr>
<tr>
<td>{{'[CharacterStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_CharacterStrokeColor)'| markdownify }}</td>
<td>{{'[CharacterStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke)'| markdownify }}</td>
<td>Gets or sets a color for the text color of the digital gauge</td>
</tr>
<tr>
<td>{{'[CharacterWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_CharacterWidth)'| markdownify }}</td>
<td>{{'[CharacterWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth)'| markdownify }}</td>
<td>Gets or sets a value to the character width.</td>
</tr>
<tr>
<td>{{'[DisabledSegmentAlpha](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_DisabledSegmentAlpha)'| markdownify }}</td>
<td>{{'[DisabledSegmentAlpha](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentAlpha)'| markdownify }}</td>
<td>Gets or sets a value to visibility of the disabled segment.</td>
</tr>
<tr>
<td>{{'[CharacterHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_CharacterHeight)'| markdownify }}</td>
<td>{{'[CharacterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight)'| markdownify }}</td>
<td>Gets or sets the value for the character height</td>
</tr>
<tr>
<td>{{'[CharacterSpacing](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.html#Syncfusion_SfGauge_XForms_SfDigitalGauge_CharacterSpacing)'| markdownify }}</td>
<td>{{'[CharacterSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing)'| markdownify }}</td>
<td>Gets or sets the value for the character spacing</td>
</tr>
</table>

The following code example explains how to initialize the segments in Xamarin SfDigitalGauge and .NET MAUI SfDigitalGauge.

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Value="SYNCFUSION" SegmentStrokeWidth="4" 
                          HeightRequest="100"  WidthRequest="340"
                          DisabledSegmentAlpha="25" DisabledSegmentColor="Gray"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SegmentSeven" 
                         CharacterStrokeColor="#146CED"/>

{% endhighlight %}

{% highlight C# %}

 SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 340;

            digital.Value = "SYNCFUSION";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.SegmentStrokeWidth = 4;

            digital.CharacterType = CharacterType.SegmentSeven;

            digital.DisabledSegmentAlpha = 25;

            digital.CharacterStrokeColor = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentColor = Color.Gray;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

 <gauge:SfDigitalGauge Text="1 2 3 4 5" StrokeWidth="5" 
                          HeightRequest="100"  WidthRequest="300"
                          DisabledSegmentAlpha="25" DisabledSegmentStroke="LightSkyBlue"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SevenSegment" 
                         CharacterStroke="#146CED"/>

{% endhighlight %}

{% highlight C# %}

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
</td></tr>
</table>

## Enum

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[CharacterType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.CharacterType.html)'| markdownify }}</td>
<td>{{'[DigitalGaugeCharacterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html)'| markdownify }}</td>
<td>Defines the character segment type for the SfDigitalGauge.</td>
</tr>
</table>

## Character Types

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[SegmentSeven](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.CharacterType.html#Syncfusion_SfGauge_XForms_CharacterType_SegmentSeven)'| markdownify }}</td>
<td>{{'[SevenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SevenSegment)'| markdownify }}</td>
<td>The seven-segment type is capable of displaying numbers and a few uppercase letters efficiently.</td>
</tr>
<tr>
<td>{{'[SegmentFourteen](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.CharacterType.html#Syncfusion_SfGauge_XForms_CharacterType_SegmentFourteen)'| markdownify }}</td>
<td>{{'[FourteenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_FourteenSegment)'| markdownify }}</td>
<td>The fourteen-segment type is capable of displaying numbers and alphabet efficiently.</td>
</tr>
<tr>
<td>{{'[SegmentSixteen](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.CharacterType.html#Syncfusion_SfGauge_XForms_CharacterType_SegmentSixteen)'| markdownify }}</td>
<td>{{'[SixteenSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_SixteenSegment)'| markdownify }}</td>
<td>The sixteen-segment type is capable of displaying numbers and alphabet clearly.</td>
</tr>
<tr>
<td>{{'[EightCrossEightDotMatrix](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.CharacterType.html#Syncfusion_SfGauge_XForms_CharacterType_EightCrossEightDotMatrix)'| markdownify }}/td>
<td>{{'[EightCrossEightDotMatrix](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html#Syncfusion_Maui_Gauges_DigitalGaugeCharacterType_EightCrossEightDotMatrix)'| markdownify }}</td>
<td>The dot matrix segment type is capable of displaying numbers, alphabet, and special characters efficiently.</td>
</tr>
</table>

The following code example explains how to initialize the character type in Xamarin SfDigitalGauge and .NET MAUI SfDigitalGauge.

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Value="SYNCFUSION" SegmentStrokeWidth="4" 
                          HeightRequest="100"  WidthRequest="340"
                          DisabledSegmentAlpha="25" DisabledSegmentColor="Gray"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SegmentSeven" 
                         CharacterStrokeColor="#146CED"/>

{% endhighlight %}

{% highlight C# %}

SfDigitalGauge digital = new SfDigitalGauge();

            digital.HeightRequest = 100;

            digital.WidthRequest = 340;

            digital.Value = "SYNCFUSION";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.HorizontalOptions = LayoutOptions.Center;

            digital.VerticalOptions = LayoutOptions.Center;

            digital.SegmentStrokeWidth = 4;

            digital.CharacterType = CharacterType.SegmentSeven;

            digital.DisabledSegmentAlpha = 25;

            digital.CharacterStrokeColor = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentColor = Color.Gray;


{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<gauge:SfDigitalGauge Text="1 2 3 4 5" StrokeWidth="5" 
                          HeightRequest="100"  WidthRequest="300"
                          DisabledSegmentAlpha="25" DisabledSegmentStroke="LightSkyBlue"
                          CharacterHeight="90" CharacterWidth="25" 
                          HorizontalOptions="Center" VerticalOptions="Center"
                          CharacterType="SevenSegment" 
                         CharacterStroke="#146CED"/>

{% endhighlight %}

{% highlight C# %}

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
</td></tr>
</table>

## Event
<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th>
<th>Description</th></tr>
<tr>
<td>{{'[ValueChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfGauge.XForms.SfDigitalGauge.ValueChangedEventHandler.html)'| markdownify }}</td>
<td>{{'[TextChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeTextChangedEventArgs.html)'| markdownify }}</td>
<td>Occurs when the text of the DigitalGauge is changed.</td>
</tr>
</table>