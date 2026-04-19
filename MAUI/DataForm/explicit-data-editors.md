---
layout: post
title: Explicit data editors of .NET MAUI DataForm control | Syncfusion
description: Learn about the explicit data editors of Syncfusion<sup>&reg;</sup> .NET MAUI DataForm(SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: Maui
control: SfDataForm
documentation: UG
---
 
# Explicit Data Editors .NET MAUI DataForm (SfDataForm)

## Explicitly create data editors

The data form auto-generates the editors based on the data type. You can explicitly add the data editors by adding [SfDataForm.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) manually, and you need to change the [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) property to false.

N> Use the [FieldName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html#Syncfusion_Maui_DataForm_DataFormItem_FieldName) property to bind the editor to the data object property.
[GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event will not be triggered when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight XAML %}
   
<ContentPage 
            . . . 
            xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
            x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
        <local:DataFormViewModel />
    </ContentPage.BindingContext>

        <ContentPage.Content>
        <dataForm:SfDataForm x:Name="dataForm" DataObject="{Binding ContactDetails}" AutoGenerateItems="false">
        <dataForm:SfDataForm.Items>
                <dataForm:DataFormTextItem FieldName="Name" />
                <dataForm:DataFormTextItem FieldName="Password" />
                <dataForm:DataFormGroupItem Name="Address">
                    <dataForm:DataFormGroupItem.Items>
                        <dataForm:DataFormMultilineItem FieldName="Street"/>
                        <dataForm:DataFormTextItem FieldName="State"/>
                        <dataForm:DataFormTextItem FieldName="ZipCode"/>
                        <dataForm:DataFormAutoCompleteItem FieldName="Country" ItemsSource = "{Binding CountryNames}"/>
                        </dataForm:DataFormGroupItem.Items>
                </dataForm:DataFormGroupItem>
            </dataForm:SfDataForm.Items>
        </dataForm:SfDataForm>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

SfDataForm dataForm = new SfDataForm();
DataFormViewModel contactInfoViewModel = new DataFormViewModel();
dataForm.DataObject = contactInfoViewModel.ContactDetails; 
ObservableCollection<DataFormViewItem> items = new ObservableCollection<DataFormViewItem>(); 
items.Add(new DataFormTextItem() { FieldName = "Name" }); 
items.Add(new DataFormPasswordItem() { FieldName = "Password" }); 
items.Add(new DataFormMultilineItem() { FieldName = "Address" }); 
DataFormGroupItem groupItem = new DataFormGroupItem();
groupItem.Name = "Address";
groupItem.Items.Add(new DataFormMultilineItem { FieldName = "Street" });
groupItem.Items.Add(new DataFormTextItem { FieldName = "State" });
groupItem.Items.Add(new DataFormTextItem { FieldName = "ZipCode" });
groupItem.Items.Add(new DataFormAutoCompleteItem { FieldName = "Country", ItemsSource = contactInfoViewModel.CountryNames }); 
items.Add(groupItem);

dataForm.AutoGenerateItems = false; 
dataForm.Items = items;
this.Content = dataForm;

{% endhighlight %}   
{% endtabs %} 

{% tabs %}
{% highlight c# tabtitle="DataFormViewModel.cs" %}

public class DataFormViewModel
{
    public DataFormViewModel()
    {
        this.ContactDetails = new ContactInfo();
        this.CountryNames = new List<string>
        {
             "United States",
            "United Kingdom",
            "France",
            "Belgium",
            "Germany"
        };
    }

    public ContactInfo ContactDetails { get; set; }

    public IList<string> CountryNames { get; set; }
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ContactInfo.cs" %}

public class ContactInfo
{
    public string Name { get; set; }

    public string Password { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Country { get; set; }

    public string Email { get; set; }
}

{% endhighlight %}
{% endtabs %}

#### Explicitly add data editor

You can dynamically add the data editor manually by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of the [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.Add(new DataFormTextItem() { FieldName = "State" });
this.dataForm.Items.Add(new DataFormTextItem() {FieldName = "Country" });

{% endhighlight %}
{% endtabs %}

#### Explicitly remove data editor
You can dynamically remove the data editor explicitly by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of the [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.RemoveAt(2);

{% endhighlight %}
{% endtabs %}

#### Explicitly clear data editors
You can dynamically clear all the item views from the [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

this.dataForm.Items.Clear();

{% endhighlight %}
{% endtabs %}

#### Explicitly replace data editor
You can replace the data editor with a new editor by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of the [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

DataFormTextItem textItem = new DataFormTextItem() { FieldName = "Age" };
this.dataForm.Items[2] = textItem;
    
DataFormDateItem dateItem = new DataFormDateItem() { FieldName ="Date Of Birth", RowOrder = 2, ItemsOrderInRow = 1, ColumnSpan = 3 });

this.dataForm.Items[3] = dateItem;
    
{% endhighlight %}
{% endtabs %}

#### Explicitly add group editor
You can dynamically add custom group editor by using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items) property of [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) when [AutoGenerateItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems) is false.

{% tabs %}
{% highlight C# %}

DataFormGroupItem dataFormGroupItem = new DataFormGroupItem();
dataFormGroupItem.Name = "Name";
dataFormGroupItem.Items = new ObservableCollection<DataFormItem>();

dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "First Name" });
dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Middle Name" });
dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Last Name" });

this.dataForm.Items.Add(dataFormGroupItem);
    
{% endhighlight %}
{% endtabs %}

#### Explicitly add custom editor

You can add custom editor manually by adding the custom view as an [EditorView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCustomItem.html#Syncfusion_Maui_DataForm_DataFormCustomItem_EditorView) of [DataFormCustomItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCustomItem.html).In this case, the editor view will not be generated based on the field type and the [RegisterEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_DataFormEditorType_).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<dataForm:SfDataForm x:Name="contactForm"
                    DataObject="{Binding ContactFormModel}" AutoGenerateItems = "False">
                
            <dataForm:SfDataForm.Items>
                <dataForm:DataFormCustomItem FieldName="ProfileImage" ShowLabel="False">
                    <dataForm:DataFormCustomItem.EditorView>
                        <Image Source="ContactImage.png"
                                   HeightRequest="80"/>
                        </dataForm:DataFormCustomItem.EditorView>
                </dataForm:DataFormCustomItem>
            </dataForm:SfDataForm.Items>
</dataForm:SfDataForm>

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/ExplicitDataFormItems)

## Explicitly create data editors from custom data dictionary

You can [explicitly](https://help.syncfusion.com/maui/dataform/dataform-settings#explicitly-create-data-editors) add the data editors from the custom data dictionary and also get the value from the dictionary and set the editors value to the dictionary by implementing [DataFormItemManager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItemManager.html), which has the methods to get and set values for the editors.

{% tabs %}
{% highlight C# %}

Dictionary<string, object> dictionary = new Dictionary<string, object>();
dictionary.Add("Name", "John");
dictionary.Add("Password", "1234");

ObservableCollection<DataFormViewItem> items = new ObservableCollection<DataFormViewItem>();
foreach (var key in dictionary.Keys)
{
    DataFormItem dataFormItem = null;
    if (key == "Name")
    {
        dataFormItem = new DataFormTextItem()
        {
            FieldName = key,
            LayoutType = DataFormLayoutType.TextInputLayout,
        };
    }
    else if (key == "Password")
    {
        dataFormItem = new DataFormPasswordItem()
        {
            FieldName = key,
            EditorTextStyle = new DataFormTextStyle { TextColor = Colors.Violet },
        };
    }

    if (dataFormItem != null)
    {
        items.Add(dataFormItem);
    }
}

dataForm.Items = items;
dataForm.AutoGenerateItems = false;
dataForm.ItemManager = new DataFormItemManagerExt(dictionary);

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="DataFormItemManagerExt" %}

public class DataFormItemManagerExt : DataFormItemManager
{
    Dictionary<string, object> dataFormDictionary;

    public DataFormItemManagerExt(Dictionary<string, object> dictionary)
    {
        dataFormDictionary = dictionary;
    }

    public override object GetValue(DataFormItem dataFormItem)
    {
        return dataFormDictionary[dataFormItem.FieldName];
    }

    public override void SetValue(DataFormItem dataFormItem, object value)
    {
        dataFormDictionary[dataFormItem.FieldName] = value;
    }
}

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-dataform/tree/master/CustomDataDictionarySample)