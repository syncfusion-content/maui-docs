---
layout: post
title: AutoSizing in .NET MAUI Autocomplete control | Syncfusion
description: Learn about autosizing support in Syncfusion .NET MAUI Autocomplete (SfAutocomplete) control and more.
platform: maui
control: SfAutocomplete
documentation: ug
---

# AutoSizing in .NET MAUI AutoComplete (SfAutocomplete)

AutoSizing can be enabled in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control so that the control will extend its layout based on the input content.

The [EnableAutoSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize) property is used to enable the auto sizing in the SfAutocomplete control. To enable the API, set the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode) as Multiple and [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode) as Wrap. The default value of [EnableAutoSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize) is false.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
             WidthRequest="350"
             ItemsSource="{Binding SocialMedias}"
             SelectionMode="Multiple"
             MaxDropDownHeight="250"
             DisplayMemberPath="Name"
             TextMemberPath="Name"
             Placeholder="Enter Media"
             TokensWrapMode="Wrap"
             EnableAutoSize="True" />

{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete AutoSize.](Images/AutoSizing/net-maui-autocomplete-autosize.png)

