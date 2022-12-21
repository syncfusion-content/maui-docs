---
layout: post
title: About .NET MAUI Calendar control | Syncfusion
description: Learn here about the overview of Syncfusion .NET MAUI Calendar (SfCalendar) control, its basic features, and calendar functionalities.
platform: maui
control: SfCalendar
documentation: ug
---

# Overview of .NET MAUI Calendar (SfCalendar)

Syncfusion .NET MAUI Calendar (SfCalendar) is a calendar control that allows users to select a Single date, Multiple dates, or a Range of dates. It provides various view options such as a Month, Year, Decade, and Century, which allow users to quickly navigate to the desired date. It also supports minimum dates, maximum dates, enable past dates, and disabled dates to restrict the date selection.

## Key features

* **Multiple calendar view modes**: For selection and navigation, use Month, Year, Decade, and Century calendar views.

   {% multiple_column split:2 %}
   {% column %}
   ![Month view in .NET MAUI Calendar.](images/overview/maui-month-view.png)
   {% endcolumn}
   {% column %}
   ![Year view in .NET MAUI Calendar.](images/overview/maui-year-view.png)
   {% endcolumn}
   {% column %}
   ![Decade view in .NET MAUI Calendar.](images/overview/maui-decade-view.png)
   {% endcolumn}
   {% column %}
   ![Century view in .NET MAUI Calendar.](images/overview/maui-century-view.png)
   {% endcolumn}
   {% endmultiple_column %}

* **Quick navigation**: You can easily navigate to the desired date using different calendar views in the `SfCalendar`.

* **Enable and disable built-in view switching**: Restricts or enables navigation to different calendar views using interaction.

   % multiple_column split:2 %}
   {% column %}
   ![Month view single selection in .NET MAUI Calendar.](images/overview/maui-month-view-single-selection.png)
   {% endcolumn}
   {% column %}
   ![Year view single selection in .NET MAUI Calendar.](images/overview/maui-year-view-single-selection.png)
   {% endcolumn}
   {% column %}
   ![Decade view single selection in .NET MAUI Calendar.](images/overview/maui-decade-view-single-selection.png)
   {% endcolumn}
   {% column %}
   ![Century view single selection in .NET MAUI Calendar.](images/overview/maui-century-view-single-selection.png)
   {% endcolumn}
   {% endmultiple_column %}

* **Date selection**: Date selection allows you to select the Single date, Multiple dates or a Range of dates by interaction or programmatic selection.

   % multiple_column split:2 %}
   {% column %}
   ![Single selection in .NET MAUI Calendar.](images/overview/maui-month-view-single-selection.png)
   {% endcolumn}
   {% column %}
   ![Multiple selection in .NET MAUI Calendar.](images/overview/maui-multiple-selection.png)
   {% endcolumn}
   {% column %}
   ![Range selection in .NET MAUI Calendar.](images/overview/maui-range-selection.png)
   {% endcolumn}
   {% endmultiple_column %}

* **Limit date selection**: Restricts interaction and navigation beyond the specified minimum and maximum dates.

   ![Limit date selection in .NET MAUI Calendar.](images/overview/maui-min-max-date.png)

* **Change first day of week**: You can customize the starting day of the week. The default first day of the week is Sunday.

   ![First day of week in .NET MAUI Calendar.](images/overview/maui-first-day-of-week.png)

* **Selectable Day Predicate**: Disable the interaction for calendar view dates and easily prevent the selection of weekends by disabling them.

   ![Selectable day predicate in .NET MAUI Calendar.](images/overview/maui-selectable-day-predicate.png)

* **Highlight weekends and special dates**: In MAUI Calendar, you can highlight special dates and weekend dates in the month view using different background colors and text styles.

   {% multiple_column split:2 %}
   {% column %}
   ![Weekend days highlighted in .NET MAUI Calendar.](images/overview/maui-weekends-dates.png)
   {% endcolumn %}

   {% column %}
   ![Special dates highlighted in .NET MAUI Calendar.](images/overview/maui-special-dates.png)
   {% endcolumn %}
   {% endmultiple_column %}

* **Right to left (RTL)**: The Calendars' text direction can be changed by using the `Right-to-left` property. Enables the user to work with RTL languages, such as Hebrew and Arabic.

   ![Right-to-left rendering in .NET MAUI Calendar.](images/overview/maui-rtl.png)

* **Globalization**: Displays the current date and time based on the globalized date and time formats.

   ![Globalization for month view in .NET MAUI Calendar.](images/overview/maui-month-view-globalization.png)
