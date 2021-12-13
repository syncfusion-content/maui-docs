---
layout: post
title: Tick in .NET MAUI Slider control | Syncfusion 
description: Learn here all about adding the Tick feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Tick in .NET MAUI Slider (SfSlider)

This section helps to learn about how to add major and minor ticks in the slider.

## Show major ticks

You can enable the major ticks on the track. It is a shape which is used to represent the major interval points of the track. The default value of `ShowTicks` property is `False`.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the slider will render the major ticks at 0.0, 2.0, 4.0 and so on.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" ShowTicks="True">
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
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider ticks](images/ticks/show-ticks.png)

## Show minor ticks

It is used to represent the number of smaller ticks between two major ticks. For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the slider will render the major ticks at 0.0, 2.0, 4.0 and so on. If `MinorTicksPerInterval` is 1, then smaller ticks will be rendered on 1.0 and 3.0 and so on. The default value of `MinorTicksPerInterval` property is Zero.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" MinorTicksPerInterval = "1" ShowTicks="True">
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
			slider.MinorTicksPerInterval = 1;
			slider.ShowLabels = true;
			slider.ShowTicks = true;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider minor ticks](images/ticks/show-minor-ticks.png)

## Major ticks color

You can change the active and inactive major ticks color of the slider using the `ActiveColor` and `InactiveColor` properties of the `MajorTickStyle` class.

The active side of the slider is between the `Minimum` value and the thumb.

The inactive side of the slider is between the thumb and the `Maximum` value.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" ShowTicks="True">
       <sliders:SfSlider.MajorTickStyle>
          <sliders:SliderTickStyle ActiveColor="#EE3F3F" InactiveColor="#F7B1AE"/>
       </sliders:SfSlider.MajorTickStyle>
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
            slider.MajorTickStyle.ActiveColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
            slider.MajorTickStyle.InactiveColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider major ticks color](images/ticks/major-ticks-color.png)

## Minor ticks color

You can change the active and inactive minor ticks color of the slider using the `ActiveColor` and `InactiveColor` properties of the `MinorTickStyle` class.

The active side of the slider is between the `Minimum` value and the thumb.

The inactive side of the slider is between the thumb and the `Maximum` value.

{% tabs %}

{% highlight xaml %}

<ContentPage>
    <sliders:SfSlider WidthRequest="400" Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" ShowTicks="True" MinorTicksPerInterval="1">
        <sliders:SfSlider.MinorTickStyle>
           <sliders:SliderTickStyle ActiveColor="#EE3F3F" InactiveColor="#F7B1AE"/>
        </sliders:SfSlider.MinorTickStyle>
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
            slider.MinorTicksPerInterval = 1;
            slider.MinorTickStyle.ActiveColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
            slider.MinorTickStyle.InactiveColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider minor ticks color](images/ticks/minor-ticks-color.png)

## Ticks size

You can change the major and minor ticks size of the slider using the `ActiveSize` and `InactiveSize` property of the `MajorTickStyle` and `MinorTickStyle` classes. The default value is is `Size(2.0, 8.0)`.

{% tabs %}

{% highlight xaml %}

<ContentPage>
     <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" ShowTicks="True" MinorTicksPerInterval="1">
        <sliders:SfSlider.MinorTickStyle>
          <sliders:SliderTickStyle ActiveSize="2,10" InactiveSize="2, 10"/>
        </sliders:SfSlider.MinorTickStyle>
        <sliders:SfSlider.MajorTickStyle>
          <sliders:SliderTickStyle ActiveSize="2,10" InactiveSize="2, 10"/>
        </sliders:SfSlider.MajorTickStyle>
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
            slider.MinorTicksPerInterval = 1;
            slider.MinorTickStyle.ActiveSize = new Size(2, 10);
            slider.MinorTickStyle.InactiveSize = new Size(2, 10);
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider tick size](images/ticks/tick-size.png)

## Ticks offset

You can adjust the space between track and ticks of the slider using the `Offset` property of the `MajorTickStyle` and `MinorTickStyle`. The default value of the `Offset` property is `3.0`.

{% tabs %}

{% highlight xaml %}

<ContentPage>
      <sliders:SfSlider Minimum="0" Maximum="10" Interval="2" Value="6" ShowLabels="True" ShowTicks="True" MinorTicksPerInterval="1">
            <sliders:SfSlider.MinorTickStyle>
                <sliders:SliderTickStyle Offset="5"/>
            </sliders:SfSlider.MinorTickStyle>
            <sliders:SfSlider.MajorTickStyle>
                <sliders:SliderTickStyle Offset="5"/>
            </sliders:SfSlider.MajorTickStyle>
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
            slider.MinorTicksPerInterval = 1;
            slider.MinorTickStyle.Offset = 5;
            slider.MajorTickStyle.Offset = 5;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider tick offset](images/ticks/tick-offset.png)
