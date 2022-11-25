---
layout: post
title: Views in MAUI Calendar widget | Syncfusion
description: Learn here all about Views feature of Syncfusion MAUI Calendar (SfCalendar) widget and more.
platform: MAUI
control: Calendar
documentation: ug
---

# Multiple Calendar Views in MAUI (SfCalendar)
The `SfCalendar` widget has four types of Calendar views to display. It can be assigned to the widget by using the [view](https://pub.dev/documentation/syncfusion_flutter_datepicker/latest/datepicker/SfDateRangePicker/view.html) property. Month view is initially rendered by Default. The current date will be displayed initially for all the Calendar views.

## Month view
The Month view displays the current month's days, and usually a few days of previous and next month. By default, initially displays the current month dates and the current date is highlighted by a separate color different from the rest of the dates color in `month view`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Month;

{% endhighlight %}
{% endtabs %}

![change-month-views-in-maui-calendar](images/views/month-view.png)


#### Week number
Week number displays in the month view by setting the [showWeekNumber](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/MonthViewSettings/showWeekNumber.html) property. By default, the week number is false. If you need to show the week number in the month view by setting the ShowWeekNumber as true. Week numbers will be displayed based on the ISO standard.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/show_week_number.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.ShowWeekNumber = true;

{% endhighlight %}
{% endtabs %}

![show-week-number-in-month-view-in-maui-calendar](images/views/show-week-number-in-month-view.png)


#### Week number style
Week number Background and TextStyle can be customized in the month view. Background color can be changed by using the [Background] property and the textStyle can be changed by using the [TextStyle] property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/week_number_style.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.WeekNumberStyle.Background = Colors.Pink;
this.Calendar.MonthView.WeekNumberStyle.TextStyle.TextColor = Colors.Purple;

{% endhighlight %}
{% endtabs %}

![week-number-style-in-month-view-in-maui-calendar](images/views/week-number-style-in-month-view.png)


## Year view
The Year view displays the current year's months. A calendar year is a one-year period that begins on January 1 and ends on December 31. By default, initially displays the current years months and the current month is highlighted by a separate color different from the rest of the month color in `year view`. Can easily navigate to the desired month dates from the year view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/year-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Year;

{% endhighlight %}
{% endtabs %}

![year-view-in-maui-calendar](images/views/year-view.png)

## Decade view
The Decade view displays the period of ten years and some years of next view. By default, initially displays the current year view and the current year is highlighted by a separate color different from the rest of the years color in `decade view`. Can easily navigate to the desired year in the Year view from the decade view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/decade-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Deacde;

{% endhighlight %}
{% endtabs %}

![decade-views-in-maui-calendar](images/views/decade-view.png)

## Century view
The Century view displays the period of hundred years and some years of next view. By default, initially displays the current range of years and the current year range is highlighted by a separate color different from the rest of the years color in `decade view`. Can easily navigate to the Decade view from the Century view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/century-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Century;

{% endhighlight %}
{% endtabs %}

![decade-views-in-maui-calendar](images/views/decade-view.png)

## Number Of Visible Weeks view
In the month view, number of visible weeks can be customized by using the [NumberOfVisibleWeeks] property in the Calendar. By default, Month view displays with the NumberOfVisibleWeeks is set to the value of six.

The following code shows the Calendar month view with NumberOfVisibleWeeks as `4`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/number-of-visible-week-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.NumberOfVisibleWeeks = 4;

{% endhighlight %}
{% endtabs %}

![number-of-visible-week-view-in-maui-calendar](images/views/number-of-visible-week-view.png)