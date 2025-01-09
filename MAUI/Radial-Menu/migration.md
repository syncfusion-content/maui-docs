---
layout: post
title: Migrate from Xamarin to .NET MAUI SfRadialMenu | Syncfusion®
description: Learn about Migrating from Syncfusion® Xamarin.Forms RadialMenu control to .NET MAUI RadialMenu control.
platform: maui
control: RadialMenu (SfRadialMenu) control
documentation: ug
---
 
# Migrate from Xamarin.Forms RadialMenu to .NET MAUI RadialMenu Control

To make the migration from the [Xamarin SfRadialMenu Control](https://www.syncfusion.com/xamarin-ui-controls/xamarin-radial-menu) to the [.NET MAUI SfRadialMenu Control](https://www.syncfusion.com/maui-controls/maui-radial-menu) easier, most of the APIs from the `Xamarin SfRadialMenu Control` were kept in the `.NET MAUI SfRadialMenu Control`. However, to maintain the consistency of API naming in the `.NET MAUI SfRadialMenu Control`, some of the APIs have been renamed. Please find the difference in the following topics.

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

To initialize the control, import the radialMenu control namespace and initialize the [SfRadialMenu]() as shown in the following code sample.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:radialMenu="clr-namespace:Syncfusion.XForms.RadialMenu;assembly=Syncfusion.RadialMenu.XForms">
     <radialMenu:SfRadialMenu x:Name="radialMenu"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.RadialMenu;
...

SfRadialMenu radialMenu = new SfRadialMenu();
this.Content = radialMenuControl;

{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
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

SfRadialMenu radialMenu = new SfRadialMenu();
this.Content = radialMenu;

{% endhighlight %}
{% endtabs %}
</td>
</tr>
</table>

## Properties

### SfRadialMenu Control

<table> 
<tr>
<th>Xamarin SfRadialMenu control</th>
<th>.NET MAUI SfRadialMenu control</th>
<th>Description</th></tr>

<tr>
<td>{{'[CenterButtonBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBorderColor)'}}</td>
<td>{{'[CenterButtonStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_CenterButtonStroke)'}}</td>
<td>Gets or sets a value of the stroke brush for the centerbuttonstroke in the SfRadialMenu.</td>
</tr>

<tr>
<td>{{'[CenterButtonBorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBorderThickness)'}}</td>
<td>{{'[CenterButtonStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_CenterButtonStrokeThickness)'}}</td>
<td>Gets or sets a value of the the strokethickness for the centerbuttonstrokethickness in the SfRadialMenu.</td>
</tr>

</table> 

## Upcoming features in .NET MAUI RadialMenu

* LayoutType that determines arrangement of items on rim either automatic or user defined.
* VisibleSegmentCount that determines the number of segments visible at a time on the menu.
* Selection allows you to highlight or choose segments within the hierarchy.
* CenterButtonPlacement that specifies the position of the center button within the menu.
* Accessibility.

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). If you do not see what you need, Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).