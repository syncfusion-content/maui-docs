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

The DataGrid supports displaying hierarchical data using the Master-Details View, allowing you to represent parent-child relationships in a structured format. This feature enables the nesting of multiple levels of related data within the grid.

## Key Features
   - Display hierarchical data in a structured format using nested tables.
   - Expand or collapse [DetailsViewDataGrid]() using an expander in a row or programmatically.
   - Support for unlimited nesting levels with relational data.

   <img alt="DetailsView" src="Images\master-details-view\maui-datagrid-detailsview-main.png" width="404" height="392" />    

## Generating Master-Details View from IEnumerable
The Master-Details View can be generated using properties of type [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-7.0) in the underlying data model.

### Steps to Generate Master-Details View for IEnumerable Properties
1. Create a Data Model with Relations
   - Define properties of type IEnumerable (such as ObservableCollection<T>) to establish hierarchical relationships.
2. Define Relations in the DataGrid
   - Auto-Generating Relations: The DataGrid automatically detects relationships based on IEnumerable properties.
   - Manually Defining Relations: Explicitly specify the relationships to customize the hierarchy.

### 1. Creating a Data Model with Relations
Define an `Employee` class with `Sales` and `Orders` properties, which use [ObservableCollection](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-7.0) to establish relations. These properties allow nesting of related data within the DataGrid.

