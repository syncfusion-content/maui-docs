---
layout: post
title: Arrange Tabs in Tab bar customization in MAUI TabView | Syncfusion
description: Learn here all about TabView Header Customization support in Syncfusion MAUI TabView (SfTabView) control and more.
platform: MAUI
control: TabView
documentation: ug
---

# Arrange Tabs in Tab bar

.NET MAUI Tab View provides three options that determine how the width of the tab is calculated on the tab bar while it gets populated. The options are Default, Size to fit and compact it can be done by [TabWidthMode](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabWidthMode)

## Default

All tabs widths are the same width that all tabs are equally sharing the actual width of the tab bar. This enables a fixed tab bar that won’t allow tab scrolling even it contains any number of tabs.

![Tab Width Mode Default.](images/tab-view/Tab-Width-Mode-Default.png)

## Size to fit

This option can be used when you need to set the width of a tab so that it fits the text or image that it contains. This will enable tab scrolling when the arrangement of the tabs and its width  get exceed the tab bar’s width.

![Tab Width Mode Size to fit.](images/tab-view/Tab-Width-Mode-SizeToFit.png) 

## Compact

This option can be set when you need a maintain the compact spacing on the tab bar when it has more tabs. Only selected tabs can expand to show both image and text. The unselected tab tabs collapse to display only their image.

![Tab Width Mode Compact.](images/tab-view/Tab-Width-Mode-Compact.png) 