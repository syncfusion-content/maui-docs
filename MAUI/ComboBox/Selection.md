---
layout: post
title: Selection in .NET MAUI ComboBox control | Syncfusion
description: Learn here all about Selection modes support in Syncfusion .NET MAUI ComboBox (SfComboBox) control and more.
platform: maui
control: SfComboBox
documentation: ug
---

# Selection in .NET MAUI ComboBox (SfComboBox)

## Single selection

The `ComboBox` allows user to select an single item from the drop-down list.

### UI Selection 

The selected item can be changed interactively by selecting from the drop-down list or entering the value using keyboard and clicking the `Enter` key or losing the control focus.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name" />

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox UI selection](Images/Selection/UISelection.png)


### Programmatic selection 

The selected item can be changed programmatically by using the `SelectedItem` or `SelectedIndex` property of `ComboBox` control. 

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    MaxDropDownHeight="250"
                    IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    SelectedIndex="2" />

{% endhighlight %}

{% highlight c# %}

comboBox.SelectedIndex = 2;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox programmatic selection](Images/Selection/ProgramaticSelection.png)


## Selection changed notification

When an item is selected from the drop-down list, the `SelectionChanged` event is triggered. The `SelectionChanged` event contains the newly selected and previously selected item in the `CurrentSelection` and `PreviousSelection` properties. The `SelectionChanged` contains the following properties:

 * CurrentSelection - Contains the item that were currently selected.
 * PreviousSelection - Contains the item that were previously selected.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionChanged="OnSelectionChanged" />

{% endhighlight %}

{% highlight C# %}

comboBox.SelectionChanged += OnSelectionChanged;

{% endhighlight %}
{% endtabs %}

The SelectionChanged event can be handled as follows.

{% tabs %}
{% highlight C# %}

private async void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    await DisplayAlert("Alert", $"Selected Item has changed", "Ok");
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox SelectedChangedEvent](Images/Selection/SelectionChangedEventNotification.png)


## Get the selected value

The `SelectedValuePath` property allows you to specify a SelectedValue for a `ComboBox`'s `SelectedItem`. The `SelectedItem` represents an object in the `Items` collection, and the `ComboBox` displays the value of the selected item's single property. The `SelectedValuePath` property specifies the path to the property that is used to determine the `SelectedValue` property's value. The default value of `SelectedValue` and `SelectedValuePath` is `null`.

For example, when you select any `SocialMedia.Name` in the `ComboBox,` the `SelectedItem` property returns the `SocialMedia` data item that corresponds to the selected `SocialMedia.Name.` However, because the `SelectedValuePath` of this `ComboBox` is set to `SocialMedia.ID,` the `SelectedValue` is set to the `SocialMedia.ID.`

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    MaxDropDownHeight="250"
                    SelectedValuePath="ID"
                    TextMemberPath="Name"   
                    DisplayMemberPath="Name"
                    ItemsSource="{Binding SocialMedias}" 
                    SelectionChanged="OnSelectionChanged"/>

<Label Text="SelectedValue :" />
<Label x:Name="selectedValue" />

{% endhighlight %}
{% highlight C# %}

comboBox.SelectedValuePath = "ID";
comboBox.SelectionChanged += OnSelectionChanged;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    selectedValue.Text = comboBox.SelectedValue.ToString();
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox selected value](Images/Selection/SelectedValuePath.png)

## Open a drop-down programmatically

In `ComboBox` control, the drop-down can be opened or closed programmatically by using the `IsDropDownOpen` property. The default value of `IsDropDownOpen` property is `false`.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="true"
                    ItemsSource="{Binding SocialMedias}"
                    IsDropDownOpen = true;
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
</editors:SfComboBox>

{% endhighlight %}
{% highlight C# %}

comboBox.IsDropDownOpen = true;

{% endhighlight %}
{% endtabs %}