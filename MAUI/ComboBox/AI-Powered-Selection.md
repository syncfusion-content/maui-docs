---
layout: post
title: AI-Powered Smart Selection in .NET MAUI MultiSelect ComboBox | Syncfusion®
description: Learn how to implement AI-powered smart multi-selection using the Syncfusion® .NET MAUI ComboBox (SfComboBox) control with Azure OpenAI.
platform: maui
control: SfCombobox
documentation: ug
---

# AI-Powered Smart Selection in .NET MAUI MultiSelect ComboBox

This article walks you through the implementation of an intelligent, AI-driven selection experience in the Syncfusion [.NET MAUI ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control. The user describes what they need in natural language, the AI interprets the intent, and the [MultiSelect ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) automatically selects the most relevant items. The example uses Azure OpenAI.

For example:

* Ask **"Lunch under ₹200"** and AI understands the intent and automatically selects matching items such as **Veg Meals**, **Lemon Rice**, and **Curd Rice** in the MultiSelect ComboBox.
* Ask **"Healthy breakfast"** and AI identifies suitable options such as **Oats**, **Fruits**, and **Whole Wheat Bread** and automatically selects them in the MultiSelect ComboBox.

**Expected Outcome:** Users describe what they need in natural language, and the MultiSelect ComboBox intelligently selects the most relevant items without manual searching.

**One-line Value:** AI understands the intent, and the MultiSelect ComboBox performs the selection.

## Prerequisites

Before you begin, ensure you have the following:

* A working .NET MAUI application with the `Syncfusion.Maui.Inputs` package installed.
* An active Azure subscription with access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and a deployed model. If you don't have access, refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account. Note down the deployment name, endpoint URL, and API key.
* The [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package (version 2.x recommended for the `IChatClient` API used in this sample). Install it by running the following command in the Visual Studio Package Manager Console:

    ```powershell
    Install-Package Azure.AI.OpenAI -Version 2.0.0
    ```
    Or using the .NET CLI:
    ```bash
    dotnet add package Azure.AI.OpenAI --version 2.0.0
    ```

## Integrating Azure OpenAI with your .NET MAUI App

First, ensure that you have access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and have created a deployment in the Azure portal.

If you do not have access, refer to the [Create and deploy an Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account.

Note down the deployment name, endpoint URL, and API key.

We will use the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package from the [NuGet Gallery](https://www.nuget.org/). Before getting started, install the `Azure.AI.OpenAI` NuGet package in your .NET MAUI app.

In your base service class (`AzureBaseService`), initialize the `AzureOpenAIClient`. Replace the `Endpoint`, `DeploymentName`, and `Key` with actual values from your Azure OpenAI resource. This creates a chat client using your endpoint, API key, and deployment name. It is stored in the `Client` property for use in other methods.

The `ComboBoxAzureAIService` uses this client to send prompts and receive completions.

In the `GetCompletion` method, we construct the prompt and send it to the Azure OpenAI service. The chat history is reset for each new prompt in this implementation to keep each selection request independent.

{% tabs %}
{% highlight c# tabtitle="AzureBaseService.cs" %}

using Azure;
using Azure.AI.OpenAI;

namespace SmartAIComboBox.SmartAIComboBox
{
    /// <summary>
    /// Base service class that initializes the Azure OpenAI chat client.
    /// Replace the Endpoint, DeploymentName, and Key with the values from your Azure OpenAI resource.
    /// </summary>
    public abstract class AzureBaseService
    {
        internal const string Endpoint = "YOUR_END_POINT_NAME";

        internal const string DeploymentName = "DEPLOYMENT_NAME";

        internal const string Key = "API_KEY";

        /// <summary>
        /// Indicates whether the Azure credentials are valid.
        /// </summary>
        internal static bool IsCredentialValid = false;

        /// <summary>
        /// The chat client used to send prompts to Azure OpenAI.
        /// </summary>
        public IChatClient? Client { get; set; }

        public AzureBaseService()
        {
            GetAzureOpenAIKernal();
        }

        /// <summary>
        /// Initializes the Azure OpenAI chat client using the configured endpoint, deployment, and key.
        /// </summary>
        private void GetAzureOpenAIKernal()
        {
            try
            {
                var client = new AzureOpenAIClient(new Uri(Endpoint), new AzureKeyCredential(Key))
                                .AsChatClient(modelId: DeploymentName);
                this.Client = client;
                IsCredentialValid = true;
            }
            catch (Exception)
            {
                IsCredentialValid = false;
            }
        }
    }
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ComboBoxAzureAIService.cs" %}

using System.Diagnostics;

namespace SmartAIComboBox.SmartAIComboBox
{
    /// <summary>
    /// Sends prompts to Azure OpenAI and returns the AI completion.
    /// </summary>
    public class ComboBoxAzureAIService : AzureBaseService
    {
        /// <summary>
        /// Holds the cumulative chat history used as the prompt payload.
        /// </summary>
        private string ChatHistory { get; set; } = string.Empty;

        /// <summary>
        /// Gets a completion response from the AzureAI service based on the provided prompt.
        /// </summary>
        /// <param name="prompt">The natural-language user request.</param>
        /// <param name="cancellationToken">Token used to cancel an in-flight request.</param>
        /// <returns>The AI-generated completion text.</returns>
        public async Task<string> GetCompletion(string prompt, CancellationToken cancellationToken)
        {
            // Reset history so each selection request is independent.
            ChatHistory = string.Empty;

            if (Client != null)
            {
                ChatHistory = "You are a food-selection assistant. From the menu provided, " +
                              "return only the item names that best match the user's intent, " +
                              "one item per line, with no extra text.";
                ChatHistory = ChatHistory + prompt;

                try
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    var chatresponse = await Client.CompleteAsync(ChatHistory);
                    cancellationToken.ThrowIfCancellationRequested();
                    return chatresponse.ToString();
                }
                catch (RequestFailedException ex)
                {
                    // Log the error message and rethrow the exception or handle it appropriately.
                    Debug.WriteLine($"Request failed: {ex.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    // Handle other potential exceptions.
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                    throw;
                }
            }
            return "";
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Implementing AI-based smart selection in .NET MAUI MultiSelect ComboBox

The [.NET MAUI ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) supports a `Multiple` [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) that lets the user choose more than one item. Combined with a natural-language request entry, AI can read the menu, interpret the user's intent (price range, category, dietary preference, meal type, etc.), and auto-populate the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectedItems) collection of the ComboBox.

**Step 1:** Create a business model that represents each food item with its name, price, category, and diet so the AI can reason about the user's request.

{% tabs %}
{% highlight c# tabtitle="FoodModel.cs" %}

namespace SmartAIComboBox.SmartAIComboBox
{
    /// <summary>
    /// Represents a single food item in the menu.
    /// </summary>
    public class FoodModel
    {
        /// <summary>Name of the food item.</summary>
        public string? Name { get; set; }

        /// <summary>Price of the food item in INR (₹).</summary>
        public double Price { get; set; }

        /// <summary>Category: Breakfast, Lunch, Dinner, Healthy, Snack, Dessert, Beverage.</summary>
        public string? Category { get; set; }

        /// <summary>Diet: Vegetarian, Vegan, Non-Vegetarian.</summary>
        public string? Diet { get; set; }

        public override string ToString() => Name ?? string.Empty;
    }
}

{% endhighlight %}
{% endtabs %}

**Step 2:** Build the ViewModel that owns the menu, exposes a `UserQuery` for the natural-language request, maintains the `SelectedItems` collection, and provides an `AskAICommand` that the page invokes when the user submits the query.

{% tabs %}
{% highlight c# tabtitle="FoodViewModel.cs" %}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace SmartAIComboBox.SmartAIComboBox
{
    /// <summary>
    /// ViewModel that owns the food menu, the user's natural-language query,
    /// the AI-selected items, and the command that triggers AI selection.
    /// </summary>
    public class FoodViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<FoodModel> _foods;
        private ObservableCollection<FoodModel> _selectedItems;
        private string? _userQuery;
        private bool _isBusy;

        /// <summary>Full menu of food items shown in the ComboBox.</summary>
        public ObservableCollection<FoodModel> Foods
        {
            get => _foods;
            set { _foods = value; OnPropertyChanged(nameof(Foods)); }
        }

        /// <summary>
        /// Items that the AI has selected inside the MultiSelect ComboBox.
        /// Bound to SfComboBox.SelectedItems.
        /// </summary>
        public ObservableCollection<FoodModel> SelectedItems
        {
            get => _selectedItems;
            set { _selectedItems = value; OnPropertyChanged(nameof(SelectedItems)); }
        }

        /// <summary>
        /// Natural-language request typed by the user (e.g. "Lunch under ₹200").
        /// </summary>
        public string? UserQuery
        {
            get => _userQuery;
            set { _userQuery = value; OnPropertyChanged(nameof(UserQuery)); }
        }

        /// <summary>
        /// Indicates that an AI request is currently in flight.
        /// </summary>
        public bool IsBusy
        {
            get => _isBusy;
            set { _isBusy = value; OnPropertyChanged(nameof(IsBusy)); }
        }

        /// <summary>Command that triggers the AI selection logic.</summary>
        public ICommand AskAICommand { get; }

        /// <summary>
        /// Raised when the AI returns matching item names. The page applies
        /// them to the ComboBox.SelectedItems collection.
        /// </summary>
        public event EventHandler<IEnumerable<string>>? AISelectionReceived;

        private CancellationTokenSource? _cts;

        public FoodViewModel()
        {
            _foods = new ObservableCollection<FoodModel>
            {
                // ---- Breakfast ----
                new FoodModel { Name = "Idli",                  Price = 40,  Category = "Breakfast", Diet = "Vegetarian" },
                new FoodModel { Name = "Dosa",                  Price = 70,  Category = "Breakfast", Diet = "Vegetarian" },
                new FoodModel { Name = "Masala Dosa",           Price = 80,  Category = "Breakfast", Diet = "Vegetarian" },
                new FoodModel { Name = "Pongal",                Price = 50,  Category = "Breakfast", Diet = "Vegetarian" },
                new FoodModel { Name = "Upma",                  Price = 45,  Category = "Breakfast", Diet = "Vegetarian" },
                new FoodModel { Name = "Vada",                  Price = 30,  Category = "Breakfast", Diet = "Vegetarian" },
                new FoodModel { Name = "Coffee",                 Price = 25,  Category = "Beverage",  Diet = "Vegetarian" },
                new FoodModel { Name = "Tea",                   Price = 20,  Category = "Beverage",  Diet = "Vegetarian" },

                // ---- Lunch ----
                new FoodModel { Name = "Veg Meals",             Price = 120, Category = "Lunch", Diet = "Vegetarian" },
                new FoodModel { Name = "Lemon Rice",             Price = 60,  Category = "Lunch", Diet = "Vegetarian" },
                new FoodModel { Name = "Curd Rice",              Price = 50,  Category = "Lunch", Diet = "Vegetarian" },
                new FoodModel { Name = "Sambar Rice",            Price = 70,  Category = "Lunch", Diet = "Vegetarian" },
                new FoodModel { Name = "Chapati",                Price = 30,  Category = "Lunch", Diet = "Vegetarian" },
                new FoodModel { Name = "Paneer Butter Masala",   Price = 160, Category = "Lunch", Diet = "Vegetarian" },
                new FoodModel { Name = "Biryani",                Price = 180, Category = "Lunch", Diet = "Non-Vegetarian" },
                new FoodModel { Name = "Grilled Chicken",        Price = 220, Category = "Lunch", Diet = "Non-Vegetarian" },

                // ---- Healthy ----
                new FoodModel { Name = "Oats",                  Price = 40,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Fruits",                 Price = 80,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Whole Wheat Bread",      Price = 35,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Vegetable Salad",        Price = 90,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Sprouts Salad",          Price = 70,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Brown Rice",             Price = 80,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Greek Yogurt",            Price = 75,  Category = "Healthy", Diet = "Vegetarian" },
                new FoodModel { Name = "Boiled Eggs",            Price = 35,  Category = "Healthy", Diet = "Non-Vegetarian" },

                // ---- Snacks ----
                new FoodModel { Name = "Samosa",                Price = 20,  Category = "Snack", Diet = "Vegetarian" },
                new FoodModel { Name = "Vada Pav",               Price = 25,  Category = "Snack", Diet = "Vegetarian" },
                new FoodModel { Name = "Pakora",                 Price = 30,  Category = "Snack", Diet = "Vegetarian" },

                // ---- Dessert ----
                new FoodModel { Name = "Gulab Jamun",            Price = 45,  Category = "Dessert", Diet = "Vegetarian" },
                new FoodModel { Name = "Ice Cream",              Price = 60,  Category = "Dessert", Diet = "Vegetarian" },
            };

            _selectedItems = new ObservableCollection<FoodModel>();
            AskAICommand = new Command(async () => await AskAIAsync());
        }

        /// <summary>
        /// Sends the user query and the menu to Azure OpenAI and raises
        /// AISelectionReceived with the matched item names.
        /// </summary>
        private async Task AskAIAsync()
        {
            if (string.IsNullOrWhiteSpace(UserQuery) || IsBusy)
                return;

            IsBusy = true;

            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            try
            {
                var aiService = new ComboBoxAzureAIService();
                if (!AzureBaseService.IsCredentialValid)
                {
                    IsBusy = false;
                    return;
                }

                // Build a structured menu description so AI can match intent precisely.
                string menu = string.Join("\n",
                    Foods.Select(f => $"{f.Name} | ₹{f.Price} | {f.Category} | {f.Diet}"));

                string prompt =
                    "You are an AI food-selection assistant for a MultiSelect food menu.\n" +
                    "From the menu below, choose the items that best match the user's natural-language request.\n\n" +
                    "Rules:\n" +
                    "- Return ONLY the exact food Names from the menu, one per line.\n" +
                    "- Do NOT include prices, categories, numbers, dashes, explanations, or any other text.\n" +
                    "- Do NOT include headings like 'Here are the items'.\n" +
                    "- Interpret intent: a budget like 'under ₹200' restricts Price; 'lunch' restricts " +
                    "Category to Lunch; 'healthy' restricts Category to Healthy; " +
                    "'breakfast' restricts Category to Breakfast. Combine constraints when given.\n" +
                    "- If multiple constraints are given, return items satisfying ALL of them.\n" +
                    "- If no items match, return exactly the word: Empty\n\n" +
                    "Menu (Name | Price | Category | Diet):\n" + menu + "\n\n" +
                    "User request: " + UserQuery + "\n\n" +
                    "Matching items (one per line):";

                string completion = await aiService.GetCompletion(prompt, token);
                token.ThrowIfCancellationRequested();

                // Parse the AI response into a clean list of names.
                var matches = completion
                    .Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim()
                                  .TrimStart('-', '•',
                                             '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                                             '.', ')')
                                  .TrimEnd())
                    .Where(s => !string.IsNullOrWhiteSpace(s) &&
                                !s.Equals("Empty", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                AISelectionReceived?.Invoke(this, matches);
            }
            catch (OperationCanceledException)
            {
                // User triggered a new request before this one finished.
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AI selection failed: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

{% endhighlight %}
{% endtabs %}

**Step 3:** Define a value converter that inverts a bool so the Entry and Button can be disabled while a request is in flight.

{% tabs %}
{% highlight c# tabtitle="InverseBoolConverter.cs" %}

using System.Globalization;

namespace SmartAIComboBox.SmartAIComboBox
{
    /// <summary>
    /// Inverts a bool value. Used to disable the Entry and Button
    /// while an AI request is in flight (IsBusy == true).
    /// </summary>
    public class InverseBoolConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
            => value is bool b ? !b : false;

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
            => value is bool b ? !b : false;
    }
}

{% endhighlight %}
{% endtabs %}

**Step 4:** Build the page that hosts the AI request entry and the MultiSelect ComboBox, and apply the AI's matched names to the ComboBox's [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectedItems) collection.

{% tabs %}
{% highlight xaml tabtitle="SmartAIComboBoxPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="SmartAIComboBox.SmartAIComboBox.SmartAIComboBoxPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
             xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             xmlns:local="clr-namespace:SmartAIComboBox.SmartAIComboBox"
             Title="AI MultiSelect ComboBox">
    <ContentPage.BindingContext>
        <local:FoodViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <local:InverseBoolConverter x:Key="InverseBoolConverter"/>
    </ContentPage.Resources>

    <ContentPage.Content>
        <VerticalStackLayout Spacing="20"
                             Margin="20,40,20,0"
                             WidthRequest="320"
                             HorizontalOptions="Center"
                             VerticalOptions="Start">

            <Label Text="AI-Powered Smart Selection"
                   FontSize="18"
                   FontAttributes="Bold"
                   TextColor="{AppThemeBinding Light='#1C1B1F', Dark='#E6E1E5'}"
                   HorizontalOptions="Center"/>

            <Label Text="Describe what you need — AI understands the intent and the MultiSelect ComboBox performs the selection."
                   FontSize="13"
                   HorizontalTextAlignment="Center"
                   TextColor="{AppThemeBinding Light='#49454F', Dark='#CAC4D0'}"/>

            <!-- Natural-language request box -->
            <syncfusion:SfTextInputLayout Hint="Ask AI (e.g. Lunch under ₹200, Healthy breakfast)"
                                          ContainerType="Outlined"
                                          WidthRequest="318"
                                          ContainerBackground="Transparent">
                <Entry x:Name="QueryEntry"
                       Text="{Binding UserQuery, Mode=TwoWay}"
                       ReturnType="Search"
                       ReturnCommand="{Binding AskAICommand}"
                       IsEnabled="{Binding IsBusy, Converter={StaticResource InverseBoolConverter}}"/>
            </syncfusion:SfTextInputLayout>

            <Button Text="Ask AI"
                    Command="{Binding AskAICommand}"
                    BackgroundColor="#6750A4"
                    TextColor="White"
                    CornerRadius="8"
                    HeightRequest="44"
                    IsEnabled="{Binding IsBusy, Converter={StaticResource InverseBoolConverter}}"/>

            <!-- MultiSelect ComboBox -->
            <syncfusion:SfTextInputLayout Hint="AI-selected items"
                                          ContainerType="Outlined"
                                          WidthRequest="318"
                                          ContainerBackground="Transparent">
                <editors:SfComboBox x:Name="comboBox"
                                    SelectionMode="Multiple"
                                    IsEditable="True"
                                    IsFilteringEnabled="True"
                                    DropDownPlacement="Bottom"
                                    MaxDropDownHeight="220"
                                    DisplayMemberPath="Name"
                                    TextMemberPath="Name"
                                    ItemsSource="{Binding Foods}"
                                    SelectedItems="{Binding SelectedItems, Mode=TwoWay}"/>
            </syncfusion:SfTextInputLayout>

            <Label x:Name="StatusLabel"
                   FontSize="12"
                   TextColor="#6750A4"
                   IsVisible="False"/>
        </VerticalStackLayout>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="SmartAIComboBoxPage.xaml.cs" %}

namespace SmartAIComboBox.SmartAIComboBox;

public partial class SmartAIComboBoxPage : ContentPage
{
    public SmartAIComboBoxPage()
    {
        InitializeComponent();
        BindingContextChanged += OnBindingContextChanged;
    }

    private void OnBindingContextChanged(object? sender, EventArgs e)
    {
        if (BindingContext is FoodViewModel vm)
        {
            vm.AISelectionReceived += OnAISelectionReceived;
        }
    }

    /// <summary>
    /// Applies the AI-matched names to the MultiSelect ComboBox's
    /// SelectedItems collection and opens the dropdown.
    /// </summary>
    private void OnAISelectionReceived(object? sender, IEnumerable<string> matchedNames)
    {
        if (BindingContext is not FoodViewModel vm)
            return;

        // Match AI-returned names against the food list (case-insensitive, trimmed).
        var nameSet = matchedNames
            .Select(n => n?.Trim())
            .Where(n => !string.IsNullOrWhiteSpace(n))
            .Select(n => n!)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        var toSelect = vm.Foods
            .Where(f => f.Name != null && nameSet.Contains(f.Name))
            .ToList();

        MainThread.BeginInvokeOnMainThread(() =>
        {
            vm.SelectedItems.Clear();
            foreach (var item in toSelect)
                vm.SelectedItems.Add(item);

            // Show selection status to the user.
            StatusLabel.Text = toSelect.Count > 0
                ? $"AI selected {toSelect.Count} item(s)."
                : "AI could not find matching items.";
            StatusLabel.IsVisible = true;

            // Open the dropdown so the user can see and refine the selection.
            comboBox.IsDropDownOpen = true;
        });
    }
}

{% endhighlight %}
{% endtabs %}

The following image demonstrates the AI-driven selection inside the MultiSelect ComboBox.

![.NET MAUI MultiSelect ComboBox With AI Smart Selection.](Images/AISelection/ai_multi_select.gif)

You can find the complete sample from this [link.](https://github.com/SyncfusionExamples/Smart-AI-Searching-using-.NET-MAUI-ComboBox)

## See also

* [Getting Started](https://help.syncfusion.com/maui/combobox/getting-started)
* [Multiple Selection](https://help.syncfusion.com/maui/combobox/multiple-selection)
* [Searching](https://help.syncfusion.com/maui/combobox/searching)
* [Filtering](https://help.syncfusion.com/maui/combobox/filtering)