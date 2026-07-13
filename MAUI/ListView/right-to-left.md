---
layout: post
title: Right To Left in .NET MAUI ListView control | Syncfusion®
description: Learn about Right To Left support in Syncfusion® .NET MAUI ListView (SfListView) control, including layout behavior and item alignment.
platform: MAUI
control: SfListView
documentation: ug
---

# Right To Left in .NET MAUI ListView (SfListView)

`Syncfusion® SfListView` supports changing the flow of text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft` in both `Vertical` and `Horizontal` orientations. RTL can be applied explicitly on the `SfListView` by setting the `FlowDirection` property, or inherited from a parent visual element or the device's system flow direction.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
              xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Content>
       <syncfusion:SfListView x:Name="listView" FlowDirection="RightToLeft"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Microsoft.Maui.Controls;
using Syncfusion.Maui.ListView;

namespace RtlSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        listView.FlowDirection = FlowDirection.RightToLeft;
    }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView with Right To Left](Images/right-to-left/maui-listview-right-to-left.png)

## Limitation

* Items are not arranged right-to-left when `SfListView.Orientation` is set to `Horizontal` and the [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) is `Height` or `DynamicHeight`.

