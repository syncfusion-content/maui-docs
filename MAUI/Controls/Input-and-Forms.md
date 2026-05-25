---
layout: post
title: Input & Forms Control | Syncfusion®
description: Controls that collect user input through forms, including text fields, selections, and validation features to ensure accurate and efficient data entry.
platform: maui
control: Input & Forms Control
documentation: ug
---

# Syncfusion<sup>®</sup> Input and Forms Control for .NET MAUI

Form controls and editors used for collecting, validating and formatting user input. These controls include pickers, masked inputs and advanced form layouts to simplify data entry patterns.

## Input and Forms Control

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
@keyframes zoomIn {
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
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/stockoverview.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Autocomplete
<a href="https://help.syncfusion.com/maui/autocomplete/overview"
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
              The .NET MAUI Autocomplete control is highly optimized to load and populate suggestions quickly from large amounts of data depending on the user’s input characters. It allows users to select an item from the suggestion list. It displays the selected item in the input view with the text and clear button.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">ComboBox
<a href="https://help.syncfusion.com/maui/combobox/overview"
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
               Represents data as portions of a circle, such as pie or donut charts.The .NET MAUI ComboBox control is a selection component that allows users to type a value or choose an option from a list of predefined options. It has many features, such as data binding, editing, searching, and button customization.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">DataForm
<a href="https://help.syncfusion.com/maui/dataform/overview"
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
               The .NET MAUI DataForm control is used to display and edit data using a wide range of built-in and custom editors for any kind of data form, such as login, reservation, employee information forms, contact forms, and more. It supports data validation, data handling, grouping, and linear and grid layouts. Users can easily customize editors, groups, labels, and validation labels’ appearances.
</div>
</div>
</div>
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
<h3 class="form-title">Date Picker
<a href="https://help.syncfusion.com/maui/datepicker/overview"
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
              The Syncfusion® .NET MAUI Date Picker (SfDatePicker) is a fully customizable component that lets you easily select a date from a list of dates.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Date Time Picker
<a href="https://help.syncfusion.com/maui/datetimepicker/overview"
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
               The AI-powered .NET MAUI Smart DataGrid (.NET MAUI Smart Grid) combines all the essentials-sorting, grouping, filtering, and styling-with intelligent AI features that save time and boost productivity. Users can leverage AI to automatically organize records, apply smart filters, and highlight specific cells or rows for quick insights
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">MaskedEntry
<a href="https://help.syncfusion.com/maui/masked-entry/overview"
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
               The .NET MAUI Masked Entry is an advanced input control that restricts user input to certain characters using a mask pattern. This control is used to create templates for providing information such as telephone numbers, email IDs, IP addresses, and product keys.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/stockoverview.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">NumericEntry
<a href="https://help.syncfusion.com/maui/numericentry/overview"
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
              The Numeric Entry control for .NET MAUI offers an intuitive and touch-friendly interface for providing numeric input in various numeric formats. Users can easily restrict input by specifying minimum and maximum values
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Picker
<a href="https://help.syncfusion.com/maui/picker/overview"
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
               The Syncfusion .NET MAUI Picker (SfPicker) is a fully customizable component that lets you select an item from a list. It supports multiple-column layout and header, footer, and selection view customizations.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">SignaturePad
<a href="https://help.syncfusion.com/maui/signaturepad/overview"
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
              The .NET MAUI Signature Pad is an interactive UI control that allows users to capture smooth and realistic signatures. Users can save their signatures as images and sync them across devices and documents that need signatures. 
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/stockoverview.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Rating
<a href="https://help.syncfusion.com/maui/rating/overview"
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
              The .NET MAUI Rating control allows users to select a rating value from a group of visual symbols like stars, hearts, or custom shapes.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Image Editor
<a href="https://help.syncfusion.com/maui/imageeditor/overview"
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
               The .NET MAUI Image Editor component allows you to edit and enhance images easily. It has built-in support to crop, rotate, flip, zoom, and apply filters to images.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/healthcare.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Time Picker
<a href="https://help.syncfusion.com/maui/timepicker/overview"
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
               The Syncfusion® .NET MAUI Time Picker (SfTimePicker) is a fully customizable control that lets you select a time. It supports the customization of the format, header, footer, and selection view. It can be opened as a dialog.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/stockoverview.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Color Picker
<a href="https://help.syncfusion.com/maui/colorpicker/overview"
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
              The Syncfusion .NET MAUI Color Picker is a UI component that allows users to select colors from various color palettes or a spectrum, making it a valuable design tool for customization within the .NET MAUI application.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Images/DashboardImages/stockoverview.webp"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title">Rich Text Editor
<a href="https://help.syncfusion.com/maui/rich-text-editor/overview"
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
              The .NET MAUI Rich Text Editor provides a simple yet powerful editor interface for composing richly formatted text with all the common formatting options like bold and italics. 
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