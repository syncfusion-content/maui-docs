---
layout: post
title: Styling in .NET MAUI DataGrid control | Syncfusion
description: Learn all about Styling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui styling, maui styling
---

# Styling in .NET MAUI DataGrid (SfDataGrid)

The [DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) applies style for all of its elements by setting desired values to the style properties in [SfDataGrid.DefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultStyleProperty). This property has all the required styling properties for each and every elements in the DataGrid.

To get start quickly with apply styling .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/1HHHz5isIM4?start=66"></iframe>


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" >
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle HeaderRowBackground="#0074E3" HeaderRowTextColor="White" RowBackground="#AFD5FB" RowTextColor="#212121"/>
            </syncfusion:SfDataGrid.DefaultStyle>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.HeaderRowBackground = Color.FromArgb("#0074E3");
        this.dataGrid.DefaultStyle.HeaderRowTextColor = Colors.White;
        this.dataGrid.DefaultStyle.RowBackground = Color.FromArgb("#AFD5FB");
        this.dataGrid.DefaultStyle.RowTextColor = Color.FromArgb("#212121");
    }
}
{% endhighlight %}
{% endtabs %}

![Default Styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-defaultsyle.png)

## Set datagrid style from application resources
You can write custom style for the properties in the `SfDataGrid.DefaultStyle` class using the application resource and consume the custom style as a static resource to the DefaultStyle property for the required DataGrid used on that page.

{% tabs %}
{% highlight xaml tabtitle="App.xaml" %}
<Application.Resources>
    <ResourceDictionary>
        <syncfusion:DataGridStyle x:Key="customStyle" 
                                  RowBackground="LightBlue"
                                  HeaderRowBackground="Blue"
                                  RowTextColor="Black"
                                  HeaderRowTextColor="White"/>
    </ResourceDictionary>
</Application.Resources>
{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid DefaultStyle="{StaticResource customStyle}" ItemsSource="{Binding OrderInfoCollection}" />
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

## Set datagrid style from page resources
You can write custom style for the properties in the `SfDataGrid.DefaultStyle` class using page resource and consume the custom style as a static resource to the DefaultStyle property for the required DataGrid used on that page.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <ResourceDictionary>
            <syncfusion:DataGridStyle x:Key="customStyle" 
                                  RowBackground="LightBlue"
                                  HeaderRowBackground="Blue"
                                  RowTextColor="Black"
                                  HeaderRowTextColor="White"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfDataGrid DefaultStyle="{StaticResource customStyle}" ItemsSource="{Binding OrderInfoCollection}" />
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![App or Page resource Styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-app-page-resource.png)

## Implicit styling
The appearance of DataGrid (SfDataGrid) and its inner elements can be customized by the writing style of TargetType to those control. If the key is not specified, then the style will be applied to all the SfDataGrid in its scope. You can apply specific to [DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) or [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) using various properties exposed.

### Styling Record cell
The record cells can be customized by the writing style for [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) TargetType. Underlying record will be the DataContext for `DataGridCell`.


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background" Value="#AFD5FB"/>
            <Setter Property="TextColor" Value="#212121"/>
            <Setter Property="FontAttributes" Value="Italic"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Record cell styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-recordcell-style.png)

### Styling Record row
The record row can be customized by the writing style for [DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) TargetType. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridRow">
            <Setter Property="Background" Value="#AFD5FB"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Record row styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-recordrow-style.png)

### Styling Header cell
The header cells can be customized by the writing style for [DataGridHeaderCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridHeaderCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridHeaderCell">
            <Setter Property="Background" Value="#0074E3"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="FontAttributes" Value="Bold"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Header cell styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-headercell-style.png)

### Styling Header row
The header row can be customized by the writing style for [DataGridHeaderRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridHeaderRow.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridHeaderRow">
            <Setter Property="Background" Value="#0074E3"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Header row styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-headerrow-style.png)

