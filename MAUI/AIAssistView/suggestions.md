---
layout: post
title: Suggestions in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Suggestions support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Working with Suggestions in .NET MAUI AI AssistView (SfAIAssistView)

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control enables the display of a list of suggestions for users to select from. Suggestions are supported for all response item types in `SfAIAssistView`. When a user selects a suggestion, the [SuggestionItemSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelected) event and [SuggestionItemSelectedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelectedCommand) are triggered, providing [SuggestionItemSelectedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SuggestionItemSelectedEventArgs.html) as arguments. This arguments contains the following details about the selected suggestion item.

 * [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SuggestionItemSelectedEventArgs.html#Syncfusion_Maui_AIAssistView_SuggestionItemSelectedEventArgs_SelectedItem) : The suggestion item chosen by the user.
 * [RequestItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SuggestionItemSelectedEventArgs.html#Syncfusion_Maui_AIAssistView_SuggestionItemSelectedEventArgs_RequestItem) : The request item associated with the selected suggestion.
 * [CancelRequest](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SuggestionItemSelectedEventArgs.html#Syncfusion_Maui_AIAssistView_SuggestionItemSelectedEventArgs_CancelRequest) : A boolean indicating whether the selected suggestion is automatically sent. The default value is false.

## Displaying Suggestions

Suggestions are displayed by creating an instance of [AssistSuggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistSuggestion.html) and assigning it to the item's [Suggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Suggestion) property.

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
            public MainPage()
            {
              InitializeComponent();
              SfAIAssistView sfAIAssistView = new SfAIAssistView();
              SuggestionsViewModel viewModel = new SuggestionsViewModel();
              this.sfAIAssistView.AssistItems = viewModel.AssistItems;
              this.Content = sfAIAssistView;
             }
         }
    }  

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="29" %}

 public class SuggestionsViewModel : INotifyPropertyChanged
 {
    ...
	
    private ObservableCollection<ISuggestion> suggestions;

    public SuggestionsViewModel()
    {
        this.AssistItems = new ObservableCollection<object>();
    }

    private async Task GetResult(AssistItem requestItem)
    {
        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
           // response from AI service
           Text = "MAUI stands for .NET Multi-platform App UI. It's a .NET framework for building cross-platform apps with a single C# codebase for iOS, Android, macOS, and Windows. Sure! Here's a link to learn more about .NET MAUI",
        };
		
		// Generate suggestions.
		var assistSuggestions = new AssistItemSuggestion();

        suggestions = new ObservableCollection<ISuggestion>();
        suggestions.Add(new AssistSuggestion() { Text = "Get started with .NET MAUI" });
        suggestions.Add(new AssistSuggestion() { Text = "Build your first MAUI app" });

        assistSuggestions.Items = suggestions;
		
		// Assign suggestions to response item.
		responseItem.Suggestion = assistSuggestions;

        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
    }

    ...
 }

{% endhighlight %}
{% endtabs %}

### Adding an image to suggestion items

You can add an image to the suggestion item by setting the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistSuggestion.html#Syncfusion_Maui_AIAssistView_AssistSuggestion_ImageSource) property in the [AssistSuggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistSuggestion.html) object.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="19 20" %}

 public class SuggestionsViewModel : INotifyPropertyChanged
 {
    ...
	 
	private async Task GetResult(AssistItem requestItem)
    {
        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
           // response from AI service
           Text = "MAUI stands for .NET Multi-platform App UI. It's a .NET framework for building cross-platform apps with a single C# codebase for iOS, Android, macOS, and Windows. Sure! Here's a link to learn more about .NET MAUI",
        };
		
		// Generate suggestions.
		var assistSuggestions = new AssistItemSuggestion();

        suggestions = new ObservableCollection<ISuggestion>();
        suggestions.Add(new AssistSuggestion() { Text = "Get started with .NET MAUI", ImageSource = "learn_more.png" });
        suggestions.Add(new AssistSuggestion() { Text = "Build your first MAUI app", ImageSource = "get_started.png" });

        assistSuggestions.Items = suggestions;
		
		// Assign suggestions to response item.
		responseItem.Suggestion = assistSuggestions;

        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
    }

    ...

 }

{% endhighlight %}
{% endtabs %}

### Changing the orientation of suggestions

The [AssistItemSuggestion.Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItemSuggestion.html#Syncfusion_Maui_AIAssistView_AssistItemSuggestion_Orientation) property allows you to display suggestions horizontally or vertically. By, default, the orientation is vertical.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="22" %}

    ...
	...
	private async Task GetResult(AssistItem requestItem)
    {
        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
           // response from AI service
           Text = "MAUI stands for .NET Multi-platform App UI. It's a .NET framework for building cross-platform apps with a single C# codebase for iOS, Android, macOS, and Windows. Sure! Here's a link to learn more about .NET MAUI",
        };
		
		// Generate suggestions.
		var assistSuggestions = new AssistItemSuggestion();

        suggestions = new ObservableCollection<ISuggestion>();
        suggestions.Add(new AssistSuggestion() { Text = "Get started with .NET MAUI" });
        suggestions.Add(new AssistSuggestion() { Text = "Build your first MAUI app" });

        assistSuggestions.Items = suggestions;
		
		assistSuggestions.Orientation = SuggestionsOrientation.Horizontal;
		
		// Assign suggestions to response item.
		responseItem.Suggestion = assistSuggestions;

        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
    }
    ...
	...
 
{% endhighlight %}
{% endtabs %}

## Response Suggestion Customization
The `SfAIAssistView` control allows you to fully customize the appearance of the response suggestion items using the `ResponseSuggestionTemplate` property. This property lets you define a custom layout and style for the suggestion item UI.

{% tabs %}
{% highlight xaml hl_lines="11" %}

  <ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="suggestionTemplate">
                ...
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                 AssistItem = "{Binding AssistItems}"
                                 ResponseSuggestionTemplate="{StaticResource suggestionTemplate}">
      </syncfusion:SfSfAIAssistView>
</ContentPage.Content>

{% endhighlight %}

{% highlight c# hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.ResponseSuggestionTemplate = this.CreateSuggestionTemplate();
        this.Content = sfAIAssistView;
    }

    private DataTemplate CreateSuggestionTemplate()
    {
        return new DataTemplate(() =>
        {
            ...
        });
    }
}

{% endhighlight %}
{% endtabs %}

![Suggestion Template in .NET MAUI AI AssistView](Images/suggestions/maui-aiassistview-suggestiontemplate.png)

## Preventing automatic sending of selected suggestion

By default, a suggestion is automatically sent as a request item immediately when selected. To change this behavior, set [SuggestionItemSelectedEventArgs.CancelRequest](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SuggestionItemSelectedEventArgs.html#Syncfusion_Maui_AIAssistView_SuggestionItemSelectedEventArgs_CancelRequest) to `true` in the [SuggestionItemSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelected) event or [SuggestionItemSelectedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelectedCommand).

### Using SuggestionItemSelected event

{% tabs %}
{% highlight c# hl_lines="5" %}

    sfAIAssistView.SuggestionItemSelected += OnSuggestionItemSelected;
	
    private void OnSuggestionItemSelected(object sender, SuggestionItemSelectedEventArgs e)
    {
        e.CancelRequest = true;
    }

{% endhighlight %}
{% endtabs %}

### Using SuggestionItemSelectedCommand

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
