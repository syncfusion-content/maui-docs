---
layout: post
title: Editors in Maui DataForm control | Syncfusion
description: Learn here all about Editors support in Syncfusion Maui DataForm (SfDataForm) control, its elements and more.
platform: Maui
control: SfDataForm
documentation: UG
---

# Editors in Maui DataForm (SfDataForm)

The data form supports several built-in editors as follows:

<table>
<tr>
<th>Editor name</th>
<th>Editor class</th>
<th>Supported Data Type/Attribute</th>
<th>Input control loaded</th>
</tr>
<tr>
<td>
Text
</td>
<td>
{{'[DataFormTextEditor
</td>
<td>
The String type property and any other type apart from the below specified cases.
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
DataFormMultiLineTextEditor
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
DataFormPasswordEditor
</td>
<td>
The String type property and property with 
[DataType(DataType.Password)] attribute.
</td>
<td>
{{'[Entry]((https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
Date
</td>
<td>
DataFormDateEditor
</td>
<td>
DateTime, DateOnly and DateTimeOffset type property and the property with [DataType(DataType.Date)] and [DataType(DataType.DateTime)] attributes.
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
DataFormTimeEditor
</td>
<td>
The DateTime, TimeSpan, TimeOnly and DateTimeOffset  property with [DataType(DataType.Time)] attribute.
</td>
<td>
{{'[TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows)'| markdownify }}
</td>
</tr>
<tr>
<td>
Checkbox
</td>
<td>
DataFormCheckBoxEditor
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
DataFormSwitchEditor
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
DataFormPickerEditor
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
DataFormComboBoxEditor
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
RadioGroup
</td>
<td>
DataFormRadioGroupEditor
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
AutoComplete
</td>
<td>
DataFormAutoCompleteEditor
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfAutoComplete](https://help.syncfusion.com/maui/autocomplete)'| markdownify }}

</td>
</tr>
</table>

## Text editor

In the text editor, the [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0) is loaded.

Text editor have Keyboard type change by using `Keyboard` property and you can set maximum allowed length of input by using `MaxLength` property.

## Multiline Text editor

In the `MultilineText` editor, the [Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-7.0) is loaded.

And `MultilineText` editor height will auto expand/reduce based on the line wraps in editor , which allowing text to be readable without scrolling the editor.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [DataType(DataType.MultilineText)]
    public String Address { get; set; }

{% endhighlight %}
{% endtabs %}

`Image`

## Password editor

In the password editor, the [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0) is loaded.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [Display(ShortName = "Transaction password", Prompt = "Enter password")]
    [DataType(DataType.Password)]
    public string Password
    {
        get { return this.password; }
        set{ this.password = value; }
    }

{% endhighlight %}
{% endtabs %}

`Image`

## Date editor

In the date editor, the [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0) will be loaded.

In [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0), the default date value is current date displayed by default. You can also adding nullable `DateTime` data type for the date picker property in data form, which allows you to set the current date and display current date in date editor. 

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [DataType(DataType.Date)]
    [Display(Name ="Birth Date")]
    public DateTime? BirthDate { get; set; }

{% endhighlight %}
{% endtabs %}

`Image`

### Customizing format in date editor

In the [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0), short date will be shown by default. You can change the applied format by setting the [Format]`Link`property in [DataFormDateItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {   

        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Date" && e.DataFormItem is DataFormDateItem dateItem)
        {
            dateItem.Format = "dd, MM, yyyy";
        }
    }
{% endhighlight %}
{% endtabs %}

`Image`

### Setting MaximumDate and MinimumDate in date editor

You can customize the maximum and minimum allowable dates in the [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0) by setting [MaximumDate]`Link` and [MinimumDate]`Link` in the [DataFormDateItem]`Link` respectively.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Date" && e.DataFormItem is DataFormDateItem dateItem)
        {
            dateItem.MinimumDate = new DateTime(2017, 5, 5);
            dateItem.MaximumDate = new DateTime(2017, 9, 2);
        }
    }

{% endhighlight %}
{% endtabs %}

`DateMAximumImages`

## Time editor

In the time editor, the [TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows) will be loaded.


In [TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows), the default time value (12:00 AM) is displayed by default. You can also adding nullable `TimeSpan` data type for the time picker property in data form, which allows you to set default time and display the (12:00 AM) in time editor. 

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [DataType(DataType.Time)]
    [Display(Name = "Birth Time")]
    public TimeSpan? BirthTime { get; set; }

{% endhighlight %}
{% endtabs %}

`images`

**Customizing format in time editor**

In the [TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows), short time will be shown by default. You can change the applied format by setting the [Format]`Link`property in [DataFormTimeItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "BirthTime" && e.DataFormItem is DataFormTimeItem timeItem)
        {
            timeItem.Format = "HH:mm";
        }
    } 

{% endhighlight %}
{% endtabs %}

`Image`

## CheckBox editor

In [CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0) editor, the [CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0) control is loaded. By default, for `bool` data type property, the [CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0) editor will be loaded in data form.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [Display(Name = "Is Billable")]
    public bool IsBillable { get; set; } = true;

    [Display(Name = "Registered Member")]
    public bool RegisteredMember { get; set; }

{% endhighlight %}
{% endtabs %}

`Image`

**Visual states of CheckBox**

CheckBox support two visual states.
  - Checked
  - UnChecked

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [Display(Name = "Is Billable")]
    public bool IsBillable { get; set; } = true;

    [Display(Name = "Registered Member")]
    public bool RegisteredMember { get; set; } = false;

{% endhighlight %}
{% endtabs %}
		
## Switch Editor

In switch editor, [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) is loaded, and DataForm [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) editor supports bool data type property.

To add [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) editor in DataForm, register the editor as [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) for the required property using the [RegisterEditor]`Link` method.

{% tabs %}
{% highlight MainPage.xaml.cs %}

       dataForm.RegisterEditor("CellularData", DataFormEditorType.Switch);
       dataForm.RegisterEditor("AirplaneMode", DataFormEditorType.Switch);

        [Display(Name ="Cellular Data")]
        public bool CellularData { get; set; } = true;

        [Display(Name = "Airplane Mode")]
        public bool AirplaneMode { get; set; }
 

{% endhighlight %}
{% endtabs %}

`Image`

## Combo Box editor

In the Combo Box editor, the [SfComboBox](https://help.syncfusion.com/maui/combobox)  will be loaded.

### Customizing ItemsSource of SfComboBox

By default, the `ItemsSource` for SfComboBox is auto-generated for enum types and collection type properties. For other types, you can set the `ItemsSource` by using the [IDataFormSourceProvider]`Link`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public string Country { get; set; }
    
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
        public override object GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "ItemName")
            {
                list.Add("India");
                list.Add("USA");
                list.Add("Japan");
            }
            return list;
        }
    }
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("ItemName", DataFormEditorType.ComboBox);

{% endhighlight %}
{% endtabs %}

#### Using GenerateDataFormItem event

You can also set the ItemsSource for combo box editor by using the [GenerateDataFormItem]`Link` event in the `DataFormComboBoxItem`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
            var list = new List<string>();
            list.Add("Home");
            list.Add("Food");
            list.Add("Utilities");
            list.Add("Education");
            comboBoxItem.ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

`Image`

### Loading complex type property values in combo box editor

You can display the complex type property values in combo box editor by using the [GetSource]`Link` method of IDataFormSourceProvider class, which is used to get source list as complex property values for combo box editor and set it to `IDataFormSourceProvider` property of SfDataForm. You need to use `GenerateDataFormItem `event to set [DisplayMemberPath]`Link` and [SelectedValuePath]`Link` property value of DataFormComboBoxItem for complex type property.

N> Class cannot be directly set as data type for combo box editor in this complex type scenario.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.DataObject = new DataModel();
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
    dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
 
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
            comboBoxItem.DisplayMemberPath = "City";
            comboBoxItem.SelectedValuePath = "PostalCode";
        }
    } 
 
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
        public override object GetSource(string sourceName)
        {
            if (sourceName == "City")
            {
                List<Address> details = new List<Address>();
                details.Add(new Address() { City = "Chennai", PostalCode = 1 });
                details.Add(new Address() { City = "Paris", PostalCode = 2 });
                details.Add(new Address() { City = "Vatican", PostalCode = 3 });

                return details;
            }
        return new List<string>();
        }
    }

    public class DataModel
    {
        [Display(Name ="First Name")]
        public String FirstName { get; set; } 
        public string City { get; set; }
    }

    public class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
    }

