---
layout: post
title: About .NET MAUI Calendar control | Syncfusion
description: Learn here the overview of Syncfusion .NET MAUI Calendar(SfCalendar) control, its basic features and functionalities of calendar.
platform: MAUI
control: SfCalendar
documentation: ug
---

# Overview of .NET MAUI Calendar (SfCalendar)

The Syncfusion .NET MAUI Calendar (SfCalendar) is a lightweight calendar control that allows user to easily select a single, multiple and a range of dates. It provides month, year, decade, and century view options to quickly navigate to the desired date. It supports minimum, maximum, enable past dates and disabled dates to restrict date selection.


## Key features

* **Multiple calendar views**: Display month, year, decade, and century views that allows user to easily select and navigate between built-in views. Supports programmatic navigation.

   ![Multiple Calendar Views](images/overview/calendar-views.png)

* **Quick navigation**: Navigate back and forth the date-range views and between different view modes.

* **Allow view Navigation**: Allows you to navigate through tap interaction on the cell or header when it is enabled. Restrict users from navigating to different calendar views and allows you to select the dates in the year, decade and century view when this property is not enabled.

	![Range selection Calendar](images/overview/range-selection.png)

* **Enable Past Dates**: Indicates whether the dates are enabled or disabled before the today date. If this property is disabled, you cannot able to select the dates before the today date and the dates before the today date are considered as disabled dates.

   ![Enable Past date Calendar](images/overview/enable-pastDates.png)

* **Date selection**: The Selection mode is specified in the calendar property enumeration, allows you to select single, multiple, and a range of dates through interaction. It also supports programmatic selection.
   
   ![Date selection Calendar](images/overview/selection_mode.png)

* **Limit the date selection range**: By setting the minimum and maximum days, you can only able to select the date within the minimum and maximum number of days(span of days).

   ![Limit the date selection range Calendar](images/overview/min_max_date.png)

* **Change first day of week**: Can customize the first day of the week as needed. The default first day of the week is Sunday.

* **Selectable Day Predicate**: This property decides whether the cell is selectable or not in calendar and if you want to disable the particular selected date in a calendar. Easily prevent the selection of weekends by disabling them.

   ![Selectable day predicate Calendar](images/overview/selectable-dates.png)

* **Highlight weekends and special dates**: Can highlight any special dates or every weekend in a month using different background color and textstyles in MAUI Calendar.

   ![Highlight weekends and special dates ](images/overview/highlight-dates.png)

* **Right to left (RTL)** - Use the Right-to-left property to change the text direction in the Calendar. Supports users for working in RTL languages like Hebrew and Arabic.

   ![Right to left Date Range Picker](images/overview/right-to-left.png)

* **Globalization** - Displays the current date and time based on the globalized date and time formats.

   ![Globalization Date Range Picker](images/overview/localization.png)
