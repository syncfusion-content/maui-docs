---
layout: post
title: Getting Started with Syncfusion .NET MAUI Avatar View
description: This section will explain how to initialize and use the .NET MAUI Avatar View control in simple way.
platform: maui
control: SfAvatarView
documentation: ug
---

# Getting Started With .NET MAUI Avatar View (SfAvatarView)

## Creating an application using the .NET MAUI Avatar View

This section explains the steps required to work with the [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) control for .NET MAUI.

## Adding .NET MAUI Avatar View reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Avatar View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

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


## Adding a namespace

Add the following namespace to add [.NET MAUI Avatar View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

    xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

### Adding the .NET MAUI Avatar View control

You can add a custom image for displaying in [.NET MAUI Avatar View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) using the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource) property.

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
                           WidthRequest="50" />
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
            SfAvatarView avatarview = new SfAvatarView();
            avatarview.VerticalOptions = LayoutOptions.Center;
            avatarview.HorizontalOptions = LayoutOptions.Center;
            avatarview.BackgroundColor = Color.FromRgba("#ffb6c1");
            avatarview.ContentType = ContentType.Custom;
            avatarview.ImageSource = "alex.png";
            avatarview.WidthRequest = 50;
            avatarview.HeightRequest = 50;
            avatarview.CornerRadius = 25;
            mainGrid.Children.Add(avatarview);
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

