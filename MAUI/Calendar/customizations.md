---
layout: post
title: Customizations in MAUI Calendar widget | Syncfusion
description: Learn here all about Customizations features of Syncfusion .NET MAUI Calendar (SfCalendar) widget and more. 
platform: maui
control: SfCalendar
documentation: ug
---

# Customizations in MAUI Calendar (SfCalendar)
Each cell of the Month, Year, Decade and Century can be customized in MAUI Calendar (SfCalendar).

## Month cell customization
You can customize the calendar month view cell by using the `MonthView` property of `SfCalendar`.

*    **Month dates** – You can customize the month dates text style and background of the `Calendar` by using the `TextStyle` and `Background` properties of `MonthView`.

*    **Today date** – You can customize the today date text style and background of the `Calendar` by using the `TodayTextStyle` and `TodayBackground` properties of `MonthView`.

*    **Trailing and Leading dates** – You can hide the trailing and leading dates by using the `ShowTrailingAndLeadingDates` property in the `CalendarMonthView` class. You can also customize the trailing and leading dates text style and background of the `Calendar` by using the `TrailingLeadingDatesTextStyle` and `TrailingLeadingDatesBackground` properties of `MonthView`.

*    **Disabled dates** – You can disable the date by using the MinimumDate, MaximumDate, EnablePastDates and SelectableDayPredicate callback. The date before `MinimumDate` is said to disabled date, the date after the `MaximumDate` is said to disabled date, if you want disable the date before today date by using the `EnablePastDates` and if you want to disable any particular date by using `SelectableDayPredicate` property. You can also customize the disabled dates text style and background of the `Calendar` by using the `DisabledDatesTextStyle` and `DisabledDatesBackground` properties of `MonthView`.

*    **Special Dates** – You can add special dates to the `DateRangePicker` by using the `SpecialDates` property and you can also customize the special dates text style and background of the `Calendar` by using the `SpecialDatesTextStyle` and `SpecialDatesBackground` properties of `MonthView`.

*    **Weekend Dates** – You can customize the weekend dates text style and background of the `Calendar` by using the `WeekendDatesTextStyle` and `WeekendDatesBackground` properties of `MonthView`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month"
                        Background="PaleGreen">
            <Calendar:SfCalendar.MonthView>
                <Calendar:CalendarMonthView TodayBackground="Pink" DisabledDatesBackground="Grey" SpecialDatesBackground="Purple" WeekendDatesBackground="Red"/>
            </Calendar:SfCalendar.MonthView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

        CalendarTextStyle textStyle = new CalendarTextStyle()
        {
            TextColor = Colors.Black,
            FontSize = 12,
        };

        this.Calendar.MinimumDate = DateTime.Now.AddDays(-15);
        this.Calendar.MaximumDate = DateTime.Now.AddDays(20);
        this.Calendar.EnablePastDates = true;
        this.Calendar.SelectableDayPredicate = (date) =>
        {
            if (date.Date == DateTime.Now.AddDays(3).Date || date.Date == DateTime.Now.AddDays(6).Date || date.Date == DateTime.Now.AddDays(-3).Date || date.Date == DateTime.Now.AddDays(-6).Date)
            {
                return false;
            }

            return true;
        };

        this.Calendar.MonthView.SpecialDates = new List<DateTime>
        {
            DateTime.Now.AddDays(2),
            DateTime.Now.AddDays(-2),
        };

        this.Calendar.MonthView.WeekendDays = new List<DayOfWeek>
        {
            DayOfWeek.Sunday,
            DayOfWeek.Saturday,
        };

        this.Calendar.Background = Colors.PaleGreen;
        this.Calendar.MonthView.TextStyle = textStyle;
        this.Calendar.MonthView.TodayBackground = Colors.Pink;
        this.Calendar.MonthView.TodayTextStyle = textStyle;
        this.Calendar.ShowTrailingAndLeadingDates = true;
        this.Calendar.MonthView.TrailingLeadingDatesBackground = Colors.Green;
        this.Calendar.MonthView.TrailingLeadingDatesTextStyle = textStyle;
        this.Calendar.MonthView.DisabledDatesBackground = Colors.Grey;
        this.Calendar.MonthView.DisabledDatesTextStyle = textStyle;
        this.Calendar.MonthView.SpecialDatesBackground = Colors.Purple;
        this.Calendar.MonthView.SpecialDatesTextStyle = textStyle;
        this.Calendar.MonthView.WeekendDatesBackground = Colors.Red;
        this.Calendar.MonthView.WeekendDatesTextStyle = textStyle;

{% endhighlight %}
{% endtabs %}

![monthview-customization-in-maui-calendar](images/customization/monthview-customization-in-maui-calendar.png)

>**NOTE**
* The Background color and text style will be applied based on the following order: selectableDayPredicate dates, special dates, disable dates, today date, trailingLeading dates, and weekend dates.

## Month View Header format
You can customize the month format of the `Calendar` by using the `TextFormat` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      View="Month">
            <Calendar:SfCalendar.MonthView>
                <Calendar:CalendarMonthView>
                    <Calendar:CalendarMonthView.HeaderView>
                        <Calendar:CalendarMonthHeaderView TextFormat="ddd" />
                    </Calendar:CalendarMonthView.HeaderView>
                </Calendar:CalendarMonthView>
            </Calendar:SfCalendar.MonthView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MonthView.HeaderView = new CalendarMonthHeaderView()
{
    TextFormat = "ddd",
};

{% endhighlight %}
{% endtabs %}

![view-header-text-format-in-maui-calendar](images/customization/view-header-text-format-in-maui-calendar.png)

## Year cell customization
You can customize the calendar `year`, `decade`, and `century` view by using the `YearView` property of `SfCalendar`.

