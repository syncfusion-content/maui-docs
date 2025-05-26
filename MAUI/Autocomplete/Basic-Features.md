---
layout: post
title: Basic Features in .NET MAUI Autocomplete Control | Syncfusion®
description: Discover the basic features supported by the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control and more.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Basic Features of .NET MAUI Autocomplete (SfAutocomplete)

## Selection

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control enables users to select an item from the drop-down list by pressing the `Enter` key or by moving the focus away from the text box.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        DisplayMemberPath = "Name"
                        TextMemberPath = "Name"
                        ItemsSource="{Binding SocialMedias}" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias,
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the output:

![.NET MAUI Autocomplete with single selection mode](Images/GettingStarted/SingleSelection.gif)

## Text

The [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Text) property retrieves the user-submitted text within the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control. The default value for the `Text` property is `string.Empty`.
