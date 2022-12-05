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

this.Calendar.HeaderView.Height = 100;

{% endhighlight %}
{% endtabs %}

![header-height-maui-calendar](images/header-height.png)

## Header appearance
You can customize the header style of the `Calendar` by using the [Background]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/background.html)), [TextStyle]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textStyle.html)), and [TextFormat]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textFormat.html)) properties of [ShowNavigationArrows]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/showNavigationArrows.html)).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/header-appearance.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.HeaderView.Background = Colors.Gray;
this.Calendar.HeaderView.TextFormat = "MMM yy";
this.Calendar.HeaderView.ShowNavigationArrows = true;
this.Calendar.HeaderView.TextStyle.TextColor = Colors.Black;
this.Calendar.HeaderView.TextStyle.FontSize = 14;

{% endhighlight %}
{% endtabs %}

![header-appearance-maui-calendar](images/header-appearance.png)

## View header
You can customize all the properties of the View Header using [HeaderView]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/monthView/headerView.html)). By using this property you can customize the Background, Height, TextFormat and TextStyle in the Calendar.

### Customize view header height
You can customize the View Header height `Calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/header-height.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.HeaderView.Height = 100;

{% endhighlight %}
{% endtabs %}

![view-header-height-maui-calendar](images/view-header-height.png)

### View header appearance
You can customize the view header style of the `Calendar` by using the [Background]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/background.html)), [TextStyle]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textStyle.html)), and [TextFormat]((https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/textFormat.html)) properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/view-header-appearance.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.HeaderView.Background = Colors.Gray;
this.Calendar.MonthView.HeaderView.TextFormat = "ddd";
this.Calendar.MonthView.HeaderView.TextStyle.TextColor = Colors.Black;
this.Calendar.MonthView.HeaderView.TextStyle.FontSize = 14;

{% endhighlight %}
{% endtabs %}

![view-header-appearance-maui-calendar](images/view-header-appearance.png)