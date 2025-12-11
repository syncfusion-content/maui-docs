---
layout: post
title: UI Customization in .NET MAUI Autocomplete control | Syncfusion®
description: Learn all about UI customization support in Syncfusion® .NET MAUI Autocomplete control into .NET MAUI application and its features here.
platform: maui
control: SfAutocomplete
documentation: ug
---

# UI Customization in .NET MAUI Autocomplete (SfAutocomplete)

This section explains different UI customizations available in the [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control.

To get start quickly to customize the Appearance of .NET MAUI Autocomplete, you can check on this video:

{% youtube "https://www.youtube.com/watch?v=Hh5pfXvax9o" %}

## Placeholder

You can prompt the user with any information by using the [Placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_Placeholder) property. This text will be displayed only if no items are selected or the edit text is empty. The default value of the Placeholder property is `string.Empty` (No string will be displayed).

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        Placeholder="Select a social media"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    Placeholder = "Select a social media",
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete placeholder](Images/UICustomization/Placeholder.png)

## Placeholder Color

The placeholder text color can be changed by using the [PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_PlaceholderColor) property. The default value of the PlaceholderColor property is `Colors.Gray`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        PlaceholderColor="Red" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Select a social media",
    PlaceholderColor = Colors.Red
};

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete placeholder color](Images/UICustomization/PlaceholderColor.png)

## Clear Button Icon Color

The clear button icon color can be changed by using the [ClearButtonIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_ClearButtonIconColor) property. The default value of the ClearButtonIconColor property is `Colors.Black`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        PlaceholderColor="Red"
                        ClearButtonIconColor="Red" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Select a social media",
    PlaceholderColor = Colors.Red,
    ClearButtonIconColor = Colors.Red
};

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete clear button color](Images/UICustomization/ClearButtonColor.png)

## Stroke

The Autocomplete border color can be changed by using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_Stroke) property.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Select a social media"
                        PlaceholderColor="Red"
                        Stroke="Red" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Select a social media",
    PlaceholderColor = Colors.Red,
    Stroke = Colors.Red
};

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code.

![.NET MAUI Autocomplete border color](Images/UICustomization/BorderColor.png)

## Customize the selection text highlightColor 

The [SelectionTextHighlightColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionTextHighlightColor) property is used to modify the background color of the selected item text in the autocomplete control.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        SelectionTextHighlightColor="Green" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    SelectionTextHighlightColor = Colors.Green
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete Selection Text Highlight Color](Images/UICustomization/SelectionTextHighlightColor.png)

## Maximum DropDown Height

The maximum height of the drop-down can be changed by using the [MaxDropDownHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_MaxDropDownHeight) property of the `Autocomplete` control. The default value of the MaxDropDownHeight property is `400d`. 

N> If the `MaxDropDownHeight` is too small compared to the populated items, the scroll viewer will be automatically shown to navigate the hidden items.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        MaxDropDownHeight = "100"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name" />

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    MaxDropDownHeight = 100,
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete maximum drop-down height](Images/UICustomization/MaxDropDownHeight.png)

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

    <editors:SfAutocomplete Placeholder="Enter an employee"
                            TextMemberPath="Name"
                            DisplayMemberPath="Name"
                            ItemsSource="{Binding Employees}"
                            x:Name="autoComplete">
        <editors:SfAutocomplete.BindingContext>
            <local:EmployeeViewModel/>
        </editors:SfAutocomplete.BindingContext>
        <editors:SfAutocomplete.ItemTemplate>
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
        </editors:SfAutocomplete.ItemTemplate>
    </editors:SfAutocomplete>

