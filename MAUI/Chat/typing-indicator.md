---
layout: post
title: Typing indicator in .NET MAUI Chat control | Syncfusion®
description: Learn here all about Typing indicator support in Syncfusion® .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Typing Indicator in .NET MAUI Chat (SfChat)

In `SfChat`, typing indicator indicates with an animation that a user (or users) is currently typing, thereby providing an enhanced user experience. To show or hide the typing indicator, set the [ShowTypingIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTypingIndicator) property to `true` or `false`, respectively. To show the user image and text in the typing indicator, create a new instance of [ChatTypingIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicator), set the [TypingIndicator.Authors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatTypingIndicator.html#Syncfusion_Maui_Chat_ChatTypingIndicator_Authors) and [TypingIndicator.Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatTypingIndicator.html#Syncfusion_Maui_Chat_ChatTypingIndicator_Text) properties, and assign the typing indicator instance to the `TypingIndicator` property.

## Prerequisites

Before using the typing indicator, install the [Syncfusion.Maui.Chat](https://www.nuget.org/packages/Syncfusion.Maui.Chat) NuGet package in your .NET MAUI project.

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

dotnet add package Syncfusion.Maui.Chat

{% endhighlight %}
{% highlight c# tabtitle="Package Manager" %}

Install-Package Syncfusion.Maui.Chat

{% endhighlight %}
{% endtabs %}

N> For a complete step-by-step setup of `SfChat` in a .NET MAUI application, refer to the [Getting Started documentation](https://help.syncfusion.com/maui/chat/getting-started).

{% tabs %}
{% highlight xaml hl_lines="15 16" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
             xmlns:local="clr-namespace:TypingIndicator"
             x:Class="TypingIndicator.MainPage">
    
    <ContentPage.BindingContext>
        <local:TypingIndicatorViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <sfChat:SfChat x:Name="sfChat"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}"
                       TypingIndicator="{Binding TypingIndicator}"
                       ShowTypingIndicator="{Binding ShowTypingIndicator}"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# hl_lines="16 17" %}
using Syncfusion.Maui.Chat;

namespace TypingIndicator
{
    public partial class MainPage : ContentPage
    {
        SfChat sfChat;
        TypingIndicatorViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            sfChat = new SfChat();
            viewModel = new TypingIndicatorViewModel();
            this.sfChat.Messages = viewModel.Messages;
            this.sfChat.CurrentUser = viewModel.CurrentUser;
            this.sfChat.TypingIndicator = viewModel.TypingIndicator;
            this.sfChat.ShowTypingIndicator = viewModel.ShowTypingIndicator;
            this.Content = sfChat;
         }
     }
 }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.Maui.Chat;

namespace TypingIndicator
{
    public class TypingIndicatorViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Collection of chat messages.
        /// </summary>
        private ObservableCollection<object> messages;

        /// <summary>
        /// Current user of the chat.
        /// </summary>
        private Author currentUser;

        /// <summary>
        /// Indicates the typing indicator visibility.
        /// </summary>
        private bool showTypingIndicator;

        /// <summary>
        /// Chat typing indicator.
        /// </summary>
        private ChatTypingIndicator typingIndicator;

        public TypingIndicatorViewModel()
        {
            this.Messages = new ObservableCollection<object>();
            this.TypingIndicator = new ChatTypingIndicator();
            this.TypingIndicator.Authors.Add(new Author() { Name = "Harrison" });
            this.TypingIndicator.AvatarViewType = AvatarViewType.Image;
            this.TypingIndicator.Text = "Harrison is typing...";
            this.ShowTypingIndicator = true;
            this.CurrentUser = new Author() { Name = "Nancy" };
            this.GenerateMessages();
        }

        /// <summary>
        /// Gets or sets the collection of chat messages.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }
            private set
            {
                this.messages = value;
                RaisePropertyChanged(nameof(Messages));
            }
        }

        /// <summary>
        /// Gets or sets the current user of the chat.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            private set
            {
                this.currentUser = value;
                RaisePropertyChanged(nameof(CurrentUser));
            }
        }

        /// <summary>
        /// Gets or sets the Chat typing indicator value.
        /// </summary>
        public ChatTypingIndicator TypingIndicator
        {
            get
            {
                return this.typingIndicator;
            }
            private set
            {
                this.typingIndicator = value;
                RaisePropertyChanged(nameof(TypingIndicator));
            }
        }

        /// <summary>
        /// Gets or sets the value indicating whether the typing indicator is visible or not.
        /// </summary>
        public bool ShowTypingIndicator
        {
            get
            {
                return this.showTypingIndicator;
            }
            set
            {
                this.showTypingIndicator = value;
                RaisePropertyChanged(nameof(ShowTypingIndicator));
            }
        }

        /// <summary>
        /// Generates a few sample text messages between the current user and the author.
        /// </summary>
        private void GenerateMessages()
        {
            this.Messages.Add(new TextMessage()
            {
                Author = this.CurrentUser,
                Text = "Hi Harrison, are you available?"
            });

            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Harrison" },
                Text = "Yes, I'm here."
            });
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">Name of the property that changed.</param>
        private void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI Chat Typing indicator with image](images/typing-indicator/maui-chat-typing-indicator.png)

