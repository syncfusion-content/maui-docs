---
layout: post
title: Migrate from Syncfusion Xamarin SfCalendar to .NET MAUI SfCalendar
description: Learn here all about Migrating from Syncfusion Xamarin calendar to Syncfusion .NET MAUI Calendar control and more.
platform: MAUI
control: SfCalendar
documentation: ug
---  

# Migrate from Xamarin.Forms SfCalendar to .NET MAUI SfCalendar 

To make the migration from the Xamarin [Xamarin SfCalendar]() to [.NET MAUI SfCalendar]() easier, most of the APIs from the Xamarin SfCalendar were kept in the.NET MAUI SfCalendar. However, to maintain the consistency of API naming in the .NET MAUI SfCalendar, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>Syncfusion.SfCalendar.XForms</td>
<td>Syncfusion.Maui.SfCalendar</td></tr>
</table>

## Initialize control

To initialize the control, import the calendar namespace and initialize SfCalendar as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

    <calendar:SfCalendar/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th></tr>
<tr>
<td>AppointmentStyle</td>
<td>CalendarTextStyle</td>
<td> Gets or sets properties which allows to customize the calendar text style of the SfCalendar.</td>
</tr>
<tr>
<td>SelectionRange</td>
<td>CalendarDateRange</td>
<td>Represents a class which holds the start and end date of the range in SfCalendar.</td>
<tr> 
<tr>
<td>MonthViewSettings</td>
<td>CalendarMonthView</td>
<td>Represents a class which is used to configure all the properties and styles of calendar month view.</td>
</tr> 

<tr>
<td>MonthLabelSettings</td>
<td>NA</td>
<td>NA</td>
</tr> 
<tr>
<td>MonthEventParameters</td>
<td>NA</td>
<td>NA</td>
</tr> 
<tr>
<td>MonthCell</td>
<td>MonthView</td>
<td>Represents month view which contains month cells, week number views and month view header.</td>
</tr> 
<tr>
<td>YearViewSettings</td>
<td>CalendarYearView</td>
<td>Represents a class which is used to used to configure all the properties and styles of calendar year, decade and century view.</td>
</tr>
<tr>
<td>YearCell</td>
<td>YearView</td>
<td>Represents Year view</td>
</tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

    <calendar:SfCalendar ViewMode="MonthView"/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
calendar.ViewMode = CalendarView.MonthView;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar View="Month"/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
calendar.View = CalendarView.Month;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Properties 
<table>
<tr>
<th>Xamarin SfCalendar Properties</th>
<th>.NET MAUI SfCalendar Properties</th>
<th>Description</th>
</tr>
<tr>
<td>TapCommand</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>SelectionChangedCommand</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>HeaderView</td>
<td>HeaderView</td>
<td>Gets or sets the properties which allows to customize the calendar header of month, year, decade and century views.</td>
</tr>
<tr>
<td>NumberOfWeeksInView</td>
<td>NumberOfVisibleWeeks(From CalendarMonthView)</td>
<td>Gets or sets a value to display the number of weeks in calendar month view.</td>
</tr>

