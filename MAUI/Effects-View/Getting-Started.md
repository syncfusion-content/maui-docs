---
layout: post
title: Getting Started with .NET MAUI Effects View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Effects View (SfEffectsView) control, its elements and more.
platform: maui
control: Effects View
documentation: ug
---

>**Notice:** After **Volume 1 2025 (Mid of March 2025),** updates, bug fixes, and feature enhancements for this control will no longer be available in the Syncfusion package. Please switch to the **Syncfusion Toolkit for .NET MAUI** for continued support. For a smooth transition refer this [migration document.](https://help.syncfusion.com/maui-toolkit/migration)

# Getting Started with .NET MAUI Effects View

This section guides you through setting up and configuring a [Effects View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add [Effects View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1) to your project.

To quickly get started with the .NET MAUI Effects View, watch this video.

{% youtube "https://www.youtube.com/watch?v=IOieyRMCuAo" %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create**.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion MAUI Core NuGet Package

1.  In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler 

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace EffectsViewMauiSample
{
  public static class MauiProgram
  {
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
		.UseMauiApp<App>()
		.ConfigureSyncfusionCore()
		.ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		});
		return builder.Build();
	}  
  }
}     

{% endhighlight %} 

## Step 4: Add a Basic Effects View

1. To initialize the control, import the Core namespace into your code.

2. Initialize [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1)

{% tabs %}

{% highlight xaml %}

<ContentPage 
            ...
            xmlns:effectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <ContentPage.Content> 
	 	<effectsView:SfEffectsView /> 
	</ContentPage.Content> 
</ContentPage>
	
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;

namespace EffectsViewMauiSample   
{  
	public partial class MainPage : ContentPage                  
	{ 
	    SfEffectsView effectsView;

		public MainPage()   
		{   
			InitializeComponent();       
			effectsView = new SfEffectsView(); 
			this.Content = effectsView;  
		}  
	}  
}  

{% endhighlight %}

{% endtabs %}

![Effects View Initialization](Getting-Started_images/RippleEffect.gif)

N> You can refer to our [.NET MAUI Effects View](https://www.syncfusion.com/maui-controls/maui-effects-view) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Effects View Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/EffectsView) that shows you how to render the Effects View in .NET MAUI.

## See also 

[How to apply ripple effect on items in .NET MAUI ListView (SfListView)?](https://support.syncfusion.com/kb/article/15802/how-to-apply-ripple-effect-on-items-in-net-maui-listview-sflistview)

[How to get the selected item from .NET MAUI ListView?](https://support.syncfusion.com/kb/article/13469/how-to-get-the-selected-item-from-net-maui-listview)