---
layout: post
title: Pane Customization in .NET MAUI Grid Splitter | Syncfusion®
description: Learn how to customize pane sizes using the Syncfusion® .NET MAUI Grid Splitter control for flexible, resizable user interfaces.
platform: MAUI
control: SfGridSplitter
documentation: UG
---

# Pane Customization in .NET MAUI Grid Splitter

The [SplitterPane]() class represents an individual pane within the [SfGridSplitter]() control. Each pane can host custom content and provides several properties to control its appearance and behavior.

The following sections describe the pane customization options available in the Grid Splitter control.

## Content

The `Content` property allows you to display any .NET MAUI view inside a pane. A pane can host controls such as labels, images, layouts, charts, data grids, editors, or any custom view.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane>
        <gridSplitter:SplitterPane.Content>
            <VerticalStackLayout Padding="16" VerticalOptions="Center" HorizontalOptions="Center">
                <Label Text="Customer Details" FontSize="20" FontAttributes="Bold" />
                <Label Text="View and manage customer information." />
            </VerticalStackLayout>
        </gridSplitter:SplitterPane.Content>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <gridSplitter:SplitterPane.Content>
            <VerticalStackLayout Padding="16" VerticalOptions="Center" HorizontalOptions="Center">
                <Label Text="Order Information" FontSize="20" FontAttributes="Bold" />
                <Label Text="Track and manage customer orders." />
            </VerticalStackLayout>
        </gridSplitter:SplitterPane.Content>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.GridSplitter;

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane customerPane = new SplitterPane
{
    Content = new VerticalStackLayout
    {
        Padding = 16,
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Center,
        Children =
        {
            new Label
            {
                Text = "Customer Details",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            },
            new Label
            {
                Text = "View and manage customer information."
            }
        }
    }
};

SplitterPane orderPane = new SplitterPane
{
    Content = new VerticalStackLayout
    {
        Padding = 16,
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Center,
        Children =
        {
            new Label
            {
                Text = "Order Information",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            },
            new Label
            {
                Text = "Track and manage customer orders."
            }
        }
    }
};

gridSplitter.AddPane(customerPane);
gridSplitter.AddPane(orderPane);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Content](Images/gridsplitter-content.png)

## Background

The `Background` property customizes the pane background using a `Brush`.

### Set a solid background color

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane Background="LightBlue">
        <Label Text="Pane Content" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane Background="LightGreen">
        <Label Text="Additional Pane Content" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