<tr>
<td>MoveToDate</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>ViewMode</td>
<td>View</td>
<td>Gets or sets the built-in views such as month, year, decade and century of the SfCalendar.</td>
</tr>
<tr>
<td>YearViewMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NavigationDirection</td>
<td>NavigationDirection</td>
<td>Gets or sets a value which determines the direction of the calendar scrolls.</td>
</tr>
<tr>
<td>EnableSwiping</td>
<td>EnableSwipeSelection</td>
<td>Gets or sets a value indicating whether the swiping selection enabled for select the date range.</td>
</tr>
<tr>
<td>DataSource</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>YearViewSettings</td>
<td>YearView</td>
<td>Gets or sets the properties which allows to customize the calendar year view.</td>
</tr>
<tr>
<td>SelectionMode</td>
<td>SelectionMode</td>
<td>Gets or sets the selection mode of the calendar.</td>
</tr>
<tr>
<td>TransitionMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>InlineViewMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>MaximumEventIndicatorCount</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>AgendaViewHeight</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>MonthViewSettings</td>
<td>MonthView</td>
<td>Gets or sets the properties which allows to customize the calendar month view.</td>
</tr>
<tr>
<td>MinDate</td>
<td>MinimumDate</td>
<td>Gets or sets the minimum display date to restrict the visible dates in the SfCalendar.</td>
</tr>
<tr>
<td>MaxDate</td>
<td>MaximumDate</td>
<td>Gets or sets the maximum display date to restrict the visible dates in the SfCalendar.</td>
</tr>
<tr>
<td>DisplayDate</td>
<td>DisplayDate</td>
<td>Gets or sets the display date to programmatically navigate the dates in the SfCalendar.</td>
</tr>
<tr>
<td>SelectedDate</td>
<td>SelectedDate</td>
<td>Gets or sets the selected date to select the particular date of the calendar.</td>
</tr>
<tr>
<td>NullableSelectedDate</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>SelectedDates</td>
<td>SelectedDates</td>
<td>Gets or sets the selected dates to select the multiple dates of the calendar.</td>
</tr>
<tr>
<td>SelectedRange</td>
<td>SelectedDateRange</td>
<td>Gets or sets the selected date range to select the range of dates of the calendar.</td>
</tr>
<tr>
<td>ShowYearView</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>Locale</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>ShowInlineEvents</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>EnableDatesInPast</td>
<td>EnablePastDates</td>
<td>Gets or sets a value indicating whether the dates enabled or disabled before today date.</td>
</tr>
<tr>
<td>NavigateToMonthOnInActive
DatesSelection
</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>ShowNavigationButtons</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>ShowLeadingAndTrailingDays</td>
<td>ShowTrailingAndLeadingDates</td>
<td>Gets or sets a value indicating whether to displays the leading and trailing dates in the month, decade, century views of the SfCalendar.</td>
</tr>
<tr>
<td>ToggleDaySelection</td>
<td>CanToggleDaySelection</td>
<td>Gets or sets a value indicating whether the selected date is deselectable through interaction on single selection mode of SfCalendar.<td>
</tr>
<tr>
<td>VisibleDates</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>FirstDayofWeek</td>
<td>FirstDayOfWeek(From CalendarMonthView)</td>
<td>Gets or sets the day of week that used to change the default first day of week in SfCalendar.</td>
</tr>
<tr>
<td>HeaderHeight</td>
<td>Height(From CalendarHeaderView)</td>
<td>Gets or sets the value to specify the height of header view on SfCalendar.</td>
</tr>
<tr>
<td>ShowHeader</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>BlackoutDates</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>CustomDayLabels</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NavigationButtonWidth</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NavigationArrowThickness</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>BlackoutDatesViewMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NavigationButtonHeight</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>HoldCommand</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>MonthChangedCommand</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>SuspendAppointmentsUpdate</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NA</td>
<td>AllowViewNavigation</td>
<td>Gets or sets a value indicating whether the navigation enabled on year, decade and century cell interaction.</td>
</tr>
<tr>
<td>NA</td>
<td>TodayHighlightBrush</td>
<td>Gets or sets the value that describes the today highlight color value.</td>
</tr>
<tr>
<td>NA</td>
<td>SelectionBackground</td>
<td>Gets or sets the value that describes the highlight of selection based on selection mode of the calendar.
1. Highlight the selected date in single selection mode.
2. Highlight the selected dates in multiple selection mode.
3. Highlight the in between dates on range selection mode.</td>
</tr>
<tr>
<td>NA</td>
<td>StartRangeSelectionBackground</td>
<td>Gets or sets the value that describes the highlight for range start date of calendar.</td>
</tr>
<tr>
<td>NA</td>
<td>EndRangeSelectionBackground</td>
<td>Gets or sets the value that describes the highlight for range end date of calendar</td>
</tr>
<tr>
<td>NA</td>
<td>ShowTrailingAndLeadingDates</td>
<td>Gets or sets a value indicating whether to displays the leading and trailing dates in the month, decade, century views of the SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>RangeSelectionDirection</td>
<td>Gets or sets a value determines the range selection direction of the SfCalendar.</td>
</tr>
</table>

## Xamarin MonthViewSettings to .NET MAUI CalendarMonthView
<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">
        <calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.MonthViewSettings>
                <calendar:MonthViewSettings SelectionShape = SelectionShape.Circle/>
            </calendar:SfCalendar.MonthViewSettings>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
