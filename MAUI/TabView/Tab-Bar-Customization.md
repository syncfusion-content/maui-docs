---
layout: post
title: Customize the Tab Bar in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about custom header support in the Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Customize the Tab Bar in .NET MAUI Tab View (SfTabView)

## Tab width options

The .NET MAUI Tab View provides two modes that determines how the width of the tab is calculated on the tab bar while it gets populated. The options are [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html#Syncfusion_Maui_TabView_TabWidthMode_Default) and [SizeToContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html#Syncfusion_Maui_TabView_TabWidthMode_SizeToContent). These can be achieved using the [TabWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html) property.

### Fixed bar

The width of the tab is divided equally based on the available control width. This enables a fixed tab bar that will not allow tab scrolling, regardless of the number of tabs. This can be achieved by setting the `TabWidthMode` as `Default`.

N> This mode is recommended when the tab count is not more than four. More tabs in this mode may appear with the text being trimmed.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView TabWidthMode="Default">
{% endhighlight %}

{% highlight C# %}
     tabView.TabWidthMode = TabWidthMode.Default;
{% endhighlight %}

{% endtabs %}

![TabWidthMode default](images/Tab-Width-Mode-Default.png)

### Based on the text size

The width of a tab is set to fit the text or image that it contains by setting the `TabWidthMode` as `SizeToContent`. Scroll is enabled in this mode to access the items outside the visible area.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView TabWidthMode="SizeToContent">
{% endhighlight %}

{% highlight C# %}
     tabView.TabWidthMode = TabWidthMode.SizeToContent;
{% endhighlight %}

{% endtabs %}

![TabWidthMode size to fit](images/Tab-Width-Mode-SizeToFit.png) 

## Customize the TabBarHeight

The height of the tab bar can be customized by setting the [TabBarHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarHeight) property. The default height is 48.

N> It is recommended to set the `TabBarHeight` to 72 while displaying both the image and text with `ImagePosition` as either top or bottom.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView TabBarHeight="100">
{% endhighlight %}

{% highlight C# %}
     tabView.TabBarHeight = 100;
{% endhighlight %}

{% endtabs %}

## Customize the tab header text alignment

The horizontal text alignment of the tab header can be customized by setting the [HeaderHorizontalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderHorizontalTextAlignment) property. The default value is `Center`. This property accepts the following values:

*   **Start** - The text will be placed at the starting position in the header tab.
*   **Center** - The text will be placed at the center of the header tab.
*   **End** - The text will be placed at the end of the header tab.

{% tabs %}

{% highlight xaml %} 
<tabView:SfTabView HeaderHorizontalTextAlignment="Center"> 
{% endhighlight %}

{% highlight C# %} 
tabView.HeaderHorizontalTextAlignment = TextAlignment.Center; {% endhighlight %}

{% endtabs %}

![Tab header text alignment](images/HorizontalTextAlignmentCenter.png) 


## TabBarPlacement options

The .NET MAUI Tab View provides four options for determining how the tab bar aligns relative to the tab content. The options are top, bottom, left and right. This can be achieved using the [TabBarPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarPlacement) property.

### Top

The tab bar will be placed above the content region of the Tab View control.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView TabBarPlacement="Top" 
                       TabBarHeight="60"
                       IndicatorWidthMode="Stretch">

    <tabView:SfTabView.Items>
        <tabView:SfTabItem Header="ITEM 1">
            <tabView:SfTabItem.Content>
                    <Label Text="Tab item content" 
                           HorizontalOptions="Center" 
                           VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="ITEM 2">
            <tabView:SfTabItem.Content>
                        <Label Text="Tab item content" 
                               HorizontalOptions="Center" 
                               VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="ITEM 3">
            <tabView:SfTabItem.Content>
                        <Label Text="Tab item content" 
                               HorizontalOptions="Center" 
                               VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView.Items>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    tabView.TabBarPlacement = TabBarPlacement.Top;
    tabView.TabBarHeight = 60;
    tabView.IndicatorWidthMode = IndicatorWidthMode.Stretch;
    var item1 = new SfTabItem { Header = "ITEM 1" };
    item1.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item1);
    var item2 = new SfTabItem { Header = "ITEM 2" };
    item2.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item2);
    var item3 = new SfTabItem { Header = "ITEM 2" };
    item3.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item3);
    this.Content = tabView;
{% endhighlight %}

{% endtabs %}

![TabBarPlacement top](images/Tab-bar-Placement-Top.png) 

### Bottom

The tab bar will be placed below the content region of the Tab View control. 

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView TabBarPlacement="Bottom">
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    tabView.TabBarPlacement = TabBarPlacement.Bottom;
    tabView.TabBarHeight = 60;
    tabView.IndicatorWidthMode = IndicatorWidthMode.Stretch;
    var item1 = new SfTabItem { Header = "ITEM 1" };
    item1.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item1);
    var item2 = new SfTabItem { Header = "ITEM 2" };
    item2.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item2);
    var item3 = new SfTabItem { Header = "ITEM 2" };
    item3.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item3);
    this.Content = tabView;
{% endhighlight %}

{% endtabs %}

![TabBarPlacement bottom](images/Tab-bar-Placement-Bottom.png) 

### Left

The tab bar will be placed left to the content region of the Tab View control.

{% tabs %}

