---
layout: post
title: Stacked Headers in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to create and customize stacked headers in Syncfusion® .NET MAUI Tree Grid to group related columns under common header categories.
platform: MAUI
control: SfTreeGrid
documentation: ug
appliesto: UI Component Suite
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid, stacked header, maui treegrid stacked header, stacked column, multilevel header
---

# Stacked Headers in .NET MAUI Tree Grid

The [.NET MAUI Tree Grid](https://www.syncfusion.com/maui-controls/maui-treegrid) supports displaying additional unbound, multiple or multilevel header rows known as [StackedHeaderRows]() that span across multiple TreeGrid columns. These headers can be used to group one or more related columns under a common category, providing better visual organization for complex hierarchical data.

Each [TreeGridStackedHeaderRow]() contains a collection of stacked columns through its [Columns]() property. The [TreeGridStackedColumn.ColumnMappingNames]() property specifies the comma-separated column mapping names that are grouped under the stacked header. The [TreeGridStackedColumn.MappingName]() property uniquely identifies the stacked column, while the [TreeGridStackedColumn.Text]() property defines the text displayed in the stacked header cell.

## Adding stacked headers

Stacked headers can be added using the following steps:

1. Create a `TreeGridStackedHeaderRow` instance for each stacked header row.
2. Create `TreeGridStackedColumn` instances and specify the grouped child columns using the `ColumnMappingNames` property.
3. Set the header label using the `Text` property.
4. Add the `TreeGridStackedColumn` instances to the `Columns` collection of the `TreeGridStackedHeaderRow`.
5. Finally, add the `TreeGridStackedHeaderRow` to the [StackedHeaderRows]() collection of the `SfTreeGrid`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"
             xmlns:local="clr-namespace:YourAppNamespace"
             x:Class="YourAppNamespace.MainPage">

    <ContentPage.BindingContext>
        <local:EmployeeViewModel />
    </ContentPage.BindingContext>

    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           ItemsSource="{Binding PersonDetails}"
                           ChildPropertyName="Children">
        <syncfusion:SfTreeGrid.StackedHeaderRows>
            <syncfusion:TreeGridStackedHeaderRow>
                <syncfusion:TreeGridStackedHeaderRow.Columns>
                    <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName,EmployeeId,Salary"
                                                      Text="Organization Overview"
                                                      MappingName="OrganizationOverview"/>
                </syncfusion:TreeGridStackedHeaderRow.Columns>
            </syncfusion:TreeGridStackedHeaderRow>

            <syncfusion:TreeGridStackedHeaderRow>
                <syncfusion:TreeGridStackedHeaderRow.Columns>
                    <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName"
                                                      Text="Personal Details"
                                                      MappingName="PersonalDetails"/>
                    <syncfusion:TreeGridStackedColumn ColumnMappingNames="EmployeeId,Salary"
                                                      Text="Work Details"
                                                      MappingName="WorkDetails"/>
                </syncfusion:TreeGridStackedHeaderRow.Columns>
            </syncfusion:TreeGridStackedHeaderRow>
        </syncfusion:SfTreeGrid.StackedHeaderRows>
    </syncfusion:SfTreeGrid>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId,Salary",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Second level stacked header row
var subStackedRow = new TreeGridStackedHeaderRow();
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName",
    Text = "Personal Details",
    MappingName = "PersonalDetails",
});
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "EmployeeId,Salary",
    Text = "Work Details",
    MappingName = "WorkDetails",
});

treeGrid.StackedHeaderRows.Add(subStackedRow);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Adding child columns dynamically

You can add child columns to an existing stacked header row at runtime by updating the `ColumnMappingNames` property of the corresponding `TreeGridStackedColumn`.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Append a new column mapping name to an existing stacked column
var existingMappings = treeGrid.StackedHeaderRows[0].Columns[0].ColumnMappingNames;
treeGrid.StackedHeaderRows[0].Columns[0].ColumnMappingNames = existingMappings + ",Salary";

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Removing child columns dynamically

Similarly, you can remove child columns from a stacked header row at runtime by removing the corresponding column mapping names from the `ColumnMappingNames` property.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId,Salary",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Remove column mapping name from the existing stacked column
var columnsList = treeGrid.StackedHeaderRows[0].Columns[0].ColumnMappingNames.Split(',').ToList();
columnsList.Remove("Salary");
treeGrid.StackedHeaderRows[0].Columns[0].ColumnMappingNames = string.Join(",", columnsList);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Changing stacked header row height

