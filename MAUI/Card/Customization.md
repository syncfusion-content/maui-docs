---
layout: post
title: Customization in MAUI Cards control | Syncfusion
description: Learn about Customization support in Syncfusion Essential Studio MAUI Cards control, its elements and more.
platform: MAUI
control: Cards
documentation: ug
---

# Customization in MAUI Cards

### ShowSwipedCard

ShowSwipedCard can be enabled to show the swiped cards at the edge of card layout.

{% tabs %} 

{% highlight xaml %}

<cards:SfCardLayout ShowSwipedCard="true">
</cards:SfCardLayout>
 
{% endhighlight %}

{% highlight C# %}

SfCardLayout cardLayout = new SfCardLayout()
{
  ShowSwipedCard = true
};

{% endhighlight %}

{% endtabs %}

![ShowSwipedCard in MAUI.Forms SfCardLayout](cardlayout-customization_images/showswipedcard.png)

### VisibleIndex

VisibleIndex is used when given index of the card to be displayed in front of the card layout.

{% tabs %} 

{% highlight xaml %}

<cards:SfCardLayout VisibleIndex="1">
</cards:SfCardLayout>
 
{% endhighlight %}

{% highlight C# %}

SfCardLayout cardLayout = new SfCardLayout()
{
  VisibleCardIndex = 1
};

{% endhighlight %}

{% endtabs %}

![VisibleCardIndex in MAUI SfCardLayout](cardlayout-customization_images/showswipedcard.png)

### SwipeDirection

The SwipeDirection property indicates the swiping direction (left,right,top and bottom).

{% tabs %} 

{% highlight xaml %}

<cards:SfCardLayout SwipeDirection="Right">
</cards:SfCardLayout>
 
{% endhighlight %}

{% highlight C# %}

SfCardLayout cardLayout = new SfCardLayout()
{
    SwipeDirection = CardSwipeDirection.Right
};


{% endhighlight %}

{% endtabs %}

![SwipeDirection in MAUI SfCardLayout](cardlayout-customization_images/swipedirection.png)

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/Getting-started-sample-of-cards).

## Customization in CardView

You can customize the border color, thickness, and card corner radius by using the following properties:

[BorderColor]() - Used to customize the card view border color.

[BorderWidth]() - Used to customize the card view border thickness.

[CornerRadius]() - Used to customize the card view corner radius.

{% tabs %} 

{% highlight xaml %}

    <StackLayout  HorizontalOptions="Center" VerticalOptions="Center">
        <cards:SfCardView BorderColor="Black" BorderWidth="5" CornerRadius="30,0,30,0" BackgroundColor="LightPink"  >
            <StackLayout Padding="10, 10, 0, 0" >
             <Label  Text="New York" FontSize="25" />
            <Label Text="Mon 3.00PM, Sunny" TextColor="Gray"/>
            <StackLayout Orientation="Horizontal">
                <Label Text="31°" FontSize="70" Padding="0, 0, 10,0"/>
                <Image  Source="Sun.png" HeightRequest="100" WidthRequest="100"/>
            </StackLayout>
        </StackLayout>
     </cards:SfCardView>
  </StackLayout>

{% endhighlight %}

{% highlight C# %}

        StackLayout mainStack = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new SfCardView(){
                    Content =  new StackLayout()
                    {
                        Padding = new Thickness(10, 10, 0, 0),
                        Children =
                        {
                            new Label(){Text = "New York" , FontSize = 25},
                            new Label(){Text = "Mon 3.00PM, Sunny" , TextColor = Color.Gray},
                            new StackLayout()
                            {
                                Orientation  = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Label(){Text = "31°" , FontSize = 70, Padding = new Thickness(0,0,10,0) },
                                    new Image(){Source = "Sun.png", HeightRequest = 100, WidthRequest = 100}
                                }
                            }
                        }
                    },
                    BorderColor = Color.Black,
                    BorderWidth = 5,
                    CornerRadius = new Thickness(30, 0, 30, 0),
                    BackgroundColor = Color.LightPink
                    }
                }
            };
           
{% endhighlight %}

{% endtabs %}

![Card customization in MAUI SfCardLayout](cardview-customization_images/card_Customization.PNG)

### Indicator customization

Indicators are used to indicate the state or level of something.

{% tabs %} 

{% highlight xaml %}

    <cards:SfCardView IndicatorColor="Cyan" HeightRequest="300" IndicatorThickness="12" IndicatorPosition="Left" >
            <Label  Text="SfCardView" VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
        </cards:SfCardView>

{% endhighlight %}

{% highlight C# %}

SfCardView cardView = new SfCardView() 
{     
    Content = new Label() 
    { 
        Text = "SfCardView", 
        HorizontalTextAlignment = TextAlignment.Center, 
        VerticalTextAlignment =  TextAlignment.Center
    },
    IndicatorThickness = 12,
    HeightRequest = 300,
    IndicatorPosition = IndicatorPosition.Left,
    IndicatorColor = Color.Cyan
};
           

{% endhighlight %}

{% endtabs %}

![Indicator in MAUI SfCardLayout](cardview-customization_images/indicator.png)

### FadeOutOnSwiping

FadeOutOnSwiping can be enabled when the card view needs to be faded with respect to swiping.

{% tabs %} 

{% highlight xaml %}

    <cards:SfCardView FadeOutOnSwiping="true"/>
 
{% endhighlight %}

{% highlight C# %}

SfCardView cardView = new SfCardView()
{
  FadeOutOnSwiping = true
};

{% endhighlight %}

{% endtabs %}

N> This property won't work when adding the SfCardView as a child of SfCardLayout.

