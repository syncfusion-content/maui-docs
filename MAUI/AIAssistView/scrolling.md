---
layout: post
title: Scrolling Features in .NET MAUI AI AssistView | Syncfusion®
description: Learn how to manage scrolling in the Syncfusion .NET MAUI AI AssistView (SfAIAssistView) with auto-scroll, scroll-to-bottom button, and event handling.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Work with Scrolling Features in .NET MAUI SfAIAssistView?

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control provides features to manage scrolling efficiently. It includes a scroll-to-bottom button for quick navigation, supports customization through templates, and allows control over auto-scrolling and scroll events to enhance user experience.

## Scroll to bottom button

The `SfAIAssistView` control provides an option to display a scroll-to-bottom button that helps users quickly navigate back to the latest responses when they have scrolled up in the AI conversation. To enable this, set the [ShowScrollToBottomButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowScrollToBottomButton) property to `true`. The default value is `false`, so the button is hidden unless you opt in.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ShowScrollToBottomButton="True" />

{% endhighlight %}
{% highlight c# hl_lines="9" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.ShowScrollToBottomButton = true;
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI SfAIAssistView scroll to bottom button](Images/scrolling/maui-aiassistview-scrolltobottom.gif)

### Scroll to bottom button customization

The `SfAIAssistView` control allows you to fully customize the scroll-to-bottom button appearance by using the [ScrollToBottomButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ScrollToBottomButtonTemplate) property. This property is of type `DataTemplate` and lets you define a custom layout and style.

{% tabs %}
{% highlight xaml hl_lines="29" %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="scrollToBottomButtonTemplate">
            <Border Padding="10"
                    BackgroundColor="#6C4EC2"
                    StrokeThickness="0"
                    StrokeShape="RoundRectangle 25"
                    HorizontalOptions="Center"
                    VerticalOptions="End">
                <HorizontalStackLayout Spacing="6"
                                       HorizontalOptions="Center"
                                       VerticalOptions="Center">
                    <Image Source="down.png"
                           WidthRequest="16"
                           HeightRequest="16"
                           VerticalOptions="Center" />
                    <Label Text="New Response"
                           FontSize="14"
                           TextColor="White"
                           VerticalOptions="Center" />
                </HorizontalStackLayout>
            </Border>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ShowScrollToBottomButton="True"
                           ScrollToBottomButtonTemplate="{StaticResource scrollToBottomButtonTemplate}" />

{% endhighlight %}
{% highlight c# hl_lines="11" %}

using Syncfusion.Maui.AIAssistView;
using Microsoft.Maui.Controls.Shapes;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.ShowScrollToBottomButton = true;
        sfAIAssistView.ScrollToBottomButtonTemplate = this.CreateScrollToBottomButtonTemplate();
    }

    private DataTemplate CreateScrollToBottomButtonTemplate()
    {
        return new DataTemplate(() =>
        {
            var border = new Border
            {
                Padding = new Thickness(10),
                BackgroundColor = Color.FromArgb("#6C4EC2"),
                StrokeThickness = 0,
                StrokeShape = new RoundRectangle { CornerRadius = 25 },
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            var layout = new HorizontalStackLayout
            {
                Spacing = 6,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var image = new Image
            {
                Source = "down.png",
                WidthRequest = 16,
                HeightRequest = 16,
                VerticalOptions = LayoutOptions.Center
            };

            var label = new Label
            {
                Text = "New Response",
                FontSize = 14,
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.Center
            };

            layout.Children.Add(image);
            layout.Children.Add(label);
            border.Content = layout;
            return border;
        });
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI SfAIAssistView scroll to bottom button template customization](Images/scrolling/maui-aiassistview-scrolltobottomtemplate.png)

## Auto-scroll to the bottom when new messages are added

By default, the `SfAIAssistView` control automatically scrolls to the bottom of the conversation to display newly added messages. If you want to prevent this behavior and retain the current scroll position, you can disable auto-scrolling by setting the [CanAutoScrollToBottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CanAutoScrollToBottom) property to `false`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           CanAutoScrollToBottom="False" />

{% endhighlight %}
{% highlight c# hl_lines="9" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.CanAutoScrollToBottom = false;
    }
}

{% endhighlight %}
{% endtabs %}

### Configuring auto-scroll behavior

The `SfAIAssistView` control provides the [AutoScrollBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AutoScrollBehavior) property, which determines how the view updates its scroll position when new messages or responses are added. This property is of type [AssistViewScrollBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistViewScrollBehavior.html), and its default value is `ScrollToLastResponse`.
The `AutoScrollBehavior` property supports the following scrolling modes:

- [ScrollToLastResponse](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistViewScrollBehavior.html#Syncfusion_Maui_AIAssistView_AssistViewScrollBehavior_ScrollToLastResponse) : Automatically scrolls the view to display the most recent AI response.
- [ScrollToLastRequest](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistViewScrollBehavior.html#Syncfusion_Maui_AIAssistView_AssistViewScrollBehavior_ScrollToLastRequest) : Scrolls the view to display the latest user request instead of the response.

By configuring `AutoScrollBehavior`, you can control which part of the conversation remains visible when new content is appended. For more advanced scenarios, you can combine this property with `CanAutoScrollToBottom` and handle the `Scrolled` event to fine-tune scrolling behavior based on user interaction or application logic.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AutoScrollBehavior="ScrollToLastRequest" />

{% endhighlight %}
{% highlight c# hl_lines="9" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.AutoScrollBehavior = AssistViewScrollBehavior.ScrollToLastRequest;
    }
}

{% endhighlight %}
{% endtabs %}

## Scrolled Event

The `SfAIAssistView` control comes with a built-in [Scrolled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Scrolled) event that is raised whenever the conversation view is scrolled. This event exposes its data through the [ScrolledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ScrolledEventArgs.html) class, which provides the following properties:

- [IsTopReached](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ScrolledEventArgs.html#Syncfusion_Maui_AIAssistView_ScrolledEventArgs_IsTopReached): `true` when the conversation is scrolled to the top.
- [IsBottomReached](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ScrolledEventArgs.html#Syncfusion_Maui_AIAssistView_ScrolledEventArgs_IsBottomReached): `true` when the conversation is scrolled to the bottom.

These members let you track whether the user has reached the top or bottom of the conversation view.

You can handle this event to control the auto-scroll behavior of the `SfAIAssistView`. For example, if the user manually scrolls up and is no longer at the bottom of the conversation, auto-scrolling can be disabled to prevent newly added messages from interrupting the user's reading position.

{% tabs %}
{% highlight xaml hl_lines="2"  %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           Scrolled="sfAIAssistView_Scrolled" />

{% endhighlight %}
{% highlight c# hl_lines="9" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.Scrolled += sfAIAssistView_Scrolled;
    }

    private void sfAIAssistView_Scrolled(object sender, ScrolledEventArgs e)
    {
        // Handle the Scrolled event.
    }
}

{% endhighlight %}
{% endtabs %}
