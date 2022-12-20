---
layout: post
title: Migrate from Xamarin to .Net MAUI DataForm (SfDataForm) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms DataForm to Syncfusion .NET MAUI DataForm control.
platform: MAUI
control: SfDataForm
documentation: ug
---  

# Migrate from Xamarin.Forms SfDataForm to .NET MAUI SfDataForm 

To make the migration from the [Xamarin SfDataForm](https://www.syncfusion.com/xamarin-ui-controls/xamarin-dataform) to `.NET MAUI SfDataForm` easier, most of the APIs from the Xamarin SfDataForm were kept in the `.NET MAUI SfDataForm`. However, to maintain the consistency of API naming in the `.NET MAUI SfDataForm`, some of the APIs have been renamed. Please find the difference in the following topics.

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

To initialize the control, import the DataForm namespace and initialize SfDataForm as shown in the following code sample.

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
    xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm x:Name="dataForm"
                         DataObject="DataModel">
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.DataForm;
…

SfDataForm dataForm = new SfDataForm();
this.Content = dataForm;
this.dataForm.DataObject = new DataModel();

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[AutoCompleteMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.AutoCompleteMode.html)'| markdownify }}</td>
<td>DataFormTextSearchMode</td>
<td>Specifies the type of the text search mode in ComboBox and AutoComplete"/>.</td>
</tr>

<tr>
<td>{{'[AutoGeneratingDataFormItemEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.AutoGeneratingDataFormItemEventArgs.html)'| markdownify }}</td>
<td>GenerateDataFormItemEventArgs</td>
<td>Provides data for GenerateDataFormItem event.</td>
</tr>

<tr>
<td>{{'[CommitMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.CommitMode.html)'| markdownify }}</td>
<td>DataFormCommitMode</td>
<td>Defines the constants for CommitMode that specifies when the value entered by user should be saved to the data object.</td>
</tr>

<tr>
<td>{{'[ConverterAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ConverterAttribute.html)'| markdownify }}</td>
<td>DataFormValueConverterAttribute</td>
<td>Specifies the converter for the data field to convert the value before reading and saving in DataForm.</td>
</tr>

<tr>
<td>{{'[DataFormAutoCompleteItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormAutoCompleteItem.html)'| markdownify }}</td>
<td>DataFormAutoCompleteItem</td>
<td>Represents the class that encapsulates the layout and auto complete editor(SfAutoComplete) settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormCheckBoxItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormCheckBoxItem.html)'| markdownify }}</td>
<td>DataFormCheckBoxItem</td>
<td>Represents the class that encapsulates the layout and CheckBox editor settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormDateItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html)'| markdownify }}</td>
<td>DataFormDateItem</td>
<td>Represents the class that encapsulates the layout and date picker editor settings for a data field.</td>
</tr>

<tr>
<td>{{'[DataFormDropDownItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDropDownItem.html)'| markdownify }}</td>
<td>DataFormComboBoxItem</td>
<td>Represents the class that encapsulates the layout and ComboBox editor settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormGroupItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html)'| markdownify}}</td>
<td>DataFormGroupItem</td>
<td>Represents the class to encapsulates the group settings for group of data field's appearing in DataForm.</td>
</tr>

<tr>
<td>{{'[DataFormItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html)'| markdownify}}</td>
<td>DataFormItem</td>
<td>Represents the class that encapsulates the layout and editor setting for a data field appearing in DataForm.</td>
</tr>

<tr> 
<td>{{'[DataFormItemBase](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html)'| markdownify }}</td>
<td>DataFormViewItem</td>
<td>Represents the base class that encapsulates the layout, group and editor setting for a data fields appearing in DataForm.</td>

<tr>
<td>{{'[DataFormPickerItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html)'| markdownify }}</td>
<td>DataFormPickerItem</td>
<td>Represents the class that encapsulates the layout and picker editor settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormRadioGroupItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormRadioGroupItem.html)'| markdownify }}</td>
<td>DataFormRadioGroupItem</td>
<td>Represents the class that encapsulates the layout and RadioGroup editor settings for data field.</td>
</tr>

<tr>
<td>{{'[DataFormTextItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTextItem.html)'| markdownify }}</td>
<td>DataFormTextItem</td>
<td>Represents the class that encapsulates the layout and text editor setting for a data field.</td>
</tr>

