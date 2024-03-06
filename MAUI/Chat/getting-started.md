---
layout: post
title: Getting Started with .NET MAUI Chat Control | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI Chat (SfChat) control, its elements and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Getting Started with .NET MAUI Chat (SfChat)

This section provides a quick overview for getting started with the .NET MAUI Chat (SfChat). Walk-through the entire process of creating real world of this control.

## Creating an application using the .NET MAUI Chat

 1. Create a new .NET MAUI application in Visual Studio.
 2. The Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfChat to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Chat` and then install it.
 3. Import the control namespace `Syncfusion.Maui.Chat` in XAML or C# code.
 4. Initialize the `SfChat` control.

{% tabs %}
{% highlight xaml hl_lines="5" %}

    <ContentPage   
      . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat">

      <syncfusion:SfChat />
    </ContentPage>

{% endhighlight %}

{% highlight c# hl_lines="9" %}
    using Syncfusion.Maui.Chat;
    . . .

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          InitializeComponent();
          SfChat chat = new SfChat();
          this.Content = chat;
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

## Creating ViewModel for the Chat

The `SfChat` control is data-bound and displays a collection of messages exchanged between users. Hence, messages should be created and binded to the control.

Create a simple message collection as shown in the following code example in a new class file. Save it as `GettingStartedViewModel.cs` file.

{% tabs %}
{% highlight c# tabtitle="GettingStartedViewModel.cs" %}

  using Syncfusion.Maui.Chat;
  public class GettingStartedViewModel : INotifyPropertyChanged
  {
      /// <summary>
      /// Collection of messages in a conversation.
      /// </summary>
      private ObservableCollection<object> messages;

      /// <summary>
      /// Current user of chat.
      /// </summary>
      private Author currentUser;

      public GettingStartedViewModel()
      {
          this.messages = new ObservableCollection<object>();
          this.currentUser = new Author() { Name = "Nancy" };
          this.GenerateMessages();
      }

      /// <summary>
      /// Gets or sets the collection of messages of a conversation.
      /// </summary>
      public ObservableCollection<object> Messages
      {
          get
          {
              return this.messages;
          }

          set
          {
              this.messages = value;
          }
      }

      /// <summary>
      /// Gets or sets the current user of the message.
      /// </summary>
      public Author CurrentUser
      {
          get
          {
              return this.currentUser;
          }
          set
          {
              this.currentUser = value;
              RaisePropertyChanged("CurrentUser");
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

      private void GenerateMessages()
      {
          this.messages.Add(new TextMessage()
          {
              Author = currentUser,
              Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
          });

          this.messages.Add(new TextMessage()
          {
              Author = new Author() { Name = "Andrea", Avatar = "Andrea.png" },
              Text = "Oh! That's great.",
          });

          this.messages.Add(new TextMessage()
          {
              Author = new Author() { Name = "Harrison", Avatar = "Harrison.png" },
              Text = "That is good news.",
          });

          this.messages.Add(new TextMessage()
          {
              Author = new Author() { Name = "Margaret", Avatar = "Margaret.png" },
              Text = "Are we going to develop the app natively or hybrid?",
          });

          this.messages.Add(new TextMessage()
          {
              Author = currentUser,
              Text = "We should develop this app in .NET MAUI, since it provides native experience and performance.\",",
          });
      }
  }

  {% endhighlight %}
  {% endtabs %}

## Binding Messages to Chat 

To bind the messages to SfChat, configure the `SfChat.Messages` property accordingly. You have the option to bind the message collection of the SfChat either through XAML or programmatically in code.

{% tabs %} {% highlight xaml hl_lines="14"%}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
      <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <sfChat:SfChat x:Name="sfChat"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}"/>
    </ContentPage.Content>	
</Content>

{% endhighlight %} 

{% highlight c# hl_lines="10" %} 

 public partial class MainPage : ContentPage 
 {
    SfChat sfChat; 
    GettingStartedViewModel viewModel; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfChat = new SfChat();
        this.viewModel = new GettingStartedViewModel(); 
        this.sfChat.Messages = viewModel.Messages; 
        this.sfChat.CurrentUser = viewModel.CurrentUser; 
        this.Content = sfChat; 
     } 
  } 
    
{% endhighlight %} {% endtabs %}

![.NET MAUI Chat getting started](images/getting-started/maui-chat-getting-started.png)

## Showing time break between messages

Messages can be separated based on their date and time of creation and this can be done by setting the `ShowTimeBreak` property to `true`.

{% tabs %}
{% highlight xaml hl_lines="2" %}
 <sfChat:SfChat x:Name="sfChat"
                ShowTimeBreak="True" />

{% endhighlight %}

{% highlight c# hl_lines="1"%}

 this.sfChat.ShowTimeBreak = true;
         
{% endhighlight %}
{% endtabs %}

![.NET MAUI Chat time break](images/getting-started/maui-chat-timebreak.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-chat)
