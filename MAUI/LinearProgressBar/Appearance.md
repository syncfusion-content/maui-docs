---
layout: post
title: Appearance in .NET MAUI Linear ProgressBar control | Syncfusion
description: Learn here all about appearance support in Syncfusion<sup>&reg;</sup> .NET MAUI Linear ProgressBar control, its elements and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Appearance in .NET MAUI Linear ProgressBar (SfLinearProgressBar)

## Range colors

Visualize multiple ranges with different colors mapped to each range to enhance the readability of progress.

The colors can be mapped to the specific ranges using the [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops) property, which holds a collection of [`ProgressGradientStop`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html). 

The following properties in the [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops) are used to map the colors to a range:

* [`Color:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html#Syncfusion_Maui_ProgressBar_ProgressGradientStop_Color) Represents the color to the specified range.
* [`Value:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html#Syncfusion_Maui_ProgressBar_ProgressGradientStop_Value) Represents the start or end value for the specified color.

The following code sample demonstrates how to map the solid color range in the linear progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="100">
    <progressBar:SfLinearProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="25"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="25"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="50"/>
        <progressBar:ProgressGradientStop Color="#e9648e" Value="50"/>
        <progressBar:ProgressGradientStop Color="#e9648e" Value="75"/>
        <progressBar:ProgressGradientStop Color="#fbb78a" Value="75"/>
        <progressBar:ProgressGradientStop Color="#fbb78a" Value="100"/>
    </progressBar:SfLinearProgressBar.GradientStops>
</progressBar:SfLinearProgressBar>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 100;
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 25 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 25 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 50 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("e9648e"), Value = 50 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("e9648e"), Value = 75 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("fbb78a"), Value = 75 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("fbb78a"), Value = 100 });
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with range colors](images/appearance/range-colors.png)

The following code sample demonstrates how to apply gradient transition effect to the range colors in the linear progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="100" >
    <progressBar:SfLinearProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="25"/>
        <progressBar:ProgressGradientStop Color="#e9648e" Value="50"/>
        <progressBar:ProgressGradientStop Color="#fbb78a" Value="75"/>
    </progressBar:SfLinearProgressBar.GradientStops>
</progressBar:SfLinearProgressBar>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 100;
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 25 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("e9648e"), Value = 50 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("fbb78a"), Value = 75 });
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with gradient range](images/appearance/gradient.png)

## Thickness

In the linear progress bar, the height of the track, progress, and secondary progress can be customized using the [`TrackHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackHeight), [`ProgressHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressHeight), and [`SecondaryProgressHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressHeight) properties, respectively.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="30" 
                                 TrackHeight="10" 
                                 ProgressHeight="10"
                                 SecondaryProgressHeight="10"
                                 SecondaryProgress="70" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 100;
linearProgressBar.SecondaryProgress = 100;
linearProgressBar.TrackHeight = 10;
linearProgressBar.ProgressHeight = 10;
linearProgressBar.SecondaryProgressHeight = 10;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with height customization](images/appearance/thickness.png)

## Padding

In the linear progress bar, the padding of the progress and the secondary progress indicator at the left and right ends can be adjusted by using the [`ProgressPadding`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressPadding) property.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="30"
                                 TrackHeight="15"
                                 ProgressHeight="5"
                                 SecondaryProgressHeight="5"
                                 SecondaryProgress="70" 
                                 ProgressPadding="5"/>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 30;
linearProgressBar.SecondaryProgress = 70;
linearProgressBar.TrackHeight = 15;
linearProgressBar.ProgressHeight = 5;
linearProgressBar.SecondaryProgressHeight = 5;
linearProgressBar.ProgressPadding = 5;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear ProgressBar with padding adjustment](images/appearance/padding.png)

## Corner radius

In the linear progress bar, the corner radius of the track, progress, and secondary progress can be customized using the [`TrackCornerRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackCornerRadius), [`ProgressCornerRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressCornerRadius), and [`SecondaryProgressCornerRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressCornerRadius) properties, respectively.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="50"
                                 TrackHeight="10" 
                                 TrackCornerRadius="5"
                                 ProgressHeight="10"
                                 ProgressCornerRadius="5" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 50;
linearProgressBar.TrackHeight = 10;
linearProgressBar.ProgressHeight = 10;
linearProgressBar.ProgressCornerRadius = 5;
linearProgressBar.TrackCornerRadius = 5;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with corner radius customization](images/appearance/corner-radius.png)

## Color customization

The following properties are used to customize the color in the linear progress bar.

* [`ProgressFill:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill) Represents the color of the progress indicator.
* [`TrackFill:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill) Represents the color of the track indicator.

The following code sample demonstrates the color customization in progress and track indicator.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="75" 
                                 TrackFill="#3351483a" 
                                 ProgressFill="#FF51483a" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 75;
linearProgressBar.TrackFill = Color.FromArgb("3351483a");
linearProgressBar.ProgressFill = Color.FromArgb("FF51483a");
linearProgressBar.SecondaryProgressFill = Colors.CornflowerBlue;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with color customization](images/appearance/color.png)

The linear progress bar provides support to customize the color for the secondary progress bar using the [`SecondaryProgressFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressFill) property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="25" 
                                 SecondaryProgress="75" 
                                 SecondaryProgressFill="CornflowerBlue" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SecondaryProgress = 75;
linearProgressBar.SecondaryProgressFill = Colors.CornflowerBlue;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with seconday progress color customization](images/appearance/secondary-progress.png)

N> Refer to our [.NET MAUI Linear ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Linear ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfLinearProgressBar in .NET MAUI.