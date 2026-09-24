---
layout: post
title: Data Binding in .NET MAUI Tree Grid | Syncfusion®
description: Learn all about data binding in Syncfusion® .NET MAUI Tree Grid, including binding hierarchical data sources, expanding and collapsing nodes.
platform: MAUI
control: SfTreeGrid
documentation: UG
keywords : maui tree grid, maui treegrid, maui hierarchical grid, treegrid maui, .net maui treegrid, .net maui tree grid, .net maui data binding, maui hierarchical data binding, tree node expand collapse
---

# Data Binding in .NET MAUI Tree Grid

The [.NET MAUI Tree Grid]() is designed primarily to display self-relational and hierarchical data in a tree structure with columns. The [SfTreeGrid.ItemsSource]() property helps bind this control with a collection of objects, and the [ChildPropertyName]() property establishes the hierarchical relationship.

Below are the ways to bind the data source to SfTreeGrid:

- Binding self-relational data
- Binding nested collection

## Binding self-relational data

The `SfTreeGrid` supports binding self-relational data by setting the [ParentPropertyName]() and [ChildPropertyName]() properties. In self-relational data, the tree structure is formed based on matching relationships between parent and child items within a single data collection.

* `ParentPropertyName` – Denotes the property in data object which is used to identify the root nodes.
* `ChildPropertyName` - Denotes the property in the data object that references the parent. This value is matched against the `ParentPropertyName` of other objects to establish the hierarchy.

Data objects which have unique values in `ParentPropertyName` or values matching the [SelfRelationRootValue]() are treated as root nodes.

### Creating Model class for Self-Relational Collection

Create a data model class with properties for the parent ID and child reference:

