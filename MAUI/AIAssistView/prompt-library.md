---
layout: post 
title: Prompt Library in .NET MAUI AI AssistView | Syncfusion®
description: Learn here all about the Prompt Library feature in the Syncfusion® .NET MAUI AI AssistView control, its APIs, and usage.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Prompt Library in .NET MAUI AI AssistView

The `SfPromptLibrary` displays a collection of predefined prompts, helping users quickly select commonly used prompts organized by category and topic.

## Populate Items in PromptLibrary

Set the `ItemsSource` property of the `SfPromptLibrary` to a collection to display the available items.

Each item in the collection is a `PromptItem`. The prompt library uses the following members to group and display prompts:

* `Title` - Specifies the prompt name.
* `Topic` - Specifies the topic to which the prompt belongs.
* `Description` - Specifies the prompt summary shown in the library.
* `Section` - Specifies the section used to group related prompts.
* `PromptContent` - Specifies the prompt text inserted or submitted when the user selects the prompt.
* `Version` - Specifies the version of the prompt.

### Define the prompt collection

Create a view model with a prompt collection and save it as `PromptLibraryViewModel.cs`.

{% tabs %}
{% highlight c# tabtitle="PromptLibraryViewModel.cs" %}

using System.Collections.ObjectModel;
using Syncfusion.Maui.AIAssistView;

public class PromptLibraryViewModel
{
    private ObservableCollection<PromptItem> promptItemsInfo;

    public PromptLibraryViewModel()
    {
        this.promptItemsInfo = new ObservableCollection<PromptItem>();
        this.InitializePromptLibrary();
    }

    public ObservableCollection<PromptItem> PromptLibraryInfo
    {
        get => this.promptItemsInfo;
        set => this.promptItemsInfo = value;
    }

    private void InitializePromptLibrary()
    {
        this.PromptLibraryInfo.Add(new PromptItem
        {
            Title = "Podcast Script Generator",
            PromptContent = "As a Podcast Script Generator, create a 10-minute podcast script about AI productivity. Include an engaging introduction, discussion points, and a closing summary.",
            Section = "Prompt Topics",
            Topic = "Audio",
            Description = "Creates structured podcast episodes."
        });

        this.PromptLibraryInfo.Add(new PromptItem
        {
            Title = "Project Proposal Writer",
            PromptContent = "As a Project Proposal Writer, draft a project proposal for cloud migration. Define objectives, scope, expected outcomes, risks, and resource requirements.",
            Section = "Prompt Topics",
            Topic = "Document",
            Description = "Creates detailed project proposal documents."
        });
    }
}

{% endhighlight %}
{% endtabs %}

### Bind to data source

Bind the view model collection to the `SfPromptLibrary.ItemsSource` property to display the items in the `PromptLibrary`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage.BindingContext>
    <local:PromptLibraryViewModel />
</ContentPage.BindingContext>

<syncfusion:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var viewModel = new PromptLibraryViewModel();
        this.BindingContext = viewModel;

        var promptLibrary = new SfPromptLibrary
        {
            ItemsSource = viewModel.PromptLibraryInfo,
        };

        this.Content = promptLibrary;
    }
}

{% endhighlight %}
{% endtabs %}

## Event and Commands

When a user selects a prompt, both the `PromptSelected` event and the `PromptSelectedCommand` are triggered. They provide a `PromptSelectedEventArgs` instance that contains the following details about the selected prompt item.

* `Prompt` - The prompt item chosen by the user.

### Using PromptSelected event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}

<ContentPage.BindingContext>
    <local:PromptLibraryViewModel />
</ContentPage.BindingContext>

<syncfusion:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}"
                            PromptSelected="OnPromptSelected" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnPromptSelected(object sender, PromptSelectedEventArgs e)
    {
        PromptItem selectedPrompt = e.Prompt;
        // Use the selected prompt text (selectedPrompt.PromptContent).
    }
}

{% endhighlight %}
{% endtabs %}

### Using PromptSelectedCommand

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}

<ContentPage.BindingContext>
    <local:PromptLibraryViewModel />
</ContentPage.BindingContext>

<syncfusion:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}"
                            PromptSelectedCommand="{Binding PromptSelectedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="PromptLibraryViewModel.cs" %}

using System.Collections.ObjectModel;
using System.Windows.Input;
using Syncfusion.Maui.AIAssistView;

public class PromptLibraryViewModel
{
    private ICommand promptSelectedCommand;

    public PromptLibraryViewModel()
    {
        this.promptSelectedCommand = new Command(ExecutePromptSelected);
    }

    public ICommand PromptSelectedCommand
    {
        get => this.promptSelectedCommand;
    }

    private void ExecutePromptSelected(object parameter)
    {
        if (parameter is PromptItem selectedPrompt)
        {
            // Handle the PromptSelected command
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Add PromptLibrary to SfAIAssistView

To show the `PromptLibrary` in `SfAIAssistView`, assign `SfPromptLibrary` to the `SfAIAssistView.PromptLibrary` property. With common suggestions configured, a more icon appears in the suggestions area. Tapping the more icon displays the `PromptLibrary` overlay.

{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage.BindingContext>
    <local:PromptLibraryViewModel />
</ContentPage.BindingContext>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                        Suggestions="{Binding PromptSuggestions}">

    <syncfusion:SfAIAssistView.PromptLibrary>
        <syncfusion:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}"/>
    </syncfusion:SfAIAssistView.PromptLibrary>

</syncfusion:SfAIAssistView>


{% endhighlight %}

N> Common suggestions must be configured for the `PromptLibrary` overlay to be displayed.
