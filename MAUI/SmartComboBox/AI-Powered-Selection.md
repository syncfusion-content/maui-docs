---
layout: post
title: AI-Powered Selection in .NET MAUI MultiSelect ComboBox | Syncfusion®
description: Learn how to select matching items in the Syncfusion® .NET MAUI MultiSelect ComboBox from a natural-language request with Azure OpenAI.
platform: maui
control: SfComboBox
documentation: ug
---

# AI-Powered Smart Selection in .NET MAUI MultiSelect ComboBox

This article demonstrates how to combine Azure OpenAI with the Syncfusion® [.NET MAUI ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) to select fruits from a natural-language request. For example, a user can ask for "low-sugar fruits that are good for immunity," and the app selects matching entries from its fruit menu.

The sample uses the Azure OpenAI .NET SDK, dependency injection (DI), and a ViewModel that owns the request, selection, loading state, and errors. The page hosts the query field and MultiSelect ComboBox, and delegates selection changes to the ViewModel.

N> **Prerequisite:** Before starting, install the required Syncfusion NuGet packages, configure a .NET MAUI application, and complete the [ComboBox getting started](https://help.syncfusion.com/maui/combobox/getting-started) steps.

## Step 1: Install the required packages

The sample uses `Syncfusion.Maui.Inputs` for `SfComboBox`, `Syncfusion.Maui.Core` for `SfTextInputLayout`, and `Azure.AI.OpenAI` for Azure OpenAI integration. Install the Azure OpenAI SDK version used by the sample:

{% tabs %}
{% highlight powershell %}
Install-Package Azure.AI.OpenAI -Version 2.1.0
{% endhighlight %}
{% highlight bash %}
dotnet add package Azure.AI.OpenAI --version 2.1.0
{% endhighlight %}
{% endtabs %}

## Step 2: Define the AI service contract

The ViewModel depends on an interface so that the AI service can be replaced with a test implementation.

{% tabs %}
{% highlight c# %}
namespace SmartAIComboBox;

public interface IFruitSelectionAIService
{
    Task<string> GetCompletionAsync(
        string prompt,
        CancellationToken cancellationToken = default);
}
{% endhighlight %}
{% endtabs %}

## Step 3: Create the Azure OpenAI service

The service uses `AzureOpenAIClient` and `ChatClient` from `Azure.AI.OpenAI`. Replace the endpoint, deployment name, and API key with the values for your Azure OpenAI resource. The system message instructs the model to return only exact fruit names from the menu supplied by the ViewModel.

{% tabs %}
{% highlight c# %}
using System.ClientModel;
using Azure;
using Azure.AI.OpenAI;
using OpenAI.Chat;

namespace SmartAIComboBox;

public sealed class FruitSelectionAzureAIService : IFruitSelectionAIService
{
    private const string Endpoint = "YOUR_ENDPOINT";
    private const string DeploymentName = "YOUR_DEPLOYMENT_NAME";
    private const string ApiKey = "YOUR_API_KEY";

    public async Task<string> GetCompletionAsync(
        string prompt,
        CancellationToken cancellationToken = default)
    {
        var client = new AzureOpenAIClient(
            new Uri(Endpoint),
            new AzureKeyCredential(ApiKey));
        var chatClient = client.GetChatClient(DeploymentName);
        var messages = new List<ChatMessage>
        {
            new SystemChatMessage(
                "You are an AI fruit-selection assistant for a MultiSelect fruit menu. " +
                "Choose matching fruits from the provided menu. Return only exact fruit names, " +
                "one per line, without bullets or explanations. If none match, return Empty."),
            new UserChatMessage(prompt)
        };

        ChatCompletion completion;
        try
        {
            completion = await chatClient.CompleteChatAsync(
                messages,
                cancellationToken: cancellationToken);
        }
        catch (ClientResultException ex) when (ex.Status == 401)
        {
            throw new InvalidOperationException(
                "Azure OpenAI returned 401. Verify the API key for the configured endpoint.", ex);
        }
        catch (ClientResultException ex) when (ex.Status == 404)
        {
            throw new InvalidOperationException(
                $"Azure OpenAI returned 404. Verify that deployment '{DeploymentName}' exists.", ex);
        }

        var content = string.Concat(completion.Content.Select(part => part.Text));
        if (string.IsNullOrWhiteSpace(content))
            throw new InvalidOperationException("Azure OpenAI returned empty content.");

        return content.Trim();
    }
}
{% endhighlight %}
{% endtabs %}

The service throws on request failures. The ViewModel catches exceptions and publishes an error message for the page; it does not interpret error text as a list of fruit names.

N> Do not store a production API key in source code. The placeholders above are for illustration; load credentials from a secure configuration provider or secret store at runtime.

## Step 4: Create the fruit model

Each item in the menu is represented by `FruitModel`. The `Diet` property contains the nutrition and health tags sent to Azure OpenAI with each fruit name. `IsSelected` keeps the checkbox and selected-item tokens in sync.

{% tabs %}
{% highlight c# %}
using System.ComponentModel;

namespace SmartAIComboBox;

public class FruitModel : INotifyPropertyChanged
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public string? Category { get; set; }
    public string? Diet { get; set; }

    private bool _isSelected;
    public bool IsSelected
    {
        get => _isSelected;
        set
        {
            if (_isSelected == value) return;
            _isSelected = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSelected)));
        }
    }

    public override string ToString() => Name ?? string.Empty;
    public event PropertyChangedEventHandler? PropertyChanged;
}
{% endhighlight %}
{% endtabs %}

