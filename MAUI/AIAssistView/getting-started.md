---
layout: post
title: Getting Started with .NET MAUI AIAssistView Control | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI AIAssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Getting Started with .NET MAUI AIAssistView (SfAIAssistView)

This section provides a quick overview for getting started with the .NET MAUI SfAIAssistView (SfAIAssistView). Walk-through the entire process of creating real world of this control.

## Creating an application using the .NET MAUI SfAIAssistView

 1. Create a new .NET MAUI application in Visual Studio.
 2. The Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfAIAssistView to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.AIAssistView]() and then install it.
 3. Import the control namespace `Syncfusion.Maui.AIAssistView` in XAML or C# code.
 4. Initialize the `SfAIAssistView` control.

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
          SfAIAssistView aiAssistView = new SfAIAssistView();
          this.Content = aiAssistView;
        }
    }

{% endhighlight %}
{% endtabs %}

## Register the handler

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

## Creating ViewModel for the SfAIAssistView

The `SfAIAssistView` control is data-bound and displays a collection of items exchanged between users and AI services. Hence, assist items should be created and bound to the control.

Create a simple assist items collection as shown in the following code example in a new class file. Save it as `ViewModel.cs` file.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

  using Syncfusion.Maui.AIAssistView;
  public class GettingStartedViewModel : INotifyPropertyChanged
  {
      /// <summary>
      /// Collection of assistItems in a conversation.
      /// </summary>
      private ObservableCollection<object> assistItems;


      public GettingStartedViewModel()
      {
          this.assistItems = new ObservableCollection<object>();
          this.GenerateAssistItems();
      }

      /// <summary>
      /// Gets or sets the collection of AssistItems of a conversation.
      /// </summary>
      public ObservableCollection<object> AssistItems
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

      private void GenerateAssistItems()
      {
          this.Messages.Add(new AssistItem()
          {
             Text = "Hey AI, can you tell me what MAUI is?",
             IsRequested = true,
          });
         this.Messages.Add(new AssistItem()
          {
              Text = "Sure! MAUI stands for .NET Multi-platform App UI. It’s a framework that allows you to create cross-platform applications using a single codebase.This powerful framework is an evolution of Xamarin.Forms and is designed to streamline the development process by allowing you to write code once and deploy it across multiple platforms.",
          });
      }
   }

{% endhighlight %}
{% endtabs %}

## Binding AssistItems to SfAIAssistView

To bind the assistItems to SfAIAssistView, configure the [AssistItems]() property accordingly. You have the option to bind the assistItems collection of the SfAIAssistView either through XAML or programmatically in code.

{% tabs %} 
{% highlight xaml hl_lines="14" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfAIAssistView="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
      <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
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

![AIAssistView control in .NET MAUI platform](Images/maui-aiassistview-getting-started.png)


N> [View Sample in GitHub]()
