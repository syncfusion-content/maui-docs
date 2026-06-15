---
layout: post
title: About .NET MAUI Sunburst Chart Control | Syncfusion
description: Learn here all about introduction of Syncfusion<sup>®</sup> .NET MAUI SunburstChart control with key features and more
platform: maui
control: SfSunburstChart
documentation: ug
---

# .NET MAUI Sunburst Chart Overview

The Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart is used to visualize hierarchical data structures. The chart organizes data in multiple levels, where each level represents a different category or subcategory. This visualization helps users understand relationships and dependencies within the data in an intuitive and user-friendly way.

![Overview of MAUI Sunburst Chart.](Overview_image/Overview_Image.png)

## Business use cases

- Business intelligence applications that require visualizing hierarchical data such as organizational structures or product categories.
- Financial and analytics dashboards that display multi-level data distribution and contribution analysis.
- Data-driven applications that require comparative insights across parent and child categories.
- Scientific and research applications that visualize nested and hierarchical relationships in datasets.  

## Key features

- **Hierarchical data visualization** allows representing multiple levels of categories and subcategories effectively.  
- **Data label** allows displaying labels for better readability of each segment.  
- **Legend** allows identifying categories and understanding data representation clearly.  
- **Tooltip** allows displaying additional information on interaction with segments.  
- **Appearance customization** allows applying custom color palettes and styling to enhance visualization.  
- **Center view** allows displaying additional information or summary content at the center of the chart.  

## Globalization

The following table summarizes the globalization support available in this control.

<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/partial-support.svg" alt="partial-support" width="16">
    <span>Partial Support</span>
</div>
<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/no-support.svg" alt="no-support" width="16">
    <span>No Support</span>
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
<td><a href="/maui/sunburstchart/overview">Sunburst Chart</a></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [Treemap](https://help.syncfusion.com/maui/treemap/overview) for visualizing hierarchical data using rectangular layouts.
- [Circular Charts](https://help.syncfusion.com/maui/circular-charts/overview) for representing proportional data using pie and doughnut charts.
- [Cartesian Charts](https://help.syncfusion.com/maui/cartesian-charts/overview) for visualizing tabular data trends and comparisons.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/sunburstchart/getting-started) shows a step‑by‑step guide to begin using the Sunburst Chart control.  
- [Appearance](https://help.syncfusion.com/maui/sunburstchart/appearance) explains how to customize chart appearance and styling.  
- [Labels](https://help.syncfusion.com/maui/sunburstchart/datalabels) helps configure data labels and segment display.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-sunburst-charts" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/SunburstChart" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/sunburst-chart" class="form-card" target="_blank">
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
