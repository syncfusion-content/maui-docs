---
layout: post
title: Data validation in .NET MAUI DataForm control | Syncfusion
description: Learn about the validation feature in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Validation in .NET MAUI DataForm (SfDataForm)

The data form validates the data and user input to update the correct value in the underlying data object. In invalid data, the error message is shown at the bottom of the editor.

## Built in validations

The supported built in validations are as follows:

#### Data annotations

Validate the data using data annotation attributes.

The String type property is validated using the [Required](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute?view=netframework-4.8) and [StringLength](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.stringlengthattribute?view=netframework-4.8) attributes.

{% tabs %}
{% highlight C# %}

    [Required(AllowEmptyStrings = false, ErrorMessage = "Name should not be empty")]
    [StringLength(15, ErrorMessage = "Name should not exceed 15 characters")]
    public string Name { get; set; }

{% endhighlight %}
{% endtabs %}

#### Date range attribute

Validate the date time value using the date range attribute.

{% tabs %}
{% highlight C# %}

    [DataType(DataType.Date)]
    [DataFormDateRange(MinimumDate = "01/01/2022", MaximumDate = "31/12/2022", ErrorMessage = "Join date is invalid")]
    public DateTime JoinDate { get; set; }

{% endhighlight %}
{% endtabs %}

## Validation mode

The [ValidationMode] determines when the value should be validated.

The supported validation modes are as follows:

* LostFocus
* PropertyChanged
* Manual

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm" 
        ValidationMode="LostFocus">
    </dataForm:SfDataForm>

</ContentPage>

{% endhighlight %}
{% highlight C# %}

this.dataForm.ValidationMode = DataFormValidationMode.LostFocus;

{% endhighlight %}
{% endtabs %}

#### LostFocus

If the validation mode is `LostFocus`, the value will be validated when the editor loses its focus. By default, the `ValidationMode` is `LostFocus`.

#### PropertyChanged

If the validation mode is `PropertyChanged`, the value will be validated immediately when it is changed.

#### Manual

If the validation mode is `Manual`, the value should be validated manually by calling the `SfDataForm.Validate` or `SfDataForm.Validate(new List())` method.

The following code validates the value of all the properties in the data object:

{% tabs %}
{% highlight C# %}

this.dataForm.Validate();

{% endhighlight %}
{% endtabs %}

To validate the specific list of property value, pass the property names as argument.

{% tabs %}
{% highlight C# %}

this.dataForm.Validate(new List<string>() {"FirstName", "Age" });

{% endhighlight %}
{% endtabs %}

Determine whether the data form or property is valid by using the `Validate` method.

{% tabs %}
{% highlight C# %}

        bool isValid = this.dataForm.Validate();

        List<string> propertyNames = new List<string>();
        propertyNames.Add("FirstName");
        bool isPropertyValid = this.dataForm.Validate(propertyNames);

{% endhighlight %}
{% endtabs %}

If the data form or property is valid, `true` will be returned. Or else `false` will be returned.

## Valid message

If the values are correct, show the `ValidMessage` like an error message, the valid message will also be displayed at the bottom of the editor.

{% tabs %}
{% highlight C# %}

    [DataFormDisplayOptions(ValidMessage = "Password strength is good")]
    [Required(ErrorMessage = "Please enter the password")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z\d]{8,}$", ErrorMessage = "A minimum 8-character password should contain a combination of uppercase and lowercase letters.")]
    public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

## Validate the data form

Get the validation details of all the editors of the data form using the `ValidateForm` event of the data form.

N> This event will be raised once after the manual validation call using the `SfDataForm.Validate()` method.

{% tabs %}
{% highlight C# %}

this.dataForm.ValidateForm += this.OnDataFormValidateForm;

    private void OnDataFormValidateForm(object sender, DataFormValidateFormEventArgs e)
    {
        object dataObject = e.DataObject;
        var values = e.NewValues;
        var errorMessage = e.ErrorMessage;
    }

{% endhighlight %}
{% endtabs %}

## Validate the specific editor

The `ValidateProperty` event allows you to validate specific editors in the data form. Set `Isvalid`, `ErrorMessage`, and `ValidMessage` of the `DataFormValidatePropertyEventArgs`.

{% tabs %}
{% highlight C# %}

this.dataForm.ValidateProperty += this.OnDataFormValidateProperty;

    private void OnDataFormValidateProperty(object sender, DataFormValidatePropertyEventArgs e)
    {
        bool isValid = e.IsValid;
        string propertyName = e.PropertyName;
        object newValue = e.NewValue;
        object currentValue = e.CurrentValue;
        string errorMessage = e.ErrorMessage;
        string validMessage = e.ValidMessage;
    }

{% endhighlight %}
{% endtabs %}

## Validation label appearance customization

The data form supports customizing the style of both error and valid message label style easily.

#### Customize error label text style

The `error label style` can be customized by changing the `ErrorLabelTextStyle` property of the `SfDataForm`.

{% tabs %}
{% highlight XAML %}

    <dataForm:SfDataForm
        x:Name="dataForm">
        <dataForm:SfDataForm.ErrorLabelTextStyle>
            <dataForm:DataFormTextStyle FontSize="10" FontAttributes="Italic" TextColor="Violet" FontFamily="Roboto"/>
        </dataForm:SfDataForm.ErrorLabelTextStyle>
    </dataForm:SfDataForm>

{% endhighlight %}
{% endtabs %}

Also, customize the `error label style` for each editor using the `ErrorLabelTextStyle` property of the `DataFormItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

 private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "FirstName")
            {
                e.DataFormItem.ErrorLabelTextStyle = new DataFormTextStyle
                {
                    TextColor = Colors.DarkSeaGreen,
                    FontSize = 8,
                    FontAttributes = FontAttributes.Italic,
                    FontFamily = "Roboto",
                };
            }
        }
}

{% endhighlight %}
{% endtabs %}

#### Customize valid message label text style

The `valid message label style` can be customized by changing the `ValidMessageLabelTextStyle` property of the `SfDataForm`.

{% tabs %}
{% highlight XAML %}

        <dataForm:SfDataForm
        x:Name="dataForm">
        <dataForm:SfDataForm.ValidMessageLabelTextStyle>
            <dataForm:DataFormTextStyle FontSize="10" FontAttributes="Italic" TextColor="Violet" FontFamily="Roboto"/>
        </dataForm:SfDataForm.ValidMessageLabelTextStyle>
    </dataForm:SfDataForm>

{% endhighlight %}
{% endtabs %}

Also, customize the `valid message label style` for each editor using the `ValidMessageLabelTextStyle` property of the `DataFormItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

 private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "FirstName")
            {
                e.DataFormItem.ValidMessageLabelTextStyle = new DataFormTextStyle
                {
                    TextColor = Colors.DarkSeaGreen,
                    FontSize = 8,
                    FontAttributes = FontAttributes.Italic,
                    FontFamily = "Roboto",
                };
            }
        }
}

{% endhighlight %}
{% endtabs %}