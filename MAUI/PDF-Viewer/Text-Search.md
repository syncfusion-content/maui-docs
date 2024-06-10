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

The [SearchTextAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SearchTextAsync_System_String_TextSearchOptions_System_Threading_CancellationTokenSource_) method asynchronously searches the specified text throughout the PDF document and highlights each occurrence (match). To start the search, you need to call the method in a button click by passing the text to be searched as a parameter as shown in the following example:

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

The [TextSearchResult](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html) will be obtained at the end of the search text operation and it will hold the search result. It allows you to navigate to the next or previous matches of the text as well as provides the following details:

1. <b>[Total matches count](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_TotalMatchesCount)</b> – It provides the total number of matches that have been found in the PDF document.

2. <b>[Current match index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_CurrentMatchIndex)</b> – It gives the index of the currently focused match. The value is index based.

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
N> * If the total matches count is 0, then there were no matches found for the given text.

### Navigate to the next and previous match

The [GoToNextMatch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_GoToNextMatch) and [GoToPreviousMatch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_GoToPreviousMatch) functionalities of the [TextSearchResult](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html) help you to navigate to the next and previous matches of the text respectively. You can follow the given steps to achieve the same:

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

2.	Call the [GoToNextMatch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_GoToNextMatch) or [GoToPreviousMatch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_GoToPreviousMatch) functionalities in a button click to move to the next or previous match of the text respectively, whenever necessary.

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

The [Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_Clear) functionality of the [TextSearchResult](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html) removes all the traces of the searched text in the PDF document.

{% tabs %}
{% highlight C# hl_lines="4" %}

private void CloseSearchButtonClicked(object sender, EventArgs e)
{
	// Closes the search and clears any traces of the searched text in the PDF document.
	SearchResult.Clear();
}

{% endhighlight %}
{% endtabs %}

## Text Search progress

By using the [SearchTextAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SearchTextAsync_System_String_TextSearchOptions_System_Threading_CancellationTokenSource_) the search result will be obtained only after all the pages has been searched. If the search completion takes a long time for a PDF document with more pages, you may get the current search result while the search is still in progress by using the [TextSearchProgress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_TextSearchProgress) event. The event is triggered on each page after the search is completed on the page and [SearchResult](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchProgressEventArgs.html#Syncfusion_Maui_PdfViewer_TextSearchProgressEventArgs_SearchResult) property of the [TextSearchProgressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchProgressEventArgs.html) contains the current search result as shown on the following code example:

{% tabs %}
{% highlight XAML hl_lines="3" %}

<syncfusion:SfPdfViewer 
	x:Name="PdfViewer"
	TextSearchProgress="PdfTextSearchProgress"/>
			
{% endhighlight %}
{% highlight C# hl_lines="3 9" %}

async void SearchText(string text)
{
	PdfViewer.TextSearchProgress += PdfTextSearchProgress;
	await PdfViewer.SearchTextAsync(text);
}

private void PdfTextSearchProgress(object sender, TextSearchProgressEventArgs e)
{
	TextSearchResult searchResult = e.SearchResult;
	int totalMatchesFound = searchResult.TotalMatchesCount;
}
	
{% endhighlight %}
{% endtabs %}

### Search completion percentage

The [TotalPagesSearched](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchProgressEventArgs.html#Syncfusion_Maui_PdfViewer_TextSearchProgressEventArgs_TotalPagesSearched) property of the `TextSearchProgressEventArgs` provides the total number of pages that have been searched to find the specified text across the PDF document. You may use this information to find the search completion percentage as shown in the following code example:

{% tabs %}
{% highlight C# %}

private void PdfTextSearchProgress(object sender, TextSearchProgressEventArgs e)
{
	float searchCompletionPercentage = (float)e.TotalPagesSearched / (float)PdfViewer.PageCount;
}
	
{% endhighlight %}
{% endtabs %}

### Cancelling search progress

The [Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_Clear) method of the [TextSearchResult](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html) can be used to cancel the text search progress that does not need to be continued. For example, under the following scenarios, cancellation may be necessary.

1.	If search is running for a long time. 
2.	When a wrong key word is entered and initiated the search.

The following code example shows how to cancel a currently running search.

{% tabs %}
{% highlight C# hl_lines="10" %}

async void SearchText(string text)
{
	PdfViewer.TextSearchProgress += PdfTextSearchProgress;
	await PdfViewer.SearchTextAsync(text);
}

private void PdfTextSearchProgress(object sender, TextSearchProgressEventArgs e)
{
	// Cancel the search operation when it is running but does not need to be continued.
	e.SearchResult?.Clear();
}
	
{% endhighlight %}
{% endtabs %}

## Text search options

By default, the case and other characteristics of the text will not be considered while using the [SearchTextAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SearchTextAsync_System_String_TextSearchOptions_System_Threading_CancellationTokenSource_) functionality. You may define how the text needs to be searched in the document by using the `TextSearchOption` with the following options.

1.	`None` – To search text without any restrictions.
2.	`CaseSensitive` - To search text with case sensitive.
3.	`WholeWords` – To search only the whole words.

You need to pass the `TextSearchOptions` as a parameter to the [SearchTextAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SearchTextAsync_System_String_TextSearchOptions_System_Threading_CancellationTokenSource_) method as shown in the following code example:

{% tabs %}
{% highlight C# hl_lines="5" %}

async void SearchText(string text)
{
	PdfViewer.TextSearchProgress += PdfTextSearchProgress;
	TextSearchOptions searchOptions = TextSearchOptions.CaseSensitive;
	await PdfViewer.SearchTextAsync(text, searchOptions);
}
	
{% endhighlight %}
{% endtabs %}

## Customize the text match highlight colors

The highlight colors of the current match and other matches of a text can be customized with the help of the [TextSearchSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchSettings.html#Syncfusion_Maui_PdfViewer_TextSearchSettings__ctor) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html).

{% tabs %}
{% highlight XAML hl_lines="4 5" %}

<syncfusion:SfPdfViewer x:Name="PdfViewer">
	<syncfusion:SfPdfViewer.TextSearchSettings>
		<syncfusion:TextSearchSettings 
			CurrentMatchHighlightColor="#438F00FF"  
			OtherMatchesHighlightColor="#4300FF00"/>
	</syncfusion:SfPdfViewer.TextSearchSettings>
</syncfusion:SfPdfViewer>
			
{% endhighlight %}
{% highlight C# hl_lines="3 9" %}

PdfViewer.TextSearchSettings.CurrentMatchHighlightColor = Color.FromRgba("#8F00FF43");
PdfViewer.TextSearchSettings.OtherMatchesHighlightColor= Color.FromRgba("#00FF0043");

{% endhighlight %}
{% endtabs %}