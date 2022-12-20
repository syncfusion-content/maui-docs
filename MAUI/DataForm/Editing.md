---
layout: post
title: Data handling in .NET MAUI DataForm control | Syncfusion
description: Learn about the commit feature in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Editing in .NET MAUI DataForm (SfDataForm)

The data form commits the data and user input to update the value in the underlying data object.

## Commit mode

The `CommitMode` determines when the value should be committed to the underlying data object to allow users to commit only correct values.

The supported commit modes are as follows:

* LostFocus
* PropertyChanged
* Manual

#### LostFocus

If the commit mode is `LostFocus`, the value is committed when the editor loses its focus. By default, the DataForm `CommitMode` is `LostFocus`.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        CommitMode="LostFocus">
    </dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}
this.dataForm.CommitMode = DataFormCommitMode.LostFocus;
{% endhighlight %}
{% endtabs %}

#### PropertyChanged

If the commit mode is `PropertyChanged`, the value will be committed immediately when it is changed.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        CommitMode="PropertyChanged">
    </dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}
this.dataForm.CommitMode = DataFormCommitMode.PropertyChanged;
{% endhighlight %}
{% endtabs %}

#### Manual

If the commit mode is `Manual`, the value should be committed manually by calling the `SfDataForm.Commit` method.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
        xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        CommitMode="Manual">
    </dataForm:SfDataForm>

</ContentPage>
{% endhighlight %}
{% highlight C# %}
this.dataForm.CommitMode = DataFormCommitMode.Manual;
{% endhighlight %}
{% endtabs %}

The following code commits the value of all the properties in the data object.

{% tabs %}
{% highlight C# %}
this.dataForm.Commit();
{% endhighlight %}
{% endtabs %}

N> On manual commit, manual validation will be called to validate the properties before the commit.

## Value converter attribute

To show the original value in a different format or as a different value, use the `DataFormValueConverter` attribute.

#### Changing original value of the DataForm property value using converter

{% tabs %}
{% highlight C# %}

    [DataFormValueConverter(typeof(StringToDateTimeConverter))]
    public string DateTime { get; set; }

public class StringToDateTimeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString()))
        {
            return DateTime.Now;
        }
        else
        {
            DateTime dateTime;
            DateTime.TryParse((string)value, out dateTime);
            return dateTime;
        }
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value.ToString();
    }
}

{% endhighlight %}
{% endtabs %}

Here, the editor will display the original value as `DateTime`. While committing, it is converted to a `string` and stored in the data object.

## Read only mode

The `DataForm` can be disabled by setting the `IsReadOnly` property of the data form.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm" 
        IsReadOnly="True">
    </dataForm:SfDataForm>

</ContentPage>
{% endhighlight %}
{% highlight C# %}
this.dataForm.IsReadOnly = true;
{% endhighlight %}
{% endtabs %}

The particular editor can be disabled using attributes and `GenerateDataFormItem` event.

#### Using attribute

An editor can be disabled using the `EditableAttribute` and `ReadOnlyAttribute`.

{% tabs %}
{% highlight C# %}

    [Editable(false)]
    public string Name { get; set; }

    [ReadOnly(true)]
    public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

An editor can be disabled by setting the `IsReadOnly` property of the `DataFormItem`.

{% tabs %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

 private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Salary")
            e.DataFormItem.IsReadOnly = true;
    }
}

{% endhighlight %}
{% endtabs %}