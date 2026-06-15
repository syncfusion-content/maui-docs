---
layout: post
title: About .NET MAUI Time Picker control | Syncfusion
description: Learn here about the overview of Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control, its basic features, and time picker functionalities.
platform: maui
control: SfTimePicker
documentation: ug
---

# Overview of .NET MAUI Time Picker (SfTimePicker)

Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control allows you to select the time and visualize its items inside a popup or a drop-down UI element. The Time Picker also enables you to set time formats and customize its dialog appearance by configuring its header, footer, and more.

## Business use cases

- Scheduling applications that require time selection for appointments, meetings, or reminders.  
- Booking systems that allow users to choose available time slots efficiently.  
- Form-based applications that collect time inputs such as start and end times.  
- Business applications that require customizable time selection UI with validation and formatting. 

## Key features

- **Header view** allows adding and customizing header text for contextual information.

   ![Header view in .NET MAUI Time picker.](images/overview/maui-time-picker-header-view.png)

- **Column header** allows displaying and customizing labels for hours, minutes, and seconds.

   ![Column header view in .NET MAUI Time picker.](images/overview/maui-time-picker-column-header-view.png)

- **Footer view** allows providing confirmation actions such as OK and Cancel with customizable appearance. 

   ![Footer view in .NET MAUI Time picker.](images/overview/maui-time-picker-footer-view.png)

- **Selection view** allows displaying the selected time clearly with configurable UI.  

   ![Selection view in .NET MAUI Time picker.](images/overview/maui-time-picker-selection-view.png)

- **Time format** allows presenting values in predefined formats for better readability.  

   ![.NET MAUI Time Picker with format h_mm_ss_tt.](images/overview/maui-time-picker-format_h_mm_ss_tt.png)

- **Picker mode** allows displaying the control in popup or dialog modes with flexible positioning. 

   ![Picker mode in .NET MAUI Time picker.](images/overview/maui-time-picker-mode.gif)

- **Interval** allows defining custom intervals for hours, minutes, and seconds.

   ![Intervals in .NET MAUI Time picker.](images/overview/maui-time-picker-intervals.gif)

- **User interaction** allows selecting time values through tap and scroll gestures. 

   ![Interactions in .NET MAUI Time picker.](images/overview/maui-time-picker-interactions.gif)
 

## Globalization

The following table summarizes the globalization support available in this control.

<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/full-support.svg" alt="full-support" width="16">
    <span>Full Support</span>
</div>

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
<td><a href="/maui/timepicker/overview">Time Picker</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [Date Picker](https://help.syncfusion.com/maui/datepicker/overview) for selecting date values in applications.  
- [DateTime Picker](https://help.syncfusion.com/maui/datetimepicker/overview) for selecting combined date and time values.  
- [Picker](https://help.syncfusion.com/maui/picker/overview) for general-purpose item selection.  

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/timepicker/getting-started) shows a step‑by‑step guide to begin using the Time Picker control.  
- [Customization](https://help.syncfusion.com/maui/timepicker/customizations) explains how to customize layout and appearance.  
- [Formatting](https://help.syncfusion.com/maui/timepicker/formatting) helps configure time formats and intervals.  
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) provides interactive demos and ready‑made UI examples.

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
<a href="https://www.syncfusion.com/maui-controls/maui-timepicker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Picker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/time-picker" class="form-card" target="_blank">
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
