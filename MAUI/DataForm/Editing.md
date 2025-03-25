---
layout: post
title: Data handling in .NET MAUI DataForm control | Syncfusion<sup>&reg;</sup>
description: Learn about the commit feature in Syncfusion<sup>&reg;</sup> .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Editing in .NET MAUI DataForm (SfDataForm)

The data form commits the data and user input to update the value in the underlying data object.

## Commit mode

The [CommitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_CommitMode) determines when the value should be committed to the underlying data object to allow users to commit only correct values.

The supported commit modes are as follows:

* LostFocus
* PropertyChanged
* Manual

#### LostFocus

If the commit mode is [LostFocus](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html#Syncfusion_Maui_DataForm_DataFormCommitMode_LostFocus), the value is committed when the editor loses its focus. By default, the DataForm [CommitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_CommitMode) is `LostFocus`.

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

SfDataForm dataForm = new SfDataForm();
this.dataForm.CommitMode = DataFormCommitMode.LostFocus;
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

#### PropertyChanged

If the commit mode is [PropertyChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html#Syncfusion_Maui_DataForm_DataFormCommitMode_PropertyChanged), the value will be committed immediately when it is changed.

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

SfDataForm dataForm = new SfDataForm();
this.dataForm.CommitMode = DataFormCommitMode.PropertyChanged;
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

#### Manual

If the commit mode is [Manual](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html#Syncfusion_Maui_DataForm_DataFormCommitMode_Manual), the value should be committed manually by calling the [SfDataForm.Commit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Commit) method.

{% tabs %}
{% highlight XAML  %}
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

SfDataForm dataForm = new SfDataForm();
this.dataForm.CommitMode = DataFormCommitMode.Manual;
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

The following code commits the value of all the properties in the data object.

{% tabs %}
{% highlight C# %}
this.dataForm.Commit();
{% endhighlight %}
{% endtabs %}

>Note: On manual commit, manual validation will be called to validate the properties before the commit.

>Note: [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/ManualCommit)

## Value converter attribute

To show the original value in a different format or as a different value, use the [DataFormValueConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValueConverterAttribute.html) attribute.

#### Changing original value of the DataForm property value using converter

{% tabs %}
{% highlight C# %}

[DataFormValueConverter(typeof(StringToDateTimeConverter))]
[DataType(DataType.Date)]
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

>Note: [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/ConvertersSample)

## Read only mode

The `DataForm` can be disabled by setting the [IsReadOnly](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_IsReadOnly) property of the data form.

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

SfDataForm dataForm = new SfDataForm();
this.dataForm.IsReadOnly = true;
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

The particular editor can be disabled using attributes and [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event.

#### Using attribute

An editor can be disabled using the [EditableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.editableattribute?view=net-7.0) and [ReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.readonlyattribute?view=net-6.0).

{% tabs %}
{% highlight C# %}

[Editable(false)]
public string Name { get; set; }

[ReadOnly(true)]
public string Password { get; set; }

{% endhighlight %}
{% endtabs %}

#### Using event

An editor can be disabled by setting the [IsReadOnly](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_IsReadOnly) property of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html).

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null)
    {
        if (e.DataFormItem.FieldName == "Salary")
        {
            e.DataFormItem.IsReadOnly = true;
        }
    }
}

{% endhighlight %}
{% endtabs %}