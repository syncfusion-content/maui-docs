---
layout: post
title: Highlighting Matched Text in Autocomplete Control | Syncfusion®
description: Learn about highlighting matched text in the .NET MAUI SfAutocomplete (SfAutocomplete) control for enhanced clarity and usability.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Highlighting Matched Text

## Highlighting Matched Text in .NET MAUI SfAutocomplete

In the [.NET MAUI SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control, you can highlight matching characters in a suggestion list to provide clarity when selecting items. There are two methods for highlighting matched text:

- **First Occurrence**: Highlights the first instance of matching characters.

- **Multiple Occurrence**: Highlights all instances of matching characters.

The text highlight can be customized using the properties below:

- **HighlightedTextColor**: Sets the color of the highlighted text to differentiate the highlighted characters.

- **HighlightTextFontAttributes**: Sets the `FontAttributes` of the highlighted text.
## First Occurrence

This mode highlights the first instance of matching characters in the suggestion list.
{% tabs %}

{% highlight xaml %}

     <editors:SfAutocomplete x:Name="autocomplete"
                    DisplayMemberPath = "Name"
                    TextMemberPath = "Name"
			     ItemsSource="{Binding SocialMedias}"
			     TextHighlightMode="FirstOccurrence"
			     HighlightedTextColor="Red"
			     HighlightedTextFontAttributes="Bold"/>

{% endhighlight %}

{% highlight c# %}

     SfAutocomplete autocomplete = new SfAutocomplete() 
     {
          DisplayMemberPath = "Name",
          TextMemberPath = "Name",
          ItemsSource = socialMediaViewModel.SocialMedias,
          TextHighlightMode = OccurrenceMode.FirstOccurrence,
          HighlightedTextColor = Colors.Red,
          HighlightedTextFontAttributes = FontAttributes.Bold,
     };

{% endhighlight %}

{% endtabs %}

![Highlight Text](images/HighlightingText/firstoccurrence.png)

## Multiple Occurrence

This mode highlights all matching characters present in the suggestion list for the [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_Contains) case in [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode).

{% tabs %}

{% highlight xaml %}

     <editors:SfAutocomplete x:Name="autocomplete"
                       DisplayMemberPath = "Name"
                       TextMemberPath = "Name"
		             ItemsSource="{Binding SocialMedias}"
		             TextHighlightMode="MultipleOccurrence"
		             HighlightedTextColor="Red"
		             HighlightedTextFontAttributes="Bold"
		             TextSearchMode="Contains"/>

{% endhighlight %}

{% highlight c# %}

     SfAutocomplete autocomplete = new SfAutocomplete() 
     {
          DisplayMemberPath = "Name",
          TextMemberPath = "Name",
          ItemsSource = socialMediaViewModel.SocialMedias,
          TextHighlightMode = OccurrenceMode.MultipleOccurrence,
          HighlightedTextColor = Colors.Red,
          HighlightedTextFontAttributes = FontAttributes.Bold,
          TextSearchMode = AutocompleteTextSearchMode.Contains,
     };

{% endhighlight %}

{% endtabs %}

![Highlight Text](images/HighlightingText/multipleoccurrence.png)
