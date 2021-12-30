---
layout: post
title: Grouping in .NET MAUI ListView control | Syncfusion
description: Learn here all about Grouping support in Syncfusion .NET MAUI ListView (SfListView) control, its elements and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Grouping in .NET MAUI ListView (SfListView)

A group represents a collection of items belongs to a category. When grouping is applied, the data is organized into different groups based on key values. Each group is identified by its `Key`, by which you can get the underlying data in the group.

N> When ItemsSource changed for ListView, `DataSource.GroupDescriptors` will be cleared by default. You need to add `DataSource.GroupDescriptors` again after changing ItemsSource if you want to retain grouping in listview.

N> To update grouping for the newly added listview items at runtime, set the `listView.DataSource.LiveDataUpdateMode` to `LiveDataUpdateMode.AllowDataShaping`. To learn more details about the `LiveDataUpdateMode`, refer to `here`.

## Programmatic grouping

The SfListView allows programmatic grouping by defining the `GroupDescriptor` object, and adding it into the `DataSource.GroupDescriptors` collection. The `GroupDescriptor` object holds the following properties:

* `PropertyName`: Describes the name of the property to be grouped.
* `KeySelector`: Describes selector to return the group key.
* `Comparer`: Describes comparer to be applied in when sorting take place.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource" >
  <syncfusion:SfListView x:Name="listView">
    <syncfusion:SfListView.DataSource>
      <data:DataSource>
        <data:DataSource.GroupDescriptors>
          <data:GroupDescriptor PropertyName="BookName"/>
        </data:DataSource.GroupDescriptors>
      </data:DataSource>
    </syncfusion:SfListView.DataSource>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
  PropertyName = "ContactName",
}); 
{% endhighlight %}
{% endtabs %}

## Custom grouping

ListView supports grouping the items based on custom logic for each `GroupDescriptor` by using `KeySelector`. Below topics explains how to achieve different custom grouping use cases with code examples,  

### Grouping based on first character

The SfListView supports grouping the items based on first character of the value assigned to the property name in `GroupDescriptor` by using `KeySelector`.  

{% tabs %}
{% highlight c# %}
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
  PropertyName = "ContactName",
  KeySelector = (object obj1) =>
  {
    var item = (obj1 as Contacts);
    return item.ContactName[0].ToString();
  }
  Comparer = new CustomGroupComparer()
});
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when grouping based on first character.

### Grouping based on more than one property in the data object

Group the items by binding multiple properties to the property name of `GroupDescriptor` by using `KeySelector` in which the group header items can be created with multiple data model object effectively.

{% tabs %}
{% highlight c# %}
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
  PropertyName = "Designation",
  KeySelector = (object obj1) =>
  {
     var item = (obj1 as Employee);
     return item.Designation + item.Level;
  }
});
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when grouping based on more than one property .

### Grouping by ignoring case sensitivity

Grouping the items by ignoring case sensitive by using the `KeySelector` property in the `GroupDescriptor`. While returning the `KeySelector`, convert the required property name in the data model to group either as Upper or Lower case. The items will be grouped based on the `KeySelector` with returned case sensitive.

{% tabs %}
{% highlight c# %}
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor() 
{ 
  PropertyName = "ContactName", 
  KeySelector = (object obj) => 
  { 
    return (obj as Contacts).ContactName.ToUpper()[0]; 
  } 
}); 
{% endhighlight %}
{% endtabs %}

The following screenshot shows grouping by ignoring case sensitivity. 

## Sorting the groups

ListView sorts the groups using default sorting logic of List.

### Custom sorting of groups
The SfListView supports sorting the groups based on custom logic applied to either `SfListView.DataSource.GroupComparer` property or `GroupDescriptor.Comparer` added to the `DataSource.GroupDescriptors` collection.

In custom group comparer, all the items present in a group compares each other based on the items count to each group sorted accordingly.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
            xmlns:dataSource="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource"
             xmlns:local="clr-namespace:CustomGrouping">
  <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding ContactsInfo}">
    <syncfusion:SfListView.DataSource>
      <dataSource:DataSource>
        <dataSource:DataSource.GroupDescriptors>
          <dataSource:GroupDescriptor PropertyName="ContactType">
            <dataSource:GroupDescriptor.Comparer>
              <local:CustomGroupComparer/>
            </dataSource:GroupDescriptor.Comparer>
          </dataSource:GroupDescriptor>
        </dataSource:DataSource.GroupDescriptors>
      </dataSource:DataSource>
    </syncfusion:SfListView.DataSource>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
