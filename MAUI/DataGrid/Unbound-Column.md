---
layout: post
title: Unbound Columns in MAUI DataGrid control | Syncfusion
description: Learn here all about Unbound columns support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Unbound column in MAUI DataGrid (SfDataGrid)

An "Unbound column" typically refers to a column in a datagrid or table that is not directly bound to a data source. In other words, the data displayed in this column is not sourced from the underlying dataset but is rather calculated or manually entered. The unbound column can be added by using the SfDataGrid.DataGridUnboundColumn class.

{% tabs %}
{% highlight xaml %}

     <syncfusion:SfDataGrid 
                    x:Name="datagrid"    
                    ColumnWidthMode="Fill"
                    AutoGenerateColumnsMode="None"
                    ItemsSource="{Binding OrderInfoCollection1}">
     <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridUnboundColumn 
                        MappingName="DiscountPrice"
                        HeaderText="SUM"
                        Expression="Price1+Price2"
                        Format="C" />
         </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>

{% endhighlight %}

{% highlight c# %}

            SfDataGrid dataGrid = new SfDataGrid();
            OrderInforRepo orderInforRepo = new OrderInforRepo();
            dataGrid.ItemsSource = orderInforRepo;
            DataGridUnboundColumn DiscountColumn = new DataGridUnboundColumn()
            {
                MappingName = "DiscountPrice",
                HeaderText = "SUM",
                Expression = "Price1+Price2",
                Format = "C"
            };
            this.datagrid.Columns.Add(DiscountColumn);
            this.dataGrid.Columns.Add(DiscountColumn);

{% endhighlight %}
{% endtabs %}

The following screenshot shows the outcome of the previous code:

<img alt="" src="Images\unbound-column\maui-datagrid-sample-example.png" width="404" Height = 396/>


# Populating data for the unbound column.
Data can be configured using the Expression or Format properties to provide data for the unbound column.

# Using Expression.
The arithmetic or logic expression can be specified by using the expression properly to compute the display value. By default, DataGridUnboundColumn evaluates the expression with casing. The casing will be disabled while evaluating the expression by setting the CaseSensitive property to false.

List of supported arithmetic and logical operations are as follows:

<table>
<tr>
<th> Arithmetic operations </th>
<th> Operator </th>
</tr>
<tr>
<td> Add</td>
<td> + </td>
</tr>
<tr>
<td> Subtract</td>
<td> - </td>
</tr>
<tr>
<td> Multiply</td>
<td> / </td>
</tr>
<tr>
<td> Divide </td>
<td> / </td>
</tr>
<tr>
<td> Power</td>
<td> ^ </td>
</tr>
<tr>
<td> Mod</td>
<td> % </td>
</tr>
<tr>
<td> Greater Than</td>
<td> < </td>
</tr>
<tr>
<td> Less than</td>
<td> > </td>
</tr>
<tr>
<td> Equal</td>
<td> = </td>
</tr>
<tr>
<td> GreaterThanOrEqual</td>
<td> >= </td>
</tr>
<tr>
<td> LessThanOrEqual </td>
<td> <= </td>
</tr>
</table>

Logical operation

<table>
<tr>
<th> Logical operations </th>
<th> Operators </th>
</tr>
<tr>
<td> AND </td>
<td> (char)135 </td>
</tr>
<tr>
<td> OR  </td>
<td> (char)136 </td>
</tr>
<tr>
<td> NOT </td>
<td> (char)137 </td>
</tr>
<tr>
</table>

{% tabs %}
{% highlight xaml %}

 <syncfusion:SfDataGrid x:Name="datagrid"    
                  ColumnWidthMode="Fill"
                  AutoGenerateColumnsMode="None"
                  ItemsSource="{Binding OrderInfoCollection1}">
     <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridUnboundColumn 
                            MappingName="DiscountPrice"
                            HeaderText="SUM"/>
     </syncfusion:SfDataGrid.Columns>
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}
    datagrid.QueryUnboundColumnValue += DataGrid_QueryUnboundColumnValue;
    
    private void DataGrid_QueryUnboundColumnValue(object? sender, DataGridUnboundColumnEventArgs e)
    {
        if (e.UnboundAction == DataGridUnboundActions.QueryData)
            {
                var Price1 = Convert.ToInt16(e.Record!.GetType().GetProperty("Price1")?.GetValue(e.Record));
                var Price2 = Convert.ToInt16(e.Record!.GetType().GetProperty("Price2")?.GetValue(e.Record));
                var amount = Price1 * Price2;
                e.Value = amount;
            }
    }
{% endhighlight %}
{% endtabs %}

# Using QueryUnboundColumnValue event

The QueryUnboundColumnValue event is fired when value for the unbound column is quired. It provides information about the cell that triggered this event. So, you can set the desired value for the grid cells of the unbound column. This event is triggered with the DataGridUnboundEventArgs.

The DataGridUnboundColumnEventArgs provides the following properties:

***Column:*** Gets DataGridColumn of the cell that triggers this event.
***OriginalSender:*** Gets the data grid raising event.
***Record:*** Gets the underlying row data
***UnboundAction:*** Defines the action for triggering event.
***Value:*** Gets or Sets the value for DataGridUnboundCOlumn cell based on unboundAction.

# Populate the data for the unbound column by handling.

QureyUnboundColumnValue event which allows customizing the value of the DataGridUnboundColumn. DataGridUnboundCOlumnEventArgs exposes Value property, by which you can set the value for the grid cells of the unbound column based on the UnboundAction.

Refer to the following code example in which data for the unbound column is populated by handling the queryUnboundColumnValue event:

{% tabs %}
{% highlight C# %}

    datagrid.QueryUnboundColumnValue += DataGrid_QueryUnboundColumnValue;
    private void DataGrid_QueryUnboundColumnValue(object? sender, DataGridUnboundColumnEventArgs e)
    {
        if (e.UnboundAction == DataGridUnboundActions.QueryData)
        {
            var Price1 = Convert.ToInt16(e.Record.GetType().GetProperty("Price1").GetValue(e.Record));
            var Price2 = Convert.ToInt16(e.Record.GetType().GetProperty("Price2").GetValue(e.Record));
            var amount = Price1 - Price2;
            e.Value = amount;
        }
    }
  
{% endhighlight %}
{% endtabs %}