<tr>
<td>{{'[DataFormTimeItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTimeItem.html)'| markdownify }}</td>
<td>DataFormTimeItem</td>
<td>Represents the class that encapsulates the layout and time picker editor setting for a data field.</td>
</tr>

<tr>
<td>{{'[DateRangeAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html)'| markdownify }}</td>
<td>DataFormDateRangeAttribute</td>
<td>Specifies the date range constraints for the value of a data field.</td>
</tr>

<tr>
<td>{{'[DisplayOptionsAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html)'| markdownify }}</td>
<td>DataFormDisplayOptionsAttribute</td>
<td>Provides a attribute that lets you specify the display settings for a data field.</td>
</tr>

<tr>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelPosition.html)'| markdownify }}</td>
<td>DataFormLabelPosition</td>
<td>Defines the constants for label position that specifies whether to layout the label at left or top of editor.</td>
</tr>

<tr>
<td>{{'[SfDataForm](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html)'| markdownify }}</td>
<td>SfDataForm</td>
<td>The DataForm control is used to manage data and develop various forms such as login, reservation, data entry and so on.</td>
</tr>

<tr>
<td>{{'[SourceProvider](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SourceProvider.html)'| markdownify }}</td>
<td>IDataFormSourceProvider</td>
<td>Represents the interface to provide method to get the source for picker type properties.</td>
</tr>

<tr>
<td>{{'[LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html)'| markdownify }}</td>
<td>DataFormTextStyle</td>
<td>Gets or sets properties which allows to customize the editor text style in the data form.</td>
</tr>

<tr>
<td>{{'[ValidatingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ValidatingEventArgs.html)'| markdownify }}</td>
<td>DataFormValidateFormEventArgs</td>
<td>Provides data for ValidateForm event.</td>
</tr>

<tr>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ValidationMode.html)'| markdownify }}</td>
<td>DataFormValidationMode</td>
<td>Defines the constants for ValidationMode that specifies when the user input should be validated for data object.</td>
</tr>

</table> 

## Properties

### SfDataForm

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
        <dataForm:SfDataForm x:Name="dataForm"/>
</ContentPage>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

using Syncfusion.Maui.DataForm;
...

SfDataForm dataForm = new SfDataForm();
this.Content = dataForm;
this.dataForm.DataObject = new DataModel();
this.dataForm.ColumnCount = 2;

{% endhighlight %}

{% highlight C# %}

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
<td>DataObject</td>
<td>Gets or sets the value which is used to set the editors to the data form.</td>
</tr>

<tr>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_IsReadOnly)'| markdownify }}</td>
<td>IsReadOnly</td>
<td>Gets or sets a value indicating whether editors are enabled for editing.</td>
</tr>

<tr>
<td>{{'[CommitMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_CommitMode)'| markdownify }}</td>
<td>CommitMode</td>
<td>Gets or sets the value that determines when to commit values that users enter in the data form’s editors to the bound data object.</td>
</tr>

<tr>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ValidationMode)'| markdownify }}</td>
<td>ValidationMode</td>
<td>Gets or sets a value that denotes when the user input should be validated based on IDataErrorInfo and ValidationAttributes.</td>
</tr>

<tr>
<td>{{'[Items](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Items)'| markdownify }}</td>
<td>Items</td>
<td>Gets or sets the value which used to set the DataFormViewItem collection in the SfDataForm.</td>
</tr>

<tr>
<td>{{'[ColumnCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ColumnCount)'| markdownify }}</td>
<td>ColumnCount</td>
<td>Gets or sets the value representing the number of editors to be arranged per row in the data form.</td>
</tr>

<tr>
<td>{{'[SourceProvider](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_SourceProvider)'| markdownify }}</td>
<td>ItemsSourceProvider</td>
<td>Gets or sets the value to get the source for picker type editors.</td>
</tr>

<tr>
<td>{{'[AutoGenerateItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_AutoGenerateItems)'| markdownify }}</td>
<td>AutoGenerateItems</td>
<td>Gets or sets a value indicating whether auto generate the DataFormItems in the data form.</td>
</tr>

