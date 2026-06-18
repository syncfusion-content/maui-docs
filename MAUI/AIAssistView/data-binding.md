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

To add an [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) to the `ViewModel.AssistItems` collection with specific values for profile details, textass, and the [IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested) property, follow the steps below:

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

## Binding custom model collection
 
The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control provides support for binding collection of custom data objects through the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemsSource) property. This feature allows users to use their own data objects with the control. The `ItemsSource` property binds a collection of custom data objects to the `SfAIAssistView` and each item in the collection will be converted to an `AssistItem` and displayed in the view. The [ItemsSourceConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemsSourceConverter) property sets the converter used to transform data objects into assist items and vice versa.
 
{% tabs %}
{% highlight xaml hl_lines="15 16" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:MauiAssistView"
             x:Class="MauiAssistView.MainPage">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:AssistItemConverter x:Key="converter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <syncfusion:SfAIAssistView x:Name="assistView"
                               ItemsSource="{Binding AssistItemsCollection}"
                               ItemsSourceConverter="{Binding converter}" />
</ContentPage>
{% endhighlight %}
 
{% highlight c# hl_lines="12 13" %}
SfAIAssistView assistView;
ViewModel viewModel;
AssistItemConverter assistItemConverter;

public MainPage()
{
    InitializeComponent();

    assistView = new SfAIAssistView();
    viewModel = new ViewModel();
    assistItemConverter = new AssistItemConverter();
    assistView.ItemsSource = viewModel.AssistItems;
    assistView.ItemsSourceConverter = assistItemConverter;

    Content = assistView;
}

{% endhighlight %}
{% endtabs %}

Create the below collection of objects that must be converted to assist items collection and displayed as items in `SfAIAssistView`.

{% tabs %}
{% highlight c# tabtitle="Model.cs" %}

    public class ItemModel : INotifyPropertyChanged
    {
        private string? prompt;
        private string? response;
        private object? promptItem;
        private bool isRequested;

        public string? Prompt
        {
            get { return prompt; }
            set
            {
                prompt = value;
                RaisePropertyChanged(nameof(Prompt));
            }
        }

        public string? Response
        {
            get { return response; }
            set
            {
                response = value;
                RaisePropertyChanged(nameof(Response));
            }
        }

        public bool IsRequested
        {
            get { return isRequested; }
            set
            {
                isRequested = value;
                RaisePropertyChanged(nameof(IsRequested));
            }
        }

        public object? PromptItem
        {
            get { return promptItem; }
            set
            {
                promptItem = value;
                RaisePropertyChanged(nameof(PromptItem));
            }
        }

        // Declare the PropertyChanged event.
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

{% endhighlight %}
{% endtabs %}

N> If you want your data objects to respond to property changes, then implement [INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-9.0) interface in your model class.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields
        ObservableCollection<ItemModel> assistItemsCollection;
        #endregion

        #region Constructor
        public ViewModel()
        {
            assistItemsCollection = new ObservableCollection<ItemModel>();
            this.GenerateAssistItems();
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the collection of messages of a conversation.
        /// </summary>
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
        #endregion
        ...

        #region Item Generation
        private async void GenerateAssistItems()
        {
            // Adding a request item
            ItemModel requestItem = new ItemModel()
            {
                Prompt = "Types of listening",
                IsRequested = true
            };

            // Add the request item to the collection
            this.assistItemsCollection.Add(requestItem);

            // Generating response item
            await GetResult(requestItem);
        }

        private async Task GetResult(ItemModel requestItem)
        {
            await Task.Delay(1000).ConfigureAwait(true);

            ItemModel responseItem = new ItemModel()
            {
                Response = "Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
                IsRequested = false,
                PromptItem = requestItem,
            };

            // Add the response item to the collection
            this.assistItemsCollection.Add(responseItem);
        }
        #endregion
    }

{% endhighlight %}
{% endtabs %}
 
This converter must implement the [IAssistItemConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.IAssistItemConverter.html) interface. Implement this interface to create a custom converter for the `ItemsSourceConverter` property.
 
{% tabs %}
{% highlight c# tabtitle="AssistItemConverter.cs" hl_lines="1" %}

    public class AssistItemConverter : IAssistItemConverter
    {
        public IAssistItem ConvertToAssistItem(object customItem, SfAIAssistView assistView)
        {
            var assistItem = new AssistItem();
            var item = customItem as ItemModel;
            if (item != null)
            {
                assistItem.Data = item;
                assistItem.IsRequested = item.IsRequested;
                if (item.IsRequested)
                {
                    if (item.Prompt != null)
                    {
                        assistItem.Text = item.Prompt;
                    }
                }
                else
                {
                    if (item.Response != null)
                    {
                        assistItem.Text = item.Response;
                    }
                }
            }
            return assistItem;
        }

        public object ConvertToData(object assistViewItem, SfAIAssistView assistView)
        {
            var item = new ItemModel();
            var assistItem = assistViewItem as AssistItem;
            if (assistItem != null)
            {
                item.IsRequested = assistItem.IsRequested;
                if (item.IsRequested)
                {
                    item.Prompt = assistItem.Text;
                }
                else
                {
                    item.Response = assistItem.Text;
                }
            }
            return item;
        }
    }
    
{% endhighlight %}
{% endtabs %}

N> The `Data` property in `AssistItem` holds a reference to the original data object which is used for data operations.

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/custom-model-collection-in-.net-maui-aiassistview).

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
