---
layout: post
title: Date Picker events in .NET MAUI Date Picker control | Syncfusion
description: Learn about date picker events in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Events in .NET MAUI Date Picker (SfDatePicker)

## SelectionChanged

The [SelectionChanged] event is used to notify when the date selection is changed onto the view in the [SfDatePicker].

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In Date Picker, [DatePickerSelectionChangedEventArgs] is used for this event which holds the data of NewValue and OldValue.

    * [NewValue] : Returns the new selected date.
    * [OldValue] : Returns the old selected date.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     SelectionChanged="OnDatePickerSelectionChanged">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.SelectionChanged += this.OnDatePickerSelectionChanged;

private void OnDatePickerSelectionChanged(object sender, DatePickerSelectionChangedEventArgs e)
{
    var oldDate = e.OldValue;
    var newDate = e.NewValue;
}

{% endhighlight %}

{% endtabs %}

## Events in dialog mode (SfDatePicker)

In `SfDatePicker`, three events are used while the date picker is in Dialog mode.

 * [`Opened`]
 * [`Closing`]
 * [`Closed`]

### Opened event

The [Opened] event occurs when the picker popup is opened in the [SfDatePicker].

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In SfDatePicker picker, [EventArgs] is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     Opened="OnDatePickerPopUpOpened">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Opened += this.OnDatePickerPopUpOpened;

private void OnDatePickerPopUpOpened(object sender, EventArgs e)
{
    // If you need to open the picker, set IsOpen property to true.
    this.Picker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

### Closing event

The [Closing] event occurs when the picker popup is closing in the [SfDatePicker].

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In SfDatePicker picker, [CancelEventArgs] is used to describe the cancel event which holds the bool value.

    * [Cancel] : Indicating whether we should cancel the operation or not.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     Closing="OnDatePickerPopUpClosing">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Closing += this.OnDatePickerPopUpClosing;

private void OnDatePickerPopUpClosing(object sender, CancelEventArgs e)
{
    //To restrict the date picker get close, set e.Cancel to true.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

### Closed event

The [Closed] event occurs when the picker popup is closed in the [SfDatePicker].

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In SfDatePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     Closed="OnDatePickerPopUpClosed">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Closed += this.OnDatePickerPopUpClosed;

private void OnDatePickerPopUpClosed(object sender, EventArgs e)
{
    // If you need to close the picker, set IsOpen property to false.
    this.Picker.IsOpen = false;
}

{% endhighlight %}

{% endtabs %}

## Events in footer view

The `SfDatePicker` footer view provides two events. These events are not applicable while the footer view is not visible.

 * [`OkButtonClicked`]
 * [`CancelButtonClicked`]

### OkButtonClicked event

 The [OkButtonClicked] event occurs when the ok button is clicked in the [SfDatePicker] footer view. This event is not applicable when the footer view is not visible and the ok button is not visible.

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In SfDatePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     OkButtonClicked="OnDatePickerOkButtonClicked">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.OkButtonClicked += this.OnDatePickerOkButtonClicked;

private void OnDatePickerOkButtonClicked(object sender, EventArgs e)
{
    // This event is used to update the selected item in the Date picker.
}

{% endhighlight %}

{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked] event occurs when the cancel button is clicked in the [SfDatePicker] footer view. This event is not applicable when the footer view is not visible.

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In SfDatePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     CancelButtonClicked="OnDatePickerCancelButtonClicked">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.CancelButtonClicked += this.OnDatePickerCancelButtonClicked;

private void OnDatePickerCancelButtonClicked(object sender, EventArgs e)
{
    // This event is used to cancel the selected item in the Date picker.
}

{% endhighlight %}

{% endtabs %}