---
layout: post
title: Getting Started with .NET MAUI Busy Indicator control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control, its elements, and more.
platform: maui
control: BusyIndicator
documentation: ug
---

# Getting Started with .NET MAUI Busy Indicator (SfBusyIndicator)

## Getting started with .NET MAUI Busy Indicator(SfBusyIndicator)

This section explains the steps to configure a SfBusyIndicator control in a real-time scenario and provides a walk-through on some of the customization features available in SfBusyIndicator control.

## Adding a SfBusyIndicator reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [SfBusyIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}
   
    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Microsoft.Maui.Controls.Compatibility;
    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    `using Syncfusion.Maui.Core.Hosting`;

    namespace BusyIndicatorSample
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

## Create a Simple SfBusyIndicator

The SfBusyIndicator control is configured entirely in C# code or by using XAML markup. The following steps explain how to create a SfBusyIndicator and configure its elements.

### Adding a SfBusyIndicator control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

Step 3: Set the control to content in `ContentPage.`

{% tabs %}

{% highlight xaml %}

    <ContentPage.Content> 
         <core:SfBusyIndicator x:Name="busyIndicator"
                               IsRunning = "True"/> 
    </ContentPage.Content>  


{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

    namespace BusyIndicatorSample   
    {  
        public partial class MainPage : ContentPage                  
        {   
           SfEffectsView effectsView;

           public MainPage()   
           {   
               InitializeComponent();       
               busyIndicator = new SfBusyIndicator(){IsRunning = true}; 
               this.Content = busyIndicator;  
           }  
        }      
    }  

{% endhighlight %}

{% endtabs %}

## Setting Animation Type

SfBusyIndicator provides some predefined animation types like Cupertino, LinearMaterial, and CircularMaterial. Users can select any one of the animation types using the `AnimationType` property.

The following example depicts the CircularMaterial type animation for SfBusyIndicator.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
             x:Class="BusyIndicatorSample.MainPage">

        <ContentPage.Content>
            <core:SfBusyIndicator x:Name="busyIndicator"
                                  IsRunning="True"
                                  AnimationType="CircularMaterial" />
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;
    using Microsoft.Maui;
    using Microsoft.Maui.Controls;

    namespace BusyIndicatorSample
    {
       public partial class MainPage : ContentPage
       {
           public MainPage()
           {
               InitializeComponent();
               SfBusyIndicator busyIndicator = new SfBusyIndicator()
               {
                   IsRunning = true,
                   AnimationType = AnimationType.CircularMaterial;
               };
            this.Content = busyIndicator;
            }
       }
    }

{% endhighlight %}

{% endtabs %}

