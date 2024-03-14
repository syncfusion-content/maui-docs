---
layout: post
title: Data Binding in .NET MAUI Chat Control | Syncfusion
description: Learn here all about Data Binding support in Syncfusion .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Data Binding in .NET MAUI Chat (SfChat)

The `SfChat` control allows to bind any existing collection of data objects as message collection using the `ItemSource` and `ItemsSourceConverter` property as follows.

Create the below collection of objects that must be converted to message collection and displayed as messages in SfChat.

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}

    public class MessageModel
    {
        public MessageModel()
        {
        }

        public ChatSuggestions Suggestions { get; set; }
        public Author User { get; set; }
        public string Text { get; set; }

    }
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

    public class ViewModel : INotifyPropertyChanged
    {
        private Author currentAuthor;

        ObservableCollection<MessageModel> messageCollection;

        public ViewModel()
        {
            MessageModel messageModel = new MessageModel();
            messageCollection = new ObservableCollection<MessageModel>();
            currentAuthor = new Author() { Name = "Stevan" };
            GenerateMessages();
        }

        public ObservableCollection<MessageModel> MessageCollection
        {
            get
            {
                return messageCollection;
            }

            set
            {
                messageCollection = value;
                RaisePropertyChanged("messageCollection");
            }
        }

        public Author CurrentUser
        {
            get
            {
                return currentAuthor;
            }
            set
            {
                currentAuthor = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void GenerateMessages()
        {
            messageCollection.Add(new MessageModel()
            {
                User = currentAuthor,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            });

            messageCollection.Add(new MessageModel()
            {
                User = new Author() { Name = "Andrea", Avatar = "peoplecircle16.png" },
                Text = "Oh! That's great.",
            });

            messageCollection.Add(new MessageModel()
            {
                User = new Author() { Name = "Harrison", Avatar = "peoplecircle14.png" },
                Text = "That is good news.",
            });
        }
    }
{% endhighlight %}
{% endtabs %}

Now, bind the existing collection of data objects to the `SfChat.ItemsSource` property, in our case it is `viewModel.MessageCollection`. 

{% tabs %}
{% highlight xaml hl_lines="21 22" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:local="clr-namespace:MauiChat"
                x:Class="MauiChat.MainPage">

        <ContentPage.Resources>
            <ResourceDictionary>
                <local:MessageConverter x:Key="MessageConverter"/>
            </ResourceDictionary>
        </ContentPage.Resources>

        <ContentPage.BindingContext>
            <local:ViewModel/>
        </ContentPage.BindingContext>

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                    CurrentUser="{Binding CurrentUser}"
                    ItemsSource="{Binding MessageCollection}"
                    ItemsSourceConverter="{StaticResource MessageConverter}"/>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="18 19" %}
    
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

Next, create a class derived from `IChatMessageConverter` interface and set it to the `SfChat.ItemsSourceConverter` property as shown below. The `IChatMessageConverter` interface provides the methods `ConvertToChatMessage` and `ConvertToData` to convert an item of an existing collection to a chat message and to convert a chat message to an item of the existing data collection respectively. Similarly these two methods `ConvertToChatMessage` and `ConvertToData` will be fired whenever a new item is added/removed/replaced in the existing data collection or in the chat message collection respectively.

Implementation of a custom message converter class with conversion logic to convert from data to message and vice versa.

{% tabs %}
{% highlight c# tabtitle="Converter.cs" %}

    public class MessageConverter : IChatMessageConverter
    {
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
