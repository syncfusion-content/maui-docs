---
layout: post
title: History in .NET MAUI AI AssistView Control | Syncfusion®
description: Learn here all about History support in Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Work with Conversation History in .NET MAUI SfAIAssistView?

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) enables managing conversation history by using AssistItems to store, display, and track chat interactions effectively.

## Conversation history

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control provides a `History` feature that allows you to display the conversation history from interactions with real-time AI. To disable this feature, set the [EnableConversationHistory](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableConversationHistory) property to `false`.

### Binding data into conversation history

The `SfAIAssistView` control provides the [ConversationItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemsSource) API to manually set the conversation history items source. This source also updates at runtime when new requests are made in the conversation.

#### Define the view model

Create a simple view model as shown in the following code example, and save it as `GettingStartedViewModel.cs` file.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

    using Syncfusion.Maui.AIAssistView;
    public class GettingStartedViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<AssistConversationItem> conversationItems;
    
        public AIAssistViewModel()
        {
            this.conversationItems = new ObservableCollection<AssistConversationItem>();
            this.InitializeConversationHistory();
        }

        public ObservableCollection<AssistConversationItem> ConversationItems 
        { 
            get { return this.conversationItems; }
            set 
            {
                this.conversationItems = value;
                this.RaisePropertyChanged(nameof(ConversationItems));
            }
        }

        public void InitializeConversationHistory()
        {
            DateTime baseTime = DateTime.Now;

            string[] topics = new string[]
            {
                "listening",
                "Hey AI, can you tell me what Maui is?",
            };

            string[] responses = new string[]
            {
                "Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
                "MAUI stands for .NET Multi-platform APP UI. It's is a framework that allowws you to create cross-platform applications using a single codebase.",
            };

            for (int i = 0; i < 2; i++)
            {
                var dateTime = baseTime.AddDays(-i);
                var request = new AssistItem
                {
                    Text = topics[i],
                    IsRequested = true,
                    DateTime = dateTime,
                };

                var response = new AssistItem
                {
                    Text = responses[i],
                    IsRequested = false,
                    DateTime = dateTime,
                    RequestItem = request,
                };

                var title = topics[i];
                var conversationItem = new AssistConversationItem
                {
                    Title = title,
                    DateTime = baseTime.AddDays(-i),
                    AssistItems = new ObservableCollection<IAssistItem>
                    {
                        request,
                        response,
                    }
                };

                this.ConversationItems.Add(conversationItem);
            }
        }
    }

{% endhighlight %}
{% endtabs %}

#### Binding conversation items to SfAIAssistView
To populate the conversation items, bind the item collection from its BindingContext to `SfAIAssistView.ConversationItemsSource` property.

{% tabs %}
{% highlight xaml hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               ConversationItemsSource="{Binding ConversationItems}"/>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.ConversationItemsSource = viewModel.ConversationItems;

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView History](Images/history/maui-aiassistview-conversation-history.gif)

### Customizing conversation header text in SfAIAssistView 

The `SfAIAssistView` control provides the [ConversationHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationHeaderText) API to set the header text for the conversation view. By default, this property is set to `string.Empty`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"
                               ConversationHeaderText="Chat History" />

{% endhighlight %}
{% highlight c# hl_lines="2" %}

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.ConversationHeaderText = "Chat History";

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Conversation Header Text](Images/history/maui-aiassistview-conversation-header-text.png)

### Customizing the empty conversation view

The [ConversationEmptyView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationEmptyView) property can be set to a string or a custom view, which will be displayed when no conversation items are available in the control.

{% tabs %}
{% highlight xaml hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               ConversationEmptyView="No conversations available"/>

{% endhighlight %}
{% highlight c# hl_lines="2" %}

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.ConversationEmptyView = "No conversations available";

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Conversation Empty View](Images/history/maui-aiassistview-conversation-custom-empty-view.png)

### Filter Conversations by Date Range

The Filter button allows users to narrow down conversation results by selecting a specific date range. This helps quickly locate relevant conversations within the history.

The following date-range options are available:

- All
- Today
- Yesterday
- Last 7 Days
- Last 30 Days

Use these options to quickly narrow the conversation history shown in the drawer.

### Conversation Actions Menu

Each conversation item shows a More option that opens a small menu with three actions:

- **Pin**: Pins the selected conversation so it appears at the top of the conversation list.
- **Rename**: Opens a rename popup containing an editor where you can change the conversation title. The popup has two actions: **Rename** (save) and **Cancel** (exit without saving). When **Rename** is clicked, the conversation item's title is updated with the entered text.
- **Delete**: Opens a delete confirmation popup with two actions: **Delete** and **Cancel**. When **Delete** is clicked the selected conversation item is removed from the conversation history.

## Events and commands

When a user selects a conversation item, the [ConversationItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemTapped) event and [ConversationItemTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemTappedCommand) are triggered, providing [ConversationItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ConversationItemTappedEventArgs.html) as arguments. This arguments contains the following details about the selected suggestion item.

 * [ConversationItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ConversationItemTappedEventArgs.html#Syncfusion_Maui_AIAssistView_ConversationItemTappedEventArgs_ConversationItem) : The conversation item selected by the user.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ConversationItemTappedEventArgs.html#Syncfusion_Maui_AIAssistView_ConversationItemTappedEventArgs_Handled) : A boolean indicating whether the selected conversation item is automatically visible in view. The default value is false.

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