{% endhighlight %}
{% endtabs %}

`Image`


## Picker editor

In the picker editor, the [Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker?view=net-maui-7.0) will be loaded.

`Image`

### Customizing ItemsSource of Picker

By default, the `ItemsSource` for picker is auto-generated for enum type and collection type properties. For other types, you can set the `ItemsSource` by using [IDataFormSourceProvider]`Link`.

### Using IDataFormSourceProvider

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public string Country { get; set; }
    
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public override object GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "Country")
            {
                list.Add("India");
                list.Add("USA");
                list.Add("China");
                list.Add("Italy");
            }
            return list;
        }
    }
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("ItemName", DataFormEditorType.Picker);

{% endhighlight %}
{% endtabs %}

### Using event

You can also set `ItemsSource` for picker editor by using the [ItemsSource]`Link` property in the [DataFormPickerItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormPickerItem pickerItem)
        {
            var list = new List<string>();
            list.Add("Home");
            list.Add("Food");
            list.Add("Utilities");
            list.Add("Education");
            pickerItem.ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

### Loading complex type property values in picker

You can display the complex type property values in picker editor by using the [GetSource]`Link` override method of IDataFormSourceProvider class, which is used to get source list as complex property values for picker editor and set it to `IDataFormSourceProvider` property of SfDataForm. You need to use `GenerateDataFormItem`event to set [DisplayMemberPath]`Link` and [ValueMemberPath]`Link` property value DataFormPickerItem for complex type property.

N> Class cannot be directly set as data type for picker editor in this complex type scenario.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("City", DataFormEditorType.Picker);
    dataForm.DataObject = new DataModel();
        dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
 
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City" && e.DataFormItem is DataFormPickerItem pickerItem)
        {
            pickerItem.DisplayMemberPath = "City";
            pickerItem.ValueMemberPath = "PostalCode";
        }
    } 
 
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
            if (sourceName == "City")
            {
                List<Address> details = new List<Address>();
                details.Add(new Address() { City = "Chennai", PostalCode = 1 });
                details.Add(new Address() { City = "Paris", PostalCode = 2 });
                details.Add(new Address() { City = "Vatican", PostalCode = 3 });

                return details;
            }
        return new List<string>();
        }
    }

    public class DataModel
    {
        public String FirstName { get; set; } 
        public string City { get; set; }
    }

    public class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
    }

