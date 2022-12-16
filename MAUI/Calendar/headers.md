---
layout: post
title: Headers in MAUI Calendar widget | Syncfusion | Calendar
description: Learn here all about Headers feature of Syncfusion Calendar (SfCalendar) widget and more.
platform: MAUI
control: SfCalendar
documentation: ug
---

# Headers in MAUI Calendar (SfCalendar)
You can customize all the properties of the Header view using [HeaderView]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/headerStyle.html)). By using this property you can customize the Background, Height, TextFormat, TextStyle and ShowNavigationArrows in the Calendar.

## Customize the header height
You can customize the header height `Calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/header-height.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.HeaderView = new CalendarHeaderView()
{
    Height = 100,
};

{% endhighlight %}
{% endtabs %}

![change-header-height-in-maui-calendar](images/header/change-header-height-in-maui-calendar.png)

## Header appearance
You can customize the header style of the `Calendar` by using the [Background]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/background.html)), [TextStyle]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textStyle.html)), and [TextFormat]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textFormat.html)) properties of [ShowNavigationArrows]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/showNavigationArrows.html)).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/header-appearance.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

CalendarTextStyle textStyle = new CalendarTextStyle()
{
    TextColor = Colors.Black,
    FontSize = 14,
};

this.Calendar.HeaderView = new CalendarHeaderView()
{
    Background = Colors.Grey,
    TextFormat = "MMM yy",
    ShowNavigationArrows = true,
    TextStyle = textStyle,
};

{% endhighlight %}
{% endtabs %}

![change-header-appearance-in-maui-calendar](images/header/change-header-appearance-in-maui-calendar.png)

## View header
You can customize all the properties of the View Header using [HeaderView]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/monthView/headerView.html)). By using this property you can customize the Background, Height, TextFormat and TextStyle in the Calendar.

### Customize view header height
You can customize the View Header height `Calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/header-height.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.HeaderView = new CalendarMonthHeaderView
{
    Height = 50,
};

{% endhighlight %}
{% endtabs %}

![change-view-header-height-in-maui-calendar](images/header/change-view-header-height-in-maui-calendar.png)

### View header appearance
You can customize the view header style of the `Calendar` by using the [Background]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/background.html)), [TextStyle]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textStyle.html)), and [TextFormat]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textFormat.html)) properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/view-header-appearance.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

CalendarTextStyle textStyle = new CalendarTextStyle()
{
    TextColor = Colors.Black,
    FontSize = 14,
};

this.Calendar.MonthView.HeaderView = new CalendarMonthHeaderView
{
    Background = Colors.Grey,
    TextFormat = "ddd",
    TextStyle = textStyle,
};

{% endhighlight %}
{% endtabs %}

![change-view-header-appearance-in-maui-calendar](images/header/change-view-header-appearance-in-maui-calendar.png)