<tr>
<td>Nil</td>
<td>EditorTextStyle</td>
<td>Gets or sets the style of editor text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>LabelTextStyle</td>
<td>Gets or sets the style of label text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>ErrorLabelTextStyle</td>
<td>Gets or sets the style of error label text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>ValidMessageLabelTextStyle</td>
<td>Gets or sets the style of validation label text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>DefaultLayoutSettings</td>
<td>Gets or sets the settings to customize default layout (Holds label and editor) settings.</td>
</tr>
</table>

### DataFormTextStyle

The properties of `Xamarin SfDataForm` [LabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html) are grouped to `DataFormTextStyle` in `.NET MAUI SfDataForm`

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
{% endtabs %}

{% tabs %}
{% highlight C# %}

using Syncfusion.Maui.DataForm;
…

SfDataForm dataForm = new SfDataForm();
this.Content = dataForm;
this.dataForm.DataObject = new DataModel();
this.dataForm.LabelTextStyle = new DataFormTextStyle()
{
    TextColor = Colors.Red,
    FontAttributes = FontAttributes.Italic,
    FontSize = 12,
};

{% endhighlight %}

{% highlight C# %}

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
<td>TextColor</td>
<td>Gets or sets the editor text color in the data form.</td>
</tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html#Syncfusion_XForms_DataForm_LabelStyle_FontSize)'| markdownify }}</td>
<td>FontSize</td>
<td>Gets or sets the double value that represents text font size in the data form.</td>
</tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html#Syncfusion_XForms_DataForm_LabelStyle_FontFamily)'| markdownify }}</td>
<td>FontFamily</td>
<td>Gets or sets the string, that represents text font family in the data form.</td>
</tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelStyle.html#Syncfusion_XForms_DataForm_LabelStyle_FontAttributes)'| markdownify }}</td>
<td>FontAttributes</td>
<td>Gets or sets the text font attributes in the data form.</td>
</tr>

</table>

### DataFormViewItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[RowSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html#Syncfusion_XForms_DataForm_DataFormItemBase_RowSpan)'| markdownify }}</td>
<td>RowSpan</td>
<td>Gets or sets the number of rows that this item spans which is used to increase item's height.</td>
</tr>

<tr>
<td>{{'[ColumnSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html#Syncfusion_XForms_DataForm_DataFormItemBase_ColumnSpan)'| markdownify }}</td>
<td>ColumnSpan</td>
<td>Gets or sets the number of column that this item spans to increase item's width.</td>
</tr>

<tr>
<td>{{'[IsVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItemBase.html#Syncfusion_XForms_DataForm_DataFormItemBase_IsVisible)'| markdownify }}</td>
<td>IsVisible</td>
<td>Gets or sets a value indicating whether the data form item layout (Holds editor and label) is visible or not.</td>
</tr>

<tr>
<td>Nil</td>
<td>RowOrder</td>
<td>Gets or sets the row order of the editor in the data form.</td>
</tr>

<tr>
<td>Nil</td>
<td>Padding</td>
<td>Gets or sets the space between the data form item’s editor and label.</td>
</tr>
</table>

### DataFormItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[GroupName](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_GroupName)'| markdownify }}</td>
<td>GroupName</td>
<td>Gets or sets the name of the group to the editor.</td>
</tr>

<tr>
<td>{{'[Name](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_Name)'| markdownify }}</td>
<td>FieldName</td>
<td>Gets or sets the editor's name in the data form.</td>
</tr>

<tr>
<td>{{'[LabelText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_LabelText)'| markdownify }}</td>
<td>LabelText</td>
<td>Gets or sets the editor’s label text.</td>
</tr>

<tr>
<td>{{'[PlaceHolderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_PlaceHolderText)'| markdownify }}</td>
<td>PlaceholderText</td>
<td>Gets or sets the prompt string displayed or the water mark to provide hint for users in the editors.</td>
</tr>

<tr>
<td>Nil</td>
<td>PlaceholderColor</td>
<td>Gets or sets the color of prompt string displayed or the water mark to provide hint for users in the editors.</td>
</tr>

<tr>
<td>{{'[ShowLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ShowLabel)'| markdownify }}</td>
<td>ShowLabel</td>
<td>Gets or sets a value indicating whether to show the label to the editor.</td>
</tr>

<tr>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_IsReadOnly)'| markdownify }}</td>
<td>IsReadOnly</td>
<td>Gets or sets a value indicating whether editor can be enabled or disabled.</td>
</tr>

<tr>
<td>{{'[EditorFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_EditorFontSize)'| markdownify }}</td>
<td>EditorTextStyle</td>
<td>Gets or sets the style of editor text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>{{'[ErrorMessageColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ErrorMessageColor)'| markdownify }}</td>
<td>ErrorLabelTextStyle</td>
<td>Gets or sets the style of error message label , that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>{{'[ValidationLabelStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ValidationLabelStyle)'| markdownify }}</td>
<td>ValidMessageLabelTextStyle</td>
<td>Gets or sets the style of valid message label, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>LabelTextStyle</td>
<td>Gets or sets the style of editor label text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>Background</td>
<td>Gets or sets the background to the data form item layout which is used to render label and editor for the data field.</td>
</tr>

<tr>
<td>Nil</td>
<td>DefaultLayoutSettings</td>
<td>Gets or sets the value of layout (holds label and editor) settings which is used to customize the label position, label width and editor width.</td>
</tr>

<tr>
<td>Nil</td>
<td>ItemsOrderInRow</td>
<td>Gets or sets the editor’s position in a row.</td>
</tr>

<tr>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_ImageSource)'| markdownify }}</td>
<td>LeadingLabelIcon</td>
<td>Gets or sets an image used as the editor’s label.</td>
</tr>