The sample ViewModel builds a menu of 50 fruit entries. Each entry includes a name, price, category, and tag string such as `VitaminC`, `LowSugar`, `Fiber`, or `Immunity`.

## Step 5: Implement the selection ViewModel

The ViewModel receives `IFruitSelectionAIService` through DI and exposes the fruit list, `SelectedItems`, query, busy and error states, and commands for searching and clearing. It builds a prompt from the current fruit names and their health tags. The prompt asks Azure OpenAI to interpret the user's request, return exact menu names one per line, and return no more than 10 matches.

After the response returns, the ViewModel removes formatting and duplicates, ignores `Empty` and non-result headings, and applies the matching names to the fruit models. The following excerpts show the selection ownership and request flow:

{% tabs %}
{% highlight c# %}
public void ApplyAISelection(IEnumerable<string> matchedNames)
{
    var nameSet = (matchedNames ?? Enumerable.Empty<string>())
        .Select(name => name.Trim())
        .Where(name => !string.IsNullOrWhiteSpace(name))
        .ToHashSet(StringComparer.OrdinalIgnoreCase);

    foreach (var fruit in Fruits)
        fruit.IsSelected = false;
    SelectedItems.Clear();

    foreach (var fruit in Fruits)
    {
        if (fruit.Name is not null && nameSet.Contains(fruit.Name))
        {
            fruit.IsSelected = true;
            SelectedItems.Add(fruit);
        }
    }

    AISelectionApplied?.Invoke(this, EventArgs.Empty);
}

public async Task AskAIAsync(string? query)
{
    if (string.IsNullOrWhiteSpace(query) || IsBusy) return;

    UserQuery = query;
    ErrorMessage = null;
    IsBusy = true;

    _cts?.Cancel();
    _cts = new CancellationTokenSource();
    var token = _cts.Token;

    try
    {
        var menu = string.Join("\n", Fruits.Select(fruit => $"{fruit.Name} | {fruit.Diet}"));
        var prompt =
            "From the menu below, choose fruits that match the user's natural-language request.\n\n" +
            "Return only exact fruit names from the menu, one per line. Use the fruit tags and " +
            "your knowledge to interpret the request. If multiple constraints are given, match all " +
            "of them. Return at most 10 fruits; return Empty only if no fruit matches.\n\n" +
            "Menu (Name | Tags):\n" + menu + "\n\n" +
            "User request: " + query + "\n\n" +
            "Matching fruits (one per line, exact names from the menu):";
        var completion = await _aiService.GetCompletionAsync(prompt, token);
        token.ThrowIfCancellationRequested();

        var matches = completion
            .Split('\n', '\r', StringSplitOptions.RemoveEmptyEntries)
            .Select(value => value.Trim())
            .Where(value => !string.IsNullOrWhiteSpace(value) &&
                            !value.Equals("Empty", StringComparison.OrdinalIgnoreCase) &&
                            !value.StartsWith("Here are", StringComparison.OrdinalIgnoreCase))
            .Select(value => value.Trim('•', '-', '*', '.', ')').Trim())
            .Where(value => !string.IsNullOrWhiteSpace(value))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .Take(10)
            .ToList();
        ApplyAISelection(matches);
    }
    catch (OperationCanceledException)
    {
        // A newer search superseded this one.
    }
    catch (Exception ex)
    {
        ErrorMessage = $"AI request failed: {ex.Message}";
    }
    finally
    {
        IsBusy = false;
        HasSearched = true;
    }
}
{% endhighlight %}
{% endtabs %}

The response parsing splits the text into lines, trims list markers, removes duplicates, ignores `Empty` and introductory text, and limits the result to 10 names. `ApplyAISelection` resets the prior selection before selecting the new matches. Manual checkbox changes use `ToggleSelection` so the same ViewModel state drives both checkboxes and ComboBox tokens.

## Step 6: Register the service, ViewModel, and page

Register the service, ViewModel, and page in `MauiProgram.cs`. The app resolves the page through DI, and the page constructor assigns the injected ViewModel as its `BindingContext`.

{% tabs %}
{% highlight c# %}
builder.Services.AddSingleton<IFruitSelectionAIService, FruitSelectionAzureAIService>();
builder.Services.AddSingleton<FruitSelectionViewModel>();
builder.Services.AddSingleton<SmartAIComboBoxPage>();
{% endhighlight %}
{% endtabs %}

## Step 7: Build the selection page

The page places an `Entry` in `SfTextInputLayout`. Its trailing view shows a search icon before a search, a loading indicator during the request, and a clear icon after results are available. Pressing Enter or tapping search starts the same ViewModel request. An error banner displays `ErrorMessage` and offers a dismiss command.

The MultiSelect ComboBox binds its item source and selection to the ViewModel. Its item template displays a checkbox for each fruit, and token mode displays the selected names.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTextInputLayout x:Name="queryInputLayout"
                              Hint="Describe your needs..."
                              ContainerType="Outlined">
    <Entry x:Name="queryEntry"
           Text="{Binding UserQuery, Mode=TwoWay}"
           ReturnType="Search"
           Completed="OnQueryCompleted"
           TextChanged="OnQueryTextChanged" />
</syncfusion:SfTextInputLayout>

<Border IsVisible="{Binding HasError}">
    <Grid ColumnDefinitions="*,Auto">
        <Label Text="{Binding ErrorMessage}" />
        <Button Grid.Column="1"
                Text="Dismiss"
                Command="{Binding DismissErrorCommand}" />
    </Grid>
</Border>

<editors:SfComboBox ItemsSource="{Binding Fruits}"
                    SelectedItems="{Binding SelectedItems, Mode=TwoWay}"
                    SelectionMode="Multiple"
                    IsEditable="False"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    MultiSelectionDisplayMode="Token"
                    TokensWrapMode="Wrap">
    <editors:SfComboBox.ItemTemplate>
        <DataTemplate x:DataType="local:FruitModel">
            <Grid ColumnDefinitions="0.9*,0.1*" HeightRequest="48">
                <Label Text="{Binding Name}" />
                <CheckBox Grid.Column="1"
                          IsChecked="{Binding IsSelected, Mode=TwoWay}"
                          CheckedChanged="OnDropDownItemCheckBoxChanged" />
            </Grid>
        </DataTemplate>
    </editors:SfComboBox.ItemTemplate>
</editors:SfComboBox>
{% endhighlight %}
{% endtabs %}

## Step 8: Connect page interactions to the ViewModel

The code-behind handles UI-only actions: it invokes a search from the keyboard or search icon, closes the dropdown on clear, and opens it after the ViewModel applies AI results. Checkbox changes are delegated to `ToggleSelection` rather than mutating `SelectedItems` in the page.

{% tabs %}
{% highlight c# %}
private void RunAISearch()
{
    if (_viewModel.IsBusy) return;
    var query = queryEntry.Text ?? string.Empty;
    if (string.IsNullOrWhiteSpace(query)) return;
    _ = _viewModel.AskAIAsync(query);
}

private void OnAISelectionApplied(object? sender, EventArgs e)
    => comboBox.IsDropDownOpen = true;

private void OnClearClicked(object? sender, EventArgs e)
{
    _viewModel.Clear();
    comboBox.IsDropDownOpen = false;
}

private void OnDropDownItemCheckBoxChanged(
    object? sender,
    CheckedChangedEventArgs e)
{
    if (sender is CheckBox checkBox && checkBox.BindingContext is FruitModel fruit)
        _viewModel.ToggleSelection(fruit);
}
{% endhighlight %}
{% endtabs %}

## How It Works

1. The user describes the fruit they want and submits the query with Enter or the search icon.
2. The ViewModel sends the query together with the fruit menu and health tags to Azure OpenAI.
3. The ViewModel parses the returned names, resets the previous choices, and selects matching menu entries.
4. The page opens the ComboBox dropdown so the selected checkboxes are visible; the selected fruits also appear as tokens.
5. The user can change selections manually, clear the results, or dismiss an error.

## Output

The selected fruits are displayed in the Syncfusion® .NET MAUI MultiSelect ComboBox.

![.NET MAUI MultiSelect ComboBox with AI smart selection](images/smartcombobox_fruits.gif)

You can find the complete sample in the [MAUI AI use-case demos repository](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master/AI%20Solutions/ComboBox/Multi%20Select%20ComboBox/SmartAIComboBox).

## See Also

- [ComboBox getting started](https://help.syncfusion.com/maui/combobox/getting-started)
- [Multiple selection](https://help.syncfusion.com/maui/combobox/selection#multiple-selection)
- [Searching](https://help.syncfusion.com/maui/combobox/searching)
- [Filtering](https://help.syncfusion.com/maui/combobox/filtering)
- [Azure OpenAI overview](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai#ProductOverview)
