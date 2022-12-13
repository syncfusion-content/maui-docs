---
layout: post
title: Working with DataForm in Maui DataForm control | Syncfusion
description: Learn here all about Working with DataForm support in Syncfusion Maui DataForm (SfDataForm) control and more.
platform: Maui
control: SfDataForm
documentation: UG
---

# Working with DataForm in Maui DataForm (SfDataForm)

## Auto-generating DataFormItems for the data field

By default, the [DataFormItems]`Link` will be generated based on the property type. For example, the [DataFormTextItem]`Link` will be created for the `string` type property. 

The [DataFormItem]`Link` generation depends on the type and attribute defined for the property.
The following tables lists the several types of `DataFormItem` and its constraints for auto generation:

<table>
<tr>
<th>Generated DataFormItem Type</th>
<th>Editor</th>
<th>Data Type / Attribute</th>
</tr>
<tr>
<td>
[DataFormTextItem]
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Default DataFormItem generated for the String type and the properties with [DataType(DataType.Text)] attributes. 
</td>
</tr>
<tr>
<td>
[DataFormMultilineTextItem]
</td>
<td>
{{'[Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the String type and the properties with  [DataType(DataType.MultilineText)] attributes. 
</td>
</tr>
<tr>
<td>
[DataFormPasswordItem]
</td>
<td>
{{'[Entry]((https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the String type and the properties with [DataType(DataType.Password)] attributes. 
</td>
</tr>
<tr>
<td>
[DataFormDateItem]
</td>
<td>
{{'[DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for DateTime, DateTime , DateTimeOffset, DateOnly type and properties with [DataType(DataType.Date)] and [DataType(DataType.DateTime)] attributes. 

</td>
</tr>
<tr>
<td>
[DataFormTimeItem]
</td>
<td>
{{'[TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows)'| markdownify }}
</td>
<td>
Generated for TimeSpan, TimeOnly, DateTime and DateTimeOffset property with [DataType(DataType.Time)] attribute. 
</td>
</tr>
<tr>
<td>
[DataFormPickerItem]
</td>
<td>
{{'[Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for Enum type property and the property with [EnumDataTypeAttribute] attribute. 
</td>
</tr>
<tr>
<td>
[DataFormCheckBoxItem]
</td>
<td>
{{'[CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the Bool type property.
[BoolDataTypeAttribute]
</td>
</tr>
<tr>
<td>
[DataFormSwitchItem]
</td>
<td>
{{'[Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the Bool type property.
[BoolDataTypeAttribute]
</td>
</tr>
<tr>
<td>
[DataFormComboBoxItem]
</td>
<td>
{{'[SfComboBox](https://help.syncfusion.com/maui/combobox)'| markdownify }}
</td>
<td>
Generated for Enum type property and the property with [EnumDataTypeAttribute] attribute. 
</td>
</tr><tr>
<td>
[DataFormAutoCompleteItem]
</td>
<td>
{{'[SfAutoComplete](https://help.syncfusion.com/maui/autocomplete)'| markdownify }}
</td>
<td>
Generated for Enum type property and the property with [EnumDataTypeAttribute] attribute. 
</td>
</tr>
<tr>
<td>
[DataFormRadioGroupItem]
</td>
<td>
{{'[RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
<td>
Generated for the Enum type property.
</td>
</tr>
</table>

You can customize the property settings or cancel the generation of `DataFormItem` by handling the [GenerateDataFormItem] event.

## Customize auto generated fields

You can customize or cancel the generated `DataFormItem` by handling the [GenerateDataFormItem]`Link`event. This event occurs when the field is auto-generated for public and non-static property of the data object.

{% tabs %}
{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
             x:Class="GettingStarted.MainPage">
    <ContentPage.Content>
        <dataForm:SfDataForm x:Name="dataForm" GenerateDataFormItem="OnGenerateDataFormItem"/>
    </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {

    }
{% endhighlight %}
{% endtabs %}

[GenerateDataFormItemEventArgs]`Link` provides the information about the auto-generated.  [GenerateDataFormItemEventArgs.DataFormItem] `Link`  property returns the newly created `DataFormItem`.

## Cancel DataFormItem generation of the data field

You can cancel the specific [DataFormItem]`Link` adding to the data form by handling the `GenerateDataFormItem` event or by defining display attribute to avoid the particular data field being displayed.

### Using attributes

You can set [AutoGenerateField]`Link` to `false` for canceling the `DataFormItem` generation.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    private int id;
    [Display(AutoGenerateField = false)]
    public int ID { get; set; } 
    
{% endhighlight %}
{% endtabs %}

### Using event

In the following code, the `DataFormItem` generation for the `MiddleName` property is canceled by setting the `Cancel` property to true.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem.FieldName == "MiddleName")
            e.Cancel = true;
    }
{% endhighlight %}
{% endtabs %}

## Changing property settings

You can change the property of [DataFormItem]`Link` in the `GenerateDataFormItem` event.

Here, `Salary` data field is restricted from being edited in the data form.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

### Changing DataFormItem visibility

You can change the [DataFormItem]`Link`  visibility by using the [IsVisible]`Link` property in the `DataFormItem`.

Here, `LastName` data field will be hidden.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Setting watermark

You can display the watermark in the editor by defining the display attribute or using the`GenerateDataFormItem` event.

### Using attribute

You can show the watermark in the editor by setting the [Prompt]`Link` in display attribute.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    
    [Display(Prompt = "Enter middle name")]
    public string MiddleName { get; set; }
    
}
{% endhighlight %}
{% endtabs %}

### Using event

You can show the watermark in the editor by using the [PlaceholderText] `Link` property in [DataFormItem] `Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Setting watermark color

You can display the color for the watermark in the editor by using `GenerateDataFormItem` event.

You can change the color for the watermark in the editor by using the [PlaceholderColor] `Link` property in [DataFormItem] `Link` .

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "Description")
                e.DataFormItem.PlaceholderText = "Enter description";
                e.DataFormItem.PlaceholderColor = Colors.MistyRose;
        }
    }
{% endhighlight %}
{% endtabs %}

## Setting Padding

You can create a space around a label and editor by using [Padding]`Link` property in the `DataFormItem`.

Here, `FirstName` data field will be changed from the default position.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "LastName")
            {
                e.DataFormItem.Padding = new thickness(10,0,10,0);
            }
        }
    }
{% endhighlight %}
{% endtabs %}

## Changing label name

By default property name should be displayed as label. You can change the label text by using display attribute or using the `GenerateDataFormItem` event.

### Using attribute

You can change the label text by setting the [Name]`Link` in display attribute.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    
    [Display(Name = "FirstName")]
    public string Name { get; set; }
    

{% endhighlight %}
{% endtabs %}

### Using event

You can change the label text by using the [LabelText] `Link` property in [DataFormItem] `Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Add or remove Label text for editor

By default the label should be generated by property name. You can remove label text by using the DataFormDisplayAttribute or using the `GenerateDataFormItem` event.

### Using attribute

You can remove the label text for editor by setting [ShowLabel] as false in dataformdisplayOption attribute.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    
    [DataFormDisplayOptions(ShowLabel = false)]
    public string MiddleName { get; set; }
    
}
{% endhighlight %}
{% endtabs %}

### Using events

You can remove the label text for editor by using the [ShowLabel] `Link` property in [DataFormItem] `Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing layout settings

You can change the label width, label position and editor width. This is possible by using the `GenerateDataFormItem` event. In the event, change the layout by using the [DefaultLayoutSettings] property in the `DataFormItem`.

By default label position is left.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Setting Background colour

You can change the background colour for the label and editor by using `GenereateDataFormItem` event.

You can change the background colour for the label and editor by using the [Background] `Link` property in [DataFormItem] `Link` .

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

### Setting order for editor

By default the editor can be placed in the order of how you declare a propety in model class

You can change the order of item in a row only if the column count more than 1 [If the column count = n , you can place a item upto n-1 position].

You can change the order of item's within a row using [ItemsOrderInRow] `Link` property.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ColumnCount = 3;

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Setting Label icon

You can set label icon instead of using label text. Example:- You have a PhoneNumber editor, and the editor label is PhoneNumber. Here You can use a phone image for the label.

Right-click on the phone image and change the build action to "Embedded resource" and configure an image in.csproj. Directly add the name of the image by using the [LeadingLabelIcon] `Link` property in [DataFormItem] `Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

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

## Changing Text style 

You can change the text style for label text, editor text , valid message text and error message text 
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


by using DataFormTextStyle class properties, you can change the text style .

DataFormTextStyle class properties:-
    1.FontSize
    2.FontFamily
    3.FontAttributes
    4.TextColor
