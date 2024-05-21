---
layout: post
title: Migrate from Xamarin to .NET MAUI SfDigitalGauge | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SfDigitalGauge to Syncfusion .NET MAUI SfDigitalGauge control and more.
platform: MAUI
control: SfDigitalGauge
documentation: ug
---  

# Migrate from Xamarin.Forms SfDigitalGauge to .NET MAUI SfDigitalGauge

To make the migration from the Xamarin `SfDigitalGauge` to the .NET MAUI `SfDigitalGauge` easier, most of the similar APIs from the Xamarin `SfDigitalGauge` were kept in the.NET MAUI `SfDigitalGauge`. Also, the APIs has been restructured by considering various use cases and maintaining API consistency. Please find the difference in the following topics.

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

## Character Segments

In the .NET MAUI digital gauge, APIs there 

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th>
<th>Description</th></tr>
<tr>
<td>Value</td>
<td>Text</td>
<td>Gets or sets the value of the text of the digital gauge.</td>
</tr>
<tr>
<td>SegmentStrokeWidth</td>
<td>StrokeWidth</td>
<td>Gets or sets the value stroke width of the segment.</td>
</tr>
<tr>
<td>DisabledSegmentColor</td>
<td>DisabledSegmentStroke</td>
<td>Gets or sets a color for the disabled segment of the digital gauge</td>
</tr>
<tr>
<td>CharacterStrokeColor</td>
<td>CharacterStroke</td>
<td>Gets or sets a color for the text color of the digital gauge</td>
</tr>
<tr>
<td>CharacterWidth</td>
<td>CharacterWidth</td>
<td>Gets or sets a value to the character width.</td>
</tr>
<tr>
<td>DisabledSegmentAlpha</td>
<td>DisabledSegmentAlpha</td>
<td>Gets or sets a value to visibility of the disabled segment.</td>
</tr>
<tr>
<td>CharacterHeight</td>
<td>CharacterHeight</td>
<td>Gets or sets the value for the character height</td>
</tr>
<tr>
<td>CharacterSpacing</td>
<td>CharacterSpacing</td>
<td>Gets or sets the value for the character spacing</td>
</tr>
</table>

The following code example explains how to initialize the axis in Xamarin SfDigitalGauge and .NET MAUI SfDigitalGauge.

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

## Character Types

<table>
<tr>
<th>Xamarin SfDigitalGauge</th>
<th>.NET MAUI SfDigitalGauge</th>
<th>Description</th></tr>
<tr>
<td>SegmentSeven</td>
<td>SevenSegment</td>
<td>The seven-segment type is capable of displaying numbers and a few uppercase letters efficiently.</td>
</tr>
<tr>
<td>SegmentFourteen</td>
<td>FourteenSegment</td>
<td>The fourteen-segment type is capable of displaying numbers and alphabet efficiently.</td>
</tr>
<tr>
<td>SegmentSixteen</td>
<td>SixteenSegment</td>
<td>The sixteen-segment type is capable of displaying numbers and alphabet clearly.</td>
</tr>
<tr>
<td>EightCrossEightDotMatrix</td>
<td>EightCrossEightDotMatrix</td>
<td>The dot matrix segment type is capable of displaying numbers, alphabet, and special characters efficiently.</td>
</tr>
</table>

The following code example explains how to initialize the charactertype in Xamarin SfDigitalGauge and .NET MAUI SfDigitalGauge.

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
