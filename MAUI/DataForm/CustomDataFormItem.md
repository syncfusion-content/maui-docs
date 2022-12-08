---
layout: post
title: Working with DataForm in Maui DataForm control | Syncfusion
description: Learn here all about Working with DataForm support in Syncfusion Maui DataForm (SfDataForm) control and more.
platform: Maui
control: SfDataForm
documentation: UG
---

## Adding custom DataFormItems

Support has been provided to generate custom DataFormItems for the defined business model using the [Items]`Link` property of the `SfDataForm` class. You need to set the [AutoGenerateItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.DataForm.SfDataForm.html#Syncfusion_XForms_DataForm_SfDataForm_AutoGenerateItems) property to false to restrict the auto generation of DataFormItems. 

{% tabs %}
{% highlight xaml %}
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"
                x:Class="GettingStarted.MainPage">
        <ContentPage.BindingContext>
            <local:ViewModel x:Name="bindingContext"/>
        </ContentPage.BindingContext>

        <ContentPage.Content>
            <dataForm:SfDataForm x:Name="dataForm" DataObject="{Binding Details}"  AutoGenerateItems="false"> 
                <dataForm:SfDataForm.Items> 
                    <dataForm:DataFormTextItem FieldName="Name" /> 
                    <dataForm:DataFormTextItem FieldName="Password" /> 
                    <dataForm:DataFormTextItem FieldName="Address" /> 
                    <dataForm:DataFormAutoCompleteItem FieldName="Countries"  ItemsSource = "{Binding CountryNames}"/> 
                    <dataForm:DataFormDateItem FieldName="BirthTime" /> 
                </dataForm:SfDataForm.Items> 
            </dataForm:SfDataForm>
        </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight MainPage.xaml.cs %}

    ObservableCollection<DataFormViewItem> items = new ObservableCollection<DataFormViewItem>();
    items.Add(new DataFormTextItem() { FieldName = "Name" });
    items.Add(new DataFormPasswordItem() { FieldName = "Password"});
    items.Add(new DataFormMultilineItem() { FieldName = "Address" });
    items.Add(new DataFormAutoCompleteItem() { FieldName = "Countries", ItemsSource = this.GetItemSource("Countries")});
    items.Add(new DataFormTimeItem() { FieldName = "BirthTime"}); 
    dataForm.AutoGenerateItems = false; 
    dataForm.Items = items; 

    public class ViewModel
    {
        private DataFormModel details;
        private IList<string> countryNames;
        public ViewModel()
        {
            details = new DataFormModel();
            countryNames = new List<string>
            {
                "United states",
                "United Kingdom",
                "France",
                "Belgium",
                "Germany"
            };
        }

        public DataFormModel Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public IList<string> CountryNames
        {
            get { return this.countryNames; }
            set { this.countryNames = value; }
        }
    }

    private IList GetItemSource(string sourceName) 
    { 
        var list = new List<string>(); 
        if (sourceName == "Countries") 
        { 
            list.Add("Afghanistan");
            list.Add("Akrotiri");
            list.Add("Albania");
            list.Add("Algeria");
            list.Add("American Samoa");
            list.Add("Andorra");
            list.Add("Angola");
            list.Add("Anguilla");
            list.Add("Antarctica");
            list.Add("Antigua and Barbuda");
        } 
        return list; 
    }
{% endhighlight %}
{% endtabs %}

### Dynamically add custom dataform items
Support has been provided to dynamically add the dataform items to collections using the [Items]`Link` property of `SfDataForm`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.Items.Add(new DataFormComboBoxItem() 
				    { FieldName = "StateName",  
					    ItemsSource = this.GetItemSource("StateName"), 
					    PlaceHolderText = "Select a State" 
				    });
				
    dataForm.Items.Add(new DataFormSwitchItem() 
				    { Name = "Save"  });
{% endhighlight %}
{% endtabs %}

`AddCustomItemsimages`

### Dynamically remove custom dataform items
Support has been provided to dynamically remove the dataform items from collections using the [Items]`Link` property of `SfDataForm`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.Items.RemoveAt(2);

{% endhighlight %}
{% endtabs %}

`images/RemoveCustomItems`

### Dynamically clear custom dataform items
Support has been provided to dynamically clear the dataform items using the [Items] property of `SfDataForm`.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    dataForm.Items.Clear();

{% endhighlight %}
{% endtabs %}

`images/ClearCustomItems`

### Dynamically reset custom dataform items
Support has been provided to reset the dataform items using the [Items] property of `SfDataForm` and we can reset two or more dataform items at a time.

{% tabs %}
{% highlight MainPage.xaml.cs %}

    var item = dataForm.Items[2];
    item = new DataFormTextItem() { FieldName = "Age" };
    dataForm.Items[2] = item;

    var item = dataForm.Items[3];
    item = new DataFormDateItem() { FieldName ="Date Of Birth", RowOrder = 2, ItemsOrderInRow = 1, ColumnSpan = 3 });
    
{% endhighlight %}
{% endtabs %}


### Dynamically add custom dataform group items
Support has been provided to dynamically add custom group items using [Items] property of `SfDataForm`.
{% tabs %}
{% highlight MainPage.xaml.cs %}

    DataFormGroupItem dataFormGroupItem = new DataFormGroupItem();
    dataFormGroupItem.GroupName = "GroupItem";
    dataFormGroupItem.IsExpanded = true;
    dataFormGroupItem.Items = new ObservableCollection<DataFormItem>();

    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "First Name", ItemsOrderInRow = 0 , GroupName = "GroupItem" });
    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Middle Name", ItemsOrderInRow = 1 , GroupName = "GroupItem" });
    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Last Name", ItemsOrderInRow = 2 , GroupName = "GroupItem" });

    dataForm.Items.Add(dataFormGroupItem);
{% endhighlight %}
{% endtabs %}

`images/GroupItems`

