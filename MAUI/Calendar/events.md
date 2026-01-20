---
layout: post
title: Events in .NET MAUI Calendar control | Syncfusion®
description: Learn here all about the Events support in Syncfusion<sup>&reg;</sup> .NET MAUI Calendar (SfCalendar) control and more details.
platform: maui
control: SfCalendar
documentation: ug
---

# Events in .NET MAUI Calendar (SfCalendar)

The Calendar has the events `ViewChanged`, `SelectionChanged`, `Tapped`, `DoubleTapped`, and `LongPressed` for notifying after user interactions in [.NET MAUI Calendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html).

## ViewChanged

The [ViewChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChanged) event is used to notify when the current view of the calendar is changed while the view is swiped to the previous or next view, as well as when the calendar view is switched to another calendar view.

* `Sender`: This contains the `SfCalendar` object.

* `EventArgs`: In Calendar, [CalendarViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html) is used for this event which holds the data of previous and new calendar views.

    * [NewVisibleDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_NewVisibleDates) : Returns the new visible date range of the view.
    * [OldVisibleDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_OldVisibleDates) : Returns the old visible date range of the view.
    * [NewView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_NewView) : Returns the new calendar view. 
    * [OldView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarViewChangedEventArgs_OldView) : Returns the old calendar view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                      ViewChanged="OnCalendarViewChanged">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.calendar.ViewChanged += OnCalendarViewChanged;
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

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChanged) event is used to notify when the cell selection is changed onto the view in the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

* `Sender`: This contains the `SfCalendar` object.

* `EventArgs`: In Calendar, [CalendarSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html) is used for this event which holds the data of NewValue and OldValue.

    * [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarSelectionChangedEventArgs_NewValue) : Returns the new selected date.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html#Syncfusion_Maui_Calendar_CalendarSelectionChangedEventArgs_OldValue) : Returns the old selected date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                      SelectionChanged="OnCalendarSelectionChanged">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.calendar.SelectionChanged += this.OnCalendarSelectionChanged;

private void OnCalendarSelectionChanged(object sender, CalendarSelectionChangedEventArgs e)
{
    var oldDateTime = e.OldValue;
    var newDateTime = e.NewValue;
}

{% endhighlight %}
{% endtabs %}

N>
The `Tapped` event is triggered first, followed by 'selection-changed' event will be performed.

## Tapped

A [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Tapped) event is triggered, each time a calendar view is tapped. The following are the list of arguments:

* `Sender`: This contains the `SfCalendar` object.

* `EventArgs`: In Calendar, [CalendarTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html) is used for this event which holds the data of date and element.

    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarTappedEventArgs_Date) : Returns the selected date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarTappedEventArgs_Element) : Returns the `Calendar` element tapped.
    * [WeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarTappedEventArgs_WeekNumber) : Returns the tapped `WeekNumber`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                      Tapped="OnCalendarTapped">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.calendar.Tapped += OnCalendarTapped;
private void OnCalendarTapped(object sender, CalendarTappedEventArgs e)
{
    var selectedDate = e.Date;
    var calendarElement = e.Element;
    var weekNumber = e.WeekNumber;
}

{% endhighlight %}
{% endtabs %}

## DoubleTapped

Whenever the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) elements are double-tapped onto the view, the [DoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DoubleTapped) event occurs. The following are the list of arguments:

* `Sender`: This contains the `SfCalendar` object.

* `EventArgs`: In Calendar, [CalendarDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html) is used for this event which holds the data of date and element.

    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarDoubleTappedEventArgs_Date) : Returns the double-tapped date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarDoubleTappedEventArgs_Element) : Returns the double-tapped `Calendar` element.
    * [WeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html#Syncfusion_Maui_Calendar_CalendarDoubleTappedEventArgs_WeekNumber) : Returns the double-tapped `WeekNumber`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                      DoubleTapped="OnCalendarDoubleTapped">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.calendar.DoubleTapped += this.OnCalendarDoubleTapped;

private void OnCalendarDoubleTapped(object sender, CalendarDoubleTappedEventArgs e)
{
    var selectedDate = e.Date;
    var calendarElement = e.Element;
    var weekNumber = e.WeekNumber;
}

{% endhighlight %}
{% endtabs %}

## LongPressed

Whenever the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) elements are long-pressed onto the view, the [LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_LongPressed) event is triggered. The following are the list of arguments:

* `Sender`: This contains the `SfCalendar` object.

