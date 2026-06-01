---
layout: post
title: About .NET MAUI Busy Indicator Control | Syncfusion®
description: Learn here all about introduction of the Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control, its elements and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator, maui busy indicator, maui loading indicator
---

# .NET MAUI Busy Indicator (SfBusyIndicator) Overview

The .NET MAUI Busy Indicator control provides an indication of app loading, data processing, and more. It can be customized in terms of indicator size, color, speed and additional options.

## Business use cases

- Data-driven applications that require **loading indicators during API calls or data fetching operations**.  
- Dashboard and analytics apps that need to show **processing states while updating or refreshing data**.  
- Mobile and desktop applications that require **feedback during navigation or long-running actions**.  
- E-commerce and business apps that display **loading states during transactions or content updates**.  

## Key features

- **Multiple animation types** provide seven built-in styles such as Circular Material, Linear Material, Cupertino, Single Circle, Double Circle, Globe, and Horizontal Pulsing Box.  
- **Appearance customization** allows modifying the indicator color and overlay background to match application themes.  
- **Animation duration control** enables adjusting the speed of animations based on UI requirements.  
- **Flexible sizing** allows configuring the indicator size to fit different layouts and screen sizes.  
- **Title display support** allows showing text with customizable font settings to provide additional context.

    ![.NET MAUI Busy Indicator](Images/Overview/Overview.gif)

## Related controls

- **[Button](https://help.syncfusion.com/maui/button/overview)** for triggering actions that require loading feedback.  
- **[DataGrid](https://help.syncfusion.com/maui/datagrid/overview)** for showing loading states while handling large datasets.  

## Next step

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/busy-indicator/getting-started) - step-by-step guide to begin using the Busy Indicator.  
- [Indicator Color & Customization](https://help.syncfusion.com/maui/busy-indicator/indicatorcolor) - personalize indicator color and styles to fit your app theme. 
- [Animation Type](https://help.syncfusion.com/maui/busy-indicator/animationtype) - explore different animation types and behaviors. 

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
<a href="https://www.syncfusion.com/maui-controls/maui-busy-indicator" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/BusyIndicator" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/busy-indicator" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
