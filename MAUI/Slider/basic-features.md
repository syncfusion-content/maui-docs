---
layout: post
title: Basic features in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding the Basic feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Basic features  in .NET MAUI Slider (SfSlider)

This section explains about how to add the numeric and date slider.

## Minimum

The minimum value that the user can select. The default value of `Minimum` property is 0.0 and it must be less than the `Maximum` value.

## Maximum

The maximum value that the user can select. The default value of `Maximum` property is 1.5 and it must be greater than the `Minimum` value.

## Value

It represents the value currently selected in the slider. The slider's thumb is drawn corresponding to this value.

For date values, the slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="2010-01-01" 
		      Maximum="2020-01-01" 
		      Value="2014-01-01" 
		      ShowLabels="True" 
		      ShowTicks="True" 
		      Interval="2" 
		      DateIntervalType="Years" 
		      DateFormat="yyyy">
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
	    slider.DateIntervalType = SliderDateIntervalType.Years;
	    slider.DateFormat = "yyyy";
	    this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider date label](images/basic-features/date-labels.png)

## Handle ValueChanging, ValueChanged, ValueChangeStart, and ValueChangeEnd callbacks

* ValueChangeStart -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* ValueChanging - Called when the user is selecting a new value for the slider by dragging the thumb.
* ValueChanged - Called when the user completed selecting a new value.
* ValueChangeEnd - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="2010-01-01" Maximum="2020-01-01" Value="2014-01-01" ValueChangeStart="OnValueChangeStart" ValueChanging="OnValueChanging" ValueChanged="OnValueChanged" ValueChangeEnd="OnValueChangeEnd" ShowLabels="True" ShowTicks="True" Interval="2" DateIntervalType="Years" DateFormat="yyyy">
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
        }

        private void OnValueChangeStart(object sender, SliderValueChangeStartEventArgs e)
	{
	}

	private void OnValueChanged(object sender, SliderValueChangedEventArgs e) 
	{
	}

	private void OnValueChanging(object sender, SliderValueChangingEventArgs e)
	{
	}

	private void OnValueChangeEnd(object sender, SliderValueChangeEndEventArgs e)
	{
	}
    }
}

{% endhighlight %}

{% endtabs %}
