---
layout: post
title: Events and Commands support in .NET MAUI Toolbar Control | Syncfusion®
description: Learn about Events and Commands support in Syncfusion® .NET MAUI Toolbar (SfToolbar) for seamless interactions.
platform: maui
control: Toolbar (SfToolbar)
documentation: ug
---

# Events in .NET MAUI Toolbar (SfToolbar)

The Toolbar supports the [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_Tapped), [ItemTouchInteraction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemTouchInteraction), [ItemLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemLongPressed), [MoreItemsChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreItemsChanged), and [MoreButtonTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreButtonTapped) events to interact with .NET MAUI Toolbar.

## Tapped

A [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_Tapped) event occurs, each time a toolbar item is tapped:

The arguments are listed below:

* **Sender** : This contains the SfToolbar object.

* **Tapped**: The tapped action performed on a toolbar element can be found in the [ToolbarTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarTappedEventArgs.html), you can see details about the tapped items:

    * **NewToolbarItem** : Returns the tapped toolbar item.
    * **PreviousToolbarItem** : Returns the previously tapped toolbar item.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<toolbar:SfToolbar x:Name="toolbar" 
                       Tapped="OnToolbarTapped" >
</toolbar:SfToolbar>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.toolbar.Tapped += this.OnToolbarTapped;
private void OnToolbarTapped(object? sender, ToolbarTappedEventArgs e)
{
    var newToolbarItem = e.NewToolbarItem;
    var oldToolbarItem = e.PreviousToolbarItem;
}

{% endhighlight %}

{% endtabs %}

## Item Touch Interaction

An [ItemTouchInteraction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemTouchInteraction) event occurs when the toolbar item is touch or pointer action:

The arguments are listed below:

* **Sender** : This contains the SfToolbar object.

* **ItemTouchInteraction**: The touch action performed on a toolbar element can be found in the [ToolbarItemTouchInteractionEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarItemTouchInteractionEventArgs.html), you can see details about the touch items:

    * **ToolbarItem** : Returns the touch SfToolbarItem.
    * **PointerActions** : Returns the ToolbarItemPointerActions.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<toolbar:SfToolbar x:Name="toolbar" 
                       ItemTouchInteraction="OnToolbarItemTouchInteraction" >
</toolbar:SfToolbar>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.toolbar.ItemTouchInteraction += this.OnToolbarItemTouchInteraction;
private void OnToolbarItemTouchInteraction(object? sender, ToolbarItemTouchInteractionEventArgs e)
{
    var toolbarItem = e.ToolbarItem;
    var toolbarItemAction = e.PointerActions;
}

{% endhighlight %}

{% endtabs %}

## Item Long Pressed 

An [ItemLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemLongPressed) event occurs when the toolbar item is long pressed.

The arguments are listed below:

* **Sender** : This contains the SfToolbar object.

* **ItemLongPressed**: The long press action performed on a toolbar element can be found in the [ToolbarItemLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarItemLongPressedEventArgs.html), you can see details about the pressed items:

    * **ToolbarItem** : Returns the pressed SfToolbarItem.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<toolbar:SfToolbar x:Name="toolbar" 
                       ItemLongPressed="OnToolbarItemLongPressed" >
</toolbar:SfToolbar>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.toolbar.ItemLongPressed += this.OnToolbarItemLongPressed;
private void OnToolbarItemLongPressed(object? sender, ToolbarItemLongPressedEventArgs e)
{
    var toolbarItem = e.ToolbarItem;
}

{% endhighlight %}

{% endtabs %}

## More Items Changed 

A [MoreItemsChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreItemsChanged) event invokes on more items changed.

The arguments are listed below:

* **Sender** : This contains the SfToolbar object.

* **MoreItemsChanged**: The more items changed action: can be found in the [ToolbarMoreItemsChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarMoreItemsChangedEventArgs.html), you can see details about the more items:

    * **ToolbarItems** : Returns the list of toolbar item in the more options.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<toolbar:SfToolbar x:Name="toolbar" 
                       MoreItemsChanged="OnMoreItemsChanged" >
</toolbar:SfToolbar>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.toolbar.MoreItemsChanged += this.OnMoreItemsChanged;
private void OnMoreItemsChanged(object? sender, ToolbarMoreItemsChangedEventArgs e)
{
    var moreItems = e.ToolbarItems;
}

{% endhighlight %}

