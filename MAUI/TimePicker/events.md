---
layout: post
title: Events in .NET MAUI Time Picker Control | Syncfusion
description: Learn about events in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Events in .NET MAUI Time Picker (SfTimePicker)

## Selection changed event

The [SelectionChanged] event is used to notify when the time selection is changed onto the view in the [SfTimePicker].

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In SfTimePicker picker, the [TimePickerSelectionChangedEventArgs] is used for this event which holds the data of NewValue and OldValue.

    * [NewValue] : Returns the new selected time.
    * [OldValue] : Returns the old selected time.


{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     SelectionChanged="OnTimePickerSelectionChanged">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.SelectionChanged += this.OnTimePickerSelectionChanged;

private void OnTimePickerSelectionChanged(object sender, TimePickerSelectionChangedEventArgs e)
{
    var oldTime = e.OldValue;
    var newTime = e.NewValue;
}

{% endhighlight %}

{% endtabs %}

## Events in dialog mode

In `SfTimePicker`, three events are used while the time picker is in Dialog mode.

 * [`Opened`]
 * [`Closing`]
 * [`Closed`]

### Opened event

The [Opened] event occurs when the picker popup is opened in the [SfTimePicker].

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In SfTimePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     Opened="OnTimePickerPopUpOpened">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Opened += this.OnTimePickerPopUpOpened;

private void OnTimePickerPopUpOpened(object sender, EventArgs e)
{
    // If you need to open the picker, set IsOpen property to true.
    this.Picker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

### Closing event

The [Closing] event occurs when the picker popup is closing in the [SfTimePicker].

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In SfTimePicker picker, [CancelEventArgs] is used to describe a cancel event which holds the bool value.

    * [Cancel] : Indicating whether we should cancel the operation or not.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     Closing="OnTimePickerPopUpClosing">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Closing += this.OnTimePickerPopUpClosing;

private void OnTimePickerPopUpClosing(object sender, CancelEventArgs e)
{
    //To restrict the time picker get close, set e.Cancel to true.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

### Closed event

The [Closed] event occurs when the picker popup is closed in the [SfTimePicker].

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In SfTimePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     Closed="OnTimePickerPopUpClosed">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Closed += this.OnTimePickerPopUpClosed;

private void OnTimePickerPopUpClosed(object sender, EventArgs e)
{
    // If you need to close the picker, set IsOpen property to false.
    this.Picker.IsOpen = false;
}

{% endhighlight %}

{% endtabs %}

## Events in footer view

In `SfTimePicker` footer view provides two events. These events are not applicable while the footer view is not visible.

 * [`OkButtonClicked`]
 * [`CancelButtonClicked`]

### OkButtonClicked event

 The [OkButtonClicked] event occurs when the ok button is clicked in the [SfTimePicker] footer view. This event is not applicable when the footer view is not visible and the ok button is not visible.

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In SfTimePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     OkButtonClicked="OnTimePickerOkButtonClicked">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.OkButtonClicked += this.OnTimePickerOkButtonClicked;

private void OnTimePickerOkButtonClicked(object sender, EventArgs e)
{
    // This event is used to update the selected item in the time picker.
}

{% endhighlight %}

{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked] event occurs when the cancel button is clicked in the [SfTimePicker] footer view. This event is not applicable when the footer view is not visible.

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In SfTimePicker picker, [EventArgs] is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     CancelButtonClicked="OnTimePickerCancelButtonClicked">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.CancelButtonClicked += this.OnTimePickerCancelButtonClicked;

private void OnTimePickerCancelButtonClicked(object sender, EventArgs e)
{
    // This event is used to cancel the selected item in the time picker.
}

{% endhighlight %}

{% endtabs %}