{% tabs %}
{% highlight c# %}
public class EmployeeInfo : INotifyPropertyChanged
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _title;
    private double _salary;
    private int _reportsTo;

    public int ID
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged("ID"); }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; OnPropertyChanged("FirstName"); }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; OnPropertyChanged("LastName"); }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; OnPropertyChanged("Title"); }
    }

    public double Salary
    {
        get { return _salary; }
        set { _salary = value; OnPropertyChanged("Salary"); }
    }

    public int ReportsTo
    {
        get { return _reportsTo; }
        set { _reportsTo = value; OnPropertyChanged("ReportsTo"); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}

### Creating ViewModel with Self-Relational Data

Create a ViewModel class that populates the self-relational employee data:

{% tabs %}
{% highlight c# %}
public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<EmployeeInfo> _employees;

    public ObservableCollection<EmployeeInfo> Employees
    {
        get { return _employees; }
        set { _employees = value; OnPropertyChanged("Employees"); }
    }

    public EmployeeViewModel()
    {
        Employees = GetEmployees();
    }

    private ObservableCollection<EmployeeInfo> GetEmployees()
    {
        ObservableCollection<EmployeeInfo> employeeDetails = new ObservableCollection<EmployeeInfo>();
        
        // Root level employees (ReportsTo = -1)
        employeeDetails.Add(new EmployeeInfo { FirstName = "James", LastName = "Smith", ID = 1, Title = "Management", Salary = 2000000, ReportsTo = -1 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "John", LastName = "Adams", ID = 2, Title = "Accounts", Salary = 2000000, ReportsTo = -1 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Thomas", LastName = "Jefferson", ID = 3, Title = "Sales", Salary = 300000, ReportsTo = -1 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Andrew", LastName = "Madison", ID = 4, Title = "Marketing", Salary = 4000000, ReportsTo = -1 });
        
        // Child level employees (ReportsTo = 1)
        employeeDetails.Add(new EmployeeInfo { FirstName = "Michael", LastName = "Fuller", ID = 5, Title = "Vice President", Salary = 1200000, ReportsTo = 1 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Janet", LastName = "Leverling", ID = 6, Title = "GM", Salary = 1000000, ReportsTo = 1 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Steven", LastName = "Buchanan", ID = 7, Title = "Manager", Salary = 900000, ReportsTo = 1 });
        
        // Child level employees (ReportsTo = 2)
        employeeDetails.Add(new EmployeeInfo { FirstName = "Nancy", LastName = "Davolio", ID = 8, Title = "Accounts Manager", Salary = 850000, ReportsTo = 2 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Margaret", LastName = "Peacock", ID = 9, Title = "Accountant", Salary = 700000, ReportsTo = 2 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Michael", LastName = "Suyama", ID = 10, Title = "Accountant", Salary = 700000, ReportsTo = 2 });
        
        // Child level employees (ReportsTo = 3)
        employeeDetails.Add(new EmployeeInfo { FirstName = "Laura", LastName = "Callahan", ID = 11, Title = "Sales Manager", Salary = 900000, ReportsTo = 3 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Anne", LastName = "Dodsworth", ID = 12, Title = "Sales Representative", Salary = 800000, ReportsTo = 3 });
        employeeDetails.Add(new EmployeeInfo { FirstName = "Albert", LastName = "Hellstern", ID = 13, Title = "Sales Representative", Salary = 750000, ReportsTo = 3 });
        
        return employeeDetails;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}

### Binding Self-Relational Data to TreeGrid

To bind self-relational data to the TreeGrid, set the `ItemsSource` property to the collection and specify the `ParentPropertyName` (ID) and `ChildPropertyName` (ReportsTo) properties. Set `SelfRelationRootValue` to identify root nodes:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                        ItemsSource="{Binding Employees}"
                        ParentPropertyName="ID"
                        ChildPropertyName="ReportsTo"
                        SelfRelationRootValue="-1"
                        AutoExpandMode="RootNodesExpanded" />
{% endhighlight %}

{% highlight c# %}
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = employeeViewModel.Employees;
treeGrid.ParentPropertyName = "ID";
treeGrid.ChildPropertyName = "ReportsTo";
treeGrid.SelfRelationRootValue = -1;
treeGrid.AutoExpandMode = TreeGridExpandMode.RootNodesExpanded;
{% endhighlight %}
{% endtabs %}

## Binding nested collection with SfTreeGrid

The TreeGrid supports binding nested or hierarchical collections where each data object contains a property that holds its child collection. This approach is commonly used for organizational hierarchies or folder structures.

### Creating Data Model for Nested Collection

Create a data model class with a `Children` property that holds the nested collection:

{% tabs %}
{% highlight c# %}
public class PersonInfo : INotifyPropertyChanged
{
    private string _firstName;
    private string _lastName;
    private bool _available;
    private double _salary;
    private ObservableCollection<PersonInfo> _children;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; OnPropertyChanged("FirstName"); }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; OnPropertyChanged("LastName"); }
    }

    public bool Available
    {
        get { return _available; }
        set { _available = value; OnPropertyChanged("Available"); }
    }

    public double Salary
    {
        get { return _salary; }
        set { _salary = value; OnPropertyChanged("Salary"); }
    }

    public ObservableCollection<PersonInfo> Children
    {
        get { return _children; }
        set { _children = value; OnPropertyChanged("Children"); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}

### Creating ViewModel with Nested Collection Data

Create a ViewModel class that populates the hierarchical employee data:

{% tabs %}
{% highlight c# %}
public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<PersonInfo> _employeeCollection;

    public ObservableCollection<PersonInfo> EmployeeCollection
    {
        get { return _employeeCollection; }
        set { _employeeCollection = value; OnPropertyChanged("EmployeeCollection"); }
    }

    public EmployeeViewModel()
    {
        EmployeeCollection = CreateEmployeeData();
    }

    private ObservableCollection<PersonInfo> CreateEmployeeData()
    {
        var employeeList = new ObservableCollection<PersonInfo>();

        // Create child collection for first manager
        ObservableCollection<PersonInfo> childCollection1 = new ObservableCollection<PersonInfo>();
        childCollection1.Add(new PersonInfo { FirstName = "Andrew", LastName = "Fuller", Available = true, Salary = 1200000 });
        childCollection1.Add(new PersonInfo { FirstName = "Theodore", LastName = "Hoover", Available = true, Salary = 1200000 });
        childCollection1.Add(new PersonInfo { FirstName = "Harry", LastName = "Nixon", Available = false, Salary = 1200000 });

        // Create child collection for second manager
        ObservableCollection<PersonInfo> childCollection2 = new ObservableCollection<PersonInfo>();
        childCollection2.Add(new PersonInfo { FirstName = "Ronald", LastName = "Fillmore", Available = false, Salary = 900000 });
        childCollection2.Add(new PersonInfo { FirstName = "Steven", LastName = "Buchanan", Available = true, Salary = 850000 });
        childCollection2.Add(new PersonInfo { FirstName = "Robert", LastName = "King", Available = true, Salary = 800000 });

        // Create root employees with children
        employeeList.Add(new PersonInfo { FirstName = "James", LastName = "Smith", Available = false, Salary = 2000000, Children = childCollection1 });
        employeeList.Add(new PersonInfo { FirstName = "John", LastName = "Adams", Available = true, Salary = 2000000, Children = childCollection2 });
        employeeList.Add(new PersonInfo { FirstName = "Thomas", LastName = "Jefferson", Available = true, Salary = 300000, Children = childCollection1 });
        employeeList.Add(new PersonInfo { FirstName = "Andrew", LastName = "Madison", Available = false, Salary = 4000000, Children = childCollection2 });
        employeeList.Add(new PersonInfo { FirstName = "Ulysses", LastName = "Pierce", Available = true, Salary = 1500000, Children = childCollection1 });

        return employeeList;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}

### Binding Nested Collection Data to TreeGrid

To bind a nested collection to the TreeGrid, set the `ItemsSource` property to the root collection and specify the `ChildPropertyName` property that contains the child items:

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                        ItemsSource="{Binding EmployeeCollection}"
                        ChildPropertyName="Children" />

{% endhighlight %}

{% highlight c# %}
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = employeeViewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
{% endhighlight %}
{% endtabs %}

## Binding with IEnumerable

The `SfTreeGrid` control supports binding any collection that implements the [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-6.0) interface. All the data operations such as sorting and filtering are supported when the binding collection is derived from `IEnumerable`. The hierarchical structure is maintained through the `ChildPropertyName` property, which specifies where child data is located.

## AutoExpandMode

By default, the items in the TreeGrid load in a collapsed state. You can control how nodes expand when the TreeGrid loads by using the [AutoExpandMode]() property.

The `AutoExpandMode` property accepts the following values of the `TreeGridExpandMode` enum:

* `None` : All items are collapsed when loaded. This is the default.
* `RootNodesExpanded` : Expands only the root-level items when loaded.
* `AllNodesExpanded` : Expands all items when loaded.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AutoExpandMode="AllNodesExpanded" />
{% endhighlight %}

{% highlight c# %}
treeGrid.AutoExpandMode = TreeGridExpandMode.AllNodesExpanded;
{% endhighlight %}
{% endtabs %}

## Expanding a tree node

You can expand a node based on its level or programmatically. The TreeGrid provides multiple methods to expand nodes at runtime:

| Method | Description |
|--------|-------------|
| [ExpandAllNodes()]() | Expands all nodes in the TreeGrid including all child nodes |
| [ExpandAllNodes(int level)]() | Expands all the nodes in TreeGrid up to given level |
| [ExpandAllNodes(TreeNode node)]() | Expands the particular node and all its child nodes |
| [ExpandNode(int level)]() | Expands the node in particular level |
| [ExpandNode(TreeNode node)]() | Expands the particular node |

### Expand all the nodes

You can expand all the nodes programmatically at runtime by using the [ExpandAllNodes()]() method:

{% tabs %}
{% highlight c# %}
treeGrid.ExpandAllNodes();
{% endhighlight %}
{% endtabs %}

You can expand the specific node and all its child nodes by using [ExpandAllNodes(TreeNode node)]() method:

{% tabs %}
{% highlight c# %}
var node = treeGrid.View.Nodes[0];
treeGrid.ExpandAllNodes(node);
{% endhighlight %}
{% endtabs %}

### Expand nodes based on level

You can expand all nodes at a specific level by using the [ExpandNode(int level)]() method. Level 0 represents the root level:

{% tabs %}
{% highlight c# %}
// Expand all nodes at root level (level 0)
treeGrid.ExpandNode(0);

// Expand all nodes at level 1
treeGrid.ExpandNode(1);
{% endhighlight %}
{% endtabs %}

### Expand a specific node

You can expand a specific node by passing the corresponding data object to the [ExpandNode(TreeNode node)]() method:

{% tabs %}
{% highlight c# %}
var node = treeGrid.View.Nodes[0];

// Expand the specific node
if (node != null)
{
    treeGrid.ExpandNode(node);
}
{% endhighlight %}
{% endtabs %}

You can expand the node at specific index also by using [ExpandNode(int rowIndex)]() method.

{% tabs %}
{% highlight c# %}
treeGrid.ExpandNode(3);
{% endhighlight %}
{% endtabs %}

### Expand a node based on business object

You can also resolve the node from your data object and expand it:

{% tabs %}
{% highlight c# %}
var employeeViewModel = new EmployeeViewModel();
var data = employeeViewModel.EmployeDetails[0];
var node = this.treeGrid.View.Nodes.GetNode(data);
treeGrid.ExpandNode(node);
{% endhighlight %}
{% endtabs %}

### NodeExpanding Event

The [NodeExpanding]() event is triggered before a node is expanded. This is a cancelable event, allowing you to prevent specific nodes from expanding based on your business logic.

The event receives [TreeGridNodeExpandingEventArgs]() which contains:

* `Cancel` - Set to true to cancel the node expansion
* `Node` - The node being expanded

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       NodeExpanding="treeGrid_NodeExpanding" />
{% endhighlight %}
{% highlight c# %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.NodeExpanding += treeGrid_NodeExpanding;

private void treeGrid_NodeExpanding(object sender, TreeGridNodeExpandingEventArgs e)
{
    // Cancel expansion for all nodes
    e.Cancel = true;
}

// Or cancel expansion for specific nodes
private void treeGrid_NodeExpanding(object sender, TreeGridNodeExpandingEventArgs e)
{
    if ((e.Node as EmployeeInfo)?.ID == 2)
    {
        e.Cancel = true; // Prevent this specific node from expanding
    }
}
{% endhighlight %}
{% endtabs %}

### NodeExpanded Event

The [NodeExpanded]() event is triggered after a node has been successfully expanded. This event is useful for performing actions after a node expansion completes.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       NodeExpanded="treeGrid_NodeExpanded" />
{% endhighlight %}
{% highlight c# %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.NodeExpanded += treeGrid_NodeExpanded;

private void treeGrid_NodeExpanded(object sender, TreeGridNodeExpandedEventArgs e)
{
    var expandedNode = e.Node;
    Debug.WriteLine($"Node expanded: {expandedNode}");
    
    // Perform any post-expansion operations here
}
{% endhighlight %}
{% endtabs %}

## Collapsing a tree node

You can collapse a node or all nodes in the TreeGrid. The TreeGrid provides multiple methods to collapse nodes at runtime:

| Method | Description |
|--------|-------------|
| [CollapseAllNodes()]() | Collapses all nodes in the TreeGrid |
| [CollapseAllNodes(TreeNode node)]() | Collapses the particular node and all its child nodes |
| [CollapseNode(int rowIndex)]() | Collapses the node in particular rowIndex |
| [CollapseNode(TreeNode node)]() | Collapses the particular node |

### Collapse all the nodes

You can collapse all the nodes programmatically at runtime by using the [CollapseAllNodes()]() method:

{% tabs %}
{% highlight c# %}
treeGrid.CollapseAll();
{% endhighlight %}
{% endtabs %}

You can collapse the particular node and all its child nodes using the [CollapseAllNodes(TreeNode node)]() method:

{% tabs %}
{% highlight c# %}
var node = treeGrid.View.Nodes[0];
treeGrid.CollapseAllNodes(node);
{% endhighlight %}
{% endtabs %}

### Collapse nodes based on level

You can collapse all nodes at a specific level by using the [CollapseNode(int level)]() method. Level 0 represents the root level:

{% tabs %}
{% highlight c# %}
// Collapse all nodes at root level (level 0)
treeGrid.CollapseNode(0);

// Collapse all nodes at level 1
treeGrid.CollapseNode(1);
{% endhighlight %}
{% endtabs %}

### Collapse a specific node

You can collapse a specific node by passing the corresponding data object to the [CollapseNode(TreeNode node)]() method:

{% tabs %}
{% highlight c# %}
// Get the first employee from the collection
var node = treeGrid.View.Nodes[0];
treeGrid.CollapseNode(node);
{% endhighlight %}
{% endtabs %}

### Collapse a node based on business object

You can also resolve the node from your data object and collapse it:

{% tabs %}
{% highlight c# %}
treeGrid.AutoExpandMode = Syncfusion.Maui.TreeGrid.TreeGridExpandMode.None;
var employeeViewModel = new EmployeeViewModel();
var data = employeeViewModel.EmployeDetails[0];
var node = this.treeGrid.View.Nodes.GetNode(data);
treeGrid.CollapseNode(node);
{% endhighlight %}
{% endtabs %}

### NodeCollapsing Event

The [NodeCollapsing]() event is triggered before a node is collapsed. This is a cancelable event, allowing you to prevent specific nodes from collapsing.

The event receives [TreeGridNodeCollapsingEventArgs]() which contains:

* `Cancel` - Set to true to cancel the node collapse
* `Node` - The node being collapsed

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children" 
                       NodeCollapsing="treeGrid_NodeCollapsing"/>
{% endhighlight %}
{% highlight c# %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.NodeCollapsing += treeGrid_NodeCollapsing;

private void treeGrid_NodeCollapsing(object sender, TreeGridNodeCollapsingEventArgs e)
{
    // Cancel collapse for all nodes
    e.Cancel = true;
}

// Or cancel collapse for specific nodes
private void treeGrid_NodeCollapsing(object sender, TreeGridNodeCollapsingEventArgs e)
{
    if ((e.Node as EmployeeInfo)?.ID == 1)
    {
        e.Cancel = true; // Prevent this specific node from collapsing
    }
}
{% endhighlight %}
{% endtabs %}

### NodeCollapsed Event

The [NodeCollapsed]() event is triggered after a node has been successfully collapsed. This event is useful for performing actions after a node collapse completes.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       NodeCollapsed="treeGrid_NodeCollapsed" />
{% endhighlight %}
{% highlight c# %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.NodeCollapsed += treeGrid_NodeCollapsed;

private void treeGrid_NodeCollapsed(object sender, TreeGridNodeCollapsedEventArgs e)
{
    var collapsedNode = e.Node;
    Debug.WriteLine($"Node collapsed: {collapsedNode}");
    
    // Perform any post-collapse operations here
}
{% endhighlight %}
{% endtabs %}

## Expand/Collapse a node based on mapping property

The TreeGrid supports expanding or collapsing nodes based on the value of a boolean mapping property in the underlying data object by using the [ExpandStateMappingName]() property. The TreeGrid will automatically expand or collapse a node when the specified property value in the underlying data object changes.

### Setting up the data model with expansion state

First, add an `IsExpanded` property to your data model class:

{% tabs %}
{% highlight c# %}
public class EmployeeInfo : INotifyPropertyChanged
{
    private bool _isExpanded;

    public bool IsExpanded
    {
        get { return _isExpanded; }
        set { _isExpanded = value; OnPropertyChanged("IsExpanded"); }
    }
}
{% endhighlight %}
{% endtabs %}

### Configure the TreeGrid to use the expansion state property

Set the `ExpandStateMappingName` property to the name of your boolean property that controls the expand/collapse state:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       ExpandStateMappingName="IsExpanded"
                       AutoExpandMode="AllNodesExpanded" />
{% endhighlight %}

{% highlight c# %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.ExpandStateMappingName = "IsExpanded";
{% endhighlight %}
{% endtabs %}

N>
* When using `ExpandStateMappingName`, ensure the property implements `INotifyPropertyChanged` so that changes to the expansion state are immediately reflected in the UI.
* The TreeGrid listens to property changes on the data objects and automatically updates the expand/collapse state accordingly.

## Events

### ItemsSourceChanged Event

The [ItemsSourceChanged]() event occurs when the data source is changed by using the [ItemsSource]() property. This event receives two arguments: sender (the TreeGrid control) and [TreeGridItemsSourceChangedEventArgs]().

The `TreeGridItemsSourceChangedEventArgs` object contains the following properties:

* `OldItems` - Gets the previous data source
* `NewItems` - Gets the new data source

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       ItemsSourceChanged="treeGrid_ItemsSourceChanged"/>
{% endhighlight %}
{% highlight c# %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.ItemsSourceChanged += treeGrid_ItemsSourceChanged;

private void treeGrid_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
{
    var oldSource = e.OldItems;
    var newSource = e.NewItems;
}
{% endhighlight %}
{% endtabs %}
