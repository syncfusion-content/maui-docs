---
layout: post
title: Appearance in .NET MAUI Circular ProgressBar control | Syncfusion
description: Learn here all about appearance support in Syncfusion<sup>&reg;</sup> .NET MAUI Circular ProgressBar control, its elements and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# Appearance in .NET MAUI Circular ProgressBar (SfCircularProgressBar)

## Angle

The appearance of the circular progress bar can be customized to semi-circle, arc, and more. The start and end angles can be customized using the [`StartAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_StartAngle) and [`EndAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_EndAngle) properties respectively.

The following code sample demonstrates how to change the appearance of the circular progress bar to semi-circle.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="75" 
                                   StartAngle="180" 
                                   EndAngle="360" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 75;
circularProgressBar.StartAngle = 180;
circularProgressBar.EndAngle = 360;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with angle customization](images/appearance/angle.png)

## Range colors

Visualize multiple ranges with different colors mapped to each range to enhance the readability of progress.

The colors can be mapped to the specific ranges using the [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops) property, which holds a collection of [`ProgressGradientStop`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html). 

The following properties in the [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops) are used to map the colors to a range:

* [`Color:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html#Syncfusion_Maui_ProgressBar_ProgressGradientStop_Color) Represents the color to the specified range.
* [`Value:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html#Syncfusion_Maui_ProgressBar_ProgressGradientStop_Value) Represents the start or end value for the specified color.

The following code sample demonstrates how to map the solid color range in the circular progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="100" >
    <progressBar:SfCircularProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="25"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="25"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="50"/>
        <progressBar:ProgressGradientStop Color="#e9648e" Value="50"/>
        <progressBar:ProgressGradientStop Color="#e9648e" Value="75"/>
        <progressBar:ProgressGradientStop Color="#fbb78a" Value="75"/>
        <progressBar:ProgressGradientStop Color="#fbb78a" Value="100"/>
    </progressBar:SfCircularProgressBar.GradientStops>
</progressBar:SfCircularProgressBar>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 100;
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 25 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 25 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 50 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("e9648e"), Value = 50 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("e9648e"), Value = 75 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("fbb78a"), Value = 75 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("fbb78a"), Value = 100 });
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with range colors](images/appearance/range-colors.png)

The following code sample demonstrates how to apply gradient transition effect to the range colors in the circular progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="100">
    <progressBar:SfCircularProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="25"/>
        <progressBar:ProgressGradientStop Color="#e9648e" Value="50"/>
        <progressBar:ProgressGradientStop Color="#fbb78a" Value="75"/>
    </progressBar:SfCircularProgressBar.GradientStops>
</progressBar:SfCircularProgressBar>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 100;
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 25 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("e9648e"), Value = 50 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("fbb78a"), Value = 75 });
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with gradient range](images/appearance/gradient.png)

## Thickness

The following properties are used to customize the appearance of the circular progress bar:

* [`ProgressRadiusFactor:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressRadiusFactor) Defines the outer radius of the progress indicator.
* [`ProgressThickness:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressThickness) Defines the thickness of the progress indicator.
* [`TrackRadiusFactor:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackRadiusFactor) Defines the outer radius of the track indicator.
* [`TrackThickness:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackThickness) Defines the thickness of the track indicator.
* [`ThicknessUnit:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ThicknessUnit) Specifies whether the [`ProgressThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressThickness) or [`TrackThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackThickness) are defined in pixel or factor.

The [`ProgressThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressThickness) or [`TrackThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackThickness) of the progress bar can be specified either in pixel or factor. If the [`ThicknessUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ThicknessUnit) is specified as [`Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SizeUnit.html#Syncfusion_Maui_ProgressBar_SizeUnit_Pixel), the range will be rendered based on the provided pixel value. If the [`ThicknessUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ThicknessUnit) is set as [`Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SizeUnit.html#Syncfusion_Maui_ProgressBar_SizeUnit_Factor), the provided factor value will be multiplied by the outer radius. For example, if the thickness width is set as 0.1, then 10% of outer radius is considered as thickness.

The following code sample demonstrates how to customize the appearance of the circular progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="75"
                                   TrackRadiusFactor="0.8" 
                                   ProgressRadiusFactor="0.75"
                                   ThicknessUnit="Factor"
                                   TrackThickness="0.05"
                                   ProgressThickness="0.05" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 75;
circularProgressBar.TrackRadiusFactor = 0.8;
circularProgressBar.ProgressRadiusFactor = 0.75;
circularProgressBar.TrackThickness = 0.05;
circularProgressBar.ProgressThickness = 0.05;
circularProgressBar.ThicknessUnit = SizeUnit.Factor;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with appearance customization](images/appearance/circular-thickness.png)

## Corner style customization

The [`ProgressCornerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressCornerStyle) and [`TrackCornerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackCornerStyle) property of the circular progress bar specifies the corner type for the progress and track. The corners can be customized using the [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.CornerStyle.html#Syncfusion_Maui_ProgressBar_CornerStyle_BothFlat), [`BothCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.CornerStyle.html#Syncfusion_Maui_ProgressBar_CornerStyle_BothCurve), [`StartCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.CornerStyle.html#Syncfusion_Maui_ProgressBar_CornerStyle_StartCurve), and [`EndCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.CornerStyle.html#Syncfusion_Maui_ProgressBar_CornerStyle_EndCurve) options. The default value of this property is [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.CornerStyle.html#Syncfusion_Maui_ProgressBar_CornerStyle_BothFlat).

The following code sample demonstrates the corner style customization in progress and track indicator.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="50"
                                   TrackCornerStyle="BothCurve"
                                   ProgressCornerStyle="BothCurve"
                                   StartAngle="180"
                                   EndAngle="360" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 50;
circularProgressBar.TrackCornerStyle = CornerStyle.BothCurve;
circularProgressBar.ProgressCornerStyle = CornerStyle.BothCurve;
circularProgressBar.StartAngle = 180;
circularProgressBar.EndAngle = 360;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with corner style customization](images/appearance/corner-style.png)

## Color customization

The following properties are used to customize the color in the circular progress bar.

* [`ProgressFill:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill) Represents the color of the progress indicator.
* [`TrackFill:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill) Represents the color of the track indicator.

The following code sample demonstrates the color customization in progress and track indicator.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="75"
                                   TrackFill="#3351483a" 
                                   ProgressFill="#FF51483a"/>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 75;
circularProgressBar.TrackFill = Color.FromArgb("3351483a");
circularProgressBar.ProgressFill = Color.FromArgb("FF51483a");
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with color customization](images/appearance/color.png)

N> Refer to our [.NET MAUI Circular ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Circular ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.