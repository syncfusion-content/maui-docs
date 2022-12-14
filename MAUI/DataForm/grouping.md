---
layout: post
title: Grouping in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the grouping support in Syncfusion .NET MAUI DataForm (SfDataForm) control and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Grouping editors

The .NET MAUI DataForm support to group the editors which are relevant to each other. You can expand or collapse the group by tapping the group item.

Grouping can be achieved by defining [Display] attribute or by handling the `GenerateDataFormItem` event.

#### Using attributes

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

#### Using event

{% tabs %}
{% highlight c# %}

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

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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


## Changing group name

The `GroupName` for the group can be changed in the `GenerateDataFormItem` event.

{% tabs %}
{% highlight c# %}

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
{% highlight c# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing linear and grid layout for the group

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

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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


## Setting different column count

The different `ColumnCount` can also be set for each group.

{% tabs %}
{% highlight c# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Loading group in collapsed state

By default, the group will be loaded in expanded state. You can collapse the group by setting the [IsExpanded] property of [DataFormGroupItem] class to `false`.

{% tabs %}
{% highlight c# %}

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
{% highlight c# %}

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
{% highlight c# %}

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