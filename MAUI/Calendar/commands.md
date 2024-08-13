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

The [ViewChangedCommand]() is triggered whenever the view is swiped to the previous or next view, as well as when the calendar view is switched to another calendar view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      ViewChangedCommand="ViewChangedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class CalendarViewModel
{
    public ICommand ViewChangedCommand { get; set; }
    public CalendarViewModel()
    {
        ViewChangedCommand = new Command(ViewChanged);
    }
    private void ViewChanged()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

## SelectionChangedCommand

The [SelectionChangedCommand]() is triggered whenever the selection is changed in calendar view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                     SelectionChangedCommand="SelectionChangedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class CalendarViewModel
{
    public ICommand SelectionChangedCommand { get; set; }
    public CalendarViewModel()
    {
        SelectionChangedCommand = new Command(SelectionChanged);
    }
    private void SelectionChanged()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

## TappedCommand

The [TappedCommand]() is triggered whenever the calendar view is tapped.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                     TappedCommand="TappedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class CalendarViewModel
{
    public ICommand TappedCommand { get; set; }
    public CalendarViewModel()
    {
        TappedCommand = new Command(Tapped);
    }
    private void Tapped()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

## DoubleTappedCommand

The [DoubleTappedCommand]() is triggered whenever the calendar view is double tapped.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

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
        DoubleTappedCommand = new Command(DoubleTapped);
    }
    private void DoubleTapped()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

## LongPressedCommand

The [LongPressedCommand]() is triggered whenever the calendar view is long pressed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<calendar:SfCalendar  x:Name="Calendar" 
                     LongPressedCommand="LongPressedCommand">
<ContentPage.BindingContext>
    <local:CalendarViewModel/>
</ContentPage.BindingContext>					  
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public class CalendarViewModel
{
    public ICommand LongPressedCommand { get; set; }
    public CalendarViewModel()
    {
        LongPressedCommand = new Command(LongPressed);
    }
    private void LongPressed()
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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

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