---
layout: post
title: AI-Powered Smart Searching in SfAutocomplete Control | Syncfusion®
description: Learn about how to implement AI-powered smart search using Syncfusion .NET MAUI Autocomplete control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Implementing AI-Powered Smart Search in .NET MAUI Autocomplete

This document will walk you through the implementation of an advanced search functionality in the Syncfusion `.NET MAUI SfAutocomplete` control. The example leverages the power of Azure OpenAI for an intelligent, AI-driven search experience while also providing a robust, offline fallback using phonetic and fuzzy search algorithms.

## Implementing custom filtering in .NET MAUI Autocomplete

The `.NET MAUI Autocomplete` control allows you to apply custom filter logic to suggest items based on your specific filter criteria by utilizing the `FilterBehavior` property, which is the entry point for our smart search logic.

{% tabs %}
{% highlight c# %}

// Model.cs
public class ComboBoxModel
{
    public string? Name { get; set; }
}

//ViewModel.cs
public class ComboBoxViewModel : INotifyPropertyChanged
{
        private ObservableCollection<ComboBoxModel> foods;

        public ObservableCollection<ComboBoxModel> Foods
        {
            get { return foods; }
            set { foods = value; OnPropertyChanged(nameof(Foods)); }
        }
        public ComboBoxViewModel()
        {
             foods = new ObservableCollection<ComboBoxModel>
             {
                new ComboBoxModel { Name = "Acai Bowl" },
                new ComboBoxModel { Name = "Aloo Gobi" },
                new ComboBoxModel { Name = "Arepas" },
                new ComboBoxModel { Name = "Baba Ganoush" },
                new ComboBoxModel { Name = "Bagels" },
                new ComboBoxModel { Name = "Bahn Xeo" },
                ....
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
}

{% endhighlight %}

{% endtabs %}

### Connecting the Custom Filter to Azure OpenAI

 Implement the `GetMatchingItemsAsync` method from the interface. This method is the heart of the custom filter. It is invoked every time the text in the `Autocomplete` control changes. 

The logic within `GetMatchingItemsAsync` intelligently decides whether to perform an online AI search or an offline algorithmic search based on the availability of Azure credentials.

To get accurate and structured results from the AI, we must provide a detailed prompt. This is constructed inside the 
`FilterCountriesUsingAzureAI` method.

The `FilterCountriesUsingAzureAI` method uses prompt engineering to instruct the AI on how to filter the results, including asking it to handle spelling mistakes and providing the response in a clean, parsable format.

{% tabs %}
{% highlight c# %}

//ComboBoxCustomFilter.cs

public class ComboBoxCustomFilter : IComboBoxFilterBehavior
{
        private readonly ComboBoxAzureAIService _azureAIService;
        public ObservableCollection<ComboBoxModel> Items { get; set; }
        public ObservableCollection<ComboBoxModel> FilteredItems { get; set; } = new ObservableCollection<ComboBoxModel>();
        private CancellationTokenSource? _cancellationTokenSource;
        private SoundexAndLevensteinAlgorithm soundexAndLevensteinAlgorithm;

        public ComboBoxCustomFilter()
        {
            _azureAIService = new ComboBoxAzureAIService();
            Items = new ObservableCollection<ComboBoxModel>();
            _cancellationTokenSource = new CancellationTokenSource();
            soundexAndLevensteinAlgorithm = new SoundexAndLevensteinAlgorithm();
        }

        public async Task<object?> GetMatchingIndexes(SfComboBox source, ComboBoxFilterInfo filterInfo)
        {
            Items = (ObservableCollection<ComboBoxModel>)source.ItemsSource;

            if (string.IsNullOrEmpty(filterInfo.Text))
            {
                _cancellationTokenSource?.Cancel();
                return await Task.FromResult(Items);
            }
            
            // If the Azure API credential is invalid, perform an offline search using Soundex and Levenshtein algorithms.
            if (!AzureBaseService.IsCredentialValid)
            {
                foreach (ComboBoxModel item in Items)
                {
                    soundexAndLevensteinAlgorithm.FilterItemsBySoundexAndLevenshtein(filterInfo.Text, item.Name!);
                }
                var filteredItemsInOrder = soundexAndLevensteinAlgorithm.GetOrder();              
                return await Task.FromResult(filteredItemsInOrder);
            }           

            string listItems = string.Join(", ", Items!.Select(c => c.Name));

            // Join the first five items with newline characters for demo output template for AI.           
            string outputTemplate = string.Join("\n", Items.Take(5).Select(c => c.Name));

            //The cancellationToken was used for cancelling the API request if user types continuously.       
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _cancellationTokenSource.Token;

            //Passing the User Input, ItemsSource, Reference output and CancellationToken
            var filteredItems = await FilterItemsUsingAzureAI(filterInfo.Text, listItems, outputTemplate, cancellationToken);
          
            return await Task.FromResult(filteredItems);
        }

        public async Task<ObservableCollection<ComboBoxModel>> FilterItemsUsingAzureAI(string userInput, string itemsList, string outputTemplate, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                var prompt = $"Filter the list items based on the user input using character Starting with and Phonetic algorithms like Soundex or Damerau-Levenshtein Distance. " +
                           $"The filter should ignore spelling mistakes and be case insensitive. " +
                           $"Return only the filtered items with each item in new line without any additional content like explanations, Hyphen, Numberings and - Minus sign. Ignore the content 'Here are the filtered items or similar things' " +
                           $"Only return items that are present in the List Items. " +
                           $"Ensure that each filtered item is returned in its entirety without missing any part of its content. " +
                           $"Arrange the filtered items that starting with the user input's first letter are at the first index, followed by other matches. " +
                           $"Examples of filtering behavior: " +
                           $" userInput: a, filter the items starting with A " +
                           $" userInput: b, filter items starting with B " +
                           $" userInput: c, filter items starting with C " +
                           $" userInput: d, filter items starting with D " +
                           $" userInput: e, filter items starting with E " +
                           $" userInput: f, filter items starting with F " +
                           $" userInput: i, filter items starting with I " +
                           $" userInput: z, filter items starting with Z " +
                           $" userInput: l, filter items starting with L " +
                           $" userInput: q, filter items starting with Q " +
                           $" userInput: o, filter items starting with O " +
                           $" userInput: in, filter items starting with In " +
                           $" userInput: pa, filter items starting with Pa " +
                           $" userInput: em, filter items starting with Em " +
                           $"The example data are for reference, dont provide these as output. Filter the item from list items properly" +
                           $"Here is the User input: {userInput}, " +
                           $"List of Items: {itemsList}" +
                           $"If no items found, return \"Empty\" " +
                           $"Dont use 'Here are the filtered items:' in the output. Check this demo output template, you should return output like this: {outputTemplate} ";

                var completion = await _azureAIService.GetCompletion(prompt, cancellationToken);

                var filteredItems = completion.Split('\n').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToList();

                if (FilteredItems.Count > 0)
                    FilteredItems.Clear();
                FilteredItems.AddRange(
                        Items
                        .Where(i => filteredItems.Any(item => i.Name!.StartsWith(item))));

                cancellationToken.ThrowIfCancellationRequested();
            }
            return FilteredItems;
        }
}

{% endhighlight %}

{% endtabs %}

Applying custom filtering to the `Autocomplete` control by using the `FilterBehavior` property.

{% tabs %}
{% highlight c# %}

<syncfusion:SfTextInputLayout Hint="Enter Country Name"
                              ContainerType="Outlined"
                              WidthRequest="248"
                              ContainerBackground="Transparent">
    <editors:SfAutocomplete x:Name="autoComplete" 
                              DropDownPlacement="Bottom"
                              MaxDropDownHeight="200"
                              TextSearchMode="Contains"
                              DisplayMemberPath="Name"
                              TextMemberPath="Name"
                              ItemsSource="{Binding Countries}">
        <editors:SfAutocomplete.FilterBehavior>
            <local:CustomFilter/>
        </editors:SfAutocomplete.FilterBehavior>
    </editors:SfAutocomplete>
</syncfusion:SfTextInputLayout>

{% endhighlight %}

{% endtabs %}

## Online Search: Integrating with Azure OpenAI

When Azure credentials are available, the application performs a real-time, intelligent search using AI.

### The Azure AI Service

In the `GetCompletion` method, we will construct the prompt and send it to the Azure OpenAI Service. The ChatHistory helps maintain context but is cleared for each new prompt in this implementation to ensure each search is independent.

{% tabs %}
{% highlight c# %}

//ComboBoxAzureAIService.cs

public class ComboBoxAzureAIService : AzureBaseService
{
        /// <summary>
        /// Gets a completion response from the AzureAI service based on the provided prompt.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<string> GetCompletion(string prompt, CancellationToken cancellationToken)
        {
            ChatHistory = string.Empty;
            if (ChatHistory != null && Client != null)
            {
                ChatHistory = ChatHistory + "You are a filtering assistant.";
                // Add the user message to the options
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
}

{% endhighlight %}

{% endtabs %}

## Offline Search with Soundex and Levenshtein Distance

For a seamless user experience when offline, the application implements a fallback using the Filtering Algorithm.

`Soundex` is a phonetic algorithm that indexes names by their sound when pronounced in English. It is excellent for matching names that sound similar but are spelled differently.
`Damerau-Levenshtein distance` is a string metric that measures the "edit distance" between two sequences. It is highly effective at catching common typing errors.

The `FilterItemsBySoundexAndLevenshtein`method calculates these values, and any item that is a phonetic match or within a close spelling distance is added to the results. 

The `GetOrder` method then sorts these results by their edit distance, ensuring the most accurate matches appear first.

{% tabs %}
{% highlight c# %}

//SoundexAndLevensteinAlgorithm.cs

public class SoundexAndLevensteinAlgorithm
{
        ObservableCollection<string> processedItems = new ObservableCollection<string>();
        ObservableCollection<SearchData> filteredSearchResults = new ObservableCollection<SearchData>();

        List<string> soundexTerms = new List<string>() { };

        public SoundexAndLevensteinAlgorithm()
        {
            soundexTerms.Add("aeiouhyw");
            soundexTerms.Add("bfpv");
            soundexTerms.Add("cgikqsxz");
            soundexTerms.Add("dt");
            soundexTerms.Add("l");
            soundexTerms.Add("mn");
            soundexTerms.Add("r");
        }

        /// <summary>
        /// Validate the Soundex and Levenshtein Distance for the user input against each source item.
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="itemValue"></param>
        /// <returns></returns>
        public bool FilterItemsBySoundexAndLevenshtein(object inputValue, object itemValue)
        {
            if (inputValue != null && itemValue != null)
            {
                var inputString = inputValue.ToString()!.ToLower();
                var itemString = itemValue.ToString()!.ToLower();
                if (inputString.Length > 0 && itemString.Length > 0)
                    if (inputString[0] != itemString[0])
                        return false;
                var trimmedInputString = string.Empty;
                var trimmedItemString = string.Empty;

                if (inputString.Length < itemString.Length)
                {
                    trimmedItemString = itemString.Remove(inputString.Length);
                    trimmedInputString = inputString;
                }

                if (itemString.Length < inputString.Length)
                {
                    return false;
                }

                if (itemString.Length == inputString.Length)
                {
                    trimmedInputString = inputString;
                    trimmedItemString = itemString;
                }
                bool IsMatchSoundex = ProcessOnSoundexAlgorithmn(trimmedInputString) == ProcessOnSoundexAlgorithmn(trimmedItemString);
                int Distance = GetDamerauLevenshteinDistance(trimmedInputString, trimmedItemString);

                if (IsMatchSoundex || Distance <= 4)
                {
                    var searchData = new SearchData() { Item = itemValue.ToString(), Distance = Distance };
                    if (!processedItems.Contains(itemValue.ToString()!))
                    {
                        filteredSearchResults.Add(searchData);
                        processedItems.Add(itemValue.ToString()!);
                    }
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        /// <summary>
        /// Computes the Soundex value for the given input string.
        /// </summary>
        /// <returns>The on soundex algorithmn.</returns>
        /// <param name="input">Input.</param>
        /// <param name="moreAccuracy">If set to <c>true</c> more accuracy.</param>
        public string ProcessOnSoundexAlgorithmn(string input, bool moreAccuracy = true)
        {
            string stringValue = string.Empty;
            foreach (var item in input.ToLower())
            {
                for (int i = 0; i < soundexTerms.Count; i++)
                {
                    if (soundexTerms[i].Contains(item.ToString()))
                    {
                        stringValue += i.ToString();
                        continue;
                    }
                }
            }
            if (stringValue.Length > 0)
            {
                if (moreAccuracy)
                {
                    stringValue = stringValue.Insert(0, input[0].ToString());
                    stringValue = stringValue.Replace("0", "");
                }
            }
            return stringValue;
        }

        /// <summary>
        /// Computes the Damerau-Levenshtein distance between two strings
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int GetDamerauLevenshteinDistance(string source, string target)
        {
            var bounds = new { Height = source.Length + 1, Width = target.Length + 1 };

            int[,] matrix = new int[bounds.Height, bounds.Width];

            for (int height = 0; height < bounds.Height; height++) { matrix[height, 0] = height; };
            for (int width = 0; width < bounds.Width; width++) { matrix[0, width] = width; };

            for (int height = 1; height < bounds.Height; height++)
            {
                for (int width = 1; width < bounds.Width; width++)
                {
                    int cost = (source[height - 1] == target[width - 1]) ? 0 : 1;
                    int insertion = matrix[height, width - 1] + 1;
                    int deletion = matrix[height - 1, width] + 1;
                    int substitution = matrix[height - 1, width - 1] + cost;

                    int distance = Math.Min(insertion, Math.Min(deletion, substitution));

                    if (height > 1 && width > 1 && source[height - 1] == target[width - 2] && source[height - 2] == target[width - 1])
                    {
                        distance = Math.Min(distance, matrix[height - 2, width - 2] + cost);
                    }

                    matrix[height, width] = distance;
                }
            }
            return matrix[bounds.Height - 1, bounds.Width - 1];
        }

        /// <summary>
        /// Arrange and return filtered items based on their Levenshtein distance
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<ComboBoxModel> GetOrder()
        {
            ObservableCollection<ComboBoxModel> orderedSource = new ObservableCollection<ComboBoxModel>();
            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int c = 0; c < filteredSearchResults.Count; c++)
                {
                    count++;
                    if (filteredSearchResults[c] != null && filteredSearchResults[c].Distance == i)
                    {
                        orderedSource.Add(new ComboBoxModel() { Name = filteredSearchResults[c].Item! });
                    }
                }
            }
            processedItems.Clear();
            filteredSearchResults.Clear();
            return orderedSource;
        }
}

{% endhighlight %}

{% endtabs %}

The following image demonstrates the output of the above AI-based search using a custom filtering sample.

![.NET MAUI AutoComplete With AI Smart Search.](Images/\AISmartSearch/ai_smart_ssearch.png)

By combining a powerful AI-driven online search with a robust, algorithm-based offline fallback, you can create a truly smart and reliable search experience in your .NET MAUI applications.