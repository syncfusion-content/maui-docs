---
layout: post
title: Layout in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the Layout support in Syncfusion .NET MAUI DataForm (SfDataForm) control and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Layout in Xamarin DataForm (SfDataForm)

## Overview

The data form supports linear and grid layouts and manages layout of label, editor, and validation label.

## Linear layout support

By default, the data form arranges the fields one-by-one. It is applicable for both label positions: left and top.

When the label position is Left, the linear layout is shown as follows:

When the label position is Top, the linear layout is shown as follows:

## Grid layout support

By default, the data form arranges one data field per row. It is possible to have more than one data fields per row by setting the [ColumnCount] property which provides grid like layout for the data form. The order of data form field can also be changed in a row using [ItemsOrderInRow]

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm"
        ColumnCount="2"
        >
    </DataForm:SfDataForm>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

this.DataForm.ColumnCount = 2;

{% endhighlight %}
{% endtabs %}

N> Setting the `ColumnCount` property to SfDataForm does not arrange the data field in a group according to the column count. To set the column count for data fields in the data form group, refer to [loading different layout for data form group]

When the label position is Left, the grid layout is shown as follows:

When the label position is Top, the grid layout is shown as follows:

## Label visibility

The label can be hided by defining the [DataFormDisplayOptions] attribute or by handling `GenerateDataFormItem` event. In this case, only the editor will be loaded.

### Using attributes

{% tabs %}
{% highlight c# %}
private double? percentage;

    [DataFormDisplayOptions(ShowLabel = false)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

### Using event

{% tabs %}
{% highlight c# %}

 this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
        {
            e.DataFormItem.PlaceholderText = "Enter your name";
            e.DataFormItem.ShowLabel = false;
        }
    }

{% endhighlight %}
{% endtabs %}

## Label position

Label can be positioned either top or left side of the editor. By using the [DataFormDefaultLayoutSettings.LabelPosition] property, you can layout the label associated with editor.

By default, the label will be positioned at left side of the editor.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm">
        <DataForm:SfDataForm.DefaultLayoutSettings>
            <DataForm:DataFormDefaultLayoutSettings
                LabelPosition="Left"/>
        </DataForm:SfDataForm.DefaultLayoutSettings>
    </DataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

this.dataForm.DefaultLayoutSettings.LabelPosition = DataFormLabelPosition.Top;

{% endhighlight %}
{% endtabs %}

### Changing label position of the DataFormItem

The label position can be changed by using the [DataFormDefaultLayoutSettings.LabelPosition] property in `DataFormItem`, and it will be handled in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm"
        DataObject="{Binding DataObjects}"
        GenerateDataFormItem="OnGenerateDataFormItem">
    </DataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
        {
            e.DataFormItem.DefaultLayoutSettings = new DataFormDefaultLayoutSettings
            {
                LabelPosition = DataFormLabelPosition.Left,
            };
        }
    }

{% endhighlight %}
{% endtabs %}

## Loading images for label

Image can be loaded instead of label  by using [LeadingLabelIcon] property of `DataFormItem`.

## Using Event

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "Name")
            {
                e.DataFormItem.LeadingLabelIcon = ImageSource.FromFile("ContactInfo.png");
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Changing order of the DataFormItem

The order of the `DataFormItem` can be changed by using attributes or by handling `GenerateDataFormItem` event.

### Using attributes

The fields order can be changed by using the `RowOrder` property in [DataFormDisplayOptionsAttribute] attribute.

{% tabs %}
{% highlight c# %}

    [DataFormDisplayOptions(RowOrder = 1)]
    public string Adress { get; set; }

    [DataFormDisplayOptions(RowOrder = 0)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

### Using event

The fields order can be changed by using the [RowOrder] property in the `DataFormItem`.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "Name")
            {
                e.DataFormItem.RowOrder = 0;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Changing order of the DataFormItem in same row

The order of the `DataFormItem` can be changed within a row by using attributes or by handling `GenerateDataFormItem` event.

### Using attributes

The order of the fields can be changed by using the `ItemsOrderInRow` property in [DataFormDisplayOptionsAttribute] attribute. This is applicable only for Grid layout.

{% tabs %}
{% highlight c# %}

    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 1)]
    public string LastName { get; set; }

    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 0)]
    public string FirstName { get; set; }

