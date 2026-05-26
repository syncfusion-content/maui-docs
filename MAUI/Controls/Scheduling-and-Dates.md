---
layout: post
title: Scheduling & Dates Control | Syncfusion®
description: Controls that provide calendar and scheduling functionalities, enabling users to view dates, manage events, and organize tasks efficiently within applications.
platform: maui
control: Scheduling & Dates Control
documentation: ug
---

# Syncfusion<sup>®</sup> Scheduling and Dates Control for .NET MAUI

Calendar and scheduling controls for appointments, availability and timeline coordination. These components provide day/week/month views, resource scheduling and interaction patterns for booking scenarios.

## Scheduling and Dates Control

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
<h3 class="form-title">Calendar
<a href="https://help.syncfusion.com/maui/calendar/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8" >
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
              Displays dates in a calendar view, allowing users to select and view specific days.
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
<h3 class="form-title">Scheduler
<a href="https://help.syncfusion.com/maui/scheduler/overview"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
     width="18" height="18" viewBox="0 0 24 24"
     fill="none" stroke="currentColor" stroke-width="1.8" >
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
               Helps manage events and appointments by organizing them across days, weeks, or months.
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