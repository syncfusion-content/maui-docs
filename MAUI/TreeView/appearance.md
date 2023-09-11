---
layout: post
title: Appearance | TreeView for Maui | Syncfusion
description: Learn about Appearance support in Syncfusion Maui Treeview (SfTreeView) Control and more details.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Appearance in Maui TreeView (SfTreeView)

The .NET MAUI SfTreeView allows customizing appearance of the underlying data, and provides different functionalities to the end-user.

## ItemTemplate
 
A template can be used to present the data in a way that makes sense for the application by using different controls.

The TreeView allows you to customize the appearance of content view and expander view by setting the `ItemTemplate` and `ExpanderTemplate` properties.

{% tabs %}
{% highlight xaml hl_lines="15" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
       <local:FileManagerViewModel x:Name="viewModel"></local:FileManagerViewModel>
    </ContentPage.BindingContext>
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView"
                              ItemTemplateContextType="Node"
                              ChildPropertyName="SubFiles"
                              ItemsSource="{Binding ImageNodeInfo}"/>
             <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                    <Grid Padding="5,0,0,0">
                        <Label Text="{Binding Content.ItemName}" 
                               VerticalTextAlignment="Center"/>
                   </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
       </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c#  hl_line= "15" %}
using Syncfusion.Maui.TreeView;

namespace GettingStarted
{
    public class MainPage : ContentPage
    {
        SfTreeView treeView;
        public MainPage()
        {
            InitializeComponent();
            treeView = new SfTreeView();
            FileManagerViewModel viewModel = new FileManagerViewModel();
            treeView.ChildPropertyName = "SubFiles";
            treeView.ItemTemplateContextType = ItemTemplateContextType.Node;
            treeView.ItemsSource = viewModel.ImageNodeInfo; 
            treeView.ItemTemplate = new DataTemplate(() => {
                var grid = new Grid ();
                var itemName = new Label;
                itemName.SetBinding(Label.TextProperty, new Binding("Content.ItemName"));
                grid.Children.Add(itemName);
                return grid;
            });
            this.Content = treeView;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## BindingContext for ItemTemplate

By default, the binding context of tree view item will be the data model object for Bound Mode and `TreeViewNode` for Unbound Mode.

For Bound Mode, you can change the binding context of the treeview items by using `ItemTemplateContextType` property.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
       <local:FileManagerViewModel x:Name="viewModel"></local:FileManagerViewModel>
    </ContentPage.BindingContext>
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView"
                              ItemTemplateContextType="Node"
                              ChildPropertyName="SubFiles"
                              ItemsSource="{Binding ImageNodeInfo}"/>
             <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                    <Grid Padding="5,0,0,0">
                        <Label Text="{Binding Content.ItemName}" 
                               VerticalTextAlignment="Center"/>
                   </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
       </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.TreeView;

namespace GettingStarted
{
    public class MainPage : ContentPage
    {
        SfTreeView treeView;
        public MainPage()
        {
            InitializeComponent();
            treeView = new SfTreeView();
            FileManagerViewModel viewModel = new FileManagerViewModel());
            treeView.ChildPropertyName = "SubFiles";
            treeView.ItemTemplateContextType = ItemTemplateContextType.Node;
            treeView.ItemsSource = viewModel.ImageNodeInfo; 
            treeView.ItemTemplate = new DataTemplate(() => {
                var grid = new Grid ();
                var itemName = new Label;
                itemName.SetBinding(Label.TextProperty, new Binding("Content.ItemName"));
                grid.Children.Add(itemName);
                return grid;
            });
            this.Content = treeView;
        }
    }
}
{% endhighlight %}
{% endtabs %}

Similarly, you can customize the expander view by using `ExpanderTemplate` property like above example.

## ItemTemplate Selector
The TreeView allows you to customize the appearance of each item with different templates based on specific constraints by using the `DataTemplateSelector`. You can choose a `DataTemplate` for each item at runtime based on the value of data-bound property using `DataTemplateSelector`.

### Create a data template selector
Create custom class that inherits from `DataTemplateSelector`, and override the `OnSelectTemplate` method to return the `DataTemplate` for that item. At runtime, the TreeView invokes the `OnSelectTemplate` method for each item and passes the data object as parameter.

Create different templates and by using `DataTemplateSelector`, load those templates using `OnSelectTemplate` based on requirements.

{% tabs %}
{% highlight c# %}
public class ItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate Template1 { get; set; }
    public DataTemplate Template2 { get; set; }
    public ItemTemplateSelector()
    {
        this.Template1 = new DataTemplate(typeof(Template1));
        this.Template2 = new DataTemplate(typeof(Template2));
    }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var treeviewNode = item as TreeViewNode;
        if (treeviewNode == null)
            return null;
        if (treeviewNode.Level == 0)
            return Template1;
        else
            return Template2;
    }
}
{% endhighlight %}
{% endtabs %}

### Applying a data template selector

Assign custom `DataTemplateSelector` to the `ItemTemplate` either in XAML or C#.

Following code example illustrates to load the different templates for treeview items using `DataTemplateSelector` based on different levels.

{% tabs %}
{% highlight xaml hl_lines="13" %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">
  <ContentPage.Resources>
    <ResourceDictionary>
      <local:ItemTemplateSelector x:Key="ItemTemplateSelector" />
    </ResourceDictionary>
  </ContentPage.Resources>
     <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView" 
                               ItemTemplate="{StaticResource ItemTemplateSelector}"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
SfTreeView treeView = new SfTreeView();
treeView.ItemTemplate = new ItemTemplateSelector()
{% endhighlight %}
<% endtabs %>
Download the entire source code from GitHub here

Similarly, you can provide `DataTemplateSelector` for `ExpanderTemplate` property.

## Indentation

The TreeView allows customizing the indent spacing of items by setting the `Indentation` property. The default value of this property is `30`. This property can be customized at runtime.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" Indentation="40">
{% endhighlight %}
{% highlight c# hl_lines="2" %}
SfTreeView treeView = new SfTreeView();
treeView.Indentation = 30;
{% endhighlight %}
<% endtabs %>

## ExpanderWidth

The TreeView allows customizing the width of expander view by setting the `ExpanderWidth` property. The default value of this property is `32d`. This property can be customized at runtime.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ExpanderWidth="40">
{% endhighlight %}
{% highlight c# hl_lines="2" %}
SfTreeView treeView = new SfTreeView();
treeView.ExpanderWidth = 32;
{% endhighlight %}
<% endtabs %>

## ExpanderPosition
The TreeView allows you change the position of expander view by setting the `ExpanderPosition` property. The default value of this property is `Start`.This property has following two positions:

* `Start`: Allows displaying the expander view at the start position.
* `End`: Allows displaying the expander view at the end position.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ExpanderPosition="End">
{% endhighlight %}
{% highlight c# hl_lines="2" %}
SfTreeView treeView = new SfTreeView();
treeView.ExpanderPosition = ExpanderPosition.End;
{% endhighlight %}
<% endtabs %>

## Level based styling

The TreeView allows you to customize the style of `TreeViewItem` based on different levels by using `IValueConverter`.

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">
<ContentPage.Resources>
    <ResourceDictionary>
        <local:FontAttributeConverter x:Key="FontAttributeConverter"/>
    </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
    <syncfusion:SfTreeView x:Name="treeView"
                           ChildPropertyName="SubFolder"
                           AutoExpandMode="AllNodesExpanded"
                           ItemTemplateContextType="Node"
                           ItemsSource="{Binding Folders}">
        <syncfusion:SfTreeView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Label LineBreakMode="NoWrap"
                               Text="{Binding Content.FolderName}"
                               FontSize="Medium"
                               FontAttributes="{Binding Level,Converter={x:StaticResource FontAttributeConverter}}"/>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfTreeView.ItemTemplate>
    </syncfusion:SfTreeView>
</ContentPage.Content>
</ContentPage>
{% endhighlight %}
<% endtabs %>

{% endhighlight %}
{% highlight c# %}
public class FontAttributeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var level = (int)value;
        return level == 0 ? FontAttributes.Bold : FontAttributes.Italic;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
<% endtabs %>
Download the entire source code from GitHub here.