You can change the height of all header rows, including stacked header rows, by setting the [SfTreeGrid.HeaderRowHeight]() property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       HeaderRowHeight="60">
    <syncfusion:SfTreeGrid.StackedHeaderRows>
        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName,EmployeeId,Salary"
                                                  Text="Organization Overview"
                                                  MappingName="OrganizationOverview"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>

        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName"
                                                  Text="Personal Details"
                                                  MappingName="PersonalDetails"/>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="EmployeeId,Salary"
                                                  Text="Work Details"
                                                  MappingName="WorkDetails"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>
    </syncfusion:SfTreeGrid.StackedHeaderRows>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.HeaderRowHeight = 60; // Set the height of the header row

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId,Salary",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Second level stacked header row
var subStackedRow = new TreeGridStackedHeaderRow();
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName",
    Text = "Personal Details",
    MappingName = "PersonalDetails",
});
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "EmployeeId,Salary",
    Text = "Work Details",
    MappingName = "WorkDetails",
});

treeGrid.StackedHeaderRows.Add(subStackedRow);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

You can also customize the height of specific stacked header rows individually using the [SfTreeGrid.QueryRowHeight]() event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       QueryRowHeight="treeGrid_QueryRowHeight">
    <syncfusion:SfTreeGrid.StackedHeaderRows>
        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName,EmployeeId,Salary"
                                                  Text="Organization Overview"
                                                  MappingName="OrganizationOverview"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>
    </syncfusion:SfTreeGrid.StackedHeaderRows>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void treeGrid_QueryRowHeight(object sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex == 0) // Customize Logic as required.
    {
        e.Height = 60;
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Styling stacked headers

The appearance of stacked headers can be customized using default styling properties or implicit styles targeting stacked header cells.

### Customizing appearance via DefaultStyle

You can customize the background color and text color of stacked header rows using the [TreeGridStyle.StackedHeaderRowBackground]() and [TreeGridStyle.StackedHeaderRowTextColor]() properties in [SfTreeGrid.DefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_DefaultStyle).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle StackedHeaderRowBackground="#4750DD"
                                    StackedHeaderRowTextColor="White"/>
    </syncfusion:SfTreeGrid.DefaultStyle>

    <syncfusion:SfTreeGrid.StackedHeaderRows>
        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName,EmployeeId,Salary"
                                                  Text="Organization Overview"
                                                  MappingName="OrganizationOverview"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>

        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName"
                                                  Text="Personal Details"
                                                  MappingName="PersonalDetails"/>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="EmployeeId,Salary"
                                                  Text="Work Details"
                                                  MappingName="WorkDetails"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>
    </syncfusion:SfTreeGrid.StackedHeaderRows>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId,Salary",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Second level stacked header row
var subStackedRow = new TreeGridStackedHeaderRow();
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName",
    Text = "Personal Details",
    MappingName = "PersonalDetails",
});
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "EmployeeId,Salary",
    Text = "Work Details",
    MappingName = "WorkDetails",
});

treeGrid.StackedHeaderRows.Add(subStackedRow);

// Set the stacked header row background and text color
treeGrid.DefaultStyle.StackedHeaderRowBackground = Color.FromArgb("#4750DD");
treeGrid.DefaultStyle.StackedHeaderRowTextColor = Colors.White;

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

### Font customization

Customize the font size, font family, and font attributes of stacked header text using the [TreeGridStyle.StackedHeaderRowFontSize](), [TreeGridStyle.StackedHeaderRowFontFamily](), and [TreeGridStyle.StackedHeaderRowFontAttributes]() properties, respectively.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle StackedHeaderRowFontSize="20"
                                  StackedHeaderRowFontFamily="Helvetica Neue"
                                  StackedHeaderRowFontAttributes="Bold"/>
    </syncfusion:SfTreeGrid.DefaultStyle>

    <syncfusion:SfTreeGrid.StackedHeaderRows>
        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName,EmployeeId,Salary"
                                                  Text="Organization Overview"
                                                  MappingName="OrganizationOverview"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>

        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName"
                                                  Text="Personal Details"
                                                  MappingName="PersonalDetails"/>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="EmployeeId,Salary"
                                                  Text="Work Details"
                                                  MappingName="WorkDetails"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>
    </syncfusion:SfTreeGrid.StackedHeaderRows>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId,Salary",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Second level stacked header row
