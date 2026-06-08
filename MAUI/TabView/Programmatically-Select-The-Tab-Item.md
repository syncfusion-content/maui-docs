---
layout: post
title: Select Tab in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about selecting a tab item programmatically in the Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Programmatically select the tab item

You can use the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView to programmatically select a tab item. Below is a code snippet demonstrating how to do this:

{% tabs %}

{% highlight xaml %}
   <tabView:SfTabView x:Name="tabView" SelectedIndex="2"/>
{% endhighlight %}

{% highlight C# %}
    tabView.SelectedIndex = 2;
{% endhighlight %}
{% endtabs %}

![SelectedIndex in SfTabView](images/SelectedIndexTabView.png)