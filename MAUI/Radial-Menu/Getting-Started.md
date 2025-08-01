---
layout: post
title: Getting Started with .NET MAUI Radial Menu Control | Syncfusion®
description: Learn about getting started with the Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) control, its elements, and more.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# Getting Started with .NET MAUI Radial Menu

This section guides you through setting up and configuring a [SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html) in your .NET MAUI application. Follow the steps below to add a basic [SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html) to your project.

To quickly get started with the .NET MAUI Radial Menu, watch this video.

{% youtube "https://www.youtube.com/watch?v=VxufXFzSh0M" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Radial Menu NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.RadialMenu](https://www.nuget.org/packages/Syncfusion.Maui.RadialMenu/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace RadialMenuGettingStarted
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

## Step 4: Add a Radial Menu

1. To initialize the control, import the Radial Menu namespace into your code.
2. Initialize [SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html).

{% tabs %}
{% highlight xaml %}
<ContentPage
    . . .    
    xmlns:radialMenu="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu">
        <radialMenu:SfRadialMenu />
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.RadialMenu;
namespace RadialMenuGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
            SfRadialMenu radialMenu = new SfRadialMenu();
            this.Content = radialMenu;
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Radial Menu NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.RadialMenu` to install the Syncfusion<sup>®</sup> .NET MAUI Radial Menu package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace RadialMenuGettingStarted
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

## Step 4: Add a Radial Menu

1. To initialize the control, import the Radial Menu namespace into your code.
2. Initialize [SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html).

{% tabs %}
{% highlight xaml %}
<ContentPage
    . . .    
    xmlns:radialMenu="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu">
        <radialMenu:SfRadialMenu />
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.RadialMenu;
namespace RadialMenuGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
            SfRadialMenu radialMenu = new SfRadialMenu();
            this.Content = radialMenu;
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
2. Install the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Radial Menu NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.RadialMenu](https://www.nuget.org/packages/Syncfusion.Maui.RadialMenu/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight C# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace RadialMenuGettingStarted
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

## Step 4: Add a Radial Menu

1. To initialize the control, import the Radial Menu namespace into your code.
2. Initialize [SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html).

{% tabs %}
{% highlight xaml %}
<ContentPage
    . . .    
    xmlns:radialMenu="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu">
        <radialMenu:SfRadialMenu />
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.RadialMenu;
namespace RadialMenuGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
            SfRadialMenu radialMenu = new SfRadialMenu();
            this.Content = radialMenu;
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

## Adding Radial Menu with items

{% tabs %}

{% highlight xaml %}

<ContentPage 
            ...
             xmlns:radialMenu="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu">
        <radialMenu:SfRadialMenu x:Name="radialMenu" 
                                CenterButtonText="Edit"
                                CenterButtonFontSize="15">
            <radialMenu:SfRadialMenu.Items>
                <radialMenu:SfRadialMenuItem Text="Cut"
                                            FontSize="15"/>
                <radialMenu:SfRadialMenuItem Text="Copy"
                                            FontSize="15"/>
                <radialMenu:SfRadialMenuItem Text="Paste"
                                            FontSize="15"/>
                <radialMenu:SfRadialMenuItem Text="Crop"
                                            FontSize="15"/>
                <radialMenu:SfRadialMenuItem Text="Paint"
                                            FontSize="15"/>
            </radialMenu:SfRadialMenu.Items>
        </radialMenu:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialMenuGettingStarted
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


![Getting started with .NET MAUI Radial Menu.](images/getting-started/maui-radialmenu-getting-started.png)

N> You can find the getting started sample of .NET MAUI Radial Menu from this [link](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-Radial-Menu).

N> You can refer to our [.NET MAUI Radial Menu](https://www.syncfusion.com/maui-controls/maui-radial-menu) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Effects View example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/RadialMenu) that shows you how to render the Effects View in .NET MAUI.
