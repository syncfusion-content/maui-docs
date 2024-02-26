---
layout: post
title: Getting Started with .NET MAUI Chat Control | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI Chat (SfChat) control, its elements and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Getting Started with .NET MAUI Chat (SfChat)

This section provides a quick overview for getting started with the Chat with the .NET Maui Chat (SfChat) for Maui. Walk through the entire process of creating real world of this control.

## Creating an application using the .NET MAUI Chat

 1. Create a new .NET MAUI application in Visual Studio.
 2. The Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfChat to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Chat` and then install it.
 3. Import the control namespace `Syncfusion.Maui.Chat` in XAML or C# code.
 4. Initialize the [SfChat]() control.

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
              fonts.AddFont("OpenSans-Regular.ttf", 
                                    "OpenSansRegular");
            });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
         }
       }
    }
{% endhighlight %} 
{% endtabs %}

## Creating View model for the Chat
The SfChat functions as a data-bound control that presents a collection of messages exchanged between users. Therefore, messages must be generated and bound to the control.
Create a simple message collection as shown in the following code example in a new class file. Save it as `GettingStartedViewModel.cs` file

{% highlight c# %}

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
          this.currentUser = new Author() { Name = "Nancy", Avatar = "Nancy.png" };
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

  ## Binding Messages to Chat 

  
To bind the messages to SfChat, configure the SfChat.Messages property accordingly. You have the option to bind the message collection of the SfChat either through XAML or programmatically in code.

{% tabs %} {% highlight xaml %}

    <ContentPage.BindingContext>
      <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
                <sfChat:SfChat x:Name="sfChat"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}"
                       ShowOutgoingMessageAvatar="True" />
    <ContentPage.Content>	

{% endhighlight %} {% highlight c# %} 

    namespace GettingStarted
    { 
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
              this.sfChat.ShowOutgoingMessageAvatar = true; 
              this.Content = sfChat; 
           } 
       } 
    }

{% endhighlight %} {% endtabs %}

Download the entire source code from GitHub [here]().

![.NET MAUI Chat getting started](Images/getting-started/maui-chat-getting-started.png)

## Showing time break between messages


To display time breaks between messages, you can segregate messages based on the specified date within each message. This can be accomplished by enabling the `SfChat.ShowTimeBreak` property, which can be configured both in XAML and programmatically. Below is an example code snippet illustrating this.

{% tabs %}
{% highlight xaml %}

    <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>
    
       <ContentPage.Content>
         <sfChat:SfChat x:Name="sfChat"
                       Messages="{Binding Messages}"
                       ShowTimeBreak="True"
                       ShowIncomingMessageTimestamp="True"
                       ShowOutgoingMessageTimestamp="True"
                       IncomingMessageTimestampFormat="hh:mm tt"
                       OutgoingMessageTimestampFormat="hh:mm tt"
                       CurrentUser="{Binding CurrentUser}" />
        </ContentPage.Content>

</ContentPage>
{% endhighlight %}

{% highlight c# %}


    namespace GettingStarted
    {
      public partial class MainPage : ContentPage
      {
         SfChat sfChat;
         GettingStartedViewModel viewModel;
         public MainPage()
         {
             InitializeComponent();
             sfChat = new SfChat();
             viewModel = new GettingStartedViewModel();
             this.sfChat.Messages = viewModel.Messages;
             this.sfChat.IncomingMessageTimestampFormat = "hh:mm tt";
             this.sfChat.OutgoingMessageTimestampFormat = "hh:mm tt";
             this.sfChat.ShowIncomingMessageTimestamp = true;
             this.sfChat.ShowOutgoingMessageTimestamp = true;
             this.sfChat.ShowTimeBreak = true;
             this.sfChat.CurrentUser = viewModel.CurrentUser;
             this.Content = sfChat;
         }
      }
    }

{% endhighlight %}
{% endtabs %}

![.NET MAUI Chat time break](Images/getting-started/maui-chat-timebreak.png)

Download the entire source code from GitHub [here]().