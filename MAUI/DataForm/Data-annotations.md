---
layout: post
title: Data annotations in .NET MAUI DataForm(SfDataForm) control | Syncfusion
description: Learn here all about Data annotations support in Syncfusion Maui DataForm (SfDataForm) control to handle the data.
platform: maui
control: SfDataForm
documentation: UG
---

# Data annotations in .NET MAUI DataForm (SfDataForm)

The data form supports the following attribute to handle the data, and these attributes can be accessible using `System.ComponentModel.DataAnnotation` assembly.

## Display attribute

<table>
<tr>
<th>Property</th>
<th>Details</th>
</tr>
<tr>
<td>
{{'[Name](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.name?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies the label text.
</td>
</tr>
<tr>
<td>
{{'[GroupName](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.groupname?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies the group name which groups the fields in the data form. Refer to  `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ShortName](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.shortname?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies the label text. It takes higher priority than Name.
</td>
</tr>
<tr>
<td>
{{'[AutoGenerateField](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.autogeneratefield?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies whether the field should be auto generated or not. 
</td>
</tr>
<tr>
<td>
{{'[ResourceType](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.resourcetype?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies the Resources File (.Resx) which is used to localize the Display attribute of `Name`, `ShortName`, `GroupName`, `Prompt` and `ItemsSource` values.
</td>
</tr>
<tr>
<td>
{{'[Prompt](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.prompt?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies watermark text for the editor. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[Order](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.order?view=net-7.0)' | markdownify }}
</td>
<td>
Specifies the order of field in the data form.
</td>
</tr>
</table>

{% tabs %}
{% highlight Name attribute}

    [Display(Name= "First Name")]
    public string FirstName { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight GroupName attribute}

    [Display(GroupName = "Address")]
    public string Street { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight ShortName attribute}

    [Display(ShortName= "First Name")]
    public string Name { get; set; }

    [Display(AutoGenerateField =false)]
    public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight AutoGenerateField attribute}

    [Display(AutoGenerateField =false)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight Prompt attribute}

    [Display(Prompt = "Enter your name")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight Order attribute}

    [Display(Order =2)]
    public string MiddleName { get; set; }

{% endhighlight %}
{% endtabs %}

## Validation attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
{{'[MinLength](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.minlengthattribute?view=net-7.0)'| markdownify }}
</td>
<td>
Specifies the required minimum input string length.
</td>
</tr>
<tr>
<td>
{{'[MaxLength](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.maxlengthattribute?view=net-7.0)'| markdownify }}

</td>
<td>
Specifies the required maximum input string length.
</td>
</tr>
<tr>
<td>
{{'[Required](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute?view=net-7.0)'| markdownify }}
</td>
<td>
Specifies that a data field value is required. 
</td>
</tr>
<tr>
<td>
{{'[StringLength](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.stringlengthattribute?view=net-7.0)'| markdownify }}
</td>
<td>
Specifies the required string length. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[EnumDataType](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.enumdatatypeattribute?view=net-7.0)'| markdownify }}
</td>
<td>
Specifies enum type for the data field.
</td>
</tr>
</table>

{% tabs %}
{% highlight MinLength attribute}

    [MinLength(5,ErrorMessage ="Password length must be greater than 5 characters")]
    public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight MaxLength attribute}

    [MaxLength(20,ErrorMessage ="Maximum password length should be less than 20")]
    public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight Required attribute}

    [Required(AllowEmptyStrings =false, ErrorMessage ="Name is required")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight StringLength attribute}

    [StringLength(20,ErrorMessage ="Name should not exceed 20 characters")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

## EnumDataType attribute



{% tabs %}
{% highlight EnumDataType attribute}

    [EnumDataType(typeof(Gender), ErrorMessage = "Please select Gender")]
    public Gender Gender { get; set; }

{% endhighlight %}
{% endtabs %}

## Bindable attribute

It specifies whether the field should be auto generated or not. If bindable set to false the field will not be auto generated. 

{% tabs %}
{% highlight Bindable attribute}

    [Bindable(false)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

## Editable attribute

It specifies whether the data field is editable or not.

{% tabs %}
{% highlight Editable attribute}

    [Editable(false)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

## ReadOnly attribute

It specifies whether the data field is read only or not.

{% tabs %}
{% highlight ReadOnly attribute}

    [ReadOnly(false)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}



## DataType attribute

It specifies data type for the field.

Supported data types are Text, MultilineText, Date, DateTime and Time.

{% tabs %}
{% highlight DataType attribute}

    [DataType(DataType.MultilineText)]
    public string Address { get; set; }

{% endhighlight %}
{% endtabs %}

## Custom attribute
The data form supports the following custom attribute, and these attributes can be accessible using `Syncfusion.Maui.DataForm`.

### DataFormDisplayOptions attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
[RowSpan]
</td>
<td>
Specifies the row span for the data form item.
</td>
</tr>
<tr>
<td>
[ColumnSpan]
</td>
<td>
Specifies the column span for the data form item.
</td>
</tr>
<tr>
<td>
[ValidMessage]
</td>
<td>
Specifies positive message to be shown when validation is passed. 
</td>
</tr>
<tr>
<td>
[ShowLabel]
</td>
<td>
Specifies whether the label should be visible or not.
</td>
</tr>
<tr>
<td>
[ItemsOrderInRow]
</td>
<td>
Specifies the ItemsOrderInRow property to display multiple editors in a single row. Two items with the same RowOrder property value are placed in this row according to their ItemOrderInRow property values.
</td>
</tr>
</table>

{% tabs %}
{% highlight RowSpan attribute}

    [DataFormDisplayOptions(RowSpan =2)]
    public string Address { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight ColumnSpan attribute}

    [DataFormDisplayOptions(ColumnSpan =2)]
    public string Name { get; set; }    

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight ValidMessage attribute}

    [StringLength(20, ErrorMessage = "Value should not empty")]
    [DataFormDisplayOptions(ValidMessage = "Text length is enough")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight ShowLabel attribute}

    [DataFormDisplayOptions(ShowLabel = false)]
    public string City { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight ItemsOrderInRow attribute}

    dataForm.columnCount = 3;
    
    [DataFormDisplayOptions(ItemsOrderInRow =2)]
    public string Address { get; set; }

{% endhighlight %}
{% endtabs %}

### DataFormValueConverter attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
[DataFormValueConverterType]
</td>
<td>
Specifies the Converter type which converts the original value in different format or as different value. Refer to here for more details.
</td>
</tr>
</table>

{% tabs %}
{% highlight  attribute}

    [DataFormValueConverter(typeof(StringToStringConverter))]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

### DateFormDateRange attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
[MaximumDate] 
</td>
<td>
Specifies the required maximum date.
</td>
</tr>
<tr>
<td>
[MinimumDate] 
</td>
<td>
Specifies the required minimum date.
</td>
</tr>
<tr>
<td>
[DisplayFormat]
</td>
<td>
Specifies the required date display format.
</td>
</tr>
</table>

{% tabs %}
{% highlight  attribute}

    [DataFormDateRange(DisplayFormat="yyyy/mm/dd")]
    public DateTime Date { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight MaximumDate attribute}

    [DataFormDateRange(MaximumDate ="2022/07/07")]
    public DateTime Date { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight MinimumDate attribute}

    [DataFormDateRange( MinimumDate ="2022/01/01")]
    public DateTime Date { get; set; }

{% endhighlight %}
{% endtabs %}


Refer to `Here Link` for more details.
