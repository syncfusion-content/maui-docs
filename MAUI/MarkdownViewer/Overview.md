---
layout: post
title: About .NET MAUI MarkdownViewer control | Syncfusion
description: Learn about the Syncfusion® .NET MAUI SfMarkdownViewer control, its rendering capabilities, and key features.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# .NET MAUI SfMarkdownViewer Overview

The .NET MAUI [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) is a lightweight and efficient UI control that enables developers to render Markdown content with full formatting support. It provides a seamless way to display documentation, help content, release notes, and other rich text formats in both mobile and desktop applications.

![.NET MAUI MarkdownViewer](Images/maui-markdown-viewer-overview.png)

## Business use cases

- Applications that display in-app documentation such as User guides and Onboarding content.  
- Software products that present release notes and feature updates in a structured and readable format.  
- Help and support modules that provide FAQs, troubleshooting guides, and instructional content.  
- Content-driven applications that require rendering external or dynamic Markdown-based data.  

## Key features

- **Standard Markdown rendering support** allows displaying headings, bold text, lists, tables, images, and code blocks with proper formatting.  
- **Flexible input source support** allows loading Markdown content from local files, embedded resources, or strings.  
- **Smooth scrolling support** allows navigating large Markdown documents with a fluid user experience across devices.  
- **Automatic link rendering support** allows handling hyperlinks for external navigation or internal app navigation. 

## Globalization

The following table summarizes the globalization support available in this control.

<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/full-support.svg" alt="full-support" width="16">
    <span>Full Support</span>
</div>
<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/no-support.svg" alt="no-support" width="16">
    <span>No Support</span>
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
<td><a href="/maui/markdownviewer/overview">Markdown Viewer</a></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [RichTextEditor](https://help.syncfusion.com/maui/rich-text-editor/overview) for editing rich text content within applications.
- [ListView](https://help.syncfusion.com/maui/listview/overview) for presenting structured content alongside Markdown views. 
- [TextInputLayout](https://help.syncfusion.com/maui/textinputlayout/overview) for capturing and structuring input that can be used to create or update Markdown content.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/markdownviewer/gettingstarted) shows a step‑by‑step guide to begin using the MarkdownViewer control.  
- [Data Binding](https://help.syncfusion.com/maui/markdownviewer/databinding) explains how to bind markdown content from local files or data sources to display formatted text easily.  
- [Customization](https://help.syncfusion.com/maui/markdownviewer/appearance) helps customize appearance and behavior of the control.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-markdown-viewer" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/MarkdownViewer" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/markdown-viewer" class="form-card" target="_blank">
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