{% endhighlight %}
{% highlight C# %}

    EmployeeViewModel employee = new EmployeeViewModel();

    SfAutocomplete autoComplete = new()
    {
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
    autoComplete.ItemTemplate = itemTemplate;


{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete ItemTemplate](Images/UICustomization/ItemTemplate.png)

### Customize the DropDown item text

DropDown items can be customized using the [DropDownItemFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontAttributes), [DropDownItemFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontFamily), [DropDownItemFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontSize), and [DropDownItemTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemTextColor) properties.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
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

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    DropDownItemFontAttributes = FontAttributes.Italic,
    DropDownItemFontFamily = "OpenSansSemibold",
    DropDownItemFontSize = 16,
    DropDownItemTextColor = Colors.DarkViolet
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete DropDown Item Text](Images/UICustomization/DropDownItemText.png)

### Customize the DropDown background color

The [DropDownBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownBackground) property is used to modify the background color of the dropdown.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        DropDownBackground="YellowGreen" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    DropDownBackground = Colors.YellowGreen
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete DropDown Background](Images/UICustomization/DropDownBackground.png)

### Customize the DropDown selected item background color

The [SelectedDropDownItemBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedDropDownItemBackground) property is used to modify the background color of the selected item in the dropdown.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        SelectedDropDownItemBackground="LightSeaGreen" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    ItemsSource = socialMediaViewModel.SocialMedias;
    DisplayMemberPath = "Name";
    TextMemberPath = "Name";
    Placeholder = "Enter Media";
    SelectedDropDownItemBackground = Colors.LightSeaGreen;
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete Selected DropDown Item Background](Images/UICustomization/SelectedDropDownItemBackground.png)

### Customize the Selected DropDown Item Text Style

The [SelectedDropDownItemTextStyle]() property in the SfAutoComplete control allows developers to customize the appearance of the selected item in the dropdown list. This feature is useful for highlighting user selections and improving the overall UI experience.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autoComplete" DisplayMemberPath = "Name" TextMemberPath = "Name" ItemsSource="{Binding SocialMedias}">
    <editors:SfAutocomplete.SelectedDropDownItemTextStyle>
        <editors:DropDownTextStyle TextColor="Orange" FontSize="16" FontAttributes="Bold"/>
    </editors:SfAutocomplete.SelectedDropDownItemTextStyle>
</editors:SfAutocomplete>

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autoComplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    SelectedDropDownItemTextStyle = new DropDownTextStyle
    {
        TextColor = Colors.Orange,
        FontSize = 16,
        FontAttributes = FontAttributes.Bold
    }
};

{% endhighlight %}
{% endtabs %}

### Customize the DropDown Border Color

The [DropDownStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownStroke) property is used to modify the border color of the dropdown.

{% tabs %}
{% highlight xaml %}
<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        DropDownStroke="DarkOrange" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    DropDownStroke = Colors.DarkOrange
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete DropDown Stroke](Images/UICustomization/DropDownStroke.png)

### Customize the DropDown Border Thickness

The [DropDownStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownStrokeThickness) property is used to modify the thickness of the dropdown border.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        DropDownStroke="DarkOrange"
                        DropDownStrokeThickness="5" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    DropDownStroke = Color.DarkOrange,
    DropDownStrokeThickness = 5
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete DropDown Stroke Thickness](Images/UICustomization/DropDownStrokeThickness.png)

### Customize the visibility of Dropdown Shadow

The [IsDropDownShadowVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_IsDropDownShadowVisible) property is used to customize the visibility of the dropdown shadow.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        IsDropDownShadowVisible="False" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    IsDropDownShadowVisible = False
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete Dropdown shadow visibility is false](Images/UICustomization/DropdownShadowVisible.png)

### Customize the DropDown Item Height

The [DropDownItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemHeight) property is used to modify the height of the dropdown items.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        Placeholder="Enter Media"
                        DropDownItemHeight="80" />

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter Media",
    DropDownItemHeight = 80
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete DropDown Item Height](Images/UICustomization/DropDownItemHeight.png)

### Customize the DropDownPlacement

The drop-down that shows the filtered items will be placed automatically based on the available space and can also be customized using the `DropDownPlacement` property.

*   `Top` - Drop-down will be placed above the text box.