<tr>
<td>{{'[IsValid](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_IsValid)'| markdownify }}</td>
<td>IsValid</td>
<td>Gets a value indicating whether this DataFormItem is valid or not.</td>
</tr>

<tr>
<td>{{'[PropertyInfo](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormItem.html#Syncfusion_XForms_DataForm_DataFormItem_PropertyInfo)'| markdownify }}</td>
<td>PropertyInfo</td>
<td>Gets the property info of the data field.</td>
</tr>
</table>

### DataFormDefaultLayoutSettings

Following properties of `Xamarin SfDataForm` is moved to `DataFormDefaultLayoutSettings` class of `.NET MAUI SfDataForm`.

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_LabelPosition)'| markdownify }}</td>
<td>LabelPosition</td>
<td>Gets or sets the label position for DataFormItem to define the position of the label which associated with the editor.</td>
</tr>

<tr>
<td>{{'[LabelWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_LabelWidth)'| markdownify }}</td>
<td>LabelWidth</td>
<td>Gets or sets the width of the label.</td>
</tr>

<tr>
<td>{{'[EditorWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_EditorWidth)'| markdownify }}</td>
<td>EditorWidth</td>
<td>Gets or sets the width of the editor.</td>
</tr>
</table>

### DataFormGroupItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ColumnCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_ColumnCount)'| markdownify }}</td>
<td>ColumnCount</td>
<td>Gets or sets the value representing the number of editors to be arranged per row in the DataFormGroupItem.</td>
</tr>

<tr>
<td>{{'[DataFormItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_DataFormItems)'| markdownify }}</td>
<td>Items</td>
<td>Gets or sets the value which used to set the items grouped under the group.</td>
</tr>

<tr>
<td>{{'[IsExpanded](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_IsExpanded)'| markdownify }}</td>
<td>IsExpanded</td>
<td>Gets or sets a value indicating whether the group of editors is expanded or not.</td>
</tr>

<tr>
<td>{{'[AllowExpandCollapse](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_AllowExpandCollapse)'| markdownify }}</td>
<td>AllowExpandCollapse</td>
<td>Gets or sets a value indicating whether users can collapse and expand the group of editors.</td>
</tr>

<tr>
<td>Nil</td>
<td>HeaderTextStyle</td>
<td>Gets or sets the style of group header text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>Nil</td>
<td>HeaderBackground</td>
<td>Gets or sets the background color for the header of the editor group.</td>
</tr>

<tr>
<td>Nil</td>
<td>ItemsPadding</td>
<td>Gets or sets the distance between editors and the data form’s borders or group headers.</td>
</tr>

<tr>
<td>{{'[GroupName](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormGroupItem.html#Syncfusion_XForms_DataForm_DataFormGroupItem_GroupName)'| markdownify }}</td>
<td>Name</td>
<td>Gets or sets the name of the editor group.</td>
</tr>
</table>

### DataFormCheckBoxItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[CheckedColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormCheckBoxItem.html#Syncfusion_XForms_DataForm_DataFormCheckBoxItem_CheckedColor)'| markdownify }}</td>
<td>Color</td>
<td>Gets or sets the color of CheckBox editor.</td>
</tr>
</table>

### DataFormSwitchItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>Nil</td>
<td>OnColor</td>
<td>Gets or sets the color of the switch when it is in the on state.</td>
</tr>

<tr>
<td>Nil</td>
<td>ThumbColor</td>
<td>Gets or sets the thumb color of the switch editor.</td>
</tr>
</table>

### DataFormTextEditorItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[KeyBoard](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTextItemBase.html#Syncfusion_XForms_DataForm_DataFormTextItemBase_KeyBoard)'| markdownify }}</td>
<td>Keyboard</td>
<td>Gets or sets the type of keyboard used to display in the text, multiline and password editor.</td>
</tr>
</table>

### DataFormDateItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html#Syncfusion_XForms_DataForm_DataFormDateItem_Format)'| markdownify }}</td>
<td>Format</td>
<td>Gets or sets the time format for time picker.</td>
</tr>

<tr>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html#Syncfusion_XForms_DataForm_DataFormDateItem_MaximumDate)'| markdownify }}</td>
<td>MaximumDisplayDate</td>
<td>Gets or sets the maximun display date to restrict the visible dates of the date editor.</td>
</tr>

<tr>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormDateItem.html#Syncfusion_XForms_DataForm_DataFormDateItem_MinimumDate)'| markdownify }}</td>
<td>MinimumDisplayDate</td>
<td>Gets or sets the minimum display date to restrict the visible dates of the date editor.</td>
</tr>
</table>

### DataFormTimeItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormTimeItem.html#Syncfusion_XForms_DataForm_DataFormTimeItem_Format)'| markdownify }}</td>
<td>Format</td>
<td>Gets or sets the time format for Time Picker.</td>
</tr>
</table>

### DataFormListItem

The common properties of `Xamarin SfDataForm` list items (` DataFormPickerItem`, ` DataFormAutoCompleteItem`, ` DataFormDropDownItem` and ` DataFormRadioGroupItem` ) are added to [DataFormListItem] class in `.NET MAUI SfDataForm` 

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html#Syncfusion_XForms_DataForm_DataFormPickerItem_ItemsSource)'| markdownify }}</td>
<td>ItemsSource</td>
<td>Gets or sets the collection which will get displayed in picker where the user can select from available items.</td>
</tr>

<tr>
<td>{{'[DisplayMemberPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html#Syncfusion_XForms_DataForm_DataFormPickerItem_DisplayMemberPath)'| markdownify }}</td>
<td>DisplayMemberPath</td>
<td>Gets or sets a path to a value on the source object that will get displayed in picker.</td>
</tr>

<tr>
<td>{{'[ValueMemberPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormPickerItem.html#Syncfusion_XForms_DataForm_DataFormPickerItem_ValueMemberPath)'| markdownify }}</td>
<td>SelectedValuePath</td>
<td>Gets or sets a path to a value on the source object which will get saved to data field.</td>
</tr>
</table>

### DataFormComboBoxItem

<table>
<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>Nil</td>
<td>IsEditable</td>
<td>Gets or sets a value indicating whether the ComboBox can be edited.</td>
</tr>

<tr>
<td>Nil</td>
<td>TextSearchMode</td>
<td>Gets or sets the text search mode for ComboBox editor.</td>
</tr>
</table>

### DataFormAutoCompleteItem

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[AutoCompleteMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DataFormAutoCompleteItem.html#Syncfusion_XForms_DataForm_DataFormAutoCompleteItem_AutoCompleteMode)'| markdownify }}</td>
<td>TextSearchMode</td>
<td>Gets or sets the text search mode for auto complete editor.</td>
</tr>
</table>

### DataFormDisplayOptionsAttribute

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ColumnSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_ColumnSpan)'| markdownify }}</td>
<td>ColumnSpan</td>
<td>Gets or sets the number of column that this item spans to increase item's width.</td>
</tr>

