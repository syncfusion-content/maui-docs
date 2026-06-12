---
layout: post
title: Overview for .NET MAUI Shimmer control | Syncfusion
description: Learn here about the overview of Syncfusion .NET MAUI Shimmer (SfShimmer) control, its basic features, elements and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Overview of .NET MAUI Shimmer (SfShimmer)

Syncfusion .NET MAUI Shimmer (SfShimmer) control can increase an application's responsiveness by displaying a shimmer effect while the content is loading or processing in the background.

## Business use cases

- Mobile applications that require loading placeholders for lists, cards, or content-heavy screens.  
- Data-driven applications that display temporary UI while data is fetched from services or APIs.  
- Dashboard applications that provide visual feedback during data refresh or processing operations.  
- Content-driven apps that require smooth transition between loading and loaded states.  

## Key features

- **Multiple shimmer view types** allows displaying predefined layouts such as persona or content placeholders for different scenarios.

    ![Multiple Shimmer View in .NET MAUI.](images/overview/maui-multiple-shimmer-views.gif)

- **Wave direction customization** allows controlling animation flow direction for enhanced visual effects. 

    ![Multiple Shimmer Wave Directions in .NET MAUI.](images/overview/maui-multiple-shimmer-wave-directions.gif)

- **Custom shimmer view** allows defining custom shapes using different shape types such as rectangle or circle.

    ![Shimmer Custom view in .NET MAUI.](images/overview/maui-custom-view.gif) 

## Related controls

- [Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/overview) for displaying indeterminate loading indicators.  
- [ListView](https://help.syncfusion.com/maui/listview/overview) for presenting data with loading placeholders.  
- [Cards](https://help.syncfusion.com/maui/cards/overview) for designing content layouts that integrate shimmer effects.  

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/shimmer/getting-started) shows a step‑by‑step guide to begin using the Shimmer control.  
- [Customization](https://help.syncfusion.com/maui/shimmer/customization) explains how to customize shimmer appearance and animations.  
- [Views](https://help.syncfusion.com/maui/shimmer/built-in-views) explores different shimmer view types and layouts.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-shimmer" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Shimmer" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/shimmer" class="form-card" target="_blank">
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
