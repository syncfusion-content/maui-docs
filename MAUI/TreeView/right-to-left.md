---
layout: post
title: Right To Left in .NET MAUI TreeView Control | Syncfusion
description: Learn here about Right To Left support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Right To Left in .NET MAUI TreeView (SfTreeView)

`SfTreeView` supports changing the flow of text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft`. TreeView supports RTL when the flow direction of the device is changed.

{% tabs %}
{% highlight xaml hl_lines="7" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             x:Class="Selection.MainPage">
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView" 
                              FlowDirection="RightToLeft"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
SfTreeView treeView = new SfTreeView();
treeView.FlowDirection = FlowDirection.RightToLeft;
{% endhighlight %}
{% endtabs %}