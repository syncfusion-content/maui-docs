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

## Show tooltip in a header and record cell

To enable tooltip for datagrid, set the [SfDataGrid.ShowToolTip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowToolTip) property to `true`. This will display tooltip containing cell content when users interact with the cells.

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

<img alt="MAUI DataGrid displays ToolTip for Record Cell" src="Images\tooltip\maui-datagrid-tooltip-basic.png" width="404" />   

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

You can customize the appearance of the tooltip in the MAUI SfDataGrid using either implicit styles or default style properties. Below are two approaches to achieve this:

### Apply Implicit Style

You can define an implicit style in the ContentPage.Resources section by targeting the DataGridToolTipView. This allows you to customize various visual aspects of the tooltip such as Background, TextColor, FontAttributes, FontFamily, and FontSize. 

To change the tooltip's border appearance, use the Stroke and StrokeThickness properties within the implicit style.

* `Stroke`: Sets the border color of the tooltip.
* `StrokeThickness`: Defines the thickness of the tooltip border. 

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
<img alt="Customizing ToolTip Style in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-style.png" width="404" /> 

### Apply Default Style

You can apply basic tooltip styling using the DefaultStyle property of SfDataGrid. This method supports only background and text color customization.

{% tabs %}
{% highlight XAML %}
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle ToolTipBackground="Red" ToolTipTextColor="White" />
            </syncfusion:SfDataGrid.DefaultStyle>
{% endhighlight %}
{% endtabs %}

## Load views to the Tooltip

### Customizing the ToolTip using DataTemplate

You can customize the appearance and content of tooltips by setting the [SfDataGrid.ToolTipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ToolTipTemplate) property.

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

<img alt="Customizing ToolTip using ToolTipTemplate in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-template.png" width="404" /> 

### Customizing the ToolTip with DataTemplateSelector

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

<img alt="Customizing ToolTip with ToolTipTemplateSelector in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-template-selector2.png"  width="404"/>

The below image refers the `AlternateTemplate` which is applied through `ToolTipTemplate`.

<img alt="Displaying AlternateTemplate for ToolTip in MAUI DataGrid" src="Images\tooltip\maui-datagrid-tooltip-template-selector1.png" width="404"/>

## Events

### CellToolTipOpening event

The [CellToolTipOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellToolTipOpening) event is raised when a tooltip is about to be displayed for a cell. The event provides [DataGridCellToolTipOpeningEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellToolTipOpeningEventArgs.html) which contains the following properties:

* [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellToolTipOpeningEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellToolTipOpeningEventArgs_Column): Gets the GridColumn of the cell for which the tooltip is being shown.
* [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellToolTipOpeningEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellToolTipOpeningEventArgs_RowData): Gets the data associated with a specific row. 
* [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellToolTipOpeningEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellToolTipOpeningEventArgs_RowColumnIndex): Gets the row and column index of the cell.
* [ToolTipText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellToolTipOpeningEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellToolTipOpeningEventArgs_ToolTipText): Gets the text content that is displayed within the tooltip.
* `Cancel`: Gets or sets a value indicating whether the tooltip should be displayed. Set to `true` to prevent the tooltip from showing.

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


