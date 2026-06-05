---
layout: post
title: Appearance in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Appearance support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Appearance in .NET MAUI AI AssistView (SfAIAssistView)
The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) allows customizing the appearance of conversation elements and provides an interactive chat-like interface for users.


## Customizing AI AssistView with ControlTemplate

The `ControlTemplate` in AI AssistView allows you to define and reuse the visual structure of a control. This flexible structure enables to fully customize the appearance and behavior of the AI AssistView. By using `ControlTemplate` with the AI AssistView, you can create a highly customized and interactive interface, as demonstrated below.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<ContentPage.Content>
    ...      
    <local:CustomAssistView x:Name="sfAIAssistView"
                            AssistItems="{Binding AssistMessages}">
        <local:CustomAssistView.ControlTemplate>
                <ControlTemplate>
                    <ContentView>
                        <ContentView.Content>
                            <Grid>
                                <ContentView IsVisible="{Binding IsActiveChatView}" Content="{TemplateBinding AssistChatView}" BindingContext="{TemplateBinding BindingContext}" />
                                <local:ComposeView  IsVisible="{Binding IsActiveComposeView}" BindingContext="{TemplateBinding BindingContext}"/>
                             </Grid>
                        </ContentView.Content>
                    </ContentView>
                </ControlTemplate>
        </local:CustomAssistView.ControlTemplate>
    </local:CustomAssistView>
            ...
</ContentPage.Content>

{% endhighlight %}
{% endtabs %}

### Customizing Chat View in AI AssistView

The [CreateAssistChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CreateAssistChat) method allows for the customization of the chat view functionality within the AI AssistView control. By overriding this method, can create their own custom implementation of the chat view, allowing for greater control over the appearance and behavior of chat interactions. It provides the flexibility to modify how chat messages are displayed, how user interactions are handled. Here’s how to override the `CreateAssistChat` method to return a custom instance of [AssistViewChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistViewChat.html).

