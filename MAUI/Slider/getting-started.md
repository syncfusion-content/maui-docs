---
layout: post
title: Getting started with .NET MAUI Slider control | Syncfusion
description: This section explains about the getting started with Syncfusion MAUI Slider (SfSlider) control.
platform: maui
control: SfSlider
documentation: ug
---

# Getting Started with .NET MAUI Slider

This section explains the steps required to add the slider control and its elements such as numeric and date values, ticks, labels and tooltip. This section covers only basic features needed to know to get started with Syncfusion Slider.

## Creating an application with .NET MAUI Slider

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfSlider to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Sliders and then install it.
3. To initialize the control, import the Slider namespace.
4. Initialize SfSlider.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:slider="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders">
    <Grid>
        <slider:SfSlider/>
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
            SfSlider slider = new SfSlider();
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Register the handler

Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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

## Initialize slider

Import the `SfSlider` namespace and initialize the slider as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:slider="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders">
    <Grid>
        <slider:SfSlider />
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
            SfSlider slider = new SfSlider();
            this.content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Initialize slider](images/getting-started/initialize-slider.png)

## Set date value

Set the 'DateTime' values to the `Minimum`, `Maximum`, and `Value` properties to display date labels in the slider.

{% tabs %}

{% highlight xaml %}

<ContentPage>
 <sliders:SfSlider Minimum="2010-01-01" Maximum="2020-01-01" Value="2014-01-01" ShowLabels="True">
 </sliders:SfSlider>
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
            SfSlider slider = new SfSlider();
			slider.Minimum = new DateTime(2010, 01, 01);
			slider.Maximum = new DateTime(2020, 01, 01);
			slider.Value = new DateTime(2014, 01, 01);
			slider.ShowLabels = true;
			this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider date labels](images/getting-started/date-time-labels.png)

## Enable ticks

The `ShowTicks` property enables ticks in the slider, while the `MinorTicksPerInterval` property enables minor ticks between the major ticks.

{% tabs %}

{% highlight xaml %}

<ContentPage>
  <sliders:SfSlider Minimum="2010-01-01" Maximum="2020-01-01" Value="2014-01-01" ShowLabels="True" ShowTicks="True" Interval="2" MinorTicksPerInterval="1">
  </sliders:SfSlider>
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
          	SfSlider slider = new SfSlider();
			slider.Minimum = new DateTime(2010, 01, 01);
			slider.Maximum = new DateTime(2020, 01, 01);
			slider.Value = new DateTime(2014, 01, 01);
			slider.ShowLabels = true;
			slider.ShowTicks = true;
			slider.Interval = 2;
			slider.MinorTicksPerInterval = 1;
			this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider ticks](images/getting-started/ticks.png)

## Orientation

The `Orientation` property allows you to show the slider in both horizontal and vertical directions. The default value of the `Orientation` property is `Horizontal`.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="0" Maximum="100" Value="40" Orientation="Vertical" ShowLabels="True" ShowTicks="True" Interval="20" MinorTicksPerInterval="1">
    </sliders:SfSlider>
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
            SfSlider slider = new SfSlider();
            slider.Minimum = 0;
            slider.Maximum = 100;
            slider.Value = 40;
            slider.Orientation = SliderOrientation.Vertical;
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.Interval = 20;
            slider.MinorTicksPerInterval = 1;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider orientation](images/getting-started/orientation.png)

## Inverse the slider

You can invert the slider using the `IsInversed` property. The default value of the `IsInversed` property is `False`.

{% tabs %}

{% highlight xaml %}

<ContentPage>
     <sliders:SfSlider Minimum="0" Maximum="100" Value="40" IsInversed="True" ShowLabels="True" ShowTicks="True" Interval="20" MinorTicksPerInterval="1">
     </sliders:SfSlider>
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
            SfSlider slider = new SfSlider();
            slider.Minimum = 0;
            slider.Maximum = 100;
            slider.Value = 40;
            slider.IsInversed = true;
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.Interval = 20;
            slider.MinorTicksPerInterval = 1;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Inverse slider](images/getting-started/slider-inverse.png)

## Add prefix/suffix to labels

You can add prefix or suffix to the labels using the `NumberFormat` or `DateFormat` properties.

N> The format type (numeric or date) of the slider is determined based on the values specified in `Minimum`, `Maximum` properties.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="20" Maximum="100" Value="60" NumberFormat="$##" ShowLabels="True" ShowTicks="True" Interval="20" MinorTicksPerInterval="1">
    </sliders:SfSlider>
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
            SfSlider slider = new SfSlider();
            slider.Minimum = 20;
            slider.Maximum = 100;
            slider.Value = 60;
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.Interval = 20;
            slider.NumberFormat = "$##";
            slider.MinorTicksPerInterval = 1;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Inverse slider](images/getting-started/label-format.png)
