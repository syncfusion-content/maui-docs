---
layout: post
title: History in .NET MAUI AI AssistView Control | Syncfusion
description: Learn here all about History support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# History in .NET MAUI AI AssistView (SfAIAssistView)

This section explains how to define and customize the history in the [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html).

## Conversation history

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control provides a `History` feature that allows you to display the conversation history from interactions with real-time AI. To disable this feature, set the `EnableConversationHistory` property to `false`.

### Binding data into conversation history

The `SfAIAssistView` control provides the `ConversationItemsSource` API to manually set the conversation history items source. This source also updates at runtime when new requests are made in the conversation. 

#### View model
Create a simple view model as shown in the following code example, and save it as `GettingStartedViewModel.cs` file.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

using Syncfusion.Maui.AIAssistView;
public class GettingStartedViewModel : INotifyPropertyChanged
{
    ...
    private ObservableCollection<AssistConversationItem> conversationItems;
    ...

    public AIAssistViewModel()
    {
        ...
        this.conversationItems = new ObservableCollection<AssistConversationItem>
        {
            new AssistConversationItem 
            { 
                Text = "Hello! How can I help you?", 
                Author = "Assistant" 
            },
            new AssistConversationItem 
            { 
                Text = "Can you explain machine learning?", 
                Author = "User" 
            }
        };
        ...
    }

    ...
    public ObservableCollection<AssistConversationItem> ConversationItems 
    { 
        get { return this.conversationItems; }
        set 
        {
            this.conversationItems = value;
            this.RaisePropertyChanged(nameof(ConversationItems));
        }
    }
    ...
}

{% endhighlight %}
{% endtabs %}

#### Binding conversation items to SfAIAssistView
To populate the conversation items, bind the item collection from its BindingContext to `SfAIAssistView.ConversationItemsSource` property.

{% tabs %}
{% highlight xaml hl_lines="15" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"            
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:GettingStartedViewModal/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                   AssistItems="{Binding AssistItems}"
                                   ConversationItemsSource="{Binding ConversationItems}"/>
    </ContentPage.Content>

</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

public partial class MainPage : ContentPage 
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems;
        this.sfAIAssistView.ConversationItemsSource = viewModel.ConversationItems;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

### Conversation header text

The `SfAIAssistView` control provides the `ConversationHeaderText` API to set the header text for the conversation view. By default, this property is set to `string.Empty`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="aiAssistView"
                     ConversationHeaderText="Chat History" />

{% endhighlight %}
{% highlight c# hl_lines="6" %}

SfAIAssistView sfAIAssistView; 
public MainPage() 
{ 
    InitializeComponent(); 
    this.sfAIAssistView = new SfAIAssistView();
    this.sfAIAssistView.ConversationHeaderText = "Chat History";
    this.Content = sfAIAssistView;
}

{% endhighlight %}
{% endtabs %}

### Conversation empty view

The `ConversationEmptyView` property can be set to a string or a custom view, which will be displayed when no conversation items are available in the control.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">

   <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                              AssistItems="{Binding AssistItems}"
                              ConversationEmptyView="No conversations available">
    </syncfusion:SfAIAssistView>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="10" %}
public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    { 
        InitializeComponent();
        sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        sfAIAssistView.AssistItems = viewModel.AssistItems;
        sfAIAssistView.ConversationEmptyView = "No conversations available";
        Content = sfAIAssistView;
   }
}

{% endhighlight %}
{% endtabs %}

## Events and commands

When a user selects a conversation item, the `ConversationItemTapped` event and `ConversationItemTappedCommand` are triggered, providing `ConversationItemTappedEventArgs ` as arguments. This arguments contains the following details about the selected suggestion item.

 * `ConversationItem` : The conversation item selected by the user.
 * `Handled` : A boolean indicating whether the selected conversation item is automatically visible in view. The default value is false.

### ConversationItemTapped event

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="aiAssistView"
                     ConversationItemTapped="OnConversationItemTapped"/>

{% endhighlight %}
{% highlight c# hl_lines="1" %}

aiAssistView.ConversationItemTapped += OnConversationItemTapped;

private void OnConversationItemTapped(object sender, ConversationItemTappedEventArgs e)
{
    // Handle the conversation item action
}

{% endhighlight %}
{% endtabs %}

### ConversationItemTappedCommand

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="aiAssistView"
                     ConversationItemTappedCommand="{Binding ConversationItemTappedCommand}"/>

{% endhighlight %}
{% highlight c# hl_lines="4,7" %}

public class AIAssistViewModel : INotifyPropertyChanged
{
    ...
    public ICommand ConversationItemTappedCommand { get; }
    ...

    public AIAssistViewModel()
    {
        ...
        this.ConversationItemTappedCommand = new Command<object>(OnConversationItemTapped);
        ...
    }

    ...
    private void OnConversationItemTapped(object obj)
    {
        // Handle the conversation item action
    }
    ...
}

{% endhighlight %}
{% endtabs %} 