* `EventArgs`: In Calendar, [CalendarLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html) is used for this event which holds the data of date and element.

    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html#Syncfusion_Maui_Calendar_CalendarLongPressedEventArgs_Date) : Returns the long-pressed date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html#Syncfusion_Maui_Calendar_CalendarLongPressedEventArgs_Element) : Returns the long-pressed `Calendar` element.
    * [WeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html#Syncfusion_Maui_Calendar_CalendarLongPressedEventArgs_WeekNumber) : Returns the long-pressed `WeekNumber`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                      LongPressed="OnCalendarLongPressed">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.calendar.LongPressed += this.OnCalendarLongPressed;

private void OnCalendarLongPressed(object sender, CalendarLongPressedEventArgs e)
{
    var selectedDate = e.Date;
    var calendarElement = e.Element;
    var weekNumber = e.WeekNumber;
}

{% endhighlight %}
{% endtabs %}

## Commands

### ViewChangedCommand

The SfCalendar includes a built-in event called `ViewChanged`, which is triggered whenever the calendar view is navigated to either the previous or next view. This event can be invoked through the [ViewChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChangedCommand), and it also triggers when switching between different calendar views. The `CalendarViewChangedEventArgs` is provided as a parameter to this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                      ViewChangedCommand="ViewChangedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class CalendarViewModel
{
    public ICommand ViewChangedCommand { get; set; }
    public CalendarViewModel()
    {
        ViewChangedCommand = new Command<CalendarViewChangedEventArgs>(ViewChanged);
    }
    private void ViewChanged(CalendarViewChangedEventArgs args)
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### SelectionChangedCommand

The SfCalendar includes a built-in event called `SelectionChanged` that is triggered whenever the selection in the calendar changes. This event can be invoked through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChangedCommand), which passes the `CalendarSelectionChangedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                     SelectionChangedCommand="SelectionChangedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class CalendarViewModel
{
    public ICommand SelectionChangedCommand { get; set; }
    public CalendarViewModel()
    {
        SelectionChangedCommand = new Command<CalendarSelectionChangedEventArgs>(SelectionChanged);
    }
    private void SelectionChanged(CalendarSelectionChangedEventArgs args)
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### TappedCommand

The SfCalendar includes a built-in event called `Tapped` that is triggered whenever the calendar view is tapped. This event can be invoked through the [TappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_TappedCommand) which passes the `CalendarTappedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                     TappedCommand="TappedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class CalendarViewModel
{
    public ICommand TappedCommand { get; set; }
    public CalendarViewModel()
    {
        TappedCommand = new Command<CalendarTappedEventArgs>(Tapped);
    }
    private void Tapped(CalendarTappedEventArgs args)
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### DoubleTappedCommand

The SfCalendar includes a built-in event called `DoubleTapped` that is triggered whenever the calendar view is double-tapped. This event can be invoked through the [DoubleTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DoubleTappedCommand), which passes the `CalendarDoubleTappedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3,6,8" %}

<calendar:SfCalendar  x:Name="calendar" 
                     DoubleTappedCommand="DoubleTappedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class CalendarViewModel
{
    public ICommand DoubleTappedCommand { get; set; }
    public CalendarViewModel()
    {
        DoubleTappedCommand = new Command<CalendarDoubleTappedEventArgs>(DoubleTapped);
    }
    private void DoubleTapped(CalendarDoubleTappedEventArgs args)
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### LongPressedCommand

The SfCalendar includes a built-in event called `LongPressed`, which is triggered when the calendar view is long pressed. This event can be invoked through the [LongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_LongPressedCommand), with the `CalendarLongPressedEventArgs` passed as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                     LongPressedCommand="LongPressedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class CalendarViewModel
{
    public ICommand LongPressedCommand { get; set; }
    public CalendarViewModel()
    {
        LongPressedCommand = new Command<CalendarLongPressedEventArgs>(LongPressed);
    }
    private void LongPressed(CalendarLongPressedEventArgs args)
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### AcceptCommand

The SfCalendar includes a built-in event called `ActionButtonClicked`, which is triggered when the confirm button is tapped on the calendar. This event can be invoked through the [AcceptCommand]().

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                     AcceptCommand="AcceptCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class CalendarViewModel
{
    public ICommand AcceptCommand { get; set; }
    public CalendarViewModel()
    {
        AcceptCommand = new Command(ActionButtonClicked);
    }
    private void ActionButtonClicked()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### DeclineCommand

The SfCalendar includes a built-in event called `ActionButtonCanceled`, which is triggered when the cancel button is tapped on the calendar. This event can be invoked through the [DeclineCommand]().

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="calendar" 
                     DeclineCommand="DeclineCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class CalendarViewModel
{
    public ICommand DeclineCommand { get; set; }
    public CalendarViewModel()
    {
        DeclineCommand = new Command(ActionButtonCanceled);
    }
    private void ActionButtonCanceled()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}
