---
layout: post
title: Custom controls in .NET MAUI Parallax View Control | Syncfusion®
description: Learn about Scrolling support for custom controls support in Syncfusion® .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Scrolling support for custom controls in .NET MAUI Parallax View

The Parallax view supports custom scrollable controls using the [`IParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface. This interface implements the [`ScrollableContentSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_ScrollableContentSize) property and the [`Scrolling`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_Scrolling) event. 

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace ParallaxViewCustomControl
{
    public class CustomListView : ListView, IParallaxView
    {
        public Size ScrollableContentSize { get ; set ; }

        public event EventHandler<ParallaxScrollingEventArgs> Scrolling;
    }
}

{% endhighlight %}                         

## Scrollable ContentSize

The [`ScrollableContentSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_ScrollableContentSize) is the total content size of the scrollable custom control.

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace ParallaxViewCustomControl
{
    public class CustomListView : ListView, IParallaxView
    {
        public Size ScrollableContentSize { get; set; }

        public CustomListView()
        {
            this.ScrollableContentSize = ContentSize; //  Total scrollable size of the custom control
        }
    }
}

{% endhighlight %}

## Scrolling event

The [`Scrolling`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html#Syncfusion_Maui_Core_IParallaxView_Scrolling) event occurs whenever the [`ParallaxScrollingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html) value is set through the scrollable custom control scrolled event.

The [`ParallaxScrollingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html) has the following three arguments:

* [`ScrollX`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html#Syncfusion_Maui_Core_ParallaxScrollingEventArgs_ScrollX): Denotes X position of the finished scroll.

* [`ScrollY`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html#Syncfusion_Maui_Core_ParallaxScrollingEventArgs_ScrollY): Denotes Y position of the finished scroll.

* [`CanAnimate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ParallaxScrollingEventArgs.html#Syncfusion_Maui_Core_ParallaxScrollingEventArgs_CanAnimate): Defines whether to animate the scroll or not.

{% tabs %}

{% highlight xaml %}

<Grid>
    <parallax:SfParallaxView Source="{x:Reference Name = listView}" x:Name="parallaxview">
        <parallax:SfParallaxView.Content>
            <Image x:Name="image" Source="{Binding Image}" BackgroundColor="Transparent" HorizontalOptions="Fill" VerticalOptions="Fill" Aspect="AspectFill" />
        </parallax:SfParallaxView.Content>
    </parallax:SfParallaxView>
    <local:CustomListView x:Name="listView" >
        . . .
    </local:CustomListView>
</Grid>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace ParallaxViewCustomControl
{
    public class CustomListView : ListView, IParallaxView
    {
        public Size ScrollableContentSize { get; set; }

        public event EventHandler<ParallaxScrollingEventArgs>? Scrolling;

        public CustomListView()
        {
            this.Scrolled += CustomListView_Scrolled;
        }

        private void CustomListView_Scrolled(object? sender, ScrolledEventArgs e)
        {
            if (sender is ListView listView && Scrolling != null)
            {
                Scrolling.Invoke(this, new ParallaxScrollingEventArgs(e.ScrollX, e.ScrollY, false));
            }
        }

        protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
        {
            var minimumSize = new Size(40, 40);
            Size request = Size.Zero;

            if (ItemsSource is IList list && HasUnevenRows == false && RowHeight > 0 && !IsGroupingEnabled)
            {
                request = new Size(widthConstraint, list.Count * RowHeight);
            }

            this.ScrollableContentSize = new SizeRequest(request, minimumSize);
            return base.MeasureOverride(widthConstraint, heightConstraint);
        }
    }
}

{% endhighlight %}

{% endtabs %}

By default, the Parallax View control supports [`.NET MAUI ScrollView`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/scrollview) and [Syncfusion ListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html). For custom controls, you need to implement the [`IParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface from Syncfusion.Maui.Core.

You can find the Parallax View control with custom ListView control from this [link](https://github.com/SyncfusionExamples/MAUI-Parallax-View-Sample-Demos).