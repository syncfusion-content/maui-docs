---
layout: post
title: Getting Started with .NET MAUI AI-Powered Scheduler | Syncfusion®
description: Learn about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler (SfSmartScheduler) control and its basic features.
platform: maui
control: SfSmartScheduler
documentation: ug
---

# Getting started with .NET MAUI Smart Scheduler

This section explains how to add the smart scheduler as well as the essential aspects for getting started with the smart Scheduler and also provides a walk-through to configure the [.NET MAUI Smart Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) control in a real-time scenario. Follow the steps below to add a .NET Smart Scheduler control to your project.

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

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI SmartComponents NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.SmartComponents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.html) and install the latest version.
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

## Step 4: Register the AI Service

To configure the AI services, you must call the `ConfigureSyncfusionAIServices()` method in the `MauiProgram.cs` file.

{% highlight c# hl_lines="6 31" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.SmartComponents.Hosting;

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

            string key = "<MENTION-YOUR-KEY>";
            Uri azureEndPoint = new Uri("<MENTION-YOUR-URL>");
            string deploymentName = "<MENTION-YOUR-DEPLOYMENT-NAME>";

            // Shows how to configure Azure AI service to the Smart Components.
            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(azureEndPoint, new AzureKeyCredential(key));
            IChatClient azureChatClient = azureOpenAIClient.GetChatClient(deploymentName).AsIChatClient();

            builder.Services.AddChatClient(azureChatClient);
            builder.ConfigureSyncfusionAIServices();

            return builder.Build();
        }
    }
}

{% endhighlight %}

N>
- You can refer to [Configure Chat Client](https://help.syncfusion.com/maui/common/configure-ai-service) for services like `Azure`, `OpenAI`, and `Ollama`.
- You can also refer to the [Custom AI Service](https://help.syncfusion.com/maui/common/custom-ai-service) section to configure your own services, such as `Claude`, `Gemini`, `DeepSeek`, `Groq`, etc.
- If you are using a custom AI service, there is no need to register `ConfigureSyncfusionAIServices()` in `MauiProgram`.

## Step 5: Add .NET MAUI Smart Scheduler control

1. To initialize the control, import the [Syncfusion.Maui.SmartComponents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.html) namespace into your code.
2. Initialize [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <smartScheduler:SfSmartScheduler />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.SmartComponents;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSmartScheduler smartScheduler = new SfSmartScheduler();
        this.Content = smartScheduler;
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
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI SmartComponents NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.SmartComponents` to install the Syncfusion<sup>®</sup> .NET MAUI SmartComponents NuGet package.
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

## Step 4: Register the AI Service

To configure the AI services, you must call the `ConfigureSyncfusionAIServices()` method in the `MauiProgram.cs` file.

{% highlight c# hl_lines="6 31" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.SmartComponents.Hosting;

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

            string key = "<MENTION-YOUR-KEY>";
            Uri azureEndPoint = new Uri("<MENTION-YOUR-URL>");
            string deploymentName = "<MENTION-YOUR-DEPLOYMENT-NAME>";

            // Shows how to configure Azure AI service to the Smart Components.
            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(azureEndPoint, new AzureKeyCredential(key));
            IChatClient azureChatClient = azureOpenAIClient.GetChatClient(deploymentName).AsIChatClient();

            builder.Services.AddChatClient(azureChatClient);
            builder.ConfigureSyncfusionAIServices();

            return builder.Build();
        }
    }
}
{% endhighlight %}

N>
- You can refer to [Configure Chat Client](https://help.syncfusion.com/maui/common/configure-ai-service) for services like `Azure`, `OpenAI`, and `Ollama`.
- You can also refer to the [Custom AI Service](https://help.syncfusion.com/maui/common/custom-ai-service) section to configure your own services, such as `Claude`, `Gemini`, `DeepSeek`, `Groq`, etc.
- If you are using a custom AI service, there is no need to register `ConfigureSyncfusionAIServices()` in `MauiProgram`.

## Step 5: Add .NET MAUI Smart Scheduler control

1. To initialize the control, import the [Syncfusion.Maui.SmartComponents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.html) namespace into your code.
2. Initialize [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <smartScheduler:SfSmartScheduler />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.SmartComponents;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSmartScheduler smartScheduler = new SfSmartScheduler();
        this.Content = smartScheduler;
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

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI SmartComponents NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.SmartComponents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.html) and install the latest version.
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

## Step 4: Register the AI Service

To configure the AI services, you must call the `ConfigureSyncfusionAIServices()` method in the `MauiProgram.cs` file.

{% highlight c# hl_lines="6 31" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.SmartComponents.Hosting;

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

            string key = "<MENTION-YOUR-KEY>";
            Uri azureEndPoint = new Uri("<MENTION-YOUR-URL>");
            string deploymentName = "<MENTION-YOUR-DEPLOYMENT-NAME>";

            // Shows how to configure Azure AI service to the Smart Components.
            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(azureEndPoint, new AzureKeyCredential(key));
            IChatClient azureChatClient = azureOpenAIClient.GetChatClient(deploymentName).AsIChatClient();

            builder.Services.AddChatClient(azureChatClient);
            builder.ConfigureSyncfusionAIServices();

            return builder.Build();
        }
    }
}
{% endhighlight %}

N>
- You can refer to [Configure Chat Client](https://help.syncfusion.com/maui/common/configure-ai-service) for services like `Azure`, `OpenAI`, and `Ollama`.
- You can also refer to the [Custom AI Service](https://help.syncfusion.com/maui/common/custom-ai-service) section to configure your own services, such as `Claude`, `Gemini`, `DeepSeek`, `Groq`, etc.
- If you are using a custom AI service, there is no need to register `ConfigureSyncfusionAIServices()` in `MauiProgram`.

## Step 5: Add .NET MAUI Smart Scheduler control

1. To initialize the control, import the [Syncfusion.Maui.SmartComponents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.html) namespace into your code.
2. Initialize [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <smartScheduler:SfSmartScheduler />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.SmartComponents;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSmartScheduler smartScheduler = new SfSmartScheduler();
        this.Content = smartScheduler;
    }
}

{% endhighlight %}
{% endtabs %}
{% endtabcontent %}
{% endtabcontents %}

## Step 6: Running the Application

Press **F5** to build and run the application. Once compiled, the Smart Scheduler will be displayed, and AI-powered features will be available after configuration.

<img src="images\overview\maui-smart-scheduler-overview.png" width="600" alt=".NET MAUI AI-Powered Scheduler." />

N> You can refer to our [.NET MAUI Smart Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Smart Scheduler Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartComponents) that shows you how to render the Smart Scheduler in .NET MAUI.