calendar.MonthViewSettings.SelectionShape = SelectionShape.Circle;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
        <calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView NumberOfVisibleWeeks="6"/>
            </calendar:SfCalendar.MonthView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
calendar.MonthView.NumberOfVisibleWeeks = 6;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar
MonthViewSettings</th>
<th>.NET MAUI SfCalendar CalendarMonthView</th>
<th>Description</th>
</tr>
<tr>
<td>DayHeight</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>CellTemplate</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>InlineItemTemplate</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>CellGridOptions</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>SelectionShape</td>
<td>SelectionShape</td>
<td>Gets or sets the selection shape of the SfCalendar.</td>
</tr>
<tr>
<td>DayLabelTextAlignment</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>HeaderTextColor,HeaderBackgroundColor,
HeaderFontAttributes,
HeaderFontFamily, HeaderFontSize</td>
<td>CalendarTextStyle(From TextStyle CalendarHeaderMonthView)</td>
<td>

Represents a class which is used to customize all the properties of view header view of the SfCalendar.</td>
</tr>
<tr>
<td>DayHeaderFontAttributes</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayHeaderFontFamily</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayFontAttributes</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayCellFontFamily</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayFontSize</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayCellFont</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayHeaderBackgroundColor</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayHeaderTextColor</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>WeekEndBackgroundColor</td>
<td>WeekendDatesBackground</td>
<td>Gets or sets the background for the weekend month cells of the calendar month view.</td>
</tr>
<tr>
<td>WeekEndTextColor</td>
<td>WeekendDatesTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the weekend month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>MonthLabelSettings</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>CurrentMonthTextColor</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>CurrentMonthBackgroundColor</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>TodaySelectionBackgroundColor</td>
<td>TodayBackground</td>
<td>Gets or sets the background for the today month cell of the calendar month view.</td>
</tr>
<tr>
<td>TodaySelectionTextColor</td>
<td>TodayHighlightBrush</td>
<td>Gets or sets the value that describes the today highlight color value.</td>
</tr>
<tr>
<td>TodayTextColor</td>
<td> TodayTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the today month cell text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>PreviousMonthTextColor</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>PreviousMonthBackgroundColor</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DisabledTextColor</td>
<td> DisabledDatesTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the disabled month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>DisabledBackgroundColor</td>
<td>DisabledDatesBackground</td>
<td>Gets or sets the background for the disabled month cells of the calendar month view.</td>
</tr>
<tr>
<td>WeekDayTextColor</td>
<td>WeekendDatesTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the weekend month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>WeekNumberStyle</td>
<td>Gets or sets the properties which allows to customize the week number view of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>HeaderView(From CalendarTextStyle)</td>
<td>Gets or sets properties which allows to customize the view header view of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>WeekendDays</td>
<td>Gets or sets the weekend days collection of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>SpecialDates</td>
<td>Gets or sets the special dates collection of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>SpecialDatesBackground</td>
<td>Gets or sets the background for the special month cells of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>WeekendDatesBackground</td>
<td>Gets or sets the background for the weekend month cells of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>Background</td>
<td>Gets or sets the background for the month cells of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>TrailingLeadingDatesBackground</td>
<td>Gets or sets the background for the trailing and leading month cells of the calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>TextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>TrailingLeadingDatesTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the trailing and leading month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>SpecialDatesTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the special month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>RangeTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the range in-between month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>SelectionTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the selection month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
</table>

## Xamarin YearViewSettings to .NET MAUI CalendarYearView
<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

<calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.YearViewSettings>
                <calendar:YearViewSettings HeaderBackground = "Red"/>
            </calendar:SfCalendar.YearViewSettings>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
calendar.YearViewSettings.HeaderBackground = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
         <calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.YearView>
                <calendar:CalendarYearView Background="Red"/>
            </calendar:SfCalendar.YearView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
