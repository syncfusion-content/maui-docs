---
layout: post
title: About .NET MAUI MaskedEntry control | Syncfusion®
description: Learn about the introduction of Syncfusion® MAUI MaskedEntry (SfMaskedEntry) control with essential features and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# .NET MAUI MaskedEntry Overview

The [.NET MAUI MaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) is an advanced version of the input control that restricts input of certain characters, text, and numbers by using a mask pattern. This control creates a template for providing information such as telephone numbers, email IDs, IP addresses, product keys, and more.

![MaskedEntry control overview in MAUI](MaskedEntry_Images/maui_maskedentry_overview.png)

## Business use cases

- Form-based applications that require **structured input such as phone numbers, email addresses, or identification numbers**.  
- Enterprise applications that enforce **validated and formatted data entry for critical fields**.  
- Financial and business systems that require **standardized input formats for codes, keys, or account numbers**.  
- Data entry applications that need **input validation and formatting to improve data accuracy and consistency**.  

## Key features

- **Mask type support** allows defining fixed or variable length input patterns using simple or regular expression masks.  
- **Prompt character customization** allows setting default placeholder characters when input is not provided.  
- **Value handling support** allows entering values and performing clipboard operations based on configured formats.  
- **Value mask format support** allows controlling how values are stored and displayed, including prompt characters and literals.  
- **UI customization support** allows modifying the appearance of the control to match application design.  

## Globalization

The following table summarizes the globalization support available in the [SfMaskedEntry](https://www.syncfusion.com/maui-controls/maui-masked-entry) control.

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
<td><a href="/maui/masked-entry/overview">Masked Entry</a></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[ComboBox](https://help.syncfusion.com/maui/combobox/overview)** for selecting values from predefined lists with optional input.
- **[DataForm](https://help.syncfusion.com/maui/dataform/overview)** for integrating masked input fields within forms.  
- **[TextInputLayout](https://help.syncfusion.com/maui/textinputlayout/overview)** for enhancing input fields with labels and validation UI.

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/masked-entry/getting-started) - step-by-step guide to begin using the MaskedEntry control.  
- [Mask Types](https://help.syncfusion.com/maui/masked-entry/mask-types) - configure mask patterns and input formats.  
- [Features](https://help.syncfusion.com/maui/masked-entry/basic-features) - built‑in options for validation, placeholders, and easy formatting.
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
<a href="https://www.syncfusion.com/maui-controls/maui-masked-entry" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/masked-entry" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>