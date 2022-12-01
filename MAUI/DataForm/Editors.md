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
Entry
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
Editor
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
DateTime type property and the property with [DataType(DataType.Date)] and [DataType(DataType.DateTime)] attributes.
</td>
<td>
DatePicker
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
The property with [DataType(DataType.Time)] attribute.
</td>
<td>
TimePicker
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
SfCheckBox
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
Switch
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
Picker
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
SfComboBox
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
Entry
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
SfRadioGroup
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
SfAutoComplete
</td>
</tr>
</table>

## Text editor

In the text editor, the [Entry]`Link` is loaded.

## Multiline Text editor

In the `MultilineText` editor, the [Editor]`Link` is loaded.

And `MultilineText` editor height will auto expand/reduce based on the line wraps in editor , which allowing text to be readable without scrolling the editor.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [DataType(DataType.MultilineText)]
    public String Address { get; set; }

{% endhighlight %}
{% endtabs %}

`Image`



## Date editor

In the date editor, the DatePicker `Link` will be loaded.

In `DatePicker`, the default date value is current date displayed by default. You can also adding nullable `DateTime` data type for the date picker property in data form, which allows you to set the current date and display current date in date editor. 

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [DataType(DataType.Date)]
    [Display(Name ="Birth Date")]
    public DateTime? BirthDate { get; set; }

{% endhighlight %}
{% endtabs %}

`Image`

### Customizing format in date editor

In the `DatePicker`, short date will be shown by default. You can change the applied format by setting the [Format]`Link`property in [DataFormDateItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {   

        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Date")
        {
        (e.DataFormItem as DataFormDateItem).Format = "dd, MM, yyyy";
        }
    }
{% endhighlight %}
{% endtabs %}

`Image`

### Setting title for date editor

You can set title to the date editor by handling the [Title]`Link`property in [DataFormDateItem]`Link`. The default value of the property is `Choose Date`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {   

        if (e.DataFormItem != null && e.DataFormItem.FieldName == "BirthDate")
        {       
            (e.DataFormItem as DataFormDateItem).Title = "Select a date";
        }
    }
{% endhighlight %}
{% endtabs %}


### Setting MaximumDate and MinimumDate in date editor

You can customize the maximum and minimum allowable dates in the `DatePicker` by setting [MaximumDate]`Link` and [MinimumDate]`Link` in the [DataFormDateItem]`Link` respectively.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Date")
        {
            (e.DataFormItem as DataFormDateItem).MinimumDate = new DateTime(2017, 5, 5);
            (e.DataFormItem as DataFormDateItem).MaximumDate = new DateTime(2017, 9, 2);
        }
    }

{% endhighlight %}
{% endtabs %}

`DateMAximumImages`

## Time editor

In the time editor, the [TimePicker]`Link` will be loaded.


In `TimePicker`, the default time value (12:00 AM) is displayed by default. You can also adding nullable `DateTime` data type for the time picker property in data form, which allows you to set default time and display the (12:00 AM) in time editor. 

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [DataType(DataType.Time)]
    [Display(Name = "Birth Time")]
    public DateTime? BirthTime { get; set; }

{% endhighlight %}
{% endtabs %}

`images`

**Customizing format in time editor**

In the `TimePicker`, short time will be shown by default. You can change the applied format by setting the [Format]`Link`property in [DataFormTimeItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "BirthTime")
        (e.DataFormItem as DataFormTimeItem).Format = "HH:mm";
    } 

{% endhighlight %}
{% endtabs %}

`Image`

### Setting title for time editor

You can set title to the time editor by handling the [Title]`Link`property in [DataFormTimeItem]`Link`. The default value of this property is `Choose Time`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {   

        if (e.DataFormItem != null && e.DataFormItem.FieldName == "BirthTime")
        {
            (e.DataFormItem as DataFormTimeItem).Title = "Select time of birth";
        }
    }

{% endhighlight %}
{% endtabs %}


## CheckBox editor

In `CheckBox` editor, the [SfCheckBox]`Link` control is loaded. By default, for `bool` data type property, the `CheckBox` editor will be loaded in data form.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [Display(Name = "Is Billable")]
    public bool IsBillable { get; set; } = true;

    [Display(Name = "Registered Member")]
    public bool RegisteredMember { get; set; }

{% endhighlight %}
{% endtabs %}

`Image`

**Visual states of SfCheckBox**

SfCheckBox support three visual states.
  - Checked
  - UnChecked

{% tabs %}
{% highlight MainPage.xaml.cs %}

    [Display(Name = "Is Billable")]
    public bool IsBillable { get; set; } = true;

    [Display(Name = "Registered Member")]
    public bool RegisteredMember { get; set; } = false;

    [Display( Name = "Is Refundable")]
    public bool? IsRefundable { get; set; } = null;

{% endhighlight %}
{% endtabs %}
		
