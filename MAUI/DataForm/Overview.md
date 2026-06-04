---
layout: post
title: Overview of .NET MAUI DataForm control | Syncfusion
description: Learn about the introduction of Syncfusion<sup>&reg;</sup> .NET MAUI DataForm(SfDataForm) control in mobile and desktop applications.
platform: maui
control: SfDataForm
documentation: ug
---
 
# Overview of .NET MAUI DataForm (SfDataForm)

The Syncfusion<sup>&reg;</sup> .NET MAUI DataForm (SfDataForm) control is used to create or edit data form such as login, reservation, contact, employee form and more based on the business purpose. 

## Business use cases

- Business applications that require **dynamic form generation for data entry such as employee, customer, or product forms**.  
- Registration and login workflows that require **validated user input and structured form layouts**.  
- Enterprise applications that handle **data editing and validation across multiple fields and sections**.  
- Mobile and desktop apps that require **consistent and reusable form UI across platforms**.  

## Key features

- **Built-in editor support** allows using predefined editors such as text, password, multiline, combo box, autocomplete, date, time, checkbox, switch, and radio group based on data types.  
- **Custom editor support** allows adding custom input controls when default editors do not meet specific requirements.  
- **Validation support** allows validating user input and displaying messages to ensure accurate data entry.  
- **Commit mode configuration** allows controlling when user input is committed to the underlying data object.  
- **Flexible layout and grouping** allows arranging fields using linear or grid layouts and organizing them into logical sections.  
- **Appearance customization** allows styling editors, labels, and group headers to match application themes.  

## Globalization

The following table summarizes the globalization support available in the [SfDataForm](https://www.syncfusion.com/maui-controls/maui-dataform) control.

<img src="Images/globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
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
<td><a href="/maui/dataform/overview">DataForm</a></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr>
</table>

## Related controls

- **[ComboBox](https://help.syncfusion.com/maui/combobox/overview)** for providing dropdown-based selection in forms.  
- **[DatePicker](https://help.syncfusion.com/maui/datepicker/overview)** for capturing date inputs within forms.  
- **[TextInputLayout](https://help.syncfusion.com/maui/textinputlayout/overview)** for enhancing input fields with labels and validation.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/dataform/getting-started) - step-by-step guide to begin using the DataForm control.  
- [Data Editors](https://help.syncfusion.com/maui/dataform/editors) - explore built-in and custom editor configurations.  
- [Validation](https://help.syncfusion.com/maui/dataform/validation) - configure validation rules and behaviors. 
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
<a href="https://www.syncfusion.com/maui-controls/maui-dataform" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/DataForm" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/dataform" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>