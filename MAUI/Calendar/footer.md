---
layout: post
title: Footer in .NET MAUI Calendar control | Syncfusion | Calendar
description: Learn here all about Footer feature of Syncfusion .NET MAUI Calendar (SfCalendar) control and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Footer in .NET MAUI Calendar (SfCalendar)
You can customize all the properties of the Footer view using [FooterView]. By using this property, you can customize the Background, Height, DividerColor, TextStyle, ShowActionButtons and ShowTodayButton of the Calendar.

## Customize the header height
You can customize the footer height `Calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <Calendar:SfCalendar.FooterView>
                <Calendar:CalendarFooterView Height="70" />
            </Calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.Height = 70;

{% endhighlight %}
{% endtabs %}

## Action buttons

You can display action buttons at the footer of the calendar by using the `ShowActionButtons` property of the `SfCalendar`. It allows you to confirm or cancel the selected date, dates, and range of dates in calendar views of the SfCalendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <Calendar:SfCalendar.FooterView>
                <Calendar:CalendarFooterView ShowActionButtons="true" />
            </Calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.ShowActionButtons = true;

{% endhighlight %}
{% endtabs %}

## Today button

The today button can be displayed at the footer of the calendar using the `ShowTodayButton` property of the `SfCalendar`, allowing you to quickly navigate from current view to the today view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <Calendar:SfCalendar.FooterView>
                <Calendar:CalendarFooterView ShowTodayButton="True" />
            </Calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.ShowTodayButton = true;

{% endhighlight %}
{% endtabs %}

## Set the Divider color

The SfCalendar control allows you to customize the footer divider color by setting the DividerColor property of the CalendarFooterView.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <Calendar:SfCalendar.FooterView>
                <Calendar:CalendarFooterView DividerColor="Red" />
            </Calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.Height = 70;

{% endhighlight %}
{% endtabs %}

## Customization of the footer 

Customize the footer text style and background color of the Calendar using the TextStyle and Background properties of the CalendarFooterView.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar x:Name="calendar" >
    <calendar:SfCalendar.FooterView >
        <calendar:CalendarFooterView Background="#D3D3D3">
            <calendar:CalendarFooterView.TextStyle >
                <calendar:CalendarTextStyle FontSize="15" TextColor="Black" />
            </calendar:CalendarFooterView.TextStyle>
        </calendar:CalendarFooterView>
    </calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfCalendar calendar = new SfCalendar();
calendar.FooterView = new CalendarFooterView()
{
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new CalendarTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = calendar;

{% endhighlight %}
{% endtabs %}