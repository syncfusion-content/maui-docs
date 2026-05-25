---
layout: post
title: ControlsCatalog
description: Controls catalog showing grouped components as clickable cards with image, description and navigation links.
platform: maui
control: Controls Catalog
documentation: ug
---

# Controls Catalog

This document provides a comprehensive collection of UI components organized into meaningful categories to help you build modern, interactive, and user-friendly .NET MAUI applications. Each category groups related controls, making it easier to explore, understand, and implement the right components for your app’s design and functionality needs.

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
<h3 class="form-title">AI and Smart Experiences
<a href="Controls\AI-and-Smart-Experiences.md"
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
              Includes intelligent components powered by AI to enhance automation and user productivity. These controls provide smart suggestions and context-aware interactions. Helps create modern, adaptive application experiences.
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
<h3 class="form-title">Data Management
<a href="Controls\Data-Management.md"
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
               Provides controls to display, organize, and manage large datasets efficiently.Supports features like sorting, filtering, and editing. Ensures smooth handling of structured data in applications
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
<h3 class="form-title">Input and Forms
<a href="Controls\Input-and-Forms.md"
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
               Offers a wide range of controls for collecting and validating user input. Supports text, numbers, dates, and selections in structured forms. Improves data entry experience and usability.
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
<h3 class="form-title">Navigation and Structure
<a href=Controls\Navigation-and-Structure.md"
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
              Enables smooth navigation across different sections of an application. Helps organize content and improve overall app structure. Enhances user flow and accessibility.
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
<h3 class="form-title">Interactive Controls
<a href="Controls\Interactive-Controls.md"
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
               Provides controls that allow users to interact and adjust values dynamically. Includes sliders and selectors for better control input. Improves user engagement and usability.
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
<h3 class="form-title">Conversational Experiences
<a href="Controls\Conversational-Experiences.md"
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
               Supports chat and messaging-based user interactions. Enables real-time communication within applications. Enhances user engagement through conversational UI.
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
<h3 class="form-title">Charts and Data insights
<a href="Controls\Charts-and-Data-Insights.mdl"
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
              Visualizes data using various charts and graphical components. Helps users easily understand trends and patterns. Improves decision-making through clear data representation.
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
<h3 class="form-title">Layouts and Containers
<a href="Controls\Layouts-and-Containers.md"
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
               Provides containers to arrange and structure UI elements. Helps create flexible and responsive layouts. Ensures consistent and organized UI design.
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
<h3 class="form-title">Feedbacks and Status indicators
<a href="Controls\Feedback-and-Status-Indicators.md"
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
              Displays system status and progress to users in real time. Includes loading indicators, progress bars, and notifications. Improves user awareness and experience.
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
<h3 class="form-title">Workflow and Planning
<a href="Controls\Workflow-and-Planning.md"
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
              Helps organize and manage tasks visually. Supports tracking progress across different workflow stages. Enhances planning and task management efficiency.
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
<h3 class="form-title">Commands and Actions
<a href="Controls\Command-and-Actions.md"
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
              Provides quick access to commonly used actions and commands. Centralizes functionality for easier user interaction. Improves productivity and usability.
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
<h3 class="form-title">Scheduling and Dates
<a href="Controls\Scheduling-and-Dates.md"
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
                Manages date-based data, events, and scheduling features. Supports calendars and appointment management. Helps users plan and track time-based activities.
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
<h3 class="form-title">Actions and Selections
<a href="Controls\Actions-and-Selection.md"
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
              Includes controls for selecting options and triggering actions. Supports toggling, choosing, and user decision inputs. Enhances interactivity and control handling.
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
<h3 class="form-title">Visual Enhancements
<a href="Controls\Visual-Enhancements.md"
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
              Adds visual effects and styling to improve UI appearance. Enhances the look and feel of application components. Creates a more engaging user experience.
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
<h3 class="form-title">Viewer
<a href="Controls\Viewer.md"
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
              Displays and renders different types of content within the app. Supports viewing formatted text and structured information. Improves content readability and presentation.
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