---
layout: post
title: About .NET MAUI AI-Powered Scheduler control | Syncfusion
description: Learn here all about introduction of Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler(SfSmartScheduler) control.
platform: maui
control: SfSmartScheduler
documentation: ug
keywords : .net maui smartScheduler, maui smart scheduler, ai scheduling, natural language scheduling, resource-aware booking, free time finder, appointment summarization.
---

# Overview of .NET MAUI AI-Powered Scheduler (SfSmartScheduler)

The Syncfusion<sup>&reg;</sup> [.NET MAUI AI-Powered Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) combines the power of the Scheduler with AI-driven intent understanding. Users can create, update, delete, and explore appointments using plain language, reducing clicks and turning scheduling into a conversation. It respects current view context, resources, and availability, and can detect conflicts, find free time, and summarize schedules.

<img src="images\overview\maui-smart-scheduler-overview.png" width="600" alt=".NET MAUI AI-Powered Scheduler." />

## Business use cases

- Enterprise applications that require **intelligent scheduling with natural language input for faster task management**.  
- Booking systems that support **resource-aware scheduling such as rooms, equipment, or personnel availability**.  
- Productivity and calendar applications that provide **smart insights such as conflict detection and availability suggestions**.  
- Business tools that require **automated scheduling assistance and summarization of appointments**.  

## Key features

- **Natural language CRUD** allows creating, updating, and deleting appointments using simple text input.  
- **Resource-aware booking** allows scheduling based on availability of resources and suggests alternative slots when needed.  
- **Conflict detection** allows identifying overlapping appointments and proposing resolution options.  
- **Smart summarization** allows generating quick summaries of schedules or upcoming events.  
- **Adaptive assist panel** allows displaying AI interaction UI in compact or expanded layouts across devices.  
- **Assist button customization** allows enabling, disabling, or customizing the trigger UI for AI interactions.  
- **Event handling** allows controlling how AI-driven changes are applied through manual or automatic workflows.  

## Globalization

The following table summarizes the globalization support available in the [SfSmartScheduler](https://www.syncfusion.com/maui-controls/maui-smart-scheduler) control.

<img src="../Images/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  

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
<td><a href="/maui/smartscheduler/overview">Smart Scheduler</a></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[Scheduler](https://help.syncfusion.com/maui/scheduler/overview)** for traditional scheduling and calendar-based appointment management.  
- **[SmartDataGrid](https://help.syncfusion.com/maui/smartdatagrid/overview)** for AI-driven data analysis and interaction in tabular form.  
- **[Calendar](https://help.syncfusion.com/maui/calendar/overview)** for basic date selection and navigation interfaces.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/smartscheduler/getting-started) - step-by-step guide to begin using the AI-Powered Scheduler control.  
- [Smart Scheduler](https://help.syncfusion.com/maui/smartscheduler/working-with-smart-scheduler) - learn how AI helps auto‑schedule tasks and events.  
- [Styles](https://help.syncfusion.com/maui/smartscheduler/styles) - customize look and feel to match your app design. 
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
<a href="https://www.syncfusion.com/maui-controls/maui-smart-scheduler" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartComponents" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/smart-scheduler" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
