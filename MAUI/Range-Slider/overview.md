---
layout: post
title: .NET MAUI Range Slider control | Syncfusion®
description: Learn here all about introduction of Syncfusion® .NET MAUI Range Slider (SfRangeSlider) control with key features and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# .NET MAUI Range Slider Overview

The Syncfusion<sup>®</sup> .NET MAUI Range Slider ([SfRangeSlider](https://www.syncfusion.com/maui-controls/maui-range-slider)) is a highly interactive UI control, allowing users to select a range values within a minimum and maximum limit. It provides rich features, such as track, labels, ticks, dividers, and tooltip.

## Business use cases

- Data-driven applications that require **filtering values such as price ranges, ratings, or quantities using a slider interface**.  
- Dashboard applications that allow users to **adjust numeric ranges dynamically for data analysis and visualization**.  
- E-commerce applications that provide **range-based filtering such as price, discount, or product attributes**.  
- Configuration screens that require **setting minimum and maximum thresholds for numeric values**.  

## Key features

- **Numeric range selection** allows selecting values between defined minimum and maximum limits.  
- **Orientation** allows displaying the slider in horizontal or vertical layouts based on UI design.  
- **Customizable label** allows rendering values with formatting based on application requirements.  
- **Ticks and dividers** allows visualizing intervals clearly using major and minor tick marks.  
- **Discrete mode** allows moving slider thumbs in fixed steps using defined intervals.  
- **Tooltip** allows displaying selected values clearly with customizable text formatting.

## Related controls

- **[Range Selector](https://help.syncfusion.com/maui/range-selector/overview)** for selecting ranges with enhanced UI and content integration.
- **[Slider](https://help.syncfusion.com/maui/slider/overview)** for selecting a single value from a numeric range.  
- **[NumericEntry](https://help.syncfusion.com/maui/numericentry/overview)** for precise numeric value input and adjustments.

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/range-slider/getting-started) - step-by-step guide to begin using the Range Slider control.
- [Thumb & Overlay](https://help.syncfusion.com/maui/range-slider/thumb-and-overlay) - customize the thumb and its overlay for clear, user‑friendly selection.  
- [Labels](https://help.syncfusion.com/maui/range-slider/labels) - configure labels and interval display.
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
<a href="https://www.syncfusion.com/maui-controls/maui-range-slider" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/range-slider" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
