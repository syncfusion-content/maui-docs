---
layout: post
title: About .NET MAUI Text Input Layout control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control, its elements and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui leading icon entry.
---

# .NET MAUI Text Input Layout (SfTextInputLayout) Overview

The text input layout adds decorative elements like floating labels, icons, and assistive labels on top of input views such as [`Entry`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry) and [`Editor`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor), [`SfAutocomplete`](https://help.syncfusion.com/maui/autocomplete/overview), [`SfComboBox`](https://help.syncfusion.com/maui/combobox/overview) controls.

![The customizable text input layout control for .NET MAUI](images/Overview/net_maui_text_input_layout.gif)

## Business use cases

- Form-based applications that require structured and visually enhanced input fields for better usability.  
- Login and authentication screens that use floating labels and password visibility controls.  
- Data entry applications that provide validation messages and guidance using assistive labels.  
- Business applications that require consistent input styling across multiple form fields.  

## Key features

- **Floating label** allows displaying labels that move dynamically based on focus and input state.  
- **Error label** allows showing validation messages for incorrect or missing input.  
- **Container style** allows choosing between filled and outlined input styles.  
- **Leading and trailing icon** allows adding icons to enhance visual clarity and usability.  
- **Assistive label** allows displaying help or hint text below input fields.  
- **Password visibility** allows toggling password input visibility for better user experience.  

## Globalization

The following table summarizes the globalization support available in this control.

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
<td><a href="/maui/textinputlayout/overview">Text Input Layout</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [Masked Entry](https://help.syncfusion.com/maui/masked-entry/overview) for formatted and validated text input.  
- [Numeric Entry](https://help.syncfusion.com/maui/numericentry/overview) for numeric data input with formatting support.
- [ComboBox](https://help.syncfusion.com/maui/combobox/overview) for selection-based input with dropdown functionality.  

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/textinputlayout/getting-started) shows a step‑by‑step guide to begin using the Text Input Layout control.  
- [Font Customization](https://help.syncfusion.com/maui/textinputlayout/custom-font) explains how to adjust fonts to match the app’s style.  
- [States & Colors](https://help.syncfusion.com/maui/textinputlayout/states-and-colors) helps apply colors and states to give clear visual feedback.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-textinputlayout" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/TextInputLayout" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/textinputlayout" class="form-card" target="_blank">
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
