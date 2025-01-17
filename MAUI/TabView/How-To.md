---
layout: post
title: Select tab in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn here all about select tab item programmatically in Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# How to select a tab item programmatically? 

## Programmatically select the tab item

Using the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView, we can programmatically select the tab item as like in the below code snippet.

{% tabs %}

{% highlight xaml %}
   <tabView:SfTabView x:Name="tabView" SelectedIndex="2"/>
{% endhighlight %}

{% highlight C# %}
    tabView.SelectedIndex = 2;
{% endhighlight %}
{% endtabs %}

![SelectedIndex in SfTabView](images/SelectedIndexTabView.png)

## Get the selected tab item using IsSelected

Indicates whether the tab item is active or not. This property can be used to get selected item of tab view as like below code snippet.

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