---
layout: post
title: Commit in .NET MAUI DataForm control | Syncfusion
description: Learn here all about the commit feature in Syncfusion .NET MAUI DataForm (SfDataForm) control and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Commit in .NET MAUI DataForm (SfDataForm)

The data form commits the data and user input in order to update the value in the underlying data object.

## Commit mode

The [CommitMode] determines when the value should be committed to the data object.

The supported commit modes are as follows:

* LostFocus
* PropertyChanged
* Manual

#### LostFocus

If the commit mode is LostFocus, the value is committed when the editor lost its focus. By default DataForm [CommitMode] is `LostFocus`.

{% tabs %}
{% highlight xaml %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        CommitMode="LostFocus">
    </dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.dataForm.CommitMode = DataFormCommitMode.LostFocus;
{% endhighlight %}
{% endtabs %}

#### PropertyChanged

If the commit mode is PropertyChanged, the value will be committed immediately when it is changed.

{% tabs %}
{% highlight xaml %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        CommitMode="PropertyChanged">
    </dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.dataForm.CommitMode = DataFormCommitMode.PropertyChanged;
{% endhighlight %}
{% endtabs %}

#### Manual

If the commit mode is Manual, the value should be committed manually by calling the [SfDataForm.Commit] method.

{% tabs %}
{% highlight xaml %}
<ContentPage 
...
        xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        CommitMode="Manual">
    </dataForm:SfDataForm>

</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.dataForm.CommitMode = DataFormCommitMode.Manual;
{% endhighlight %}
{% endtabs %}

The following code commits the value of all the properties in the data object:

{% tabs %}
{% highlight c# %}
this.dataForm.Commit();
{% endhighlight %}
{% endtabs %}

N> On manual commit, manual validation will be called to validate the properties before the commit.

## Value converter attribute

To show the original value in different format or as different value, use the [DataFormValueConverter] attribute.

#### Changing original value of the DataForm property value using converter

{% tabs %}
{% highlight c# %}

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

Here, the editor will display the original value as `DateTime`. While committing, it is converted to `string` and stored in data object.

## Read only mode

DataForm can be disabled by setting the [IsReadOnly] property of the data form.

{% tabs %}
{% highlight xaml %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm" 
        IsReadOnly="True">
    </dataForm:SfDataForm>

</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.dataForm.IsReadOnly = true;
{% endhighlight %}
{% endtabs %}

The particular editor can disabled by setting the [IsReadOnly] property of the [DataFormItem].

{% tabs %}
{% highlight c# %}
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