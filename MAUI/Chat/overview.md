---
layout: post
title: About .NET MAUI Chat Control | Syncfusion
description: Learn here all about Introduction of the Syncfusion .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: Chat
documentation: ug
---

# Overview of .NET MAUI Chat (SfChat)

The Syncfusion .NET MAUI Chat control offers a contemporary conversational chatbot experience, allowing for flexible customization of the layout to display conversations between two or more users.

    ![overview in .NET MAUI SfChat](Images/maui-chat-overview.png)

## Business use cases

- Messaging applications that require **real-time conversations and rich chat interfaces**.  
- Customer support systems that provide **chat-based assistance and automated responses**.  
- AI chatbot integrations that enable **interactive user engagement with intelligent replies**.  
- Collaboration tools that involve **team communication and message history management**.

## Key features

- **Rich Message Types** including text, images, cards, calendar, and hyperlinks
- **Message Grouping** with time breaks for better readability
- **Typing Indicators** to show real‑time user activity
- **Quick Suggestions** for faster replies and reduced typing effort
- **Load More Messages** to handle long chat histories smoothly 

    ![.NET MAUI Chat Overview](Images/maui-chat-overview.png) 

## Globalization

The following table summarizes the globalization support available in the [SfChat](https://www.syncfusion.com/maui-controls/maui-chat) control.

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
<td><a href="/maui/chat/overview">Chat</a></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/globalization/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="Images/globalization/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="Images/globalization/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related Controls

- **[AIAssistView](https://help.syncfusion.com/maui/aiassistview/overview)** – integrate AI‑powered responses and conversational experiences into your app.  

## Next Step

Explore further:

- [Getting Started](https://help.syncfusion.com/maui/chat/getting-started) – step‑by‑step guide to begin using the Chat control.  
- [Styles Guide](https://help.syncfusion.com/maui/chat/styles) – learn how to customize message styles, editor appearance, and overall chat layout.  
- [Suggestions](https://help.syncfusion.com/maui/chat/suggestions) – provide quick reply options to improve conversational flow and user interaction.

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
<a href="https://www.syncfusion.com/maui-controls/maui-chat" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Chat" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/chat" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
