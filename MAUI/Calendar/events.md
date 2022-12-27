---
layout: post
title: Events in .NET MAUI Calendar control | Syncfusion
description: Learn here all about the Events support in Syncfusion .NET MAUI Calendar (SfCalendar) control and more details.
platform: maui
control: SfCalendar
documentation: ug
---

# Events in .NET MAUI Calendar (SfCalendar)

The Calendar has the events `ViewChanged`, `SelectionChanged`, `Tapped`, `DoubleTapped`, and `LongPressed` for notifying after user interactions in [.NET MAUI Calendar].

## ViewChanged

The [ViewChanged] event is used to notify when the current view of the calendar is changed while the view is swiped to the previous or next view, as well as when the calendar view is switched to another calendar view.

* `Sender`: This contains the `SfCalendar` object.

* `ViewChanged`: The Calendar current view visible dates are available in the [CalendarViewChangedEventArgs] when the calendar visible dates or view is changed.

    * [NewVisibleDates] : Returns the new visible date range of the view.
    * [OldVisibleDates] : Returns the old visible date range of the view.
    * [NewView] : Returns the new calendar view. 
    * [OldView] : Returns the old calendar view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      ViewChanged="OnCalendarViewChanged">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Calendar.ViewChanged += OnCalendarViewChanged;
private void OnCalendarViewChanged(object sender, CalendarViewChangedEventArgs e)
{
    var oldVisibleDates = e.OldVisibleDates;
    var newVisibleDates = e.NewVisibleDates;
    var oldCalendarView = e.OldView;
    var newCalendarView = e.NewView;
}

{% endhighlight %}
{% endtabs %}

N>
Whenever a calendar view is changed, the `SelectableDayPredicate` function must be called to decide whether the cell is selectable or not in the `SfCalendar.`

## SelectionChanged

The [SelectionChanged] event is used to notify when the cell selection is changed onto the view in the [SfCalendar].

* `Sender`: This contains the `SfCalendar` object.

* `SelectionChanged`: The selection is changed when the selection-changed action is performed on the element available in the [CalendarSelectionChangedEventArgs].

    * [NewValue] : Returns the new selected date.
    * [OldValue] : Returns the old selected date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      SelectionChanged="OnCalendarSelectionChanged">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Calendar.SelectionChanged += this.OnCalendarSelectionChanged;

private void OnCalendarSelectionChanged(object sender,  private void OnCalendarSelectionChanged(object sender, CalendarSelectionChangedEventArgs e)
    {
        var oldDateTime = e.OldValue;
        var newDateTime = e.NewValue;
    }

{% endhighlight %}
{% endtabs %}

N>
The `Tapped` event is triggered first, followed by 'selection-changed' event will be performed.

## Tapped

A [Tapped] event is triggered, each time a calendar view is tapped. The following are the list of arguments:

* `Sender`: This contains the `SfCalendar` object.

* `Tapped`: The tapped action performed on a Calendar element can be found in the [CalendarTappedEventArgs], where you can see details about the tapped dates and elements.

    * [Date] : Returns the selected date.
    * [Element] : Returns the `Calendar` element tapped.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      Tapped="OnCalendarTapped">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Calendar.Tapped += OnCalendarTapped;
private void OnCalendarTapped(object sender, CalendarTappedEventArgs e)
{
    var selectedDate = e.Date;
    var calendarElement = e.Element;
}

{% endhighlight %}
{% endtabs %}

## DoubleTapped

Whenever the [SfCalendar] elements are double-tapped onto the view, the [DoubleTapped] event occurs. The following are the list of arguments:

* `Sender`: This contains the `SfCalendar` object.

* `DoubleTapped`: This double-tapped action performed on a Calendar element can be found in the [CalendarDoubleTappedEventArgs], where you can see the details about the double-tapped dates and elements.

    * [Date] : Returns the double-tapped date.
    * [Element] : Returns the double-tapped `Calendar` element.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      DoubleTapped="OnCalendarDoubleTapped">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Calendar.DoubleTapped += this.OnCalendarDoubleTapped;

private void OnCalendarDoubleTapped(object sender, CalendarDoubleTappedEventArgs e)
{
    var selectedDate = e.Date;
    var calendarElement = e.Element;
}

{% endhighlight %}
{% endtabs %}

## LongPressed

Whenever the [SfCalendar] elements are long-pressed onto the view, the [LongPressed] event is triggered. The following are the list of arguments:

* `Sender`: This contains the `SfCalendar` object.

* `LongPressed`: This long-pressed action performed on a Calendar element can be found in the [CalendarLongPressedEventArgs], where you can see details about the long-pressed dates and elements.

    * [Date] : Returns the long-pressed date.
    * [Element] : Returns the long-pressed `Calendar` element.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      LongPressed="OnCalendarLongPressed">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Calendar.LongPressed += this.OnCalendarLongPressed;

private void OnCalendarLongPressed(object sender, CalendarLongPressedEventArgs e)
{
    var selectedDate = e.Date;
    var calendarElement = e.Element;
}

{% endhighlight %}
{% endtabs %}

