---
layout: post
title: Validation in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the validation support in Syncfusion .NET MAUI DataForm (SfDataForm) and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Validation in .NET MAUI DataForm (SfDataForm)

The data form validates the data and displays hints in the case of validation is not passed. In case of invalid data, the error message is shown at the bottom of the editor.

## Built in validations

The supported built in validations are as follows:

* Data annotation

### Data annotations

You can validate the data using data annotation attributes.

The numeric type like Int, Double, Decimal properties can be validated using the [Range](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.rangeattribute?view=netframework-4.8) attribute.

{% tabs %}
{% highlight c# %}

    private int age;

    [Range(1,120,ErrorMessage ="Age should be between 1 and 120")]
    public int Age { get; set; }

{% endhighlight %}
{% endtabs %}

The String type property can be validated using [Required](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute?view=netframework-4.8) and [StringLength](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.stringlengthattribute?view=netframework-4.8) attributes.

{% tabs %}
{% highlight c# %}

    private string name;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Name should not be empty")]
    [StringLength(10, ErrorMessage = "Name should not exceed 15 characters")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Date range attribute

You can validate the date time value using date range attribute.

{% tabs %}
{% highlight c# %}

    private DateTime joinDate;

    [DataType(DataType.Date)]
    [DataFormDateRange(MinimumDate = "01/01/2022", MaximumDate = "31/12/2022", ErrorMessage = "Join date is invalid")]
    public DateTime JoinDate { get; set; }

{% endhighlight %}
{% endtabs %}

## Validation mode

The [ValidationMode] determines when the value should be validated.

The supported validation modes are as follows:

* LostFocus
* PropertyChanged
* Manual

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="ValidationMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm" 
        ValidationMode="LostFocus">
    </DataForm:SfDataForm>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

this.DataForm.ValidationMode = DataFormValidationMode.LostFocus;

{% endhighlight %}
{% endtabs %}

### LostFocus

If the commit mode is LostFocus, the value will be validated when the editor lost its focus.

### PropertyChanged

If the commit mode is PropertyChanged, The value will be validated immediately when it is changed.

### Explicit

The value should be validated manually by calling the [SfDataForm.Validate] or [SfDataForm.Validate(new List<string>())] method.

The following code validates the value of all the properties in the data object:

{% tabs %}
{% highlight c# %}

this.DataForm.Validate();

{% endhighlight %}
{% endtabs %}

To validate the specific list of property value, pass the property names as argument.

{% tabs %}
{% highlight c# %}
this.DataForm.Validate(new List<string>() {"FirstName", "Age" });
{% endhighlight %}
{% endtabs %}

You can determine whether the data form or property is valid or not by using the `Validate` method.

{% tabs %}
{% highlight c# %}

        bool isValid = DataForm.Validate();
        bool isPropertyValid = DataForm.Validate(new List<string>());

{% endhighlight %}
{% endtabs %}

If the data form or property is valid, `true` will be returned. Or else `false` will be returned.

N> For validating value, the new value should be committed in data object. So, `DataFormValidationMode` takes higher priority than `DataFormCommitMode`.

### Custom validation through events

You can validate the entire data form using the [ValidateForm] event of the data form.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm"
        ValidateForm="DataForm_ValidateForm">
    </DataForm:SfDataForm>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

this.DataForm.ValidateForm += DataForm_ValidateForm;

    private void DataForm_ValidateForm(object sender, DataFormValidateFormEventArgs e)
    {
        if (e.DataObject != null)
        {
            if (e.NewValues != null)
            {
                this.DataForm.Validate();
            }
        }
    }

{% endhighlight %}
{% endtabs %}

You can also validate the each property of data form using the [ValidateProperty] event of the data form.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm"
        ValidateProperty="DataForm_ValidateProperty">
    </DataForm:SfDataForm>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

this.DataForm.ValidateProperty += DataForm_ValidateProperty;

    private void DataForm_ValidateProperty(object sender, DataFormValidatePropertyEventArgs e)
    {
        if (e.PropertyName == "FirstName")
        {
            if (e.NewValue != null && e.NewValue.ToString().Length > 8)
            {
                e.IsValid = false;
                e.ErrorMessage = "Name should not exceed 10 characters";
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Valid message

If the value meets the desired criteria, you can show the [validmessage]. As error message, the valid message will also be displayed at the bottom of the editor.

{% tabs %}
{% highlight c# %}

    private string name;

    [DataFormDisplayOptions(ValidMessage = "Name length is enough")]
    [StringLength(10, ErrorMessage = "Name should not exceed 10 characters")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}


