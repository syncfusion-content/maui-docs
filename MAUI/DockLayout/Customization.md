---
layout: post
title: Customization in .NET MAUI DockLayout Control | Syncfusion®
description: Learn about customization options in the Syncfusion® .NET MAUI DockLayout (SfDockLayout) control, including spacing and child expansion behavior.
platform: MAUI
control: SfDockLayout
documentation: ug
---

# Customization in .NET MAUI DockLayout Control

## Exapnd LastChild
The `ShouldExpandLastChild` property (of type `bool`) determines whether the last non-docked child should automatically occupy all remaining space after other docked children have been positioned. By default, this property is set to `True`. This feature is particularly valuable for ensuring that the last child element fully utilizes available space, resulting in a seamless and gap-free layout. If `ShouldExpandLastChild` is set to `False`, the last child's size must be defined explicitly.

{% tabs %}
{% highlight xaml %}

 <dx:SfDockLayout ShouldExpandLastChild="False">
    <!-- Add child elements here -->
     <Label Text="None" HeightRequest="45"/>
 </dx:SfDockLayout>

{% endhighlight %}

{% highlight c# %}

 SfDockLayout dockLayout = new SfDockLayout() { ShouldExpandLastChild = false };
 dockLayout.Children.Add(new Label() { Text = "None", WidthRequest = 45 });

{% endhighlight %}

{% endtabs %}

![.NET MAUI DockLayout Last Child not Expanded](DockLayout-Images/maui-docklayout-lastchild-alignment.png)

## Spacing
Customize the spacing between child elements using the `HorizontalSpacing` and `VerticalSpacing` properties.The default value for both is `0`

* [HorizontalSpacing]() — of type `double`: Specifies the horizontal gap between docked children.
* [VerticalSpacing]() — Of type `double`: Specifies the vertical  gap between docked children.


{% tabs %}

{% highlight xaml %}

 <dx:SfDockLayout HorizontalSpacing="10" VerticalSpacing="10">
    ...
 </dx:SfDockLayout>
 {% endhighlight %}

{% highlight c# %}
SfDockLayout dockLayout = new SfDockLayout() 
{ 
    HorizontalSpacing = 10, VerticalSpacing = 10
};

{% endhighlight %}
{% endtabs %}


![Output of DockLayout with Spacing](DockLayout-Images/maui-docklayout-spacing.png)

## Methods in .NET MAUI DockLayout Control

## GetDock
The `GetDock` method retrieves the docking position for a specified view within the layout.

`GetDock(BindableObject view)`

### Parameters
- **view:** `BindableObject` - The targeted child view for docking evaluation.

{% highlight c# %}

SfDockLayout dockLayout = new SfDockLayout();
dockLayout.Children.Add(new Label() { Text = "Left", WidthRequest = 80, Background = Color.FromArgb("#CA7842") }, Dock.Left);

Dock currentPosition = SfDockLayout.GetDock((BindableObject)dockLayout.Children[0]);
Content = dockLayout;

{% endhighlight %}

## SetDock
The `SetDock` method assigns a specific docking position to a child element within the layout.

`SetDock(BindableObject view, Dock position)`

### Parameters
* view: `BindableObject` - The targeted child view for docking adjustment.
* position: `Dock` - The designated docking position to assign.

SetDock(BindableObject view, Dock position)

{% highlight c# %}

 SfDockLayout dockLayout = new SfDockLayout();

var leftLabel = new Label() { Text = "Left", WidthRequest = 80, Background = Color.FromArgb("#CA7842") };
dockLayout.Children.Add(leftLabel);
SfDockLayout.SetDock((BindableObject)leftLabel, Dock.Left);

var rightLabel = new Label() { Text = "Right", WidthRequest = 80, Background = Color.FromArgb("#71C0BB") };
dockLayout.Children.Add(rightLabel);
SfDockLayout.SetDock((BindableObject)rightLabel, Dock.Right);

var topLabel = new Label() { Text = "Top", HeightRequest = 80, Background = Color.FromArgb("#B2CD9C") };
dockLayout.Children.Add(topLabel);
SfDockLayout.SetDock((BindableObject)topLabel, Dock.Top);

var bottomLabel = new Label() { Text = "Bottom", HeightRequest = 80, Background = Color.FromArgb("#94B4C1") };
dockLayout.Children.Add(bottomLabel);
SfDockLayout.SetDock((BindableObject)bottomLabel, Dock.Bottom);

Content = dockLayout;

{% endhighlight %}
