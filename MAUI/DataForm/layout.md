---
layout: post
title: Layout in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the Layout support in Syncfusion .NET MAUI DataForm (SfDataForm) control and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Layout in .NET MAUI DataForm (SfDataForm)

## Overview

The data form supports linear and grid layouts and manages layout of label, editor, and validation label.

## Linear layout support

By default, the data form arranges the fields one-by-one. It is applicable for both label positions: left and top.

When the label position is Left, the linear layout is shown as follows:

When the label position is Top, the linear layout is shown as follows:

## Grid layout support

By default, the data form arranges one data field per row. It is possible to have more than one data fields per row by setting the [ColumnCount] property which provides grid like layout for the data form. The column order of data form field in a row can also be changed using [ItemsOrderInRow].

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">

    <dataForm:SfDataForm
        x:Name="dataForm"
        ColumnCount="2"
        >
    </dataForm:SfDataForm>

</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.ColumnCount = 2;

{% endhighlight %}
{% endtabs %}

N> Setting the `ColumnCount` property to SfDataForm does not arrange the data field in a group according to the column count. To set the column count for data fields in the data form group, refer to [loading different layout for data form group]

When the label position is Left, the grid layout is shown as follows:

When the label position is Top, the grid layout is shown as follows:

## Label visibility

The label can be hided by defining the [DataFormDisplayOptions] attribute or by handling `GenerateDataFormItem` event. In this case, only the editor will be loaded.

#### Using attributes

{% tabs %}
{% highlight C# %}
private double? percentage;

    [DataFormDisplayOptions(ShowLabel = false)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

{% tabs %}
{% highlight C# %}

 this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

Label can be positioned either top or left side of the editor. By using the [DataFormDefaultLayoutSettings.LabelPosition] property, you can layout the label associated with editor for data form.

By default, the label will be positioned at left side of the editor.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm">
        <dataForm:SfDataForm.DefaultLayoutSettings>
            <dataForm:DataFormDefaultLayoutSettings
                LabelPosition="Left"/>
        </dataForm:SfDataForm.DefaultLayoutSettings>
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

this.dataForm.DefaultLayoutSettings.LabelPosition = DataFormLabelPosition.Top;

{% endhighlight %}
{% endtabs %}

#### Changing particular editors label position

The label position of particular editor can be changed by using the [DataFormDefaultLayoutSettings.LabelPosition] property in `DataFormItem`, and it will be handled in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        DataObject="{Binding DataObjects}"
        GenerateDataFormItem="OnGenerateDataFormItem">
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

#### Using event

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing order of the editors

The order of the data form editors can be changed by using attributes or by handling `GenerateDataFormItem` event.

#### Using attributes

The data form editors order can be changed by using the `RowOrder` property in [DataFormDisplayOptionsAttribute] attribute.

{% tabs %}
{% highlight C# %}

    [DataFormDisplayOptions(RowOrder = 1)]
    public string Adress { get; set; }

    [DataFormDisplayOptions(RowOrder = 0)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

The data form editors order can be changed by using the [RowOrder] property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing editor order in grid rows

The order of the editors in grid row can be changed within a row by using attributes or by handling `GenerateDataFormItem` event.

#### Using attributes

The order of the editors in grid rows can be changed by using the `ItemsOrderInRow` property in [DataFormDisplayOptionsAttribute] attribute. This is applicable only for Grid layout.

{% tabs %}
{% highlight C# %}

this.dataForm.ColumnCount = 2;

{% endhighlight %}
{% highlight C# %}

    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 1)]
    public string LastName { get; set; }

    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 0)]
    public string FirstName { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

The order of the editors in grid rows can be changed by using the [ItemsOrderInRow] property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.ColumnCount = 2;
this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "FirstName")
            {
                e.DataFormItem.RowOrder = 0;
                e.DataFormItem.ItemsOrderInRow = 1;
            }
            else if (e.DataFormItem.FieldName == "LastName")
            {
                e.DataFormItem.RowOrder = 0;
                e.DataFormItem.ItemsOrderInRow = 0;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Change label and editor width

The label and editor width can be set proportionally by using [LabelWidth] and [EditorWidth] properties of [DefaultLayoutSettings] class.
The [Value] and [UnitType] properties of [DataFormItemLength] each return the value and unit type of the corresponding DataFormItemLength, respectively. 

Label and Editor can be specified with proportionate values such as 0.4* and 0.6* when the [DataFormItemLength.UnitType] is 'Star'.
Additionally, you can specify a defined width for the editor and label, such as "300, 400," and the [DataFormItemLength.UnitType] is "Absolute."


{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm">
        <dataForm:SfDataForm.DefaultLayoutSettings>
            <dataForm:DataFormDefaultLayoutSettings
                LabelWidth="0.4*"
                EditorWidth="0.6*"/>
        </dataForm:SfDataForm.DefaultLayoutSettings>
    </dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

        this.dataForm.DefaultLayoutSettings.LabelWidth = new DataFormItemLength(300, DataFormItemLengthUnitType.Absolute);
        this.dataForm.DefaultLayoutSettings.LabelWidth = new DataFormItemLength(400, DataFormItemLengthUnitType.Absolute);

{% endhighlight %}
{% highlight C# %}

        this.dataForm.DefaultLayoutSettings.LabelWidth = new DataFormItemLength(0.3, DataFormItemLengthUnitType.Star);
        this.dataForm.DefaultLayoutSettings.LabelWidth = new DataFormItemLength(0.7, DataFormItemLengthUnitType.Star);

{% endhighlight %}
{% endtabs %}

N> Label width customization is applicable only when `LabelPosition` is Left.

By default, the available width is divided into 40% for label and 60% for editor.

## Spanning editors rows and columns

Row height and column width can be increased by defining the `DataFormDisplayOptions` attribute or by handling `GenerateDataFormItem` event.

### Row span

#### Using attributes

Row height can be increased by using the [RowSpan] property in the`DataFormDisplayOptions` attribute.

{% tabs %}
{% highlight C# %}

    [DataFormDisplayOptions(RowSpan = 2)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

The row height of each `DataFormItem` can also be increased by using the [RowSpan] property and it will be handled in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

#### Using attributes

When the grid layout is used, the column width can be increased by using the [ColumnSpan] property in the `DataFormDisplayOptions` attribute.

{% tabs %}
{% highlight C# %}

this.dataForm.ColumnCount = 2;

{% endhighlight %}
{% highlight C# %}

    [DataFormDisplayOptions(ColumnSpan = 2)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

When the grid layout is used, you can increase the column width of each `DataFormItem` using the [ColumnSpan] property and it will be handled in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Change the editor visibility

The data form editor visibility can be changed at run time by using the [IsVisible] of `DataFormItem`.

{% tabs %}
{% highlight C# %}

    DataFormItem dataFormItem = this.dataForm.GetDataFormItem("Name");
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