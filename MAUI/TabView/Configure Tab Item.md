---
layout: post
title: Display Type in .NET MAUI Tab View control | Syncfusion
description: Learn here all about color and font customization in Syncfusion .NET MAUI Tab View (SfTabView) control.
platform: .NET MAUI
control: Tab View
documentation: ug
---
# Configure and customize the appearance of Tab Item

A tab item consists of the following elements that can be customized.

* **Header** - Holds the text of the tab item that is displayed in the tab bar.

* **ImageSource** - The image to be displayed in the tabbar representing the tab item.

* **Content** - The assigned view will get displayed in the main area of the Tab View.

* **ImagePosition** - Determines the Image text relation of the tab item.

* **TextColor** - The text color of the tab item displayed in the tab bar.

* **FontFamily** - Font family of the tab item text displayed in the tab bar.

* **FontAttribute** - The font style of the text of each tab item in the tab bar.

* **FontSize** - The size of the text of each tab item in the tab bar.

* **IsSelected** - Indicates whether the tab item is active or not.

## Tab Image Position

The .NET MAUI Tab View provides four options that determine how the image of the tab aligns relative to the text. The options are left, top, right and bottom. It can be achieved using the [ImagePosition](https://npmci.syncfusion.com/maui/api/development/maui-tabview/) property of [SfTabItem](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImagePosition) of type TabImagePosition.

N> Each tab item can be set with different image positions. Visual State Manager can be used to apply same value to all tabs.

### Top

The image will be placed above the text vertically.

![Tab Image Position Top](images/tab-view/Image-Position-Top.png) 

### Bottom

The image will be placed below the text vertically.

![Tab Image Position Bottom](images/tab-view/Image-Position-Bottom.png) 

### Left

The image will be placed before the text horizontally.

### Right

The image will be placed to the right side of the text horizontally.
