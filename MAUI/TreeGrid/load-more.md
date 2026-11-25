---
layout: post
title: Load More in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to load more data on demand in Syncfusion® .NET MAUI Tree Grid using the load more command, load more options, position, appearance and custom load more view.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid load more, maui treegrid load more, treegrid load on demand
---

# Load More in .NET MAUI Tree Grid

To enable load more functionality in [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html), set the [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowLoadMore) property to `true` and specify a [LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreOption). When enabled, the load more view appears when the user scrolls to the end of the records. Depending on the option, the user taps the load more button, or the TreeGrid automatically executes the command, to load additional items from your data source.

N> The `syncfusion` prefix used in the XAML samples refers to `xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"`.

## Load more command

The [LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreCommand) is an `ICommand` that executes when the user triggers a load more action. Use [LoadMoreCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreCommandParameter) to pass a parameter to your command. When no parameter is set, the `SfTreeGrid` instance is passed as the command parameter when the load more button is tapped.

**Managing the loading state:**
Set the [IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_IsBusy) property to `true` before loading items. This displays a loading indicator and prevents duplicate load more requests. Set it to `false` after the load completes. The loading indicator remains visible until `IsBusy` is set to `false`.

**Example: Basic load more with command**

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfTreeGrid treeGrid;
    EmployeeViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        treeGrid = new SfTreeGrid();
        viewModel = new EmployeeViewModel();
        treeGrid.ItemsSource = viewModel.Employees;
        treeGrid.ChildPropertyName = "ReportingPeople";
        treeGrid.AllowLoadMore = true;
        treeGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = treeGrid;
    }

    private async void ExecuteLoadMoreCommand()
    {
        this.treeGrid.IsBusy = true;
        await Task.Delay(TimeSpan.FromSeconds(2)); // Simulate network delay.
        viewModel.LoadMoreItems();
        this.treeGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeViewModel.cs" %}
using System.Collections.ObjectModel;

public class EmployeeViewModel
{
    public ObservableCollection<EmployeeInfo> Employees { get; set; } = new();

    public EmployeeViewModel()
    {
        this.LoadMoreItems();
    }

    public void LoadMoreItems()
    {
        int count = Employees.Count;
        for (int i = 1; i <= 10; i++)
        {
            Employees.Add(new EmployeeInfo { Name = $"Employee {count + i}", Title = "Developer" });
        }
    }
}

public class EmployeeInfo
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public ObservableCollection<EmployeeInfo> ReportingPeople { get; set; } = new();
}
{% endhighlight %}
{% endtabs %}

N> Add the new items to the same observable collection that is bound to [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ItemsSource), so that the TreeGrid is notified about the new root nodes.

## Load More Option

The [LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreOption) property determines when the load more action is triggered. The default option is `Manual`.

| [TreeGridLoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMoreOption.html) | Behavior |
|---|---|
| `Manual` | Displays a load more button at the end of the records. The user must tap the button to execute `LoadMoreCommand`. |
| `Auto` | Executes `LoadMoreCommand` automatically when the last record is reached while scrolling. |
| `AutoOnScroll` | Executes `LoadMoreCommand` automatically when the last record is reached, but only after the user has interacted with the scroll view. |

### Configure load more options

All three options use the same command pattern.

#### Auto (automatic loading at the end)

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowLoadMore="True"
                       LoadMoreOption="Auto"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowLoadMore = true;
treeGrid.LoadMoreOption = TreeGridLoadMoreOption.Auto;
treeGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);

private async void ExecuteLoadMoreCommand()
{
    treeGrid.IsBusy = true;
    await Task.Delay(TimeSpan.FromSeconds(2));
    viewModel.LoadMoreItems();
    treeGrid.IsBusy = false;
}
{% endhighlight %}
{% endtabs %}

#### Manual (button appears at the end)

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowLoadMore="True"
                       LoadMoreOption="Manual"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

#### AutoOnScroll (automatic when the user scrolls to the end)

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowLoadMore="True"
                       LoadMoreOption="AutoOnScroll"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

N> With `AutoOnScroll`, `LoadMoreCommand` is not executed on the initial load. It is executed only after the user scrolls.

## Customization

### Display text

Customize the text displayed in the load more button by setting the [LoadMoreText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreText) property. The default text is `Load More`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowLoadMore="True"
                       LoadMoreText="LOAD MORE"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowLoadMore = true;
treeGrid.LoadMoreText = "LOAD MORE";
treeGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
{% endhighlight %}
{% endtabs %}

### Position

The position of the load more view can be customized by using the [LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMorePosition) property. By default, the load more view is displayed at the bottom.

