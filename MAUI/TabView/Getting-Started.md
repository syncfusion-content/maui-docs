---
layout: post
title: Getting Started with .NET MAUI Tab View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Tab View (SfTabView) control, its elements and more.
platform: maui
control: Tab View
documentation: ug
---

# Getting Started with .NET MAUI Tab View (SfTabView)

This section explains the steps required to configure the .NET MAUI Tab View control and customize its elements.

## Adding SfTabView reference

Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfTabView to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.TabView` and then install it.

## Register the handler

Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file register the handler for Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace TabViewMauiSample
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

## Create a simple Tab View

This section explains how to create a Tab View and configure it. The control can be configured entirely in C# code or by using XAML markup. The following screenshot illustrates the output of Tab View on iOS, Android and MacCatalyst.

![TabViewImage](images/TabView.png)

### Creating the project

Create a new .NET MAUI application in Visual Studio.

### Adding SfTabView control

Add the nuget to the project as discussed in the above reference section.

Add the namespace as shown in the following code.

{% tabs %}

{% highlight xaml %}

xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
	
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

{% endhighlight %}

{% endtabs %}

Set the control to content in `ContentPage`.

Tab items can be added to the Tab View through the `Items` property of `SfTabView`, which holds the collection of `SfTabItem` through `TabItemsCollection`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            x:Class="TabViewMauiSample.MainPage"
            xmlns:tabView="http://schemas.syncfusion.com/maui"
            BackgroundColor="{DynamicResource PageBackgroundColor}">
    <ContentPage.Content> 
        <tabView:SfTabView /> 
    </ContentPage.Content>  
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.TabView;

namespace TabViewMauiSample  
{  
    public partial class MainPage : ContentPage                  
    {   
        private SfTabView tabView;   
        public MainPage()   
        {   
            InitializeComponent();       
            tabView = new SfTabView();   
            this.Content = tabView;  
        }  
    }  
}  

{% endhighlight %}

{% endtabs %}

### How to add items in SfTabView

Tab items can be added to the control using the `Items` property of `SfTabView`.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="TabViewMauiSample.MainPage"
             xmlns:tabView="http://schemas.syncfusion.com/maui"
             BackgroundColor="{DynamicResource SecondaryColor}">
    <ContentPage.Content>
          <tabView:SfTabView x:Name="tabView">
                <tabView:SfTabView.Items>
                    <tabView:SfTabItem Header="Item1">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Red" />
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>

                    <tabView:SfTabItem Header="Item2">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Green"/>
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>

                    <tabView:SfTabItem Header="Item3">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Blue"/>
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>
                </tabView:SfTabView.Items>
            </tabView:SfTabView>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

namespace TabViewMauiSample
{
	public partial class TabView : ContentPage
	{
        SfTabView tabView;
		public TabView ()
		{
			InitializeComponent ();
            var tabView = new SfTabView();
            Grid allContactsGrid = new Grid { BackgroundColor = Color.Red };
            Grid favoritesGrid = new Grid { BackgroundColor = Color.Green };
            Grid contactsGrid = new Grid { BackgroundColor = Color.Blue };
            var tabItems = new TabItemCollection
            {
                new SfTabItem()
                {
                    Header = "Item1",
                    Content = allContactsGrid
                },
                new SfTabItem()
                {
                    Header = "Item2",
                    Content = favoritesGrid
                },
                new SfTabItem()
                {
                    Header = "Item3",
                    Content = contactsGrid
                }
            };

            tabView.Items = tabItems;
            this.Content = tabView;
		}
	}
}

{% endhighlight %}

{% endtabs %}