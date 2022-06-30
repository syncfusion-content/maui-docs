---
layout: post
title: Styling in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Styling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Styling in .NET MAUI DataGrid (SfDataGrid)

The data grid applies style for all of its elements by setting desired values to the style properties in SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" >
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle HeaderRowBackground="Red" HeaderRowTextColor="White" RowBackground="Bisque" RowTextColor="Red"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.HeaderRowBackground = Colors.Red;
        this.dataGrid.DefaultStyle.HeaderRowTextColor = Colors.White;
        this.dataGrid.DefaultStyle.RowBackground = Colors.Bisque;
        this.dataGrid.DefaultStyle.RowTextColor = Colors.Red;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Styling based on DefaultStyle](Images/styling/Styles_1.png)

## Set datagrid style from application resources
You can write custom style for the properties in SfDataGrid.DefaultStyle class using application resource and consume the custom style as static resource to the DefaultSyle property for the required DataGrid used in that page.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<Application.Resources>
    <ResourceDictionary>
        <syncfusion:DataGridStyle x:Key="customStyle" 
                                  RowBackground="Bisque"
                                  HeaderRowBackground="Red"
                                  RowTextColor="Red"
                                  HeaderRowTextColor="White"/>
    </ResourceDictionary>
</Application.Resources>
<ContentPage.Content>
    <syncfusion:SfDataGrid DefaultStyle="{StaticResource customStyle}" ItemsSource="{Binding OrderInfoCollection}" />
</ContentPage.Content>
{% endhighlight %}
{% endtabs %}

## Set datagrid style from page resources
You can write custom style for the properties in SfDataGrid.DefaultStyle class using page resource and consume the custom style as static resource to the DefaultSyle property for the required DataGrid used in that page.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.Resources>
    <ResourceDictionary>
        <syncfusion:DataGridStyle x:Key="customStyle" 
                                  RowBackground="Bisque"
                                  HeaderRowBackground="Red"
                                  RowTextColor="Red"
                                  HeaderRowTextColor="White"/>
    </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
    <syncfusion:SfDataGrid DefaultStyle="{StaticResource customStyle}" ItemsSource="{Binding OrderInfoCollection}" />
</ContentPage.Content>
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Styling based on DefaultStyle in APP or Page resource](Images/styling/Styles_2.png)

## Implicit styling
The appearance of DataGrid (SfDataGrid) and its inner elements can be customized by writing style of TargetType to those control. If the key is not specified, then the style will be applied to all the SfDataGrid in its scope. You can apply specific to SfDataGrid or DataRow or cell using various properties exposed.

### Styling Record cell
The record cells can be customized by writing style of TargetType DataGridCell. Underlying record will be the DataContext for GridCell.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.Resources>
    <Style TargetType="syncfusion:DataGridCell">
        <Setter Property="Background" Value="Bisque"/>
        <Setter Property="TextColor" Value="Red"/>
        <Setter Property="FontAttributes" Value="Italic"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="FontFamily" Value="TimesNewRoman"/>
    </Style>
</ContentPage.Resources>
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Styling Record cell](Images/styling/Styles_5.png)

### Styling Record row
The record row can be customized by writing style of TargetType DataGridRow. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<Style TargetType="syncfusion:DataGridRow">
    <Setter Property="Background" Value="Bisque"/>
</Style>
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Styling Record row](Images/styling/Styles_6.png)

### Styling Header cell
The header cells can be customized by writing style of TargetType DataGridHeaderCell

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<Style TargetType="syncfusion:DataGridHeaderCell">
    <Setter Property="Background" Value="Bisque"/>
    <Setter Property="TextColor" Value="Red"/>
    <Setter Property="FontAttributes" Value="Bold"/>
    <Setter Property="FontSize" Value="14"/>
    <Setter Property="FontFamily" Value="TimesNewRoman"/>
</Style>
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Styling Header cell](Images/styling/Styles_7.png)

### Styling Header row
The header row can be customized by writing style of TargetType DataGridHeaderRow.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<Style TargetType="syncfusion:DataGridHeaderRow">
    <Setter Property="Background" Value="Bisque"/>
</Style>
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Styling Header row](Images/styling/Styles_8.png)

### Column Styling 
You can apply the style for a particular column by using GridColumn.CellStyle and GridColumn.HeaderStyle property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.Resources>
    <Style TargetType="syncfusion:DataGridHeaderCell" x:Key="customHeaderStyle">
        <Setter Property="Background" Value="Red"/>
        <Setter Property="TextColor" Value="Bisque"/>
        <Setter Property="FontAttributes" Value="Bold"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="FontFamily" Value="TimesNewRoman"/>
    </Style>
    <Style TargetType="syncfusion:DataGridCell" x:Key="customCellStyle">
        <Setter Property="Background" Value="Bisque"/>
        <Setter Property="TextColor" Value="Red"/>
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
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Column Styling ](Images/styling/Styles_15.png)

## Applying alternate row style
You can apply the alternative row color by using AlternateRowBackground in SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle AlternateRowBackground="Bisque"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.AlternateRowBackground = Colors.Bisque;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Applying alternate row style](Images/styling/Styles_3.png)

## Changing the alternation row count
You can customize the alternate row count for applying the alternate row style using the SfDataGrid.AlternationRowCount property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid AlternationRowCount="3" 
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle AlternateRowBackground="Bisque"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.AlternateRowBackground = Colors.Bisque;
        this.dataGrid.AlternationRowCount = 3;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Changing the alternation row count](Images/styling/Styles_4.png)

## Changing the font style
You can apply the style for header and row font attributes by using SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Changing the font style](Images/styling/Styles_9.png)

## Border customization
The data grid customizes the grid borders to vertical, horizontal, both, or none. Set desired value to GridLinesVisibility property in SfDataGrid.GridLinesVisibility or SfDataGrid.HeaderGridLinesVisibility
Following are the list of options available to customize the grid borders:
.	Both
.	Horizontal
.	Vertical
.	None

### Both
The GridLinesVisibility.Both displays the data grid with both horizontal and vertical borders.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"/>
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

![MAUI DataGrid Both GridLinesVisibility](Images/styling/Styles_10.png)

### Horizontal
The GridLinesVisibility.Horizontal allows displays the data grid with horizontal border only.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Horizontal"
                       HeaderGridLinesVisibility="Horizontal"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.GridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.Horizontal;
        this.dataGrid.HeaderGridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.Horizontal;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Horizontal GridLinesVisibility](Images/styling/Styles_11.png)

### Vertical
The GridLinesVisibility.Vertical displays the data grid with vertical border only.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Vertical"
                       HeaderGridLinesVisibility="Vertical"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.GridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.Vertical;
        this.dataGrid.HeaderGridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.Vertical;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Vertical GridLinesVisibility](Images/styling/Styles_12.png)

### None
GridLinesVisibility.None allows you to display the data grid without borders.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="None"
                       HeaderGridLinesVisibility="None"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.GridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.None;
        this.dataGrid.HeaderGridLinesVisibility = Syncfusion.Maui.DataGrid.GridLinesVisibility.None;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid None GridLinesVisibility](Images/styling/Styles_13.png)

## Changing the border width
You can change the border width by using GridLineStrokeThickness  property in SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle GridLineStrokeThickness="3"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.GridLineStrokeThickness = 3;
    }
}
{% endhighlight %}
{% endtabs %}

![MAUI DataGrid Changing the border width](Images/styling/Styles_14.png)