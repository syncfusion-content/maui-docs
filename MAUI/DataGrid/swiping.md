---
layout: post
title: Swiping in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Swiping support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui swiping, maui swiping
---

# Swiping in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) enables the swiping option by setting the [SfDataGrid.AllowSwiping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowSwiping) property to `true`. Swipe views are displayed when swiping from `left to right` or `right to left` on a data row. The control provides customizable swipe templates for both the left and right sides. Additionally, the swipe gesture can be restricted to a certain point on the row by setting the [SfDataGrid.MaxSwipeOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_MaxSwipeOffset) property.

## Swipe template

The data grid allows for loading desired content using the [SfDataGrid.LeftSwipeTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LeftSwipeTemplate) when swiping to the right. The template can be defined either in code or XAML. The content within the swipe template is arranged according to the offset values when swiping a data row.

{% tabs %}
{% highlight XAML %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DataGridMaui.MainPage"
             xmlns:local="clr-namespace:DataGridMaui"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">
    <ContentPage.BindingContext>
        <local:OrderInfoViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfDataGrid x:Name="dataGrid"
                              ItemsSource="{Binding OrdersInfo}"
                              AllowSwiping="True">
            <syncfusion:SfDataGrid.LeftSwipeTemplate>
                <DataTemplate>
                    <Grid BackgroundColor="#6750A4"
                            Padding="0" ColumnDefinitions="*, *">
                        <Label Grid.Column="0"
                                   Text="EDIT"
                                   HorizontalTextAlignment="End"
                                   TextColor="#FFFFFF"
                                   VerticalTextAlignment="Center"
                                   LineBreakMode="NoWrap"
                                   BackgroundColor="Transparent"/>
                        <Image Grid.Column="1"
                                   Source="edit.png"
                                   HeightRequest="18"
                                   WidthRequest="18"
                                   Margin="12,0,0,0"
                                   HorizontalOptions="Start"
                                   VerticalOptions="Center"/>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfDataGrid.LeftSwipeTemplate>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
 public partial class MainPage : ContentPage
 {
     SfDataGrid dataGrid;
     OrderInfoViewModel viewModel;
     public MainPage()
     {
         InitializeComponent();
         dataGrid = new SfDataGrid();
         viewModel = new OrderInfoViewModel();
         dataGrid.ItemsSource = viewModel.OrdersInfo;
         dataGrid.AllowSwiping = true;
         dataGrid.LeftSwipeTemplate = new DataTemplate(() =>
         {
             var grid = new Grid
             {
                 BackgroundColor = Color.FromArgb("#6750A4"),
                 Padding = new Thickness(0)
             };

             grid.ColumnDefinitions.Add(new ColumnDefinition());
             grid.ColumnDefinitions.Add(new ColumnDefinition());

             var editLabel = new Label
             {
                 Text = "EDIT",
                 HorizontalTextAlignment = TextAlignment.End,
                 TextColor = Colors.White,
                 VerticalTextAlignment = TextAlignment.Center,
                 LineBreakMode = LineBreakMode.NoWrap,
                 BackgroundColor = Colors.Transparent
             };
             Grid.SetColumn(editLabel, 0);

             var image = new Image
             {
                 Source="edit.png",
                 HeightRequest = 18,
                 WidthRequest = 18,
                 Margin = new Thickness(12, 0, 0, 0),
                 HorizontalOptions = LayoutOptions.Start,
                 VerticalOptions = LayoutOptions.Center
             };
             Grid.SetColumn(image, 1);
             grid.Children.Add(editLabel);
             grid.Children.Add(image);

             return grid;
         });

         Content = dataGrid;
     }
 }

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with swiping" src="Images\swiping\maui-datagrid-swipe-template.png" width="404"/>

N> Similarly, the desired content can be loaded using the [SfDataGrid.RightSwipeTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RightSwipeTemplate) when swiping to the left.

N> The `DataTemplateSelector` can be directly assigned to both the `SfDataGrid.RightSwipeTemplate` and the `SfDataGrid.LeftSwipeTemplate`. You can load the appropriate template based on the RowData and the row element provided in the event arguments.

## Swipe events

[SwipeStarting](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SwipeStarting): Raised when the swipe offset changes from its initial value. The swipe action can be canceled by setting the `Cancel` property of the [DataGridSwipeStartingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeStartingEventArgs.html) to `true`.

[SwipeEnded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SwipeEnded): The event is triggered when the swipe offset value reaches `SfDataGrid.MaxSwipeOffset`, indicating that the swipe action is complete. This event is triggered with [DataGridSwipeEndedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeEndedEventArgs.html).

`Swiping`: The event is raised while a row is being swiped. This event is triggered with [DataGridSwipingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipingEventArgs.html#properties).

The swipe events provide the following properties in their arguments:

* [RowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridSwipingEventArgs_RowIndex): Defines the index of the swiping row.
* [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridSwipingEventArgs_RowData): Defines the underlying data associated with the swiped row as its argument.
* [SwipeDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridSwipingEventArgs_SwipeDirection): Defines the swipe direction of the swiped row.
* [SwipeOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridSwipingEventArgs_SwipeOffset): Defines the current swipe offset of the row that is being swiped.

By handling the swipe events, you can use the values of these properties from the arguments to perform any desired actions, such as deleting a row or editing the data, etc. 

## Loading multiple views as swipe template

The swipe templates can be customized by loading any view into the templates and assigning custom actions to them, such as deleting a row, adding a row, or editing the underlying associated data. Multiple views can also be displayed in a template, as shown in the following example, where two views are loaded for editing the cell values in a row and deleting the row, respectively.

{% tabs %}
{% highlight xaml %}
    <ContentPage.Content>
        <syncfusion:SfDataGrid x:Name="dataGrid"
                             ItemsSource="{Binding OrdersInfo}"
                             AllowSwiping="True"
                             AutoGenerateColumnsMode="None"
                             SwipeEnded="dataGrid_SwipeEnded">           
            <syncfusion:SfDataGrid.LeftSwipeTemplate>
                <DataTemplate>
                    <Grid ColumnDefinitions="*,*">
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer NumberOfTapsRequired="1"
                          Tapped="TapGestureRecognizer_InsertButtonTapped" />
                        </Grid.GestureRecognizers>
                        <Grid BackgroundColor="#009EDA" ColumnDefinitions="4*,6*" Grid.Column="0">
                            <Image Grid.Column="0"
                                   HorizontalOptions="End"
                                   Source="insert.png" 
                                   HeightRequest="18"
                                   WidthRequest="18"
                                   Margin="0,0,8,0"/>
                            <Label Grid.Column="1"
                                   BackgroundColor="Transparent"
                                   LineBreakMode="NoWrap"
                                   Text="INSERT"
                                   TextColor="White"
                                   HorizontalTextAlignment ="Start"
                                   VerticalTextAlignment="Center" />
                        </Grid>
                        <Grid Grid.Column="1" BackgroundColor="#DC595F" ColumnDefinitions="4*,6*">
                            <Grid.GestureRecognizers>
                                <TapGestureRecognizer NumberOfTapsRequired="1"
                          Tapped="TapGestureRecognizer_DeleteButtonTapped" />
                            </Grid.GestureRecognizers>
                            <Image Grid.Column="0"
                                   BackgroundColor="Transparent"
                                   HorizontalOptions="CenterAndExpand"
                                   Source="delete.png"
                                   HeightRequest="18"
                                   WidthRequest="18"/>
                            <Label Grid.Column="1"
                                   BackgroundColor="Transparent"
                                   LineBreakMode="NoWrap"
                                   Text="DELETE"
                                   TextColor="White"
                                   HorizontalOptions="Start"
                                   HorizontalTextAlignment ="Start"
                                   VerticalTextAlignment ="Center" />
                        </Grid>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfDataGrid.LeftSwipeTemplate>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    private int swipedRowIndex;
    public MainPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_InsertButtonTapped(object sender, TappedEventArgs e)
    {
        InsertButtonPressed();
    }

    private void TapGestureRecognizer_DeleteButtonTapped(object sender, TappedEventArgs e)
    {
        DeleteButtonPressed();
    }

    internal void DeleteButtonPressed()
    {
        viewModel.OrdersInfo.RemoveAt(swipedRowIndex - 1);
    }

    internal void InsertButtonPressed()
    {
        viewModel.OrdersInfo.Insert(this.swipedRowIndex - 1, InsertItems());
    }

    private void dataGrid_SwipeEnded(object sender, Syncfusion.Maui.DataGrid.DataGridSwipeEndedEventArgs e)
    {
        this.swipedRowIndex = e.RowIndex;
    }

    internal OrderInfo InsertItems()
    {
        var ordeshipcity = "Italy";
        var order = new OrderInfo()
        {
            OrderID = 1101,
            CustomerID = "Frans",
            ShipCity = "Italy",
            ShipCountry = "France",          
        };
        return order;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with multiple views in left swipe template" src="Images\swiping\maui-datagrid-multiple-views-in-swipe-template.png" width="404"/>

N> Similarly, you can load two views using the `SfDataGrid.RightSwipeTemplate` when swiping towards left will result in the following outcome:

<img alt="DataGrid with multiple views in right swipe template" src="Images\swiping\maui-datagrid-multiple-views-in-right-swipe-template.png" width="404"/>

## Customized swipe delete functionality

Operations such as deleting a row by swiping a data row from one extent to another in the view can be performed.

{% tabs %}
{% highlight XAML %}
        <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}"
                           AllowSwiping="True"
                           MaxSwipeOffset="404"
                           SwipeEnded="dataGrid_SwipeEnded">
            <syncfusion:SfDataGrid.LeftSwipeTemplate>
                <DataTemplate>
                    <ContentView x:Name="leftTemplateView"
                                 BackgroundColor="#1AAA87">
                        <Label FontSize="15"                     
                               Text ="Deleted" 
                               TextColor ="White"
                               HorizontalTextAlignment ="Center"
                               VerticalTextAlignment ="Center"/>
                    </ContentView>
                </DataTemplate>
            </syncfusion:SfDataGrid.LeftSwipeTemplate>
            <syncfusion:SfDataGrid.RightSwipeTemplate>
                <DataTemplate>
                    <ContentView x:Name="rightTemplateView"
                                 BackgroundColor="#1AAA87">
                        <Label FontSize="15"
                               HorizontalTextAlignment ="Center" 
                               Text ="Deleted" 
                               TextColor ="White"                  
                               VerticalTextAlignment ="Center"  />
                    </ContentView>
                </DataTemplate>
            </syncfusion:SfDataGrid.RightSwipeTemplate>
        </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void dataGrid_SwipeEnded(object sender, Syncfusion.Maui.DataGrid.DataGridSwipeEndedEventArgs e)
    {
        PerformRowDelete(e.RowData);
    }

    private void PerformRowDelete(object? rowData)
    {
        if (rowData is OrdersInfo orderInfo && viewModel.OrdersInfo.Contains(orderInfo))
        {
            viewModel.OrdersInfo.Remove(orderInfo);
        }
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with swipe delete functionality" src="Images\swiping\maui-datagrid-customize-swipe-delete.png" width="404"/>

## Loading complex template for swiping

The datagrid allows you to swipe the data rows, even when we have a complex template in `DataGridTemplateColumn`.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                ItemsSource="{Binding OrdersInfo}"
                AllowSwiping="True"
                MaxSwipeOffset="180"
                RowHeight="60">
    <syncfusion:SfDataGrid.LeftSwipeTemplate>
        <DataTemplate>
            <Grid BackgroundColor="#6750A4" Padding="0" ColumnDefinitions="*,*">
                <Label Grid.Column="0"
                Text="EDIT"
                HorizontalTextAlignment="End"
                TextColor="#FFFFFF"
                VerticalTextAlignment="Center"
                LineBreakMode="NoWrap"
                BackgroundColor="Transparent"/>
                <Image Grid.Column="1"
                Source="edit.png"
                HeightRequest="18"
                WidthRequest="18"
                Margin="12,0,0,0"
                HorizontalOptions="Start"
                VerticalOptions="Center"/>
            </Grid>
        </DataTemplate>
    </syncfusion:SfDataGrid.LeftSwipeTemplate>
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTemplateColumn MappingName="CustomerID" HeaderText="Customer Details" Width="140">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <Grid InputTransparent="True" 
                          ColumnSpacing="0" 
                          RowSpacing="0" 
                          HorizontalOptions="FillAndExpand" 
                          Margin="0" 
                          ColumnDefinitions="*,*,*"
                          RowDefinitions="10,*,10">
                        <StackLayout
                            Margin="2" 
                            BackgroundColor="White" 
                            Orientation="Vertical" 
                            HorizontalOptions="FillAndExpand"
                            VerticalOptions="FillAndExpand"
                            Grid.Column="0"
                            Grid.ColumnSpan="3"
                            Grid.Row="1">
                            <StackLayout Orientation="Horizontal" HorizontalOptions="FillAndExpand" >
                                <Label Text="Customer ID: " HorizontalTextAlignment="Start" FontSize="13" Padding="0,0,4,0"/>
                                <Label Text="{Binding CustomerID}" FontAttributes="Bold" TextColor="Black" FontSize="13" HorizontalTextAlignment="Start"/>
                            </StackLayout>
                            <StackLayout Orientation="Horizontal" HorizontalOptions="FillAndExpand">
                                <Label Text="Country:" HorizontalTextAlignment="Start" FontSize="13" Padding="0,0,4,0"/>
                                <Label Text="{Binding ShipCountry}" FontAttributes="Bold" TextColor="Black" FontSize="13" HorizontalTextAlignment="Start"/>
                            </StackLayout>
                        </StackLayout>
                    </Grid>
                </DataTemplate>
            </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Loading complex views in swipe template in a DataGrid" src="Images\swiping\maui-datagrid-complex-template-column.png" width="404"/>

## Cancel the swipe programmatically

The data grid allows you to cancel the swipe programmatically by calling the [SfDataGrid.ResetSwipeOffset()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ResetSwipeOffset) method in the [SfDataGrid.SwipeEnded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SwipeOffsetMode) event.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfDataGrid x:Name="dataGrid"
              ItemsSource="{Binding OrdersInfo}"
              AllowSwiping="True"
              SwipeEnded="dataGrid_SwipeEnded">
    <syncfusion:SfDataGrid.LeftSwipeTemplate>
        <DataTemplate>
            <Grid BackgroundColor="Blue" Padding="9">
                <Label Text ="Edit"
                       HorizontalTextAlignment="Center"
                       VerticalTextAlignment="Center"
                       LineBreakMode ="NoWrap"
                       BackgroundColor="Transparent"
                       TextColor ="White" />
            </Grid>
        </DataTemplate>
    </syncfusion:SfDataGrid.LeftSwipeTemplate>
    <syncfusion:SfDataGrid.RightSwipeTemplate>
        <DataTemplate>
            <Grid BackgroundColor="Red" Padding="9">
                <Label FontSize="15"
                       HorizontalTextAlignment ="Center"
                       Text ="Delete"
                       TextColor ="White"
                       VerticalTextAlignment ="Center"
                       LineBreakMode ="NoWrap" />
            </Grid>
        </DataTemplate>
    </syncfusion:SfDataGrid.RightSwipeTemplate>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}

private void dataGrid_SwipeEnded(object sender, Syncfusion.Maui.DataGrid.DataGridSwipeEndedEventArgs e)
{
	dataGrid.ResetSwipeOffset();
}

{% endhighlight %}
{% endtabs %}

## Set MaxSwipeOffset based on content size

Users can restrict the max swipe offset of a row to the width of the content loaded inside the swipe template by setting the [SfDataGrid.SwipeOffsetMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SwipeOffsetMode) as [SwipeOffsetMode.Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeOffsetMode.html#Syncfusion_Maui_DataGrid_DataGridSwipeOffsetMode_Auto). The default value of the `SwipeOffsetMode` is [SwipeOffsetMode.Custom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeOffsetMode.html#Syncfusion_Maui_DataGrid_DataGridSwipeOffsetMode_Custom).

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="datagrid"
                       AllowSwiping="True"
                       SwipeOffsetMode="Auto"
                       ItemsSource="{Binding OrdersInfo}"

</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.SwipeOffsetMode=SwipeOffsetMode.Auto;
{% endhighlight %}
{% endtabs %}

<img alt="Maximum swipe offset based on the content of the swipe template" src="Images\swiping\maui-datagrid-max-swipe-offset-mode.png" width="404"/>

N> The value of the `SfDataGrid.MaxSwipeOffset` property will not be considered when the `SfDataGrid.SwipeOffsetMode` is set to `SwipeOffsetMode.Auto`.

## Load custom swipe buttons based on row data

Using a `DataTemplateSelector`, you can load specific views based on row data, such as `SfDataGrid.RightSwipeTemplate` and `SfDataGrid.LeftSwipeTemplate`. Refer to the code example below to load the desired template based on the row data.

{% tabs %}
{% highlight XAML %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                  ItemsSource="{Binding OrdersInfo}"
                  AllowSwiping="True">
        <syncfusion:SfDataGrid.LeftSwipeTemplate>
            <local:LeftTemplateSelector/>
        </syncfusion:SfDataGrid.LeftSwipeTemplate>
        <syncfusion:SfDataGrid.RightSwipeTemplate>
            <local:RightTemplateSelector/>
        </syncfusion:SfDataGrid.RightSwipeTemplate>
    </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
public class LeftTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var value = (item as OrderInfo).IsClosed;
        if (value)
        {
            var dataTemplate = new DataTemplate(() =>
            {
                Button button = new Button()
                {      
                    TextColor = Colors.Green,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = "Online",
                    BackgroundColor = Colors.LightGray,
                    WidthRequest = 200,
                    CornerRadius = 0,
                    FontAttributes = FontAttributes.Bold
                };
                return button;
            });
            return dataTemplate;
        }

        else
        {
            var dataTemplate = new DataTemplate(() =>
            {
                Button button = new Button()
                {
                    TextColor = Colors.Red,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = "Offline",
                    WidthRequest = 200,
                    BackgroundColor = Colors.LightGray,
                    CornerRadius = 0,
                    FontAttributes = FontAttributes.Bold
                };
                return button;
            });
            return dataTemplate;
        }
    }
}

public class RightTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var value = (item as OrderInfo).IsClosed;
        if (value)
        {
            var dataTemplate = new DataTemplate(() =>
            {
                Button button = new Button()
                {
                    TextColor = Colors.Green,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = "Online",
                    BackgroundColor = Colors.LightGray,
                    WidthRequest = 200,
                    CornerRadius = 0,
                    FontAttributes = FontAttributes.Bold
                };
                return button;
            });
            return dataTemplate;
        }

        else
        {
            var dataTemplate = new DataTemplate(() =>
            {
                Button button = new Button()
                {
                    TextColor = Colors.Red,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = "Offline",
                    BackgroundColor = Colors.LightGray,
                    WidthRequest = 200,
                    CornerRadius = 0,
                    FontAttributes = FontAttributes.Bold
                };
                return button;
            });
            return dataTemplate;
        }
    }
}

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the custom swipe buttons that are loaded based on the cell value of the "Is Online" switch column.

