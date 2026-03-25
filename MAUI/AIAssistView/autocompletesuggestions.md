---
layout: post
title: AutoComplete Suggestions in .NET MAUI AI AssistView | Syncfusion
description: Learn here all about AutoComplete Suggestions support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# AutoComplete Suggestions in .NET MAUI AI AssistView (SfAIAssistView)

## Displaying AutoComplete suggestions

The `SfAIAssistView` control includes an `AutoCompletesuggestions` feature that displays relevant suggestions as the user types. The suggestions appear when the user enters the required number of characters, defined by the `MinimumPrefixCharacters` property. As the user continues typing, the list updates automatically.

Suggestions are provided through the AutoSuggestions property, which accepts any `IEnumerable<ISuggestion>` collection.
This feature helps users compose clearer and more effective prompts, making it especially valuable in conversational AI scenarios.

## AutoComplete suggestion customization

The `SfAIAssistView` control provides a set of properties under the [AutoSuggestionOverlay](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AutoSuggestionOverlay) that enable you to customize the autocomplete overlay’s behavior, appearance, and interaction model to fit your application's needs.

### AutoSuggestions

The [AutoSuggestions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_AutoSuggestions) property displays a bound collection of `ISuggestion` items in the autocomplete overlay. Populate this collection in your ViewModel or code‑behind for dynamic, context‑aware suggestions.

{% tabs %}
{% highlight xaml hl_lines="4" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="9 17" %}

using Syncfusion.Maui.AIAssistView;

public class GettingStartedViewModel : INotifyPropertyChanged
{
    private ObservableCollection<ISuggestion> autoSuggestions;

    public GettingStartedViewModel()
    {
        AutoCompleteSuggestions = new ObservableCollection<ISuggestion>()
        {
            new AssistSuggestion() { Text = "What is .NET MAUI?" },
            new AssistSuggestion() { Text = "How do I get started with AI AssistView?" },
            new AssistSuggestion() { Text = "Explain data binding in .NET MAUI" },
        };
    }

    public ObservableCollection<ISuggestion> AutoCompleteSuggestions
    {
        get { return this.autoSuggestions; }
        set
        {
            this.autoSuggestions = value;
            RaisePropertyChanged(nameof(AutoCompleteSuggestions));
        }
    }
}

{% endhighlight %}
{% endtabs %}

![Auto Complete Suggestions in .NET MAUI AI AssistView](images/maui-aiassistview-auto-complete-suggestion.gif)

### ItemSelectedCommand

The [ItemSelectedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_ItemSelectedCommand) property accepts an `ICommand` that runs when the user selects an item from the autocomplete overlay. The command receives the selected ISuggestion as its parameter.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          ItemSelectedCommand="{Binding SuggestionSelectedCommand}" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class GettingStartedViewModel : INotifyPropertyChanged
{
    public GettingStartedViewModel()
    {
        SuggestionSelectedCommand = new Command<ISuggestion>(OnSuggestionSelected);
    }

    public ICommand SuggestionSelectedCommand { get; set; }

    private void OnSuggestionSelected(ISuggestion selectedSuggestion)
    {
        // Handle the selected suggestion
        Console.WriteLine($"Selected: {selectedSuggestion.Text}");
    }
}

{% endhighlight %}
{% endtabs %}

### AutoSuggestionTemplate

The [AutoSuggestionTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_AutoSuggestionTemplate) property lets you customize the look and structure of each suggestion item shown in the autocomplete overlay.

{% tabs %}
{% highlight xaml hl_lines="20" %}

<ContentPage.Resources>
    <DataTemplate x:Key="autoSuggestionTemplate">
        ...
    </DataTemplate>
</ContentPage.Resources>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          AutoSuggestionTemplate="{StaticResource autoSuggestionTemplate}" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# hl_lines="16" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;

    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems;
        this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
        {
            AutoSuggestions = viewModel.AutoCompleteSuggestions,
            AutoSuggestionTemplate = CreateSuggestionTemplate(),
        };
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

### MinimumPrefixCharacters

The [MinimumPrefixCharacters](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_MinimumPrefixCharacters) sets the minimum number of typed characters required before displaying suggestions. The default is `1`.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          MinimumPrefixCharacters="3" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
{
    AutoSuggestions = viewModel.AutoCompleteSuggestions,
    MinimumPrefixCharacters = 3,
};

{% endhighlight %}
{% endtabs %}

### SuggestionOpenDelay 

The [SuggestionOpenDelay](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_SuggestionOpenDelay) property sets the delay (in milliseconds) before the autosuggestion overlay opens after typing. This helps reduce unnecessary lookups during rapid typing. The default value is `200`.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          SuggestionOpenDelay="300" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
{
    AutoSuggestions = viewModel.AutoCompleteSuggestions,
    SuggestionOpenDelay = 300,
};

{% endhighlight %}
{% endtabs %}

### CancelRequest

The [CancelRequest](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_CancelRequest) property controls whether selecting a suggestion automatically submits it as a request. When set to `false`, the selected suggestion is sent immediately. When set to `true`, the text is inserted into the editor so the user can review or edit it before submitting. The default value is `true`.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          CancelRequest="True" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
{
    AutoSuggestions = viewModel.AutoCompleteSuggestions,
    CancelRequest = true,
};

{% endhighlight %}
{% endtabs %}

### IsOpen

The [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html#Syncfusion_Maui_AIAssistView_AutoSuggestionOverlay_IsOpen) property is a read‑only boolean that indicates whether the autocomplete overlay is currently visible. It is updated automatically by the control, and you can observe it to respond to changes in the overlay’s state.

{% tabs %}
{% highlight c# %}

// Observing the IsOpen state
var autoComplete = sfAIAssistView.AutoSuggestionOverlay;
if (autoComplete.IsOpen)
{
    // The suggestion overlay is currently visible
    Console.WriteLine("Autocomplete overlay is open.");
}
else
{
    // The suggestion overlay is hidden
    Console.WriteLine("Autocomplete overlay is closed.");
}

{% endhighlight %}
{% endtabs %}

N> The `IsOpen` property is read-only and is managed internally by `SfAIAssistView`. Attempting to set it directly from external code will have no effect.