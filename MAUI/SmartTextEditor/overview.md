---
layout: post
title: About .NET MAUI AI-Powered Text Editor control | Syncfusion®
description: Learn about the overview of Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Text Editor (SfSmartTextEditor) control, its basic features.
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Overview of .NET MAUI Smart Text Editor

Syncfusion [.NET MAUI AI-Powered Text Editor](https://www.syncfusion.com/maui-controls/maui-smart-texteditor) (SfSmartTextEditor) is a multiline input control that accelerates typing with predictive suggestions. It supports inline and popup suggestion display, can integrate with an AI inference service for context aware completions, and falls back to your custom phrase list when AI is unavailable. The control provides full text styling, placeholder customization, and command/event hooks for text changes.

![Overview in .NET MAUI Smart Text Editor.](images/overview/maui-smarttexteditor-overview.gif)

## Business use cases

- Messaging and chat applications that require predictive text suggestions for faster communication.  
- Content creation tools that support AI-assisted writing and text completion.  
- Form-based applications that enhance user input experience with intelligent suggestions.  
- Productivity applications that require context-aware text entry with improved accuracy and speed.  

## Key features

- **Suggestion display mode** allows presenting suggestions inline or in popup mode based on user interaction.  
- **AI-powered suggestion** allows generating context-aware completions using AI inference services.  
- **Custom phrase fallback** allows using predefined phrases when AI suggestions are not available.  
- **Maximum length validation** allows restricting input length for controlled data entry.  
- **Keyboard interaction** allows accepting suggestions quickly using keys such as Tab or arrow keys.  
- **Touch interaction** allows selecting suggestions through tap or click gestures.  
- **Placeholder text** allows configuring placeholder text with style options.  
- **Customization** allows modifying fonts, colors, sizes, and layout for consistent UI design.  

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
<td><a href="/maui/smarttexteditor/overview">Smart Text Editor</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
</tr> 
</table>

## Related controls

- [RichTextEditor](https://help.syncfusion.com/maui/rich-text-editor/overview) for editing and formatting rich text content.
- [MarkDownViewer](https://help.syncfusion.com/maui/markdownviewer/overview) for displaying formatted Markdown content.
- [TextInputLayout](https://help.syncfusion.com/maui/textinputlayout/overview) for enhancing input fields with labels and validation UI.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/smarttexteditor/getting-started) shows a step‑by‑step guide to begin using the Smart Text Editor control.  
- [Suggestions](https://help.syncfusion.com/maui/smarttexteditor/suggestion-display-mode) explains how to configure suggestion behavior and AI integration.  
- [Customization](https://help.syncfusion.com/maui/smarttexteditor/customization) helps customize appearance and interaction settings.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-smart-texteditor" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartComponents" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore Blogs</h3>
    <div class="form-description">
      Read insights, tutorials, and developer journeys.
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
