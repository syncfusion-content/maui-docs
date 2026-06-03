---
layout: post
title: .NET MAUI Range Selector control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI Range Selector (SfRangeSelector) control with key features and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# .NET MAUI Range Selector Overview

The Syncfusion<sup>®</sup> .NET MAUI Range Selector ([SfRangeSelector](https://www.syncfusion.com/maui-controls/maui-range-selector)) is a highly interactive UI control, allowing users to select a range values within a minimum and maximum limit. It provides rich features, such as track, labels, ticks, dividers, and tooltip.

## Business use cases

- Data analytics applications that require **filtering datasets based on numeric ranges such as price, quantity, or duration**.  
- Dashboard applications that allow users to **adjust value ranges dynamically for data visualization**.  
- Financial and reporting systems that use **range selection for comparing metrics across intervals**.  
- Configuration panels that require **user-defined range inputs for values like thresholds and limits**.  

## Key features

- **Numeric range selection** allows selecting values between a defined minimum and maximum range.  
- **Content integration** allows embedding custom UI elements or controls such as [Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) inside the range selector.  
- **Customizable label** allows displaying values with formatting based on application needs.  
- **Ticks and dividers** allows indicating intervals clearly using major and minor tick marks.  
- **Discrete mode** allows moving selection thumbs in fixed steps using defined intervals.  
- **Tooltip** allows displaying selected values clearly with customizable text formatting.  

## Globalization

The following table summarizes the globalization support available in the [SfRangeSelector](https://www.syncfusion.com/maui-controls/maui-range-selector) control.

<img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable  
<img src="Images/globalization/no-support.svg" alt="no-support" width="16" align="center"/> No Support  

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
<td><a href="/maui/range-selector/overview">Range Selector</a></td>
<td align="center"><img src="Images/globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="Images/globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[Range Slider](https://help.syncfusion.com/maui/range-slider/overview)** for selecting numeric ranges using slider-based interaction.
- **[Cartesian Charts](https://help.syncfusion.com/maui/cartesian-charts/overview)** for visualizing filtered data using charts.
- **[NumericEntry](https://help.syncfusion.com/maui/numericentry/overview)** for precise numeric input and value modification.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/range-selector/getting-started) - step-by-step guide to begin using the Range Selector control.
- [Thumb & Overlay](https://help.syncfusion.com/maui/range-selector/thumb-and-overlay) - customize the thumb and its overlay for clear, user‑friendly selection.  
- [Labels](https://help.syncfusion.com/maui/range-selector/labels) - configure label formatting and interval display.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-range-selector" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/range-selector" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