{% endtabs %}

## More Button Tapped 

A [MoreButtonTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreButtonTapped) event invokes on [MoreButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarItemOverflowMode.html#Syncfusion_Maui_Toolbar_ToolbarItemOverflowMode_MoreButton) tapped.

The arguments are listed below:

* **Sender** : This contains the SfToolbar object.

* **MoreButtonTapped**: The more button tapped action: can be found in the [ToolbarMoreButtonTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarMoreButtonTappedEventArgs.html), you can see details about the more button:

    * **ToolbarItems** : Returns the list of toolbar item in the more options.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<toolbar:SfToolbar x:Name="toolbar" 
                       MoreButtonTapped="OnMoreButtonTapped" >
</toolbar:SfToolbar>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.toolbar.MoreButtonTapped += this.OnMoreButtonTapped;
private void OnMoreButtonTapped(object? sender, ToolbarMoreButtonTappedEventArgs e)
{
    var moreItems = e.ToolbarItems;
}

{% endhighlight %}

{% endtabs %}

## Commands

Toolbar commands allows to map [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_Tapped) event, [ItemTouchInteraction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemTouchInteraction) event, [ItemLongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemLongPressed) event, [MoreItemsChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreItemsChanged) event and [MoreButtonTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreButtonTapped) event to `Commands` which supports the MVVM (Model-View-ViewModel) pattern.

### Tapped Command

The [TappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_TappedCommand) will be triggered when you tap the toolbar item and pass the [ToolbarItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarTappedEventArgs.html#properties) as parameter.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<Grid>
    <Grid.BindingContext>
        <local:ToolbarInteractionViewModel />
    </Grid.BindingContext>
    <toolbar:SfToolbar x:Name="toolbar"
                    TappedCommand="{Binding ToolbarTappedCommand}"
                    HeightRequest="56"
                    Orientation="Horizontal">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="ToolbarItem1" Text="Zoom-in">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE713;" FontFamily="MaterialAssets"/>
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar toolbar = new SfToolbar();
        ToolbarInteractionViewModel viewModel = new ToolbarInteractionViewModel();
        toolbar.TappedCommand = viewModel.ToolbarTappedCommand;
        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
        {
            new SfToolbarItem
            {
                Name = "Zoom-in",
                ToolTipText = "Zoom-in",
                Icon = new FontImageSource { Glyph = "&#xE713;", FontFamily = "MauiMaterialAssets" }
            },
        };
        toolbar.Items = itemCollection;
        this.Content = toolbar;
    }   
}

{% endhighlight %}

{% highlight C# tabtitle="ToolbarInteractionViewModel.cs" %}

public class ToolbarInteractionViewModel
{
    public ICommand ToolbarTappedCommand { get; set; }
    public ToolbarInteractionViewModel()
    {
        this.ToolbarTappedCommand = new Command<ToolbarTappedEventArgs>(ExecuteTapped, CanExecuteTapped);
    }
    private bool CanExecuteTapped(ToolbarTappedEventArgs arg)
    {
        return true;
    }
    private void ExecuteTapped(ToolbarTappedEventArgs obj)
    {
        var oldItem = obj.PreviousToolbarItem;
        var newItem = obj.NewToolbarItem;
    }
}

{% endhighlight %}

{% endtabs %}

### Item Touch Interaction Command

The [ItemTouchInteractionCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemTouchInteractionCommand) will be triggered when you touch the toolbar item and pass the [ToolbarItemTouchInteractionEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarItemTouchInteractionEventArgs.html) as parameter.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<Grid>
    <Grid.BindingContext>
        <local:ToolbarInteractionViewModel />
    </Grid.BindingContext>
    <toolbar:SfToolbar ItemTouchInteractionCommand="{Binding ToolbarItemTouchInteractedCommand}"
                    HeightRequest="56"
                    Orientation="Horizontal">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="ToolbarItem1" Text="Zoom-in">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE713;" FontFamily="MaterialAssets"/>
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar toolbar = new SfToolbar();
        ToolbarInteractionViewModel viewModel = new ToolbarInteractionViewModel();
        toolbar.ItemTouchInteractionCommand = viewModel.ToolbarItemTouchInteractedCommand;
        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
        {
            new SfToolbarItem
            {
                Name = "Zoom-in",
                ToolTipText = "Zoom-in",
                Icon = new FontImageSource { Glyph = "&#xE713;", FontFamily = "MauiMaterialAssets" }
            },
        };
        toolbar.Items = itemCollection;
        this.Content = toolbar;
    }   
}

