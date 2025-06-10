---
layout: post
title: Master Details View in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about Master Details View support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements, and more here.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui DetailsViewDataGrid, maui AutoGenerateRelations
---

# Master Details View in Maui DataGrid (SfDataGrid)
The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) supports displaying hierarchical data using the `Master-Details View`, allowing you to represent parent-child relationships in a structured format. This feature enables the nesting of multiple levels of related data within the grid.

## Key Features
   - Display hierarchical data in a structured format using nested tables.
   - Expand or collapse [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) using an expander in a row or programmatically.
   - Support for unlimited nesting levels with relational data.

<img alt="Master-Details-View" src="Images\master-details-view\maui-datagrid-detailsview-main.png" width="604"/>    

## Generating Master-Details View from IEnumerable
The `Master-Details View` can be generated using properties of type [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-7.0) in the underlying data model.

### Steps to Generate Master-Details View for IEnumerable Properties
1. Create a Data Model with Relations
   - Define properties of type `IEnumerable` (such as ObservableCollection<T>) to establish hierarchical relationships.
2. Define Relations in the `SfDataGrid`
   - **Auto-Generating Relations:** The `SfDataGrid` automatically detects relationships based on IEnumerable properties.
   - **Manually Defining Relations:** Explicitly specify the relationships to customize the hierarchy.

### 1. Creating a Data Model with Relations
Define an `Employee` class with `Sales` and `Orders` properties, which use [ObservableCollection](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-7.0) to establish relations. These properties allow nesting of related data within the `SfDataGrid`.

