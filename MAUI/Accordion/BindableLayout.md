---
layout: post
title: BindableLayout | Accordion for .NET MAUI | Syncfusion
description: This section described about how to bind AccordionItem to .NET MAUI Accordion (SfAccordion) using BindableLayout.
platform: MAUI
control: SfAccordion
documentation: ug
---

# BindableLayout in .NET MAUI Accordion (SfAccordion)

The `SfAccordion` allows you to set a collection of items by setting the `BindableLayout.ItemsSource` and `BindableLayout.ItemTemplate` properties.

## Creating Data Model

Create a simple data model to bind the data for `SfAccordion` as shown in the following code example in a new class file, and save it as `EmployeeInfo.cs` file:

{% tabs %}
{% highlight c# %}
public class EmployeeInfo
{
    #region Constructor

    public EmployeeInfo(string name, string image, string position, string organizationunit, string dateofbirth, string location, string phone, bool isexpanded, string description)
    {
        Name = name;
        Image = image;
        Position = position;
        OrganizationUnit = organizationunit;
        DateOfBirth = dateofbirth;
        Location = location;
        Phone = phone;
        IsExpanded = isexpanded;
        Description = description;
    }

    #endregion

    #region Properties

    public string Name { get; set; }

    public string Image { get; set; }

    public string Position { get; set; }

    public string OrganizationUnit { get; set; }

    public string DateOfBirth { get; set; }

    public string Location { get; set; }

    public string Phone { get; set; }

    public bool IsExpanded { get; set; }

    public string Description { get; set; }

    #endregion
}
{% endhighlight %}
{% endtabs %}

Create a model repository class with the EmployeeInfo collection property initialized with required number of data objects in a new class file as shown in the following code example, and save it as `EmployeeDetails.cs` file.

{% tabs %}
{% highlight c# %}
public class EmployeeDetails
    {
        #region Fields

        private ObservableCollection<EmployeeInfo>? _employee;

        string[] Description = new string[]
        {
        "Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.",
        "Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.",
        "Clara Venus, Asst. Manager at ABC Inc., efficiently handles multiple tasks. With her strong skill set and dedication, she contributes significantly to the company's growth and success.",
        "Maria Even, a highly experienced professional, holds the position of Executive Manager at XYZ Corp. She oversees crucial operations, enforcing company policies and practices.",
        "Mark Zuen, Senior Executive at ABC Inc., skillfully manages business operations. He is adept at leadership and strategic thinking.",
        "Eric John, Technical Manager at ABC Inc., expertly leads his team to develop innovative solutions, creating value for the company",
        "Chris Marker serves as the Senior Accountant at XYZ Corp. With extensive experience, he skillfully manages the company's financial matters, ensuring accuracy and compliance.",
        "Seria Stein, an Account Executive at ABC Inc., adeptly manages client portfolios, ensuring their satisfaction. She is a great communicator, skilled in building relationships.",
        "Angelina Justin, HR Manager at XYZ Corp., expertly handles workplace dynamics with her exceptional communication and problem-solving skills, fostering a positive work environment"
        };

        #endregion

        #region Constructor

        public EmployeeDetails()
        {
            Employees = new ObservableCollection<EmployeeInfo>();
            Employees.Add(new EmployeeInfo("Robin Rane", "emp_01.png", "Chairman", "ABC Inc.", "09/17/1973", "Boston", "(617) 555-1234", false, Description[0]));
            Employees.Add(new EmployeeInfo("Paul Vent", "emp_02.png", "General Manager", "XYZ Corp.", "05/27/1985", "New York", "(212) 555-1234", true, Description[1]));
            Employees.Add(new EmployeeInfo("Clara Venus", "emp_03.png", "Assistant Manager", "ABC Inc.", "07/22/1988", "California", "(415) 123-4567", false, Description[2]));
            Employees.Add(new EmployeeInfo("Maria Even", "emp_04.png", "Executive Manager", "XYZ Corp.", "04/16/1970", "New York", "(516) 345-6789", false, Description[3]));
            Employees.Add(new EmployeeInfo("Mark Zuen", "emp_05.png", "Senior Executive", "ABC Inc.", "09/11/1983", "Boston", "(617) 123-4567", false, Description[4]));
            Employees.Add(new EmployeeInfo("Eric John", "emp_06.png", "Technical Manager", "ABC Inc.", "12/09/1985", "New Jersey", "(201) 555-1234", false, Description[5]));
            Employees.Add(new EmployeeInfo("Chris Marker", "emp_07.png", "Senior Accountant", "XYZ Corp.", "03/14/1986", "California", "(714) 555-5678", false, Description[6]));
            Employees.Add(new EmployeeInfo("Seria Stein", "emp_08.png", "Account Executive", "XYZ Corp.", "02/07/1985", "New York", "(646) 987-6543", false, Description[7]));
            Employees.Add(new EmployeeInfo("Angelina Justin", "emp_09.png", "HR Manager", "XYZ Corp.", "07/11/1972", "Boston", "(617) 987-6543", false, Description[8]));
        }

        #endregion

        #region Properties

        public ObservableCollection<EmployeeInfo>? Employees
        {
            get { return _employee; }
            set { _employee = value; }
        }

        #endregion        
    }
{% endhighlight %}
{% endtabs %}

Set the ViewModel instance as `BindingContext` of your page to bind properties of ViewModel to `SfAccordion`.

{% tabs %} 
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeDetails/>
</ContentPage.BindingContext>
{% endhighlight %}
{% highlight c# %}
this.BindingContext = new EmployeeDetails();      
{% endhighlight %}
{% endtabs %}

## Binding data to SfAccordion

`SfAccordion` can be bound with data by setting the ItemsSource property of BindableLayout.

The following code example binds the collection created in previous step to the `Bindable.ItemsSource` property.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander"
             xmlns:local="clr-namespace:AccordionBindableLayout"
             x:Class="AccordionBindableLayout.MainPage">
    <syncfusion:SfAccordion x:Name="Accordion" BindableLayout.ItemsSource="{Binding Employees}"/>
</ContentPage>      
{% endhighlight %}
{% highlight c# %}
SfAccordion Accordion = new SfAccordion();
BindableLayout.SetItemsSource(Accordion, viewModel.Employees);
{% endhighlight %}
{% endtabs %}

## Defining the AccordionItem

The `SfAccordion` accepts `AccordionItem` as its child element. The appearance of each `AccordionItem` can be defined by setting the `BindableLayout.ItemTemplate` property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="Accordion" BindableLayout.ItemsSource="{Binding Info}">
    <BindableLayout.ItemTemplate>
        <DataTemplate>
            <syncfusion:AccordionItem>
                <syncfusion:AccordionItem.Header>
                    <Grid>
                        <Label Text="{Binding Name}"/>
                    </Grid>
                </syncfusion:AccordionItem.Header>
                <syncfusion:AccordionItem.Content>
                    <Grid>
                        <Label Text="{Binding Description}"/>
                    </Grid>
                </syncfusion:AccordionItem.Content>
            </syncfusion:AccordionItem>
        </DataTemplate>
    </BindableLayout.ItemTemplate>
</syncfusion:SfAccordion>     
{% endhighlight %}
{% highlight c# %}
SfAccordion Accordion = new SfAccordion();
DataTemplate ItemTemplate = new DataTemplate(() =>
{
    AccordionItem accordionItem = new AccordionItem();
    var headerGrid = new Grid();
    var header = new Label();
    header.SetBinding(Label.TextProperty, new Binding("Name"));
    headerGrid.Children.Add(header);
    accordionItem.Header = headerGrid;
    var contentGrid = new Grid();
    var content = new Label();
    content.SetBinding(Label.TextProperty, new Binding("Description"));
    contentGrid.Children.Add(content);
    accordionItem.Content = contentGrid;
    return accordionItem;
});
BindableLayout.SetItemTemplate(Accordion, ItemTemplate);
BindableLayout.SetItemsSource(Accordion, viewModel.Info);
{% endhighlight %}
{% endtabs %}

![.NET MAUI Forms Accordion with Bindable Layout](accordion_images/maui-accordion-with-bindablelayout.png)

## Events

### Get the index of expanded or collapsed accordion item.

You can get the index of the interacted `AccordionItem` by using the `Collapsed`. It will occur after an `AccordionItem` is collapsed when tapping on the Header. The `ExpandedAndCollapsedEventArgs` properties provides data for the `Collapsed` event.  

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="Accordion" Collapsed="Accordion_Collapsed">
{% endhighlight %}
{% highlight c# %}
Accordion.Collapsed += Accordion_Collapsed;
private void Accordion_Collapsed(object sender, Syncfusion.XForms.Accordion.ExpandedAndCollapsedEventArgs e)
{
    var value = e.Index.ToString();
    DisplayAlert("Index", value, "ok");
}
{% endhighlight %}
{% endtabs %}		

Using the `Expanded` event, you can get the index of the interacted `AccordionItem.` It will occur after an `AccordionItem` is expanded when tapping on the `Header`. The `ExpandedAndCollapsedEventArgs` properties provides data for the `Expanded` event.  

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="Accordion" Expanded="Accordion_Expanded">
{% endhighlight %}
{% highlight c# %}
Accordion.Expanded += Accordion_Expanded;
private void Accordion_Expanded(object sender, Syncfusion.XForms.Accordion.ExpandedAndCollapsedEventArgs e)
{
    var value = e.Index.ToString();
    DisplayAlert("Index", value, "ok");
}
{% endhighlight %}
{% endtabs %}

### Restricting the accordion item expanding and collapsing 

The `Collapsing` event occurs while collapsing an `AccordionItem` when tapping on the `Header`. You can cancel the collapsing action by using the `Cancel` property in the event args. 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="Accordion" Collapsing="Accordion_Collapsing">
{% endhighlight %}
{% highlight c# %}
Accordion.Collapsing += Accordion_Collapsing;
private void Accordion_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
   e.cancel = true;
}
{% endhighlight %}
{% endtabs %}

You can also get the index of the interacted `AccordionItem` by using the `index` property of the `ExpandingAndCollapsingEventArgs`.

{% tabs %}
{% highlight c# %}
private void Accordion_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
    var value = e.Index.ToString();
    DisplayAlert("Index", value, "ok");
}
{% endhighlight %}
{% endtabs %}

The `Expanding` event occurs while expanding an `AccordionItem` when tapping on the `Header`. You can cancel the expanding action by using the `Cancel` property in the event args. 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="Accordion" Expanding="Accordion_Expanding">
{% endhighlight %}
{% highlight c# %}
Accordion.Expanding += Accordion_Expanding;
private void Accordion_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

You can also get the index of the interacted `AccordionItem` by using the `index` property of the `ExpandingAndCollapsingEventArgs`.

{% tabs %}
{% highlight c# %}
private void Accordion_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
    var value = e.Index.ToString();
    DisplayAlert("Index",value, "ok");
}
{% endhighlight %}
{% endtabs %}
                                                                                                                                                         
