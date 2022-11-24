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

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfCalendar to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Calendar and then install it.

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

The .NET MAUI Calendar control provides four different types of views to display dates and it can be assigned to the control by using the `View` property. The control is assigned to the Month view by default. Initially, all Calendar views will show the current date.

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

The Calendar control rendered with `Sunday` as first day of week and it  provides customization to change the first day of the week with the FirstDayOfWeek property in month view.

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

Calendar allows the user to Select a single date, multiple dates, or a range of dates through interaction and programmatically. The default selection mode is `Default`. 

The selection details can be obtained by using SelectionChanged event of calendar. It returns `CalendarSelectionChangedEventArgs` which holds the details about selected date or range.

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