{% tabs %}
{% highlight c# %}

public class SalesInfo 
{
    public int OrderID { get; set; }      
    public string SalesID { get; set; }         
    public string ProductName { get; set; }
}

public class OrderInfo 
{
    public int OrderID { get; set; }      
    public int Quantity { get; set; }
}

public class Employee
{
    public string EmployeeID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    
    // Establishing hierarchical relations
    public ObservableCollection<SalesInfo> Sales { get; set; }
    public ObservableCollection<OrderInfo> Orders { get; set; }

}

{% endhighlight %}
{% endtabs %}

Create a `ViewModel` class with `Employees` property and it is initialized with several data objects in the constructor. Similarly, the `Sales` and `Orders` property are also initialized.

{% tabs %}
{% highlight c# %}
public class ViewModel
{
    private ObservableCollection<Employee> _employees;
    
    public ObservableCollection<Employee> Employees
    {
        get { return _employees; }
        set { _employees = value; }
    }

    // Collections for Sales and Orders
    private ObservableCollection<OrderInfo> Orders = new ObservableCollection<OrderInfo>();
    private ObservableCollection<SalesInfo> Sales = new ObservableCollection<SalesInfo>();

    public ViewModel()
    {        
        GenerateOrders();
        GenerateSales();
        _employees = GetEmployeesDetails();
    }

    public ObservableCollection<Employee> GetEmployeesDetails()
    {
        var employees = new ObservableCollection<Employee>
        {
            new Employee() { EmployeeID = "1", Name = "John Doe", City = "Berlin", Country = "Germany", Orders = GetOrders("1001"), Sales = GetSales("1001") },
            new Employee() { EmployeeID = "2", Name = "Jane Smith", City = "Mexico D.F.", Country = "Mexico", Orders = GetOrders("1002"), Sales = GetSales("1002") },
            new Employee() { EmployeeID = "3", Name = "Michael Brown", City = "London", Country = "UK", Orders = GetOrders("1003"), Sales = GetSales("1003") },
            new Employee() { EmployeeID = "4", Name = "Emily Johnson", City = "Paris", Country = "France", Orders = GetOrders("1004"), Sales = GetSales("1004") },
            new Employee() { EmployeeID = "5", Name = "David Williams", City = "Mannheim", Country = "Germany", Orders = GetOrders("1005"), Sales = GetSales("1005") }
        };
        return employees;
    }

    public void GenerateOrders()
    {
        Orders.Add(new OrderInfo() { OrderID = "1001", Quantity = 10, Status = "Shipped" });
        Orders.Add(new OrderInfo() { OrderID = "1002", Quantity = 20, Status = "Processing" });
        Orders.Add(new OrderInfo() { OrderID = "1003", Quantity = 50, Status = "Delivered" });
        Orders.Add(new OrderInfo() { OrderID = "1004", Quantity = 70, Status = "Pending" });
        Orders.Add(new OrderInfo() { OrderID = "1005", Quantity = 20, Status = "Cancelled" });
    }
    
    private ObservableCollection<OrderInfo> GetOrders(string orderID)
    {
        return new ObservableCollection<OrderInfo>(Orders.Where(o => o.OrderID == orderID));
    }

    public void GenerateSales()
    {
        Sales.Add(new SalesInfo() { OrderID = "1001", SalesID = "A00001", ProductName = "Bike1", Discount = 5.0m, SaleDate = DateTime.Now });
        Sales.Add(new SalesInfo() { OrderID = "1002", SalesID = "A00002", ProductName = "Car1", Discount = 10.0m, SaleDate = DateTime.Now.AddDays(-1) });
        Sales.Add(new SalesInfo() { OrderID = "1003", SalesID = "A00003", ProductName = "Cycle", Discount = 15.0m, SaleDate = DateTime.Now.AddDays(-2) });
        Sales.Add(new SalesInfo() { OrderID = "1004", SalesID = "A00004", ProductName = "Auto", Discount = 20.0m, SaleDate = DateTime.Now.AddDays(-3) });
    }
    
    private ObservableCollection<SalesInfo> GetSales(string orderID)
    {
        return new ObservableCollection<SalesInfo>(Sales.Where(s => s.OrderID == orderID));
    }
}
{% endhighlight %}
{% endtabs %}

### 2. Defining Relations
#### Auto-Generating Relations
[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) automatically generates master-details relationships for properties of type `IEnumerable` in the underlying data object. This can be enabled by setting the [SfDataGrid.AutoGenerateRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations) property to `true`.

Bind the collection created in the previous step to [SfDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSourceProperty) and set the SfDataGrid.AutoGenerateRelations to true.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        AutoGenerateRelations="True"
                        ItemsSource="{Binding Employees}" />
{% endhighlight %}
{% highlight c# %}
dataGrid.AutoGenerateRelations = True;
{% endhighlight %}
{% endtabs %}

When relations are auto-generated, you can handle the [SfDataGrid.AutoGeneratingRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations) event to modify or cancel [DataGridViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridViewDefinition.html) before adding it to [SfDataGrid.DetailsViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDefinition.html).

Here, two relations are created from `Sales` and `Orders` collection property.

<img alt="auto-relation" src="Images\master-details-view\maui-datagrid-auto-generate-relation.png" width="604"/>  

#### Manually Defining Relations
we can manually define the `Master-Details View` relation in `SfDataGrid` using [DetailsViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDefinition.html) when [AutoGenerateRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations) is set to false.

 **To establish the relation:**
1. Create a [DataGridViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridViewDefinition.html).
2. Set the [RelationalColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html#Syncfusion_Maui_DataGrid_ViewDefinition_RelationalColumn) property to the name of the `IEnumerable` type property in the data object.
3. Add the [DataGridViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridViewDefinition.html) to SfDataGrid.DetailsViewDefinition.
This approach provides greater control over the Master-Details structure in the data grid.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                AutoGenerateRelations="False"
                ItemsSource="{Binding Employees}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <!--  FirstLevelNestedGrid1 is created here  -->
        <syncfusion:DataGridViewDefinition RelationalColumn="Sales">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid1" />
                </syncfusion:DataGridViewDefinition.DataGrid>
                </syncfusion:DataGridViewDefinition>
                <!--  FirstLevelNestedGrid2 is created here  -->
                <syncfusion:DataGridViewDefinition RelationalColumn="Products">
                    <syncfusion:DataGridViewDefinition.DataGrid>
                        <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid2" />
                        </syncfusion:DataGridViewDefinition.DataGrid>
                        </syncfusion:DataGridViewDefinition>
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
 dataGrid.AutoGenerateRelations = false;

 var gridViewDefinition1 = new DataGridViewDefinition();
 gridViewDefinition1.RelationalColumn = "Sales";
 gridViewDefinition1.DataGrid = new SfDataGrid();

 var gridViewDefinition2 = new DataGridViewDefinition();
 gridViewDefinition2.RelationalColumn = "Products";
 gridViewDefinition2.DataGrid = new SfDataGrid();

 dataGrid.DetailsViewDefinition.Add(gridViewDefinition1);
 dataGrid.DetailsViewDefinition.Add(gridViewDefinition2);
{% endhighlight %}
{% endtabs %}

 <img alt="manual-generate-relation" src="Images\master-details-view\maui-datagrid-manually-generate-relation.png" width="604" /> 

 In the same way, we can define relations for first level nested grids by defining relations to the ViewDefinition.DataGrid of first level nested grid.

 {% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateRelations="False"                        
                        ItemsSource="{Binding Employees}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <!--  FirstLevelNestedGrid is created here  -->
        <syncfusion:DataGridViewDefinition RelationalColumn="Orders">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid  x:Name="FirstLevelNestedGrid"
                                        AutoGenerateRelations="False">
                    <!--  SecondLevelNestedGrid is created here  -->
                    <syncfusion:SfDataGrid.DetailsViewDefinition>
                        <syncfusion:DataGridViewDefinition RelationalColumn="Products">
                            <syncfusion:DataGridViewDefinition.DataGrid>
                                <syncfusion:SfDataGrid  x:Name="SecondLevelNestedGrid"/>
                            </syncfusion:DataGridViewDefinition.DataGrid>
                        </syncfusion:DataGridViewDefinition>
                    </syncfusion:SfDataGrid.DetailsViewDefinition>                   
                </syncfusion:SfDataGrid>
            </syncfusion:DataGridViewDefinition.DataGrid>
        </syncfusion:DataGridViewDefinition>
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid.AutoGenerateRelations = false;

// DataGridViewDefinition for parent DataGrid
var gridViewDefinition1 = new DataGridViewDefinition();
gridViewDefinition1.RelationalColumn = "Sales";
var firstLevelNestedGrid = new SfDataGrid();
firstLevelNestedGrid.AutoGenerateRelations = false;

// DataGridViewDefinition for FirstLevelNestedGrid
var gridViewDefinition = new DataGridViewDefinition();
gridViewDefinition.RelationalColumn = "Products";
gridViewDefinition.DataGrid = new SfDataGrid();
firstLevelNestedGrid.DetailsViewDefinition.Add(gridViewDefinition);
gridViewDefinition1.DataGrid = firstLevelNestedGrid;

dataGrid.DetailsViewDefinition.Add(gridViewDefinition1);
{% endhighlight %}
{% endtabs %}

<img alt="manual-generate-relation" src="Images\master-details-view\maui-datagrid-manual-generate-relation2.png" width="604" /> 

## Generating Master-Details View from DataTable
A `Master-Details View` can be created using [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-6.0) when a [DataRelation](https://learn.microsoft.com/en-us/dotnet/api/system.data.datarelation?view=net-7.0) is established between two tables in the underlying [DataSet](https://learn.microsoft.com/en-us/dotnet/api/system.data.dataset?view=net-7.0).

### Steps to Generate Master-Details Relations for DataTable
1. **Create DataTables with Relations**
Define multiple `DataTable` objects inside a DataSet and establish relationships between them using `DataRelation`.

2. **Defining Relations**
There are two ways to define relations between DataTable objects in SfDataGrid:
 - Auto-Generating Relations
 - Manually Defining Relations

Each method allows [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) to create hierarchical views, where the child table's data is displayed based on the parent table's selection.

N>
To `manually Defining relations`, follow the same procedure used for `IEnumerable`.

### 1. Creating a DataTable with Relations
To establish a `Master-Details` relationship in [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html), define a `DataTable` with a `DataRelation` in a `DataSet`. The parent table represents the main data, and the child table contains related details linked through a common key.

#### Steps to Implement the DataTable with Relations
1. Create a `ViewModel` class with an Orders property of type `DataTable`.
2. Define two `DataTable` objects (parent and child).
3. Add them to a `DataSet` and establish a relation using the Order ID column.
4. Bind the parent table to `SfDataGrid.ItemsSource`, and enable [AutoGenerateRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations).

{% tabs %}
{% highlight c# %}

public class DataViewModel
{
    public DataTable Orders { get; set; }

    public DataViewModel()
    {
        var parentTable = GetParentDataTable();
        var childTable = GetChildDataTable();
        
        DataSet dataSet = new DataSet();
        dataSet.Tables.Add(parentTable);
        dataSet.Tables.Add(childTable);

        // Define DataRelation between Parent and Child tables using Order ID
        dataSet.Relations.Add(new DataRelation("Parent_Child",
            dataSet.Tables[0].Columns["ID"],
            dataSet.Tables[1].Columns["ID"]));

        // Assign parent table as the main data source
        Orders = dataSet.Tables[0];
    }

    private DataTable GetParentDataTable()
    {
        DataTable table = new DataTable();
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Q1", typeof(float));
        table.Columns.Add("Q2", typeof(float));
        table.Columns.Add("Q3", typeof(float));

        table.Rows.Add(1001, "Belgim", 872.81, 978.89, 685.90);
        table.Rows.Add(1002, "Oliver", 978.76, 458.21, 675.99);
        table.Rows.Add(1003, "Bernald", 548.31, 234.32, 423.44);
        table.Rows.Add(1004, "James", 123.31, 6543.12, 978.31);

        return table;
    }

    private DataTable GetChildDataTable()
    {
        DataTable table = new DataTable();
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("City", typeof(string));
        table.Columns.Add("Quantity", typeof(int));
        table.Columns.Add("UnitPrice", typeof(int));

        table.Rows.Add(1001, "Belgim", "California", 10, 50);
        table.Rows.Add(1001, "Belgim", "Colorado", 20, 35);
        table.Rows.Add(1001, "Belgim", "Alaska", 50, 65);
        table.Rows.Add(1001, "Belgim", "Roraima", 10, 40);

        table.Rows.Add(1002, "Oliver", "California", 32, 40);
        table.Rows.Add(1002, "Oliver", "Alaska", 24, 35);
        table.Rows.Add(1002, "Oliver", "Roraima", 98, 50);
        table.Rows.Add(1002, "Oliver", "Colorado", 78, 65);

        table.Rows.Add(1003, "Bernald", "California", 89, 35);
        table.Rows.Add(1003, "Bernald", "Alaska", 10, 65);
        table.Rows.Add(1003, "Bernald", "Colorado", 20, 50);
        table.Rows.Add(1003, "Bernald", "Roraima", 30, 40);

        table.Rows.Add(1004, "James", "Colorado", 22, 50);
        table.Rows.Add(1004, "James", "Roraima", 53, 40);
        table.Rows.Add(1004, "James", "California", 65, 65);
        table.Rows.Add(1004, "James", "Alaska", 25, 35);

        return table;
    }
}

{% endhighlight %}
{% endtabs %}

### 2. Defining Relations
#### Auto-Generating Relations
In [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html), we can automatically generate `Master-Details` relationships using [AutoGenerateRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations). This allows `SfDataGrid` to detect and create hierarchical views based on `DataSet` relationships.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateRelations="True"
                        ItemsSource="{Binding Orders}" />
{% endhighlight %}

{% highlight c# %}
dataGrid.AutoGenerateRelations = true;
{% endhighlight %}
{% endtabs %}

Here, `Master-Details View` relation is auto generated based on the `Orders` relation.

<img alt="auto-relation-DataTable" src="Images\master-details-view\Master-Details-View-DataTable.png" width="604" /> 

## Defining columns for DetailsViewDataGrid
The [ViewDefinition.DataGrid’s](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) columns can be generated either automatically or manually like parent `SfDataGrid`. You can refer here to know more about columns.

### Auto-generating columns
We can automatically generate columns for [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) by setting the AutoGenerateColumnsMode to any value other than None.

{% tabs %}
{% highlight xaml %}
  <syncfusion:SfDataGrid x:Name="dataGrid"                        
              AutoGenerateRelations="False"
              ItemsSource="{Binding Orders}">
      <syncfusion:SfDataGrid.DetailsViewDefinition>
          <syncfusion:DataGridViewDefinition RelationalColumn="ProductDetails">
              <syncfusion:DataGridViewDefinition.DataGrid>
                  <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid"    
									     AutoGenerateColumnsMode ="Reset"/>
              </syncfusion:DataGridViewDefinition.DataGrid>
          </syncfusion:DataGridViewDefinition>
      </syncfusion:SfDataGrid.DetailsViewDefinition>
  </syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

### Manually defining columns
We can directly define the columns to [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) when [SfDataGrid.AutoGenerateColumnsMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.AutoGenerateColumnsMode.html) property to `None`. When relation is manually defined, you can define the columns directly to `ViewDefinition.DataGrid` in XAML or C#, by adding desired column to the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnCollection.html) collection.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AutoGenerateRelations="False"
                       ItemsSource="{Binding Orders}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:DataGridViewDefinition RelationalColumn="ProductDetails">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid"
                                        AutoGenerateColumnsMode="None">
                    <syncfusion:SfDataGrid.Columns>
                        <syncfusion:DataGridTextColumn MappingName="OrderID" />
                        <syncfusion:DataGridTextColumn MappingName="ProductName" />
                    </syncfusion:SfDataGrid.Columns>
                </syncfusion:SfDataGrid>
            </syncfusion:DataGridViewDefinition.DataGrid>
        </syncfusion:DataGridViewDefinition>
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

When relation is auto generated, you can define the [ViewDefinition.DataGrid’s](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) columns manually through the [SfDataGrid.AutoGeneratingRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations) event handler.
{% tabs %}
{% highlight c# %}
this.dataGrid.AutoGeneratingRelations += DataGrid_AutoGeneratingRelations; 

void DataGrid_AutoGeneratingRelations(object? sender, DataGridAutoGeneratingRelationsArgs e)
 {
     e.DataGridViewDefinition.DataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
     e.DataGridViewDefinition.DataGrid.Columns.Add(new DataGridTextColumn() { MappingName = "OrderID" });
     e.DataGridViewDefinition.DataGrid.Columns.Add(new DataGridTextColumn() { MappingName = "ProductName" });
 }
{% endhighlight %}
{% endtabs %}

## Selection
[DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) allows you to select rows or cells based on the [SelectionUnit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionUnit.html) property in its parent DataGrid.

### Getting the selected DetailsViewDataGrid
We can get the currently selected [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) by using the [SelectedDetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedDetailsViewDataGrid) property of parent DataGrid.
{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.SelectedDetailsViewDataGrid;
{% endhighlight %}
{% endtabs %}

For accessing nested level [SelectedDetailsViewGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedDetailsViewDataGrid),

{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.SelectedDetailsViewDataGrid.SelectedDetailsViewDataGrid;
{% endhighlight %}
{% endtabs %}

### Getting the DetailsViewDataGrid
We can get the [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) based on row index through `GetDetailsViewDataGrid` helper method.

{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(2);
{% endhighlight %}
{% endtabs %}

### Getting the SelectedRow, SelectedRows and SelectedIndex of DetailsViewDataGrid
We can access the selected record or records and selected record index of [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) by using [SelectedRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRow), [SelectedRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRows), [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedIndex) properties directly.

{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(2);
int selectedIndex = detailsViewDataGrid.SelectedIndex;
var selectedRow = detailsViewDataGrid.SelectedRow;
var selectedRows = detailsViewDataGrid.SelectedRows;
{% endhighlight %}
{% endtabs %}

We can access `DetailsViewDataGrid's` [SelectedRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRow), [SelectedRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRows), [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedIndex) properties by using parent dataGrid’s [SelectedDetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedDetailsViewDataGrid) property also.

{% tabs %}
{% highlight c# %}
int selectedIndex = this.dataGrid.SelectedDetailsViewDataGrid.SelectedIndex;
var selectedRow = this.dataGrid.SelectedDetailsViewDataGrid.SelectedRow;
var selectedRows = this.dataGrid.SelectedDetailsViewDataGrid.SelectedRows;
{% endhighlight %}
{% endtabs %}


## Appearance customization
The visual appearance of [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) can be customized like parent DataGrid through [DetailsViewDefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewDefaultStyle) in `SfDataGrid`.

We can customize the header appearance of `DetailsViewDataGrid` , through `HeaderRowBackground` property of [DetailsViewDefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewDefaultStyle).

{% tabs %}
{% highlight xaml %}
 <syncfusion:SfDataGrid x:Name="dataGrid"
            AutoGenerateRelations="False" 
            ItemsSource="{Binding Employees}">
     <syncfusion:SfDataGrid.DetailsViewDefinition>
         <syncfusion:DataGridViewDefinition RelationalColumn="Sales">
             <syncfusion:DataGridViewDefinition.DataGrid>
                 <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid" >
                     <syncfusion:SfDataGrid.Columns>
                         <syncfusion:DataGridTextColumn MappingName="OrderID" />
                         <syncfusion:DataGridTextColumn MappingName="ProductName" />
                     </syncfusion:SfDataGrid.Columns>
                 </syncfusion:SfDataGrid>
             </syncfusion:DataGridViewDefinition.DataGrid>
         </syncfusion:DataGridViewDefinition>
     </syncfusion:SfDataGrid.DetailsViewDefinition>
     <syncfusion:SfDataGrid.DetailsViewDefaultStyle>
         <syncfusion:DataGridStyle HeaderRowBackground="#2596be"/>
     </syncfusion:SfDataGrid.DetailsViewDefaultStyle>
 </syncfusion:SfDataGrid>
 {% endhighlight %}
{% endtabs %}

<img alt="auto-relation-headerstyle" src="Images\master-details-view\maui-datagrid-header-color.png" width="604" /> 

### Hiding header row of Master-Details View
We can hide the header row of `DetailsViewDataGrid` by setting [HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderRowHeight) property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateRelations="False"
                        ItemsSource="{Binding Employees}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:DataGridViewDefinition RelationalColumn="Sales">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid  x:Name="FirstLevelNestedGrid"
                                        HeaderRowHeight="0" />
            </syncfusion:DataGridViewDefinition.DataGrid>
        </syncfusion:DataGridViewDefinition>
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
 {% endhighlight %}

 {% highlight c# %}
FirstLevelNestedGrid.HeaderRowHeight = 0;
 {% endhighlight %}
{% endtabs %}

<img alt="auto-relation-rowheight" src="Images\master-details-view\maui-datagrid-header-rowheight.png" width="604" /> 


### Customizing padding of the DetailsViewDataGrid
The padding of `DetailsViewDataGrid` can be customized through the [DetailsViewPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewPadding) property and it will be set to its corresponding parent `SfDataGrid`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateRelations="True"
                        DetailsViewPadding="15"
                        ItemsSource="{Binding Employees}" />
 {% endhighlight %}

 {% highlight c# %}
this.dataGrid.DetailsViewPadding = new Thickness(15);
 {% endhighlight %}
{% endtabs %}

<img alt="auto-relation-padding" src="Images\master-details-view\maui-datagrid-detailsview-padding.png" width="604" /> 

### Customize ExpanderColumn width
We can customize the width of ExpanderColumn in [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) by using [ExpanderColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpanderColumnWidth) property as like below.

{% tabs %}
{% highlight xaml %}
<Syncfusion:SfDataGrid x:Name="dataGrid"                               
                       ExpanderColumnWidth="50"
                       ItemsSource="{Binding OrderInfoCollection }">
 {% endhighlight %}

 {% highlight c# %}
this.dataGrid.ExpanderColumnWidth = 50;
 {% endhighlight %}
{% endtabs %}

<img alt="auto-relation-Expander-column-Wdith" src="Images\master-details-view\maui-datagrid-expander-column-width.png" width="604"/> 

## Expanding and collapsing the DetailsViewDataGrid programmatically
[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) allows you to expand or collapse the [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) programmatically in different ways.

Expand or collapse all the DetailsViewDataGrid
We can expand or collapse all the `DetailsViewDataGrid` programmatically by using [ExpandAllDetailsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandAllDetailsView) and [CollapseAllDetailsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CollapseAllDetailsView) methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllDetailsView();
this.dataGrid.CollapseAllDetailsView();
 {% endhighlight %}
{% endtabs %}

### Expand DetailsViewDataGrid based on level
We can expand all the `DetailsViewDataGrid` programmatically based on level using [ExpandAllDetailsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandAllDetailsView_System_Int32_) method.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllDetailsView(2);
 {% endhighlight %}
{% endtabs %}

Here, all the DetailsViewDataGrids up to second level will be expanded.

### Expand or collapse Details View based on record index
We can expand or collapse `DetailsViewDataGrid` based on the record index by using [ExpandDetailsViewAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandDetailsViewAt_System_Int32_) and [CollapseDetailsViewAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CollapseDetailsViewAt_System_Int32_) methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandDetailsViewAt(0);
this.dataGrid.CollapseDetailsViewAt(0);
 {% endhighlight %}
{% endtabs %}

## Handling Events

### DetailsViewLoading
The [DetailsViewLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewLoadingEventArgs.html) event is triggered when the `DetailsViewDataGrid` is loaded into the view.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewLoading += DataGrid_DetailsViewLoading;

private void DataGrid_DetailsViewLoading(object? sender, DataGridDetailsViewLoadingEventArgs e)
{
   
}
{% endhighlight %}
{% endtabs %}


### DetailsViewUnloading
The [DetailsViewUnLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewUnloadingEventArgs.html) event occurs when the `DetailsViewDataGrid` is removed from the view. 

{% tabs %}
{% highlight c# %}
 this.dataGrid.DetailsViewUnloading += DataGrid_DetailsViewUnloading;

 private void DataGrid_DetailsViewUnloading(object? sender, DataGridDetailsViewUnloadingEventArgs e)
 {
     
 }
{% endhighlight %}
{% endtabs %}

### DetailsViewExpanding
The [DetailsViewExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewExpandingEventArgs.html) event is raised when the `DetailsViewDataGrid` is being expanded by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanding += DataGrid_DetailsViewExpanding;

private void DataGrid_DetailsViewExpanding(object? sender, DataGridDetailsViewExpandingEventArgs e)
{
   
}
{% endhighlight %}
{% endtabs %}


### DetailsViewExpanded
The [DetailsViewExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewExpandedEventArgs.html) event is raised after the `DetailsViewDataGrid` is expanded by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanded += DataGrid_DetailsViewExpanded; 

private void DataGrid_DetailsViewExpanded(object? sender, DataGridDetailsViewExpandedEventArgs e)
{
     
}
{% endhighlight %}
{% endtabs %}

### DetailsViewCollapsing
The [DetailsViewCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewCollapsingEventArgs.html) event is raised when the `DetailsViewDataGrid` is being collapsed from the view by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewCollapsing += DataGrid_DetailsViewCollapsing;

 private void DataGrid_DetailsViewCollapsing(object? sender, DataGridDetailsViewCollapsingEventArgs e)
 {
    
 }
{% endhighlight %}
{% endtabs %}

### DetailsViewCollapsed
The [DetailsViewCollapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewCollapsedEventArgs.html) event is raised after the `DetailsViewDataGrid` is collapsed by using an expander.

{% tabs %}
{% highlight c# %}
 this.dataGrid.DetailsViewCollapsed += DataGrid_DetailsViewCollapsed; 
 
private void DataGrid_DetailsViewCollapsed(object? sender, DataGridDetailsViewCollapsedEventArgs e)
{
    
}
{% endhighlight %}
{% endtabs %}

### Cancel expanding or collapsing operations through events
We can cancel expanding operation while expanding the `DetailsViewDataGrid` by using [GridDetailsViewExpandingEventArgs.Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewExpandingEventArgs.html) property in the [DetailsViewExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewExpandingEventArgs.html) event handler.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanding += DataGrid_DetailsViewExpanding;

private void DataGrid_DetailsViewExpanding(object? sender, DataGridDetailsViewExpandingEventArgs e)
{
   if ((e.Record as OrderInfo).OrderID == 1002)
      e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

Similarly, the collapsing operation can be canceled through the [DataGridDetailsViewCollapsingEventArgs.Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewCollapsingEventArgs.html) property in the [DetailsViewCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewCollapsingEventArgs.html) event handler.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewCollapsing += DataGrid_DetailsViewCollapsing;

private void DataGrid_DetailsViewCollapsing(object? sender, DataGridDetailsViewCollapsingEventArgs e)
{
   if ((e.Record as OrderInfo).OrderID == 1002)
      e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Master-Details View Limitations
The `Master-Details View` in [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) has certain limitations that should be considered while using this feature:

 - The Master-Details View is released with basic functionalities. Currently, both the `SfDataGrid` and [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) do not support all existing features of `SfDataGrid` when the Master-Details View is enabled. Full support is planned for the 2025 Volume 2 Main Release.
 - Virtualization is not supported for `DetailsViewDataGrid` on Android, iOS, and Mac platforms. As a result, there may be delays in loading the details view data grid due to the initial loading of all rows and columns.
 - `DetailsViewPadding` property must have identical values in both `SfDataGrid` and `DetailsViewDataGrid`.
