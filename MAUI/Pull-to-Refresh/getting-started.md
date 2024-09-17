---
layout: post
title: Getting Started with .NET MAUI PullToRefresh control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI PullToRefresh (SfPullToRefresh) control, its elements, and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
---

# Getting Started with .NET MAUI PullToRefresh

This section guides you through setting up and configuring a [PullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html) in your .NET MAUI application. Follow the steps below to add a basic PullToRefresh to your project.

## Prerequisites
Before proceeding, ensure the following are in place:

 1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
 2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a .NET MAUI project

### Visual Studio

 1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
 2. Name the project and choose a location, then click **Next**.
 3. Select the .NET framework version and click **Create**.

### Visual Studio Code

 1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
 2. Choose the **.NET MAUI App** template.
 3. Select the project location, type the project name and press enter.
 4. Then choose **Create project**.
 
## Step 2: Install the Syncfusion MAUI PullToRefresh NuGet Package
 
 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.PullToRefresh](https://www.nuget.org/packages/Syncfusion.Maui.PullToRefresh) and install the latest version.
 3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 20" %}

    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    using Microsoft.Maui.Hosting;
    using Syncfusion.Maui.Core.Hosting;

    namespace GettingStarted
    {
        public class MauiProgram 
        {
            public static MauiApp CreateMauiApp()
            {
                var builder = MauiApp.CreateBuilder();
                builder
                    .UseMauiApp<App>()
                    .ConfigureFonts(fonts =>
                    {
                        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    });

                builder.ConfigureSyncfusionCore();
                return builder.Build();
            }
        }
    }

{% endhighlight %} 
{% endtabs %}
 
## Step 4: Add a Basic PullToRefresh

 1. To initialize the control, import the `Syncfusion.Maui.PullToRefresh` namespace into your code.
 2. Initialize [SfPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html).
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

    <ContentPage
        xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh">
        <syncfusion:SfPullToRefresh />
    </ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}

    using Syncfusion.Maui.PullToRefresh;
    . . .

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfPullToRefresh pullToRefresh = new SfPullToRefresh();
            this.Content = pullToRefresh;
        }
    }

{% endhighlight %}
{% endtabs %}

## Step 5: Define the PullableContent

The [PullableContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent) view serves as the designated area where users can initiate the pull-to-refresh action, enabling them to refresh and update the content within the view.

To show the progress indicator while updating the view, set [IsRefreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_IsRefreshing) property to `True` using [Refreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshing) event. Once view is updated, remove the progress indicator by setting `IsRefreshing` property to `False`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7 11" %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="GettingStarted.MainPage"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh">

        <syncfusion:SfPullToRefresh x:Name="pullToRefresh">
            <syncfusion:SfPullToRefresh.PullableContent>
                <StackLayout>
                    <Label Text="sample page" />
                </StackLayout>
            </syncfusion:SfPullToRefresh.PullableContent>
        </syncfusion:SfPullToRefresh>
    </ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}

    namespace GettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
                this.pullToRefresh.Refreshing += PullToRefresh_Refreshing;
            }

            private async void PullToRefresh_Refreshing(object sender, EventArgs e)
            {
                this.pullToRefresh.IsRefreshing = true;
                await Task.Delay(2000);
                this.pullToRefresh.IsRefreshing = false;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Step 6: Running the Application

Press **F5** to build and run the application. Once compiled, perform pull-to-refresh action on pullable content view to refresh the view.

![.NET MAUI PullToRefresh with slide on top transition mode](Images/getting-started//maui-pull-to-refresh-slideontop-mode.gif)

N> [View sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-pull-to-refresh/tree/master).

If we run the above sample with [TransitionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_TransitionMode) set to [Push](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html#Syncfusion_Maui_PullToRefresh_PullToRefreshTransitionType_Push), the output will be as shown in the following.

![.NET MAUI PullToRefresh with slide on top transition mode](Images/getting-started//maui-pull-to-refresh-push-mode.gif).

N> PullToRefresh does not have a view. So, it is mandatory to set size or LayoutOptions when loaded inside any layouts.