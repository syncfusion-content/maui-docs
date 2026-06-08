---
layout: post
title: About .NET MAUI Picker control | Syncfusion
description: Learn about the overview of Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control, its basic features, and picker functionalities.
platform: maui
control: SfPicker
documentation: ug
---

# Overview of .NET MAUI Picker (SfPicker)

Syncfusion .NET MAUI Picker (SfPicker) control allows you to select an item and visualize its items inside a popup or a drop-down UI element. It supports multiple-column layout, header, footer, and selection view customizations. It provides customization as a date picker, time picker, date-time picker, country picker, color picker, and more.

## Business use cases

- Form-based applications that require **selecting values such as country, category, or options from predefined lists**.  
- Scheduling and booking systems that use **custom picker configurations for date, time, or combined inputs**.  
- Business applications that require **multi-column selection for hierarchical or grouped data**.  
- Mobile applications that need **user-friendly and customizable selection UI for various input scenarios**. 

## Key features

- **Header view** allows adding and customizing header text to provide context for the picker. 

   ![Header view in .NET MAUI Picker.](images/overview/maui-header-view.png)

- **Column header view** allows separating multiple columns with distinct headers for better clarity.

   ![Column header view in .NET MAUI Picker.](images/overview/maui-column-header-view.png)

- **Footer view** allows displaying validation buttons such as OK and Cancel with customizable appearance. 

   ![Footer view in .NET MAUI Picker.](images/overview/maui-footer-view.png)

- **Selection view** allows showing the selected item in a configurable display area.  

   ![Selection view in .NET MAUI Picker.](images/overview/maui-selection-view.png)

- **Picker mode** allows displaying the picker in popup or dialog mode with flexible positioning.

   ![Picker mode in .NET MAUI Picker.](images/overview/maui-picker-mode.gif)

- **User interaction** allows selecting items through tap and scroll gestures.  

   ![Picker interactions in .NET MAUI Picker.](images/overview/maui-picker-interactions.gif)

- **Item template support** allows customizing how items are displayed within the picker. 

   ![Item template in .NET MAUI Picker.](images/overview/maui-picker-item-template.png ) 

## Globalization

The following table summarizes the globalization support available in the [SfPicker](https://www.syncfusion.com/maui-controls/maui-picker) control.

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
<td><a href="/maui/picker/overview">Picker</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[DatePicker](https://help.syncfusion.com/maui/datepicker/overview)** for selecting date values using a specialized picker interface.  
- **[DateTimePicker](https://help.syncfusion.com/maui/datetimepicker/overview)** for selecting combined date and time values.
- **[ComboBox](https://help.syncfusion.com/maui/combobox/overview)** for searchable dropdown-based selection with text input.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/picker/getting-started) - step-by-step guide to begin using the Picker control.
- [Mode](https://help.syncfusion.com/maui/picker/picker-mode) - choose between default, dialog, or custom display styles.
- [Columns Header](https://help.syncfusion.com/maui/picker/dealing-with-column-header) - add and customize headers for better clarity in multi‑column pickers.
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
<a href="https://www.syncfusion.com/maui-controls/maui-picker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Picker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/picker" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
