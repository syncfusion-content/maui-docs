---
layout: post
title: Getting Started with .NET MAUI Autocomplete | Syncfusion®
description: Learn how to get started with Syncfusion® .NET MAUI Autocomplete control and its suggestion list, as well as other topics in this section.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Getting Started with .NET MAUI Autocomplete (SfAutocomplete)

This section guides you through setting up and configuring a [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) in your .NET MAUI application. Follow the steps below to add a basic Autocomplete to your project.

To quickly get started with the .NET MAUI Autocomplete, watch this video.

{% youtube "https://www.youtube.com/watch?v=ontSh2NZvE4" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later, with the **.NET Multi-platform App UI development** workload installed.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET target framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the dependencies are installed and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code. Install the **C# Dev Kit** and **.NET MAUI** extensions.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code. On macOS, use <kbd>Cmd</kbd> + <kbd>`</kbd>.
2. Ensure you are in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Inputs` to install the Syncfusion<sup>®</sup> .NET MAUI Inputs package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select **.NET (C#)** and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET target framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs/) and install the latest version.
3. Ensure the dependencies are installed and the project is restored. If not, open the Terminal in Rider and manually run `dotnet restore`.

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register the Syncfusion core handler

Add the following `using` directive at the top of the `MauiProgram.cs` file. The `Syncfusion.Maui.Core` package is added transitively by `Syncfusion.Maui.Inputs`.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}

Call the [ConfigureSyncfusionCore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Hosting.AppHostBuilderExtensions.html#Syncfusion_Maui_Core_Hosting_AppHostBuilderExtensions_ConfigureSyncfusionCore_Microsoft_Maui_Hosting_MauiAppBuilder_) extension method in the `CreateMauiApp` method of the `MauiProgram.cs` file. The call must be made before `UseMauiApp<TApp>()`.

{% tabs %}
{% highlight c# %}
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore();
        // ...
        return builder.Build();
    }
}
{% endhighlight %}
{% endtabs %}

N> This call is required for all Syncfusion .NET MAUI controls. Skipping it can cause the SfAutocomplete to fail to render.

## Step 4: Define the model and view model

Create a simple model class called `SocialMedia` with fields `ID` and `Name`, and then populate the social media data in the `SocialMediaViewModel`.

{% tabs %}
{% highlight c# %}

//Model.cs
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

//ViewModel.cs
using System.Collections.ObjectModel;

public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
    }
}

{% endhighlight %}
{% endtabs %}

## Step 5: Import the Autocomplete namespace

Add the following namespace to your XAML or C# file.

{% tabs %}
{% highlight xaml %}
xmlns:inputs="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
{% endhighlight %}
{% highlight csharp %}
using Syncfusion.Maui.Inputs;
{% endhighlight %}
{% endtabs %}

## Step 6: Set the page's BindingContext

To bind the `SocialMedias` collection to the SfAutocomplete, set the `BindingContext` of the page to an instance of `SocialMediaViewModel`. This can be done in XAML or in the page's code-behind.

**XAML**

{% tabs %}
{% highlight xaml %}
xmlns:local="clr-namespace:YourAppNamespace"

<ContentPage.BindingContext>
    <local:SocialMediaViewModel />
</ContentPage.BindingContext>
{% endhighlight %}
{% highlight csharp %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new SocialMediaViewModel();
    }
}
{% endhighlight %}
{% endtabs %}

Replace `YourAppNamespace` with the namespace where the `SocialMedia` and `SocialMediaViewModel` classes are defined.

## Step 7: Add the SfAutocomplete component

Create an instance of the SfAutocomplete control and populate it with the `SocialMediaViewModel` data by binding to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource) property.

The SfAutocomplete control is populated with a list of social media options. Since the `SocialMedia` model includes two properties, `Name` and `ID`, you must specify which property should be used as the display value in both the selection area and the drop-down suggestion list.

**TextMemberPath**: This property path is used to retrieve the value that is displayed in the selection area of the SfAutocomplete when an item is selected. The default value is `string.Empty`.

**DisplayMemberPath**: This property path is used to specify the name or path of the property that is displayed for each data item in the drop-down list. The default value is `string.Empty`.

{% tabs %}
{% highlight xaml %}
<inputs:SfAutocomplete x:Name="autocomplete"
                       WidthRequest="250"
                       HeightRequest="40"
                       DisplayMemberPath="Name"
                       TextMemberPath="Name"
                       ItemsSource="{Binding SocialMedias}" />
{% endhighlight %}
{% highlight csharp %}
using Syncfusion.Maui.Inputs;

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
SfAutocomplete autocomplete = new SfAutocomplete
{
    WidthRequest = 250d,
    HeightRequest = 40d,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias,
};
{% endhighlight %}
{% endtabs %}

The following image illustrates the output:

![.NET MAUI Autocomplete populated with social media suggestions](Images/GettingStarted/SingleSelection.gif)

## Step 8: Run the application

Select a target framework (for example, `net9.0-windows10.0.19041.0`, `net9.0-android`, or `net9.0-maccatalyst`) and start debugging by pressing **F5** (Visual Studio / Rider) or running `dotnet build -t:Run -f net9.0-android` from the integrated terminal.

You can download the Autocomplete Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-autocomplete-control).

## Notes

N> **BindingContext**: Set the `BindingContext` of your page to an instance of `SocialMediaViewModel`. This allows you to bind the properties of `SocialMediaViewModel` to the SfAutocomplete control.

N> **iOS AOT**: When publishing in AOT mode on iOS, ensure `[Preserve(AllMembers = true)]` is added to the model class to maintain `DisplayMemberPath` binding. The attribute requires `using Foundation;`.

{% highlight c# %}
using Foundation;

[Preserve(AllMembers = true)]
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}
{% endhighlight %}

N> You can refer to our [.NET MAUI Autocomplete](https://www.syncfusion.com/maui-controls/maui-autocomplete) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Autocomplete Example](https://github.com/SyncfusionExamples/maui-autocomplete-samples) that shows you how to render the Autocomplete in .NET MAUI.

## See also

- [Selection](Selection.md)
- [UI Customization](UI-Customization.md)
- [Searching and Filtering](Searching-Filtering.md)
- [Basic Features](Basic-Features.md)