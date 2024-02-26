---
layout: post
title: Working with TreeView in .NET MAUI Chat Control | Syncfusion
description: Learn here about Working with TreeView support in Syncfusion .NET MAUI Chat (SfChat) control and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Working with Chat in .NET MAUI Chat (SfChat)

## Message Tapped Event and Command

The 'SfChat' control is equipped with both the 'SfChat.MessageTapped' event and 'SfChat.MessageTappedCommand'. These are triggered when a message is tapped. You can retrieve the tapped Message and the interaction point using the 'MessageTappedEventArgs', Accessible as 'MessageTappedEventArgs.Message' and 'MessageTappedEventArgs.Point', in both the event handler for 'MessageTapped' and the action of 'MessageTappedCommand' .

### MessageTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 11" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                 xmlns:local="clr-namespace:ChatInteraction"
                 x:Class="ChatInteraction.MainPage">

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                    MessageTapped="sfChat_MessageTapped"
                    Messages="{Binding Messages}"
                    CurrentUser="{Binding CurrentUser}"                      
                    ShowOutgoingMessageAvatar="True">
            </sfChat:SfChat>
        </ContentPage.Content>
    </ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="11" %}
      
    using Syncfusion.Maui.Chat;

    namespace ChatInteraction
    {
        public partial class MainPage : ContentPage
        { 
            public MainPage()
            {
                InitializeComponent();
                sfChat.MessageTapped += SfChat_MessageTapped;
            }

            private void sfChat_MessageTapped(object sender, MessageTappedEventArgs e)
            {                    
                App.Current.MainPage.DisplayAlert("Message", " Tapped on message :" + e.Message.Author.Name, "Ok");
            }
        }
    }
{% endhighlight %}
{% endtabs %}

### MessageTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}   

    <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"  
                        MessageTappedCommand="{Binding TappedCommand}" />
    </ContentPage.Content>
{% endhighlight %}
{% highlight c# %}

    //ViewModel.cs

    public class GettingStartedViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public GettingStartedViewModel()
        {
            // assigning command action to ICommand type property
            TappedCommand = new Command<object>(MessageTapped);
        }
        
        // ICommand type property for binding with sfChat.MessageTappedCommand
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }
        
        private void MessageTapped(object args)
        {
            var MessageTappedArgs = obj as MessageTappedEventArgs;
    App.Current.MainPage.DisplayAlert("Message", "Tapped on Message :" + MessageTappedArgs.Message.Author.Name, "Ok");
        }
    }
{% endhighlight %}
{% endtabs %}

## Message DoubleTapped Event and Command

The 'SfChat' control is equipped with both the 'SfChat.MessageDoubleTapped' event and 'SfChat.MessageDoubleTappedCommand'. These are triggered when a message is double tapped. You can retrieve the double tapped Message and the interaction point using the 'MessageDoubleTappedEventArgs',Accessible as 'MessageDoubleTappedEventArgs.Message' and 'MessageDoubleTappedEventArgs.Point', in both the event handler for 'MessageDoubleTapped' and the action of 'MessageDoubleTappedCommand' .

### MessageDoubleTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 11" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                 xmlns:local="clr-namespace:ChatInteraction"
                 x:Class="ChatInteraction.MainPage">

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                        MessageDoubleTapped="sfChat_MessageDoubleTapped"
                        Messages="{Binding Messages}"
                        CurrentUser="{Binding CurrentUser}"                      
                        ShowOutgoingMessageAvatar="True">
            </sfChat:SfChat>
        </ContentPage.Content>
    </ContentPage>
        
