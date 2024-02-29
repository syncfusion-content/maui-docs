---
layout: post
title: Data Binding in .NET MAUI Chat Control | Syncfusion
description: Learn here all about Data Binding support in Syncfusion .NET MAUI Chat (SfChat) control, its elements and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Data Binding in .NET MAUI Chat (SfChat)

The 'SfChat' control facilitates binding any existing collection of data objects as a message collection using the 'SfChat.ItemsSource' property. Additionally, you can utilize the 'SfChat.ItemsSourceConverter' property to customize the conversion process if needed.

Consider/create the below collection of objects that has to be converted to message collection and displayed as messages in SfChat.

{% tabs %}
{% highlight c# %}
    
    public class MessageModel
    {
        public MessageModel()
        {
        }

        public ChatSuggestions Suggestions { get; set; }
        public Author User { get; set; }
        public string Text { get; set; }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        ObservableCollection<MessageModel> messageCollection;

        public ViewModel()
        {
            this.messageCollection = new ObservableCollection<MessageModel>();
            this.GenerateMessages();
        }

        /// <summary>
        /// Gets or sets the collection of messages of a conversation.
        /// </summary>
        public ObservableCollection<MessageModel> MessageCollection
        {
            get
            {
                return this.messageCollection;
            }

            set
            {
                this.messageCollection = value;
                RaisePropertyChanged("MessageCollection");
            }
        }

        private void GenerateMessages()
        {
            this.messageCollection.Add(new MessageModel()
            {
                User = currentAuthor,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            });

            this.messageCollection.Add(new MessageModel()
            {
                User = new Author() { Name = "Andrea", Avatar = "peoplecircle7.png" },
                Text = "Oh! That's great.",
            });

            this.messageCollection.Add(new MessageModel()
            {
                User = new Author() { Name = "Harrison", Avatar = "peoplecircle5.png" },
                Text = "That is good news.",
            });
        }
    }
{% endhighlight %}
{% endtabs %}

Now, bind the existing collection of data objects to the 'SfChat.ItemsSource' property, in our case it is 'viewModel.MessageCollection'. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="19 20" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:converter="clr-namespace:MauiChat.ViewModel"
                xmlns:local="clr-namespace:MauiChat.ViewModel"
                x:Class="MauiChat.MainPage">

        <ContentPage.Resources>
            <ResourceDictionary>
                <converter:MessageConverter x:Key="MessageConverter"/>
            </ResourceDictionary>
        </ContentPage.Resources>

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                        CurrentUser="{Binding CurrentUser}"
                        ItemsSource="{Binding MessageCollection}"
                        ItemsSourceConverter="{StaticResource MessageConverter }"/>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml.cs" hl_lines=" 19 20" %}
    
    using MauiChat.ViewModel;
    using Syncfusion.Maui.Chat;

    namespace MauiChat
    {
        public partial class MainPage : ContentPage
        {
            SfChat sfChat;
            ViewModel viewModel;
            MessageConverter messageConverter;
            public MainPage()
            {
                InitializeComponent();
                sfChat = new SfChat();
                messageConverter = new MessageConverter();
                viewModel = new ViewModel();
                sfChat.CurrentUser = viewModel.CurrentUser;
                sfChat.ItemsSource = viewModel.MessageCollection;
                sfChat.ItemsSourceConverter = messageConverter;
                Content = sfChat;
            }       
        }
    }
{% endhighlight %}
{% endtabs %}

Next, create a class derived from 'IChatMessageConverter' interface and set it to the 'SfChat.ItemsSourceConverter' property as shown below. The 'IChatMessageConverter' interface provides the methods 'ConvertToChatMessage' and 'ConvertToData' to convert an item of an existing collection to a chat message and to convert a chat message to an item of the existing data collection respectively. Similarly these two methods 'ConvertToChatMessag' and 'ConvertToData' will be fired whenever a new item is added/removed/replaced in the existing data collection or in the chat message collection respectively.

Implementation of a custom message converter class with conversion logics to convert from data to message and vice versa.
{% tabs %}
{% highlight c# %}

    
    /// <summary>
    /// Defines methods that can be used to convert data objects to chat messages and vice versa.
    /// </summary>
    public class MessageConverter : IChatMessageConverter
    {
        /// <summary>
        /// Converts given data object to a chat message.
        /// </summary>
        /// <param name="data">The data object to be converted as a chat message.</param>
        /// <param name="chat">Instance of <see cref="SfChat"/>. </param>
        /// <returns>Returns the data object as a chat message.</returns>
        public IMessage ConvertToChatMessage(object data, SfChat chat)
        {
            var message = new TextMessage();
            var item = data as MessageModel;

            message.Text = item.Text;
            message.Author = item.User;
            message.Data = item;
            if (item.Suggestions != null)
            {
                message.Suggestions = item.Suggestions;
            }
            return message;
        }

        /// <summary>
        /// Converts the given chat message to a data object.
        /// </summary>
        /// <param name="chatMessage">The chat message that is to be converted as a data object.</param>
        /// <param name="chat">Instance of <see cref="SfChat"/>. </param>
        /// <returns>Returns the chat message as a data object.</returns>
        public object ConvertToData(object chatMessage, SfChat chat)
        {
            var message = new MessageModel();
            var item = chatMessage as TextMessage;

            message.Text = item.Text;
            message.User = chat.CurrentUser;
            if (message.Suggestions != null)
            {
                message.Suggestions = chat.Suggestions;
            }
            return message;
        }
    }
{% endhighlight %}
{% endtabs %}

You can download the entire working sample from [here].

