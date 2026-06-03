---
layout: post
title: About .NET MAUI Smart DataGrid control | Syncfusion®
description: Learn about the Syncfusion® .NET MAUI Smart DataGrid (SfSmartDataGrid) control and its AI-assisted features.
platform: MAUI
control: SfSmartDataGrid
documentation: ug
keywords: maui smart datagrid, ai datagrid maui, smart grid maui, ai gridview maui, .net maui smart datagrid, .net maui ai grid
---

# .NET MAUI Smart DataGrid (SfSmartDataGrid) Overview

The .NET MAUI Smart DataGrid is an AI-assisted data grid control that enhances how users interact with data. It enables natural language–driven operations for sorting, filtering, grouping, and highlighting, helping users perform complex tasks more intuitively and efficiently.

<img src="Images\getting-started\maui-smart-datagrid.png" width="600" alt=".NET MAUI Smart DataGrid." />

## Business use cases

- Business intelligence applications that require **advanced data analysis through natural language interactions**.  
- Enterprise systems that enable **users to explore and manipulate large datasets without technical expertise**.  
- Dashboard applications that provide **intelligent filtering, grouping, and highlighting of data**.  
- Data-driven applications that require **interactive and AI-powered insights for decision-making**.  

## Key features

- **AI-based sorting** allows sorting data using natural language inputs without manual configuration.  
- **Intelligent filtering** allows applying filters using plain language queries with context-aware results.  
- **Smart grouping** allows organizing related data dynamically based on user intent.  
- **Conditional highlighting** allows emphasizing rows or cells by describing conditions in natural language.  

## Globalization

The following table summarizes the globalization support available in the [SfSmartDataGrid](https://www.syncfusion.com/maui-controls/maui-smart-datagrid) control.

<img src="Images/globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable

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
<td><a href="/maui/smartdatagrid/overview">Smart DataGrid</a></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[DataGrid](https://help.syncfusion.com/maui/datagrid/overview)** for traditional data grid features and structured data handling.  
- **[ListView](https://help.syncfusion.com/maui/listview/overview)** for displaying data collections in list formats.  
- **[Treemap](https://help.syncfusion.com/maui/treemap/overview)** for handling hierarchical data with expandable rows.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/smartdatagrid/getting-started) - step-by-step guide to begin using the Smart DataGrid control.
- [AI Features](https://help.syncfusion.com/maui/smartdatagrid/ai-powered-features) - explore AI-powered operations such as filtering and grouping.
- [Customization](https://help.syncfusion.com/maui/smartdatagrid/customization) - customize grid behavior and appearance.
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
<a href="https://www.syncfusion.com/maui-controls/maui-smart-datagrid" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartComponents" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