{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml.cs" hl_lines="11" %}
    
    using Syncfusion.Maui.Chat;

    namespace ChatInteraction
    {
        public partial class MainPage : ContentPage
        {        
            public MainPage()
            {
                InitializeComponent();
                sfChat.MessageDoubleTapped += SfChat_MessageDoubleTapped;
            }

            private void sfChat_MessageDoubleTapped(object? sender, MessageDoubleTappedEventArgs e)
            {
                App.Current.MainPage.DisplayAlert("Message", " DoubleTapped on message :" + e.Message.Author.Name, "Ok");
            }
        }
    }
{% endhighlight %}
{% endtabs %}

### MessageDoubleTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
    
    <ContentPage.Content>
                <sfChat:SfChat x:Name="sfChat"  
                            MessageDoubleTappedCommand="{Binding DoubleTappedCommand}" />
    </ContentPage.Content>
{% endhighlight %}
{% highlight C# %}

    //ViewModel.cs

    public class GettingStartedViewModel : INotifyPropertyChanged
    {
        public Command<object> doubleTappedCommand;

        public GettingStartedViewModel()
        {
            // assigning command action to ICommand type property
            DoubleTappedCommand = new Command<object>(MessageDoubleTapped);
        }
        
        // ICommand type property for binding with sfChat.MessageDoubleTappedCommand
        public Command<object> DoubleTappedCommand
        {
            get { return doubleTappedCommand; }
            set { doubleTappedCommand = value; }
        }
        
        private void MessageDoubleTapped(object obj)
        {
            var MessageDoubleTappedArgs= obj as MessageDoubleTappedEventArgs;
            App.Current.MainPage.DisplayAlert("Message", "DoubleTapped on Message :" + MessageDoubleTappedArgs.Message.Author.Name, "Ok");
        }
    }
{% endhighlight %}
{% endtabs %}

## Message LongPressed Event and Command

The 'SfChat' control is equipped with both the 'SfChat.MessageLongPressed' event and 'SfChat.MessageLongPressedCommand'. These are triggered when a message is long pressed. You can retrieve the long pressed Message and the interaction point using the 'MessageLongPressedEventArgs',Accessible as 'MessageLongPressedEventArgs.Message' and 'MessageLongPressedEventArgs.Point', in both the event handler for 'MessageLongPressed' and the action of 'MessageLongPressedCommand' .

### MessageLongPressed Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 11" %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                 xmlns:local="clr-namespace:ChatInteraction"
                 x:Class="ChatInteraction.MainPage">

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                    MessageLongPressed="sfChat_MessageLongPressed"
                    Messages="{Binding Messages}"
                    CurrentUser="{Binding CurrentUser}"                      
                    ShowOutgoingMessageAvatar="True">
            </sfChat:SfChat>
        </ContentPage.Content>
    </ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="11" %}
    
    using Syncfusion.Maui.Chat;

    namespace ChatInteraction
    {
        public partial class MainPage : ContentPage
        {        
            public MainPage()
            {
                InitializeComponent();
                sfChat.MessageLongPressed += sfChat_MessageLongPressed;
            }

            private void sfChat_MessageLongPressed(object sender, MessageLongPressedEventArgs e)
            {
                App.Current.MainPage.DisplayAlert("Message", " LongPressed on message :" + e.Message.Author.Name, "Ok");
            }
        }
    }
{% endhighlight %}
{% endtabs %}

### MessageLongPressed Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
    
    <ContentPage.Content>
                <sfChat:SfChat x:Name="sfChat"  
                            MessageLongPressedCommand ="{Binding LongPressedCommand }" />
    </ContentPage.Content>
{% endhighlight %}
{% highlight C# %}
    
    //ViewModel.cs

    public class GettingStartedViewModel : INotifyPropertyChanged
    {
        public Command<object> longPressedCommand;

        public GettingStartedViewModel()
        {
            // assigning command action to ICommand type property
            LongPressedCommand = new Command<object>(MessageLongPressed);
        }

        // ICommand type property for binding with sfChat.MessageLongPressedCommand
        public Command<object> LongPressedCommand
        {
            get { return longPressedCommand; }
            set { longPressedCommand = value; }
        }

        private void MessageLongPressed(object obj)
        {
            var MessageLongPressedArgs = obj as MessageLongPressedEventArgs;
            App.Current.MainPage.DisplayAlert("Message", "LongPressed on Message :" + MessageLongPressedArgs.Message.Author.Name, "Ok");
        }
    }
{% endhighlight %}
{% endtabs %}