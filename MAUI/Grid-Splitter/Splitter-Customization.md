---
layout: post
title: Splitter Customization in .NET MAUI Grid Splitter | Syncfusion®
description: Learn how to customize the appearance and behavior of the Syncfusion® .NET MAUI Grid Splitter control.
platform: maui-toolkit
control: SfGridSplitter
documentation: UG
---

# Splitter Customization in .NET MAUI Grid Splitter

The [.NET MAUI Grid Splitter]() control provides several customization options that allow you to modify the layout behavior and appearance of splitter separators. You can control pane arrangement, separator thickness, colors, resize icons, and right-to-left layout behavior.

## Orientation

The `Orientation` property determines how the panes are arranged within the Grid Splitter.

The `GridSplitterOrientation` enum contains the following values:

| Value | Description |
|---------|---------|
| `Horizontal` | Arranges panes side-by-side from left to right. Resizing changes pane widths. |
| `Vertical` | Arranges panes from top to bottom. Resizing changes pane heights. |

### Horizontal orientation

By default, the Grid Splitter uses horizontal orientation.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Orientation="Horizontal">

    <gridSplitter:SplitterPane>
        <Label Text="Navigation Pane" 
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Content Pane"
               VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    Orientation = GridSplitterOrientation.Horizontal
};

SplitterPane navigationPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Navigation Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane contentPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Content Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(navigationPane);
gridSplitter.AddPane(contentPane);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Horizontal Orientation](Images/gridsplitter-horizontalpane.png)

### Vertical orientation

The following example arranges panes vertically in Grid Splitter.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Orientation="Vertical">

    <gridSplitter:SplitterPane>
        <Label Text="Top Pane"
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Bottom Pane"
               VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    Orientation = GridSplitterOrientation.Vertical
};

SplitterPane topPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Top Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane bottomPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Bottom Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(topPane);
gridSplitter.AddPane(bottomPane);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Vertical orientation](Images/gridsplitter-verticalpane.png)

## SeparatorSize

The `SeparatorSize` property specifies the thickness of the separator displayed between adjacent panes. The default value is `8`.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter SeparatorSize="15">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" 
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2"
               VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    SeparatorSize = 15
};

SplitterPane pane1 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
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

![.NET MAUI Grid Splitter Separator Size](Images/gridsplitter-separatorsize.png)

## SeparatorBackground

The `SeparatorBackground` property allows you to customize the appearance of the separator between panes.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter SeparatorBackground="LightBlue">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1"
               VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2"
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    SeparatorBackground = Colors.LightBlue
};

SplitterPane pane1 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
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

![.NET MAUI Grid Splitter Separator Background](Images/gridsplitter-separatorbackground.png)

You can use any solid color, dynamic resource, or theme resource to style the separator.

### Using AppThemeBinding

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter
    SeparatorBackground="{AppThemeBinding Light=#E0E0E0, Dark=#3C3C3C}" />

{% endhighlight %}
{% endtabs %}

## ResizeIconColor

The `ResizeIconColor` property customizes the color of the built-in resize indicator displayed in the separator.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter ResizeIconColor="Blue">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1"
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2"
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    ResizeIconColor = Colors.Blue
};

SplitterPane pane1 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
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

![.NET MAUI Grid Splitter Resize Icon Color](Images/gridsplitter-resizeiconcolor.png)

## ExpandCollapseIconColor

The `ExpandCollapseIconColor` property customizes the color of the expand and collapse icon displayed on collapsible panes.

The icon is displayed only when the associated pane has its `IsCollapsible` property set to `True`.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter ExpandCollapseIconColor="Red">

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Collapsible Pane"
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Content Pane" 
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    ExpandCollapseIconColor = Colors.Red
};

