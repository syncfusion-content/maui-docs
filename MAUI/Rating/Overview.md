---

layout: post
title: About .NET MAUI Rating control | Syncfusion®
description: Learn here all about the introduction of Syncfusion® .NET MAUI Rating (SfRating) control, its elements and more.
platform: maui
control: Rating
documentation: ug

---
# .NET MAUI Rating (SfRating) Overview

The Essential .NET MAUI Rating control provides the number of stars that represents a rating. Also used to configure the item size, item spacing and the number of displayed items in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. Essential .NET MAUI Rating control can be used in various scenarios like movie rating, rating the application etc.

   ![Rating OverView](images/overview.png)

## Business use cases

- E-commerce applications that collect product ratings and user feedback using star-based inputs.  
- Media and entertainment apps that display ratings for movies, songs, or content items.  
- Survey and feedback systems that require simple and intuitive user rating inputs.  
- Business applications that measure user satisfaction or performance ratings.  

## Key features

- **[Precision](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Precision)** allows defining the accuracy of rating values such as full, half, or fractional ratings.  
- **[Item count](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount)** allows configuring the total number of rating items displayed.  
- **[Rating shape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingShape.html)** allows choosing predefined shapes for rating items to match application design.  

## Globalization

The following table summarizes the globalization support available in this control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support   
<img src="../Images/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable

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
<td><a href="/maui/rating/overview">Rating</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
</tr> 
</table>

## Related controls

- [CheckBox](https://help.syncfusion.com/maui/checkbox/overview) for collecting multiple selection inputs.
- [RadioButton](https://help.syncfusion.com/maui/radio-button/overview) for handling single selection scenarios.
- [ComboBox](https://help.syncfusion.com/maui/checkbox/overview) for dropdown-based user input.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/rating/getting-started) shows a step‑by‑step guide to begin using the Rating control.  
- [Customization](https://help.syncfusion.com/maui/rating/appearance-customization) explains how to customize rating appearance and behavior.  
- [Precision](https://help.syncfusion.com/maui/rating/precision-mode) helps configure rating precision and value handling.  
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) provides interactive demos and ready‑made UI examples. 

## Resources

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
<a href="https://www.syncfusion.com/maui-controls/maui-rating" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/rating" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore KB's</h3>
    <div class="form-description">
      Find quick solutions and step‑by‑step guidance.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore Blogs</h3>
    <div class="form-description">
      Read insights, tutorials, and developer journeys.
    </div>
  </div>
</a>
