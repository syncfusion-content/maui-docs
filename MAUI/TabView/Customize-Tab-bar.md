---
layout: post
title: customize the tab bar in .NET MAUI Tab View control | Syncfusion
description: Learn here all about Custom Header support in Syncfusion .NET MAUI Tab View(SfTabView) control and more.
platform: .NET MAUI
control: Tab View
documentation: ug
---

# Customize the tab bar in .NET MAUI Tab View(SfTabView)

## Tab Bar Placement

The .NET MAUI Tab View provides two options that determine how the tab bar aligns relative to the tab content. The options are top and bottom. It can be done by using [TabBarPlacement](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarPlacement) property.

### Top

Tab bar will be placed above the content region of the Tab View control.

![Tab Bar Placement Top](images/tab-view/Tab-bar-Placement-Top.png) 

### Bottom

Tab bar will be placed below the content region of the Tab View control. 

![Tab Bar Placement Bottom](images/tab-view/Tab-bar-Placement-Bottom.png) 

## Customize the tab bar height

The height of the tab bar can be customized by setting the `TabBarHeight` property. The default height is 48.

N> It is recommended to set the TabBarHeight as 72 while displaying image and text with ImagePosition as either Top or Bottom.

## Customize the background

The tab bar background can be customized using the `TabBarBackground` property which is of type `Brush`.

## Indicator Placement

The .NET MAUI Tab View provides three options that determine how selection indicator aligns relative to the tab header item. The options are top, bottom, and fill. This can be done by setting the [IndicatorPlacement](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorPlacement) property of SfTabView.

### Top

The indicator will be placed at the top of the selected tab.

![Tab Image Position Top.](images/tab-view/Selection-Indicator-placement-Top.png) 

### Bottom

The indicator will be placed at the bottom of the selected tab.

![Tab Image Position Bottom.](images/tab-view/Selection-Indicator-placement-Bottom.png) 

### Fill

The indicator will fill the selected tab.

![Tab Image Position Fill.](images/tab-view/Selection-Indicator-placement-Fill.png) 

## Indicator Background

The background of the indicator can be customized using [IndicatorBackground](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorBackground) property of SfTabView.