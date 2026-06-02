---
layout: post
title: .NET MAUI Slider control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI Slider (SfDateTimeSlider) control with key features and more.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# .NET MAUI DateTime Slider Overview

The Syncfusion<sup>®</sup> .NET MAUI DateTime Slider ([SfDateTimeSlider](https://www.syncfusion.com/maui-controls/maui-slider)) is a highly interactive UI control, allowing users to select a single value from a range of values.

## Business use cases

- Data analysis applications that require **selection of a specific date or time value for filtering datasets**.  
- Dashboard applications that allow users to **navigate through time-based data using a slider interface**.  
- Scheduling applications that require **quick selection of a precise date or time point**.  
- Configuration panels that use **single value sliders for adjusting time-based parameters**.  

## Key features

- **Single DateTime value selection support** allows selecting a specific value within a defined range.  
- **Orientation support** allows displaying the slider in horizontal or vertical layouts based on UI design.  
- **Customizable labels support** allows rendering date values with formatting based on application requirements.  
- **Ticks and dividers support** allows indicating intervals clearly using major and minor tick marks.  
- **Discrete mode support** allows moving the slider thumb in fixed steps based on configured intervals.  
- **Tooltip support** allows displaying the selected value clearly during interaction.  

## Globalization

The following table summarizes the globalization support available in the [SfDateTimeSlider](https://www.syncfusion.com/maui-controls/maui-datepicker) control.

<img src="Images/globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  

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
<td><a href="/maui/datepicker/overview">DateTimeSlider</a></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[RangeSlider](https://help.syncfusion.com/maui/range-slider/overview)** for selecting ranges of values using slider-based interaction.  
- **[RangeSelector](https://help.syncfusion.com/maui/range-selector/overview)** for advanced range selection with integrated content and visualization.  
- **[DatePicker](https://help.syncfusion.com/maui/datepicker/overview)** for selecting individual dates using a picker interface.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/datetime-slider/getting-started) - step-by-step guide to begin using the DateTime Slider control.  
- [Thumb & Overlay](https://help.syncfusion.com/maui/datetime-slider/thumb-and-overlay) - customize the slider thumb and its overlay to improve visibility and give users a clear handle for selecting values.  
- [Labels](https://help.syncfusion.com/maui/datetime-slider/labels) - configure label formatting and interval display.
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
