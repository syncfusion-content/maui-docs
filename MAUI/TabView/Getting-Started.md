---
layout: post
title: Getting Started with MAUI TabView control | Syncfusion
description: Learn here about getting started with Syncfusion MAUI TabView (SfTabView) control, its elements and more.
platform: MAUI
control: TabView
documentation: ug
---

# Getting Started with MAUI TabView (SfTabView)

This section explains the steps required to configure the MAUI TabView control and customize its elements.

## Assembly deployment


## Adding SfTabView reference


**Method 1: Adding SfTabView reference from nuget.org**

Syncfusion MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfTabView to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.MAUI.SfTabView] and then install it.

**Method 2: Adding SfTabView reference from toolbox**

## Create a simple tab view

This section explains how to create a tab view and configure it. The control can be configured entirely in C# code or by using XAML markup. The following screenshot illustrates the output of tab view on iOS, Android and UWP devices.

![TabViewImage](images/TabView.png)

### Creating the project

Create a new BlankApp MAUI application in  Visual Studio for MAUI.

### Adding SfTabView in MAUI.Forms

Add the Nuget to the PCL and renderer projects as discussed in the Assembly deployment section.

Import the control namespace as shown in the following code.

## Populating tab items

Tab items can be configured in tab view through the [Items](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_Items) property of [SfTabView](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html), which holds the collection of [SfTabItem](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html) through [TabItemsCollection]()https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.TabItemCollection.html.