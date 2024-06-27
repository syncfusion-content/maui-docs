---
layout: post
title: Right To Left in .NET MAUI ListView control | Syncfusion
description: Learn here all about Right To Left support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
keywords : .net maui listview, .net maui list, .net maui rtl listview, .net maui listview right-to-left ui.
---

# Right To Left in .NET MAUI ListView (SfListView)

`SfListView` supports changing the flow of text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft` in both `Vertical` and `Horizontal` orientations. ListView supports RTL when the flow direction of the device is changed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
<ContentPage  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Content>
       <syncfusion:SfListView x:Name="listView" FlowDirection="RightToLeft"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.FlowDirection = FlowDirection.RightToLeft;
{% endhighlight %}
{% endtabs %}

![MAUI ListView with right to left](Images/right-to-left/maui-listview-right-to-left.png)

## Limitation

* ListView item does not arrange from right to left direction in `Horizontal` orientation, when the [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) is `Height` or `DynamicHeight`.

