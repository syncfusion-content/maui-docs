---
layout: post
title: ControlsCatalog | Syncfusion®
description: Controls catalog that displays grouped components as interactive cards with images, descriptions, and links for quick discovery.
platform: maui
control: Controls Catalog
documentation: ug
---

# Syncfusion<sup>®</sup> Controls Catalog for .NET MAUI

This document provides a comprehensive collection of UI components organized into meaningful categories to help you build modern, interactive, and user-friendly .NET MAUI applications. Each category groups related controls, making it easier to explore, understand, and implement the right components for your app’s design and functionality needs.

## Controls Catalog

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
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls\Grids">Grids</a></h3>
<div class="form-description">
               Provides controls to display, organize, and manage large datasets efficiently.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Editors">Editors</a></h3>
<div class="form-description">
               Offers a wide range of controls for collecting and validating user input.
</div>
</div>
</div>
<!-- Card 1 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Navigation">Navigation</a></h3>
<div class="form-description">
              Enables smooth navigation across different sections of an application. 
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Sliders">Sliders</a></h3>
<div class="form-description">
               Provides controls that allow users to interact and adjust values dynamically. 
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/ConversationalUI">Conversational UI</a></h3>
<div class="form-description">
               Supports chat and messaging-based user interactions. 
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/DataVisualization">Data Visualizations</a></h3>
<div class="form-description">
              Visualizes data using various charts and graphical components.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Layouts">Layouts</a></h3>
<div class="form-description">
               Provides containers to arrange and structure UI elements.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Notification">Notification</a></h3>
<div class="form-description">
              Displays system status and progress to users in real time.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/ProjectManagement">Project Management</a></h3>
<div class="form-description">
              Helps organize and manage tasks visually.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Toolbar">Toolbar</a></h3>
<div class="form-description">
              Provides quick access to commonly used actions and commands. 
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Calendars">Calendars</a></h3>
<div class="form-description">
                Manages date-based data, events, and scheduling features.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Buttons">Buttons</a></h3>
<div class="form-description">
              Includes controls for selecting options and triggering actions.
</div>
</div>
</div>
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Visual-Enhancements">Visual Enhancements</a></h3>
<div class="form-description">
              Adds visual effects and styling to improve UI appearance.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div style="background:#eef2ec; text-align:center;">
<img src="Controls/Images/AllControl.png"
                loading="lazy"
                decoding="async"
                class="form-image"
                onclick="openImage(this.src, event)">
</div>
<div class="form-content">
<h3 class="form-title"><a class="form-link" href="Controls/Viewer">Viewer</a></h3>
<div class="form-description">
              Displays and renders different types of content within the app.
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