| [TreeGridLoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMorePosition.html) | Description |
|---|---|
| `Bottom` | The load more view is displayed at the bottom of the TreeGrid. This is the default value. |
| `Top` | The load more view is displayed at the top of the TreeGrid, below the header row. |

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowLoadMore="True"
                       LoadMorePosition="Top"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowLoadMore = true;
treeGrid.LoadMorePosition = TreeGridLoadMorePosition.Top;
treeGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
{% endhighlight %}
{% endtabs %}

### Appearance

Customize the load more view appearance using the following `TreeGridStyle` properties:

| Property | Type | Default | Description |
|---|---|---|---|
| [LoadMoreBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_LoadMoreBackground) | `Brush` | `#FFFBFE` | Sets the background of the load more view. |
| [LoadMoreButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_LoadMoreButtonBackground) | `Brush` | `#6750A4` | Sets the background of the load more button. |
| [LoadMoreButtonTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_LoadMoreButtonTextColor) | `Color` | `#FFFFFF` | Sets the text color of the load more button. |
| [LoadMoreIndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_LoadMoreIndicatorColor) | `Color` | `#6750A4` | Sets the color of the loading indicator. |

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowLoadMore="True"
                       LoadMoreOption="Manual">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle LoadMoreBackground="#FFF1F6"
                                  LoadMoreButtonBackground="#FFAFCC"
                                  LoadMoreButtonTextColor="#c1121f"
                                  LoadMoreIndicatorColor="#CDB4DB" />
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowLoadMore = true;
treeGrid.LoadMoreOption = TreeGridLoadMoreOption.Manual;
treeGrid.DefaultStyle.LoadMoreBackground = new SolidColorBrush(Color.FromArgb("#FFF1F6"));
treeGrid.DefaultStyle.LoadMoreButtonBackground = new SolidColorBrush(Color.FromArgb("#FFAFCC"));
treeGrid.DefaultStyle.LoadMoreButtonTextColor = Color.FromArgb("#C1121F");
treeGrid.DefaultStyle.LoadMoreIndicatorColor = Color.FromArgb("#CDB4DB");
{% endhighlight %}
{% endtabs %}

## Change load more view size

You can customize the load more view size by setting the `HeightRequest` and `WidthRequest` properties on the [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreView) and on its button. The default height of the load more view is `54`, and the default size of the button is `116` x `40`.

{% tabs %}
{% highlight c# %}
public MainPage()
{
    InitializeComponent();
    treeGrid = new SfTreeGrid();
    viewModel = new EmployeeViewModel();
    treeGrid.ItemsSource = viewModel.Employees;
    treeGrid.ChildPropertyName = "ReportingPeople";
    treeGrid.AllowLoadMore = true;
    treeGrid.LoadMoreText = "Load More Items";
    treeGrid.LoadMoreView.HeightRequest = 50;
    treeGrid.LoadMoreView.Children.OfType<Button>().First().WidthRequest = 150;
    treeGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
    this.Content = treeGrid;
}
{% endhighlight %}
{% endtabs %}

## Custom load more view

You can replace the built-in load more view with a custom view to match your application design. Create a class that derives from [TreeGridLoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMoreView.html), override the required methods, and assign it to the `SfTreeGrid.LoadMoreView` property.

**When to use:** When the built-in load more button does not match your UI design, or you need custom behavior.

| Member of `TreeGridLoadMoreView` | Description |
|---|---|
| `LoadMoreCommand` | The command that is executed by the view. The TreeGrid assigns its `LoadMoreCommand` to this property. |
| `InitLoadMoreView()` | Protected virtual. Initializes the content of the view. Override it to create custom content. The base implementation creates the button and the indicator. |
| `SetLoadMoreViewStyle(TreeGridStyle? style)` | Protected internal virtual. Applies the style of the TreeGrid to the view. |
| `MeasureContent(double, double)` and `ArrangeContent(Rect)` | Protected override. Measure and arrange the content of the view. |
| `OnDraw(ICanvas, RectF)` | Protected override. Draws the border lines of the view. |
| `Dispose()` and `Dispose(bool)` | Releases the resources of the view. |

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfTreeGrid treeGrid;
    EmployeeViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        treeGrid = new SfTreeGrid();
        viewModel = new EmployeeViewModel();
        treeGrid.ItemsSource = viewModel.Employees;
        treeGrid.ChildPropertyName = "ReportingPeople";
        treeGrid.AllowLoadMore = true;
        treeGrid.LoadMoreView = new CustomLoadMoreView();
        treeGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = treeGrid;
    }

    private void ExecuteLoadMoreCommand()
    {
        treeGrid.IsBusy = true;
        viewModel.LoadMoreItems();
        treeGrid.IsBusy = false;
    }
}