{% tabs %} 
{% highlight c# %}

public class CustomAIAssiststView : SfAIAssistView
{
    public CustomAIAssiststView() { }

    protected override AssistViewChat CreateAssistChat()
    {
        // Returning custom implementation of AssistViewChat
        return new CustomAssistViewChat(this);
    }
}

{% endhighlight %} 
{% endtabs %}

The `CustomAssistViewChat `class inherits from `AssistViewChat` and can be used to further customize the chat view, here  the input view is removed by setting `ShowMessageInputView` to `false` as shown below.

{% tabs %}
{% highlight c# %}

public class CustomAssistViewChat : AssistViewChat
{
    public CustomAssistViewChat(SfAIAssistView assistView) : base(assistView)
    {
        //Customize the AssistViewChat
        this.ShowMessageInputView = false;   
    }
}

{% endhighlight %} 
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/custom-control-template-in-.net-maui-aiassistview)

## Edit option for request item

The `SfAIAssistView` allows you to edit a previously sent request. This feature lets users review and refine the prompt and resubmit from the editor to get more accurate responses. Each request shows an Edit icon; when tapped, the request text is placed in the editor (InputView) to redefine.

N> **Interaction**: On desktop (Windows, macOS), hover over a request to reveal the Edit icon. On mobile (Android, iOS), tap the request to show the Edit option.

![Edit Option in .NET MAUI AI AssistView](Images/appearance/maui-aiassistview-editoption.gif)
 
## Show ResponseLoader View

By Default, the response loader view will be enabled, and the default shimmer view will be displayed when the request is added. To disable it, set the [ShowResponseLoader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowResponseLoader) property to `false`.

{% tabs %}
{% highlight xaml hl_lines="8" %}

<ContentPage.BindingContext>
    <local:GettingStartedViewModel/>
</ContentPage.BindingContext>

<ContentPage.Content>
    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               AssistItems="{Binding AssistItems}"
                               ShowResponseLoader="False"/>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems;
        this.sfAIAssistView.ShowResponseLoader = false;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

## Template customization

The `SfAIAssistView` facilitates the customization of both request and response item templates according to specific requirements. This feature enhances flexibility and provides a higher degree of control over the display of items.

By utilizing the template selector, distinct templates can be assigned to all [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) or to a particular item, allowing for the independent customization of both request and response items. This capability is particularly beneficial when custom item types require different visual representations, offering precise control over the layout and presentation within the assist view.

### Request item template

A template can be used to present the data in a way that makes sense for the application by using different controls. `SfAIAssistView` allows customizing the appearance of the Request view by setting the [RequestItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestItemTemplate) property.

#### Data model

{% tabs %}
{% highlight c# tabtitle="FileAssistItem.cs" %}

public class FileAssistItem : AssistItem, INotifyPropertyChanged
{
    private string fileName;

    private string fileType;

    public string FileName
    { 
        get
        {
            return fileName;
        }
        set
        {
            fileName = value;
            OnPropertyChanged("FileName");
        }
    }
    public string FileType
    {
        get
        {
            return fileType;
        }
        set
        {
            fileType = value;
            OnPropertyChanged("FileType");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}

{% endhighlight %}
{% endtabs %}

#### View model

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class GettingStartedViewModel : INotifyPropertyChanged
{
    private ObservableCollection<IAssistItem> assistItems;


    public GettingStartedViewModel()
    {
        this.assistItems = new ObservableCollection<IAssistItem>();
        this.GenerateAssistItems();
    }

    /// <summary>
    /// Gets or sets the collection of AssistItem of a conversation.
    /// </summary>
    public ObservableCollection<IAssistItem> AssistItems
    {
        get
        {
            return this.assistItems;
        }

        set
        {
            this.assistItems = value;
        }
    }

    private async void GenerateAssistItems()
    {
            

        FileAssistItem FileItem = new FileAssistItem()
        {
            FileName = ".NET MAUI",
            FileType = "Document",
            IsRequested = true
        };

        this.AssistItems.Add(FileItem);


        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem2 = new AssistItem()
        {
            Text = "you've uploaded a file containing information about .NET MAUI.If you have any specific questions or would like to dive deeper into any part of the file, feel free to let me know!",
            IsRequested = false
        };

        this.AssistItems.Add(responseItem2);
    }
}

{% endhighlight %}
{% endtabs %}

#### Data template selector

Create a custom class that inherits from [RequestItemTemplateSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestItemTemplateSelector.html), and override the [OnSelectTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestItemTemplateSelector.html#Syncfusion_Maui_AIAssistView_RequestItemTemplateSelector_OnSelectTemplate_System_Object_Microsoft_Maui_Controls_BindableObject_) method to return the `DataTemplate` for that item. At runtime, the `SfAIAssistView` invokes the `OnSelectTemplate` method for each item and passes the data object as parameter.

{% tabs %}
{% highlight c# tabtitle="TemplateSelector.cs" %}

public class CustomRequestTemplateSelector : RequestItemTemplateSelector
{
    private readonly DataTemplate? requestcustomtemplate;

    public CustomRequestTemplateSelector()
    {
        this.requestcustomtemplate = new DataTemplate(typeof(FileTemplate));
    }


    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        var assistitem = item as IAssistItem;

        if (assistitem == null)
        {
            return null;
        }

        // Returns the custom data template for the file item.
        if (item.GetType() == typeof(FileAssistItem))
        {
            return requestcustomtemplate;
        }

        // Returns the inbuilt data templates for the other request AssistItems.
        else
        {
            return base.OnSelectTemplate(item, container);
        }
    }
}

{% endhighlight %}
{% endtabs %}

#### Applying the data template selector

{% tabs %}
{% highlight xaml hl_lines="12" %}

    <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <local:CustomRequestTemplateSelector x:Key="requestSelector"/>
    </ContentPage.Resources>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               AssistItems="{Binding AssistItems}"
                               RequestItemTemplate="{StaticResource requestSelector}"/>
    </ContentPage.Content>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems;
        this.sfAIAssistView.RequestItemTemplate = new CustomRequestTemplateSelector();
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![RequestItem Template in .NET MAUI AI AssistView](Images/appearance/maui-aiassistview-RequestTemplate.png)

### Response item template

A template can be used to present the data in a way that makes sense for the application by using different controls. `SfAIAssistView` allows customizing the appearance of the Response view by setting the [ResponseItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseItemTemplate) property.

#### View model

{% tabs %}
{% highlight c# %}

public class GettingStartedViewModel : INotifyPropertyChanged
{
    /// <summary>
    /// Collection of assistItem in a conversation.
    /// </summary>
    private ObservableCollection<IAssistItem> assistItems;

    public GettingStartedViewModel()
    {
        this.assistItems = new ObservableCollection<IAssistItem>();
        this.GenerateAssistItems();
    }

    /// <summary>
    /// Gets or sets the collection of AssistItem of a conversation.
    /// </summary>
    public ObservableCollection<IAssistItem> AssistItems
    {
        get
        {
            return this.assistItems;
        }

        set
        {
            this.assistItems = value;
        }
    }

    private async void GenerateAssistItems()
    {
        AssistItem requestItem = new AssistItem()
        {
            Text = "Hi, I think I caught a cold.",
            IsRequested = true
        };

        // Add the request item to the collection
        this.AssistItems.Add(requestItem);


        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
            Text = "Do you want me to schedule a consultation with a doctor?",
            IsRequested = false,
        };

        // Add the response item to the collection
        this.AssistItems.Add(responseItem);

        // Adding a request item
        AssistItem requestItem1 = new AssistItem()
        {
            Text = "Yes, Consultation with Dr.Harry tomorrow",
            IsRequested = true
        };

        // Add the request item to the collection
        this.AssistItems.Add(requestItem1);

        await Task.Delay(1000).ConfigureAwait(true);

        DatePickerItem datepickerItem = new DatePickerItem()
        {
            Text = "Choose a date for Consultation",
            IsRequested = false,
            SelectedDate = DateTime.Today,
        };

        // Add the response item to the collection
        this.AssistItems.Add(datepickerItem);
        // Generating response item
    }
}

{% endhighlight %}
{% endtabs %}

#### Data template selector

Create a custom class that inherits from [ResponseItemTemplateSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseItemTemplateSelector.html), and override the [OnSelectTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseItemTemplateSelector.html#Syncfusion_Maui_AIAssistView_ResponseItemTemplateSelector_OnSelectTemplate_System_Object_Microsoft_Maui_Controls_BindableObject_) method to return the `DataTemplate` for that item. At runtime, the `SfAIAssistView` invokes the `OnSelectTemplate` method for each item and passes the data object as parameter.

{% tabs %}
{% highlight c# tabtitle="TemplateSelector.cs" %}

public class CustomResponseTemplateSelector : ResponseItemTemplateSelector
{
    private readonly DataTemplate? reponsecustomtemplate;

    public CustomResponseTemplateSelector()
    {
        this.reponsecustomtemplate = new DataTemplate(typeof(TimePickerTemplate));
    }


    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        var assistitem = item as IAssistItem;

        if (assistitem == null)
        {
            return null;
        }

        // Returns the custom data template for the DatePickerItem item.
        if (item.GetType() == typeof(DatePickerItem))
        {
            return reponsecustomtemplate;
        }

        // Returns the inbuilt data templates for the other request AssistItems.
        else
        {
            return base.OnSelectTemplate(item, container);
        }
    }
}

{% endhighlight %}
{% endtabs %}

#### Applying the data template selector

{% tabs %}
{% highlight xaml hl_lines="12" %}

    <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <local:CustomResponseTemplateSelector x:Key="responseSelector"/>
    </ContentPage.Resources>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                   AssistItems="{Binding AssistItems}"
                                   ResponseItemTemplate="{StaticResource responseSelector}"/>
    </ContentPage.Content>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems;
        this.sfAIAssistView.ResponseItemTemplate = new CustomResponseTemplateSelector();
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![ResponseItem Template in .NET MAUI AI AssistView](Images/appearance/maui-aiassistview-ResponseTemplate.png)

## Text selection
The `SfAIAssistView` allows for selecting specific phrases or the entire response or request text. It enables the platform specific selection functionalities.
By default, text selection is disabled. To enable it, set the [AllowTextSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowTextSelection) property to `true`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AllowTextSelection="True"/>

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
            sfAIAssistView.AllowTextSelection = true;
            this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![Text Selection in .NET MAUI AI AssistView](Images/appearance/maui-aiassistview-textselection.gif)