## Switch Editor

In switch editor, [Switch]`Link` is loaded, and DataForm `Switch` editor supports bool data type property.

To add `Switch` editor in DataForm, register the editor as `Switch` for the required property using the [RegisterEditor]`Link` method.

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

In the Combo Box editor, the [SfComboBox]`Link` will be loaded.

### Customizing ItemsSource of SfComboBox

By default, the `ItemsSource` for SfComboBox is auto-generated for enum types and collection type properties. For other types, you can set the `ItemsSource` by using the [IDataFormSourceProvider]`Link`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public string ItemName { get; set; }
    
    public class SourceProviderExt : IDataFormSourceProvider
    {
        public override IList GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "ItemName")
            {
                list.Add("Item1");
                list.Add("Item2");
                list.Add("Item3");
            }
            return list;
        }
    }
    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.RegisterEditor("ItemName", DataFormEditorType.ComboBox);

{% endhighlight %}
{% endtabs %}

#### Using ItemsSource property

You can also set the ItemsSource for combo box editor by using the [ItemsSource]`Link` property in the `DataFormComboBoxItem`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
        {
            var list = new List<string>();
            list.Add("Home");
            list.Add("Food");
            list.Add("Utilities");
            list.Add("Education");
            (e.DataFormItem as DataFormComboBoxItem).ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

`Image`

### Changing ItemsSource of SfComboBox at run time

You can also change the `ItemsSource` at runtime.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    private void Button_Click(object sender, EventArgs e)
    {
        var dataFormItem = dataForm.ItemManager.DataFormItems["Name"];
        if (dataFormItem.FieldName == "Name")
        {
            var list = new List<string>();
            list.Add("Home");
            list.Add("Food");
            list.Add("Utilities");
            list.Add("Education");
            (dataFormItem as DataFormComboBoxItem).ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

### Loading complex type property values in combo box editor

You can display the complex type property values in combo box editor by using the [GetSource]`Link` method of IDataFormSourceProvider class, which is used to get source list as complex property values for combo box editor and set it to `IDataFormSourceProvider` property of SfDataForm. You need to use `GenerateDataFormItem `event to set [DisplayMemberPath]`Link` and [SelectedValuePath]`Link` property value of DataFormComboBoxItem for complex type property.

N> Class cannot be directly set as data type for combo box editor in this complex type scenario.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.DataObject = new DataModel();
    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;
    dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
 
    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City")
        {
       
            (e.DataFormItem as DataFormComboBoxItem).DisplayMemberPath = "City";
            (e.DataFormItem as DataFormComboBoxItem).SelectedValuePath = "PostalCode";
        }
    } 
 
    public class SourceProviderExt : IDataFormSourceProvider
    {
        public override IList GetSource(string sourceName)
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

In the picker editor, the [Picker]`Link` will be loaded.

`Image`

### Customizing ItemsSource of Picker

By default, the `ItemsSource` for picker is auto-generated for enum type and collection type properties. For other types, you can set the `ItemsSource` by using [IDataFormSourceProvider]`Link`.

### Using IDataFormSourceProvider

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public string ItemName { get; set; }
    
    public class SourceProviderExt : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "ItemName")
            {
                list.Add("Item1");
                list.Add("Item2");
                list.Add("Item3");
            }
            return list;
        }
    }
    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.RegisterEditor("ItemName", DataFormEditorType.Picker);

{% endhighlight %}
{% endtabs %}

### Using event

