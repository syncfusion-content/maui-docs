---
layout: post
title: AutoComplete Suggestions in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about AutoComplete Suggestions support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# AutoComplete Suggestions in .NET MAUI AI AssistView (SfAIAssistView)

## Displaying AutoComplete suggestions

The `SfAIAssistView` control supports an **AutoComplete suggestions** feature that displays a real-time overlay of matching suggestions as the user types in the editor. The overlay appears once the user has entered at least the minimum number of required characters (controlled by `MinimumPrefixCharacters`) and dynamically filters or updates based on each keystroke. Suggestions are supplied through the `AutoSuggestions` property, which accepts any `IEnumerable<ISuggestion>` collection.

This feature is especially useful in conversational AI interfaces, where guiding users towards well-formed prompts improves the quality of AI responses and accelerates user interactions.

## AutoComplete suggestion customization

The `SfAIAssistView` control exposes several properties on its `AutoSuggestionOverlay` object that allow you to tailor the behavior, appearance, and interaction model of the autocomplete overlay to match your application's requirements.

### AutoSuggestions

The [AutoSuggestions]() property accepts a collection of `ISuggestion` items that are displayed in the autocomplete overlay as the user types. Populate this collection from your ViewModel or code-behind and bind it to the control to provide contextual, real-time suggestions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="9 19" %}

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

The [ItemSelectedCommand]() property accepts an `ICommand` that is executed when the user selects an item from the autocomplete overlay. The command parameter is the selected `ISuggestion` instance, which you can use to populate the editor, trigger a request, or perform any custom action.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

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

### AutoSuggestionsTemplate

The [AutoSuggestionsTemplate]() property accepts a `DataTemplate` used to render each row in the autocomplete overlay. This allows you to fully customize the visual appearance of suggestion items — for example, adding icons, secondary text, or custom layouts — beyond the default text-only presentation.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="20" %}

<ContentPage.Resources>
    <DataTemplate x:Key="autoSuggestionTemplate">
        <Grid ColumnDefinitions="Auto,*" Padding="8" ColumnSpacing="10">
            <Image Grid.Column="0"
                   Source="suggestion_icon.png"
                   HeightRequest="20"
                   WidthRequest="20" />
            <Label Grid.Column="1"
                   Text="{Binding Text}"
                   VerticalOptions="Center"
                   TextColor="#333333" />
        </Grid>
    </DataTemplate>
</ContentPage.Resources>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          AutoSuggestionsTemplate="{StaticResource autoSuggestionTemplate}" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="16" %}

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
            AutoSuggestionsTemplate = CreateSuggestionTemplate(),
        };
        this.Content = sfAIAssistView;
    }

    private DataTemplate CreateSuggestionTemplate()
    {
        return new DataTemplate(() =>
        {
            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Star }
                },
                Padding = new Thickness(8),
                ColumnSpacing = 10
            };

            var image = new Image { Source = "suggestion_icon.png", HeightRequest = 20, WidthRequest = 20 };
            var label = new Label { VerticalOptions = LayoutOptions.Center, TextColor = Color.FromArgb("#333333") };
            label.SetBinding(Label.TextProperty, "Text");

            grid.Add(image, 0, 0);
            grid.Add(label, 1, 0);
            return grid;
        });
    }
}

{% endhighlight %}
{% endtabs %}

### MinimumPrefixCharacters

The [MinimumPrefixCharacters]() property specifies the minimum number of characters a user must type in the editor before the autocomplete overlay is triggered and suggestions are displayed. The default value is `1`. Increasing this value avoids showing suggestions too early, which is useful when your suggestion list is large or when network-based lookups are involved.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          MinimumPrefixCharacters="3" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}

this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
{
    AutoSuggestions = viewModel.AutoCompleteSuggestions,
    MinimumPrefixCharacters = 3,
};

{% endhighlight %}
{% endtabs %}

### DebounceMs

The [DebounceMs]() property sets the debounce delay, in milliseconds, that is applied before the suggestion query is triggered after the user stops typing. This helps reduce unnecessary lookups or filtering operations when the user is typing rapidly. The default value is `200`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          DebounceMs="300" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}

this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
{
    AutoSuggestions = viewModel.AutoCompleteSuggestions,
    DebounceMs = 300,
};

{% endhighlight %}
{% endtabs %}

### AutoSubmitOnSuggestionSelect

The [AutoSubmitOnSuggestionSelect]() property controls whether selecting a suggestion from the overlay automatically submits it as a request item. When set to `true`, the selected suggestion text is immediately sent as a user request without any additional confirmation. When set to `false`, the selected suggestion text is populated into the editor, allowing the user to review or modify it before submitting. The default value is `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           AssistItems="{Binding AssistItems}">
    <syncfusion:SfAIAssistView.AutoSuggestionOverlay>
        <syncfusion:AutoSuggestionOverlay AutoSuggestions="{Binding AutoCompleteSuggestions}"
                                          AutoSubmitOnSuggestionSelect="True" />
    </syncfusion:SfAIAssistView.AutoSuggestionOverlay>
</syncfusion:SfAIAssistView>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}

this.sfAIAssistView.AutoSuggestionOverlay = new AutoSuggestionOverlay()
{
    AutoSuggestions = viewModel.AutoCompleteSuggestions,
    AutoSubmitOnSuggestionSelect = true,
};

{% endhighlight %}
{% endtabs %}

### IsOpen

The [IsOpen]() property is a read-only boolean that reflects whether the autocomplete suggestion overlay is currently visible (`true`) or hidden (`false`). This property is managed internally by the control and is updated automatically as the user types or dismisses the overlay. You can observe this property in your ViewModel or code-behind to react to overlay state changes, such as adjusting the UI layout when the overlay is shown or hidden.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

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