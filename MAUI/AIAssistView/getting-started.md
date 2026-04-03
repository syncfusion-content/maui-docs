---
layout: post
title: Getting Started with .NET MAUI AI AssistView Control | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Getting Started with .NET MAUI AI AssistView

This section guides you through setting up and configuring AI AssistView (SfAIAssistView) in your .NET MAUI application. Follow the steps below to add a basic AI AssistView to your project.

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

 1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
 2. Set up a .NET MAUI environment with Visual Studio 2026 (v18.0.0 or later).

## Step 1: Create a .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**
 
## Step 2: Install the Syncfusion<sup>®</sup> MAUI AI AssistView NuGet package
 
 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.AIAssistView](https://www.nuget.org/packages/Syncfusion.Maui.AIAssistView) and install the latest version.
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

## Step 4: Add a basic AI AssistView

 1. To initialize the control, import the `Syncfusion.Maui.AIAssistView` namespace into your code.
 2. Initialize [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html).

{% tabs %}
{% highlight xaml hl_lines="4" %}

    <ContentPage> 
      . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">
      <syncfusion:SfAIAssistView />
    </ContentPage>

{% endhighlight %}

{% highlight c# hl_lines="9" %}
    using Syncfusion.Maui.AIAssistView;
    . . .

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          InitializeComponent();
          SfAIAssistView sfAIAssistView = new SfAIAssistView();
          this.Content = sfAIAssistView;
        }
    }

{% endhighlight %}
{% endtabs %}

## Step 5: Define the view model

Next, create a view model class and initialize the collection of [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) instance as follows

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

  using Syncfusion.Maui.AIAssistView;
  public class GettingStartedViewModel : INotifyPropertyChanged
  {
      /// <summary>
      /// Collection of assistItem in a conversation.
      /// </summary>
      private ObservableCollection<IAssistItem> assistItems;


      public GettingStartedViewModel()
      {
          this.assistItems = new ObservableCollection<IAssistItem>();
          this.GenerateAssistItems();
      }

      /// <summary>
      /// Gets or sets the collection of AssistItem of a conversation.
      /// </summary>
      public ObservableCollection<IAssistItem> AssistItems
      {
          get
          {
              return this.assistItems;
          }

          set
          {
              this.assistItems = value;
          }
      }

      private async void GenerateAssistItems()
      {
        // Adding a request item
        AssistItem requestItem = new AssistItem()
        {
            Text = "listening", 
            IsRequested = true
        };
 
        // Add the request item to the collection
        this.AssistItems.Add(requestItem);
 
        // Generating response item
        await GetResult(requestItem);
      }
 
     private async Task GetResult(AssistItem requestItem)
     {
        await Task.Delay(1000).ConfigureAwait(true);
 
        AssistItem responseItem = new AssistItem()
        {
            Text ="Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
            IsRequested = false, 
        };
 
        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
     }

      /// <summary>
      /// Property changed handler.
      /// </summary>
      public event PropertyChangedEventHandler PropertyChanged;

      /// <summary>
      /// Occurs when property is changed.
      /// </summary>
      /// <param name="propName">changed property name</param>
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

### Bind AssistItems

Set the `ViewModel` as the BindingContext for the AI AssistView or the parent ContentPage. This allows data binding between the UI and the ViewModel properties.
To populate AI AssistView, bind the assist items in ViewModel to [AssistItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems) property of AI AssistView.

{% tabs %} 
{% highlight xaml hl_lines="14" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
      <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                   AssistItems="{Binding AssistItems}"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
 public partial class MainPage : ContentPage 
 {
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView aiAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.aiAssistView.AssistItems = viewModel.AssistItems;
        this.Content = aiAssistView;
    }
  }
{% endhighlight %}
{% endtabs %}

## Step 6: Running the application

Press **F5** to build and run the application. Once compiled, the AI AssistView will be displayed with the data provided.

Here is the result of the previous codes,

![AI AssistView control in .NET MAUI platform](images/maui-aiassistview-getting-started.png)

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites
Before proceeding, ensure the following are in place:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI AI AssistView NuGet package
 
 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.AIAssistView](https://www.nuget.org/packages/Syncfusion.Maui.AIAssistView) and install the latest version.
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

## Step 4: Add a basic AI AssistView

 1. To initialize the control, import the `Syncfusion.Maui.AIAssistView` namespace into your code.
 2. Initialize [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html).

{% tabs %}
{% highlight xaml hl_lines="4" %}

    <ContentPage> 
      . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">
      <syncfusion:SfAIAssistView />
    </ContentPage>

{% endhighlight %}

{% highlight c# hl_lines="9" %}
    using Syncfusion.Maui.AIAssistView;
    . . .

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          InitializeComponent();
          SfAIAssistView sfAIAssistView = new SfAIAssistView();
          this.Content = sfAIAssistView;
        }
    }

