---
layout: post
title: UI Customization in .NET MAUI ComboBox control | Syncfusion
description: Learn here all about UI customization support in Syncfusion .NET MAUI ComboBox control into .NET MAUI application and its basic features.
platform: maui
control: SfComboBox
documentation: ug
---

# UI Customization in .NET MAUI ComboBox (SfComboBox)

This section explains different UI customization available in `ComboBox`.

## Placeholder

You can prompt the user with any information by using the `Placeholder` property. This text will be displayed only if no items are selected or the edit text is empty. The default value of `Placeholder` property is `string.Empty` (No string will be displayed).

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    Width="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    Placeholder="Select a social media" />

{% endhighlight %}
{% highlight C# %}

comboBox.Placeholder = "Select a social media";

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox placeholder](Images/UICustomization/Placeholder.png)


### Change color of placeholder

The placeholder texts’ foreground can be changed by using the `PlaceholderColor` property. The default value of `PlaceholderColor` property is `Colors.Gray`.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    Width="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    PlaceholderColor="Red"
                    Placeholder="Select a social media" />

{% endhighlight %}
{% highlight C# %}

comboBox.PlaceholderColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox placeholder color](Images/UICustomization/PlaceholderColor.png)

## How to change DropDown MaxHeight

The maximum height of the drop-down can be changed by using the `MaxDropDownHeight` property of `ComboBox` control. The default value of `MaxDropDownHeight` property is `400d`. 

 N> If the `MaxDropDownHeight` is too small compared to the populated items, scroll viewer will be automatically shown to navigate the hidden items.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    Width="250"
                    IsEditable="true"
                    MaxDropDownHeight="300"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

comboBox.MaxDropDownHeight = 150;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox maximum drop-down height](Images/UICustomization/MaxDropDownHeight.png)