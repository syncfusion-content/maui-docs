---
layout: post
title: Footer in .NET MAUI Calendar control | Syncfusion<sup>&reg;</sup> | Calendar
description: Learn here all about Footer view feature of Syncfusion<sup>&reg;</sup> .NET MAUI Calendar (SfCalendar) control and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Footer in .NET MAUI Calendar (SfCalendar)
You can customize all the properties of the Footer view using [FooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_FooterView). By using this property, you can customize the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_Background), [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_Height), [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_DividerColor), [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_TextStyle), [ShowActionButtons](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_ShowActionButtons) and [ShowTodayButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_ShowTodayButton) of the Calendar.

## Customize the header height
You can customize the footer height [Calendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) by using the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_Height) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.FooterView>
                <calendar:CalendarFooterView Height="70" ShowActionButtons="True" ShowTodayButton="True" />
            </calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.Height = 70;

{% endhighlight %}
{% endtabs %}

![Customize the header height in .NET MAUI Calendar.](images/footer/calendar-footer-height.png)

## Action buttons

You can display action buttons at the footer of the calendar by using the [ShowActionButtons](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_ShowActionButtons) property of the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html). It allows you to confirm or cancel the selected date, dates, and range of dates in calendar views of the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.FooterView>
                <calendar:CalendarFooterView ShowActionButtons="true" />
            </calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.ShowActionButtons = true;

{% endhighlight %}
{% endtabs %}

![Show Action button in .NET MAUI Calendar.](images/footer/calendar-action-button.png)

## Today button

The today button can be displayed at the footer of the calendar using the [ShowTodayButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_ShowTodayButton) property of the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html), allowing you to quickly navigate from current view to the today view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.FooterView>
                <calendar:CalendarFooterView ShowTodayButton="True" />
            </calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.ShowTodayButton = true;

{% endhighlight %}
{% endtabs %}

![Show Today button in .NET MAUI Calendar.](images/footer/calendar-today-button.png)

## Set the Divider color

You can customize the footer divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_DividerColor) property of the [CalendarFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.FooterView>
                <calendar:CalendarFooterView DividerColor="Red" ShowActionButtons="True" ShowTodayButton="True" />
            </calendar:SfCalendar.FooterView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.FooterView.Height = 70;

{% endhighlight %}
{% endtabs %}

![Set Divider Color in .NET MAUI Calendar.](images/footer/calendar-divider-color.png)

## Customization of the footer 

You can customize the footer text style and background color of the Calendar footer view using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html#Syncfusion_Maui_Calendar_CalendarFooterView_Background) properties of the [CalendarFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar x:Name="calendar" >
    <calendar:SfCalendar.FooterView >
        <calendar:CalendarFooterView Background="#D3D3D3" ShowActionButtons="True" ShowTodayButton="True" >
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

![Footer Text Style in .NET MAUI Calendar.](images/footer/calendar-footer-textstyle.png)