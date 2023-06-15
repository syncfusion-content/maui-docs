---
layout: post
title: Change the editor settings in .NET MAUI DataForm control | Syncfusion
description: Learn about to change the Syncfusion .NET MAUI DataForm (SfDataForm) settings in mobile and desktop applications from a single shared codebase.
platform: Maui
control: SfDataForm
documentation: UG
---

# Change the data editor settings (SfDataForm)

## Auto generate data editor 

By default, the [SfDataForm.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) will be generated based on the property type. For example, the [DataFormTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextItem.html) will be generated based on the property type in [DataObject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject).
The [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) generation depends on the type and attribute defined for the property.

You can customize the auto-generated editor, label, and group settings by using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event.

<table>
<tr>
<th>Generated DataFormItem Type</th>
<th>Editor</th>
<th>Data Type / Attribute</th>
</tr>
<tr>
<td>
{{'[DataFormTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextItem.html)'| markdownify }}
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the string type and the properties with [DataType(DataType.Text)] attribute.
</td>
</tr>
<tr>
<td>
{{'[DataFormMultilineTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMultilineItem.html)'| markdownify }}
</td>
<td>
{{'[Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the string type properties with [DataType(DataType.MultilineText)] attribute. 
</td>
</tr>
<tr>
<td>
{{'[DataFormPasswordItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormPasswordItem.html)'| markdownify }}
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the string type properties with [DataType(DataType.Password)] attribute. 
</td>
</tr>
<tr>
<td>
{{'[DataFormDateItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateItem.html)'| markdownify }}
</td>
<td>
{{'[DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the DateTime, DateTimeOffset, and DateOnly type properties and the properties with [DataType(DataType.Date)] or [DataType(DataType.DateTime)] attributes.
</td>
</tr>
<tr>
<td>
{{'[DataFormTimeItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTimeItem.html)'| markdownify }}
</td>
<td>
{{'[TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows)'| markdownify }}
</td>
<td>
Generated for TimeSpan and TimeOnly type properties and the properties with [DataType(DataType.Time)] attribute. 
</td>
</tr>
<tr>
<td>
{{'[DataFormCheckBoxItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCheckBoxItem.html)'| markdownify }}
</td>
<td>
{{'[CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the Bool type property.
</td>
</tr>
<tr>
<td>
{{'[DataFormSwitchItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormSwitchItem.html)'| markdownify }}
</td>
<td>
{{'[Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the Bool type property.
</td>
</tr>
<tr>
<td>
{{'[DataFormComboBoxItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormComboBoxItem.html)'| markdownify }}
</td>
<td>
{{'[SfComboBox](https://help.syncfusion.com/maui/combobox)'| markdownify }}
</td>
<td>
Generated for the enum type property. 
</td>
</tr><tr>
<td>
{{'[DataFormAutoCompleteItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormAutoCompleteItem.html)'| markdownify }}
</td>
<td>
{{'[SfAutoComplete](https://help.syncfusion.com/maui/autocomplete)'| markdownify }}
</td>
<td>
Generated for the enum type property. 
</td>
</tr>
<tr>
<td>
{{'[DataFormPickerItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormPickerItem.html)'| markdownify }}
</td>
<td>
{{'[Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the enum type property. 
</td>
</tr>
<tr>
<td>
{{'[DataFormRadioGroupItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormRadioGroupItem.html)'| markdownify }}
</td>
<td>
{{'[RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the enum type property.
</td>
</tr>
</table>

You can customize the property settings or cancel the generation of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) by handling the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event.

## Cancel the auto generate data editors

You can cancel the specific data editor by handling the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is set to true or by defining display attribute to avoid the particular data field being displayed.

#### Using attributes

You can set [AutoGenerateField](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.autogeneratefield?view=net-7.0) to `false` for canceling the data editor generation.

{% tabs %}
{% highlight C# %}

[Display(AutoGenerateField = false)]
public int ID { get; set; } 
    
{% endhighlight %}
{% endtabs %}

#### Using event

In the following code, the data editor generation for the `MiddleName` property is canceled by setting the `Cancel` property to true of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html).

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem.FieldName == "MiddleName")
    {
        e.Cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}

The [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event will be raised only when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is set to true.

For [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) false, you can use settings properties directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

## Change the editor settings

#### Change the editor read only

You can change the data editor settings by using the property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

Here, `Salary` data field is restricted from being edited in the data form.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "MiddleName")
        {
             e.DataFormItem.IsReadOnly = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

#### Change the editor visibility

You can change the specific editor visibility by using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_IsVisible) property of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

Here, the `LastName` data field will be hidden.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "LastName")
        {
            e.DataFormItem.IsVisible = false;
        }
    }
}

{% endhighlight %}
{% endtabs %}

#### Setting watermark for data editor

You can display the watermark in the editor by defining the display attribute or using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems]((https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems)) is true.

#### Using attribute

You can show the watermark in the editor by setting the [Prompt](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.prompt?view=net-7.0) in display attribute.

{% tabs %}
{% highlight C# %}

[Display(Prompt = "Enter middle name")]
public string MiddleName { get; set; }
    
{% endhighlight %}
{% endtabs %}

#### Using event

You can show the watermark in the editor by using the [PlaceholderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_PlaceholderText) property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Description")
        {
            e.DataFormItem.PlaceholderText = "Enter description";
        }
    }
}
{% endhighlight %}
{% endtabs %}

![Editor placeholder text in .NET MAUI DataForm.](images/editor-settings/placeholder-text.png)

#### Changing watermark color for data editor

You can change the color for the watermark in the editor by using the [PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_PlaceholderColor) property of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Description")
        {
            e.DataFormItem.PlaceholderText = "Enter description";
            e.DataFormItem.PlaceholderColor = Colors.MistyRose;
        }
    }
}
{% endhighlight %}
{% endtabs %}

![Editor placeholder text color in .NET MAUI DataForm.](images/editor-settings/placeholder-text-color.png)

#### Change padding for the data editor

You can create a space around a label and editor by using the [Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_Padding) property in the DataFormItem by using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

Here, the `FirstName` data field will be changed from the default position.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "LastName")
        {
            e.DataFormItem.Padding = new Thickness(10);
        }
    }
}
{% endhighlight %}
{% endtabs %}