{% highlight xaml %}
  <tabView:SfTabView TabBarPlacement="Left" 
                     TabBarWidth="60"
                     IndicatorWidthMode="Stretch">

    <tabView:SfTabView.Items>
        <tabView:SfTabItem Header="ITEM 1">
            <tabView:SfTabItem.Content>
                    <Label Text="Tab item content" 
                           HorizontalOptions="Center" 
                           VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="ITEM 2">
            <tabView:SfTabItem.Content>
                        <Label Text="Tab item content" 
                               HorizontalOptions="Center" 
                               VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="ITEM 3">
            <tabView:SfTabItem.Content>
                        <Label Text="Tab item content" 
                               HorizontalOptions="Center" 
                               VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView.Items>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    tabView.TabBarPlacement = TabBarPlacement.Left;
    tabView.TabBarWidth = 60;
    tabView.IndicatorWidthMode = IndicatorWidthMode.Stretch;
    var item1 = new SfTabItem { Header = "ITEM 1" };
    item1.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item1);
    var item2 = new SfTabItem { Header = "ITEM 2" };
    item2.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item2);
    var item3 = new SfTabItem { Header = "ITEM 2" };
    item3.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item3);
    this.Content = tabView;
{% endhighlight %}

{% endtabs %}

![TabBarPlacement Left](images\TabBarPlacementLeft.png) 

### Right

The tab bar will be placed right to the content region of the Tab View control.

{% tabs %}

{% highlight xaml %}
  <tabView:SfTabView TabBarPlacement="Right" 
                   TabBarWidth="60"
                   IndicatorWidthMode="Stretch">

    <tabView:SfTabView.Items>
        <tabView:SfTabItem Header="ITEM 1">
            <tabView:SfTabItem.Content>
                    <Label Text="Tab item content" 
                           HorizontalOptions="Center" 
                           VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="ITEM 2">
            <tabView:SfTabItem.Content>
                        <Label Text="Tab item content" 
                               HorizontalOptions="Center" 
                               VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="ITEM 3">
            <tabView:SfTabItem.Content>
                        <Label Text="Tab item content" 
                               HorizontalOptions="Center" 
                               VerticalOptions="Center" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView.Items>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    tabView.TabBarPlacement = TabBarPlacement.Right;
    tabView.TabBarWidth = 60;
    tabView.IndicatorWidthMode = IndicatorWidthMode.Stretch;
    var item1 = new SfTabItem { Header = "ITEM 1" };
    item1.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item1);
    var item2 = new SfTabItem { Header = "ITEM 2" };
    item2.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item2);
    var item3 = new SfTabItem { Header = "ITEM 2" };
    item3.Content = new Label
    {
        Text = "Tab item content",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };
    tabView.Items.Add(item3);
    this.Content = tabView;
{% endhighlight %}

{% endtabs %}

![TabBarPlacement Right](images\TabBarPlacementRight.png) 

## TabBarBackground customization

The tab bar background can be customized using the [TabBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBackground) property, which is of type `Brush`.

### Solid color 

A solid color can be achieved by assigning the `SolidColorBrush` to the [TabBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBackground), which represents the color of the tab bar background.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView TabBarBackground="LightBlue">
{% endhighlight %}

{% highlight C# %}
     tabView.TabBarBackground = Colors.LightBlue;
{% endhighlight %}

{% endtabs %}

![Solid color](images/TabBarSolidColor.png) 

### Gradient color 

The background can be customized with a linear gradient and radial gradient as like below example.

{% tabs %}
{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabView.TabBarBackground>
            <LinearGradientBrush EndPoint="0,1">
                <GradientStop Color="#009FFF" Offset="0.1" />
                <GradientStop Color="#ec2F4B Offset="1.0" />
            </LinearGradientBrush>
        </tabView:SfTabView.TabBarBackground>
    </tabView:SfTabView>
{% endhighlight %}


{% highlight C# %}
Microsoft.Maui.Controls.GradientStop gra1 = new Microsoft.Maui.Controls.GradientStop()
{
    Color = Color.FromArgb("#009FFF"),
    Offset = (float)0.1,
};

Microsoft.Maui.Controls.GradientStop gra2 = new Microsoft.Maui.Controls.GradientStop()
{
    Color = Color.FromArgb("#ec2F4B"),
    Offset = (float)1.0,
};

LinearGradientBrush graBrush = new LinearGradientBrush()
{
    EndPoint = new Point(0, 1),
    GradientStops = new GradientStopCollection() { gra1, gra2 }
};

SfTabView tabView = new SfTabView();
tabView.TabBarBackground = graBrush;
{% endhighlight %}
{% endtabs %}

![Gradient color](images/TabBarGradientColor.png) 

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabBarCustomization) in GitHub.

## Tab bar border customization

You can customize the border of the tab header area in .NET MAUI Tab View using the following properties:

- [TabBarBorderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBorderColor): Sets the border color.
- [TabBarBorderThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBorderThickness): Sets the border thickness.
- [TabBarCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarCornerRadius): Sets the corner radius of the tab bar's border.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView
    x:Name="tabView"
    TabBarPlacement="Bottom"
    TabBarBorderColor="#7C3AED"
    TabBarBorderThickness="2"
    TabBarCornerRadius="24">
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
tabView.TabBarPlacement = TabBarPlacement.Bottom;
tabView.TabBarBorderColor = Color.FromArgb("#7C3AED");
tabView.TabBarBorderThickness = 2;
tabView.TabBarCornerRadius = new CornerRadius(24);
{% endhighlight %}

{% endtabs %}

![Tab bar border](images/Tab-bar-border.png)