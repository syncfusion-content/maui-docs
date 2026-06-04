---
layout: post
title: About .NET MAUI Date Picker control | Syncfusion
description: Learn about the overview of Syncfusion .NET MAUI Date Picker (SfDatePicker) control, its basic features, and date picker functionalities.
platform: maui
control: SfDatePicker
documentation: ug
---

> **Notice**: After **Volume 3 2025 (Mid of Sep 2025)**, feature enhancements for this control will no longer be available in the Syncfusion® package. Please switch to the **Syncfusion® Toolkit for .NET MAUI** for continued support. For a smooth transition refer this [migration document](https://help.syncfusion.com/maui-toolkit/migration).

# Overview of .NET MAUI Date Picker (SfDatePicker)

Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control allows you to select a date and visualize its items inside a popup or a drop-down UI element. The Date Picker also enables you to set date ranges and formats and customize its dialog appearance by configuring its header, footer, and more.

## Business use cases

- Booking and reservation applications that require **date selection with validation and range restrictions**.  
- Form-based applications that need **user-friendly date input for registration, scheduling, or data entry**.  
- Business applications that use **date-based filtering and reporting workflows**.  
- Mobile and desktop apps that require **consistent and customizable date selection UI across platforms**. 

## Key features

- **Header view support** allows displaying and customizing header text to provide context in the date picker dialog.  

   ![Header view in .NET MAUI Date picker.](images/overview/maui-header-view.png)

- **Column header view support** allows showing predefined or custom column headers for better readability of date elements. 

   ![Column header view in .NET MAUI Date picker.](images/overview/maui-column-header-view.png)

- **Footer view support** provides OK and Cancel buttons with customizable text and appearance.  

   ![Footer view in .NET MAUI Date picker.](images/overview/maui-date-picker-footer-view.png)

- **Selection view support** allows displaying the currently selected date in a dedicated customizable section.

   ![Selection view in .NET MAUI Date picker.](images/overview/maui-selection-view.png)

- **Date format support** allows representing selected dates using predefined string formats.  

   ![.NET MAUI Date Picker with format yyyy_MM_dd.](images/overview/maui-date-picker-format_yyyy_MM_dd.png)

- **Picker mode options** allow displaying the picker in popup or dialog mode with flexible positioning. 

   ![Dialog mode in .NET MAUI Date picker.](images/overview/maui-date-picker-dialog-mode.gif)

- **Date restriction support** allows limiting selection within minimum and maximum date ranges.  

   ![Minimum date in .NET MAUI Date picker.](images/overview/maui-date-picker-minimum-date.png)

   ![Maximum date in .NET MAUI Date picker.](images/overview/maui-date-picker-maximum-date.png)

- **Interval support** allows configuring values for days, months, and years using defined intervals.

   ![Intervals in .NET MAUI Date picker.](images/overview/maui-date-picker-intervals.gif)

- **User interaction support** allows selecting dates through intuitive tap and scroll gestures.

   ![Picker interactions in .NET MAUI Date picker.](images/overview/maui-date-picker-interactions.gif)   

## Globalization

The following table summarizes the globalization support available in the [SfDatePicker](https://www.syncfusion.com/maui-controls/maui-datepicker) control.

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
<td><a href="/maui/datepicker/overview">DatePicker</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[DateTimePicker](https://help.syncfusion.com/maui/datetimepicker/overview)** for selecting both date and time values.  
- **[Calendar](https://help.syncfusion.com/maui/calendar/overview)** for navigating and selecting dates using full calendar views.  
- **[DataForm](https://help.syncfusion.com/maui/dataform/overview)** for integrating date picker inputs within forms.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/datepicker/getting-started) - step-by-step guide to begin using the Date Picker control.  
- [Formatting](https://help.syncfusion.com/maui/datepicker/formatting) - configure how date values are displayed.  
- [Customization](https://help.syncfusion.com/maui/datepicker/customizations) - modify appearance and interaction behavior. 
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) - explore interactive demos and ready‑made UI examples.

## Learnings

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
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore Blogs</h3>
    <div class="form-description">
      Read insights, tutorials, and developer journeys.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore KB's</h3>
    <div class="form-description">
      Find quick solutions and step‑by‑step guidance.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/maui-controls/maui-datepicker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/date-picker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
