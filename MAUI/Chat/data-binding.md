---
layout: post
title: Data Binding in .NET MAUI Chat Control | Syncfusion®
description: Learn here all about Data Binding support in Syncfusion® .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Data Binding in .NET MAUI Chat (SfChat)

The `SfChat` control allows you to bind any existing collection of data objects as a data collection and display them as chat messages using the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSource) and [ItemsSourceConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSourceConverter) properties as follows.

Create the following data collection of objects that will be converted to chat messages and displayed in SfChat.

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}
using Syncfusion.Maui.Chat;
using System.ComponentModel;

namespace DataBinding
{
    public class MessageModel
    {
        #region Public Properties
        public Author? User { get; set; }
        public string? Text { get; set; }
        #endregion
    }
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.Collections.ObjectModel;
using System.ComponentModel;

public class ViewModel : INotifyPropertyChanged
{
    private Author currentAuthor;

    ObservableCollection<MessageModel> messageCollection;

    public ViewModel()
    {
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
            RaisePropertyChanged(nameof(MessageCollection));
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
            RaisePropertyChanged(nameof(CurrentUser));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void RaisePropertyChanged(string propName)
    {
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
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

N> The sample uses peoplecircle14.png and peoplecircle16.png as avatar images. Add these image files to the project's Resources/Images folder and ensure their build action is set to MauiImage so that they can be displayed correctly at runtime.

Now, bind the existing collection of data objects to the `SfChat.ItemsSource` property. In this example, the collection is `viewModel.MessageCollection`. 

{% tabs %}
{% highlight xaml hl_lines="21 22" %}
    
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
            xmlns:local="clr-namespace:DataBinding"
            x:Class="DataBinding.MainPage">

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

namespace DataBinding
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

Next, create a class that implements the [IChatMessageConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.IChatMessageConverter.html) interface and assign it to the [ItemsSourceConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSourceConverter) property as shown below. The `IChatMessageConverter` interface provides the [ConvertToChatMessage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.IChatMessageConverter.html#Syncfusion_Maui_Chat_IChatMessageConverter_ConvertToChatMessage_System_Object_Syncfusion_Maui_Chat_SfChat_) and [ConvertToData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.IChatMessageConverter.html#Syncfusion_Maui_Chat_IChatMessageConverter_ConvertToData_System_Object_Syncfusion_Maui_Chat_SfChat_) methods to convert data collection items into chat messages and chat messages back into data collection items. These methods are triggered whenever an item is added, removed, or replaced in either the data collection or the chat message collection.

N>  The ConvertToData method uses `SfChat.CurrentUser` and `SfChat.Suggestions` to populate the User and Suggestions properties of the converted MessageModel. Ensure that these properties are set on the SfChat instance before data conversion occurs; otherwise, the resulting MessageModel may contain `null` values.

Implementation of a custom message converter class with conversion logic to convert from data to message and vice versa.

N> The `ConvertToChatMessage` method must return an `IMessage` object, such as `TextMessage`, which is displayed by the `SfChat` control. The `ConvertToData` method must return an object of the underlying data type, such as `MessageModel`, to synchronize changes from the chat message collection back to the original data source. For more information, refer to the `IMessage` API documentation.

{% tabs %}
{% highlight c# tabtitle="Converter.cs" %}
using Syncfusion.Maui.Chat;
namespace MauiChat
{
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
            if (item.Suggestions != null)
            {
                message.Suggestions = item.Suggestions;
            }
            return message;
        }
    }
}
{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/convert-data-objects-to-messages-in-mvvm-in-.net-maui-chat)
