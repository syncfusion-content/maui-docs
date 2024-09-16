---
layout: post
title: Getting Started with Syncfusion .NET MAUI Avatar View
description: This section will explain how to initialize and use the .NET MAUI Avatar View control in simple way.
platform: maui
control: SfAvatarView
documentation: ug
---

# Getting Started with .NET MAUI Avatar View

This section guides you through setting up and configuring a [AvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add a basic Avatar View to your project.

To get start quickly with our .NET MAUI Avatar View, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=XrTvIgeeUm0" %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
1. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New MAUI Project

1. Launch Visual Studio or VS Code.
1. Navigate to **File > New > Project,** then select the **.NET MAUI App** template.
1. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Core NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
1. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
1. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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


## Step 4: Add a Basic Avatar View

1. To initialize the control, import the Core namespace into your code.
1. Initialize [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1).

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

## Step 5: Adding a image in .NET MAUI Avatar View

You can add a custom image for displaying in [.NET MAUI Avatar View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) using the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource) property. And set the [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentType) to `Custom.` To ensure the avatar image appears correctly, place the image in the `Resources/Images` directory.

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

![.NET MAUI Avatar View Getting Started](GettingStarted_Images/Getting_Started_Sample.png) 

The Getting Started sample of .NET MAUI Avatar View is available in this following link: [Getting Started](https://github.com/SyncfusionExamples/maui-avatarview-samples). 

N> You can refer to our [.NET MAUI Avatar View](https://www.syncfusion.com/maui-controls/maui-avatarview) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Avatar View Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/AvatarView) that shows you how to render the Avatar View in .NET MAUI.