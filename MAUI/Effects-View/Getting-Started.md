---
layout: post
title: Getting Started with .NET MAUI Effects View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Effects View (SfEffectsView) control, its elements and more.
platform: maui
control: Effects View
documentation: ug
---

# Getting Started with .NET MAUI Effects View
This section guides you through setting up and configuring a
[Effects View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1)
in your .NET MAUI application. Follow the steps below to add [Effects View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1)
to your project.

To get start quickly with our .NET MAUI EffectsView, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=IOieyRMCuAo" %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

1. Launch Visual Studio or VS Code.
2. Navigate to **File > New > Project,** then select the .NET MAUI App template.
3. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Core NuGet Package

1.  In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

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