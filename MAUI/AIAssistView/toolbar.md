---
layout: post
title: Toolbar in .NET MAUI AI AssistView control | Syncfusion®
description: Learn here all about Toolbar support in Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Customize Toolbar in .NET MAUI SfAIAssistView?

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to define and customize the toolbar to tailor actions and improve user interaction within the chat interface.

## AssistView Toolbar

`SfAIAssistView` exposes a header toolbar that can be enabled and customized for conversation-level actions and titles. The toolbar will not be visible when the [ShowToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowToolbar) is set to `false`.

- **[ShowToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowToolbar)**: Set to `false` to hide the toolbar. The default value is `true`.
- **[ToolbarTitle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarTitle)**: A simple string title you can bind or set to display in the toolbar.
- **[ToolbarHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarHeight)**: Set a custom height for the toolbar area.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="1 2 3" %}

<syncfusion:SfAIAssistView ShowToolbar="True"
                           ToolbarTitle="AI AssistView"
                           ToolbarHeight="50" />

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10 11" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.ToolbarTitle = "AI AssistView";
        sfAIAssistView.ShowToolbar = true;
        sfAIAssistView.ToolbarHeight = 50;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Toolbar](Images/toolbar/maui-aiassistview-toolbar.png)

## Toolbar Menu Items

In the Syncfusion .NET MAUI AI AssistView, you can provide toolbar menu items using the [ToolbarMenuOptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarMenuOptions) collection on `SfAIAssistView`. Each item can be an [ActionButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtons) (or any suitable view) and bound to a command on your view model.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3 4" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView">
    <syncfusion:SfAIAssistView.ToolbarMenuOptions>
        <syncfusion:ActionButton Text="Settings" Icon="settings.png" Command="{Binding SettingsCommand}" />
        <syncfusion:ActionButton Text="Help" Icon="help.png" Command="{Binding HelpCommand}" />
    </syncfusion:SfAIAssistView.ToolbarMenuOptions>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% endtabs %}

The items added to [ToolbarMenuOptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarMenuOptions) appear when the toolbar menu icon is clicked. Each item invokes its bound command when tapped.

## Chat Modes

### New Chat Button

The toolbar includes a "New Chat" option. When clicked, it opens a fresh chat session so the user can start an entirely new conversation, while the previous session is preserved in the conversation history.

### Temporary Chat

The `SfAIAssistView` supports a Temporary Chat mode that provides a temporary conversation that is not saved, useful for quick, non-persistent interactions. When temporary mode is clicked, the control clears the active `AssistItems` collection and displays a banner above the chat to indicate the temporary state. The control preserves your original `EmptyViewTemplate` and restores it when temporary mode ends.

- **[EnableTemporaryChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableTemporaryChat)**: Set to `false` to disable Temporary Chat mode.

- **[TemporaryChatBannerTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TemporaryChatBannerTemplate)**: Provide a `DataTemplate` to replace the default temporary-mode banner with a custom view.
- **[TemporaryChatBannerText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TemporaryChatBannerText)**: The default banner text when no custom banner template is provided.

N> Enabling `EnableTemporaryChat` includes the temporary chat in the toolbar's new chat button. Clicking the temporary chat routes new requests to a fresh `AssistItems` collection and displays a temporary banner.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3" %}

<syncfusion:SfAIAssistView x:Name="assist"
                           EnableTemporaryChat="True"
                           TemporaryChatBannerText="This chat will not be saved" />

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.EnableTemporaryChat = true;
        sfAIAssistView.TemporaryChatBannerText = "This chat will not be saved";
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

### Events for chat mode

`SfAIAssistView` raises two events when the user changes the chat mode via the toolbar: [`ChatModeChanging`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ChatModeChanging) (raised before the change) and [`ChatModeChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ChatModeChanged) (raised after the change). Both event-args types expose a [ChatMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangedEventArgs.html#Syncfusion_Maui_AIAssistView_ChatModeChangedEventArgs_ChatMode) property indicating the mode being switched to. The `ChatMode` enumeration includes values such as `NewChat` and `TemporaryChat`.

- **`ChatModeChanging`**: Provides a [ChatModeChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangingEventArgs.html) with the [ChatMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangingEventArgs.html#Syncfusion_Maui_AIAssistView_ChatModeChangingEventArgs_ChatMode) that the control is about to transition to. Handlers can cancel the change by setting `e.Cancel = true`. The `Cancel` property is available only on this event.
- **`ChatModeChanged`**: Provides a [ChatModeChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangedEventArgs.html) with the [ChatMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangedEventArgs.html#Syncfusion_Maui_AIAssistView_ChatModeChangedEventArgs_ChatMode) that the control has transitioned to.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.ChatModeChanging += OnChatModeChanging;
        sfAIAssistView.ChatModeChanged += OnChatModeChanged;
        this.Content = sfAIAssistView;
    }

    private void OnChatModeChanging(object sender, ChatModeChangingEventArgs e)
    {
        if (e.ChatMode == ChatMode.TemporaryChat)
        {
            e.Cancel = true;
        }
    }

    private void OnChatModeChanged(object sender, ChatModeChangedEventArgs e)
    {
        if (e.ChatMode == ChatMode.TemporaryChat)
        {
            // Temporary chat is active: show custom banner or reset local state.
        }
        else
        {
            // Any other chat mode (for example, NewChat): restore saved templates/state if needed.
        }
    }
}

{% endhighlight %}
{% endtabs %}
