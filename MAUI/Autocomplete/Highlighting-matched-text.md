---
layout: post
title: Highlighting matched text in Autocomplete control | Syncfusion
description: Learn about Highlighting matched text in .NET MAUI SfAutocomplete (SfAutocomplete) control and more details.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Highlighting matched text

## Highlighting matched text in .NET MAUI SfAutocomplete

Highlight matching characters in a suggestion list to pick an item with more clarity. There are two ways to highlight the matching text:

*   `First Occurrence`

*   `Multiple Occurrence`

The text highlight can be indicated with various customizing styles by enabling the below properties. They are

*   `HighlightedTextColor` - sets the color of the highlighted text for differentiating the highlighted characters.

*   `HighlightTextFontAttributes` - sets the FontAttributes of the highlighted text.

## First Occurrence

It highlights the first position of the matching characters in the suggestion list.

{% tabs %}

{% highlight xaml %}

     <editors:SfAutocomplete x:Name="autocomplete"
			     HeightRequest = "40"
			     WidthRequest="300"
			     ItemsSource="{Binding SocialMedias}"
			     TextHighlightMode="FirstOccurrence"
			     HighlightedTextColor="Red"
			     HighlightedTextFontAttributes="Bold"/>

{% endhighlight %}

{% highlight c# %}

    SfAutocomplete autoComplete = new SfAutocomplete() 
    {
         HeightRequest = 40,
         WidthRequest=300,
         TextHighlightMode = OccurrenceMode.FirstOccurrence,
         HighlightedTextColor = Colors.Red,
         HighlightedTextFontAttributes = FontAttributes.Bold,
    };

{% endhighlight %}

{% endtabs %}

![HighlightText Image](images/HighlightingText/firstoccurrence.png)

## Multiple Occurrence

It highlights the matching character that are present everywhere in the suggestion list for [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_Contains) case in [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode).

{% tabs %}

{% highlight xaml %}

     <editors:SfAutocomplete x:Name="autocomplete"
		             HeightRequest = "40"
		             WidthRequest="300"
		             ItemsSource="{Binding SocialMedias}"
		             TextHighlightMode="MultipleOccurrence"
		             HighlightedTextColor="Red"
		             HighlightedTextFontAttributes="Bold"
		             TextSearchMode="Contains"/>

{% endhighlight %}

{% highlight c# %}

    SfAutocomplete autoComplete = new SfAutocomplete() 
    {
         HeightRequest = 40,
         WidthRequest=300,
         TextSearchMode = AutocompleteTextSearchMode.Contains,
         TextHighlightMode = OccurrenceMode.MultipleOccurrence,
         HighlightedTextColor = Colors.Red,
         HighlightedTextFontAttributes = FontAttributes.Bold,
    };

{% endhighlight %}

{% endtabs %}

![HighlightText Image](images/HighlightingText/multipleoccurrence.png)