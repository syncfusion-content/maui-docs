---
layout: post
title: Selection in .NET MAUI Autocomplete control | Syncfusion®
description: Learn all about Selection support in Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control and more here.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Selection in .NET MAUI Autocomplete (SfAutocomplete)

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) allows user to select single or multiple items. The selection mode can be set by using the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode) property. There are two different selection modes: [Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteSelectionMode.html#Syncfusion_Maui_Inputs_AutocompleteSelectionMode_Single) and [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteSelectionMode.html#Syncfusion_Maui_Inputs_AutocompleteSelectionMode_Multiple).

## Single selection

The [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) allows the user to select an item by entering the value using the keyboard, then selecting from the drop-down list by clicking the item. The selected item can be retrieved from the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) property.

{% tabs %}
{% highlight c# %}

//Model.cs
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

//ViewModel.cs
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public ObservableCollection<SocialMedia> SelectedItemsList { get; set; }
    public ObservableCollection<object> SelectedValueList { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tumblr", ID = 9 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Twitter", ID = 10 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Vimeo", ID = 11 });
        this.SocialMedias.Add(new SocialMedia() { Name = "WhatsApp", ID = 12 });
        this.SocialMedias.Add(new SocialMedia() { Name = "YouTube", ID = 13 });

        SelectedItemsList = new ObservableCollection<SocialMedia>();
        this.SelectedItemsList.Add(SocialMedias[0]);
        this.SelectedItemsList.Add(SocialMedias[2]);
        this.SelectedItemsList.Add(SocialMedias[4]);

        this.SelectedValueList = new ObservableCollection<object>();
        this.SelectedValueList.Add(SocialMedias[0].ID); 
        this.SelectedValueList.Add(SocialMedias[4].ID);
    }
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name" />

{% endhighlight %}
{% highlight c# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    MinimumPrefixCharacters = 3,
    TextSearchMode = AutocompleteTextSearchMode.StartsWith,
    ItemsSource = socialMediaViewModel.SocialMedias
};

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete with single selection mode.](Images/Selection/net-maui-autocomplete-single-selection.png)

## Multiple selection

The Autocomplete allows user to select multiple values from the drop-down list by setting the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode) property as [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteSelectionMode.html#Syncfusion_Maui_Inputs_AutocompleteSelectionMode_Multiple).

The selected items can be changed programmatically by using the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) property. This property allows both getting and setting of the selected items in the Autocomplete control.

Also there are two ways to display multi-selection items in the AutoComplete control using [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html) property. By default MultiSelectionDisplayMode  is [Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Token).

* [Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Delimiter)
* [Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Token)

{% tabs %}

{% highlight xaml %}

  <editors:SfAutocomplete x:Name="autoComplete"
                SelectionMode="Multiple"
                ItemsSource="{Binding SocialMedias}"
                SelectedItems="{Binding SelectedItemsList}"
                DisplayMemberPath="Name"
                TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    SelectionMode = AutocompleteSelectionMode.Multiple,
    ItemsSource = socialMediaViewModel.SocialMedias
    SelectedItems = socialMediaViewModel.SelectedItemsList,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};

{% endhighlight %}

{% endtabs %}

### Delimiter

When setting [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html) to [Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Delimiter), the selected items can be separated by the desired character specified as the delimiter. We can set the delimiter text to any preferred character using the [DelimiterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText) property. By default DelimiterText is ",".

{% tabs %}

{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autoComplete" 
                         ItemsSource="{Binding SocialMedias}"
                         SelectionMode="Multiple"
                         MultiSelectionDisplayMode="Delimiter"
                         DelimiterText="/"
                         MaxDropDownHeight="250"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name"
                         Placeholder="Enter Media" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = AutocompleteSelectionMode.Multiple,
    MultiSelectionDisplayMode = AutocompleteMultiSelectionDisplayMode.Delimiter,
    DelimiterText = "/",
    MaxDropDownHeight = 250,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media"
};

{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete with MultiSelectionDisplayMode as Delimiter.](Images/Selection/net-maui-autocomplete-delimiter.jpg)

### Token
Multi-selection token mode has two different layouts to display the selected items by setting [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode) property.

