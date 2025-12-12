---
layout: post
title: Record Template View in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Record Template View support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Record Template View in Maui DataGrid (SfDataGrid)

The SfDataGrid provides support to represent additional information of a row using [TemplateViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.TemplateViewDefinition.html) that can be defined in datagrid. It allows you to load any controls to [TemplateViewDefinition.RowTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.TemplateViewDefinition.html#Syncfusion_Maui_DataGrid_TemplateViewDefinition_RowTemplate) in order to display the additional information of a row. You can expand or collapse the row template view by using an expander in a row or programmatically.

<img alt="Unbound Rows" src="Images\record-template-view\maui-datagrid-row-template.png" width="504"/>

## Defining row template

Template view can be generated for the master row by using the `RowTemplate` defined in the `TemplateViewDefinition`.

Follow the below steps to define the row template,
* Create `TemplateViewDefinition`.
* Define data template for the `TemplateViewDefinition.RowTemplate` property.
* Then add `TemplateViewDefinition` to the [SfDataGrid.DetailsViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewDefinition). 

You can bind the row data using the `Data.PropertyName` (where Data is the underlying object bound).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Employees}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:TemplateViewDefinition  x:Name="Template"
                                            HeightMode="Auto">
            <syncfusion:TemplateViewDefinition.RowTemplate>
                <DataTemplate>
                    <Label Text="{Binding Data.Name}" />
                </DataTemplate>
            </syncfusion:TemplateViewDefinition.RowTemplate>
        </syncfusion:TemplateViewDefinition>
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

## Defining RowTemplateSelector

`TemplateViewDefinition` provides support to choose different `DataTemplate` based on underlying data object using `TemplateViewDefinition.RowTemplate` property.

{% tabs %}
{% highlight xaml %}

<ContentPage.Resources>
    <DataTemplate x:Key="ProductInfo">
        <Grid BackgroundColor="AliceBlue">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" />
                <RowDefinition Height="Auto" />
            </Grid.RowDefinitions>
            <Label Grid.Row="0"
                   HorizontalOptions="Center"
                   Margin="5"
                   Text="Prodcut Info"
                   FontAttributes="Bold" />
            <Grid Grid.Row="1"
                  HorizontalOptions="Center"
                  VerticalOptions="Center">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>
                <Label Grid.Row="0"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Name" />
                <Label Grid.Row="0"
                       Grid.Column="1"
                       Margin="5"
                       HorizontalOptions="Center"
                       Text="Phill" />
                <Label Grid.Row="1"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Quantity Per Unit" />
                <Label Grid.Row="1"
                       Margin="5"
                       Grid.Column="1"
                       HorizontalOptions="Center"
                       Text="25" />
                <Label Grid.Row="2"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Unit Price" />
                <Label Grid.Row="2"
                       Margin="5"
                       Grid.Column="1"
                       HorizontalOptions="Center"
                       Text="23825$" />
                <Label Grid.Row="3"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Stock" />
                <Label Grid.Row="3"
                       Margin="5"
                       Grid.Column="1"
                       HorizontalOptions="Center"
                       Text="34.2" />
            </Grid>
        </Grid>
    </DataTemplate>
    <DataTemplate x:Key="SupplierInfo">
        <Grid BackgroundColor="AliceBlue">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" />
                <RowDefinition Height="Auto" />
            </Grid.RowDefinitions>
            <Label Grid.Row="0"
                   Margin="5"
                   HorizontalOptions="Center"
                   Text="Supplier Info"
                   FontAttributes="Bold" />
            <Grid Grid.Row="1"
                  HorizontalOptions="Center">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>
                <Label Grid.Row="0"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Company" />
                <Label Grid.Row="0"
                       Grid.Column="1"
                       Margin="5"
                       HorizontalOptions="Center"
                       Text="Syncfusion" />
                <Label Grid.Row="1"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Contact Person" />
                <Label Grid.Row="1"
                       Grid.Column="1"
                       Margin="5"
                       HorizontalOptions="Center"
                       Text="Jack" />
                <Label Grid.Row="2"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Date" />
                <Label Grid.Row="2"
                       Margin="5"
                       Grid.Column="1"
                       HorizontalOptions="Center"
                       Text="12/03/2025" />
                <Label Grid.Row="3"
                       Margin="5"
                       Grid.Column="0"
                       HorizontalOptions="Center"
                       Text="Country" />
                <Label Grid.Row="3"
                       Margin="5"
                       Grid.Column="1"
                       HorizontalOptions="Center"
                       Text="India" />
            </Grid>
        </Grid>
    </DataTemplate>
     <selector:DetailsViewTemplateSelector x:Key="EditTemplateSelector"
                                       ProductTemplate="{StaticResource ProductInfo}"
                                       SupplierTemplate="{StaticResource SupplierInfo}" />
