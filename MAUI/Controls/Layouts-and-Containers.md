---
layout: post
title: Layouts & Containers | Syncfusion®
description: Layout and container components that organize UI elements, enabling responsive design, proper alignment, and efficient screen space usage.
platform: maui
control: Layouts & Containers
documentation: ug
---

# Syncfusion<sup>®</sup> Layouts and Containers for .NET MAUI

Container and layout primitives used to compose responsive and adaptive UI screens. These controls let you structure content, present overlays, and create polished, modular layouts for production apps.

## Layouts and Containers

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
<h3 class="form-title">BackDrop
<a href="https://help.syncfusion.com/maui/backdrop/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
              The .NET MAUI Backdrop is a specialized page with two surfaces, a back layer and a front layer stacked one above the other. The back layer holds options such as navigation, filtration, and more, which updates the front layer content on performing certain actions.
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
<h3 class="form-title">ListView
<a href="https://help.syncfusion.com/maui/listview/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
               The .NET MAUI ListView control is used to present lists of data in a vertical or horizontal orientation with different layouts virtually. It supports essential features such as selection, template selectors, horizontal and vertical orientation, load more, autofitting items, and more. 
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
<h3 class="form-title">Popup
<a href="https://help.syncfusion.com/maui/popup/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
               The .NET MAUI Popup control displays an alert message with customized buttons or a desired view inside a pop-up. Users can completely customize the pop-up’s appearance and functionality, including its header, body, and footer.
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
<h3 class="form-title">Text Input Layout
<a href="https://help.syncfusion.com/maui/textinputlayout/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
              The .NET MAUI Text Input Layout or Label Entry is a container control that allows users to add floating labels, password toggle icons to show or hide passwords, leading and trailing icons, and assistive labels such as error messages and help text on top of input controls.
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
<h3 class="form-title">Expander
<a href="https://help.syncfusion.com/maui/expander/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
               The Syncfusion .NET MAUI Expander is a layout control capable of loading any UI view in both header and content sections. By simply tapping the header, users can effortlessly expand or collapse the control.
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
<h3 class="form-title">Accordion
<a href="https://help.syncfusion.com/maui/accordion/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
               The .NET MAUI Accordion control or Accordion Panels offers a vertically collapsible panel with stacked headers, allowing users to expand or collapse one or multiple items simultaneously to display content. 
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
<h3 class="form-title">Carousel
<a href="https://help.syncfusion.com/maui/carousel-view/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
              The .NET MAUI Carousel control is an intuitive interface for navigating through a collection of views. This control supports both scaling and rotation transformations for enhanced visual effects, or can be used without them, depending on your design needs.
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
<h3 class="form-title">Cards
<a href="https://help.syncfusion.com/maui/cards/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
               The Syncfusion .NET MAUI Cards control allows you to create removable cards or a stack of cards. You can organize a sequence of cards where only one card is visible at a time. You can easily navigate through the stack by swiping to reveal the next card in the sequence.
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
<h3 class="form-title">Parallax View
<a href="https://help.syncfusion.com/maui/parallax-view/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
               The .NET MAUI Parallax View is a visual effect that binds the scroll position of a foreground element (e.g., a list) to a background element and moves the background element at a different speed.
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
<h3 class="form-title">DocLayout
<a href="https://help.syncfusion.com/maui/docklayout/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8">
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
              The .NET MAUI Dock Layout is a flexible layout container that allows UI elements to be docked to the top, bottom, left, or right edges of the container, or fill the remaining space.
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