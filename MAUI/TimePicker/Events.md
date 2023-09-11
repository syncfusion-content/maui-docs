---
layout: post
title: TimePicker Events in .NET MAUI TimePicker control | Syncfusion
description: Learn here all about TimePicker Events support in Syncfusion .NET MAUI Date Picker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---

# Events in .NET MAUI TimePicker (SfTimePicker)

The TimePicker has the events `SelectionChanged` for notifying after user interactions in [.NET MAUI TimePicker]().

## SelectionChanged

The [SelectionChanged]() event is used to notify when the cell selection is changed onto the view in the [SfTimePicker]().

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In TimePicker, [TimePickerSelectionChangedEventArgs]() is used for this event which holds the data of NewValue and OldValue.

    * [NewValue]() : Returns the new selected date.
    * [OldValue]() : Returns the old selected date.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker  x:Name="picker" 
                      SelectionChanged="SfTimePicker_SelectionChanged">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker TimePicker = new SfTimePicker();
TimePicker.SelectionChanged += TimePicker_SelectionChanged;
this.Content = TimePicker;

private void TimePicker_SelectionChanged(object sender, TimePickerSelectionChangedEventArgs e)
{
    var oldDateTime = e.OldValue;
    var newDateTime = e.NewValue;
}

{% endhighlight %}
{% endtabs %}

# Events in .NET MAUI TimePicker in Dialog (SfTimePicker)

The TimePicker [Dialog]() mode has the events `Opened`, `Closing`, `Closed` for notifying after user interactions in [.NET MAUI TimePicker]().

## Opened event

The [Opened]() event occurs when the TimePicker is opened. 

## Closing event 

The [Closing]() event occurs when the TimePicker closes.

Drop-down close can be restricted by setting `e.cancel` to true.

## Closed event

The [Closed]() event was triggered, after the TimePicker was closed.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfTimePicker x:Name="timePicker" IsOpen="True" Mode="Dialog"
                                Opened="SfTimePicker_Opened"
                                Closing="SfTimePicker_Closing"
                                Closed="SfTimePicker_Closed">           
</picker:SfTimePicker>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

this.timePicker.Opened += SfTimePicker_Opened;
this.timePicker.Closing += SfTimePicker_Closing;
this.timePicker.Closed += SfTimePicker_Closed;

private void SfTimePicker_Opened(object sender, EventArgs e)
{
}

private void SfTimePicker_Closing(object sender, System.ComponentModel.CancelEventArgs e)
{
    //To restrict the TimePicker get close, set e.Cancel to true.
    e.Cancel = true;
}

private void SfTimePicker_Closed(object sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}