<img alt="Custom Swipe button for Online" src="Images\swiping\maui-datagrid-custom-online-swipe-buttons.png" width="404"/>

<img alt="Custom Swipe button for Offline" src="Images\swiping\maui-datagrid-custom-offline-swipe-buttons.png" width="404"/>

## Enable swiping for summary and unbound rows

To enable swiping of the `UnboundRow`, `CaptionSummaryRow`, `GroupSummaryRow`, and `TableSummaryRow`, set the `Cancel` property of the `SwipeStartedEventArgs` to false in the `SfDataGrid.SwipeStarted` event handler. By default, the `Cancel` property is set to true for all non-data rows.

{% highlight c# %}

    private void dataGrid_SwipeStarting(object sender, Syncfusion.Maui.DataGrid.DataGridSwipeStartingEventArgs e)
    {
        if(dataGrid.IsUnboundRow(e.RowIndex) || dataGrid.IsCaptionSummaryRow(e.RowIndex) || dataGrid.IsGroupSummaryRow(e.RowIndex))
        {
            e.Cancel = false;
        }
        else if (e.RowData.GetType() == typeof(SummaryRecordEntry))
        {
            if ((e.RowData as SummaryRecordEntry).Parent?.GetType() == typeof(Group))
            {
                //// Enable swiping for group summary row.
                e.Cancel = false;
            }
            else
            {
                //// Enable swiping for table summary row.
                e.Cancel = false;
            }
        }
    }

{% endhighlight %}