{% tabs %}
{% highlight c# %}

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

## Defining Relations in SfDataGrid
### Auto-Generating Relations
SfDataGrid automatically generates master-details relationships for properties of type `IEnumerable` in the underlying data object. This can be enabled by setting the [SfDataGrid.AutoGenerateRelations]() property to `true`.

## Binding Data to SfDataGrid
To display hierarchical data, bind the Employees collection to [SfDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSourceProperty) and enable automatic relation generation.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        AutoGenerateRelations="True"
                        ItemsSource="{Binding Employees}" />
{% endhighlight %}
{% endtabs %}

## Customizing Auto-Generated Relations
When relations are auto-generated, you can handle the [SfDataGrid.AutoGeneratingRelations]() event to modify or cancel [DataGridViewDefinition]() before adding it to [SfDataGrid.DetailsViewDefinition]().

Here, two relations are created from `Sales` and `Orders` collection property.

  <img alt="auto-relation" src="Images\master-details-view\maui-datagrid-auto-generate-relation.png" width="404" height="392" />  

 ## Manually Defining Relations
we can manually define the Master-Details View relation in SfDataGrid using `DetailsViewDefinition` when `AutoGenerateRelations` is set to false.

To establish the relation:

1. Create a [DataGridViewDefinition]().
2. Set the [RelationalColumn]() property to the name of the `IEnumerable` type property in the data object.
3. Add the `DataGridViewDefinition` to SfDataGrid.DetailsViewDefinition.
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
gridViewDefinition1.DataGrid = new SfDataGrid() { Name = "FirstLevelNestedGrid1"};

var gridViewDefinition2 = new DataGridViewDefinition();
gridViewDefinition2.RelationalColumn = "Products";
gridViewDefinition2.DataGrid = new SfDataGrid() { Name = "FirstLevelNestedGrid2"};

dataGrid.DetailsViewDefinition.Add(gridViewDefinition1);
dataGrid.DetailsViewDefinition.Add(gridViewDefinition2);
{% endhighlight %}
{% endtabs %}

 <img alt="auto-relation" src="Images\master-details-view\maui-datagrid-manually-generate-relation.png" width="404" height="392" /> 

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
var firstLevelNestedGrid = new SfDataGrid() { Name = "FirstLevelNestedGrid" };
firstLevelNestedGrid.AutoGenerateRelations = false;

// DataGridViewDefinition for FirstLevelNestedGrid
var gridViewDefinition = new DataGridViewDefinition();
gridViewDefinition.RelationalColumn = "Products";
gridViewDefinition.DataGrid = new SfDataGrid() { Name = "SecondLevelNestedGrid"};
firstLevelNestedGrid.DetailsViewDefinition.Add(gridViewDefinition);
gridViewDefinition1.DataGrid = firstLevelNestedGrid;

dataGrid.DetailsViewDefinition.Add(gridViewDefinition1);
{% endhighlight %}
{% endtabs %}

<img alt="auto-relation" src="Images\master-details-view\maui-datagrid-manual-generate-relation2.png" width="404" height="392" /> 

## Generating Master-Details View from DataTable
A Master-Details View can be created using [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-6.0) when a [DataRelation](https://learn.microsoft.com/en-us/dotnet/api/system.data.datarelation?view=net-7.0) is established between two tables in the underlying [DataSet](https://learn.microsoft.com/en-us/dotnet/api/system.data.dataset?view=net-7.0).

### Steps to Generate Master-Details Relations for DataTable
1. **Create DataTables with Relations**
Define multiple DataTable objects inside a DataSet and establish relationships between them using DataRelation.

2. **Defining Relations**
There are two ways to define relations between DataTable objects in SfDataGrid:
 - Auto-Generating Relations
 - Manually Defining Relations

Each method allows SfDataGrid to create hierarchical views, where the child table's data is displayed based on the parent table's selection.

### Creating a DataTable with Relations in SfDataGrid
To establish a Master-Details relationship in `SfDataGrid`, define a `DataTable` with a `DataRelation` in a `DataSet`. The parent table represents the main data, and the child table contains related details linked through a common key.

### Steps to Implement the DataTable with Relations
1. Create a ViewModel class with an Orders property of type DataTable.
2. Define two DataTable objects (parent and child).
3. Add them to a DataSet and establish a relation using the Order ID column.
4. Bind the parent table to SfDataGrid.ItemsSource, and enable AutoGenerateRelations.

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

## Auto-Generating Relations in SfDataGrid
In `SfDataGrid`, we can automatically generate Master-Details relationships using `AutoGenerateRelations`. This allows `SfDataGrid` to detect and create hierarchical views based on `DataSet` relationships.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="datagrid"
                        AutoGenerateRelations="True"
                        ItemsSource="{Binding Orders}" />
{% endhighlight %}

{% highlight c# %}
dataGrid.AutoGenerateRelations = true;
{% endhighlight %}
{% endtabs %}

Here, Master-Details View relation is auto generated based on the `Orders` relation.

<img alt="auto-relation-DataTable" src="Images\master-details-view\Master-Details-View-DataTable.png" width="404" height="392" /> 

## Populating Master-Details View through Events
we can load `ItemsSource` for [DetailsViewDataGrid]() asynchronously by handling the [SfDataGrid.DetailsViewExpanding]() event. Set the ItemsSource on demand when expanding a record using the [DataGridDetailsViewExpandingEventArgs.DetailsViewItemsSource]() property in the [SfDataGrid.DetailsViewExpanding]() event handler.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="datagrid"
                        AutoGenerateRelations="True"
                        ItemsSource="{Binding Orders}" />
{% endhighlight %}

{% highlight c# %}
this.dataGrid.DetailsViewExpanding += dataGrid_DetailsViewExpanding;

void Datagrid_DetailsViewExpanding(object? sender, DataGridDetailsViewExpandingEventArgs e)
 {
     e.DetailsViewItemsSource.Clear();
     var itemsSource = GetItemSource();
     e.DetailsViewItemsSource.Add("ProductDetails", Products);
 }

private ObservableCollection<ProductInfo> GetItemSource()
{
    Products = new ObservableCollection<ProductInfo>();    
    Products.Add(new ProductInfo() { OrderID = 1001, ProductName = "Bike" });
    Products.Add(new ProductInfo() { OrderID = 1002, ProductName = "Car" });
    Products.Add(new ProductInfo() { OrderID = 1003, ProductName = "Bike1" });             
    return Products;
}
{% endhighlight %}
{% endtabs %}

N>
This event will be trigged only when underlying data object contains relations. Otherwise, you have to define dummy relation to notify DataGrid to fire this event.

In the below code snippet, `AutoGenerateRelations` set to false and also relation is defined with some name to `RelationalColumn`. For example, `ProductDetails` is the dummy relational column and underlying data object does not contain the `IEnumerable` type property with name `ProductDetails`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AutoGenerateRelations="False"
                       ItemsSource="{Binding Orders}">
            <syncfusion:SfDataGrid.DetailsViewDefinition>
                <syncfusion:DataGridViewDefinition RelationalColumn="ProductDetails">
                    <syncfusion:DataGridViewDefinition.DataGrid>
                        <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid"/>
                    </syncfusion:DataGridViewDefinition.DataGrid>
                </syncfusion:DataGridViewDefinition>
            </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

Now the `ItemsSource` for [DetailsViewDataGrid]() can be supplied through [DetailsViewExpanding]() event as mentioned above.

### Loading DetailsViewItemsSource Asynchronously
When populating the Master-Details view through events, loading data from an external source or file may cause a delay. In such cases, the `DetailsViewExpanding` event may execute before the I/O process completes.

To handle this, use [async](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/async) and [await](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/async) to load data with a time delay, ensuring the event waits until the external data loading is complete before execution.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanding += dataGrid_DetailsViewExpanding;

private async Task<ObservableCollection<ProductInfo>> GetItemSource()
{
     var products = new ObservableCollection<ProductInfo>();
     await Schedule(() =>
     {
          products.Add(new ProductInfo() { OrderID = 1001, ProductName = "Bike" });
          products.Add(new ProductInfo() { OrderID = 1002, ProductName = "Car" });
          products.Add(new ProductInfo() { OrderID = 1003, ProductName = "Bike1" });
     }, 2000);
     return products;
}

public async Task<bool> Schedule(Action _onCompletion, int durationMS)
{ 
    DispatcherTimer timer = new DispatcherTimer();
    timer.Interval = TimeSpan.FromMilliseconds(durationMS);

    //Task that causes time delay
    timer.Tick += timer_Tick;            
    _onCompletion();
    timer.Stop();
    return true;
}

 private void Datagrid_DetailsViewExpanding(object? sender, DataGridDetailsViewExpandingEventArgs e)
 {
     e.DetailsViewItemsSource.Clear();
     var itemsSource = await GetItemSource();
     e.DetailsViewItemsSource.Add("ProductDetails", itemsSource);
 }
{% endhighlight %}
{% endtabs %}

The declaration of `await` with `GetItemSource` method hold the further process of adding the `DetailsViewItemsSource` until the items are assigned to the ItemsSource. Here the timer is invoked with 2 seconds delay in asynchronous `Schedule` method call in `GetItemSource` method while adding the `DetailsViewDataGrid` items.

The `DetailsViewExpanding` method runs synchronously until it reaches its first await expression. After await is reached, it is suspended until the awaited task is complete.

## Defining columns for DetailsViewDataGrid
The [ViewDefinition.DataGrid’s]() columns can be generated either automatically or manually like parent DataGrid. You can refer here to know more about columns.

### Auto-generating columns
You can auto-generate the [ViewDefinition.DataGrid’s]() columns by setting the [DataGridViewDefinition.DataGrid.AutoGenerateColumns]() to `true`. We can `cancel` or `customize` the column being created for [ViewDefinition.DataGrid]() by handling [DataGridViewDefinition.DataGrid.AutoGeneratingColumn]() event.

{% tabs %}
{% highlight xaml %}
  <syncfusion:SfDataGrid x:Name="dataGrid"                        
              AutoGenerateRelations="False"
              ItemsSource="{Binding Orders}">
      <syncfusion:SfDataGrid.DetailsViewDefinition>
          <syncfusion:DataGridViewDefinition RelationalColumn="ProductDetails">
              <syncfusion:DataGridViewDefinition.DataGrid>
                  <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid"    
									AutoGeneratingColumn="FirstLevelNestedGrid_AutoGeneratingColumn" />
              </syncfusion:DataGridViewDefinition.DataGrid>
          </syncfusion:DataGridViewDefinition>
      </syncfusion:SfDataGrid.DetailsViewDefinition>
  </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
FirstLevelNestedGrid.AutoGeneratingColumn += FirstLevelNestedGrid_AutoGeneratingColumn;
{% endhighlight %}
{% endtabs %}

### Manually defining columns
We can directly define the columns to [ViewDefinition.DataGrid]() when [AutoGenerateColumns]() is `false`. When relation is manually defined, you can define the columns directly to `ViewDefinition.DataGrid` in XAML or C#, by adding desired column to the [SfDataGrid.Columns]() collection.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AutoGenerateRelations="False"
                       ItemsSource="{Binding Orders}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:DataGridViewDefinition RelationalColumn="ProductDetails">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid">
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

When relation is auto generated, you can define the [ViewDefinition.DataGrid’s]() columns manually through the [SfDataGrid.AutoGeneratingRelations]() event handler.
{% tabs %}
{% highlight c# %}
this.dataGrid.AutoGeneratingRelations += DataGrid_AutoGeneratingRelations; 

void DataGrid_AutoGeneratingRelations(object? sender, DataGridAutoGeneratingRelationsArgs e)
 {
     e.DataGridViewDefinition.DataGrid.ColumnWidthMode = ColumnWidthMode.None;
     e.DataGridViewDefinition.DataGrid.Columns.Add(new DataGridTextColumn() { MappingName = "OrderID" });
     e.DataGridViewDefinition.DataGrid.Columns.Add(new DataGridTextColumn() { MappingName = "ProductName" });
 }
{% endhighlight %}
{% endtabs %}

## Handling Events for DetailsViewDataGrid
We can handle [DetailsViewDataGrid]() events by wiring events to [ViewDefinition.DataGrid](), where the sender is `ViewDefinition.DataGrid`. Alternatively, you can handle `DetailsViewDataGrid` events through `ParentDataGrid` events by setting the [NotifyEventsToParentDataGrid]() property of `ViewDefinition.DataGrid`.

For more details, refer to the [Listen DetailsViewDataGrid Event from ParentDataGrid Event Handler]() section.

## Selection
[DetailsViewDataGrid]() allows you to select rows or cells based on the [SelectionUnit]() property in its parent DataGrid.

### Getting the selected DetailsViewDataGrid
You can get the currently selected [DetailsViewDataGrid]() by using the [SelectedDetailsViewDataGrid]() property of parent DataGrid.
{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.SelectedDetailsViewDataGrid;
{% endhighlight %}
{% endtabs %}

For accessing nested level [SelectedDetailsViewGrid](),

{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.SelectedDetailsViewDataGrid.SelectedDetailsViewDataGrid;
{% endhighlight %}
{% endtabs %}

We can also get the selected `DetailsViewDataGrid` using `GetDataGrid` helper method which returns the DataGrid that contains the current cell.
{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.GetDataGrid();
{% endhighlight %}
{% endtabs %}

### Getting the DetailsViewDataGrid
We can get the [DetailsViewDataGrid]() based on row index through [GetDetailsViewDataGrid]() helper method.

{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(2);
{% endhighlight %}
{% endtabs %}

You can also get the `DetailsViewDataGrid` based on the record index and relational column name using `GetDetailsViewGrid` method.

{% tabs %}
{% highlight c# %}
var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(0, "ProductDetails");
{% endhighlight %}
{% endtabs %}

## Programmatic Selection in DetailsViewDataGrid
In [DetailsViewDataGrid](), you can add or remove the selection programmatically like parent DataGrid. You can get particular `DetailsViewDataGrid` by using [DetailsViewLoading]() event or [GetDetailsViewGrid]() method to process the selection operations.

### Selecting records
We can select the particular record by using SelectedIndex property.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewLoading += DataGrid_DetailsViewLoading; 

void DataGrid_DetailsViewLoading(object? sender, DataGridDetailsViewLoadingEventArgs e)
{
  e.DetailsViewDataGrid.SelectedIndex = 1;
}
{% endhighlight %}
{% endtabs %}

## Appearance customization
The visual appearance of `DetailsViewDataGrid` can be customized like parent DataGrid through `Styling` and `Templates support` in SfDataGrid.

### Changing Header appearance of DetailsViewDataGrid
You can customize the header appearance of `DetailsViewDataGrid` , through `HeaderRowBackground` property of [DetailsViewDefaultStyle]().

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

When the relation is auto-generated, you can assign the customized header style to `ViewDefinition.DataGrid` in [AutoGeneratingRelations]() event.

{% tabs %}
{% highlight c# %}
this.dataGrid.AutoGeneratingRelations += DataGrid_AutoGeneratingRelations;

 private void DataGrid_AutoGeneratingRelations(object? sender, DataGridAutoGeneratingRelationsArgs e)
 {
     e.DataGridViewDefinition.DataGrid.DefaultStyle.HeaderRowBackground = Color.FromArgb("#2596be");
 }
 {% endhighlight %}
{% endtabs %}

<img alt="auto-relation-DataTable" src="Images\master-details-view\maui-datagrid-header-color.png" width="404" height="392" /> 

### Hiding header row of Master-Details View

You can hide the header row of `DetailsViewDataGrid` by setting [HeaderRowHeight]() property.

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

<img alt="auto-relation-DataTable" src="Images\master-details-view\maui-datagrid-header-rowheight.png" width="404" height="392" /> 


### Customizing padding of the DetailsViewDataGrid
The padding of `DetailsViewDataGrid` can be customized through the [DetailsViewPadding]() property and it will be set to its corresponding parent DataGrid.

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

<img alt="auto-relation-DataTable" src="Images\master-details-view\maui-datagrid-detailsview-padding.png" width="404" height="392" /> 

### Customize ExpanderColumn width
You can customize the width of ExpanderColumn in SfDataGrid by using [ExpanderColumnWidth]() property as like below.

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

<img alt="auto-relation-DataTable" src="Images\master-details-view\maui-datagrid-expander-column-width.png" width="404" height="392" /> 

## Expanding and collapsing the DetailsViewDataGrid programmatically
SfDataGrid allows you to expand or collapse the [DetailsViewDataGrid]() programmatically in different ways.

Expand or collapse all the DetailsViewDataGrid
You can expand or collapse all the `DetailsViewDataGrid` programmatically by using [ExpandAllDetailsView]() and [CollapseAllDetailsView]() methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllDetailsView();
this.dataGrid.CollapseAllDetailsView();
 {% endhighlight %}
{% endtabs %}

### Expand DetailsViewDataGrid based on level
You can expand all the `DetailsViewDataGrid` programmatically based on level using [ExpandAllDetailsView]() method.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllDetailsView(2);
 {% endhighlight %}
{% endtabs %}

Here, all the DetailsViewDataGrids up to second level will be expanded.

### Expand or collapse Details View based on record index
You can expand or collapse `DetailsViewDataGrid` based on the record index by using [ExpandDetailsViewAt]() and [CollapseDetailsViewAt]() methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandDetailsViewAt(0);
this.dataGrid.CollapseDetailsViewAt(0);
 {% endhighlight %}
{% endtabs %}

## Handling Events

### DetailsViewLoading

The [DetailsViewLoading]() event is triggered when the `DetailsViewDataGrid` is loaded into the view. This can happen during scrolling, window resizing, or when expanding a record. The event provides [DataGridDetailsViewLoadingEventArgs](), which contains the `DetailsViewDataGrid` property. This allows customization of renderers, selection controllers, resizing controllers, and other components. However, modifying public properties like AllowFiltering, AllowSorting, and SelectionUnit within this event is not recommended.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewLoading += DataGrid_DetailsViewLoading;

private void DataGrid_DetailsViewLoading(object? sender, DataGridDetailsViewLoadingEventArgs e)
{
   
}
{% endhighlight %}
{% endtabs %}


### DetailsViewUnLoading
The [DetailsViewUnLoading]() event occurs when the `DetailsViewDataGrid` is removed from the view. This can happen when scrolling, resizing the window, sorting, filtering, or collapsing a record. The event provides [DataGridDetailsViewUnloadingEventArgs](), which contains the `DetailsViewDataGrid` property. This allows performing any necessary cleanup or additional customization before the details view is unloaded.

{% tabs %}
{% highlight c# %}
 this.dataGrid.DetailsViewUnloading += DataGrid_DetailsViewUnloading;

 private void DataGrid_DetailsViewUnloading1(object? sender, DataGridDetailsViewUnloadingEventArgs e)
 {
     
 }
{% endhighlight %}
{% endtabs %}

### DetailsViewExpanding
The [DetailsViewExpanding]() event is raised when the `DetailsViewDataGrid` is being expanded by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanding += DataGrid_DetailsViewExpanding;

private void DataGrid_DetailsViewExpanding(object? sender, DataGridDetailsViewExpandingEventArgs e)
{
   
}
{% endhighlight %}
{% endtabs %}


### DetailsViewExpanded
The [DetailsViewExpanded]() event is raised after the `DetailsViewDataGrid` is expanded by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanded += DataGrid_DetailsViewExpanded; 

private void DataGrid_DetailsViewExpanded(object? sender, DataGridDetailsViewExpandedEventArgs e)
{
     
}
{% endhighlight %}
{% endtabs %}

### DetailsViewCollapsing
The [DetailsViewCollapsing]() event is raised when the `DetailsViewDataGrid` is being collapsed from the view by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewCollapsing += DataGrid_DetailsViewCollapsing;

 private void DataGrid_DetailsViewCollapsing(object? sender, DataGridDetailsViewCollapsingEventArgs e)
 {
    
 }
{% endhighlight %}
{% endtabs %}

### DetailsViewCollapsed
The [DetailsViewCollapsed]() event is raised after the `DetailsViewDataGrid` is collapsed by using an expander.

{% tabs %}
{% highlight c# %}
 this.dataGrid.DetailsViewCollapsed += DataGrid_DetailsViewCollapsed; 
 
private void DataGrid_DetailsViewCollapsed(object? sender, DataGridDetailsViewCollapsedEventArgs e)
{
    
}
{% endhighlight %}
{% endtabs %}

### Cancel expanding or collapsing operations through events
You can cancel expanding operation while expanding the `DetailsViewDataGrid` by using [GridDetailsViewExpandingEventArgs.Cancel]() property in the [DetailsViewExpanding]() event handler.

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

Similarly, the collapsing operation can be canceled through the [DataGridDetailsViewCollapsingEventArgs.Cancel]() property in the [DetailsViewCollapsing]() event handler.

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
The Master-Details View in SfDataGrid has certain limitations that should be considered while using this feature:

1. The `AutoGenerateColumnsMode.ResetAll` is not supported in DetailsViewDataGrid. Instead, it works based on `Reset`.
2. Data Virtualization is not supported in the Master-Details View for `Android, IOS, Mac platform`.
3. `Freeze Pane` are not available for the Master-Details View.
4. Properties such as `SelectionMode, NavigationMode, and DetailsViewPadding` are inherited from the parent grid. This means both the parent `DataGrid` and the `DetailsViewDataGrid` must share the same values for these properties.