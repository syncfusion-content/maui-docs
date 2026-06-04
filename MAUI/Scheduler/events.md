---
layout: post
title: Events in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Events support in Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) control and more details.
platform: maui
control: SfScheduler
documentation: ug
---

# Events in .NET MAUI Scheduler (SfScheduler)

The Scheduler supports the `Tapped,` `DoubleTapped,` `LongPressed,` `SelectionChanged,` and `ViewChanged` events to interact with [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html). 

## Tapped

A [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped) event occurs, each time a scheduler view is tapped.
Below is a list of the arguments:

* `Sender`: This contains the `SfScheduler` object.

* `Tapped`: The tapped action performed on an Scheduler element can be found in the [SchedulerTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTappedEventArgs.html), you can see details about the tapped dates, appointments, and elements.

    * [Appointments](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Appointments): Returns the selected appointments.
    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Date) : Returns the selected date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Element) : Returns the `Scheduler` element tapped.
    * [WeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_WeekNumber) : Returns the tapped week number value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       Tapped="OnSchedulerTapped" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Scheduler.Tapped += this.OnSchedulerTapped;

private void OnSchedulerTapped(object sender, SchedulerTappedEventArgs e)
{
    var appointments = e.Appointments;
    var selectedDate = e.Date;
    var schedulerElement = e.Element;
    var weekNumber = e.WeekNumber;
}

{% endhighlight %}
{% endtabs %}

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)
* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## DoubleTapped

Whenever the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) elements are double-tapped onto the view, the [DoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_DoubleTapped) event occurs. Below is a list of the arguments:

* `Sender`: This contains the `SfScheduler` object.

* `DoubleTapped`: This double tapped action performed on a Scheduler element can be found in the [SchedulerDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDoubleTappedEventArgs.html), and you can see the details about the double-tapped dates, appointments, and elements.

    * [Appointments](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Appointments): Returns the double-tapped appointments.
    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Date) : Returns the double-tapped date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Element) : Returns the double-tapped `Scheduler` element.
    * [WeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_WeekNumber) : Returns the double-tapped week number value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       DoubleTapped="OnSchedulerDoubleTapped" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Scheduler.DoubleTapped += this.OnSchedulerDoubleTapped;

private void OnSchedulerDoubleTapped(object sender, SchedulerDoubleTappedEventArgs e)
{
    var appointments = e.Appointments;
    var selectedDate = e.Date;
    var schedulerElement = e.Element;
    var weekNumber = e.WeekNumber;
}

{% endhighlight %}
{% endtabs %}

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)
* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## LongPressed

Whenever the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) elements are long-pressed onto the view, the [LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_LongPressed) event occurs. Below is a list of the arguments:

* `Sender`: This contains the `SfScheduler` object.

* `LongPressed`: This long-pressed action performed on a Scheduler element can be found in the [SchedulerLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerLongPressedEventArgs.html), and you can see details about the long-pressed dates, appointments, and elements.

    * [Appointments](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Appointments): Returns the long-pressed appointments.
    * [Date](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Date) : Returns the long-pressed date.
    * [Element](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_Element) : Returns the long-pressed `Scheduler` element.
    * [WeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerInteractionEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerInteractionEventArgs_WeekNumber) : Returns the long-pressed week number value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       LongPressed="OnSchedulerLongPressed" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Scheduler.LongPressed += this.OnSchedulerLongPressed;

private void OnSchedulerLongPressed(object sender, SchedulerLongPressedEventArgs e)
{
    var appointments = e.Appointments;
    var selectedDate = e.Date;
    var schedulerElement = e.Element;
    var weekNumber = e.WeekNumber;
}

{% endhighlight %}
{% endtabs %}

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)
* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_SelectionChanged) event is used to notify when the cell selection is changed onto the view in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

* `Sender`: This contains the `SfScheduler` object.

* `SelectionChanged`: The selection is changed when the selection-changed action is performed on the element available in the [SchedulerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerSelectionChangedEventArgs.html).

    * [NewValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerSelectionChangedEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerSelectionChangedEventArgs_NewValue): Returns the new selected date.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerSelectionChangedEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerSelectionChangedEventArgs_OldValue) : Returns the old selected date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       SelectionChanged="OnSchedulerSelectionChanged" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Scheduler.SelectionChanged += this.OnSchedulerSelectionChanged;

private void OnSchedulerSelectionChanged(object sender, SchedulerSelectionChangedEventArgs e)
{
    var oldDateTime = e.OldValue;
    var newdateTime = e.NewValue;
}

{% endhighlight %}
{% endtabs %}

N>
The `Tapped` event is triggered first, followed by 'selection-changed' event will be performed.

## ViewChanged

The [ViewChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_ViewChanged) event is used to notify when the current view of scheduler is changed, that is when the view is swiped to previous or next view, and when the scheduler view is switched to another scheduler view.

* `Sender`: This contains the `SfScheduler` object.

