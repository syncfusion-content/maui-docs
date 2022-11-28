---
layout: post
title: Selections in MAUI Calendar widget | Syncfusion
description: Learn here all about Selections feature in Syncfusion MAUI Calendar (SfCalendar) widget and more.
platform: MAUI
control: SfCalendar
documentation: ug
---

# Selections in MAUI Calendar (SfCalendar)
The Selection mode is specified in the calendar property enumeration. Can select the dates by tap the cell in the calendar. `SfCalendar` provides three types mode such as `Single`, `Multiple` and `Range` Selection. The default [selectionMode](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/selectionMode.html) is Single that allows the user to select one date at a time.

>**NOTE** Can able to select the cells in the Year, Decade and Century views in the calendar only when the `allowViewNavigation` property is set to false.

## Single selection
The `Single` selection can be performed in the Calendar by setting the [CalendarSelectionMode](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarSelectionMode.html) property to `Single`. In this Selection, you can able to select a single date from the cell.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/single-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectionMode = CalendarSelectionMode.Single;

{% endhighlight %}
{% endtabs %}

![single-selection-maui-calendar](images/views/single-selection.png)

>**NOTE**
* In the Year, Decade and Century views can able to select the cells, only when the `allowViewNavigation` property is set to false.
* In this scenario, the `selection changed` callback will return the first date of the month, year, decade or century of the selected cell.
Eg: 
* In the year view, when the Dec month cell is selected then the selected date value will be 01-12-2022.
* In the decade view, when the (2022) year cell is selected then the selected date value will be 01-01-2022.
* In the century view, when the (2020-2029) decade cell is selected then the selected date value will be 01-01-2020.


## Multiple selection
The `Multiple` selection can be performed in the Calendar by setting the [CalendarSelectionMode](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarSelectionMode.html) property to `Multiple`. In this Selection, you can able to select a multiple dates from the cell. If you want to remove the selected cell by clicking the same cell again.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/multiple-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectionMode = CalendarSelectionMode.Multiple;

{% endhighlight %}
{% endtabs %}

![multiple-selection-maui-calendar](images/views/multiple-selection.png)


## Range selection
The `Range` selection can be performed in the Calendar by setting the [CalendarSelectionMode](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarSelectionMode.html) property to `Range`. In this Selection, you can able to select a range of dates from the cell by interacting the cell either tap or swipe action. Swipe action can only performed by setting the [enableSwipeSelection] property to `true` in the calendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/range-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectionMode = CalendarSelectionMode.Range;

{% endhighlight %}
{% endtabs %}

![range-selection-maui-calendar](images/views/range-selection.png)

>**NOTE**
* In the Year, Decade and Century views can able to select the cells, only when the `allowViewNavigation` property is set to false.
* In this scenario, the `selection changed` callback will return the first  and last date of the month, year, decade or century of the selected cell when the seletionmodeis set to `range `.
Eg: 
* In the year view, when the range is selected as Sep - Dec, then the range value will be 01-09-2022 to 31-12-2022.
* In the decade view, when the range is selected as 2022 - 2025, then the range value will be 01-01-2022 to 31-12-2025.
* In the century view, when the range is selected as 2020-2029 to 2030-2039, then the range value will be 01-01-2020 to 31-12-2039.

### Range Selection Direction
The Range Selection Direction is specified in the calendar property enumeration which is uesd to select the range based on the direction. The `RangeSelectionDirection` provides five types of direction such as `Default`, `Forward`, `Backward`, `Both` and `None`. The default [rangeSelectionDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/rangeSelectionDirection.html) is `Default` in the SfCalendar.

#### Range Selection Direction - Default
If the [RangeSelectionDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarRangeSelectionDirection.html) property to `Default` allows you to select the range of date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/range-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.RangeSelectionDirection = CalendarRangeSelectionDirection.Default;

{% endhighlight %}
{% endtabs %}

![default-range-selection-direction-maui-calendar](images/views/default-range-selection-direction.png)

#### Range Selection Direction - Forward
If the [RangeSelectionDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarRangeSelectionDirection.html) property to `Forward` allows you to select only the dates after the selected range start date and the dates before the range start date is considered as disabled date. The start date will not be changed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/range-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.RangeSelectionDirection = CalendarRangeSelectionDirection.Forward;

{% endhighlight %}
{% endtabs %}

![forward-range-selection-direction-maui-calendar](images/views/forward-range-selection-direction.png)

#### Range Selection Direction - Backward
If the [RangeSelectionDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarRangeSelectionDirection.html) property to `Backward` allows you to select only the dates before the selected range end date and the dates after the range end date is considered as disabled date. The end date will not be changed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/range-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.RangeSelectionDirection = CalendarRangeSelectionDirection.Backward;

{% endhighlight %}
{% endtabs %}

![backward-range-selection-direction-maui-calendar](images/views/backward-range-selection-direction.png)

#### Range Selection Direction - Both
If the [RangeSelectionDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarRangeSelectionDirection.html) property to `Both` allows you to extend the selection from the selected range. Then the tapped date is considered based on (if the date is nearby start date then start date is updated, else if the date is nearby end date then end date is updated, else if in-between the start and end date and both have same distance then the start date is updated.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/range-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.RangeSelectionDirection = CalendarRangeSelectionDirection.Both;

{% endhighlight %}
{% endtabs %}

![both-range-selection-direction-maui-calendar](images/views/both-range-selection-direction.png)

#### Range Selection Direction - None
If the [RangeSelectionDirection](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarRangeSelectionDirection.html) property to `None` allows you to select only the single range and the dates after the range end date and before start date is considered as disabled date. It will remain in the initial range.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/range-selection.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.RangeSelectionDirection = CalendarRangeSelectionDirection.None;

{% endhighlight %}
{% endtabs %}

![none-range-selection-direction-maui-calendar](images/views/none-range-selection-direction.png)

## Selection shape
The Selected date will render based on the [selectionShape](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/CalendarSelectionShape.html) property. The default selection shape is `Circle`. You can customize the selection shape either `Rectangle` or `Circle` of the SfCalendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/selection-shape.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectionShape = CalendarSelectionShape.Circle;

{% endhighlight %}
{% endtabs %}

![none-range-selection-direction-maui-calendar](images/views/none-range-selection-direction.png)