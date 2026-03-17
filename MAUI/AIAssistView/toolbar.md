---
layout: post
title: Toolbar in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Toolbar support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Toolbar in .NET MAUI AI AssistView (SfAIAssistView)

This section explains how to define and customize the toolbar in the [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html).

## AssistView Toolbar

`SfAIAssistView` exposes a header toolbar that can be enabled and customized for conversation-level actions and titles. The toolbar will be visible when the `ShowToolbar` is set to `true`.

Key properties and APIs
- **`ShowToolbar`**: Set to `false` to hide the toolbar. The default value is `true`.
- **`ToolbarTitle`**: A simple string title you can bind or set to display in the toolbar.
- **`ToolbarHeight`**: Set a custom height for the toolbar area.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2,3,4" %}
    <syncfusion:SfAIAssistView 
                ShowToolbar="True" 
                ToolbarTitle="AI AssistView" 
                ToolbarHeight="50">
    </syncfusion:SfAIAssistView>
{% endhighlight %}

{% highlight c# hl_lines="6,7,8" %}

    SfAIAssistView sfAIAssistView; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.ToolbarTitle = "AI AssistView";
        this.sfAIAssistView.ShowToolbar = true;
        this.sfAIAssistView.ToolbarHeight = 50;
        this.Content = sfAIAssistView; 
     }

{% endhighlight %}
{% endtabs %}

## Temporary Chat (Temporary Mode)

The `SfAIAssistView` supports a Temporary Chat mode that provides an ephemeral conversation surface for quick, non-persistent interactions. When temporary mode is Clicked, the control clears the active `AssistItems` collection and displays a banner above the chat to indicate the temporary state. The control preserves your original `EmptyViewTemplate` and restores it when temporary mode ends.

- **`EnableTemporaryChat`**: Set to `true` to enable Temporary Chat mode; set to `false` to disable.
- **`TemporaryChatBannerTemplate`**: Provide a `DataTemplate` to replace the default temporary-mode banner with a custom view.
- **`TemporaryChatBannerText`**: The default banner text when no custom banner template is provided.

N> Enabling `EnableTemporaryChat` includes the temporary chat in the toolbar's new chat Button. Clicking the temporary chat routes new requests to a fresh `AssistItems` collection and displays a temporary banner.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAIAssistView x:Name="assist"
                           EnableTemporaryChat="True"
                           TemporaryChatBannerText="This chat will not be saved" />
{% endhighlight %}

{% highlight c# %}

    public partial class MainPage : ContentPage
    {
        SfAIAssistView sfAIAssistView;
        public MainPage()
        {
            InitializeComponent();
            sfAIAssistView = new SfAIAssistView();
            sfAIAssistView.EnableTemporaryChat = true;
            sfAIAssistView.TemporaryChatBannerText="This chat will not be saved"
            this.Content = sfAIAssistView;
        }
    }

{% endhighlight %}
{% endtabs %}