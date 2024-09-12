---
layout: post
title: Events and Commands in .NET MAUI AI Assist View Control | Syncfusion
description: Learn here all about Events and Commands support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Events and Commands in .NET MAUI AI Assist View (SfAIAssistView)

## ItemTapped Event and Command

The `SfAIAssistView` control includes a built-in event called `ItemTapped` and a command named `ItemTappedCommand`. These are triggered when a item is tapped. The tapped item and the point of interaction are accessible through the `ItemTappedEventArgs`. 

### ItemTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               ItemTapped="sfAIAssistView_ItemTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
    sfAIAssistView.ItemTapped += SfAIAssistView_ItemTapped;

    private void SfAIAssistView_ItemTapped(object sender, ItemTappedEventArgs e)
    {  
       DisplayAlert("Item", " Tapped on item :" + e.Item.Text, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### ItemTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               ItemTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(ItemTapped);
        }
        
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void ItemTapped(object obj)
        {
           var ItemTappedArgs = obj as ItemTappedEventArgs;
           DisplayAlert("Item", " Tapped on item :" + ItemTappedArgs.Text, "Ok");                  
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## ItemLongPressed Event and Command

The `SfAIAssistView` control has built-in features like the `ItemLongPressed` event and `ItemLongPressedCommand`. These are activated when a item is long-pressed. The item that was long-pressed and the point of interaction are accessible through the `ItemLongPressedEventArgs`.

### ItemLongPressed Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               ItemLongPressed="sfAIAssistView_ItemLongPressed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
    sfAIAssistView.ItemLongPressed" += SfAIAssistView_ItemLongPressed";

    private void SfAIAssistView_ItemLongPressed(object sender, ItemLongPressedEventArgs e)
    {  
       DisplayAlert("Item", " Long pressed on item :" + e.Item.Text, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### ItemLongPressed Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    
    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               ItemLongPressedCommand ="{Binding LongPressedCommand }" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> longPressedCommand;

        public ViewModel()
        {
            LongPressedCommand = new Command<object>(ItemLongPressed);
        }

        public Command<object> LongPressedCommand
        {
            get { return longPressedCommand; }
            set { longPressedCommand = value; }
        }

        private void ItemLongPressed(object obj)
        {
            var ItemLongPressedArgs = obj as ItemLongPressedEventArgs;
            DisplayAlert("Item", "LongPressed on Item :" + ItemLongPressedArgs.Item.Text, "Ok");
        }
    }  

{% endhighlight %}
{% endtabs %}

## Request Event and Command

The `SfAIAssistView` control includes a built-in event called `Request` and a command named `RequestCommand`. These are triggered when a request item is sent.

### Request Event

The Request event is fired when a request item is sent. This event can be handled to fetch response from an AI service.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               Request="sfAIAssistView_Request" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
    sfAIAssistView.Request += SfAIAssistView_sfAIAssistView_Request;

    private void SfAIAssistView_sfAIAssistView_Request(object sender, RequestEventArgs e)
    {  
       //logic for getting response from the AI
    }

{% endhighlight %}
{% endtabs %}

### Request Command

The `SfAIAssistView` control allows you to bind user requests using the `RequestCommand` as follows.

{% tabs %}
{% highlight xaml hl_lines="3" %}

   <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
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

The `SfAIAssistView` control includes a built-in command named `ItemCopyCommand`. These are triggered when a copy action is initiated for an item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
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
             //// add copy logic here
        }    
      
    }

{% endhighlight %}
{% endtabs %}


## ItemRetry Command

The `SfAIAssistView` control includes a built-in command named `ItemRetryCommand`. This is triggered when a retry action is initiated for an item.

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
            //// add retry logic here
        }    
      
    }

{% endhighlight %}
{% endtabs %}

##  ItemRatingChanged Command

The `SfAIAssistView` control includes a built-in command named `ItemRatingChangedCommand`. This command is triggered when the rating of an item changes, such as when a user switches from a `like` to a `dislike` or vice versa.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"   
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