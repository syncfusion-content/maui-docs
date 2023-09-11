---
layout: post
title: DatePicker Events in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about DatePicker Events support in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---

# Events in .NET MAUI DatePicker (SfDatePicker)

The DatePicker has the events `SelectionChanged` for notifying after user interactions in [.NET MAUI DatePicker]().

## SelectionChanged

The [SelectionChanged]() event is used to notify when the cell selection is changed onto the view in the [SfDatePicker]().

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In DatePicker, [DatePickerSelectionChangedEventArgs]() is used for this event which holds the data of NewValue and OldValue.

    * [NewValue]() : Returns the new selected date.
    * [OldValue]() : Returns the old selected date.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker  x:Name="picker" 
                      SelectionChanged="SfDatePicker_SelectionChanged">
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.SelectionChanged += DatePicker_SelectionChanged;
this.Content = datePicker;

private void DatePicker_SelectionChanged(object sender, DatePickerSelectionChangedEventArgs e)
{
    var oldDateTime = e.OldValue;
    var newDateTime = e.NewValue;
}

{% endhighlight %}
{% endtabs %}

# Events in .NET MAUI DatePicker in Dialog (SfDatePicker)

The DatePicker [Dialog]() mode has the events `Opened`, `Closing`, `Closed` for notifying after user interactions in [.NET MAUI DatePicker]().

## Opened event

The [Opened]() event occurs when the DatePicker is opened. 

## Closing event 

The [Closing]() event occurs when the DatePicker closes.

Drop-down close can be restricted by setting `e.cancel` to true.

## Closed event

The [Closed]() event was triggered, after the DatePicker was closed.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfDatePicker x:Name="datePicker" IsOpen="True" Mode="Dialog"
                                Opened="SfDatePicker_Opened"
                                Closing="SfDatePicker_Closing"
                                Closed="SfDatePicker_Closed">           
</picker:SfDatePicker>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

this.datePicker.Opened += SfDatePicker_Opened;
this.datePicker.Closing += SfDatePicker_Closing;
this.datePicker.Closed += SfDatePicker_Closed;

private void SfDatePicker_Opened(object sender, EventArgs e)
{
}

private void SfDatePicker_Closing(object sender, System.ComponentModel.CancelEventArgs e)
{
    //To restrict the datepicker get close, set e.Cancel to true.
    e.Cancel = true;
}

private void SfDatePicker_Closed(object sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}