*   `Bottom` - Drop-down will be placed below the text box.

*   `Auto` - Drop-down will be placed based on the available space either top or bottom of the text box.

*   `None` - Drop-down will not be shown with the filtered items.


{% tabs %}
{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autocomplete"
                         ItemsSource="{Binding SocialMedias}"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name"
                         DropDownPlacement="Top"/>

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    DropDownPlacement = AutocompleteDropDownPlacement.Top
};


{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete Dropdownplacement.](Images/UICustomization/placementauto.png)

### Customize the DropDown ItemPadding

The autocomplete enables the user to provide padding for the items inside dropdown using `ItemPadding` property.

{% tabs %}
{% highlight xaml %}

   <editors:SfAutocomplete x:Name="autocomplete"
                           ItemsSource="{Binding SocialMedias}"
                           DisplayMemberPath="Name"
                           TextMemberPath="Name"
                           ItemPadding="10,20,0,0"/>

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemPadding = new Thickness(10, 20, 0, 0)
};


{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete Itempadding.](Images/UICustomization/Itempadding.png)

### Customize the DropDown Width

The `DropdownWidth` property is used to modify the Width of the dropdown.

{% tabs %}
{% highlight xaml %}

    <editors:SfAutocomplete x:Name="autocomplete"
                            ItemsSource="{Binding SocialMedias}"
                            DisplayMemberPath="Name"
                            TextMemberPath="Name"                           
                            DropdownWidth="400"/>

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    DropDownWidth = 400
};


{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete DropDownWidth.](Images/UICustomization/DropDownWidth.png)


### Show suggestion box on focus

Suggestion box can be shown whenever the control receives focus using the `ShowSuggestionsOnFocus` property. At this time, suggestion list is the complete list of data source.

{% tabs %}

{% highlight xaml %}

      <editors:SfAutocomplete x:Name="autocomplete"
                              ItemsSource="{Binding SocialMedias}"
                              DisplayMemberPath="Name"
                              TextMemberPath="Name"                           
                              ShowSuggestionsOnFocus="True"/>

{% endhighlight %}

{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ShowSuggestionsOnFocus = true
};


{% endhighlight %}

{% endtabs %}

![.NET MAUI Autocomplete OnFocus.](Images/UICustomization/OnFocus.png)

## Customize DropDown (suggestion) items based on condition

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

        <editors:SfAutocomplete Placeholder="Enter an employee"
                                TextMemberPath="Name"
                                DisplayMemberPath="Name"
                                ItemsSource="{Binding Employees}"
                                SelectedItem="{Binding SelectedEmployee,Mode=TwoWay}"
                                x:Name="autoComplete"
                                ItemTemplate="{StaticResource employeeTemplateSelector}">
            <editors:SfAutocomplete.BindingContext>
                <local:EmployeeViewModel/>
            </editors:SfAutocomplete.BindingContext>
        </editors:SfAutocomplete>
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

    SfAutocomplete autoComplete = new()
    {
        BindingContext = employee,
        ItemsSource = employee.Employees,
        DisplayMemberPath = "Name",
        Placeholder = "Enter an employee",
        TextMemberPath = "Name", 
        ItemTemplate = employeeTemplateSelector,
    };

    this.Content = autoComplete;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete ItemTemplateSelector](Images/UICustomization/TemplateSelector.png)

## Styling token items

The Autocomplete control allows you to customize the style of the TokenItem generated in the selection area by using the TokenItemStyle property.

{% tabs %}

