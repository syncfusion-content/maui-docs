---
layout: post
title: Getting Started with .NET MAUI PullToRefresh control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI PullToRefresh (SfPullToRefresh) control, its elements, and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
---

# Getting Started with .NET MAUI PullToRefresh (SfPullToRefresh)

This section provides a quick overview of how to get started with the .NET MAUI PullToRefresh (SfPullToRefresh) for MAUI and a walk-through to configure the .NET MAUI PullToRefresh control in a real-time scenario.

## Creating an application using the .NET MAUI PullToRefresh

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfPullToRefresh to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.PullToRefresh and install it.
 3. Import the control namespace `Syncfusion.Maui.PullToRefresh` in XAML or C# code.
 4. Initialize the `SfPullToRefresh` control.
 
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

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

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

## Defining PullableConent

`SfPullToRefresh.PullableContent` view serves as the designated area where users can initiate the pull-to-refresh action, enabling them to refresh and update the content within the view.

Refer to the following code example for PulltoRefresh.

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

![.NET MAUI PullToRefresh with slide on top transition mode](Images/getting-started//maui-pull-to-refresh-slideontop-mode.gif)

N> [View sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-pull-to-refresh/tree/master).

If we run the above sample with `TransitionMode` set to `Push`, the output will be as shown in the following.

![.NET MAUI PullToRefresh with slide on top transition mode](Images/getting-started//maui-pull-to-refresh-push-mode.gif).

N> PullToRefresh does not have a view. So, it is mandatory to set size or LayoutOptions when loaded inside any layouts.