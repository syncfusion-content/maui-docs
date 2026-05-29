---
layout: post
title: AI Components for .NET MAUI | Syncfusion®
description: Explore Syncfusion® AI-powered controls for .NET MAUI to build intelligent, interactive, and productivity-focused applications.
platform: maui
control: AI Components
documentation: ug
---

# Syncfusion<sup>®</sup> AI Components for .NET MAUI

Syncfusion® AI components for .NET MAUI provide a range of intelligent controls designed to enhance desktop and mobile applications with advanced, AI-driven capabilities. These tools integrate seamlessly with modern AI services to deliver smart data processing, conversational experiences, predictive interactions, and automation, enabling developers to create more efficient and user-centric applications.

## AI Controls

<style>
.form-card {
   flex: 0 0 calc(33.33% - 14px);
   border: 1px solid #ddd;
   border-radius: 12px;
   overflow: hidden;
   background: white;
   box-sizing: border-box;
   transition: 0.3s ease;
   cursor: pointer;
}
.form-card:hover {
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
<div class="form-card" data-target="ai-assist-view">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/maui-aiassistview-getting-started.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">AI Assist View</a></h3>
<div class="form-description">
              Provides AI-based chat interactions and helpful context-aware assistance.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/maui-aiassistview-getting-started.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/smartdatagrid/overview">Smart DataGrid</a></h3>
<div class="form-description">
               Provides intelligent data analysis with AI-driven insights, filtering, and automation.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/maui-aiassistview-getting-started.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/smartscheduler/overview">Smart Scheduler</a></h3>
<div class="form-description">
               Simplifies event management using natural language input and AI-assisted scheduling.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/maui-aiassistview-getting-started.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/smarttexteditor/overview">Smart Text Editor</a></h3>
<div class="form-description">
                 Enhances typing with AI-powered autocomplete and contextual text suggestions.
</div>
</div>
</div>

</div>
<!-- Popup Modal -->
<div id="imageModal">
<span class="close-popup" onclick="closeImage()">
&times;
</span>
<img id="popupImage">
</div>
<script>
function openImage(src) {
   document.getElementById("imageModal").style.display = "flex";
   document.getElementById("popupImage").src = src;
}
function closeImage() {
   document.getElementById("imageModal").style.display = "none";
}
/* Close when clicking outside image */
document.getElementById("imageModal").addEventListener("click", function(e) {
   if (e.target.id === "imageModal") {
       closeImage();
   }
});
</script>