var subStackedRow = new TreeGridStackedHeaderRow();
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName",
    Text = "Personal Details",
    MappingName = "PersonalDetails",
});
subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "EmployeeId,Salary",
    Text = "Work Details",
    MappingName = "WorkDetails",
});

treeGrid.StackedHeaderRows.Add(subStackedRow);

// Set the font size, font family, and font attributes for the stacked header rows
treeGrid.DefaultStyle.StackedHeaderRowFontSize = 20;
treeGrid.DefaultStyle.StackedHeaderRowFontFamily = "Helvetica Neue";
treeGrid.DefaultStyle.StackedHeaderRowFontAttributes = FontAttributes.Bold;

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Customizing stacked header with templates

You can customize the content and layout of stacked header cells by using the [TreeGridStackedColumn.Template]() property. A `DataTemplateSelector` can also be assigned to this property. When the `Template` property is set, the `Text` value and the stacked header font and text color settings defined in `DefaultStyle` are not applied to the cell content.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">

    <syncfusion:SfTreeGrid.StackedHeaderRows>
        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName,EmployeeId,Salary"
                                                  Text="Organization Overview"
                                                  MappingName="OrganizationOverview"/>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>

        <syncfusion:TreeGridStackedHeaderRow>
            <syncfusion:TreeGridStackedHeaderRow.Columns>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="FirstName,LastName"
                                                  Text="Personal Details"
                                                  MappingName="PersonalDetails"/>
                <syncfusion:TreeGridStackedColumn ColumnMappingNames="EmployeeId,Salary">
                    <syncfusion:TreeGridStackedColumn.Template>
                        <DataTemplate>
                            <Grid BackgroundColor="#7d8597"
                                  Padding="5"
                                  ColumnDefinitions="30,*">
                                <Label Text="Work Details"
                                       TextColor="#FFFFFF"
                                       HorizontalTextAlignment="Center"
                                       VerticalTextAlignment="Center"
                                       FontAttributes="Bold"
                                       Grid.Column="1"/>
                                <Image Source="Image0.png"
                                       HeightRequest="20"
                                       Margin="5"
                                       Grid.Column="0"/>
                            </Grid>
                        </DataTemplate>
                    </syncfusion:TreeGridStackedColumn.Template>
                </syncfusion:TreeGridStackedColumn>
            </syncfusion:TreeGridStackedHeaderRow.Columns>
        </syncfusion:TreeGridStackedHeaderRow>
    </syncfusion:SfTreeGrid.StackedHeaderRows>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";

// First level stacked header row
var topStackedRow = new TreeGridStackedHeaderRow();
topStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName,EmployeeId,Salary",
    Text = "Organization Overview",
    MappingName = "OrganizationOverview",
});

treeGrid.StackedHeaderRows.Add(topStackedRow);

// Second level stacked header row
var subStackedRow = new TreeGridStackedHeaderRow();

subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "FirstName,LastName",
    Text = "Personal Details",
    MappingName = "PersonalDetails",
});

// Create the stacked header template
var workDetailsTemplate = new DataTemplate(() =>
{
    Grid grid = new Grid
    {
        BackgroundColor = Color.FromArgb("#7d8597"),
        Padding = new Thickness(5),
        ColumnDefinitions =
        {
            new ColumnDefinition { Width = 30 },
            new ColumnDefinition { Width = GridLength.Star }
        }
    };

    Image image = new Image
    {
        Source = "dotnet_bot.png",
        HeightRequest = 20,
        Margin = new Thickness(5)
    };
    Grid.SetColumn(image, 0);

    Label label = new Label
    {
        Text = "Work Details",
        TextColor = Color.FromArgb("#FFFFFF"),
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontAttributes = FontAttributes.Bold
    };
    Grid.SetColumn(label, 1);

    grid.Children.Add(image);
    grid.Children.Add(label);

    return grid;
});

subStackedRow.Columns.Add(new TreeGridStackedColumn()
{
    ColumnMappingNames = "EmployeeId,Salary",
    MappingName = "WorkDetails",
    Template = workDetailsTemplate
});

treeGrid.StackedHeaderRows.Add(subStackedRow);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

