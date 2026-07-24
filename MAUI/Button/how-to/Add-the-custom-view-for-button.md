---
layout: post
title: How to Add a Custom View to a .NET MAUI Button | Syncfusion®
description: Learn how to add and customize a custom view within the Syncfusion® .NET MAUI Button (SfButton) control for richer UI experiences.
platform: maui
control: SfButton
documentation: ug
---

# Add a Custom View to a Button (SfButton)

You can customize the appearance of the [.NET MAUI Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) with any custom view by setting the [Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Content) property. This is useful for adding spinners, icons, or any composite layout inside the button.

N> When the `Content` property is set, the `Text`, `ImageSource`, and `ShowIcon` properties are not rendered.

The following code samples show how to set the `Content` of `Button` to a horizontal layout that contains a `ActivityIndicator` and a `Label`.

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <buttons:SfButton CornerRadius="10" 
                      Text="SfButton" 
                      Background="#4125BC">
        <buttons:SfButton.Content>
            <DataTemplate>
                <HorizontalStackLayout Spacing = "8" Padding="5">
                    <ActivityIndicator Color = "White" IsRunning="True"/>
                    <Label Text = "Loading..." 
                           VerticalOptions="Center" 
                           TextColor="White"/>
                </HorizontalStackLayout>
            </DataTemplate>
        </buttons:SfButton.Content>
    </buttons:SfButton>
</VerticalStackLayout>

{% endhighlight %}
{% highlight c# %}

var customTemplate = new DataTemplate(() =>
{
    var activityIndicator = new ActivityIndicator
    {
        Color = Colors.White,
        IsRunning = true
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

## See Also

- [Getting Started](https://help.syncfusion.com/maui/button/getting-started)
- [Customization](https://help.syncfusion.com/maui/button/customization)
