---
layout: post
title: Events in .NET MAUI Calendar control | Syncfusion
description: Learn here all about the Events support in Syncfusion .NET MAUI Calendar (SfCalendar) control and more details.
platform: maui
control: SfCalendar
documentation: ug
---

# Events in .NET MAUI Calendar (SfCalendar)

The Calendar has the events `ViewChanged`, `SelectionChanged`, `Tapped`, `DoubleTapped` and `LongPressed` for notifying after user interactions in [.NET MAUI Calendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html). 

## ViewChanged

The [ViewChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChanged) event is used to notify when the current view of calendar is changed while the view is swiped to previous or next view, and when the calendar view is switched to another calendar view.

* `Sender`: This contains the `SfCalendar` object.

* `ViewChanged`: The Calendar current view visible dates are available in the [CalendarViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html) when the calendar visible dates or view is changed.

    * [NewVisibleDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_NewVisibleDates): Returns the new visible date range of the view.
    * [OldVisibleDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_OldVisibleDates) : Returns the old visible date range of the view.
    * [NewView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_CalendarViewChangedEventArgs_NewView): Returns the new calendar view. 
    * [OldView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_OldView) : Returns the old calendar view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

{% include_relative code-snippet/view-changed-event.xaml %}

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

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChanged) event is used to notify when the cell selection is changed onto the view in the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html).

* `Sender`: This contains the `SfCalendar` object.

* `SelectionChanged`: The selection is changed when the selection-changed action is performed on the element available in the [CalendarSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html).

    * [NewValue ](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarSelectionChangedEventArgs_NewValue): Returns the new selected date.
    * [OldValue     ](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarSelectionChangedEventArgs_OldValue) : Returns the old selected date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

{% include_relative code-snippet/selection-changed-event.xaml %}

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

A [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Tapped) event is triggered, each time a calendar view is tapped.
Below is a list of the arguments:

* `Sender`: This contains the `SfCalendar` object.

* `Tapped`: The tapped action performed on an Calendar element can be found in the [CalendarTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html), you can see details about the tapped dates and elements.

    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarTappedEventArgs_Date) : Returns the selected date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarTappedEventArgs_Element) : Returns the `Calendar` element tapped.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

{% include_relative code-snippet/tapped-event.xaml %}

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

Whenever the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) elements are double-tapped onto the view, the [DoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DoubleTapped) event occurs. Below is a list of the arguments:

* `Sender`: This contains the `SfCalendar` object.

* `DoubleTapped`: This double tapped action performed on a Calendar element can be found in the [CalendarDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html), and you can see the details about the double-tapped dates and elements.

    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarDoubleTappedEventArgs_Date) : Returns the double-tapped date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarDoubleTappedEventArgs_Element) : Returns the double-tapped `Calendar` element.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

{% include_relative code-snippet/double-tapped-event.xaml %}

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

Whenever the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) elements are long-pressed onto the view, the [LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_LongPressed) event is triggered. Below is a list of the arguments:

* `Sender`: This contains the `SfCalendar` object.

* `LongPressed`: This long-pressed action performed on a Calendar element can be found in the [CalendarLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html), and you can see details about the long-pressed dates and elements.

    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html#Syncfusion_Maui_Calendar_CalendarLongPressedEventArgs_Date) : Returns the long-pressed date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html#Syncfusion_Maui_Calendar_CalendarLongPressedEventArgs_Element) : Returns the long-pressed `Calendar` element.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

{% include_relative code-snippet/long-pressed-event.xaml %}

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

