---
layout: post
title: Styling in .NET MAUI TreeGrid | Syncfusion
description: Learn about styling in .NET MAUI TreeGrid control, including DefaultStyle, implicit styling, row and cell styling, and customization options.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, maui gridview, grid in maui, .net maui treegrid, .net maui grid, .net grid maui, .net maui styling, maui styling, maui treegrid styling, treegrid cell styling, tree grid implicit styling
---

# Styling in .NET MAUI TreeGrid

The [SfTreeGrid]() provides comprehensive styling support to customize the appearance of grid elements through multiple approaches. You can apply styles at the column level, row level, or using DefaultStyle and implicit styling. The [SfTreeGrid.DefaultStyle]() property contains all the required styling properties for each element in the TreeGrid, while implicit styling allows you to customize the appearance of specific control types using TargetType styles.

> **Note:** **Styling Priority Order:** Column-level styles (explicit) take precedence over implicit TargetType styles, which take precedence over the default TreeGridStyle.

## Column Styling

You can apply the style for a particular column by using [TreeGridColumn.CellStyle]() and [TreeGridColumn.HeaderStyle]() property. Column-level styling allows you to customize the appearance of cells and headers for a specific column in TreeGrid.

### Cell Styling
You can apply styling for cells of a particular column in TreeGrid using [TreeGridColumn.CellStyle]() property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridCell"
               x:Key="customCellStyle">
            <Setter Property="Background" 
                    Value="#5BC0EB"/>
            <Setter Property="TextColor"
                    Value="#212121"/>
            <Setter Property="FontAttributes" 
                    Value="Italic"/>
            <Setter Property="FontSize" 
                    Value="14"/>
            <Setter Property="FontFamily" 
                    Value="TimesNewRoman"/>
        </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
                       
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="Employee ID"
                                       MappingName="EmployeeID"
                                       CellStyle="{StaticResource customCellStyle}"/>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Column cell style" src="Images\styling\maui-treegrid-column-cell-styling.png" width="404"/>

### Header Styling
You can apply styling for header cell of a particular column in TreeGrid using [TreeGridColumn.HeaderStyle]() property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridHeaderCell"
               x:Key="customHeaderStyle">
            <Setter Property="Background" 
                    Value="#4750DD"/>
            <Setter Property="TextColor" 
                    Value="White"/>
            <Setter Property="FontAttributes" 
                    Value="Bold"/>
            <Setter Property="FontSize" 
                    Value="14"/>
            <Setter Property="FontFamily" 
                    Value="TimesNewRoman"/>
        </Style>
    </ContentPage.Resources>
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="Employee ID"
                                       MappingName="EmployeeID"
                                       HeaderStyle="{StaticResource customHeaderStyle}"/>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Column header style" src="Images\styling\maui-treegrid-column-header-styling.png" width="404"/>

## Implicit Styling

The appearance of `TreeGrid` and its inner elements can be customized by writing style of TargetType to those control. If the key is not specified, then the style will be applied to all the SfTreeGrid in its scope.

### Styling Record Cell

The record cells can be customized by writing a style for [TreeGridCell]() TargetType. The underlying record serves as the DataContext for `TreeGridCell`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridCell">
        <Setter Property="Background"
                          Value="#AFD5FB"/>
        <Setter Property="TextColor"
                          Value="#212121"/>
        <Setter Property="FontAttributes"
                          Value="Italic"/>
        <Setter Property="FontSize"
                          Value="14"/>
        <Setter Property="FontFamily"
                          Value="TimesNewRoman"/>
    </Style>
    <Style TargetType="treeGrid:TreeGridExpanderCell">
        <Setter Property="Background" 
                          Value="#AFD5FB"/>
        <Setter Property="TextColor"
                          Value="#212121"/>
        <Setter Property="FontAttributes"
                          Value="Italic"/>
        <Setter Property="FontSize" 
                          Value="14"/>
        <Setter Property="FontFamily" 
                          Value="TimesNewRoman"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Implicit cell style" src="Images\styling\maui-treegrid-implicit-record-cell-style.png" width="404"/>

### Styling Header Cell

The header cells can be customized by writing a style for [TreeGridHeaderCell]() TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridHeaderCell">
        <Setter Property="Background" Value="#7BD389"/>
        <Setter Property="TextColor" Value="White"/>
        <Setter Property="FontAttributes" Value="Bold"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="FontFamily" Value="TimesNewRoman"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Implicit header style" src="Images\styling\maui-treegrid-implicit-header-cell-style.png" width="404"/>

### Styling Record Row

The record row can be customized by writing a style for [TreeGridRow]() TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridRow">
        <Setter Property="Background" Value="#BADFCD"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Implicit row style" src="Images\styling\maui-treegrid-implicit-record-row-style.png" width="404"/>

### Styling Header Row

The header row can be customized by writing a style for [TreeGridHeaderRow]() TargetType.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridHeaderRow">
        <Setter Property="Background" Value="#FC8F8F"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Implicit header row style" src="Images\styling\maui-treegrid-implicit-header-row-style.png" width="404"/>

