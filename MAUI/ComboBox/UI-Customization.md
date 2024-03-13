---
layout: post
title: UI Customization in .NET MAUI ComboBox control | Syncfusion
description: Learn all about UI customization support in Syncfusion .NET MAUI ComboBox control into .NET MAUI application and its basic features here.
platform: maui
control: SfComboBox
documentation: ug
---

# UI Customization in .NET MAUI ComboBox (SfComboBox)

This section explains different UI customizations available in [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html).

## Placeholder

You can prompt the user with any information by using the [Placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_Placeholder) property. This text will be displayed only if no items are selected or the edit text is empty. The default value of Placeholder property is `string.Empty` (No string will be displayed).

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    Placeholder="Select a social media" />

{% endhighlight %}
{% highlight C# %}

comboBox.Placeholder = "Select a social media";

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox placeholder](Images/UICustomization/Placeholder.png)


## Placeholder color

The placeholder text color can be changed by using the [PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_PlaceholderColorProperty) property. The default value of PlaceholderColor property is `Colors.Gray`.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    PlaceholderColor="Red"
                    Placeholder="Select a social media" />

{% endhighlight %}
{% highlight C# %}

comboBox.PlaceholderColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox placeholder color](Images/UICustomization/PlaceholderColor.png)

## Clear Button Icon Color

The clear button icon color can be changed by using the [ClearButtonIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_ClearButtonIconColorProperty) property. The default value of the ClearButtonIconColor property is `Colors.Black`.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="combobox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    ClearButtonIconColor="Red" />

{% endhighlight %}
{% highlight C# %}

combobox.ClearButtonIconColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox clear button color](Images/UICustomization/ClearButtonColor.png)

## DropDown Icon Color

The DropDown icon color can be changed by using the [DropDownIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_DropDownIconColor) property. The default value of the DropDownIconColor property is `Colors.Black`.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="combobox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    DropDownIconColor="Red" />

{% endhighlight %}
{% highlight C# %}

combobox.DropDownIconColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox  drop-down icon color](Images/UICustomization/DropDownIconColor.png)


## Stroke

The ComboBox border color can be changed by using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_Stroke) property.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="combobox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    DropDownIconColor="Red"
                    Stroke="Red" />

{% endhighlight %}
{% highlight C# %}

combobox.Stroke = Colors.Red;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox border color](Images/UICustomization/BorderColor.png)

## Customize the selection text highlightColor 

The SelectionTextHighlightColor property is used to modify the background color of the selected item text in the combobox control.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        SelectionTextHighlightColor="Aqua" />

{% endhighlight %}

{% highlight C# %}

combobox.SelectionTextHighlightColor = Colors.Aqua;

{% endhighlight %}
{% endtabs %}

## Maximum DropDown Height

The maximum height of the drop-down can be changed by using the [MaxDropDownHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_MaxDropDownHeight) property of the ComboBox control. The default value of MaxDropDownHeight property is `400d`.

 N> If the `MaxDropDownHeight` is too small compared to the populated items, the scroll viewer will be automatically shown to navigate the hidden items.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="true"
                    MaxDropDownHeight="150"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

comboBox.MaxDropDownHeight = 150;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox maximum drop-down height](Images/UICustomization/MaxDropDownHeight.png)

## Customize the DropDown (suggestion) item 

The [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemTemplate) property helps you to decorate drop-down items using the custom templates. The default value of the `ItemTemplate` is `null`. The following example shows how to customize drop-down items using templates.

