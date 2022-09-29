---
layout: post
title: Appearance in .NET MAUI Linear ProgressBar control | Syncfusion
description: Learn here all about appearance support in Syncfusion .NET MAUI Linear ProgressBar control, its elements and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Appearance in .NET MAUI Linear ProgressBar (SfLinearProgressBar)

## Range colors

Visualize multiple ranges with different colors mapped to each range to enhance the readability of progress.

The colors can be mapped to the specific ranges using the `GradientStops` property, which holds a collection of `ProgressGradientStop`. 

The following properties in the `GradientStops` are used to map the colors to a range:

* `Color:` Represents the color to the specified range.
* `Value:` Represents the start or end value for the specified color.

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

![.NET MAUI SfLinearProgressBar with range colors](images/appearance/range-colors.png)

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

![.NET MAUI SfLinearProgressBar with gradient range](images/appearance/gradient.png)

## Thickness

In the linear progress bar, the height of the track, progress, and secondary progress can be customized using the `TrackHeight`, `ProgressHeight`, and `SecondaryProgressHeight` properties, respectively.

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

![.NET MAUI Linear Progress Bar with height customization](images/appearance/thickness.png)

## Corner radius

In the linear progress bar, the corner radius of the track, progress, and secondary progress can be customized using the `TrackCornerRadius`, `ProgressCornerRadius`, and `SecondaryCornerRadius` properties, respectively.

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

![.NET MAUI Linear Progress Bar with corner radius customization](images/appearance/corner-radius.png)

## Color customization

The following properties are used to customize the color in the linear progress bar.

* `ProgressFill:` Represents the color of the progress indicator.
* `TrackFill:` Represents the color of the track indicator.

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

![.NET MAUI Linear Progress Bar with color customization](images/appearance/color.png)

The linear progress bar provides support to customize the color for the secondary progress bar using the `SecondaryProgressFill` property as demonstrated in the following code sample.

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

![.NET MAUI Linear Progress Bar with seconday progress color customization](images/appearance/secondary-progress.png)

N> Refer to our `.NET MAUI SfLinearProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI SfLinearProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfLinearProgressBar in .NET MAUI.