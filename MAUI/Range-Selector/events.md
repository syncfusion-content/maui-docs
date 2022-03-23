---
layout: post
title: Events in.NET MAUI Range Selector control | Syncfusion 
description: Learn here all about adding the events of Syncfusion .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Events in .NET MAUI Range Selector (SfRangeSelector)

This section explains about how to add the events for range selector.

## Handle callbacks

* [ValueChangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChangeStart) -  Called when the user selecting a new value for the selector by tap/mouse down in the thumb.
* [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChanging) - Called when the user is selecting a new value for the selector by dragging the thumb.
* [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChanged) - Called when the user completed selecting a new value.
* [ValueChangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChangeEnd) - Called when the user stopped interacting with selector by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
   <rangeselector:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                          Maximum="2020-01-01" 
                                          RangeStart="2012-01-01" 
                                          RangeEnd="2018-01-01" 
                                          ValueChangeStart="OnValueChangeStart" 
                                          ValueChanging="OnValueChanging" 
                                          ValueChanged="OnValueChanged" 
                                          ValueChangeEnd="OnValueChangeEnd">
      <chart:SfCartesianChart />
   </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

{
   SfRangeSelector rangeSelector = new SfRangeSelector();
   rangeSelector.ValueChangeStart += OnValueChanged;
   rangeSelector.ValueChanging += OnValueChanged;
   rangeSelector.ValueChanged += OnValueChanged;
   rangeSelector.ValueChangeEnd += OnValueChanged;
   SfCartesianChart chart = new SfCartesianChart();
   rangeSelector.Content = chart;
}

private void OnValueChangeStart(object sender, EventArgs e)
{
}

private void OnValueChanging(object sender, DateTimeRangeSelectorValueChangingEventArgs e)
{
}

private void OnValueChanged(object sender, DateTimeRangeSelectorValueChangedEventArgs e)
{
}

private void OnValueChangeEnd(object sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}

## Customize label text

You can format or change the whole numeric or date label text using the [`LabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_LabelCreated) event. The [`SliderLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html) contains the following parameters,

* Text – Customize the text color using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.
* Style – Formats the text color, font size, font family, offset using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
      <rangeselector:SfRangeSelector Minimum="0" 
                               Maximum="10" 
                               Interval="2" 
                               RangeStart="2" 
                               RangeEnd="8"
                               LabelCreated="OnLabelCreated"   
                               ShowLabels="True" 
                               ShowTicks="True">
            <chart:SfCartesianChart />
      </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

{
   SfRangeSelector rangeSelector = new SfRangeSelector();
   rangeSelector.Minimum = 0;
   rangeSelector.Maximum = 10;
   rangeSelector.RangeStart = 2;
   rangeSelector.RangeEnd = 8;
   rangeSelector.Interval = 2;
   rangeSelector.ShowLabels = true;
   rangeSelector.ShowTicks = true;
   rangeSelector.LabelCreated += OnLabelCreated;
   SfCartesianChart chart = new SfCartesianChart();
   rangeSelector.Content = chart;
}
private void OnLabelCreated(object sender, SliderLabelCreatedEventArgs e)
{
	e.Text = "$" + e.Text;
}

{% endhighlight %}

{% endtabs %}

![RangeSelector custom label](images/labels-and-dividers/custom-label.png)

## Tooltip text format

By default it is formatted based on [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_NumberFormat)  property and [`DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_DateFormat) property based on whether it is date type [`SfDateTimeRangeSelector`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html) or numeric [`SfRangeSelector`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSelector.html).

You can format or change the whole tooltip label text using the [`ToolTipLabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipLabelCreated) event. The [`SliderLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html) contains the following parameters,

* Text – Change the format of the tooltip text using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Text) property.
* Style – Change the appearance of the tooltip text like color, stroke color, and padding using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) property.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
   <rangeselector:SfRangeSelector>
      <rangeselector:SfRangeSelector.Tooltip>
         <rangeselector:SliderTooltip TooltipLabelCreated="OnTooltipLabelCreated" />
      </rangeselector:SfRangeSelector.Tooltip>
      <chart:SfCartesianChart />
   </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

{
    SfRangeSelector rangeSelector = new SfRangeSelector();
    rangeSelector.Tooltip.TooltipLabelCreated += OnTooltipLabelCreated;
    SfCartesianChart chart = new SfCartesianChart();
    rangeSelector.Content = chart;
 }
 private void OnTooltipLabelCreated(object sender, SliderTooltipLabelCreatedEventArgs e)
 {
     e.Text = "$" + e.Text;
 }

{% endhighlight %}

{% endtabs %}

![RangeSelector custom tooltip](images/tooltip/custom-tooltip.png)
