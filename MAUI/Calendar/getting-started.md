---
layout: post
title: Getting started with MAUI Calendar control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Calendar(SfCalendar) control and its basic features.
platform: maui
control: SfCalendar
documentation: ug
---

# Getting started with .NET MAUI Calendar (SfCalendar)
This section explains the steps required to add the Calendar control. This section covers only basic features needed to get started with Syncfusion Calendar.

## Creating an application using the .NET MAUI Calendar

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfCalendar to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Calendar](https://www.nuget.org/packages/Syncfusion.Maui.Calendar), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Calendar` in XAML or C# code.

4. Initialize `SfCalendar.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

using Syncfusion.Maui.Calendar;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfCalendar calendar = new SfCalendar();
        this.Content = calendar;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Segoe-mdl2.ttf", "SegoeMDL2");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Change different calendar views

The [.NET MAUI Calendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) control provides four different types of views to display dates, and it can be assigned to the control using the [View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_View) property. By default, the control is assigned to the [Month](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarView.html#Syncfusion_Maui_Calendar_CalendarView_Month) view. Initially, all Calendar views will show the current date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Month;

{% endhighlight %}
{% endtabs %}

![change-different-calendar-views-in-maui-calendar](images/getting-started/maui-calendar-month-view.png)

## Change first day of week

The Calendar control is rendered with `Sunday` as the first day of the week and it allows customization to change the first day of the week using the [FirstDayOfWeek](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_FirstDayOfWeek) property in month view.

The following code shows the Calendar with `Monday` as the first day of the week.

{% tabs %}  
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar x:Name="calendar">
    <calendar:SfCalendar.MonthView>
        <calendar:CalendarMonthView FirstDayOfWeek="Monday"/>
    </calendar:SfCalendar.MonthView>
 </calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.FirstDayOfWeek = DayOfWeek.Monday;

{% endhighlight %}  
{% endtabs %}

![change-first-day-of-week-in-maui-calendar](images/getting-started/maui-calendar-first-day-of-week.png)

## Date selection

The [Calendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) allows the user to select a single date, multiple dates, or a range of dates by interaction or programmatic selection. The default selection mode is `Single`.

The selection details can be obtained by using the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChanged) event of the calendar. It returns `CalendarSelectionChangedEventArgs`, which holds the details about the selected date or range.

The following code shows the Calendar with `Multiple` as the Selection mode.

{% tabs %}  
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      SelectionMode="Multiple">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectionMode = CalendarSelectionMode.Multiple;

{% endhighlight %}  
{% endtabs %}

![change-selection-mode](images/getting-started/maui-calendar-multiple-selection.png)