## Default Styling

You can customize the appearance of the TreeGrid by using the `DefaultStyle` property. The following example demonstrates how to apply basic styling:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle HeaderRowBackground="#0074E3"
                                  HeaderRowTextColor="White"
                                  RowBackground="#AFD5FB"
                                  RowTextColor="#212121"/>
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = employeeViewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children"
treeGrid.DefaultStyle.HeaderRowBackground = Color.FromArgb("#0074E3");
treeGrid.DefaultStyle.HeaderRowTextColor = Colors.White;
treeGrid.DefaultStyle.RowBackground = Color.FromArgb("#AFD5FB");
treeGrid.DefaultStyle.RowTextColor = Color.FromArgb("#212121");
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Default style" src="Images\styling\maui-treegrid-default-style.png" width="404"/>

### Set TreeGrid Style from Application Resources

You can write custom style for the properties in the `SfTreeGrid.DefaultStyle` class using the application resource and consume the custom style as a static resource to the DefaultStyle property for the required TreeGrid used on that page.

{% tabs %}
{% highlight xaml tabtitle="App.xaml" %}
<Application.Resources>
    <ResourceDictionary>
        <syncfusion:TreeGridStyle x:Key="customStyle" 
                                  RowBackground="#BADFCD"
                                  HeaderRowBackground="#05B084"
                                  RowTextColor="Black"
                                  HeaderRowTextColor="White"/>
    </ResourceDictionary>
</Application.Resources>
{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       DefaultStyle="{StaticResource customStyle}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Set TreeGrid Style from Page Resources

You can write custom style for the properties in the `SfTreeGrid.DefaultStyle` class using page resource and consume the custom style as a static resource to the DefaultStyle property for the required TreeGrid used on that page.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <ResourceDictionary>
        <syncfusion:TreeGridStyle x:Key="customStyle"
                                  RowBackground="#85D5F6"
                                  HeaderRowBackground="#4750DD"
                                  RowTextColor="Black"
                                  HeaderRowTextColor="White"/>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       DefaultStyle="{StaticResource customStyle}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Default style- App page resource" src="Images\styling\maui-treegrid-default-style-app-page-resource.png" width="404"/>

## Grid line customization

### Visibility

The TreeGrid provides support to change the visibility of the vertical and horizontal borders. Set desired value to [SfTreeGrid.GridLinesVisibility]() for data rows or [SfTreeGrid.HeaderGridLinesVisibility]() for header row.

Following are the options available to customize the grid borders:
- Both
- Horizontal
- Vertical
- None

The following example shows how to apply both vertical and horizontal borders for header and data rows:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Content>
    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           ItemsSource="{Binding EmployeeCollection}"
                           ChildPropertyName="Children"
                           GridLinesVisibility="Both"
                           HeaderGridLinesVisibility="Both"/>
</ContentPage.Content>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = employeeViewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Grid line visibility" src="Images\styling\maui-treegrid-gridline-visibility.png" width="404"/>

### Stroke

The grid line color of column header and data row cells can be customized by setting [TreeGridStyle.GridLineColor]() and [TreeGridStyle.HeaderGridLineColor]() properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Content>
    <syncfusion:SfTreeGrid x:Name="treeGrid"
                            ItemsSource="{Binding EmployeeCollection}"
                            GridLinesVisibility="Both"
                            HeaderGridLinesVisibility="Both">
        <syncfusion:SfTreeGrid.DefaultStyle>
            <syncfusion:TreeGridStyle HeaderGridLineColor="#219ebc"
                                        GridLineColor="#219ebc"/>
        </syncfusion:SfTreeGrid.DefaultStyle>
    </syncfusion:SfTreeGrid>
</ContentPage.Content>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = employeeViewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.DefaultStyle.HeaderGridLineColor = Color.FromArgb("#219ebc");
treeGrid.DefaultStyle.GridLineColor = Color.FromArgb("#219ebc");
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Changing the border color" src="Images\styling\maui-treegrid-grid-line-customization.png" width="404"/>

### Stroke Thickness

The grid line stroke thickness of column header and data row cells can be customized by setting [TreeGridStyle.GridLineStrokeThickness]() and [TreeGridStyle.HeaderGridLineStrokeThickness]() properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Content>
    <syncfusion:SfTreeGrid x:Name="treeGrid"
                            ItemsSource="{Binding EmployeeCollection}"
                            GridLinesVisibility="Both"
                            HeaderGridLinesVisibility="Both">
        <syncfusion:SfTreeGrid.DefaultStyle>
            <syncfusion:TreeGridStyle HeaderGridLineStrokeThickness="3"
                                        GridLineStrokeThickness="3"/>
        </syncfusion:SfTreeGrid.DefaultStyle>
    </syncfusion:SfTreeGrid>
</ContentPage.Content>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = employeeViewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.DefaultStyle.HeaderGridLineStrokeThickness = 3;
treeGrid.DefaultStyle.GridLineStrokeThickness = 3;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Changing the Border Width" src="Images\styling\maui-treegrid-grid-stroke-thickness-customization.png" width="404"/>