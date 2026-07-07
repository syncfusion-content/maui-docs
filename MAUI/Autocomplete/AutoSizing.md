---
layout: post
title: AutoSizing in .NET MAUI Autocomplete control | Syncfusion®
description: Learn about auto sizing support in the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control, which lets the input area grow to fit the selected tokens.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Auto Sizing in .NET MAUI Autocomplete (SfAutocomplete)

## Prerequisites

Before using the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Enabling auto sizing

Auto sizing can be enabled in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) so that the input area grows vertically to fit the selected tokens when the control is in multiple-selection mode.

To enable auto sizing, set the [EnableAutoSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize) property to `true`. The feature requires that the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode) is set to [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteSelectionMode.html#Syncfusion_Maui_Inputs_AutocompleteSelectionMode_Multiple) and the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode) is set to [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTokensWrapMode.html#Syncfusion_Maui_Inputs_AutocompleteTokensWrapMode_Wrap); otherwise, the property has no visible effect. The default value of `EnableAutoSize` is `false`.

### Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `EnableAutoSize` | `bool` | `false` | Gets or sets a value that indicates whether the input area grows to fit the selected tokens. |
| `MaxDropDownHeight` | `double` | `300` | Gets or sets the maximum height of the drop-down list. |
| `SelectionMode` | `AutocompleteSelectionMode` | `Single` | Specifies single or multiple selection. Auto sizing requires `Multiple`. |
| `TokensWrapMode` | `AutocompleteTokensWrapMode` | `None` | Specifies how selected tokens are arranged. Auto sizing requires `Wrap`. |

### Example

The following code example shows how to enable auto sizing in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html):

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        SelectionMode="Multiple"
                        MaxDropDownHeight="250"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        TokensWrapMode="Wrap"
                        EnableAutoSize="True" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    ItemsSource = new SocialMediaViewModel().SocialMedias,
    SelectionMode = AutocompleteSelectionMode.Multiple,
    MaxDropDownHeight = 250,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    TokensWrapMode = AutocompleteTokensWrapMode.Wrap,
    EnableAutoSize = true
};

{% endhighlight %}
{% highlight ViewModel %}

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

The following image illustrates the auto-sized Autocomplete as the selected tokens wrap to the next line:

![.NET MAUI Autocomplete with auto sizing enabled and tokens wrapping to the next line](Images/AutoSizing/net-maui-autocomplete-autosize.png)

## See also

- [Selection](Selection.md)
- [UI Customization](UI-Customization.md)
- [Getting Started](Getting-Started.md)