![Editor padding in .NET MAUI DataForm.](images/editor-settings/changing-padding.png)

#### Change editor layout settings

You can change the label width, label position, and editor width. This is possible by using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true. In the event, change the layout settings by using the [DefaultLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DefaultLayoutSettings) property in the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html).

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

By default label position is left.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Description")
        {
            e.DataFormItem.DefaultLayoutSettings.LabelPosition = DataFormLabelPosition.Top;
            e.DataFormItem.DefaultLayoutSettings.LabelWidth = 100;
            e.DataFormItem.DefaultLayoutSettings.EditorWidth = 200;
        }
    }
}
{% endhighlight %}
{% endtabs %}

Please refer [here](https://help.syncfusion.com/maui/dataform/layout#change-the-label-and-editor-width) to learn more about editor layout settings. 

#### Change the Background for editor layout

You can change the background color for the label and editor by using [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "FirstName")
        {
            e.DataFormItem.Background = Brush.Azure; 
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Change the label name for data editor

By default, the property name will be displayed as label text. You can change the label text by using the display attribute or using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

#### Using attribute

You can change the label text by setting the [Name](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.name?view=net-7.0) or [ShortName](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute.shortname?view=net-7.0) in display attribute.

{% tabs %}
{% highlight C# %}

[Display(Name = "FirstName")]
public string Name { get; set; }
    
{% endhighlight %}
{% endtabs %}

#### Using event

You can change the label text by using the [LabelText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LabelText) property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Name")
        {
            e.DataFormItem.LabelText = "FirstName";
        }
    }
}
{% endhighlight %}
{% endtabs %}

## Hide Label for an editor

By default, the label will be generated from the property name. You can hide the label text by using the DataFormDisplayAttribute or using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems]((https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems)) is true. 

