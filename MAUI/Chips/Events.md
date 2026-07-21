---
layout: post
title: Events in .NET MAUI SfChipGroup and SfChip | Syncfusion®
description: Learn about the events raised by the Syncfusion® .NET MAUI SfChipGroup and SfChip controls, including SelectionChanging, SelectionChanged, ChipClicked, ItemRemoved, and CloseButtonClicked.
platform: maui
control: Chips
documentation: ug
keywords: .net maui sfchipgroup events, syncfusion chips selection changed maui, sfchipgroup chipclicked maui, .net maui sfchip close button clicked, sfchipgroup itemremoved maui, sfchip selection changing maui
---

# Events in .NET MAUI SfChipGroup and SfChip

[SfChipGroup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html) and [SfChip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) raise events to notify your application when the user interacts with the chips. This page documents the events exposed by both controls.

## Prerequisites

Before using the [SfChip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/chips/getting-started) documentation.

## Supported Events

| Event | Control | EventArgs | Trigger |
|-------|---------|-----------|---------|
| [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanging) | `SfChipGroup` | `SelectionChangingEventArgs` | Raised before a chip is selected. Can be canceled. |
| [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanged) | `SfChipGroup` | `SelectionChangedEventArgs` | Raised after a chip is selected. |
| [ChipClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipClicked) | `SfChipGroup` | `EventArgs` | Raised when a chip is clicked. |
| [ItemRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemRemoved) | `SfChipGroup` | `SelectionChangedEventArgs` | Raised after a chip is removed from an `Input`-type `SfChipGroup`. |
| [CloseButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_CloseButtonClicked) | `SfChip` | `EventArgs` | Raised when the close button of an `SfChip` is clicked. |