{% tabs %}
{% highlight C# %}

    //Model.cs
    public class Employee
    {
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public string Designation { get; set; }
        public string ID { get; set; }
    }

    //ViewModel.cs
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public EmployeeViewModel()
        {
            this.Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee
            {
                Name = "Anne Dodsworth",
                ProfilePicture = "people_circle1.png",
                Designation = "Developer",
                ID = "E001",
            });
            Employees.Add(new Employee
            {
                Name = "Andrew Fuller",
                ProfilePicture = "people_circle8.png", 
                Designation = "Team Lead",
                ID = "E002",
            });
            ...
        }
    }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}

    <editors:SfComboBox Placeholder="Select an employee"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"
                        ItemsSource="{Binding Employees}"
                        WidthRequest="280"
                        HeightRequest="34"
                        x:Name="comboBox">
        <editors:SfComboBox.BindingContext>
            <local:EmployeeViewModel/>
        </editors:SfComboBox.BindingContext>
        <editors:SfComboBox.ItemTemplate>
            <DataTemplate >
                <ViewCell>
                    <Grid Margin="0,5"
                          VerticalOptions="Center"
                          HorizontalOptions="Center"
                          ColumnDefinitions="48,220"
                          RowDefinitions="50">
                        <Image Grid.Column="0"
                               HorizontalOptions="Center"
                               VerticalOptions="Center"
                               Source="{Binding ProfilePicture}"
                               Aspect="AspectFit"/>
                        <StackLayout HorizontalOptions="Start"
                                     VerticalOptions="Center"
                                     Grid.Column="1"
                                     Margin="15,0,0,0">
                            <Label HorizontalTextAlignment="Start"
                                   VerticalTextAlignment="Center"
                                   Opacity=".87"
                                   FontSize="14"
                                   Text="{Binding Name}"/>
                            <Label HorizontalOptions="Start"
                                   VerticalTextAlignment="Center"
                                   Opacity=".54"
                                   FontSize="12"
                                   Text="{Binding Designation}"/>
                        </StackLayout>
                    </Grid>
                </ViewCell>
            </DataTemplate>
        </editors:SfComboBox.ItemTemplate>
    </editors:SfComboBox>

{% endhighlight %}
{% highlight C# %}

    EmployeeViewModel employee = new EmployeeViewModel();

    SfComboBox comboBox = new SfComboBox()
        {
            HeightRequest = 34,
            WidthRequest = 280,
            BindingContext = employee,
            ItemsSource = employee.Employees,
            DisplayMemberPath = "Name",
            Placeholder = "Enter an employee",
            TextMemberPath = "Name",
        };

    DataTemplate itemTemplate = new DataTemplate(() =>
    {
        Grid grid = new();
        grid.Margin = new Thickness(0, 5);
        grid.HorizontalOptions = LayoutOptions.Center;
        grid.VerticalOptions = LayoutOptions.Center;
        ColumnDefinition colDef1 = new ColumnDefinition() { Width = 48 };
        ColumnDefinition colDef2 = new ColumnDefinition() { Width = 220 };
        RowDefinition rowDef = new RowDefinition() { Height = 50 };
        grid.ColumnDefinitions.Add(colDef1);
        grid.ColumnDefinitions.Add(colDef2);
        grid.RowDefinitions.Add(rowDef);

        Image image = new();
        image.HorizontalOptions = LayoutOptions.Center;
        image.VerticalOptions = LayoutOptions.Center;
        image.Aspect = Aspect.AspectFit;
        image.SetBinding(Image.SourceProperty, ("ProfilePicture"));
        Grid.SetColumn(image, 0);

        StackLayout stack = new();
        stack.Orientation = StackOrientation.Vertical;
        stack.Margin = new Thickness(15, 0,0,0);
        stack.HorizontalOptions = LayoutOptions.Start;
        stack.VerticalOptions = LayoutOptions.Center;
        Grid.SetColumn(stack, 1);

        Label label = new();
        label.SetBinding(Label.TextProperty, "Name");
        label.FontSize = 14;
        label.VerticalOptions = LayoutOptions.Center;
        label.HorizontalTextAlignment = TextAlignment.Start;
        label.Opacity = .87;

        Label label1 = new();
        label1.SetBinding(Label.TextProperty, "Designation");
        label1.FontSize = 12;
        label1.VerticalOptions = LayoutOptions.Center;
        label1.HorizontalTextAlignment = TextAlignment.Start;
        label1.Opacity = .54;

        stack.Children.Add(label);
        stack.Children.Add(label1);

        grid.Children.Add(image);
        grid.Children.Add(stack);

        return new ViewCell { View = grid };
    });
    comboBox.ItemTemplate = itemTemplate;

    this.Content = comboBox;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox ItemTemplate](Images/UICustomization/ItemTemplate.png)

