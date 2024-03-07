---
layout: post
title: Working with Chat in .NET MAUI Chat Control | Syncfusion
description: Learn here all about Working with Chat support in Syncfusion .NET MAUI Chat (SfChat) control and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Working with Chat in .NET MAUI Chat (SfChat)

## MessageTapped Event and Command

The `SfChat` control includes a built-in event called `SfChat.MessageTapped` and a command named `SfChat.MessageTappedCommand`. These are triggered when a message is tapped. You can access the tapped message and the point of interaction through the `MessageTappedEventArgs`. 

### MessageTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

    <sfChat:SfChat x:Name="sfChat"
            MessageTapped="sfChat_MessageTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
      
    sfChat.MessageTapped += SfChat_MessageTapped;

    private void sfChat_MessageTapped(object sender, MessageTappedEventArgs e)
    {                    
        DisplayAlert("Message", " Tapped on message :" + e.Message.Author.Name, "Ok");
    }

{% endhighlight %}
{% endtabs %}

### MessageTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}   

    <sfChat:SfChat x:Name="sfChat"  
            MessageTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="19" %}

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

## MessageDoubleTapped Event and Command

The `SfChat` control includes built-in features like the `SfChat.MessageDoubleTapped` event and `SfChat.MessageDoubleTappedCommand`. These are activated when a message is double-tapped. You can access the message that was double-tapped and the point of interaction through the `MessageDoubleTappedEventArgs`.

### MessageDoubleTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
    
    <sfChat:SfChat x:Name="sfChat"
            MessageDoubleTapped="sfChat_MessageDoubleTapped" />
        
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}

    sfChat.MessageDoubleTapped += SfChat_MessageDoubleTapped;            

    private void sfChat_MessageDoubleTapped(object? sender, MessageDoubleTappedEventArgs e)
    {
        DisplayAlert("Message", " DoubleTapped on message :" + e.Message.Author.Name, "Ok");
    }
{% endhighlight %}
{% endtabs %}

### MessageDoubleTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
    
    <sfChat:SfChat x:Name="sfChat"  
            MessageDoubleTappedCommand="{Binding DoubleTappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="19" %}

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

## MessageLongPressed Event and Command

The `SfChat` control has built-in features like the `SfChat.MessageLongPressed` event and `SfChat.MessageLongPressedCommand`. These are activated when a message is long-pressed. You can access the message that was long-pressed and the point of interaction through the `MessageLongPressedEventArgs`. 

### MessageLongPressed Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

    <sfChat:SfChat x:Name="sfChat"
            MessageLongPressed="sfChat_MessageLongPressed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
    
    sfChat.MessageLongPressed += sfChat_MessageLongPressed;

    private void sfChat_MessageLongPressed(object sender, MessageLongPressedEventArgs e)
    {
        DisplayAlert("Message", " LongPressed on message :" + e.Message.Author.Name, "Ok");
    }
{% endhighlight %}
{% endtabs %}

### MessageLongPressed Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
    
    <sfChat:SfChat x:Name="sfChat"  
            MessageLongPressedCommand ="{Binding LongPressedCommand }" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="19" %}

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
