---
layout: post
title: .NET MAUI DateTime Range Selector control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI Range Selector (SfDateTimeRangeSelector) control with key features and more.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# .NET MAUI DateTime Range Selector Overview

The Syncfusion<sup>®</sup> .NET MAUI DateTime Range Selector ([SfDateTimeRangeSelector](https://www.syncfusion.com/maui-controls/maui-range-selector)) is a highly interactive UI control, allowing users to select a range of values within a minimum and maximum limit.

## Business use cases

- Data analytics applications that require **filtering datasets based on selected date and time ranges**.  
- Financial and reporting tools that depend on **range-based analysis of time-series data**.  
- Dashboard applications that integrate **interactive range selection with charts and visual components**.  
- Booking and scheduling systems that require **selecting start and end date-time values within defined limits**.  

## Key features

- **DateTime range selection support** allows selecting a start and end value within a specified range.  
- **Content integration support** allows embedding custom UI elements or controls such as [Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) within the range selector.  
- **Customizable labels support** allows displaying date and time values with formatting based on requirements.  
- **Ticks and dividers support** allows visualizing intervals clearly using major and minor ticks.  
- **Discrete mode support** allows moving the selection in fixed intervals based on defined step values.  
- **Tooltip support** allows displaying selected values clearly with customizable formatting.  

## Globalization

The following table summarizes the globalization support available in the [SfDateTimeRangeSelector](https://www.syncfusion.com/maui-controls/maui-datepicker) control.

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
<td><a href="/maui/datepicker/overview">DateTimeRangeSelector</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[RangeSlider](https://help.syncfusion.com/maui/range-slider/overview)** for selecting numeric or date ranges using slider-based interaction.
- **[DatePicker](https://help.syncfusion.com/maui/datepicker/overview)** for selecting single date values.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/datetime-range-selector/getting-started) - step-by-step guide to begin using the DateTime Range Selector control.  
- [Track](https://help.syncfusion.com/maui/datetime-range-selector/track) - .  
- [Thumb & Overlay](https://help.syncfusion.com/maui/datetime-range-selector/thumb-and-overlay) - .  
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
