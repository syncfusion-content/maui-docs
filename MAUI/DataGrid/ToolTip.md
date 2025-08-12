---
layout: post
title: ToolTip in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about ToolTip support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui tooltip, maui tooltip
---

# ToolTip in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) provides support for displaying tooltips. ToolTip provides the support to show the pop-up window that displays the information when interacting with cells of SfDataGrid. 

To show tooltips:
- **On Windows/Mac**: Hover the mouse cursor over any cell in the grid
- **On Android/iOS**: Long press on any cell in the grid

## Record cell tooltip

To enable tooltip for datagrid, set the `SfDataGrid.ShowToolTip` property to `true`. This will display tooltip containing cell content when users interact with the cells.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                              ItemsSource="{Binding OrdersInfo}"
                              ShowToolTip="True" />

{% endhighlight %}
{% highlight c# %}

this.dataGrid.ShowToolTip = true;

{% endhighlight %}
{% endtabs %}

<img alt="MAUI DataGrid displays ToolTip for Record Cell" src="Images\tooltip\maui-datagrid-tooltip-basic.png" width="404" height="396"/>   

You can enable tooltips for specific columns by setting the `DataGridColumn.ShowToolTip` property to `true` for the desired columns.

{% tabs %}
{% highlight XAML %}
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn HeaderText="Order ID" 
                                       MappingName="OrderID" 
                                       ShowToolTip="True"/>
        <syncfusion:DataGridTextColumn HeaderText="Customer ID" 
                                       MappingName="CustomerID" 
                                       ShowToolTip="True"/>
    </syncfusion:SfDataGrid.Columns>
{% endhighlight %}
{% highlight c# %}
dataGrid.Columns.Add(new DataGridTextColumn()
{
    HeaderText = "Order ID",
    MappingName = "OrderID",
    ShowToolTip = true
});

dataGrid.Columns.Add(new DataGridTextColumn()
{
    HeaderText = "Customer ID",
    MappingName = "CustomerID",
    ShowToolTip = true
});
{% endhighlight %}
{% endtabs %}

N> 
The `DataGridColumn.ShowToolTip` property takes higher priority than the `SfDataGrid.ShowToolTip` property.

## ToolTip Customization

You can change the appearance of the ToolTip by customizing the style with TargetType as DataGridToolTipView.

{% tabs %}
{% highlight XAML %}
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridToolTipView">
            <Setter Property="Background" Value="AliceBlue" />
            <Setter Property="Stroke" Value="Red" />
            <Setter Property="StrokeThickness" Value="2" />
            <Setter Property="TextColor" Value="Brown" />
        </Style>
    </ContentPage.Resources>
{% endhighlight %}
{% endtabs %}
<img alt="Customizing ToolTip Style in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-style.png" width="404" height="396"/> 

### Customize the ToolTip using ToolTipTemplate

You can customize the appearance and content of tooltips by setting the `SfDataGrid.ToolTipTemplate` property.

{% tabs %}
{% highlight XAML %}
        <syncfusion:SfDataGrid x:Name="dataGrid" 
                               ItemsSource="{Binding Orders}"
                               ShowToolTip="True">

            <syncfusion:SfDataGrid.ToolTipTemplate>
                <DataTemplate>
                    <Image Height="100" Width="100" Source="{Binding Customer,Converter={StaticResource ImageConverter}}" />
                </DataTemplate>
            </syncfusion:SfDataGrid.ToolTipTemplate>

        </syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Customizing ToolTip using ToolTipTemplate in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-template.png" width="404" height="396"/> 

### Customize the ToolTip with ToolTipTemplateSelector

You can load different tooltip templates conditionally based on cell data by using a DataTemplateSelector with the `SfDataGrid.ToolTipTemplate` property.

{% tabs %}
{% highlight XAML %}
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="Default">
                <Border Stroke="Black" StrokeThickness="2">
                    <Label Text="{Binding OrderID}" Background="Red" TextColor="White" Padding="2" />
                </Border>                
            </DataTemplate>
            <DataTemplate x:Key="Alternative">
                <Border Stroke="Black" StrokeThickness="2" >
                    <Label Text="{Binding OrderID}" Background="ForestGreen" TextColor="Black" Padding="2" />
                </Border>
            </DataTemplate>
        </ResourceDictionary>    
    </ContentPage.Resources>
    
    <ContentPage.Content>
        <syncfusion:SfDataGrid x:Name="dataGrid" 
                               ItemsSource="{Binding Orders}"
                               ShowToolTip="True">

            <syncfusion:SfDataGrid.ToolTipTemplate>
                <local:ToolTipTemplateSelector AlternateTemplate="{StaticResource Alternative}" DefaultTemplate="{StaticResource Default}" />
            </syncfusion:SfDataGrid.ToolTipTemplate>

        </syncfusion:SfDataGrid>
    </ContentPage.Content>
{% endhighlight %}
{% highlight c# %}
public class ToolTipTemplateSelector : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }
    public DataTemplate AlternateTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is OrderInfo employee)
        {
            if (employee.OrderID % 2 == 0)
            {
                return AlternateTemplate;
            }
            else
            {
                return DefaultTemplate;
            }
        }

        return DefaultTemplate;
    }
}
{% endhighlight %}
{% endtabs %}

The below image refers the `DefaultTemplate` which is applied through `ToolTipTemplate`.

<img alt="Customizing ToolTip with ToolTipTemplateSelector in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-template-selector2.png" height="396" width="404"/>

The below image refers the `AlternateTemplate` which is applied through `ToolTipTemplate`.

<img alt="Displaying AlternateTemplate for ToolTip in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-template-selector1.png" height="396" width="404"/>

## Events

### CellToolTipOpening event

The [CellToolTipOpening]() event is raised when a tooltip is about to be displayed for a cell. The event provides [DataGridCellToolTipOpeningEventArgs]() which contains the following properties:

* [Column](): Gets the GridColumn of the cell for which the tooltip is being shown.
* [RowData](): Gets the data associated with a specific row. 
* [RowColumnIndex](): Gets the row and column index of the cell.
* [ToolTipText](): Gets the text content that is displayed within the tooltip.
* [Cancel](): Gets or sets a value indicating whether the tooltip should be displayed. Set to `true` to prevent the tooltip from showing.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                      ItemsSource="{Binding OrdersInfo}"
                      ShowToolTip="True"
                      CellToolTipOpening="DataGrid_CellToolTipOpening">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.CellToolTipOpening += DataGrid_CellToolTipOpening;

private void DataGrid_CellToolTipOpening(object sender, DataGridCellToolTipOpeningEventArgs e)
{

}
{% endhighlight %}
{% endtabs %}


