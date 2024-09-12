---
layout: post
title: Getting Started with .NET MAUI AI Assist View Control | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Getting Started with .NET MAUI AI Assist View (SfAIAssistView)

This section provides a quick overview for getting started with the .NET MAUI AI Assist View (SfAIAssistView). Walk-through the entire process of creating real world of this control.

## Creating an application using the .NET MAUI AI Assist View

 1. Create a new .NET MAUI application in Visual Studio.
 2. The Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfAIAssistView` to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.AIAssistView` and then install it.
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
          SfAIAssistView sfAIAssistView = new SfAIAssistView();
          this.Content = sfAIAssistView;
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

## Creating ViewModel for the AI Assist View

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

N> The data type of `AssistItem` is IList<IAssistItem>. Use `IAssistItem` in the collection for binding, instead of a generic `object` type.

## Request and Response items

The `IsRequested` property is used to determine whether a item is a Request or a Response. If `IsRequested` property is set to true, the item is a Request item.

`Request Items`: These are the items sent by the user. They typically appear aligned to the right side of the window to visually differentiate them as user inputs.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="4" %}

  AssistItem requestItem = new AssistItem()
  {
      Text = "listening", 
      IsRequested = true
  };

{% endhighlight %}
{% endtabs %}

`Response Items`: These are messages generated by the AI in reply to a request. They are usually aligned to the left side of the window to indicate that they are responses.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="4" %}

  AssistItem responseItem = new AssistItem()
  {
      Text ="Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
      IsRequested = false, 
  };

{% endhighlight %}
{% endtabs %}


## Binding AssistItems to AI Assist View

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

![AI Assist View control in .NET MAUI platform](images/maui-aiassistview-getting-started.png)