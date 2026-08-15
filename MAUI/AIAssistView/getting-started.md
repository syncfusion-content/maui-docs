---
layout: post
title: Getting Started with .NET MAUI AI AssistView Control | Syncfusion®
description: Learn here about getting started with the Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Getting Started with .NET MAUI AI AssistView

This section guides you through setting up and configuring AI AssistView (SfAIAssistView) in your .NET MAUI application. Follow the steps below to add a basic AI AssistView to your project.

To quickly get started with the .NET MAUI AI AssistView, watch this video:

{% youtube "https://www.youtube.com/watch?v=l_mW3Py0N3M" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**
 
## Step 2: Install the Syncfusion<sup>®</sup> MAUI AI AssistView NuGet package
 
 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.AIAssistView](https://www.nuget.org/packages/Syncfusion.Maui.AIAssistView) and install the latest version.
 3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI AI AssistView NuGet package
 
1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.AIAssistView` to install the Syncfusion<sup>®</sup> .NET MAUI AIAssistView package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**. Select **.NET (C#)** and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI AI AssistView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.AIAssistView](https://www.nuget.org/packages/Syncfusion.Maui.AIAssistView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

### Add the required namespace

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
### Register the Syncfusion handler

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Define the view model

Next, create a view model class and initialize the collection of [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) instances as follows.

{% tabs %}
{% highlight c# %}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Syncfusion.Maui.AIAssistView;

public class GettingStartedViewModel : INotifyPropertyChanged
{
    private ObservableCollection<IAssistItem> assistItems;

    public GettingStartedViewModel()
    {
        this.assistItems = new ObservableCollection<IAssistItem>();
        this.GenerateAssistItems();
    }

    public ObservableCollection<IAssistItem> AssistItems
    {
        get{return this.assistItems;}
        set
        {
            if (assistItems != value)
            {
                assistItems = value;
                RaisePropertyChanged(nameof(AssistItems));
            }
        }
    }

    private async void GenerateAssistItems()
    {
        AssistItem requestItem = new AssistItem()
        {
            Text = "listening",
            IsRequested = true
        };

        this.AssistItems.Add(requestItem);
        await GetResult(requestItem);
    }

    private async Task GetResult(AssistItem requestItem)
    {
        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
            Text = "Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
            IsRequested = false,
        };
        this.AssistItems.Add(responseItem);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void RaisePropertyChanged(string propName)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
{% endhighlight %}
{% endtabs %}

N> The `SfAIAssistView.AssistItems` property is of type `IList<IAssistItem>`. To ensure the [AssistItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems) property functions correctly, it is recommended to use a collection property in the ViewModel with the same type, such as `ObservableCollection<IAssistItem>`.

## Step 5: Import the AI AssistView namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.AIAssistView;
{% endhighlight %}
{% endtabs %}

## Step 6: Add the AI AssistView component

Set the `ViewModel` as the BindingContext for the AI AssistView or the parent ContentPage. This allows data binding between the UI and the ViewModel properties.
Create an instance of the `SfAIAssistView` control. To populate AI AssistView, bind the assist items in ViewModel to [AssistItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems) property of AI AssistView.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage.BindingContext>
    <local:GettingStartedViewModel />
</ContentPage.BindingContext>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}" />

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    private SfAIAssistView aiAssistView;

    public MainPage()
    {
        InitializeComponent();
        this.aiAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.aiAssistView.AssistItems = viewModel.AssistItems;
        this.Content = this.aiAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

![Syncfusion .NET MAUI AI AssistView control](images/maui-aiassistview-getting-started.png)

You can download the AI AssistView Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-aiassistview)