{% endhighlight %}
{% endtabs %}

## Step 5: Define the view model

Next, create a view model class and initialize the collection of [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) instance as follows

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

  using Syncfusion.Maui.AIAssistView;
  public class GettingStartedViewModel : INotifyPropertyChanged
  {
      /// <summary>
      /// Collection of assistItem in a conversation.
      /// </summary>
      private ObservableCollection<IAssistItem> assistItems;


      public GettingStartedViewModel()
      {
          this.assistItems = new ObservableCollection<IAssistItem>();
          this.GenerateAssistItems();
      }

      /// <summary>
      /// Gets or sets the collection of AssistItem of a conversation.
      /// </summary>
      public ObservableCollection<IAssistItem> AssistItems
      {
          get
          {
              return this.assistItems;
          }

          set
          {
              this.assistItems = value;
          }
      }

      private async void GenerateAssistItems()
      {
        // Adding a request item
        AssistItem requestItem = new AssistItem()
        {
            Text = "listening", 
            IsRequested = true
        };
 
        // Add the request item to the collection
        this.AssistItems.Add(requestItem);
 
        // Generating response item
        await GetResult(requestItem);
      }
 
     private async Task GetResult(AssistItem requestItem)
     {
        await Task.Delay(1000).ConfigureAwait(true);
 
        AssistItem responseItem = new AssistItem()
        {
            Text ="Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
            IsRequested = false, 
        };
 
        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
     }

      /// <summary>
      /// Property changed handler.
      /// </summary>
      public event PropertyChangedEventHandler PropertyChanged;

      /// <summary>
      /// Occurs when property is changed.
      /// </summary>
      /// <param name="propName">changed property name</param>
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

### Bind AssistItems

Set the `ViewModel` as the BindingContext for the AI AssistView or the parent ContentPage. This allows data binding between the UI and the ViewModel properties.
To populate AI AssistView, bind the assist items in ViewModel to [AssistItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems) property of AI AssistView.

{% tabs %} 
{% highlight xaml hl_lines="14" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
      <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                   AssistItems="{Binding AssistItems}"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
 public partial class MainPage : ContentPage 
 {
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView aiAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.aiAssistView.AssistItems = viewModel.AssistItems;
        this.Content = aiAssistView;
    }
  }
{% endhighlight %}
{% endtabs %}

## Step 6: Running the application

Press **F5** to build and run the application. Once compiled, the AI AssistView will be displayed with the data provided.

Here is the result of the previous codes,

![AI AssistView control in .NET MAUI platform](images/maui-aiassistview-getting-started.png)

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI AI AssistView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.AIAssistView](https://www.nuget.org/packages/Syncfusion.Maui.AIAssistView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

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

## Step 4: Add a basic AI AssistView

 1. To initialize the control, import the `Syncfusion.Maui.AIAssistView` namespace into your code.
 2. Initialize [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html).

{% tabs %}
{% highlight xaml hl_lines="4" %}

    <ContentPage> 
      . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">
      <syncfusion:SfAIAssistView />
    </ContentPage>

{% endhighlight %}

{% highlight c# hl_lines="9" %}
    using Syncfusion.Maui.AIAssistView;
    . . .

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          InitializeComponent();
          SfAIAssistView sfAIAssistView = new SfAIAssistView();
          this.Content = sfAIAssistView;
        }
    }

{% endhighlight %}
{% endtabs %}
{% endtabcontent %}
{% endtabcontents %}

## Request and response item
 
The [IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested) property is used to determine whether a item is a Request or a Response. If `IsRequested` property is set to `true`, the item is a Request item.
 
### Request item

These are the items sent by the user. They typically appear aligned to the right side of the window to visually differentiate them as user inputs.
 
{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="4" %}
 
  AssistItem requestItem = new AssistItem()
  {
      Text = "listening",
      IsRequested = true
  };
 
{% endhighlight %}
{% endtabs %}
 
### Response item

These are messages generated by the AI in reply to a request. They are usually aligned to the left side of the window to indicate that they are responses.
 
{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="4" %}
 
  AssistItem responseItem = new AssistItem()
  {
      Text ="Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
      IsRequested = false,
  };
 
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-aiassistview)