---
layout: post
title: Popup Positioning in .NET MAUI Popup control | Syncfusion
description: Learn all about Popup Positioning support in the Syncfusion .NET MAUI Popup (SfPopup) control, its elements, and more.
platform: MAUI
control: SfPopup
documentation: ug
---

# Popup Positioning in MAUI Popup (SfPopup)

The `SfPopup` allows showing the popup content at various available positions.

Following are the list of options available to show SfPopup at various positions.

<table>
<tr>
<th>Methods / Properties</th>
<th>Description</th></tr>
<tr>
<td>{{'[IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsOpen)'| markdownify }}</td>
<td>Show the <code>SfPopup</code> at the center.</td></tr>
<tr>
<td>{{'[Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_)'| markdownify }}</td>
<td>Similar as <code>SfPopup.IsOpen</code> property.</td></tr>
<tr>
<td>{{'[Show(x-position, y-position)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Double_System_Double_)'| markdownify }}</td>
<td>Show the <code>SfPopup</code> at the specified X and y positions.</td></tr>
<tr>
<td>{{'[ShowRelativeToView(View, RelativePosition)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Microsoft_Maui_Controls_View_Syncfusion_Maui_Popup_PopupRelativePosition_System_Double_System_Double_)'| markdownify }}</td>
<td>Show the <code>SfPopup</code> at the position relative to the specified view.</td></tr>
<tr>
<td>{{'[ShowRelativeToView(View, RelativePosition, x-position, y-position)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Microsoft_Maui_Controls_View_Syncfusion_Maui_Popup_PopupRelativePosition_System_Double_System_Double_)'| markdownify }}</td>
<td>Show the <code>SfPopup</code> at an absolute x, y coordinate from the relative position of the specified view.</td></tr>
<tr>
<td>{{'[IsFullScreen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsFullScreen)'| markdownify }}</td>
<td>Show the <code>SfPopup</code> in full width and height of the screen.</td></tr>
<tr>
<td>{{'[Show(bool)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_)'| markdownify }}</td>
<td>Similar as <code>SfPopup.IsFullScreen</code> property.</td></tr>
<tr>
<td>{{'[SfPopup.Show(string title, string message)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_String_System_String_)'| markdownify }}</td>
<td>Static method to show a popup with the title and message.</td></tr>
<tr>
<td>{{'[SfPopup.Show(string title, string message, string acceptText)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_String_System_String_System_String_)'| markdownify }}</td>
<td>Static method to show a popup with the title, message and acceptText.</td></tr>
</table>

## Center positioning

The `SfPopup` can be shown at the center by using the following options.

 * IsOpen property
 * SfPopup.Show

To open the `SfPopup`, use the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsOpen) property as in the following code sample.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.Content>
    <StackLayout Padding="20">
      <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
              VerticalOptions="Start" HorizontalOptions="Center" 
              Clicked="ClickToShowPopup_Clicked" />
      <sfPopup:SfPopup x:Name="sfPopup">
      </sfPopup:SfPopup>
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  // Shows SfPopup at the center of the view.
  sfPopup.IsOpen = true;
}
{% endhighlight %}
{% endtabs %}

To open the SfPopup, use the [SfPopup.Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_) method as in the following code sample.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.Content>
    <StackLayout Padding="20">
      <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
              VerticalOptions="Start" HorizontalOptions="Center" 
              Clicked="ClickToShowPopup_Clicked" />
      <sfPopup:SfPopup x:Name="sfPopup">
      </sfPopup:SfPopup>
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  // Shows SfPopup at the center of the view.
  sfPopup.Show();
}
{% endhighlight %}
{% endtabs %}

![Displaying a .NET MAUI Popup at the center of the screen.](Images/popup-positioning/maui-popup-with-center-positioning.png)

## Absolute positioning

To open the `SfPopup` in specific X and Y coordinates, use the [SfPopup.Show(x-position, y-position)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Double_System_Double_) method as in the following code sample.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.Content>
    <StackLayout Padding="20">
      <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
              VerticalOptions="Start" HorizontalOptions="Center" 
              Clicked="ClickToShowPopup_Clicked" />
      <sfPopup:SfPopup x:Name="sfPopup">
      </sfPopup:SfPopup>
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  // Shows SfPopup at x-position 50 and y position 200.
  sfPopup.Show(50, 200);
}
{% endhighlight %}
{% endtabs %}

![Displaying a .NET MAUI Popup at Absolute position.](Images/popup-positioning/maui-popup-absolute-positioning.png)

### Show absolute positioning in MVVM

