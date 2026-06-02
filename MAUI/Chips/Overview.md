---
layout: post
title: Overview | .NET MAUI Chips | Syncfusion®
platform: maui
description: Learn here about overall key features in Essential Studio® for .NET MAUI SfChip Control, its elements, and more.
control: SfChip
---

# Overview in .NET MAUI Chips

The [.NET MAUI Chips](https://www.syncfusion.com/maui-controls/maui-chips) control is a versatile and feature-rich component that allows you to present information in an interactive and customizable layout. It enables you to arrange multiple chips in a layout and group them, making a selection and interaction seamless.

## Business use cases

- Applications that require **tag or category selection for filtering and classification**.  
- Search interfaces that use **filter chips to refine results dynamically**.  
- E-commerce apps that allow users to **select product attributes such as size, color, or category**.  
- Mobile and business apps that need **compact selectable UI elements for quick interactions**.  

## Key features

- **Flexible layout options** allow arranging chips using layouts such as stack, flex, and other configurable arrangements.  
- **Text-to-chip conversion** allows transforming text values into compact chip representations for better readability.  
- **Background customization** allows adding background images to enhance chip visuals.  
- **Comprehensive styling support** allows modifying text color, background color, border color, border thickness, and selection color for a consistent UI design. 

    ![NET MAUI Chip](images/overview/maui_chip.png)

## Globalization

The following table summarizes the globalization support available in the [SfChip](https://www.syncfusion.com/maui-controls/maui-chips) control.

<img src="Images/globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
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
<td><a href="/maui/chips/overview">Chips</a></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr>
</table>

## Related controls

- **[CheckBox](https://help.syncfusion.com/maui/checkbox/overview)** for implementing multi-selection using checkbox controls.  
- **[ComboBox](https://help.syncfusion.com/maui/combobox/overview)** for selection from dropdown-based inputs.  
- **[Autocomplete](https://help.syncfusion.com/maui/autocomplete/overview)** for searchable and suggestion-based inputs.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/chips/getting-started) - step-by-step guide to begin using the Chips control.
- [Chip Types](https://help.syncfusion.com/maui/chips/chips-types) – explore different chip variations such as input, choice, filter, and action chips, and learn how each type can be used to represent data or user actions.  
- [Customization](https://help.syncfusion.com/maui/chips/customization) – personalize chip appearance by modifying styles, colors, icons, and templates to match your application’s design and improve usability. 
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
<a href="https://www.syncfusion.com/maui-controls/maui-chips" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Chips" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/chips" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
