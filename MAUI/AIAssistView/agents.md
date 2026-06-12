---
layout: post
title: Agent in .NET MAUI AI AssistView Control | Syncfusion
description: Learn how to work with Agent support in the Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, including its key elements and features.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Getting Started with Agent in .NET MAUI AI AssistView

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control provides an `Agent` feature that allows you to display a collection of agents in the view. Agents can be used in AI applications to handle specific tasks like writing assistance, image generation, and data analysis.

## Populating agent collection

The `SfAIAssistView` control provides the `Agents` property to set the agents collection. Each item in the collection is of type `AssistAgent` and contains the following members:

* `Name` : Displays the name of the agent.
* `Description` : Defines the agent's functionality.
* `Instructions` : Determines the agent's behavior associated with AI.
* `Icon` : Displays the agent's image.

### Define the view model

Create a simple view model as shown in the following code example and save it as `GettingStartedViewModel.cs`.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

using Syncfusion.Maui.AIAssistView;
using System.Collections.ObjectModel;
using System.ComponentModel;

public class GettingStartedViewModel : INotifyPropertyChanged
{
    ...
    private ObservableCollection<AssistAgent> agentCollections;
    ...

    public GettingStartedViewModel()
    {
        ...
        this.agentCollections = new ObservableCollection<AssistAgent>();
        this.InitializeAgentCollection();
        ...
    }

    ...
    public ObservableCollection<AssistAgent> AgentCollection
    {
        get => this.agentCollections;
        set
        {
            this.agentCollections = value;
            this.OnPropertyChanged(nameof(AgentCollection));
        }
    }
    ...

    ...
    public void InitializeAgentCollection()
    {
        var agent1 = new AssistAgent
        {
            Name = "Writing Assistant",
            Description = "Helps with writing, editing, and brainstorming",
            Instructions = "You are a writing assistant that helps with content creation, editing, brainstorming ideas, and improving written communication. Provide constructive feedback and creative suggestions.",
            Icon = "richtexteditor.png"
        };

        var agent2 = new AssistAgent
        {
            Name = "Art Assistant",
            Description = "Creates images based on user descriptions and ideas",
            Instructions = "You are an image generation assistant that creates visual content from user prompts. Understand the user's description clearly and generate accurate, creative, and high-quality images. If needed, refine the prompt for better results. Keep responses simple and confirm the type of image before generating when require",
            Icon = "imageeditor.png"
        };

        this.AgentCollection.Add(agent1);
        this.AgentCollection.Add(agent2);
    }

    ...
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

{% endhighlight %}
{% endtabs %}

### Binding agent collection to SfAIAssistView

To populate the agent collection, bind the collection from its `BindingContext` to the `SfAIAssistView.Agents` property.

{% tabs %}
{% highlight xaml hl_lines="15" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
             xmlns:local="clr-namespace:GettingStarted"            
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                   Agents="{Binding AgentCollection}"/>
    </ContentPage.Content>

</ContentPage>

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
        this.sfAIAssistView.Agents = viewModel.AgentCollection;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![Agents in .NET MAUI AI AssistView](Images/agents/maui-aiassitview-agentview.png)

### Selecting an agent

The `SfAIAssistView` control supports setting a current agent using the `SelectedAgent` property. User can directly set the `SelectedAgent` in the `SfAIAssistView`, or user can select one from the editor by typing `@`, which reveals all available agents in the `Agents` collection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           Agents="{Binding AgentCollection}"
                           SelectedAgent="{Binding Agent}"/>  

{% endhighlight %} 
{% highlight c# hl_lines="8" %}

SfAIAssistView sfAIAssistView; 
public MainPage() 
{ 
    InitializeComponent(); 
    this.sfAIAssistView = new SfAIAssistView();
    GettingStartedViewModel viewModel = new GettingStartedViewModel();
    this.sfAIAssistView.Agents = viewModel.AgentCollection;
    this.sfAIAssistView.SelectedAgent = viewModel.Agent;
    this.Content = sfAIAssistView;
} 

{% endhighlight %}
{% endtabs %}

![Selected Agents in .NET MAUI AI AssistView](Images/agents/maui-aiassitview-selected-agent.png)

### Show selected agent in view

The `SfAIAssistView` control supports showing the selected agent in the view. By default, the `SelectedAgent` is displayed. To hide the `SelectedAgent`, set the `ShowSelectedAgent` property to `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ShowSelectedAgent="False"/>  

{% endhighlight %} 
{% highlight c# hl_lines="6" %}

SfAIAssistView sfAIAssistView; 
public MainPage() 
{ 
    InitializeComponent(); 
    this.sfAIAssistView = new SfAIAssistView();
    this.sfAIAssistView.ShowSelectedAgent = false;
    this.Content = sfAIAssistView;
} 

{% endhighlight %}
{% endtabs %}

![Show Selected Agent in .NET MAUI AI AssistView](Images/agents/maui-aiassitview-show-selected-agent.png)

### Agent view customization

The `SfAIAssistView` control allows you to fully customize the `SelectedAgent` appearance in the editor using the `SelectedAgentTemplate` property. This property lets you define a custom layout and style.

{% tabs %}
{% highlight xaml hl_lines="11" %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="agentTemplate">
            <Grid>
                ...
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           SelectedAgentTemplate="{StaticResource agentTemplate}" />

{% endhighlight %}
{% highlight c# hl_lines="11" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.SelectedAgentTemplate = this.CreateAgentTemplate();
        this.Content = this.sfAIAssistView;
    }

    private DataTemplate CreateAgentTemplate()
    {
        return new DataTemplate(() =>
        {
            ...
        });
    }
}

{% endhighlight %}
{% endtabs %}

![Agent Template in .NET MAUI AI AssistView](Images/agents/maui-aiassitview-selected-agent-template.png)