---
layout: post
title: Highlighting matched text in .NET MAUI ComboBox | Syncfusion®
description: Learn about highlighting matched text in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control and more.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# Highlighting matched text in .NET MAUI ComboBox

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control can highlight the characters that match the text typed into the editor, making items in the drop-down easier to identify. Highlighting is enabled through the `TextHighlightMode` property and is applied only when `IsEditable` and `IsFilteringEnabled` are `true`.

## Prerequisites

Before using the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/combobox/getting-started) documentation.

## Highlight modes

The [TextHighlightMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextHighlightMode) property controls how the matched text is highlighted. The available modes are:

* `FirstOccurrence` - Highlights only the first occurrence of the matched characters in each item.
* `MultipleOccurrence` - Highlights every occurrence of the matched characters in each item. Typically used with [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) set to `Contains`, but also works with `StartsWith` (only the leading characters are matched).

The default value of `TextHighlightMode` is `FirstOccurrence`.

## Highlight style

The highlight style can be customized using the following properties:

* `HighlightedTextColor` - Sets the color of the highlighted characters. Type: `Color`. Default: `Colors.Blue`.
* `HighlightedTextFontAttributes` - Sets the font attributes (such as `Bold` or `Italic`) of the highlighted characters. Type: `FontAttributes`. Default: `None`.

N> Highlighting is applied only when `IsEditable` is `true` and `IsFilteringEnabled` is `true`. If either is `false`, the matched text is not highlighted even if `TextHighlightMode` is set.

## First occurrence

Highlights only the first occurrence of the matched characters in each item of the drop-down.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    TextHighlightMode="FirstOccurrence"
                    HighlightedTextColor="Red"
                    HighlightedTextFontAttributes="Bold">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    IsEditable = true,
    IsFilteringEnabled = true,
    TextHighlightMode = OccurrenceMode.FirstOccurrence,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

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

![First Occurrence highlight in the .NET MAUI ComboBox drop-down](images/HighlightingText/firstoccurence1.png)

## Multiple occurrence

Highlights every occurrence of the matched characters in each item. This mode is most useful when combined with [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) set to `Contains`, because the matched substring can appear anywhere in the item.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    TextHighlightMode="MultipleOccurrence"
                    TextSearchMode="Contains"
                    HighlightedTextColor="Red"
                    HighlightedTextFontAttributes="Bold">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    IsEditable = true,
    IsFilteringEnabled = true,
    TextHighlightMode = OccurrenceMode.MultipleOccurrence,
    TextSearchMode = ComboBoxTextSearchMode.Contains,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

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

![Multiple Occurrence highlight in the .NET MAUI ComboBox drop-down](images/HighlightingText/multipleoccurence2.png)

## See Also

* [Getting Started](https://help.syncfusion.com/maui/combobox/getting-started)
* [Searching](https://help.syncfusion.com/maui/combobox/searching)
* [Editing](https://help.syncfusion.com/maui/combobox/editing)
* [Filtering](https://help.syncfusion.com/maui/combobox/filtering)
* [Selection](https://help.syncfusion.com/maui/combobox/selection)