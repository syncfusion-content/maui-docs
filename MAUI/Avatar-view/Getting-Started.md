---
layout: post
title: Getting Started with Syncfusion .NET MAUI AvatarView
description: This section will explain how to initialize and use .NET MAUI SfAvataView control in simple way.
platform: .NET MAUI
control: SfAvatarView
documentation: ug
---

# Getting Started With .NET MAUI AvatarView (SfAvatarView)

## Getting started with SfAvatarView

This section explains the steps required to work with the SfAvatarView control for .NET MAUI.

## Adding SfAvatarView reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add SfAvatarView to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}
   
    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Microsoft.Maui.Controls.Compatibility;
    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    
`using Syncfusion.Maui.Core.Hosting;`

    namespace AvatarViewSample
    {
      public static class MauiProgram
      {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
			.`ConfigureSyncfusionCore()`
 
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

Add the following namespace to add .NET MAUI AvatarView.

{% tabs %}

{% highlight xaml %}

    xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

### Adding the SfAvatarView control as the content of ContentPage

You can add a custom image for displaying in SfAvatarView using the `ImageSource` property.

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

![.NET MAUI Avatar View Getting Started](GettingStartedImages/Getting_Started_Sample.png) 

