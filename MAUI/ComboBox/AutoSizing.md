---
layout: post
title: AutoSizing in .NET MAUI ComboBox control | Syncfusion®
description: Learn about auto sizing support in Syncfusion® .NET MAUI ComboBox (SfComboBox) control and more here.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# AutoSizing in .NET MAUI ComboBox

## Prerequisites

Before using the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## EnableAutoSize

The [EnableAutoSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_EnableAutoSize) property in the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control automatically adjusts the editor height to fit the selected tokens, so the control grows to display all wrapped tokens without scrolling. It is a `bool` property and the default value is `false`.

To make AutoSizing take effect, configure the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) with the following:

* [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) set to `Multiple`.
* [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_MultiSelectionDisplayMode) set to `Token` (default).
* [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) set to `Wrap`.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionMode="Multiple"
                    MultiSelectionDisplayMode="Token"
                    MaxDropDownHeight="250"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    Placeholder="Enter Media"
                    TokensWrapMode="Wrap"
                    EnableAutoSize="True">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}
{% highlight C# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = ComboBoxSelectionMode.Multiple,
    MultiSelectionDisplayMode = ComboBoxMultiSelectionDisplayMode.Token,
    MaxDropDownHeight = 250,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    TokensWrapMode = ComboBoxTokensWrapMode.Wrap,
    EnableAutoSize = true,
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

![.NET MAUI ComboBox AutoSize.](Images/AutoSizing/net-maui-combobox-autosize.png)

N> If `EnableAutoSize` is set to `true` without `SelectionMode` as `Multiple` or `TokensWrapMode` as `Wrap`, the AutoSizing behavior is ignored and the editor height remains fixed.

## See Also

* [Getting started with .NET MAUI ComboBox](getting-started.md)
* [Editing in .NET MAUI ComboBox](Editing.md)
* [Selection in .NET MAUI ComboBox](Selection.md)