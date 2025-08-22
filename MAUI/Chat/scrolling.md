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

You can scroll to a particular message programmatically using the [SfChat.ScrollToMessage(Object)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToMessage_System_Object_) method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
    <StackLayout>
        <Button x:Name="ScrollTo" Text="Scroll to message" HeightRequest="100" Clicked="ScrollTo_Clicked" />
        <sfChat:SfChat x:Name="sfChat"
            Messages="{Binding Messages}"
            CurrentUser="{Binding CurrentUser}"
            CanAutoScrollToBottom="False"/>
    </StackLayout>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void ScrollTo_Clicked(object sender, EventArgs e)
    {
        // Scroll to the sixth message in the collection.
        this.sfChat.ScrollToMessage(this.viewModel.Messages[5]);
    }

{% endhighlight %}
{% endtabs %}

## Auto scroll chat control to bottom when new message is added

By default, the [SfChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html) control is scrolled to the bottom to show the newly added message. If you want to disable this auto scroll, set [CanAutoScrollToBottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CanAutoScrollToBottom) as `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
    <sfChat:SfChat x:Name="sfChat"
                Messages="{Binding Messages}"
                CurrentUser="{Binding CurrentUser}"
                CanAutoScrollToBottom="False"/>  

{% endhighlight %}
{% endtabs %}

## Scrolled event

The [SfChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html) control comes with a built-in `Scrolled` event that will be fired whenever the chat control is scrolled. You can get the current scroll offset, whether scrolling has reached the top or bottom of the message list in the [ChatScrolledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatScrolledEventArgs.html). You can handle this event to restrict the auto-scroll in chat for newly added messages, if the user had already scrolled up manually and was currently not at the bottom of the chat when the new message was added. 

{% tabs %}
{% highlight xaml hl_lines="4" %}
    <sfChat:SfChat x:Name="sfChat"
                Messages="{Binding Messages}"
                CurrentUser="{Binding CurrentUser}"
                Scrolled="sfChat_Scrolled"/>
{% endhighlight %}  
{% highlight c# hl_lines="8" %}
     sfChat.Scrolled += sfChat_Scrolled;
    
    private void sfChat_Scrolled(object? sender, ChatScrolledEventArgs e)
    {
        // The chat will not be auto scrolled to the bottom
        // if the user is not currently at the bottom end of the chat at the time of the arrival of the new message
        // but rather already manually scrolled above to read old messages.
        sfChat.CanAutoScrollToBottom = e.IsBottomReached;
    }

{% endhighlight %}
{% endtabs %}
## Scroll to Bottom Button

The `SfChat` allows you to display a scroll to bottom button when `ShowScrollToBottomButton` property is set to `true` that helps to quickly navigate to the last message when they have scrolled up through older messages in the conversation.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
    <sfChat:SfChat x:Name="sfChat"
                Messages="{Binding Messages}"
                CurrentUser="{Binding CurrentUser}"
                ShowScrollToBottomButton="True"/>  

{% endhighlight %}
{% endtabs %}

### Scroll to Bottom Button Template

The `SfChat` control allows you to fully customize the  scroll to bottom button appearance by using the `ScrollToBottomButtonTemplate` property. This property lets you define a custom layout and style.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="20" %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="scrollToBottomButtonTemplate">
            <Grid>
                <Label Text="↓"
                       FontSize="30"
                       FontAttributes="Bold"
                       HorizontalOptions="Center"
                       VerticalOptions="Center" />
                       ...
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
       <sfChat:SfChat x:Name="sfChat"
                Messages="{Binding Messages}"
                CurrentUser="{Binding CurrentUser}"
                ShowScrollToBottomButton="True"
                ScrollToBottomButtonTemplate="{StaticResource scrollToBottomButtonTemplate}"/>  
</ContentPage.Content>

{% endhighlight %}
{% endtabs %}