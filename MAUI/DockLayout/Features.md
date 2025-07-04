---
layout: post
title: Features in .NET MAUI DockLayout Control | Syncfusion
description: Learn about features in the Syncfusion® .NET MAUI DockLayout (SfDockLayout) control, including spacing and child expansion behavior.
platform: MAUI
control: SfDockLayout
documentation: ug
---

# Features in .NET MAUI DockLayout Control

## Expand LastChild
The [ShouldExpandLastChild](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_ShouldExpandLastChild) property (of type `bool`) determines whether the last docked child should automatically occupy all remaining space after other docked children have been positioned. By default, this property is set to `True`. This feature is particularly valuable for ensuring that the last child element fully utilizes available space, resulting in a seamless and gap-free layout.

{% tabs %}
{% highlight xaml %}

<sf:SfDockLayout ShouldExpandLastChild="False">
    <!-- Since ShouldExpandLastChild is False, the last child's size must be defined explicitly -->
    <Label Text="None" HeightRequest="45"/>
</sf:SfDockLayout>

{% endhighlight %}

{% highlight c# %}

SfDockLayout dockLayout = new SfDockLayout() { ShouldExpandLastChild = false };
dockLayout.Children.Add(new Label() { Text = "None", WidthRequest = 45 });

{% endhighlight %}

{% endtabs %}

![.NET MAUI DockLayout Last Child not Expanded](DockLayout-Images/maui-docklayout-lastchild-alignment.png)

## Spacing
Customize the spacing between child elements using the [HorizontalSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_HorizontalSpacing) and [VerticalSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_VerticalSpacing) properties.The default value for both is 0.

* [HorizontalSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_HorizontalSpacing) —  Specifies the horizontal gap between docked children.
* [VerticalSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_VerticalSpacing) — Specifies the vertical  gap between docked children.


{% tabs %}

{% highlight xaml %}

<sf:SfDockLayout HorizontalSpacing="10" VerticalSpacing="10">
    ...
</sf:SfDockLayout>
 {% endhighlight %}

{% highlight c# %}
SfDockLayout dockLayout = new SfDockLayout() 
{ 
    HorizontalSpacing = 10, VerticalSpacing = 10
};

{% endhighlight %}
{% endtabs %}


![Output of DockLayout with Spacing](DockLayout-Images/maui-docklayout-spacing.png)

## GetDock
The [GetDock](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_GetDock_Microsoft_Maui_Controls_BindableObject_) method retrieves the docking position for a specified view within the layout.

`GetDock(BindableObject view)`

### Parameters
- **view:** `BindableObject` - The targeted child view for docking evaluation.

{% tabs %}

{% highlight c# %}

SfDockLayout dockLayout = new SfDockLayout();
var leftLabel = new Label() { Text = "Left", WidthRequest = 80, Background = Color.FromArgb("#CA7842") };
dockLayout.Children.Add(leftLabel, Dock.Left);
Content = dockLayout;

Dock currentPosition = SfDockLayout.GetDock((BindableObject)dockLayout.Children[0]);

{% endhighlight %}

{% endtabs %}

## SetDock
The [SetDock](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_SetDock_Microsoft_Maui_Controls_BindableObject_Syncfusion_Maui_Core_Dock_) method assigns a specific docking position to a child element within the layout.

`SetDock(BindableObject view, Dock position)`

### Parameters
* view: `BindableObject` - The targeted child view for docking adjustment.
* position: `Dock` - The designated docking position to assign.

{% tabs %}

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

{% endtabs %}

## Right To Left (RTL)

The .NET MAUI DockLayout control supports Right-to-Left (RTL) layout direction. When the `FlowDirection` property is set to `RightToLeft`, the docking positions are mirrored to align with RTL language standards.

You can enable RTL either by setting `FlowDirection` directly on the DockLayout, or by changing the device language to one that uses an RTL script.

{% tabs %}

{% highlight xaml %}

<sf:SfDockLayout FlowDirection="RightToLeft">
...
</sf:SfDockLayout>
{% endhighlight %}

{% highlight c# %}
SfDockLayout dockLayout = new SfDockLayout()
{
    FlowDirection = FlowDirection.RightToLeft,
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI Docklayout with RTL support](DockLayout-Images/maui-docklayout-right-to-left.png)
