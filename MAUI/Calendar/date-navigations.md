---
layout: post
title: Date Navigations in  MAUI Calendar widget | Syncfusion
description: Learn here all about Date navigations feature of Syncfusion MAUI Calendar (SfCalendar) widget and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Date Navigations in MAUI Calendar (SfCalendar)

## Programmatic date navigation
Allows you to navigate through the Dates by programmatically in the calendar widget by using the [DisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DisplayDate) property of [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.DisplayDate = DateTime.Now.AddMonths(2).Date;

{% endhighlight %}
{% endtabs %}

![display-date-in-maui-calendar](images/date-navigation/display-date-in-maui-calendar.png)

## Programmatic view navigation
Allows you to navigate through the views by programmatically in the calendar widget by using the [View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_View) property of [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.View = CalendarView.Month;

{% endhighlight %}
{% endtabs %}

![monthview-in-maui-calendar](images/date-navigation/monthview-in-maui-calendar.png)

## Allow view navigation
Allows you to navigate by using the [AllowViewNavigation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_AllowViewNavigation)  property through tap interaction on the cell or header. By using this property you can able to restrict the view navigation and allow you to select the cells in the Year, Decade and Century views.

The following code shows whem the AllowViewNavigation property is `true`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month"
                        AllowViewNavigation="True">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.AllowViewNavigation = true;

{% endhighlight %}
{% endtabs %}

## Programmatically change to adjacent dates
The next and previous view can be navigated by swiping the Calendar control from right to left and left to right. In the `SfCalendar`, view can be changed programmatically by using the [Forward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Forward) and [Backward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Backward) methods.

### Forward
The `Forward` navigation allows you to view the next immediate date of the calendar based on the CalendarViews.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
        <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition Height="30"/>
        </Grid.RowDefinitions>
        <Calendar:SfCalendar x:Name="Calendar"
                             View="Month" />
        <Button x:Name="button" Grid.Row="1" Text="Forward"
                Clicked="button_Clicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void button_Clicked(object sender, EventArgs e)
{
  this.Calendar.Forward();
}

{% endhighlight %}
{% endtabs %}

### Backward
The `Backward` navigation allows you to view the immediate previous date of the calendar based on the CalendarViews.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
        <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition Height="30"/>
        </Grid.RowDefinitions>
        <Calendar:SfCalendar x:Name="Calendar"
                             View="Month" />
        <Button x:Name="button" Grid.Row="1" Text="Backward"
                Clicked="button_Clicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void button_Clicked(object sender, EventArgs e)
{
  this.Calendar.Backward();
}

{% endhighlight %}
{% endtabs %}

## Navigation direction
Views can be navigated by using the `Navigation direction` property either `Vertical` or `Horizontal` directions by setting the `NavigationDirection` property of `Calendar`. The default [NavigationDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_NavigationDirection) is `Vertical`.

The following code shows the Navigation direction in `Horizontal`,

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month"
                        NavigationDirection="Horizontal">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.NavigationDirection = CalendarNavigationDirection.Horizontal;

{% endhighlight %}
{% endtabs %}

![horizontal-navigation-direction-in-maui-calendar](images/date-navigation/horizontal-navigation-direction-in-maui-calendar.png)

## Show navigation arrow
By using the `ShowNavigationArrows` property of the `Calendar` you can navigate to the next or previous views of the calendar without swiping. By default, the value of [ShowNavigationArrows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_ShowNavigationArrows) is `true`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month">
                        <Calendar:SfCalendar.HeaderView>
                            <Calendar:CalendarHeaderView ShowNavigationArrows="False" />
                        </Calendar:SfCalendar.HeaderView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.HeaderView.ShowNavigationArrows = false;

{% endhighlight %}
{% endtabs %}

![show-navigation-arrows-in-maui-calendar](images/date-navigation/show-navigation-arrows-in-maui-calendar.png)