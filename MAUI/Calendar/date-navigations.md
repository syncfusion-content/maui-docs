---
layout: post
title: Date Navigations in  MAUI Calendar widget | Syncfusion
description: Learn here all about Date navigations feature of Syncfusion MAUI Calendar (SfCalendar) widget and more.
platform: MAUI
control: SfCalendar
documentation: ug
---

# Date Navigations in MAUI Calendar (SfCalendar)

## Programmatic date navigation
Allows you to navigate through the Dates by programmatically in the calendar widget by using the [displayDate](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarController/displayDate.html)  property of [CalendarController](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarController-class.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/display-date.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.DisplayDate = DateTime.Now.AddMonths(2).Date;

{% endhighlight %}
{% endtabs %}

![Displaydate calendar](images/dateNavigation/display-date.png)

## Programmatic view navigation
Allows you to navigate through the views by programmatically in the calendar widget by using the [view](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarController/view.html) property of [CalendarController](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarController-class.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Month;

{% endhighlight %}
{% endtabs %}

![view navigation-maui-calendar](images/views/month-view.png)

## Allow view navigation
Allows you to navigate by using the [allowViewNavigation](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarController/allowViewNavigation.html)  property through tap interaction on the cell or header. By using this property you can able to restrict the view navigation and allow you to select the cells in the Year, Decade and Century views.

The following code shows whem the AllowViewNavigation property is `true`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/allow-view-navigation.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.AllowViewNavigation = true;

{% endhighlight %}
{% endtabs %}

## Programmatically change to adjacent dates
The next and previous view can be navigated by swiping the Calendar control from right to left and left to right. In the `SfCalendar`, view can be changed programmatically by using the [forward](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarControl/forward.html) and [backward](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/CalendarControl/backward.html)methods.

### Forward
The `forward` navigation allows you to view the next immediate date of the calendar based on the CalendarViews.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/forward-navigation.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void button_Clicked(object sender, EventArgs e)
{
  this.Calendar.Forward();
}

{% endhighlight %}
{% endtabs %}

### Backward
The `backward` navigation allows you to view the immediate previous date of the calendar based on the CalendarViews.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/backward-navigation.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void button_Clicked(object sender, EventArgs e)
{
  this.Calendar.Backward();
}

{% endhighlight %}
{% endtabs %}

## Navigation direction
Views can be navigated by using the `Navigation direction` property either `Vertical` or `Horizontal` directions by setting the [navigationDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/navigationDirection.html) property of `Calendar`. The default navigation direction is `Horizontal`.

The following code shows the Navigation direction in `Horizontal`,

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/horizontal-navigation-direction.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.NavigationDirection = CalendarNavigationDirection.Horizontal;

{% endhighlight %}
{% endtabs %}

![horizontal-navigation-direction-maui-calendar](images/views/horizontal-navigation-direction.png)

## Show navigation arrow
By using the [showNavigationArrow](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/shownavigationArrow.html) property of the `Calendar` you can navigate to the next or previous views of the calendar without swiping. By default, the value of showNavigationArrow is `true`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/show-navigation-arrow.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.HeaderView.ShowNavigationArrows = false;

{% endhighlight %}
{% endtabs %}

![show-navigation-arrow-maui-calendar](images/views/show-navigation-arrow.png)