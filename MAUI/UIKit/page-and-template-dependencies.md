---
layout: post
title:  Page Template Dependencies | Essential® UI Kit .NET MAUI | Syncfusion®
description: The list of screen-wise resources and NuGet packages required for each Individual Essential® UI Kit for .NET MAUI Screens.
platform: maui
control: Essential<sup>®</sup> UI Kit for .NET MAUI
documentation: ug
---

# Page Dependencies of Essential<sup>®</sup> UI Kit for .NET MAUI

This page lists the dependencies (NuGet packages) required for each XAML page in the Essential<sup>®</sup> UI Kit for .NET MAUI project  

## Forms

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
<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Login with Social Icon</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<!-- Card 7 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Login Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Sign Up Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Reset Password Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Forgot Password Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<!-- Card 6 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Tabbed Login</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Card Payment Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Add Profile Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Business Registration Form</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
</div>
</div>
</div>
</div>
 
## Catalog

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Category Tile Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Catalog Tile Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Catalog List Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Cards</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article List Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Cards</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article Tile Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 6 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Product Home Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 7 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Event List Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 8 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article Card Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Travel Planner</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
</div>
 
## Details

 <div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Product Detail Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article Detail Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Event Detail Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Data Table Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">My Address Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 6 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Room Booking Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Maps</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Chat

 <div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Recent Conversation Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Chat Conversation Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Article

 <div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article With Comments Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article Parallax Header Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">My Article Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Review And Ratings

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Feedback Page	</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ProgressBar</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Review Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Dataform</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
</div>

## Contact Us

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Contact Us Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Dataform</span>
<span class="chip">Syncfusion.Maui.Maps</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## About Us

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Simple About Us Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">AboutUs Page With Cards</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Simple About Us Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Navigation

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Navigation List Card</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Navigation Tile Card</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Songs</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">FAQs</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Expander</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Contacts</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 6 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Song Play List</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 7 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Movies List</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 8 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Names List</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 9 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Restaurant</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 10 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Icon Names List</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 11 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Suggestion</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 12 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">App Usage</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ProgressBar</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 13 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Documents List</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 14 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Selectable Name Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 15 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Movies Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 16 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">File Explorer List</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 17 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">File Explorer Grid</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Error And Empty

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Error and Empty</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Location Denied</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">No Credits</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">No Internet Connection</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">No Item</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 6 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">No Photos</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 7 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">No Tasks</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 8 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Not Enough Credit</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 9 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">No Videos</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 10 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Payment Failed</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 11 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Something Went Wrong</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Transaction

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Checkout</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Payment Success</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Payment Failure</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Saved Card</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Cards</span>
<span class="chip">Syncfusion.Maui.ListView</span>
</div>
</div>
</div>
</div>

## 	Bookmark

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">WishList</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Cart</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Article Bookmarks</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
</div>
</div>
</div>
</div>

## History

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Transaction History</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Cards</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Cart</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Social

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Social Profile With Connections</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Social Profile with Card</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Social Profile with Interest</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Social Profile With Message</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Profile

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Author Profile</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Contacts Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Contacts Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Master Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Health Profile Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Tracking

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Product Delivery Tracking Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## DashBoard

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Stock Overview Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Picker</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Popup</span>
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Charts</span>
<span class="chip">Syncfusion.Maui.Expander</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Health Care Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Charts</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Daily Calories Report Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.Charts</span>
</div>
</div>
</div>
<!-- Card 4 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Daily Timeline Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 5 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Company History Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span> 	
<span class="chip">Syncfusion.Maui.Buttons</span>
</div>
</div>
</div>
<!-- Card 6 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">My Wallet Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Charts</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.Inputs</span> 	
<span class="chip">Syncfusion.Maui.Buttons</span>
</div>
</div>
</div>
<!-- Card 7 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Restaurant Dashboard Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Buttons</span>
</div>
</div>
</div>
</div>

## Settings

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Settings Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Help Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Notification

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Task Notification Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Social Notification Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 3 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">E-Commerce Notification Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Onboarding

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Settings Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
<!-- Card 2 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Help Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Buttons</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>

## Notification

<div class="container">
<!-- Card 1 -->
<div class="form-card">
<div class="form-content">
<h3 class="form-title">Walk-Through Page</h3>
<div class="section-title">Packages</div>
<div class="chips">
<span class="chip">Syncfusion.Maui.Rotator</span>
<span class="chip">Syncfusion.Maui.DataForm</span>
<span class="chip">Syncfusion.Maui.Toolkit</span>
<span class="chip">Syncfusion.Maui.ListView</span>
<span class="chip">Syncfusion.Maui.Core</span>
<span class="chip">Syncfusion.Maui.Inputs</span>
</div>
</div>
</div>
</div>