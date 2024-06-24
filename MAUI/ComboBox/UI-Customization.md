---
layout: post
title: UI Customization in .NET MAUI ComboBox control | Syncfusion
description: Learn all about UI customization support in Syncfusion .NET MAUI ComboBox control into .NET MAUI application and its basic features here.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
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

The [SelectionTextHighlightColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionTextHighlightColor) property is used to modify the background color of the selected item text in the combobox control.

{% tabs %}
{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        SelectionTextHighlightColor="Green" />

{% endhighlight %}

{% highlight C# %}

    comboBox.SelectionTextHighlightColor = Colors.Green;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox Selection Text Highlight Color](Images/UICustomization/SelectionTextHighlightColor.png)

## CustomView for ComboBox

[CustomView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_CustomView) property has used to provide the custom view instead of entry in ComboBox. It's default height and width has control height and width.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    HeightRequest="40"
                    WidthRequest="240">
    <editors:SfComboBox.CustomView>
        <Label x:Name="customLabel"  Text="Custom View"  
               TextColor="Red"
               HorizontalOptions="Center"
               VerticalTextAlignment="Center"/>
    </editors:SfComboBox.CustomView>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

var customLabel = new Label();
customLabel.TextColor = Colors.Red;
customLabel.VerticalTextAlignment = TextAlignment.Center;
customLabel.HorizontalOptions = LayoutOptions.Center;
customLabel.Text = "Custom View";

comboBox.CustomView = customLabel; 

{% endhighlight %}

{% endtabs %}

![CustomView](images/UICustomization/CustomView.png)

N> `SfComboBox` ClearButton will not be supported when using Custom View.

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
            <DataTemplate>
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

DropDown items can be customized using the [DropDownItemFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontAttributes), [DropDownItemFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontFamily), [DropDownItemFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontSize), and [DropDownItemTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemTextColor) properties.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    Placeholder="Enter Media"
                    DropDownItemFontAttributes="Italic"
                    DropDownItemFontFamily="OpenSansSemibold"
                    DropDownItemFontSize="16"
                    DropDownItemTextColor="DarkViolet" />

{% endhighlight %}

{% highlight C# %}

    comboBox.DropDownItemFontAttributes = FontAttributes.Italic;
    comboBox.DropDownItemFontFamily = "OpenSansSemibold";
    comboBox.DropDownItemFontSize = 16;
    comboBox.DropDownItemTextColor = Colors.DarkViolet;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox DropDown Item Text](Images/UICustomization/DropDownItemText.png)

### Customize the DropDown background color

The [DropDownBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownBackground) property is used to modify the background color of the dropdown.

{% tabs %}
{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                            WidthRequest="250"
                            ItemsSource="{Binding SocialMedias}"
                            DisplayMemberPath="Name"
                            TextMemberPath="Name"
                            Placeholder="Enter Media"
                            DropDownBackground="YellowGreen" />

{% endhighlight %}

{% highlight C# %}

    comboBox.DropDownBackground = Colors.YellowGreen;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox DropDown Background](Images/UICustomization/DropDownBackground.png)

### Customize the DropDown selected item backgroundcolor

The [SelectedDropDownItemBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedDropDownItemBackground) property is used to modify the backgroundcolor of selected item in the dropdown.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        SelectedDropDownItemBackground="LightSeaGreen" />

{% endhighlight %}

{% highlight C# %}

    comboBox.SelectedDropDownItemBackground = Colors.LightSeaGreen;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox Selected DropDown Item Background](Images/UICustomization/SelectedDropDownItemBackground.png)

### Customize the DropDown Border Color

The [DropDownStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownStroke) property is used to modify the border color of the dropdown.

{% tabs %}
{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                            WidthRequest="250"
                            ItemsSource="{Binding SocialMedias}"
                            DisplayMemberPath="Name"
                            TextMemberPath="Name"
                            Placeholder="Enter Media"
                            DropDownStroke="DarkOrange" />

{% endhighlight %}

{% highlight C# %}

    comboBox.DropDownStroke = Colors.DarkOrange;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox DropDown Stroke](Images/UICustomization/DropDownStroke.png)

### Customize the DropDown Border Thickness

The [DropDownStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownStrokeThickness) property is used to modify the thickness of the dropdown border.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        DropDownStroke="DarkOrange"
                        DropDownStrokeThickness="5" />

{% endhighlight %}

{% highlight C# %}

    comboBox.DropDownStrokeThickness = 5;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox DropDown StrokeThickness](Images/UICustomization/DropDownStrokeThickness.png)

### Customize the DropDown Item Height

The [DropDownItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemHeight) property is used to modify the height of the dropdown items.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                        WidthRequest="250"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        DropDownItemHeight="25" />

{% endhighlight %}

{% highlight C# %}

    comboBox.DropDownItemHeight = 25;

{% endhighlight %}
{% endtabs %}

![.NET MAUI ComboBox DropDown Item Height](Images/UICustomization/DropDownItemHeight.png)

### Customize the DropDownPlacement

The drop-down that shows the filtered items will be placed automatically based on the available space and can also be customized using the `DropDownPlacement` property.

*   `Top` - Drop-down will be placed above the text box.

*   `Bottom` - Drop-down will be placed below the text box.

*   `Auto` - Drop-down will be placed based on the available space either top or bottom of the text box.

*   `None` - Drop-down will not be shown with the filtered items.


{% tabs %}
{% highlight xaml %}

 <editors:SfComboBox x:Name="comboBox"
                         WidthRequest="300"                  
                         ItemsSource="{Binding SocialMedias}"
                         DropDownPlacement="Top"/>

{% endhighlight %}

{% highlight C# %}

comboBox.DropDownPlacement = DropDownPlacement.Top;

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox Dropdownplacement.](Images/UICustomization/placementcombo.png)

### Customize the DropDown ItemPadding

The comboBox enables the user to provide padding for the items inside dropdown using `ItemPadding` property.

{% tabs %}
{% highlight xaml %}

   <editors:SfComboBox x:Name="comboBox"
                         WidthRequest="300"                          
                         ItemsSource="{Binding SocialMedias}"
                         ItemPadding="10,20,0,0"/>

{% endhighlight %}

{% highlight C# %}

comboBox.ItemPadding = new Thickness(10,20,0,0);

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox Itempadding.](Images/UICustomization/Itempadding.png)

### Customize the DropDown Width

The `DropdownWidth` property is used to modify the Width of the dropdown.

{% tabs %}
{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                         WidthRequest="300"                            
                         ItemsSource="{Binding SocialMedias}"                           
                         DropdownWidth="400"/>

{% endhighlight %}

{% highlight C# %}

comboBox.DropdownWidth = 400;

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox DropDownWidth.](Images/UICustomization/DropDownWidth.png)


### Show suggestion box on focus

Suggestion box can be shown whenever the control receives focus using the `ShowSuggestionsOnFocus` property. At this time, suggestion list is the complete list of data source.

{% tabs %}
{% highlight xaml %}

      <editors:SfComboBox x:Name="comboBox"
                          WidthRequest="300"                            
                          ItemsSource="{Binding SocialMedias}"                           
                          ShowSuggestionsOnFocus="True"/>


{% endhighlight %}

{% highlight C# %}

comboBox.ShowSuggestionsOnFocus = true;

{% endhighlight %}

{% endtabs %}

![.NET MAUI ComboBox OnFocus.](Images/UICustomization/OnFocus.png)

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

    <Grid>
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

## DropDown button customization

We can set view to the drop down button in [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) using [DropDownButtonSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_DropDownButtonSettings) property.
{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                     TextMemberPath="Name"
                    DisplayMemberPath="Name"
                    HeightRequest="40"
                    WidthRequest="240">
    <editors:SfComboBox.DropDownButtonSettings>
        <editors:DropDownButtonSettings>
            <editors:DropDownButtonSettings.View>
            <Label Text="Click" FontSize="12" TextColor="Blue"
                   VerticalOptions="Center" />
            </editors:DropDownButtonSettings.View>
        </editors:DropDownButtonSettings>
    </editors:SfComboBox.DropDownButtonSettings>
    
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

var dropDownButtonSettings = new DropDownButtonSettings();
var label = new Label
{
    Text="Click";
    FontSize="12"; 
    TextColor="Blue";
    VerticalOptions="Center" 
};
dropDownButtonSettings.View = label;
comboBox.DropDownButtonSettings = dropDownButtonSettings;
{% endhighlight %}

{% endtabs %}

![CustomView](images/UICustomization/DropDownButtonSettings_View.png)

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

The [DropDownOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_DropdownOpening) event will be fired whenever opening the dropdown menu in the SfComboBox. It can cancel dropdown opening with CancelEventArgs that contains the following property:

 * Cancel: Dropdown opening is based on this value.

{% tabs %}

{% highlight xaml %}

     <editors:SfComboBox x:Name="comboBox"
                         DropdownOpening="comboBox_DropdownOpening"
                         WidthRequest="350"
                         HeightRequest="50"
                         ItemsSource="{Binding SocialMedias}"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name">
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

The [DropDownOpened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_DropdownOpened) event occurs when the SfComboBox drop-down is opened.

{% tabs %}

{% highlight xaml %}

    <editors:SfComboBox x:Name="comboBox"
                        DropdownOpened="comboBox_DropdownOpened"
                        WidthRequest="350"
                        HeightRequest="50"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name">   
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

The [DropDownClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownClosed) event occurs when the SfComboBox drop-down is closed.

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

The [ShowBorder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_ShowBorder) property of [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) is used to modify the visibility of the border and its default value is **true**. The following code example demonstrates how to change the border visibility,

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

## TextAlignment

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) provides support to customize the text alignment by using the [HorizontalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_HorizontalTextAlignment) and [VerticalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_VerticalTextAlignment) properties.

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