public class CustomGroupComparer : IComparer<GroupResult>
{
  public int Compare(GroupResult x, GroupResult y)
  {
    if (x.Count > y.Count)
    {
       //GroupResult y is stacked into top of the group i.e., Ascending.
       //GroupResult x is stacked at the bottom of the group i.e., Descending.
        return 1;
    }
    else if (x.Count < y.Count)
    {
       //GroupResult x is stacked into top of the group i.e., Ascending.
       //GroupResult y is stacked at the bottom of the group i.e., Descending.
       return -1;
    }

    return 0;
  }
}
{% endhighlight %}
{% endtabs %}

### Sorting the items within group

Group the items of underlying collection along with sorting by adding the `DataSource.GroupDescriptors` and the `DataSource.SortDescriptors` with required properties.

{% tabs %}
{% highlight c# %}
public GroupingPage()
{
    InitializeComponent();
    listView.DataSource.SortDescriptors.Add(new SortDescriptor { PropertyName = "ContactName", Direction = ListSortDirection.Ascending });
    //Applying custom grouping
    listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
       {
           PropertyName = "ContactName",
           KeySelector = (object obj1) =>
            {
                var item = (obj1 as Contacts);
                return item.ContactName[0].ToString();
            },
        });
}
{% endhighlight %}
{% endtabs %}

## Group header summary

### Aggregate summary

For each group, display the sum of values of the property from model object in the `SfListView.GroupHeaderTemplate` by using converter. 

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource" >
  <syncfusion:SfListView x:Name="listView">
      <syncfusion:SfListView.GroupHeaderTemplate>
                    <DataTemplate x:Name="GroupHeaderTemplate"  x:Key="GroupHeaderTemplate">
                        <ViewCell>
                            <ViewCell.View>
                                <Grid BackgroundColor="#E4E4E4">
                                    <Grid.ColumnDefinitions>
                                        <ColumnDefinition Width="*" />
                                    </Grid.ColumnDefinitions>
                                    <Label Text="{Binding Key}" />
                                    <Label Text="{Binding Items,Converter={StaticResource Converter}}" Grid.Column="1" />
                                </Grid>
                            </ViewCell.View>
                        </ViewCell>
                    </DataTemplate>
      </syncfusion:SfListView.GroupHeaderTemplate>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}

