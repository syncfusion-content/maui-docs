---
layout: post
title: Agent in .NET MAUI AI AssistView Control | Syncfusion®
description: Learn here all about Agent support in the Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Getting Started with Agent in .NET MAUI AI AssistView

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control provides an `Agent` feature that enables multiple AI agents to be presented within a single chat experience. Agents are useful in AI chat applications because they represent specialized assistants for different tasks and domains, allowing users to switch between capabilities seamlessly and receive more focused, context-aware responses.

## Populating agent collection

The `SfAIAssistView` control provides the [Agents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Agents) property to set the agents collection. Each item in the collection is of type [AssistAgent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAgent.html) and contains the following members:

* [Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAgent.html#Syncfusion_Maui_AIAssistView_AssistAgent_Name) : Displays the name of the agent.
* [Description](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAgent.html#Syncfusion_Maui_AIAssistView_AssistAgent_Description) : Defines the agent's functionality.
* [Instructions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAgent.html#Syncfusion_Maui_AIAssistView_AssistAgent_Instructions) : Determines the agent's behavior associated with AI.
* [Icon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAgent.html#Syncfusion_Maui_AIAssistView_AssistAgent_Icon) : Displays the agent's image.

### Define the View Model

Create a simple view model as shown in the following code example and save it as `ViewModel.cs`.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.Maui.AIAssistView;

public class GettingStartedViewModel : INotifyPropertyChanged
{
    private ObservableCollection<AssistAgent> agentCollections;
    private AssistAgent agent;

    public GettingStartedViewModel()
    {
        this.agentCollections = new ObservableCollection<AssistAgent>();
        this.InitializeAgentCollection();
        
        // Default selected agent
        if (this.AgentCollection.Count > 0)
        {
            this.Agent = this.AgentCollection[0];
        }
    }

    public ObservableCollection<AssistAgent> AgentCollection
    {
        get => this.agentCollections;
        set
        {
            this.agentCollections = value;
            this.OnPropertyChanged(nameof(AgentCollection));
        }
    }

    public AssistAgent Agent
    {
        get => this.agent;
        set
        {
            this.agent = value;
            this.OnPropertyChanged(nameof(Agent));
        }
    }

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
            Instructions = "You are an image generation assistant that creates visual content from user prompts. Understand the user's description clearly and generate accurate, creative, and high-quality images. If needed, refine the prompt for better results. Keep responses simple and confirm the type of image before generating when required.",
            Icon = "imageeditor.png"
        };

        this.AgentCollection.Add(agent1);
        this.AgentCollection.Add(agent2);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

{% endhighlight %}
{% endtabs %}

### Binding Agent Collection to AI AssistView

To populate the agent collection, first assign the view model as the `BindingContext` of the page, then bind the collection to the [Agents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Agents) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}

<ContentPage.BindingContext>
    <local:GettingStartedViewModel />
</ContentPage.BindingContext>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           Agents="{Binding AgentCollection}" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var viewModel = new GettingStartedViewModel();
        this.BindingContext = viewModel;

        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.Agents = viewModel.AgentCollection;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Agents](Images/agents/maui-aiassitview-agentview.png)

### Selecting an Agent

The `SfAIAssistView` control supports setting a current agent using the [SelectedAgent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SelectedAgent) property. A user can directly set the `SelectedAgent` in the `SfAIAssistView`, or select one from the editor by typing `@`, which reveals all available agents in the [Agents](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Agents) collection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7" %}

<ContentPage.BindingContext>
    <local:GettingStartedViewModel />
</ContentPage.BindingContext>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           Agents="{Binding AgentCollection}"
                           SelectedAgent="{Binding Agent}" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="13" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var viewModel = new GettingStartedViewModel();
        this.BindingContext = viewModel;

        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.Agents = viewModel.AgentCollection;
        sfAIAssistView.SelectedAgent = viewModel.Agent;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Selected Agent](Images/agents/maui-aiassitview-selected-agent.png)

### Show Selected Agent in View

The `SfAIAssistView` control supports showing the `SelectedAgent` in the editor view. By default, `ShowSelectedAgent` is `true` and the `SelectedAgent` is displayed. To hide the `SelectedAgent`, set the [ShowSelectedAgent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowSelectedAgent) property to `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ShowSelectedAgent="False" />

{% endhighlight %}
{% highlight c# hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.ShowSelectedAgent = false;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Show Selected Agent](Images/agents/maui-aiassitview-show-selected-agent.png)

### Agent view customization

The `SfAIAssistView` control allows you to fully customize the `SelectedAgent` appearance in the editor using the [SelectedAgentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SelectedAgentTemplate) property. This property lets you define a custom layout and style.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="8" %}

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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.SelectedAgentTemplate = this.CreateAgentTemplate();
        this.Content = sfAIAssistView;
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

![Syncfusion .NET MAUI AI AssistView Agent view customization](Images/agents/maui-aiassitview-selected-agent-template.png)
