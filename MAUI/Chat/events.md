---
layout: post
title: Events and Commands in .NET MAUI Chat Control | Syncfusion®
description: Learn about the events, commands, suggestions, and MVVM interactions supported by the Syncfusion® .NET MAUI Chat (SfChat) control.
platform: MAUI
control: SfChat
documentation: ug
---

# Events and Commands in .NET MAUI Chat (SfChat)

The `SfChat` control exposes a set of events and commands that are raised in response to user interactions on chat messages, such as tapping, double-tapping, and long-pressing.

## MessageTapped Event and Command

The `SfChat` control includes a built-in event called [MessageTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTapped) and a command named [MessageTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTappedCommand). These are raised when a chat message bubble is tapped. You can access the tapped message and the point of interaction through the [MessageTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageTappedEventArgs.html). 

### MessageTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<sfChat:SfChat x:Name="sfChat"
        MessageTapped="sfChat_MessageTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
sfChat.MessageTapped += SfChat_MessageTapped;

private void sfChat_MessageTapped(object sender, MessageTappedEventArgs e)
{                    
    DisplayAlert("Message", "Tapped on message: " + e.Message.Author.Name, "Ok");
}

{% endhighlight %}
{% endtabs %}

### MessageTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

<sfChat:SfChat x:Name="sfChat"  
        MessageTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Syncfusion.Maui.Chat;

public class ViewModel : INotifyPropertyChanged
{
    private ICommand tappedCommand;

    public ViewModel()
    {
        // Assigning command action to ICommand type property
        TappedCommand = new Command<object>(OnMessageTapped);
    }
    
    // ICommand type property for binding with sfChat.MessageTappedCommand
    public ICommand TappedCommand
    {
        get { return tappedCommand; }
        set
        {
            tappedCommand = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    private void OnMessageTapped(object obj)
    {
        if (obj is MessageTappedEventArgs messageTappedArgs)
        {
            // Expose the tapped message to the View rather than calling UI APIs from the ViewModel
            LastTappedMessage = messageTappedArgs.Message.Author.Name;
        }
    }

    private string lastTappedMessage;
    public string LastTappedMessage
    {
        get { return lastTappedMessage; }
        set
        {
            lastTappedMessage = value;
            OnPropertyChanged();
        }
    }
}
{% endhighlight %}
{% endtabs %}

## MessageDoubleTapped Event and Command

The `SfChat` control includes built-in features like the [MessageDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTapped) event and [MessageDoubleTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTappedCommand). These are raised when a chat message bubble is double-tapped. You can access the message that was double-tapped and the point of interaction through the [MessageDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageDoubleTappedEventArgs.html).

### MessageDoubleTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
<sfChat:SfChat x:Name="sfChat"
        MessageDoubleTapped="sfChat_MessageDoubleTapped" />
        
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

sfChat.MessageDoubleTapped += SfChat_MessageDoubleTapped;            

private void sfChat_MessageDoubleTapped(object? sender, MessageDoubleTappedEventArgs e)
{
    DisplayAlert("Message", "Tapped on message: " + e.Message.Author.Name, "Ok");
}
{% endhighlight %}
{% endtabs %}

### MessageDoubleTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
<sfChat:SfChat x:Name="sfChat"  
        MessageDoubleTappedCommand="{Binding DoubleTappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Syncfusion.Maui.Chat;

public class ViewModel : INotifyPropertyChanged
{
    private ICommand doubleTappedCommand;

    public ViewModel()
    {
        // Assigning command action to ICommand type property
        DoubleTappedCommand = new Command<object>(OnMessageDoubleTapped);
    }
    
    // ICommand type property for binding with sfChat.MessageDoubleTappedCommand
    public ICommand DoubleTappedCommand
    {
        get { return doubleTappedCommand; }
        set
        {
            doubleTappedCommand = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    private void OnMessageDoubleTapped(object obj)
    {
        if (obj is MessageDoubleTappedEventArgs messageDoubleTappedArgs)
        {
            // Expose the double-tapped message to the View rather than calling UI APIs from the ViewModel
            LastTappedMessage = messageDoubleTappedArgs.Message.Author.Name;
        }
    }

    private string lastTappedMessage;
    public string LastTappedMessage
    {
        get { return lastTappedMessage; }
        set
        {
            lastTappedMessage = value;
            OnPropertyChanged();
        }
    }
}
{% endhighlight %}
{% endtabs %}

## MessageLongPressed Event and Command

The `SfChat` control has built-in features like the [MessageLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressed) event and [MessageLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressedCommand). These are raised when a chat message bubble is long-pressed. You can access the message that was long-pressed and the point of interaction through the [MessageLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageLongPressedEventArgs.html).

### MessageLongPressed Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<sfChat:SfChat x:Name="sfChat"
        MessageLongPressed="sfChat_MessageLongPressed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    
sfChat.MessageLongPressed += sfChat_MessageLongPressed;

private void sfChat_MessageLongPressed(object sender, MessageLongPressedEventArgs e)
{
    DisplayAlert("Message", "Tapped on message: " + e.Message.Author.Name, "Ok");
}
{% endhighlight %}
{% endtabs %}

### MessageLongPressed Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
<sfChat:SfChat x:Name="sfChat"  
        MessageLongPressedCommand="{Binding LongPressedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="18" %}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Syncfusion.Maui.Chat;

public class ViewModel : INotifyPropertyChanged
{
    private ICommand longPressedCommand;

    public ViewModel()
    {
        // Assigning command action to ICommand type property
        LongPressedCommand = new Command<object>(OnMessageLongPressed);
    }

    // ICommand type property for binding with sfChat.MessageLongPressedCommand
    public ICommand LongPressedCommand
    {
        get { return longPressedCommand; }
        set
        {
            longPressedCommand = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnMessageLongPressed(object obj)
    {
        if (obj is MessageLongPressedEventArgs messageLongPressedArgs)
        {
            // Expose the long-pressed message to the View rather than calling UI APIs from the ViewModel
            LastTappedMessage = messageLongPressedArgs.Message.Author.Name;
        }
    }

    private string lastTappedMessage;
    public string LastTappedMessage
    {
        get { return lastTappedMessage; }
        set
        {
            lastTappedMessage = value;
            OnPropertyChanged();
        }
    }
}
{% endhighlight %}
{% endtabs %}
