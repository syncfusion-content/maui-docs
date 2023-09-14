---
layout: post
title: Getting Started with .NET MAUI DataForm control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Getting Started with .NET MAUI DataForm (SfDataForm)

This section provides a quick overview of how to get started with the [.NET MAUI DataForm(SfDataForm)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.html) for .NET MAUI and a walk-through to configure the .NET MAUI DataForm control in a real-time scenario.

## Creating an application using the .NET MAUI DataForm

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add the SfDataForm to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.DataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.html), then install it.

3. To initialize the control, import the control namespace [Syncfusion.Maui.DataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.html) in XAML or C# code.

4. Initialize [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html).


{% tabs %}
{% highlight XAML %}

<ContentPage   
            
        xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">

        <dataForm:SfDataForm />
</ContentPage>

{% endhighlight %}
{% highlight C# %}

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

The [Syncfusion.Maui.Core](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.html) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

    
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

## Creating data object

The [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) is a data edit control, so create a data object with details to create a data form based on your business requirement.

Here, the data object named **ContactsInfo** is created with some properties.

{% tabs %}
{% highlight c# tabtitle="ContactsInfo.cs" %}

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

Initialize the data object in view model class to bind in the [DataObject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject) property of [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html).

{% tabs %}
{% highlight c# tabtitle="DataFormViewModel.cs" %}

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

By default, the data form auto-generates the editors based on the primitive data type in the [DataObject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject) property. Please refer the following code to set the [DataObject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject) property.

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

this.BindingContext = new DataFormViewModel();
SfDataForm dataForm = new SfDataForm()
{
    DataObject = new ContactsInfo()
};
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/GettingStarted)

## Defining editors

The data form control automatically generates the [SfDataForm.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemsProperty) (which has UI settings of data field) based on the data type in the [SfDataForm.DataObject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObjectProperty) property. The [SfDataForm.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemsProperty) summarizes the layout of the label and editor setting for the data field appearing in the dataform. 

The type of input editor generated for the data field depends on the type and attribute settings of the property. The following table lists the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) and its constraints for generation.

<table>
<tr>
<th>Generated DataFormItem Type</th>
<th>Data Type / Attribute</th>
<th>Editor</th>
<th>Input Control</th>
</tr>
<tr>
<td>
{{'[DataFormTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextItem.html)'| markdownify }}
</td>
<td>
Default DataFormItem generated for the String type and the properties with [DataType(DataType.Text)] attributes.
</td>
<td>
Text
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormMultilineTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMultilineItem.html)'| markdownify }}
</td>
<td>
Generated for string type property with [DataType(DataType.MultilineText)] attribute.
</td>
<td>
Multiline Text
</td>
<td>
{{'[Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormPasswordTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormPasswordItem.html)'| markdownify }}
</td>
<td>
Generated for string type property with [DataType(DataType.Password)] attribute.
</td>
<td>
Password
</td>
<td>
{{'[Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormNumericItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormNumericItem.html)'| markdownify }}
</td>
<td>
Generated for int, double, float type properties.
</td>
<td>
Numeric
</td>
<td>
{{'[SfNumericEntry](https://help.syncfusion.com/maui/numericentry/overview)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormMaskedTextItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormMaskedTextItem.html)'| markdownify }}
</td>
<td>
Generated for string type property with [DataType(DataType.PhoneNumber)] and [DataType(DataType.CreditCard)] attribute.
</td>
<td>
MaskedText
</td>
<td>
{{'[SfMaskedEntry](https://help.syncfusion.com/maui/masked-entry/overview)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormCheckBoxItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCheckBoxItem.html)'| markdownify }}
</td>
<td>
Generated for the Bool type property.
</td>
<td>
CheckBox
</td>
<td>
{{'[CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormSwitchItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormSwitchItem.html)'| markdownify }} 
</td>
<td>
Generated for the Bool type property.
</td>
<td>
Switch
</td>
<td>
{{'[Switch](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormDateItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDateItem.html)'| markdownify }} 
</td>
<td>
Generated for the DateTime, DateOnly, DateTimeOffset type properties and the properties with
[DataType(DataType.Date)] or
[DataType(DataType.DateTime)] attributes.
</td>
<td>
Date
</td>
<td>
{{'[DatePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/datepicker?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormTimeItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTimeItem.html)'| markdownify }}
</td>
<td>
Generated for the TimeSpan and TimeOnly type properties and the properties with [DataType(DataType.Time)] attribute.
</td>
<td>
Time
</td>
<td>
{{'[TimePicker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/timepicker?view=net-maui-7.0&tabs=windows)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormPickerItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormPickerItem.html)'| markdownify }}
</td>
<td>
Generated for the Enum type property.
</td>
<td>
Picker
</td>
<td>
{{'[Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormAutoCompleteItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormAutoCompleteItem.html)'| markdownify }}
</td>
<td>
Generated for the Enum type property.
</td>
<td>
AutoComplete
</td>
<td>
{{'[SfAutoComplete](https://help.syncfusion.com/maui/autocomplete/overview)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormComboBoxItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormComboBoxItem.html)'| markdownify }}
</td>
<td>
Generated for the Enum type property.
</td>
<td>
ComboBox
</td>
<td>
{{'[SfComboBox](https://help.syncfusion.com/maui/combobox/overview)'| markdownify }}
</td>
</tr>
<tr>
<td>
{{'[DataFormRadioGroupItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormRadioGroupItem.html)'| markdownify }}
</td>
<td>
Generated for the Enum type property.
</td>
<td>
RadioGroup
</td>
<td>
{{'[RadioButton](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0)'| markdownify }}
</td>
</tr>
</table>