* [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTokensWrapMode.html#Syncfusion_Maui_Inputs_AutocompleteTokensWrapMode_Wrap)
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTokensWrapMode.html#Syncfusion_Maui_Inputs_AutocompleteTokensWrapMode_None)

#### Wrap mode

When the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode) is set to [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTokensWrapMode.html#Syncfusion_Maui_Inputs_AutocompleteTokensWrapMode_Wrap), the selected items will be wrapped to the next line of the SfAutocomplete.

{% tabs %}

{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autoComplete" 
             ItemsSource="{Binding SocialMedias}"
             SelectionMode="Multiple"
             MaxDropDownHeight="250"
             DisplayMemberPath="Name"
             Placeholder="Enter Media"
             TextMemberPath="Name"
             TokensWrapMode="Wrap" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autoComplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    SelectionMode = AutocompleteSelectionMode.Multiple,
    MaxDropDownHeight = 250,
    TokensWrapMode = AutoCompleteTokensWrapMode.Wrap
};

{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete with TokensWrapMode as wrap.](Images/Selection/net-maui-autocomplete-wrapmode.png)

#### None Mode

When the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode) is set to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTokensWrapMode.html#Syncfusion_Maui_Inputs_AutocompleteTokensWrapMode_None), the selected item will be wrapped in a horizontal orientation.

{% tabs %}

{% highlight xaml %}

<editors:SfAutoComplete x:Name="autoComplete" 
             ItemsSource="{Binding SocialMedias}"
             DisplayMemberPath="Name"
             TextMemberPath="Name"
             Placeholder="Enter Media"
             SelectionMode="Multiple"
             MaxDropDownHeight="250"
             TokensWrapMode="None" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autoComplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = AutocompleteSelectionMode.Multiple,
    MaxDropDownHeight = 250,
    DisplayMemberPath = "Name",
    Placeholder = "Enter Media",
    TextMemberPath = "Name",
    TokensWrapMode = AutoCompleteTokensWrapMode.None
};

{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete with TokensWrapMode as none.](Images/Selection/net-maui-autocomplete-nonemode.png)

## Selection changing notification

When a user attempts to select an item from the drop-down list, the [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanging) event is triggered. This event allows developers to intercept the selection process, providing an opportunity to cancel or modify the selection based on predefined criteria.

The SelectionChangingEventArgs provides essential data related to the selection-changing event:

* [CurrentSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangingEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangingEventArgs_CurrentSelection) - Contains the item that are about to be selected.
* [PreviousSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangingEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangingEventArgs_PreviousSelection) - Contains the item that were previously selected.
* **Cancel** - Allows preventing the selection change when set to true.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"
                        SelectionChanging="OnSelectionChanging"/>

{% endhighlight %}

{% highlight C# %}

SfAutoComplete autocomplete = new SfAutoComplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name"
};
autocomplete.SelectionChanging += OnSelectionChanging;

{% endhighlight %}
{% endtabs %}

The `SelectionChanging` event can be handled as follows:

{% tabs %}
{% highlight C# %}

private async void OnSelectionChanging(object sender, Syncfusion.Maui.Inputs.SelectionChangingEventArgs e)
{
    await DisplayAlert("Alert", "Selecting Item has changing", "Ok");
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete selection changing event notification.](Images/Selection/net-maui-autocomplete-selection-changing-notification.gif)


## Selection changed notification

When an item is selected from the drop-down list, the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanged) event is triggered. The SelectionChanged event contains the newly selected and removed items in the `AddedItems` and `RemovedItems` properties. The SelectionChanged Event contains the following properties:

 * `AddedItems` - Contains the item that were currently selected.
 * `RemovedItems` - Contains the item that were unselected.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"
                        SelectionChanged="OnSelectionChanged"/>

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
};
autocomplete.SelectionChanged += OnSelectionChanged;

{% endhighlight %}
{% endtabs %}

The `SelectionChanged` event can be handled as follows:

{% tabs %}
{% highlight C# %}

private async void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    await DisplayAlert("Alert", "Selected Item has changed", "Ok");
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete selection changed event notification.](Images/Selection/net-maui-autocomplete-selection-changed-notification.gif)

N> SelectionChanged event arguments `CurrentSelection` and `PreviousSelection` marked as "Obsolete". You can use the `AddedItems` and `RemovedItems` event arguments.

## Selected value

The [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) property in a Autocomplete control allows you to get or set the selected value based on the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) depending on the selection mode. The [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property specifies which property of the selected item is used to populate the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue).

In single selection mode, the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) property holds the value defined by the [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property, such as "ID". When the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) returns the entire object (e.g., SocialMedia), the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) contains the value of SocialMedia.ID field.