{% endhighlight %}
{% endtabs %}

`Image`



## RadioGroup editor

In the [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) editor, the [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) control is loaded.

The [items]`Link` for [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) is generated for `enum` and `List` data type properties. In order to add [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) editor in the DataForm, you need to register editor as [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) for the required property by using the [RegisterEditor]`Link` method.

**Support for enum data type**

For `enum` data type property, [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) [items]`Link` will be added based on specified property enum values.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.RegisterEditor("Phone", DataFormEditorType.RadioGroup);

    public Numbers Phone
    {
	    get { return phone; }
	    set { this.phone = value; }
    }

    public enum Numbers
    {
	    Home,
	    Work,
	    Other
    }

{% endhighlight %}
{% endtabs %}

**Support for List data type**

For `List` data type property, you have to set the `ItemsSource` by using the [IDataFormSourceProvider`Link`, based on that [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) [items]`Link` will be added.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.RegisterEditor("Phone", DataFormEditorType.RadioGroup);
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();

    public string Phone
    {
        get { return phone; }
        set { this.phone = value; }
    }

    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
		    var list = new List<string>();
		    if(sourceName == "Phone")
		    {
			    list.Add("Home");
			    list.Add("Work");
			    list.Add("Other");
		    }
		    return list;
        }
    }

{% endhighlight %}
{% endtabs %}

`Image`

## AutoComplete editor

In the autocomplete editor, the [SfAutoComplete](https://help.syncfusion.com/maui/autocomplete) is loaded.

### Customizing ItemsSource of autocomplete editor

By default, the [ItemsSource]`Link` for `AutoComplete` editor is auto-generated for enum types. For other types, you can set [ItemsSource]`Link` using [IDataFormSourceProvider]`Link`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public string Country { get ; set ; }
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "Country")
            {
                list.Add("Indonesia");
                list.Add("Italy");
                list.Add("India");
                list.Add("Iran");
                list.Add("Iraq");
                list.Add("Uganda");
                list.Add("Ukraine");
                list.Add("Canada");
                list.Add("Australia");
                list.Add("Uzbekistan");
                list.Add("France");
                list.Add("United Kingdom");
                list.Add("United States");
            }
            return list;
        }
    }
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);

{% endhighlight %}
{% endtabs %}

`Image`

#### Using GenerateDataFormItem event

