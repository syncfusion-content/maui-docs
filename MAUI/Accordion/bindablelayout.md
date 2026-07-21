---
layout: post
title: BindableLayout in .NET MAUI Accordion control | Syncfusion®
description: This section describes how to bind AccordionItem to Syncfusion® .NET MAUI Accordion (SfAccordion) using BindableLayout.
platform: MAUI
control: SfAccordion
documentation: ug
---

# BindableLayout in .NET MAUI Accordion (SfAccordion)

The [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html) control allows the use of [.NET MAUI BindableLayout](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/bindablelayout) to bind a data collection using `BindableLayout.ItemsSource` and `BindableLayout.ItemTemplate` properties.

## Creating the data model

Create a simple data model to bind to `SfAccordion` as shown in the following code example in a new class file, and save it as `EmployeeInfo.cs`:

{% tabs %}
{% highlight c# %}
using System.Collections.ObjectModel;
using System.ComponentModel;

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

    public bool IsExpanded
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

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
{% endhighlight %}
{% endtabs %}

Create a model repository class with the `EmployeeInfo` collection property initialized with the required number of data objects in a new class file, as shown in the following code example, and save it as `EmployeeDetails.cs`.

{% tabs %}
{% highlight c# %}
using System.Collections.ObjectModel;

public class EmployeeDetails
{
    #region Fields

    private ObservableCollection<EmployeeInfo>? _employee;

    string[] Description = new string[]
    {
    "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. Under his guidance, the company thrives and continues to make a significant impact in the industry.",
    "Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.",
    "Clara Venus, Asst. Manager at ABC Inc., efficiently handles multiple tasks. With her strong skill set and dedication, she contributes significantly to the company's growth and success.",
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
        Employees.Add(new EmployeeInfo("Mark Zuen", "emp_05.png", "Senior Executive", "ABC Inc.", "11/03/1982", "Seattle", "(206) 555-9876", false, Description[4]));
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

### Setting the BindingContext

Set the ViewModel instance as the `BindingContext` of your page to bind the ViewModel properties to `SfAccordion`.

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

`SfAccordion` can be bound with data by setting the `ItemsSource` property of `BindableLayout`.

The following code example binds the collection created in the previous step to the `BindableLayout.ItemsSource` property.

{% tabs %}
{% highlight xaml hl_lines="5" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander"
             xmlns:local="clr-namespace:AccordionSample">
    <syncfusion:SfAccordion x:Name="Accordion"
                            BindableLayout.ItemsSource="{Binding Employees}"/>
</ContentPage>      
{% endhighlight %}
{% highlight c# hl_lines="3" %}
using Syncfusion.Maui.Accordion;
using System.Collections.ObjectModel;

EmployeeDetails viewModel = new EmployeeDetails();
SfAccordion Accordion = new SfAccordion();
BindableLayout.SetItemsSource(Accordion, viewModel.Employees ?? new ObservableCollection<EmployeeInfo>());
{% endhighlight %}
{% endtabs %}

## Defining the AccordionItem

The [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html) accepts the [AccordionItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html) as its child element. The appearance of each `AccordionItem` can be defined by setting the `BindableLayout.ItemTemplate` property.

In the following template, an image file name is bound to the `Image.Source` property through an `ImageConverter` that converts the file name into an `ImageSource`. Define the converter in C# and expose it as a page resource with the key `image converter`, as shown below.

{% tabs %}
{% highlight c# %}
using System.Globalization;
using Microsoft.Maui.Controls;

public class ImageConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string imageName && !string.IsNullOrWhiteSpace(imageName))
        {
            return ImageSource.FromFile(imageName);
        }

        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<ContentPage.Resources>
    <local:ImageConverter x:Key="imageconverter"/>
</ContentPage.Resources>
{% endhighlight %}
{% endtabs %}

N> Refer to the [.NET MAUI fonts documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/fonts) for details on how to add and register the `AccordionFontIcons.ttf` font used by the phone icon in the following template.

{% tabs %}
{% highlight xaml hl_lines="2 3" %}
<syncfusion:SfAccordion x:Name="accordion"
                        BindableLayout.ItemsSource="{Binding Employees}">
    <BindableLayout.ItemTemplate>
        <DataTemplate>
            <syncfusion:AccordionItem IsExpanded="{Binding IsExpanded}">
                <syncfusion:AccordionItem.Header>
                    <Grid HeightRequest="48">
                        <Label Text="{Binding Name}" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
                    </Grid>
                </syncfusion:AccordionItem.Header>
                <syncfusion:AccordionItem.Content>
                    <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                        <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                            <Grid.Resources>
                                <Style TargetType="Label">
                                    <Setter Property="FontFamily" Value="Roboto-Regular" />
                                </Style>
                            </Grid.Resources>
                            <Border Grid.RowSpan="4" Padding="0" Margin="0,0,12,7">
                                <Image Source="{Binding Image,Converter={StaticResource imageconverter}}"/>
                            </Border>
                            <Label Text="Position" Grid.Column="1" Margin="6,0,0,0" />
                            <Label Text="{Binding Position}" Grid.Column="2" />
                            <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                            <Label Text="{Binding OrganizationUnit}" Grid.Row="1" Grid.Column="2" />
                            <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                            <Label Text="{Binding DateOfBirth}" Grid.Row="2" Grid.Column="2" />
                            <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                            <Label Text="{Binding Location}" Grid.Row="3" Grid.Column="2" />
                            <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                   Text="{Binding Description}">
                            </Label>
                            <HorizontalStackLayout Grid.Row="5" Margin="0,0,0,12">
                                <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                                <Label Text="{Binding Phone}" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                            </HorizontalStackLayout>
                        </Grid>
                    </Grid>
                </syncfusion:AccordionItem.Content>
            </syncfusion:AccordionItem>
        </DataTemplate>
    </BindableLayout.ItemTemplate>
</syncfusion:SfAccordion>    
{% endhighlight %}
{% highlight c# hl_lines="27 28" %}
using Syncfusion.Maui.Accordion;
using System.Collections.ObjectModel;

EmployeeDetails viewModel = new EmployeeDetails();
SfAccordion accordion = new SfAccordion();
DataTemplate ItemTemplate = new DataTemplate(() =>
{
    var accordionItem = new AccordionItem();
    var headerGrid = new Grid();
    var headerLabel = new Label { Margin = new Thickness(16, 14, 0, 14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 };
    headerLabel.SetBinding(Label.TextProperty, new Binding("Name"));
    headerGrid.Children.Add(headerLabel);
    headerGrid.HeightRequest = 48;
    accordionItem.Header = headerGrid;
    accordionItem.SetBinding(AccordionItem.IsExpandedProperty, new Binding("IsExpanded"));

    var contentGrid = new Grid();
    contentGrid.ColumnSpacing = 10;
    contentGrid.RowSpacing = 2;
    contentGrid.BackgroundColor = Color.FromArgb("#f4f4f4");

    var contentInnerGrid = new Grid
    {
        Margin = new Thickness(16, 6, 0, 0),
        RowDefinitions = new RowDefinitionCollection
        {
            new RowDefinition { Height = 25 },
            new RowDefinition { Height = 25 },
            new RowDefinition { Height = 25 },
            new RowDefinition { Height = 25 },
            new RowDefinition { Height = 70 },
            new RowDefinition { Height = GridLength.Auto }
        },
        ColumnDefinitions = new ColumnDefinitionCollection
        {
            new ColumnDefinition { Width = 100 },
            new ColumnDefinition { Width = 100 },
            new ColumnDefinition { Width = GridLength.Star }
        }
    };

    var positionLabel = new Label { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
    positionLabel.SetValue(Grid.ColumnProperty, 1);
    var positionValue = new Label();
    positionValue.SetBinding(Label.TextProperty, new Binding("Position"));
    positionValue.SetValue(Grid.ColumnProperty, 2);

    var organizationLabel = new Label { Text = "Organization ", Margin = new Thickness(6, 0, 0, 0) };
    organizationLabel.SetValue(Grid.RowProperty, 1);
    organizationLabel.SetValue(Grid.ColumnProperty, 1);
    var organizationValue = new Label();
    organizationValue.SetBinding(Label.TextProperty, new Binding("OrganizationUnit"));
    organizationValue.SetValue(Grid.RowProperty, 1);
    organizationValue.SetValue(Grid.ColumnProperty, 2);

    var descriptionLabel = new Label
    {
        Padding = new Thickness(0, 10, 0, 10),
        LineBreakMode = LineBreakMode.WordWrap,
        FontSize = 14,
        CharacterSpacing = 0.25,
        VerticalTextAlignment = TextAlignment.Center
    };
    descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));
    descriptionLabel.SetValue(Grid.RowProperty, 4);
    descriptionLabel.SetValue(Grid.ColumnSpanProperty, 3);

    var phoneStack = new HorizontalStackLayout { Margin = new Thickness(0, 0, 0, 12) };
    var phoneIcon = new Label
    {
        Text = "\ue700",
        FontSize = 16,
        Margin = new Thickness(0, 2, 2, 2),
        VerticalOptions = LayoutOptions.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
    phoneIcon.SetValue(Grid.RowProperty, 5);
    var phoneLabel = new Label { CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center };
    phoneLabel.SetBinding(Label.TextProperty, new Binding("Phone"));
    phoneStack.Children.Add(phoneIcon);
    phoneStack.Children.Add(phoneLabel);
    phoneStack.SetValue(Grid.RowProperty, 5);

    contentInnerGrid.Children.Add(positionLabel);
    contentInnerGrid.Children.Add(positionValue);
    contentInnerGrid.Children.Add(organizationLabel);
    contentInnerGrid.Children.Add(organizationValue);
    contentInnerGrid.Children.Add(descriptionLabel);
    contentInnerGrid.Children.Add(phoneStack);
    contentGrid.Children.Add(contentInnerGrid);
    accordionItem.Content = contentGrid;
    return accordionItem;
});

BindableLayout.SetItemTemplate(accordion, ItemTemplate);
BindableLayout.SetItemsSource(accordion, viewModel.Employees ?? new ObservableCollection<EmployeeInfo>());
{% endhighlight %}
{% endtabs %}

N> The `IsExpanded` property of the `EmployeeInfo` model is two-way bound to each `AccordionItem.IsExpanded`. Setting `IsExpanded = true` on a data item expands the corresponding accordion item at load, and the value is kept in sync when the user expands or collapses an item at runtime.

![Syncfusion Maui Accordion with bound data](Images\bindablelayout\maui-accordion-with-bindablelayout.png) 

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/binding-items-using-bindable-layout-in-.net-maui-accordion).

