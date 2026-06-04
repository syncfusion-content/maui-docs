---
layout: post
title: About .NET MAUI Digital Gauge control | Syncfusion
description: Learn here all about introduction of Syncfusion<sup>&reg;</sup> .NET MAUI Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---
# .NET MAUI Digital Gauge (SfDigitalGauge) Overview

The [Syncfusion .NET MAUI DigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) control is used to display alphanumeric characters in digital (LED display) mode. This control displays a range of values that use characters in combination with numbers.

## Business use cases

- Dashboard applications that display **numeric values such as counters, timers, or measurements in LED format**.  
- Industrial and monitoring systems that require **digital-style displays for real-time data representation**.  
- IoT and device interfaces that present **sensor values or status indicators using segment-based displays**.  
- Entertainment or media applications that use **stylized digital text for clocks, scoreboards, or indicators**.  

## Key features

- **Multiple segment types support** allows displaying characters using 7-segment, 14-segment, 16-segment, and 8x8 dot matrix formats.  
- **7-segment display support** is optimized for rendering numeric values using a simple and clear digital format.  
- **14-segment display support** allows displaying both numeric and alphabetical characters for extended representation.  
- **16-segment display support** provides improved clarity for alphanumeric characters with enhanced segment detail.  
- **8x8 dot matrix display support** allows rendering numbers, characters, and symbols using dot-based matrix patterns.  

## Globalization

The following table summarizes the globalization support available in the [SfDigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  
<img src="../Images/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="../Images/no-support.svg" alt="no-support" width="16" align="center"/> No Support 

<table>
<tr>
<th align="center">Control</th>
<th align="center">Localization</th>
<th align="center">RTL</th>
<th align="center">Time zone</th>
<th align="center">Screen reader</th>
<th align="center">Keyboard navigation</th>
</tr>
<tr>
<td><a href="/maui/digitalgauge/overview">Digital Gauge</a></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[CircularChart](https://help.syncfusion.com/maui/circular-charts/overview)** for visualizing proportional data using circular charts.   
- **[LinearGauge](https://help.syncfusion.com/maui/linear-gauge/overview)** for representing values using gauge-based visualization.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/digitalgauge/getting-started) - step-by-step guide to begin using the Digital Gauge control.
- [Segments Types](https://help.syncfusion.com/maui/digitalgauge/character-segment-types) - understand different segment types and configurations.
- [Customization](https://help.syncfusion.com/maui/digitalgauge/customization) - customize appearance and behavior of the control.
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) - explore interactive demos and ready‑made UI examples.

## Learnings

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
   text-decoration: none;
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
@key frames zoomIn {
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
<!-- Card 1 -->
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore Blogs</h3>
    <div class="form-description">
      Read insights, tutorials, and developer journeys.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore KB's</h3>
    <div class="form-description">
      Find quick solutions and step‑by‑step guidance.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/maui-controls/maui-digital-gauge" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/digital-gauge" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