{% tabs %}
{% highlight XAML %}

<StackLayout>
    <editors:SfAutocomplete x:Name="autocomplete"
                            MaxDropDownHeight="250"
                            TextMemberPath="Name"
                            DisplayMemberPath="Name"
                            ItemsSource="{Binding SocialMedias}"
                            SelectedValuePath="ID"
                            SelectionChanged="OnSelectionChanged"/>
    <HorizontalStackLayout>
        <Label x:Name="labelTitle" Text="SelectedValue :" />
        <Label x:Name="selectedValue" />
    </HorizontalStackLayout>
</StackLayout>

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    MaxDropDownHeight = 250,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectedValuePath = "ID"
};
autocomplete.SelectionChanged += OnSelectionChanged;

Label labelTitle = new Label { Text = "SelectedValue :" };
Label selectedValue = new Label();

HorizontalStackLayout horizontalLayout = new HorizontalStackLayout()
{
    Children = { labelTitle, selectedValue }
};

StackLayout mainLayout = new StackLayout
{
    Children = { autocomplete, horizontalLayout }
};


{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    selectedValue.Text = autocomplete.SelectedValue.ToString();
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete single selected value.](Images/Selection/net-maui-autocomplete-single-selected-value.png)

In multi-selection mode, the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) is a collection of values derived from the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) based on the [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property such as "ID", the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) will contains a list of IDs (e.g., SocialMedia.ID) corresponding to the selected SocialMedia items.

{% tabs %}
{% highlight XAML %}

<StackLayout>
    <editors:SfAutocomplete x:Name="autocomplete"
                            MaxDropDownHeight="250"
                            TextMemberPath="Name"
                            DisplayMemberPath="Name"
                            ItemsSource="{Binding SocialMedias}"
                            SelectionMode="Multiple"
                            SelectedValuePath="ID"
                            SelectedValue="{Binding SelectedValueList}"
                            SelectionChanged="OnSelectionChanged"/>
    <HorizontalStackLayout>
        <Label x:Name="labelTitle" Text="SelectedValue count :"/>
        <Label x:Name="selectedValue"/>
    </HorizontalStackLayout>
</StackLayout>

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    MaxDropDownHeight = 250,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = AutocompleteSelectionMode.Multiple,
    SelectedValuePath = "ID",
    SelectedValue = socialMediaViewModel.SelectedValueList
};
autocomplete.SelectionChanged += OnSelectionChanged;

Label labelTitle = new Label { Text = "SelectedValue count :" };
Label selectedValue = new Label();

HorizontalStackLayout horizontalLayout = new HorizontalStackLayout()
{
    Children = { labelTitle, selectedValue }
};

StackLayout mainLayout = new StackLayout
{
    Children = { autocomplete, horizontalLayout }
};

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void OnSelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
{
    if(autocomplete != null && autocomplete.SelectedValue is IList<object> value)
    {
        selectedValue.Text = value.Count.ToString();
    }
}

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete multiple selected value.](Images/Selection/net-maui-autocomplete-multiple-selected-value.png)

N> If the [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) is not specified, the [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) will be the same as the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems), depending on the selection mode.

## Hide clear button in the Autocomplete

By default, the clear button `X` will be displayed in the editor of the [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control, which can be used to clear the entered input. Hide the clear button in Autocomplete control using the [IsClearButtonVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsClearButtonVisibleProperty) property. The default value of IsClearButtonVisible property value is `true`.

{% tabs %}
{% highlight XAML %}

<editors:SfAutocomplete x:Name="autocomplete"
                        IsClearButtonVisible="false"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    IsClearButtonVisible = false,
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete is clear button visible.](Images/Selection/net-maui-autocompete-is-clear-button-visible.png)

## Is Drop-Down Open

In the Autocomplete control, the drop-down can be opened or closed programmatically by using the [IsDropDownOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsDropDownOpen) property. The default value of the IsDropDownOpen property is `false`.


{% tabs %}
{% highlight XAML %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        IsDropDownOpen = "true";
                        DisplayMemberPath="Name"
                        TextMemberPath="Name">
</editors:SfAutocomplete>

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    IsDropDownOpen = true,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};

{% endhighlight %}
{% endtabs %}


## Clear Selected Items

Users can remove selected items and input text using the [Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Clear) method in the Autocomplete control.

{% tabs %}

{% highlight C# %}

autocomplete.Clear();

{% endhighlight %}
{% endtabs %}
