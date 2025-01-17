---
layout: post
title: Selection in .NET MAUI ComboBox control | Syncfusion®
description: Learn all about selection modes support in Syncfusion® .NET MAUI ComboBox (SfComboBox) control and more here.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, .net maui multi selection combobox, .net maui multi selection token, .net maui multi selection delimiter.
---

# Selection in .NET MAUI ComboBox (SfComboBox)

The .NET MAUI ComboBox allows user to select single or multiple items from the .NET MAUI drop-down list. The selection mode can be set by using the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) property. There are two different selection modes: [Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Single), and [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Multiple).

## Single selection

The [.NET MAUI ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) allows users to select an single item from the .NET MAUI drop-down list.

### UI Selection 

The selected item can be changed interactively by selecting from the .NET MAUI drop-down list or entering the value.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="True"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name" />

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox UI selection.](Images/Selection/net-maui-combobox-ui-selection.gif)


### Programmatic selection 

The selected item can be changed programmatically by using the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectedIndex) properties of the .NET MAUI ComboBox control.

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

![.NET MAUI ComboBox programmatic selection.](Images/Selection/net-maui-combobox-programatic-selection.png)

## Multiple selection

The .NET MAUI ComboBox allows user to select multiple values from the .NET MAUI drop-down list by setting the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) property as [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Multiple). The selected items can be changed programmatically by using the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) property. This property allows both getting and setting of the selected items in the .NET MAUI ComboBox control.

Also there are two ways to display multi-selection items in the .NET MAUI ComboBox control using [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html) Property. By default MultiSelectionDisplayMode is [Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Token).

* [Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Delimiter)
* [Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Token)


{% tabs %}

{% highlight xaml %}

 <editors:SfComboBox x:Name="comboBox" 
             HeightRequest="50"
             WidthRequest="350"
             ItemsSource="{Binding SocialMedias}"
             SelectedItems="{Binding SelectedItemsList}"
             SelectionMode="Multiple"
             MaxDropDownHeight="250"
             DisplayMemberPath="Name"
             TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

  public ObservableCollection<SocialMedia> SelectedItemsList { get; set; }
  SocialMediaViewModel socialMediaViewModel = (this.comboBox.BindingContext as SocialMediaViewModel);
  ObservableCollection<SocialMedia> socialMediasList = socialMediaViewModel.SocialMedias;
  SelectedItemsList = new ObservableCollection<SocialMedia>();
  SelectedItemsList.Add(socialMediasList[0]);
  SelectedItemsList.Add(socialMediasList[2]);

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code.

![.NET MAUI ComboBox Multiple selection.](Images/Selection/net-maui-combobox-multiple-selection.png)

### Delimiter

When setting [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html) to [Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Delimiter), the selected items can be separated by the desired character specified as the delimiter. We can set the delimiter text to any preferred character using the [DelimiterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText) property. By default DelimiterText is ",".

{% tabs %}

{% highlight xaml %}

 <editors:SfComboBox x:Name="combobox" 
                         HeightRequest="50"
                         WidthRequest="350"
                         ItemsSource="{Binding SocialMedias}"
                         SelectionMode="Multiple"
                         MultiSelectionDisplayMode="Delimiter"
                         DelimiterText="/"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name"
                         Placeholder="Enter Media" />

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox with MultiSelectionDisplayMode as Delimiter.](Images/Selection/net-maui-combobox-delimiter.jpg)

### Token
Multi-selection token mode has two different layouts to display the selected items by setting [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) property.

* [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_Wrap)
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_None)

#### Wrap mode

When the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) is set to [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_Wrap), the selected items will be wrapped to the next line of the SfComboBox.

{% tabs %}

{% highlight xaml %}

 <editors:SfComboBox x:Name="comboBox" 
             HeightRequest="50"
             WidthRequest="350"
             ItemsSource="{Binding SocialMedias}"
             SelectionMode="Multiple"
             Placeholder="Enter Media"
             DisplayMemberPath="Name"
             TextMemberPath="Name"
             TokensWrapMode="Wrap" />

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox Wrap mode.](Images/Selection/net-maui-combobox-wrapmode.png)

#### None mode

When the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) is set to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_None), the selected item will be wrapped in a horizontal orientation.

