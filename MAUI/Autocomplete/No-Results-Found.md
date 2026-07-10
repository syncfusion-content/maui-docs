---
layout: post
title: No Results Found in .NET MAUI Autocomplete control | Syncfusion®
description: Learn how to customize the no-results-found message in the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# No Results Found in .NET MAUI Autocomplete (SfAutocomplete)

## Prerequisites

Before using the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Overview

When the entered text does not match any item in the `SfAutocomplete`drop-down, the control displays a no-results-found message. You can customize the message text with the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) property, or provide a fully custom UI with the [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) property.

### Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `NoResultsFoundText` | `string` | `No results found` | Gets or sets the message displayed when no matching items are found. |
| `NoResultsFoundTemplate` | `DataTemplate` | `null` | Gets or sets a custom template used to render the no-results-found message. Takes precedence over `NoResultsFoundText` when set. |

## NoResultsFoundText

You can customize the text displayed when no results are found by setting the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) property. The default value is `No results found`.

{% tabs %}

{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        NoResultsFoundText="Not Found"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    NoResultsFoundText = "Not Found",
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = new SocialMediaViewModel().SocialMedias
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

The following image illustrates a customized no-results-found message:

![Customized no-results-found message in the SfAutocomplete drop-down](Images/NoResultsFound/NoResultsFoundText.png)

## NoResultsFoundTemplate

You can fully customize the appearance of the no-results-found message by setting the [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) property. When the template is set, it takes precedence over the `NoResultsFoundText` property.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name">
    <editors:SfAutocomplete.NoResultsFoundTemplate>
        <DataTemplate>
            <Label Text="Not Found"
                   FontSize="20"
                   FontAttributes="Italic"
                   TextColor="Red"
                   Margin="70,10,0,0" />
        </DataTemplate>
    </editors:SfAutocomplete.NoResultsFoundTemplate>
</editors:SfAutocomplete>

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = new SocialMediaViewModel().SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    NoResultsFoundTemplate = new DataTemplate(() =>
    {
        return new Label
        {
            Text = "Not Found",
            FontSize = 20,
            FontAttributes = FontAttributes.Italic,
            TextColor = Colors.Red,
            Margin = new Thickness(70, 10, 0, 0)
        };
    })
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

The following image illustrates a customized no-results-found template:

![Customized no-results-found template in the SfAutocomplete drop-down](Images/NoResultsFound/NoResultsFoundTemplate.png)

## Notes

N> **Hiding the message**: To hide the no-results-found message, set `NoResultsFoundText` to an empty string (`NoResultsFoundText = string.Empty`).

N> **Template precedence**: When `NoResultsFoundTemplate` is set, the template is used instead of the `NoResultsFoundText` value. Leave the template unset to use the plain text message.

## See also

- [Getting Started](Getting-Started.md)
- [Selection](Selection.md)
- [UI Customization](UI-Customization.md)