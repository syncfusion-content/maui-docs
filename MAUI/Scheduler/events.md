---
layout: post
title: Events in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Events support in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more details.
platform: maui
control: SfScheduler
documentation: ug
---

# Events in .NET MAUI Scheduler (SfScheduler)

The Scheduler supports the `Tapped,` `DoubleTapped,` `LongPressed,` `SelectionChanged,` and `ViewChanged` events to interact with .NET MAUI Scheduler 

## Tapped

A `Tapped` event occurs each time a scheduler view is tapped. 
Below is a list of the arguments:

* `Sender`: This contains the `SfScheduler` object.

* `Tapped`: The tapped action performed on an Scheduler element can be found in the `SchedulerTappedEventArgs`, you can see details about the tapped dates, appointments, and elements.

    * `Appointments`: Returns the selected appointments.
    * `Date` : Returns the selected date.
    * `Element` : Returns the `Scheduler` element tapped.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       Tapped="OnSchedulerTapped" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c#%}

this.Scheduler.Tapped += this.OnSchedulerTapped;

private void OnSchedulerTapped(object sender, SchedulerTappedEventArgs e)
{
    var appointments = e.Appointments;
    var selectedDate = e.Date;
    var schedulerElement = e.Element;
}

{% endhighlight %}
{% endtabs %}

## DoubleTapped

Whenever the `SfScheduler` elements are double-tapped onto the view, the `DoubleTapped` event occurs. Below is a list of the arguments:

* `Sender`: This contains the `SfScheduler` object.

* `DoubleTapped`: this double tapped action performed on an Scheduler element can be found in the `SchedulerDoubleTappedEventArgs`, you can see details about the double-tapped dates, appointments, and elements.

    * `Appointments`: Returns the double-tapped appointments.
    * `Date` : Returns the double-tapped date.
    * `Element` : Returns the double-tapped `Scheduler` element.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       DoubleTapped="OnSchedulerDoubleTapped" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c#%}

this.Scheduler.DoubleTapped += this.OnSchedulerDoubleTapped;

private void OnSchedulerDoubleTapped(object sender, SchedulerDoubleTappedEventArgs e)
{
    var appointments = e.Appointments;
    var selectedDate = e.Date;
    var schedulerElement = e.Element;
}

{% endhighlight %}
{% endtabs %}

## LongPressed

Whenever the `SfScheduler` elements are long-pressed onto the view, the `LongPressed` event occurs. Below is a list of the arguments:

* `Sender`: This contains the `SfScheduler` object.

* `LongPressed`: this long-pressed action performed on an Scheduler element can be found in the `SchedulerLongPressedEventArgs`, you can see details about the long-pressed dates, appointments, and elements.

    * `Appointments`: Returns the long-pressed appointments.
    * `Date` : Returns the long-pressed date.
    * `Element` : Returns the long-pressed `Scheduler` element.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       LongPressed="OnSchedulerLongPressed" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c#%}

this.Scheduler.LongPressed += this.OnSchedulerLongPressed;

private void OnSchedulerLongPressed(object sender, SchedulerLongPressedEventArgs e)
{
    var appointments = e.Appointments;
    var selectedDate = e.Date;
    var schedulerElement = e.Element;
}

{% endhighlight %}
{% endtabs %}

## SelectionChanged

The `SelectionChanged` event is used to notify when the cell selection is changed onto the view in the `SfScheduler.`

* `Sender`: This contains the `SfScheduler` object.

* `SelectionChanged`: The selection-changed date when the selection changed action performed on element available in the `SchedulerSelectionChangedEventArgs.`

    * `NewValue`: Returns the new selected date.
    * `OldValue` : Returns the old selected date.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       SelectionChanged="OnSchedulerSelectionChanged" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c#%}

this.Scheduler.SelectionChanged += this.OnSchedulerSelectionChanged;

private void OnSchedulerSelectionChanged(object sender, SchedulerSelectionChangedEventArgs e)
{
    var oldDateTime = e.OldValue;
    var newdateTime = e.NewValue;
}

{% endhighlight %}
{% endtabs %}

## ViewChanged

The `ViewChanged` event is used to notify when the current view of scheduler changed, that is view swiped to previous or next view, scheduler view switched to another scheduler view.

* `Sender`: This contains the `SfScheduler` object.

* `ViewChanged`:  The scheduler current view visible dates available in the `SchedulerViewChangedEventArgs` when scheduler visible dates or view changed.

    * `NewVisibleDates`: Returns the new visible date range of the view.
    * `OldVisibleDates` : Returns the old visible date range of the view.
    * `NewView`: Returns the new scheduler view. 
    * `OldView` : Returns the old scheduler view.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       ViewChanged="OnSchedulerViewChanged" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c#%}

this.Scheduler.ViewChanged += this.OnSchedulerViewChanged;

private void OnSchedulerViewChanged(object sender, SchedulerViewChangedEventArgs e)
{
    var oldVisibleDates = e.OldVisibleDates;
    var newVisibleDates = e.NewVisibleDates;
    var oldSchedulerView = e.OldView;
    var newSchedulerView = e.NewView;
}

{% endhighlight %}
{% endtabs %}