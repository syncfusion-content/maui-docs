---
layout: post
title: Getting Started with .NET MAUI Effects View Control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Effects View (SfEffectsView) control, its elements, and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

>**Notice:** After **Volume 1 2025 (Mid of March 2025)**, feature enhancements for this control will no longer be available in the Syncfusion<sup>®</sup> package. Please switch to the **Syncfusion<sup>®</sup> Toolkit for .NET MAUI** for continued support. For a smooth transition, refer to this [migration document](https://help.syncfusion.com/maui-toolkit/migration).

# Getting Started with .NET MAUI Effects View

This section guides you through setting up and configuring the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add [Effects View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1) to your project.

To quickly get started with the .NET MAUI Effects View, watch this video.

{% youtube "https://www.youtube.com/watch?v=IOieyRMCuAo" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project, choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure all necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler 

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependency for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace EffectsViewGettingStarted
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

## Step 4: Add a basic Effects View

1. To initialize the control, import the Core namespace into your code.

2. Initialize [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1).

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

namespace EffectsViewGettingStarted   
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

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project**, then press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Core` to install the Syncfusion<sup>®</sup> .NET MAUI Core package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler 

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependency for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace EffectsViewGettingStarted
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

## Step 4: Add a basic Effects View

1. To initialize the control, import the Core namespace into your code.

2. Initialize [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1).

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

namespace EffectsViewGettingStarted   
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

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select .NET (C#) and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the terminal in Rider and manually run: `dotnet restore`.

## Step 3: Register the handler 

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependency for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace EffectsViewGettingStarted
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

## Step 4: Add a basic Effects View

1. To initialize the control, import the Core namespace into your code.

2. Initialize [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html?tabs=tabid-1).

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

namespace EffectsViewGettingStarted   
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

{% endtabcontent %}
{% endtabcontents %}


## Adding a content

An image, label or any view can be added to the Effects View using the Content property.

{% tabs %}
{% highlight xaml %}

    <Border HorizontalOptions="Center" VerticalOptions="Center">
        <Border.StrokeShape>
            <RoundRectangle CornerRadius="18" />
        </Border.StrokeShape>
        <Border.Background>
            <LinearGradientBrush EndPoint="1,0">
                <GradientStop Color="#4E54C8" Offset="0.0" />
                <GradientStop Color="#8F94FB" Offset="1.0" />
            </LinearGradientBrush>
        </Border.Background>
        <effectsView:SfEffectsView>
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="90" />
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>

                <Image Source="laura.png" Margin="7" VerticalOptions="Center"
                               WidthRequest="72" HeightRequest="72" />
                <StackLayout Grid.Column="1" VerticalOptions="Center">
                    <Label Text="Laura Steffi" Margin="10,0,10,0" FontSize="18" />
                    <Label Text="Data Science Analyst" Margin="10,0,10,0" FontSize="12"/>
                </StackLayout>
            </Grid>
        </effectsView:SfEffectsView>
    </Border>

{% endhighlight %}
{% endtabs %}

![Effects View initialization](Getting-Started_images/RippleEffect.gif)

You can download the getting started project of this demo from [GitHub](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-EffectsView)

N> You can refer to our [.NET MAUI Effects View](https://www.syncfusion.com/maui-controls/maui-effects-view) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Effects View example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/EffectsView) that shows you how to render the Effects View in .NET MAUI.

## See also 

[How to apply ripple effect on items in .NET MAUI ListView (SfListView)?](https://support.syncfusion.com/kb/article/15802/how-to-apply-ripple-effect-on-items-in-net-maui-listview-sflistview)

[How to get the selected item from .NET MAUI ListView?](https://support.syncfusion.com/kb/article/13469/how-to-get-the-selected-item-from-net-maui-listview)