---
layout: post
title: About .NET MAUI Scheduler control | Syncfusion
description: Learn here all about introduction of Syncfusion .NET MAUI Scheduler(SfScheduler) control, its basic features and functionalities of scheduler.
platform: maui
control: SfScheduler
documentation: ug
keywords : .net maui scheduler, maui appointment scheduling, .net maui agenda view.
---

# Overview of .NET MAUI Scheduler (SfScheduler)

The Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) has nine different types of built-in configurable view modes that provides all the common scheduling functionalities to display appointments in different views, and allows users to create and manage appointments efficiently. It exposes user interface for custom working days and hours, and basic operations such as viewing daily/all day/spanned appointments, date navigation, selection, and Data binding to different sources.

![overview-in-maui-scheduler](images/overview/overview-in-maui-scheduler.png)

## Business use cases

- Calendar and booking applications that require **managing appointments, meetings, and schedules efficiently**.  
- Enterprise systems that track **employee schedules, tasks, and resource planning**.  
- Health care and service applications that manage **appointments with recurrence and time-based availability**.  
- Productivity and collaboration apps that display **events across multiple calendar views for better planning**. 

## Key features

- **Built‑in Views** : switch between Day, Week, WorkWeek, Month, Agenda, and Timeline views for flexible scheduling

 ![built-in-views-in-maui-scheduler](images/overview/built-in-views-in-maui-scheduler.png)

- **Appointments** : create and manage events with start/end time, subject, and notes

 ![appointment-events-in-maui-scheduler](images/overview/appointment-events-in-maui-scheduler.png)

- **Recurrence Events** : schedule repeating events daily, weekly, monthly, or yearly with exceptions

 ![recurring-events-with-exceptions-dates-in-maui-scheduler](images/overview/recurring-events-with-exceptions-dates-in-maui-scheduler.png)

- **Appointment Mapping** : bind custom data objects to appointments for seamless integration

- **Time Zone Support** : schedule across regions with automatic daylight saving adjustments

- **Agenda View** : view appointments in a simple list format grouped by week

 ![agenda-view-events-in-maui-scheduler](images/overview/agenda-view-events-in-maui-scheduler.png)

- **Timeline Month View** : display appointments horizontally across days for long‑term planning

 ![timeline-month-view-in-maui-scheduler](images/overview/timeline-month-view-in-maui-scheduler.png)

- **First Day of the Week** : customize the start day (e.g., Monday or Sunday) to match regional preferences

 ![first-day-of-week-in-maui-scheduler](images/overview/first-day-of-week-in-maui-scheduler.png)

- **Flexible Working Days** : define working and non‑working days for realistic business schedules

- **Date Range Limits** : restrict navigation to minimum and maximum dates for controlled scenarios

- **Special Time Regions** : block or highlight unavailable slots such as holidays or breaks

 ![recurring-special-time-region-in-maui-scheduler](images/overview/recurring-special-time-region-in-maui-scheduler.png)

- **Blackout Dates** : disable specific dates to prevent scheduling on restricted days

 ![selectable-day-predicate-or-blackout-dates-in-maui-scheduler](images/overview/selectable-day-predicate-or-blackout-dates-in-maui-scheduler.png)

- **Hide Leading & Trailing Dates** : remove extra month dates for a cleaner calendar view

 ![hide-leading-and-trailing-dates-in-maui-scheduler](images/overview/hide-leading-and-trailing-dates-in-maui-scheduler.png)

- **Custom Start & End Hours** : show only relevant time ranges by hiding unnecessary hours

 ![flexible-working-hours-in-maui-scheduler](images/overview/flexible-working-hours-in-maui-scheduler.png) 


## Globalization

The following table summarizes the globalization support available in the [SfScheduler](https://www.syncfusion.com/maui-controls/maui-scheduler) control.

<img src="Images/globalization/full-support.svg" alt="full-support" width="16" align="center"/> Full Support  

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
<td><a href="/maui/scheduler/overview">Scheduler</a></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="Images/full-support.svg" alt="full-support" width="16" /></td>
</tr> 
</table>

## Related controls

- **[Calendar](https://help.syncfusion.com/maui/calendar/overview)** for date navigation and selection using calendar UI.  
- **[DataGrid](https://help.syncfusion.com/maui/datagrid/overview)** for managing and displaying appointment data in tables.  
- **[Kanban](https://help.syncfusion.com/maui/kanban-board/overview)** for workflow-based task management views.  

## Next steps

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/scheduler/getting-started) - step-by-step guide to begin using the Scheduler control.  
- [Day Week Views](https://help.syncfusion.com/maui/scheduler/day-week-views) - switch between day and week layouts for flexible scheduling.
- [Appointments](https://help.syncfusion.com/maui/scheduler/appointments) - manage appointments and data binding. 
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
<a href="https://www.syncfusion.com/maui-controls/maui-scheduler" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Scheduler" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/scheduler" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
