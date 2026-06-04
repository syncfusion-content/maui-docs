---
layout: post
title: About .NET MAUI Calendar control | Syncfusion
description: Learn here about the overview of Syncfusion .NET MAUI Calendar (SfCalendar) control, its basic features, and calendar functionalities.
platform: maui
control: SfCalendar
documentation: ug
---

> **Notice**: After **Volume 1 2025 (Mid of March 2025)**, feature enhancements for this control will no longer be available in the Syncfusion<sup>&reg;</sup> package. Please switch to the **Syncfusion Toolkit for .NET MAUI** for continued support. For a smooth transition refer this [migration document](https://help.syncfusion.com/maui-toolkit/migration).

# Overview of .NET MAUI Calendar (SfCalendar)

Syncfusion<sup>&reg;</sup> .NET MAUI Calendar (SfCalendar) is a calendar control that allows users to select a Single date, Multiple dates, or a Range of dates. It provides various view options such as a Month, Year, Decade, and Century, which allow users to quickly navigate to the desired date. It also supports minimum dates, maximum dates, enable past dates, and disabled dates to restrict the date selection.

## Business use cases

- Booking and reservation applications that require date selection and scheduling workflows.  
- Business applications that depend on date-based filtering and data analysis.  
- Event management systems that require navigation across months, years, and custom date ranges.  
- Form-based applications that need single, multiple, or range date selection inputs.  

## Key features

- **Multiple calendar view modes** allow switching between Month, Year, Decade, and Century views for easy navigation.

   ![Multiple views in .NET MAUI Calendar.](images/overview/maui-multiple-views.png)

- **Quick navigation** enables moving across different date levels efficiently using hierarchical calendar views.

- **Enable and disable built-in view switching** allows enabling or restricting navigation between calendar views based on interaction.

   ![Single selection in .NET MAUI Calendar.](images/overview/maui-single-selection.png)

- **Date selection** support selecting single, multiple, range, or multiple range of dates programmatically or through user interaction.

   ![Selection Modes in .NET MAUI Calendar.](images/overview/maui-selection-modes.png)

- **Limit date selection** allows limiting selectable dates using minimum and maximum range values.

   ![Limit date selection in .NET MAUI Calendar.](images/overview/maui-min-max-date.png)

- **Change first day of week** allows setting the starting day of the week based on regional or application requirements.

   ![First day of week in .NET MAUI Calendar.](images/overview/maui-first-day-of-week.png)

- **Selectable day predicate** allows disabling specific dates such as weekends or holidays to control user interaction.

   ![Selectable day predicate in .NET MAUI Calendar.](images/overview/maui-selectable-day-predicate.png)

- **Highlight weekends and special dates** enables highlighting weekends and special dates using custom styles and colors.

   ![Weekend days highlighted in .NET MAUI Calendar.](images/overview/maui-weekends-dates.png)

   ![Special dates highlighted in .NET MAUI Calendar.](images/overview/maui-special-dates.png)

- **Right to left (RTL)** allows adapting the layout for RTL languages such as Arabic and Hebrew.

   ![Right-to-left rendering in .NET MAUI Calendar.](images/overview/maui-rtl.png)

- **Globalization** ensure that date and time values are displayed based on regional and cultural settings.

   ![Globalization for month view in .NET MAUI Calendar.](images/overview/maui-month-view-globalization.png)

## Globalization

The following table summarizes the globalization support available in this control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support 

<table>
<tr>
<th align="center">Control</th>
<th align="center">Localization</th>
<th align="center">RTL</th>
<th align="center">Time zone</th>
<th align="center">Screen reader</th>
<th align="center">Keyboard navigation</th>
</tr>
<tr>
<td><a href="/maui/calendar/overview">Calendar</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr>
</table>

## Related controls

- [DatePicker](https://help.syncfusion.com/maui/datepicker/overview) for selecting and handling single date input scenarios.  
- [Scheduler](https://help.syncfusion.com/maui/scheduler/overview) for managing appointments and scheduling workflows.  
- [DateTimePicker](https://help.syncfusion.com/maui/datetimepicker/overview) for selecting combined date and time values.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/calendar/getting-started) shows how to begin using the Calendar control step by step.  
- [Selection modes](https://help.syncfusion.com/maui/calendar/selections) explain different date selection behaviors.  
- [Customization](https://help.syncfusion.com/maui/calendar/customizations) shows how to modify appearance and interaction settings.  

## Resources

<style>
.form-card {
   flex: 0 0 calc(33.33% - 14px);
   border: 1px solid #ddd;
   border-radius: 12px;
   overflow: hidden;
   background: white;
   box-sizing: border-box;
   transition: 0.3s ease;
}
.form-card:hover {
   text-decoration: none;
   transform: translateY(-4px);
   box-shadow: 0 8px 24px rgba(0,0,0,0.08);
}
.form-image {
   width: 100%;
   height: 100%;
   object-fit: cover;
   display: block;
   cursor: pointer;
   transition: 0.3s ease;
}
.form-image:hover {
   transform: scale(1.02);
}
.form-content {
   padding: 16px;
}
.form-title {
   margin-top: 0px;
   margin: 0 0 10px;
   font-size: 20px;
   font-weight: 600;
   color: #000000;
}
.form-link {
   color: #0078D4;
   text-decoration: none;
}
.form-description {
   margin-top: 14px;
   font-size: 13px;
   color: #000000;
   line-height: 1.6;
}
.source-icon {
   display: inline-flex;
   align-items: center;
   justify-content: center;
   width: 36px;
   height: 36px;
   border-radius: 50%;
   background: #f3f4f6;
   color: #0078D4;
   text-decoration: none;
   transition: 0.3s ease;
   margin-top: 12px;
}
.source-icon:hover {
   background: #0078D4;
   color: white;
}
/* Popup Modal */
#imageModal {
   display: none;
   position: fixed;
   z-index: 9999;
   left: 0;
   top: 0;
   width: 100%;
   height: 100%;
   background: rgba(0,0,0,0.85);
   justify-content: center;
   align-items: center;
   padding: 20px;
   box-sizing: border-box;
}
#popupImage {
   max-width: 90%;
   max-height: 90%;
   border-radius: 14px;
   box-shadow: 0 10px 30px rgba(0,0,0,0.4);
   animation: zoomIn 0.25s ease;
}
.close-popup {
   position: absolute;
   top: 20px;
   right: 30px;
   color: white;
   font-size: 42px;
   cursor: pointer;
   font-weight: bold;
}
@key frames zoomIn {
   from {
       transform: scale(0.9);
       opacity: 0;
   }
   to {
       transform: scale(1);
       opacity: 1;
   }
}
@media(max-width:900px) {
   .form-card {
       flex: 0 0 calc(50% - 10px);
   }
}
@media(max-width:600px) {
   .form-card {
       flex: 0 0 100%;
   }
}
</style>

<div style="display:flex; flex-wrap:wrap; gap:20px; margin-top:20px;">
<!-- Card 1 -->
<a href="https://www.syncfusion.com/maui-controls/maui-calendar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Calendar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/calendar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore KB's</h3>
    <div class="form-description">
      Find quick solutions and step‑by‑step guidance.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore Blogs</h3>
    <div class="form-description">
      Read insights, tutorials, and developer journeys.
    </div>
  </div>
</a>