{% highlight xaml %}

 ...
  xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
  xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
 ...

  <editors:SfAutocomplete x:Name="autoComplete"
                        SelectionMode="Multiple"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name" > 
       <editors:SfAutocomplete.TokenItemStyle>
           <Style TargetType="core:SfChipGroup">
               <Setter Property="ChipTextColor" Value="White"/>
               <Setter Property="ChipFontAttributes" Value="Bold"/>
               <Setter Property="CloseButtonColor" Value="White"/>
               <Setter Property="ChipBackground" Value="#d3a7ff"/>
               <Setter Property="ChipStroke" Value="#5118e3"/>
               <Setter Property="ChipStrokeThickness" Value="6"/>
               <Setter Property="ChipCornerRadius" Value="18"/>
           </Style>
       </editors:SfAutocomplete.TokenItemStyle>
   </editors:SfAutocomplete>

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete with tokenitemstyle](Images/UICustomization/TokenItemStyle.png)

## Completed Event

The [Completed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Completed) event is raised when the user finalizes the text in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) by pressing return key on the keyboard.The handler for the event is a generic event handler, taking the `sender` and `EventArgs`(the `EventArgs` value is `string.Empty`):

{% tabs %}
{% highlight xaml %}

    <editors:SfAutocomplete x:Name="autoComplete"
                            ItemsSource="{Binding SocialMedias}"
                            DisplayMemberPath="Name"
                            TextMemberPath="Name"
                            Completed="autoComplete_Completed" />

{% endhighlight %}
{% highlight C# %}

private async void autoComplete_Completed(object sender, EventArgs e)
{
    await DisplayAlert("Message", "Text entering Completed", "close");
}

{% endhighlight %}
{% endtabs %}

Completed event can be subscribed in C# also:

{% tabs %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};
autoComplete.Completed+=autoComplete_Completed;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete completed event](Images/UICustomization/CompletedEvent.png)

N> The `Completed` event is not supported in the Android platform.

## DropDownOpening Event

The [DropDownOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_DropdownOpening) event will be fired whenever opening the dropdown menu in the SfAutocomplete. It can cancel dropdown opening with CancelEventArgs that contains the following property:

 * Cancel: Dropdown opening is based on this value.

{% tabs %}

{% highlight xaml %}

    <editors:SfAutocomplete x:Name="autoComplete"
                            DropdownOpening="Autocomplete_DropdownOpening"
                            ItemsSource="{Binding SocialMedias}"
                            DisplayMemberPath="Name"
                            TextMemberPath="Name">
    </editors:SfAutocomplete>
    
{% endhighlight %}

