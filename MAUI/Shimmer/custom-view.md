---
layout: post
title: Custom View for .NET MAUI Shimmer control | Syncfusion
description: Learn here all about the custom view support in Syncfusion .NET MAUI Shimmer (SfShimmer) control and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Custom view of .NET MAUI Shimmer (SfShimmer)

The `CustomView` property of the [SfShimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) can be used to create your shimmer view. The below code demonstrates how to customize the shimmer view using the .NET MAUI framework elements by `CustomView`.

{% tabs %}

{% highlight xaml %} 

        <shimmer:SfShimmer>
            <shimmer:SfShimmer.CustomView>
                <Grid
                    Padding="10"
                    ColumnSpacing="15"
                    RowSpacing="10">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="Auto" />

                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="Auto" />

                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="Auto" />

                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="Auto" />

                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="Auto" />

                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="Auto" />
                    </Grid.RowDefinitions>

                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="Auto" />
                        <ColumnDefinition Width="Auto" />
                    </Grid.ColumnDefinitions>
                    
                    <BoxView BackgroundColor="Gray"
                            Grid.Row="0"
                            Grid.ColumnSpan="2"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="280" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="1"
                            Grid.ColumnSpan="2"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="260" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="2"
                            Grid.RowSpan="8" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="2"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="190" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="3"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="190" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="4"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="170" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="5"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="190" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="6"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="150" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="7"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="160" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="8"
                            Grid.Column="1"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="175" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="10"
                            Grid.RowSpan="2"
                            Grid.Column="1"
                            Margin="0,5,0,0" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="10"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="160" />

                    <BoxView BackgroundColor="Gray"
                            Grid.Row="11"
                            HeightRequest="10"
                            HorizontalOptions="Start"
                            VerticalOptions="Start"
                            WidthRequest="175" />
                </Grid>
            </shimmer:SfShimmer.CustomView>
        </shimmer:SfShimmer>

{% endhighlight %}

{% highlight C# %} 

    SfShimmer shimmer = new SfShimmer();
        this.Content = shimmer;
        Grid grid = new Grid
        {
            Padding = 10,
            ColumnSpacing = 15,
            RowSpacing = 10,
            VerticalOptions = LayoutOptions.Fill,
            RowDefinitions = new RowDefinitionCollection()
            {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto }
            },

            ColumnDefinitions = new ColumnDefinitionCollection()
            {
                new ColumnDefinition { Width = GridLength.Auto},
                new ColumnDefinition { Width = GridLength.Auto},
            }
        };

        var boxView1 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 280,
            HeightRequest = 10
        };

        var boxView2 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 260,
            HeightRequest = 10
        };

        var boxView3 = new BoxView
        {
            BackgroundColor = Colors.Gray,
        };

        var boxView4 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 190,
            HeightRequest = 10
        };

        var boxView5 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 190,
            HeightRequest = 10
        };

        var boxView6 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 170,
            HeightRequest = 10
        };

        var boxView7 = new BoxView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            BackgroundColor = Colors.Gray,
            WidthRequest = 190,
            HeightRequest = 10

        };
        var boxView8 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 150,
            HeightRequest = 10
            
        };

        var boxView9 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 160,
            HeightRequest = 10
        };

        var boxView10 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 175,
            HeightRequest = 10
        };

        var boxView11 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            Margin = new Thickness(0, 5, 0, 0)
        };

        var boxView12 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 160,
            HeightRequest = 10
        };

        var boxView13 = new BoxView
        {
            BackgroundColor = Colors.Gray,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 175,
            HeightRequest = 10
        };

        grid.Add(boxView1, 0, 0);
        Grid.SetColumnSpan(boxView1, 2);

        grid.Add(boxView2, 0, 1);
        Grid.SetColumnSpan(boxView2, 2);

        grid.Add(boxView3, 0, 2);
        Grid.SetRowSpan(boxView3, 8);

        grid.Add(boxView4, 1, 2);

        grid.Add(boxView5, 1, 3);

        grid.Add(boxView6, 1, 4);

        grid.Add(boxView7, 1, 5);

        grid.Add(boxView8, 1, 6);

        grid.Add(boxView9, 1, 7);

        grid.Add(boxView10, 1, 8);

        grid.Add(boxView11, 1, 10);
        Grid.SetRowSpan(boxView11, 2);

        grid.Add(boxView12, 0, 10);

        grid.Add(boxView13, 0, 11);

        shimmer.CustomView = grid;