#### Using attribute

You can hide the label text for editor by setting [ShowLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ShowLabel) as false in [DataformDisplayOptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html) attribute.

{% tabs %}
{% highlight C# %}

[DataFormDisplayOptions(ShowLabel = false)]
public string MiddleName { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using events

You can hide the label text for an editor by using the [ShowLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ShowLabel) property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "FirstName")
        {
            e.DataFormItem.ShowLabel = false;
        }
    }
}
{% endhighlight %}
{% endtabs %}

![Hide label name in .NET MAUI DataForm.](images/editor-settings/hide-label-name.png)

## Change the order for editor

You can change the row order of an editor by setting the [RowOrder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_RowOrder) property of [DataFormViewItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html) by using [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

You can change the order of item's within a row using [ItemsOrderInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ItemsOrderInRow) property, which is applicable only when [ColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ColumnCountProperty) is set to more than one. You can place an item within a row from 0 to [ColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ColumnCountProperty) - 1 position.

Refer [here](https://help.syncfusion.com/maui/dataform/layout#changing-order-of-the-editors) to know more about changing order of the editors.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.ColumnCount = 3;

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "FirstName")
        {
            e.DataFormItem.RowOrder = 1;
            e.DataFormItem.ItemsOrderInRow = 2;  
        }
    }
}
{% endhighlight %}
{% endtabs %}

## Add Label icon for the editor

You can set the label icon instead of label text by using [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "PhoneNumber")
        {
            e.DataFormItem.LeadingView = new Label { Text = "E", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
        }
    }
}

{% endhighlight %}
{% endtabs %}

![Leading label icon in .NET MAUI DataForm.](images/layout/leading-label-icon.png)

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/LabelIconSample)

## Change the Text style 

You can change the text styles of the label, editor, valid message, and error message by using the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is true.

