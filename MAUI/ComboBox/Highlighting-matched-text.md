---
layout: post
title: Header and Footer in MAUI Autocomplete control | Syncfusion
description: Learn about Header and Footer support in Syncfusion MAUI Autocomplete (SfAutocomplete) control and more details.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Highlighting matched text

## Highlighting matched text in .NET MAUI SfComboBox

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

 <editors:SfComboBox x:Name="combobox"
     WidthRequest="300"
     ItemsSource="{Binding SocialMedias}"
     TextHighlightMode="FirstOccurrence"
     TextMemberPath="Name"
     DisplayMemberPath="Name"
     IsEditable="True"
     IsFilteringEnabled="True"
     HighlightedTextColor="Red"
     HighlightedTextFontAttributes="Bold"
     TextSearchMode="StartsWith" />

{% endhighlight %}

{% highlight c# %}

SfComboBox comboBox = new SfComboBox() 
{
 HeightRequest = 40,
 TextSearchMode = ComboBoxTextSearchMode.StartsWith,
 TextHighlightMode = OccurrenceMode.FirstOccurrence,
 IsEditable =true,
 IsFilteringEnabled = true,
 HighlightedTextColor = Colors.Red,
 HighlightedTextFontAttributes = FontAttributes.Bold,
 ItemsSource = new List<string>(){ "Facebook", "Twitter", "Instagram", "LinkedIn" }
};

{% endhighlight %}
{% endtabs %}

![HighlightText Image](images/HighlightingText/firstoccurence1.png)

## Multiple Occurrence

It highlights the matching character that are present everywhere in the suggestion list for [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_Contains) case in [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode)

{% tabs %}

{% highlight xaml %}

 <editors:SfComboBox x:Name="combobox"
     WidthRequest="300"
     ItemsSource="{Binding SocialMedias}"
     TextHighlightMode="MultipleOccurrence"
     TextMemberPath="Name"
     DisplayMemberPath="Name"
     IsEditable="True"
     IsFilteringEnabled="True"
     HighlightedTextColor="Red"
     HighlightedTextFontAttributes="Bold"
     TextSearchMode="Contains" />

{% endhighlight %}

{% highlight c# %}

SfComboBox comboBox = new SfComboBox() 
{
 HeightRequest = 40,
 TextSearchMode = ComboBoxTextSearchMode.Contains,
 TextHighlightMode = OccurrenceMode.MultipleOccurrence,
 IsEditable = true,
 IsFilteringEnabled = true,
 HighlightedTextColor = Colors.Red,
 HighlightedTextFontAttributes = FontAttributes.Bold,
 ItemsSource = new List<string>(){ "Facebook", "Twitter", "Instagram", "LinkedIn" }
};

{% endhighlight %}
{% endtabs %}

![HighlightText Image](images/HighlightingText/multipleoccurence2.png)