---
layout: post
title: Highlighting Matched Text in .NET MAUI SfComboBox | Syncfusion®
description: Learn about highlighting matched text in the .NET MAUI SfComboBox (SfComboBox) control and more details.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# Highlighting Matched Text

## Highlighting Matched Text in .NET MAUI SfComboBox

Highlight matching characters in a suggestion list to pick an item with more clarity. There are two ways to highlight the matching text:

- `First Occurrence`
- `Multiple Occurrence`

The text highlight can be indicated with various customizable styles by enabling the following properties:

- `HighlightedTextColor` - Sets the color of the highlighted text for differentiating the highlighted characters.
- `HighlightTextFontAttributes` - Sets the font attributes of the highlighted text.

## First Occurrence
This option highlights the first position of the matching characters in the suggestion list.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    TextHighlightMode="FirstOccurrence"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    HighlightedTextColor="Red"
                    HighlightedTextFontAttributes="Bold"/>

    {% endhighlight %}

{% highlight c# %}

    SfComboBox comboBox = new SfComboBox() 
    {
         ItemsSource = socialMediaViewModel.SocialMedias,
         DisplayMemberPath = "Name",
         TextMemberPath = "Name",
         TextHighlightMode = OccurrenceMode.FirstOccurrence,
         IsEditable =true,
         IsFilteringEnabled = true,
         HighlightedTextColor = Colors.Red,
         HighlightedTextFontAttributes = FontAttributes.Bold
    };

{% endhighlight %}
{% endtabs %}

![HighlightText Image](images/HighlightingText/firstoccurence1.png)

## Multiple Occurrence

It highlights the matching character that are present everywhere in the suggestion list for [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_Contains) case in [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode).

{% tabs %}

{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        TextHighlightMode="MultipleOccurrence"
                        IsEditable="True"
                        IsFilteringEnabled="True"
                        HighlightedTextColor="Red"
                        HighlightedTextFontAttributes="Bold"
                        TextSearchMode="Contains" />

{% endhighlight %}

{% highlight c# %}

    SfComboBox comboBox = new SfComboBox() 
    {
         ItemsSource = socialMediaViewModel.SocialMedias,
         DisplayMemberPath = "Name",
         TextMemberPath = "Name",
         TextHighlightMode = OccurrenceMode.MultipleOccurrence,
         IsEditable = true,
         IsFilteringEnabled = true,
         HighlightedTextColor = Colors.Red,
         HighlightedTextFontAttributes = FontAttributes.Bold,
         TextSearchMode = ComboBoxTextSearchMode.Contains
    };

{% endhighlight %}
{% endtabs %}

![HighlightText Image](images/HighlightingText/multipleoccurence2.png)
