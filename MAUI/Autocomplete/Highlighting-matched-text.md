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

For step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Overview

You can highlight the matching characters in each suggestion of the `SfAutocomplete` drop-down to help users identify the matching suggestion. There are two highlight modes:

- `FirstOccurrence` — highlights the first match in each suggestion.
- `MultipleOccurrence` — highlights every match in each suggestion.

Use the following properties to customize the appearance of the highlighted text:

- `HighlightedTextColor` — the color applied to the highlighted characters.
- `HighlightedTextFontAttributes` — the font attributes applied to the highlighted characters (`None`, `Bold`, `Italic`, or `Bold, Italic`).

### Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `TextHighlightMode` | `OccurrenceMode` | `None` | Specifies whether the first match or every match is highlighted. |
| `HighlightedTextColor` | `Color` | `Colors.Blue` | Gets or sets the color of the highlighted text. |
| `HighlightedTextFontAttributes` | `FontAttributes` | `None` | Gets or sets the font attributes of the highlighted text. |
| `TextSearchMode` | `AutocompleteTextSearchMode` | `StartsWith` | Specifies how the input text is matched against the suggestion list. `MultipleOccurrence` requires `Contains`. |

## First Occurrence

Set `TextHighlightMode` to [FirstOccurrence](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.OccurrenceMode.html#Syncfusion_Maui_Inputs_OccurrenceMode_FirstOccurrence) to highlight the first match in each suggestion.

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

using Syncfusion.Maui.Inputs;
using System.Collections.Generic;

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = new List<SocialMedia>
    {
        new SocialMedia { Name = "Facebook" },
        new SocialMedia { Name = "Twitter" },
        new SocialMedia { Name = "Instagram" },
        new SocialMedia { Name = "LinkedIn" }
    },
    TextHighlightMode = OccurrenceMode.FirstOccurrence,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold
};

public class SocialMedia
{
    public string Name { get; set; }
}

{% endhighlight %}

{% endtabs %}

The following image illustrates first-occurrence highlighting in the SfAutocomplete drop-down:

![First occurrence highlighting in the SfAutocomplete drop-down](Images/HighlightingText/firstoccurrence.png)

## Multiple Occurrence

Set `TextHighlightMode` to [MultipleOccurrence](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.OccurrenceMode.html#Syncfusion_Maui_Inputs_OccurrenceMode_MultipleOccurrence) to highlight every match in each suggestion. This mode requires [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode) to be set to [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_Contains); otherwise, only the first match is highlighted.

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

using Syncfusion.Maui.Inputs;
using System.Collections.Generic;

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = new List<SocialMedia>
    {
        new SocialMedia { Name = "Facebook" },
        new SocialMedia { Name = "Twitter" },
        new SocialMedia { Name = "Instagram" },
        new SocialMedia { Name = "LinkedIn" }
    },
    TextHighlightMode = OccurrenceMode.MultipleOccurrence,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold,
    TextSearchMode = AutocompleteTextSearchMode.Contains
};

{% endhighlight %}

{% endtabs %}

The following image illustrates multiple-occurrence highlighting in the SfAutocomplete drop-down:

![Multiple occurrence highlighting in the SfAutocomplete drop-down](Images/HighlightingText/multipleoccurrence.png)

## See also

- [Searching and Filtering](Searching-Filtering.md)
- [Selection](Selection.md)
- [Getting Started](Getting-Started.md)