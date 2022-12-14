---
layout: post
title: Getting Started with .NET MAUI DataForm control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI DataForm (SfDataForm) control.
platform: Maui
control: SfDataForm
documentation: ug
---

# Getting Started with .NET MAUI DataForm (SfDataForm)

This section provides a quick overview of how to get started with the .NET MAUI DataForm(SfDataForm) for .NET MAUI and also provides a walk-through to configure the .NET MAUI DataForm control in a real-time scenario.

## Creating an application using the .NET MAUI DataForm

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfDataForm to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.DataForm](https://www.nuget.org/packages/Syncfusion.Maui.DataForm) and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.DataForm` in XAML or C# code.

4. Initialize `SfDataForm.`


{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

    <ContentPage   
            
            xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm" >

            <dataForm:SfDataForm />
    </ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

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

#### Creating data object

The `SfDataForm` is a data edit control so, create a data object with details to create a data form based on your business requirement.

Here, the data object named **ContactsInfo** created with some properties.

{% tabs %}
{% highlight C# %}


    public class ContactsInfo
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

Initialize the data object in view model class in order to bind in 'DataObject' property of 'SfDataForm'.

{% tabs %}
{% highlight C# %}

    public class DataFormViewModel
    {
        public ContactsInfo ContactsInfo {get; set;}
        
        public DataFormViewModel()
        {
            this.ContactsInfo = new ContactsInfo();
        }
    }

{% endhighlight %}
{% endtabs %}

## Set data object to data form

By default, data form auto generate the editors based on the primitive data type in the 'DataObject' property. Please refer the following code to set the 'DataObject' property.

{% tabs %}
{% highlight XAML %}

    <ContentPage 
        . . .
                xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
                x:Class="GettingStarted.MainPage">

                    <ContentPage.BindingContext>
                        <local:DataFormViewModel/>
                    </ContentPage.BindingContext>    
	                        <dataForm:SfDataForm x:Name="dataForm" 
						    DataObject="{Binding ContactsInfo}"/>    
    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    dataForm.DataObject = new ContactsInfo();

{% endhighlight %}
{% endtabs %}

`Image`

## Defining editors

The data form control automatically generates `DataFormItems` (which has UI settings of data field) based on the data type in the `SfDataForm.DataObject` property. The `SfDataForm.Items` encapsulates the layout of label and editor setting for the data field appearing in the dataform. 

The type of input editor generated for the data field depends on the type and attribute settings of the property. The following table lists the `DataFormItem` and its constraints for generation:

<table>
<tr>
<th>Generated DataFormItem Type</th>
<th>Data Type / Attribute</th>
<th>Editor</th>
<th>Input Control</th>
</tr>
<tr>
<td>
{{'[DataFormTextItem]
`Link`
</td>
<td>
Default DataFormItem generated for the String type and the properties with [DataType(DataType.Text)].
</td>
<td>
Text
</td>
<td>
Entry
</td>
</tr>
<tr>
<td>
{{'[DataFormMultilineTextItem]
`Link`
</td>
<td>
Generated for string type property with [DataType(DataType.MultilineText)] attributes.
</td>
<td>
Multiline Text
</td>
<td>
Editor
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
<td>
Password
</td>
<td>
Entry
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
<td>
CheckBox
</td>
<td>
CheckBox
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
<td>
Switch
</td>
<td>
Switch
</td>
</tr>
<tr>
<td>
{{'[DataFormDateItem] `Link`
</td>
<td>
Generated for the DateTime, DateOnly, DateTimeOffset type properties.
[DataType(DataType.Date)].
[DataType(DataType.DateTime)].
</td>
<td>
DatePiker
</td>
<td>
DatePicker
</td>
</tr>
<tr>
<td>
{{'[DataFormTimeItem]
`Link`
</td>
<td>
Generated for the TimeSpan, TimeOnly, DateTime, DateTimeOffset type properties.
[DataType(DataType.Time)].
</td>
<td>
TimePicker
</td>
<td>
TimePicker
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
<td>
Picker
</td>
<td>
Picker
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
<td>
AutoComplete
</td>
<td>
SfAutoComplete
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
<td>
ComboBox
</td>
<td>
SfComboBox
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
<td>
RadioGroup
</td>
<td>
RadioButton
</td>
</tr>
</table>

#### Label position

By default, the data form arranges the label at left side and input control at the right side. You can change the label position by setting the `SfDataForm.DefaultLayoutSettings.LabelPosition` property. You can position the label from left to top of the input control by setting the `LabelPosition` as Top.

{% tabs %}
{% highlight XAML %}

    <dataForm:SfDataForm x:Name="dataForm" >
            <dataForm:SfDataForm.DefaultLayoutSettings>
                <dataForm:DataFormDefaultLayoutSettings LabelPosition="Top"/>
            </dataForm:SfDataForm.DefaultLayoutSettings>
    </dataForm:SfDataForm>

{% endhighlight %}
{% highlight C# %}

    dataForm.DefaultLayoutSettings.LabelPosition = LabelPosition.Top;

{% endhighlight %}
{% endtabs %}

`Label Positioning images`


## Editing

By default, the data form enables editing of the data field. You can disable editing by setting the `IsReadOnly` property of the data form. You can enable or disable editing for a particular data field by setting the `IsReadOnly` property of `DataFormItem` in the `GenerateDataFormItem` event. The data field editing behavior can also be defined by using [EditableAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.editableattribute?view=netframework-4.8Dip)