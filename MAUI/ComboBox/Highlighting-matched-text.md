---
layout: post
title: Highlighting matched text in .NET MAUI SfComboBox control | Syncfusion
description: Learn about Highlighting matched text in .NET MAUI SfComboBox (SfComboBox) control and more details.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
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

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="350"
                    HeightRequest = "50"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextHighlightMode="FirstOccurrence"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    HighlightedTextColor="Red"
                    HighlightedTextFontAttributes="Bold"/>

    {% endhighlight %}

{% highlight c# %}

    SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
    SfComboBox comboBox = new SfComboBox() 
    {
         HeightRequest = 50,
         WidthRequest= 350,
         TextHighlightMode = OccurrenceMode.FirstOccurrence,
         ItemsSource = socialMediaViewModel.SocialMedias,
         IsEditable =true,
         DisplayMemberPath = "Name",
         IsFilteringEnabled = true,
         HighlightedTextColor = Colors.Red,
         HighlightedTextFontAttributes = FontAttributes.Bold
    };
Content = comboBox;

{% endhighlight %}
{% endtabs %}

![HighlightText Image](images/HighlightingText/firstoccurence1.png)

## Multiple Occurrence

It highlights the matching character that are present everywhere in the suggestion list for [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_Contains) case in [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode).

{% tabs %}

{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                        WidthRequest="350"
                        DisplayMemberPath="Name"
                        HeightRequest = "50"
                        ItemsSource="{Binding SocialMedias}"
                        TextHighlightMode="MultipleOccurrence"
                        IsEditable="True"
                        IsFilteringEnabled="True"
                        HighlightedTextColor="Red"
                        HighlightedTextFontAttributes="Bold"
                        TextSearchMode="Contains" />

{% endhighlight %}

{% highlight c# %}

    SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
    SfComboBox comboBox = new SfComboBox() 
    {
         HeightRequest = 50,
         WidthRequest= 350,
         TextSearchMode = ComboBoxTextSearchMode.Contains,
         ItemsSource = socialMediaViewModel.SocialMedias,
         TextHighlightMode = OccurrenceMode.MultipleOccurrence,
         DisplayMemberPath = "Name",
         IsEditable = true,
         IsFilteringEnabled = true,
         HighlightedTextColor = Colors.Red,
         HighlightedTextFontAttributes = FontAttributes.Bold
    };
Content = comboBox;

{% endhighlight %}
{% endtabs %}

![HighlightText Image](images/HighlightingText/multipleoccurence2.png)