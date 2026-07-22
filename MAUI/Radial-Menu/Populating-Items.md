---
layout: post
title: Populating Items in .NET MAUI Radial Menu (SfRadialMenu) | Syncfusion®
description: Learn about item population support in the Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) control and more.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# Populating Items in .NET MAUI Radial Menu (SfRadialMenu)

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.RadialMenu`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/radial-menu/getting-started) documentation.

## Populating Items

This section explains how to populate the menu in two ways: by adding [`SfRadialMenuItem`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuItem.html) instances directly to the [`Items`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Items) collection, or by binding the menu to an [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_ItemsSource) and rendering each item with an [`ItemTemplate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_ItemTemplate). A second half of the document covers appearance and behavior properties such as `AnimationDuration`, `IsOpen`, `SeparatorColor`, `RimColor`, and `DisplayMemberPath`.

## Properties Summary

| Property | Type | Default | Description |
| --- | --- | --- | --- |
| `Items` | `RadialMenuItemsCollection` | empty | The collection of `SfRadialMenuItem` instances rendered as the rim. |
| `ItemsSource` | `IEnumerable` | `null` | The data source used to generate items. Pairs with `ItemTemplate` or `DisplayMemberPath`. |
| `ItemTemplate` | `DataTemplate` | `null` | Template used to render each item from `ItemsSource`. |
| `DisplayMemberPath` | `string` | `null` | Property name on each data item whose value is rendered as the item text. |
| `AnimationDuration` | `int` (milliseconds) | `300` | Duration of the open/close animation in milliseconds. |
| `IsOpen` | `bool` | `false` | Indicates (or sets) whether the menu is open. Set to `true` to open the menu at startup. |
| `SeparatorThickness` | `double` (DIUs) | `0` | Thickness of the strip between two adjacent items. |
| `SeparatorColor` | `Color` | theme default | Color of the strip between two adjacent items. |
| `RimRadius` | `double` (DIUs) | `120` | Radius of the rim. |
| `RimColor` | `Color` | theme default | Color of the rim. |
| `SelectionColor` | `Color` | theme default | Color applied to a menu item when it is selected. |

## Populate using SfRadialMenuItem instances

By adding [`SfRadialMenuItem`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuItem.html) instances to the menu's [`Items`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Items) collection, you can populate the rim with text, icons, images, or a custom view. Items can be nested to create sub-menus (see [Adding nested items](#adding-nested-items)).

### Text

The following sample creates a menu with text-only items.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu>
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items = new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

{% endhighlight %}

{% endtabs %}

## Populate using ItemsSource and ItemTemplate

Using [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_ItemsSource), objects of any class can be used as items in [`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html). The views corresponding to the objects can be set using the [`ItemTemplate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_ItemTemplate) property. Inside the `DataTemplate`, the binding context is the data item (not the page), so `{Binding EmployeeName}` reads the property of each item.

The following sample displays a list of users with a shared image and a per-item name from the view model.

{% tabs %}
{% highlight xaml %}

<radialMenu:SfRadialMenu 
    x:Name="radial_Menu"
    CenterButtonFontSize="28"
    CenterButtonFontFamily="Maui Material Assets"
    CenterButtonText="&#xe71b;"
    ItemsSource="{Binding EmployeeCollection}">
    <radialMenu:SfRadialMenu.ItemTemplate>
        <DataTemplate>
            <StackLayout>
                <Image Source="user.png" 
                        HorizontalOptions="Center" 
                        WidthRequest="15"/>
                <Label Text="{Binding EmployeeName}" 
                        HorizontalTextAlignment="Center" 
                        VerticalTextAlignment="Center"/>
            </StackLayout>
        </DataTemplate>
    </radialMenu:SfRadialMenu.ItemTemplate>
</radialMenu:SfRadialMenu>

{% endhighlight %}
{% highlight C# %}

EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfRadialMenu radial_Menu = new SfRadialMenu
{
    CenterButtonFontSize = 28,
    CenterButtonFontFamily = "Maui Material Assets",
    CenterButtonText = "Edit",
    ItemsSource = employeeViewModel.EmployeeCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        Label label = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center
        };
        label.SetBinding(Label.TextProperty, nameof(EmployeeModel.EmployeeName));
        return new StackLayout
        {
            Children =
            {
                new Image
                {
                    Source = "dotnet_bot.png",
                    HorizontalOptions = LayoutOptions.Center,
                    WidthRequest = 15
                },
                label
            }
        };
    })
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

public class EmployeeModel
{
    private string employeeName;

    public string EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }
}

public class EmployeeViewModel
{
    private ObservableCollection<EmployeeModel> employeeCollection = new ObservableCollection<EmployeeModel>();

    public ObservableCollection<EmployeeModel> EmployeeCollection
    {
        get { return employeeCollection; }
        set { employeeCollection = value; }
    }

    public EmployeeViewModel()
    {
        EmployeeCollection.Add(new EmployeeModel() { EmployeeName = "Alex" });
        EmployeeCollection.Add(new EmployeeModel() { EmployeeName = "Lee" });
        EmployeeCollection.Add(new EmployeeModel() { EmployeeName = "Ben" });
        EmployeeCollection.Add(new EmployeeModel() { EmployeeName = "Carl" });
        EmployeeCollection.Add(new EmployeeModel() { EmployeeName = "Yang" });
    }
}

