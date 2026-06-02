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

- The Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) has nine different types of built-in configurable view modes that provides all the common scheduling functionalities to display appointments in different views, and allows users to create and manage appointments efficiently. 

- It exposes user interface for custom working days and hours, and basic operations such as viewing daily/all day/spanned appointments, date navigation, selection, and Data binding to different sources.

![overview-in-maui-scheduler](images/overview/overview-in-maui-scheduler.png)

## Control Highlights

- Create and manage appointments efficiently  
- View schedules in multiple formats (calendar, timeline, agenda)  
- Handle recurring events and time-based planning  
- Customize working hours, days, and time slots  
- Control scheduling behavior with flexible configurations  

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

- Localization for text, date formats, and right‑to‑left (RTL) layouts
- Time zone handling and daylight saving adjustments for global scheduling

## Real‑World Scenarios

- Corporate calendars for managing meetings and recurring events
- Health care scheduling for appointments and time‑bound slots
- Education timetables with weekly and monthly views
- Project planning using timeline and agenda views for task tracking

## Related Controls

- DataGrid for structured tabular data visualization
- ListView for flexible collection display with templates
- ComboBox for selection and input scenarios
- Charts for visualizing schedules and analytics

## Next Step

Explore further:

- [Getting Started](https://help.syncfusion.com/maui/scheduler/getting-started)
- [Appointments Guide](https://help.syncfusion.com/maui/scheduler/appointments)  
- [Reminders Guide](https://help.syncfusion.com/maui/scheduler/reminders)

## Learning & Demos

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
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Explore Blogs
<a href="https://www.syncfusion.com/blogs/category/net-maui"
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
              Read insights, tutorials, and developer journeys.
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Explore KB's
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76"
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
               Find quick solutions and step‑by‑step guidance.
</div>
</div>
</div>
<!-- card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Feature Tour
<a href="https://www.syncfusion.com/maui-controls/maui-scheduler"
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
               Walk through highlights and core capabilities.
</div>
</div>
</div>
<!-- card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Showcase Demos
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Scheduler"
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
                Discover polished real‑world app scenarios.
</div>
</div>
</div>