SplitterPane collapsiblePane = new SplitterPane
{
    IsCollapsible = true,
    Content = new Label
    {
        Text = "Collapsible Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane contentPane = new SplitterPane
{
    Content = new Label
    {
        Text = "Content Pane",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(collapsiblePane);
gridSplitter.AddPane(contentPane);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Expand Collapse Icon Color](Images/gridsplitter-expandcollapseiconcolor.png)

## ResizeIconTemplate

The `ResizeIconTemplate` property allows you to replace the default resize icon with custom content.

The template is applied to all separators created by the Grid Splitter.

{% tabs %}
{% highlight c# %}

DataTemplate resizeIconTemplate = new DataTemplate(() =>
{
    return new Image
    {
        Source = "resize_handle.png",
        HeightRequest = 16,
        WidthRequest = 16
    };
});

SfGridSplitter gridSplitter = new SfGridSplitter
{
    SeparatorSize = 15,
};

SplitterPane pane1 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 2",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
gridSplitter.ResizeIconTemplate = resizeIconTemplate;
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Resize Icon Template](Images/gridsplitter-resizeicontemplate.png)

### Custom resize icon using shapes

{% tabs %}
{% highlight c# %}

DataTemplate resizeIconTemplate = new DataTemplate(() =>
{
    return new HorizontalStackLayout
    {
        Spacing = 2,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        Children =
        {
            new BoxView
            {
                WidthRequest = 2,
                HeightRequest = 12,
                Color = Colors.Gray
            },
            new BoxView
            {
                WidthRequest = 2,
                HeightRequest = 12,
                Color = Colors.Gray
            },
            new BoxView
            {
                WidthRequest = 2,
                HeightRequest = 12,
                Color = Colors.Gray
            }
        }
    };
});

SfGridSplitter gridSplitter = new SfGridSplitter
{
    SeparatorSize = 15
};

SplitterPane pane1 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 2",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
gridSplitter.ResizeIconTemplate = resizeIconTemplate;

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter Resize Icon Template using shapes](Images/gridsplitter-resizeicontemplateshape.png)

## Right-to-left (RTL)

The Grid Splitter supports right-to-left layouts through the `FlowDirection` property.

When RTL is enabled:

* Pane arrangement flows from right to left.
* Separator interactions are mirrored automatically.
* Expand and collapse icons are rendered on the opposite side of the separator.
* Resize behavior remains consistent with the application layout direction.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter FlowDirection="RightToLeft">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" 
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2"
               VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    FlowDirection = FlowDirection.RightToLeft
};

SplitterPane pane1 = new SplitterPane
{
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
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

![.NET MAUI Grid Splitter RTL](Images/gridsplitter-rtl.png)

## Combined customization example

The following example demonstrates several customization properties together.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Orientation="Horizontal"
                             SeparatorBackground="#E0E0E0"
                             SeparatorSize="8"
                             ResizeIconColor="#6750A4"
                             ExpandCollapseIconColor="#6750A4">

    <gridSplitter:SplitterPane IsCollapsible="True" 
                               Background="LightBlue">
        <Label Text="Pane 1"
               VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center"/>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane Background="LightGreen">
        <Label Text="Pane 2" 
               VerticalTextAlignment="Center"
               HorizontalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter
{
    Orientation = GridSplitterOrientation.Horizontal,
    SeparatorSize = 8,
    SeparatorBackground = Color.FromArgb("#E0E0E0"),
    ResizeIconColor = Color.FromArgb("#6750A4"),
    ExpandCollapseIconColor = Color.FromArgb("#6750A4")
};

SplitterPane pane1 = new SplitterPane
{
    IsCollapsible = true,
    Background = Colors.LightBlue,
    Content = new Label
    {
        Text = "Pane 1",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane
{
    Background = Colors.LightGreen,
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

![.NET MAUI Grid Splitter Combined Custmization](Images/gridsplitter-combination.png)

In this example, the Grid Splitter uses a custom separator thickness, customized separator appearance, custom icon colors, and pane collapse support to create a personalized splitter layout.