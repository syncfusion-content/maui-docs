---
layout: post
title: How to programmatically select the tab item in .NET MAUI Tab View control | Syncfusion
description: Learn here all about select tab item programmatically in Syncfusion .NET MAUI Tab View(SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# How to select a tab item programmatically? 

Indicates whether the tab item is active or not. This property can be used to get selected item of tab view as like below code snippet.

{% tabs %}

{% highlight xaml %}
   <tabView:SfTabView x:Name="tabView">
                <tabView:SfTabView.Items>
                    <tabView:SfTabItem x:Name="tab1" Header="ITEM 1">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Red" />
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>

                    <tabView:SfTabItem x:Name="tab2" Header="ITEM 2">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Green"/>
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>

                    <tabView:SfTabItem x:Name="tab3" Header="ITEM 3">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Blue"/>
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>
                </tabView:SfTabView.Items>
            </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
private void Index_Changed(object sender, TabSelectionChangedEventArgs e)
{
    bool itemSelection = tab1.IsSelected;
    if (itemSelection)
    {
        tab1.FontSize = 20;
    }
}
{% endhighlight %}

{% endtabs %}