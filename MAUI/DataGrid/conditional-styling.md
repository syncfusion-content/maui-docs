---
layout: post
title: Conditional Styling in .NET MAUI DataGrid control | Syncfusion
description: Learn all about Conditional Styling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Conditional Styling in .NET MAUI DataGrid (SfDataGrid)
The [SfDataGrid] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) allows to customize the style of the individual cells and rows based on the requirements. It can be customized in the following ways:

1. Using column CellStyle
2. Using Converter
3. Using DataTriggers

## Conditional Row Style
The record rows ([DataGridRow] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html)) can be customized conditionally by changing its property value based on ‘cell value’ or ‘data object’ by using converter, where converter returns the value based on underlying record.

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

## How to style a particular row based on RowIndex
Styling can be applied to a particular row based on RowIndex property by writing the style for [DataGridRow] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) TargetType.

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

## How to style a particular row based on RowData
Styling can be applied to a particular row based on RowData property by writing the style for [DataGridRow] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) TargetType.

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

## Conditional Style for Column 

The `SfDataGrid` provides the support for apply the conditional style for a column by using [CellStyle] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellStyleProperty) property in [SfDataGrid.Column] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html).

% tabs %}
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