{% tabs %}

{% highlight xaml %}

 <editors:SfComboBox x:Name="comboBox" 
             HeightRequest="50"
             WidthRequest="350"
             ItemsSource="{Binding SocialMedias}"
             SelectionMode="Multiple"
             Placeholder="Enter Media"
             DisplayMemberPath="Name"
             TextMemberPath="Name"
             TokensWrapMode="None" />

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox None mode.](Images/Selection/net-maui-combobox-nonemode.png)

## Selection changed notification

When an item is selected from the .NET MAUI drop-down list, the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanged) event is triggered. The SelectionChanged event contains the newly selected and previously selected items in the `AddedItems` and `RemovedItems` properties. The SelectionChanged contains the following properties:

 * AddedItems - Contains the item that were currently selected.
 * RemovedItems - Contains the item that were unselected.

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

The SelectionChanged event can be handled as follows:

{% tabs %}
{% highlight C# %}

private async void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    await DisplayAlert("Alert", $"Selected Item has changed", "Ok");
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox SelectedChangedEvent.](Images/Selection/net-maui-combobox-selection-changed-event.gif)

N> SelectionChanged event arguments `CurrentSelection` and `PreviousSelection` marked as "Obsolete". You can use the `AddedItems` and `RemovedItems` event arguments.

## Selected value

The [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) property in a ComboBox control allows you to get or set the selected value based on the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) depending on the selection mode. The [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property specifies which property of the selected item is used to populate the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue).

In single selection mode, the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) property holds the value defined by the [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property, such as "ID". When the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) returns the entire object (e.g., SocialMedia), the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) contains the value of SocialMedia.ID field.

{% tabs %}
{% highlight XAML %}

<Label Text="SelectedValue :" />
<Label x:Name="selectedValue" />

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    MaxDropDownHeight="250"
                    TextMemberPath="Name"   
                    DisplayMemberPath="Name"
                    ItemsSource="{Binding SocialMedias}"
                    SelectedValuePath="ID"
                    SelectionChanged="OnSelectionChanged"/>

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

![.NET MAUI ComboBox single selected value.](Images/Selection/net-maui-combobox-single-selected-value.gif)

In multi-selection mode, the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) is a collection of values derived from the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) based on the [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property such as "ID", the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) will contains a list of IDs (e.g., SocialMedia.ID) corresponding to the selected SocialMedia items.

{% tabs %}
{% highlight XAML %}

<Label Text="SelectedValue count :" />
<Label x:Name="selectedValue" />

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    MaxDropDownHeight="250"
                    TextMemberPath="Name"   
                    DisplayMemberPath="Name"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionMode="Multiple"
                    SelectedValuePath="ID"
                    SelectedValue="{Binding SelectedValueList}"
                    SelectionChanged="OnSelectionChanged"/>

{% endhighlight %}
{% highlight C# %}

public ObservableCollection<object> SelectedValueList { get; set; }
SocialMediaViewModel socialMediaViewModel = (this.comboBox.BindingContext as SocialMediaViewModel);
ObservableCollection<SocialMedia> socialMediasList = socialMediaViewModel.SocialMedias;
SelectedValueList = new ObservableCollection<object>();
SelectedValueList.Add(socialMediasList[4].ID);
SelectedValueList.Add(socialMediasList[6].ID);
comboBox.SelectedValuePath = "ID";
comboBox.SelectionChanged += OnSelectionChanged;
  

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    if(comboBox != null && comboBox.SelectedValue is IList<object> value)
    {
        selectedValue.Text = value.Count.ToString();
    }
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox multiple selected value.](Images/Selection/net-maui-combobox-multiple-selected-value.png)

N> If the [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) is not specified, the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) will be the same as the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems), depending on the selection mode.

## Open a drop-down programmatically

In the .NET MAUI ComboBox control, the .NET MAUI drop-down list can be opened or closed programmatically by using the [IsDropDownOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsDropDownOpen) property. The default value of the IsDropDownOpen property is `false`.

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

## Clear Selected Items

Users can remove selected items and input text using the [Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Clear) method in the ComboBox control.

{% tabs %}

{% highlight C# %}

comboBox.Clear();

{% endhighlight %}
{% endtabs %}