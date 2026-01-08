---
layout: post
title: Events and Commands in .NET MAUI AI AssistView Control | Syncfusion
description: Learn here all about Events and Commands support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Events and Commands in .NET MAUI AI AssistView (SfAIAssistView)

## ItemTapped Event and Command

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control provides the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTapped) and [ItemTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTappedCommand) to respond when an item is tapped. The tapped item and its position are passed through the [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemTappedEventArgs.html). This argument provides the following details:

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

The `SfAIAssistView` control also supports the [ItemLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressed) event and [ItemLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressedCommand), which are triggered when an item is long-pressed. The [ItemLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemLongPressedEventArgs.html) argument provides the following details:

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

## Request Event and Command

The [Request](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Request) event and [RequestCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestCommand) are triggered when a request item is sent. The [RequestEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestEventArgs.html) argument provides the following details:

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
{% highlight xaml hl_lines="3" %}

   <syncfusion:SfAIAssistView x:Name="aiAssistView"
                              AssistItems="{Binding AssistItems}" 
                              RequestCommand="{Binding AssistViewRequestCommand}"/>
      
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="11" %}

 public class ViewModel : INotifyPropertyChanged
 {
     ...

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

    ....

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

## ItemRatingChanged Command

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