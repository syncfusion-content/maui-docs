---
layout: post
title: Overview of .NET MAUI Toolbar | Syncfusion
description: Learn about the introduction of Syncfusion .NET MAUI Toolbar(SfToolbar) control, its basic features, and the functionalities of Toolbar.
platform: maui
control: Toolbar (SfToolbar)
documentation: ug
---
 
# Overview of .NET MAUI Toolbar (SfToolbar)

The Syncfusion<sup>&reg;</sup> [.NET MAUI Toolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) control is a customizable UI control that provides quick access to actions or commands through buttons, icons, or menus, enhancing usability and efficiency. It offers a structured, customizable, and user-friendly layout that supports multiple orientations, item alignments, and overflow handling.

## Business use cases

- Applications that require **quick access to common actions such as save, edit, or navigation commands**.  
- Productivity and editor apps that provide **toolbar-based command execution for user tasks**.  
- Dashboard applications that expose **frequently used actions in a compact and accessible UI**.  
- Business applications that require **organized command layouts with support for overflow and responsiveness**.  

## Key features

- **Toolbar item** allows displaying icons, text, or custom views for flexible command representation.  
- **Orientation** allows arranging toolbar items in horizontal or vertical layouts.  
- **Item alignment** allows positioning items at the start, center, or end of the toolbar.  
- **Overflow handling** allows managing extra items using scroll, navigation buttons, or a more options menu.  
- **Overflow positioning** allows controlling the placement of overflow items based on available space.  
- **Overlay toolbar** allows displaying floating toolbars that appear when needed.  
- **Separator** allows visually dividing toolbar items for better clarity and grouping.  
- **Tooltip** allows showing additional information when interacting with toolbar items.  
- **Enable or disable** allows controlling the availability of individual toolbar actions.  
- **Interaction** allows selecting and highlighting toolbar items for better usability.  
- **Keyboard support** allows navigating and interacting with toolbar items through keyboard shortcuts.  

## Globalization

The following table summarizes the globalization support available in the [SfToolbar](https://www.syncfusion.com/maui-controls/maui-toolbar) control.

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
<td><a href="/maui/toolbar/overview">Toolbar</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/overview)** for organizing navigation and actions in a side panel.
- **[TabView](https://help.syncfusion.com/maui/tabview/overview)** for grouping content and actions within tabbed interfaces.

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/toolbar/getting-started) - step-by-step guide to begin using the Toolbar control.
- [Toolbar Items](https://help.syncfusion.com/maui/toolbar/toolbar-items) - configure toolbar items and commands.
- [Customization](https://help.syncfusion.com/maui/toolbar/customization) - customize layout and appearance.
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
<a href="https://www.syncfusion.com/maui-controls/maui-toolbar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Toolbar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/toolbar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
