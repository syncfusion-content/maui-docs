---
layout: post
title: .NET MAUI AI AssistView Conversation History | Syncfusion®
description: Learn how to manage conversation history in the Syncfusion® .NET MAUI AI AssistView control using AssistItems to store and display chat interactions.
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
{% highlight xaml hl_lines="3" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}"
                           ConversationItemsSource="{Binding ConversationItems}"/>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    GettingStartedViewModel viewModel = new GettingStartedViewModel();
    this.sfAIAssistView.AssistItems = viewModel.AssistItems;
    this.sfAIAssistView.ConversationItemsSource = viewModel.ConversationItems;

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
{% highlight xaml hl_lines="3" %}

   <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                              AssistItems="{Binding AssistItems}"
                              ConversationEmptyView="No conversations available">
    </syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

 SfAIAssistView sfAIAssistView = new SfAIAssistView();
 GettingStartedViewModel viewModel = new GettingStartedViewModel();
 sfAIAssistView.AssistItems = viewModel.AssistItems;
 sfAIAssistView.ConversationEmptyView = "No conversations available";

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Conversation Empty View](Images/history/maui-aiassistview-conversation-custom-empty-view.png)


