---
layout: post
title: Getting Started with .NET MAUI Effects View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Effects View (SfEffectsView) control, its elements and more.
platform: maui
control: Effects View
documentation: ug
---

# Getting Started with .NET MAUI Effects View (SfEffectsView)

This section explains the steps required to configure the .NET MAUI Effects View control and customize its elements.

To get start quickly with our .NET MAUI Effects View, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=IOieyRMCuAo" %}

## Adding a SfEffectsView reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and then install it.

## Handler registration 

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

## Create a simple Effects View

This section explains how to create a Effects View and configure it. The control can be configured entirely in C# code or by the XAML markup.

### Adding a SfEffectsView control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

    xmlns:effectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

Step 3: Set the control to content in `ContentPage`.

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