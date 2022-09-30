---
layout: post
title: Getting started with .NET MAUI Slider control | Syncfusion
description: This section explains about the getting started with Syncfusion MAUI Slider (SfDateTimeSlider) control and more.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# Getting Started with .NET MAUI DateTime Slider (SfDateTimeSlider)

This section explains the steps required to add the DateTime Slider control and its elements track, ticks, labels, and tooltip. This section covers only basic features needed to know to get started with Syncfusion DateTime Slider.

## Creating an application with .NET MAUI

Create a new .NET MAUI application in Visual Studio.

 ![Create MAUI Application](images/getting-started/create-project.png)

## Adding SfDateTimeSlider reference

 The Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add the SfDateTimeSlider to your project, open the NuGet package manager in the Visual Studio, search for the Syncfusion.Maui.Sliders, and install it.

 ![Create MAUI Application](images/getting-started/nuget-installation.png)


## Handler registration

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace SliderGettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}


{% endhighlight %}

## Initialize DateTimeSlider

Import the [`SfDateTimeSlider`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html?tabs=tabid-2) namespace and initialize the DateTime Slider as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders">
    <Grid>
        <sliders:SfDateTimeSlider Minimum="2010-01-01"
                                  Maximum="2018-01-01"
                                  Value="2014-01-01" />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Sliders;

namespace SliderGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDateTimeSlider slider = new SfDateTimeSlider();
            slider.Minimum = new DateTime(2010, 01, 01);
            slider.Maximum = new DateTime(2018, 01, 01);
            slider.Value = new DateTime(2014, 01, 01);
            this.content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Initialize slider](images/getting-started/initialize-slider.png)

## Enable labels

The [`ShowLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels) property enables the labels which renders on given interval.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2018-01-01"
                          Value="2014-01-01"
                          ShowLabels="True"
                          Interval="2" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2018, 01, 01);
slider.Value = new DateTime(2014, 01, 01);
slider.ShowLabels = true;
slider.Interval = 2;

{% endhighlight %}

{% endtabs %}

![Slider labels](images/getting-started/labels.png)

## Enable ticks

The [`ShowTicks`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks) property enables the ticks in the range selector, while the [`MinorTicksPerInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval) property enables the minor ticks between the major ticks.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2018-01-01"
                          Value="2014-01-01"
                          ShowLabels="True"
                          ShowTicks="True"
                          Interval="2"
                          MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2018, 01, 01),
    Value = new DateTime(2014, 01, 01),
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
    MinorTicksPerInterval = 1,
};

{% endhighlight %}

{% endtabs %}

![Slider ticks](images/getting-started/ticks.png)

## Orientation

The [`Orientation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Orientation) property allows you to show the slider in both horizontal and vertical directions. The default value of the [`Orientation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Orientation) property is `Horizontal`.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Orientation="Vertical"
                          Minimum="2010-01-01"
                          Maximum="2018-01-01"
                          Value="2014-01-01"
                          ShowLabels="True"
                          ShowTicks="True"
                          Interval="2"
                          MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Orientation = SliderOrientation.Vertical;
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2018, 01, 01);
slider.Value = new DateTime(2014, 01, 01);
slider.ShowLabels = true;
slider.Interval = 2;
slider.ShowTicks = true;
slider.MinorTicksPerInterval = 1;

{% endhighlight %}

{% endtabs %}

![Slider orientation](images/getting-started/orientation.png)

## Inverse the slider

Invert the slider using the [`IsInversed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property. The default value of the [`IsInversed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property is `False`.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2018-01-01"
                          Value="2014-01-01"
                          IsInversed="True"
                          ShowLabels="True"
                          ShowTicks="True"
                          Interval="2"
                          MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2018, 01, 01);
slider.Value = new DateTime(2014, 01, 01);
slider.IsInversed = true;
slider.ShowLabels = true;
slider.Interval = 2;
slider.ShowTicks = true;
slider.MinorTicksPerInterval = 1;

{% endhighlight %}

{% endtabs %}

![Inverse slider](images/getting-started/slider-inverse.png)

## Formatting labels

Add prefix or suffix to the labels using the [`DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_DateFormat) property.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2011-01-01"
                          Value="2010-07-01"
                          DateFormat="MMM"
                          IntervalType="Months"
                          ShowTicks="True"
                          MinorTicksPerInterval="1"
                          ShowLabels="True"
                          Interval="2" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2011, 01, 01),
    Value = new DateTime(2010, 07, 01),
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
    MinorTicksPerInterval = 1,
    DateFormat = "MMM",
    IntervalType = SliderDateIntervalType.Months,
};

{% endhighlight %}

{% endtabs %}

![Slider label format](images/getting-started/label-format.png)