<tr>
<td>{{'[RowSpan](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_RowSpan)'| markdownify }}</td>
<td>RowSpan</td>
<td>Gets or sets the number of rows that this item spans which is used to increase item's height.</td>
</tr>

<tr>
<td>Nil</td>
<td>RowOrder</td>
<td>Gets or sets the row order of the editor in the data form.</td>
</tr>

<tr>
<td>Nil</td>
<td>ItemsOrderInRow</td>
<td>Gets or sets the editor’s position in a row.</td>
</tr>

<tr>
<td>{{'[ShowLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_ShowLabel)'| markdownify }}</td>
<td>ShowLabel</td>
<td>Gets or sets a value indicating whether to show the label to the DataForm editor.</td>
</tr>

<tr>
<td>{{'[ValidMessage](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DisplayOptionsAttribute.html#Syncfusion_XForms_DataForm_DisplayOptionsAttribute_ValidMessage)'| markdownify }}</td>
<td>ValidMessage</td>
<td>Gets or sets a string which will get displayed when user enters valid value for the data field as success message.</td>
</tr>
</table>

### DataFormDateRangeAttribute

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[MinDay](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MinDay)'| markdownify }}</td>
<td>MinimumDate</td>
<td>Gets or sets the minimum date that users can assign to the date editor.</td>
</tr>

<tr>
<td>{{'[MaxDay](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.DateRangeAttribute.html#Syncfusion_XForms_DataForm_DateRangeAttribute_MaxDay)'| markdownify }}</td>
<td>MaximumDate</td>
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
<td>DisplayFormat</td>
<td>Gets or sets the attribute date display format of date editor.</td>
</tr>
</table>

### DataFormValueConverterAttribute 

<table>

<tr>
<th>Xamarin SfDataForm</th>
<th>.NET MAUI SfDataForm</th>
<th>Description</th></tr>

<tr>
<td>{{'[ConverterType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ConverterAttribute.html#Syncfusion_XForms_DataForm_ConverterAttribute_ConverterType)'| markdownify }}</td>
<td>ConverterType</td>
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
<td>DataFormCommitMode</td>
<td>Defines the constants for CommitMode that specifies when the value entered by user should be saved to the data object.</td>
</tr>

<tr>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.LabelPosition.html)'| markdownify }}</td>
<td>DataFormLabelPosition</td>
<td>Defines the constants for label position that specifies whether to layout the label at left or top of editor.</td>
</tr>

<tr>
<td>{{'[SuggestionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SuggestionMode.html)'| markdownify }}</td>
<td>DataFormTextSearchMode</td>
<td>Specifies the type of the text search mode in ComboBox and AutoComplete.</td>
</tr>

<tr>
<td>{{'[ValidationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.ValidationMode.html)'| markdownify }}</td>
<td>DataFormValidationMode</td>
<td>Defines the constants for ValidationMode that specifies when the user input should be validated for data object.</td>
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
<td>GenerateDataFormItem</td>
<td>Occurs during the generation of data form item in the data form when AutoGenerateItems is true.</td>
</tr>

<tr>
<td>{{'[Validating](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Validating)'| markdownify }}</td>
<td>ValidateProperty</td>
<td>Occurs when SfDataForm validates the user input.</td>
</tr>

<tr>
<td>{{'[ValidationCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_ValidationCompleted)'| markdownify }}</td>
<td>ValidateForm</td>
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
<td>RegisterEditor</td>
<td>Mthod to register DataFormEditor.</td>
</tr>

<tr>
<td>{{'[Validate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Validate().html)'| markdownify }}</td>
<td>Validate</td>
<td>Validates all the fields of DataFormViewItem</td>
</tr>

<tr>
<td>{{'[Commit](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_Commit().html)'| markdownify }}</td>
<td>Commit</td>
<td>Method to commit all properties underlying data object from the editor view.</td>
</tr>

<tr>
<td>{{'[UpdateEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_UpdateEditor_System_String_)'| markdownify }}</td>
<td>UpdateEditor</td>
<td>Updates the value of the specific property in corresponding editor.</td>
</tr>
</table>

## Upcoming Features

* Support for Floating label layout.
* Keyboard interaction support for MacCatalyst, Android, and iOS.
* Support for group header view customization.
* Support for DataFormViewItem's auto height.
* Support for programmatic scrolling to a specific editor.
* Support for dataform themeing.

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

