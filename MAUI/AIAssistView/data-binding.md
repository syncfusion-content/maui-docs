---
layout: post
title: Data Binding in .NET MAUI AI AssistView Control | Syncfusion
description: Learn here all about Data Binding support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Data Binding in .NET MAUI AI AssistView (SfAIAssistView)

## Generate the assist request & response items

To add an [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) to the `ViewModel.AssistItems` collection with specific values for profile details, text, and the [IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested) property, follow the steps below:

1. Start by creating an instance of the [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) class. This item will represent either a user request or a response received from the AI service.

2. The Assist item has the following members, which provides information for the request/response items,

   * [Profile](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Profile): Provides information for the user details.
   * [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Text): Describes the text content of the assist item (e.g., the request text from the user or the response text from the AI).
   * [IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested): When the assist item represents a user request, set the `IsRequested` property to `True`. If it's a response item from the AI service, set `IsRequested` to `False`.
   * [DateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_DateTime): To display item created or received time.
   * [RequestItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_RequestItem): Used to hold data (request item) associated with response item. Default value is `null`.

3. After setting the properties, add the `AssistItem` instance to the `ViewModel.AssistItems` collection, which binds to the `SfAIAssistView.AssistItems` property.

N> The [IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested) property is automatically set to `True`, indicating it is a request from the user. If you want to manually add a request item through code, ensure you explicitly set the `IsRequested` property to `True`. 
Additionally, use the [CurrentUser](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CurrentUser) property to specify the requester in the `SfAIAssistView`.

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

N> The `SfAIAssistView.AssistItems` property is of type `IList<IAssistItem>`. To ensure the [AssistItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems) property functions correctly, it is recommended to use a collection property in the ViewModel with the same type, such as `ObservableCollection<IAssistItem>`.

## Binding Custom Model Collection
 
The `SfAIAssistView` control provides support for binding a custom model collection through the `ItemsSource` property. This feature allows users to use their own data models with the control.The ItemsSource property binds a collection of custom data objects to the SfAIAssistView. Each item in the collection is converted to an AssistItem and displayed in the view.The `ItemsSourceConverter` property sets the converter used to transform data objects into AssistItems and vice versa.
 
{% tabs %}
{% highlight xaml hl_lines="16 17" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:MauiAssistView"
             x:Class="MauiAssistView.MainPage">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:AssistItemConverter x:Key="Converter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <syncfusion:SfAIAssistView x:Name="assistView"
                               RequestCommand="{Binding AssistViewRequestCommand}"
                               ItemsSource="{Binding AssistItemsCollection}"
                               ItemsSourceConverter="{Binding Converter}" />
</ContentPage>
{% endhighlight %}
 
{% highlight c# hl_lines="12" %}
SfAIAssistView assistView;
ViewModel viewModel;
AssistItemConverter assistItemConverter;

public MainPage()
{
    InitializeComponent();

    assistView = new SfAIAssistView();
    viewModel = new ViewModel();
    assistItemConverter = new AssistItemConverter();
    assistView.RequestCommand = viewModel.AssistViewRequestCommand;

    assistView.ItemsSource = viewModel.AssistItems;
    assistView.ItemsSourceConverter = assistItemConverter;

    Content = assistView;
}
{% endhighlight %}
{% endtabs %}

Create the below collection of objects that must be converted to assist items collection and displayed as items in SfAIAssistView.

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}

    public class ItemModel
    {
        public ItemModel()
        {
        }

       public string Text { get; set; }
       public bool IsRequested {  get; set; }

    }
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

    public class ViewModel : INotifyPropertyChanged
    {
        ObservableCollection<ItemModel> assistItemsCollection;

        public ICommand AssistViewRequestCommand { get; set; }

        public ViewModel()
        {
            assistItemsCollection = new ObservableCollection<ItemModel>();
            this.AssistViewRequestCommand = new Command<object>(ExecuteRequestCommand);
            this.GenerateItems();
        }

        public ObservableCollection<ItemModel> AssistItemsCollection
        {
            get
            {
                return assistItemsCollection;
            }

            set
            {
                assistItemsCollection = value;
                RaisePropertyChanged(nameof(AssistItemsCollection));            
            }
        }

        private void GenerateItems()
        {
            assistItemsCollection.Add(new ItemModel()
            {
                Text = "What is .NET MAUI?", 
                IsRequested = true,
            });
        }

        private async void ExecuteRequestCommand(object obj)
        {
            var request = (obj as RequestEventArgs).RequestItem;
            await this.GetResult(request).ConfigureAwait(true);
        }

        private async Task GetResult(object inputQuery)
        {
            await Task.Delay(2000).ConfigureAwait(true);
            this.assistItemsCollection.Add(new ItemModel()
            {
                Text = "Sure! MAUI stands for .NET Multi-platform App UI. It’s a framework that allows you to create cross-platform applications using a single codebase.This powerful framework is an evolution of Xamarin.Forms .",
                IsRequested = false,
            });
        }
    }
{% endhighlight %}
{% endtabs %}
 
This converter must implement the `IAssistItemConverter` interface. Implement this interface to create a custom converter for the ItemsSourceConverter property.
 
{% tabs %}
{% highlight c# hl_lines="1" %}
public class AssistItemConverter : IAssistItemConverter
{
    public IAssistItem ConvertToAssistItem(object data, SfAIAssistView assistView)
    {
        // Convert custom message object to AssistItem
        var item = data as ItemModel;
        var assistItem = new AssistItem();
 
        assistItem.Text = item.Text;
        assistItem.Data = item;      
        assistItem.IsRequested = item.IsRequested;
        return assistItem;
    }
 
    public object ConvertToData(object item, SfAIAssistView assistView)
    {
        var item = new ItemModel();
        var assistItem = item as AssistItem;
 
        item.Text = assistItem.Text;
        item.IsRequested = assistItem.IsRequested;
        return item;
    }
}
{% endhighlight %}
{% endtabs %}
 
 
N> The `Data` property stores the original data object in the AssistItem, which maintains a reference to the custom data model which is used for data operations.

## Bind the RequestCommand property

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to handle user requests by binding them to the [RequestCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestCommand) property. This command is triggered whenever the user sends a request in the assist view.

{% tabs %}
{% highlight xaml hl_lines="15" %}
    
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
                xmlns:local="clr-namespace:MauiAIAssistView.ViewModel"
                x:Class="MauiAIAssistView.MainPage">

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<ContentPage.Content>
    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
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
