---
layout: post
title: Column Sizing in .NET MAUI Tree Grid | Syncfusion®
description: Learn all about column sizing support in Syncfusion® .NET MAUI Tree Grid, including auto-sizing modes, customization options, and usage examples.
platform: maui
control: SfTreeGrid
documentation: ug
keywords : maui treegrid, maui tree grid, .net maui treegrid, .net maui tree grid, maui hierarchical grid, maui tree view grid, maui sizing, .net maui sizing, treegrid sizing, maui treegrid column sizing
---

# Column Sizing in .NET MAUI Tree Grid

The [.NET MAUI Tree Grid]() allows you to set the column widths based on certain logics using the [SfTreeGrid.ColumnWidthMode]() or [TreeGridColumn.ColumnWidthMode]() property.

Below is the list of predefined column sizing options available:

<table>
<tr>
<th>
Type
</th>
<th>
Column width
</th>
</tr>
<tr>
<td>
<code>Fill</code>
</td>
<td>
Divides the total width equally for columns. 
</td>
</tr>
<tr>
<td>
<code>Auto</code>
</td>
<td>
Calculates the width of columns based on header and cell contents so that header and cell contents are not truncated. 
</td>
</tr>
<tr>
<td>
<code>LastColumnFill</code>
</td>
<td>
The column width of the TreeGridColumns is adjusted with respect to the SfTreeGrid.DefaultColumnWidth property. If the columns do not fill the entire view space, the width of the last column fills the unoccupied space in the view.
</td>
</tr>
<tr>
<td>
<code>FitByCell</code>
</td>
<td>
Calculates the width of columns based on cell contents so that cell contents are not truncated. 
</td>
</tr>
<tr>
<td>
<code>FitByHeader</code>
</td>
<td>
Calculates the width of columns based on header content so that header content is not truncated.  
</td>
</tr>
<tr>
<td>
<code>None</code>
</td>
<td>
Default column width or defined width set to a column.
</td>
</tr>
</table>

N> `ColumnWidthMode` will not work when the column width is defined explicitly. The `ColumnWidthMode` calculates the column width based on [MinimumWidth]() and [MaximumWidth]() properties.

The code below applies the [ColumnWidthMode.Fill]() to equally set the width for `SfTreeGrid.Columns`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ColumnWidthMode="Fill">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ColumnWidthMode = TreeGridColumnWidthMode.Fill;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-treegrid-fill-column-width-mode" src="Images\column-sizing\net-maui-treegrid-fill-column-width-mode.png" width="404" Height = "396"/>

## Change the default column width for columns

If you want to set the common width for all the columns, you can use the [DefaultColumnWidth]() property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       DefaultColumnWidth="120">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.DefaultColumnWidth = 120d;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Retrieve the auto-calculated width of columns

You can retrieve the width of the columns when it is auto-calculated based on the `ColumnWidthMode` property using the [ActualWidth]() property. The `ActualWidth` is only accurate after the TreeGrid has been loaded and laid out.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<Grid RowDefinitions="*,50">
    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           Grid.Row="0"
                           ItemsSource="{Binding PersonDetails}"
                           ChildPropertyName="Children"
                           ColumnWidthMode="Auto"/>
    <Button Text="Get Column Width"
            Grid.Row="1"
            WidthRequest="300"
            HorizontalOptions="Center"
            Clicked="Button_Clicked">
    </Button>
</Grid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ColumnWidthMode = TreeGridColumnWidthMode.Auto;

