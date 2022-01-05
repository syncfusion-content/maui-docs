---
layout: post
title: Right To Left in .NET MAUI ListView control | Syncfusion
description: Learn here all about Right To Left support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Right To Left in .NET MAUI ListView (SfListView)

`SfListView` supports to change the flow of text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft` in both `Vertical` and `Horizontal` orientations. ListView supports RTL when device's flow direction is changed.

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Content>
       <syncfusion:SfListView x:Name="listView" FlowDirection="RightToLeft"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.FlowDirection = FlowDirection.RightToLeft;
{% endhighlight %}
{% endtabs %}

![MAUI ListView with right to left](SfListView_images/SfListView-Right-To-Left.png)

## Limitation

* ListView item does not arrange from right to left direction in `Horizontal` orientation, when the [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) is `Height` or `DynamicHeight`.

