---
layout: post
title: Arrange Tabs in Tab bar customization in .NET MAUI Tab View | Syncfusion
description: Learn here all about Tab View Header Customization support in Syncfusion .NET MAUI Tab View (SfTabView) control and more.
platform: .NET MAUI
control: Tab View
documentation: ug
---

# Arrange Tabs in Tab bar

.NET MAUI Tab View provides two modes that determine how the width of the tab is calculated on the tab bar while it gets populated. The options are `Default` and `SizeToContent` and can be achieved using [TabWidthMode](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabWidthMode) property.

## Fixed bar

The width of the tab is splitted equally based on the available control width. This enables a fixed tab bar that won’t allow tab scrolling even it contains any number of tabs. This can be achieved by setting the `TabWidthMode` as `Default`.

N> This mode is recommended when the tab count is not more than 4. More tabs in this mode may appear with the text being trimmed.

![Tab Width Mode Default](images/tab-view/Tab-Width-Mode-Default.png)

## Based on the text size

The width of a tab is set to fit the text or image that it contains by setting the `TabWidthMode` as `Default`. Scroll is enabled in this mode to access the items that are outside the visible area.

![Tab Width Mode Size to fit](images/tab-view/Tab-Width-Mode-SizeToFit.png) 