### Styling Table Summary cell
The table summary cell can be customized by the writing style for [DataGridTableSummaryCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridTableSummaryCell">
            <Setter Property="Background" Value="#0074E3"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="FontAttributes" Value="Bold"/>
            <Setter Property="FontSize" Value="16"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Table summary cell styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-table-summary-cell-style.png)

### Styling Table Summary row
The table summary row can be customized by the writing style for [DataGridTableSummaryRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRowView.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridTableSummaryRowView">
            <Setter Property="Background" Value="#0074E3"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Table summary row styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-table-summary-row-style.png)

### Styling Caption Summary cell
The caption summary cell can be customized by the writing style for [DataGridCaptionSummaryCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCaptionSummaryCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridCaptionSummaryCell">
            <Setter Property="Background" Value="#0074E3"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="FontAttributes" Value="Bold"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Caption summary cell styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-caption-summary-cell-style.png)

### Styling Caption Summary row
The caption summary row can be customized by the writing style for [DataGridCaptionSummaryRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCaptionSummaryRowView.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridCaptionSummaryRowView">
            <Setter Property="Background" Value="#0074E3"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Caption summary row styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-caption-summary-row-style.png)

### Styling Group Summary cell
The group summary cell can be customized by the writing style for [DataGridGroupSummaryCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridGroupSummaryCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridGroupSummaryCell">
            <Setter Property="Background" Value="#0074E3"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="FontAttributes" Value="Bold"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Group summary cell styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-group-summary-cell-style.png)

### Styling Group Summary row
The group summary row can be customized by the writing style for [DataGridGroupSummaryRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridGroupSummaryRowView.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridGroupSummaryRowView">
            <Setter Property="Background" Value="#0074E3"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Group summary row styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-group-summary-row-style.png)

### Styling unbound row cell
The unbound row cell can be customized by the writing style for [DataGridUnboundRowCell]() TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridUnboundRowCell">
            <Setter Property="Background" Value="#0074E3"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="FontAttributes" Value="Bold"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

<img alt="Unbound row cell styling in .NET MAUI DataGrid" src="Images\styling\maui-datagrid-unbound-row-cell-styling.png" width="404"/>

### Styling unbound row
The unbound row can be customized by the writing style for [DataGridUnboundRowView]() TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridUnboundRowView">
            <Setter Property="Background" Value="#0074E3"/>
        </Style>
    </ContentPage.Resources>
</ContentPage>
{% endhighlight %}
{% endtabs %}

<img alt="Unbound row styling in .NET MAUI DataGrid" src="Images\styling\maui-datagrid-unbound-row-styling.png" width="404"/>

### Styling row header
The row header can be customized by the writing style for `DataGridRowHeaderCell` Target Type. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
     <Style TargetType="syncfusion:DataGridRowHeaderCell">
         <Setter Property="Background" Value="#0074E3"/>
     </Style>
</ContentPage.Resources>
{% endhighlight %}
{% endtabs %}

<img alt="Row header styling in .NET MAUI DataGrid" src="Images\styling\maui-datagrid-show-row-header.png" width="404"/>

### Column Styling 
You can apply the style for a particular column by using [DataGridColumn.CellStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellStyleProperty) and [DataGridColumn.HeaderStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderStyleProperty) property.

N> The column styling (explicit styling) takes higher priority than implicit styling, and implicit styling takes higher priority than default styling in SfDataGrid.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridHeaderCell" x:Key="customHeaderStyle">
            <Setter Property="Background" Value="#0074E3"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="FontAttributes" Value="Bold"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
        <Style TargetType="syncfusion:DataGridCell" x:Key="customCellStyle">
            <Setter Property="Background" Value="#AFD5FB"/>
            <Setter Property="TextColor" Value="#212121"/>
            <Setter Property="FontAttributes" Value="Italic"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontFamily" Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>

    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridTextColumn MappingName="OrderID" HeaderText="Order ID"
                                        CellStyle="{StaticResource customCellStyle}"
                                        HeaderStyle="{StaticResource customHeaderStyle}"/>
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Column Styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-column-style.png)

