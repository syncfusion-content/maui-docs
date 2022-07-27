---
layout: post
title: Conditional Styling in .NET MAUI DataGrid control | Syncfusion
description: Learn all about Conditional Styling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Conditional Styling in .NET MAUI DataGrid (SfDataGrid)
The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) allows you to customize the style of the individual cells and rows based on the requirements. 

## Conditional row style
The data rows can be customized conditionally by writing the style with a converter for the [DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) control. Its BindingContext is the underlying datasource object.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <Style TargetType="syncfusion:DataGridRow">
            <Setter Property="Background" Value="{Binding Converter={StaticResource converter}}" />
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var input = (value as OrderInfo).OrderID;
        if (input < 1003)
            return Colors.Bisque;
        else if (input < 1007)
            return Colors.LightBlue;
        else
            return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional DataGridRow styling in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridrowstyle.png)

## Style a particular row based on row index
Styling can be applied to a particular row based on RowIndex property by writing the style for the [DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <Style TargetType="syncfusion:DataGridRow">
            <Setter Property="Background" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var dataGridRow = value as DataGridRow;
        var rowIndex = dataGridRow.DataRow.RowIndex;
        if (rowIndex == 3)
           return Colors.LightBlue;
        else
            return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional DataGridRow styling Based on RowIndex in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridrowstyle_basedonrowindex.png)

## Style a particular row based on RowData
Styling can be applied to a particular row based on the RowData property by writing the style for the [DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <Style TargetType="syncfusion:DataGridRow">
            <Setter Property="Background" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var dataGridRow = value as DataGridRow;
        var rowData = dataGridRow.DataRow.RowData;
        if(rowData == (dataGridRow.DataGrid.BindingContext as ViewModel).OrderInfoCollection[5])
            return Colors.LightBlue;
        else
            return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional DataGridRow styling Based on RowData in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridrowstyle_basedonrowdata.png)

## Conditional style for particular column

The `SfDataGrid` provides the support to apply the conditional style for specific column by using the [CellStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellStyleProperty) property in the [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.Columns>
                <syncfusion:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID"  Format="d">
                    <syncfusion:DataGridNumericColumn.CellStyle>
                        <Style TargetType="syncfusion:DataGridCell">
                            <Setter Property="Background" Value="{Binding OrderID, Converter={StaticResource converter}}"/>
                        </Style>
                    </syncfusion:DataGridNumericColumn.CellStyle>
                </syncfusion:DataGridNumericColumn>
            </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        if ((int)value < 1006)
            return Colors.LightBlue;
        else
            return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional column styling in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-columnstyle-conditional.png)

## Conditional cell style
The grid cell can be customized conditionally by writing the style with a converter for the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) control. Its BindingContext is the underlying datasource object.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background" Value="{Binding OrderID, Converter={StaticResource converter}}"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        if ((int)value < 1006)
            return Colors.LightBlue;
        else
            return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional cell styling in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridcellstyle.png)

## Style a cell based on MappingName and RowColumnIndex
Styling can be applied to a particular cell based on RowIndex, ColumnIndex and MappingName property of the column by writing the style for the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <local:ForeColorConverter x:Key="foreColorconverter"/>
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}"/>
            <Setter Property="TextColor" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=foreColorconverter}}"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var gridCell = (value as DataGridCell);
        var columnIndex = gridCell.ColumnIndex;
        var rowIndex = gridCell.RowIndex;
        var mappingName = gridCell.DataColumn.DataGridColumn.MappingName;
        if (columnIndex == 0 && rowIndex % 3 == 1)
            return Colors.BlueViolet;
        else if (mappingName == "ShipCountry")
            return Colors.CornflowerBlue;
        else if (columnIndex == 1 && rowIndex % 4 == 0)
            return Colors.YellowGreen;
        else if (columnIndex == 3 && rowIndex % 6 == 1)
            return Colors.PaleVioletRed;
        return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% highlight xaml tabtitle="ForeColorConverter.cs"%}
public class ForeColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var gridCell = (value as DataGridCell);
        var columnIndex = gridCell.ColumnIndex;
        var rowIndex = gridCell.RowIndex;
        var mappingName = gridCell.DataColumn.DataGridColumn.MappingName;
        if (columnIndex == 0 && rowIndex % 3 == 1)
            return Colors.Wheat;
        else if (mappingName == "ShipCountry")
            return Colors.White;
        else if (columnIndex == 1 && rowIndex % 4 == 0)
            return Colors.Red;
        else if (columnIndex == 3 && rowIndex % 6 == 1)
            return Colors.Yellow;

        return Colors.Black;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional cell styling based in MappingName RowColumnIndex in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridcelltyle_basedonmappingname_rowcolumnindex.png)

## Style a cell based on RowIndex and ColumnIndex
Styling can be applied to a particular cell based on RowIndex and ColumnIndex property by writing the style for the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) TargetType.


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <local:ForeColorConverter x:Key="foreColorconverter"/>
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}"/>
            <Setter Property="TextColor" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=foreColorconverter}}"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var gridCell = (value as DataGridCell);
        var columnIndex = gridCell.ColumnIndex;
        var rowIndex = gridCell.RowIndex;
        if(columnIndex == 0 && rowIndex == 1)
            return Colors.BlueViolet;
        return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% highlight xaml tabtitle="ForeColorConverter.cs"%}
public class ForeColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var gridCell = (value as DataGridCell);
        var columnIndex = gridCell.ColumnIndex;
        var rowIndex = gridCell.RowIndex;
        if(columnIndex == 0 && rowIndex == 1)
            return Colors.White;
        return Colors.Black;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional cell styling based on RowIndex and ColumnIndex in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridcelltyle_basedon_rowcolumnindex.png)

## Style a cell based on cell value
Styling can be applied to a particular cell based on CellValue property by writing the style for the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <local:ColorConverter x:Key="converter"/>
        <local:ForeColorConverter x:Key="foreColorconverter"/>
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}"/>
            <Setter Property="TextColor" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=foreColorconverter}}"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% highlight xaml tabtitle="ColorConverter.cs"%}
public class ColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var gridCell = (value as DataGridCell);
        var cellValue = gridCell.CellValue;
        if (cellValue.Equals("Thomas Hardy"))
            return Colors.LightBlue;
        return Colors.White;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% highlight xaml tabtitle="ForeColorConverter.cs"%}
public class ForeColorConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var gridCell = (value as DataGridCell);
        var cellValue = gridCell.CellValue;
        if (cellValue.Equals("Thomas Hardy"))
            return Colors.Red;
        return Colors.Black;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

![Conditional cell styling based on CellValue in .NET MAUI DataGrid](Images/conditional-styling/maui-datagrid-conditional-datagridcellstyle_basedon_cellvalue.png)