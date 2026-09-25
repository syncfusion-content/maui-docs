---
layout: post
title: Expander Column Customization in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to customize the expander column in Syncfusion® .NET MAUI Tree Grid, including icons, width, column placement, and node expansion.
platform: maui
control: SfTreeGrid
documentation: ug
keywords : maui treegrid expander column, maui tree grid expander, .net maui treegrid expander icon, maui hierarchical grid expander, maui treegrid node expansion
---

# Expander Column Customization in .NET MAUI Tree Grid

The [.NET MAUI Tree Grid]() displays hierarchical data using an expander column that allows users to expand and collapse parent nodes. The `SfTreeGrid` provides various customization options for the expander column, including customizing the expander icon, changing the expander column, modifying the expander column width, and controlling the initial expansion state through a data source property.

## Load expander icon through template

The `SfTreeGrid` allows you to customize the expand and collapse indicator by using the [SfTreeGrid.ExpanderIcon]() property. This property accepts a DataTemplate that enables you to replace the default expander icon with custom content.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.ExpanderIcon>
        <DataTemplate>
            <Image Source="expand_icon.png"
                   HeightRequest="15"
                   WidthRequest="15"/>
        </DataTemplate>
    </syncfusion:SfTreeGrid.ExpanderIcon>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ExpanderIcon = new DataTemplate(() =>
{
    return new Image
    {
        Source = "expand_icon.png",
        HeightRequest = 15,
        WidthRequest = 15
    };
});
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid expander icon template" src="Images\expander\maui-treegrid-expander-icon-template.png" width="404">

## Load expander icon through template selector

The `SfTreeGrid` allows you to use a [DataTemplateSelector]() with the `ExpanderIcon` property to display different icons for expanded and collapsed nodes.

The following example shows how to load separate templates for expanded and collapsed states using a custom DataTemplateSelector.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="Collapsed">
            <Image HeightRequest="12"
                   WidthRequest="12">
                <Image.Source>
                    <FontImageSource Color="Black"
                                     Glyph="&#xe704;"
                                     FontFamily="{OnPlatform iOS=MauiMaterialAssets, MacCatalyst=MauiMaterialAssets, WinUI=MauiMaterialAssets.ttf#, Android=MauiMaterialAssets.ttf#}"/>
                </Image.Source>
            </Image>
        </DataTemplate>
        <DataTemplate x:Key="Expanded">
            <Image HeightRequest="12"
                   WidthRequest="12">
                <Image.Source>
                    <FontImageSource Color="Black"
                                     Glyph="&#xe701;"
                                     FontFamily="{OnPlatform iOS=MauiMaterialAssets, MacCatalyst=MauiMaterialAssets, WinUI=MauiMaterialAssets.ttf#, Android=MauiMaterialAssets.ttf#}"/>
                </Image.Source>
            </Image>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">

    <syncfusion:SfTreeGrid.ExpanderIcon>
        <local:ExpanderIconTemplateSelector ExpandedTemplate="{StaticResource Expanded}"
                                            CollapsedTemplate="{StaticResource Collapsed}"/>
    </syncfusion:SfTreeGrid.ExpanderIcon>

</syncfusion:SfTreeGrid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public class ExpanderIconTemplateSelector : DataTemplateSelector
{
    public DataTemplate? ExpandedTemplate { get; set; }

    public DataTemplate? CollapsedTemplate { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        if (item is TreeNode treeNode)
        {
            return treeNode.IsExpanded
                ? ExpandedTemplate
                : CollapsedTemplate;
        }

        return CollapsedTemplate;
    }
}
{% endhighlight %}
{% endtabs %}

> **Note:**
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

<img alt="TreeGrid expander icon template selector" src="Images\expander\maui-treegrid-expander-icon-template-selector.png" width="404">

## Change the expander column

By default, the expander icon is displayed in the first column. You can display the expander icon in another column by specifying the corresponding column mapping name using the [SfTreeGrid.ExpanderColumn]() property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ExpanderColumn="LastName">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ExpanderColumn = "LastName";
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Change expander column in .NET MAUI TreeGrid" src="Images\expander\maui-treegrid-expander-column.png" width="404">

## Customize the width of the expander column

The `SfTreeGrid` provides support to customize the width of the expander column by using the [SfTreeGrid.ExpanderWidth]() property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ExpanderWidth="50">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ExpanderWidth = 50;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid with customized expander column width" src="Images\expander\maui-treegrid-expander-width.png" width="404">

## Expand nodes using a model property

The `SfTreeGrid` provides support to control the initial expansion state of nodes through a property in the underlying data object by using the [SfTreeGrid.ExpandStateMappingName]() property.

{% tabs %}
{% highlight xaml %}   
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       ExpandStateMappingName="Availability">
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.ExpandStateMappingName = "Availability";
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid expand nodes using model property" src="Images\expander\maui-treegrid-expand-state-mapping.png" width="404">