gridSplitter.AddPane(new SplitterPane
{
    Background = Colors.LightBlue,
    Content = new Label
    {
        Text = "Pane Content",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});

gridSplitter.AddPane(new SplitterPane
{
    Background = Colors.LightGreen,
    Content = new Label
    {
        Text = "Additional Pane Content",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Content](Images/gridsplitter-background.png)

### Use a gradient background

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane>
        <gridSplitter:SplitterPane.Background>
            <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                <GradientStop Color="#6750A4" Offset="0.0" />
                <GradientStop Color="#D0BCFF" Offset="1.0" />
            </LinearGradientBrush>
        </gridSplitter:SplitterPane.Background>

        <Label Text="Pane 1" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <gridSplitter:SplitterPane.Background>
            <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                <GradientStop Color="#00897B" Offset="0.0" />
                <GradientStop Color="#80CBC4" Offset="1.0" />
            </LinearGradientBrush>
        </gridSplitter:SplitterPane.Background>

        <Label Text="Pane 2" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane pane1 = new SplitterPane
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(1, 1),
        GradientStops =
        {
            new GradientStop
            {
                Color = Color.FromArgb("#6750A4"),
                Offset = 0.0f
            },
            new GradientStop
            {
                Color = Color.FromArgb("#D0BCFF"),
                Offset = 1.0f
            }
        }
    },
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(1, 1),
        GradientStops =
        {
            new GradientStop
            {
                Color = Color.FromArgb("#00897B"),
                Offset = 0.0f
            },
            new GradientStop
            {
                Color = Color.FromArgb("#80CBC4"),
                Offset = 1.0f
            }
        }
    },
    Content = new Label
    {
        Text = "Pane 2",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}
![.NET MAUI Grid Splitter Gradient Background](Images/gridsplitter-lineargradientpane.png)

---

## IsCollapsible

The `IsCollapsible` property determines whether a pane can be expanded or collapsed by the user.

The default value is `true`.

When enabled, an expand/collapse icon is displayed on the associated separator.

### Enable collapse support

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Collapsible Pane" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Additional Collapsible Pane" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane pane1 = new SplitterPane()
{
    IsCollapsible = true,
    Content = new Label
    {
        Text = "Collapsible Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane()
{
    IsCollapsible = true,
    Content = new Label
    {
        Text = "Additional Collapsible Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Collapsible Pane](Images/gridsplitter-collapsiblepane.png)

### Multiple collapsible panes

In this example, the first two panes can be collapsed or expanded through their corresponding separators.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Pane 1" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Pane 2" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane IsCollapsible="False">
        <Label Text="Pane 3" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

gridSplitter.AddPane(new SplitterPane
{
    IsCollapsible = true,
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});

gridSplitter.AddPane(new SplitterPane
{
    IsCollapsible = true,
    Content = new Label
    {
        Text = "Pane 2",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});

gridSplitter.AddPane(new SplitterPane
{
    IsCollapsible = false,
    Content = new Label
    {
        Text = "Pane 3",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Multiple Collapsible Panes](Images/gridsplitter-multiple-collaspible-panaes.png)

---

## IsResizable

The `IsResizable` property controls whether a pane can participate in drag-based resizing.

The default value is `true`.

When this property is set to `false`, the separator associated with the pane ignores resize gestures.

### Disable pane resizing

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane IsResizable="False">
        <Label Text="Pane 1" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane IsResizable="False">
        <Label Text="Pane 2" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

gridSplitter.AddPane(new SplitterPane
{
    IsResizable = false,
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});

gridSplitter.AddPane(new SplitterPane
{
    IsResizable = false,
    Content = new Label
    {
        Text = "Pane 2",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
});
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Resizable Panes](Images/gridsplitter-resizablepane.png)

### Create a fixed navigation pane

The following example shows a non-resizable navigation pane with a resizable content pane.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane IsResizable="False" Background="#ECECEC">
        <Label Text="Navigation" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Content Area" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Details Pane" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane navigationPane = new SplitterPane
{
    IsResizable = false,
    Background = Color.FromArgb("#ECECEC"),
    Content = new Label
    {
        Text = "Navigation",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane contentPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Content Area",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane detailsPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Details Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(navigationPane);
gridSplitter.AddPane(contentPane);
gridSplitter.AddPane(detailsPane);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter fixed and resizable pane](Images/gridsplitter-fixedandresizablepane.png)
This is useful when certain regions must maintain a fixed layout while allowing other panes to resize.

---

## IsCollapsed

The `IsCollapsed` property specifies whether a pane is currently collapsed.

The default value is `false`.

A collapsed pane occupies no layout space and can be expanded later either by user interaction or programmatically.

### Collapse a pane initially

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane IsCollapsed="True">
        <Label Text="Initially Collapsed" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Expandable Pane" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane collapsedPane = new SplitterPane
{
    IsCollapsed = true,
    Content = new Label
    {
        Text = "Initially Collapsed",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane expandablePane = new SplitterPane
{
    Content = new Label
    {
        Text = "Expandable Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(collapsedPane);
gridSplitter.AddPane(expandablePane);
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Collapsed Pane](Images/gridsplitter-collapsedpane.png)

### Collapse and expand panes programmatically

You can collapse or expand panes using the GridSplitter methods.

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout Spacing="12" Padding="16">

    <gridSplitter:SfGridSplitter x:Name="gridSplitter" HeightRequest="300">

        <gridSplitter:SplitterPane>
            <Label Text="Pane 1" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
        </gridSplitter:SplitterPane>

        <gridSplitter:SplitterPane>
            <Label Text="Pane 2" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
        </gridSplitter:SplitterPane>

    </gridSplitter:SfGridSplitter>

    <Button Text="Collapse Pane" Clicked="CollapsePaneClicked" />

    <Button Text="Expand Pane" Clicked="ExpandPaneClicked" />

</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

private async void CollapsePaneClicked(object sender, EventArgs e)
{
    await gridSplitter.CollapsePane(1);
}

private async void ExpandPaneClicked(object sender, EventArgs e)
{
    await gridSplitter.ExpandPane(1);
}

{% endhighlight %}
{% endtabs %}

### Two-way data binding

The `IsCollapsed` property supports two-way binding, allowing the pane state to be synchronized with a view model.

{% tabs %}
{% highlight xaml %}

<Grid RowDefinitions="Auto, *">

    <Switch IsToggled="{Binding IsPaneCollapsed, Mode=TwoWay}" />

    <gridSplitter:SfGridSplitter Grid.Row="1">
        <gridSplitter:SplitterPane IsCollapsible="True" IsCollapsed="{Binding IsPaneCollapsed, Mode=TwoWay}">
            <Label Text="Pane 1" VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
        </gridSplitter:SplitterPane>

        <gridSplitter:SplitterPane>
            <Label Text="Pane 2" VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
        </gridSplitter:SplitterPane>
    </gridSplitter:SfGridSplitter>

</Grid>

{% endhighlight %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ViewModel();

    }
}

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

public class ViewModel : INotifyPropertyChanged
{
    private bool isPaneCollapsed;

    public bool IsPaneCollapsed
    {
        get => isPaneCollapsed;
        set
        {
            if (isPaneCollapsed != value)
            {
                isPaneCollapsed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPaneCollapsed)));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}

{% endhighlight %}
{% endtabs %}

---

## Combined pane customization

The following example demonstrates multiple pane customization options together.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane Background="#E8DEF8" IsCollapsible="True" Size="1*">
        <VerticalStackLayout Padding="16">
            <Label Text="Navigation" FontAttributes="Bold"/>
        </VerticalStackLayout>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane Background="#F7F2FA" IsResizable="True" Size="2*">
        <VerticalStackLayout Padding="16">
            <Label Text="Content Area" FontAttributes="Bold"/>
        </VerticalStackLayout>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane navigationPane = new SplitterPane
{
    Background = Color.FromArgb("#E8DEF8"),
    IsCollapsible = true,
    Size = "1*",
    Content = new VerticalStackLayout
    {
        Padding = 16,
        Children =
        {
            new Label
            {
                Text = "Navigation",
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }
        }
    }
};

SplitterPane contentPane = new SplitterPane
{
    Background = Color.FromArgb("#F7F2FA"),
    IsResizable = true,
    Size = "2*",
    Content = new VerticalStackLayout
    {
        Padding = 16,
        Children =
        {
            new Label
            {
                Text = "Content Area",
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }
        }
    }
};

gridSplitter.AddPane(navigationPane);
gridSplitter.AddPane(contentPane);
Content = gridSplitter;

{% endhighlight %}

{% endtabs %}
![.NET MAUI Grid Splitter Combined Pane](Images/gridsplitter-combinedpane.png)

In this example:

* The first pane uses a custom background color.
* The first pane can be collapsed and expanded.
* The second pane contains custom content.
* Both panes participate in layout sizing through the splitter.
* Users can resize the panes using the separator between them.