---
layout: post
title: About .NET MAUI Rich Text Editor control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control, its elements and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# .NET MAUI Rich Text Editor (SfRichTextEditor) Overview

The .NET MAUI Rich Text Editor provides a simple yet powerful editor interface to compose richly formatted text with all the common formatting options like bold and italics. The Rich Text Editor is used to create messaging applications, email composers, blog editors, forum post text boxes, feedback and review sections, notes sections, and more. It has a variety of tools to edit and format rich content and returns valid HTML markup content.

![RichTextEditor Overview Image](images/rich-text-editor-overview.png)

## Business use cases

- Messaging and email applications that require **rich text composition with formatting options**.  
- Content management systems that allow users to **create and edit blogs, articles, or posts**.  
- Feedback and review sections that support **formatted text input with links, lists, and styling**.  
- Note-taking applications that require **structured and visually formatted content editing**.  

## Key features

- **WYSIWYG editing** allows editing content visually with real-time formatting feedback.  
- **Comprehensive formatting tools** allow applying styles such as bold, italic, underline, font size, color, alignment, lists, and indentation.  
- **Hyperlink support** allows inserting and editing links within the content.  
- **Image and table insertion** allows embedding media and structured data within the editor.  
- **Customizable toolbar** allows configuring toolbar actions and visibility based on application requirements.  
- **Clipboard operation** allows copy, paste, and cut actions for efficient editing.  
- **Undo and redo** allows managing editing history for better user control. 

## Globalization

The following table summarizes the globalization support available in the [SfRichTextEditor](https://www.syncfusion.com/maui-controls/maui-rich-text-editor) control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="../Images/no-support.svg" alt="no-support" width="16" align="center"/> No Support   

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
<td><a href="/maui/rich-text-editor/overview">Rich Text Editor</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[MarkdownViewer](https://help.syncfusion.com/maui/markdownviewer/overview)** for rendering formatted Markdown content in applications.  
- **[TextInputLayout](https://help.syncfusion.com/maui/textinputlayout/overview)** for enhancing simple text input fields with labels and validation.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/rich-text-editor/getting-started) - step-by-step guide to begin using the Rich Text Editor control.  
- [Toolbar](https://help.syncfusion.com/maui/rich-text-editor/toolbar) - configure toolbar items and actions.  
- [Customization](https://help.syncfusion.com/maui/rich-text-editor/customization) - adjust look, behavior, and features to match your needs.
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
<a href="https://www.syncfusion.com/maui-controls/maui-rich-text-editor" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/RichTextEditor" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/rich-text-editor" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
