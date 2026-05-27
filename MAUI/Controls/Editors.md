---
layout: post
title: Editors | Syncfusion®
description: Controls that collect user input through forms, including text fields, selections, and validation features to ensure accurate and efficient data entry.
platform: maui
control: Editors
documentation: ug
---

# Syncfusion<sup>®</sup> Editors for .NET MAUI

Form controls and editors used for collecting, validating and formatting user input. These controls include pickers, masked inputs and advanced form layouts to simplify data entry patterns.

## Editors
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
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Autocomplete</a></h3>
<div class="form-description">
              The .NET MAUI Autocomplete control is highly optimized to load and populate suggestions quickly.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">ComboBox</a></h3>
<div class="form-description">
               Represents data as portions of a circle, such as pie or donut charts.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Data form</a></h3>
<div class="form-description">
               The .NET MAUI DataForm displays and edits data using customizable input fields with support for validation and flexible layouts.
</div>
</div>
</div>
<!-- Card 1 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Date Picker</a></h3>
<div class="form-description">
              The .NET MAUI Date Picker is a fully customizable component that lets you easily select a date from a list of dates.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Date Time Picker</a></h3>
<div class="form-description">
               The .NET MAUI Date Time Picker lets users select both date and time with customizable options.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Masked Entry</a></h3>
<div class="form-description">
               The .NET MAUI Masked Entry lets users enter data in a specific format using predefined input patterns.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Numeric Entry</a></h3>
<div class="form-description">
              The .NET MAUI Numeric Entry lets users enter numbers with limits like minimum and maximum values.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Picker</a></h3>
<div class="form-description">
               The Syncfusion .NET MAUI Picker lets users choose items from a list with customizable layout and options.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Signature Pad</a></h3>
<div class="form-description">
              The .NET MAUI Signature Pad lets users draw and save smooth digital signatures as images.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Rating</a></h3>
<div class="form-description">
              The .NET MAUI Rating control lets users choose a rating using stars, hearts, or custom symbols.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Image Editor</a></h3>
<div class="form-description">
               The .NET MAUI Image Editor lets users easily edit images by cropping, rotating, zooming, and applying filters.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Time Picker</a></h3>
<div class="form-description">
               The Syncfusion .NET MAUI Time Picker lets users select a time with customizable format and layout.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Color Picker</a></h3>
<div class="form-description">
              The Syncfusion .NET MAUI Color Picker lets users choose colors from palettes or a color spectrum.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Rich Text Editor</a></h3>
<div class="form-description">
              The .NET MAUI Rich Text Editor lets users create and format text with options like bold and italics. 
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