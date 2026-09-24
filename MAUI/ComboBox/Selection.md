---
layout: post
title: Selection in .NET MAUI ComboBox | Syncfusion®
description: Learn how to configure single and multiple selection and related APIs in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, .net maui multi selection combobox, .net maui multi selection token, .net maui multi selection delimiter.
---

# Selection in .NET MAUI ComboBox

The [.NET MAUI ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control allows users to select a single item or multiple items from the drop-down. Use the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) property to choose between [Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Single) and [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Multiple) selection. The default value of `SelectionMode` is `Single`.

## Prerequisites

Before using the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/combobox/getting-started) documentation.

## Single selection

In single selection mode, the [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) allows users to select a single item from the drop-down. This is the default mode when `SelectionMode` is `Single`.

### UI selection

The selected item can be changed interactively by selecting from the drop-down or by typing a value into the editor.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    IsEditable = true,
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox UI selection](Images/Selection/net-maui-combobox-ui-selection.gif)

### Programmatic selection

The selected item can be changed programmatically by using the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) (`object`) or [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectedIndex) (`int`) property. `SelectedIndex` defaults to `-1` (no selection).

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    MaxDropDownHeight="250"
                    IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    SelectedIndex="2">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    MaxDropDownHeight = 250,
    IsEditable = true,
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    SelectedIndex = 2,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox programmatic selection](Images/Selection/net-maui-combobox-programatic-selection.png)

## Multiple selection

The [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) allows users to select multiple values from the drop-down by setting the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) property to [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Multiple). The selected items can be changed programmatically by using the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) property, which supports two-way binding.

There are two ways to display multi-selection items, controlled by the [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_MultiSelectionDisplayMode) property. The default value is `Token`.

* [Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Delimiter) - Displays selected items as a single line separated by a custom character.
* [Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Token) - Displays each selected item as a token (chip).

The following example uses `MultiSelectionDisplayMode="Token"` (the default) and binds `SelectedItems` to a view model property.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    SelectedItems="{Binding SelectedItemsList}"
                    SelectionMode="Multiple"
                    MaxDropDownHeight="250"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public ObservableCollection<SocialMedia> SelectedItemsList { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };

        SelectedItemsList = new ObservableCollection<SocialMedia>
        {
            SocialMedias[0],
            SocialMedias[2],
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox multiple selection](Images/Selection/net-maui-combobox-multiple-selection.png)

N> Switching `SelectionMode` from `Multiple` to `Single` at runtime clears the current `SelectedItems` collection.

### Delimiter

Set [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html) to `Delimiter` to display selected items as a single line separated by a custom character. Use the [DelimiterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText) property to set the separator. The default value is `","`.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionMode="Multiple"
                    MultiSelectionDisplayMode="Delimiter"
                    DelimiterText="/"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    Placeholder="Enter Media">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = ComboBoxSelectionMode.Multiple,
    MultiSelectionDisplayMode = ComboBoxMultiSelectionDisplayMode.Delimiter,
    DelimiterText = "/",
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox with MultiSelectionDisplayMode as Delimiter](Images/Selection/net-maui-combobox-delimiter.jpg)

### Token

`Token` mode supports two layouts for displaying selected items, controlled by the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) property. The default value is `None`.

* [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_Wrap) - Wraps tokens onto multiple lines.
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_None) - Displays all tokens on a single horizontal line that scrolls horizontally.

#### Wrap mode

When [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) is set to `Wrap`, the selected tokens wrap onto the next line when they exceed the editor width.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionMode="Multiple"
                    Placeholder="Enter Media"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    TokensWrapMode="Wrap">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = ComboBoxSelectionMode.Multiple,
    Placeholder = "Enter Media",
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    TokensWrapMode = ComboBoxTokensWrapMode.Wrap,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox Wrap mode](Images/Selection/net-maui-combobox-wrapmode.png)

#### None mode

When [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) is set to `None`, the selected tokens are displayed on a single horizontal line that scrolls horizontally when it overflows.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionMode="Multiple"
                    Placeholder="Enter Media"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    TokensWrapMode="None">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = ComboBoxSelectionMode.Multiple,
    Placeholder = "Enter Media",
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    TokensWrapMode = ComboBoxTokensWrapMode.None,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox None mode](Images/Selection/net-maui-combobox-nonemode.png)


## Selected value

The [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) property gets or sets a value based on the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems), depending on the selection mode. The [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) property specifies which property of the selected item is used to populate `SelectedValue`.

### Single selection

