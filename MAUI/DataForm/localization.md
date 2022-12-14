---
layout: post
title: Localization in .NET MAUI DataForm control | Syncfusion
description: Learn here all about Localization support in Syncfusion .NET MAUI DataForm(SfDataForm) control and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Localization in .NET MAUI DataForm (SfDataForm)

You can localize the DataFormItem [Display] attribute values and validation ([Required] ,[StringLength] ) attributes values by using `ResourceType` display attribute or using the `GenerateDataFormItem` event.

## Localizing data form item display values

Here, the display attributes or data form item display values get localized based on culture from Localization Resource File (.Resx).

#### Using attribute

`ResourceType` [Display] attribute specifies the Resources File (.Resx) which is used to localize the Display attribute of `Name`, `ShortName`, `GroupName` and `Prompt` values.

{% tabs %}
{% highlight C# %}

    [Display(Name = "First Name", ShortName = "Name", GroupName = "Details", Prompt = "Type first name", ResourceType = typeof(DataFormLocalization))]
    public string FirstName { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

You can also localize the DataFormItem `LabelText`, `PlaceHolderText`, `GroupName` in the `GenerateDataFormItem` event of SfDataForm by using the Resources (.Resx) file.

Here, string member of .resx file will be accessed through the class (in resxFilename.Designer.cs) which was auto-generated when .resx file created and static string members get localized using [ResourceManager] based on culture.

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

Here, the validation (`Required`,`StringLength`) attributes or data form error messages get localized based on culture from Localization Resource File (.Resx).

#### Using attribute

The `Required` and `StringLength` attributes error message can be localized using [ErrorMessageResourceType](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute.errormessageresourcetype?redirectedfrom=MSDN&view=net-5.0#System_ComponentModel_DataAnnotations_ValidationAttribute_ErrorMessageResourceType ) and [ErrorMessageResourceName](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute.errormessageresourcetype?redirectedfrom=MSDN&view=net-5.0#System_ComponentModel_DataAnnotations_ValidationAttribute_ErrorMessageResourceType ) properties which are used to get a localized error messages from Localization Resource File (.Resx) based on culture.

{% tabs %}
{% highlight C# %}

    [Required(ErrorMessage = "Value should not be empty", ErrorMessageResourceName = "ErrorMessage", ErrorMessageResourceType = typeof(DataFormLocalization))]
    [StringLength(15, ErrorMessage = "Enter proper name", ErrorMessageResourceName ="ErrorMessageLength", ErrorMessageResourceType =typeof(DataFormLocalization))]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

You can also localize the data form error message in the ` ValidateProperty` event of SfDataForm by using the Resources (.Resx) file.

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


## Localizing DataForm List items

You can also localize DataForm List items (Picker, AutoComplete, RadioGroup, ComoboBox) ItemsSource using `ResourceType` [Display] attribute and [SfDataForm.ItemsSourceProvider]

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

Here, the radio group items source get localized based on culture from Localization Resource File (.Resx).