You can also set `ItemsSource` for picker editor by using the [ItemsSource]`Link` property in the [DataFormPickerItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
        {
            var list = new List<string>();
            list.Add("Home");
            list.Add("Food");
            list.Add("Utilities");
            list.Add("Education");
            (e.DataFormItem as DataFormPickerItem).ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

### Changing ItemsSource of picker at run time

You can also change the `ItemsSource` at runtime.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    private void Button_Click(object sender, EventArgs e)
    {
        var dataFormItem = dataForm.ItemManager.DataFormItems["Name"];
        if (dataFormItem.FieldName == "Name")
        {
            var list = new List<string>();
            list.Add("Home");
            list.Add("Food");
            list.Add("Utilities");
            list.Add("Education");
            (dataFormItem as DataFormPickerItem).ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

### Loading complex type property values in picker

You can display the complex type property values in picker editor by using the [GetSource]`Link` override method of IDataFormSourceProvider class, which is used to get source list as complex property values for picker editor and set it to `IDataFormSourceProvider` property of SfDataForm. You need to use `GenerateDataFormItem`event to set [DisplayMemberPath]`Link` and [ValueMemberPath]`Link` property value DataFormPickerItem for complex type property.

N> Class cannot be directly set as data type for picker editor in this complex type scenario.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.RegisterEditor("City", DataFormEditorType.Picker);
    dataForm.DataObject = new DataModel();
        dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;
 
    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City")
        {
            (e.DataFormItem as DataFormPickerItem).DisplayMemberPath = "City";
            (e.DataFormItem as DataFormPickerItem).ValueMemberPath = "PostalCode";
        }
    } 
 
    public class SourceProviderExt : IDataFormSourceProvider
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

## Password editor

In the password editor, the [Entry]`Link` is loaded.

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

## RadioGroup editor

In the `RadioGroup` editor, the [SfRadioGroup]`Link` control is loaded.

The [items]`Link` for `SfRadioGroup` is generated for `enum` and `List` data type properties. In order to add `RadioGroup` editor in the DataForm, you need to register editor as `RadioGroup` for the required property by using the [RegisterEditor]`Link` method.

**Support for enum data type**

For `enum` data type property, `SfRadioGroup` [items]`Link` will be added based on specified property enum values.

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

For `List` data type property, you have to set the `ItemsSource` by using the [IDataFormSourceProvider`Link`, based on that `SfRadioGroup` [items]`Link` will be added.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.RegisterEditor("Phone", DataFormEditorType.RadioGroup);
    dataForm.ItemsSourceProvider = new SourceProviderExt();

    public string Phone
    {
        get { return phone; }
        set { this.phone = value; }
    }

    public class SourceProviderExt : IDataFormSourceProvider
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

In the autocomplete editor, the [SfAutoComplete]`Link` is loaded.

### Customizing ItemsSource of autocomplete editor

By default, the [ItemsSource]`Link` for `AutoComplete` editor is auto-generated for enum types. For other types, you can set [ItemsSource]`Link` using [IDataFormSourceProvider]`Link`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public string Country { get ; set ; }
    public class SourceProviderExt : IDataFormSourceProvider
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
    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);

{% endhighlight %}
{% endtabs %}

`Image`

#### Using GenerateDataFormItem event

You can also set `ItemsSource` for autocomplete editor by using [ItemsSource]`Link` property in the [DataFormAutoCompleteItem]`Link`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country")
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
            (e.DataFormItem as DataFormAutoCompleteItem).ItemsSource = list;
        }
    }
{% endhighlight %}
{% endtabs %}

#### Dynamically changing the ItemsSource of autocomplete editor

You can also change the [ItemsSource]`Link` at runtime.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    private void Button_Click(object sender, EventArgs e)
    {
        var dataFormItem = dataForm.ItemManager.DataFormItems["Country"];
        if (dataFormItem.FieldName == "Country")
        {
            var list = new List<string>();
            list.Add("Ukraine");
            list.Add("Canada");
            list.Add("Australia");
            list.Add("Uzbekistan");
            list.Add("France");
            list.Add("United Kingdom");
            list.Add("United States");
            (dataFormItem as DataFormAutoCompleteItem).ItemsSource = list;
        }
    }
{% endhighlight %}
{% endtabs %}

#### Loading complex type property values in autocomplete editor

You can display the complex type property values in autocomplete editor by using [GetSource]`Link` method of the IDataFormSourceProvider class, which is used to get source list as complex property values for autocomplete editor and set it to the `IDataFormSourceProvider` property of SfDataForm.Use the `GenerateDataFormItem `event to set [DisplayMemberPath] and [SelectedValuePath] property values of AutoComplete for complex type property.

N> Class cannot be directly set as data type for autocomplete editor in this complex type scenario.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.DataObject = new DataModel();
    dataForm.RegisterEditor("City", DataFormEditorType.AutoComplete);
    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;
 
    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City")
        {
            (e.DataFormItem as DataFormAutoCompleteItem).DisplayMemberPath = "City";
            (e.DataFormItem as DataFormAutoCompleteItem).SelectedValuePath = "PostalCode";
        }
    } 
 
    public class SourceProviderExt : IDataFormSourceProvider
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

* Suggest - Displays suggestions in drop-down list

* Append - Appends the first suggestion to text

* SuggestAppend - Performs both suggest and append.

The `AutoCompleteMode` property is used to choose the suggestion display mode in the `DataFormAutoCompleteItem` class. The default value is Suggest.

#### Suggestion choices in list

The filtered suggestions are displayed in a drop-down list. Users can pick an item from the list.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.DataObject = new DataModel();
    dataForm.ItemsSourceProvider = new SourceProviderExt();
    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
    dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

    private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country")
        {
            var autoCompleteItem = (e.DataFormItem as DataFormAutoCompleteItem);
            autoCompleteItem.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
    }
    public class SourceProviderExt : IDataFormSourceProvider
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

{% endhighlight %}
{% endtabs %}

`Image`

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
            return new Entry(); 
        } 
    } 
… 

dataForm.RegisterEditor("PhoneNumber", new NumericEditor(dataForm)); 
{% endhighlight %}
{% endtabs %}

You should manually commit and validate the editor value of custom DataFormItem. Refer to this [link]`Link` to know more about custom editor. 
