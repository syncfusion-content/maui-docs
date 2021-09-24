---
layout: post
title: Display Type in MAUI TabView control | Syncfusion
description: Learn here all about Display Type support in Syncfusion MAUI TabView (SfTabView) control and more.
platform: MAUI
control: TabView
documentation: ug
---
# How to set and customize tab bar appearance in the header?

## Header

[Header](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_Header) property used to set the header of text of each tab item. This will be the title of the respective tab item's content.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView>
    <tabView:SfTabItem Header="TAB 1">
        <tabView:SfTabItem.Content>
            <Label Text="First tab content" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}

{% endtabs %}

## Tab header text color

[TextColor](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_TextColorProperty) property used to change the tab bar headers text colors of SfTabItem.

## Font Attribute

[FontAttribute](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontAttributes) property used to change the atrribute font in SfTabItem.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView>
    <tabView:SfTabItem FontAttributes="Bold">
        <tabView:SfTabItem.Content>
            <Label Text="Tab content" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}

{% endtabs %}

## Font Family

[FontFamily](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontFamily) property used to change the style of font in SfTabItem.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView>
    <tabView:SfTabItem FontFamily="OpenSansRegular">
        <tabView:SfTabItem.Content>
            <Label Text="Tab content" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}

{% endtabs %}

## Font Size

[FontSize](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontSize) property used to change the size of font in SfTabItem.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView>
    <tabView:SfTabItem FontFamily="OpenSansRegular">
        <tabView:SfTabItem.Content>
            <Label Text="Tab content" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}

{% endtabs %}

## ImageSource

[ImageSource](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImageSource) property used to set the header image of the each tab item.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView>
    <tabView:SfTabItem ImageSource="image_name">
        <tabView:SfTabItem.Content>
            <Label Text="Tab content" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}

{% endtabs %}

## IsSelected

[IsSelected](https://npmci.syncfusion.com/maui/api/development/maui-tabview/api/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_IsSelected) property indicates whether the item is selected or not. This property can be used to change selected item of tab view through code behind.