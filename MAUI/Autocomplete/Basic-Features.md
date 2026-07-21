---
layout: post
title: Basic Features in .NET MAUI Autocomplete control | Syncfusion®
description: Learn about the basic feature support in the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control, including selection, text, and automation ID support.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Basic Features with .NET MAUI Autocomplete (SfAutocomplete)

## Prerequisites

Before using the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/autocomplete/getting-started) documentation.

## Selection

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) allows the user to select an item from the drop-down list by clicking or tapping the item, pressing the `Enter` key, or losing focus from the text box. By default, the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode) is `Single`.

### Selection properties

| Property | Type | Description |
|----------|------|-------------|
| `SelectedItem` | `object` | Gets or sets the currently selected item. |
| `SelectedValue` | `object` | Gets or sets the value of the selected item based on `ValueMemberPath`. |
| `SelectionMode` | `SelectionMode` | Specifies whether single or multiple selection is enabled. Default is `Single`. |

The following code example shows how to configure the basic selection behavior in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html):

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        DisplayMemberPath = "Name"
                        TextMemberPath = "Name"
                        ItemsSource="{Binding SocialMedias}" />

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Inputs;

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = new SocialMediaViewModel().SocialMedias,
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

The following image illustrates the output:

![.NET MAUI Autocomplete with single selection mode](Images/GettingStarted/SingleSelection.gif)

For more information about selection, refer to the [Selection](https://help.syncfusion.com/maui/autocomplete/selection) documentation.

## Text

The [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Text) property is used to get the text entered by the user in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html). The default value of the `Text` property is `string.Empty`. The `Text` property is updated live as the user types and is also updated when an item is selected from the drop-down list.

## Automation ID

The [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control provides `AutomationId` support for the input field and the clear button, enabling UI automation frameworks to reliably target these elements. Each element's `AutomationId` is derived from the control's `AutomationId` to ensure uniqueness.

For example, if the SfAutocomplete’s `AutomationId` is set to “Employee Autocomplete,” the editable entry can be targeted as “Employee Autocomplete Entry” and the clear button as “Employee Autocomplete Clear Button.” This focused support improves accessibility and automated UI testing by providing stable, predictable identifiers for the primary interactive elements

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        AutomationId="Employee Autocomplete" />

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Inputs;

SfAutocomplete autocomplete = new SfAutocomplete()
{
    AutomationId = "Employee Autocomplete",
};

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the AutomationIds of the inner elements:

![AutomationIds of inner elements in .NET MAUI Autocomplete](Images/GettingStarted/AutoComplete_AutomationID.png)

## See also

- [Selection](https://help.syncfusion.com/maui/autocomplete/selection)
- [UI Customization](https://help.syncfusion.com/maui/autocomplete/ui-customization)
- [Getting Started](https://help.syncfusion.com/maui/autocomplete/getting-started)
