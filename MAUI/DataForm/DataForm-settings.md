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

By default, the `SfDataForm.Items` will be generated based on the property type. For example, the `DataFormTextItem` will be generated based on the property type in `DataObject`.
The `DataFormItem` generation depends on the type and attribute defined for the property.

You can customize the auto-generated editor, label, and group settings by using the `GenerateDataFormItem` event.

<table>
<tr>
<th>Generated DataFormItem Type</th>
<th>Editor</th>
<th>Data Type / Attribute</th>
</tr>
<tr>
<td>
DataFormTextItem
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
DataFormMultilineTextItem
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
DataFormPasswordItem
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
DataFormDateItem
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
DataFormTimeItem
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
DataFormCheckBoxItem
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
DataFormSwitchItem
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
DataFormComboBoxItem
</td>
<td>
{{'[SfComboBox](https://help.syncfusion.com/maui/combobox)'| markdownify }}
</td>
<td>
Generated for the enum type property. 
</td>
</tr><tr>
<td>
DataFormAutoCompleteItem
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
DataFormPickerItem
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
DataFormRadioGroupItem
</td>
<td>
{{'[RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the enum type property.
</td>
</tr>
</table>

You can customize the property settings or cancel the generation of `DataFormItem` by handling the `GenerateDataFormItem` event.

## Cancel the auto-generation data editor

You can cancel the specific data editor by handling the `GenerateDataFormItem` event or by defining display attribute to avoid the particular data field being displayed.

#### Using attributes

You can set `AutoGenerateField` to `false` for canceling the data editor generation.

{% tabs %}
{% highlight C# %}

[Display(AutoGenerateField = false)]
public int ID { get; set; } 
    
{% endhighlight %}
{% endtabs %}

#### Using event

In the following code, the data editor generation for the `MiddleName` property is canceled by setting the `Cancel` property to true of the `DataFormItem`.

{% tabs %}
{% highlight C# %}

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

The `GenerateDataFormItem` event will be raised only when `AutoGenerateItems` is set to true.

For `AutoGenerateItems` false, you can use settings properties directly by using the `DataFormItem`. Please refer here to learn more about creating data editors explicitly.

## Change the auto-generated editor settings

You can change the data editor settings by using the property of `DataFormItem` in the `GenerateDataFormItem` event when `AutoGenerateItems` is true.

Here, `Salary` data field is restricted from being edited in the data form.

{% tabs %}
{% highlight C# %}

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

#### Change the autogenerated editor visibility

You can change the specific editor visibility by using the `IsVisible` property in the `DataFormItem`.

Here, the `LastName` data field will be hidden.

{% tabs %}
{% highlight C# %}

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

## Setting watermark for auto-generated editor

You can display the watermark in the editor by defining the display attribute or using the `GenerateDataFormItem` event when `AutoGenerateItems` is true.

#### Using attribute

You can show the watermark in the editor by setting the `Prompt` in display attribute.

{% tabs %}
{% highlight C# %}

[Display(Prompt = "Enter middle name")]
public string MiddleName { get; set; }
    
{% endhighlight %}
{% endtabs %}

#### Using event

You can show the watermark in the editor by using the `PlaceholderText` property in `DataFormItem`.

{% tabs %}
{% highlight C# %}

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

## Changing watermark color for auto-generated editor

You can display the color for the watermark in the editor by using `GenerateDataFormItem` event when `AutoGenerateItems` is true.

You can change the color for the watermark in the editor by using the `PlaceholderColor` property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

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

## Change padding for auto-generated editor

You can create a space around a label and editor by using the `Padding` property in the DataFormItem by using the `GenerateDataFormItem` event when `AutoGenerateItems` is true.

Here, the `FirstName` data field will be changed from the default position.

{% tabs %}
{% highlight C# %}

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

## Change the label name for auto-generated editor

By default, the property name will be displayed as label text. You can change the label text by using the display attribute or using the `GenerateDataFormItem` event when `AutoGenerateItems` is true.

#### Using attribute

You can change the label text by setting the `Name` or `ShortName` in display attribute.

{% tabs %}
{% highlight C# %}

[Display(Name = "FirstName")]
public string Name { get; set; }
    
{% endhighlight %}
{% endtabs %}

#### Using event

You can change the label text by using the `LabelText` property in `DataFormItem` .

{% tabs %}
{% highlight C# %}

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

By default, the label will be generated from the property name. You can hide the label text by using the DataFormDisplayAttribute or using the `GenerateDataFormItem` event when `AutoGenerateItems` is true.

#### Using attribute

You can hide the label text for editor by setting `ShowLabel` as false in `DataformDisplayOptions` attribute.

{% tabs %}
{% highlight C# %}

[DataFormDisplayOptions(ShowLabel = false)]
public string MiddleName { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using events

You can hide the label text for an editor by using the `ShowLabel` property in `DataFormItem`.

{% tabs %}
{% highlight C# %}

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

## Change editor layout settings

You can change the label width, label position, and editor width. This is possible by using the `GenerateDataFormItem` event when `AutoGenerateItems` is true. In the event, change the layout settings by using the `DefaultLayoutSettings` property in the `DataFormItem`.

For `AutoGenerate` false, you can use property directly by using the `DataFormItem` - add refrence link for explict create data editor.

By default label position is left.

{% tabs %}
{% highlight C# %}

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

## Change the Background for editor layout

You can change the background color for the label and editor by using `GenereateDataFormItem` event when `AutoGenerateItems` is true.

{% tabs %}
{% highlight C# %}

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

## Change the order for editor

You can change the row order of an editor by setting the `RowOrder` property of DataFormViewItem by using `GenerateDataFormItem` event when `AutoGenerateItems` is true.

You can change the order of item's within a row using `ItemsOrderInRow` property, which is applicable only when `ColumnCount` is set to more than one. You can place an item within a row from 0 to `ColumnCount` - 1 position.

{% tabs %}
{% highlight C# %}

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

You can set the label icon instead of label text by using `GenereateDataFormItem` event when `AutoGenerateItems` is true.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "PhoneNumer")
        {
            e.DataFormItem.LeadingLabelIcon = new FontImageSource() 
            { 
                Glyph = "K", 
                Color = Colors.Black, 
                FontFamily = "DataFormIcons", 
                Size=18 
            };
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Change the Text style 

You can change the text styles of the label, editor, valid message, and error message by using the `GenereateDataFormItem` event when `AutoGenerateItems` is true.

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

By using `DataFormTextStyle` class properties, you can change the text style .

DataFormTextStyle class properties:-
    1.FontSize
    2.FontFamily
    3.FontAttributes
    4.TextColor

#### Change Label Text Style

{% tabs %}
{% highlight C# %}

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

#### Change Editor Text Style

{% tabs %}
{% highlight C# %}

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

## Manually create DataForm Items

The data form autogenerates the editors based on the data type, you can explicitly add the data editors by adding `SfDataForm.Items` manually and you need to change the `AutoGenerateItems` property to false.

N> Use the FieldName property to bind the editor to the data object property.
`GenerateDataFormItem` event will not be trigger when `AutoGenerateItems` is false.
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
{% highlight C# %}

DataFormViewModel contactInfoViewModel = new DataFormViewModel();
this.dataForm.DataObject = contactInfoViewModel.ContactDetails; 
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

this.dataForm.AutoGenerateItems = false; 
this.dataForm.Items = items;

{% endhighlight %}
{% highlight C# %}

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
{% highlight C# %}

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
{% tabs %}

## Dynamically add data editor

You can dynamically add the data editor manually by using `Items` property of `SfDataForm`.
{% tabs %}
{% highlight C# %}

this.dataForm.Items.Add(new DataFormTextItem() { FieldName = "State" });
this.dataForm.Items.Add(new DataFormTextItem() {FieldName = "Country" });

{% endhighlight %}
{% endtabs %}

## Dynamically remove manually added dataform items
You can dynamically remove the data editor explicitly by using the `Items` property of `SfDataForm`.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.RemoveAt(2);

{% endhighlight %}
{% endtabs %}

## Dynamically clear manually added dataform items
You can dynamically clear all the item views from `SfDataForm`.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.Clear();

{% endhighlight %}
{% endtabs %}

## Dynamically reset manual dataform items
You can replace data editor with new editor by using the `Items` property of `SfDataForm` when AutoGenerateItems is false.

{% tabs %}
{% highlight C# %}

DataFormTextItem textItem = new DataFormTextItem() { FieldName = "Age" };
this.dataForm.Items[2] = textItem;
    
DataFormDateItem dateItem = new DataFormDateItem() { FieldName ="Date Of Birth", RowOrder = 2, ItemsOrderInRow = 1, ColumnSpan = 3 });

this.dataForm.Items[3] = dateItem;
    
{% endhighlight %}
{% endtabs %}

## Dynamically add Dataform group items
You can dynamically add custom group editor by using the `Items` property of `SfDataForm`.

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

#### Adding custom editor view using Manual DataFormItem

You can add custom editor manually by adding the custom view as an `EditorView` of `DataFormCustomItem`. In this case, the editor view will not be generated based on field type and `RegistorEditor`.

{% tabs %}
{% highlight XAML %}

<dataForm:SfDataForm x:Name="contactForm"
                                         DataObject="{Binding ContactFormModel}">
                
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