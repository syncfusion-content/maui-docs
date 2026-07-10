---
layout: post
title: No Results Found in .NET MAUI ComboBox control | Syncfusion®
description: Learn about the No Results Found support in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, .net maui combobox no results.
---

# No Results Found in .NET MAUI ComboBox

When no items match the text typed into the editor, the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control displays a message in the drop-down to inform the user that no results were found. Customize this message with the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) and [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) properties.

N> The No Results Found view is shown only when `IsEditable` is `true` and `IsFilteringEnabled` is `true`. If either is `false`, the view is not shown even if the filter result is empty.

## Prerequisites

Before using the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Customize the No Results text

Use the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) `string` property to customize the message shown when no items match the typed text. The default value is `"No results found"`.

To hide the message entirely, set `NoResultsFoundText` to an empty string (`""`).

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    NoResultsFoundText="Not Found"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    IsFilteringEnabled = true,
    IsEditable = true,
    NoResultsFoundText = "Not Found",
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
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

![Custom No Results text in the .NET MAUI ComboBox drop-down](images/NoResultsFound/NoResultsFoundText.png)

## Customize the No Results view

Use the [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) property to provide a custom `DataTemplate` for the no-results view. The template's `BindingContext` is not set; the content is rendered as-is.

When `NoResultsFoundTemplate` is set, it takes precedence over `NoResultsFoundText`.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
    <editors:SfComboBox.NoResultsFoundTemplate>
        <DataTemplate>
            <Label Text="Not Found"
                   FontSize="20"
                   FontAttributes="Italic"
                   TextColor="Red"
                   Margin="70,10,0,0" />
        </DataTemplate>
    </editors:SfComboBox.NoResultsFoundTemplate>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    BindingContext = socialMediaViewModel,
    NoResultsFoundTemplate = new DataTemplate(() => new Label
    {
        Text = "Not Found",
        FontSize = 20,
        FontAttributes = FontAttributes.Italic,
        TextColor = Colors.Red,
        Margin = new Thickness(70, 10, 0, 0),
    }),
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

![Custom No Results view in the .NET MAUI ComboBox drop-down](images/NoResultsFound/NoResultsFoundTemplate.png)

## See Also

* [Getting started with .NET MAUI ComboBox](getting-started.md)
* [Editing in .NET MAUI ComboBox](Editing.md)
* [Filtering in .NET MAUI ComboBox](Filtering.md)
* [Selection in .NET MAUI ComboBox](Selection.md)
