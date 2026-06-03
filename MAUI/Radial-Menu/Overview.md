---
layout: post
title: About .NET MAUI Radial Menu Control | Syncfusion®
description: Learn about the introduction of the Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) control, its elements, and more.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# .NET MAUI Radial Menu (SfRadialMenu) Overview

 The [.NET MAUI Radial Menu](https://www.syncfusion.com/maui-controls/maui-radial-menu) control displays a hierarchical menu in a circular layout, optimized for touch-enabled devices. It is typically used as a context menu and can expose more menu items in the same space than traditional menus.

 ![.NET MAUI Radial Menu](images/overview/maui-radialmenu-overview.png)

## Business use cases

- Mobile applications that require **compact and touch-friendly context menus for quick actions**.  
- Design and drawing tools that use **radial menus for tool selection and commands**.  
- Productivity applications that provide **shortcut actions in a circular layout for faster interaction**.  
- Applications with limited screen space that require **efficient organization of multiple menu options**.  

## Key features

- **Drag** allows floating the radial menu over layouts to avoid blocking underlying content.  
- **Rotation** allows rotating menu items for better visual arrangement and interaction.  
- **Font icon** allows using vector-based icons to avoid rendering issues with images.  
- **Custom view** allows embedding images or custom UI elements within menu items.  
- **Segment customization** allows modifying colors, sizes, shapes, and positioning of menu segments.  
- **Auto arrangement** allows automatically arranging menu items for better usability and layout consistency.

## Related controls

- **[Button](https://help.syncfusion.com/maui/button/overview)** for triggering actions and commands in applications.  
- **[Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/overview)** for organizing navigation options in a sliding panel.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/radial-menu/getting-started) - step-by-step guide to begin using the Radial Menu control.
- [Customization](https://help.syncfusion.com/maui/radial-menu/sfradialmenuitem-customization) - customize layout and appearance of menu items.  
- [Populating Items](https://help.syncfusion.com/maui/radial-menu/populating-items) - configure menu structure and hierarchy.
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
<a href="https://www.syncfusion.com/maui-controls/maui-radial-menu" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/RadialMenu" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/radial-menu" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
