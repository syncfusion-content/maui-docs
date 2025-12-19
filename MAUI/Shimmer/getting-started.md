---
layout: post
title: Getting Started for .NET MAUI Shimmer control | Syncfusion
description: Learn here about the getting started with Syncfusion .NET MAUI Shimmer (SfShimmer) control, its elements and more.
platform: maui
control: SfShimmer
documentation: ug
---

> **Notice**: After **Volume 1 2025 (Mid of March 2025)**, feature enhancements for this control will no longer be available in the Syncfusion<sup>&reg;</sup> package. Please switch to the **Syncfusion Toolkit for .NET MAUI** for continued support. For a smooth transition refer this [migration document](https://help.syncfusion.com/maui-toolkit/migration).

# Getting started of .NET MAUI Shimmer

This section explains how to add the [.NET MAUI Shimmer](https://www.syncfusion.com/maui-controls/maui-shimmer) control. Follow the steps below to add a .NET MAUI Shimmer control to your project.

To get start quickly with our .NET MAUI Shimmer, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=NGGQhUA9Bu0"%}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install .NET SDK
  - [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later must be installed.
2. Set up a .NET MAUI Environment with Visual Studio. Supported Visual Studio Versions:
  - Visual Studio 2022: Version 17.13 or later (e.g., 17.14.7) for .NET 9 development.
  - Visual Studio 2026: Required for .NET 10 development.

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Core NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI Shimmer control

1. To initialize the control, import the `Syncfusion.Maui.Shimmer` namespace into your code.
2. Initialize [SfShimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:shimmer="clr-namespace:Syncfusion.Maui.Shimmer;assembly=Syncfusion.Maui.Core">

    <shimmer:SfShimmer />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Shimmer;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfShimmer shimmer = new SfShimmer();
        this.Content = shimmer;
    }
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Core NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Core` to install the Syncfusion<sup>®</sup> .NET MAUI Core NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI Shimmer control

1. To initialize the control, import the `Syncfusion.Maui.Shimmer` namespace into your code.
2. Initialize [SfShimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:shimmer="clr-namespace:Syncfusion.Maui.Shimmer;assembly=Syncfusion.Maui.Core">

    <shimmer:SfShimmer />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Shimmer;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfShimmer shimmer = new SfShimmer();
        this.Content = shimmer;
    }
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI Shimmer control

1. To initialize the control, import the `Syncfusion.Maui.Shimmer` namespace into your code.
2. Initialize [SfShimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:shimmer="clr-namespace:Syncfusion.Maui.Shimmer;assembly=Syncfusion.Maui.Core">

    <shimmer:SfShimmer />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Shimmer;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfShimmer shimmer = new SfShimmer();
        this.Content = shimmer;
    }
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

## Change different shimmer views

The [.NET MAUI Shimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) control provides seven different shimmer types of views. It can be assigned to the control using the [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_Type) property. By default, the control is assigned to the [CirclePersona](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerType.html#Syncfusion_Maui_Shimmer_ShimmerType_CirclePersona) view.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<shimmer:SfShimmer x:Name="shimmer" VerticalOptions="Fill"
                   Type="CirclePersona">
    <StackLayout>
        <Label
            Text="Content is loaded!"
            HorizontalOptions="CenterAndExpand"
            VerticalOptions="CenterAndExpand">
        </Label>
    </StackLayout>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfShimmer shimmer = new SfShimmer()
   {
      Type = ShimmerType.CirclePersona,
      VerticalOptions = LayoutOptions.Fill,
      Content = new Label
      {
         Text = "Content is loaded!!"
      }
   };

   this.Content = shimmer;

{% endhighlight %}
{% endtabs %}

![Circle persona shimmer view in .NET MAUI.](images/overview/maui-circle-persona.gif)

## Loading shimmer content

Shimmer content is loaded when the [`IsActive`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_IsActive) property of the [`SfShimmer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) is disabled.

{% tabs %} 

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

        <shimmer:SfShimmer x:Name="shimmer" VerticalOptions="FillAndExpand" IsActive ="false">
                <shimmer:SfShimmer.Content>
                     <StackLayout>
                        <Label Text="Content is loaded!"/>
                      </StackLayout>
                </shimmer:SfShimmer.Content>
        </shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

            shimmer = new SfShimmer()
            {
                IsActive = false,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Content is loaded!"
                }
            };
            this.Content = shimmer;

{% endhighlight %}

{% endtabs %}

N> You can refer to our [.NET MAUI Shimmer](https://www.syncfusion.com/maui-controls/maui-shimmer) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Shimmer Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Shimmer) that shows you how to render the Shimmer in .NET MAUI.