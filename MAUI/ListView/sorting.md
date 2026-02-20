---
layout: post
title: Sorting in .NET MAUI ListView control | Syncfusion
description: Learn here all about Sorting support in Syncfusion .NET MAUI ListView (SfListView) control, its elements and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Sorting in .NET MAUI ListView (SfListView)

The `SfListView` supports sorting the data either in ascending or descending order by using the [DataSource.SortDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_SortDescriptors) property and custom logic.

To get start quickly with sorting in .NET MAUI ListView, you can check on this video:
<style>#MAUIListViewSortingVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIListViewSortingVideoTutorial' src='https://www.youtube.com/embed/IedulwH4h4c'></iframe>

N> When the `ItemsSource` is changed for a ListView, `DataSource.SortDescriptors` will be cleared by default. You need to add `DataSource.SortDescriptors` again after changing the `ItemsSource`, if you want to retain sorting in the listview.

N> To sort the newly added listview items at runtime, set the [SfListView.DataSource.LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.LiveDataUpdateMode.html) to [LiveDataUpdateMode.AllowDataShaping](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.LiveDataUpdateMode.html#Syncfusion_DataSource_LiveDataUpdateMode_AllowDataShaping). 

## Programmatic sorting

Sorting the data by creating a [SortDescriptor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html) with the required property name and direction and adding it into the [DataSource.SortDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_SortDescriptors) property.

`SortDescriptor` object holds the following three properties:

* [PropertyName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html#Syncfusion_DataSource_SortDescriptor_PropertyName): Describes the name of the sorted property.
* [Direction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html#Syncfusion_DataSource_SortDescriptor_Direction): Describes an object of type [ListSortDirection](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.ListSortDirection.html) that defines the sorting direction.
* [Comparer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html#Syncfusion_DataSource_SortDescriptor_Comparer): Describes the comparer to be applied when sorting takes place.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6 7 8" %}
<ContentPage  xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
               xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource" >
  <syncfusion:SfListView x:Name="listView">
            <syncfusion:SfListView.DataSource>
                <data:DataSource>
                    <data:DataSource.SortDescriptors>
                        <data:SortDescriptor PropertyName="ContactName" Direction="Ascending"/>
                    </data:DataSource.SortDescriptors>
                </data:DataSource>
            </syncfusion:SfListView.DataSource>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3 4" %}
listView.DataSource.SortDescriptors.Add(new SortDescriptor()
{
  PropertyName = "ContactName",
  Direction = ListSortDirection.Ascending,
}); 
listView.RefreshView();
{% endhighlight %}
{% endtabs %}

N> It is mandatory to specify the `PropertyName` of `SortDescriptor`.

## Custom sorting

Sort the items based on the custom logic and it can be applied to either [SfListView.DataSource.SortComparer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_SortComparer) property or [SortDescriptor.Comparer](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.SortDescriptor.html#Syncfusion_DataSource_SortDescriptor_Comparer), which is added into the [DataSource.SortDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_SortDescriptors) collection.

N> If the `PropertyName` in the [SortDescriptor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html) and `GroupDescriptor` are same, then the [GroupResult](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.Extensions.GroupResult.html) will be passed as parameters for the `SortDescriptor.Comparer`. Otherwise, data objects are passed. To sort the data items alone, set the different `PropertyName` in both the `SortDescriptor` and the `GroupDescriptor` properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 11 12 13" %}
<ContentPage  xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
               xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
  <ContentPage.Resources>
    <ResourceDictionary>
      <local:CustomSortComparer x:Key="CustomSortComparer" />
    </ResourceDictionary>
  </ContentPage.Resources>
  <syncfusion:SfListView x:Name="listView">
    <syncfusion:SfListView.DataSource>
      <data:DataSource>
        <data:DataSource.SortDescriptors>
          <data:SortDescriptor Comparer="{StaticResource CustomSortComparer}"/>
        </data:DataSource.SortDescriptors>
      </data:DataSource>
    </syncfusion:SfListView.DataSource>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
listView.DataSource.SortDescriptors.Add(new SortDescriptor()
{
  Comparer = new CustomSortComparer()
});
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="CustomSortComaparer.cs" %}
public class CustomSortComparer : IComparer<object>
{
  public int Compare(object x, object y)
  {
     if (x.GetType() == typeof(ListViewContactsInfo))
     {
        var xitem = (x as ListViewContactsInfo).ContactName;
        var yitem = (y as ListViewContactsInfo).ContactName;

        if (xitem.Length > yitem.Length)
        {
           return 1;
        }
        else if (xitem.Length < yitem.Length)
        {
           return -1;
        }
        else
        {
           if (string.Compare(xitem, yitem) == -1)
               return -1;
           else if (string.Compare(xitem, yitem) == 1)
               return 1;
        }
     }

     return 0;
   }
}
{% endhighlight %}
{% endtabs %}

You can download the entire sample code from the [github](https://github.com/SyncfusionExamples/custom-sorting-.net-maui-listview).

![.NET MAUI ListView custom sorting](Images/sorting/net-maui-listview-custom-sorting.jpg)

## Sort the items on header tapped

To apply the sorting when tapping the header, handle the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event of the `SfListView`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
               xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
  <syncfusion:SfListView x:Name="listView" ItemSize="60"
                        ItemsSource="{Binding customerDetails}" 
                        ItemTapped="ListView_ItemTapped" 
                        IsStickyHeader="True">
    <syncfusion:SfListView.HeaderTemplate>
      <DataTemplate>
            <StackLayout BackgroundColor="Teal">
              <Label TextColor="White" FontSize="20" FontAttributes="Bold" Text="CustomerDetails" />
            </StackLayout>
      </DataTemplate>
    </syncfusion:SfListView.HeaderTemplate>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
listView = new SfListView();
listView.ItemsSource = viewModel.customerDetails;
listView.ItemSize = 60;
listView.ItemTapped += ListView_ItemTapped;
listView.IsStickyHeader = true;
listView.HeaderTemplate = new DataTemplate(() => 
{
  var stackLayout = new StackLayout { BackgroundColor = Colors.Teal };
  var label = new Label { Text = "CustomerDetails", TextColor = Colors.White, 
                          FontAttributes = FontAttributes.Bold, FontSize = 20 };
  stackLayout.Children.Add(label);
  return stackLayout;
});
{% endhighlight %}
{% endtabs %}

When the `ItemTapped` event is raised for the Header, add the [SortDescriptor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html) and refresh the view.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7 8 9 10 11" %}
private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
{
  //Applying sorting to the underlying data when the header item is tapped.
  if (e.ItemType == ItemType.Header && listView.IsStickyHeader)
  {
    listView.DataSource.SortDescriptors.Clear();
    listView.DataSource.SortDescriptors.Add(new SortDescriptor()
    {
      PropertyName = "ContactName",
      Direction = ListSortDirection.Ascending
    });
  }
}
{% endhighlight %}
{% endtabs %}

## Sort the items along with grouping
 
The `SfListView` allows sorting and grouping the items by adding the [DataSource.GroupDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_GroupDescriptors) and the [DataSource.SortDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_SortDescriptors) with required property name.

## Sorting with grouping by year

Sorting and grouping the items by using [KeySelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.GroupDescriptor.html#Syncfusion_DataSource_GroupDescriptor_KeySelector) based on retuning the year value of the date-time property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="8" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
               xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
  <ContentPage.Content>
    <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding Items}" ItemSize="50">
      <syncfusion:SfListView.GroupHeaderTemplate>
        <DataTemplate>
          <Grid>
              <Label Text= "{Binding Key}" BackgroundColor="Teal" FontAttributes="Bold" TextColor="White"/>
		      </Grid>
        </DataTemplate>
      </syncfusion:SfListView.GroupHeaderTemplate>
    </syncfusion:SfListView>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="20 21 22 23" %}
var listView = new SfListView();
listView.ItemSize = 50;
listView.ItemsSource = viewModel.Items;
listView.GroupHeaderTemplate = new DataTemplate(() => 
{
   var grid = new Grid();
   var headerLabel = new Label
   {
   TextColor = Colors.White,
   FontAttributes = FontAttributes.Bold,
   BackgroundColor=Colors.Teal
   };
   headerLabel.SetBinding(Label.TextProperty, new Binding("key"));
   grid.Children.Add(headerLabel);
   return grid;
});
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
  PropertyName = "DateOfBirth",
  KeySelector = (object obj1) =>
  {
   var item = (obj1 as Contacts);
   return item.DateOfBirth.Year;
  },
});
this.listView.DataSource.SortDescriptors.Add(new SortDescriptor()
{
  PropertyName = "DateOfBirth",
  Direction = ListSortDirection.Ascending
});
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when items are sorted by year. Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/sorting-and-grouping-.net-maui-listview)

![.NET MAUI ListView sorting with grouping by year](Images/sorting/net-maui-listview-with-grouping-by-year.jpg)

## Sorting with grouping by month and year

Sorting and grouping the items by using `KeySelector` based on returning the month and year value of the date-time property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7 8 9 10 11 12" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
              xmlns:data="clr-namespace:Syncfusion.Maui.DataSource;assembly=Syncfusion.Maui.DataSource">
  <ContentPage.Content>
    <syncfusion:SfListView x:Name="listView">
      <syncfusion:SfListView.DataSource>
        <data:DataSource>
        <data:DataSource.GroupDescriptors>
            <data:GroupDescriptor PropertyName="ContactName" />
          </data:DataSource.GroupDescriptors>
          <data:DataSource.SortDescriptors>
            <data:SortDescriptor PropertyName="ContactName" Direction="Ascending"/>
          </data:DataSource.SortDescriptors>
        </data:DataSource>
      </syncfusion:SfListView.DataSource>
    </syncfusion:SfListView>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10 11 12 13" %}
public partial class MainPage : ContentPage
{
   public MainPage()
   {
       InitializeComponent();
       listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
       {
           PropertyName = "DateOfBirth",
           KeySelector = (object obj1) =>
           {
               var item = (obj1 as Contacts);
               return item.DateOfBirth.Month + "/" + item.DateOfBirth.Year;
           },
           Comparer = new CustomGroupComparer()
       });
       this.listView.DataSource.SortDescriptors.Add(new SortDescriptor()
       {
           PropertyName = "DateOfBirth",
           Direction = ListSortDirection.Ascending
       });
   }
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output when items are sorted by month and year.

![.NET MAUI ListView sorting with grouping by month and year](Images/sorting/net-maui-listview-sorting-with-grouping-by-year.jpg)