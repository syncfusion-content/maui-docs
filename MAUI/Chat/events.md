---
layout: post
title: Events and Commands in .NET MAUI Chat Control | Syncfusion
description: Learn here all about Events and Commands support in Syncfusion .NET MAUI Chat (SfChat) control and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Events and Commands in .NET MAUI Chat (SfChat)

## MessageTapped event and command

The `SfChat` control includes a built-in event called [MessageTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTapped) and a command named [MessageTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTappedCommand). These are triggered when a message is tapped. You can access the tapped message and the point of interaction through the [MessageTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageTappedEventArgs.html). 

### MessageTapped event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <sfChat:SfChat x:Name="sfChat"
            MessageTapped="sfChat_MessageTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
    sfChat.MessageTapped += SfChat_MessageTapped;

    private void sfChat_MessageTapped(object sender, MessageTappedEventArgs e)
    {                    
        DisplayAlert("Message", " Tapped on message :" + e.Message.Author.Name, "Ok");
    }

{% endhighlight %}
{% endtabs %}

### MessageTapped command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <sfChat:SfChat x:Name="sfChat"  
            MessageTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            // Assigning command action to ICommand type property
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
            DisplayAlert("Message", "Tapped on Message :" + MessageTappedArgs.Message.Author.Name, "Ok");
        }
    }
{% endhighlight %}
{% endtabs %}

## MessageDoubleTapped event and command

The `SfChat` control includes built-in features like the [MessageDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTapped) event and [MessageDoubleTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTappedCommand). These are activated when a message is double-tapped. You can access the message that was double-tapped and the point of interaction through the [MessageDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageDoubleTappedEventArgs.html).

### MessageDoubleTapped event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
    <sfChat:SfChat x:Name="sfChat"
            MessageDoubleTapped="sfChat_MessageDoubleTapped" />
        
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    sfChat.MessageDoubleTapped += SfChat_MessageDoubleTapped;            

    private void sfChat_MessageDoubleTapped(object? sender, MessageDoubleTappedEventArgs e)
    {
        DisplayAlert("Message", " DoubleTapped on message :" + e.Message.Author.Name, "Ok");
    }
{% endhighlight %}
{% endtabs %}

### MessageDoubleTapped command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
    <sfChat:SfChat x:Name="sfChat"  
            MessageDoubleTappedCommand="{Binding DoubleTappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> doubleTappedCommand;

        public ViewModel()
        {
            // Assigning command action to ICommand type property
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
            DisplayAlert("Message", "DoubleTapped on Message :" + MessageDoubleTappedArgs.Message.Author.Name, "Ok");
        }
    }
{% endhighlight %}
{% endtabs %}

## MessageLongPressed event and command

The `SfChat` control has built-in features like the [MessageLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressed) event and [MessageLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressedCommand). These are activated when a message is long-pressed. You can access the message that was long-pressed and the point of interaction through the [MessageLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageLongPressedEventArgs.html).

### MessageLongPressed event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <sfChat:SfChat x:Name="sfChat"
            MessageLongPressed="sfChat_MessageLongPressed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    
    sfChat.MessageLongPressed += sfChat_MessageLongPressed;

    private void sfChat_MessageLongPressed(object sender, MessageLongPressedEventArgs e)
    {
        DisplayAlert("Message", " LongPressed on message :" + e.Message.Author.Name, "Ok");
    }
{% endhighlight %}
{% endtabs %}

### MessageLongPressed command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
    <sfChat:SfChat x:Name="sfChat"  
            MessageLongPressedCommand ="{Binding LongPressedCommand }" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> longPressedCommand;

        public ViewModel()
        {
            // Assigning command action to ICommand type property
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
            DisplayAlert("Message", "LongPressed on Message :" + MessageLongPressedArgs.Message.Author.Name, "Ok");
        }
    }       
{% endhighlight %}
{% endtabs %}