*   **Year cell dates** – You can customize the year view date's text style and background of the `Calendar` by using the `TextStyle` and `Background` properties of `YearView`.

*    **Disabled dates** – You can disable the date by using the MinimumDate, MaximumDate, EnablePastDates and SelectableDayPredicate callback. The date before `MinimumDate` is said to disabled date, the date after the `MaximumDate` is said to disabled date, if you want disable the date before today date by using the `EnablePastDates` and if you want to disable any particular date by using `SelectableDayPredicate` property. You can also customize the disabled dates text style and background of the `Calendar` by using the `DisabledDatesTextStyle` and `DisabledDatesBackground` properties of `YearView`.

*    **Leading dates** – You can hide the Leading date by using the `ShowTrailingAndLeadingDates` property in the `SfCalendar` class. You can also customize the Leading dates text style and background of the `Calendar` by using the `LeadingDatesTextStyle` and `LeadingDatesBackground` properties of `YearView`. It is not applicable for Year view.

*    **Today date** – You can customize the today date text style and background of the `Calendar` by using the `TodayTextStyle` and `TodayBackground` properties of `YearView`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month"
                        Background="PaleGreen">
            <Calendar:SfCalendar.YearView>
                <Calendar:CalendarYearView TodayBackground="Pink" DisabledDatesBackground="Grey" LeadingDatesBackground="Green" />
            </Calendar:SfCalendar.YearView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

        CalendarTextStyle textStyle = new CalendarTextStyle()
        {
            TextColor = Colors.Black,
            FontSize = 12,
        };

        this.Calendar.View = CalendarView.Decade;
        this.Calendar.MinimumDate = DateTime.Now.AddYears(-1);
        this.Calendar.MaximumDate = DateTime.Now.AddYears(8);
        this.Calendar.EnablePastDates = false;
        this.Calendar.SelectableDayPredicate = (date) =>
        {
            if (date.Year == DateTime.Now.AddYears(3).Year)
            {
                return false;
            }
            return true;
        };

        this.Calendar.Background = Colors.PaleGreen;
        this.Calendar.YearView.TextStyle = textStyle;
        this.Calendar.YearView.TodayBackground = Colors.Pink;
        this.Calendar.YearView.TodayTextStyle = textStyle;
        this.Calendar.ShowTrailingAndLeadingDates = true;
        this.Calendar.YearView.LeadingDatesBackground = Colors.Green;
        this.Calendar.YearView.LeadingDatesTextStyle = textStyle;
        this.Calendar.YearView.DisabledDatesBackground = Colors.Grey;
        this.Calendar.YearView.DisabledDatesTextStyle = textStyle;

{% endhighlight %}
{% endtabs %}

![decadeview-customization-in-maui-calendar](images/customization/decadeview-customization-in-maui-calendar.png)

>**NOTE**
* The Background color and text style will be applied based on the following order: selectableDayPredicate dates, disable dates, today date and leading Dates.

## Year View Text format
You can customize the month format of the `Calendar` by using the `MonthFormat` property in `YearView` class.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      View="Year">
            <Calendar:SfCalendar.YearView>
                <Calendar:CalendarYearView MonthFormat="MMMM" />
            </Calendar:SfCalendar.YearView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.YearView = new CalendarYearView()
{
    MonthFormat = "MMMM",
};

{% endhighlight %}
{% endtabs %}

![yearview-text-format-in-maui-calendar](images/customization/yearview-text-format-in-maui-calendar.png)

## Selection cell customization

You can customize the Selection cell background and textStyle in Month, Year, Decade and Century view by using the `SfCalendar`.

*    **Selection Background** - The Selected date background can be customized by using the `SelectionBackground` property in `SfCalendar`. This property is used in `Single`, `Multiple` and in between selected date of `Range` selection.

*    **Selection TextStyle** - The Selected date textstyle can be customized by using the `SelectionTextStyle` property in `MonthView`. This property is used in `Single`, `Multiple` and start and end date of the selected date range of `Range` selection.

*    **Start Range Selection Background** - The Start range date background can be customized by using the `StartRangeSelectionBackground` property in `SfCalendar`. This property is used in Start range selected date of `Range` selection.

*    **End Range Selection Background** -  The End range date background can be customized by using the `EndRangeSelectionBackground` property in `SfCalendar`. This property is used in End range selected date of `Range` selection.

*    **Range TextStyle** – The in between selected date range textstyle can be customized by using the `RangeTextStyle` property in `MonthView`. This property is used in between selected date range of `Range` selection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                      View="Month"
                      Background="PaleGreen"
                      StartRangeSelectionBackground="Purple" EndRangeSelectionBackground="Purple" SelectionBackground="Pink">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

        CalendarTextStyle textStyle = new CalendarTextStyle()
        {
            TextColor = Colors.Black,
            FontSize = 12,
        };

        this.Calendar.SelectedDateRange = new CalendarDateRange(DateTime.Now.AddDays(5).Date, DateTime.Now.AddDays(20).Date);
        this.Calendar.View = CalendarView.Month;
        this.Calendar.SelectionMode = CalendarSelectionMode.Range;
        this.Calendar.StartRangeSelectionBackground = Colors.Purple;
        this.Calendar.EndRangeSelectionBackground = Colors.Purple;
        this.Calendar.SelectionBackground = Colors.Pink;
        this.Calendar.MonthView.SelectionTextStyle = textStyle;
        this.Calendar.MonthView.RangeTextStyle = textStyle;

{% endhighlight %}
{% endtabs %}

![monthview-selection-customization-in-maui-calendar](images/customization/monthview-selection-customization-in-maui-calendar.png)