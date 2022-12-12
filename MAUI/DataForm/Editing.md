---
layout: post
title: Editing in Maui DataForm control | Syncfusion
description: Learn here all about Editing support in Syncfusion Maui DataForm (SfDataForm) control, its elements and more.
platform: Maui
control: SfDataForm
documentation: UG
---

# Editing in Maui DataForm (SfDataForm)

The data form supports several built-in editors. 

## Supported editors and associated DataFormItem

<table>
<tr>
<th>Editor name</th>
<th>Editor class</th>
<th>Data Type/Attribute</th>
<th>Input control loaded</th>
</tr>
<tr>
<td>
Text
</td>
<td>
[DataFormTextEditor]`Link`
</td>
<td>
The String type property and any other type apart from the following specified cases.
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
MultilineText
</td>
<td>
[DataFormMultiLineTextEditor]`Link`
</td>
<td>
The String type property with multi line text.
[DataType(DataType.MultilineText)] 
</td>
<td>
{{'[Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
Password
</td>
<td>
[DataFormPasswordEditor]`Link`
</td>
<td>
The String type property and property with 
[DataType(DataType.Password)] attribute.
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
Date
</td>
<td>
[DataFormDateEditor]
</td>
<td>
The DateTime type property and the property with [DataType(DataType.Date)] and [DataType(DataType.DateTime)] attributes.
</td>
<td>
{{'[DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
Time
</td>
<td>
[DataFormTimeEditor]
</td>
<td>
The property with [DataType(DataType.Time)] attribute.
</td>
<td>
{{'[TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows)'| markdownify }}
</td>
</tr>
<tr>
<td>
CheckBox
</td>
<td>
[DataFormCheckBoxEditor]
</td>
<td>
Bool type property.
</td>
<td>
{{'[CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
Switch
</td>
<td>
'[SwitchEditor]
</td>
<td>
Bool type property.
</td>
<td>
{{'[Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
Picker
</td>
<td>
'[DataFormPickerEditor]`Link`
</td>
<td>
Enum and List type property. 
[EnumDataTypeAttribute]
</td>
<td>
{{'[Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
ComboBox
</td>
<td>
[ComboBoxEditor]
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfComboBox](https://help.syncfusion.com/maui/combobox)'| markdownify }}
</td>
</tr>
<tr>
<td>
AutoComplete
</td>
<td>
{{'[DataFormAutoCompleteEditor]
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfAutoComplete](https://help.syncfusion.com/maui/autocomplete)'| markdownify }}
</td>
</tr>

<tr>
<td>
RadioGroup
</td>
<td>
[DataFormRadioGroupEditor]`Link`
</td>
<td>
Enum and List type property. 
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfRadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
</table>

## Changing editor for type

By default, the editors will be loaded based on the previous table. To change the editor for any type, use the [RegisterEditor]`Link` method and specify the type and editor.

{% tabs %}
{% highlight c# %}

    dataForm.RegisterEditor(typeof(string), DataFormEditorType.Password);

{% endhighlight %}
{% endtabs %}

Here, the `Password` editor will be loaded for the string type instead of text editor.

## Changing editor for property

To change the editor for any property, use the [RegisterEditor]`Link` method and specify the property name and editor.

{% tabs %}
{% highlight c# %}

    dataForm.RegisterEditor("Name", DataFormEditorType.Password);

{% endhighlight %}
{% endtabs %}

Here, the Password editor will be loaded for the `Name` property (String type) instead of `Text` editor.

## Creating new custom editor

Create the custom editor by inheriting the [IDataFormEditor] interface.

Property settings, commit, data validation can be handled by  the required methods. Here, the [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}  is loaded for `PhoneNumber` editor.

{% tabs %}
{% highlight c# %}

    public class NumericTextEditor : IDataFormEditor 
    { 
        public NumericEditor(Syncfusion.Maui.DataForm.SfDataForm dataForm)
        {
            this.dataForm = dataForm;
        }
        public View CreateEditorView(DataFormItem dataFormItem) 
        { 
            Entry inputView = new Entry();
            if (dataFormItem.FieldName == "CVV")
            {
                inputView.IsPassword = true;
                inputView.MaxLength = 3;
            } 
            inputView.Keyboard = Keyboard.Numeric;
            inputView.Placeholder = dataFormItem.PlaceholderText;
            DataFormTextStyle textStyle = dataForm.EditorTextStyle;
            inputView.TextColor = textStyle.TextColor;
            inputView.FontSize = textStyle.FontSize;
            inputView.FontFamily = textStyle.FontFamily;
            inputView.FontAttributes = textStyle.FontAttributes;
            inputView.TextChanged += this.OnViewTextChanged;
            this.dataFormCustomItem = (DataFormCustomItem)dataFormItem;
            this.dataFormCustomItem.EditorValue = string.Empty;

            return inputView;
        }
        
        public void CommitValue(DataFormItem dataFormItem, View view)
        {
            if (view is InputView numericText)
            {
                double numericValue;
                double.TryParse(numericText.Text, out numericValue);
                dataFormItem.SetValue(numericValue);
            }
        }
        
        private void ValidateValue(DataFormItem dataFormItem)
        {
            dataForm.Validate(new List<string>() { dataFormItem.FieldName });
        }

        private void OnViewTextChanged(object? sender, TextChangedEventArgs e)
        {
            if (sender is not InputView numericEntry || dataFormCustomItem == null)
            {
                return;
            }

            string? numericText = Regex.Replace(numericEntry.Text, "[^0-9]+", string.Empty);
            if (numericText != numericEntry.Text)
            {
                numericEntry.Text = numericText;
                return;
            }

            dataFormCustomItem.EditorValue = numericText;
            this.ValidateValue(dataFormCustomItem);
            this.CommitValue(dataFormCustomItem, numericEntry);
        }
        public void UpdateReadyOnly(DataFormItem dataFormItem)
        {
        }
    }
        
    } 

    dataForm.RegisterEditor("PinCode", new NumericTextEditor(dataForm));
    dataForm.RegisterEditor("Phone", new NumericTextEditor(dataForm));
    dataForm.ValidationMode = ValidationMode.LostFocus;

{% endhighlight %}
{% endtabs %}

You should manually commit the custom DataFormItem editor value by using [CommitValue]  method of [IDataFormEditor] interface on custom editor `Value` or `Focus changed` event which is used to update the custom editor value in respective property in [DataObject]`Link` based on dataform [commit mode]`Link` set. 

Also , you should manually validate the custom editor value in by using [ValidateValue] interface method of `IDataFormEditor` interface on custom editor `Value` or `Focus changed` event which is used to validate the custom editor value based on data form [validation mode]`Link` set . In the override method for OnValidateValue, you need to return [DataForm.Validate(List<string> PropertyName)] method in order to validate the particular data item.

`images/DataFormCustomEditor`