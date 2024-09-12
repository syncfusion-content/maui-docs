---
layout: post
title: Data Binding in .NET MAUI AI Assist View Control | Syncfusion
description: Learn here all about Data Binding support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Data Binding in .NET MAUI AI Assist View (SfAIAssistView)

## Generate the assist request & response items

To add an `AssistItem` to the `ViewModel.AssistItems` collection with specific values for profile details, text, and the `IsRequest` property, follow the steps below:

1. Start by creating an instance of the `AssistItem` class. This item will represent either a user request or a response received from the AI service.

2. The Assist item has the following members, which provides information for the request/response items,

* `Profile`: Provides information for the user details.
* `Text`: Describes the text content of the assist item (e.g., the request text from the user or the response text from the AI).
* `IsRequested`: When the assist item represents a user request, set the `IsRequested` property to `True`. If it's a response item from the AI service, set `IsRequested` to `False`.
* `DateTime`: To display item created or received time.
* `RequestItem`: Used to hold data (request item) associated with response item. Default value is `null`.

3. After setting the properties, add the `AssistItem` instance to the `ViewModel.AssistItems` collection, which binds to the `SfAIAssistView.AssistItems` property.

N> The `IsRequested` property is automatically set to `True`, indicating it is a request from the user. If you want to manually add a request item through code, ensure you explicitly set the `IsRequested` property to `True`.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel : INotifyPropertyChanged
{
    . . .

    public ObservableCollection<IAssistItem> AssistItems
    {
        get
        {
            return this.assistItems;
        }

        set
        {
            this.assistItems = value;
            RaisePropertyChanged("AssistItems");
        }
    }

    public ICommand AssistViewRequestCommand { get; set; }

    public ViewModel()
    {
        this.assistItems = new ObservableCollection<IAssistItem>();
        this.AssistViewRequestCommand = new Command<object>(ExecuteRequestCommand);
    }

    private async void ExecuteRequestCommand(object obj)
    {
        var request = (obj as Syncfusion.Maui.AIAssistView.RequestEventArgs).RequestItem;
        await this.GetResult(request).ConfigureAwait(true);
    }

    private async Task GetResult(object inputQuery)
    {
        await Task.Delay(1000).ConfigureAwait(true);
        AssistItem request = (AssistItem)inputQuery;
        if (request != null)
        {
            // Generating response from AI

            var userAIPrompt = this.GetUserAIPrompt(request.Text);
            var response = await azureAIService!.GetResultsFromAI(request.Text, userAIPrompt).ConfigureAwait(true);

            // Creating response item using response received from AI

            AssistItem responseItem = new AssistItem() { Text = response };
            responseItem.RequestItem = inputQuery;

            this.AssistItems.Add(responseItem);
        }
    }
    ...
}

{% endhighlight %}
{% endtabs %}

N> The data type of AssistItems is IList<IAssistItem>. Use IAssistItem in the collection for binding, instead of a generic object type.

## Bind the RequestCommand property
The `SfAIAssistView` control allows you to handle user requests by binding them to the `RequestCommand` property. This command is triggered whenever the user sends a request in the assist view.

{% tabs %}
{% highlight xaml hl_lines="15" %}
    
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfAIAssistView="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
                xmlns:local="clr-namespace:MauiAIAssistView.ViewModel"
                x:Class="MauiAIAssistView.MainPage">

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<ContentPage.Content>
    <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                   AssistItems="{Binding AssistItems}" 
                                   RequestCommand="{Binding AssistViewRequestCommand}"/>
</ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="16" %}
    
using MauiAIAssistView.ViewModel;
using Syncfusion.Maui.SfAIAssistView;

namespace MauiAIAssistView
{
    public partial class MainPage : ContentPage
    {
        SfAIAssistView sfAIAssistView;
        ViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            sfAIAssistView = new SfAIAssistView();
            viewModel = new ViewModel();
            this.sfAIAssistView.AssistItems = viewModel.AssistItems;
            sfAIAssistView.SetBinding(SfAIAssistView.RequestCommandProperty, new Binding("AssistViewRequestCommand"));
            this.Content = sfAIAssistView;
        }       
    }
}
{% endhighlight %}
{% endtabs %}