calendar.YearView.Background = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar YearViewSettings</th>
<th>.NET MAUI SfCalendar CalendarYearView</th>
<th>Description</th>
</tr>
<tr>
<td>LayoutBackground</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>HeaderBackground</td>
<td>Background(From CalendarHeaderView)</td>
<td>Gets or sets the background of the header view in SfCalendar.</td>
</tr>
<tr>
<td>MonthLayoutBackground, MonthHeaderBackground</td>
<td>Background</td>
<td>Gets or sets the background for the year, decade and century cells of the calendar year, decade and century view.</td>
</tr>
<tr>
<td>YearHeaderTextColor</td>
<td>TextStyle(CalendarHeaderView)</td>
<td>Gets or sets the text style of the header text in SfCalendar.</td>
</tr>
<tr>
<td>LabelAlignment</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NA</td>
<td>MonthFormat</td>
<td>Gets or sets the format to customize the month text in calendar year view.</td>
</tr>
<tr>
<td>NA</td>
<td>DisabledDatesBackground</td>
<td>Gets or sets the background for the disabled year, decade and century cells of the calendar year, decade and century view.</td>
</tr>
<tr>
<td>NA</td>
<td>Background</td>
<td>Gets or sets the background for the year, decade and century cells of the calendar year, decade and century view.</td>
</tr>
<tr>
<td>NA</td>
<td>TodayBackground</td>
<td>Gets or sets the background for the today year, decade and century cell of the calendar year, decade and century view.</td>
</tr>
<tr>
<td>NA</td>
<td>LeadingDatesBackground</td>
<td>Gets or sets the background for the leading decade and century cells of the calendar decade and century view.</td>
</tr>
<tr>
<td>NA</td>
<td>TextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the year, decade and century cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>TodayTextStyle</td>
<td>Gets or sets the text style of the today year, decade and century cell text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>LeadingDatesTextStyle(From CalendarTextStyle)</td>
<td>Gets or sets the text style of the leading decade and century cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>DisabledDatesTextStyle</td>
<td>Gets or sets the text style of the disabled year, decade and century cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>RangeTextStyle</td>
<td>Gets or sets the text style of the range in-between year, decade and century cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>NA</td>
<td>SelectionTextStyle</td>
<td>Gets or sets the text style of the selection year, decade and century cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
</table>

## CalendarTextStyle
<table>
<tr>
<th>Xamarin SfCalendar </th>
<th>.NET MAUI SfCalendar CalendarTextStyle</th>
<th>Description</th>
</tr>
<tr>
<td>NA</td>
<td>TextColor</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>NA</td>
<td>FontSize</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>NA</td>
<td>FontFamily</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>NA</td>
<td>FontAttributes</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>
</table>

## WeekNumberStyle
<table>
<tr>
<th>Xamarin SfCalendar(NA)</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

<calendar:SfCalendar x:Name="clendar">
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
<calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView>
                    <calendar:CalendarMonthView.WeekNumberStyle>
                        <calendar:CalendarWeekNumberStyle>
                            <calendar:CalendarWeekNumberStyle.TextStyle>
                                <calendar:CalendarTextStyle TextColor="Red"/>
                            </calendar:CalendarWeekNumberStyle.TextStyle>
                        </calendar:CalendarWeekNumberStyle>
                    </calendar:CalendarMonthView.WeekNumberStyle>
                </calendar:CalendarMonthView>
            </calendar:SfCalendar.MonthView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
calendar.MonthView.WeekNumberStyle.TextStyle.TextColor = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar </th>
<th>.NET MAUI SfCalendar WeekNumberStyle</th>
<th>Description</th>
</tr>
<tr>
<td>NA</td>
<td>Background</td>
<td>Gets or sets the background of the week number view in SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>TextStyle</td>
<td>Gets or sets the text style of the week number text in SfCalendar.</td>
</tr>
</table>

## CalendarMonthHeaderView
<table>
<tr>
<th>Xamarin SfCalendar(NA)</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

<calendar:SfCalendar x:Name="clendar">
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
 <calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView>
                    <calendar:CalendarMonthView.HeaderView>
                        <calendar:CalendarMonthHeaderView Height="50" Background="Red">
                        </calendar:CalendarMonthHeaderView>
                    </calendar:CalendarMonthView.HeaderView>
                </calendar:CalendarMonthView>
            </calendar:SfCalendar.MonthView>
        </calendar:SfCalendar>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