You can also set `ItemsSource` for autocomplete editor by using [ItemsSource]`Link` property in the [DataFormAutoCompleteItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {
            var list = new List<string>();
            list.Add("Indonesia");
            list.Add("Italy");
            list.Add("India");
            list.Add("Iran");
            list.Add("Iraq");
            list.Add("Uganda");
            list.Add("Ukraine");
            list.Add("Canada");
            list.Add("Australia");
            list.Add("Uzbekistan");
            list.Add("France");
            list.Add("United Kingdom");
            list.Add("United States");
            autoCompleteItem.ItemsSource = list;
        }
    }
{% endhighlight %}
{% endtabs %}

#### Loading complex type property values in autocomplete editor

You can display the complex type property values in autocomplete editor by using [GetSource]`Link` method of the IDataFormSourceProvider class, which is used to get source list as complex property values for autocomplete editor and set it to the `IDataFormSourceProvider` property of SfDataForm.Use the `GenerateDataFormItem `event to set [DisplayMemberPath] and [SelectedValuePath] property values of AutoComplete for complex type property.

N> Class cannot be directly set as data type for autocomplete editor in this complex type scenario.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.DataObject = new DataModel();
    dataForm.RegisterEditor("City", DataFormEditorType.AutoComplete);
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
 
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {
            autoCompleteItem.DisplayMemberPath = "City";
            autoCompleteItem.SelectedValuePath = "PostalCode";
        }
    } 
 
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
            if (sourceName == "City")
            {
                List<Address> details = new List<Address>();
                details.Add(new Address() { City = "Colorado Springs", PostalCode = 1 });
                details.Add(new Address() { City = "Chicago", PostalCode = 2 });
                details.Add(new Address() { City = "Columbus", PostalCode = 3 });
                details.Add(new Address() { City = "Portland", PostalCode = 4 });
                details.Add(new Address() { City = "Paris", PostalCode = 5 });
                details.Add(new Address() { City = "Las Vegas", PostalCode = 6 });         
                details.Add(new Address() { City = "New York", PostalCode = 7 });
                details.Add(new Address() { City = "Cincinnati", PostalCode = 8 });
                details.Add(new Address() { City = "San Diego", PostalCode = 9 });

                return details;
            }
            return new List<string>();
        }
    }

    public class DataModel
    {
        [Display(Name ="First Name")]
        public String FirstName { get; set; } 
        public string City { get; set; }
    }

    public class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
{% endhighlight %}
{% endtabs %}

`Image`

#### AutoComplete editor modes

The [DataFormAutoCompleteEditor]`Link` provides display the filtered suggestions.

The `AutoCompleteMode` property is used to choose the suggestion display mode in the `DataFormAutoCompleteItem` class.

#### AutoComplete editor suggestion options

The phenomenon of string comparison for filtering suggestions can be changed using the "StartsWith" and "Containswith" `Link` property. The default filtering strategy is “StartsWith”, and it is case insensitive. The available filtering modes are,

* StartsWith

* ContainsWithCaseSensitive

#### Filtering words that starts with the input text

Displays all the matches that contain first character of the typed characters in items source of autocomplete editor. This strategy is case in-sensitive.

#### Filtering words that contains with the input text

Displays all the matches that contain the typed characters in items source of autocomplete editor. This strategy is case in-sensitive.
	
## Custom editor

The custom editor can be added to DataForm by inheriting the `IDataFormEditor` class for business models. You can create custom editor using implement all method in IDataFormEditor. 

To add custom editor in DataForm, register the editor with custom registered type for the required property using `RegisterEditor` method. You can also customize editor settings by using available methods in `IDataFormEditor`. 

### Creating custom editor using IDataFormEditor 

Views such as labels, buttons, and sliders can be loaded to custom editor. Here, entry is loaded as custom editor for `PhoneNumer` property. 

### Below methioned example code for Numeric editor which accepts only numbers 

{% tabs %}
{% highlight MainPage.xaml.cs %}

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
                if (dataFormItem.FieldName == nameof(PaymentFormModel.CVV))
                {
                    dataFormItem.SetValue(numericText.Text);
                }
                else
                {
                    double numericValue;
                    double.TryParse(numericText.Text, out numericValue);
                    dataFormItem.SetValue(numericValue);
                }
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
… 

    dataForm.RegisterEditor("PhoneNumber", new NumericEditor(dataForm)); 
{% endhighlight %}
{% endtabs %}

You should manually commit and validate the editor value of custom DataFormItem. Refer to this [link]`Link` to know more about custom editor. 