Button button = new Button();
button.Text = "Get Column Width";
button.WidthRequest = 300;
button.HorizontalOptions = LayoutOptions.Center;
button.Clicked += Button_Clicked;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
grid.Children.Add(treeGrid);
grid.Children.Add(button);
grid.SetRow(treeGrid, 0);
grid.SetRow(button, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Button_Clicked(object sender, EventArgs e)
{
    double width = treeGrid.Columns["FirstName"]?.ActualWidth ?? 0;
}
{% endhighlight %}
{% endtabs %}

## Apply ColumnWidthMode for a particular column

To apply column sizing to an individual column, use the `TreeGridColumn.ColumnWidthMode` property. The `TreeGridColumn.ColumnWidthMode` property is also a type of the `ColumnWidthMode`. If the `TreeGridColumn.ColumnWidthMode` is not explicitly set to a value, then it takes the value of the `SfTreeGrid.ColumnWidthMode` and applies the width to the columns accordingly.

To apply `ColumnWidthMode` for a particular column, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ColumnWidthMode="None">

    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="First Name"
                                       MappingName="FirstName"
                                       ColumnWidthMode="Auto">
        </syncfusion:TreeGridTextColumn>
    </syncfusion:SfTreeGrid.Columns>

</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ColumnWidthMode = TreeGridColumnWidthMode.None;

TreeGridTextColumn textColumn = new TreeGridTextColumn();
textColumn.MappingName = "FirstName";
textColumn.HeaderText = "First Name";
textColumn.ColumnWidthMode = TreeGridColumnWidthMode.Auto;

treeGrid.Columns.Add(textColumn);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-treegrid-individual-column-width-mode" src="Images\column-sizing\net-maui-treegrid-invididual-column-width-mode.png" width="404" Height = "396"/>

## Set minimum and maximum column widths

You can constrain the auto-calculated column width by setting the `MinimumWidth` and `MaximumWidth` properties on individual columns. These constraints are respected when any `ColumnWidthMode` is applied.

N> `MinimumWidth` and `MaximumWidth` work with all `ColumnWidthMode` options (Auto, Fill, FitByCell, FitByHeader, LastColumnFill) to ensure columns stay within defined bounds.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ColumnWidthMode="Auto">

    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="First Name"
                                       MappingName="FirstName"
                                       MinimumWidth="80"
                                       MaximumWidth="150">
        </syncfusion:TreeGridTextColumn>
        <syncfusion:TreeGridTextColumn HeaderText="Last Name"
                                       MappingName="LastName"
                                       MinimumWidth="100"
                                       MaximumWidth="150">
        </syncfusion:TreeGridTextColumn>
    </syncfusion:SfTreeGrid.Columns>

</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ColumnWidthMode = TreeGridColumnWidthMode.Auto;

TreeGridTextColumn firstNameColumn = new TreeGridTextColumn();
firstNameColumn.MappingName = "FirstName";
firstNameColumn.HeaderText = "First Name";
firstNameColumn.MinimumWidth = 80;
firstNameColumn.MaximumWidth = 150;

TreeGridTextColumn lastNameColumn = new TreeGridTextColumn();
lastNameColumn.MappingName = "LastName";
lastNameColumn.HeaderText = "Last Name";
lastNameColumn.MinimumWidth = 100;
lastNameColumn.MaximumWidth = 150;

treeGrid.Columns.Add(firstNameColumn);
treeGrid.Columns.Add(lastNameColumn);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Refreshing ColumnSizer at runtime

To refresh the column sizing for [SfTreeGrid.Columns]() at runtime, use the [SfTreeGrid.ColumnSizer.Refresh]() method.

Consider that [ColumnWidthMode.Auto]() is applied to the SfTreeGrid. If the underlying values are changed at run time, refresh the column sizer as follows:

{% tabs %}
{% highlight xaml %}   
<Grid RowDefinitions="*,50">
    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           Grid.Row="0"
                           ItemsSource="{Binding PersonDetails}"
                           ChildPropertyName="Children"
                           ColumnWidthMode="Auto">
    </syncfusion:SfTreeGrid>
    <Button x:Name="button"
            Grid.Row="1"
            Text="Refresh ColumnSizer"
            WidthRequest="200"
            HorizontalOptions="Center"
            Clicked="ColumnSizerChanged">
    </Button>
</Grid>
{% endhighlight %}

{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ColumnWidthMode = TreeGridColumnWidthMode.Auto;

Button button = new Button();
button.Text = "Refresh ColumnSizer";
button.WidthRequest = 200;
button.HorizontalOptions = LayoutOptions.Center;
button.Clicked += ColumnSizerChanged;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
grid.Children.Add(treeGrid);
grid.Children.Add(button);
grid.SetRow(treeGrid, 0);
grid.SetRow(button, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void ColumnSizerChanged(object sender, EventArgs e)
{
    //Refreshes the column sizer of the SfTreeGrid
    treeGrid.ColumnSizer.Refresh(true);
}   
{% endhighlight %}
{% endtabs %} 
 

## Customize auto width calculation for a column

For cases where a column might require more width than the applied auto width or if you want to use your custom logic to calculate the auto width of a column, return a desired width in the [OnComputeCellWidth()]() override of the custom-written column-sizer class derived from `TreeGridColumnSizer` and assign it to the `SfTreeGrid.ColumnSizer` property.
In case you want to modify the auto calculations of a column's header cell alone, return the desired width in the [OnComputeHeaderCellWidth()]() override of your custom column-sizer class.

{% tabs %}
{% highlight xaml %}
<ContentPage.Resources>
    <local:CustomColumnSizer x:Key = "CustomColumnSizer"/>
</ContentPage.Resources>

<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ColumnWidthMode="Auto"
                       ColumnSizer="{x:StaticResource CustomColumnSizer}">
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ColumnWidthMode = TreeGridColumnWidthMode.Auto;
treeGrid.ColumnSizer = new CustomColumnSizer();
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
public class CustomColumnSizer : TreeGridColumnSizer
{
    protected override double OnComputeHeaderCellWidth(string? cellValue, TreeGridColumn? column = null)
    {
        if (column?.MappingName == "FirstName")
        {
            // return width based on your logic
            return 150;
        }
        else
        {
            return base.OnComputeHeaderCellWidth(cellValue, column);
        }
    }
}
{% endhighlight %}
{% endtabs %}