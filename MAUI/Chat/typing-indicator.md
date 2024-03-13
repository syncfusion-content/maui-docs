---
layout: post
title: Typing indicator in .NET MAUI Chat control | Syncfusion
description: Learn here all about Typing indicator support in .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Typing indicator in .NET MAUI Chat (SfChat)

In `SfChat`, typing indicator indicates with an animation, that a user (or users) is currently typing, thereby providing an enhanced user experience. To show or hide the typing indicator set the `ShowTypingIndicator` property to `true` or `false` respectively. To show user image and text in the typing indicator create a new instance of `TypingIndicator`, set the `TypingIndicator.Authors` and `TypingIndicator.Text` property and assign the typing indicator instance to the `TypingIndicator` property.

{% tabs %}
{% highlight xaml hl_lines="14 15" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
             xmlns:local="clr-namespace:TypingIndicator"
             x:Class="TypingIndicator.MainPage">
    
    <ContentPage.BindingContext>
        <local:TypeIndicatorViewModel/>
    </ContentPage.BindingContext>
    
        <ContentPage.Content>
        <sfChat:SfChat x:Name="sfChat"
                       Messages="{Binding Messages}"
                       TypingIndicator="{Binding TypingIndicator}"
                       ShowTypingIndicator="{Binding ShowTypingIndicator}"
                       CurrentUser="{Binding CurrentUser}"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# hl_lines="16 17" %}
using Syncfusion.Maui.Chat;

namespace GettingStarted
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

    public class TypeIndicatorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> messages;

        /// <summary>
        /// Current user of chat.
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

        public TypeIndicatorViewModel()
        {
            this.Messages = new ObservableCollection<object>();
            this.TypingIndicator = new ChatTypingIndicator();
            this.TypingIndicator.Authors.Add(new Author() { Name = "Harrison"});
            this.TypingIndicator.AvatarViewType = AvatarViewType.Image;
            this.TypingIndicator.Text = "Harrison is typing...";
            this.ShowTypingIndicator = true;
            this.CurrentUser = new Author() { Name = "Nancy" };
            this.GenerateMessages();
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
                RaisePropertyChanged("TypingIndicator");
            }
        }

        /// <summary>
        /// Gets or sets the message conversation.
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
                RaisePropertyChanged("ShowTypingIndicator");
            }
        }

        /// <summary>
        /// Gets or sets the current user.
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
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</m>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void GenerateMessages()
        {
            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Andrea", Avatar = "peoplecircle7.png" },
                Text = "Oh! That's great.",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Harrison", Avatar = "peoplecircle1.png" },
                Text = "That is good news.",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Stevan", Avatar = "peoplecircle2.png" },
                Text = "What kind of application is it and when are we going to launch?",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "A kind of Emergency Broadcast App.",
            });
        }
    }

{% endhighlight %}
{% endtabs %}

![Typing indicator with image in .NET MAUI Chat](images/typing-indicator/maui-chat-typing-indicator.png)

## Customize avatar view of typing indicator

The avatar view in the typing indicator can be customized to show only starting alphabet of the username or only image of the user as avatar by using `TypingIndicator.AvatarViewType` property.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}
public class TypingIndicatorViewModel : INotifyPropertyChanged
{
    /// <summary>
    /// Indicates the typing indicator visibility. 
    /// </summary>
    private bool showTypingIndicator;

    /// <summary>
    /// Chat typing indicator.
    /// </summary>
    private ChatTypingIndicator typingIndicator;
    
    public GettingStattedViewModel()
    {
        this.TypingIndicator = new ChatTypingIndicator();
        this.TypingIndicator.Authors.Add(new Author() { Name = "Harrison", Avatar = "People_Circle14.png" }        
        
        this.TypingIndicator.AvatarViewType = AvatarViewType.Text;
        
        this.TypingIndicator.Text = "Harrison is typing...";
        this.ShowTypingIndicator = true;
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
            RaisePropertyChanged("TypingIndicator");
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
        private set
        {
            this.showTypingIndicator = value;
            RaisePropertyChanged("ShowTypingIndicator");
        }
    }
}

{% endhighlight %}
{% endtabs %}

![Typing indicator with text in .NET MAUI Chat](images/typing-indicator/maui-chat-typing-indicator-text.png)

## Notifications when user start/stop typing
 
In `SfChat`, you can access the typing area in SfChat using the `SfChat.Editor` property, listen to its focus change, text change, completed events to identify when the user starts or ends typing.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 11" %}
namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Notifies that user has started typing.
            this.sfChat.Editor.TextChanged += Editor_TextChanged;
            // Notifies that user has stopped typing.
            this.sfChat.Editor.Unfocused += Editor_Unfocused;
        }      

        private void Editor_Unfocused(object sender, FocusEventArgs e)
        {
            // User has stopped typing.
            this.sfChat.ShowTypingIndicator = false;
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            // User has started typing.
            this.sfChat.ShowTypingIndicator = true;
        }
    }
}

{% endhighlight %}
{% endtabs %} 

## Customize height of the typing indicator view area

SfChat provides the flexibility to adjust the height or completely remove the static area above the message editor, where the typing indicator is displayed. You can achieve this by using the `SfChat.TypingIndicatorViewHeight` property.

{% tabs %}
{% highlight xaml hl_lines="2" %}
 <sfChat:SfChat x:Name="sfChat"
                TypingIndicatorViewHeight="0"
                Messages="{Binding Messages}"
                CurrentUser="{Binding CurrentUser}" >
 </sfChat:SfChat>
        
{% endhighlight %}

{% highlight c# hl_lines="10" %}
    public partial class MainPage : ContentPage
    {
        SfChat sfChat;
        TypingIndicatorViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            sfChat = new SfChat();
            viewModel = new TypingIndicatorViewModel();
            sfChat.TypingIndicatorViewHeight = 0;
            sfChat.Messages = viewModel.Messages;
            sfChat.CurrentUser = viewModel.CurrentUser;
            this.Content = sfChat;
        }
    }

{% endhighlight %}
{% endtabs %} 

![Customize height of the typing indicator view area in .NET MAUI Chat](images/typing-indicator/maui-chat-typing-indicator-height.png)