N> The `SelectionChanging` and `SelectionChanged` events are supported only for [`Choice`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Choice) and [`Filter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Filter) chip types. The `ItemRemoved` event is supported only for the [`Input`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Input) chip type.

## Selection changing event

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanging) event is raised before a chip is selected. Cancel the selection by setting the `Cancel` property of the event argument to `true`.

### Event Arguments

| Property | Type | Description |
|----------|------|-------------|
| `AddedItem` | `object` | The chip that is about to be selected. |
| `RemovedItem` | `object` | The previously selected or deselected chip. |
| `Cancel` | `bool` | Set to `true` to cancel the selection. Defaults to `false`. |

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <chip:SfChipGroup x:Name="chipGroup"
                        ChipType="Choice"
                        SelectionChanging="OnSelectionChanging">
        <chip:SfChip Text="Apple" />
        <chip:SfChip Text="Banana" />
        <chip:SfChip Text="Cherry" />
    </chip:SfChipGroup>
</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

// Folowing code comes under the main page constructor inside.
// Create ChipGroup
var chipGroup = new SfChipGroup
{
    ChipType = SfChipsType.Choice
};

// Subscribe to event
chipGroup.SelectionChanging += OnSelectionChanging;

// Add chips
chipGroup.Items.Add(new SfChip() { Text = "Apple" });
chipGroup.Items.Add(new SfChip() { Text = "Banana" });
chipGroup.Items.Add(new SfChip() { Text = "Cherry" });

// Create layout and add ChipGroup
var layout = new VerticalStackLayout();
layout.Children.Add(chipGroup);
Content = layout;

void OnSelectionChanging(object? sender, SelectionChangingEventArgs e)
{
    // Block selection of the "Cherry" chip.
    if (e.AddedItem is SfChip chip && chip.Text == "Cherry")
    {
        e.Cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}

## Selection changed event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanged) event is raised after a chip is selected.

### Event Arguments

| Property | Type | Description |
|----------|------|-------------|
| `AddedItem` | `object` | The newly selected chip. |
| `RemovedItem` | `object` | The previously selected chip (or `null` if there was no previous selection). |

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <chip:SfChipGroup x:Name="chipGroup"
                        ChipType="Filter"
                        SelectionChanged="OnSelectionChanged">
        <chip:SfChip Text="Red" />
        <chip:SfChip Text="Green" />
        <chip:SfChip Text="Blue" />
    </chip:SfChipGroup>
</VerticalStackLayout>

{% endhighlight %}

{% highlight C# %}

// Folowing code comes under the main page constructor inside.
var chipGroup = new SfChipGroup
{
    ChipType = SfChipsType.Filter
};

chipGroup.SelectionChanged += OnSelectionChanged;

chipGroup.Items.Add(new SfChip() { Text = "Apple" });
chipGroup.Items.Add(new SfChip() { Text = "Banana" });
chipGroup.Items.Add(new SfChip() { Text = "Cherry" });

var layout = new VerticalStackLayout();
layout.Children.Add(chipGroup);
Content = layout;

void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
{
    if (e.AddedItem is SfChip chip)
    {
        System.Diagnostics.Debug.WriteLine($"Selected: {chip.Text}");
    }
}

{% endhighlight %}
{% endtabs %}

## Chip clicked event

The [ChipClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipClicked) event is raised when a chip is clicked. The event argument is of type `EventArgs`, which exposes the clicked chip.

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <chip:SfChipGroup x:Name="chipGroup"
                        ChipType="Choice"
                        ChipClicked="OnChipClicked">
        <chip:SfChip Text="Red" />
        <chip:SfChip Text="Green" />
        <chip:SfChip Text="Blue" />
    </chip:SfChipGroup>
</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

// Folowing code comes under the main page constructor inside.
var chipGroup = new SfChipGroup
{
    ChipType = SfChipsType.Choice
};

chipGroup.ChipClicked += OnChipClicked;

chipGroup.Items.Add(new SfChip() { Text = "Apple" });
chipGroup.Items.Add(new SfChip() { Text = "Banana" });
chipGroup.Items.Add(new SfChip() { Text = "Cherry" });

var layout = new VerticalStackLayout();
layout.Children.Add(chipGroup);
Content = layout;

void OnChipClicked(object? sender, EventArgs e)
{
    if (sender is SfChip chip)
    {
        System.Diagnostics.Debug.WriteLine($"Clicked: {chip.Text}");
    }
}

{% endhighlight %}
{% endtabs %}

## Item removed event

The [ItemRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemRemoved) event is raised after a chip is removed from an `Input`-type `SfChipGroup`.

### Event Arguments

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <chip:SfChipGroup x:Name="chipGroup"
                        ChipType="Input"
                        DisplayMemberPath="Name"
                        ItemRemoved="OnChipItemRemoved"
                        ItemsSource="{Binding Employees}"/>
</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

var viewModel = new EmployeeViewModel();
BindingContext = viewModel;

var chipGroup = new SfChipGroup
{
    ChipType = SfChipsType.Input,
    DisplayMemberPath = "Name",
    ItemsSource = viewModel.Employees
};

chipGroup.ItemRemoved += OnChipItemRemoved;

Content = new VerticalStackLayout
{
    Children =
    {
        chipGroup
    }
};

void OnChipItemRemoved(object sender, SelectionChangedEventArgs e)
{
    if (e.RemovedItem is Employee employee)
    {
        System.Diagnostics.Debug.WriteLine($"Removed: {employee.Name}");
    }
}

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

## Close button clicked event

The [CloseButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_CloseButtonClicked) event is raised when the close button of an `SfChip` is clicked. The event argument is of type `EventArgs`.

{% highlight xaml %}

<VerticalStackLayout>
    <chip:SfChip x:Name="chip"
                Text="John"
                ShowCloseButton="True"
                CloseButtonClicked="OnCloseButtonClicked" />
</VerticalStackLayout>

{% endhighlight %}

{% highlight C# %}

var chip = new SfChip
{
    Text = "John",
    ShowCloseButton = true
};
chip.CloseButtonClicked += OnCloseButtonClicked;
Content = new VerticalStackLayout
{
    Children =
    {
        chip
    }
};

void OnCloseButtonClicked(object? sender, CloseButtonClickedEventArgs e)
{
    System.Diagnostics.Debug.WriteLine("Close button clicked");
}

{% endhighlight %}

## Troubleshooting

| Issue | Possible Cause | Recommended Action |
|-------|----------------|--------------------|
| `SelectionChanging` / `SelectionChanged` is never raised. | The `SfChipGroup.Type` is not `Choice` or `Filter`. | Set `Type="Choice"` or `Type="Filter"`. |
| `ItemRemoved` is never raised. | The `SfChipGroup.Type` is not `Input`. | Set `Type="Input"`. |
| The handler is not invoked from XAML. | The event handler name in the XAML attribute does not match the method name in the code-behind. | Verify the attribute name matches the method signature. |
| The clicked chip is not available in the handler. | The `ChipClicked` event argument's `Chip` property was not used. | Read the chip from `e.Chip` (or `e.AddedItem` for the selection events). |

## See Also

- [Getting Started with .NET MAUI SfChipGroup/SfChip](https://help.syncfusion.com/maui/chips/getting-started)
- [SfChipGroup API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html)
- [SfChip API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html)
- [Chip Types](https://help.syncfusion.com/maui/chips/chips-types)


