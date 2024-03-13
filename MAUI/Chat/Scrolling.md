---
layout: post
title: Scrolling in .NET MAUI Chat control | Syncfusion
description: Learn here all about Scrolling support in Syncfusion .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Scrolling in .NET MAUI Chat (SfChat)

## Scroll to message

You can scroll to a particular message programmatically using the `SfChat.ScrollToMessage(Object)` method.

{% tabs %}
{% highlight tabtitle="MainPage.xaml" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:local="clr-namespace:MauiChat"             
                x:Class="MauiChat.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
        </ContentPage.BindingContext>
    
        <StackLayout>
            <Button x:Name="ScrollTo" Text="Scroll to message" HeightRequest="100" Clicked="ScrollTo_Clicked" />
            <sfChat:SfChat x:Name="sfChat"
                Messages="{Binding Messages}"
                CurrentUser="{Binding CurrentUser}"
                SendMessageCommand="{Binding SendMessageCommand}"
                CanAutoScrollToBottom="False"/>
        </StackLayout>
    </ContentPage>

{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml.cs" %}

    private void ScrollTo_Clicked(object sender, EventArgs e)
    {
        // Scroll to the sixth message in the collection.
        this.sfChat.ScrollToMessage(this.viewModel.Messages[5]);
    }

{% endhighlight %}
{% endtabs %}

## Auto scroll chat control to bottom when new message is added

By default, the `SfChat` control is scrolled to the bottom to show the newly added message. If you want to disable this auto scroll, set `SfChat.CanAutoScrollToBottom` as `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="16" %}
    
    <?xml version="1.0" encoding="utf-8" ?>     
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:local="clr-namespace:MauiChat"             
                x:Class="MauiChat.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
        </ContentPage.BindingContext>

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                        Messages="{Binding Messages}"
                        CurrentUser="{Binding CurrentUser}"
                        CanAutoScrollToBottom="False"/>  
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% endtabs %}

## Scrolled event

The `SfChat` control comes with a built-in `SfChat.Scrolled` event that will be fired whenever the chat control is scrolled. You can get the current scroll offset, whether scrolling has reached the top or bottom of the message list in the `ChatScrolledEventArgs`. You can handle this event to restrict the auto-scroll in chat for newly added messages, if the user had already scrolled up manually and was currently not at the bottom of the chat when the new message was added. 

{% tabs %}
{% highlight xaml hl_lines="16" %}
    
    <?xml version="1.0" encoding="utf-8" ?>     
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:local="clr-namespace:MauiChat"             
                x:Class="MauiChat.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
        </ContentPage.BindingContext>

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                        Messages="{Binding Messages}"
                        CurrentUser="{Binding CurrentUser}"
                        Scrolled="sfChat_Scrolled"/>  
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}  
{% highlight c# hl_lines="16" %}
    
    using Syncfusion.Maui.Chat;

    namespace MauiChat
    {
        public partial class MainPage : ContentPage
        {
            SfChat sfChat;
            ViewModel viewModel;
            public MainPage()
            {
                InitializeComponent();
                sfChat = new SfChat();
                viewModel = new ViewModel();
                sfChat.Messages = viewModel.Messages;
                sfChat.CurrentUser = viewModel.CurrentUser;
                sfChat.Scrolled += ScrollTo_Clicked;
            }
            private void ScrollTo_Clicked(object? sender, ChatScrolledEventArgs e)
            {
                // The chat will not be auto scrolled to the bottom
                // if the user is not currently at the bottom end of the chat at the time of the arrival of the new message
                // but rather already manually scrolled above to read old messages.
                sfChat.CanAutoScrollToBottom = e.IsBottomReached;
            }
        }
    }

{% endhighlight %}
{% endtabs %}
