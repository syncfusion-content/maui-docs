---
layout: post
title: What's New in Essential Studio® for .NET MAUI | Syncfusion®
description: A .NET MAUI backdrop appears behind all the surfaces in an app, displaying contextual and actionable content.
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# .NET MAUI Backdrop Page (SfBackdropPage) Overview

The **[.NET MAUI Backdrop](https://www.syncfusion.com/maui-controls/maui-backdrop)** page comprises two surfaces: a back layer and a front layer. The back layer holds actionable content (like navigation or filtration), which is relevant to the front layer.

   ![BackdropPage control for .NET MAUI.](images/overview/net_maui_backdrop.gif)

## Business use cases

- Navigation panels with contextual menus for streamlined app navigation.
- Search and filtering panels layered behind main content for efficient workflows.
- Dashboards with expandable configuration panels or control sections. 
- Mobile apps requiring layered UI layouts for better space utilization.

## Key features

- **Navigation integration** works with NavigationPage and supports toolbar customization.  
- **Adaptive back layer height** adjusts the height of the back layer based on its content and allows full expansion.  
- **Customizable front layer shape** supports curved and flat edge styles with configurable corner radius.  
- **Smooth layer animations** provide animations when revealing or hiding the back layer.  
- **Custom header icons** allow different icons for expanded and collapsed states.

## Globalization

The following table summarizes the globalization support available in this control.

<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/full-support.svg" alt="full-support" width="16">
    <span>Full Support</span>
</div>
<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto;">
    <img src="../Images/not-applicable.svg" alt="not-applicable" width="16">
    <span>Not Applicable</span>
</div>

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
<td><a href="/maui/backdrop/overview">Backdrop</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
</tr> 
</table> 

## Related controls

- [NavigationPage](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage) for providing navigation structure integrated with BackdropPage.
- [Accordion](https://help.syncfusion.com/maui/accordion/overview) for organizing collapsible content within panels.
- [ListView](https://help.syncfusion.com/maui/listview/overview) for displaying navigational options or filter lists in the back layer.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/backdrop/getting-started) shows how to begin using BackdropPage step by step.
- [Header Configuration](https://help.syncfusion.com/maui/backdrop/header-configuration) explains how to configure headers and icons for different states.
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) provides interactive demos and ready-made UI examples.

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
<a href="https://www.syncfusion.com/maui-controls/maui-backdrop" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Backdrop" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/backdrop" class="form-card" target="_blank">
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