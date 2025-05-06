---
layout: post
title: How to Add the Custom View for Syncfusion® SfButton
description: Learn here about how to add the custom view for the Syncfusion® .NET MAUI Button (SfButton) control.
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

<ContentPage.Content>
    <buttons:SfButton  CornerRadius="10" Text="SfButton" Background="#4125BC">
        <buttons:SfButton.Content>
            <DataTemplate>
                <HorizontalStackLayout Spacing = "8" Padding="5">
                    <ActivityIndicator Color = "White" IsRunning="True"/>
                    <Label Text = "Loading..." VerticalOptions="Center" TextColor="White"/>
                </HorizontalStackLayout>
            </DataTemplate>
        </buttons:SfButton.Content>
    </buttons:SfButton>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

. . . 

var customTemplate = new DataTemplate(() =>
{
    var activityIndicator = new ActivityIndicator
    {
        Color = Colors.White,
        IsRunning = true,
    };
    var label = new Label
    {
        Text = "Loading...",
        TextColor = Colors.White,
        VerticalOptions = LayoutOptions.Center
    };
    var stackLayout = new HorizontalStackLayout
    {
        Spacing = 8,
        Padding = new Thickness(5)
    };
    stackLayout.Children.Add(activityIndicator);
    stackLayout.Children.Add(label);
    return stackLayout;
});
SfButton button = new SfButton
{
    Text = "SfButton",
    Background = Color.FromArgb("#4125BC"),
    CornerRadius= 10,
    Content = customTemplate
};

Content = new VerticalStackLayout
{
    Children = { button }
};


{% endhighlight %}
{% endtabs %}

![SfButton with custom view](images/button-content.png)
