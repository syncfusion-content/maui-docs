---
layout: post
title: AutoSizing in .NET MAUI ComboBox control | Syncfusion
description: Learn all about autosizing support in Syncfusion .NET MAUI ComboBox (SfComboBox) control and more here.
platform: maui
control: SfComboBox
documentation: ug
---

# AutoSizing in .NET MAUI ComboBox (SfComboBox)

AutoSizing can be enabled in [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control so that the control will extend its layout based on the input content.

[EnableAutoSize] property is used to enable the autoSizing in SfComboBox control. To enable the API, you need to set the SelectMode as Multiple and TokensWrapMode as Wrap. The default value of EnableAutoSize is false.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox" 
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

![.NET MAUI ComboBox AutoSize.]

