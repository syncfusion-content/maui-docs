---
layout: post
title: About .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui
---

# .NET MAUI DataGrid (SfDataGrid) Overview

- Create powerful, high-performance **tabular data experiences** in your **.NET MAUI applications** using the **Syncfusion DataGrid control ([SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html))**.

- Designed for **scalability, interactivity, and flexibility**, it enables you to efficiently display, manage, and analyze large datasets across **mobile and desktop platforms**.

   <img alt="MAUI DataGrid" src="Images\overview\maui-datagrid.png" width="567"/>

## Key features

- **Flexible data binding** to collections, tables, and MVVM sources.
- **Rich volume types** including text, numeric, date, checkbox, image, combobox, picker, and template columns.
- **Data operations** with sorting, filtering, grouping, summaries, and search.
- **Editing & interaction** through in‑place editing, drag‑drop, swipe actions, and selection.
- **Performance & virtualization** with paging, incremental loading, and smooth rendering for large datasets.
- **Advanced views** such as master‑details, record templates, unbound rows, and unbound columns.
- **Styling & customization** with conditional formatting, stacked headers, freeze panes, and theme support.
- **Export & data handling** including Excel/PDF export, clipboard operations, serialization, and deserialization.

## Globalization

Syncfusion<sup>®</sup> .NET MAUI controls are designed to support global users by providing key globalization features such as Localization, Right‑To‑Left (RTL) layout, Time zone handling, Accessibility through screen readers and Keyboard navigation.

The following table summarizes the globalization support available across all the Syncfusion<sup>®</sup> .NET MAUI controls.

### Legend

<img src="Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="Images/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="Images/no-support.svg" alt="no-support" width="16" align="center"/> No Support  
<img src="Images/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable

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
<td><a href="/maui/datagrid/overview">DataGrid</a></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Real‑World Scenarios

- Business dashboards requiring clear and structured **tabular data visualization**.
- Financial systems that rely on grouping, summaries, and **Excel or PDF export**.
- Inventory management applications handling **large datasets efficiently**.
- Analytics and reporting tools with **dynamic filtering and real‑time updates**.

## Related Controls

