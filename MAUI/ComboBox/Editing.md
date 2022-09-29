---
layout: post
title: Editing in .NET MAUI ComboBox control | Syncfusion
description: Learn all about Editable modes support in Syncfusion .NET MAUI ComboBox (SfComboBox) control and more here.
platform: maui
control: SfComboBox
documentation: ug
---

# Editing in .NET MAUI ComboBox (SfComboBox)

The `ComboBox` control supports both editable and non-editable text boxes for selecting an item from a data source. To enable editing functionality, set `IsEditable` property as `true`. The default value is `false`.

## Editable ComboBox

In the editable mode, the `ComboBox` allows users to edit in the text box and it automatically appends the remaining letters to the entered text when it is valid.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="true"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
</editors:SfComboBox>

{% endhighlight %}

{% highlight C# %}

comboBox.IsEditable = true;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox choose item using editing](Images/Editing/EditableMode.png)

## Non-editable ComboBox

Non-editable mode prevents users from editing and instead allows them to select from the drop-down list.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="false"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
</editors:SfComboBox>

{% endhighlight %}

{% highlight C# %}

comboBox.IsEditable = false;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox choose item using non editing mode](Images/Editing/NonEditableMode.png)

## Hide clear button in the editor

By default, the clear button `X` will be displayed in the editor of the ComboBox control, which can be used to clear the entered input. Hide the clear button in ComboBox control using the `IsClearButtonVisible` property. The default value of the IsClearButtonVisible property value is `true`.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="true"
                    IsClearButtonVisible="false"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
</editors:SfComboBox>

{% endhighlight %}

{% highlight C# %}

comboBox.IsClearButtonVisible = false;

{% endhighlight %}
{% endtabs %}

N> The `IsClearButtonVisible` property has no effect in non-editable mode.

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox clear button visibility](Images/Editing/IsClearButtonVisible.png)