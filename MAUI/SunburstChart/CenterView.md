---
layout: post
title: CenterView in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains about how to add center view in Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Center View in .NET MAUI Sunburst Chart 

Any view can be added to the center of the sunburst chart using the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_CenterView) property of [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html). The view placed in the center of the chart is useful for sharing additional information about the sunburst chart.The binding context of the CenterView will be the SfSunburstChart class.

## CenterHoleSize

The [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_CenterHoleSize) property of SfSunburstChart is used to get the diameter value of the center hole. Using the CenterHoleSize, we can protect the view in the sunburst chart center from overlapping with the segments.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart.CenterView>
    <Border x:Name="border" HeightRequest="{Binding CenterHoleSize}" 
            WidthRequest="{Binding CenterHoleSize}" BackgroundColor="GhostWhite">
        <Border.StrokeShape>
            <RoundRectangle CornerRadius="{Binding CenterHoleSize,Converter={StaticResource cornerRadius}}"/>
        </Border.StrokeShape>
        <Border.Shadow>
            <Shadow Brush="Black" Opacity="0.5" 
                    Radius="50"/>
        </Border.Shadow>
        <VerticalStackLayout WidthRequest="{Binding CenterHoleSize,Converter={StaticResource cornerRadius}}"
                             HorizontalOptions="Center" VerticalOptions="Center">
            <Grid HorizontalOptions="Center">
                <Path Data="{StaticResource PathData}" Fill="Black"/>
            </Grid>
            <Label LineBreakMode="WordWrap" WidthRequest="{Binding CenterHoleSize,Converter={StaticResource cornerRadius}}" 
                   Text="Behind the Bricks" TextColor="Black" FontSize="12" Padding="0,5,0,0"
                   VerticalTextAlignment="Center" HorizontalTextAlignment="Center" FontFamily="Verdana"
                   HorizontalOptions="CenterAndExpand"/> 
        </VerticalStackLayout>
    </Border>
</sunburst:SfSunburstChart.CenterView>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .      
RoundRectangle roundRectangle = new RoundRectangle();
roundRectangle.SetBinding(RoundRectangle.CornerRadiusProperty, "CenterHoleSize", converter: sunburstChart.Resources["cornerRadius"] as IValueConverter);

Label label = new Label()
{
    Text = "Behind the Bricks",
    LineBreakMode = LineBreakMode.WordWrap,
    HorizontalTextAlignment = TextAlignment.Center,
    VerticalTextAlignment = TextAlignment.Center,
    FontSize = 12,
    Padding = new Thickness(0, 5, 0, 0),
    FontFamily = "Verdana",
    TextColor = Colors.Black
};

Path path = new Path()
{
    Data = viewModel.Data,
    Fill = Brush.Black
};

Grid grid = new Grid()
{
    HorizontalOptions = LayoutOptions.Center
};
grid.Children.Add(path);

VerticalStackLayout views = new VerticalStackLayout()
{
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center
};
views.SetBinding(WidthRequestProperty, "CenterHoleSize", converter: sunburstChart.Resources["cornerRadius"] as IValueConverter);
views.Children.Add(grid);
views.Children.Add(label);

Border border = new Border()
{
    BackgroundColor = Colors.GhostWhite,
    StrokeShape = roundRectangle,
    Shadow = new Shadow { Radius = 50, Brush = Brush.Black, Opacity = 0.5f }
};
border.SetBinding(HeightRequestProperty, "CenterHoleSize");
border.SetBinding(WidthRequestProperty, "CenterHoleSize");

border.Content = views;
sunburst.CenterView = border;

{% endhighlight %}

{% endtabs %}

![Center view in MAUI Sunburst Chart.](Center_view_images/maui_centre_view_ouput_image.png)