## Applying alternate row style
You can apply the alternative row color by using [AlternateRowBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_AlternateRowBackground) in `SfDataGrid.DefaultStyle`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle AlternateRowBackground="#AFD5FB"/>
            </syncfusion:SfDataGrid.DefaultStyle>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.AlternateRowBackground = Color.FromArgb("#AFD5FB");
    }
}
{% endhighlight %}
{% endtabs %}

![Alternative row style in .NET MAUI DataGrid](Images/styling/maui-datagrid-Alternativerow-style.png)

## Changing the alternation row count
You can change the row count which should be considered to apply the background for alternate rows using the [SfDataGrid.AlternationRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AlternationRowCountProperty) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid AlternationRowCount="3" 
                            ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle AlternateRowBackground="#AFD5FB"/>
            </syncfusion:SfDataGrid.DefaultStyle>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.AlternateRowBackground = Color.FromArgb("#AFD5FB");
        this.dataGrid.AlternationRowCount = 3;
    }
}
{% endhighlight %}
{% endtabs %}

![Changing the alternation row count in .NET MAUI DataGrid](Images/styling/maui-datagrid-Alternation-rowcount.png)

## Changing the font style
You can apply the style for header and row font attributes by using SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle HeaderRowFontAttributes="Bold"
                                        HeaderRowFontFamily="TimesNewRoman"
                                        HeaderRowFontSize="16"
                                        RowFontAttributes="Italic"
                                        RowFontFamily="Adabi"
                                        RowFontSize="14"/>
            </syncfusion:SfDataGrid.DefaultStyle>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Changing the font style .NET MAUI DataGrid](Images/styling/maui-datagrid-font-style.png)

## Border customization
The DataGrid provides support to change the visibility of the vertical and horizontal borders. Set desired value to [SfDataGrid.GridLinesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GridLinesVisibilityProperty) for data rows or [SfDataGrid.HeaderGridLinesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderGridLinesVisibilityProperty) for header row.

Following are the list of options available to customize the grid borders:
.	Both
.	Horizontal
.	Vertical
.	None

The following example shows how to apply both vertical and horizontal borders for header and data rows,

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}"
                            GridLinesVisibility="Both"
                            HeaderGridLinesVisibility="Both"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.GridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.Both;
        this.dataGrid.HeaderGridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.Both;
    }
}
{% endhighlight %}
{% endtabs %}

![Both GridLinesVisibility in .NET MAUI DataGrid](Images/styling/maui-datagrid-both-gridlinesvisibility.png)

## Changing the border color

The grid line color of column header and data row cells can be customized by setting [DataGridStyle.GridLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GridLineColorProperty) and `DataGridStyle.HeaderGridLineColor` properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle HeaderGridLineColor="#219ebc"/>
                <syncfusion:DataGridStyle GridLineColor="#219ebc"/>
            </syncfusion:SfDataGrid.DefaultStyle>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
var defaultsyle = new DataGridStyle() 
{ 
   HeaderGridLineColor = Color.FromArgb("#219ebc"),
   GridLineColor = Color.FromArgb("#219ebc")
};
dataGrid.DefaultStyle = defaultsyle;
{% endhighlight %}
{% endtabs %}

<img alt="MAUI-DataGrid with border color customization" src="Images/styling/maui-datagrid-border-color.png" width="404"/>

## Changing the border width

The grid line stroke thickness of column header and data row cells can be customized by setting [DataGridStyle.GridLineStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GridLineStrokeThicknessProperty) and `DataGridStyle.HeaderGridLineStrokeThickness` properties. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle HeaderGridLineStrokeThickness="3"/>
                <syncfusion:DataGridStyle GridLineStrokeThickness="3"/>
            </syncfusion:SfDataGrid.DefaultStyle>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
var defaultsyle = new DataGridStyle()
 {
    HeaderGridLineStrokeThickness = 3,
    GridLineStrokeThickness = 3 
 };
dataGrid.DefaultStyle = defaultsyle;
{% endhighlight %}
{% endtabs %}

<img alt="MAUI-DataGrid with border width customization" src="Images/styling/maui-datagrid-border-width.png" width="404"/>


