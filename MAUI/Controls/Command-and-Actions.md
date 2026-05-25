---
layout: post
title: Command & Actions Controls | Syncfusion®
description: Controls that provide toolbars and command surfaces for organizing actions, enabling easy access to commands and improving overall user interaction and workflow efficiency.
platform: maui
control: Commands and Action Controls
documentation: ug
---

# Syncfusion<sup>®</sup> Commands and Actions Controls for .NET MAUI

Toolbars and command surfaces for invoking app-level and contextual actions. Use these controls to expose primary commands, organize actions and provide keyboard or touch affordances.

## Commands and Actions Controls

<style>
.container {
   display: grid;
   grid-template-columns: repeat(3, minmax(0, 1fr));
   gap: 16px;
   align-items: stretch;
   grid-auto-rows: 1fr;
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
}
.source-icon:hover {
  background: #0078D4;
  color: white;
}
.form-card {
   border: 1px solid #ddd;
   border-radius: 14px;
   overflow: hidden;
   background: #ffffff;
   box-sizing: border-box;
   min-width: 0;
   transition: 0.3s ease;
   /* IMPORTANT */
   height: 100%;
   display: flex;
   flex-direction: column;
}
.form-card:hover {
   transform: translateY(-2px);
   box-shadow: 0 6px 18px rgba(0,0,0,0.08);
}
.form-content {
   padding: 18px;
   /* IMPORTANT */
   flex: 1;
   display: flex;
   flex-direction: column;
}
.form-title {
   margin: 0;
   font-size: 22px;
   font-weight: 700;
   color: #111827;
}
.section-title {
   font-size: 14px;
   font-weight: 700;
   margin-top: 18px;
   margin-bottom: 8px;
   color: #374151;
}
.chips {
   display: flex;
   flex-wrap: wrap;
   gap: 8px;
   /* keeps chips aligned nicely */
   align-content: flex-start;
}
.chip {
   background: #e0ecff;
   color: #1e3a8a;
   padding: 6px 12px;
   border-radius: 8px;
   font-size: 12px;
   font-weight: 600;
}
@media (max-width: 900px) {
   .container {
       grid-template-columns: repeat(2, 1fr);
   }
}
@media (max-width: 600px) {
   .container {
       grid-template-columns: 1fr;
   }
}
</style>

<div style="display:flex; flex-wrap:wrap; gap:20px; margin-top:20px;">
<!-- Card 1 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/stockoverview.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Toolbar
<a href="https://help.syncfusion.com/maui/toolbar/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8" stroke-linecap="round" stroke-linejoin="round">
  <path d="M21 6H8"></path>
  <path d="M21 12H3"></path>
  <path d="M21 18H8"></path>
  <circle cx="3.5" cy="6" r="1"></circle>
  <circle cx="14.5" cy="12" r="1"></circle>
  <circle cx="3.5" cy="18" r="1"></circle>
</svg>
</a>
</h3>
<div class="form-description">
              The .NET MAUI Toolbar (SfToolbar) control is a flexible UI control that provides configurable action items for seamless user interaction, enhancing application usability.

</div>
</div>
</div>

</div>

[Back to Controls Catalog](ControlsCatalog.md)
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