* `ViewChanged`: The scheduler current view visible dates are available in the [SchedulerViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html) when the scheduler visible dates or view is changed.

    * [NewVisibleDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerViewChangedEventArgs_NewVisibleDates): Returns the new visible date range of the view.
    * [OldVisibleDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerViewChangedEventArgs_OldVisibleDates) : Returns the old visible date range of the view.
    * [NewView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerViewChangedEventArgs_NewView): Returns the new scheduler view. 
    * [OldView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html#Syncfusion_Maui_Scheduler_SchedulerViewChangedEventArgs_OldView) : Returns the old scheduler view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       ViewChanged="OnSchedulerViewChanged" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

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

N>
Whenever a scheduler view is changed, the `SelectableDayPredicate` function must be called to decide whether the cell is selectable or not in the `SfScheduler.`

## Commands

Scheduler commands allow to map Tapped event, Double tapped event, Long Pressed event and View Changed event to Commands which supports the MVVM (Model-View-ViewModel) pattern. 

### TappedCommand 

The [TappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TappedCommand) will be triggered when you tap the scheduler view and pass the [SchedulerTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTappedEventArgs.html) as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18 21 24" %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Month"
                       AllowedViews="Day,Month,TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek,Agenda"
                       TappedCommand="{Binding SchedulerTappedCommand}">
                       <scheduler:SfScheduler.BindingContext>
                            <local:SchedulerInteractionViewModel />
                       </scheduler:SfScheduler.BindingContext>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class SchedulerInteractionViewModel
{
    public ICommand SchedulerTappedCommand { get; set; }

    public SchedulerInteractionViewModel()
    {
        this.SchedulerTappedCommand = new Command<SchedulerTappedEventArgs>(ExecuteTapped);
    }

    private void ExecuteTapped(SchedulerTappedEventArgs obj)
    {
        var selectedDate = obj.Date;
    }

}

{% endhighlight %}  
{% endtabs %}

### DoubleTappedCommand 

The [DoubleTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_DoubleTappedCommand) will be triggered when you double-tap the scheduler view and pass the [SchedulerDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDoubleTappedEventArgs.html) as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18 21 24" %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Month"
                       AllowedViews="Day,Month,TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek,Agenda"
                       DoubleTappedCommand="{Binding SchedulerDoubleTappedCommand}">
                       
                       <scheduler:SfScheduler.BindingContext>
                            <local:SchedulerInteractionViewModel />
                       </scheduler:SfScheduler.BindingContext>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class SchedulerInteractionViewModel
{
    public ICommand SchedulerDoubleTappedCommand { get; set; }

    public SchedulerInteractionViewModel()
    {
        this.SchedulerDoubleTappedCommand = new Command<SchedulerDoubleTappedEventArgs>(ExecuteDoubleTapped);
    }

    private void ExecuteDoubleTapped(SchedulerDoubleTappedEventArgs obj)
    {
        var selectedDate = obj.Date;
    }

}

{% endhighlight %}  
{% endtabs %}

### LongPressedCommand 

The [LongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_LongPressedCommand) will be triggered when you long-press the scheduler view and pass the [SchedulerLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerLongPressedEventArgs.html) as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18 21 24" %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Month"
                       AllowedViews="Day,Month,TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek,Agenda"
                       LongPressedCommand="{Binding SchedulerLongPressedCommand}">

                       <scheduler:SfScheduler.BindingContext>
                            <local:SchedulerInteractionViewModel />
                       </scheduler:SfScheduler.BindingContext>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class SchedulerInteractionViewModel
{
    public ICommand SchedulerLongPressedCommand { get; set; }   

    public SchedulerInteractionViewModel()
    {
        this.SchedulerLongPressedCommand = new Command<SchedulerLongPressedEventArgs>(ExecuteLongPressed);
    }

    private void ExecuteLongPressed(SchedulerLongPressedEventArgs obj)
    {
        var selectedDate = obj.Date;
    }
}

{% endhighlight %}  
{% endtabs %}

### ViewChangedCommand 

The [ViewChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_ViewChangedCommand) will be triggered when you long-press the scheduler view and pass the [SchedulerViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html) as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18 21 24" %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Month"
                       AllowedViews="Day,Month,TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek,Agenda"
                       ViewChangedCommand="{Binding SchedulerViewChangedCommand}">

                       <scheduler:SfScheduler.BindingContext>
                            <local:SchedulerInteractionViewModel />
                       </scheduler:SfScheduler.BindingContext>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class SchedulerInteractionViewModel
{
    public ICommand SchedulerViewChangedCommand { get; set; }

    public SchedulerInteractionViewModel()
    {
        this.SchedulerViewChangedCommand = new Command<SchedulerViewChangedEventArgs>(ExecuteViewChanged);
    }

    private void ExecuteViewChanged(SchedulerViewChangedEventArgs obj)
    {
        var oldVisibleDates = obj.OldVisibleDates;
        var newVisibleDates = obj.NewVisibleDates;
        var oldSchedulerView = obj.OldView;
        var newSchedulerView = obj.NewView;
    }
}

{% endhighlight %}  
{% endtabs %}

•    SelectionChangedCommand 

The [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_SelectionChangedCommand) will be triggered when the scheduler view changes and pass the [SchedulerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerSelectionChangedEventArgs.html) as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18 21 24" %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Month"
                       AllowedViews="Day,Month,TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek,Agenda"
                       SelectionChangedCommand="{Binding SchedulerSelectionChangedCommand}">
                       <scheduler:SfScheduler.BindingContext>
                            <local:SchedulerInteractionViewModel />
                       </scheduler:SfScheduler.BindingContext>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class SchedulerInteractionViewModel
{
    public ICommand SchedulerSelectionChangedCommand { get; set; }

    public SchedulerInteractionViewModel()
    {
        this.SchedulerSelectionChangedCommand = new Command<SchedulerSelectionChangedEventArgs>(ExecuteSelectionChanged);
    }

    private void ExecuteSelectionChanged(SchedulerSelectionChangedEventArgs obj)
    {
        var newDateTime = obj.NewValue;
        var oldDateTime = obj.OldValue;
    }
}

{% endhighlight %}  
{% endtabs %}