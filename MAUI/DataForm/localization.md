---
layout: post
title: Data localization in .NET MAUI DataForm control | Syncfusion
description: Learn about the data localization support in Syncfusion .NET MAUI DataForm(SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Localization in .NET MAUI DataForm (SfDataForm)

Localization is translating the application resources into different languages for specific cultures. The `SfDataForm` can be localized by adding a `resource` file.

Localize the `DataFormViewItem` [DisplayAttribute](https://help.syncfusion.com/maui/dataform/data-annotations#display-attribute) values and [ValidationAttribute](https://help.syncfusion.com/maui/dataform/data-annotations#validation-attribute) values by using the `ResourceType` property of the attribute or using the `GenerateDataFormItem` event when auto-generate true.

## Setting CurrentUICulture to the application

Application culture can be changed by setting the `CurrentUICulture` in the `App.xaml.cs` file.

{% tabs %}
{% highlight C# tabtitle="App.xaml.cs" %}

using System.Globalization;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
        var culture = new CultureInfo("fr");
        CultureInfo.CurrentUICulture = culture;
    }
}

{% endhighlight %}
{% endtabs %}

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Add Localization resx file in sample level

Follow these steps to localize the `DataForm` based on the `CurrentUICulture` using the `resource` files.

1. Right-click on the `Resources` folder in the application.

    ![addition-of-default-resource-file-of-maui-dataform-into-resources-folder](images/localization/addition-of-default-resource-file-of-maui-dataform-into-resources-folder.png)

2. Click `Add` and then `NewItem`.
3. In the `Add New Item` wizard, select the `Resource File` option and name the filename as `DataFormLocalization.<culture name>.resx.` For example, give the name `DataFormLocalization.fr.resx` for French culture.

    ![shows-the-name-of-resource-file-to-be-added-for-maui-dataform](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-dataform.png)

4. The culture name indicates the name of the language and country.

5. Now, click `Add` to add the resource file in the **Resources** folder.

    ![shows-the-added-resource-file-for-french-language-in-maui-dataform](images/localization/shows-the-added-resource-file-for-french-language-in-maui-dataform.png)

6. Add the Name or Value pair in the Resource Designer of the `DataFormLocalization.fr.resx` file and change its corresponding value to the corresponding culture.
 
    ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-dataform](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-dataform.png)

## Localizing data form display values

Here, the display attributes or data form item display values to get localized based on culture from the Localization Resource File (.Resx).

#### Using attribute

The `ResourceType` property of the [Display](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-7.0) attribute specifies the Resources File (.Resx), which is used to localize the values of the `Name`, `ShortName`, `GroupName`, `Prompt`, and `ItemsSource`.

{% tabs %}
{% highlight C# %}

[Display(Name = "First Name", ShortName = "Name", GroupName = "Details", Prompt = "Type first name", ResourceType = typeof(DataFormLocalization))]
public string FirstName { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

Also, localize the DataFormItem's `LabelText`, `PlaceholderText`, and `GroupName` in the `GenerateDataFormItem` event of the `SfDataForm` by using the Resources (.Resx) file.

Here, the string member of the .resx file will be accessed through the class (in resxFilename.Designer.cs), which will be auto-generated when the .resx file is created, and static string members get localized using the [ResourceManager](https://learn.microsoft.com/en-us/dotnet/api/system.resources.resourcemanager.getstring?view=net-7.0) based on culture.

{% tabs %}
{% highlight C# %}

[Display(Name = "First Name", GroupName = "Details", Prompt = "Type first name")]
public String FirstName { get; set; }

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem?.GroupName == "Details")
    {
        e.DataFormItem.GroupName = DataFormLocalization.GroupName;
    }

    if (e.DataFormItem.LabelText == "First Name")
    {
        e.DataFormItem.LabelText = DataFormLocalization.FirstName;
        e.DataFormItem.PlaceholderText = DataFormLocalization.PlaceHolder;
    }
}

{% endhighlight %}
{% endtabs %}

## Localizing validation error messages

Here, the [ValidationAttribute](https://help.syncfusion.com/maui/dataform/data-annotations#validation-attribute) values or data form error messages get localized based on culture from Localization Resource File (.Resx).

#### Using attribute

The [ValidationAttribute](https://help.syncfusion.com/maui/dataform/data-annotations#validation-attribute) error message can be localized using the [ErrorMessageResourceType](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute.errormessageresourcetype?redirectedfrom=MSDN&view=net-5.0#System_ComponentModel_DataAnnotations_ValidationAttribute_ErrorMessageResourceType ) and [ErrorMessageResourceName](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute.errormessageresourcetype?redirectedfrom=MSDN&view=net-5.0#System_ComponentModel_DataAnnotations_ValidationAttribute_ErrorMessageResourceType )  properties, which are used to get localized error messages from the Localization Resource File (.Resx) based on culture.

{% tabs %}
{% highlight C# %}

[Required(ErrorMessage = "Value should not be empty", ErrorMessageResourceName = "ErrorMessage", ErrorMessageResourceType = typeof(DataFormLocalization))]
[StringLength(15, ErrorMessage = "Enter proper name", ErrorMessageResourceName ="ErrorMessageLength", ErrorMessageResourceType =typeof(DataFormLocalization))]
public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

Also, localize the data form error message and valid message in the `ValidateProperty` event of the `SfDataForm` by using the Resources (.Resx) file.

{% tabs %}
{% highlight C# %}

[DataFormDisplayOptions(ValidMessage = "Text length is enough")]
[Required(ErrorMessage = "Enter proper name")]
[StringLength(15, ErrorMessage = "Enter proper name")]
public string Name { get; set; }

this.dataForm.ValidateProperty += DataForm_ValidateProperty;

private void DataForm_ValidateProperty(object sender, DataFormValidatePropertyEventArgs e)
{
    e.ErrorMessage = DataFormLocalization.ErrorMessage;
    e.ValidMessage = DataFormLocalization.ValidMessage;
}

{% endhighlight %}
{% endtabs %}

## Localizing data form picker editors

Localize DataForm list items (Picker, AutoComplete, RadioGroup, ComoboBox) ItemsSource using the ResourceType property of [Display](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-7.0) attribute.

{% tabs %}
{% highlight C# %}

[Display(ResourceType = typeof(DataFormLocalization))]
public string Gender { get; set; }

this.dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem?.FieldName == "Gender")
    {
        var list = new List<string>();
        list.Add("Male");
        list.Add("Female");
        list.Add("Other");
        (e.DataFormItem as DataFormRadioGroupItem).ItemsSource = list;            
    }
}

{% endhighlight %}
{% endtabs %}

Here, the radio group items source gets localized based on culture from Localization Resource File (.Resx).