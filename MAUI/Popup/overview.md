---
layout: post
title: About .NET MAUI Popup control | Syncfusion
description: Learn about the introduction of Syncfusion .NET MAUI Popup (SfPopup) control, its elements and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# MAUI Popup (SfPopup) Overview

Popup layout allows you to display an alert message with customizable buttons or load any desired view inside a popup. It provides options to fully customize the popup with custom header, body, and footer capabilities, allowing you to display important information precisely how users want to.

## Business use cases

- Applications that require displaying alerts, confirmations, or notifications to users.  
- Form-based workflows that use modal dialogs for validation, input confirmation, or action prompts.  
- Mobile apps that present contextual content such as tips, menus, or additional details in overlays.  
- Business applications that require custom popup layouts for interactive user experiences.  

## Key features

- **Flexible positioning** allows displaying the popup at any location on the screen.  
- **Relative positioning** allows aligning the popup based on a target UI element.  
- **Full-screen mode** allows displaying popup content across the entire screen for engaging experiences.  
- **Auto sizing** allows adjusting popup dimensions automatically based on loaded content.  
- **Predefined layout** allows using built-in layouts such as single-button or two-button dialog styles.  
- **Template** allows loading custom views for header, content, and footer using templates.  
- **Modal behavior** allows preventing interaction with background content until the popup is closed.  

## Globalization

The following table summarizes the globalization support available in this control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="../Images/no-support.svg" alt="no-support" width="16" align="center"/> No Support  
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
<td><a href="/maui/popup/overview">Popup</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
</tr>
</table>

## Related controls
  
- [Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/overview) for creating sliding panels for navigation and content display.  
- [Backdrop Page](https://help.syncfusion.com/maui/backdrop/overview) for implementing layered UI interactions with front and back panels.
- [Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/overview) for displaying loading or status feedback within popup overlays.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/popup/getting-started) shows a step‑by‑step guide to begin using the Popup control.  
- [Customization](https://help.syncfusion.com/maui/popup/layout-customizations) explains how to customize layout and appearance.  
- [Positioning](https://help.syncfusion.com/maui/popup/popup-positioning) helps configure popup positioning and alignment.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-popup" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Popup" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/popup" class="form-card" target="_blank">
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