- **[Charts](https://help.syncfusion.com/maui/cartesian-charts/overview)** for advanced data visualization and analytics.
- **[ListView](https://help.syncfusion.com/maui/listview/overview)** for flexible and lightweight collection display.
- **[TreeMap](https://help.syncfusion.com/maui/treemap/overview)** for hierarchical or comparative visualization.

## Next Step

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/datagrid/getting-started) - step‑by‑step guide to begin using the DataGrid.
- [Styling Guide](https://help.syncfusion.com/maui/datagrid/styling) - learn how to customize appearance and themes.
- [Selection Guide](https://help.syncfusion.com/maui/datagrid/selection) - manage row and cell selection effectively.
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) – explore interactive demos and ready‑made UI examples.

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
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Explore Blogs
<a href="https://www.syncfusion.com/blogs/category/net-maui"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
                    width="16"
                    height="16"
                    fill="currentColor"
                    viewBox="0 0 32 32">
<path d="M18.684326,11.112103L20.888334,13.315114 13.312324,20.888142 11.108316,18.68513z M7.8643327,10.378122L9.801342,12.317125 5.7623454,16.356142C2.6103413,19.508131,2.1483364,24.17215,4.7313409,26.755167L5.2443409,27.269177C7.8273454,29.851189,12.492317,29.388175,15.642338,26.238167L19.683317,22.197167 21.622311,24.137146 17.580324,28.175187C13.119331,32.636202,6.5353241,33.290198,2.8813372,29.634177L2.3673301,29.119191C-1.2896477,25.462164,-0.63764038,18.881146,3.8243294,14.419122z M23.060328,6.1310129E-05C25.357323,-0.0079345306,27.517323,0.76608578,29.11632,2.3660676L29.62932,2.8810842C33.287304,6.5371036,32.634289,13.120106,28.171314,17.582129L24.132319,21.62316 22.195309,19.684157 26.235312,15.64514C29.386309,12.493121,29.847307,7.8291011,27.265308,5.2450762L26.75231,4.7310972C24.170311,2.1490867,19.504334,2.6120705,16.354313,5.7620764L12.313333,9.8031077 10.375346,7.8641047 14.416327,3.8250882C16.926333,1.3150686,20.107328,0.011077993,23.060328,6.1310129E-05z" />
</svg>
</a>
</h3>
<div class="form-description">
              Read insights, tutorials, and developer journeys.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Explore KB's
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
                    width="16"
                    height="16"
                    fill="currentColor"
                    viewBox="0 0 32 32">
<path d="M18.684326,11.112103L20.888334,13.315114 13.312324,20.888142 11.108316,18.68513z M7.8643327,10.378122L9.801342,12.317125 5.7623454,16.356142C2.6103413,19.508131,2.1483364,24.17215,4.7313409,26.755167L5.2443409,27.269177C7.8273454,29.851189,12.492317,29.388175,15.642338,26.238167L19.683317,22.197167 21.622311,24.137146 17.580324,28.175187C13.119331,32.636202,6.5353241,33.290198,2.8813372,29.634177L2.3673301,29.119191C-1.2896477,25.462164,-0.63764038,18.881146,3.8243294,14.419122z M23.060328,6.1310129E-05C25.357323,-0.0079345306,27.517323,0.76608578,29.11632,2.3660676L29.62932,2.8810842C33.287304,6.5371036,32.634289,13.120106,28.171314,17.582129L24.132319,21.62316 22.195309,19.684157 26.235312,15.64514C29.386309,12.493121,29.847307,7.8291011,27.265308,5.2450762L26.75231,4.7310972C24.170311,2.1490867,19.504334,2.6120705,16.354313,5.7620764L12.313333,9.8031077 10.375346,7.8641047 14.416327,3.8250882C16.926333,1.3150686,20.107328,0.011077993,23.060328,6.1310129E-05z" />
</svg>
</a>
</h3>
<div class="form-description">
               Find quick solutions and step‑by‑step guidance.
</div>
</div>
</div>
<!-- card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Feature Tour
<a href="https://www.syncfusion.com/maui-controls/maui-datagrid"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
                    width="16"
                    height="16"
                    fill="currentColor"
                    viewBox="0 0 32 32">
<path d="M18.684326,11.112103L20.888334,13.315114 13.312324,20.888142 11.108316,18.68513z M7.8643327,10.378122L9.801342,12.317125 5.7623454,16.356142C2.6103413,19.508131,2.1483364,24.17215,4.7313409,26.755167L5.2443409,27.269177C7.8273454,29.851189,12.492317,29.388175,15.642338,26.238167L19.683317,22.197167 21.622311,24.137146 17.580324,28.175187C13.119331,32.636202,6.5353241,33.290198,2.8813372,29.634177L2.3673301,29.119191C-1.2896477,25.462164,-0.63764038,18.881146,3.8243294,14.419122z M23.060328,6.1310129E-05C25.357323,-0.0079345306,27.517323,0.76608578,29.11632,2.3660676L29.62932,2.8810842C33.287304,6.5371036,32.634289,13.120106,28.171314,17.582129L24.132319,21.62316 22.195309,19.684157 26.235312,15.64514C29.386309,12.493121,29.847307,7.8291011,27.265308,5.2450762L26.75231,4.7310972C24.170311,2.1490867,19.504334,2.6120705,16.354313,5.7620764L12.313333,9.8031077 10.375346,7.8641047 14.416327,3.8250882C16.926333,1.3150686,20.107328,0.011077993,23.060328,6.1310129E-05z" />
</svg>
</a>
</h3>
<div class="form-description">
               Walk through highlights and core capabilities.
</div>
</div>
</div>
<!-- card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Showcase Samples
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/DataGrid"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
                    width="18"
                    height="18"
                    fill="currentColor"
                    viewBox="0 0 16 16">
<path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38
                   0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52
                   -.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07
                   -1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12
                   0 0 .67-.21 2.2.82a7.56 7.56 0 0 1 2-.27c.68 0 1.36.09 2 .27 1.53-1.04
                   2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15
                   0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48
                   0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8
                   c0-4.42-3.58-8-8-8z"/>
</svg>
</a>
</h3>
<div class="form-description">
                Explore sample scenarios for real apps.
</div>
</div>
</div>
<!-- card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Tutorial Videos
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/DataGrid"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
                    width="16"
                    height="16"
                    fill="currentColor"
                    viewBox="0 0 32 32">
<path d="M18.684326,11.112103L20.888334,13.315114 13.312324,20.888142 11.108316,18.68513z M7.8643327,10.378122L9.801342,12.317125 5.7623454,16.356142C2.6103413,19.508131,2.1483364,24.17215,4.7313409,26.755167L5.2443409,27.269177C7.8273454,29.851189,12.492317,29.388175,15.642338,26.238167L19.683317,22.197167 21.622311,24.137146 17.580324,28.175187C13.119331,32.636202,6.5353241,33.290198,2.8813372,29.634177L2.3673301,29.119191C-1.2896477,25.462164,-0.63764038,18.881146,3.8243294,14.419122z M23.060328,6.1310129E-05C25.357323,-0.0079345306,27.517323,0.76608578,29.11632,2.3660676L29.62932,2.8810842C33.287304,6.5371036,32.634289,13.120106,28.171314,17.582129L24.132319,21.62316 22.195309,19.684157 26.235312,15.64514C29.386309,12.493121,29.847307,7.8291011,27.265308,5.2450762L26.75231,4.7310972C24.170311,2.1490867,19.504334,2.6120705,16.354313,5.7620764L12.313333,9.8031077 10.375346,7.8641047 14.416327,3.8250882C16.926333,1.3150686,20.107328,0.011077993,23.060328,6.1310129E-05z" />
</svg>
</a>
</h3>
<div class="form-description">
                Step‑by‑step guidance through video tutorials.
</div>
</div>
</div>