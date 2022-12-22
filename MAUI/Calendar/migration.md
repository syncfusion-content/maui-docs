---
layout: post
title: Migrate from Syncfusion Xamarin SfCalendar to .NET MAUI SfCalendar
description: Learn here all about Migrating from Syncfusion Xamarin calendar to Syncfusion .NET MAUI Calendar control.
platform: maui
control: SfCalendar
documentation: ug
---  

# Migrate from Xamarin.Forms SfCalendar to .NET MAUI SfCalendar 

To make the migration from the `Xamarin SfCalendar` to `.NET MAUI SfCalendar` easier, most of the APIs from the Xamarin SfCalendar were kept in the.NET MAUI SfCalendar. However, to maintain the consistency of API naming in the .NET MAUI SfCalendar, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>Syncfusion.SfCalendar.XForms</td>
<td>Syncfusion.Maui.SfCalendar</td></tr>
</table>

N> The selection-based `.NET MAUI SfCalendar` does not manage appointments like the `Xamarin SfCalendar` does. If you require appointment/events management use `.NET MAUI SfScheduler`.

## Initialize control

To initialize the control, import the calendar namespace and initialize `SfCalendar` as shown in the following code sample.

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
...

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
<th>Description</th>
</tr>

<tr>
<td>SelectionRange</td>
<td>CalendarDateRange</td>
<td>Represents a class which holds the start and end date of the range in SfCalendar.</td>
</tr>

<tr>
<td>MonthViewSettings</td>
<td>CalendarMonthView</td>
<td>Represents a class which is used to configure all the properties and styles of calendar month view.</td>
</tr>

<tr>
<td>YearViewSettings</td>
<td>CalendarYearView</td>
<td>Represents a class which is used to used to configure all the properties and styles of calendar year, decade and century view.</td>
</tr>

<tr>
<td>CalendarTappedEventArgs</td>
<td>CalendarTappedEventArgs</td>
<td>Represents a class which is used to hold the tap interaction event details and it occurs when the user clicks or touch on the calendar elements.</td>
</tr>

<tr>
<td>DayCellHoldingEventArgs</td>
<td>CalendarLongPressedEventArgs</td>
<td>Represents a class which is used to hold the long press interaction event details and it occurs when the user long press inside the calendar elements.</td>
</tr>

<tr>
<td>MonthChangedEventArgs</td>
<td>CalendarViewChangedEventArgs</td>
<td>Represents a class which is used to hold the view changed event details.</td>
</tr>

<tr>
<td>SelectionChangedEventArgs</td>
<td>CalendarSelectionChangedEventArgs</td>
<td>Represents a class which is used to hold the selection changed event details.</td>
</tr>

<tr>
<td>ViewModeChangedEventArgs</td>
<td>CalendarViewChangedEventArgs</td>
<td>Represents a class which is used to hold the view changed event details.</td>
</tr>

<tr>
<td>MonthLabelSettings</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CalendarInlineEvent</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthEventParameters</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineEventArgs</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineItemTappedEventArgs</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineToggledEventArgs</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthCell</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthCellLoadedEventArgs</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthChangingEventArgs</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>YearCell</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>YearCellLoadedEventArgs</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

</table>

## Properties 

### SfCalendar

The following code example, explains how to initialize the properties of the `Xamarin SfCalendar` and `.NET MAUI SfCalendar` class.

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
</tr>
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
...

SfCalendar calendar = new SfCalendar();
calendar.View = CalendarView.Month;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>

<tr>
<td>AgendaViewHeight</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>BlackoutDates </td>
<td>SelectableDayPredicate</td>
<td>Gets or sets the function to decide whether the cell is selectable or not in the calendar.</td>
</tr>

<tr>
<td>BlackoutDatesViewMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CustomDayLabels</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DataSource</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DisplayDate</td>
<td>DisplayDate</td>
<td>Gets or sets the display date to programmatically navigate the dates in the SfCalendar.</td>
</tr>

<tr>
<td>EnableDatesInPast</td>
<td>EnablePastDates</td>
<td>Gets or sets a value indicating whether the dates enabled or disabled before today date.</td>
</tr>

<tr>
<td>EnableSwiping</td>
<td>EnableSwipeSelection</td>
<td>Gets or sets a value indicating whether the swiping selection enabled for select the date range.</td>
</tr>

<tr>
<td>FirstDayofWeek</td>
<td>FirstDayOfWeek(From MonthView)</td>
<td>Gets or sets the day of week that used to change the default first day of week in SfCalendar.</td>
</tr>

<tr>
<td>HeaderHeight</td>
<td>Height(From HeaderView)</td>
<td>Gets or sets the value to specify the height of header view on SfCalendar.</td>
</tr>

