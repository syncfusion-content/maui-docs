---
layout: post
title: Custom controls in .NET MAUI Parallax View Control | Syncfusion®
description: Learn about scrolling support for custom controls in Syncfusion<sup>®</sup> .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Scrolling support for custom controls in .NET MAUI Parallax View

The Parallax View supports custom scrollable controls using the [`IParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface. This interface implements the [`ScrollableContentSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_ScrollableContentSize) property and the [`Scrolling`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_Scrolling) event.

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace ParallaxViewCustomControl
{
    public class CustomListView : CollectionView, IParallaxView
    {
        public Size ScrollableContentSize { get; set; }

        public event EventHandler<ParallaxScrollingEventArgs> Scrolling;
    }
}

{% endhighlight %}

## Scrollable ContentSize

The [`ScrollableContentSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_ScrollableContentSize) represents the total content size of the scrollable custom control.

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace ParallaxViewCustomControl
{
    public class CustomListView : CollectionView, IParallaxView
    {
        public Size ScrollableContentSize { get; set; }

        public CustomListView()
        {
            this.ScrollableContentSize = ContentSize; // Total scrollable size of the custom control
        }
    }
}

{% endhighlight %}

## Scrolling event

The [`Scrolling`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_Scrolling) event occurs whenever the [`ParallaxScrollingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html) value is set through the scrollable custom control's scrolled event.

The [`ParallaxScrollingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html) has the following three arguments:

* [`ScrollX`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html#Syncfusion_Maui_Core_ParallaxScrollingEventArgs_ScrollX): Denotes the X position of the finished scroll.

* [`ScrollY`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html#Syncfusion_Maui_Core_ParallaxScrollingEventArgs_ScrollY): Denotes the Y position of the finished scroll.

* [`CanAnimate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html#Syncfusion_Maui_Core_ParallaxScrollingEventArgs_CanAnimate): Defines whether to animate the scroll or not.

{% tabs %}

{% highlight xaml %}

<Grid>
    <parallax:SfParallaxView Source="{x:Reference Name=listView}" x:Name="parallaxview">
        <parallax:SfParallaxView.Content>
            <Image x:Name="image" Source="{Binding Image}" BackgroundColor="Transparent" Aspect="AspectFill" />
        </parallax:SfParallaxView.Content>
    </parallax:SfParallaxView>
    <local:CustomListView x:Name="listView">
        . . .
    </local:CustomListView>
</Grid>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace ParallaxViewCustomControl
{
    public class CustomListView : CollectionView, IParallaxView
    {
        // Creating RowHeight property for fixed item height and to calculate the ScrollableContentSize
        public static readonly BindableProperty RowHeightProperty =
            BindableProperty.Create(nameof(RowHeight), typeof(double), typeof(CustomListView), 0d);

        public double RowHeight
        {
            get => (double)GetValue(RowHeightProperty);
            set => SetValue(RowHeightProperty, value);
        }

        public Size ScrollableContentSize { get; set; }

        public event EventHandler<ParallaxScrollingEventArgs>? Scrolling;

        public CustomListView()
        {
            this.Scrolled += CustomListView_Scrolled;
        }

        private void CustomListView_Scrolled(object? sender, ItemsViewScrolledEventArgs e)
        {
            if (sender is CollectionView collectionView && Scrolling != null)
            {
                Scrolling.Invoke(this, new ParallaxScrollingEventArgs(e.HorizontalOffset, e.VerticalOffset, false));
            }
        }

        protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
        {
            var minimumSize = new Size(40, 40);
            Size request = Size.Zero;

            if (ItemsSource is IList list && RowHeight > 0)
            {
                request = new Size(widthConstraint, list.Count * RowHeight);
            }

            this.ScrollableContentSize = new Size(request.Width, Math.Max(request.Height, minimumSize.Height));
            return base.MeasureOverride(widthConstraint, heightConstraint);
        }
    }
}

{% endhighlight %}

{% endtabs %}

By default, the Parallax View control supports [.NET MAUI ScrollView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/scrollview) and [Syncfusion ListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html). For custom controls, you need to implement the [`IParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface from Syncfusion.Maui.Core.

You can find the Parallax View control with custom ListView control from this [link](https://github.com/SyncfusionExamples/MAUI-Parallax-View-Sample-Demos).