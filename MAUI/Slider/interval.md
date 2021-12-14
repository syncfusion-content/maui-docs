---
layout: post
title: Interval in.NET MAUI Slider control | Syncfusion 
description: Learn here all about adding the Interval feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Interval in .NET MAUI Slider (SfSlider)

This section explains about how to add the interval for numeric and date slider.

## Numeric interval

Slider elements like labels, ticks and dividers are rendered based on the `Interval`, `Minimum` and `Maximum` properties. The default value is `Zero`.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the slider will render the labels, major ticks, and dividers at 0.0, 2.0, 4.0 and so on.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" ShowTicks="True" ShowDividers="True">
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
            slider.Maximum = 10;
            slider.Value = 6;
            slider.Interval = 2;
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.ShowDividers = true;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider numeric interval](images/interval/numeric-interval.png)

## Date interval

The type of date interval. It can be years to seconds. It is mandatory for date `SfSlider`. The default value of `DateIntervalType` property is `DateTime.Year`.

For date values, the slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values.

For example, if `Minimum` is `DateTime(2000, 01, 01)` and `Maximum` is `DateTime(2005, 01, 01)` and `Interval` is `1`, `DateIntervalType` is `SliderDateIntervalType.years`, `DateFormat` is `yyyy` then the slider will render the labels, major ticks, and dividers at 2000, 2001, 2002 and so on.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="2000-01-01" Maximum="2005-01-01" Interval="1" Value="2002-01-01" DateFormat="yyyy" DateIntervalType="Years" ShowLabels="True" ShowTicks="True" ShowDividers="True">
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
            slider.Minimum = new DateTime(2000, 01, 01);
            slider.Maximum = new DateTime(2005, 01, 01);
            slider.Value = new DateTime(2002, 01, 01); 
            slider.Interval = 1;
            slider.DateIntervalType = SliderDateIntervalType.Years;
            slider.DateFormat = "yyyy";
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.ShowDividers = true;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider date interval](images/interval/date-interval.png)

## Discrete selection for numeric values

You can move the thumb in discrete manner for numeric values using the `StepSize` property in the slider.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" StepSize="2" Value="6" ShowLabels="True" ShowTicks="True" ShowDividers="True">
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
            slider.Maximum = 10;
            slider.Value = 6;
            slider.Interval = 2;
            slider.StepSize = 2;
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.ShowDividers = true;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider numeric discrete mode](images/interval/step-size.gif)

## Discrete selection for date values

You can move the thumb in discrete manner for date values using the `StepDuration` property in the slider.

For example, if `Minimum` is DateTime(2015, 01, 01) and `Maximum` is DateTime(2020, 01, 01) and `StepDuration` is `1`,the slider will move the thumbs at DateTime(2015, 01, 01), DateTime(2016, 01, 01), DateTime(2017, 01, 01),and DateTime(2018, 01, 01).

{% tabs %}

{% highlight xaml %}

<ContentPage>
     <sliders:SfSlider Minimum="2000-01-01" Maximum="2005-01-01" Interval="1" StepDuration="1" Value="2002-01-01" DateFormat="yyyy" DateIntervalType="Years" ShowLabels="True" ShowTicks="True" ShowDividers="True">
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
            slider.Minimum = new DateTime();
            slider.Maximum = new DateTime(2005, 01, 01);
            slider.Value = new DateTime(2002, 01, 01); ;
            slider.Interval = 1;
            slider.DateIntervalType = SliderDateIntervalType.Years;
            slider.DateFormat = "yyyy";
            slider.StepDuration = new SliderStepDuration(years: 1);
            slider.ShowLabels = true;
            slider.ShowTicks = true;
            slider.ShowDividers = true;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider date discrete mode](images/interval/step-duration.gif)