{% highlight c# %}
listView.GroupHeaderTemplate = new DataTemplate(() =>
{
   var grid = new Grid();

   var label1 = new Label();
   label1.SetBinding(Label.TextProperty, new Binding("Key"));

   var label2 = new Label();
   Binding binding = new Binding("Items");
   binding.Converter = new Converter();
   label2.SetBinding(Label.TextProperty,binding);

   grid.Children.Add(label1);
   grid.Children.Add(label2, 1, 0);

   return grid;
 });
 {% endhighlight %}

{% highlight c# %}
 public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
 {
    int result = 0;
    var items = value as IEnumerable;
    if(items != null)
    {
    var items = items.ToList<object>().ToList<object>();
        if (items != null)
        {
        for (int i = 0; i < items.Count; i++)
            {
            var contact = items[i] as Contacts;
            result += contact.ContactNumber;
            }
        }
    }
    return result
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows grouping by sum of property value. 

### Displaying items count

The total number of items in each group will be displayed in the group header by binding the `Count` property in the `SfListView.GroupHeaderTemplate`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
 <syncfusion:SfListView>
  <syncfusion:SfListView.GroupHeaderTemplate>
    <DataTemplate>
     <Grid BackgroundColor="#E4E4E4">
      <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*"/>
        <ColumnDefinition Width="*"/>
      </Grid.ColumnDefinitions>
      <StackLayout Orientation="Horizontal" HorizontalOptions="Start"
                   VerticalOptions="Center" >
        <Label Text="{Binding Key}" TextColor="Black" />
        <Label Text="Year" TextColor="Black" />
      </StackLayout>
      <StackLayout Orientation="Horizontal" Grid.Column="1"
                   HorizontalOptions="EndAndExpand" VerticalOptions="Center">
        <Label Text="{Binding Count}" TextColor="Black" />
        <Label Text="Item(s)" TextColor="Black" />
      </StackLayout>
     </Grid>
    </DataTemplate>
  </syncfusion:SfListView.GroupHeaderTemplate>
 </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.GroupHeaderTemplate = new DataTemplate(() => 
{
  var grid = new Grid();

  var stack1 = new StackLayout()
  {
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Start,
    Orientation = StackOrientation.Horizontal
  };
  var yearLabel = new Label
  {
    TextColor = Color.Black,
  };
  var yearlabel2 = new Label() { Text="Year", TextColor=Color.Black};
  yearLabel.SetBinding(Label.TextProperty, new Binding("key"));

  var stack2 = new StackLayout()
  {
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.EndAndExpand,
    Orientation = StackOrientation.Horizontal
  };
  var countLabel = new Label
  {
    TextColor = Color.Black,
  };
  countLabel.SetBinding(Label.TextProperty, new Binding("Count"));
  var countlabel2 = new Label() { Text="Item's" , TextColor=Color.Black};

  grid.Children.Add(stack1);
  grid.Children.Add(stack2, 1, 0);
  return grid;
});
{% endhighlight %}
{% endtabs %}
 
The following screenshot shows the output when displaying items count at group header. 

## Multi-level grouping

The SfListView supports multiple level grouping by adding multiple `GroupDescriptor` objects into the `DataSource.GroupDescriptors` collection. The grouped items will be displayed in hierarchical structure by customizing the `SfListView.GroupHeaderTemplate` property. In the `GroupHeaderTemplate`, set the `Padding` property to the custom view to arrange the group header items and sub-group header items in the hierarchical structure. 

N> Multi-level grouping is only applicable for `LinearLayout` in the SfListView.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
  <ContentPage.Resources>
    <ResourceDictionary>
      <local:GroupHeaderConverter x:Key="TemplateConverter"/>
    </ResourceDictionary>
  </ContentPage.Resources>
  <syncfusion:SfListView ItemsSource="{Binding EmployeeInfo}" ItemSize="60">
    <syncfusion:SfListView.DataSource>
      <data:DataSource>
        <data:DataSource.GroupDescriptors>
            <data:GroupDescriptor PropertyName="Designation" />
            <data:GroupDescriptor PropertyName="Level" />
        </data:DataSource.GroupDescriptors>
      </data:DataSource>
    </syncfusion:SfListView.DataSource>
    <syncfusion:SfListView.GroupHeaderTemplate>
      <DataTemplate>
          <ViewCell>
            <ViewCell.View>
              <StackLayout BackgroundColor="{Binding Level,Converter={StaticResource TemplateConverter}}"
                            Padding="{Binding Level,Converter={StaticResource TemplateConverter}}">
                  <Label Text="{Binding Key}" 
                        VerticalOptions="Center" HorizontalOptions="Start"/>
              </StackLayout>
            </ViewCell.View>
          </ViewCell>
      </DataTemplate>
    </syncfusion:SfListView.GroupHeaderTemplate>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}

{% highlight c# %}

listView.ItemsSource = viewModel.EmployeeInfo;
listView.ItemSize = 60;
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
  PropertyName = "Designation",
});
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
  PropertyName = "Designation",
});
listView.GroupHeaderTemplate = new DataTemplate(() =>
{
  var stack = new StackLayout();
  Binding binding = new Binding("Level");
  binding.Converter = new TemplateConverter();
  stack.SetBinding(StackLayout.BackgroundColorProperty, binding);
  stack.SetBinding(StackLayout.PaddingProperty, binding);

  var label = new Label() { VerticalOptions=LayoutOptions.Center,HorizontalOptions=LayoutOptions.Start};
  label.SetBinding(Label.TextProperty, new Binding("Key"));

  return stack;
});
{% endhighlight %}

{% highlight c# %}
public class GroupHeaderConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
     if (targetType.Name == "Color")
     {
        if ((int)value == 1)
           return Color.FromHex("#D3D3D3");
        else
           return Color.Transparent;
     }
     else
     {
        if ((int)value == 1)
           return new Thickness(5, 5, 5, 0);
        else
           return new Thickness((int)value * 15, 5, 5, 0);
     }
  }

   public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
   {
     throw new NotImplementedException();
   }
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output for multi-level grouping. 

## Group expand and collapse

