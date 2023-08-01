---
layout: post
title: BindableLayout | Accordion for .NET MAUI | Syncfusion
description: This section describes how to bind AccordionItem to .NET MAUI Accordion (SfAccordion) using BindableLayout.
platform: MAUI
control: SfAccordion
documentation: ug
---

# BindableLayout in .NET MAUI Accordion (SfAccordion)

The [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html) control allows the use of [.NET MAUI BindableLayout](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/bindablelayout) to bind a data collection using `BindableLayout.ItemsSource` and `BindableLayout.ItemTemplate` properties.

## Creating Data Model

Create a simple data model to bind the data for `SfAccordion` as shown in the following code example in a new class file, and save it as an `EmployeeInfo.cs` file:

{% tabs %}
{% highlight c# %}
public class EmployeeInfo : INotifyPropertyChanged
{
    #region Fields

    private string name;
    private string image;
    private string position;
    private string organizationunit;
    private string dateofbirth;
    private string location;
    private string phone;
    private bool isexpanded;
    private string description;

    #endregion

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

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            OnPropertyChanged("Name");
        }
    }

    public string Image
    {
        get { return image; }
        set
        {
            image = value;
            OnPropertyChanged("Image");
        }
    }

    public string Position
    {
        get { return position; }
        set
        {
            position = value;
            OnPropertyChanged("Position");
        }
    }

    public string OrganizationUnit
    {
        get { return organizationunit; }
        set
        {
            organizationunit = value;
            OnPropertyChanged("OrganizationUnit");
        }
    }

    public string DateOfBirth
    {
        get { return dateofbirth; }
        set
        {
            dateofbirth = value;
            OnPropertyChanged("DateOfBirth");
        }
    }

    public string Location
    {
        get { return location; }
        set
        {
            location = value;
            OnPropertyChanged("Location");
        }
    }

    public string Phone
    {
        get { return phone; }
        set
        {
            phone = value;
            OnPropertyChanged("Phone");
        }
    }

    public string IsExpanded
    {
        get { return isexpanded; }
        set
        {
            isexpanded = value;
            OnPropertyChanged("IsExpanded");
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            description = value;
            OnPropertyChanged("Description");
        }
    }

    #endregion
}
{% endhighlight %}
{% endtabs %}

Create a model repository class with the EmployeeInfo collection property initialized with required number of data objects in a new class file, as shown in the following code example, and save it as `EmployeeDetails.cs` file.

