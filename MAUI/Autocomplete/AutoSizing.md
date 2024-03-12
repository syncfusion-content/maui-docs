---
layout: post
title: AutoSizing in .NET MAUI Autocomplete control | Syncfusion
description: Learn all about autosizing support in Syncfusion .NET MAUI Autocomplete (SfAutocomplete) control and more here.
platform: maui
control: SfAutocomplete
documentation: ug
---

# AutoSizing in .NET MAUI AutoComplete (SfAutocomplete)

AutoSizing can be enabled in [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control so that the control will extend its layout based on the input content.

[EnableAutoSize] property is used to enable the autoSizing in SfAutocomplete control. To enable the API, you need to set the SelectMode as Multiple and TokensWrapMode as Wrap. The default value of EnableAutoSize is false.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete" 
             HeightRequest="50"
             WidthRequest="350"
             ItemsSource="{Binding SocialMedias}"
             SelectionMode="Multiple"
             MaxDropDownHeight="250"
             DisplayMemberPath="Name"
             TextMemberPath="Name"
             TokensWrapMode="Wrap"
             EnableAutoSize="True" />

{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete AutoSize.]

