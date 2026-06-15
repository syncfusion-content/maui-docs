---
layout: post
title: About .NET MAUI Parallax View control | Syncfusion®
description: Learn about the introduction of Syncfusion<sup>®</sup> .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# .NET MAUI Parallax View (SfParallaxView) Overview

The [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) for .NET MAUI provides an optimal way to scroll any control that implements the [IParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface with a background element that translates more slowly than the foreground element. The SfParallaxView control binds the scroll position of a foreground element (such as a list) to a background element and moves the background element at a varying speed.

   ![Overview image of Syncfusion .NET MAUI Parallax View](ParallaxView_Images/maui_parallaxview_overview.gif)

## Business use cases

- Mobile applications that require modern UI experiences with smooth and interactive scrolling effects.  
- E-commerce and media apps that display rich visual content using layered scrolling layouts.  
- Dashboard applications that enhance user engagement with dynamic background animations.  
- Content-driven applications that require improved visual storytelling using parallax effects.  

## Key features

- **Parallax effect customization support** allows controlling the speed difference between foreground and background scrolling.  
- **Orientation support** allows enabling both horizontal and vertical scrolling behaviors.  
- **Scroll binding support** allows linking foreground elements such as ScrollView or ListView with background content.  
- **Flexible integration support** allows using any control that implements the IParallaxView interface for advanced scenarios.

## Globalization

The following table summarizes the globalization support available in this control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support    
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
<td><a href="/maui/parallax-view/overview">Parallax View</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
</tr>
</table>

## Related controls

- [ListView](https://help.syncfusion.com/maui/listview/overview) for creating scrollable data lists with rich layouts.
- [Cards](https://help.syncfusion.com/maui/cards/overview) for designing content blocks that can be enhanced with parallax effects.
- [Backdrop Page](https://help.syncfusion.com/maui/backdrop/overview) for creating layered front and back panels with depth-based UI interactions.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/parallax-view/getting-started) shows a step‑by‑step guide to begin using the Parallax View control.  
- [Customization](https://help.syncfusion.com/maui/parallax-view/customization) explains how to customize appearance and parallax settings.  
- [Scrolling](https://help.syncfusion.com/maui/parallax-view/custom-controls) helps configure scrolling behavior and effects.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-parallax-view" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/ParallaxView" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/parallax-view" class="form-card" target="_blank">
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