By default, the groups will be in expanded state in the SfListView. You can expand or collapse the group at runtime by setting the `SfListView.AllowGroupExpandCollapse` to `true`. So, when tapping the group header, the group gets collapse if the group is in expand state and vice-versa. 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemSize="70" AllowGroupExpandCollapse="True" 
                     ItemsSource="{Binding contactsInfo}" />          
{% endhighlight %}
{% highlight c# %}
listView.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when the groups are collapsed.

### Programmatic expand and collapse

#### Expand or collapse all the groups

Expand or collapse all the groups programmatically at runtime by using the `SfListView.ExpandAll` method and `SfListView.CollapseAll` method.

{% tabs %}
{% highlight c# %}
listView.ExpandAll();
listView.CollapseAll();
{% endhighlight %}	
{% endtabs %}

#### Expand or collapse a specific group

Expand or collapse a specific group by using the `SfListView.ExpandGroup` method and `SfListView.CollapseGroup` method.

{% tabs %}
{% highlight c# %}
var group = listView.DataSource.Groups[0];
listView.ExpandGroup(group);
listView.CollapseGroup(group);
{% endhighlight %}
{% endtabs %}

#### Expand or collapse all groups by default

Expand or collapse all the groups by default using the `SfListView.Loaded` event.

{% tabs %}
{% highlight c# %}
listView.Loaded += ListView_Loaded;
  
private void ListView_Loaded(object sender, ListViewLoadedEventArgs e)
{
    listView.CollapseAll();
    listView.ExpandAll();
}
{% endhighlight %}
{% endtabs %}

### Keeping only one group in expanded state

To keep any one specific group alone in the expanded state, use the `SfListView.GroupExpanding` event. The particular selected group can be get from `GroupExpandCollapseChangingEventArgs`, by which you can compare and collapse all other groups, and expand the particular selected group. 

{% tabs %}
{% highlight c# %}
private void ListView_GroupExpanding(object sender, GroupExpandCollapseChangingEventArgs e) 
{ 
  if (e.Groups.Count > 0) 
  { 
    var group = e.Groups[0]; 
    if (expandedGroup == null || group.Key != expandedGroup.Key) 
    { 
      foreach (var otherGroup in listView.DataSource.Groups) 
      { 
        if (group.Key != otherGroup.Key) 
        { 
          listView.CollapseGroup(otherGroup); 
        } 
      } 
      expandedGroup = group; 
      listView.ExpandGroup(expandedGroup); 
    } 
 } 
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when one group in expanded state.

### Expand groups while grouping

You can expand all the groups while grouping by setting the `DataSource.AutoExpandGroups` to `true`. So, when grouping any item, all the groups will be automatically expanded.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView"> 
    <syncfusion:SfListView.DataSource> 
        <data:DataSource AutoExpandGroups="true"> 
            <data:DataSource.GroupDescriptors> 
                <data:GroupDescriptor PropertyName="BookName"/> 
            </data:DataSource.GroupDescriptors> 
        </data:DataSource> 
    </syncfusion:SfListView.DataSource> 
</syncfusion:SfListView> 
{% endhighlight %}
{% highlight c# %}
listView.DataSource.AutoExpandGroups = true;
{% endhighlight %}
{% endtabs %}
 
### Events

### GroupExpanding Event

The `SfListView.GroupExpanding` event occurs when the group is being expanded.
 
The `GroupExpandCollapseChangingEventArgs` of the `GroupExpanding` event provides the information about the expanding group and it has the following members:

`Groups`: Gets a list of groups being expanded.
`Cancel`: Decides whether to cancel the group expansion or not.

The `GroupExpanding` event used for the following use case.

* Keeps any one specific group in the expanded state by comparing and collapsing all other groups.

You can cancel the group expansion by setting `GroupExpandCollapseChangingEventArgs.Cancel` to `true`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemsSource="{Binding contactsInfo}" 
                       GroupExpanding="ListView_GroupExpanding" />
{% endhighlight %}
{% highlight c# %}
listView.GroupExpanding += ListView_GroupExpanding;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void ListView_GroupExpanding(object sender, GroupExpandCollapseChangingEventArgs e)
{
  if (e.Groups[0] == listView.DataSource.Groups[0])
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### GroupExpanded Event

The `SfListView.GroupExpanded` event occurs after expanding the group.

The `GroupExpandCollapseChangedEventArgs` of the `GroupExpanded` event provides the information about the expanded group and it has the following member:

`Groups`: Gets a list of expanded groups.

### GroupCollapsing Event 

The `SfListView.GroupCollapsing` event occurs when the group is being collapsed.

The `GroupExpandCollapseChangingEventArgs` of the `GroupCollapsing` event provides the information about the collapsing group and it contains the following members:

`Groups`: Gets a list of groups being collapsed.
`Cancel`: Decides whether to cancel the group collapsing or not.

You can cancel the group is being collapsed by setting the `GroupExpandCollapseChangingEventArgs.Cancel` to `true`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemsSource="{Binding contactsInfo}" 
                       GroupCollapsing="ListView_GroupCollapsing" />
{% endhighlight %}
{% highlight c# %}
listView.GroupCollapsing += ListView_GroupCollapsing;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void ListView_GroupCollapsing(object sender, GroupExpandCollapseChangingEventArgs e)
{
  if (e.Groups[0] == listView.DataSource.Groups[0])
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### GroupCollapsed Event
 
The `SfListView.GroupCollapsed` event occurs after the group is collapsed.
 
The `GroupExpandCollapseChangedEventArgs` of the `GroupCollapsed` event provides the information about collapsed group and it contains the following member.

`Groups`: Gets a list of collapsed groups.

## Stick group header

To stick the group header to view, enable the property `SfListView.IsStickyGroupHeader`. If `IsStickyGroupHeader` is `true`, the corresponding group header will be in view until the last item of the group goes out of view, and sticky group header will move when another group header leads while scrolling.

I> If sticky group header is enabled and `AutoFitMode` is `Height`, the panning experience will not be smooth or item's layout will not work as expected. To make the panning experience smooth, set the same size for all group header items by handling the `QueryItemSize` event.

N> When the `IsStickyGroupHeader` is set to `true`, the `IsStickyHeader` property will be changed to `true` because the header item can not be scrolled. When the `IsStickyHeader` is set to `false`, if `IsStickyGroupHeader` is `true` then it will be changed to `false` because the group header item cannot be sticky.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemSize="70" IsStickyGroupHeader="True" 
                       ItemsSource="{Binding contactsInfo}" />          
{% endhighlight %}
{% highlight c# %}  
listView.IsStickyGroupHeader = true;
{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the output when the group headers are sticky.

## Group header customization

### Appearance customization

The User Interface (UI) for the group header items can be customized by using the `SfListView.GroupHeaderTemplate` property.

To customize the view for group header items and binding the `Key` to it, follow the code example.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
 <syncfusion:SfListView x:Name="listView">
  <syncfusion:SfListView.GroupHeaderTemplate>
    <DataTemplate>
      <ViewCell>
        <ViewCell.View>
          <StackLayout BackgroundColor="#E4E4E4">
            <Label Text="{Binding Key}"
                   FontSize="22"
                   FontAttributes="Bold"
                   VerticalOptions="Center"
                   HorizontalOptions="Start"
                   Margin="20,0,0,0" />
          </StackLayout>
        </ViewCell.View>
      </ViewCell>
    </DataTemplate>
  </syncfusion:SfListView.GroupHeaderTemplate>
 </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.GroupHeaderTemplate = new DataTemplate(() =>
{
  var grid = new Grid { BackgroundColor = Color.FromHex("#E4E4E4") };
  var label = new Label
  {
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Start,
    Margin = new Thickness(20, 0, 0, 0),
  };
  label.SetBinding(Label.TextProperty, new Binding("Key"));
  grid.Children.Add(label);
  return grid;
});
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when the groups header appearance customized by key.

### Expand and collapse icon in group header

Expand and collapse the group when tapping icon in the group header item by customizing the `SfListView.GroupHeaderTemplate` with the help of converter.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:BoolToImageConverter x:Key="BoolToImageConverter"/>
            <DataTemplate x:Name="GroupHeaderTemplate"  x:Key="GroupHeaderTemplate">
                <ViewCell>
                    <ViewCell.View>
                        <Grid>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="30" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            <Image x:Name="NormalImage" Grid.Column="0" HorizontalOptions="Center"
                                   Source="{Binding IsExpand, Converter={StaticResource BoolToImageConverter}}"
                                   VerticalOptions="Center"/>
                            <Label Text="{Binding Key}" Grid.Column="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <Grid>
            <syncfusion:SfListView x:Name="listView" ItemSize="70"
                                 GroupHeaderSize="60"
                                 GroupHeaderTemplate="{StaticResource GroupHeaderTemplate}"
                                 ItemsSource="{Binding contactsInfo}"
                                 AllowGroupExpandCollapse="True">
            </syncfusion:SfListView>
        </Grid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView = new SfListView();
viewModel = new ContactsViewModel();
listView.ItemsSource = viewModel.contactsInfo;
listView.GroupHeaderTemplate = new DataTemplate(() => 
{
    var grid = new Grid { BackgroundColor = Color.FromHex("#E4E4E4") };
    var column0 = new ColumnDefinition { Width = 30 };
    var column1 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
    grid.ColumnDefinitions.Add(column0);
    grid.ColumnDefinitions.Add(column1);
  
    var image = new Image();
    Binding binding = new Binding("IsExpand");
    binding.Converter = new BoolToImageConverter();
    image.SetBinding(Image.SourceProperty, binding);
    image.HeightRequest = 30;
    image.WidthRequest = 30;
    image.VerticalOptions = LayoutOptions.Center;
    image.HorizontalOptions = LayoutOptions.Center;
  
    var label = new Label
    {
        FontAttributes = FontAttributes.Bold,
        FontSize = 22,
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Start,
        Margin = new Thickness(20, 0, 0, 0),
    };
  
    label.SetBinding(Label.TextProperty, new Binding("Key"));
  
    grid.Children.Add(image, 0, 0);
    grid.Children.Add(label, 1, 0);
    return grid;
});
{% endhighlight %}
{% endtabs %}

You can switch the expand or collapse group icon based on `IsExpand` property using the converter.

{% tabs %}
{% highlight c# %}
public class BoolToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value) 
            return ImageSource.FromResource("ListViewSample.Images. GroupExpand.png");
        else
            return ImageSource.FromResource("ListViewSample.Images. GroupCollapse.png");
    }
  
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when grouping with expand collapse icon in group header. 

### Height customization

The size of the group header items can be customized by setting the `SfListView.GroupHeaderSize` property. The default value of this property is `40`. This property responds to runtime changes.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" GroupHeaderSize="60" />
{% endhighlight %}
{% highlight c# %}
listView.GroupHeaderSize = 60;
{% endhighlight %}
{% endtabs %}

N> For Vertical orientation, the group header size is considered as height and for Horizontal orientation, it will be considered as width.

### CheckBox in group header

ListView supports selecting each group and items in the group like a checkBox selection by customizing the `SfListView.GroupHeaderTemplate` and the `ItemTemplate` respectively. The checkbox state will be update by using converter.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView>
    <syncfusion:SfListView.GroupHeaderTemplate>
        <DataTemplate>
            <ViewCell>
              <ViewCell.View>
                <Grid BackgroundColor="#d3d3d3">
                   <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="30" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="Auto" />
                   </Grid.ColumnDefinitions>
                   <Label Text="{Binding Key}" Grid.Column="1" VerticalTextAlignment="Center"/>
                   <Image Grid.Column="2" IsVisible="{Binding SelectionMode, Source={x:Reference listView}}" 
                           HorizontalOptions="Center" VerticalOptions="Center"
                           Source="{Binding ., Converter={StaticResource GroupingSelectionConverter}, ConverterParameter={x:Reference listView}}">
                        <Image.GestureRecognizers>
                            <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped"/>
                        </Image.GestureRecognizers>
                   </Image>
                </Grid>
              </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </syncfusion:SfListView.GroupHeaderTemplate>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.GroupHeaderTemplate = new DataTemplate(() => 
{
  var grid = new Grid();

  var label = new Label() { VerticalTextAlignment=TextAlignment.Center};
  label.SetBinding(Label.TextProperty, new Binding("Key"));

  var image = new Image() { VerticalOptions=LayoutOptions.Center, HorizontalOptions=LayoutOptions.Center};
  Binding binding = new Binding(".");
  binding.Converter = new GroupingSelectionConverter();
  binding.ConverterParameter = listView;
  image.SetBinding(Image.SourceProperty, binding);

  Binding bind = new Binding("SelectionMode");
  bind.Source = listView;
  image.SetBinding(Image.IsVisibleProperty, bind);

  var tapped = new TapGestureRecognizer();
  tapped.Tapped += Image_Tapped;
  image.GestureRecognizers.Add(tapped);
               
  grid.Children.Add(label);
  grid.Children.Add(image, 2, 0);
                
  return grid;
});
{% endhighlight %} 
{% endtabs %}

The checkBox state in the `GroupHeaderTemplate` will be updated whenever items select and deselect by using converter.

{% tabs %}
{% highlight c# %}
public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
{
    if (value == null)
        return value;

    GroupResult groupResult = value as GroupResult;
    SfListView list = parameter as SfListView;

    var items = new List<MusicInfo>(groupResult.Items.ToList<MusicInfo>());

    if ((items.All(item => item.IsSelected == false)))
    {
        for (int i = 0; i < items.Count(); i++)
        {
            var item = items[i];
            (item as MusicInfo).IsSelected = false;
            list.SelectedItems.Remove(item);
        }
        return ImageSource.FromResource("CustomSelection.Images.NotSelected.png");
    }

    else if ((items.All(item => item.IsSelected == true)))
    {
        for (int i = 0; i < items.Count(); i++)
        {
            var item = items[i];
            (item as MusicInfo).IsSelected = true;
            list.SelectedItems.Add(item);
        }
        return ImageSource.FromResource("CustomSelection.Images.Selected.png");
    }

    else
        return ImageSource.FromResource("CustomSelection.Images.Intermediate.png");
}
{% endhighlight %}
{% endtabs %}

To select and deselect all the items of group by tap the checkbox in the group header, follow the code example.

{% tabs %}
{% highlight c# %}
private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
{
    var image = (sender as Image);
    var groupResult = image.BindingContext as GroupResult;

    if (groupResult == null)
        return;
    var items = groupResult.Items.ToList<MusicInfo>().ToList();

    if ((items.All(listItem => listItem.IsSelected == true)))
    {
        for (int i = 0; i < items.Count(); i++)
           {
                var item = items[i];
                (item as MusicInfo).IsSelected = false;
            }
    }
    else if ((items.All(listItem => listItem.IsSelected == false)))
    {
        for (int i = 0; i < items.Count(); i++)
            {
                var item = items[i];
                (item as MusicInfo).IsSelected = true;
            }
    }
    this.RefreshGroupHeader(groupResult);
    listView.RefreshView();
}

private void RefreshGroupHeader(GroupResult group)
{
    foreach (var item in this.listView.GetVisualContainer().Children)
    {
      if (item.BindingContext == group)
       {
         item.BindingContext = null;
         (item as GroupHeaderItem).Content.BindingContext = null;
        }
    }
}        
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when checking items in group header. 

### Changing group header appearance when expanding

Change the `SfListView.GroupHeaderTemplate` appearance like `BackgroundColor` of view while expanding the particular group with the help of Converter.   

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
 <ContentPage.Resources> 
  <ResourceDictionary> 
    <local:SelectionBoolToBackgroundColorConverter x:Key="BoolToColorConverter"/> 
  </ResourceDictionary> 
 </ContentPage.Resources> 
 <syncfusion:SfListView x:Name="listView" ItemSize="90" AllowGroupExpandCollapse="True" 
                     ItemSpacing="2" ItemsSource="{Binding Items}"> 
   <syncfusion:SfListView.DataSource> 
    <data:DataSource> 
      <data:DataSource.GroupDescriptors> 
         <data:GroupDescriptor PropertyName="DisplayString"/> 
      </data:DataSource.GroupDescriptors> 
    </data:DataSource> 
   </syncfusion:SfListView.DataSource> 
   <syncfusion:SfListView.GroupHeaderTemplate> 
    <DataTemplate> 
      <StackLayout BackgroundColor="{Binding Path=IsExpand,   
                                    Converter={StaticResource BoolToColorConverter}}"> 
         <Label Text="{Binding Key}"  
                VerticalOptions="Center" HorizontalOptions="Start" /> 
      </StackLayout> 
    </DataTemplate> 
   </syncfusion:SfListView.GroupHeaderTemplate> 
 </syncfusion:SfListView> 
</ContentPage>
{% endhighlight %}
{% highlight c# %}

listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
 {
   PropertyName = "BookName",
 });
listView.GroupHeaderTemplate = new DataTemplate(() =>
 {
   var grid = new Grid();
   var stack = new StackLayout();
   Binding binding = new Binding("IsExpand");
   binding.Converter = new BoolToColorConverter();
   stack.SetBinding(StackLayout.BackgroundColorProperty, binding);

   var label = new Label() { VerticalOptions=LayoutOptions.Center,HorizontalOptions=LayoutOptions.Start};
   label.SetBinding(Label.TextProperty, new Binding("Key"));

   stack.Children.Add(label);
   grid.Children.Add(stack);
   return grid;
 });
{% endhighlight %}

{% highlight c# %}
 public class SelectionBoolToBackgroundColorConverter : IValueConverter 
 { 
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
    { 
      return (bool)value == true ? Color.FromHex("#E4E4E4") : Color.FromHex("#ADD8E6"); 
    } 
 
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
    { 
      throw new NotImplementedException(); 
    } 
 } 
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when group header appearance changed by expanding. 

N> The binding context for `GroupHeaderTemplate` is `GroupResult`. 

### Providing Indentation for GroupHeader items

ListView allows you to provide space between the group header items by using the `Margin` property of parent view in the `GroupHeaderTemplate` property. For example, in the following code snippet, StackLayout is considered as parent view and spacing is provided by setting its margin.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemSize="90" AllowGroupExpandCollapse="True" 
                     ItemSpacing="2" ItemsSource="{Binding Items}">
<syncfusion:SfListView.GroupHeaderTemplate> 
  <DataTemplate> 
    <StackLayout BackgroundColor="#E4E4E4" Margin="2,0,0,0"> 
      <Label Text="{Binding Key}" FontSize="22" /> 
    </StackLayout> 
  </DataTemplate> 
</syncfusion:SfListView.GroupHeaderTemplate> 
</syncfusion:SfListView> 
{% endhighlight %}
{% endtabs %}


## How To 

### Allow to select only one item in a group at a time

To select only one item in a group at a time, use the `ItemSelectionChangingEventArgs` event. If more than one item in the same group gets selected, already selected item will be removed from `ListView.SelectedItems`. 

{% tabs %}
{% highlight c# %}
private void ListView_SelectionChanging(object sender, ItemSelectionChangingEventArgs e) 
{ 
  GroupResult actualGroup = null; 
  object key = null; 
  var selectedItems = listView.SelectedItems; 
  
  //To Cancel the Deselection 
  if (e.RemovedItems.Count > 0 && selectedItems.Contains(e.RemovedItems[0])) 
  { 
    e.Cancel = true; 
    return; 
  } 
  
 //To return when SelectedItems is zero 
  if (e.AddedItems.Count <= 0) 
     return; 
  
  var itemData = (e.AddedItems[0] as Contacts); 
  
  var descriptor = listView.DataSource.GroupDescriptors[0]; 
  if (descriptor.KeySelector == null) 
  { 
    var Collection = new PropertyInfoCollection(itemData.GetType()); 
    key = Collection.GetValue(itemData, descriptor.PropertyName); 
  } 
  else 
    key = descriptor.KeySelector(itemData); 
  
  for (int i = 0; i < listView.DataSource.Groups.Count; i++) 
  { 
   var group = listView.DataSource.Groups[i]; 
  
   if ((group.Key != null && group.Key.Equals(key)) || group.Key == key) 
   { 
     actualGroup = group; 
     break; 
   } 
} 
  
if (selectedItems.Count > 0) 
{ 
   foreach (var item in actualGroup.Items) 
    { 
      var groupItem = item; 
  
      if (selectedItems.Contains(groupItem)) 
      { 
        listView.SelectedItems.Remove(groupItem); 
        break; 
      } 
    } 
  } 
} 
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when only one item in a group gets selected. 

### Add an item at the specific index in a group

The SfListView allows adding an item at the specific index in a group by finding the group with the help of `Key` value of the group.

{% tabs %}
{% highlight c# %}

internal void GetGroupResult(object ItemData)
{
    var descriptor = listView.DataSource.GroupDescriptors[0];
    object key;
  
    if (descriptor.KeySelector == null)
    {
      var propertyInfoCollection = new PropertyInfoCollection(ItemData.GetType());
      key = propertyInfoCollection.GetValue(ItemData, descriptor.PropertyName);
    }
    else
      key = descriptor.KeySelector(ItemData);
    for (int i = 0; i < this.listView.DataSource.Groups.Count; i++)
    {
      var group = this.listView.DataSource.Groups[i];
      if ((group.Key != null && group.Key.Equals(key)) || group.Key == key)
         {
           itemGroup = group;
           break;
         }
       group = null;
     }
     itemGroup = this.listView.DataSource.Groups.FirstOrDefault(x => x.Key == key);         
     descriptor = null;
     key = null;
}

{% endhighlight %}
{% endtabs %}

To add item at  specific index in a group, follow the code example

{% tabs %}
{% highlight c# %}
using Syncfusion.ListView.XForms.Control.Helpers;
private void AddItem_Clicked(object sender, EventArgs e)
{
  var contact = new Contacts();
  contact.ContactName = "Adam";
  contact.ContactNumber = "783-457-567";
  contact.DisplayString = "A";
  contact.ContactImage = ImageSource.FromResource("Grouping.Images.Image" + 25 + ".png");
  ViewModel.ContactItems.Add(contact);

  GetGroupResult(contact);

  if (itemGroup == null)
      return;

   var items = itemGroup.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "ItemList").GetValue(itemGroup) as List<object>;
   InsertItemInGroup(items, contact, 0);
}

internal void InsertItemInGroup(List<object> items, object Item, int InsertAt)  
{
   visualContainer = listView.GetVisualContainer();
   items.Remove(Item);
   items.Insert(InsertAt, Item);
   visualContainer.ForceLayout();
}

{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when item added at specified index. 