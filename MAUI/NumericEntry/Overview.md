---
layout: post
title: About .NET MAUI NumericEntry Control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI NumericEntry (SfNumericEntry) control, its features, and more.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# .NET MAUI NumericEntry Overview

The [.NET MAUI NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control is designed to provide a user-friendly and advanced input experience for numeric values. It supports a wide range of numeric formats, including currency, percentages, decimals, and more. With its key features, it enables enhanced user experience and facilitates input validation.

## Control Structure

![.NET MAUI NumericEntry structure](Overview_images/overview_img.png)

## Business use cases

- Financial applications that require **currency, percentage, or decimal value input with validation**.  
- Form-based applications that collect **numeric data such as quantity, price, or measurements**.  
- Business systems that enforce **accurate numeric input with formatting and validation rules**.  
- Data-driven applications that require **increment and decrement functionality for numeric adjustments**.  

## Key features

- **Validation** allows validating numeric input when focus is lost or when the enter key is pressed.  
- **Increment and decrement** allows adjusting values easily using built-in up and down buttons.  
- **Flexible formatting** allows displaying values in formats such as currency, percentage, and decimals.  
- **Culture-aware formatting** allows adapting value display based on regional and cultural settings.  
- **Placeholder** allows displaying hint text when the control contains an empty or null value.  

## Globalization

The following table summarizes the globalization support available in the [SfNumericEntry](https://www.syncfusion.com/maui-controls/maui-numeric-entry) control.

<img src="globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="globalization/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable

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
<td><a href="/maui/numericentry/overview">Numeric Entry</a></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr>
</table>

## Related controls

- **[ComboBox](https://help.syncfusion.com/maui/combobox/overview)** for selecting values from predefined lists.
- **[MaskedEntry](https://help.syncfusion.com/maui/masked-entry/overview)** for formatted and restricted input scenarios. 

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/numericentry/getting-started) - step-by-step guide to begin using the NumericEntry control.
- [Features](https://help.syncfusion.com/maui/numericentry/basic-features) - learn core capabilities like validation and culture support.
- [Formatting](https://help.syncfusion.com/maui/numericentry/formatting) - configure numeric formats and display.    
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
<a href="https://www.syncfusion.com/maui-controls/maui-numeric-entry" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/numeric-entry" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>