The [StartX](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_StartX) and [StartY](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_StartY) properties of the `SfPopup` control define the initial coordinates for the popup to display.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="16 17" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMauiPositioning"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.BindingContext>
    <local:ViewModel/>
  </ContentPage.BindingContext>
  <ContentPage.Content>       
    <StackLayout>
      <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" Margin="0,30,0,30"
              HorizontalOptions="Center"
              Clicked="ClickToShowPopup_Clicked" />
      <sfPopup:SfPopup x:Name="sfPopup" 
                       StartX="0" 
                       StartY="100"
                       IsOpen="{Binding DisplayPopup}">
      </sfPopup:SfPopup>
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  (this.BindingContext as ViewModel).DisplayPopup = true;	
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class ViewModel : INotifyPropertyChanged
{
  private bool displayPopup;
  public bool DisplayPopup
  {
      get { return displayPopup; }
      set { displayPopup = value; RaisePropertyChanged("DisplayPopup"); }
  }
  public ViewModel()
  {
      this.DisplayPopup = false;
  }
  public void RaisePropertyChanged(string propName)
  {
      if (this.PropertyChanged != null)
          this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
  }
  public event PropertyChangedEventHandler PropertyChanged;
}
{% endhighlight %}
{% endtabs %}


## Relative positioning

`SfPopup` can be shown at the relative position by using the following method.

### Display popup relative to a view

To open the `SfPopup` relative to a view, use the [SfPopup.ShowRelativeToView(View, RelativePosition)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Microsoft_Maui_Controls_View_Syncfusion_Maui_Popup_PopupRelativePosition_System_Double_System_Double_) method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Content>       
  <StackLayout VerticalOptions="Start" HorizontalOptions="Center" Padding="20">
    <Button x:Name="clickToShowPopup" Text="ClickToShowPopup"
            VerticalOptions="Start" HorizontalOptions="Start"
            Clicked="ClickToShowPopup_Clicked" />   
    <sfPopup:SfPopup x:Name="sfPopup">
    </sfPopup:SfPopup>
  </StackLayout>
</ContentPage.Content>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  // Shows SfPopup at the bottom of the button.
  sfPopup.ShowRelativeToView(clickToShowPopup, PopupRelativePosition.AlignBottom);
}
{% endhighlight %}
{% endtabs %}

![Displaying a .NET MAUI Popup at Relative position.](Images/popup-positioning/maui-popup-relative-positioning.png)

### Display popup relatively to a view with absolute coordinates

The `SfPopup` can be displayed at an absolute x, y coordinate from the relative position of the specified view by using the following method.

To open the `SfPopup` in the specific x and y coordinate relative to a view, use the [SfPopup.ShowRelativeToView(View, RelativePosition, x-position, y-position)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Microsoft_Maui_Controls_View_Syncfusion_Maui_Popup_PopupRelativePosition_System_Double_System_Double_) method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Content>       
  <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="20">
    <Button x:Name="clickToShowPopup" Text="ClickToShowPopup"
            VerticalOptions="Center" HorizontalOptions="Start"
            Clicked="ClickToShowPopup_Clicked" />
    <sfPopup:SfPopup x:Name="sfPopup">
    </sfPopup:SfPopup>
  </StackLayout>
</ContentPage.Content>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  // Show the SfPopup at the bottom of the button and with an absolute relative position.
  sfPopup.ShowRelativeToView(clickToShowPopup, PopupRelativePosition.AlignBottom, 50, 50);
}
{% endhighlight %}
{% endtabs %}

![Displaying a .NET MAUI Popup at Absolute Relative position.](Images/popup-positioning/maui-popup-absolute-relative-positioning.png)

You can pass both negative and positive values as parameters to the `SfPopup.ShowRelativeToView(View, RelativePosition, x-position, y-position)`. The popup will be positioned by considering the relative position as (0, 0) the center point. For example, if you have set the `RelativePosition` as `PopupRelativePosition.AlignBottomRight` and `RelativeView` as a button, bottom right corner of the button will be considered as the 0, 0 point and a negative x-position value will place the popup to the left of that point and a positive x-position value will place the popup to the right of that point. The same applies for y-position also.

### Show relative to view in MVVM

