---
layout: post
title: Overview of .NET MAUI Maps Control | Syncfusion
description: Learn here all about the introduction of Syncfusion<sup>&reg;</sup> .NET MAUI Maps (SfMaps) control, its features, and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# .NET MAUI Maps (SfMaps) Overview

The [.NET MAUI Maps](https://www.syncfusion.com/maui-controls/maui-maps) control is a powerful data visualization component that displays statistical information for a geographical area. It has highly interactive and customizable features such as selection, tooltip, legends, markers, bubbles, and color mapping. Using the Maps control, you can generate maps for population density, sales, political boundaries, weather, elections, and routes.

![.NET MAUI Maps layer overview.](images/overview/net-maui-maps-overview.png)

## Business use cases

- Analytics applications that require visualizing geographical data such as population density, sales distribution, or regional performance.  
- Logistics and tracking systems that display locations, routes, and real-time movement on maps.  
- Business intelligence dashboards that use map-based visualization for better decision-making insights.  
- Applications that require location tagging and highlighting specific regions or points of interest. 

## Key features

- **[Shape layer](https://help.syncfusion.com/maui/maps/getting-started#add-shape-layer-maps-elements)** allows visualizing geographical regions using GeoJSON or shapefile data.
- **[Data labels](https://help.syncfusion.com/maui/maps/data-labels)** allows displaying names or information for map shapes with intelligent layout handling.
- **[Markers](https://help.syncfusion.com/maui/maps/markers)** allows placing symbols or custom UI elements at specific latitude and longitude locations.
- **[Bubbles](https://help.syncfusion.com/maui/maps/bubble)** allows representing data values using varying sizes and colors of bubbles.
- **[Shape selection](https://help.syncfusion.com/maui/maps/selection)** allows highlighting specific regions and handling selection interactions.
- **[Legend](https://help.syncfusion.com/maui/maps/legend)** allows explaining the data representation used in the map for better understanding.
- **[Colors](https://help.syncfusion.com/maui/maps/shape)** allows categorizing and styling regions based on underlying data values or ranges.
- **[Tooltip](https://help.syncfusion.com/maui/maps/tooltip)** allows displaying additional information for shapes, markers, and bubbles interactively.

## Related controls

- [Treemap](https://help.syncfusion.com/maui/treemap/overview) for displaying hierarchical and comparative data visualization.
- [DataGrid](https://help.syncfusion.com/maui/datagrid/overview) for managing and presenting location-based data in tabular format.
- [Cartesian Chart](https://help.syncfusion.com/maui/cartesian-charts/overview) for visualizing geographical or statistical data trends using interactive charts.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/maps/getting-started) shows a step‑by‑step guide to begin using the Maps control.  
- [Vector Layers](https://help.syncfusion.com/maui/maps/vector-layers/line-layer) lets you add line, polygon, or point layers to visualize geographic data clearly.  
- [Markers](https://help.syncfusion.com/maui/maps/markers) explains how to add markers and customize location visualization.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-maps" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Maps" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/maps" class="form-card" target="_blank">
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
