---
layout: post
title: Events and Commands in .NET MAUI AI AssistView Control | Syncfusion®
description: Learn here all about Events and Commands support in Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Use Events and Commands in .NET MAUI SfAIAssistView?

Events and commands in the [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) enable handling user interactions and executing actions, allowing you to customize and control chat behavior effectively.

## ItemTapped Event and Command

The `SfAIAssistView` control provides the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTapped) and [ItemTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTappedCommand) to respond when an item is tapped. The tapped item and its position are passed through the [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemTappedEventArgs.html). This argument provides the following details:

 * [Item](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemTappedEventArgs.html#Syncfusion_Maui_AIAssistView_ItemTappedEventArgs_Item) : The tapped item within AI AssistView.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemTappedEventArgs.html#Syncfusion_Maui_AIAssistView_ItemTappedEventArgs_Position) : The touch position when the item was tapped.

### ItemTapped Event

The following example demonstrates how to handle the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTapped) event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"
                               ItemTapped="OnAssistViewItemTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAssistViewItemTapped(object sender, ItemTappedEventArgs e)
    {  
       DisplayAlert("Item", " Tapped on item :" + e.Item.Text, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### ItemTapped Command

To handle the tap action using commands (MVVM), bind the [ItemTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTappedCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"  
                               ItemTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(ExecuteItemTappedCommand);
        }
        
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void ExecuteItemTappedCommand(object obj)
        {
           var ItemTappedArgs = obj as ItemTappedEventArgs;
           DisplayAlert("Item", " Tapped on item :" + ItemTappedArgs.Text, "Ok");                  
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## ItemLongPressed Event and Command

The `SfAIAssistView` control also supports the [ItemLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressed) event and [ItemLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressedCommand), which are triggered when item is long-pressed. The [ItemLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemLongPressedEventArgs.html) argument provides the following details:

 * [Item](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemLongPressedEventArgs.html#Syncfusion_Maui_AIAssistView_ItemLongPressedEventArgs_Item) : The item that was long-pressed.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemLongPressedEventArgs.html#Syncfusion_Maui_AIAssistView_ItemLongPressedEventArgs_Position) : The touch position of the long press.

### ItemLongPressed Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"
                               ItemLongPressed="OnAssistViewItemLongPressed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAssistViewItemLongPressed(object sender, ItemLongPressedEventArgs e)
    {  
       DisplayAlert("Item", " Long pressed on item :" + e.Item.Text, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### ItemLongPressed Command

To handle the long-press action using commands (MVVM), bind the [ItemLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressedCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"
                               ItemLongPressedCommand ="{Binding LongPressedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> longPressedCommand;

        public ViewModel()
        {
            LongPressedCommand = new Command<object>(ExecuteItemLongPressedCommand);
        }

        public Command<object> LongPressedCommand
        {
            get { return longPressedCommand; }
            set { longPressedCommand = value; }
        }

        private void ExecuteItemLongPressedCommand(object obj)
        {
            var ItemLongPressedArgs = obj as ItemLongPressedEventArgs;
            DisplayAlert("Item", "LongPressed on Item :" + ItemLongPressedArgs.Item.Text, "Ok");
        }
    }  

{% endhighlight %}
{% endtabs %}

## ImageTapped Event and Command

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control provides built-in support for handling image interactions through the [ImageTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ImageTapped) event and the [ImageTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ImageTappedCommand).
These are triggered whenever a user taps on an image within the control. The tapped image item is accessible through the [ImageTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ImageTappedEventArgs.html), which includes the following member:

 * [ImageItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ImageTappedEventArgs.html#Syncfusion_Maui_AIAssistView_ImageTappedEventArgs_ImageItem) : Refers to the tapped image item.

### ImageTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               ImageTapped="sfAIAssistView_ImageTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    sfAIAssistView.ImageTapped += SfAIAssistView_ImageTapped;

    private void SfAIAssistView_ImageTapped(object sender, ImageTappedEventArgs e)
    {  
       DisplayAlert("Image", " Tapped on image :" + e.ImageItem.Source, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### ImageTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               ImageTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(ImageTapped);
        }
        
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void ImageTapped(object obj)
        {
           var ImageTappedArgs = obj as ImageTappedEventArgs;
           DisplayAlert("Image", " Tapped on Image item :" + ImageTappedArgs.ImageItem.Source, "Ok");                  
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## CardTapped Event and Command

 The `SfAIAssistView` control provides built-in support for handling card interactions through the [CardTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTapped) event and the [CardTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTappedCommand). These are triggered whenever a user taps on a card within the control. The tapped card item is accessible through the [CardTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html), which includes the following members:

 * [Card](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_Card) : Represents the selected card from the card collection.
 * [Action](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_Action) : Holds the information about the selected action when a user taps a button on a card.
 * [CardItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_CardItem) : Refers to the current assist view card item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_Handled) : Indicates whether the event is handled or not.

### CardTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               CardTapped="sfAIAssistView_CardTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    sfAIAssistView.CardTapped += SfAIAssistView_CardTapped;

    private void SfAIAssistView_CardTapped(object sender, CardTappedEventArgs e)
    {  
       DisplayAlert("Card", " Tapped on card :" + e.Card.Title, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### CardTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               CardTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(CardTapped);
        }
        
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void CardTapped(object obj)
        {
           var CardTappedArgs = obj as CardTappedEventArgs;
           DisplayAlert("Card", " Tapped on Card item :" + CardTappedArgs.Card.Title, "Ok");                  
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## AttachmentTapped Event and Command

The `SfAIAssistView` control provides built-in support for handling attachment interactions through the [AttachmentTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTapped) event and the [AttachmentTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTappedCommand). These are triggered whenever a user taps on an attachment in the preview.
The tapped attachment item is accessible through the [AttachmentTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AttachmentTappedEventArgs.html), which includes the following member:
 * [Attachment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AttachmentTappedEventArgs.html#Syncfusion_Maui_AIAssistView_AttachmentTappedEventArgs_Attachment) : Refers to the tapped attachment item.

### AttachmentTapped Event

The [AttachmentTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTapped) event is triggered when a preview attachment item is tapped.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               AttachmentTapped="sfAIAssistView_AttachmentTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    SfAIAsssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.AttachmentTapped += SfAIAssistView_AttachmentTapped;

    private void SfAIAssistView_AttachmentTapped(object sender, AttachmentTappedEventArgs e)
    {  
        DisplayAlert("Attachment", " Tapped on attachment :" + e.Attachment.FileName, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### AttachmentTapped Command

The [AttachmentTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTappedCommand) is triggered when a preview attachment item is tapped.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               AttachmentTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(AttachmentTapped);
        }
    
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void AttachmentTapped(object obj)
        {
            var AttachmentTappedArgs = obj as AttachmentTappedEventArgs;
            DisplayAlert("Attachment", " Tapped on Attachment item :" + AttachmentTappedArgs.Attachment.FileName, "Ok");                  
        }      
    }

{% endhighlight %}
{% endtabs %}

## Request Event and Command

The [Request](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Request) event and [RequestCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestCommand) are triggered when a request item is sent. The [RequestEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestEventArgs.html) arguments provides the following details:

 * [RequestItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestEventArgs.html#Syncfusion_Maui_AIAssistView_RequestEventArgs_RequestItem) : Represents the item requested.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestEventArgs.html#Syncfusion_Maui_AIAssistView_RequestEventArgs_Handled) : Indicates whether the request has been handled.
 
### Request Event

The [Request](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Request) event is triggered when a request item is sent. This event can be handled to fetch response from an AI service.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"
                               Request="OnAssistViewRequest" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAssistViewRequest(object sender, RequestEventArgs e)
    {  
       // Add your code for getting response from the AI.
    }

{% endhighlight %}
{% endtabs %}

### Request Command

To handle the request action using commands (MVVM), bind the [RequestCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestCommand).

{% tabs %}
{% highlight xaml hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"
                               RequestCommand="{Binding AssistViewRequestCommand}"/>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="6" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            this.assistItems = new ObservableCollection<object>();
            this.AssistViewRequestCommand = new Command<object>(ExecuteRequestCommand);
        }

        private async void ExecuteRequestCommand(object obj)
        {
            var request = (obj as Syncfusion.Maui.AIAssistView.RequestEventArgs).RequestItem;
            //logic for getting response from the AI
        }
    }

{% endhighlight %}
{% endtabs %}

## ItemCopy Command

The [ItemCopyCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemCopyCommand) is executed when user clicks on the copy action icon in a response item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="aiAssistView"  
                               ItemCopyCommand="{Binding CopyCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> copyCommand;

        public ViewModel()
        {
            CopyCommand = new Command<object>(ExecuteCopyCommand);
        }
        
        public Command<object> CopyCommand
        {
            get { return copyCommand; }
            set { copyCommand = value; }
        }

        private void ExecuteCopyCommand(object obj)
        {
             // add copy logic here
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## ItemRetry Command

The [ItemRetryCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemRetryCommand) is executed when user clicks on the retry action icon in a response item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               ItemRetryCommand="{Binding RetryCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> retryCommand;

        public ViewModel()
        {
            RetryCommand = new Command<object>(ExecuteRetryCommand);
        }
        
        public Command<object> RetryCommand
        {
            get { return retryCommand; }
            set { retryCommand = value; }
        }

        private void ExecuteRetryCommand(object obj)
        {
            // add retry logic here
        }    
      
    }

{% endhighlight %}
{% endtabs %}

##  ItemRatingChanged Command

The [ItemRatingChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemRatingChangedCommand) is executed whenever a user changes the rating of a response item. This typically occurs when a user performs an action like liking or disliking the item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="aiAssistView"   
                               ItemRatingChangedCommand="{Binding RatingChangedCommand}" />

{% endhighlight %}                                  
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> ratingChangedCommand;

        public ViewModel()
        {
            RatingChangedCommand = new Command<object>(ExecuteRatingChangedCommand);
        }
        
        public Command<object> RatingChangedCommand
        {
            get { return ratingChangedCommand; }
            set { ratingChangedCommand = value; }
        }

        private void ExecuteRatingChangedCommand(object obj)
        {
            DisplayAlert("Rating", "Rating changed", "Ok");                              
        }    
      
    }

{% endhighlight %}
{% endtabs %}

### StopResponding Event and Command

The `SfAIAssistView` control includes a built-in event called [StopResponding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopResponding) and a command named [StopRespondingCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingCommand). These are triggered when the `Stop Responding` button is clicked.
To cancel the response using the `StopRespondingCommand` or `StopResponding` event, you can include logic to stop the ongoing response as shown below. 

#### StopResponding Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               StopResponding="OnStopResponding" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.StopResponding += OnStopResponding;

    private void OnStopResponding(object sender, EventArgs e)
    {
       // Handle the Stop Responding action
    }

{% endhighlight %}
{% endtabs %}

#### StopResponding Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               StopRespondingCommand="{Binding StopRespondingCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

    public class ViewModel : INotifyPropertyChanged
    {
         public ICommand StopRespondingCommand { get; set; }

        public ViewModel()
        {
            AssistViewRequestCommand = new Command(ExecuteRequestCommand);
            StopRespondingCommand = new Command(ExecuteStopResponding);
        }

        private void ExecuteStopResponding()
        {
            // logic to handle the Stop Responding action
            this.CancelResponse = true;
            AssistItem responseItem = new AssistItem() { Text = "You canceled the response" };
            responseItem.ShowAssistItemFooter = false;
            this.AssistItems.Add(responseItem);
        } 
        
        private void ExecuteRequestCommand()
        {
            this.GetResult();
        }

        private void GetResult()
        {
            if (!CancelResponse)
            {
                // generating the response if it has not been canceled.
            }  
        }      
    }

{% endhighlight %}
{% endtabs %}

![Stop Responding in .NET MAUI AI AssistView](Images/inputview/maui-aiassistview-stopresponding.gif)

N> [View sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-aiassistview)

## Conversation Events and Commands

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
{% highlight c# hl_lines="7,10" %}

public class AIAssistViewModel : INotifyPropertyChanged
{
    public ICommand ConversationItemTappedCommand { get; }

    public AIAssistViewModel()
    {
        this.ConversationItemTappedCommand = new Command<object>(OnConversationItemTapped);
    }

    private void OnConversationItemTapped(object obj)
    {
        // Handle the conversation item action
    }
}

{% endhighlight %}
{% endtabs %}

## ContextMenuOpening Event

The [ContextMenuOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextMenuOpening) event is triggered before the context menu is displayed. The [ContextMenuOpeningEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ContextMenuOpeningEventArgs.html) provide the following details:

- [ContextMenuItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ContextMenuOpeningEventArgs.html#Syncfusion_Maui_AIAssistView_ContextMenuOpeningEventArgs_ContextMenuItems) : Represents the collection of menu items that will be displayed. You can modify this list (add or remove items) dynamically before the menu appears.
- `Cancel` : Indicates whether the context menu opening should be canceled. Set this property to true to prevent the menu from being shown.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ContextMenuOpening="OnContextMenuOpening">
</syncfusion:SfAIAssistView>
{% endhighlight %}
{% highlight c# %}

private void OnContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
{
   // Allows customizing or canceling the context menu before it is displayed
}

{% endhighlight %}
{% endtabs %}
