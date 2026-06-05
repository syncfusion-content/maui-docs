---
layout: post
title: About .NET MAUI Step ProgressBar Control | Syncfusion
description: Learn about the overview of Syncfusion<sup>&reg;</sup> .NET MAUI Step ProgressBar (SfStepProgressBar) control, basic features, and its functionalities.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Overview of .NET MAUI Step ProgressBar (SfStepProgressBar)

[Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar)](https://www.syncfusion.com/maui-controls/maui-stepprogressbar) control allows you to displays progress through multiple steps in a process, such as order tracking or a user registration form. It's customizable, with options for step shape, content, progress bar color, and more.

## Business use cases

- E-commerce applications that display order tracking stages such as placed, shipped, and delivered.  
- Form-based applications that guide users through multi-step processes such as registration or checkout flows.  
- Workflow systems that represent progress through defined sequential stages.  
- Business applications that require clear visualization of task completion status across steps.  

## Key features

- **Orientation** allows displaying the step progress bar in horizontal or vertical layouts.  
- **Progress status** allows representing steps using states such as completed, in progress, and not started.  
- **Status text** allows displaying primary and secondary text to describe each step clearly.  
- **Formatted text** allows customizing the appearance and style of step descriptions.  
- **Flexible label positioning** allows placing labels at start, end, top, or bottom positions.  
- **Active step control** allows setting and updating the current step index programmatically.  
- **Content customization** allows displaying indicators such as tick, cross, dot, or custom content.  
- **Shape customization** allows configuring step shapes such as circle or square.  
- **Image support** allows displaying images within step indicators for enhanced visualization.  
- **Appearance customization** allows modifying colors, sizes, animations, and layout for better UI consistency. 

![Overview of .NET MAUI StepProgressBar](images/overview/maui-stepprogressbar-overview.gif)

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
<td><a href="/maui/stepprogressbar/overview">Step Progress Bar</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [Linear ProgressBar](https://help.syncfusion.com/maui/linearprogressbar/overview) for displaying continuous progress using a linear indicator.
- [Circular ProgressBar](https://help.syncfusion.com/maui/circularprogressbar/overview) for representing progress using circular visuals. 
- [TabView](https://help.syncfusion.com/maui/tabview/overview) for guiding users through multiple steps or stages using a structured, step-by-step interface.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/stepprogressbar/getting-started) shows a step‑by‑step guide to begin using the Step ProgressBar control.  
- [Customization](https://help.syncfusion.com/maui/stepprogressbar/customization) explains how to customize appearance and step configuration.  
- [Tooltip](https://help.syncfusion.com/maui/stepprogressbar/tooltip) helps show helpful hints when hovering.  
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
<a href="https://www.syncfusion.com/maui-controls/maui-stepprogressbar" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/step-progress-bar" class="form-card" target="_blank">
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