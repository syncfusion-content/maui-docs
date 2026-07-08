---
layout: post
title: Selection in .NET MAUI ComboBox control | Syncfusion®
description: Learn about the selection modes in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, .net maui multi selection combobox, .net maui multi selection token, .net maui multi selection delimiter.
---

# Selection in .NET MAUI ComboBox

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control allows users to select a single item or multiple items from the drop-down. Use the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) property to choose between [Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Single) and [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Multiple) selection. The default value of `SelectionMode` is `Single`.

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later and the .NET MAUI workload. For setup details, see [Install .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0).
2. Create a [.NET MAUI project](Getting-Started.md#step-1-create-a-new-net-maui-project).
3. Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package in your .NET MAUI project.
4. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs`:

    ```csharp
    using Syncfusion.Maui.Core.Hosting;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
    ```

5. Add the following namespace declaration to your XAML page and `using` directive to your C# files:

    ```xml
    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    ```

    ```csharp
    using Syncfusion.Maui.Inputs;
    ```

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Define the model and view model

The samples below use the `SocialMedia` model and `SocialMediaViewModel` defined in [Getting Started](Getting-Started.md#step-4-define-model-and-view-model). Use a `BindingContext` on the page so that `{Binding SocialMedias}` resolves correctly.

## Single selection

In single selection mode, the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) allows users to select a single item from the drop-down. This is the default mode when `SelectionMode` is `Single`.

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

using Syncfusion.Maui.Inputs;

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
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox programmatic selection](Images/Selection/net-maui-combobox-programatic-selection.png)

## Multiple selection

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) allows users to select multiple values from the drop-down by setting the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_SelectionMode) property to [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSelectionMode.html#Syncfusion_Maui_Inputs_ComboBoxSelectionMode_Multiple). The selected items can be changed programmatically by using the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) property, which supports two-way binding.

There are two ways to display multi-selection items, controlled by the [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html) property. The default value is [Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Token).

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

{% highlight c# %}

using Syncfusion.Maui.Inputs;

public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public ObservableCollection<SocialMedia> SelectedItemsList { get; set; }

    public SocialMediaViewModel()
    {
        SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
        };

        SelectedItemsList = new ObservableCollection<SocialMedia>
        {
            SocialMedias[0],
            SocialMedias[2],
        };
    }
}

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox multiple selection](Images/Selection/net-maui-combobox-multiple-selection.png)

N> Switching `SelectionMode` from `Multiple` to `Single` at runtime clears the current `SelectedItems` collection.

### Delimiter

Set [MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html) to [Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_ComboBoxMultiSelectionDisplayMode_Delimiter) to display selected items as a single line separated by a custom character. Use the [DelimiterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText) `string` property to set the separator. The default value is `","`.

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

{% endtabs %}

![.NET MAUI ComboBox with MultiSelectionDisplayMode as Delimiter](Images/Selection/net-maui-combobox-delimiter.jpg)

### Token

Token mode supports two layouts for displaying selected items, controlled by the [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) property. The default value is `None`.

* [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_Wrap) - Wraps tokens onto multiple lines.
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_None) - Displays all tokens on a single horizontal line that scrolls horizontally.

#### Wrap mode

When [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) is set to [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_Wrap), the selected tokens wrap onto the next line when they exceed the editor width.

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

{% endtabs %}

![.NET MAUI ComboBox Wrap mode](Images/Selection/net-maui-combobox-wrapmode.png)

#### None mode

When [TokensWrapMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TokensWrapMode) is set to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTokensWrapMode.html#Syncfusion_Maui_Inputs_ComboBoxTokensWrapMode_None), the selected tokens are displayed on a single horizontal line that scrolls horizontally when it overflows.

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

{% endtabs %}

![.NET MAUI ComboBox None mode](Images/Selection/net-maui-combobox-nonemode.png)

## Selection events

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) raises events before and after the selection changes. The following sections describe each event and its arguments.

### SelectionChanging

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanging) event fires before the selection changes. Use this event to cancel or modify the selection based on predefined criteria.

The [SelectionChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangingEventArgs.html) provides the following members:

* [CurrentSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangingEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangingEventArgs_CurrentSelection) - The items that are about to be selected.
* [PreviousSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangingEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangingEventArgs_PreviousSelection) - The items that were previously selected.
* `Cancel` - Set to `true` to cancel the selection change.

The XAML below references an event handler defined in the page code-behind. The C# samples show the page constructor (which wires up the ComboBox and event) and the event handler.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    HeightRequest="40"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name"
                    SelectionChanging="OnSelectionChanging">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Inputs;

// Run this code in a ContentPage code-behind file (MainPage.xaml.cs).
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

        SfComboBox comboBox = new SfComboBox
        {
            WidthRequest = 250,
            HeightRequest = 40,
            ItemsSource = socialMediaViewModel.SocialMedias,
            TextMemberPath = "Name",
            DisplayMemberPath = "Name",
            BindingContext = socialMediaViewModel,
        };

        comboBox.SelectionChanging += OnSelectionChanging;
        Content = comboBox;
    }

    private void OnSelectionChanging(object sender, SelectionChangingEventArgs e)
    {
        // Set e.Cancel = true to cancel the selection change.
        e.Cancel = false;
    }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox SelectionChanging event](Images/Selection/net-maui-combobox-selection-changing-notification.gif)

### SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanged) event fires after the selection changes. The [SelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html) provides the following members:

* `AddedItems` - The items that were just selected.
* `RemovedItems` - The items that were unselected.

N> The `CurrentSelection` and `PreviousSelection` members of `SelectionChangedEventArgs` are marked as `Obsolete`. Use `AddedItems` and `RemovedItems` instead.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name"
                    ItemsSource="{Binding SocialMedias}"
                    SelectionChanged="OnSelectionChanged">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

        SfComboBox comboBox = new SfComboBox
        {
            ItemsSource = socialMediaViewModel.SocialMedias,
            DisplayMemberPath = "Name",
            TextMemberPath = "Name",
            BindingContext = socialMediaViewModel,
        };

        comboBox.SelectionChanged += OnSelectionChanged;
        Content = comboBox;
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // e.AddedItems contains the newly selected items.
        // e.RemovedItems contains the items that were unselected.
    }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox SelectionChanged event](Images/Selection/net-maui-combobox-selection-changed-event.gif)

## Selected value

The [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) property gets or sets a value based on the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) or [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems), depending on the selection mode. The [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) `string` property specifies which property of the selected item is used to populate `SelectedValue`.

### Single selection

In single selection mode, [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) holds the value defined by `SelectedValuePath`, such as the `ID` property. When [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem) returns the entire object (for example, `SocialMedia`), `SelectedValue` contains the value of the `SocialMedia.ID` property.

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

public partial class MainPage : ContentPage
{
    private readonly Label selectedValue = new Label { Text = string.Empty };
    private SfComboBox comboBox;

    public MainPage()
    {
        InitializeComponent();

        SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

        comboBox = new SfComboBox
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
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (comboBox.SelectedValue is not null)
        {
            selectedValue.Text = comboBox.SelectedValue.ToString();
        }
    }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox single selected value](Images/Selection/net-maui-combobox-single-selected-value.gif)

### Multiple selection

In multiple selection mode, [SelectedValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue) is a collection of values derived from [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems) based on [SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath) (for example, a list of `SocialMedia.ID` values for the selected items).

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

public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public ObservableCollection<object> SelectedValueList { get; set; }

    public SocialMediaViewModel()
    {
        SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Televzr", ID = 6 },
        };

        SelectedValueList = new ObservableCollection<object>
        {
            SocialMedias[4].ID,
            SocialMedias[6].ID,
        };
    }
}

public partial class MainPage : ContentPage
{
    private readonly Label selectedValue = new Label { Text = string.Empty };
    private SfComboBox comboBox;

    public MainPage()
    {
        InitializeComponent();

        SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

        comboBox = new SfComboBox
        {
            ItemsSource = socialMediaViewModel.SocialMedias,
            TextMemberPath = "Name",
            DisplayMemberPath = "Name",
            SelectionMode = ComboBoxSelectionMode.Multiple,
            SelectedValuePath = "ID",
            BindingContext = socialMediaViewModel,
        };

        comboBox.SelectionChanged += OnSelectionChanged;

        Content = new StackLayout
        {
            Children =
            {
                new Label { Text = "SelectedValue count:" },
                selectedValue,
                comboBox,
            },
        };
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (comboBox.SelectedValue is IList<object> value)
        {
            selectedValue.Text = value.Count.ToString();
        }
    }
}

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox multiple selected value](Images/Selection/net-maui-combobox-multiple-selected-value.png)

N> If `SelectedValuePath` is not specified, `SelectedValue` is the same as `SelectedItem` (single mode) or `SelectedItems` (multiple mode).

## Open or close the drop-down programmatically

The drop-down can be opened or closed programmatically by setting the [IsDropDownOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsDropDownOpen) `bool` property. The default value is `false`. Set it in code at runtime rather than in XAML, because the drop-down state is typically controlled by user interaction.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="true"
                    ItemsSource="{Binding SocialMedias}"
                    IsDropDownOpen = true;
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
{% endtabs %}

## Clear selected items

Use the [Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Clear) method to remove all selected items and clear the editor text. The snippet assumes `comboBox` is an instance reference to a `SfComboBox` in the current scope (for example, a field on the page code-behind).

{% tabs %}

{% highlight c# %}

comboBox.Clear();

{% endhighlight %}
{% endtabs %}

## See Also

* [Getting started with .NET MAUI ComboBox](getting-started.md)
* [Editing in .NET MAUI ComboBox](Editing.md)
* [Filtering in .NET MAUI ComboBox](Filtering.md)
* [Searching in .NET MAUI ComboBox](Searching.md)
* [Highlighting matched text in .NET MAUI ComboBox](Highlighting-matched-text.md)
* [SfComboBox API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html)