---
layout: post
title: Track in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding the track feature of .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Track in .NET MAUI Slider (SfSlider)

This section helps to learn about how to customize the track in the slider.

## Track color

You can change the active and inactive track color of the slider using the `ActiveColor` and `InactiveColor` properties of the `TrackStyle` class.

The active side of the slider is between the `Minimum` value and the thumb.

The inactive side of the slider is between the thumb and the `Maximum` value.

{% tabs %}

{% highlight xaml %}

<ContentPage>
   <sliders:SfSlider>
      <sliders:SfSlider.TrackStyle>
         <sliders:SliderTrackStyle ActiveColor="#EE3F3F" InactiveColor="#F7B1AE" />
      </sliders:SfSlider.TrackStyle>
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
			slider.TrackStyle.ActiveColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
			slider.TrackStyle.InactiveColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
			this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider track color](images/track/track-color.png)

## Track height

You can change the active and inactive track height of the slider using the `ActiveSize` and `InactiveSize` properties of the `TrackStyle` class. The default value of the `ActiveSize` and the `InactiveSize` properties are `8.0` and `6.0` respectively.


{% tabs %}

{% highlight xaml %}

<ContentPage>
   <sliders:SfSlider>
      <sliders:SfSlider.TrackStyle>
         <sliders:SliderTrackStyle ActiveColor="#EE3F3F" InactiveColor="#F7B1AE" />
      </sliders:SfSlider.TrackStyle>
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
			slider.TrackStyle.ActiveSize = 10;
			slider.TrackStyle.InactiveSize = 8;
			this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider track size](images/track/track-size.png)