<tr>
<td>HeaderView</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>HoldCommand</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineViewMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>Locale</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MaxDate</td>
<td>MaximumDate</td>
<td>Gets or sets the maximum display date to restrict the visible dates in the SfCalendar.</td>
</tr>

<tr>
<td>MaximumEventIndicatorCount</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MinDate</td>
<td>MinimumDate</td>
<td>Gets or sets the minimum display date to restrict the visible dates in the SfCalendar.</td>
</tr>

<tr>
<td>MonthChangedCommand</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthViewSettings</td>
<td>MonthView</td>
<td>Gets or sets the properties which allows to customize the calendar month view.</td>
</tr>

<tr>
<td>MoveToDate</td>
<td>DisplayDate</td>
<td>Gets or sets the display date to programmatically navigate the dates in the SfCalendar.</td>
</tr>

<tr>
<td>NavigateToMonthOnInActiveDatesSelection</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>NavigationArrowThickness</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>NavigationButtonHeight</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>NavigationButtonWidth</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>NavigationDirection</td>
<td>NavigationDirection</td>
<td>Gets or sets a value which determines the direction of the calendar scrolls.</td>
</tr>

<tr>
<td>NullableSelectedDate</td>
<td>SelectedDate</td>
<td>Gets or sets the selected date to select the particular date of the calendar.</td>
</tr>

<tr>
<td>NumberOfWeeksInView</td>
<td>NumberOfVisibleWeeks(From MonthView)</td>
<td>Gets or sets a value to display the number of weeks in calendar month view.</td>
</tr>

<tr>
<td>SelectedDate</td>
<td>SelectedDate</td>
<td>Gets or sets the selected date to select the particular date of the calendar.</td>
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
<td>SelectionChangedCommand</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>SelectionMode</td>
<td>SelectionMode</td>
<td>Gets or sets the selection mode of the calendar.</td>
</tr>

<tr>
<td>ShowHeader</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ShowInlineEvents</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ShowLeadingAndTrailingDays</td>
<td>ShowTrailingAndLeadingDates</td>
<td>Gets or sets a value indicating whether to displays the leading and trailing dates in the month, decade, century views of the SfCalendar.</td>
</tr>

<tr>
<td>ShowNavigationButtons</td>
<td>ShowNavigationArrows(From HeaderView)</td>
<td>Gets or sets a value indicating whether to displays the navigation arrows on the header view of the SfCalendar.</td>
</tr>

<tr>
<td>ShowYearView</td>
<td>AllowViewNavigation</td>
<td>Gets or sets a value indicating whether the navigation enabled on year, decade and century cell interaction.</td>
</tr>

<tr>
<td>TapCommand</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ToggleDaySelection</td>
<td>CanToggleDaySelection</td>
<td>Gets or sets a value indicating whether the selected date is deselectable through interaction on single selection mode of SfCalendar.</td>
</tr>

<tr>
<td>TransitionMode </td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ViewMode</td>
<td>View</td>
<td>Gets or sets the built-in views such as month, year, decade and century of the SfCalendar.</td>
</tr>

<tr>
<td>VisibleDates</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>YearViewMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>YearViewSettings</td>
<td>YearView</td>
<td>Gets or sets the properties which allows to customize the calendar year, decade and century views.</td>
</tr>

</table>

### MonthViewSettings

The following code example explains how to configure the month view settings in `Xamarin SfCalendar` and `.NET MAUI SfCalendar`.

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
        <calendar:SfCalendar x:Name="calendar">
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
        <calendar:SfCalendar x:Name="calendar">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView NumberOfVisibleWeeks="6"/>
            </calendar:SfCalendar.MonthView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
...

SfCalendar calendar = new SfCalendar();
calendar.MonthView.NumberOfVisibleWeeks = 6;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>

<tr>
<td>AgendaSelectedDateColor</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>BlackoutColor</td>
<td>DisabledDatesTextStyle</td>
<td>Gets or sets the text style of the disabled month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>BorderColor</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CellGridOptions</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CellTemplate</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CurrentMonthBackgroundColor</td>
<td>Background</td>
<td>Gets or sets the background for the month cells of the calendar month view.</td>
</tr>

<tr>
<td>CurrentMonthTextColor</td>
<td>TextColor(From TextStyle of MonthView)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>DateSelectionColor</td>
<td>SelectionBackground(From SfCalendar)</td>
<td>Gets or sets the value that describes the highlight of selection based on selection mode of the calendar.</td>
</tr>

