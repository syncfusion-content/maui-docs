---
layout: post
title: Migrate from Xamarin to .NET MAUI RadialMenu Control (SfRadialMenu) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms RadialMenu control to .NET MAUI RadialMenu control.
platform: maui
control: RadialMenu (SfRadialMenu) control
documentation: ug
---
 
# Migrate from Xamarin.Forms RadialMenu Control to .NET MAUI RadialMenu Control (SfRadialMenuControl)

To make the migration from the [Xamarin SfRadialMenu Control](https://www.syncfusion.com/xamarin-ui-controls/xamarin-radialMenu-control) to the [.NET MAUI SfRadialMenu Control](https://www.syncfusion.com/maui-controls/maui-radialMenu-control) easier, most of the APIs from the `Xamarin SfRadialMenu Control` were kept in the `.NET MAUI SfRadialMenu Control`. However, to maintain the consistency of API naming in the `.NET MAUI SfRadialMenu Control`, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces

<table>
<tr>
<th>Xamarin SfRadialMenu control</th>
<th>.NET MAUI SfRadialMenu control</th></tr>
<tr>
<td>Syncfusion.Xamarin.RadialMenu</td>
<td>Syncfusion.Maui.RadialMenu</td></tr>
</table>

## Initialize Control

To initialize the control, import the radialMenu control namespace and initialize the [SfRadialMenuControl](https://www.syncfusion.com/maui-controls/maui-radial-menu-control) as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfRadialMenu control</th>
<th>.NET MAUI SfRadialMenu control</th></tr>
<tr>
<td>

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:radialMenu="clr-namespace:Syncfusion.XForms.RadialMenu;assembly=Syncfusion.RadialMenu.XForms">
     <radialMenu:SfRadialMenu x:Name="radialMenuControl"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.RadialMenu;
...

SfRadialMenu radialMenuControl = new SfRadialMenu();
this.Content = radialMenuControl;

{% endhighlight %}
{% endtabs %}

</td>
<td>

{% tabs %}
{% highlight XAML %}

<ContentPage 
...
xmlns:radialMenu="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu">
    <radialMenu:SfRadialMenu x:Name="radialMenuControl"/>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;
…

SfRadialMenu radialMenuControl = new SfRadialMenu();
this.Content = radialMenuControl;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfRadialMenu control</th>
<th>.NET MAUI SfRadialMenu control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[SfRadialMenu](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RadialMenu.SfRadialMenu.html)'| markdownify }}</td>
<td>{{'[SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html)'| markdownify}}</td>
<td>The SfRadialMenu displays a hierarchical menu in a circular layout, which is optimized for touch enabled devices. Typically, it is used as a context menu, and it can expose more menu items in the same space than traditional menus.</td>
</tr>

<tr>
<td>{{'[SfRadialMenuItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RadialMenu.SfRadialMenuItem.html)'| markdownify }}</td>
<td>{{'[SfRadialMenuItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuItem.html)'| markdownify}}</td>
<td>Represents an item that can be added as children in SfRadialMenu.Any object can be added as SfRadialMenuItem and that can be populated as menus.</td>
</tr>

</table> 


## Properties

### SfRadialMenuControl

<table> 
<tr>
<th>Xamarin SfRadialMenu control</th>
<th>.NET MAUI SfRadialMenu control</th>
<th>Description</th></tr>

<tr>
<td>{{'[CenterButtonBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RadialMenu.SfRadialMenuControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_BorderColor)'| markdownify }}</td>
<td>{{'[CenterButtonStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_Stroke)'| markdownify}}</td>
<td>Gets or sets the stroke brush for the centerbuttonstroke in the SfRadialMenuControl.</td>
</tr>

<tr>
<td>{{'[CenterButtonBorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RadialMenu.SfRadialMenuControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_BorderThickness)'| markdownify }}</td>
<td>{{'[CenterButtonStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_StrokeThickness)'| markdownify}}</td>
<td>Gets or sets a value of the the stroke brush for the centerbuttonstrokethickness in the SfRadialMenuControl.</td>
</tr>

</table> 

## Upcoming features

* LayoutType.
* VisibleSegmentCount.
* Selection.
* CenterButtonPlacement.
* Accessibility.