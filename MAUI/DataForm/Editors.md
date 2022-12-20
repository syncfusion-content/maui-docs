---
layout: post
title: Editors in .NET MAUI DataForm(SfDataForm) control | Syncfusion
description: Learn here all about Editors support in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: Maui
control: SfDataForm
documentation: UG
---

# Editors in .NET MAUI DataForm (SfDataForm)

The data form supports several built-in editors as follows:

<table>
<tr>
<th>Editor name</th>
<th>Supported Data Type/Attribute</th>
<th>Input control loaded</th>
</tr>
<tr>
<td>
Text
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
DateTime, DateOnly or DateTimeOffset type property and the property with [DataType(DataType.Date)] and [DataType(DataType.DateTime)] attributes.
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
The DateTime, TimeSpan, TimeOnly or DateTimeOffset  property with [DataType(DataType.Time)] attribute.
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
Enum and List type property. 
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
Enum and List type property.
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
Enum and List type property.
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
Enum and List type property.
</td>
<td>
{{'[RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
</tr>

</table>

## To change the editor for any data type

By default, the editors will be loaded based on the datatype. To change the editor for any type, use the `RegisterEditor` method and specify the type and editor.

{% tabs %}
{% highlight C# %}

    this.dataForm.RegisterEditor(typeof(string), DataFormEditorType.MultilineText);

{% endhighlight %}
{% endtabs %}

Here, the `MultilineText` editor will be loaded for the string type instead of `Text` editor.

## Changing the editor for property

To change the editor for any property, use the `RegisterEditor` method and specify the property name and editor.

{% tabs %}
{% highlight c# %}

    this.dataForm.RegisterEditor("On", DataFormEditorType.Switch);

{% endhighlight %}

{% endtabs %}

Here, the Switch editor will be loaded for the `On` property (bool type) instead of `CheckBox` editor.

## Text editor

In the text editor, the [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0) is loaded.

Text editor have Keyboard type change by using `Keyboard` property and you can set maximum allowed length of input by using `MaxLength` property.

{% tabs %}
{% highlight C# %}

    [DataType(DataType.Text)]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

## Multiline Text editor

In the `MultilineText` editor, the [Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-7.0) is loaded.

And `MultilineText` editor height will auto expand/reduce based on the line wraps in editor , which allowing text to be readable without scrolling the editor.

{% tabs %}
{% highlight C# %}

    [DataType(DataType.MultilineText)]
    public string Address { get; set; }

{% endhighlight %}
{% endtabs %}

![MultiLineText](images\MultiLine\MultiLineText.png)

## Password editor

In the password editor, the [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0) is loaded.

{% tabs %}
{% highlight C# %}

    [Display(ShortName = "Transaction password", Prompt = "Enter password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
{% endhighlight %}
{% endtabs %}

![PasswordEditor](images\Editors\PasswordEditor.png)

## Date editor

In the date editor, the [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0) will be loaded.

In [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0), the default date value is current date displayed. You can also adding nullable `DateTime` data type for the date picker property in data form, which allows you to set the current date and display current date in date editor. 

{% tabs %}
{% highlight C# %}

    [DataType(DataType.Date)]
    [Display(Name ="Event Date")]
    public DateTime? EventDate { get; set; }

{% endhighlight %}
{% endtabs %}

![DatePicker](images\Editors\DatePicker.png)

#### Change the format of the date editor

In the [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0), short date will be shown by default. You can change the applied format by setting the `Format`property in `DataFormDateItem`.

{% tabs %}
{% highlight C# %}

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

#### Change the minimum and maximum date in date editor

You can customize the maximum and minimum allowable dates in the [DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0) by setting `MaximumDate` and `MinimumDate` in the `DataFormDateItem` respectively.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Date" && e.DataFormItem is DataFormDateItem dateItem)
        {
            dateItem.MinimumDate = new DateTime(2022, 5, 5);
            dateItem.MaximumDate = new DateTime(2022, 9, 2);
        }
    }

{% endhighlight %}
{% endtabs %}

`DateMAximumImages`

## Time editor

In the time editor, the [TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows) will be loaded.


In [TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows), the default time value (12:00 AM) is displayed. You can also adding nullable `TimeSpan` data type for the time picker property in data form, which allows you to set default time and display the (12:00 AM) in time editor. 

{% tabs %}
{% highlight C# %}

    [DataType(DataType.Time)]
    [Display(Name = "Event Time")]
    public TimeSpan? EventTime { get; set; }

{% endhighlight %}
{% endtabs %}

![TimePicker](images\Editors\TimePicker.png)

#### Change the format of time editor**

In the [TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows), short time will be shown by default. You can change the applied format by setting the `Format`property in `DataFormTimeItem`.

{% tabs %}
{% highlight C# %}

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
{% highlight C# %}

    [Display(Name = "Is Billable")]
    public bool IsBillable { get; set; } = true;

    [Display(Name = "Registered Member")]
    public bool RegisteredMember { get; set; }

{% endhighlight %}
{% endtabs %}

![CheckBox](images\Editors\CheckBox.png)

CheckBox support two visual states.
  - Checked
  - UnChecked

{% tabs %}
{% highlight C# %}

    [Display(Name = "Is Billable")]
    public bool IsBillable { get; set; } = true;

    [Display(Name = "Registered Member")]
    public bool RegisteredMember { get; set; } = false;

{% endhighlight %}
{% endtabs %}

#### Changing the checkbox color

By default the checkbox color is blue, you can change the checkbox color by using `Color` property in `DataFormItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
    
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem.FieldName == "agree" && e.DataFormItem is DataFormCheckBoxItem dataFormCheckBox)
        {
            dataFormCheckBox.Color = Colors.Pink;
        }
    }
    
{% endhighlight %}
{% endtabs %}

![CheckBoxWithColor](images\Editors\CheckBoxWithColor.png)
		
## Switch Editor

In switch editor, [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) is loaded, and DataForm [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) editor supports bool data type property.

To add [Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0) editor in DataForm, register the editor as DataFormEditorType.Switch  for the required property using the `RegisterEditor` method.

{% tabs %}
{% highlight C# %}

       dataForm.RegisterEditor("CellularData", DataFormEditorType.Switch);
       dataForm.RegisterEditor("AirplaneMode", DataFormEditorType.Switch);

        [Display(Name ="Cellular Data")]
        public bool CellularData { get; set; } = true;

        [Display(Name = "Airplane Mode")]
        public bool AirplaneMode { get; set; }
 

{% endhighlight %}
{% endtabs %}

`![SwitchEditor](images\Editors\SwitchEditor.png)

#### Changing the Switch Editor thumb color

#### Using event

By default switch editor Thumb color is Blue, you can change the Thumb color by using `ThumbColor` property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Agree" && e.DataFormItem is DataFormSwitchItem switchItem)
        {
            switchItem. ThumbColor = Colors.Pink;
        }
    }

{% endhighlight %}
{% endtabs %}

![SwitchWithThumbColor](images\Editors\SwitchWithThumbColor.png)

#### Changing the Switch editor background color

#### Using event

By default switch editor background colour is white, you can change the Background color by using `OnColor` property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Agree" && e.DataFormItem is DataFormSwitchItem switchItem)
        {
            dataFormSwitchItem. OnColor = Colors.Black;
        }
    }

{% endhighlight %}
{% endtabs %}

![SwitchWithOnColor](images\Editors\SwitchWithOnColor.png)

## Combo Box editor

In the Combo Box editor, the [SfComboBox](https://help.syncfusion.com/maui/combobox)  will be loaded.

#### Changing the ItemsSource of combo box

By default, the `ItemsSource` for SfComboBox is auto-generated for enum types and collection type properties. For other types, you can set the `ItemsSource` by using the `IDataFormSourceProvider`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight C# %}

    public string Country { get; set; }
    
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            
            if (sourceName == "Country")
            {
                List<string> list = new List<string>()
                {
                    "India",
                    "USA",
                    "Japan"
                };
                return list;
            }
            return new List<string>();
        }
    }
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("Country", DataFormEditorType.ComboBox);

{% endhighlight %}
{% endtabs %}

![ComboBoxEditor](images\Editors\ComboBoxEditor.png)

#### Using GenerateDataFormItem event

You can also set the ItemsSource for combo box editor by using the `GenerateDataFormItem` event in the `DataFormComboBoxItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
             List<string> list = new List<string>()
            {
                "Home",
                "Food",
                "Utilities",
                "Education"
            };
            comboBoxItem.ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}


#### Enabling editing mode in combobox

By default, in the combobox editor, you can select a needed item by scrolling the whole list of items.

You can filter a particular item in the list items by using the `IsEditable` property, this property enables you to type a list item in the combo box editor.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
           comboBoxItem.IsEditable = true;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Searching words that starts with the input text

Displays all the matches that contain first character of the typed characters in items source of combobox editor. This strategy is case in-sensitive.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
            comboBoxItem.TextSearchMode = DataFormTextSearchMode.StartsWith;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Searching words that contains the input text

Displays all the matches that contain the typed characters in items source of combobox editor. This strategy is case in-sensitive.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "City" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
            comboBoxItem.TextSearchMode = DataFormTextSearchMode.Contains;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Changing the height of combobox item 

By default the combo box drop down list item height is `400d` , You can change the size for the drop down list item size by using `MaxDropDownHeight` property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {
            comboBoxItem.MaxDropDownHeight = 400;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Loading the complex type property values in combo box editor

You can display the complex type property values in combo box editor by using the DisplayMemberPath and SelectedValuePath properties of DataFormComboBoxItem. You need to use `GenerateDataFormItem `event to set `DisplayMemberPath` and `SelectedValuePath` property value of DataFormComboBoxItem for complex type property.

N> Class cannot be directly set as data type for combo box editor in this complex type scenario.

{% tabs %}
{% highlight C# %}

    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.DataObject = new ContactModel();
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
    dataForm.RegisterEditor("EmployeeDetails", DataFormEditorType.ComboBox);
 
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "EmployeeDetails" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
        {   
            comboBoxItem.DisplayMemberPath = "ID";
            comboBoxItem.SelectedValuePath = "Name";
        }
    } 
 
    public class DataFormItemsSourceProvider  : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "EmployeeDetails")
            {
                List<EmployeeInfo> details = new List<EmployeeInfo>();
                details.Add(new EmployeeInfo() { ID = 1, Name =  "Eric"  });
                details.Add(new EmployeeInfo() { ID = 2, Name = "James"  });
                details.Add(new EmployeeInfo() { ID = 3, Name = "Jacob"  });
                details.Add(new EmployeeInfo() { ID = 4, Name = "Lucas"  });
                details.Add(new EmployeeInfo() { ID = 5, Name = "Mark"  });
                details.Add(new EmployeeInfo() { ID = 6, Name = "Aldan"  });
                details.Add(new EmployeeInfo() { ID = 7, Name = "Aldrin"  });
                details.Add(new EmployeeInfo() { ID = 8, Name = "Alan"  });
                details.Add(new EmployeeInfo() { ID = 9, Name = "Aaron"  });

                return details;
            }
        return new List<string>();
        }
    }

    public class ContactInfo
    {
        [Display(Name ="First Name")]
        public String FirstName { get; set; } 
        public string EmployeeDetails { get; set; }
    }

    public class EmployeeInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

{% endhighlight %}
{% endtabs %}

`Image`

## AutoComplete editor

In the autocomplete editor, the [SfAutoComplete](https://help.syncfusion.com/maui/autocomplete) is loaded.

#### Changing the ItemsSource of autocomplete editor

By default, the `ItemsSource` for `AutoComplete` editor is auto-generated for enum types. For other types, you can set `ItemsSource` using `IDataFormSourceProvider`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight C# %}

    public string Country { get ; set ; }
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
            if (sourceName == "Country")
            {
                List<string> list = new List<string>()
                {
                    "Indonesia",
                    "Italy",
                    "India",
                    "Iran",
                    "Iraq",
                    "Uganda"
                    "Ukraine"
                    "Canada"
                    "Australia"
                    "Uzbekistan"
                    "France"
                    "United Kingdom"
                    "United States"
                };
                return list;
            }
            return new List<string>();
        }
    }
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);

{% endhighlight %}
{% endtabs %}

`Image`

#### Using GenerateDataFormItem event

You can also set `ItemsSource` for autocomplete editor by using `ItemsSource` property in the `DataFormAutoCompleteItem`.

{% tabs %}
{% highlight C# %}

    dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {
            List<string> list = new List<string>();
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

#### Loading the complex type property values in autocomplete editor

You can display the complex type property values in combo box editor by using the DisplyMemberPath and SelectedValuePath properties of DataFormComboBoxItem. You need to use `GenerateDataFormItem `event to set `DisplayMemberPath` and `SelectedValuePath` property value of DataFormComboBoxItem for complex type property.

You can display the complex type property values in autocomplete editor by using the DisplayMemberPath and SelectedValuePath properties of DataFormAutoCompleteItem. Use the `GenerateDataFormItem `event to set `DisplayMemberPath` and `SelectedValuePath` property values of AutoComplete for complex type property.

N> Class cannot be directly set as data type for autocomplete editor in this complex type scenario.

{% tabs %}
{% highlight C# %}

    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.DataObject = new ContactModel();
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
    dataForm.RegisterEditor("EmployeeDetails", DataFormEditorType.ComboBox);
 
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "EmployeeDetails" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {   
            autoCompleteItem.DisplayMemberPath = "ID";
            autoCompleteItem.SelectedValuePath = "Name";
        }
    } 
 
    public class DataFormItemsSourceProvider  : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "EmployeeDetails")
            {
                List<EmployeeInfo> details = new List<EmployeeInfo>();
                details.Add(new EmployeeInfo() { ID = 1, Name =  "Eric"  });
                details.Add(new EmployeeInfo() { ID = 2, Name = "James"  });
                details.Add(new EmployeeInfo() { ID = 3, Name = "Jacob"  });
                details.Add(new EmployeeInfo() { ID = 4, Name = "Lucas"  });
                details.Add(new EmployeeInfo() { ID = 5, Name = "Mark"  });
                details.Add(new EmployeeInfo() { ID = 6, Name = "Aldan"  });
                details.Add(new EmployeeInfo() { ID = 7, Name = "Aldrin"  });
                details.Add(new EmployeeInfo() { ID = 8, Name = "Alan"  });
                details.Add(new EmployeeInfo() { ID = 9, Name = "Aaron"  });

                return details;
            }
        return new List<string>();
        }
    }

    public class ContactInfo
    {
        [Display(Name ="First Name")]
        public String FirstName { get; set; } 
        public string EmployeeDetails { get; set; }
    }

    public class EmployeeInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

{% endhighlight %}
{% endtabs %}


`Image`

The `DataFormAutoCompleteEditor` provides display the filtered suggestions.

The `AutoCompleteMode` property is used to choose the suggestion display mode in the `DataFormAutoCompleteItem` class.

#### AutoComplete editor suggestion options

The phenomenon of string comparison for filtering suggestions can be changed using the `"StartsWith"` and `"Contains"` property. The default filtering strategy is “StartsWith”, and it is case insensitive. The available filtering modes are,

* StartsWith

* Contains

#### Filtering words that starts with the input text

Displays all the matches that contain first character of the typed characters in items source of autocomplete editor. This strategy is case in-sensitive.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {
            autoComplete.TextSearchMode = DataFormTextSearchMode.StartsWith;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Filtering words that contains the input text

Displays all the matches that contain the typed characters in items source of autocomplete editor. This strategy is case in-sensitive.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {
            autoComplete.TextSearchMode = DataFormTextSearchMode.Contains;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Setting the height for autocomplete list item 

By default the autocomplete drop down list item height is `400d` , You can change the size for the drop down list item size by using `MaxDropDownHeight` property in the `DataFormItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormAutoCompleteItem autoCompleteItem)
        {
            autoComplete.MaxDropDownHeight = 400;
        }
    }

{% endhighlight %}
{% endtabs %}


## Picker editor

In the picker editor, the [Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker?view=net-maui-7.0) will be loaded.

`Image`

#### Changing the ItemsSource of Picker

By default, the `ItemsSource` for picker is auto-generated for enum type and collection type properties. For other types, you can set the `ItemsSource` by using `IDataFormSourceProvider`.

#### Using IDataFormSourceProvider

{% tabs %}
{% highlight C# %}

    public string Country { get; set; }
    
    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
            if (sourceName == "Country")
            {
                List<string> list = new List<string>()
                {
                    "India",
                    "USA",
                    "China",
                    "Italy"
                };
                return list;
            }
            return new List<string>();
        }
    }
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.RegisterEditor("Country", DataFormEditorType.Picker);

{% endhighlight %}
{% endtabs %}

#### Using event

You can also set `ItemsSource` for picker editor by using the `ItemsSource` property in the `DataFormPickerItem`.

{% tabs %}
{% highlight C# %}

    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormPickerItem pickerItem)
        {
            List<string> list = new Lisvt<string>()
            {
                "Home",
                "Food",
                "Utilities",
                "Education"
            };
            pickerItem.ItemsSource = list;
        }
    }

{% endhighlight %}
{% endtabs %}

#### Loading the complex type property values in picker

You can display the complex type property values in picker editor by using the DisplayMemberPath and SelectedValuePath properties of DataFormPickerItem. You need to use `GenerateDataFormItem`event to set `DisplayMemberPath` and `SelectedValuePath` property value DataFormPickerItem for complex type property.

N> Class cannot be directly set as data type for picker editor in this complex type scenario.

{% tabs %}
{% highlight C# %}

    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
    dataForm.DataObject = new ContactModel();
    dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
    dataForm.RegisterEditor("EmployeeDetails", DataFormEditorType.Picker);
 
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem.FieldName == "EmployeeDetails" && e.DataFormItem is DataFormPickerItem pickerItem)
        {   
            pickerItem.DisplayMemberPath = "ID";
            pickerItem.SelectedValuePath = "Name";
        }
    } 
 
    public class DataFormItemsSourceProvider  : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "EmployeeDetails")
            {
                List<EmployeeInfo> details = new List<EmployeeInfo>();
                details.Add(new EmployeeInfo() { ID = 1, Name =  "Eric"  });
                details.Add(new EmployeeInfo() { ID = 2, Name = "James"  });
                details.Add(new EmployeeInfo() { ID = 3, Name = "Jacob"  });
                details.Add(new EmployeeInfo() { ID = 4, Name = "Lucas"  });
                details.Add(new EmployeeInfo() { ID = 5, Name = "Mark"  });
                details.Add(new EmployeeInfo() { ID = 6, Name = "Aldan"  });
                details.Add(new EmployeeInfo() { ID = 7, Name = "Aldrin"  });
                details.Add(new EmployeeInfo() { ID = 8, Name = "Alan"  });
                details.Add(new EmployeeInfo() { ID = 9, Name = "Aaron"  });

                return details;
            }
        return new List<string>();
        }
    }

    public class ContactInfo
    {
        [Display(Name ="First Name")]
        public String FirstName { get; set; } 
        public string EmployeeDetails { get; set; }
    }

    public class EmployeeInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

{% endhighlight %}
{% endtabs %}

`Image`

## RadioGroup editor

In the [RadioGroup](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) editor, the [RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) control is loaded.

The `items` for [RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) is generated for `enum` and `List` data type properties. In order to add [RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) editor in the DataForm, you need to register editor as DataFormEditorType.RadioGroup for the required property by using the `RegisterEditor` method.

**Support for enum data type**

For `enum` data type property, [RadioButon](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) `items` will be added based on specified property enum values.

{% tabs %}
{% highlight C# %}

    dataForm.RegisterEditor("Phone", DataFormEditorType.RadioGroup);

    public Numbers Phone  { get; set; }

    public enum Numbers
    {
	    Home,
	    Work,
	    Other
    }

{% endhighlight %}
{% endtabs %}

**Support for List data type**

For `List` data type property, you have to set the `ItemsSource` by using the `IDataFormSourceProvider`, based on that [RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0) `items` will be added.

{% tabs %}
{% highlight C# %}

    dataForm.RegisterEditor("Phone", DataFormEditorType.RadioGroup);
    dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();

    public string Phone  { get; set; }

    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
         public object GetSource(string sourceName)
        {
		    if(sourceName == "Phone")
		    {
                List<string> list = new List<string>() {"Home", "Work", "Other"};
                return list;
		    }
		    return new List<string>();
        }
    }

{% endhighlight %}
{% endtabs %}

`Image`
	
## Custom editor

The custom editor can be added to DataForm by inheriting the `IDataFormEditor` class for business models. You can create custom editor using implement all method in IDataFormEditor. 

To add custom editor in DataForm, register the editor with custom registered type for the required property using `RegisterEditor` method. You can also customize editor settings by using available methods in `IDataFormEditor`. 

#### Creating custom editor using IDataFormEditor 

Views such as labels, buttons, and sliders can be loaded to custom editor. Here, entry is loaded as custom editor for `PhoneNumer` property. 

#### Below methioned example code for Numeric editor which accepts only numbers 

{% tabs %}
{% highlight C# %}

    public class NumericTextEditor : IDataFormEditor 
    { 
        private Syncfusion.Maui.DataForm.SfDataForm dataForm;

        private DataFormCustomItem? dataFormCustomItem;


        public NumericEditor(Syncfusion.Maui.DataForm.SfDataForm dataForm)
        {
            this.dataForm = dataForm;
        }

        public View CreateEditorView(DataFormItem dataFormItem) 
        { 
            Entry inputView = new Entry();
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
… 

    dataForm.RegisterEditor("PhoneNumber", new NumericEditor(dataForm)); 
{% endhighlight %}
{% endtabs %}

If ValidationMode.Manual is used then update EditorValue property once value commit. This value will be used for DataFormValidateFormEventArgs.NewValues on manual validation

Note: If custom validation is required, you can set error and valid messages using SfDataForm.ValidateProperty event.