To open the SfPopup relative to a view in MVVM assign values to the [SfPopup.RelativeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_RelativeView) and [SfPopup.RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_RelativePosition) properties and use the `SfPopup.IsOpen` property to open or close the popup using binding.
The [AbsoluteX](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AbsoluteX) and [AbsoluteY](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AbsoluteY) are used to display popup at the specified coordinates when positioning it relatively to the specified `RelativeView` based on the `RelativePosition`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="19" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMauiPositioning"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.BindingContext>
    <local:ViewModel/>
  </ContentPage.BindingContext>
  <ContentPage.Content>       
    <StackLayout>
      <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" Margin="0,30,0,30"
              HorizontalOptions="Center"
              Clicked="ClickToShowPopup_Clicked" />
      <Label x:Name="relativeView" Text="Showing Popup at relative position in MVVM" 
             VerticalOptions="StartAndExpand" HorizontalOptions="Center" 
             HorizontalTextAlignment="Center" FontFamily="Roboto" Padding="20"
             LineBreakMode="WordWrap" FontSize="14" BackgroundColor="#6750A4" TextColor="White"/>
      <sfPopup:SfPopup x:Name="sfPopup" 
                       IsOpen="{Binding DisplayPopup}"
                       RelativeView="{x:Reference relativeView}" RelativePosition="AlignBottom"
                       AbsoluteX="0" AbsoluteY="5">
      </sfPopup:SfPopup>
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
  // Show the SfPopup at the bottom of the label and with absolute relative position.
  (this.BindingContext as ViewModel).DisplayPopup = true;	
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class ViewModel : INotifyPropertyChanged
{
  private bool displayPopup;
  public bool DisplayPopup
  {
      get { return displayPopup; }
      set { displayPopup = value; RaisePropertyChanged("DisplayPopup"); }
  }
  public ViewModel()
  {
      this.DisplayPopup = false;
  }
  public void RaisePropertyChanged(string propName)
  {
      if (this.PropertyChanged != null)
          this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
  }
  public event PropertyChangedEventHandler PropertyChanged;
}
{% endhighlight %}
{% endtabs %}

![Relative positioning of .NET MAUI Popup in MVVM](Images/popup-positioning/maui-popup-relative-positioning-in-mvvm.png)

## Close the popup automatically after timeout

To close a popup automatically after a specified delay, you can use the [AutoCloseDuration] (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AutoCloseDuration) property, which allows you to give the duration in milliseconds for the popup to automatically close itself without any user interaction.

{% tabs %}
{% highlight xaml hl_lines="3" %}
<syncfusion:SfPopup x:Name="SfPopup" 
                    IsOpen="True"
                    AutoCloseDuration="3000"> 
</syncfusion:SfPopup>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
SfPopup popup = new SfPopup();
popup.AutoCloseDuration = 3000;
popup.IsOpen = true;
{% endhighlight %}
{% endtabs %}

![Dismiss the popup automatically after a specified delay in the .NET MAUI Popup.](Images/popup-positioning/maui-popup-autocloseduration.gif)

## How to

### Returning result

The [ShowAsync()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowAsync) method of the Popup allows you to display the popup and returns `true` if the user closes it using the accept button, or `false` otherwise.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:PopupDemo"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupDemo.MainPage">
    <StackLayout padding="20">
        <Button x:Name="clickToShowPopup"
                Text="ClickToShowPopup"
                VerticalOptions="Start"
                HorizontalOptions="Center"
                Clicked="ClickToShowPopup_Clicked" />
        <sfPopup:SfPopup x:Name="popup">
        </sfPopup:SfPopup>
    </StackLayout>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}
using Syncfusion.Maui.Popup;
public partial class MainPage : ContentPage
{
  SfPopup popup;
  public MainPage()
  {
    InitializeComponent();
    popup = new SfPopup();
  }
  private async void ClickToShowPopup_Clicked(object sender, EventArgs e)
  {
    bool answer = await popup.ShowAsync();
  }
}
{% endhighlight %}
{% endtabs %}

The [Show(string title, string message, string acceptText, string declineText)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_String_System_String_System_String_System_String_) static method of the Popup allows you to display the popup and returns `true` if the user closes it using the accept button, or `false` otherwise.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.Content>
    <StackLayout Padding="20">
      <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
              VerticalOptions="Start" HorizontalOptions="Center" 
              Clicked="ClickToShowPopup_Clicked" />
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="10" %}
using Syncfusion.Maui.Popup;
public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
  }
  private async void ClickToShowPopup_Clicked(object sender, EventArgs e)
  {
    bool answer = await SfPopup.Show("Question?", "Would you like to play a game", "Yes", "No");
  }
}
{% endhighlight %}
{% endtabs %}

### Load the SfPopup in CellTappedEvent of the SfDataGrid

