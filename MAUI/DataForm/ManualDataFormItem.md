---
layout: post
title: Manually create DataFormItems in Maui DataForm control | Syncfusion
description: Learn here all about working with manually created DataFormViewItems in Syncfusion . NET MAUI DataForm(SfDataForm) control.
platform: Maui
control: SfDataForm
documentation: UG
---

# Working DataForm Items Manually

You can manually create [DataFormViewItem] for the defined business model by using the [Items] property of the `SfDataForm` class. You should set the [AutoGenerateItems] property to false to restrict the auto-generation of [SfDataForm.Items]. 

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
            <dataForm:SfDataForm x:Name="dataForm" DataObject="{Binding ContactDetails}"  AutoGenerateItems="false"> 
                <dataForm:SfDataForm.Items> 
                    <dataForm:DataFormTextItem FieldName="Name" /> 
                    <dataForm:DataFormTextItem FieldName="Password" /> 
                    <dataForm:DataFormTextItem FieldName="Address" /> 
                    <dataForm:DataFormAutoCompleteItem FieldName="Country"  ItemsSource = "{Binding CountryNames}"/> 
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
    items.Add(new DataFormAutoCompleteItem() { FieldName = "Country", ItemsSource = contactInfoViewModel.CountryNames }); 
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

        public string Address { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }
    }

{% endhighlight %}

### Adding DataForm group manually
You can also generate [DataFormGroupItem] manually using the [Items] property of `SfDataForm`.

{% tabs %}
{% highlight XAML %}
    <dataForm:SfDataForm.Items>
            <dataForm:DataFormGroupItem Name="Address">
                    <dataForm:DataFormGroupItem.Items>
                        <dataForm:DataFormMultilineItem FieldName="Address"/>
                        <dataForm:DataFormTextItem FieldName="State"/>
                        <dataForm:DataFormTextItem FieldName="ZipCode"/>
                    </dataForm:DataFormGroupItem.Items>
        </dataForm:DataFormGroupItem>
    </dataForm:SfDataForm.Items>
    

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

    DataFormGroupItem groupItem = new DataFormGroupItem();
        groupItem.Name = "Address";
        groupItem.Items.Add(new DataFormMultilineItem { FieldName = "Address" });
        groupItem.Items.Add(new DataFormMultilineItem { FieldName = "State" });
        groupItem.Items.Add(new DataFormMultilineItem { FieldName = "ZipCode" });
        this.dataForm.Items.Add(groupItem);

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

    public class DataFormModel
    {
        public string Name { get; set; }
        public int Phone { get; set; }
    }


    public class DataFormViewModel
    {
        public DataFormViewModel
        {
            this.DataFormModel = new DataFormModel();
        }

        public DataFormModel DataFormModel { get; set; }
        
    }
{% endhighlight %}
{% endtabs %}

`AddCustomItemsimages`

### Dynamically remove manually added dataform items
You can dynamically remove the dataform items from collections using the [Items]`Link` property of `SfDataForm`.

{% tabs %}
{% highlight C# %}

    dataForm.Items.RemoveAt(2);

{% endhighlight %}
{% endtabs %}

`images/RemoveCustomItems`

### Dynamically clear manually added dataform items
You can dynamically clear the dataform items using the [Items] property of `SfDataForm`.

{% tabs %}
{% highlight C# %}

    dataForm.Items.Clear();

{% endhighlight %}
{% endtabs %}

`images/ClearCustomItems`

### Dynamically reset manual dataform items
You can reset the dataform items using the [Items] property of `SfDataForm` and we can reset two or more dataform items at a time.

{% tabs %}
{% highlight C# %}

    DataFormTextItem textItem = new DataFormTextItem() { FieldName = "Age" };
    dataForm.Items[2] = textItem;
    
    
    DataFormDateItem dateItem = new DataFormDateItem() { FieldName ="Date Of Birth", RowOrder = 2, ItemsOrderInRow = 1, ColumnSpan = 3 });

    dataForm.Items[3] = dateItem;
    
{% endhighlight %}
{% endtabs %}


### Dynamically add Dataform group items
You can dynamically add custom group items using [Items] property of `SfDataForm`.
{% tabs %}
{% highlight C# %}

    DataFormGroupItem dataFormGroupItem = new DataFormGroupItem();
    dataFormGroupItem.Name = "GroupItem";
    dataFormGroupItem.IsExpanded = true;
    dataFormGroupItem.Items = new ObservableCollection<DataFormItem>();

    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "First Name", ItemsOrderInRow = 0 , GroupName = "GroupItem" });
    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Middle Name", ItemsOrderInRow = 1 , GroupName = "GroupItem" });
    dataFormGroupItem.Items.Add(new DataFormTextItem() { FieldName = "Last Name", ItemsOrderInRow = 2 , GroupName = "GroupItem" });

    dataForm.Items.Add(dataFormGroupItem);
{% endhighlight %}
{% endtabs %}

`images/GroupItems`

#### Adding custom editor view using Manual DataFormItem

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

