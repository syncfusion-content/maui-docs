---
layout: post
title: Populating Items in .NET MAUI SfChipGroup | Syncfusion®
description: Learn how to populate the Syncfusion® .NET MAUI SfChipGroup control with business objects (via ItemsSource) or with SfChip instances (via Items).
platform: maui
control: SfChipGroup
documentation: ug
keywords: .net maui sfchipgroup populating items, syncfusion chips itemssource maui, sfchipgroup items maui, .net maui sfchip list binding, .net maui chip displaymemberpath, sfchipgroup chip type maui
---

# Populating Items in .NET MAUI SfChipGroup

[SfChipGroup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html) supports two ways to populate its items:

- **Business objects** — bind a collection to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemsSource) property.
- **SfChip instances** — add [SfChip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) controls to the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_Items) collection.

## Prerequisites

Before using the [SfChip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/chips/getting-started) documentation.

## Data Source Options

| Approach | Property | When to Use |
|----------|----------|-------------|
| Business objects | `ItemsSource` | Bind a list of model objects (e.g., `Employee`, `Tag`, `Category`). Supports change notification via `INotifyCollectionChanged`. |
| SfChip instances | `Items` | Build chips entirely in XAML or code, with full control over each chip's appearance. |

## Populate with business objects

Bind any `IEnumerable` (such as an `ObservableCollection<T>`) to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemsSource) property. By default, the chip's `Text` is set to the string representation of each item. Use `DisplayMemberPath` to bind a specific property of the business object.

The following example uses a simple `Employee` model and an `ObservableCollection<Employee>` exposed by a view model.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup x:Name="chipGroup"
                  Type="Action"
                  DisplayMemberPath="Name"
                  ItemsSource="{Binding Employees}" />

{% endhighlight %}
{% highlight C# %}

var viewModel = new EmployeeViewModel();
BindingContext = viewModel;
var chipGroup = new SfChipGroup
{
    ChipType = SfChipsType.Action,
    DisplayMemberPath = nameof(Employee.Name),
    ItemsSource = viewModel.Employees
};
Content = chipGroup;

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

public class Employee
{
    public string Name { get; set; } = string.Empty;
}

public class EmployeeViewModel
{
    public ObservableCollection<Employee> Employees { get; } = new()
    {
        new Employee { Name = "John" },
        new Employee { Name = "Jane" },
        new Employee { Name = "Alex" }
    };
}

{% endhighlight %}
{% endtabs %}

N> To render a custom view for each item, set the `ItemTemplate` property instead of `DisplayMemberPath`. The template receives each business object as its `BindingContext`.

## Populate with SfChip instances

Add [SfChip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) controls to the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_Items) collection. Use this approach when you need full control over each chip's appearance or when the items are not derived from a data model.

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <chip:SfChipGroup x:Name="chipGroup" 
                      ChipType="Action">
        <chip:SfChipGroup.Items>
            <chip:SfChip Text="Extra Small" 
                         TextColor="White" 
                         Background="Blue" />
            <chip:SfChip Text="Small" 
                         TextColor="White" 
                         Background="Blue" />
            <chip:SfChip Text="Medium" 
                         TextColor="White" 
                         Background="Blue" />
            <chip:SfChip Text="Large" 
                         TextColor="White" 
                         Background="Blue" />
            <chip:SfChip Text="Extra Large" 
                         TextColor="White" 
                         Background="Blue" />
        </chip:SfChipGroup.Items>
    </chip:SfChipGroup>
</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

var chipGroup = new SfChipGroup
{
    ChipType = SfChipsType.Action,
};

chipGroup.Items.Add(new SfChip { Text = "Extra Small", Background = Colors.Blue, TextColor = Colors.White });
chipGroup.Items.Add(new SfChip { Text = "Small", Background = Colors.Blue, TextColor = Colors.White });
chipGroup.Items.Add(new SfChip { Text = "Medium", Background = Colors.Blue, TextColor = Colors.White });
chipGroup.Items.Add(new SfChip { Text = "Large", Background = Colors.Blue, TextColor = Colors.White });
chipGroup.Items.Add(new SfChip { Text = "Extra Large", Background = Colors.Blue, TextColor = Colors.White });

Content = new VerticalStackLayout
{
    Children =
    {
        chipGroup
    }
};
{% endhighlight %}
{% endtabs %}

![SfChipGroup populated with five SfChip instances using the Action chip type](images/items/chips_items.png)

## See Also

- [Getting Started with .NET MAUI SfChipGroup/SfChip](https://help.syncfusion.com/maui/chips/getting-started)
- [Chip Types](https://help.syncfusion.com/maui/chips/chips-types)
- [Customization](https://help.syncfusion.com/maui/chips/customization)