{% endhighlight %}
{% endtabs %}


![ItemsSource and ItemTemplate](images/populating-items/maui-radialmenu-populating-itemssource-with-itemtemplate.png)

### Per-item images with ItemTemplate

The previous example used a single `user.png` for every item. To render a different image per item, expose an `ImageUrl` (or similar) property on the data item and bind to it.

{% tabs %}

{% highlight xaml %}
<DataTemplate>
    <StackLayout>
        <Image Source="{Binding ImageUrl}"
               HorizontalOptions="Center"
               WidthRequest="15" />
        <Label Text="{Binding EmployeeName}"
               HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </StackLayout>
</DataTemplate>
{% endhighlight %}

{% highlight C# %}
public class EmployeeModel
{
    public string EmployeeName { get; set; }
    public string ImageUrl { get; set; }
}

EmployeeCollection.Add(new EmployeeModel { EmployeeName = "Alex", ImageUrl = "alex.png" });
EmployeeCollection.Add(new EmployeeModel { EmployeeName = "Lee", ImageUrl = "lee.png" });

{% endhighlight %}
{% endtabs %}

## Customization properties

The properties in this section control the appearance and runtime behavior of the menu. They can be set in XAML or in C#.

## AnimationDuration

Use the [`AnimationDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_AnimationDuration) property (in milliseconds) to control the speed of the open and close animations. The default is 300 ms.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu AnimationDuration="800">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    AnimationDuration = 800,
    Items = new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    };
};

{% endhighlight %}
{% endtabs %}

## IsOpen

The [`IsOpen`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_IsOpen) property indicates (or sets) whether the menu is currently open. Setting `IsOpen="True"` in XAML opens the menu at startup; toggle it to `false` to close.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu IsOpen="True">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}
{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    IsOpen = true,
    Items = new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    };
};
           
{% endhighlight %}
{% endtabs %}

## Separator thickness and color

Use the [`SeparatorThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_SeparatorThickness) property to set the thickness of the strip between two adjacent items (in device-independent units, DIUs), and the [`SeparatorColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_SeparatorColor) property to set its color.

{% tabs %}
{% highlight xaml %}

<radialMenu:SfRadialMenu  SeparatorThickness="5" 
                            SeparatorColor="#FF1493">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}
{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    SeparatorThickness = 5,
    SeparatorColor = Color.FromArgb("#FF1493"),
    Items = new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

{% endhighlight %}
{% endtabs %}

## Rim color and radius

Use the [`RimRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_RimRadius) property to set the rim radius (in DIUs), and the [`RimColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_RimColor) property to set the rim color.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu  RimRadius="200" 
                            RimColor="#FF1493">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    RimRadius = 150,
    RimColor = Color.FromArgb("#FF1493"),
    Items = new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

{% endhighlight %}
{% endtabs %}

## DisplayMemberPath

When the menu is bound to a data source via [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_ItemsSource), use the [`DisplayMemberPath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DisplayMemberPath) property to indicate which property of each data item is rendered as the item text. This is a simpler alternative to `ItemTemplate` when you do not need a custom view per item.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu 
    ItemsSource="{Binding EmployeeCollection}"
    DisplayMemberPath="EmployeeName"/>

{% endhighlight %}

{% highlight C# %}

EmployeeViewModel employeeViewModel = new EmployeeViewModel();

SfRadialMenu radialMenu = new SfRadialMenu
{
    ItemsSource = employeeViewModel.EmployeeCollection,
    DisplayMemberPath = "EmployeeName"
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

public class Employee
{
    private int id;
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    private string employeeName;
    public string EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }
}

public class EmployeeViewModel
{
    private ObservableCollection<Employee> employeeCollection;
    public ObservableCollection<Employee> EmployeeCollection
    {
        get { return employeeCollection; }
        set { employeeCollection = value; }
    }
    public EmployeeViewModel()
    {
        employeeCollection = new ObservableCollection<Employee>();
        employeeCollection.Add(new Employee() { ID = 1, EmployeeName = "Eric" });
        employeeCollection.Add(new Employee() { ID = 2, EmployeeName = "James" });
        employeeCollection.Add(new Employee() { ID = 3, EmployeeName = "Jacob" });
        employeeCollection.Add(new Employee() { ID = 4, EmployeeName = "Lucas" });
    }
}

{% endhighlight %}
{% endtabs %}


## SelectionColor

Use the [`SelectionColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_SelectionColor) property to set the color applied to a menu item when it is selected (highlighted).

{% tabs %}
{% highlight xaml %}

<radialMenu:SfRadialMenu SelectionColor="#FF1493">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12" />
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12" />
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12" />
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12" />
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12" />
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}
{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    SelectionColor = Color.FromArgb("#FF1493")
    Items = new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

{% endhighlight %}
{% endtabs %}

## See also

- [SfRadialMenuItem’s Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/sfradialmenuitem-customization)
- [Segmenting and Placing Items in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/segmenting-placing-items)
- [CenterButton Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/centerbutton-customization)
- [Placing and Dragging in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/place-and-drag-radialmenu)