</ContentPage.Resources>
<syncfusion:SfDataGrid x:Name="dataGrid"
                       DataGridLoaded="dataGrid_DataGridLoaded"
                       ItemsSource="{Binding Employees}">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:TemplateViewDefinition  x:Name="Template"
                                            RowTemplate="{StaticResource EditTemplateSelector}"
                                            HeightMode="Auto" />
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}
public class DetailsViewTemplateSelector : DataTemplateSelector
{
    public DataTemplate ProductTemplate { get; set; }
    public DataTemplate SupplierTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var employeeID = ((item as RecordEntry)?.Data as Employee)?.EmployeeID ?? 0;
        return (employeeID % 2 == 0) ? SupplierTemplate : ProductTemplate;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Unbound Rows" src="Images\record-template-view\maui-datagrid-row-template-selector.png" width="504"/>

## Height customization

### Height mode

You can customize height of the row that contains `RowTemplate` by using the [TemplateViewDefinition.HeightMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.TemplateViewDefinition.html#Syncfusion_Maui_DataGrid_TemplateViewDefinition_HeightMode) property. The height modes are as follows.

<table>
<tr>
<th>
Height mode
</th>
<th>
Definition
</th>
</tr>
<tr>
<td>
<code>Auto</code>
</td>
<td>
Arranges template for the actual size as the {{'RowTemplate'| markdownify}} is measured.
</td>
</tr>
<tr>
<td>
<code>Fixed</code>
</td>
<td>
Arranges template for the specified height in {{'[TemplateViewDefinition.Height]()'| markdownify}}.
</td>
</tr>
<tr>
<td>
<code>ViewportHeight</code>
</td>
<td>
Arranges template for the <code>ViewPortHeight</code> when the {{'RowTemplate'| markdownify}} actual height is greater than <code>ViewPortHeight</code>.
</td>
</tr>
</table>

## Populating record template view using events

You can set the [RowTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.TemplateViewDefinition.html#Syncfusion_Maui_DataGrid_TemplateViewDefinition_RowTemplate) on-demand when expanding the record by using the [DataGridDetailsViewExpandingEventArgs.RowTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewExpandingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridDetailsViewExpandingEventArgs_RowTemplate) property in [SfDataGrid.DetailsViewExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewExpanding) event handler.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid Name="dataGrid"
                       DetailsViewExpanding="dataGrid_DetailsViewExpanding"                                   
                       ItemsSource="{Binding Employees}">
    <datagrid:SfDataGrid.DetailsViewDefinition>
        <datagrid:TemplateViewDefinition  RowTemplate="{StaticResource DetailViewTemplate}"/>
    </datagrid:SfDataGrid.DetailsViewDefinition>
</Syncfusion.SfDataGrid>

{% endhighlight %}
{% highlight c# %}

private void dataGrid_DetailsViewExpanding(object sender, DataGridDetailsViewExpandingEventArgs e)
{
    e.RowTemplate = GetDataTemplate();
}

public DataTemplate GetDataTemplate()
{
    return new DataTemplate(() =>
    {
        var label = new Label();
        label.SetBinding(Label.TextProperty, "Data.ShipCity");
        return label;
    });
}      

{% endhighlight %}
{% endtabs %}

## Expanding and collapsing row template programmatically

The SfDataGrid allows you to expand or collapse the `RowTemplate` programmatically in different ways.

### Expand or collapse all the row template

You can expand or collapse all the `RowTemplate` by using the [ExpandAllDetailsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandAllDetailsView) and [CollapseAllDetailsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CollapseAllDetailsView) methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllDetailsView();
this.dataGrid.CollapseAllDetailsView();
{% endhighlight %}
{% endtabs %}

### Expand or collapse row template based on record index

You can expand or collapse the `RowTemplate` based on the record index by using the [ExpandDetailsViewAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandDetailsViewAt_System_Int32_) and [CollapseDetailsViewAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CollapseDetailsViewAt_System_Int32_) methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandDetailsViewAt(1);
this.dataGrid.CollapseDetailsViewAt(1);
{% endhighlight %}
{% endtabs %}

## Handling events 

### DetailsViewExpanding

The [DetailsViewExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewExpanding) event is raised when the `RowTemplate` is being expanded by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanding += dataGrid_DetailsViewExpanding;

void dataGrid_DetailsViewExpanding(object sender, DataGridDetailsViewExpandingEventArgs e)
{
}
{% endhighlight %}
{% endtabs %}

### DetailsViewExpanded

The [DetailsViewExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewExpanded) event is raised when the `RowTemplate` is expanded by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanded += dataGrid_DetailsViewExpanded;

void dataGrid_DetailsViewExpanded(object sender, DataGridDetailsViewExpandedEventArgs e)
{
}
{% endhighlight %}
{% endtabs %}

### DetailsViewCollapsing

The [DetailsViewCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewCollapsing) event is raised when the `RowTemplate` is being collapsed by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewCollapsing += dataGrid_DetailsViewCollapsing;

void dataGrid_DetailsViewCollapsing(object sender, DataGridDetailsViewCollapsingEventArgs e)
{
}
{% endhighlight %}
{% endtabs %}

### DetailsViewCollapsed

The [DetailsViewCollapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewCollapsed) event is raised when the `RowTemplate` is collapsed by using an expander.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewCollapsed += dataGrid_DetailsViewCollapsed;

void dataGrid_DetailsViewCollapsed(object sender, DataGridDetailsViewCollapsedEventArgs e)
{
}
{% endhighlight %}
{% endtabs %}

### Cancel expanding or collapsing operations through events

You can cancel the expanding operation when expanding the `RowTemplate` by using the [DataGridDetailsViewExpandingEventArgs.Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewExpandingEventArgs.html) property in the [DetailsViewExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewExpanding) event handler.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewExpanding += dataGrid_DetailsViewExpanding;

void dataGrid_DetailsViewExpanding(object sender, DataGridDetailsViewExpandingEventArgs e)
{
     if ((e.Record as Employee).EmployeeID == 1002)
     e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

Similarly, the collapsing operation can also be canceled through the [DataGridDetailsViewCollapsingEventArgs.Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDetailsViewCollapsingEventArgs.html) property in [DetailsViewCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewCollapsing) event handler.

{% tabs %}
{% highlight c# %}
this.dataGrid.DetailsViewCollapsing += dataGrid_DetailsViewCollapsing;

void dataGrid_DetailsViewCollapsing(object sender, DataGridDetailsViewCollapsingEventArgs e)
{
     if ((e.Record as Employee).EmployeeID == 1002)
     e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Limitations

Limitations are:

* Does not support both `DetailsViewTemplate` and `DetailsViewDataGrid` at same level.
* Does not support more than one `DetailsViewTemplate` in same level.
