---
layout: post
title: Data annotations in .NET MAUI DataForm control | Syncfusion®
description: Data annotations support in Syncfusion® Maui DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: UG
---

# Data annotations in .NET MAUI DataForm (SfDataForm)

The data form supports the following attribute to handle the data, and these attributes can be accessed using the [System.ComponentModel.DataAnnotation](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-7.0) assembly.

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
Specifies the group name that identifies the fields in the data form.
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
Specifies whether the field should be auto-generated or not. 
</td>
</tr>
<tr>
<td>
{{'[ResourceType](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.resourcetype?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies the Resources File (.Resx), which is used to localize the Display attribute of Name, ShortName, GroupName, Prompt and ItemsSource values.
</td>
</tr>
<tr>
<td>
{{'[Prompt](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.prompt?view=net-7.0)' |  markdownify }}
</td>
<td>
Specifies watermark text for the editor.
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
{% highlight C# %}

[Display(Name = "First Name", GroupName = "Name", Prompt="Enter your name")]
public string FirstName { get; set; }

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
Specifies the required data field value. 
</td>
</tr>
<tr>
<td>
{{'[StringLength](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.stringlengthattribute?view=net-7.0)'| markdownify }}
</td>
<td>
Specifies the required string length. 
</td>
</tr>
<tr>
<td>
{{'[EnumDataType](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.enumdatatypeattribute?view=net-7.0)'| markdownify }}
</td>
<td>
Specifies the enum type for the data field.
</td>
</tr>
</table>

{% tabs %}
{% highlight C# %}

[MinLength(5, ErrorMessage = "Password length must be greater than 5 characters")]
public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

[MaxLength(20, ErrorMessage = "Maximum password length should be less than 20")]
public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

[Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

[StringLength(20, ErrorMessage = "Name should not exceed 20 characters")]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}


{% tabs %}
{% highlight C# %}

[EnumDataType(typeof(Gender), ErrorMessage = "Please select Gender")]
public Gender Gender { get; set; }

{% endhighlight %}
{% endtabs %}

## Bindable attribute

It specifies whether the field should be auto-generated or not. If bindable is set to false, the field will not be auto-generated. 

{% tabs %}
{% highlight C# %}

[Bindable(false)]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

## Editable attribute

It specifies whether the data field is editable or not.

{% tabs %}
{% highlight C# %}

[Editable(false)]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

## ReadOnly attribute

It specifies whether the data field is read only or not.

{% tabs %}
{% highlight C# %}

[ReadOnly(true)]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

N> The `ReadOnlyAttribute` takes higher priority than `EditableAttribute`

## DataType attribute

It specifies the data type for the field.

The Supported data types are Text, MultilineText, Date, DateTime and Time.

{% tabs %}
{% highlight C# %}

[DataType(DataType.MultilineText)]
public string Address { get; set; }

{% endhighlight %}
{% endtabs %}

## Custom attribute
The data form supports the following custom attribute, and these attributes can be accessed using the [Syncfusion.Maui.DataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.html) assembly.

#### DataFormDisplayOptions attribute

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
{{'[RowSpan](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_RowSpan)'| markdownify }}
</td>
<td>
Specifies the row span for the data form item.
</td>
</tr>
<tr>
<td>
{{'[ColumnSpan](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ColumnSpan)'| markdownify }}
</td>
<td>
Specifies the column span for the data form item.
</td>
</tr>
<tr>
<td>
{{'[ValidMessage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ValidMessage)'| markdownify }}
</td>
<td>
Specifies the positive message to be shown when validation is passed. 
</td>
</tr>
<tr>
<td>
{{'[ShowLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ShowLabel)'| markdownify }}
</td>
<td>
Specifies whether the label should be visible or not.
</td>
</tr>
<tr>
<td>
{{'[RowOrder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_RowOrder)'| markdownify }}
</td>
<td>
Specifies the row order of field in the data form
</td>
</tr>
<tr>
<td>
{{'[ItemsOrderInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ItemsOrderInRow)'| markdownify }}
</td>
<td>
Specifies the ItemsOrderInRow property to display multiple editors in a single row. Two items with the same RowOrder property value are placed in this row according to their ItemOrderInRow property values.
</td>
</tr>
</table>

{% tabs %}
{% highlight C# %}

[DataFormDisplayOptions(Rowspan = 2, ColumnSpan = 2, RowOrder = 1, ItemsOrderInRow = 0)]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### DataFormValueConverter attribute

Specifies the Converter type, which converts the original value in a different format or as a different value.

N> When publishing in AOT mode on iOS and macOS, ensure that `[Preserve(AllMembers = true)]` is added to the converter class in order to maintain its functionality.

{% tabs %}
{% highlight C# %}

[DataFormValueConverter(typeof(StringToDateConverter))]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### DateFormDateRange attribute

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
{{'[MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_MaximumDate)'| markdownify }}
</td>
<td>
Specifies the maximum date that can be selected in the date editor.
</td>
</tr>
<tr>
<td>
{{'[MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_MinimumDate)'| markdownify }}
</td>
<td>
Specifies the minimum date that can be selected in the date editor.
</td>
</tr>
<tr>
<td>
{{'[DisplayFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_DisplayFormat)'| markdownify }}
</td>
<td>
Specifies the format of the {{'[MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_MaximumDate)'| markdownify }} and {{'[MinumumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_MinimumDate)'| markdownify }} used in attribute.
</td>
</tr>
</table>

{% tabs %}
{% highlight C# %}

[DataFormDateRange(DisplayFormat="yyyy/mm/dd", MaximumDate ="2022/07/01", MaximumDate ="2022/07/07")]
public DateTime EventDate { get; set; }

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/DataFormAnnotations)