---
layout: post
title: How to Add the Custom View for Syncfusion<sup>®</sup> SfButton
description: Learn here about how to add the custom view for the Syncfusion<sup>®</sup> .NET MAUI Button (SfButton) control.
platform: maui
control: Sfbutton
documentation: ug
---

# Add the custom view for button

You can customize the appearance of the button by adding your custom view in the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Content) property. The following code sample demonstrates how to apply the busy indicator control as a custom view for a button.

{% tabs %}
{% highlight xaml %}

xmlns:busy="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"

. . .

<ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="happyTemplate">
                <HorizontalStackLayout>
                    <busy:SfBusyIndicator AnimationType="SingleCircle" IsRunning="True" TextColor="White" WidthRequest="80" HeightRequest="60" IndicatorColor="White" VerticalOptions="Center" HorizontalOptions="End"/>
                    <Label Text="Loading..." FontSize="20" HorizontalOptions="Start" VerticalOptions="Center" TextColor="White" />
                </HorizontalStackLayout>
            </DataTemplate>
        </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
    <button:SfButton  CornerRadius="20"  WidthRequest="300"   Content="{x:StaticResource happyTemplate}" Text="SfButton"   />
</ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

. . . 

SfButton button = new SfButton();
var happyTemplate = new DataTemplate(() =>
{
// Create the HorizontalStackLayout.
var stackLayout = new Microsoft.Maui.Controls.StackLayout()
{
    Orientation = StackOrientation.Horizontal,
    VerticalOptions = LayoutOptions.Center
};

// Create the SfBusyIndicator.
var busyIndicator = new SfBusyIndicator()
{
    AnimationType = AnimationType.SingleCircle,
    IsRunning = true,
    TextColor = Colors.White,
    WidthRequest = 80,
    HeightRequest = 60,
    IndicatorColor = Colors.Yellow,
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.End
};

// Create the Label.
var label = new Label
{
    Text = "Loading...",
    FontSize = 20,
    HorizontalOptions = LayoutOptions.Start,
    VerticalOptions = LayoutOptions.Center,
    TextColor = Colors.White
};

// Add the busyIndicator and label to the stackLayout.
stackLayout.Children.Add(busyIndicator);
stackLayout.Children.Add(label);

// Return the constructed stackLayout as the root of the DataTemplate.
return stackLayout;

});
button.Content = happyTemplate;
{% endhighlight %}
{% endtabs %}

![SfButton with custom view](images/button-content.png)