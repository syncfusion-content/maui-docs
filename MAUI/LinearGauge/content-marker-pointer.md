---
layout: post
title: Content Marker Pointer in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Content Marker Pointer of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Content Marker Pointer in .NET MAUI Linear Gauge (SfLinearGauge)

The [`LinearContentPointer`]() in [`SfLinearGauge`]() allows to use any .NET MAUI content as marker pointer. The following code sample uses a [`Image`]() as marker pointer.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearContentPointer Value="50">
                        <gauge:LinearContentPointer.Content>
                            <Image Source="pin.png" HeightRequest="20" WidthRequest="20"/>
                        </gauge:LinearContentPointer.Content>
                    </gauge:LinearContentPointer>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		LinearContentPointer contentPointer = new LinearContentPointer();
		contentPointer.Value = 50;
		contentPointer.Content = new Image() { Source = "pin.png", HeightRequest = 20, WidthRequest = 20 };
		gauge.MarkerPointers.Add(contentPointer);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Initialize linear gauge for content pointer](images/content-pointer/default_content_pointer.png)

## Change marker alignment

The content marker pointer's alignment can be changed by the [`Alignment`]() property of [`LinearContentPointer`](). The available marker positions are `Start`, `End`, and `Center`. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearContentPointer Value="50" Alignment="End">
                        <gauge:LinearContentPointer.Content>
                            <Grid HeightRequest="25" WidthRequest="25">
                                <RoundRectangle CornerRadius="5" Fill="#ff0074E3"/>
                                <Label Text="50" HorizontalOptions="Center"
                                   VerticalOptions="Center" TextColor="White"/>
                            </Grid>
                        </gauge:LinearContentPointer.Content>
                    </gauge:LinearContentPointer>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		Grid views = new Grid() { HeightRequest = 25, WidthRequest = 25 };
		views.Add(new RoundRectangle()
		{
			Fill = new SolidColorBrush(Color.FromArgb("#ff0074E3")),
			CornerRadius = 5
		});
		views.Add(new Label()
		{
			Text = "50",
			TextColor = Colors.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		});
		LinearContentPointer contentPointer = new LinearContentPointer();
		contentPointer.Value = 50;
		contentPointer.Alignment = GaugeAlignment.End;
		contentPointer.Content = views;
		gauge.MarkerPointers.Add(contentPointer);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize size of content pointer](images/content-pointer/content_alignment.png)

## Change the position

By default, the shape pointer is positioned `Outside` the scale. This position can be changed by the [`Position`]() property of pointer. It is possible to position the shape pointer `Inside`, `Cross`, or `Outside` the axis. The following code sample demonstrates how to change the shape pointer position to `Cross` the scale. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearContentPointer Value="50" Position="Cross">
                        <gauge:LinearContentPointer.Content>
                            <Grid HeightRequest="25" WidthRequest="25">
                                <RoundRectangle CornerRadius="5" Fill="#ff0074E3"/>
                                <Label Text="50" HorizontalOptions="Center"
                                   VerticalOptions="Center" TextColor="White"/>
                            </Grid>
                        </gauge:LinearContentPointer.Content>
                    </gauge:LinearContentPointer>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		Grid views = new Grid() { HeightRequest = 25, WidthRequest = 25 };
		views.Add(new RoundRectangle()
		{
			Fill = new SolidColorBrush(Color.FromArgb("#ff0074E3")),
			CornerRadius = 5
		});
		views.Add(new Label()
		{
			Text = "50",
			TextColor = Colors.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		});
		LinearContentPointer contentPointer = new LinearContentPointer();
		contentPointer.Value = 50;
		contentPointer.Position = GaugeElementPosition.Cross;
		contentPointer.Content = views;
		gauge.MarkerPointers.Add(contentPointer);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change content pointer position](images/content-pointer/content_pointer_position.png)

## Change the offset

In addition to position the content marker pointer, it is also possible to change the offset of the shape pointer. The [`OffsetX`]() and [`OffsetY`]() are the distance from the axis. The cross positioned elements will not get affected by the [`OffsetX`]() and [`OffsetY`]() values. The following code sample demonstrates how to change the offset value of the shape pointer. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearContentPointer Value="50" OffsetY="-5">
                        <gauge:LinearContentPointer.Content>
                            <Grid HeightRequest="25" WidthRequest="25">
                                <RoundRectangle CornerRadius="5" Fill="#ff0074E3"/>
                                <Label Text="50" HorizontalOptions="Center"
                                   VerticalOptions="Center" TextColor="White"/>
                            </Grid>
                        </gauge:LinearContentPointer.Content>
                    </gauge:LinearContentPointer>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		Grid views = new Grid() { HeightRequest = 25, WidthRequest = 25 };
		views.Add(new RoundRectangle()
		{
			Fill = new SolidColorBrush(Color.FromArgb("#ff0074E3")),
			CornerRadius = 5
		});
		views.Add(new Label()
		{
			Text = "50",
			TextColor = Colors.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		});
		LinearContentPointer contentPointer = new LinearContentPointer();
		contentPointer.Value = 50;
		contentPointer.OffsetY = -5;
		contentPointer.Content = views;
		gauge.MarkerPointers.Add(contentPointer);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize linear gauge bar pointer offset](images/content-pointer/content_pointer_offset.png)
