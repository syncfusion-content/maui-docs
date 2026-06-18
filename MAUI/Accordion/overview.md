---
layout: post
title: About .NET MAUI Accordion control | Syncfusion
description: Learn here all about introduction of Syncfusion .NET MAUI Accordion (SfAccordion) control, its elements and more.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Overview of .NET MAUI Accordion (SfAccordion)

The **[.NET MAUI Accordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html)** (SfAccordion) offers a vertically collapsible panel with stacked headers, allowing the expansion or collapse of one or multiple items simultaneously.

![.NET MAUI accordion overview ](Images/overview_images/accordion_overview.png)

## Business use cases

- FAQ or help sections with collapsible question‑answer visualization.  
- Form sections grouped into expandable category layouts for structured input.  
- Mobile apps with limited screen space needing compact, responsive UI design.  
- Product descriptions and detail sections with expandable content presentation.  

## Key features

- **Data binding** populates Accordion items by binding collections using .NET MAUI BindableLayout.  
- **Expand modes** support single or multiple item expansion.  
- **Animation support** provides smooth expand and collapse animations with customizable duration. 

## Globalization

The following table summarizes the globalization support available in this control.

<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/full-support.svg" alt="full-support" width="16">
    <span>Full Support</span>
</div>
<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto; margin-bottom:6px;">
    <img src="../Images/partial-support.svg" alt="partial-support" width="16">
    <span>Partial Support</span>
</div>
<div style="display:flex; align-items:center; justify-content:flex-start; gap:8px; width:auto;">
    <img src="../Images/not-applicable.svg" alt="not-applicable" width="16">
    <span>Not Applicable</span>
</div>

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
<td><a href="/maui/accordion/overview">Accordion</a></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
<td align="center"><img src="../Images/full-support.svg" alt="full-support" width="16" /></td>
</tr>
</table>

## Related controls

- [SfExpander](https://help.syncfusion.com/maui/expander/overview) for expanding and collapsing a single content section.
- [SfNavigationDrawer](https://help.syncfusion.com/maui/navigationdrawer/overview) for slide‑in navigation panels and grouped menus.
- [SfTabView](https://help.syncfusion.com/maui/tabview/overview) for organizing content into tabbed sections.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/accordion/getting-started) shows how to begin using the Accordion step by step.
- [Bindable Layout](https://help.syncfusion.com/maui/accordion/bindablelayout) explains how to bind Accordion items to collections.
- [Events](https://help.syncfusion.com/maui/accordion/events) show how to handle interactions and customize behavior.
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) provides interactive demos and ready-made UI examples.

## Additional Resources

<style>

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
/* TOOLKIT ICON FONT */
@font-face {
    font-family: 'Toolkit Icons';
    src: url('data:font/woff2;charset=utf-8;base64,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') format('woff2');
    font-weight: normal;
    font-style: normal;
    font-display: swap;
}

/* TOOLKIT BASE CLASS */
.card-icon {
  font-family: 'Toolkit Icons' !important;
  font-size: 20px;
  line-height: 1;
  display: inline-block;
  font-style: normal;
}

/* TOOLKIT ICONS */
.card-ai:before { content: "\e720"; }
.card-arrow:before { content: "\e721"; }

/* CARD LAYOUT */
.card-container {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
  margin-top: 20px;
}

/* CARD */
.form-card {
  flex: 0 0 calc(33.33% - 14px);
  padding: 20px;
  border-radius: 16px;
  border: 1px solid #e1dcf5;
  display: flex;
  flex-direction: column;
  background: #f7f5ff;
  text-decoration: none;
  transition: all 0.25s ease;
  color: inherit;
}

.form-card:hover {
  transform: translateY(-3px);
  text-decoration: none;
  box-shadow: 0 10px 25px rgba(0,0,0,0.08);
}

/* CONTENT */
.form-content {
  display: flex;
  flex-direction: column;
  gap: 6px;
}

/* ICON */
.icon-circle {
  width: 36px;
  height: 36px;
  border-radius: 50%;
  background: #F6EDFF;
  display: flex;
  align-items: center;
  justify-content: center;
}

/* FIXED ICON STYLE */
.card-icon {
  font-family: 'Toolkit Icons' !important;
  font-size: 16px;
  line-height: 1;
  color: #6750A4;
}


/* TITLE */
.form-title {
  font-size: 20px;
  font-weight: 600;
  margin: 0;
  color: #2d2d2d;
}

/* DESCRIPTION */
.form-description {
  font-size: 15px;
  margin: 0;
  min-height: 48px;
  color: #666;
  line-height: 1.5;
}


.card-header {
  display: flex;
  align-items: center;
  gap: 12px;
  margin-bottom: 8px;
}


/* EXPLORE LINK */
.explore-link {
  margin-top: auto;
  color: #6750A4;
  font-weight: 500;
  display: flex;
  align-items: center;
  gap: 6px;
}

/* ARROW ICON */
.explore-link .card-icon {
  font-size: 16px;
}


</style>

<div style="display:flex; flex-wrap:wrap; gap:20px; margin-top:20px;">
<!-- Card 1 -->
<a href="https://www.syncfusion.com/maui-controls/maui-accordion" class="form-card" target="_blank">
  <div class="form-content">
<div class="card-header">
    <div class="icon-circle">
        <span class="card-icon card-ai"></span>
    </div>
    <h3 class="form-title">Feature Tour</h3>
</div>
<div class="form-description">Quick overview of key features to get started.</div>
<div class="explore-link">
Explore tour
  <span class="card-icon card-arrow"></span>
</div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Accordion" class="form-card" target="_blank">
  <div class="form-content">
  <div class="card-header">
    <div class="icon-circle">
    <span class="card-icon card-ai"></span>
  </div>
    <h3 class="form-title">Showcase Samples</h3>
</div>
    <div class="form-description">Explore sample apps and real-world use cases.</div>
    <div class="explore-link">
    Explore Samples
  <span class="card-icon card-arrow"></span>
</div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/accordion" class="form-card" target="_blank">
  <div class="form-content">
  <div class="card-header">
    <div class="icon-circle">
    <span class="card-icon card-ai"></span>
    </div>
    <h3 class="form-title">Tutorial Videos</h3>
</div>
    <div class="form-description">
      Watch step‑by‑step videos to learn faster.
    </div>
    <div class="explore-link">
    Explore Videos
  <span class="card-icon card-arrow"></span>
</div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76" class="form-card" target="_blank">
  <div class="form-content">
   <div class="card-header">
    <div class="icon-circle">
    <span class="card-icon card-ai"></span>
    </div>
    <h3 class="form-title">Explore KB's</h3>
</div>
    <div class="form-description">
      Find solutions, guides, and troubleshooting tips.
    </div>
    <div class="explore-link">
Explore KB's
  <span class="card-icon card-arrow"></span>
</div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
   <div class="card-header">
    <div class="icon-circle">
    <span class="card-icon card-ai"></span>
    </div>
    <h3 class="form-title">Explore Blogs</h3>
</div>
    <div class="form-description">
      Read articles, use cases, and expert insights.
    </div>
    <div class="explore-link">
Explore Blogs
  <span class="card-icon card-arrow"></span>
</div>
  </div>
</a>

</div>
