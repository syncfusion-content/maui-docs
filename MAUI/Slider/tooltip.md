---
layout: post
title: Tooltip in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Tooltip in .NET MAUI Slider (SfSlider)

This section helps to learn about how to add tooltip in the slider.

## Enable tooltip

You can enable tooltip for the thumb by setting the `ToolTipShape` property to `SliderToolTipShape.Rectangular`. It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the `ToolTipShape` property is `SliderToolTipShape.None`.

{% tabs %}

{% highlight xaml %}

  <sliders:SfSlider ToolTipShape="Rectangular" />

{% endhighlight %}

{% highlight C# %}

   SfSlider slider = new SfSlider();
   slider.ToolTipShape = SliderToolTipShape.Rectangular;

{% endhighlight %}

{% endtabs %}

![Slider tooltip](images/tooltip/tooltip.png)

## Tooltip text format

By default it is formatted based on `NumberFormat` property and `DateFormat` property based on whether it is date type `SfSlider` or numeric `SfSlider`.

You can format or change the whole tooltip label text using the `ToolTipLabelCreated` event. The `SliderLabelCreatedEventArgs` contains the following parameters,

* Text – Change the format of the tooltip text using the `Text` property.
* Style – Change the appearance of the tooltip text like color, stroke color, and padding using the `Style` property.

{% tabs %}

{% highlight xaml %}

<ContentPage>
     <sliders:SfSlider Minimum="2" Maximum="10" Interval="2" ToolTipLabelCreated="OnTooltipLabelCreated" Value="6" ToolTipShape="Rectangular" ShowLabels="True">
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

        private void OnTooltipLabelCreated(object sender, SliderLabelCreatedEventArgs e)
		{
			e.Text = "$" + e.Text;
		}
    }
}

{% endhighlight %}

{% endtabs %}

![Slider custom tooltip](images/tooltip/custom-tooltip.png)

## Tooltip label style

You can change the appearance of the tooltip text like color, stroke color, padding around the text using the `ToolTipStyle` property.

{% tabs %}

{% highlight xaml %}

<ContentPage>
   <sliders:SfSlider Minimum="2" Maximum="10" Interval="2" Value="6" ToolTipShape="Rectangular" ShowLabels="True">
      <sliders:SfSlider.ToolTipStyle>
         <sliders:SliderToolTipStyle Color="#F7B1AE" StrokeColor="#EE3F3F" StrokeWidth="2" />
      </sliders:SfSlider.ToolTipStyle>
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
            slider.Minimum = 2;
            slider.Maximum = 10;
            slider.Value = 6;
            slider.Interval = 2;
            slider.ShowLabels = true;
            slider.ToolTipShape = SliderToolTipShape.Rectangular;
            slider.ToolTipStyle.Color = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
            slider.ToolTipStyle.StrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
            slider.ToolTipStyle.StrokeWidth = 2;
            this.Content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Slider tooltip style](images/tooltip/tooltip-style.png)
