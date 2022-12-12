---
layout: post
title: Getting Started with Maui DataForm control | Syncfusion
description: Learn here about getting started with Syncfusion Maui DataForm (SfDataForm) control, its elements and more.
platform: Maui
control: SfDataForm
documentation: ug
---

# Getting Started with Maui DataForm (SfDataForm)

This section provides a quick overview of how to get started with the .NET Maui DataForm(SfDataForm) for Maui and also provides a walk-through to configure the .NET MAUI DataForm control in a real-time scenario.

## Creating an application using the .NET MAUI DataForm

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfDataForm to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.DataForm](https://www.nuget.org/packages/Syncfusion.Maui.DataForm) and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.DataForm` in XAML or C# code.

4. Initialize `SfDataForm.`


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

    <ContentPage   
            
            xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm" >

            <dataForm:SfDataForm />
    </ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

    using Syncfusion.Maui.DataForm;
    . . .

    public partial class MainPage : ContentPage
    {
        public MainPage()
    {
        InitializeComponent();
        SfDataForm dataForm = new SfDataForm();
        this.Content = dataForm;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

    
    using Syncfusion.Maui.Core.Hosting;

    public static class MauiProgram
    {
	    public static MauiApp CreateMauiApp()
	    {
	        var builder = MauiApp.CreateBuilder();
		    builder
			    .ConfigureSyncfusionCore()
			    .UseMauiApp<App>()
			    .ConfigureFonts(fonts =>
			    {
				    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			    });

		    return builder.Build();
	    }
    }

{% endhighlight %}
{% endtabs %}

### Creating data object

The `SfDataForm` is a data edit control so, create a data object to edit the data object.

Here, the data object named **DataModel** created with some properties.

{% tabs %}
{% highlight MainPage.xaml.cs %}


    public class DataModel
    {
        public string FirstName { get; set; }
    
        public string MiddleName { get; set; }
    
        public string LastName { get; set; }
    
        public string ContactNumber { get; set; }
    
        public string Email { get; set; }
   
        public string Address { get; set; }

        public DateTime? BirthDate { get; set; }
    
        public string GroupName { get; set; }

    }

{% endhighlight %}
{% endtabs %}

Create a model repository class with DataModel property initialized with required data in a new class file as shown in the following code example and save it ViewModel.cs file:

{% tabs %}
{% highlight MainPage.xaml.cs %}

    public class ViewModel
    {
        public DataModel DataModel {get; set;}
        
        public ViewModel()
        {
            this.DataModel = new DataModel();
        }
    }

{% endhighlight %}
{% endtabs %}

## Setting data object

To populate the labels and editors in the data form, set the `DataObject` property.

{% tabs %}
{% highlight MainPage.xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
                x:Class="GettingStarted.MainPage">

                    <ContentPage.BindingContext>
                        <local:ViewModel/>
                    </ContentPage.BindingContext>    
	                        <dataForm:SfDataForm x:Name="dataForm" 
						    DataObject="{Binding DataModel}"/>    
    </ContentPage>

{% endhighlight %}
{% highlight MainPage.xaml.cs %}

    dataForm.DataObject = new DataModel();

{% endhighlight %}
{% endtabs %}

Now, run the application to render the `data form` to edit the data object as in the following screenshot:

`Image`

## Defining editors

The data form control automatically generates `DataFormItems` (which has UI settings of data field) when the data object set to the `SfDataForm.DataObject` property. The `DataFormItem` encapsulates the layout and editor setting for the data field appearing in the data form. When the `DataFormItems` are generated, you can handle the SfDataForm.GenerateDataFormItem event to customize or cancel the `DataFormItem`. 

The type of input editor generated for the data field depends on the type and attribute settings of the property. The following table lists the `DataFormItem` and its constraints for generation:

<table>
<tr>
<th>Generated DataFormItem Type</th>
<th>Data Type / Attribute</th>
</tr>
<tr>
<td>
{{'[DataFormTextItem]
`Link`
</td>
<td>
Default DataFormItem generated for the String type and the properties with [DataType(DataType.Text)].
</td>
</tr>
<tr>
<td>
{{'[DataFormMultiLineTextItem]
`Link`
</td>
<td>
Generated for string type property with [DataType(DataType.MultilineText)] attributes.
</td>
</tr>
<tr>
<td>
{{'[DataFormPasswordTextItem]
`Link`
</td>
<td>
Generated for string type property with [DataType(DataType.Password)] attributes.
</td>
</tr>
<tr>
<td>
{{'[DataFormCheckBoxItem]`Link`
</td>
<td>
Generated for the Bool type property.
[BoolDataTypeAttribute]
</td>
</tr>
<tr>
<td>
{{'[DataFormSwitchItem] `Link`
</td>
<td>
Generated for the Bool type property.
[BoolDataTypeAttribute]
</td>
</tr>

<tr>
<td>
{{'[DataFormDateItem] `Link`
</td>
<td>
Generated for the DateTime, DateOnly, DateTimeOffset type property.
[DataType(DataType.Date)].
[DataType(DataType.DateTime)].
</td>
</tr>
<tr>
<td>
{{'[DataFormTimeItem]
`Link`
</td>
<td>
Generated for the TimeSpan, TimeOnly  type property.
[DataType(DataType.Time)].
</td>
</tr>
<tr>
<td>
{{'[DataFormPickerItem] `Link`
</td>
<td>
Generated for the Enum type property.
[EnumDataTypeAttribute]
</td>
</tr>

<tr>
<td>
{{'[DataFormAutoCompleteItem]`Link`
</td>
<td>
Generated for the Enum type property.
[EnumDataTypeAttribute]
</td>
</tr>
<tr>
<td>
{{'[DataFormComboBoxItem]`Link`
</td>
<td>
Generated for the Enum type property.
[EnumDataTypeAttribute]
</td>
</tr>
<tr>
<td>
{{'[DataFormRadioGroupItem]`Link`
</td>
<td>
Generated for the Enum type property.
[EnumDataTypeAttribute]
</td>
</tr>
</table>

The following list of editors are supported:

<table>
<tr>
<th>Editor</th>
<th>Data Type/Attribute</th>
<th>Input control loaded</th>
</tr>
<tr>
<td>
Text
</td>
<td>
The String type property and any other type apart from the following specified cases.
</td>
<td>
{{'[Entry]`Link`
</td>
</tr>
<tr>
<td>
MultilineText
</td>
<td>
The String type property with multi line text.
[DataType(DataType.Multiline)] 
</td>
<td>
{{'[Editor]`Link`
</td>
</tr>
<tr>
<td>
Password
</td>
<td>
The String type property with [DataType(DataType.Password)] attribute.
</td>
<td>
{{'[Entry]`Link`
</td>
</tr>
<tr>
<td>
CheckBox
</td>
<td>
Bool type property.
</td>
<td>
{{'[CheckBox]`Link`
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
{{'[Switch] `Link`
</td>
</tr>
<tr>
<td>
Picker
</td>
<td>
Enum and List type property. 
[EnumDataTypeAttribute]
</td>
<td>
{{'[Picker]`Link`
</td>
</tr>
<tr>
<td>
DatePicker
</td>
<td>
The DateTime type property with date value.
[DataType(DataType.Date)]
[DataType(DataType.DateTime)]
</td>
<td>
{{'[DatePicker]`Link`
</td>
</tr>
<tr>
<td>
TimePicker
</td>
<td>
Property with [DataType(DataType.Time)] attribute.
</td>
<td>
{{'[TimePicker]`Link`
</td>
</tr>
<tr>
<td>
ComboBox
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfComboBox]`Link`
</td>
</tr>
<tr>
<td>
AutoComplete
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[SfAutoComplete]`Link`
</td>
</tr>

<tr>
<td>
RadioGroup
</td>
<td>
Enum and List type property.
[EnumDataTypeAttribute]
</td>
<td>
{{'[RadioButton]`Link`
</td>
</tr>
</table>

## Layout options

### Label position

By default, the data form arranges the label at left side and input control at the right side. You can change the label position by setting the `SfDataForm.DefaultLayoutSettings.LabelPosition` property. You can position the label from left to top of the input control by setting the `LabelPosition` as Top.

{% tabs %}
{% highlight MainPage.xaml %}

    <dataForm:SfDataForm x:Name="dataForm" >
            <dataForm:SfDataForm.DefaultLayoutSettings>
                <dataForm:DataFormDefaultLayoutSettings LabelPosition="Top"/>
            </dataForm:SfDataForm.DefaultLayoutSettings>
    </dataForm:SfDataForm>

{% endhighlight %}
{% highlight MainPage.xaml.cs %}

    dataForm.DefaultLayoutSettings.LabelPosition = LabelPosition.Top;

{% endhighlight %}
{% endtabs %}

`Label Positioning images`

### Grid layout

By default, the data form arranges one data field per row. It is possible to have more than one data field per row by setting the `ColumnCount` property which provides grid like layout for the data form.

[ItemsOrderInRow]`Link` property is applicable to only when the ColumnCount is greater than 1. The items on the data form are arranged in layout rows. Use the RowOrder property to specify the number of the layout row where the item should be displayed.

{% tabs %}
{% highlight MainPage.xaml %}

    <dataForm:SfDataForm ColumnCount="2"/>

{% endhighlight %}
{% highlight MainPage.xaml.cs %}

    dataForm.ColumnCount = 2;

{% endhighlight %}
{% endtabs %}

`ColumnCount Image `

## Editing

By default, the data form enables editing of the data field. You can disable editing by setting the `IsReadOnly` property of the data form. You can enable or disable editing for a particular data field by setting the `IsReadOnly` property of `DataFormItem` in the `GenerateDataFormItem` event. The data field editing behavior can also be defined by using [EditableAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.editableattribute?view=netframework-4.8Dip)