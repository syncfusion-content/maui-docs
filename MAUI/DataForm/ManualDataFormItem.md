---
layout: post
title: Manually create view items in .NET MAUI DataForm control | Syncfusion
description: Learn about the working with manually created DataFormViewItems in Syncfusion .NET MAUI DataForm(SfDataForm) control in mobile and desktop applications.
platform: Maui
control: SfDataForm
documentation: UG
---

# Working with manually created DataForm Items

You can manually create `DataFormViewItem` for the defined business model by using the `Items` property of the `SfDataForm` class. You should set the `AutoGenerateItems` property to false to restrict the auto-generation of `SfDataForm.Items`. 

{% tabs %}
{% highlight xaml %}
   
    <ContentPage 
    . . . 
                xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
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
{% highlight C# %}

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

{% endhighlight}   
{% endtabs %} 

{% endhighlight %}
{% highlight C# %}

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

{% endhighlight %}
{% highlight C# %}

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

## Dynamically add DataForm items
You can dynamically add the items using `Items` property of `SfDataForm`.
{% tabs %}
{% highlight C# %}

    dataForm.Items.Add(new DataFormTextItem() { FieldName = "State" });
    dataForm.Items.Add(new DataFormTextItem() {FieldName = "Country" });

{% endhighlight %}
{% endtabs %}


## Dynamically remove manually added dataform items
You can dynamically remove the `DataFormViewItem` from the `Items` property of `SfDataForm`.

{% tabs %}
{% highlight C# %}

    dataForm.Items.RemoveAt(2);

{% endhighlight %}
{% endtabs %}


## Dynamically clear manually added dataform items
You can dynamically clear all the item views from `SfDataForm`.

{% tabs %}
{% highlight C# %}

    dataForm.Items.Clear();

{% endhighlight %}
{% endtabs %}


## Dynamically reset manual dataform items
You can reset the `SfDataForm.Items` and we can reset two or more items at a time.

{% tabs %}
{% highlight C# %}

    DataFormTextItem textItem = new DataFormTextItem() { FieldName = "Age" };
    dataForm.Items[2] = textItem;
    
    
    DataFormDateItem dateItem = new DataFormDateItem() { FieldName ="Date Of Birth", RowOrder = 2, ItemsOrderInRow = 1, ColumnSpan = 3 });

    dataForm.Items[3] = dateItem;
    
{% endhighlight %}
{% endtabs %}


## Dynamically add Dataform group items
You can dynamically add custom group items using `Items` property of `SfDataForm`.
{% tabs %}
{% highlight C# %}

    DataFormGroupItem dataFormGroupItem = new DataFormGroupItem();
    dataFormGroupItem.Name = "Name";
    dataFormGroupItem.Items = new ObservableCollection<DataFormItem>();

    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "First Name" });
    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Middle Name" });
    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Last Name" });

    dataForm.Items.Add(dataFormGroupItem);
    
{% endhighlight %}
{% endtabs %}


#### Adding custom editor view using Manual DataFormItem

You can directly set a custom view as an `EditorView` of `DataFormCustomItem`. In this case, the editor view will not be generated based on field type and `RegistorEditor`.
{% tabs %}
{% highlight XAML %}

    <dataForm:SfDataForm x:Name="contactForm"
                                         DataObject="{Binding ContactFormModel}">
                
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

