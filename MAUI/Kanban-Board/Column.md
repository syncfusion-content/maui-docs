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

By default, columns are sized smartly to arrange the default elements of the cards with better readability. However, you can define the minimum and maximum width for the columns in [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) using [`MinimumColumnWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumColumnWidth) and [`MaximumColumnWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumColumnWidth) properties respectively. 

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban MinimumColumnWidth ="300" MaximumColumnWidth ="340">
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

kanban.MinimumColumnWidth = 300;
kanban.MaximumColumnWidth = 340;

{% endhighlight %}

{% endtabs %}

You can also define the exact column width using [`ColumnWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnWidth) property of [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html).

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

To categorize columns based on a specific property, you must explicitly define the property path using the [`ColumnMappingPath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath) property. However, only the properties of [`KanbanModel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanModel.html) can be assigned to [`ColumnMappingPath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath). By default, [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) will categorize the items using the Category property of KanbanModel.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban ColumnMappingPath="ID">
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

kanban.ColumnMappingPath = "ID";

{% endhighlight %}

{% endtabs %}

### Category for a column

You can assign a specific category to a column by setting the [Categories](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_Categories) property of the [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html). This will display cards with the specified category under the corresponding column. For example, to map the `In Progress` category to the `In Progress` column

{% tabs %}

{% highlight xaml %}

<kanban:KanbanColumn x:Name="progressColumn" Categories="In Progress" />

{% endhighlight %}

{% highlight C# %} 

progressColumn.Categories = new List<object>() { "In Progress" };

{% endhighlight %}

{% endtabs %}

## Headers

Header shows the category `Title`, `Items count`, `Min` and `Max` informations of a column. The UI of the header can be replaced entirely using [`HeaderTemplate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_HeaderTemplate) property of [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html). The following code snippet and screenshot illustrates this.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban.HeaderTemplate >
    <DataTemplate>
        <StackLayout WidthRequest="300" HeightRequest="40"  BackgroundColor="Silver">
            <Label Margin="10" Text="{Binding Title}" TextColor="Purple" HorizontalOptions="Start" />
        </StackLayout>
    </DataTemplate>
</kanban:SfKanban.HeaderTemplate>

{% endhighlight %}

{% highlight C# %} 

var headerTemplate = new DataTemplate(() => 
{
    StackLayout root = new StackLayout()
    { 
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

## Expand/Collapse Column

Columns can be expanded/collapsed by tapping the toggle button which is placed at top right corner of the Kanban header. [`IsExpanded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_IsExpanded) property of [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) is used to programmatically expand/collapse the Kanban column. The following code example describes the above behavior.   

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

## Enable/Disable Drag & Drop 

You can enable and disable the drag and drop operation of the cards for particular column using [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_AllowDrag) and [`AllowDrop`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_AllowDrop) properties of [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html).

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

## Items Count

[`ItemsCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_ItemsCount) property is used to get the total cards count in each column.

{% highlight C# %}

int count = todoColumn.ItemsCount;         

{% endhighlight %}


## Work In-Progress Limit

[`MinimumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MinimumLimit) and [`MaximumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MaximumLimit) properties are used to define the minimum and maximum number of items in a column. If the actual items count is exceeded or lesser than the specified limits, the error bars are used to indicate this violation. Following properties of [`ErrorBarSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_ErrorBarSettings) are used to customize the appearance of error bar.

* [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_Fill), of type `Brush`, used to change the default color of the error bar.
* [MaxValidationFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_MaxValidationFill), of type `Brush`, used to change the maximum validation color of the error bar.
* [MinValidationFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_MinValidationFill), of type `Brush`, used to change the minimum validation color of the error bar.
* [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_Height),of type `double`, used to change the height of the error bar.

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

KanbanColumn todoColumn = new KanbanColumn();
todoColumn.Title = "To Do";
todoColumn.MaximumLimit = 5;
todoColumn.MinimumLimit = 3;
KanbanErrorBarSettings kanbanErrorBarSettings = new KanbanErrorBarSettings()
{
    Fill = Colors.Green,
    MaxValidationFill = Colors.Red,
    MinValidationFill = Colors.Orange,
    Height = 4,
};
todoColumn.ErrorBarSettings = kanbanErrorBarSettings;
kanban.Columns.Add(todoColumn);

{% endhighlight %}

{% endtabs %}
