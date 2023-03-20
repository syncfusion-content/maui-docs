---
layout: post
title: Text Search in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about searching a text in the PDF documents using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer).
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Text Search in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to search for text in a PDF document and navigate to all its occurrences.

## Initiate a text search

The `SearchTextAsync` method asynchronously searches the specified text throughout the PDF document and highlights each occurrence (match). To start the search, you need to call the method in a button click by passing the text to be searched as a parameter as shown in the following example.

{% tabs %}
{% highlight C# hl_lines="8" %}

    private void SearchButtonClicked(object sender, EventArgs e)
    {
        SearchText("key");
    }

    async void SearchText(string text)
    {
        await PdfViewer.SearchTextAsync(text);
    }

{% endhighlight %}
{% endtabs %}

### Search result

The `TextSearchResult` will be obtained at the end of search text operation and it will hold search result. It allows you to navigate to next or previous matches of the text as well as provides the following details.

1. <b>Total matches count</b> – It provides the total number of matches that have been found in the PDF document.

2. <b>Current match index</b> – It gives the index of the current focused match. The value is index based.

{% tabs %}
{% highlight C# hl_lines="5 6" %}

    async void SearchText(string text)
    {
        TextSearchResult searchResult = await PdfViewer.SearchTextAsync(text);
        // Get the total matches count and current match index.
        int totalMatchesCount = searchResult.TotalMatchesCount;
        int currentMatchIndex = searchResult.CurrentMatchIndex;
    }

{% endhighlight %}
{% endtabs %}

N> * The current match index value may change on every search call for a given text, depending on the page from which you started the search.
* If the total matches count is 0, then there were no matches found for the given text.

### Navigate to the next and previous match

The `GoToNextMatch` and `GoToPreviousMatch` functionalities of the `TextSearchResult` help you to navigate to the next and previous matches of the text respectively. You can follow the below steps to achieve the same.

1.	Search a text and store the search result in a global variable.

{% tabs %}
{% highlight C# %}

    /// <summary>
    /// Stores the search result obtained from searching the text.
    /// </summary>
    TextSearchResult SearchResult;

    async void SearchText(string text)
    {
        SearchResult = await PdfViewer.SearchTextAsync(text);
    }

{% endhighlight %}
{% endtabs %}

2.	Call the `GoToNextMatch` or `GoToPreviousMatch` functionalities in a button click to move to the next or previous match of the text respectively, whenever necessary.

{% tabs %}
{% highlight C# hl_lines="4 10" %}

    private void NextMatchButtonClicked(object sender, EventArgs e)
    {
        // Navigate to the next match.
        SearchResult.GoToNextMatch();
    }

    private void PreviousMatchButtonClicked(object sender, EventArgs e)
    {
        // Navigate to the previous match.
        SearchResult.GoToPreviousMatch();
    }

{% endhighlight %}
{% endtabs %}

### Close the text search

The `Clear` functionality of the `TextSearchResult` removes all the traces of the searched text in the PDF document.

{% tabs %}
{% highlight C# hl_lines="4" %}

    private void CloseSearchButtonClicked(object sender, EventArgs e)
    {
        // Closes the search and clears any traces of the searched text in the PDF document.
        SearchResult.Clear();
    }

{% endhighlight %}
{% endtabs %}