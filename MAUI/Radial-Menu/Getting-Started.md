---
layout: post
title: Getting Started with MAUI Radial Menu Control | Syncfusion
description: Learn here about getting started with Syncfusion MAUI Radial Menu (SfRadialMenu) control, its elements and more.
platform: MAUI
control: RadialMenu (SfRadialMenu)
documentation: ug
---

# Getting Started with .NET MAUI RadialMenu Control (SfRadialMenu)

This section guides you through setting up and configuring a [.NET MAUI RadialMenu control (SfRadialMenu)](https://www.syncfusion.com/maui-controls/maui-radial-menu) in your .NET MAUI application. Follow the steps below to add a basic [.NET MAUI RadialMenu control (SfRadialMenu)](https://www.syncfusion.com/maui-controls/maui-radial-menu) to your project.

To get start quickly with our .NET MAUI Radio Button, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=VxufXFzSh0M" %}

## Prerequisites
Before proceeding, ensure the following are in place:
1. Install .NET 7 SDK or later.

2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured

## Create a New MAUI Project

1. Open Visual Studio or VS Code.
2. Go to File > New > Project and choose the .NET MAUI App template.
3. Name the project and choose a location, then click Create.

## Install the Syncfusion MAUI RadialMenu NuGet Package

1. In Solution Explorer, right-click the project and choose Manage NuGet Packages.
2. Search for [Syncfusion.Maui.RadialMenu](https://www.nuget.org/packages/Syncfusion.Maui.RadialMenu) and install the latest version.
Ensure the necessary dependencies are installed correctly, and the project is restored.

## Register the handler

The [Syncfusion.Maui.Core](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.html) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

    
    using Syncfusion.Maui.Core.Hosting;
    public static class MauiProgram
    {
	    public static MauiApp CreateMauiApp()
	    {
	        var builder = MauiApp.CreateBuilder();
		    builder
			    .ConfigureSyncfusionCore()
			    .UseMauiApp<App>()
			    .ConfigureFonts(fonts =>
			    {
				    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			    });

		    return builder.Build();
	    }
    }

{% endhighlight %}
{% endtabs %}

## Create a Simple .NET MAUI SfRadialMenu

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.RadialMenu;

{% endhighlight %}
{% endtabs %}

Step 3: Set the control to content in `ContentPage`.

{% tabs %}
{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8">
    <ContentPage    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                    xmlns:local="clr-namespace:GettingStarted"
	                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu" 
	                x:Class="GettingStarted.MainPage">
        <ContentPage.Content>
            <StackLayout>
                <syncfusion:SfRadialMenu x:Name="syncfusion"/>        
            </StackLayout>
        </ContentPage.Content>
     </ContentPage>

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.RadialMenu;

    namespace GettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
                StackLayout stackLayout = new StackLayout();
                SfRadialMenu radialMenu = new SfRadialMenu();
                stackLayout.Children.Add(syncfusion);
                this.Content = radialMenu;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

### Adding radial menu with items

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu" 
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu x:Name="radialMenu" 
                             CenterButtonText="Edit"
                             CenterButtonFontSize="15">
        <syncfusion:SfRadialMenu.Items>
            <syncfusion:SfRadialMenuItem Text="Cut"
                                         FontSize="15"/>
            <syncfusion:SfRadialMenuItem Text="Copy"
                                         FontSize="15"/>
            <syncfusion:SfRadialMenuItem Text="Paste"
                                         FontSize="15"/>
            <syncfusion:SfRadialMenuItem Text="Crop"
                                         FontSize="15"/>
            <syncfusion:SfRadialMenuItem Text="Paint"
                                         FontSize="15"/>
        </syncfusion:SfRadialMenu.Items>
    </syncfusion:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonText = "Edit",
                CenterButtonFontSize = 15
            };

            RadialMenuItemsCollection itemCollection = new RadialMenuItemsCollection();
            itemCollection.Add(new SfRadialMenuItem()
            {
                Text = "Cut",
                FontSize = 15
            });
            itemCollection.Add(new SfRadialMenuItem()
            {
                Text = "Copy",
                FontSize = 15
            });
            itemCollection.Add(new SfRadialMenuItem()
            {
                Text = "Paste",
                FontSize = 15
            });
            itemCollection.Add(new SfRadialMenuItem()
            {
                Text = "Crop",
                FontSize = 15
            });
            itemCollection.Add(new SfRadialMenuItem()
            {
                Text = "Paint",
                FontSize = 15
            });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}


![Getting started in .NET MAUI RadialMenu control.](images/getting-started/maui-radialmenu-getting-started.png)

N> You can find the getting started sample of .NET MAUI SfRadialMenu from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-Radial-Menu)



