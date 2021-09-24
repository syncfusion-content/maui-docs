---
layout: post
title: Getting Started with .NET MAUI Tab View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Tab View (SfTabView) control, its elements and more.
platform: .NET MAUI
control: Tab View
documentation: ug
---

# Getting Started with .NET MAUI Tab View (SfTabView)

This section explains the steps required to configure the .NET MAUI Tab View control and customize its elements.

## Adding SfTabView reference

Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfTabView to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.TabView] and then install it.

## Create a simple Tab View

This section explains how to create a Tab View and configure it. The control can be configured entirely in C# code or by using XAML markup. The following screenshot illustrates the output of Tab View on iOS, Android and MacCatalyst.

![TabViewImage](images/TabView.png)

### Creating the project

Create a new .NET MAUI application in Visual Studio.

### Adding SfTabView control

Add the nuget to the project as discussed in the above reference section.

Add the namespace as shown in the following code.

{% tabs %}

{% highlight xaml %}

xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
	
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

{% endhighlight %}

{% endtabs %}

## Populating tab items

Tab items can be added to the Tab View through the [Items](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_Items) property of [SfTabView](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabView.html), which holds the collection of [SfTabItem](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html) through [TabItemsCollection](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.TabItemCollection.html).

