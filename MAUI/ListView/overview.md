---
layout: post
title: About .NET MAUI ListView control | Syncfusion
description: Learn here all about introduction of Syncfusion .NET MAUI ListView (SfListView) control, its elements and more.
platform: MAUI
control: ListView
documentation: ug
---

# Overview of .NET MAUI ListView (SfListView)

The Syncfusion [.NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview) renders set of data items using Maui views or custom templates. Data can easily be grouped, sorted, and filtered.
 
## Business use cases

- Data-driven applications that require **efficient display of large collections using list or grid layouts**.  
- E-commerce and catalog apps that present **products with rich templates and grouped categories**.  
- Messaging and social apps that display **dynamic lists with real-time updates and infinite scrolling**.  
- Business applications that require **sorting, grouping, and filtering of data in list-based views**.  

## Key features

- **Optimized performance support** allows smooth rendering using efficient view reuse techniques.  
- **Item templating support** allows designing rich and customized UI layouts for each data item.  
- **Dynamic template selection** allows using DataTemplateSelector to define different UI layouts based on item type.  
- **Auto-fit item sizing** allows adjusting item size automatically based on content within the template.  
- **Multiple layout support** allows displaying items in both linear and grid arrangements.  
- **Orientation support** allows switching between horizontal and vertical list layouts.  
- **Data operations support** allows sorting, grouping, and filtering data efficiently.  
- **Group header customization** allows customizing group headers with sticky header support.  
- **Selection support** allows choosing items using various selection modes and gestures.  
- **Header and footer support** allows adding sticky headers and footers for better content organization.  
- **Load more support** allows loading additional data automatically or manually when scrolling reaches the list boundaries.  

## Globalization

The following table summarizes the globalization support available in the [SfListView](https://www.syncfusion.com/maui-controls/maui-listview) control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="../Images/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="../Images/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable

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
<td><a href="/maui/listview/overview">ListView</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[DataGrid](https://help.syncfusion.com/maui/datagrid/overview)** for displaying structured data in a tabular format.
- **[Cards](https://help.syncfusion.com/maui/cards/overview)** for presenting content using card-based layouts.

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/listview/getting-started) - step-by-step guide to begin using the ListView control.  
- [Layouts](https://help.syncfusion.com/maui/listview/layouts) - configure list and grid layouts.  
- [Grouping](https://help.syncfusion.com/maui/listview/grouping) - implement grouping and data organization. 
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
<a href="https://www.syncfusion.com/maui-controls/maui-listview" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/listview" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>