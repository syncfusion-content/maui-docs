---
layout: post
title: Getting Started with Syncfusion® .NET MAUI Badge View
description: Learn all about getting started with the Syncfusion® .NET MAUI Badge View (SfBadgeView) control, its elements, and more.
platform: MAUI
control: SfBadgeView
documentation: UG
---

# Getting Started with .NET MAUI Badge View

This section guides you through setting up and configuring a [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add a basic Badge View to your project.

To quickly get started with the .NET MAUI Badge View, watch this video.

{% youtube "https://www.youtube.com/watch?v=wlh2eMPYZY0" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or a later version.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace BadgeViewGettingStarted
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

## Step 4:  Add a basic Badge View

1. To initialize the control, import the Core namespace into your code.
2. Initialize [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

   <ContentPage
    . . .    
    xmlns:badgeView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <Grid>
        <badgeView:SfBadgeView />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;
    namespace BadgeViewGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfBadgeView badgeView = new SfBadgeView();
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or a later version.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P`, type **.NET:New Project**, and press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Core` to install the Syncfusion<sup>®</sup> .NET MAUI Core package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace BadgeViewGettingStarted
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

## Step 4:  Add a basic Badge View

1. To initialize the control, import the Core namespace into your code.
2. Initialize [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

   <ContentPage
    . . .    
    xmlns:badgeView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <Grid>
        <badgeView:SfBadgeView />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;
    namespace BadgeViewGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfBadgeView badgeView = new SfBadgeView();
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
2. Install the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or a later version.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select .NET (C#), and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the terminal in Rider and manually run: `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace BadgeViewGettingStarted
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

## Step 4:  Add a basic Badge View

1. To initialize the control, import the Core namespace into your code.
2. Initialize [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

   <ContentPage
    . . .    
    xmlns:badgeView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <Grid>
        <badgeView:SfBadgeView />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;
    namespace BadgeViewGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfBadgeView badgeView = new SfBadgeView();
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}


## Adding a badge notification text

Add text to Badge View using the [BadgeText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeText) property.

{% tabs %}

{% highlight xaml %}

<badgeView:SfBadgeView>        
    <badgeView:SfBadgeView BadgeText="20" />          
</badgeView:SfBadgeView>

{% endhighlight %}

{% highlight c# %}
   
SfBadgeView badgeView = new SfBadgeView();

//Adding text to the badge view.

badgeView.BadgeText = "20";

this.Content = badgeView;

{% endhighlight %}

{% endtabs %}

## Adding a content

An image, button, label or any view can be added to the Badge View using the [Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_Content) property. If you need to display a custom icon or image in the badge, ensure the image is included correctly in your project resources.

{% tabs %}

{% highlight xaml %}

<badgeView:SfBadgeView HorizontalOptions="Center" VerticalOptions="Center" >
        <badgeView:SfBadgeView.Content>
            <Button Text="Primary" WidthRequest="120"  HeightRequest="60"/>
        </badgeView:SfBadgeView.Content>
</badgeView:SfBadgeView>   

{% endhighlight %}

{% highlight c# %}
	
SfBadgeView badgeView = new SfBadgeView();
badgeView.HorizontalOptions = LayoutOptions.Center;
badgeView.VerticalOptions = LayoutOptions.Center;
//Adding image to the content of the badge view.
Button button = new Button();
button.Text = "Primary";
button.WidthRequest = 120;
button.HeightRequest = 60;
badgeView.Content = button;
Content = badgeView;

{% endhighlight %}
 
{% endtabs %}

The following code sample gives you the complete code for Badge View with badge notification types and text.

{% tabs %}

{% highlight xaml %}

<badgeView:SfBadgeView HorizontalOptions="Center" VerticalOptions="Center" BadgeText="20">
        <badgeView:SfBadgeView.Content>
            <Button Text="Primary" WidthRequest="120"  HeightRequest="60"/>
        </badgeView:SfBadgeView.Content>
</badgeView:SfBadgeView>


{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfBadgeView badgeView = new SfBadgeView();
    badgeView.HorizontalOptions = LayoutOptions.Center;
    badgeView.VerticalOptions = LayoutOptions.Center;
    badgeView.BadgeText = "20";

    //Adding image to the content of the badge view.
    Button button = new Button();
    button.Text = "Primary";
    button.WidthRequest = 120;
    button.HeightRequest = 60;
    badgeView.Content = button;
    Content = badgeView;
}

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![.NET MAUI Badge View](getting-started_images/net_maui_badge_view_getting_started.png) 

You can download the getting started project of this demo from [GitHub](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-BadgeView)

N> You can refer to our [.NET MAUI Badge View](https://www.syncfusion.com/maui-controls/maui-badge-view) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Badge View example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/BadgeView/SampleBrowser.Maui.BadgeView/Samples/BadgeView) that shows you how to render the Badge View in .NET MAUI.