{% endhighlight %}
{% endtabs %}

### Using event

The order of the fields can be changed by using the [ItemsOrderInRow] property in the `DataFormItem`.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "FirstName")
            {
                e.DataFormItem.ItemsOrderInRow = 1;
            }
            if (e.DataFormItem.FieldName == "LastName")
            {
                e.DataFormItem.ItemsOrderInRow = 0;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Grouping data fields

It is possible to group some fields and set group name in the data form. You can expand or collapse the group by tapping the group item.

Grouping can be achieved by defining [Display] attribute or by handling the `GenerateDataFormItem` event.

### Using attributes

{% tabs %}
{% highlight c# %}

public class ContactsInfo
{
    [Display(GroupName = "Name")]
    public string FirstName { get; set; }

    [Display(GroupName = "Name")]
    public string MiddleName { get; set; }

    [Display(GroupName = "Name")]
    public string LastName { get; set; }    
}

{% endhighlight %}
{% endtabs %}

### Using event

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "FirstName" || e.DataFormItem.FieldName == "MiddleName" || e.DataFormItem.FieldName == "LastName")
            {
                e.DataFormItem.GroupName = "Name";
            }
        }
    }

{% endhighlight %}
{% endtabs %}

### Changing order of the DataFormGroupItem

The order of the `DataFormGroupItem` can be changed by using attributes. You can set the order of data form items in group by using the `Order` property along with `GroupName` property in display attribute.

{% tabs %}
{% highlight c# %}
public class ContactInfo
{
    [Display(GroupName = "Name", Order = 0)]
    public string FirstName { get; set; }

    [Display(GroupName = "Name", Order = 1)]
    public string LastName { get; set; }

    [Display(GroupName = "Name", Order = 2)]
    public string MiddleName { get; set; }
}
{% endhighlight %}
{% endtabs %}

The order of the `DataFormGroupItem` can also be changed by handling the `GenerateDataFormItem` event.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.GroupName == "Name")
            {
                if (e.DataFormItem.FieldName == "FirstName")
                {
                    e.DataFormItem.RowOrder = 0;
                }
                else if (e.DataFormItem.FieldName == "LastName")
                {
                    e.DataFormItem.RowOrder = 2;
                }
                else if (e.DataFormItem.FieldName == "MiddleName")
                {
                    e.DataFormItem.RowOrder = 1;
                }
            }
        }
    }

{% endhighlight %}
{% endtabs %}


### Changing group name

The `GroupName` for the group can be changed in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

       private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.GroupName == "Name")
                {
                    e.DataFormItem.GroupName = "Name Group";
                }
            }
        }
    }

{% endhighlight %}
{% endtabs %}

### Loading different layout for group

The linear or grid layout for the particular group can be loaded by handling the `GenerateDataFormItem` event.
By setting the `ColumnCount` property in the data form, non-grouped items only will be arranged in the grid layout. To load the grid layout, set the [ColumnCount] for the `DataFormGroupItem`

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.ColumnCount = 2;
            }
            else if (e.DataFormGroupItem.Name == "Details")
            {
                e.DataFormGroupItem.ColumnCount = 3;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

#### Loading linear and grid layout for the group

{% tabs %}
{% highlight c# %}

public class ContactsInfo
{
    [Display(GroupName = "Name")]
    public string FirstName { get; set; }

    [Display(GroupName = "Name")]
    public string LastName { get; set; }

    [Display(GroupName = "Name")]
    public string MiddleName { get; set; }

    [Display(GroupName = "Details")]
    public string Address { get; set; }

    [Display(GroupName = "Details")]
    public double PhoneNumber { get; set; }
}

{% endhighlight %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.ColumnCount = 2;
            }
        }
    }


{% endhighlight %}
{% endtabs %}

In the following image, for the `Name` group, the grid layout is loaded and for the `Details` group, linear layout is loaded:


#### Setting different column count

The different `ColumnCount` can also be set for each group.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.ColumnCount = 2;
            }
            else if (e.DataFormGroupItem.Name == "Details")
            {
                e.DataFormGroupItem.ColumnCount = 3;
            }
        }
    }


