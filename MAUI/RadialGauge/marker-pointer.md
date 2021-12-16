---
layout: post
title: Marker Pointer in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Marker Pointer feature of Syncfusion .NET MAUI Radial Gauge control with image, text pointer support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Marker Pointer in .NET MAUI Radial Gauge

Indicate current values by using different types of marker pointers. You can change the marker shape type using the [`MarkerType`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_MarkerType) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="60" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 60;
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Default Marker Pointer](images/marker-pointers/maui-radial-gauge-default-marker-pointer.png)

Gauge supports the following types of shapes:

* Circle
* Diamond
* Inverted triangle
* Rectangle
* Triangle

![.NET MAUI Radial Gauge Markers](images/marker-pointers/maui-radial-gauge-markers.png)

## Marker customization

The marker pointer can be customized using the following properties:

* [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_Fill) – Allows you to customize the marker color.
* [`MarkerHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_MarkerHeight) – Allows you to specify the marker height.
* [`MarkerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_MarkerWidth) – Allows you to specify the marker width.
* [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_Stroke) – Allows you to specify the border color for the marker.
* [`BorderWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_BorderWidth) –  Allows you to specify the border width of the marker.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="60"
                                     MarkerHeight="30"
                                     MarkerWidth="30"
                                     Stroke="Black"
                                     BorderWidth="3"
                                     MarkerType="Circle"
                                     Fill="LightBlue"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 60;
markerPointer.MarkerHeight = 30;
markerPointer.MarkerWidth = 30;
markerPointer.Stroke = Colors.Black;
markerPointer.BorderWidth = 3;
markerPointer.MarkerType = MarkerType.Circle;
markerPointer.Fill = new SolidColorBrush(Colors.LightBlue);
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Custom Marker Pointer](images/marker-pointers/maui-radial-gauge-custom-marker-pointer.png)

## Marker position customization

The marker pointer can be moved near or far from its actual position using the [`MarkerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_MarkerOffset) and [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_OffsetUnit) properties. 

When you set [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_OffsetUnit) to pixel, the marker pointer will be moved based on the pixel value. If you set [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_OffsetUnit) to factor, then provided factor will be multiplied with the axis radius value, and then the pointer will be moved to corresponding value. The default value of [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html#Syncfusion_Maui_Gauges_MarkerPointer_OffsetUnit) is [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="60"
                                     MarkerOffset="-18"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 60;
markerPointer.MarkerOffset = -18;
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Marker Offset](images/marker-pointers/maui-radial-gauge-marker-offset.png)

## Custom marker pointer

You can add customized view to denote the current pointer value instead of in-built marker shape. It can be achieved by setting the `MarkerTemplate` property.

{% tabs %}

{% highlight xaml %}

 <ContentPage.Resources>
            <DataTemplate x:Key="dataTemplate1">
                <Grid HeightRequest="{Binding MarkerHeight}"
                      WidthRequest="{Binding MarkerWidth}" >
                    <Ellipse  Fill="{Binding Fill}"
                              Stroke="{Binding Stroke}"
                              StrokeThickness="1" />
                    <Label FontFamily="FontGaugeIcons" 
                           Text="&#xe701;" TextColor="White"
                           FontSize="14"
                           HorizontalOptions="Center"
                           HorizontalTextAlignment="Center"
                           VerticalOptions="Center"
                           VerticalTextAlignment="Center"/>
                </Grid>
            </DataTemplate>

            <DataTemplate x:Key="dataTemplate2">
                <Grid HeightRequest="{Binding MarkerHeight}" 
                      WidthRequest="{Binding MarkerWidth}" >
                    <Ellipse  Fill="{Binding Fill}"
                              Stroke="{Binding Stroke}"
                              StrokeThickness="1" />
                    <Label FontFamily="FontGaugeIcons"  
                           Text="&#xe700;" TextColor="White"
                           FontSize="14"
                           HorizontalOptions="Center"
                           HorizontalTextAlignment="Center"
                           VerticalOptions="Center"
                           VerticalTextAlignment="Center"/>
                </Grid>
            </DataTemplate>
            
        </ContentPage.Resources>
        <gauge:SfRadialGauge x:Name="gauge">
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis x:Name="radialAxis"
                                  StartAngle="270"
                                  EndAngle="270"
                                  Minimum="0"
                                  Maximum="24"
                                  Interval="6"
                                  MinorTicksPerInterval="5"
                                  ShowFirstLabel="False">
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle Fill="#e1f5fe" Thickness="0.03" ThicknessUnit="Factor"/>
                    </gauge:RadialAxis.AxisLineStyle>

                    <gauge:RadialAxis.MajorTickStyle>
                        <gauge:RadialTickStyle StrokeThickness="2"/>
                    </gauge:RadialAxis.MajorTickStyle>

                    <gauge:RadialAxis.Pointers>
                        <gauge:MarkerPointer x:Name="startPointer"
                                             Value="20"
                                             IsInteractive="True"
                                             Fill="#2194f3"
                                             MarkerHeight="30"
                                             MarkerWidth="30"
                                             MarkerTemplate="{StaticResource dataTemplate1}"/>
                        <gauge:MarkerPointer x:Name="endPointer"
                                             IsInteractive="True"
                                             Value="6"
                                             MarkerHeight="30"
                                             MarkerWidth="30"
                                             Fill="#2194f3"
                                             Stroke="LightGray"
                                             MarkerTemplate="{StaticResource dataTemplate2}"/>
                    </gauge:RadialAxis.Pointers>

                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

 SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.StartAngle = 270;
            radialAxis.EndAngle = 270;
            radialAxis.Minimum = 0;
            radialAxis.Maximum = 24;
            radialAxis.Interval = 6;
            radialAxis.MinorTicksPerInterval = 5;
            radialAxis.ShowFirstLabel = false;
            sfRadialGauge.Axes.Add(radialAxis);

            radialAxis.AxisLineStyle = new RadialLineStyle()
            {
                Fill=new SolidColorBrush(Color.FromHex("e1f5fe")),
                Thickness=0.03,
                ThicknessUnit=SizeUnit.Factor
            };

            radialAxis.MajorTickStyle = new RadialTickStyle()
            {
                StrokeThickness=2
            };

            MarkerPointer markerPointer = new MarkerPointer();
            markerPointer.Value = 20;
            markerPointer.IsInteractive = true;
            markerPointer.Fill = new SolidColorBrush(Color.FromHex("2194f3"));
            markerPointer.MarkerHeight = 30;
            markerPointer.MarkerWidth = 30;
            markerPointer.MarkerTemplate = this.Resources["dataTemplate1"] as DataTemplate;
            radialAxis.Pointers.Add(markerPointer);

            markerPointer = new MarkerPointer();
            markerPointer.Value = 6;
            markerPointer.IsInteractive = true;
            markerPointer.Fill = new SolidColorBrush(Color.FromHex("2194f3"));
            markerPointer.MarkerHeight = 30;
            markerPointer.MarkerWidth = 30;
            markerPointer.MarkerTemplate = this.Resources["dataTemplate2"] as DataTemplate;
            radialAxis.Pointers.Add(markerPointer);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Custom Marker Pointer](images/marker-pointers/maui-radial-gauge-marker-template-pointer.png)

N> If you set both MarkerTemplate and MarkerType in the MarkerPointer, MarkerTemplate will be first priority for pointer. 
