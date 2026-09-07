---
layout: post 
title: Prompt Library in .NET MAUI AI AssistView | Syncfusion®
description: Learn here all about the Prompt Library feature in the Syncfusion® .NET MAUI AI AssistView control, its APIs, and usage.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Prompt Library in .NET MAUI AI AssistView

The SfPromptLibrary control displays a collection of predefined prompts. It helps users quickly choose common prompts grouped by category and topic.

## Prompt library overview

The PromptLibrary control accepts a PromptLibrary instance. Provide prompt data through its `ItemsSource` property.

Each item in the collection is a `PromptItem`. The prompt library uses the following members to group and display prompts:

* `Title` - Displays the prompt name.
* `PromptContent` - Inserts the prompt text when selected.
* `Section` - Groups prompts into categories.
* `Topic` - Filters prompts within a category.
* `Description` - Shows a short summary for the prompt.
* `Version` - Represents the version of the prompt.

### Define the prompt collection

Create a view model with a prompt collection and save it as `PromptLibraryModel.cs`.

{% tabs %}
{% highlight c# tabtitle="PromptLibraryModel.cs" %}

using System.Collections.ObjectModel;
using Syncfusion.Maui.AIAssistView;

namespace SampleBrowser.Maui.AIAssistView.SfAIAssistView;

public class PromptLibraryInfoRepository
{
    private ObservableCollection<PromptItem> promptItemsInfo;

    public PromptLibraryInfoRepository()
    {
        this.promptItemsInfo = new ObservableCollection<PromptItem>();
        this.InitializePromptLibrary();
    }

    public ObservableCollection<PromptItem> PromptLibraryInfo
    {
        get => this.promptItemsInfo;
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

### Bind the prompt library

Assign the view model as the page `BindingContext`, then bind the prompt collection to the prompt library. Set the `ItemsSource` property of `SfPromptLibrary` to the prompt collection so the prompts are displayed in the prompt library.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage.BindingContext>
    <local:PromptLibraryModel />
</ContentPage.BindingContext>

<promptLibrary:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var viewModel = new PromptLibraryInfoRepository();
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
{% highlight xaml hl_lines="6" %}

<ContentPage.BindingContext>
    <local:PromptLibraryViewModel />
</ContentPage.BindingContext>

<promptLibrary:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}"
                            PromptSelected="OnPromptSelected" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

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
        // TODO: Use the selected prompt text (selectedPrompt.PromptContent).
    }
}

{% endhighlight %}
{% endtabs %}

### Using PromptSelectedCommand

{% tabs %}
{% highlight xaml hl_lines="6" %}

<ContentPage.BindingContext>
    <local:PromptLibraryViewModel />
</ContentPage.BindingContext>

<promptLibrary:SfPromptLibrary ItemsSource="{Binding PromptLibraryInfo}"
                            PromptSelectedCommand="{Binding PromptSelectedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

using System.Collections.ObjectModel;
using System.Windows.Input;
using Syncfusion.Maui.AIAssistView;

public class PromptLibraryViewModel
{
    private ICommand promptSelectedCommand;

    public PromptLibraryViewModel()
    {
        this.PromptLibraryInfo = new ObservableCollection<PromptItem>();
        this.promptSelectedCommand = new Command(ExecutePromptSelected);
    }

    public ObservableCollection<PromptItem> PromptLibraryInfo { get; }

    public ICommand PromptSelectedCommand
    {
        get => this.promptSelectedCommand;
    }

    private void ExecutePromptSelected(object parameter)
    {
        if (parameter is PromptSelectedEventArgs args)
        {
            // Handle the PromptSelected command
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Integrate SfPromptLibrary with SfAIAssistView

To show the PromptLibrary UI inside the AssistView, embed `SfPromptLibrary` into the `SfAIAssistView.PromptLibrary` property.

{% highlight xaml %}

<aiAssist:SfAIAssistView x:Name="sfAIAssistView"
                        Suggestions="{Binding PromptSuggestions}">

    <aiAssist:SfAIAssistView.PromptLibrary>
        <aiAssist:SfPromptLibrary ItemsSource="{Binding PromptLibrary.PromptLibraryInfo}" PromptSelectedCommand="{Binding PromptSelectedCommand}"/>
    </aiAssist:SfAIAssistView.PromptLibrary>

</aiAssist:SfAIAssistView>


{% endhighlight %}

N> The PromptLibrary overlay is displayed only when common suggestions are configured.
