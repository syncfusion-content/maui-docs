---
layout: post
title: Getting Started with Syncfusion® .NET MAUI Avatar View
description: Learn how to initialize and use the .NET MAUI Avatar View control in a simple way.
platform: MAUI
control: SfAvatarView
documentation: UG
---

# Getting Started with .NET MAUI Avatar View

This section guides you through setting up and configuring a [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add a basic Avatar View to your project.

To quickly get started with the .NET MAUI Avatar View, watch this video.

{% youtube "https://www.youtube.com/watch?v=XrTvIgeeUm0" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or a later version.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace AvatarViewSample
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


## Step 4: Add a basic Avatar View

1. To initialize the control, import the Core namespace into your code.
2. Initialize [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <Grid>
        <sfavatar:SfAvatarView />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;
    namespace AvatarViewGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfAvatarView avatarView = new SfAvatarView();
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P`, type **.NET:New Project** and press **Enter**.
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

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace AvatarViewSample
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


## Step 4: Add a basic Avatar View

1. To initialize the control, import the Core namespace into your code.
2. Initialize [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <Grid>
        <sfavatar:SfAvatarView />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;
    namespace AvatarViewGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfAvatarView avatarView = new SfAvatarView();
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

1. Go to **File > New Solution**, select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the terminal in Rider and manually run: `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace AvatarViewSample
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


## Step 4: Add a basic Avatar View

1. To initialize the control, import the Core namespace into your code.
2. Initialize [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <Grid>
        <sfavatar:SfAvatarView />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;
    namespace AvatarViewGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfAvatarView avatarView = new SfAvatarView();
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Adding an image in .NET MAUI Avatar View

You can add a custom image to display in the [.NET MAUI Avatar View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) using the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource) property. Set the [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentType) to `Custom.` To ensure the avatar image appears correctly, place the image in the `Resources/Images` directory.

{% tabs %}

{% highlight xaml %}

<ContentPage.Content>
<Grid>
    <sfavatar:SfAvatarView ContentType="Custom"
                           ImageSource="alex.png"
                           VerticalOptions="Center"
                           HorizontalOptions="Center"   
                           HeightRequest="50"
                           CornerRadius="25"
                           WidthRequest="50" 
                           Stroke="Black"
                           StrokeThickness="1"/>
</Grid>
</ContentPage.Content>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace AvatarViewGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
	        //main grid
            Grid mainGrid = new Grid();

            // Create an SfAvatarView control.
            SfAvatarView avatarView = new SfAvatarView();
            avatarView.VerticalOptions = LayoutOptions.Center;
            avatarView.HorizontalOptions = LayoutOptions.Center;
            avatarView.ContentType = ContentType.Custom;
            avatarView.ImageSource = "alex.png";
            avatarView.WidthRequest = 50;
            avatarView.HeightRequest = 50;
            avatarView.CornerRadius = 25;
            avatarView.Stroke = Colors.Black;
            avatarView.StrokeThickness = 1;
            mainGrid.Children.Add(avatarView);
            this.Content = mainGrid;
        }
    }
}
 
{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![.NET MAUI Avatar View](GettingStarted_Images/Getting_Started_Sample.png) 

The Getting Started sample of .NET MAUI Avatar View is available in this following link: [Getting Started](https://github.com/SyncfusionExamples/maui-avatarview-samples). 

N> You can refer to our [.NET MAUI Avatar View](https://www.syncfusion.com/maui-controls/maui-avatarview) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Avatar View example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/AvatarView) that shows you how to render the Avatar View in .NET MAUI.