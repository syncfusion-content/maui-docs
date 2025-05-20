---
layout: post
title: Select Tab in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about selecting a tab item programmatically in the Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# How to Select a Tab Item Programmatically? 

## Programmatically Select the Tab Item

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

## Get the Selected Tab Item Using IsSelected

The `IsSelected` property indicates whether the tab item is active. This property can be used, as shown in the code snippet below, to check and perform actions on the selected tab item.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView x:Name="tabView" SelectionChanged="Index_Changed"/>
{% endhighlight %}

{% highlight C# %}

    tabView.SelectionChanged += Index_Changed;
    private void Index_Changed(object sender, TabSelectionChangedEventArgs e)
    {
        bool itemSelection = tab1.IsSelected;
        if (itemSelection)
        {
            tab1.FontSize = 26;
        }
    }

{% endhighlight %}

{% endtabs %}

![IsSelected TabItem](images/SelectedIndex.png)