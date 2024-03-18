---
layout: post
title: Migrate from Xamarin to .NET MAUI DataForm (SfDataForm) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms DataForm to Syncfusion .NET MAUI DataForm control.
platform: MAUI
control: SfDataForm
documentation: ug
---  

# Migrate from Xamarin.Forms SfDataForm to .NET MAUI SfDataForm 

To make the migration from the [Xamarin SfDataForm](https://www.syncfusion.com/xamarin-ui-controls/xamarin-dataform) to the [.NET MAUI SfDataForm](https://www.syncfusion.com/maui-controls/maui-dataform) easier, most of the APIs from the `Xamarin SfDataForm` were kept in the `.NET MAUI SfDataForm`. However, to maintain the consistency of API naming in the `.NET MAUI SfDataForm`, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th></tr>
<tr>
<td>Syncfusion.SfDataForm.XForms</td>
<td>Syncfusion.Maui.DataForm</td></tr>
</table>

## Initialize control

To initialize the control, import the DataForm namespace and initialize the `SfDataForm` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th></tr>
<tr>
<td>

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.XForms.DataForm;assembly=Syncfusion.SfDataForm.XForms">
    <dataForm:SfDataForm x:Name="dataForm"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.DataForm;
...

SfDataForm dataForm = new SfDataForm();
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

</td>
<td>

{% tabs %}
{% highlight XAML %}

<ContentPage
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm x:Name="dataForm"/>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.DataForm;
…

SfDataForm dataForm = new SfDataForm();
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[AutoCompleteMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.AutoCompleteMode.html)'| markdownify }}</td>
<td>{{'[DataFormTextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextSearchMode.html)'| markdownify }}</td>
<td>Specifies the type of the text search mode in ComboBox and AutoComplete.</td>
</tr>

<tr>
<td>{{'[AutoGeneratingDataFormItemEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.AutoGeneratingDataFormItemEventArgs.html)'| markdownify }}</td>
<td>{{'[GenerateDataFormItemEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.GenerateDataFormItemEventArgs.html)'| markdownify }}</td>
<td>Provides data for GenerateDataFormItem event.</td>
</tr>

<tr>
<td>{{'[CommitMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.CommitMode.html)'| markdownify }}</td>
<td>{{'[DataFormCommitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html)'| markdownify }}</td>
<td>Defines the constants for CommitMode that specify when the value entered by the user should be saved to the data object.</td>
</tr>

<tr>
<td>{{'[ConverterAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ConverterAttribute.html)'| markdownify }}</td>
<td>{{'[DataFormValueConverterAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValueConverterAttribute.html)'| markdownify }}</td>
<td>Specifies the converter for the data field to convert the value before reading and saving in DataForm.</td>
</tr>

<tr>
<td>{{'[DataFormAutoCompleteItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormAutoCompleteItem.html)'| markdownify }}</td>
<td>{{'[DataFormAutoCompleteItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormAutoCompleteItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and auto complete editor(SfAutoComplete) settings for the data field.
</td>
</tr>

<tr>
<td>{{'[DataFormCheckBoxItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormCheckBoxItem.html)'| markdownify }}</td>
<td>{{'[DataFormCheckBoxItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCheckBoxItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and CheckBox editor settings for the data field.</td>
</tr>

<tr>
<td>{{'[DataFormDateItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html)'| markdownify }}</td>
<td>{{'[DataFormDateItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and date picker editor settings for a data field.</td>
</tr>

<tr>
<td>{{'[DataFormDropDownItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDropDownItem.html)'| markdownify }}</td>
<td>{{'[DataFormComboBoxItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormComboBoxItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and ComboBox editor settings for the data field.</td>
</tr>

<tr>
<td>{{'[DataFormGroupItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html)'| markdownify}}</td>
<td>{{'[DataFormGroupItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html)'| markdownify }}</td>
<td>Represents the class to encapsulate the group settings for a group of data fields appearing in DataForm.</td>
</tr>

<tr>
<td>{{'[DataFormItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html)'| markdownify}}</td>
<td>{{'[DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and editor setting for a data field appearing in DataForm.</td>
</tr>

<tr> 
<td>{{'[DataFormItemBase](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html)'| markdownify }}</td>
<td>{{'[DataFormViewItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html)'| markdownify }}</td>
<td>Represents the base class that encapsulates the layout, group and editor setting for a data fields appearing in DataForm.</td>
</tr>

<tr>
<td>{{'[DataFormPickerItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html)'| markdownify }}</td>
<td>{{'[DataFormPickerItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormPickerItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and picker editor settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormRadioGroupItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormRadioGroupItem.html)'| markdownify }}</td>
<td>{{'[DataFormRadioGroupItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormRadioGroupItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and RadioGroup editor settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormTextItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTextItem.html)'| markdownify }}</td>
<td>{{'[DataFormTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and text editor setting for a data field.</td>
</tr>

<tr>
<td>{{'[DataFormNumericItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormNumericItem.html)'| markdownify }}</td>
<td>{{'[DataFormNumericItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html)'| markdownify }}</td>
<td>Represent the class that encapsulates the layout and numeric editor(SfNumericEntry) settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormMaskedEditTextItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html)'| markdownify }}</td>
<td>{{'[DataFormMaskedTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html)'| markdownify }}</td>
<td>Represent the class that encapsulates the layout and masked text editor(SfMaskedEntry) settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormTimeItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTimeItem.html)'| markdownify }}</td>
<td>{{'[DataFormTimeItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTimeItem.html)'| markdownify }}</td>
<td>Represents the class that encapsulates the layout and time picker editor setting for a data field.</td>
</tr>

<tr>
<td>{{'[DateRangeAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html)'| markdownify }}</td>
<td>{{'[DataFormDateRangeAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html)'| markdownify }}</td>
<td>Specifies the date range constraints for the value of a data field.</td>
</tr>

<tr>
<td>{{'[DisplayOptionsAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html)'| markdownify }}</td>
<td>{{'[DataFormDisplayOptionsAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html)'| markdownify }}</td>
<td>Provides a attribute that lets you specify the display settings for a data field.</td>
</tr>

<tr>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelPosition.html)'| markdownify }}</td>
<td>{{'[DataFormLabelPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormLabelPosition.html)'| markdownify }}</td>
<td>Defines the constants for label position that specifies whether to layout the label at left or top of editor.</td>
</tr>

<tr>
<td>{{'[SfDataForm](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html)'| markdownify }}</td>
<td>{{'[SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html)'| markdownify }}</td>
<td>The DataForm control is used to manage data and develop various forms such as login, reservation, data entry, and so on.</td>
</tr>

<tr>
<td>{{'[SourceProvider](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SourceProvider.html)'| markdownify }}</td>
<td>{{'[IDataFormSourceProvider](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.IDataFormSourceProvider.html)'| markdownify }}</td>
<td>Represents the interface to provide a method to get the source for the picker type properties.</td>
</tr>

<tr>
<td>{{'[LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html)'| markdownify }}</td>
<td>{{'[DataFormTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the editor text style in the data form.</td>
</tr>

<tr>
<td>{{'[ValidatingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ValidatingEventArgs.html)'| markdownify }}</td>
<td>{{'[DataFormValidateFormEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidateFormEventArgs.html)'| markdownify }}</td>
<td>Provides data for ValidateForm event.</td>
</tr>

<tr>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ValidationMode.html)'| markdownify }}</td>
<td>{{'[DataFormValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidationMode.html)'| markdownify }}</td>
<td>Defines the constants for the ValidationMode that specifies when the user input should be validated for the data object.</td>
</tr>

<tr>
<td>{{'[TextInputLayoutSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.TextInputLayoutSettings.html)'| markdownify }}</td>
<td>{{'[TextInputLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html)'| markdownify }}</td>
<td>Represents the class to settings for layout type to TextInputLayout.</td>
</tr>
</table> 

## Properties

#### SfDataForm

<table> 
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm x:Name="dataForm"
                        DataObject="{Binding DataModel}"
                        ColumnCount="2"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.DataForm;
...

SfDataForm dataForm = new SfDataForm();
dataForm.DataObject = new DataModel();
dataForm.ColumnCount = 2;
this.Content = dataForm;

{% endhighlight %}

{% highlight c# tabtitle="DataModel.cs" %}

public class DataModel
{
    public string Name { get; set; }

    public string Email { get; set; }

    public int PhoneNumber { get; set; }

    public string Address { get; set; }
}

{% endhighlight %}
{% endtabs %}

<tr>
<td>{{'[DataObject](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_DataObject)'| markdownify }}</td>
<td>{{'[DataObject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject)'| markdownify }}</td>
<td>Gets or sets the value which is used to set the editors to the data form.</td>
</tr>

<tr>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_IsReadOnly)'| markdownify }}</td>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_IsReadOnly)'| markdownify }}</td>
<td>Gets or sets a value indicating whether editors are enabled for editing.</td>
</tr>

<tr>
<td>{{'[CommitMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_CommitMode)'| markdownify }}</td>
<td>{{'[CommitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_CommitMode)'| markdownify }}</td>
<td>Gets or sets the value that determines when to commit values that users enter in the data form’s editors to the bound data object.</td>
</tr>

<tr>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ValidationMode)'| markdownify }}</td>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidationMode)'| markdownify }}</td>
<td>Gets or sets a value that denotes when the user input should be validated based on IDataErrorInfo and ValidationAttributes.</td>
</tr>

<tr>
<td>{{'[Items](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Items)'| markdownify }}</td>
<td>{{'[Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items)'| markdownify }}</td>
<td>Gets or sets the value which used to set the DataFormViewItem collection in the SfDataForm.</td>
</tr>

<tr>
<td>{{'[ColumnCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ColumnCount)'| markdownify }}</td>
<td>{{'[ColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ColumnCount)'| markdownify }}</td>
<td>Gets or sets the value representing the number of editors to be arranged per row in the data form.</td>
</tr>

<tr>
<td>{{'[SourceProvider](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_SourceProvider)'| markdownify }}</td>
<td>{{'[ItemsSourceProvider](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemsSourceProvider)'| markdownify }}</td>
<td>Gets or sets the value to get the source for the picker type editors.</td>
</tr>

<tr>
<td>{{'[AutoGenerateItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_AutoGenerateItems)'| markdownify }}</td>
<td>{{'[AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to auto-generate the DataFormItems in the data form.</td>
</tr>

<tr>
<td>{{'[ItemManager](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ItemManager)'| markdownify }}</td>
<td>{{'[ItemManager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemManager)'| markdownify }}</td>
<td>Get or set the item manager.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[EditorTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_EditorTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of the editor text used to customize the text color, font, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[LabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_LabelTextStyle)'| markdownify }}</td>
<td>Gets or sets the label text style used to customize the text color, font, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ErrorLabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ErrorLabelTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of error label text used to customize the text color, font, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ValidMessageLabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidMessageLabelTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of the validation label text used to customize the text color, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[DefaultLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DefaultLayoutSettings)'| markdownify }}</td>
<td>Gets or sets the settings to customize the default layout (Holds label and editor) settings.</td>
</tr>

<tr>
<td>{{'[LayoutOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_LayoutOptions)'| markdownify }}</td>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LayoutType)'| markdownify }}</td>
<td>Gets or sets the layout options for DataForm to define the layout type for the Dataform.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[TextInputLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_TextInputLayoutSettings)'| markdownify }}</td>
<td>Gets or sets the floating label layout settings for Dataform.</td>
</tr>
</table>

#### DataFormTextStyle

The properties of the `Xamarin SfDataForm` [LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html) are grouped to the [DataFormTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html) in `.NET MAUI SfDataForm`.

{% tabs %}
{% highlight XAML %}

<ContentPage
...
xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm
        x:Name="dataForm">
        <dataForm:SfDataForm.LabelTextStyle>
            <dataForm:DataFormTextStyle
                TextColor="Red"
                FontAttributes="Italic"
                FontSize="12">                
            </dataForm:DataFormTextStyle>
        </dataForm:SfDataForm.LabelTextStyle>
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.DataForm;
…

SfDataForm dataForm = new SfDataForm();
this.dataForm.DataObject = new DataModel();
this.dataForm.LabelTextStyle = new DataFormTextStyle()
{
    TextColor = Colors.Red,
    FontAttributes = FontAttributes.Italic,
    FontSize = 12,
};
this.Content = dataForm;

{% endhighlight %}

{% highlight c# tabtitle="DataModel.cs" %}

public class DataModel
{
    public string Name { get; set; }

    public string Email { get; set; }

    public int PhoneNumber { get; set; }

    public string Address { get; set; }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>Nil</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html#Syncfusion_Maui_DataForm_DataFormTextStyle_TextColor)'| markdownify }}</td>
<td>Gets or sets the editor text color in the data form.</td>
</tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html#Syncfusion_XForms_DataForm_LabelStyle_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html#Syncfusion_Maui_DataForm_DataFormTextStyle_FontSize)'| markdownify }}</td>
<td>Gets or sets the double value that represents the text font size in the data form.</td>
</tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html#Syncfusion_XForms_DataForm_LabelStyle_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html#Syncfusion_Maui_DataForm_DataFormTextStyle_FontFamily)'| markdownify }}</td>
<td>Gets or sets the string that represents the text font family in the data form.</td>
</tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html#Syncfusion_XForms_DataForm_LabelStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html#Syncfusion_Maui_DataForm_DataFormTextStyle_FontAttributes)'| markdownify }}</td>
<td>Gets or sets the text font attributes in the data form.</td>
</tr>

</table>

#### DataFormViewItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[RowSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html#Syncfusion_XForms_DataForm_DataFormItemBase_RowSpan)'| markdownify }}</td>
<td>{{'[RowSpan](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_RowSpan)'| markdownify }}</td>
<td>Gets or sets the number of rows this item spans, which increases the item's height.</td>
</tr>

<tr>
<td>{{'[ColumnSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html#Syncfusion_XForms_DataForm_DataFormItemBase_ColumnSpan)'| markdownify }}</td>
<td>{{'[ColumnSpan](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_ColumnSpan)'| markdownify }}</td>
<td>Gets or sets the number of columns this item spans to increase the item's width.</td>
</tr>

<tr>
<td>{{'[IsVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html#Syncfusion_XForms_DataForm_DataFormItemBase_IsVisible)'| markdownify }}</td>
<td>{{'[IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_IsVisible)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the data form item layout (Holds editor and label) is visible or not.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[RowOrder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_RowOrder)'| markdownify }}</td>
<td>Gets or sets the row order of the editor in the data form.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html#Syncfusion_Maui_DataForm_DataFormViewItem_Padding)'| markdownify }}</td>
<td>Gets or sets the space between the data form item’s editor and label.</td>
</tr>
</table>

#### DataFormItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[GroupName](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_GroupName)'| markdownify }}</td>
<td>{{'[GroupName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_GroupName)'| markdownify }}</td>
<td>Gets or sets the name of the group to the editor.</td>
</tr>

<tr>
<td>{{'[Name](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_Name)'| markdownify }}</td>
<td>{{'[FieldName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_FieldName)'| markdownify }}</td>
<td>Gets or sets the editor's name in the data form.</td>
</tr>

<tr>
<td>{{'[LabelText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_LabelText)'| markdownify }}</td>
<td>{{'[LabelText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LabelText)'| markdownify }}</td>
<td>Gets or sets the editor’s label text.</td>
</tr>

<tr>
<td>{{'[PlaceHolderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_PlaceHolderText)'| markdownify }}</td>
<td>{{'[PlaceholderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_PlaceholderText)'| markdownify }}</td>
<td>Gets or sets the prompt string displayed or the water mark to provide hint for users in the editors.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_PlaceholderColor)'| markdownify }}</td>
<td>Gets or sets the color of the prompt string displayed or the watermark to provide hints for users in the editors.</td>
</tr>

<tr>
<td>{{'[ShowLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ShowLabel)'| markdownify }}</td>
<td>{{'[ShowLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ShowLabel)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show the label to the editor.</td>
</tr>

<tr>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_IsReadOnly)'| markdownify }}</td>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_IsReadOnly)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the editor can be enabled or disabled.</td>
</tr>

<tr>
<td>{{'[EditorFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_EditorFontSize)'| markdownify }}</td>
<td>{{'[EditorTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_EditorTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of editor text used to customize the text color, font, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>{{'[ErrorMessageColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ErrorMessageColor)'| markdownify }}</td>
<td>{{'[ErrorLabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ErrorLabelTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of the error message label used to customize the text color, font, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>{{'[ValidationLabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ValidationLabelStyle)'| markdownify }}</td>
<td>{{'[ValidMessageLabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ValidMessageLabelTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of a valid message label used to customize the text color, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[LabelTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LabelTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of editor label text used to customize the text color, font size, font family, and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_Background)'| markdownify }}</td>
<td>Gets or sets the background to the data form item layout, which is used to render the label and editor for the data field.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[DefaultLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_DefaultLayoutSettings)'| markdownify }}</td>
<td>Gets or sets the value of the layout (holds label and editor) settings used to customize the label position, label width, and editor width.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ItemsOrderInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ItemsOrderInRow)'| markdownify }}</td>
<td>Gets or sets the editor’s position in a row.</td>
</tr>

<tr>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ImageSource)'| markdownify }}</td>
<td>{{'[LeadingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LeadingView)'| markdownify }}</td>
<td>Gets or sets an image used as the editor’s label.</td>
</tr>


<tr>
<td>{{'[IsValid](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_IsValid)'| markdownify }}</td>
<td>{{'[IsValid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_IsValid)'| markdownify }}</td>
<td>Gets a value indicating whether this DataFormItem is valid or not.</td>
</tr>

<tr>
<td>{{'[PropertyInfo](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_PropertyInfo)'| markdownify }}</td>
<td>{{'[PropertyInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_PropertyInfo)'| markdownify }}</td>
<td>Gets the property info of the data field.</td>
</tr>

<tr>
<td>{{'[LayoutOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_LayoutOptions)'| markdownify }}</td>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LayoutType)'| markdownify }}</td>
<td>Gets or sets the layout options for DataFormItem to define the layout type for the DataFormItem in dataform.</td>
</tr>

<tr>
<td>{{'[TextInputLayoutSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_TextInputLayoutSettings)'| markdownify }}</td>
<td>{{'[TextInputLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html)'| markdownify }}</td>
<td>Gets or sets the Text input Layout Settings for dataformitem to customize and configure the text input layout item in dataform.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ShowLeadingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ShowLeadingView)'| markdownify }}</td>
<td></td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[LeadingViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_LeadingViewPosition)'| markdownify }}</td>
<td>Gets or sets the value that determines whether to place the leading view within the floating label layout.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[TrailingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_TrailingView)'| markdownify }}</td>
<td>Gets or sets a value for a view to place after input view.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[TrailingViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_TrailingViewPosition)'| markdownify }}</td>
<td>Gets or sets a value that determines whether to place the trailing view within the layout.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ShowTrailingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_ShowTrailingView)'| markdownify }}</td>
<td>Gets or sets a value that indicates whether to display the trailing view.</td>
</tr>

<tr>
<td>{{'[Height](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_Height)'| markdownify }}</td>
<td>{{'[EditorHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_EditorHeight)'| markdownify}}</td>
<td>Gets or sets the height of the editor.</td>
</tr>
</table>

#### DataFormDefaultLayoutSettings

The following properties of the `Xamarin SfDataForm` is moved to the [DataFormDefaultLayoutSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDefaultLayoutSettings.html) class of `.NET MAUI SfDataForm`.

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_LabelPosition)'| markdownify }}</td>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDefaultLayoutSettings.html#Syncfusion_Maui_DataForm_DataFormDefaultLayoutSettings_LabelPosition)'| markdownify }}</td>
<td>Gets or sets the label position for DataFormItem to define the position of the label associated with the editor.</td>
</tr>

<tr>
<td>{{'[LabelWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_LabelWidth)'| markdownify }}</td>
<td>{{'[LabelWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDefaultLayoutSettings.html#Syncfusion_Maui_DataForm_DataFormDefaultLayoutSettings_LabelWidth)'| markdownify }}</td>
<td>Gets or sets the width of the label.</td>
</tr>

<tr>
<td>{{'[EditorWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_EditorWidth)'| markdownify }}</td>
<td>{{'[EditorWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDefaultLayoutSettings.html#Syncfusion_Maui_DataForm_DataFormDefaultLayoutSettings_EditorWidth)'| markdownify }}</td>
<td>Gets or sets the width of the editor.</td>
</tr>
</table>

#### TextInputLayoutSettings

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ContainerType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.TextInputLayoutSettings.html#Syncfusion_XForms_DataForm_TextInputLayoutSettings_ContainerType)'| markdownify }}</td>
<td>{{'[ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_ContainerType)'| markdownify }}</td>
<td>Gets or sets a value determining the container types for floating label layout.</td>
</tr>

<tr>
<td>{{'[OutlineCornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.TextInputLayoutSettings.html#Syncfusion_XForms_DataForm_TextInputLayoutSettings_OutlineCornerRadius)'| markdownify }}</td>
<td>{{'[OutlineCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_OutlineCornerRadius)'| markdownify }}</td>
<td>Gets or sets a value to customize the customize the corner radius of outline border in the floating label layout.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[EnableFloating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_EnableFloating)'| markdownify }}</td>
<td>Gets or sets a value that indicates whether to float the label when it is focused or unfocused.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[IsHintAlwaysFloated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_IsHintAlwaysFloated)'| markdownify }}</td>
<td>Gets or sets a value that indicates whether to fix the hint label always at the top even when the text is empty in the floating label layout.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[EnableHintAnimation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_EnableHintAnimation)'| markdownify }}</td>
<td>Gets or sets a value that indicates whether to enable animation for the hint text when the input view is focused or unfocused in the floating label layout.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[HelperTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_HelperTextStyle)'| markdownify }}</td>
<td>Gets or sets the style for helper label in the floating label layout.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_Stroke)'| markdownify }}</td>
<td>Gets or sets the border  color based on the container in the floating label layout. </td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[FocussedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_FocusedStrokeThickness)'| markdownify }}</td>
<td>Gets or sets as a value to customize the stroke width in a focused state in the floating label layout. It applies to the bottom line and outline border when setting the container type as filled and outlined.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[UnfocussedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_UnfocusedStrokeThickness)'| markdownify }}</td>
<td>Gets or sets as a value to customize the stroke width in an unfocused state in the floating label layout. It applies to the bottom line and outline border when setting the container type as filled and outlined.</td>
</tr>

<tr>
<td>{{'[ShowHelperText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.TextInputLayoutSettings.html#Syncfusion_XForms_DataForm_TextInputLayoutSettings_ShowHelperText)'| markdownify }}</td>
<td>{{'[ShowHelperText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_ShowHelperText)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to display the helper and error text. It determines the visibility of the helper text and error text.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[FocusedStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html#Syncfusion_Maui_DataForm_TextInputLayoutSettings_FocusedStroke)'| markdownify }}</td>
<td>Gets or sets the focused border color or focused baseline color based on the container type of the data form floating label layout type.</td>
</tr>
</table>

#### DataFormGroupItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ColumnCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_ColumnCount)'| markdownify }}</td>
<td>{{'[ColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_ColumnCount)'| markdownify }}</td>
<td>Gets or sets the value representing the number of editors to be arranged per row in the DataFormGroupItem.</td>
</tr>

<tr>
<td>{{'[DataFormItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_DataFormItems)'| markdownify }}</td>
<td>{{'[Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_Items)'| markdownify }}</td>
<td>Gets or sets the value which used to set the items grouped under the group.</td>
</tr>

<tr>
<td>{{'[IsExpanded](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_IsExpanded)'| markdownify }}</td>
<td>{{'[IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_IsExpanded)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the group of editors is expanded or not.</td>
</tr>

<tr>
<td>{{'[AllowExpandCollapse](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_AllowExpandCollapse)'| markdownify }}</td>
<td>{{'[AllowExpandCollapse](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_AllowExpandCollapse)'| markdownify }}</td>
<td>Gets or sets a value indicating whether users can collapse and expand the group of editors.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[HeaderTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_HeaderTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of group header text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[HeaderBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_HeaderBackground)'| markdownify }}</td>
<td>Gets or sets the background color for the header of the editor group.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ItemsPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_ItemsPadding)'| markdownify }}</td>
<td>Gets or sets the distance between editors and the data form’s borders or group headers.</td>
</tr>

<tr>
<td>{{'[GroupName](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_GroupName)'| markdownify }}</td>
<td>{{'[Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html#Syncfusion_Maui_DataForm_DataFormGroupItem_Name)'| markdownify }}</td>
<td>Gets or sets the name of the editor group.</td>
</tr>
</table>

#### DataFormPasswordItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[EnablePasswordVisibilityToggle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTextItem.html#Syncfusion_XForms_DataForm_DataFormTextItem_EnablePasswordVisibilityToggle)'| markdownify }}</td>
<td>{{'[EnablePasswordVisibilityToggle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormPasswordItem.html#Syncfusion_Maui_DataForm_DataFormPasswordItem_EnablePasswordVisibilityToggle)'| markdownify }}</td>
<td>Gets or sets a value that indicates whether to show the password visibility toggle.</td>
</tr>
</table>

#### DataFormCheckBoxItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[CheckedColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormCheckBoxItem.html#Syncfusion_XForms_DataForm_DataFormCheckBoxItem_CheckedColor)'| markdownify }}</td>
<td>{{'[Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCheckBoxItem.html#Syncfusion_Maui_DataForm_DataFormCheckBoxItem_Color)'| markdownify }}</td>
<td>Gets or sets the color of CheckBox editor.</td>
</tr>
</table>

#### DataFormSwitchItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>Nil</td>
<td>{{'[OnColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormSwitchItem.html#Syncfusion_Maui_DataForm_DataFormSwitchItem_OnColor)'| markdownify }}</td>
<td>Gets or sets the color of the switch when it is in the on state.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ThumbColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormSwitchItem.html#Syncfusion_Maui_DataForm_DataFormSwitchItem_ThumbColor)'| markdownify }}</td>
<td>Gets or sets the thumb color of the switch editor.</td>
</tr>
</table>

#### DataFormTextEditorItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[KeyBoard](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTextItemBase.html#Syncfusion_XForms_DataForm_DataFormTextItemBase_KeyBoard)'| markdownify }}</td>
<td>{{'[Keyboard](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextEditorItem.html#Syncfusion_Maui_DataForm_DataFormTextEditorItem_Keyboard)'| markdownify }}</td>
<td>Gets or sets the type of keyboard used to display the text, multiline, and password editor.</td>
</tr>
</table>

#### DataFormNumericItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[AllowNull](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormNumericItemBase.html#Syncfusion_XForms_DataForm_DataFormNumericItemBase_AllowNull)'| markdownify }}</td>
<td>{{'[AllowNull](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html#Syncfusion_Maui_DataForm_DataFormNumericItem_AllowNull)'| markdownify }}</td>
<td>Get or set a value indicating whether the DataFormNumericEditor allows a null value or not.</td>
</tr>

<tr>
<td>{{'[FormatString](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormNumericItemBase.html#Syncfusion_XForms_DataForm_DataFormNumericItemBase_FormatString)'| markdownify }}</td>
<td>{{'[CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html#Syncfusion_Maui_DataForm_DataFormNumericItem_CustomFormat)'| markdownify }}</td>
<td>Get or set the format used to specify the formatting of the editor value.</td>
</tr>

<tr>
<td>{{'[Maximum](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormNumericUpDownItem.html#Syncfusion_XForms_DataForm_DataFormNumericUpDownItem_Maximum)'| markdownify }}</td>
<td>{{'[Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html#Syncfusion_Maui_DataForm_DataFormNumericItem_Maximum)'| markdownify }}</td>
<td>Get or set the numerical maximum value for DataFormNumericEditor.</td>
</tr>

<tr>
<td>{{'[Minimum](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormNumericUpDownItem.html#Syncfusion_XForms_DataForm_DataFormNumericUpDownItem_Minimum)'| markdownify }}</td>
<td>{{'[Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html#Syncfusion_Maui_DataForm_DataFormNumericItem_Minimum)'| markdownify }}</td>
<td>Get or set the numerical minimum value for DataFormNumericEditor.</td>
</tr>

<tr>
<td>{{'[CultureInfo](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormNumericItemBase.html#Syncfusion_XForms_DataForm_DataFormNumericItemBase_CultureInfo)'| markdownify }}</td>
<td>{{'[Culture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html#Syncfusion_Maui_DataForm_DataFormNumericItem_Culture)'| markdownify }}</td>
<td>Get or set the culture for DataFormNumericEditor.</td>
</tr>

</table>

#### DataFormMaskedTextItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[CultureInfo](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html#Syncfusion_XForms_DataForm_DataFormMaskedEditTextItem_CultureInfo)'| markdownify }}</td>
<td>{{'[Culture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html#Syncfusion_Maui_DataForm_DataFormMaskedTextItem_Culture)'| markdownify }}</td>
<td>Get or set the culture for mask values based on the given culture.</td>
</tr>

<tr>
<td>{{'[Mask](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html#Syncfusion_XForms_DataForm_DataFormMaskedEditTextItem_Mask)'| markdownify }}</td>
<td>{{'[Mask](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html#Syncfusion_Maui_DataForm_DataFormMaskedTextItem_Mask)'| markdownify }}</td>
<td>Get or set the mask value which restricts the inputs provided in the control.</td>
</tr>

<tr>
<td>{{'[MaskType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html#Syncfusion_XForms_DataForm_DataFormMaskedEditTextItem_MaskType)'| markdownify }}</td>
<td>{{'[MaskType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html#Syncfusion_Maui_DataForm_DataFormMaskedTextItem_MaskType)'| markdownify }}</td>
<td>Get or set the mask type for the DataFormMaskedTextEditor.</td>
</tr>

<tr>
<td>{{'[PromptChar](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html#Syncfusion_XForms_DataForm_DataFormMaskedEditTextItem_PromptChar)'| markdownify }}</td>
<td>{{'[PromptChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html#Syncfusion_Maui_DataForm_DataFormMaskedTextItem_PromptChar)'| markdownify }}</td>
<td>Get or set a char which is used as a prompt char of DataFormMaskedTextEditor.</td>
</tr>

<tr>
<td>{{'[ValueMaskFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html#Syncfusion_XForms_DataForm_DataFormMaskedEditTextItem_ValueMaskFormat)'| markdownify }}</td>
<td>{{'[ValueMaskFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html#Syncfusion_Maui_DataForm_DataFormMaskedTextItem_ValueMaskFormat)'| markdownify }}</td>
<td>Get or set the format for the value.</td>
</tr>

</table>

#### DataFormDateItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html#Syncfusion_XForms_DataForm_DataFormDateItem_Format)'| markdownify }}</td>
<td>{{'[Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateItem.html#Syncfusion_Maui_DataForm_DataFormDateItem_Format)'| markdownify }}</td>
<td>Gets or sets the time format for time picker.</td>
</tr>

<tr>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html#Syncfusion_XForms_DataForm_DataFormDateItem_MaximumDate)'| markdownify }}</td>
<td>{{'[MaximumDisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateItem.html#Syncfusion_Maui_DataForm_DataFormDateItem_MaximumDisplayDate)'| markdownify }}</td>
<td>Gets or sets the maximum display date to restrict the visible dates of the date editor.</td>
</tr>

<tr>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html#Syncfusion_XForms_DataForm_DataFormDateItem_MinimumDate)'| markdownify }}</td>
<td>{{'[MinimumDisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateItem.html#Syncfusion_Maui_DataForm_DataFormDateItem_MinimumDisplayDate)'| markdownify }}</td>
<td>Gets or sets the minimum display date to restrict the visible dates of the date editor.</td>
</tr>
</table>

#### DataFormTimeItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTimeItem.html#Syncfusion_XForms_DataForm_DataFormTimeItem_Format)'| markdownify }}</td>
<td>{{'[Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTimeItem.html#Syncfusion_Maui_DataForm_DataFormTimeItem_Format)'| markdownify }}</td>
<td>Gets or sets the time format for the Time Picker.</td>
</tr>
</table>

#### DataFormListItem

The common properties of `Xamarin SfDataForm` list items ( [ DataFormPickerEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.Editors.DataFormPickerEditor.html),  [DataFormAutoCompleteEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.Editors.DataFormAutoCompleteEditor.html),  [DataFormDropDownEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.Editors.DataFormDropDownEditor.html) and  [DataFormRadioGroupEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.Editors.DataFormRadioGroupEditor.html)) are added to the [DataFormListItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormListItem.html) class in  the `.NET MAUI SfDataForm`.

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html#Syncfusion_XForms_DataForm_DataFormPickerItem_ItemsSource)'| markdownify }}</td>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormListItem.html#Syncfusion_Maui_DataForm_DataFormListItem_ItemsSource)'| markdownify }}</td>
<td>Gets or sets the collection, which will be displayed in the picker where the user can select from available items.</td>
</tr>

<tr>
<td>{{'[DisplayMemberPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html#Syncfusion_XForms_DataForm_DataFormPickerItem_DisplayMemberPath)'| markdownify }}</td>
<td>{{'[DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormListItem.html#Syncfusion_Maui_DataForm_DataFormListItem_DisplayMemberPath)'| markdownify }}</td>
<td>Gets or sets a path to a value on the source object that will get displayed in the picker.</td>
</tr>

<tr>
<td>{{'[ValueMemberPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html#Syncfusion_XForms_DataForm_DataFormPickerItem_ValueMemberPath)'| markdownify }}</td>
<td>{{'[SelectedValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormListItem.html#Syncfusion_Maui_DataForm_DataFormListItem_SelectedValuePath)'| markdownify }}</td>
<td>Gets or sets a path to a value on the source object which will get saved to the data field.</td>
</tr>
</table>

#### DataFormComboBoxItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>Nil</td>
<td>{{'[IsEditable](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormComboBoxItem.html#Syncfusion_Maui_DataForm_DataFormComboBoxItem_IsEditable)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the ComboBox can be edited.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormComboBoxItem.html#Syncfusion_Maui_DataForm_DataFormComboBoxItem_TextSearchMode)'| markdownify }}</td>
<td>Gets or sets the text search mode for the ComboBox editor.</td>
</tr>
</table>

#### DataFormAutoCompleteItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[AutoCompleteMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormAutoCompleteItem.html#Syncfusion_XForms_DataForm_DataFormAutoCompleteItem_AutoCompleteMode)'| markdownify }}</td>
<td>{{'[TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormAutoCompleteItem.html#Syncfusion_Maui_DataForm_DataFormAutoCompleteItem_TextSearchMode)'| markdownify }}</td>
<td>Gets or sets the text search mode for the auto complete editor.</td>
</tr>
</table>

#### DataFormDisplayOptionsAttribute

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ColumnSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_ColumnSpan)'| markdownify }}</td>
<td>{{'[ColumnSpan](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ColumnSpan)'| markdownify }}</td>
<td>Gets or sets the number of columns this item spans to increase the item's width.</td>
</tr>

<tr>
<td>{{'[RowSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_RowSpan)'| markdownify }}</td>
<td>{{'[RowSpan](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_RowSpan)'| markdownify }}</td>
<td>Gets or sets the number of rows this item spans, which is used to increase the item's height.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[RowOrder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_RowOrder)'| markdownify }}</td>
<td>Gets or sets the row order of the editor in the data form.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ItemsOrderInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ItemsOrderInRow)'| markdownify }}</td>
<td>Gets or sets the editor’s position in a row.</td>
</tr>

<tr>
<td>{{'[ShowLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_ShowLabel)'| markdownify }}</td>
<td>{{'[ShowLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ShowLabel)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show the label to the DataForm editor.</td>
</tr>

<tr>
<td>{{'[ValidMessage](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_ValidMessage)'| markdownify }}</td>
<td>{{'[ValidMessage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDisplayOptionsAttribute.html#Syncfusion_Maui_DataForm_DataFormDisplayOptionsAttribute_ValidMessage)'| markdownify }}</td>
<td>Gets or sets a string displayed when the user enters a valid value for the data field as a success message.</td>
</tr>
</table>

#### DataFormDateRangeAttribute

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[MinDay](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MinDay)'| markdownify }}</td>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_MinimumDate)'| markdownify }}</td>
<td>Gets or sets the minimum date that users can assign to the date editor.</td>
</tr>

<tr>
<td>{{'[MaxDay](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MaxDay)'| markdownify }}</td>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_MaximumDate)'| markdownify }}</td>
<td>Gets or sets the maximum date that users can assign to the date editor.</td>
</tr>

<tr>
<td>{{'[MinMonth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MinMonth)'| markdownify }}</td>
<td>Nil</td>
<td>Gets or sets the minimum month of a date.</td>
</tr>

<tr>
<td>{{'[MaxMonth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MaxMonth)'| markdownify }}</td>
<td>Nil</td>
<td>Gets or sets the maximum month of a date.</td>
</tr>

<tr>
<td>{{'[MinYear](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MinYear)'| markdownify }}</td>
<td>Nil</td>
<td>Gets or sets the minimum year of a date.</td>
</tr>

<tr>
<td>{{'[MaxYear](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MaxYear)'| markdownify }}</td>
<td>Nil</td>
<td>Gets or sets the maximum year of a date.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[DisplayFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateRangeAttribute.html#Syncfusion_Maui_DataForm_DataFormDateRangeAttribute_DisplayFormat)'| markdownify }}</td>
<td>Gets or sets the attribute date display format of the date editor.</td>
</tr>
</table>

#### DataFormValueConverterAttribute 

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ConverterType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ConverterAttribute.html#Syncfusion_XForms_DataForm_ConverterAttribute_ConverterType)'| markdownify }}</td>
<td>{{'[ConverterType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValueConverterAttribute.html#Syncfusion_Maui_DataForm_DataFormValueConverterAttribute_ConverterType)'| markdownify }}</td>
<td>Gets the Converter type.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[CommitMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.CommitMode.html)'| markdownify }}</td>
<td>{{'[DataFormCommitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html)'| markdownify }}</td>
<td>Defines the constants for the CommitMode that specify when the value entered by the user should be saved to the data object.</td>
</tr>

<tr>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelPosition.html)'| markdownify }}</td>
<td>{{'[DataFormLabelPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormLabelPosition.html)'| markdownify }}</td>
<td>Defines the constants for the label position that specifies whether to lay out the label at the left or top of the editor.</td>
</tr>

<tr>
<td>{{'[SuggestionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SuggestionMode.html)'| markdownify }}</td>
<td>{{'[DataFormTextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextSearchMode.html)'| markdownify }}</td>
<td>Specifies the type of the text search mode in ComboBox and AutoComplete.</td>
</tr>

<tr>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ValidationMode.html)'| markdownify }}</td>
<td>{{'[DataFormValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidationMode.html)'| markdownify }}</td>
<td>Defines the constants for the ValidationMode that specifies when the user input should be validated for the data object.</td>
</tr>

<tr>
<td>{{'[LayoutType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LayoutType.html)'| markdownify }}</td>
<td>{{'[DataFormLayoutType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormLayoutType.html)'| markdownify }}</td>
<td>Defines the constants for the ValidationMode that specifies when the user input should be validated for the data object.</td>
</tr>

<tr>
<td>{{'[ContainerType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ContainerType.html)'| markdownify }}</td>
<td>{{'[TextInputLayoutContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutContainerType.html)'| markdownify }}</td>
<td>Defines the constants for the ValidationMode that specifies when the user input should be validated for the data object.</td>
</tr>

<tr>
<td>{{'[ViewPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ViewPosition.html)'| markdownify }}</td>
<td>{{'[TextInputLayoutViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutViewPosition.html)'| markdownify }}</td>
<td>Defines the constants for the ValidationMode that specifies when the user input should be validated for the data object.</td>
</tr>

<tr>
<td>{{'[MaskType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.MaskedEdit.MaskType.html)'| markdownify }}</td>
<td>{{'[MaskedEditorMaskType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.MaskedEditorMaskType.html)'| markdownify }}</td>
<td>Defines the constants for DataFormMaskedTextItem MaskType</td>
</tr>

<tr>
<td>{{'[MaskFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.MaskedEdit.MaskFormat.html)'| markdownify }}</td>
<td>{{'[MaskedEditorMaskFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.MaskedEditorMaskFormat.html)'| markdownify }}</td>
<td>Defines the constants for DataFormMaskedTextItem ValueMaskFormat.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[MaskedEditorClearButtonVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.MaskedEditorClearButtonVisibility.html)'| markdownify }}</td>
<td>Defines the constants for ClearButtonVisibility that specifies when to show clear button.</td>
</tr>

<tr>
<td>{{'[SpinButtonAlignment ](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericUpDown.XForms.SpinButtonAlignment.html)'| markdownify }}</td>
<td>{{'[NumericEditorUpDownPlacementMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.NumericEditorUpDownPlacementMode.html)'| markdownify}}</td>
<td>Defines the constants for ClearButtonVisibility that specifies when to show clear button.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[AutoGeneratingDataFormItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html)'| markdownify }}</td>
<td>{{'[GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem)'| markdownify }}</td>
<td>Occurs during the generation of data form item in the data form when AutoGenerateItems is true.</td>
</tr>

<tr>
<td>{{'[Validating](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Validating)'| markdownify }}</td>
<td>{{'[ValidateProperty](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidateProperty)'| markdownify }}</td>
<td>Occurs when SfDataForm validates the user input.</td>
</tr>

<tr>
<td>{{'[ValidationCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ValidationCompleted)'| markdownify }}</td>
<td>{{'[ValidateForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidateForm)'| markdownify }}</td>
<td>Occurs when DataFormValidationMode is Manual to get the invalid DataFormItem’s details.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[RegisterEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_XForms_DataForm_Editors_DataFormEditorBase_)'| markdownify }}</td>
<td>{{'[RegisterEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_DataFormEditorType_)'| markdownify }}</td>
<td>Method to register DataFormEditor.</td>
</tr>

<tr>
<td>{{'[Validate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Validate().html)'| markdownify }}</td>
<td>{{'[Validate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Validate)'| markdownify }}</td>
<td>Validates all the fields of DataFormViewItem</td>
</tr>

<tr>
<td>{{'[Commit](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Commit().html)'| markdownify }}</td>
<td>{{'[Commit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Commit)'| markdownify }}</td>
<td>Method to commit all properties underlying data object from the editor view.</td>
</tr>

<tr>
<td>{{'[UpdateEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_UpdateEditor_System_String_)'| markdownify }}</td>
<td>{{'[UpdateEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_UpdateEditor_System_String_)'| markdownify }}</td>
<td>Updates the value of the specific property in corresponding editor.</td>
</tr>
</table>

## Upcoming Features

* Support for group header view customization.
* Support for programmatic scrolling to a specific editor.

## Known issues in .NET MAUI DataForm

* [MacCatalyst] - TimePicker popup is not working.
* [MacCatalyst, iOS] - Multiline editor placeholder text font size not changing based on editor font size.
* [MacCatalyst, iOS] – Date and Time picker text styles are not changing.
* [MacCatalyst, iOS] – Date picker minimum and maximum display dates are not working.
* [MacCatalyst, iOS] - Text style not applied to radio button.
* [Android, iOS, MacCatalyst] - In RTL mode, the multiline text editor text is not showing from the right.
* [Windows] - Picker editor text style is not changing.
* [iOS] - Maximum input length is not working in Text and Password editors.
* [Windows] - Time picker format not changing.
* [MacCatalyst, iOS] - RTL FlowDirection is not working for Date and Time pickers.
* [MacCatalyst, iOS] - In RTL FlowDirection, the ScrollView scroll bar shows at the right.
* [Android] - in RTL mode Radio button's content does not arrange from the right.
* `RTL` flow direction not working for ComboBox and AutoComplete editors.
* `IsReadOnly` not working for AutoComplete editor.
* Dark and light theme - There is no border and focused border stroke customization for the default editors (Text, password, multiline text, picker, DatePicker, and TimePicker).
* Dark and light theme - [iOS] There is no border and focused border stroke customization for the default editor (Text, password, picker, DatePicker, and TimePicker).
* Dark and light theme -[MacOS] There is no border and focused border stroke customization for the default editor (Text, password, and picker).
* Dark and light theme - MacOS The text color customization will not work for the DatePicker and TimePicker.