{% endhighlight %}
{% endtabs %}

### Loading group in collapsed state

By default, the group will be loaded in expanded state. You can collapse the group by setting the [IsExpanded] property of [DataFormGroupItem] class to `false`.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.IsExpanded = false;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

### Restricting the group expanding and collapsing

The group being expanded or collapsed can be restricted by setting the [AllowExpandCollapse] to `false` in the [DataFormGroupItem].

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.AllowExpandCollapse = false;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

### Changing DataFormGroupItem visibility

The [DataFormGroupItem] visibility can be changed by using the [IsVisible] property.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.IsVisible = false;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

Here, the `Name` group will be hidden.

## Label width customization

The label and editor width can be set proportionally by using [LabelWidth] and [EditorWidth] properties of [DefaultLayoutSettings] class.
The [Value] and [UnitType] properties of [DataFormItemLength] each return the value and unit type of the corresponding DataFormItemLength, respectively. 

Label and Editor can be specified with proportionate values such as 0.4* and 0.6* when the [DataFormItemLength.UnitType] is 'Star'.
Additionally, you can specify a defined width for the editor and label, such as "300, 400," and the [DataFormItemLength.UnitType] is "Absolute."


{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="Sample.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm">
        <DataForm:SfDataForm.DefaultLayoutSettings>
            <DataForm:DataFormDefaultLayoutSettings
                LabelWidth="0.4*"
                EditorWidth="0.6*"/>
        </DataForm:SfDataForm.DefaultLayoutSettings>
    </DataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

    this.DataForm.DefaultLayoutSettings.LabelWidth = 300;
    this.DataForm.DefaultLayoutSettings.EditorWidth = 400;

{% endhighlight %}
{% endtabs %}

N> Label width customization is applicable only when `LabelPosition` is Left.

By default, the available width is divided into 40% for label and 60% for editor.

## Spanning rows and columns

Row height and column width can be increased by defining the `DataFormDisplayOptions` attribute or by handling `GenerateDataFormItem` event.

### Row span

### Using attributes

Row height can be increased by using the [RowSpan] property in the`DataFormDisplayOptions` attribute.

{% tabs %}
{% highlight c# %}
private string firstName;
[DisplayOptions(RowSpan = 2)]

    [DataFormDisplayOptions(RowSpan = 2)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

### Using event

The row height of each `DataFormItem` can also be increased by using the [RowSpan] property and it will be handled in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "Name")
            {
                e.DataFormItem.RowSpan = 2;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

Here, `Name` field’s row height is increased.

### Column span

### Using attributes

When the grid layout is used, the column width can be increased by using the [ColumnSpan] property in the `DataFormDisplayOptions` attribute.

{% tabs %}
{% highlight c# %}

this.DataForm.ColumnCount = 2;

{% endhighlight %}
{% highlight c# %}

    [DataFormDisplayOptions(ColumnSpan = 2)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

### Using event

When the grid layout is used, you can increase the column width of each `DataFormItem` using the [ColumnSpan] property and it will be handled in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight c# %}

this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "Name")
            {
                e.DataFormItem.ColumnSpan = 2;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Change DataFormItem visibility at runtime

The field visibility can be changed at run time by using the [IsVisible] property.

{% tabs %}
{% highlight c# %}

    DataFormItem dataFormItem = this.DataForm.GetDataFormItem("Name");
    if (dataFormItem != null)
    {
        if (dataFormItem.FieldName == "Name")
        {
            dataFormItem.IsVisible = false;
        }
    }

{% endhighlight %}
{% endtabs %}

Here, the `Name` field will be hidden.

## Change DataFormGroupItem visibility at runtime

The [DataFormGroupItem] visibility can be changed at run time by using the [IsVisible] property.

{% tabs %}
{% highlight c# %}

    DataFormGroupItem dataFormGroupItem = this.DataForm.GetDataFormGroupItem("Name");
    if (dataFormGroupItem != null)
    {
        if (dataFormGroupItem.Name == "Name")
        {
            dataFormGroupItem.IsVisible = false;
        }
    }

{% endhighlight %}
{% endtabs %}

Here, the `Name` group will be hidden.