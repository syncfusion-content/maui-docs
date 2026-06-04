---
layout: post
title: About .NET MAUI Circular Chart Control | Syncfusion
description: Learn here all about introduction of Syncfusion® .NET MAUI Chart(SfCircularChart) control with key features and more.
platform: maui
control: SfCircularChart
documentation: ug
---

# .NET MAUI Circular Chart Overview

Syncfusion® .NET MAUI Charts (SfCircularChart) is used to create the chart with beautiful and enhanced UI visualization of data that are used in high-quality .NET MAUI applications.

## Business use cases

- Business dashboards that require **proportion-based data visualization using pie or doughnut charts**.  
- Financial applications that display **distribution of expenses, revenue, or category-based data**.  
- Analytics tools that present **comparative insights using percentage-based charts**.  
- Reporting applications that require **easy-to-understand graphical representation of segmented data**.  

## Key features

- **Circular chart types** support pie and doughnut series to represent data in intuitive and visually distinct formats.  
- **User interaction support** includes selection, tooltip, and explode features to improve data exploration and usability.  
- **Legend support** provides additional information about data points and helps users interpret chart values.  
- **Dynamic data updates** allow updating the chart in real time or lazily based on changing data sources.  

## Globalization

The following table summarizes the globalization support available in the [SfCircularChart](https://www.syncfusion.com/maui-controls/maui-circular-charts) control.
 
<img src="globalization/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="globalization/no-support.svg" alt="no-support" width="16" align="center"/> No Support  

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
<td><a href="/maui/circular-charts/overview">Circular Charts</a></td>
<td align="center"><img src="globalization/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="globalization/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="globalization/no-support.svg" alt="no-support" width="16" /></td>
</tr>
</table>

## Related controls

- **[Cartesian Chart](https://help.syncfusion.com/maui/cartesian-charts/overview)** for trend analysis, comparisons, and multi‑series data visualization using X and Y axes.
- **[Funnel Chart](https://help.syncfusion.com/maui/funnel-charts/overview)** for visualizing stages in a process or pipeline.
- **[Pyramid Chart](https://help.syncfusion.com/maui/pyramid-charts/overview)** for hierarchical or comparative data representation.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/circular-charts/getting-started) - step-by-step guide to begin using the Circular Chart control.  
- [Pie Chart](https://help.syncfusion.com/maui/circular-charts/piechart) - create simple part‑to‑whole visualizations with clear category splits.  
- [Doughnut Chart](https://help.syncfusion.com/maui/circular-charts/doughnutchart) - highlight proportions with a modern ring‑style chart for better readability.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-circular-charts" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/CircularChart" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/circular-charts" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
