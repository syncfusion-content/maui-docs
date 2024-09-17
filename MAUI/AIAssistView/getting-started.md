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

## Prerequisites

Before proceeding, ensure the following are in place:

 1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
 2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

 ## Step 1: Create a .NET MAUI project

**Visual Studio**

 1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
 2. Name the project and choose a location, then click **Next**.
 3. Select the .NET framework version and click **Create**.

** Visual Code**

 1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
 2. Choose the **.NET MAUI App** template.
 3. Select the project location, type the project name and press enter.
 4. Then choose **Create project**

## Step 2: Install the Syncfusion MAUI AI AssistView NuGet Package

 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for `Syncfusion.Maui.AIAssistView` on [nuget.org](https://www.nuget.org/) and install the latest version.
 3. Ensure all dependencies are correctly installed, and restore your project.

## Step 3: Add a Basic AI AssistView

 1. To initialize the control, import the `Syncfusion.Maui.AIAssistView` namespace into your code.
 2. Initialize `SfAIAssistView`.

{% tabs %}
{% highlight xaml hl_lines="4" %}

    <ContentPage> 
      . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AssistView">
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

## Step 4: Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all the Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

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

## Step 5: Define the View Model

The `SfAIAssistView` control is data-bound and displays a collection of items exchanged between users and AI services. Hence, assist items should be created and bound to the control.

Create a simple assist items collection as shown in the following code example in a new class file. Save it as `ViewModel.cs` file.

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

N> The `SfAIAssistView.AssistItems` property is of type `IList<IAssistItem>`. To ensure the `AssistItems` property functions correctly, it is recommended to use a collection property in the ViewModel with the same type, such as `ObservableCollection<IAssistItem>`.

## Binding AssistItems to AI AssistView

To bind the assist items to `SfAIAssistView`, configure the `AssistItems` property accordingly. You have the option to bind the assistItems collection of the `SfAIAssistView` either through XAML or programmatically in code.

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
</Content>

{% endhighlight %} 

{% highlight c# hl_lines="10" %} 
 public partial class MainPage : ContentPage 
 {
    SfAIAssistView sfAIAssistView; 
    GettingStartedViewModel viewModel; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.viewModel = new GettingStartedViewModel(); 
        this.sfAIAssistView.AssistItems = viewModel.AssistItems; 
        this.Content = sfAIAssistView; 
     } 
  } 
    
{% endhighlight %} 
{% endtabs %}

## Step 6: Running the Application

Press **F5** to build and run the application. Once compiled, the AI AssistView will be displayed with the data provided.

Here is the result of the previous codes,

![AI AssistView control in .NET MAUI platform](images/maui-aiassistview-getting-started.png)