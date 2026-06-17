---
layout: post
title: AI-Powered Smart Filtering in SfAutocomplete Control | Syncfusion®
description: Learn about how to implement AI-powered smart filter using Syncfusion® .NET MAUI Autocomplete control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Implementing AI-Powered Smart filter in .NET MAUI Autocomplete

This document will walk you through the implementation of an advanced filter functionality in the Syncfusion [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control. The example leverages the power of Azure OpenAI for an intelligent, AI-driven filter experience.

## Integrating Azure OpenAI with your .NET MAUI App

First, ensure you have access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and have created a deployment in the Azure portal.

If you don’t have access, please refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account.

Note down the deployment name, endpoint URL, and API key.

we’ll use the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12) NuGet package from the [NuGet Gallery](https://www.nuget.org/). So, before getting started, install the Azure.AI.OpenAI NuGet package in your .NET MAUI app.

In your base service class (AzureBaseService), initialize the OpenAIClient. Replace the Endpoint, DeploymentName, Key with actual values from your Azure OpenAI resource.

This creates a chat client using your endpoint, API key, and deployment name. It’s stored in the Client property for use in other methods.

ComboBoxAzureAIService use this Client to send prompts and receive completions.

In the `GetCompletion` method, we will construct the prompt and send it to the Azure OpenAI Service. The ChatHistory helps maintain context but is cleared for each new prompt in this implementation to ensure each filter is independent.

{% tabs %}
{% highlight c# %}

// AzureBaseService.cs
    public abstract class AzureBaseService
    {        
        internal const string Endpoint = "YOUR_END_POINT_NAME";

        internal const string DeploymentName = "DEPLOYMENT_NAME";

        internal const string Key = "API_KEY";

        public AzureBaseService()
        {
        }
                        
        /// <summary>
        /// To get the Azure open ai kernal method
        /// </summary>
        private void GetAzureOpenAIKernal()
        {
            try
            {
                var client = new AzureOpenAIClient(new Uri(Endpoint), new AzureKeyCredential(Key)).AsChatClient(modelId: DeploymentName);
                this.Client = client;
            }
            catch (Exception)
            {
            }
        }
        
    }

{% endhighlight %}

{% endtabs %}

{% tabs %}
{% highlight c# %}

//AzureAIService.cs

public class AzureAIService : AzureBaseService
    {
        /// <summary>
        /// Gets a completion response from the AzureAI service based on the provided prompt.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<string> GetCompletion(string prompt, CancellationToken cancellationToken)
        {
            if (_chatCompletion != null)
            {
                // Use a fresh chat history per request to avoid stale context affecting results
                var requestHistory = new ChatHistory();
                requestHistory.AddUserMessage(prompt);
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    var chatresponse = await _chatCompletion.GetChatMessageContentAsync(chatHistory: requestHistory, kernel: _kernel);
                    cancellationToken.ThrowIfCancellationRequested();
                    return chatresponse.ToString();
                }
                catch (RequestFailedException ex)
                {
                    // Log the error message and rethrow the exception or handle it appropriately
                    Debug.WriteLine($"Request failed: {ex.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    // Handle other potential exceptions
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                    throw;
                }
            }
            return "";
        }

{% endhighlight %}

{% endtabs %}

## Implementing custom filtering in .NET MAUI Autocomplete

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control allows you to apply custom filter logic to suggest items based on your specific filter criteria by utilizing the `FilterBehavior` property, which is the entry point for our smart filter logic.

**Step 1:** Let’s create a new business model to filter food names. Refer to the following code example.

{% tabs %}
{% highlight c# %}

// Model.cs

public class AutocompleteModel
{
    public string? Name { get; set; }
}

//ViewModel.cs

public class AutocompleteViewModel : INotifyPropertyChanged
{
    private ObservableCollection<AutocompleteModel> foods;

    public ObservableCollection<AutocompleteModel> Foods
    {
        get { return foods; }
        set { foods = value; OnPropertyChanged(nameof(Foods)); }
    }
    public AutocompleteViewModel()
    {
        foods = new ObservableCollection<AutocompleteModel>
        {
            new AutocompleteModel { Name = "BBQ Pulled Pork" },
            new AutocompleteModel { Name = "BBQ Brisket" },
            new AutocompleteModel { Name = "BBQ Ribs" },
            new AutocompleteModel { Name = "Bacon Cheeseburger" },
            new AutocompleteModel { Name = "Baked Meatloaf" },
            new AutocompleteModel { Name = "Beef Tacos" },
            new AutocompleteModel { Name = "Cheeseburger" },
            new AutocompleteModel { Name = "Chicken Pot Pie" },
            new AutocompleteModel { Name = "Chicken Tenders" },
            new AutocompleteModel { Name = "Chili Con Carne" },
            ...
        };
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

{% endhighlight %}

{% endtabs %}

**Step 2:** Connecting the Custom Filter to Azure OpenAI

Implement the `GetMatchingItemsAsync` method from the interface. This method is the heart of the custom filter. It is invoked every time the text in the [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control changes. 

The logic within [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) intelligently decides whether to perform an online AI filter based on the availability of Azure credentials.

To get accurate and structured results from the AI, we must provide a detailed prompt. This is constructed inside the 
`FilterItemsUsingAzureAI` method.

The `FilterItemsUsingAzureAI` method uses prompt engineering to instruct the AI on how to filter the results, including asking it to handle spelling mistakes and providing the response in a clean format.

{% tabs %}
{% highlight c# %}

//CustomFilter.cs

public class AutocompleteFilterBehavior : IAutocompleteFilterBehavior
{
    private readonly AzureOpenAIService _azureAIService;
    public ObservableCollection<AutocompleteModel> Items { get; set; }
    public ObservableCollection<AutocompleteModel> FilteredItems { get; set; } = new ObservableCollection<AutocompleteModel>();
    private CancellationTokenSource? _cancellationTokenSource;

    public AutocompleteFilterBehavior()
    {
        _azureAIService = new AzureOpenAIService();
        Items = new ObservableCollection<AutocompleteModel>();
        _cancellationTokenSource = new CancellationTokenSource();
    }

    

    /// <summary>
    ///  Finds matching items using the typed text
    /// </summary>
    /// <param name="source"></param>
    /// <param name="filterInfo"></param>
    /// <returns></returns>
    public async Task<object?> GetMatchingItemsAsync(SfAutocomplete source, AutocompleteFilterInfo filterInfo)
    {
        //If crendential is not valid the filtering data shows as empty
        if (!_azureAIService.IsCredentialValid)
        {
            FilteredItems.Clear();
            return await Task.FromResult(FilteredItems);
        }

        if (string.IsNullOrEmpty(filterInfo.Text))
        {
            _cancellationTokenSource?.Cancel();
            FilteredItems.Clear();
            return await Task.FromResult(FilteredItems);
        }

        Items = (ObservableCollection<AutocompleteModel>)source.ItemsSource;

        string listItems = string.Join(", ", Items!.Select(c => c.Name));

        // Join the first five items with newline characters for demo output template for AI           
        string outputTemplate = string.Join("\n", Items.Take(5).Select(c => c.Name));

        //The cancellationToken was used for cancelling the API request if user types continuously       
        _cancellationTokenSource?.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = _cancellationTokenSource.Token;

        //Passing the User Input, ItemsSource, Reference output and CancellationToken
        var filterCountries = await FilterItemsUsingAzureAI(filterInfo.Text, listItems, outputTemplate, cancellationToken);

        return await Task.FromResult(filterCountries);
    }

    /// <summary>
    /// Filters country names based on user input using Azure AI.
    /// </summary>
    /// <param name="userInput"></param>
    /// <param name="itemsList"></param>
    /// <param name="outputTemplate"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ObservableCollection<AutocompleteModel>> FilterItemsUsingAzureAI(string userInput, string itemsList, string outputTemplate, CancellationToken cancellationToken)
    {
        if (!string.IsNullOrEmpty(userInput))
        {
            var prompt =
            $"You are a strict food item filtering engine." +
            $"Your job is to filter ONLY relevant items from the provided list." +
            $"STEP 1 — CLASSIFY USER INTENT" +
            $"Extract filters from the user query." +
            $"Possible filters:" +

            $"Diet- veg, non veg, vegan, egg, halal" +
            $"Ingredients:- chicken- beef- mutton- fish- seafood- pork- paneer- cheese- rice- noodles- bread" +
            $"Other:- spicy- sweet- fried- grilled- healthy- breakfast- lunch- dinner- snack- drink- dessert" +

            $"STEP 2 — CLASSIFY EACH ITEM" +
            $"For EACH item, determine:" +
            $"- Is it veg?- Is it non veg ?-Does it contain egg?-Main ingredients- Food category" +
            $"Use the ITEM NAME ONLY." +
            $"Examples:" +
            $"Veg:- Veg Burger- Paneer Burger- Margherita Pizza- Cheese Sandwich" +
            $"Non Veg:- Chicken Burger- Beef Burger- Fish Fry- Mutton Biryani- Pepper Chicken" +

            $"IMPORTANT:- Cheeseburger is NOT automatically non veg-Only treat an item as non veg if the name explicitly contains: chicken, beef, mutton, fish, seafood, prawn, shrimp, pork, meat, turkey, lamb" +
            $"If meat is NOT explicitly mentioned, DO NOT assume non veg." +
            $"STEP 3 — HARD FILTERING (MANDATORY)" +
            $"Apply strict exclusions BEFORE ranking." +
            $"RULES:" +
            $"1. If user asks 'veg': EXCLUDE any item containing: chicken, beef, mutton, fish, seafood, prawn, shrimp, pork, meat, egg" +
            $"2. If user asks 'non veg':INCLUDE ONLY items explicitly containing:chicken, beef, mutton, fish, seafood, prawn, shrimp, pork, meat, egg, lamb, turkey. EXCLUDE:paneer,cheese,veg,vegetarian,vegan,margherita" +

            $" 3. NEVER infer meat from category names like: burger, pizza, sandwich, noodles, rice" +
            $" 4. If multiple filters exist, ALL must match." +

            $" STEP 4 — MATCHING PRIORITY" +
            $" Priority order:" +
            $" 1. Exact item name match" +
            $" 2.Fuzzy / spelling similarity" +
            $" 3.Full filter match" +
            $" 4.Partial match" +

            $"Partial match is allowed ONLY if diet rules are satisfied." +
            $"STEP 5 — OUTPUT RULES" +
            $"- Return ONLY item names from the list, One per line, No numbering, No explanation, No extra text, NEVER generate new items, If no items match, return exactly: Empty" +

         $" User Input: {userInput} " +
         $" List of Items: {itemsList} " +
         $" Expected Output Format: {outputTemplate}";

            var completion = await _azureAIService.GetCompletion(prompt, cancellationToken);

            var filteredCountryNames = completion.Split('\n').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToList();

            if (FilteredItems.Count > 0)
                FilteredItems.Clear();
            if (completion.ToLower().Trim() != "empty")
            {
                foreach (var country in filteredCountryNames)
                {
                    FilteredItems.Add(new AutocompleteModel { Name = country });
                }
            }
        }
        return FilteredItems;
    }
}

{% endhighlight %}

{% endtabs %}

**Step:3** Applying Custom Filtering to AutoComplete

Applying custom filtering to the [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control by using the `AutocompleteFilterBehavior` property.

{% tabs %}
{% highlight xaml %}
    <input:SfAutocomplete x:Name="autoComplete"
                        DropDownPlacement="Bottom"
                        MaxDropDownHeight="200"
                        TextSearchMode="StartsWith"
                        DisplayMemberPath="Name"
                        ItemsSource="{Binding Foods}">
        <input:SfAutocomplete.FilterBehavior>
            <local:AutocompleteFilterBehavior />
        </input:SfAutocomplete.FilterBehavior>
    </input:SfAutocomplete>
{% endhighlight %}

{% endtabs %}

The following image demonstrates the output of the above AI-based filter using a custom filtering sample.

![.NET MAUI AutoComplete With AI Smart filter.](Images/AISmartFilter/ai_smart_filter_autocomplete)

You can find the complete sample from this [link](https://github.com/SyncfusionExamples/dotnet-maui-ai-autocomplete-smart-filtering).

By combining a powerful AI-driven online filter with a robust you can create a truly smart and reliable filter experience in your .NET MAUI applications.