calendar.MonthView.HeaderView.Height = 50;
calendar.MonthView.HeaderView.Background = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar </th>
<th>.NET MAUI SfCalendar CalendarMonthHeaderView</th>
<th>Description</th>
</tr>
<tr>
<td>NA</td>
<td>TextFormat</td>
<td>Gets or sets the format of the view header text in calendar month view.</td>
</tr>
<tr>
<td>NA</td>
<td>Height</td>
<td>Gets or sets the value to specify the height of view header view on SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>TextStyle</td>
<td>Gets or sets the text style of the view header text in SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>Background</td>
<td>Gets or sets the background of the view header view in SfCalendar.</td>
</tr>
</table>

## CalendarHeaderView
<table>
<tr>
<th>Xamarin SfCalendar(NA)</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

<calendar:SfCalendar x:Name="clendar">
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
<calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar x:Name="clendar">
            <calendar:SfCalendar.HeaderView>
                <calendar:CalendarHeaderView Background="Red" Height="50"/>
            </calendar:SfCalendar.HeaderView>
        </calendar:SfCalendar>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
…

SfCalendar calendar = new SfCalendar();
calendar.HeaderView.Height = 50;
calendar.HeaderView.Background = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar </th>
<th>.NET MAUI SfCalendar CalendarHeaderView</th>
<th>Description</th>
</tr>
<tr>
<td>NA</td>
<td>TextFormat</td>
<td>Gets or sets the format of the header text in calendar.</td>
</tr>
<tr>
<td>NA</td>
<td>Height</td>
<td>Gets or sets the value to specify the height of header view on SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>TextStyle</td>
<td>Gets or sets the text style of the header text in SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>Background</td>
<td>Gets or sets the background of the header view in SfCalendar.</td>
</tr>
<tr>
<td>ShowNavigationButtons</td>
<td>ShowNavigationArrows</td>
<td>Gets or sets a value indicating whether to displays the navigation arrows on the header view of the SfCalendar.</td>
</tr>
</table>

## Enums
<table>
<tr>
<th>Xamarin SfCalendar Enums</th>
<th>.NET MAUI SfCalendar Enums</th>
<th>Description</th>
</tr>
<tr>
<td>SelectionMode</td>
<td>CalendarSelectionMode</td>
<td>Defines the selection mode for the SfCalendar.</td>
</tr>
<tr>
<td>NavigationDirection</td>
<td>CalendarNavigationDirection</td>
<td>Defines the navigation direction for the SfCalendar.</td>
</tr>
<tr>
<td>ViewMode</td>
<td>CalendarView</td>
<td>Defines the view for the SfCalendar.</td>
</tr>
<tr>
<td>YearViewMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>TransitionMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>LabelAlignment</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>InlineViewMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DayLabelTextAlignment</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>DateTextAlignment</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>SelectionShape</td>
<td>CalendarSelectionShape</td>
<td>Defines the selection shape for the SfCalendar.</td>
</tr>
<tr>
<td>CellGridOptions</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>BlackoutDatesViewMode</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NA</td>
<td>RangeSelectionDirection</td>
<td>Defines the direction for the SfCalendar range selection.</td>
</tr>
<tr>
<td>NA</td>
<td>SelectedRangeStatus</td>
<td>Defines the Selected range element of Month and Year View panel.</td>
</tr>
<tr>
<td>NA</td>
<td>CalendarSelectionShape</td>
<td>Defines the selection shape for the SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>CalendarElement</td>
<td>Defines the calendar element of the SfCalendar.</td>
</tr>
</table>

## Events
<table>
<tr>
<th>Xamarin SfCalendar Events</th>
<th>.NET MAUI SfCalendar Events</th>
<th>Description</th>
</tr>
<tr>
<td>ViewModeChanged</td>
<td>ViewChanged</td>
<td>Occurs whenever the calendar view and visible dates changed on SfCalendar. </td>
</tr>
<tr>
<td>OnMonthChanged</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>OnInlineToggled</td>
<td>NA</td>
<td>NA</td>
</tr>
<tr>
<td>NA</td>
<td>SelectionChanged</td>
<td>Occurs after the selection changed on SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>Tapped</td>
<td>Occurs after the tap interaction on SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>DoubleTapped</td>
<td>Occurs after the double tapped interaction on SfCalendar.</td>
</tr>
<tr>
<td>NA</td>
<td>LongPressed</td>
<td>Occurs after the long press interaction on SfCalendar.</td>
</tr>
</table>