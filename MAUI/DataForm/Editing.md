---
layout: post
title: Commit in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the commit support in Syncfusion .NET MAUI DataForm (SfDataForm) and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Editing in .NET MAUI DataForm (SfDataForm)

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
{{'[DataFormTextEditor]'| markdownify }}
</td>
<td>
The String type property and any other type apart from the following specified cases.
</td>
<td>
{{'[Entry]'| markdownify }}
</td>
</tr>
<tr>
<td>
MultilineText
</td>
<td>
{{'[DataFormMultiLineTextEditor]'| markdownify }}
</td>
<td>
The String type property with multi line text.
[DataType(DataType.MultilineText)] 
</td>
<td>
{{'[Editor]'| markdownify }}
</td>
</tr>
</tr>
<tr>
<td>
Password
</td>
<td>
{{'[DataFormPasswordEditor]'| markdownify }}
</td>
<td>
The String type property and property with 
[DataType(DataType.Password)] attribute.
</td>
<td>
{{'[Entry]'| markdownify }}
</td>
</tr>
<tr>
<td>
Checkbox
</td>
<td>
{{'[DataFormCheckBoxEditor]'| markdownify }}
</td>
<td>
Bool type property.
</td>
<td>
{{'[CheckBox]'| markdownify }}
</td>
</tr>
<tr>
<td>
Switch
</td>
<td>
{{'[DataFormSwitchEditor]'| markdownify }}
</td>
<td>
Bool type property.
</td>
<td>
{{'[Switch]'| markdownify }}
</td>
</tr>
<tr>
<td>
Date Picker
</td>
<td>
{{'[DataFormDatePickerEditor]'| markdownify }}
</td>
<td>
The DateTime type property and the property with [DataType(DataType.Date)] and [DataType(DataType.DateTime)] attributes.
</td>
<td>
{{'[DatePicker]| markdownify }}
</td>
</tr>
<tr>
<td>
Time Picker
</td>
<td>
{{'[DataFormTimePickerEditor]'| markdownify }}
</td>
<td>
The property with [DataType(DataType.Time)] attribute.
</td>
<td>
{{'[TimePicker]'| markdownify }}
</td>
</tr>
<tr>
<td>
Picker
</td>
<td>
{{'[DataFormPickerEditor]'| markdownify }}
</td>
<td>
Enum and List type property. 
[EnumDataTypeAttribute]
</td>
<td>
{{'[Picker]'| markdownify }}
</td>
</tr>
<tr>
<td>
ComboBox
</td>
<td>
{{'[DataFormComboBoxEditor]'| markdownify }}
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfComboBox]'| markdownify }}
</td>
</tr>
<tr>
<td>
AutoComplete
</td>
<td>
{{'[DataFormAutoCompleteEditor]'| markdownify }}
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfAutocomplete]'| markdownify }}
</td>
</tr>
<tr>
<td>
RadioGroup
</td>
<td>
{{'[DataFormRadioGroupEditor]'| markdownify }}
</td>
<td>
Enum and List type property. 
[EnumDataTypeAttribute]
</td>
<td>
{{'[RadioButton]'| markdownify }}
</td>
</tr>
</table>

## Changing editor for type

By default, the editors will be loaded based on the previous table. To change the editor for any type, use the [RegisterEditor] method and specify the type and editor.