The `SfPopup` allows opening it in the [CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped) event of the `SfDataGrid`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="14" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfDatagrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMauiPositioning"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
  </ContentPage.BindingContext>  
  <ContentPage.Content>
    <Grid>
      <sfDatagrid:SfDataGrid x:Name="dataGrid"
                             ItemsSource="{Binding OrdersInfo}"
                             CellTapped="OnDataGridCellTapped"    
                             ColumnWidthMode="Fill">
      </sfDatagrid:SfDataGrid>
      <sfPopup:SfPopup x:Name="sfPopup" 
                       HeaderTitle="Popup" 
                       AutoSizeMode="Height"
                       ShowCloseButton="True">
        <sfPopup:SfPopup.ContentTemplate>
          <DataTemplate>
            <Label Text="A pop-up is a graphical user interface display area that suddenly appears in the foreground of the visual interface. Pop-up can be initiated by single or double tap or can be timed to occur. A pop-up window should be smaller than the background window or interface; otherwise, it's a replacement interface."                               
                   TextColor="Black" 
                   FontSize="14" 
                   FontFamily="Roboto" 
                   Padding="0,0,0,24" />
          </DataTemplate>
        </sfPopup:SfPopup.ContentTemplate>
      </sfPopup:SfPopup>
    </Grid>
  </ContentPage.Content> 
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="17" %}
namespace PopupMauiPositioning;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
  SfDataGrid dataGrid;
  ViewModel viewModel;
  SfPopup sfPopup;

  public MainPage()
  {
    InitializeComponent();
    dataGrid = new SfDataGrid();
    viewModel = new ViewModel();
    dataGrid.ItemsSource = viewModel.OrdersInfo;
    dataGrid.CellTapped += OnDataGridCellTapped;
    dataGrid.ColumnWidthMode = ColumnWidthMode.Fill;

    sfPopup = new SfPopup();
    sfPopup.HeaderTitle = "Popup";
    sfPopup.ShowCloseButton = true;
    sfPopup.AutoSizeMode = PopupAutoSizeMode.Height;
    sfPopup.ContentTemplate = new DataTemplate(() =>
    {
        var label = new Label();
        label.Text = "A pop-up is a graphical user interface display area that suddenly appears in the foreground of the visual interface. The pop-up can be initiated by a single or double tap or can be timed to occur. A pop-up window should be smaller than the background window or interface; otherwise, it's a replacement interface.";
        label.TextColor = Colors.Black;
        label.FontSize = 14;
        label.FontFamily = "Roboto";
        label.Padding = new Thickness(0, 0, 0, 24);
        return label;
    });
    this.Content = dataGrid;
  }  
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void OnDataGridCellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
{
  sfPopup.Show();
}
{% endhighlight %}
{% endtabs %}

![.NET MAUI Popup with DataGrid ](Images/popup-positioning/show-maui-popup-when-grid-cell-tap.png)

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/how-to-show-a-.net-maui-popup-when-tap-.net-maui-datagrid-cell).

### Open SfPopup in ItemTapped event of SfListView

