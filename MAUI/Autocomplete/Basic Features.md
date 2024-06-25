---
layout: post
title: Basic Features with .NET MAUI Autocomplete | Syncfusion
description: Learn the basic features with Syncfusion .NET MAUI Autocomplete control and more details.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Basic Features with .NET MAUI Autocomplete (SfAutocomplete)

## Selection

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) allows the user to select an item from the drop-down list by clicking the `Enter` key or losing focus from the text box.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        WidthRequest="250"
                        DisplayMemberPath = "Name"
                        TextMemberPath = "Name"
                        ItemsSource="{Binding SocialMedias}" />

{% endhighlight %}
{% highlight C# %}

autocomplete.DisplayMemberPath = "Name";
autocomplete.TextMemberPath = "Name";

{% endhighlight %}
{% endtabs %}

The following image illustrates the output:

![.NET MAUI Autocomplete with single selection mode](Images/GettingStarted/SingleSelection.gif)

You can access the full getting started sample for .NET MAUI Autocomplete by following this [link](https://github.com/SyncfusionExamples/maui-autocomplete-samples).

## Text

The [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Text) property is used to get the user-submitted text in the [SfAutoComplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html). The default value of the `Text` property is `string.Empty`.

N> You can refer to our [.NET MAUI Autocomplete](https://www.syncfusion.com/maui-controls/maui-autocomplete) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Autocomplete Example](https://github.com/SyncfusionExamples/maui-autocomplete-samples) that shows you how to render the Autocomplete in .NET MAUI.
