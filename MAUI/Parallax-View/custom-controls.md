---
layout: post
title: Custom controls in .NET MAUI Parallax View Control | Syncfusion
description: Learn here all about Scrolling support for custom controls support in Syncfusion .NET MAUI Parallax View (SfParallaxView) control and more.
platform: .NET MAUI
control: SfParallaxView
documentation: ug
---

# Scrolling support for custom controls in .NET MAUI Parallax View

The Parallax view supports custom scrollable controls using the [`IParallaxView`]() interface. This interface implements the [`ScrollableContentSize`]() property and the [`Scrolling`]() event. 

{% highlight c# %}

        public class CustomListView : ListView, IParallaxView
        {

            public Size ScrollableContentSize { get ; set ; }

            public event EventHandler<ParallaxScrollingEventArgs> Scrolling;

        }

{% endhighlight %}                         

## Scrollable ContentSize

The [`ScrollableContentSize`]() is the total content size of the scrollable custom control.

{% highlight c# %}

    public class CustomListView : ListView, IParallaxView

    {
        public Size ScrollableContentSize { get; set; }
        public CustomListView()
        {
            this.ScrollableContentSize = ContentSize; //  Total scrollable size of the custom control
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
                    <Image x:Name="image" BackgroundColor="Transparent" HorizontalOptions="Fill" VerticalOptions="Fill" Aspect="AspectFill" />
                </parallax:SfParallaxView.Content>
            </parallax:SfParallaxView>
            <local:CustomListView x:Name="listView" >
                                  
                   . . .

            </local:CustomListView>
            </Grid>

{% endhighlight %}

{% highlight c# %}

          public class CustomListView : ListView, IParallaxView
            {
                public ListViewScrollingEventArgs scrollingEventArgs;
                internal event EventHandler<ListViewScrollingEventArgs> CustomListViewScrolling;

                private Size scrollableContentSize = new Size();
                public Size ScrollableContentSize
                {
                    get
                    {
                        return this.scrollableContentSize;
                    }
                    set
                    {
                        this.scrollableContentSize = value;
                        OnPropertyChanged("ScrollableContentSize");
                    }
                }

                public event EventHandler<ParallaxScrollingEventArgs> Scrolling;

                protected virtual void OnScrollChanged(ParallaxScrollingEventArgs e)
                {
                    Scrolling?.Invoke(this, e);
                }


                public CustomListView()
                {
                    this.scrollingEventArgs = new ListViewScrollingEventArgs(); // Need to initiate event args
                    CustomListViewScrolling += CustomListView_CustomListViewScrolling; // Need to invoke custom scroll event
                }

                private void CustomListView_CustomListViewScrolling(object sender, ListViewScrollingEventArgs e)
                {
                    OnScrollChanged(new ParallaxScrollingEventArgs(e.ScrollX, e.ScrollY, false));
                }
            }

            public class ListViewScrollingEventArgs : EventArgs
            {
                /// <summary>
                /// Initializes a new instance of the <see cref="ListViewScrollingEventArgs" /> class.
                /// </summary>
                public ListViewScrollingEventArgs()
                {
                }

                /// <summary>
                /// Gets or sets ScrollX value.
                /// </summary>
                public double ScrollX { get; set; }

                /// <summary>
                /// Gets or sets ScrollY value.
                /// </summary>
                public double ScrollY { get; set; }
            
            }

{% endhighlight %}

{% endtabs %}

By default, ParallaxView control supports [`.NET MAUI ScrollView`](). For custom controls you need to implement the [`IParallaxView`]() interface.

You can achieve the parallax scroll support to the custom controls using the native renderers to calculate the total size of the scrollable content. Refer to this [KB article]() for more details.