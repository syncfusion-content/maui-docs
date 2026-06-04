---
layout: post
title: About .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about introduction of Syncfusion® .NET MAUI Chart (SfCartesianChart) control with key features and more.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui sfCartesianChart overview,  introduction to sfCartesianChart in .net maui, exploring sfCartesianChart in .net maui.
---

# .NET MAUI Cartesian Chart Overview

The [.NET MAUI Cartesian chart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) provides a perfect way to visualize data with a high level of user involvement that focuses on development, productivity, and simplicity of use. Chart also provides a wide variety of charting features that can be used to visualize large quantities of data, as well as flexibility in data binding and user customization.

## Business use cases

- Business dashboards that require interactive data visualization with charts and graphs.  
- Financial and analytics applications that rely on trend analysis and comparison of multiple datasets.  
- Reporting tools that display large volumes of data in an easy-to-understand visual format.  
- Real-time monitoring applications that require dynamic updates and interactive chart exploration.

## Key features

- **Rich chart types** include line, spline, column, bar, area, scatter, and combination series.
- **MVVM-Friendly data binding** supports property path binding, collection binding, and dynamic updates.
- **Interactive exploration** provides zooming, panning, tooltips, selection, and trackball interaction.
- **Multi-series visualization** enables comparison of multiple datasets and supports combining different chart types.
- **Visual customization** offers styling for axes, gridlines, labels, legends, markers, and themes.

## Globalization

The following table summarizes the globalization support available in this control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="../Images/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="../Images/no-support.svg" alt="no-support" width="16" align="center"/> No Support  

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
<td><a href="/maui/cartesian-charts/overview">Cartesian Charts</a></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [Circular Chart](https://help.syncfusion.com/maui/circular-charts/overview) for proportional data visualization using pie, doughnut, and radial bar charts.
- [Funnel Chart](https://help.syncfusion.com/maui/funnel-charts/overview) for visualizing stages in a process or pipeline.
- [Pyramid Chart](https://help.syncfusion.com/maui/pyramid-charts/overview) for hierarchical or comparative data representation.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started) shows how to begin using the Cartesian chart control step by step.  
- [Customization and Styling](https://help.syncfusion.com/maui/cartesian-charts/appearance) shows how to configure chart appearance, axes, gridlines, labels, legends, and themes.  
- [Labels](https://help.syncfusion.com/maui/cartesian-charts/datalabels) display values directly on data points.
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) provides interactive demos and ready-made UI examples.

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
<a href="https://www.syncfusion.com/maui-controls/maui-cartesian-charts" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/CartesianChart" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/cartesian-charts" class="form-card" target="_blank">
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