// Custom load more view implementation.
public class CustomLoadMoreView : TreeGridLoadMoreView
{
    private Label? loadMoreLabel;

    protected internal override void SetLoadMoreViewStyle(TreeGridStyle? style)
    {
        if (style != null)
        {
            this.Background = style.LoadMoreBackground;
        }
    }

    protected override void InitLoadMoreView()
    {
        this.HeightRequest = 50;
        var tapGestureRecognizer = new TapGestureRecognizer();
        loadMoreLabel = new Label()
        {
            HeightRequest = 25,
            WidthRequest = 150,
            Text = "Load More Items",
            HorizontalTextAlignment = TextAlignment.Center
        };
        loadMoreLabel.GestureRecognizers.Add(tapGestureRecognizer);
        this.Children.Add(loadMoreLabel);
        tapGestureRecognizer.Tapped += LoadMoreLabel_Tapped;
    }

    private void LoadMoreLabel_Tapped(object? sender, EventArgs e)
    {
        this.LoadMoreCommand?.Execute(null);
    }

    protected override Size MeasureContent(double widthConstraint, double heightConstraint)
    {
        (loadMoreLabel as IView)?.Measure(widthConstraint, heightConstraint);
        return new Size(widthConstraint, heightConstraint);
    }

    protected override Size ArrangeContent(Rect bounds)
    {
        (loadMoreLabel as IView)?.Arrange(bounds);
        return bounds.Size;
    }
}
{% endhighlight %}
{% endtabs %}

N> The view displays the busy indicator that the base class creates. A custom view that overrides `InitLoadMoreView` without calling the base implementation does not display a loading indicator. Verification Required – the visibility of a custom view while `IsBusy` is `true` is not verified.

## API reference

### SfTreeGrid

| Property | Type | Default | Description |
|---|---|---|---|
| [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowLoadMore) | `bool` | `false` | Enables the load more support. |
| [LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreCommand) | `ICommand?` | `null` | The command that is executed to load more items. |
| [LoadMoreCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreCommandParameter) | `object?` | `null` | The parameter that is passed to the command. |
| [LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreOption) | `TreeGridLoadMoreOption` | `Manual` | How the load more operation is triggered. |
| [LoadMoreText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreText) | `string` | `Load More` | The text of the load more button. |
| [LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMorePosition) | `TreeGridLoadMorePosition` | `Bottom` | The position of the load more view. |
| [IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_IsBusy) | `bool` | `false` | Indicates that the TreeGrid is loading more items. |
| [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LoadMoreView) | `TreeGridLoadMoreView` | A `TreeGridLoadMoreView` instance | The view that is displayed at the top or bottom of the TreeGrid. |

`AllowLoadMoreProperty`, `LoadMoreCommandProperty`, `LoadMoreCommandParameterProperty`, `LoadMoreOptionProperty`, `LoadMoreTextProperty`, `LoadMorePositionProperty`, `IsBusyProperty`, and `LoadMoreViewProperty` are the bindable property identifiers of the corresponding properties.

### Related public types

| Type | Description |
|---|---|
| [TreeGridLoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMoreOption.html) | Enum with the values `Manual`, `Auto`, and `AutoOnScroll`. |
| [TreeGridLoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMorePosition.html) | Enum with the values `Top` and `Bottom`. |
| [TreeGridLoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMoreView.html) | The view that displays the load more button and the loading indicator. It implements `IDisposable`. |
| [TreeGridLoadMoreViewButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMoreViewButton.html) | The `Button` that is used by the load more view. Its default size is 116 x 40, with a corner radius of 20. |
| [TreeGridLoadMoreViewIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLoadMoreViewIndicator.html) | The `ActivityIndicator` that is used by the load more view. Its default size is 36 x 36. |

## Supported combinations

### Works with

* **Hierarchical and self-relational data**: Items that are added to the bound collection are displayed as new nodes.
* **Custom view and appearance**: `LoadMoreView`, `LoadMoreText`, `LoadMorePosition`, and the `TreeGridStyle` properties.

### Known limitations

* While `IsBusy` is `true`, further load more triggers are ignored.
* The load more view is displayed when the end of the records is reached. When all records fit in the viewport, the view is collapsed. Verification Required – the behavior for collapsed nodes that load their child nodes on demand is not verified.
* Verification Required – Combination support not verified: load more with sorting, filtering, and search.

## Platform-specific considerations

Verification Required – Platform differences in the load more behavior are not identified in the source. The load more view is displayed on all the platforms that the TreeGrid supports.

## See also

* [Data binding in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/data-binding)
* [Styling in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/styling)