<tr>
<td>DateTextAlignment</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DayCellFont</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DayCellFontFamily</td>
<td>FontFamily(From TextStyle, TodayTextStyle, TrailingLeadingDatesTextStyle, DisabledDatesTextStyle, WeekendDatesTextStyle, SpecialDatesTextStyle)</td>
<td>Gets or sets the font family of the text style.</td>
</tr>

<tr>
<td>DayFontSize</td>
<td>FontSize(From TextStyle, TodayTextStyle, TrailingLeadingDatesTextStyle, DisabledDatesTextStyle, WeekendDatesTextStyle, SpecialDatesTextStyle)</td>
<td>Gets or sets the font size of the text style.</td>
</tr>

<tr>
<td>DayFontAttributes</td>
<td>FontAttributes(From TextStyle, TodayTextStyle, TrailingLeadingDatesTextStyle, DisabledDatesTextStyle, WeekendDatesTextStyle, SpecialDatesTextStyle)</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>

<tr>
<td>DayHeaderBackgroundColor</td>
<td>Background(From HeaderView of MonthView)</td>
<td>Gets or sets the background of the view header view in SfCalendar.</td>
</tr>

<tr>
<td>DayHeaderFont</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DayHeaderFontAttributes</td>
<td>FontAttributes(From TextStyle of HeaderView in MonthView)</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>

<tr>
<td>DayHeaderFontFamily</td>
<td>FontFamily(From TextStyle of HeaderView in MonthView)</td>
<td>Gets or sets the font family of the text style.</td>
</tr>

<tr>
<td>DayHeaderFontSize</td>
<td>FontSize(From TextStyle of HeaderView in MonthView)</td>
<td>Gets or sets the font size of the text style.</td>
</tr>

<tr>
<td>DayHeaderTextColor</td>
<td>TextColor(From TextStyle of HeaderView in MonthView)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>DayHeaderFormat</td>
<td>TextFormat(From HeaderView of MonthView)</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>

<tr>
<td>DayHeight</td>
<td>Height(From HeaderView of MonthView)</td>
<td>Gets or sets the value to specify the height of view header view on SfCalendar.</td>
</tr>

<tr>
<td>DayLabelTextAlignment </td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DisabledBackgroundColor</td>
<td>DisabledDatesBackground</td>
<td>Gets or sets the background for the disabled month cells of the calendar month view.</td>
</tr>