{% endhighlight %}

{% highlight C# tabtitle="ToolbarInteractionViewModel.cs" %}

public class ToolbarInteractionViewModel
{
    public ICommand ToolbarItemTouchInteractedCommand { get; set; }
    public ToolbarInteractionViewModel()
    {
        this.ToolbarItemTouchInteractedCommand = new Command<ToolbarItemTouchInteractionEventArgs>(ExecuteToolbarItemTouchInteracted, CanExecuteToolbarItemTouchInteracted);
    }
    private bool CanExecuteToolbarItemTouchInteracted(ToolbarItemTouchInteractionEventArgs arg)
    {
        return true;
    }
    private void ExecuteToolbarItemTouchInteracted(ToolbarItemTouchInteractionEventArgs e)
    {
        var toolbarItem = e.ToolbarItem;
        var toolbarItemAction = e.PointerActions;
    }
}


{% endhighlight %}

{% endtabs %}

### Item Long Pressed Command

The [ItemLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ItemLongPressedCommand) will be triggered when you long press the toolbar item and pass the [ToolbarItemLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarItemLongPressedEventArgs.html) as parameter.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<Grid>
<Grid.BindingContext>
    <local:ToolbarInteractionViewModel />
</Grid.BindingContext>
<toolbar:SfToolbar ItemLongPressedCommand="{Binding ToolbarItemLongPressedCommand}"
                    HeightRequest="56"
                    Orientation="Horizontal">
    <toolbar:SfToolbar.Items>
        <toolbar:SfToolbarItem Name="ToolbarItem1" Text="Zoom-in">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE713;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
    </toolbar:SfToolbar.Items>
</toolbar:SfToolbar>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar toolbar = new SfToolbar();
        ToolbarInteractionViewModel viewModel = new ToolbarInteractionViewModel();
        toolbar.ItemLongPressedCommand = viewModel.ToolbarItemLongPressedCommand;
        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
        {
            new SfToolbarItem
            {
                Name = "Zoom-in",
                ToolTipText = "Zoom-in",
                Icon = new FontImageSource { Glyph = "&#xE713;", FontFamily = "MauiMaterialAssets" }
            },
        };
        toolbar.Items = itemCollection;
        this.Content = toolbar;
    }   
}

{% endhighlight %}