{% tabs %}
{% highlight c# %}

this.DataForm.RegisterEditor(typeof(string), DataFormEditorType.MultilineText);

{% endhighlight %}
{% endtabs %}

Here, the `MultilineText` editor will be loaded for the string type instead of `Text` editor.

## Changing editor for property

To change the editor for any property, use the [RegisterEditor] method and specify the property name and editor.

{% tabs %}
{% highlight c# %}

this.DataForm.RegisterEditor("On"), DataFormEditorType.Switch);

{% endhighlight %}
{% endtabs %}

Here, the Switch editor will be loaded for the `On` property (bool type) instead of `CheckBox` editor.

## Creating new custom editor

Create the custom editor by overriding the [IDataFormEditorBase] class.

Property settings, commit, data validation can be handled by implementing the required methods. Here, the `Entry` is loaded for `Age` editor.

{% tabs %}
{% highlight c# %}

public class CustomNumericEditor : IDataFormEditor
{
  
    private SfDataForm dataForm;
    private DataFormCustomItem dataFormCustomItem;

    public CustomTextEditor(SfDataForm dataForm)
    {
        this.dataForm = dataForm;
    }

    public View CreateEditorView(DataFormItem dataFormItem)
    {
        Entry view = new Entry();
        view.Keyboard = Keyboard.Numeric;
        view.Placeholder = dataFormItem.PlaceholderText;
        DataFormTextStyle textStyle = dataForm.EditorTextStyle;
        view.TextColor = textStyle.TextColor;
        view.FontSize = textStyle.FontSize;
        view.FontFamily = textStyle.FontFamily;
        view.FontAttributes = textStyle.FontAttributes;
        view.TextChanged += this.OnViewTextChanged;
        this.dataFormCustomItem = (DataFormCustomItem)dataFormItem;
        this.dataFormCustomItem.EditorValue = string.Empty;

        return view;
    }

    private void OnViewTextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is not InputView numericEntry || dataFormCustomItem == null)
        {
            return;
        }

        string numericText = Regex.Replace(numericEntry.Text, "[^0-9]+", string.Empty);
        if (numericText != numericEntry.Text)
        {
            numericEntry.Text = numericText;
            return;
        }

        dataFormCustomItem.EditorValue = numericText;
        this.ValidateValue(dataFormCustomItem);
        this.CommitValue(dataFormCustomItem, numericEntry);
    }

    private void ValidateValue(DataFormItem dataFormItem)
    {
        dataForm.Validate(new List<string>() { dataFormItem.FieldName });
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

    public void UpdateReadyOnly(DataFormItem dataFormItem)
    {
    }
}

this.DataForm.RegisterEditor("Age", new CustomTextEditor(dataForm));

{% endhighlight %}
{% endtabs %}

The custom DataFormItem editor value should be committed manually by using [OnCommitValue] method of [IDataFormEditor] class on custom editor `Value` or `Focus changed` event which is used to update the custom editor value in respective property in [DataObject] based on dataform [commitMode] set.

## Commit mode

The [CommitMode] determines when the value should be committed to the data object.

The supported commit modes are as follows:

* LostFocus
* PropertyChanged
* Manual

### LostFocus
If the commit mode is LostFocus, the value is committed when the editor lost its focus. By default DataForm [CommitMode] is `LostFocus`.

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">
    <DataForm:SfDataForm
        x:Name="DataForm"
        CommitMode="LostFocus">
    </DataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.DataForm.CommitMode = DataFormCommitMode.LostFocus;
{% endhighlight %}
{% endtabs %}


### PropertyChanged
If the commit mode is PropertyChanged, the value will be committed immediately when it is changed.

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">
    <DataForm:SfDataForm
        x:Name="DataForm"
        CommitMode="PropertyChanged">
    </DataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.DataForm.CommitMode = DataFormCommitMode.PropertyChanged;
{% endhighlight %}
{% endtabs %}

### Manual
If the commit mode is Manual, the value should be committed manually by calling the [SfDataForm.Commit] method.

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">
    <DataForm:SfDataForm
        x:Name="DataForm"
        CommitMode="Manual">
    </DataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.DataForm.CommitMode = DataFormCommitMode.Manual;
{% endhighlight %}
{% endtabs %}

The following code commits the value of all the properties in the data object:

{% tabs %}
{% highlight c# %}
this.DataForm.Commit();
{% endhighlight %}
{% endtabs %}

N> On manual commit call manual validation will be called to validate the properties before commit

## Converter

To show the original value in different format or as different value, use the [DataFormValueConverter] attribute.

### Changing original value of the DataForm property value using converter

Here, the original value is multiplied by 10 and shown in editor. While committing, it is divided by 10 and stored in the data object.

{% tabs %}
{% highlight c# %}
public class ValueConverterExt : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {            
        var amount = double.Parse(value.ToString());
        return amount * 10;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var amount = double.Parse(value.ToString());
        return amount / 10;
    }
}

private double? amount = 1000;

[DataFormValueConverter(typeof(ValueConverterExt))]

public double? Amount { get; set; }

{% endhighlight %}
{% endtabs %}

## Disable editing
Editing DataForm can be disabled by setting the [IsReadOnly] property of the data form.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm" 
        IsReadOnly="True">
    </DataForm:SfDataForm>

</ContentPage>

{% endhighlight %}
{% highlight c# %}
this.DataForm.IsReadOnly = true;
{% endhighlight %}
{% endtabs %}

The editing behavior can also be changed by setting the [IsReadOnly] property of the [DataFormItem].

{% tabs %}
{% highlight c# %}
this.DataForm.GenerateDataFormItem += OnGenerateDataFormItem;

 private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Salary")
            e.DataFormItem.IsReadOnly = true;
    }
}
{% endhighlight %}
{% endtabs %}