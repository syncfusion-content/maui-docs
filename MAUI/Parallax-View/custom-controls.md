---
layout: post
title: Custom controls in .NET MAUI Parallax View Control | Syncfusion
description: Learn about Scrolling support for custom controls support in Syncfusion .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Scrolling support for custom controls in .NET MAUI Parallax View

The Parallax view supports custom scrollable controls using the [`IParallaxView`]() interface. This interface implements the [`ScrollableContentSize`]() property and the [`Scrolling`]() event. 

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

The [`ScrollableContentSize`]() is the total content size of the scrollable custom control.

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

The [`Scrolling`]() event occurs whenever the [`ParallaxScrollingEventArgs`]() value is set through the scrollable custom control scrolled event.

The [`ParallaxScrollingEventArgs`]() has the following three arguments:

* [`ScrollX`](): Denotes X position of the finished scroll.

* [`ScrollY`](): Denotes Y position of the finished scroll.

* [`CanAnimate`](): Defines whether to animate the scroll or not.

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

By default, the Parallax View control supports [`.NET MAUI ScrollView`]() and [Syncfusion ListView](). For custom controls, you need to implement the [`IParallaxView`]() interface from Syncfusion.Maui.Core.

Refer to this [sample]() for Parallax View control with custom control(ListView).