{% highlight C# tabtitle="ToolbarInteractionViewModel.cs" %}

public class ToolbarInteractionViewModel
{
    public ICommand ToolbarItemLongPressedCommand { get; set; }
    public ToolbarInteractionViewModel()
    {
        this.ToolbarItemLongPressedCommand = new Command<ToolbarItemLongPressedEventArgs>(ExecuteToolbarItemLongPressed, CanExecuteToolbarItemLongPressed);
    }
    private bool CanExecuteToolbarItemLongPressed(ToolbarItemLongPressedEventArgs arg)
    {
        return true;
    }
    private void ExecuteToolbarItemLongPressed(ToolbarItemLongPressedEventArgs e)
    {
        var toolbarItem = e.ToolbarItem;
    }
}

{% endhighlight %}

{% endtabs %}

### More Button Tapped Command

The [MoreButtonTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreButtonTappedCommand) will be triggered when you tap the more button and pass the [ToolbarMoreButtonTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarMoreButtonTappedEventArgs.html) as parameter.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<Grid>
<Grid.BindingContext>
    <local:ToolbarInteractionViewModel />
</Grid.BindingContext>
<toolbar:SfToolbar x:Name="Toolbar" MoreButtonTappedCommand="{Binding MoreButtonTappedCommand}"
                HeightRequest="56"
                WidthRequest="150"
                Orientation="Horizontal"
                OverflowMode="MoreButton">
    <toolbar:SfToolbar.Items>
        <toolbar:SfToolbarItem Name="ToolbarItem1" Text="Zoom-in">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE713;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
        <toolbar:SfToolbarItem Name="ToolbarItem2" Text="Zoom-out">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE714;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
        <toolbar:SfToolbarItem Name="ToolbarItem3" Text="Search">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE715;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
    </toolbar:SfToolbar.Items>
</toolbar:SfToolbar>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar toolbar = new SfToolbar();
        ToolbarInteractionViewModel viewModel = new ToolbarInteractionViewModel();
        toolbar.MoreButtonTappedCommand = viewModel.MoreButtonTappedCommand;
        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
        {
            new SfToolbarItem
            {
                Name = "Zoom-in",
                ToolTipText = "Zoom-in",
                Icon = new FontImageSource { Glyph = "&#xE713;", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "Zoom-out",
                ToolTipText = "Zoom-out",
                Icon = new FontImageSource { Glyph = "&#xE714;", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "Search",
                ToolTipText = "Search",
                Icon = new FontImageSource { Glyph = "&#xE715;", FontFamily = "MauiMaterialAssets" }
            },
        };
        toolbar.Items = itemCollection;
        this.Content = toolbar;
    }   
}

{% endhighlight %}

{% highlight C# tabtitle="ToolbarInteractionViewModel.cs" %}

public class ToolbarInteractionViewModel
{
    public ICommand MoreButtonTappedCommand { get; set; }
    public ToolbarInteractionViewModel()
    {
        this.MoreButtonTappedCommand = new Command<ToolbarMoreButtonTappedEventArgs>(ExecuteMoreButtonTapped, CanExecuteMoreButtonTapped);
    }
    private bool CanExecuteMoreButtonTapped(ToolbarMoreButtonTappedEventArgs arg)
    {
        return true;
    }
    private void ExecuteMoreButtonTapped(ToolbarMoreButtonTappedEventArgs e)
    {
        var moreItems = e.ToolbarItems;
    }
}

{% endhighlight %}

{% endtabs %}

### More Items Changed Command

The [MoreItemsChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreItemsChangedCommand) will be triggered when the more items are changed and pass the [ToolbarMoreItemsChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarMoreItemsChangedEventArgs.html) as parameter.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<Grid>
<Grid.BindingContext>
    <local:ToolbarInteractionViewModel />
</Grid.BindingContext>
<toolbar:SfToolbar x:Name="toolbar" MoreItemsChangedCommand="{Binding MoreItemsChangedCommand}"
                HeightRequest="56"
                WidthRequest="150"
                Orientation="Horizontal"
                OverflowMode="MoreButton">
    <toolbar:SfToolbar.Items>
        <toolbar:SfToolbarItem Name="ToolbarItem1" Text="Zoom-in">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE713;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
        <toolbar:SfToolbarItem Name="ToolbarItem2" Text="Zoom-out">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE714;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
        <toolbar:SfToolbarItem Name="ToolbarItem3" Text="Search">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE715;" FontFamily="MaterialAssets"/>
            </toolbar:SfToolbarItem.Icon>
        </toolbar:SfToolbarItem>
    </toolbar:SfToolbar.Items>
</toolbar:SfToolbar>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar toolbar = new SfToolbar();
        ToolbarInteractionViewModel viewModel = new ToolbarInteractionViewModel();
        toolbar.MoreItemsChangedCommand = viewModel.MoreItemsChangedCommand;
        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
        {
            new SfToolbarItem
            {
                Name = "Zoom-in",
                ToolTipText = "Zoom-in",
                Icon = new FontImageSource { Glyph = "&#xE713;", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "Zoom-out",
                ToolTipText = "Zoom-out",
                Icon = new FontImageSource { Glyph = "&#xE714;", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "Search",
                ToolTipText = "Search",
                Icon = new FontImageSource { Glyph = "&#xE715;", FontFamily = "MauiMaterialAssets" }
            },
        };
        toolbar.Items = itemCollection;
        this.Content = toolbar;
    }   
}

{% endhighlight %}

{% highlight C# tabtitle="ToolbarInteractionViewModel.cs" %}

public class ToolbarInteractionViewModel
{
    public ICommand MoreItemsChangedCommand { get; set; }
    public ToolbarInteractionViewModel()
    {
        this.MoreItemsChangedCommand = new Command<ToolbarMoreItemsChangedEventArgs>(ExecuteMoreItemsChanged, CanExecuteMoreItemsChanged);
    }
    private bool CanExecuteMoreItemsChanged(ToolbarMoreItemsChangedEventArgs arg)
    {
        return true;
    }
    private void ExecuteMoreItemsChanged(ToolbarMoreItemsChangedEventArgs e)
    {
        var moreItems = e.ToolbarItems;
    }
}

{% endhighlight %}

{% endtabs %}