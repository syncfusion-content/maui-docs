---
layout: post
title: UI Customization in .NET MAUI Autocomplete control | Syncfusion
description: Learn here all about UI customization support in Syncfusion .NET MAUI Autocomplete control into .NET MAUI application and its features.
platform: maui
control: SfAutocomplete
documentation: ug
---

# UI Customization in .NET MAUI Autocomplete (SfAutocomplete)

This section explains different UI customization available in the `Autocomplete` control.

## Placeholder

You can prompt the user with any information by using the `Placeholder` property. This text will be displayed only if no items are selected or the edit text is empty. The default value of `Placeholder` property is `string.Empty` (No string will be displayed).

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete
    x:Name="autocomplete"
    WidthRequest="250"
    Placeholder="Select a social media"
    ItemsSource="{Binding SocialMedias}"
    DisplayMemberPath="Name"
    TextMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

autocomplete.Placeholder = "Select a social media";

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete placeholder](Images/UICustomization/Placeholder.png)

## Placeholder Color

The placeholder text color can be changed by using the `PlaceholderColor` property. The default value of `PlaceholderColor` property is `Colors.Gray`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete
    x:Name="autocomplete"
    WidthRequest="250"
    ItemsSource="{Binding SocialMedias}"
    DisplayMemberPath="Name"
    TextMemberPath="Name"
    Placeholder="Select a social media"
    PlaceholderColor="Red" />

{% endhighlight %}
{% highlight C# %}

autocomplete.PlaceholderColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete placeholder color](Images/UICustomization/PlaceholderColor.png)

## Clear Button Icon Color

The clear button icon color can be changed by using the `ClearButtonIconColor` property. The default value of `ClearButtonIconColor` property is `Colors.Black`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete
    x:Name="autocomplete"
    WidthRequest="250"
    ItemsSource="{Binding SocialMedias}"
    DisplayMemberPath="Name"
    TextMemberPath="Name"
    Placeholder="Select a social media"
    PlaceholderColor="Red"
    ClearButtonIconColor="Red" />

{% endhighlight %}
{% highlight C# %}

autocomplete.ClearButtonIconColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete clear button color](Images/UICustomization/ClearButtonColor.png)

## Border Color

The Autocomplete border color can be changed by using the `BorderColor` property.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete
    x:Name="autocomplete"
    WidthRequest="250"
    ItemsSource="{Binding SocialMedias}"
    DisplayMemberPath="Name"
    TextMemberPath="Name"
    Placeholder="Select a social media"
    PlaceholderColor="Red"
    BorderColor="Red" />

{% endhighlight %}
{% highlight C# %}

autocomplete.BorderColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete border color](Images/UICustomization/BorderColor.png)

## Maximum DropDown Height

The maximum height of the drop-down can be changed by using `MaxDropDownHeight` property of `Autocomplete` control. The default value of `MaxDropDownHeight` property is `400d`. 

N> If the `MaxDropDownHeight` is too small compared to the populated items, the scroll viewer will be automatically shown to navigate the hidden items.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete
    x:Name="autocomplete"
    WidthRequest="250"
    MaxDropDownHeight = "100"
    ItemsSource="{Binding SocialMedias}"
    DisplayMemberPath="Name"
    TextMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

autocomplete.MaxDropDownHeight = 100;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete maximum drop-down height](Images/UICustomization/MaxDropDownHeight.png)