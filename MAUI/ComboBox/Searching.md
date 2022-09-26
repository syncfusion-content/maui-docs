---
layout: post
title: Searching in .NET MAUI ComboBox control | Syncfusion
description: Learn how to perform searching operation in Syncfusion .NET MAUI ComboBox control and more.
platform: maui
control: SfComboBox
documentation: ug
---

# Searching in .NET MAUI ComboBox (SfComboBox)

The `ComboBox` control provides rich text searching functionality. The `TextSearchMode` property of the `ComboBox` can be used to regulate how the control behaves when it receives user input.

## Search based on member path

The `DisplayMemberPath` and `TextMemberPath` properties of ComboBox control specify the property path, by which the searching must be done when a custom data is bound to the `ItemsSource` property.

 * `DisplayMemberPath` - Specifies the property path whose value is displayed as text in the drop-down menu. The default value is `string.Empty`.

 * `TextMemberPath` - Specifies the property path whose value is used to perform searching based on user input received in the selection box portion of the `ComboBox` control. The default value is `string.Empty`. When `TextMemberPath` is `null` or `string.Empty`, searching will be performed based on `DisplayMemberPath`. 

N> `DisplayMemberPath` and `TextMemberPath` will be effective for the collection item that holds two or more properties in it.

N> When both the `DisplayMemberPath` and `TextMemberPath` properties have a `null` or `string.Empty` value, searching will be performed based on the class name with namespace of the item.

## Edit mode Searching based on TextMemberPath

In edit mode, searching will be performed based on the `TextMemberPath` property while entering the text into the selection box. When `TextMemberPath` is `null` or `string.Empty`, searching will be performed based on `DisplayMemberPath`. 

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="true"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="ID"
                    DisplayMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

comboBox.TextMemberPath = "ID";

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox search based on TextMemberPath](Images/Searching/SearchTextMemberPath.png)

## Non-Editable mode Searching based on DisplayMemberPath

In non-editable mode, searching will be performed based on the `DisplayMemberPath` property when user input is received in drop-down. 

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="ID" />

{% endhighlight %}

{% highlight C# %}

comboBox.DisplayMemberPath = "ID";

{% endhighlight %}
{% endtabs %}

For e.g. After typing `4` in drop-down.

The following image illustrates the result of the above code:

![.NET MAUI ComboBox search based on DisplayMemberPath](Images/Searching/SearchDisplayMemberPath.png)

N> Auto appending of text is supported only in `Editable` mode and `TextSearchMode` property should be `StartsWith`.

## Text Search Mode

The `TextSearchMode` property of the `ComboBox` can be used to regulate how the control behaves when it receives user input. The default text searching type is `StartsWith`, ignoring accent and it is case insensitive. The available text search modes are,

* StartsWith
* Contains

### Search with beginning text

Set the `TextSearchMode` property value to `StartWith` to search the matching items based on the starting text, and the first item which fits the user input in the drop-down list, will be highlighted.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    TextSearchMode="StartsWith"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

comboBox.TextSearchMode = ComboBoxTextSearchMode.StartsWith;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox TextSearchMode StartsWith](Images/Searching/TextSearchModeStartsWith.png)

### Search with contains text

Set the `TextSearchMode` property value to `Contains` to search the matching items containing specific text, and the first item which fits the user input in the drop-down list, will be highlighted.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="True"
                    TextSearchMode="Contains"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

comboBox.TextSearchMode = ComboBoxTextSearchMode.Contains;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox TextSearchMode Contains](Images/Searching/TextSearchModeContains.png)