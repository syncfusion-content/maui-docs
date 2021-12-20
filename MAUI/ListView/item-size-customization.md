---
layout: post
title: Item Size Customization in .NET MAUI ListView control | Syncfusion
description: Learn here all about Item Size Customization support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Item Size Customization in .NET MAUI ListView (SfListView)

This section explains how to customize the item size in the `.NET MAUI ListView` (SfListView).

## Customize item size of a particular item on-demand

The `SfListView` allows customizing the size of the item on-demand by the `SfListView.QueryItemSize` event using the item index. This event is raised whenever items come to view and triggered with `QueryItemSizeEventArgs`.

The `SfListView.QueryItemSize` event provides the following properties in their arguments:

 * `ItemIndex`: Identifies a particular item in the `SfListView`. 
 * `ItemData`: Identifies the underlying data bound to that item.
 * `ItemSize`: Identifies size of the queried item. For vertical orientation, it will be considered as the item height. For horizontal orientation, it will be considered as the item width.
 * `ItemType`: Identifies the item type of the queried item.
 * `Handled`: Decides whether the specified size can be set to the item or not. The default value is `false`. When this property is not set, the decided size will not set to the item.

{% tabs %}
{% highlight c# %}
this.listView.QueryItemSize += ListView_QueryItemSize;

private void ListView_QueryItemSize(object sender, Syncfusion.Maui.ListView.QueryItemSizeEventArgs e)
{
    if(e.ItemIndex == 1)
    {
        e.ItemSize = 300;
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## AutoFit the items based on the content

The `SfListView` allows dynamically adjusting size of items based on the content loaded in the `SfListView.ItemTemplate` by defining the `SfListView.AutoFitMode` property.

The control contains the following three types of `AutoFitMode`:

 * `Height`: AutoFit the items based on the content.
 * `DynamicHeight`: AutoFit the items based on the content if size of the content is changed at run time.
 * `None`: The `SfListView` items are layout by `SfListView.ItemSize`.

 N> If you define any size manually to the view loaded in `SfListView.ItemTemplate`, the `SfListView` will return that size as the item size for each item.

### AutoFitMode as Height

AutoFit considers height of the item when `SfListView.Orientation` is `Vertical`. When `SfListView.Orientation` is `Horizontal`, it considers width of the item. The `SfListView.GridLayout` AutoFit all the items in a row and takes the maximum item height of the row and applies to all other items in the row.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                    ItemSize="200"
                    AutoFitMode="Height"
                    ItemsSource="{Binding BookInfo}" />
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.AutoFitMode = AutoFitMode.Height; 
{% endhighlight %}
{% endtabs %}

### AutoFitMode as DynamicHeight

AutoFit considers height of the item when `SfListView.Orientation` is `Vertical`. When `SfListView.Orientation` is `Horizontal`, it considers width of the item. The `SfListView.GridLayout` autofit all the items in a row and takes the maximum item height of the row and applies to all other items in the row.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                    ItemSize="200"
                    AutoFitMode="DynamicHeight"
                    ItemsSource="{Binding BookInfo}" />
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.AutoFitMode = AutoFitMode.DynamicHeight; 
{% endhighlight %}
{% endtabs %}

## Updating the listview item size based on font at runtime

.NET MAUI ListView (SfListView) allows you to resize the item size based on the change in font size of the label element at runtime when `SfListView.AutoFitMode` is `DynamicHeight`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">       
 <Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="50"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Button Text="Modify FontSize" Clicked="Button_Clicked"/>
    <syncfusion:SfListView x:Name="listView" 
                ItemsSource="{Binding Items}"
                BackgroundColor="#FFE8E8EC"
                AutoFitMode="DynamicHeight"
                ItemSize="60">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <Grid x:Name="grid" RowSpacing="1">
                    <Label LineBreakMode="NoWrap"
                    TextColor="#474747"
                    FontSize="{Binding BindingContext.FontSize, Source={x:Reference Name=listView}}"
                    Text="{Binding ContactName}">
                    </Label>
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>                
</ContentPage>
{% endhighlight %}
{% highlight c# %}
private void Button_Clicked(object sender, EventArgs e)
{
    ViewModel.FontSize += 25;
}
{% endhighlight %}
{% endtabs %}

## Updating the Header and Footer height based on font at runtime

`SfListView` allows you to resize the `Header` and `Footer` item size based on the change in font size of the label element at runtime by calling `RefreshListViewItem` method asynchronously when `SfListView.AutoFitMode` is `Height`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">       
 <Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="50"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Button Text="Change FontSize" Command="{Binding ResizeHeaderFooterCommand}" CommandParameter="{x:Reference listView}"/>
    <syncfusion:SfListView x:Name="listView" 
                ItemsSource="{Binding Contacts}"
                BackgroundColor="#FFE8E8EC"
                AutoFitMode="Height">
                <syncfusion:SfListView.HeaderTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <Grid>
                                <Label Text="Contact Details"
                                       FontSize="{Binding BindingContext.FontSize, Source={x:Reference listView}}"/>
                            </Grid>
                        </ViewCell>
                    </DataTemplate>
                </syncfusion:SfListView.HeaderTemplate>
                <syncfusion:SfListView.FooterTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <Grid >
                                <Label Text="Contacts Count" FontSize="{Binding BindingContext.FontSize, Source={x:Reference listView}}"/>
                                <Label Text="{Binding Contacts.Count}" FontSize="{Binding BindingContext.FontSize, Source={x:Reference listView}}"/>
                            </Grid>
                        </ViewCell>
                    </DataTemplate>
                </syncfusion:SfListView.FooterTemplate>
    </syncfusion:SfListView>                
</ContentPage>
{% endhighlight %}
{% highlight c# %}
namespace SfListViewSample
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        public Command ResizeHeaderFooterCommand { get; set; }
        public ContactsViewModel()
        {
           ResizeHeaderFooterCommand = new Command(ResizeHeaderFooter);
        }
        private void ResizeHeaderFooter(object obj)
        {
            list = obj as SfListView;
            var maxFont = 40;
            var minFont = 18;
            if (FontSize >= maxFont)
            {
                FontSize = minFont;
            }
            else
            {
                FontSize += 10;
            }
            list.RefreshListViewItem(-1, -1, true);
        }
    }
}       
{% endhighlight %}
{% endtabs %}

## Load images with autofit mode

By default, the image is not loaded with the actual size in `AutoFitMode`, as it measures the size before the layout. So, the size of the child view changes cannot be found from the parent view. It is a known issue in `ListView`, but this can be overcome by calling the `RefreshListViewItem` method in the `Loaded` event of `ListView`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Content>
        <Grid>
            <syncfusion:SfListView x:Name="listView" 
                                   AutoFitMode="Height"
                                   ItemsSource="{Binding ContactsInfo}"
                                   Loaded="ListView_Loaded">
                <syncfusion:SfListView.ItemTemplate>
                    <DataTemplate>
                        <StackLayout>
                            <StackLayout>
                                <Label Text="{Binding ContactName}" />
                                <Label Text="{Binding ContactNumber}"  />
                            </StackLayout>
                            <Image Source="{Binding ContactImage}"  />
                        </StackLayout>
                    </DataTemplate>
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
        </Grid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
private void ListView_Loaded(object sender, Syncfusion.Maui.ListView.ListViewLoadedEventArgs e)
{
    Device.BeginInvokeOnMainThread(async() =>
    {
        await Task.Delay(100);
        listView.RefreshListViewItem();
    });
}
{% endhighlight %}
{% endtabs %}

## Limitations

 * Defines the size of the image when loading image in the `SfListView.ItemTemplate`. Because, it does not return actual measured size when measuring before layout the item.
 * Avoids `SfListView` inside the `SfListView` if `SfListView.AutoFitMode` is `Height` or `DynamicHeight`. Because, the inner `SfListView` does not return actual measured size when measuring before layout the item.
                                                                                                                                                                 