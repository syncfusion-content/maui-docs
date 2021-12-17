---
layout: post
title: Getting Started with Syncfusion Badge View control for .NET MAUI
description: Learn here all about getting started with Syncfusion .NET MAUI Badge View (SfBadgeView) control its elements and more.
platform: maui
control: Badge View
documentation: ug
---

# Getting Started with .NET MAUI Badge View (SfBadgeView)

This section explains the steps required to configure the .NET MAUI Badge View control and customize its elements.

## Adding a SfBadgeView reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}
   
    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Microsoft.Maui.Controls.Compatibility;
    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    
`using Syncfusion.Maui.Core.Hosting;`

    namespace EffectsViewMauiSample
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

Add the following namespace.

{% tabs %}

{% highlight xaml %}

    xmlns:badge="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

## Initializing a badge view

Create an instance for the Badge View control, and add it as content.

{% tabs %}

{% highlight xaml %}

 <badge:SfBadgeView >        
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

//Initializing the badge view.

SfBadgeView sfBadgeView = new SfBadgeView();

this.Content = sfBadgeView;
	
{% endhighlight %}

{% endtabs %}

## Adding a badge text

Add text to Badge View using the `BadgeText` property.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView>        
    <badge:SfBadgeView BadgeText="20" />          
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}
   
SfBadgeView sfBadgeView = new SfBadgeView();

//Adding text to the badge view.

sfBadgeView.BadgeText = "20";

this.Content = sfBadgeView;

{% endhighlight %}

{% endtabs %}

## Adding a content

An Image, button, or label or any view can be added to the Badge View using the `Content` property.

{% tabs %}

{% highlight xaml %}

 <badge:SfBadgeView HorizontalOptions="Center" VerticalOptions="Center" >
        <badge:SfBadgeView.Content>
            <Button Text="Primary" WidthRequest="120"  HeightRequest="60"/>
        </badge:SfBadgeView.Content>
</badge:SfBadgeView>   

{% endhighlight %}

{% highlight c# %}
	
SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
//Adding image to the content of the badge view.
Button button = new Button();
button.Text = "Primary";
button.WidthRequest = 120;
button.HeightRequest = 60;
sfBadgeView.Content = button;
Content = sfBadgeView;

{% endhighlight %}
 
{% endtabs %}

The following code sample gives you the complete code for Badge View with badge types and text.

{% tabs %}

{% highlight xaml %}

 <badge:SfBadgeView HorizontalOptions="Center" VerticalOptions="Center" BadgeText="20">
        <badge:SfBadgeView.Content>
            <Button Text="Primary" WidthRequest="120"  HeightRequest="60"/>
        </badge:SfBadgeView.Content>
</badge:SfBadgeView>


{% endhighlight %}

{% highlight c# %}

        public MainPage()
        {
            InitializeComponent();
            SfBadgeView sfBadgeView = new SfBadgeView();
            sfBadgeView.HorizontalOptions = LayoutOptions.Center;
            sfBadgeView.VerticalOptions = LayoutOptions.Center;
            sfBadgeView.BadgeText = "20";

            //Adding image to the content of the badge view.
            Button button = new Button();
            button.Text = "Primary";
            button.WidthRequest = 120;
            button.HeightRequest = 60;
            sfBadgeView.Content = button;
            Content = sfBadgeView;
        }

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![.NET MAUI Badge View getting started](getting-started_images/Badgeview.png) 


