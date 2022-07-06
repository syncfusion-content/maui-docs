---
layout: post
title: Styling in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Styling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Styling in .NET MAUI DataGrid (SfDataGrid)

The [DataGrid] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.html) applies style for all of its elements by setting desired values to the style properties in [SfDataGrid.DefaultStyle] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultStyleProperty). This property has all the required styling properties for each and every elements in the DataGrid.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
You can write custom style for the properties in `SfDataGrid.DefaultStyle` class using application resource and consume the custom style as static resource to the DefaultSyle property for the required DataGrid used in that page.

{% tabs %}
{% highlight xaml tabtitle="App.xaml"%}
<Application.Resources>
    <ResourceDictionary>
        <syncfusion:DataGridStyle x:Key="customStyle" 
                                  RowBackground="Bisque"
                                  HeaderRowBackground="Red"
                                  RowTextColor="Red"
                                  HeaderRowTextColor="White"/>
    </ResourceDictionary>
</Application.Resources>
{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid DefaultStyle="{StaticResource customStyle}" ItemsSource="{Binding OrderInfoCollection}" />
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

## Set datagrid style from page resources
You can write custom style for the properties in `SfDataGrid.DefaultStyle` class using page resource and consume the custom style as static resource to the DefaultSyle property for the required DataGrid used in that page.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
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
</ContentPage>
{% endhighlight %}
{% endtabs %}

![App or Page resource Styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-app-page-resource.png)

## Implicit styling
The appearance of DataGrid (SfDataGrid) and its inner elements can be customized by writing style of TargetType to those control. If the key is not specified, then the style will be applied to all the SfDataGrid in its scope. You can apply specific to [DataGridRow] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) or [DataGridCell] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) using various properties exposed.

### Styling Record cell
The record cells can be customized by writing style for [DataGridCell] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) TargetType. Underlying record will be the DataContext for `DataGridCell`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
The record row can be customized by writing style for [DataGridRow] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html) TargetType. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
The header cells can be customized by writing style for [DataGridHeaderCell] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridHeaderCell.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
The header row can be customized by writing style for [DataGridHeaderRow] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridHeaderRow.html) TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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

### Column Styling 
You can apply the style for a particular column by using [DataGridColumn.CellStyle] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellStyleProperty) and [DataGridColumn.HeaderStyle] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderStyleProperty) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
    </syncfusion:SfDataGrid>]
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Column Styling in .NET MAUI DataGrid](Images/styling/maui-datagrid-column-style.png)

## Applying alternate row style
You can apply the alternative row color by using [AlternateRowBackground] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_AlternateRowBackground) in `SfDataGrid.DefaultStyle`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
You can change the row count which should be considered to apply the background for alternate rows using the [SfDataGrid.AlternationRowCount] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AlternationRowCountProperty) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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
{% highlight xaml tabtitle="MainPage.xaml"%}
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
The DataGrid provides support to change the visibility of the vertical and horizontal borders. Set desired value to [SfDataGrid.GridLinesVisibility] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GridLinesVisibilityProperty) for data rows or [SfDataGrid.HeaderGridLinesVisibility] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderGridLinesVisibilityProperty) for header row.

Following are the list of options available to customize the grid borders:
.	Both
.	Horizontal
.	Vertical
.	None

The following example shows how to apply both vertical and horizontal borders for header and data rows,

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
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

## Changing the border width
You can change the border width by using [GridLineStrokeThickness] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GridLineStrokeThicknessProperty) property in `SfDataGrid.DefaultStyle`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <ContentPage.Content>
        <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle GridLineStrokeThickness="3"/>
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
        this.dataGrid.DefaultStyle.GridLineStrokeThickness = 3;
    }
}
{% endhighlight %}
{% endtabs %}

![Changing the border width in .NET MAUI DataGrid](Images/styling/maui-datagrid-border-width.png)