In single selection mode, `SelectedValue` holds the value defined by `SelectedValuePath`, such as the `ID` property. When `SelectedItem` returns the entire object (for example, `SocialMedia`), `SelectedValue` contains the value of the `SocialMedia.ID` property.

{% tabs %}
{% highlight xaml %}

<StackLayout>
    <Label Text="SelectedValue:" />
    <Label x:Name="selectedValue" />

    <editors:SfComboBox x:Name="comboBox"
                        MaxDropDownHeight="250"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"
                        ItemsSource="{Binding SocialMedias}"
                        SelectedValuePath="ID"
                        SelectionChanged="OnSelectionChanged">
        <editors:SfComboBox.BindingContext>
            <local:SocialMediaViewModel />
        </editors:SfComboBox.BindingContext>
    </editors:SfComboBox>
</StackLayout>

{% endhighlight %}
{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    MaxDropDownHeight = 250,
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    SelectedValuePath = "ID",
    BindingContext = socialMediaViewModel,
};

comboBox.SelectionChanged += OnSelectionChanged;

Label selectedValue = new Label
{
	Text = string.Empty
};

Content = new StackLayout
{
    Children =
    {
        new Label { Text = "SelectedValue:" },
        selectedValue,
        comboBox,
    },
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

The `SelectionChanged` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (comboBox.SelectedValue is not null)
    {
        selectedValue.Text = comboBox.SelectedValue.ToString();
    }
}

{% endhighlight %}
{% endtabs %}


The following image illustrates the result of the above code:

![.NET MAUI ComboBox single selected value](Images/Selection/net-maui-combobox-single-selected-value.gif)

### Multiple selection

In multiple selection mode, `SelectedValue` is a collection of values derived from `SelectedItems` based on `SelectedValuePath` (for example, a list of `SocialMedia.ID` values for the selected items).

{% tabs %}
{% highlight xaml %}

<StackLayout>
    <Label Text="SelectedValue count:" />
    <Label x:Name="selectedValue" />

    <editors:SfComboBox x:Name="comboBox"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"
                        ItemsSource="{Binding SocialMedias}"
                        SelectionMode="Multiple"
                        SelectedValuePath="ID"
                        SelectedValue="{Binding SelectedValueList}"
                        SelectionChanged="OnSelectionChanged">
        <editors:SfComboBox.BindingContext>
            <local:SocialMediaViewModel />
        </editors:SfComboBox.BindingContext>
    </editors:SfComboBox>
</StackLayout>

{% endhighlight %}
{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    SelectionMode = ComboBoxSelectionMode.Multiple,
    SelectedValuePath = "ID",
    BindingContext = socialMediaViewModel,
};

comboBox.SelectionChanged += OnSelectionChanged;

Label selectedValue = new Label
{
	Text = string.Empty
};
        
        
Content = new StackLayout
{
    Children =
    {
        new Label { Text = "SelectedValue count:" },
        selectedValue,
        comboBox,
    },
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public ObservableCollection<object> SelectedValueList { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };

        SelectedValueList = new ObservableCollection<object>
        {
            SocialMedias[4].ID,
            SocialMedias[6].ID,
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

The `SelectionChanged` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if(comboBox != null && comboBox.SelectedValue is IList<object> value)
    {
        selectedValue.Text = value.Count.ToString();
    }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox multiple selected value](Images/Selection/net-maui-combobox-multiple-selected-value.png)

N> If `SelectedValuePath` is not specified, `SelectedValue` is the same as `SelectedItem` (single mode) or `SelectedItems` (multiple mode).

## Open or close the drop-down programmatically

The drop-down can be opened or closed programmatically by setting the [IsDropDownOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsDropDownOpen) `bool` property. The default value is `false`.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    IsDropDownOpen = "True";
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
</editors:SfComboBox>

{% endhighlight %}
{% highlight C# %}

SfComboBox comboBox = new SfComboBox
{
    IsEditable = true,
    ItemsSource = socialMediaViewModel.SocialMedias,
    IsDropDownOpen = true,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

## Clear selected items

Use the [Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Clear) method to remove all selected items and clear the editor text. The snippet assumes `comboBox` is an instance reference to a `SfComboBox` in the current scope (for example, a field on the page code-behind).

{% tabs %}

{% highlight c# %}

comboBox.Clear();

{% endhighlight %}
{% endtabs %}

## See Also

* [Editing](https://help.syncfusion.com/maui/combobox/editing)
* [Filtering](https://help.syncfusion.com/maui/combobox/filtering)
* [Searching](https://help.syncfusion.com/maui/combobox/searching)
* [Highlighting matched text](https://help.syncfusion.com/maui/combobox/highlighting-matched-text)