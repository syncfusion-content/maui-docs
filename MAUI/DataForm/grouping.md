---
layout: post
title: Grouping the editors in .NET MAUI DataForm control | Syncfusion
description: Learn about the grouping support in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Grouping the editors in .NET MAUI DataForm (SfDataForm)

The .NET MAUI DataForm supports the grouping of the editors, which are relevant to each other. Expand or collapse the group by tapping the group item.

Grouping is achieved by defining the [Display](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-7.0) attribute or by handling the `GenerateDataFormItem` event.

#### Using attributes

{% tabs %}
{% highlight C# %}

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

#### Using event

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing editors order in the group

#### Using attribute

#### Display attribute

The order of the editors in the group is changed by using attributes. Set the order of the data form items in the group by using the `Order` property along with the `GroupName` property in the `Display` attribute.

{% tabs %}
{% highlight C# %}
public class ContactInfo
{
    [Display(GroupName = "Name", Order = 0)]
    public string FirstName { get; set; }

    [Display(GroupName = "Name", Order = 2)]
    public string LastName { get; set; }

    [Display(GroupName = "Name", Order = 1)]
    public string MiddleName { get; set; }
}
{% endhighlight %}
{% endtabs %}

#### DataForm display options attribute

The order of the editors in the group is also changed by using the `RowOrder` property of the `DataFormDisplayOptions` attribute.

{% tabs %}
{% highlight C# %}

public class ContactInfo
{
    [Display(GroupName = "Details")]
    [DataFormDisplayOptions(RowOrder = 0)]
    public string FirstName { get; set; }

    [Display(GroupName = "Details")]
    [DataFormDisplayOptions(RowOrder = 2)]
    public string LastName { get; set; }

    [Display(GroupName = "Details")]
    [DataFormDisplayOptions(RowOrder = 1)]
    public string MiddleName { get; set; }
}

{% endhighlight %}
{% endtabs %}

#### Using event

The order of the editors in the group can also be changed by handling the `GenerateDataFormItem` event using `RowOrder` property of a `DataFormItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
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

{% endhighlight %}
{% endtabs %}

## Changing the editors order of the group in grid rows

The order of the editors of group in grid row can be changed within a row by using `RowOrder` and `ItemsOrderInRow` properties `DataFormDisplayOptions` attribute and by handling `GenerateDataFormItem` event.

{% tabs %}
{% highlight C# %}

    [Display(GroupName = "Name")]
    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 0)]
    public string FirstName { get; set; }

    [Display(GroupName = "Name")]
    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 2)]
    public string LastName { get; set; }

    [Display(GroupName = "Name")]
    [DataFormDisplayOptions(RowOrder = 0, ItemsOrderInRow = 1)]
    public string MiddleName { get; set; }

{% endhighlight %}
{% highlight C# %}

        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.ColumnCount = 3;
            }
        }

{% endhighlight %}
{% endtabs %}

## Changing the group name for the editors

The `GroupName` for the group can be changed in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing the layout for the group

The linear or grid layout for the particular group can be loaded by handling the `GenerateDataFormItem` event.
By setting the `ColumnCount` property in the data form, non-grouped items only will be arranged in the grid layout. To load the grid layout, set the `ColumnCount` for the `DataFormGroupItem`

{% tabs %}
{% highlight C# %}

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
{% highlight C# %}

this.dataForm.DataObject = new ContactsInfo();
this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.GroupName == "Name")
            {
                e.DataFormGroupItem.ColumnCount = 3;
            }
            else if (e.DataFormGroupItem.GroupName == "Details")
            {
                e.DataFormGroupItem.ColumnCount = 2;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Loading the group in collapsed state

By default, the group will be loaded in expanded state. You can collapse the group by setting the `IsExpanded` property of `DataFormGroupItem` class to `false`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Restricting the group expanding and collapsing

The group being expanded or collapsed can be restricted by setting the `AllowExpandCollapse` to `false` in the `DataFormGroupItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing the group editors visibility

The data form group visibility can be changed by using the `IsVisible` property of `DataFormGroupItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing the group header background

The data form group header background can be changed by using the `HeaderBackground` property of `DataFormGroupItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.GroupName == "Name")
            {
                e.DataFormGroupItem.HeaderBackground = Brush.Yellow;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Changing the group header text style

The data form group header text style can be changed by using the `HeaderTextStyle` property of `DataFormGroupItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.GroupName == "Name")
            {
                e.DataFormGroupItem.HeaderTextStyle = new DataFormTextStyle
                {
                    TextColor = Colors.Violet,
                    FontSize = 12,
                    FontAttributes = FontAttributes.Italic,
                };
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Changing the padding for group headers and editors

The distance between editors and the data form’s borders or group headers can be changed by using `ItemsPadding` property of `DataFormGroupItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormGroupItem.GroupName == "Name")
        {
            e.DataFormGroupItem.ItemsPadding = 20;
        }
    }

{% endhighlight %}
{% endtabs %}