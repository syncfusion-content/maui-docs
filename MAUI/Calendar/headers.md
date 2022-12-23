---
layout: post
title: Headers in MAUI Calendar widget | Syncfusion | Calendar
description: Learn here all about Headers feature of Syncfusion .NET MAUI Calendar (SfCalendar) widget and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Headers in MAUI Calendar (SfCalendar)
You can customize all the properties of the Header view using `HeaderView`. By using this property you can customize the Background, Height, TextFormat, TextStyle and ShowNavigationArrows in the Calendar.

## Customize the header height
You can customize the header height `Calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar"
                      View="Month">
            <Calendar:SfCalendar.HeaderView>
                <Calendar:CalendarHeaderView Height="70" />
            </Calendar:SfCalendar.HeaderView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.HeaderView = new CalendarHeaderView()
{
    Height = 70,
};

{% endhighlight %}
{% endtabs %}

![change-header-height-in-maui-calendar](images/header/change-header-height-in-maui-calendar.png)

## Header appearance
You can customize the header style of the `Calendar` by using the [Background], [TextStyle], and [TextFormat] properties of [ShowNavigationArrows].

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar"
                      View="Month">
            <Calendar:SfCalendar.HeaderView>
                <Calendar:CalendarHeaderView Background="Grey" TextFormat="MMM yy" ShowNavigationArrows="True">
                    <Calendar:CalendarHeaderView.TextStyle>
                        <Calendar:CalendarTextStyle TextColor="Black" FontSize="14" />
                    </Calendar:CalendarHeaderView.TextStyle>
                </Calendar:CalendarHeaderView>
            </Calendar:SfCalendar.HeaderView>
</calendar:SfCalendar>

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
You can customize all the properties of the View Header using [HeaderView]. By using this property you can customize the Background, Height, TextFormat and TextStyle in the Calendar.

### Customize view header height
You can customize the View Header height `Calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar"
                      View="Month">
            <Calendar:SfCalendar.MonthView>
                <Calendar:CalendarMonthView>
                    <Calendar:CalendarMonthView.HeaderView>
                        <Calendar:CalendarMonthHeaderView Height="50" />
                    </Calendar:CalendarMonthView.HeaderView>
                </Calendar:CalendarMonthView>
            </Calendar:SfCalendar.MonthView>
</calendar:SfCalendar>

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
You can customize the view header style of the `Calendar` by using the [Background], [TextStyle], and [TextFormat] properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar"
                      View="Month">
            <Calendar:SfCalendar.MonthView>
                <Calendar:CalendarMonthView>
                    <Calendar:CalendarMonthView.HeaderView>
                        <Calendar:CalendarMonthHeaderView Background="Grey" TextFormat="ddd">
                            <Calendar:CalendarMonthHeaderView.TextStyle>
                                <Calendar:CalendarTextStyle TextColor="Black" FontSize="14" />
                            </Calendar:CalendarMonthHeaderView.TextStyle>
                        </Calendar:CalendarMonthHeaderView>
                    </Calendar:CalendarMonthView.HeaderView>
                </Calendar:CalendarMonthView>
            </Calendar:SfCalendar.MonthView>
</calendar:SfCalendar>

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