{% endhighlight %}
{% endtabs %}

![Shimmer Custom view in .NET MAUI.](images/customview/maui-custom-view.gif)

## Shimmer view

[ShimmerView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerView.html) can be used to customize the custom view with different shape by using [ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerView.html#Syncfusion_Maui_Shimmer_ShimmerView_ShapeType). The `ShimmerView` is available in three different shape types such as Circle, Rectangle, and RoundedRectangle. By default, the shape type is [Rectangle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerShapeType.html#Syncfusion_Maui_Shimmer_ShimmerShapeType_Rectangle).

{% tabs %} 

{% highlight xaml %} 

        <shimmer:SfShimmer>
        <shimmer:SfShimmer.CustomView>
            <Grid Padding="10"
                      ColumnSpacing="15"
                      RowSpacing="10">
                <Grid.RowDefinitions>
                    <RowDefinition Height="10" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto" />
                    <ColumnDefinition Width="Auto" />
                </Grid.ColumnDefinitions>

                <shimmer:ShimmerView Grid.Row="0"
                                         Grid.ColumnSpan="2"
                                         HorizontalOptions="Start"
                                         WidthRequest="300" />

                <shimmer:ShimmerView Grid.Row="1"
                                         Grid.ColumnSpan="2"
                                         HorizontalOptions="Start"
                                         WidthRequest="250" />

                <shimmer:ShimmerView Grid.Row="2"
                                         Grid.ColumnSpan="2"
                                         HeightRequest="10"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="280" />

                <shimmer:ShimmerView Grid.Row="3"
                                         Grid.ColumnSpan="2"
                                         HeightRequest="10"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="260" />

                <shimmer:ShimmerView Grid.Row="5"
                                     Grid.RowSpan="8"
                                     ShapeType="Circle"/>

                <shimmer:ShimmerView Grid.Row="5"
                                     Grid.Column="1"
                                     HeightRequest="10"
                                     ShapeType="Rectangle"
                                     HorizontalOptions="Start"
                                     VerticalOptions="Start"
                                     WidthRequest="180" />

                <shimmer:ShimmerView Grid.Row="6"
                                         Grid.Column="1"
                                         HeightRequest="10"
                                     ShapeType="Rectangle"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="190" />

                <shimmer:ShimmerView Grid.Row="7"
                                         Grid.Column="1"
                                     ShapeType="Rectangle"
                                         HeightRequest="10"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="170" />

                <shimmer:ShimmerView Grid.Row="8"
                                         Grid.Column="1"
                                     ShapeType="Rectangle"
                                         HeightRequest="10"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="180" />

                <shimmer:ShimmerView Grid.Row="9"
                                     Grid.Column="1"
                                     ShapeType="Rectangle"
                                     HeightRequest="10"
                                     HorizontalOptions="Start"
                                     VerticalOptions="Start"
                                     WidthRequest="150" />

                <shimmer:ShimmerView Grid.Row="10"
                                     Grid.Column="1"
                                     HeightRequest="10"
                                     ShapeType="Rectangle"
                                     HorizontalOptions="Start"
                                     VerticalOptions="Start"
                                     WidthRequest="160" />

                <shimmer:ShimmerView Grid.Row="11"
                                         Grid.Column="1"
                                         HeightRequest="10"
                                     ShapeType="Rectangle"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="175" />

                <shimmer:ShimmerView Grid.Row="13"
                                     Grid.RowSpan="3"
                                     Grid.Column="1"
                                     ShapeType="Rectangle"
                                     Margin="0,5,0,0" />

                <shimmer:ShimmerView Grid.Row="13"
                                     ShapeType="RoundedRectangle"
                                     HeightRequest="10"
                                     HorizontalOptions="Start"
                                     VerticalOptions="Start"
                                     WidthRequest="150" />

                <shimmer:ShimmerView Grid.Row="14"
                                     HeightRequest="10"
                                     ShapeType="RoundedRectangle"
                                     HorizontalOptions="Start"
                                     VerticalOptions="Start"
                                     WidthRequest="160" />

                <shimmer:ShimmerView Grid.Row="15"
                                     ShapeType="RoundedRectangle"
                                         HeightRequest="10"
                                         HorizontalOptions="Start"
                                         VerticalOptions="Start"
                                         WidthRequest="175" />
            </Grid>
        </shimmer:SfShimmer.CustomView>
    </shimmer:SfShimmer>

{% endhighlight %}

{% highlight C# %} 

        SfShimmer shimmer = new SfShimmer();
        this.Content = shimmer;
        var grid = new Grid
        {
            Padding = 10,
            ColumnSpacing = 15,
            RowSpacing = 10,
            VerticalOptions = LayoutOptions.Fill,
            RowDefinitions = new RowDefinitionCollection()
                {
                    new RowDefinition { Height = 10 },
                    new RowDefinition { Height = 10 },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto }
                },

            ColumnDefinitions = new ColumnDefinitionCollection()
            {
                new ColumnDefinition { Width = GridLength.Auto},
                new ColumnDefinition { Width = GridLength.Auto},
            }
        };

        var shimmerView1 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            WidthRequest = 300
        };

        var shimmerView2 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            WidthRequest = 250
        };

        var shimmerView3 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 280
        };

        var shimmerView4 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 260,
            HeightRequest = 10,
        };

        var shimmerView5 = new ShimmerView()
        {
            ShapeType = ShimmerShapeType.Circle,
        };

        var shimmerView6 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            VerticalOptions = LayoutOptions.Start,
            WidthRequest = 180,
            ShapeType = ShimmerShapeType.Rectangle,
        };

        var shimmerView7 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 190
        };

        var shimmerView8 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 170,
            ShapeType = ShimmerShapeType.Rectangle,
        };

        var shimmerView9 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 180,
            ShapeType = ShimmerShapeType.Rectangle,
        };

        var shimmerView10 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 150,
            ShapeType = ShimmerShapeType.Rectangle,
        };

        var shimmerView11 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 160,
            ShapeType = ShimmerShapeType.Rectangle,
        };

        var shimmerView12 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 10,
            WidthRequest = 175
        };

        var shimmerView13 = new ShimmerView
        {
            Margin = new Thickness(0, 5, 0, 0),
            ShapeType = ShimmerShapeType.Rectangle,
        };

        var shimmerView14 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            ShapeType = ShimmerShapeType.RoundedRectangle,
            HeightRequest = 10,
            WidthRequest = 150
        };

        var shimmerView15 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            ShapeType = ShimmerShapeType.RoundedRectangle,
            HeightRequest = 10,
            WidthRequest = 160
        };

        var shimmerView16 = new ShimmerView
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            ShapeType = ShimmerShapeType.RoundedRectangle,
            HeightRequest = 10,
            WidthRequest = 175
        };

        grid.Add(shimmerView1, 0, 0);
        Grid.SetColumnSpan(shimmerView1, 2);

        grid.Add(shimmerView2, 0, 1);
        Grid.SetColumnSpan(shimmerView2, 2);

        grid.Add(shimmerView3, 0, 2);
        Grid.SetColumnSpan(shimmerView3, 2);

        grid.Add(shimmerView4, 0, 3);
        Grid.SetColumnSpan(shimmerView4, 2);

        grid.Add(shimmerView5, 0, 5);
        Grid.SetRowSpan(shimmerView5, 8);

        grid.Add(shimmerView6, 1, 5);

        grid.Add(shimmerView7, 1, 6);

        grid.Add(shimmerView8, 1, 7);

        grid.Add(shimmerView9, 1, 8);

        grid.Add(shimmerView10, 1, 9);

        grid.Add(shimmerView11, 1, 10);

        grid.Add(shimmerView12, 1, 11);

        grid.Add(shimmerView13, 1, 13);
        Grid.SetRowSpan(shimmerView13, 3);

        grid.Add(shimmerView14, 0, 13);

        grid.Add(shimmerView15, 0, 14);

        grid.Add(shimmerView16, 0, 15);

        shimmer.CustomView = grid;

{% endhighlight %}
{% endtabs %}

![Shimmer Custom view in .NET MAUI.](images/customview/maui-shimmer-view.gif)