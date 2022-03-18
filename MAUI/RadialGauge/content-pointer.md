---
layout: post
title: Content Pointer in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Content Pointer feature of Syncfusion .NET MAUI Radial Gauge control with image, text pointer support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Content Pointers in .NET MAUI Radial Gauge

The [`ContentPointer`]() in [`SfRadialGauge`]() allows to use any .NET MAUI content as pointer. The following code sample uses a [`Ellipse`]() and [`Label`]() as content pointer.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
                <gauge:SfRadialGauge.Axes>
                    <gauge:RadialAxis >
                        <gauge:RadialAxis.Pointers>
                            <gauge:ContentPointer  Value="45">
                                <gauge:ContentPointer.Content>
                                    <Grid HeightRequest="37" WidthRequest="37" >
                                        <RoundRectangle  Fill="White"
                                                         CornerRadius="8"
                                                         Stroke="Black" StrokeThickness="2" />
                                        <VerticalStackLayout>
                                            <Image Source="sun.png" HeightRequest="20" WidthRequest="20"
                                                   HorizontalOptions="Center"/>
                                            <Label Text="45°F" HorizontalOptions="Center"
                                                   TextColor="Black" FontAttributes="Bold"
                                                   FontSize="10"/>
                                        </VerticalStackLayout>
                                    </Grid>
                                </gauge:ContentPointer.Content>
                            </gauge:ContentPointer>
                        </gauge:RadialAxis.Pointers>
                    </gauge:RadialAxis>
                </gauge:SfRadialGauge.Axes>
            </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

        RadialAxis radialAxis = new RadialAxis();
        sfRadialGauge.Axes.Add(radialAxis);

        ContentPointer pointer = new ContentPointer();
        pointer.Value = 45;
        Grid grid = new Grid();
        grid.HeightRequest = 37;
        grid.WidthRequest = 37;
        grid.Children.Add(new RoundRectangle()
        {
            Fill = new SolidColorBrush(Colors.White),
            CornerRadius = 8,
            Stroke = new SolidColorBrush(Colors.Black),
            StrokeThickness = 2,
        });
        VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
        verticalStackLayout.Children.Add(new Image()
        {
            Source = "sun.png",
            HorizontalOptions=LayoutOptions.Center,
            HeightRequest = 20,
            WidthRequest = 20,
        });
        verticalStackLayout.Children.Add(new Label()
        {
            Text = "45°F",
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.Black,
            FontAttributes = FontAttributes.Bold,
            FontSize = 10
        });
        grid.Children.Add(verticalStackLayout);
        pointer.Content = grid;
        radialAxis.Pointers.Add(pointer);

        this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Content Pointer](images/marker-pointers/maui-radial-gauge-content-pointer.png)

## Position customization

The content pointer can be moved near or far from its actual position using the [`Offset`]() and [`OffsetUnit`]() properties.

When you set [`OffsetUnit`]() to logical pixel, then the content pointer will be moved based on the logical pixel value. If you set [`OffsetUnit`]() to factor, then provided factor will be multiplied with the axis radius value, and then the pointer will be moved to corresponding value. The default value of [`OffsetUnit`]() is [`SizeUnit.Pixel`]().

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
                <gauge:SfRadialGauge.Axes>
                    <gauge:RadialAxis >
                        <gauge:RadialAxis.Pointers>
                            <gauge:ContentPointer  Value="45" Offset="-20">
                                <gauge:ContentPointer.Content>
                                    <Grid HeightRequest="37" WidthRequest="37" >
                                        <RoundRectangle  Fill="White"
                                                         CornerRadius="8"
                                                         Stroke="Black" StrokeThickness="2" />
                                        <VerticalStackLayout>
                                            <Image Source="sun.png" HeightRequest="20" WidthRequest="20"
                                                   HorizontalOptions="Center"/>
                                            <Label Text="45°F" HorizontalOptions="Center"
                                                   TextColor="Black" FontAttributes="Bold"
                                                   FontSize="10"/>
                                        </VerticalStackLayout>
                                    </Grid>
                                </gauge:ContentPointer.Content>
                            </gauge:ContentPointer>
                        </gauge:RadialAxis.Pointers>
                    </gauge:RadialAxis>
                </gauge:SfRadialGauge.Axes>
            </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

        RadialAxis radialAxis = new RadialAxis();
        sfRadialGauge.Axes.Add(radialAxis);

        ContentPointer pointer = new ContentPointer();
        pointer.Value = 45;
        pointer.Offset = -20;        
        Grid grid = new Grid();
        grid.HeightRequest = 37;
        grid.WidthRequest = 37;
        grid.Children.Add(new RoundRectangle()
        {
            Fill = new SolidColorBrush(Colors.White),
            CornerRadius = 8,
            Stroke = new SolidColorBrush(Colors.Black),
            StrokeThickness = 2,
        });
        VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
        verticalStackLayout.Children.Add(new Image()
        {
            Source = "sun.png",
            HorizontalOptions=LayoutOptions.Center,
            HeightRequest = 20,
            WidthRequest = 20,
        });
        verticalStackLayout.Children.Add(new Label()
        {
            Text = "45°F",
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.Black,
            FontAttributes = FontAttributes.Bold,
            FontSize = 10
        });
        grid.Children.Add(verticalStackLayout);
        pointer.Content = grid;
        radialAxis.Pointers.Add(pointer);

        this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Content Pointer](images/marker-pointers/maui-radial-gauge-content-pointer_offset.png)

