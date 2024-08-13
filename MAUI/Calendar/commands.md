---
layout: post
title: Events in .NET MAUI Calendar control | Syncfusion
description: Learn here all about the Command support in Syncfusion .NET MAUI Calendar (SfCalendar) control and more details.
platform: maui
control: SfCalendar
documentation: ug
---

# Commands

## ViewChangedCommand

The [ViewChangedCommand]() is invoked whenever the view is navigated to either the previous or next view. Additionally, it is triggered when switching between different calendar views, with the `CalendarViewChangedEventArgs` provided as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
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

## SelectionChangedCommand

The [SelectionChangedCommand]() is invoked whenever selection changes in the calendar  changes, with the `CalendarSelectionChangedEventArgs` passed as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
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

## TappedCommand

The [TappedCommand] is invoked whenever the calendar view is tapped, with the `CalendarTappedEventArgs` passed as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
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

## DoubleTappedCommand

The [DoubleTappedCommand]() is invoked whenever the calendar view is double tapped, with the `CalendarDoubleTappedEventArgs` passed as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3,6,8" %}

<calendar:SfCalendar  x:Name="Calendar" 
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

## LongPressedCommand

The [LongPressedCommand]() is invoked whenever the calendar view is long pressed, with the `CalendarLongPressedEventArgs` passed as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
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

## AcceptCommand

The [AcceptCommand]() is triggered whenever confirm button tapped on calendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
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

## DeclineCommand

The [DeclineCommand]() is triggered whenever the cancel button tapped on calendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
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