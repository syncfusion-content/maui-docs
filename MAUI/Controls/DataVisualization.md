---
layout: post
title: Data Visualization | Syncfusion®
description: Controls designed for data visualization, enabling the creation of interactive charts and graphical representations for better data analysis and insights.
platform: maui
control: Data Visualization
documentation: ug
---

# Syncfusion<sup>®</sup> Data Visualization for .NET MAUI

Comprehensive charting and visualization controls for turning data into actionable insights. This collection includes charts, gauges and map visualizations designed for performance and customization in analytics scenarios.

## Data Visualization

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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/aiassistview/overview">Cartesian Charts</a></h3>
<div class="form-description">
              Displays data using X and Y axes for comparing values over time or categories.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/circular-charts/overview">Circular Charts</a></h3>
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/funnel-charts/overview">Funnel Charts</a></h3>
<div class="form-description">
               Shows data flow across stages, typically used in processes like sales pipelines.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/pyramid-charts/overview">Pyramid Charts</a></h3>
<div class="form-description">
              Visualizes hierarchical data in a pyramid shape, often used for comparisons.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/polar-charts/overview">Polar Charts</a></h3>
<div class="form-description">
               Displays data in a circular layout based on angles and radius values.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/sunburstchart/overview">Sunburst Charts</a></h3>
<div class="form-description">
               It visualizes hierarchical data in a concentric circular layout.
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
<h3 class="form-title"><a class="form-link" href=" ">Spark Charts</a></h3>
<div class="form-description">
              .NET MAUI Spark Charts are compact charts that show trends and variations in data.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/radial-gauge/overview">Radial Gauge</a></h3>
<div class="form-description">
               It is a multipurpose data visualization control that displays numerical values on a circular scale.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/linear-gauge/overview">Linear Gauge</a></h3>
<div class="form-description">
              The .NET MAUI Linear Gauge displays numerical values on a horizontal or vertical linear scale.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/digital-gauge/overview">Digital Gauge</a></h3>
<div class="form-description">
              This is data visualization component that displays alphanumeric characters in digital mode.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/maps/overview">Maps</a></h3>
<div class="form-description">
               The .NET MAUI Maps displays statistical information for a geographical area.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/barcode-generator/overview">Barcode Generator</a></h3>
<div class="form-description">
               The .NET MAUI Barcode Generator creates and displays machine-readable data using standard 1D and 2D barcode formats.
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
<h3 class="form-title"><a class="form-link" href="https://help.syncfusion.com/maui/treemap/overview">TreeMap</a></h3>
<div class="form-description">
              A .NET MAUI TreeMap shows hierarchical data as nested rectangles based on values.
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