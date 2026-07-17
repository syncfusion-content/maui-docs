---
layout: post
title: Highlighting matched text in .NET MAUI Autocomplete | Syncfusion®
description: Learn how to highlight matched text in the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) drop-down.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Highlighting matched text in .NET MAUI Autocomplete (SfAutocomplete)

## Prerequisites

Before using the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/autocomplete/getting-started) documentation.

## Overview

You can highlight the matching characters in each suggestion of the `SfAutocomplete` drop-down to help users identify the matching suggestion. There are two highlight modes:

- `FirstOccurrence` - highlights the first match in each suggestion.
- `MultipleOccurrence` - highlights every match in each suggestion.

Use the following properties to customize the appearance of the highlighted text:

- `HighlightedTextColor` - the color applied to the highlighted characters.
- `HighlightedTextFontAttributes` - the font attributes applied to the highlighted characters (`None`, `Bold`, `Italic`, or `Bold, Italic`).

### Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `TextHighlightMode` | `OccurrenceMode` | `None` | Specifies whether the first match or every match is highlighted. |
| `HighlightedTextColor` | `Color` | `Colors.Blue` | Gets or sets the color of the highlighted text. |
| `HighlightedTextFontAttributes` | `FontAttributes` | `None` | Gets or sets the font attributes of the highlighted text. |
| `TextSearchMode` | `AutocompleteTextSearchMode` | `StartsWith` | Specifies how the input text is matched against the suggestion list. `MultipleOccurrence` requires `Contains`. |

## First Occurrence

Set [TextHighlightMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextHighlightMode) to [FirstOccurrence](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.OccurrenceMode.html#Syncfusion_Maui_Inputs_OccurrenceMode_FirstOccurrence) to highlight the first match in each suggestion.

{% tabs %}

{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        ItemsSource="{Binding SocialMedias}"
                        TextHighlightMode="FirstOccurrence"
                        HighlightedTextColor="Red"
                        HighlightedTextFontAttributes="Bold" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = new SocialMediaViewModel().SocialMedias,
    TextHighlightMode = OccurrenceMode.FirstOccurrence,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold
};

public class SocialMedia
{
    public string Name { get; set; }
}

{% endhighlight %}

{% highlight c# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}

{% endtabs %}

The following image illustrates first-occurrence highlighting in the SfAutocomplete drop-down:

![First occurrence highlighting in the SfAutocomplete drop-down](Images/HighlightingText/firstoccurrence.png)

## Multiple Occurrence

Set [TextHighlightMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextHighlightMode)  to [MultipleOccurrence](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.OccurrenceMode.html#Syncfusion_Maui_Inputs_OccurrenceMode_MultipleOccurrence) to highlight every match in each suggestion. This mode requires [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode) to be set to [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_Contains); otherwise, only the first match is highlighted.

{% tabs %}

{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        ItemsSource="{Binding SocialMedias}"
                        TextHighlightMode="MultipleOccurrence"
                        HighlightedTextColor="Red"
                        HighlightedTextFontAttributes="Bold"
                        TextSearchMode="Contains" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = new SocialMediaViewModel().SocialMedias,
    TextHighlightMode = OccurrenceMode.MultipleOccurrence,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold,
    TextSearchMode = AutocompleteTextSearchMode.Contains
};

{% endhighlight %}

{% highlight c# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}

{% endtabs %}

The following image illustrates multiple-occurrence highlighting in the SfAutocomplete drop-down:

![Multiple occurrence highlighting in the SfAutocomplete drop-down](Images/HighlightingText/multipleoccurrence.png)

## See also

- [Searching and Filtering](https://help.syncfusion.com/maui/autocomplete/searching-filtering)
- [Selection](https://help.syncfusion.com/maui/autocomplete/selection)
- [UI Customization](https://help.syncfusion.com/maui/autocomplete/ui-customization)
- [Getting Started](https://help.syncfusion.com/maui/autocomplete/getting-started)