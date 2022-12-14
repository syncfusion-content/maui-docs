---
layout: post
title: Grouping in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the grouping support in Syncfusion .NET MAUI DataForm (SfDataForm) control.
platform: maui
control: SfDataForm
documentation: ug
---

# Grouping editors in .NET MAUI DataForm (SfDataForm)

The .NET MAUI DataForm support to group the editors which are relevant to each other. You can expand or collapse the group by tapping the group item.

Grouping can be achieved by defining [Display] attribute or by handling the `GenerateDataFormItem` event.

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

The order of the editors in the group can be changed by using attributes. You can set the order of data form items in group by using the `Order` property along with `GroupName` property in display attribute.

{% tabs %}
{% highlight C# %}
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

The order of the `DataFormGroupItem` can also be changed by handling the `GenerateDataFormItem` event using `RowOrder` property of a `DataFormItem`.

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


## Changing group name

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
By setting the `ColumnCount` property in the data form, non-grouped items only will be arranged in the grid layout. To load the grid layout, set the [ColumnCount] for the `DataFormGroupItem`

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

## Loading group in collapsed state

By default, the group will be loaded in expanded state. You can collapse the group by setting the [IsExpanded] property of [DataFormGroupItem] class to `false`.

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

The group being expanded or collapsed can be restricted by setting the [AllowExpandCollapse] to `false` in the [DataFormGroupItem].

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

The data form group visibility can be changed by using the [IsVisible] property of [DataFormGroupItem].

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

The data form group header background can be changed by using the [HeaderBackground] property of [DataFormGroupItem].

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

The data form group header text style can be changed by using the [HeaderTextStyle] property of [DataFormGroupItem].

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

## Changing distance between group headers and editors

The distance between editors and the data form’s borders or group headers can be changed by using [ItemsPadding] property of [DataFormGroupItem].

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