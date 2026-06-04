---
layout: post
title: Overview | .NET MAUI Radio Button | Syncfusion®
platform: maui
description: Learn about the overall key features in Syncfusion® .NET MAUI Radio Button (SfRadioButton) control, its elements, and more.
control: SfRadioButton
---

# .NET MAUI Radio Button (SfRadioButton) Overview

The .NET MAUI Radio Button is a selection control that allows users to select one option from a set. The two states of the Radio Button are checked and unchecked.

## Business use cases

- Form-based applications that require **single selection from multiple options such as gender, plan type, or preferences**.  
- Survey and questionnaire systems that collect **user responses using exclusive selection inputs**.  
- Settings pages that allow users to **choose one option from predefined configurations**.  
- Business applications that require **clear and structured decision-based input controls**.  

## Key features

- **Single selection** allows choosing only one option from a group of radio buttons.  
- **Tap interaction** allows users to select options easily through touch input.  
- **Appearance customization** allows modifying color and label text to match application themes.  
- **Grouped behavior** allows logically grouping radio buttons for exclusive selection scenarios.  

   ![.NET MAUI Radio Button](Images/Getting-Started/radiobuttonoverview.png)

## Globalization

The following table summarizes the globalization support available in the [SfRadioButton](https://www.syncfusion.com/maui-controls/maui-radio-button) control.

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
<td><a href="/maui/radio-button/overview">Radio Button</a></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[CheckBox](https://help.syncfusion.com/maui/checkbox/overview)** for handling multiple selection scenarios.  
- **[Switch](https://help.syncfusion.com/maui/switch/overview)** for toggle-based on and off interactions.  
- **[DataForm](https://help.syncfusion.com/maui/dataform/overview)** for integrating selection controls within forms.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/radio-button/getting-started) - step-by-step guide to begin using the Radio Button control.  
- [Customization](https://help.syncfusion.com/maui/radio-button/visual-customization) - customize appearance and behavior.  
- [Grouping](https://help.syncfusion.com/maui/radio-button/grouping) - configure grouping and selection logic.
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
<a href="https://www.syncfusion.com/maui-controls/maui-radio-button" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/radio-button" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