The `SfPopup` allows opening it in the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event of the `SfListView`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="15" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfListView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMauiPositioning"
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.BindingContext>
    <local:ContactsViewModel x:Name="viewModel" />
  </ContentPage.BindingContext>  
  <ContentPage.Content>
    <Grid>
      <sfListView:SfListView x:Name="listView" ItemSize="56"
                             ItemsSource="{Binding Items}" 
                             SelectionMode="None"
                             ItemTapped="OnListViewItemTapped">
        <sfListView:SfListView.ItemTemplate>
          <DataTemplate>
            <Grid x:Name="grid">
              <Grid.RowDefinitions>
                  <RowDefinition Height="*" />
                  <RowDefinition Height="1"/>
              </Grid.RowDefinitions>
              <Grid.ColumnDefinitions>
                  <ColumnDefinition Width="56" />
                  <ColumnDefinition Width="*" />
                  <ColumnDefinition Width="*" />
              </Grid.ColumnDefinitions>
              <Image Source="{Binding ContactImage}"
                     VerticalOptions="Center"
                     HorizontalOptions="Center"
                     HeightRequest="40"
                     WidthRequest="40"/>
              <Label Grid.Column="1"
                     VerticalTextAlignment="Center"
                     LineBreakMode="NoWrap"
                     Text="{Binding ContactName}" 
                     FontSize="14" />
              <Image Grid.Column="2"
                     Source="{Binding ContactType}"
                     VerticalOptions="Center"
                     HorizontalOptions="End"
                     HeightRequest="20"
                     WidthRequest="20" Margin="0,0,8,0"/>
              <StackLayout BackgroundColor="LightGray" 
                           HeightRequest="1" 
                           Grid.Row="1" Grid.ColumnSpan="3"/>
            </Grid>
          </DataTemplate>
        </sfListView:SfListView.ItemTemplate>
      </sfListView:SfListView>
      <sfPopup:SfPopup x:Name="sfPopup" 
                       WidthRequest="220" HeightRequest="120"
                       ShowCloseButton="True">
        <sfPopup:SfPopup.ContentTemplate>
          <DataTemplate>
            <Label Text="ListView item is tapped"                           
                   TextColor="Black"
                   FontSize="14"
                   FontFamily="Roboto"/>
          </DataTemplate>
        </sfPopup:SfPopup.ContentTemplate>
      </sfPopup:SfPopup>
    </Grid>
  </ContentPage.Content> 
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="72" %}
namespace PopupMauiPositioning;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
  SfListView listView;
  ContactsViewModel viewModel;
  SfPopup sfPopup;

  public MainPage()
  {
    InitializeComponent();  
    listView = new SfListView();
    listView.ItemTemplate = new DataTemplate(() =>
    {
      var grid = new Grid();
      grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 56 });
      grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
      grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
      grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
      grid.RowDefinitions.Add(new RowDefinition() { Height = 1 });
      
      var contactImage = new Image()
      {
          VerticalOptions = LayoutOptions.Center,
          HorizontalOptions = LayoutOptions.Center,
          HeightRequest = 40,
          WidthRequest = 40
      };
      contactImage.SetBinding(Image.SourceProperty, new Binding("ContactImage"));
      var contactName = new Label()
      {
          VerticalTextAlignment = TextAlignment.Center,
          LineBreakMode = LineBreakMode.NoWrap,
          FontSize = 14
      };
      contactName.SetBinding(Label.TextProperty, new Binding("ContactName"));
      var contactType = new Image()
      {
          VerticalOptions = LayoutOptions.Center,
          HorizontalOptions = LayoutOptions.End,
          HeightRequest = 20,
          WidthRequest = 20,
          Margin = new Thickness(0, 0, 8, 0)
      };
      contactType.SetBinding(Image.SourceProperty, new Binding("ContactType"));
      var stackLayout = new StackLayout()
      {
          BackgroundColor = Colors.LightGray,
          HeightRequest = 1,                
      };      
      grid.Children.Add(contactImage);
      Grid.SetColumn(contactImage, 0);
      Grid.SetRow(contactImage, 0);
      grid.Children.Add(contactName);
      Grid.SetColumn(contactName, 1);
      Grid.SetRow(contactName, 0);
      grid.Children.Add(contactType);
      Grid.SetColumn(contactType, 2);
      Grid.SetRow(contactType, 0);
      grid.Children.Add(stackLayout);
      Grid.SetColumn(stackLayout, 0);
      Grid.SetRow(stackLayout, 1);
      Grid.SetColumnSpan(stackLayout, 3);
      return grid;
    });
    viewModel = new ContactsViewModel();
    listView.ItemsSource = viewModel.Items;
    listView.ItemSize = 56;
    listView.SelectionMode = Syncfusion.Maui.ListView.SelectionMode.None;
    listView.ItemTapped += OnListViewItemTapped;
    sfPopup = new SfPopup();
    sfPopup.WidthRequest = 220;
    sfPopup.HeightRequest = 120; ;
    sfPopup.ShowCloseButton = true;
    sfPopup.ContentTemplate = new DataTemplate(() =>
    {
      return new Label()
      {
        Text = "ListView item is tapped",
        FontSize = 14,
        TextColor = Colors.Black,
        FontFamily = "Roboto"
      };
    });        
    this.Content = listView;  
  }  
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void OnListViewItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
{
  sfPopup.Show();
}
{% endhighlight %}
{% endtabs %}

![ListView with .NET MAUI Popup](Images/popup-positioning/show-maui-popup-when-listview-item-tap.png)

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/how-to-show-a-.net-maui-popup-when-tap-.net-maui-listview-item).

### Display popup when interacting with a switch

[SfPopup.IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsOpen) is a bindable property and hence can be bind to any property and based on its value the popup will open or close. In the following code example, we have bound the `IsOpen` property with the `IsToggled` property of the switch, and the popup will be opened or closed as the switch toggles.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="11" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"             
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"            
             x:Class="PopupMauiPositioning.MainPage">
  <ContentPage.Content>
    <StackLayout Padding="20">
      <Switch x:Name="popupSwitch" 
              IsToggled="False" 
              VerticalOptions="Start" HorizontalOptions="Center"/>
      <sfPopup:SfPopup x:Name="sfPopup"
                       IsOpen="{Binding Source={x:Reference popupSwitch},Path=IsToggled}"/>
    </StackLayout>
  </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}