N> The `SfChat` allows you to customize the height of the typing indicator by using the [TypingIndicatorViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicatorViewHeight) property.

## Customize avatar view of typing indicator

The avatar view in the typing indicator can be customized to show only the first letter of the username or only the user's image as the avatar by using the [TypingIndicator.AvatarViewType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatTypingIndicator.html#Syncfusion_Maui_Chat_ChatTypingIndicator_AvatarViewType) property.

N> To use a custom avatar image, add the `People_Circle14.png` file to the `Resources/Images` folder of your .NET MAUI project and ensure the build action is set to **MauiImage**.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="6" %}
public partial class TypingIndicatorViewModel
{
    public TypingIndicatorViewModel()
    {
        this.TypingIndicator = new ChatTypingIndicator();
        this.TypingIndicator.Authors.Add(new Author() { Name = "Harrison", Avatar = "People_Circle14.png" });
        this.TypingIndicator.AvatarViewType = AvatarViewType.Text;
        this.TypingIndicator.Text = "Harrison is typing...";
        this.ShowTypingIndicator = true;
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI Chat Typing indicator with text](images/typing-indicator/maui-chat-typing-indicator-text.png)

## Notifications when the user starts/stops typing

In `SfChat`, you can access the typing area using the [Editor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Editor) property, listen to its focus change, text change, and completed events to identify when the user starts or ends typing.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 11" %}
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Chat;

namespace TypingIndicator
{
    public partial class MainPage : ContentPage
    {
        private readonly SfChat sfChat;
        private System.Timers.Timer typingTimer;
        private const int TypingTimeoutMs = 1000;

        public MainPage()
        {
            InitializeComponent();
            this.sfChat = new SfChat();

            // Notifies that the user has started typing.
            this.sfChat.Editor.TextChanged += Editor_TextChanged;
            // Notifies that the user has stopped typing.
            this.sfChat.Editor.Unfocused += Editor_Unfocused;
            // Notifies that the user has submitted the message.
            this.sfChat.Editor.Completed += Editor_Completed;

            this.Content = this.sfChat;
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            // User has started typing.
            this.sfChat.ShowTypingIndicator = true;

            // Reset the inactivity timer on every keystroke.
            if (this.typingTimer == null)
            {
                this.typingTimer = new System.Timers.Timer(TypingTimeoutMs) { AutoReset = false };
                this.typingTimer.Elapsed += (s, args) =>
                {
                    Dispatcher.Dispatch(() => this.sfChat.ShowTypingIndicator = false);
                };
            }
            this.typingTimer.Stop();
            this.typingTimer.Start();
        }

        private void Editor_Unfocused(object sender, FocusEventArgs e)
        {
            // User has stopped typing (lost focus from the editor).
            this.typingTimer?.Stop();
            this.sfChat.ShowTypingIndicator = false;
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            // User has finished typing and submitted the message.
            this.typingTimer?.Stop();
            this.sfChat.ShowTypingIndicator = false;
        }
    }
}

{% endhighlight %}
{% endtabs %}

N> Use the `TextChanged` and `Unfocused` events for continuous typing feedback, the `Completed` event when the message is submitted, and the timer-based pattern to automatically hide the typing indicator after a period of inactivity.