### Customize the DropDown item text

DropDown items can be customized using the [DropDownItemFontAttributes], [DropDownItemFontFamily], [DropDownItemFontSize], and [DropDownItemTextColor] properties.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        DropDownItemFontAttributes="Bold"
                        DropDownItemFontFamily="OpenSansSemibold"
                        DropDownItemFontSize="20"
                        DropDownItemTextColor="White" />

{% endhighlight %}

{% highlight C# %}

combobox.DropDownItemFontAttributes = FontAttributes.Bold;
combobox.DropDownItemFontFamily = "OpenSansSemibold";
combobox.DropDownItemFontSize = 20;
combobox.DropDownItemTextColor = Colors.White;

{% endhighlight %}
{% endtabs %}

### Customize the DropDown background color

The DropDownBackground property is used to modify the background color of the dropdown.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        DropDownBackground="Yellow" />

{% endhighlight %}

{% highlight C# %}

combobox.DropDownBackground = Colors.Yellow;

{% endhighlight %}
{% endtabs %}

### Customize the DropDown selected item backgroundcolor

The SelectedDropDownItemBackground property is used to modify the backgroundcolor of selected item in the dropdown.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        SelectedDropDownItemBackground="YellowGreen" />

{% endhighlight %}

{% highlight C# %}

combobox.SelectedDropDownItemBackground = Colors.YellowGreen;

{% endhighlight %}
{% endtabs %}

### Customize the DropDown Border Color

The DropDownStroke property is used to modify the border color of the dropdown.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        DropDownStroke="Red" />

{% endhighlight %}

{% highlight C# %}

combobox.DropDownStroke = Colors.Red;

{% endhighlight %}
{% endtabs %}

### Customize the DropDown Border Thickness

The DropDownStrokeThickness property is used to modify the thickness of the dropdown border.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        DropDownStrokeThickness="5" />

{% endhighlight %}

{% highlight C# %}

combobox.DropDownStrokeThickness = 5;

{% endhighlight %}
{% endtabs %}

### Customize the DropDown Item Height

The DropDownItemHeight property is used to modify the height of the dropdown items.

{% tabs %}
{% highlight xaml %}

<editors:SfCombobox x:Name="combobox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        DropDownItemHeight="50" />

{% endhighlight %}

{% highlight C# %}

combobox.DropDownItemHeight = 50;

{% endhighlight %}
{% endtabs %}

## Customize the DropDown (suggestion) item based on condition

The [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemTemplate) property helps you to decorate drop-down items conditionally based on their content using the custom templates. The default value of the `ItemTemplate` is `null`.

{% tabs %}
{% highlight C# %}

    //Model.cs
    public class Employee
    {
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public string Designation { get; set; }
        public string ID { get; set; }
    }

    //ViewModel.cs
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public EmployeeViewModel()
        {
            this.Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee
            {
                Name = "Anne Dodsworth",
                ProfilePicture = "people_circle1.png",
                Designation = "Developer",
                ID = "E001",
            });
            Employees.Add(new Employee
            {
                Name = "Andrew Fuller",
                ProfilePicture = "people_circle8.png", 
                Designation = "Team Lead",
                ID = "E002",
            });
            Employees.Add(new Employee
            {
                Name = "Andrew Fuller",
                ProfilePicture ="people_circle8.png",
                Designation = "Team Lead",
                ID = "E002",
            });
            Employees.Add(new Employee
            {
                Name = "Emilio Alvaro",
                ProfilePicture = "people_circle7.png",
                Designation = "Product Manager",
                ID = "E003"
            });
            Employees.Add(new Employee
            {
                Name = "Janet Leverling",
                ProfilePicture = "people_circle2.png",
                Designation = "HR",
                ID = "E004",
            });
            Employees.Add(new Employee
            {
                Name = "Laura Callahan",
                ProfilePicture = "people_circle10.png",
                Designation = "Product Manager",
                ID = "E005",
            });
        }
    }

    //Template selector
    public class EmployeeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EmployeeTemplate1 { get; set; }
        public DataTemplate EmployeeTemplate2 { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var employeeName = ((Employee)item).Name;
            {
                if (employeeName.ToString() == "Anne Dodsworth" || employeeName.ToString() == "Emilio Alvaro" ||
                    employeeName.ToString() == "Laura Callahan")
                {
                    return EmployeeTemplate1;
                }
                else
                {
                    return EmployeeTemplate2;
                }
            }
        }
    }

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}

    <Grid >
        <Grid.Resources>
            <DataTemplate x:Key="employeeTemplate1">
                <ViewCell>
                    <Grid Margin="0,5"
                          VerticalOptions="Center"
                          HorizontalOptions="Center"
                          ColumnDefinitions="48,220"
                          RowDefinitions="50">
                        <Image Grid.Column="0"
                               HorizontalOptions="Center"
                               VerticalOptions="Center"
                               Source="{Binding ProfilePicture}"
                               Aspect="AspectFit"/>
                        <StackLayout HorizontalOptions="Start"
                                     VerticalOptions="Center"
                                     Grid.Column="1"
                                     Margin="15,0,0,0">
                            <Label HorizontalTextAlignment="Start"
                                   VerticalTextAlignment="Center"
                                   Opacity=".87"
                                   FontSize="14"
                                   TextColor="Blue"
                                   Text="{Binding Name}"/>
                            <Label HorizontalOptions="Start"
                                   VerticalTextAlignment="Center"
                                   Opacity=".54"
                                   FontSize="12"
                                   TextColor="Coral"
                                   Text="{Binding Designation}"/>
                        </StackLayout>
                    </Grid>
                </ViewCell>
            </DataTemplate>
        
            <DataTemplate x:Key="employeeTemplate2">
                <ViewCell>
                    <Grid Margin="0,5"
                          VerticalOptions="Center"
                          HorizontalOptions="Center"
                          ColumnDefinitions="48,220"
                          RowDefinitions="50">
                        <Image Grid.Column="0"
                               HorizontalOptions="Center"
                               VerticalOptions="Center"
                               Source="{Binding ProfilePicture}"
                               Aspect="AspectFit"/>
                        <StackLayout HorizontalOptions="Start"
                                     VerticalOptions="Center"
                                     Grid.Column="1"
                                     Margin="15,0,0,0">
                            <Label HorizontalTextAlignment="Start"
                                   VerticalTextAlignment="Center"
                                   Opacity=".87"
                                   FontSize="14"
                                   TextColor="Red"
                                   Text="{Binding Name}"/>
                            <Label HorizontalOptions="Start"
                                   VerticalTextAlignment="Center"
                                   Opacity=".54"
                                   FontSize="12"
                                   TextColor="Green"
                                   Text="{Binding Designation}"/>
                        </StackLayout>
                    </Grid>
                </ViewCell>
            </DataTemplate>

            <local:EmployeeTemplateSelector x:Key="employeeTemplateSelector"
                                            EmployeeTemplate1="{StaticResource employeeTemplate1}"
                                            EmployeeTemplate2="{StaticResource employeeTemplate2}"/>

        </Grid.Resources>
        <editors:SfComboBox Placeholder="Select an employee"
                            TextMemberPath="Name"
                            DisplayMemberPath="Name"
                            ItemsSource="{Binding Employees}"
                            SelectedItem="{Binding SelectedEmployee,Mode=TwoWay}"
                            WidthRequest="280"
                            HeightRequest="34"
                            x:Name="comboBox"
                            ItemTemplate="{StaticResource employeeTemplateSelector}">
            <editors:SfComboBox.BindingContext>
                <local:EmployeeViewModel/>
            </editors:SfComboBox.BindingContext>
        </editors:SfComboBox>
    </Grid>

{% endhighlight %}
{% highlight C# %}

    EmployeeViewModel employee = new EmployeeViewModel();

    DataTemplate employeeTemplate1 = new DataTemplate(() =>
    {
        Grid grid = new();
        grid.Margin = new Thickness(0, 5);
        grid.HorizontalOptions = LayoutOptions.Center;
        grid.VerticalOptions = LayoutOptions.Center;
        ColumnDefinition colDef1 = new ColumnDefinition() { Width = 48 };
        ColumnDefinition colDef2 = new ColumnDefinition() { Width = 220 };
        RowDefinition rowDef = new RowDefinition() { Height = 50 };
        grid.ColumnDefinitions.Add(colDef1);
        grid.ColumnDefinitions.Add(colDef2);
        grid.RowDefinitions.Add(rowDef);

        Image image = new();
        image.HorizontalOptions = LayoutOptions.Center;
        image.VerticalOptions = LayoutOptions.Center;
        image.Aspect = Aspect.AspectFit;
        image.SetBinding(Image.SourceProperty, ("ProfilePicture"));
        Grid.SetColumn(image, 0);

        StackLayout stack = new();
        stack.Orientation = StackOrientation.Vertical;
        stack.Margin = new Thickness(15, 0,0,0);
        stack.HorizontalOptions = LayoutOptions.Start;
        stack.VerticalOptions = LayoutOptions.Center;
        Grid.SetColumn(stack, 1);

        Label label = new();
        label.SetBinding(Label.TextProperty, "Name");
        label.FontSize = 14;
        label.TextColor = Colors.Blue;
        label.VerticalOptions = LayoutOptions.Center;
        label.HorizontalTextAlignment = TextAlignment.Start;
        label.Opacity = .87;

        Label label1 = new();
        label1.SetBinding(Label.TextProperty, "Designation");
        label1.FontSize = 12;
        label1.TextColor = Colors.Coral;
        label1.VerticalOptions = LayoutOptions.Center;
        label1.HorizontalTextAlignment = TextAlignment.Start;
        label1.Opacity = .54;

        stack.Children.Add(label);
        stack.Children.Add(label1);

        grid.Children.Add(image);
        grid.Children.Add(stack);

        return new ViewCell { View = grid };
    });

    DataTemplate employeeTemplate2 = new DataTemplate(() =>
    {
        Grid grid = new();
        grid.Margin = new Thickness(0, 5);
        grid.HorizontalOptions = LayoutOptions.Center;
        grid.VerticalOptions = LayoutOptions.Center;
        ColumnDefinition colDef1 = new ColumnDefinition() { Width = 48 };
        ColumnDefinition colDef2 = new ColumnDefinition() { Width = 220 };
        RowDefinition rowDef = new RowDefinition() { Height = 50 };
        grid.ColumnDefinitions.Add(colDef1);
        grid.ColumnDefinitions.Add(colDef2);
        grid.RowDefinitions.Add(rowDef);

        Image image = new();
        image.HorizontalOptions = LayoutOptions.Center;
        image.VerticalOptions = LayoutOptions.Center;
        image.Aspect = Aspect.AspectFit;
        image.SetBinding(Image.SourceProperty, ("ProfilePicture"));
        Grid.SetColumn(image, 0);

        StackLayout stack = new();
        stack.Orientation = StackOrientation.Vertical;
        stack.Margin = new Thickness(15, 0, 0, 0);
        stack.HorizontalOptions = LayoutOptions.Start;
        stack.VerticalOptions = LayoutOptions.Center;
        Grid.SetColumn(stack, 1);

        Label label = new();
        label.SetBinding(Label.TextProperty, "Name");
        label.FontSize = 14;
        label.TextColor = Colors.Red;
        label.VerticalOptions = LayoutOptions.Center;
        label.HorizontalTextAlignment = TextAlignment.Start;
        label.Opacity = .87;

        Label label1 = new();
        label1.SetBinding(Label.TextProperty, "Designation");
        label1.FontSize = 12;
        label1.TextColor = Colors.Green;
        label1.VerticalOptions = LayoutOptions.Center;
        label1.HorizontalTextAlignment = TextAlignment.Start;
        label1.Opacity = .54;

        stack.Children.Add(label);
        stack.Children.Add(label1);

        grid.Children.Add(image);
        grid.Children.Add(stack);

        return new ViewCell { View = grid };
    });

    EmployeeTemplateSelector employeeTemplateSelector = new EmployeeTemplateSelector();
    employeeTemplateSelector.EmployeeTemplate1 = employeeTemplate1;
    employeeTemplateSelector.EmployeeTemplate2 = employeeTemplate2;

    SfComboBox comboBox = new SfComboBox()
    {
        HeightRequest = 34,
        WidthRequest = 280,
        BindingContext = employee,
        ItemsSource = employee.Employees,
        DisplayMemberPath = "Name",
        Placeholder = "Enter an employee",
        TextMemberPath = "Name",
        ItemTemplate = employeeTemplateSelector,
    };

    this.Content = comboBox;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox ItemTemplateSelector](Images/UICustomization/TemplateSelector.png)

## Styling token items

The ComboBox control allows you to customize the style of TokenItem generated in the selection area by using the `TokenItemStyle` property. 

{% tabs %}

{% highlight xaml %}
 ...

  xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
  xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"

 ...

  <editors:SfComboBox SelectionMode="Multiple" 
             x:Name="comboBox" 
             ItemsSource="{Binding SocialMedias}" 
             HeightRequest="50"
             MaxDropDownHeight="250"
             WidthRequest="350"
             DisplayMemberPath="Name"
             TextMemberPath="Name">
     <editors:SfComboBox.TokenItemStyle>
         <Style TargetType="core:SfChipGroup">
             <Setter Property="ChipTextColor" Value="White"/>
             <Setter Property="ChipFontAttributes" Value="Bold"/>
             <Setter Property="CloseButtonColor" Value="White"/>
             <Setter Property="ChipBackground" Value="#d3a7ff"/>
             <Setter Property="ChipStroke" Value="#5118e3"/>
             <Setter Property="ChipStrokeThickness" Value="6"/>
             <Setter Property="ChipCornerRadius" Value="18"/>
         </Style>
     </editors:SfComboBox.TokenItemStyle>
 </editors:SfComboBox>

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code.

![.NET MAUI ComboBox token item style](Images/UICustomization/Tokenitemstyle.png)


## Completed Event

The [Completed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Completed) event is raised when the user finalizes the text in the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) editable mode by pressing return key on the keyboard.The handler for the event is a generic event handler, taking the `sender` and `EventArgs`(the `EventArgs` value is `string.Empty`):

{% tabs %}
{% highlight xaml %}

    <editors:SfComboBox x:Name="combobox"
                        IsEditable="True" 
                        WidthRequest="280" 
                        HeightRequest="34" 
                        Completed="combobox_Completed"/>

{% endhighlight %}
{% highlight C# %}

    private async void combobox_Completed(object sender, EventArgs e)
    {
        await DisplayAlert("Message", "Text entering Completed", "close");
    }

{% endhighlight %}
{% endtabs %}

Completed event can be subscribed in C# also:

{% tabs %}
{% highlight C# %}

    combobox.Completed+=combobox_Completed;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox completed event](Images/UICustomization/CompletedEvent.png)

N> The `Completed` event is not supported in the Android platform.

## DropDownOpening Event

The `DropDownOpening` event will be fired whenever opening the dropdown menu in the SfComboBox. It can cancel dropdown opening with CancelEventArgs that contains the following property:

 * Cancel: Dropdown opening is based on this value.

{% tabs %}

{% highlight xaml %}

 <editors:SfComboBox 
 DropdownOpening="comboBox_DropdownOpening"
 WidthRequest="350"
 HeightRequest="50"
 ItemsSource="{Binding SocialMedias}"
 DisplayMemberPath="Name"
 TextMemberPath="Name"    
 x:Name="comboBox" >
 </editors:SfComboBox>
    
{% endhighlight %}

{% highlight c# %}

  SfComboBox comboBox = new SfComboBox();
  comboBox.DropdownOpening += comboBox_DropdownOpening;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
 private void comboBox_DropdownOpening(object sender, CancelEventArgs e)
 {
     e.Cancel = true; // If you want to restrict the dropdown open then set the e.Cancel is true. 
 }

{% endhighlight %}

{% endtabs %}

## DropDownOpened Event

The `DropDownOpened` event occurs when the SfComboBox drop-down is opened.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox 
DropdownOpened="comboBox_DropdownOpened"
WidthRequest="350"
HeightRequest="50"
ItemsSource="{Binding SocialMedias}"
DisplayMemberPath="Name"
TextMemberPath="Name"    
x:Name="comboBox" >
</editors:SfComboBox>
 
{% endhighlight %}

{% highlight c# %}

  SfComboBox comboBox = new SfComboBox();
  comboBox.DropdownOpened += comboBox_DropdownOpened;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}

  private void comboBox_DropdownOpened(object sender, EventArgs e)
  {

  }

{% endhighlight %}

{% endtabs %}

## DropDownClosed Event

The `DropDownClosed` event occurs when the SfComboBox drop-down is closed.

{% tabs %}
{% highlight xaml %}

    
    <comboBox:SfComboBox HeightRequest="40"
                         x:Name="comboBox"
                         ItemSource="{Binding Employees}"
                         DropDownClosed="SfComboBox_DropDownClosed"/>
{% endhighlight %}
{% highlight c# %}

    SfComboBox comboBox = new SfComboBox();
    comboBox.DropDownClosed+=comboBox_DropDownClosed;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
    
    private void SfComboBox_DropDownClosed(object sender, EventArgs e)
    {
        await DisplayAlert("Message", "DropDown Closed", "close");
    }

{% endhighlight %}
{% endtabs %}

## CursorPosition

The cursor position in the input view can be obtained or updated using the [CursorPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_CursorPosition) property in the SfComboBox.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                            WidthRequest="250" 
                            HeightRequest="35"
                            IsEditable="True"
                            CursorPosition = "4" />
{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Inputs;

SfComboBox comboBox = new SfComboBox();
comboBox.IsEditable = true;
comboBox.CursorPosition = 4;

{% endhighlight %}
{% endtabs %}

N> The cursor position support is available for editable mode only, and two-way binding is not supported in the Android platform.

## Border visibility

The `ShowBorder` property of [`SfComboBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) is used to modify the visibility of the border and its default value is **true**. The following code example demonstrates how to change the border visibility,

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                            WidthRequest="200" 
                            HeightRequest="35"
                            ShowBorder="False"/>
{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Inputs;

SfComboBox comboBox = new SfComboBox();
comboBox.WidthRequest = 200;
comboBox.HeightRequest = 35;
comboBox.ShowBorder = false;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox showborder](Images/UICustomization/ShowBorder.png)

### TextAlignment

The [`SfComboBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) provides support to customize the text alignment by using the `HorizontalTextAlignment` and `VerticalTextAlignment` properties.

N> Dynamic changes to the `HorizontalTextAlignment` property may not be functioning as expected on Android platform.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250" 
                    HeightRequest="50"
                    HorizontalTextAlignment="Center" 
                    VerticalTextAlignment="Start"/>
{% endhighlight %}
{% highlight c# %}

SfComboBox comboBox = new SfComboBox();
comboBox.WidthRequest = 250;
comboBox.HeightRequest = 50;
comboBox.HorizontalTextAlignment = TextAlignment.Center;
comboBox.VerticalTextAlignment = TextAlignment.Start;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![TextAlignment](Images/UICustomization/TextAlignment.png)