N> If [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false, you can set the property directly by using the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Please refer [here](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) to learn more about creating data editors explicitly.

<table>
<tr>
<th>Text</th>
<th>Property</th>
</tr>
<tr>
<td>Label Text</td>
<td>LabelTextStyle</td>
</tr>
<tr>
<td>Editor Text</td>
<td>EditorTextStyle</td>
</tr>
<tr>
<td>Error Message Text</td>
<td>ErrorLabelTextStyle</td>
</tr>
<tr>
<td>Valid Message Text</td>
<td>ValidMessageLabelTextStyle</td>
</tr>
</table>

By using [DataFormTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html) class properties, you can change the text style .

DataFormTextStyle class properties:-
    1.FontSize
    2.FontFamily
    3.FontAttributes
    4.TextColor

#### Change Label Text Style

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormTextItem textItem)
    {
        e.DataFormItem.LabelTextStyle = new DataFormTextStyle() 
        {
            FontSize = 19, 
            TextColor = Colors.Pink, 
            FontAttributes = FontAttributes.Italic
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Label text style in .NET MAUI DataForm.](images/editor-settings/label-text-style.png)

#### Change Editor Text Style

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormTextItem textItem)
    {
        e.DataFormItem.EditorTextStyle = new DataFormTextStyle() 
        {
            FontSize = 19, 
            TextColor = Colors.Blue, 
            FontAttributes = FontAttributes.Italic
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Editor text style in .NET MAUI DataForm.](images/editor-settings/editor-text-style.png)

Please refer [here](https://help.syncfusion.com/maui/dataform/validation#validation-label-appearance-customization) to learn more about changing the [ErrorLabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ErrorLabelTextStyle) and [ValidMessageLabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ValidMessageLabelTextStyle)

## Editor view customization
You can customize the editor view by using the  `InitializeDataEditor` method of `DataFormItemManager`.

{% tabs %}
{% highlight c# %}

this.dataForm.ItemManager = new DataFormItemManagerEditorExt();

public class DataFormItemManagerEditorExt : DataFormItemManager
{
    if (editor is Entry entry)
    {
        entry.SelectionLength = 5;
        entry.TextTransform = TextTransform.Lowercase;
        entry.VerticalTextAlignment = TextAlignment.Center;
    }
}

{% endhighlight %}
{% endtabs %} 

## Explicitly create data editors

The data form auto generates the editors based on the data type, you can explicitly add the data editors by adding [SfDataForm.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) manually and you need to change the [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) property to false.

N> Use the [FieldName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_FieldName) property to bind the editor to the data object property.
[GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event will not be trigger when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight XAML %}
   
<ContentPage 
            . . . 
            xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
            x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
        <local:DataFormViewModel />
    </ContentPage.BindingContext>

        <ContentPage.Content>
        <dataForm:SfDataForm x:Name="dataForm" DataObject="{Binding ContactDetails}" AutoGenerateItems="false">
        <dataForm:SfDataForm.Items>
                <dataForm:DataFormTextItem FieldName="Name" />
                <dataForm:DataFormTextItem FieldName="Password" />
                <dataForm:DataFormGroupItem Name="Address">
                    <dataForm:DataFormGroupItem.Items>
                        <dataForm:DataFormMultilineItem FieldName="Street"/>
                        <dataForm:DataFormTextItem FieldName="State"/>
                        <dataForm:DataFormTextItem FieldName="ZipCode"/>
                        <dataForm:DataFormAutoCompleteItem FieldName="Country" ItemsSource = "{Binding CountryNames}"/>
                        </dataForm:DataFormGroupItem.Items>
                </dataForm:DataFormGroupItem>
            </dataForm:SfDataForm.Items>
        </dataForm:SfDataForm>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

SfDataForm dataForm = new SfDataForm();
DataFormViewModel contactInfoViewModel = new DataFormViewModel();
dataForm.DataObject = contactInfoViewModel.ContactDetails; 
ObservableCollection<DataFormViewItem> items = new ObservableCollection<DataFormViewItem>(); 
items.Add(new DataFormTextItem() { FieldName = "Name" }); 
items.Add(new DataFormPasswordItem() { FieldName = "Password" }); 
items.Add(new DataFormMultilineItem() { FieldName = "Address" }); 
DataFormGroupItem groupItem = new DataFormGroupItem();
groupItem.Name = "Address";
groupItem.Items.Add(new DataFormMultilineItem { FieldName = "Street" });
groupItem.Items.Add(new DataFormTextItem { FieldName = "State" });
groupItem.Items.Add(new DataFormTextItem { FieldName = "ZipCode" });
groupItem.Items.Add(new DataFormAutoCompleteItem { FieldName = "Country", ItemsSource = contactInfoViewModel.CountryNames }); 
items.Add(groupItem);

dataForm.AutoGenerateItems = false; 
dataForm.Items = items;
this.Content = dataForm;



{% endhighlight %}   
{% endtabs %} 

{% tabs %}
{% highlight c# tabtitle="DataFormViewModel.cs" %}

public class DataFormViewModel
{
    public DataFormViewModel()
    {
        this.ContactDetails = new ContactInfo();
        this.CountryNames = new List<string>
        {
             "United States",
            "United Kingdom",
            "France",
            "Belgium",
            "Germany"
        };
    }

    public ContactInfo ContactDetails { get; set; }

    public IList<string> CountryNames { get; set; }
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ContactInfo.cs" %}

public class ContactInfo
{
    public string Name { get; set; }

    public string Password { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Country { get; set; }

    public string Email { get; set; }
}

{% endhighlight %}
{% endtabs %}

#### Explicitly add data editor

You can dynamically add the data editor manually by using [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.Add(new DataFormTextItem() { FieldName = "State" });
this.dataForm.Items.Add(new DataFormTextItem() {FieldName = "Country" });

{% endhighlight %}
{% endtabs %}

#### Explicitly remove data editor
You can dynamically remove the data editor explicitly by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.RemoveAt(2);

{% endhighlight %}
{% endtabs %}

#### Explicitly clear data editors
You can dynamically clear all the item views from [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.Clear();

{% endhighlight %}
{% endtabs %}

#### Explicitly replace data editor
You can replace data editor with new editor by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when AutoGenerateItems is false.

{% tabs %}
{% highlight C# %}

DataFormTextItem textItem = new DataFormTextItem() { FieldName = "Age" };
this.dataForm.Items[2] = textItem;
    
DataFormDateItem dateItem = new DataFormDateItem() { FieldName ="Date Of Birth", RowOrder = 2, ItemsOrderInRow = 1, ColumnSpan = 3 });

this.dataForm.Items[3] = dateItem;
    
{% endhighlight %}
{% endtabs %}

#### Explicitly add group editor
You can dynamically add custom group editor by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

DataFormGroupItem dataFormGroupItem = new DataFormGroupItem();
dataFormGroupItem.Name = "Name";
dataFormGroupItem.Items = new ObservableCollection<DataFormItem>();

dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "First Name" });
dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Middle Name" });
dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Last Name" });

this.dataForm.Items.Add(dataFormGroupItem);
    
{% endhighlight %}
{% endtabs %}

#### Explicitly add custom editor

You can add custom editor manually by adding the custom view as an [EditorView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCustomItem.html#Syncfusion_Maui_DataForm_DataFormCustomItem_EditorView) of [DataFormCustomItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCustomItem.html). In this case, the editor view will not be generated based on field type and [RegisterEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_DataFormEditorType_).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<dataForm:SfDataForm x:Name="contactForm"
                    DataObject="{Binding ContactFormModel}" AutoGenerateItems = "False">
                
            <dataForm:SfDataForm.Items>
                <dataForm:DataFormCustomItem FieldName="ProfileImage" ShowLabel="False">
                    <dataForm:DataFormCustomItem.EditorView>
                        <Image Source="ContactImage.png"
                                   HeightRequest="80"/>
                        </dataForm:DataFormCustomItem.EditorView>
                </dataForm:DataFormCustomItem>
            </dataForm:SfDataForm.Items>
</dataForm:SfDataForm>

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/ExplicitDataFormItems)

## Explicitly create data editors from custom data dictionary

You can [explicitly](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) add the data editors from the custom data dictionary and also get the value from the dictionary and set the editors value to the dictionary by implementing `DataFormItemManager`, which has the methods to get and set values for the editors.

{% tabs %}
{% highlight C# %}

Dictionary<string, object> dictionary = new Dictionary<string, object>();
dictionary.Add("Name", "John");
dictionary.Add("Password", "1234");

ObservableCollection<DataFormViewItem> items = new ObservableCollection<DataFormViewItem>();
foreach (var key in dictionary.Keys)
{
    DataFormItem dataFormItem = null;
    if (key == "Name")
    {
        dataFormItem = new DataFormTextItem()
        {
            FieldName = key,
            LayoutType = DataFormLayoutType.TextInputLayout,
        };
    }
    else if (key == "Password")
    {
        dataFormItem = new DataFormPasswordItem()
        {
            FieldName = key,
            EditorTextStyle = new DataFormTextStyle { TextColor = Colors.Violet },
        };
    }

    if (dataFormItem != null)
    {
        items.Add(dataFormItem);
    }
}

dataForm.Items = items;
dataForm.AutoGenerateItems = false;
dataForm.ItemManager = new DataFormItemManagerExt(dictionary);

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="DataFormItemManagerExt" %}

public class DataFormItemManagerExt : DataFormItemManager
{
    Dictionary<string, object> dataFormDictionary;

    public DataFormItemManagerExt(Dictionary<string, object> dictionary)
    {
        dataFormDictionary = dictionary;
    }

    public override object GetValue(DataFormItem dataFormItem)
    {
        return dataFormDictionary[dataFormItem.FieldName];
    }

    public override void SetValue(DataFormItem dataFormItem, object value)
    {
        dataFormDictionary[dataFormItem.FieldName] = value;
    }
}

{% endhighlight %}
{% endtabs %}