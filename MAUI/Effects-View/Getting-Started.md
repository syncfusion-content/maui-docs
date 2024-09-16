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

## Prerequisites
Before proceeding, ensure the following are in place:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://github.com/dotnet/maui/wiki/).

{% youtube "https://www.youtube.com/watch?v=IOieyRMCuAo" %}

## Step 1: Create a New MAUI Project
1. Open Visual Studio or VS Code.
2. Go to **File** > **New** > **Project** and choose the .NET MAUI App template.
3. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Core NuGet Package
1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
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

## Step 4: Create a simple Effects View

This section explains how to create a Effects View and configure it. The control can be configured entirely in C# code or by the XAML markup.

### Adding a SfEffectsView control

Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

    xmlns:effectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

Open the `MainPage.xaml` file and define the `SfEffectsView` control using consistent instance names:

{% tabs %}

{% highlight xaml %}

<ContentPage.Content> 
	 <effectsView:SfEffectsView /> 
</ContentPage.Content>  

{% endhighlight %}

{% highlight c# %}

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