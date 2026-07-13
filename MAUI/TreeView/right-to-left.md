---
layout: post
title: Right-to-Left in .NET MAUI TreeView (SfTreeView) Control | Syncfusion®
description: Learn how to enable Right-to-Left (RTL) layout support in the Syncfusion® .NET MAUI TreeView (SfTreeView) control for RTL languages.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Right-to-Left in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` control supports displaying its content in a right-to-left (RTL) layout for languages such as Arabic, Hebrew, and Urdu. To enable RTL, set the [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.flowdirection?view=net-maui-10.0) property to `RightToLeft`. The `FlowDirection` can be set directly on the `SfTreeView` or inherited from its parent layout. By default, the `FlowDirection` is set to `LeftToRight`.

## Enabling right-to-left

{% tabs %}
{% tab title="XAML" hl_lines="2" %}

<syncfusion:SfTreeView x:Name="treeView"
                       FlowDirection="RightToLeft"/>
{% endtab %}
{% tab title="C#" hl_lines="9" %}

using Syncfusion.Maui.TreeView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeView treeView = new SfTreeView();
        treeView.FlowDirection = FlowDirection.RightToLeft;
    }
}

{% endtab %}
{% endtabs %}