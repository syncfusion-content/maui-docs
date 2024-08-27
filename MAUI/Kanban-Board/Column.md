---
layout: post
title: Column in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Column support in Syncfusion .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Column in .NET MAUI Kanban Board (SfKanban)

## Customizing Column Size

By default, columns are sized smartly to arrange the default elements of the cards with better readability. However, you can define the minimum and maximum width for the columns in [`SfKanban`]() using [`MinimumColumnWidth`]() and [`MaximumColumnWidth`]() properties respectively. 

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban MinimumColumnWidth ="300" MaximumColumnWidth ="340">
    </kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

    kanban. MinimumColumnWidth = 300;
    kanban. MaximumColumnWidth = 340;

{% endhighlight %}

{% endtabs %}


You can also define the exact column width using [`ColumnWidth`]() property of [`SfKanban`]().

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban ColumnWidth ="250">
    </kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

    kanban.ColumnWidth = 250;

{% endhighlight %}

{% endtabs %}

## Categorizing Columns

If [`ItemsSource`]() contains custom objects, the path of the property which can be used to categorize the card should be explicitly defined using [`ColumnMappingPath`]() property. By default, [`SfKanban`]() will automatically categorize the items using [`Category`]() property of [`KanbanModel`]().

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban ColumnMappingPath="Group">
    </kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

    kanban.ColumnMappingPath = "Group";

{% endhighlight %}

{% endtabs %}

### Multiple category for a column

More than one category can be mapped to a column by assigning multiple values to [Categories]() collection of [`KanbanColumn`](). For e.g., you can map "In progress, Validate" types under "In progress" column.

{% highlight C# %} 

    progressColumn.Categories = new List<object>() { "In Progress", "Validated" };

{% endhighlight %}

## Headers

Header shows the category [`Title`](), items count, min and max informations of a column. The UI of the header can be replaced entirely using [`HeaderTemplate`]() property of [`SfKanban`](). The following code snippet and screenshot illustrates this.

{% tabs %}

{% highlight xaml %}

     <kanban:SfKanban.HeaderTemplate >
         <DataTemplate>
             <StackLayout WidthRequest="300" HeightRequest="40"  BackgroundColor="Silver">
                 <Label Margin="10" Text="{Binding Path=Title}" TextColor="Purple" HorizontalOptions="Start" />
             </StackLayout>
         </DataTemplate>
     </kanban:SfKanban.HeaderTemplate>

{% endhighlight %}

{% highlight C# %} 

    var headerTemplate = new DataTemplate(() => {
        StackLayout root = new StackLayout() { 
            WidthRequest = 300, 
            HeightRequest = 40, 
            BackgroundColor = Color.Silver 
        };
        Label label = new Label();
        label.Margin = new Thickness(10); 
        label.SetBinding(Label.TextProperty, new Binding("Title") );
        label.TextColor = Color.Purple;
        label.HorizontalOptions = LayoutOptions.Start; 
        root.Children.Add(label);
        return root;
        });
    kanban.HeaderTemplate = headerTemplate;

{% endhighlight %}

{% endtabs %}

The following output is displayed as a result of the above code example.

## Expand/Collapse Column

Columns can be expanded/collapsed by tapping the toggle button which is placed at top right corner of the Kanban header. [`IsExpanded`]() property of [`KanbanColumn`]() is used to programmatically expand/collapse the Kanban column. The following code example describes the above behavior.   

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban.Columns>
        <kanban:KanbanColumn x:Name="column1" Title="To Do" IsExpanded="false" />
        <kanban:KanbanColumn x:Name="column2" Title="In Progress" IsExpanded="false" />
    </kanban:SfKanban.Columns>

{% endhighlight %}

{% highlight C# %}

    KanbanColumn column1 = new KanbanColumn();
    column1.IsExpanded = false; 
    KanbanColumn column2 = new KanbanColumn();
    column2.IsExpanded = false;

    kanban.Columns.Add(column1);
    kanban.Columns.Add(column2);

{% endhighlight %}

{% endtabs %}

The following output is displayed as a result of the above code example.

## Enable/Disable Drag & Drop 

You can enable and disable the drag and drop operation of the cards for particular column using [`AllowDrag`]() and [`AllowDrop`]() properties of [`KanbanColumn`]().

The following code is used to disable the drag operation from progress column.

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban.Columns>
        <kanban:KanbanColumn AllowDrag="false"/>
    </kanban:SfKanban.Columns>

{% endhighlight %}

{% highlight C# %}

    KanbanColumn progressColumn = new KanbanColumn();
    progressColumn.AllowDrag = false;

{% endhighlight %}

{% endtabs %}

The following code is used to disable the drop operation of the cards into the progress column.

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban.Columns>
        <kanban:KanbanColumn AllowDrop="false"/>
    </kanban:SfKanban.Columns>

{% endhighlight %}

{% highlight C# %}

    KanbanColumn progressColumn = new KanbanColumn();
    progressColumn.AllowDrop = false; 

{% endhighlight %}

{% endtabs %}

The following output demonstrates the above example code.

## Items Count

[`ItemsCount`]() property is used to get the total cards count in each column.

{% highlight C# %}

    int count = todoColumn.ItemsCount;         

{% endhighlight %}


## Work In-Progress Limit

[`MinimumLimit`]() and [`MaximumLimit`]() properties are used to define the minimum and maximum number of items in a column. If the actual items count is exceeded or lesser than the specified limits, the error bars are used to indicate this violation. Following properties of [`ErrorBarSettings`]() are used to customize the appearance of error bar.

* [`Fill`]() - used to change the default color of the error bar.
* [`MaxValidationFill`]() - used to change the maximum validation color of the error bar.
* [`MinValidationFill`]() - used to change the minimum validation color of the error bar.
* [`Height`]() - used to change the height of the error bar.

{% tabs %}

{% highlight xaml %}

    <kanban:KanbanColumn x:Name="todoColumn" Title="To Do" MinimumLimit="2" MaximumLimit="1">
    </kanban:KanbanColumn>

{% endhighlight %}

{% highlight C# %}

    todoColumn.MinimumLimit = 2; 
    todoColumn.MaximumLimit = 1;   

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight xaml %}

    <kanban:KanbanColumn x:Name="todoColumn" Title="To Do" MinimumLimit="3" MaximumLimit="5">
        <kanban:KanbanColumn.ErrorBarSettings>
            <kanban:KanbanErrorBarSettings Fill="Green" MinValidationFill="Orange" MaxValidationFill="Red" Height="4"/>
        </kanban:KanbanColumn.ErrorBarSettings>
    </kanban:KanbanColumn>

{% endhighlight %}

{% highlight C# %}

    todoColumn.ErrorBarSettings.Fill = Colors.Green;
    todoColumn.ErrorBarSettings.MinValidationFill = Colors.Orange;
    todoColumn.ErrorBarSettings.MaxValidationFill = Colors.Red;
    todoColumn.ErrorBarSettings.Height = 4;

{% endhighlight %}

{% endtabs %}