---
layout: post
title: Command & Actions
description: Toolbars and command surfaces.
platform: maui
control: Command & Actions
documentation: ug
---

# Command & Actions

Toolbars and command surfaces for invoking app-level and contextual actions. Use these controls to expose primary commands, organize actions and provide keyboard or touch affordances.

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
<a href="https://github.com/syncfusion/essential-ui-kit-for-.net-maui/blob/master/EssentialMAUIUIKit/EssentialMAUIUIKit/Views/Dashboard/StockOverviewPage.xaml"
              target="_blank"
              class="source-icon"
              title="View Source">
<svg xmlns="http://www.w3.org/2000/svg"
                    width="18"
                    height="18"
                    fill="currentColor"
                    viewBox="0 0 16 16">
<path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38
                   0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52
                   -.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07
                   -1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12
                   0 0 .67-.21 2.2.82a7.56 7.56 0 0 1 2-.27c.68 0 1.36.09 2 .27 1.53-1.04
                   2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15
                   0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48
                   0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8
                   c0-4.42-3.58-8-8-8z"/>
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