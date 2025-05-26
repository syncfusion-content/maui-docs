---
layout: post
title: AutoSizing in .NET MAUI Autocomplete Control | Syncfusion®
description: Discover autosizing support in the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control and more.
platform: maui
control: SfAutocomplete
documentation: ug
---

# AutoSizing in .NET MAUI AutoComplete (SfAutocomplete)

AutoSizing in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control allows the layout to adjust based on input content size.

To enable autosizing, set the [EnableAutoSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize) property to `true`. This feature requires the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode) to be set to `Multiple` and the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode) to `Wrap`. By default, [EnableAutoSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize) is set to `false`.

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
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = AutocompleteSelectionMode.Multiple,
    MaxDropDownHeight = 250,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    TokensWrapMode = AutocompleteTokensWrapMode.Wrap,
    EnableAutoSize = true
};

{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete AutoSize](Images/AutoSizing/net-maui-autocomplete-autosize.png)