{% tabs %}
{% highlight c# %}
public class EmployeeDetails
{
    #region Fields

    private ObservableCollection<EmployeeInfo>? _employee;

    string[] Description = new string[]
    {
    "Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.",
    "Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.",        "Clara Venus, Asst. Manager at ABC Inc., efficiently handles multiple tasks. With her strong skill set and dedication, she contributes significantly to the company's growth and success.",
    "Maria Even, a highly experienced professional, holds the position of Executive Manager at XYZ Corp. She oversees crucial operations, enforcing company policies and practices.",
    "Mark Zuen, Senior Executive at ABC Inc., skillfully manages business operations. He is adept at leadership and strategic thinking."
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

Set the ViewModel instance as the `BindingContext` of your page to bind properties of the ViewModel to `SfAccordion`.

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

`SfAccordion` can be bound with data by setting the `ItemsSource` property of the `BindableLayout`.

The following code example binds the collection created in the previous step to the `BindableLayout.ItemsSource` property.

{% tabs %}
{% highlight xaml hl_lines="7"%}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander"
             xmlns:local="clr-namespace:AccordionBindableLayout"
             x:Class="AccordionBindableLayout.MainPage">
    <syncfusion:SfAccordion x:Name="Accordion"
                            BindableLayout.ItemsSource="{Binding Employees}"/>
</ContentPage>      
{% endhighlight %}
{% highlight c# hl_lines="2"%}
SfAccordion Accordion = new SfAccordion();
BindableLayout.SetItemsSource(Accordion, viewModel.Employees);
{% endhighlight %}
{% endtabs %}

## Defining the AccordionItem

The [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html) accepts the [AccordionItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html) as its child element. The appearance of each `AccordionItem` can be defined by setting the `BindableLayout.ItemTemplate` property.

{% tabs %}
{% highlight xaml hl_lines="2 3" %}
<syncfusion:SfAccordion  x:Name="accordion"
                         BindableLayout.ItemsSource="{Binding Employees}" >
    <BindableLayout.ItemTemplate>
        <DataTemplate>
            <syncfusion:AccordionItem IsExpanded="{Binding IsExpanded}">
                <syncfusion:AccordionItem.Header>
                    <Grid  HeightRequest="48">
                        <Label Text="{Binding Name}" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
                            </Grid>
                </syncfusion:AccordionItem.Header>
                <syncfusion:AccordionItem.Content>
                    <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4"  >
                        <Grid Margin="16,6,0,0">
                            <Grid.Resources>
                                <Style TargetType="Label">
                                            <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                </Style>
                            </Grid.Resources>
                            <Grid.RowDefinitions >
                                <RowDefinition Height="25"/>
                                <RowDefinition Height="25"/>
                                <RowDefinition Height="25"/>
                                <RowDefinition Height="25"/>
                                <RowDefinition Height="{OnPlatform Default=90,Android=90,WinUI=70, iOS=100,MacCatalyst=70 }"/>
                                <RowDefinition Height="Auto"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="100"/>
                                <ColumnDefinition Width="100"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Frame  Grid.RowSpan="4" BorderColor="Transparent" Grid.Row="0" Grid.Column="0"  Padding="0" Margin="0,0,0,7">
                                <Image  Source="{Binding Image}"/>
                            </Frame>
                            <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                            <Label Text="{Binding Position}" Grid.Row="0" Grid.Column="2"/>
                            <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                            <Label Text="{Binding OrganizationUnit}" Grid.Row="1" Grid.Column="2"/>
                            <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                            <Label Text="{Binding DateOfBirth}" Grid.Row="2" Grid.Column="2"/>
                            <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                            <Label Text="{Binding Location}" Grid.Row="3" Grid.Column="2"/>
                            <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="{Binding Description}">
                            </Label>
                            <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                           FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                <Label Text="{Binding Phone}" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                            </StackLayout>
                        </Grid>
                    </Grid>
                </syncfusion:AccordionItem.Content>
            </syncfusion:AccordionItem>
        </DataTemplate>
    </BindableLayout.ItemTemplate>
</syncfusion:SfAccordion>    
{% endhighlight %}
{% highlight c# hl_lines="26 27"%}
SfAccordion accordion = new SfAccordion();
DataTemplate ItemTemplate = new DataTemplate(() =>
{
    var accordionItem = new AccordionItem();
    var headerGrid = new Grid();
    var headerLabel = new Label() { Text = "Robin Rane", Margin = new Thickness(16, 14, 0, 14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 };
    headerLabel.SetBinding(Label.TextProperty, new Binding("Name"));
    headerGrid.Children.Add(headerLabel);
    headerGrid.HeightRequest = 48;
    accordionItem.Header = headerGrid;

    var content = new Grid();
    content.ColumnSpacing = 10;
    content.RowSpacing = 2;
    content.BackgroundColor = Color.FromArgb("#f4f4f4");
    var contentGrid = new Grid();

    (......)

    contentGrid.Children.Add(stack);
    content.Children.Add(contentGrid);
    accordionItem.Content = contentGrid;
    accordion.Items.Add(accordionItem);
    return accordionItem;
});
BindableLayout.SetItemTemplate(accordion, ItemTemplate);
BindableLayout.SetItemsSource(accordion, viewModel.Employees);
{% endhighlight %}
{% endtabs %}

![.NET MAUI Forms Accordion with Bindable Layout](Images/bindablelayout/maui-accordion-with-bindablelayout.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/binding-items-using-bindable-layout-in-.net-maui-accordion).

