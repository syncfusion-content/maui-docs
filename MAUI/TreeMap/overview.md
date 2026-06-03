---
layout: post
title: Overview of .NET MAUI TreeMap | Syncfusion
description: Learn about the introduction of Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap(STreeMap) control, its basic features, and the functionalities of treemap.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---
 
# Overview of .NET MAUI TreeMap (SfTreeMap)

The Syncfusion<sup>&reg;</sup> [.NET MAUI TreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) control allows you to visually represent hierarchical data with rectangles that are sized and colored based on underlying values. It efficiently displays grouped and nested data structures, offering various layout options, extensive customization options, supporting item selection, data binding to different sources, and more.

 ![overview-of-maui-tree-map](images/overview/overview-of-maui-tree-map.png)

## Business use cases

- Business intelligence applications that require **visualizing hierarchical data such as categories, subcategories, and performance metrics**.  
- Financial dashboards that display **portfolio distribution, revenue contribution, or market segmentation**.  
- Analytics applications that require **comparing proportional values across grouped datasets**.  
- Data-driven applications that need **efficient visualization of large hierarchical datasets in a compact layout**.  
  
## Key features 
 
- **Data Binding** allows binding structured data with multiple levels and categories.
- **Layout** allows choosing between layouts such as slice and dice or squarified for optimal visualization. 

    ![layout-in-maui-tree-map](images/overview/layout-in-maui-tree-map.png)

- **Levels** allows representing nested data structures with clear parent-child relationships. 

    ![level-in-maui-tree-map](images/overview/level-in-maui-tree-map.png)

- **Brush Settings** allows applying colors based on value ranges or categories for better interpretation.

    ![brush-settings-in-maui-tree-map](images/overview/brush-settings-in-maui-tree-map.png)

- **Legend** allows providing visual guidance for understanding color and data mapping. 

    ![legend-in-maui-tree-map](images/overview/legend-in-maui-tree-map.png)

- **Tooltip** allows displaying additional information on interaction with tree map items.

    ![tool-tip-in-maui-tree-map](images/overview/tool-tip-in-maui-tree-map.gif)

- **Interaction** allows selecting and highlighting items for focused analysis.  
- **Accessibility and keyboard** allows improving usability with keyboard navigation and inclusive design.  
- **Appearance customization** allows modifying styles, layouts, and visual properties to match application requirements.

    ![leaf-item-template-in-maui-tree-map](images/overview/leaf-item-template-in-maui-tree-map.png)

## Globalization

The following table summarizes the globalization support available in the [SfTreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) control.

<img src="Images/globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
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
<td><a href="/maui/treemap/overview">TreeMap</a></td>
<td align="center"><img src="Images/globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[Sunburst Chart](https://help.syncfusion.com/maui/sunburstchart/overview)** for visualizing hierarchical data using a radial layout.
- **[Cartesian Chart](https://help.syncfusion.com/maui/cartesian-charts/overview)** for analyzing data trends using axis-based charts.
- **[Maps](https://help.syncfusion.com/maui/maps/overview)** for visualizing location-based hierarchical data.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/treemap/getting-started) - step-by-step guide to begin using the TreeMap control.
- [Layouts](https://help.syncfusion.com/maui/treemap/layouts) - configure layout types and data arrangement.  
- [Drilldown](https://help.syncfusion.com/maui/treemap/drilldown) - Drilldown – dive into details by exploring data hierarchies step by step. 
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
<a href="https://www.syncfusion.com/maui-controls/maui-tree-map" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/TreeMap" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/treemap" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
