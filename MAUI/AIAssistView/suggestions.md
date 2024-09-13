---
layout: post
title: Suggestions in .NET MAUI AIAssistView control | Syncfusion
description: Learn here all about Suggestions support in Syncfusion .NET MAUI AIAssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Suggestions in .NET MAUI AIAssistView (SfAIAssistView)

The `SfAIAssistView` control allows to display a list of options, as suggestions. These suggestions are supported for all the response item types in `SfAIAssistView`. When a user selects a suggestion item, the `SuggestionItemSelected` event and `SuggestionItemSelectedCommand` will be triggered. Both the event and the command will provide the `SuggestionItemSelectedEventArgs` as arguments, providing the following information about the selected suggestion item.

* `SelectedItem` : Represents the selected suggestion item.
* `RequestItem` : Represents the request item associated with the selected suggestion.
* `CancelRequest` : Indicates whether the selected suggestion will be sent automatically or not. The default value is false.

## Showing suggestions in items

Suggestions can be shown in a item by creating a `AssistSuggestion` instance and setting it to the desired item's `Suggestion` property.

{% tabs %}
{% highlight xaml %}

  <?xml version="1.0" encoding="utf-8" ?>
  <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
               xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
               xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
               x:Class="MauiAIAssistView.MainPage">

      <ContentPage.Content>
             <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                        AssistItems="{Binding AssistItems}"/>
	  <ContentPage.Content>	
  </ContentPage>

{% endhighlight %}

{% highlight c# %}

   namespace MauiAIAssistView
   {
         public partial class MainPage : ContentPage
         {
            SfAIAssistView sfAIAssistView;
            SuggestionsViewModel viewModel;
            public MainPage()
            {
              InitializeComponent();
              this.sfAIAssistView = new SfAIAssistView();
              this.viewModel = new SuggestionsViewModel();
              this.sfAIAssistView.AssistItems = viewModel.AssistItems;
              this.Content = sfAIAssistView;
             }
         }
    }  

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="37" %}

 public class SuggestionsViewModel : INotifyPropertyChanged
 {
    ...

    /// <summary>
    /// AssistItem suggestion
    /// </summary>
    private AssistItemSuggestion assistSuggestions;

    /// <summary>
    /// collection of suggestion items
    /// </summary>
    private ObservableCollection<ISuggestion> suggestions;

    public SuggestionsViewModel()
    {
        this.AssistItems = new ObservableCollection<object>();
        
        assistSuggestions = new AssistItemSuggestion();

        suggestions = new ObservableCollection<ISuggestion>();
        suggestions.Add(new AssistSuggestion() { Text = "Get started with .NET MAUI" });
        suggestions.Add(new AssistSuggestion() { Text = "Build your first MAUI app" });

        assistSuggestions.Items = suggestions;

        this.GenerateAssistItems();
     }

    private async Task GetResult(AssistItem requestItem)
    {
        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
           // response from AI service
           Text = "MAUI stands for .NET Multi-platform App UI. It's a .NET framework for building cross-platform apps with a single C# codebase for iOS, Android, macOS, and Windows. Sure! Here's a link to learn more about .NET MAUI",
           Suggestion = assistSuggestions,
        };

        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
    }

    ...
 }

{% endhighlight %}
{% endtabs %}

### Add an image in suggestion item

In the `SfAIAssistView` control, an image can be added to the suggestion list by assigning an image source to the `ImageSource` property.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="13 14" %}
   
 public class SuggestionsViewModel : INotifyPropertyChanged
 {

    ....

    public SuggestionsViewModel()
    {
        this.AssistItems = new ObservableCollection<object>();
        
        assistSuggestions = new AssistItemSuggestion();

        suggestions = new ObservableCollection<ISuggestion>();
        suggestions.Add(new AssistSuggestion() { Text = "Get started with .NET MAUI", ImageSource = "learn_more.png" });
        suggestions.Add(new AssistSuggestion() { Text = "Build your first MAUI app", ImageSource = "get_started.png" });

        assistSuggestions.Items = suggestions;
     }

    ...

 }

{% endhighlight %}
{% endtabs %}

### Change the orientation of suggestions

The `AssistItemSuggestion.Orientation` property allows you to display suggestion items in either horizontal or vertical orientation. The default orientation is vertical.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="13" %}

    public SuggestionsViewModel()
    {
        this.AssistItems = new ObservableCollection<object>();
        
        assistSuggestions = new AssistItemSuggestion();

        suggestions = new ObservableCollection<ISuggestion>();
        suggestions.Add(new AssistSuggestion() { Text = "Get started with .NET MAUI" });
        suggestions.Add(new AssistSuggestion() { Text = "Build your first MAUI app" });

        assistSuggestions.Items = suggestions;

        assistSuggestions.Orientation = SuggestionsOrientation.Horizontal;
     }
 
 
{% endhighlight %}
{% endtabs %}


## Prevent the chosen suggestion from being sent automatically.

By default, when tapping or clicking the suggestion item, it will be sent as a request item immediately. So, to restrict this behavior and show the suggestion list in editor view, you can set the `SuggestionItemSelectedEventArgs.CancelRequest` to `true` within the `SuggestionItemSelected` event handler or the `SuggestionItemSelectedCommand` command's execution.

**SuggestionItemSelected event**

{% tabs %}
{% highlight c# hl_lines="1 10" %}

    sfAIAssistView.SuggestionItemSelected += SfAIAssistView_SuggestionItemSelected;

    /// <summary>
    /// Raised when current user has selected the suggestion option from suggestion list.
    /// </summary>
    /// <param name="sender"><see cref="SfAIAssistView"/> as sender</param>
    /// <param name="e"><see cref="SuggestionItemSelectedEventArgs"/> as parameter</param>
    private void SfAIAssistView_SuggestionItemSelected(object sender, SuggestionItemSelectedEventArgs e)
    {
        e.CancelRequest = true;
    }

{% endhighlight %}
{% endtabs %}

**SuggestionItemSelectedCommand command**

{% tabs %}
{% highlight xaml hl_lines="11" %}

 <?xml version="1.0" encoding="utf-8" ?>
 <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
              xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
              xmlns:local="clr-namespace:MauiAIAssistView"             
              x:Class="MauiAIAssistView.MainPage">

        <ContentPage.Content>
            <syncfusion:SfAIAssistView x:Name="sfAIAssistView" 
                                       AssistItems="{Binding AssistItems}"
                                       SuggestionItemSelectedCommand="{Binding SuggestionItemSelectedCommand}" />
        </ContentPage.Content>
 </ContentPage>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="28" %}

    public class SuggestionsViewModel : INotifyPropertyChanged
    {
        private ICommand suggestionItemSelectedCommand;

        public SuggestionsViewModel()
        {
            SuggestionItemSelectedCommand = new Command(ExecuteSuggestion);
        }

        /// <summary>
        /// Gets or sets the suggestion item selected command.
        /// </summary>
        public ICommand SuggestionItemSelectedCommand
        {
            get
            {
                return this.suggestionItemSelectedCommand;
            }  
            set
            {
                this.suggestionItemSelectedCommand = value;
            }
        }

        /// <summary>
        /// Executes the action when a suggestion item is selected.
        /// </summary>
        public void ExecuteSuggestion(object parameter)
        {
           var args = parameter as SuggestionItemSelectedEventArgs;
           args.CancelRequest = true;
        }
    }

{% endhighlight %}
{% endtabs %}
