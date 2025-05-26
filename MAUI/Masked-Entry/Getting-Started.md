---
layout: post
title: Getting Started with .NET MAUI Masked Entry control | Syncfusion®
description: Learn about getting started with Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control, its elements, and more.
platform: maui
control: MaskedEntry
documentation: ug 
keywords: mask, SfMaskedEntry, maskedentry
---

# Getting Started with .NET MAUI Masked Entry

This section guides you through setting up and configuring a [Masked Entry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) in your .NET MAUI application. Follow the steps below to add a basic Masked Entry to your project.

To quickly get started with the .NET MAUI Masked Entry, watch this video.

{% youtube "https://www.youtube.com/watch?v=yTbh1Jo95Vw" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.8 or later).

## Step 1: Create a New MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project, select a location, and click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Verify all necessary dependencies are installed and the project is restored.

## Step 3: Register the Handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet package is a dependency for all Syncfusion<sup>®</sup> .NET MAUI controls. Register the handler for Syncfusion<sup>®</sup> core in the `MauiProgram.cs` file.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MaskedEntrySample
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

## Step 4: Add a Basic Masked Entry

**Step 1**: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

	<xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}

{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

**Step 2**: Add the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control with a desired name using the included namespace.

{% tabs %}

{% highlight xaml %}

	<editors:SfMaskedEntry x:Name="maskedentry" />
	
{% endhighlight %}

{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure the .NET MAUI extension is installed and configured, as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P**, type **.NET:New Project**, and press Enter.
2. Select the **.NET MAUI App** template.
3. Choose the project location, type the project name, and press Enter.
4. Choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Navigate to the project root directory where your `.csproj` file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Inputs` to install the Syncfusion<sup>®</sup> .NET MAUI Inputs package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the Handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet package is a dependency for all Syncfusion<sup>®</sup> .NET MAUI controls. Register the handler for Syncfusion<sup>®</sup> core in the `MauiProgram.cs` file.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MaskedEntrySample
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

## Step 4: Add a Basic Masked Entry

**Step 1**: Add the NuGet package to the project as discussed in the reference section above.

**Step 2**: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

	<xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}

{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

**Step 3**: Add the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control with the desired name using the included namespace.

{% tabs %}

{% highlight xaml %}

	<editors:SfMaskedEntry x:Name="maskedentry" />
	
{% endhighlight %}

{% highlight C# %}

        maskedEntry = new SfMaskedEntry();

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

## Step 5: Adding Mask to the Masked Entry

### Initialize MaskedEntry control using Simple Mask

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry WidthRequest="200"
                          ClearButtonVisibility="WhileEditing"
                          MaskType="Simple"
                          Mask="00/00/0000" />

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";

{% endhighlight %}
{% endtabs %}

![Simple mask in .NET MAUI Masked Entry.](maskedentry_images/net-maui-masked-entry-simple-mask.png)

### Initialize MaskedEntry control using RegEx Mask

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry WidthRequest="200"
                          ClearButtonVisibility="WhileEditing"
                          MaskType="RegEx"
                          Mask="[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}" />

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.RegEx;
maskedEntry.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}";

{% endhighlight %}
{% endtabs %}

![RegEx mask in .NET MAUI Masked Entry.](maskedentry_images/net-maui-masked-entry-regex-mask.png)

## Setting the Prompt Character

Each mask displays a prompt character (`_`) when there is no input. Customize this character using the [PromptChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PromptChar) property.

{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry WidthRequest="200"
                          ClearButtonVisibility="WhileEditing"
                          MaskType="Simple"
                          Mask="00/00/0000"
                          PromptChar="#" />
                          
{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.PromptChar = '#';

{% endhighlight %}
{% endtabs %}

![.NET MAUI Masked Entry prompt character.](maskedentry_images/net-maui-masked-entry-prompt-char.png)

## Setting the Value

The [Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Value) property sets the input value for the MaskedEntry control.

{% tabs %}
{% highlight XAML %}

<editors:SfMaskedEntry WidthRequest="200"
                          ClearButtonVisibility="WhileEditing"
                          MaskType="Simple"
                          Mask="00/00/0000"
                          Value="12/02/2022" />

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.Value = "12/02/2022";

{% endhighlight %}
{% endtabs %}

![.NET MAUI Masked Entry value.](maskedentry_images/net-maui-masked-entry-value.png)

N> 
Get the complete getting started sample from the [GitHub](https://github.com/SyncfusionExamples/maui-maskedentry-samples) link.

N> You can refer to our [.NET MAUI Masked Entry](https://www.syncfusion.com/maui-controls/maui-masked-entry) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Masked Entry Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/MaskedEntry) that shows you how to render the Masked Entry in .NET MAUI.