<tr>
<td>DisabledTextColor</td>
<td>TextColor(From DisabledDatesTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>HeaderBackgroundColor</td>
<td>Background(From HeaderView of SfCalendar)</td>
<td>Gets or sets the background of the header view in SfCalendar.</td>
</tr>

<tr>
<td>HeaderFont</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>HeaderFontAttributes</td>
<td>FontAttributes(From TextStyle of HeaderView in SfCalendar)</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>

<tr>
<td>HeaderFontFamily</td>
<td>FontFamily(From TextStyle of HeaderView in SfCalendar)</td>
<td>Gets or sets the font family of the text style.</td>
</tr>

<tr>
<td>HeaderFontSize</td>
<td>FontSize(From TextStyle of HeaderView in SfCalendar)</td>
<td>Gets or sets the font size of the text style.</td>
</tr>

<tr>
<td>HeaderTextColor</td>
<td>TextColor(From TextStyle of HeaderView in SfCalendar)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>InlineBackgroundColor</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineItemTemplate</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineTextColor</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthLabelSettings</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>PreviousMonthBackgroundColor</td>
<td>TrailingLeadingDatesBackground</td>
<td>Gets or sets the background for the trailing and leading month cells of the calendar month view.</td>
</tr>

<tr>
<td>PreviousMonthTextColor</td>
<td>TextColor(From TrailingLeadingDatesTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>SelectedDayTextColor</td>
<td>TextColor(From SelectionTextStyle and RangeTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>SelectionRadius</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>SelectionShape</td>
<td>SelectionShape(From SfCalendar)</td>
<td>Gets or sets the selection shape of the SfCalendar.</td>
</tr>

<tr>
<td>TodayBorderColor</td>
<td>TodayHighlightBrush(From SfCalendar)</td>
<td>Gets or sets the value that describes the today highlight color value.</td>
</tr>

<tr>
<td>TodaySelectionBackgroundColor</td>
<td>SelectionBackground(From SfCalendar)</td>
<td>Gets or sets the value that describes the highlight of selection based on selection mode of the calendar.</td>
</tr>

<tr>
<td>TodaySelectionTextColor</td>
<td>TextColor(From SelectionTextStyle and RangeTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>TodayTextColor</td>
<td>TextColor(From TodayTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>WeekDayBackgroundColor</td>
<td>Background, TodayBackground, TrailingLeadingDatesBackground, DisabledDatesBackground, SpecialDatesBackground</td>
<td>Gets or sets the background for the week day month cells of the calendar month view.</td>
</tr>

<tr>
<td>WeekDayTextColor</td>
<td>TextColor(From TextStyle, TodayTextStyle, TrailingLeadingDatesTextStyle, DisabledDatesTextStyle, SpecialDatesTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>WeekEndBackgroundColor</td>
<td>WeekendDatesBackground</td>
<td>Gets or sets the background for the weekend month cells of the calendar month view.</td>
</tr>

<tr>
<td>WeekEndTextColor</td>
<td>TextColor(From WeekendDatesTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

</table>

### YearViewSettings

The following code example explains how to configure the year view settings in `Xamarin SfCalendar` and `.NET MAUI SfCalendar`.

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

<calendar:SfCalendar x:Name="calendar">
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
         <calendar:SfCalendar x:Name="calendar">
            <calendar:SfCalendar.YearView>
                <calendar:CalendarYearView Background="Red"/>
            </calendar:SfCalendar.YearView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
...

SfCalendar calendar = new SfCalendar();
calendar.YearView.Background = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>

<tr>
<td>LayoutBackground</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>LabelAlignment</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthHeaderBackground</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthHeaderTextColor</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DateTextColor</td>
<td>TextColor(From TextStyle, TodayTextStyle, LeadingDatesTextStyle, DisabledDatesTextStyle)</td>
<td>Gets or sets the text color of the text style.</td>
</tr>

<tr>
<td>HeaderBackground</td>
<td>Background(From HeaderView of SfCalendar)</td>
<td>Gets or sets the background of the header view in SfCalendar.</td>
</tr>

<tr>
<td>MonthLayoutBackground</td>
<td>Background</td>
<td>Gets or sets the background for the year, decade and century cells of the calendar year, decade and century view.</td>
</tr>

<tr>
<td>YearHeaderTextColor</td>
<td>TextStyle(From HeaderView of SfCalendar)</td>
<td>Gets or sets the text style of the header text in SfCalendar.</td>
</tr>

</table>

## Enums

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>

<tr>
<td>BlackoutDatesViewMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CellGridOptions</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DateTextAlignment</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>DayLabelTextAlignment</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineViewMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>LabelAlignment</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>NavigationDirection</td>
<td>CalendarNavigationDirection</td>
<td>Defines the navigation direction for the SfCalendar.</td>
</tr>

<tr>
<td>SelectionMode</td>
<td>CalendarSelectionMode</td>
<td>Defines the selection mode for the SfCalendar.</td>
</tr>

<tr>
<td>SelectionShape</td>
<td>CalendarSelectionShape</td>
<td>Defines the selection shape for the SfCalendar.</td>
</tr>

<tr>
<td>TransitionMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ViewMode</td>
<td>CalendarView</td>
<td>Defines the view for the SfCalendar.</td>
</tr>

<tr>
<td>YearViewMode</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

</table>

## Events

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>

<tr>
<td>InlineItemTapped</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>InlineToggled</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>MonthChanged</td>
<td>ViewChanged</td>
<td>Occurs whenever the calendar view and visible dates changed on SfCalendar. </td>
</tr>

<tr>
<td>MonthChanging</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>OnCalendarTapped</td>
<td>Tapped</td>
<td>Occurs after the tap interaction on SfCalendar.</td>
</tr>

<tr>
<td>OnDateCellHolding</td>
<td>LongPressed</td>
<td>Occurs after the long press interaction on SfCalendar.</td>
</tr>

<tr>
<td>OnHeaderLoaded</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>OnInlineLoaded</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>OnMonthCellLoaded</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>OnViewModeChanged</td>
<td>ViewChanged</td>
<td>Occurs whenever the calendar view and visible dates changed on SfCalendar. </td>
</tr>

<tr>
<td>OnYearCellLoaded</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>SelectionChanged</td>
<td>SelectionChanged</td>
<td>Occurs after the selection changed on SfCalendar.</td>
</tr>

</table>

## Methods

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>

<tr>
<td>AddDatesInPast</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>Backward</td>
<td>Backward</td>
<td>Move to previous view which displays previous view dates.</td>
</tr>

<tr>
<td>ClearSelection</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>CollapseInlineView</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ExpandInlineView</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>Forward</td>
<td>Forward</td>
<td>Move to next view which displays next view dates.</td>
</tr>

<tr>
<td>NavigateTo</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>Refresh</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>ResumeAppointmentUpdate</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

<tr>
<td>SuspendAppointmentUpdate</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>

</table>

## Upcoming Features

* Cell template support for month, year, decade and century views.
* Multi range selection support.