{% highlight c# %}

    SfAutocomplete autoComplete = new SfAutocomplete
    {
        ItemsSource = socialMediaViewModel.SocialMedias,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name"
    };
    autoComplete.DropdownOpening += Autocomplete_DropdownOpening;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
 private void Autocomplete_DropdownOpening(object sender, CancelEventArgs e)
 {
     e.Cancel = true; // If you want to restrict the dropdown open then set the e.Cancel is true. 
 }
 
{% endhighlight %}

{% endtabs %}


## DropDownOpened Event

The [DropDownOpened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_DropdownOpened) event occurs when the SfAutocomplete drop-down is opened.

{% tabs %}

{% highlight xaml %}

     <editors:SfAutocomplete x:Name="autoComplete" 
                             DropdownOpened="autoComplete_DropdownOpened"
                             ItemsSource="{Binding SocialMedias}"
                             DisplayMemberPath="Name"
                             TextMemberPath="Name">
     </editors:SfAutocomplete>
 
{% endhighlight %}

{% highlight c# %}

    SfAutocomplete autoComplete = new SfAutocomplete
    {
        ItemsSource = socialMediaViewModel.SocialMedias,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name"
    };
    autoComplete.DropdownOpened += autoComplete_DropdownOpened;
    

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}

  private void autoComplete_DropdownOpened(object sender, EventArgs e)
  {
    // Trigger when the dropdown is opened
  }
   
{% endhighlight %}

{% endtabs %}

## DropDownClosed Event

The [DropDownClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownClosed) event occurs when the SfAutocomplete drop-down is closed.

{% tabs %}
{% highlight xaml %}

    
    <editors:SfAutocomplete x:Name="autoComplete" 
                            ItemsSource="{Binding SocialMedias}"
                            DisplayMemberPath="Name"
                            TextMemberPath="Name"
                            DropDownClosed="SfAutocomplete_DropDownClosed">
    </editors:SfAutocomplete>
{% endhighlight %}
{% highlight c# %}

    SfAutocomplete autoComplete = new SfAutocomplete
    {
        ItemsSource = socialMediaViewModel.SocialMedias,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name"
    };
    autoComplete.DropDownClosed += SfAutocomplete_DropDownClosed;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
    
    private void SfAutocomplete_DropDownClosed(object sender, EventArgs e)
    {
        await DisplayAlert("Message", "DropDown Closed", "close");
    }

{% endhighlight %}
{% endtabs %}

## ValueChanged Event
When the value of Autocomplete changes, the [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ValueChanged) event is triggered. This event is raised when the value changes due to user interaction, programmatic updates, or any other mechanism. It provides both `OldValue` and `NewValue`, allowing for responsive handling of changes. The ValueChanged event contains the following properties:

* `OldValue` – Contains the previous text value before the change.
* `NewValue` – Contains the new text value after the change.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"  
                    TextMemberPath="Name" 
                    DisplayMemberPath="Name" 
                    ItemsSource="{Binding SocialMedias}" 
                    ValueChanged="OnValueChanged" />

{% endhighlight %}

{% highlight C# %}

SfAutoComplete autocomplete = new SfAutoComplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};
autocomplete.ValueChanged += OnValueChanged;

{% endhighlight %}

{% endtabs %}

The ValueChanged event can be handled as follows:

{% tabs %}
{% highlight C# %}

private async void OnValueChanged(object sender, AutocompleteValueChangedEventArgs e)
{
    await DisplayAlert("Alert", "Value has changed to: " + e.NewValue.ToString(), "Ok");
}

{% endhighlight %}

{% endtabs %} 
 

## CursorPosition

The cursor position in the input view can be obtained or updated using the [CursorPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_CursorPosition) property in the SfAutocomplete.

{% tabs %}
{% highlight xaml %}

    <editors:SfAutocomplete x:Name="autoComplete"
                            CursorPosition = "4" />
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Inputs;

    SfAutocomplete autocomplete = new SfAutocomplete
    {
        CursorPosition = 4,
    };

{% endhighlight %}
{% endtabs %}

N> Two way binding not supported in Android platform.

## Border visibility

The [ShowBorder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ShowBorder) property of [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) is used to modify the visibility of the border and its default value is **true**. The following code example demonstrates how to change the border visibility,

{% tabs %}
{% highlight xaml %}

    <editors:SfAutocomplete x:Name="autoComplete"
                            ShowBorder = "False" />
{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Inputs;

    SfAutocomplete autocomplete = new SfAutocomplete
    {
        ShowBorder = false,
    };

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![ShowBorder](Images/UICustomization/ShowBorder.png)

## TextAlignment

The [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) provides support to customize the text alignment by using the [HorizontalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_HorizontalTextAlignment) and [VerticalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_VerticalTextAlignment) properties.

N> Dynamic changes to the `HorizontalTextAlignment` property may not be functioning as expected on Android platform.

{% tabs %}
{% highlight xaml %}

    <editors:SfAutocomplete x:Name="autoComplete"
                            HorizontalTextAlignment="Center" 
                            VerticalTextAlignment="Start"/>
{% endhighlight %}
{% highlight c# %}

    SfAutocomplete autocomplete = new SfAutocomplete
    {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Start,
    };

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![TextAlignment](Images/UICustomization/TextAlignment.png)

## ReturnType

The `ReturnType` property specifies the return button (e.g., Next, Done, Go) of the keyboard. It helps manage the flow between multiple input fields by defining what happens when the action button is pressed.

You can define the return key type of [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) by using the ReturnType property.

N> Default value of ReturnType is `Default`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
            ItemsSource="{Binding SocialMedias}"
            DisplayMemberPath="Name"
            TextMemberPath="Name" 
            ReturnType="Next"/>

{% endhighlight %}
{% highlight C# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ReturnType = ReturnType.Next
};


{% endhighlight %}
{% endtabs %}

![.NET MAUI Autocomplete ReturnType](Images/UICustomization/ReturnType.png)

## Clear button customization

The `ClearButtonPath` property allows users to set the path for customizing the appearance of the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) clear button.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autoComplete"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name">
            <editors:SfAutocomplete.ClearButtonPath>
                <Path Data="M1.70711 0.292893C1.31658 -0.097631 0.683417 -0.097631 0.292893 0.292893C-0.097631 0.683417 -0.097631 1.31658 0.292893 1.70711L5.58579 7L0.292893 12.2929C-0.097631 12.6834 -0.097631 13.3166 0.292893 13.7071C0.683417 14.0976 1.31658 14.0976 1.70711 13.7071L7 8.41421L12.2929 13.7071C12.6834 14.0976 13.3166 14.0976 13.7071 13.7071C14.0976 13.3166 14.0976 12.6834 13.7071 12.2929L8.41421 7L13.7071 1.70711C14.0976 1.31658 14.0976 0.683417 13.7071 0.292893C13.3166 -0.097631 12.6834 -0.097631 12.2929 0.292893L7 5.58579L1.70711 0.292893Z" 
                Fill="Red" 
                Stroke="Red"/>
            </editors:SfAutocomplete.ClearButtonPath>
</editors:SfAutocomplete>

{% endhighlight %}
{% highlight c# %}

private string _customPath = "M1.70711 0.292893C1.31658 -0.097631 0.683417 -0.097631 0.292893 0.292893C-0.097631 0.683417 -0.097631 1.31658 0.292893 1.70711L5.58579 7L0.292893 12.2929C-0.097631 12.6834 -0.097631 13.3166 0.292893 13.7071C0.683417 14.0976 1.31658 14.0976 1.70711 13.7071L7 8.41421L12.2929 13.7071C12.6834 14.0976 13.3166 14.0976 13.7071 13.7071C14.0976 13.3166 14.0976 12.6834 13.7071 12.2929L8.41421 7L13.7071 1.70711C14.0976 1.31658 14.0976 0.683417 13.7071 0.292893C13.3166 -0.097631 12.6834 -0.097631 12.2929 0.292893L7 5.58579L1.70711 0.292893Z";

var converter = new PathGeometryConverter();
var path = new Path() 
{ 
    Data = (PathGeometry)converter.ConvertFromInvariantString(_customPath),
    Fill = Colors.Red,
    Stroke = Colors.Red
};

SfAutocomplte autocomplete = new SfAutocomplte();
autocomplete.ItemsSource = viewModel.SocialMedia;
autocomplete.DisplayMemberPath = "Name";
autocomplete.TextMemberPath = "Name";
autocomplete.ClearButtonPath = path;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI Autocomplete ClearButtonPath](Images/UICustomization/clearbuttoncustomization.png)

## Return Command and Return Command Parameter

- `ReturnCommand`, of type ICommand, defines the command to be executed when the return key is pressed.
- `ReturnCommandParameter`, of type object, specifies the parameter for the `ReturnCommand`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                    ItemsSource="{Binding SocialMedia}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    ReturnCommand="{Binding AlertCommand}"
                    ReturnCommandParameter="Return key is pressed"/>

{% endhighlight %}
{% highlight c# %}

SfAutocomplete autocomplete = new SfAutocomplete
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ReturnCommand = socialMediaViewModel.AlertCommand,
    ReturnCommandParameter = "Return key is pressed"
};

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

public SocialMediaViewModel
{
    public ICommand AlertCommand => new Command<string>(OnAlertCommandExecuted);

    private async void OnAlertCommandExecuted(string parameter)
    {
        await Application.Current.MainPage.DisplayAlert("Alert", parameter, "OK");
    }
}

{% endhighlight %}
{% endtabs %}
