---
layout: post
title: Custom Icons in .NET MAUI Text Input Layout control | Syncfusion
description: Learn here all about Custom Icons support in Syncfusion .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui leading icon entry.
---

# Custom Icons in .NET MAUI Text Input Layout (SfTextInputLayout)

Any custom icons can be added to the leading edge or the trailing edge of the input view in the text input layout control. The events and commands related to the custom icons should be handled at the application level.

Unicode or font icons for the labels can be displayed as icons.

N> Refer to the following links to learn more about font icons:
* [How to create font icons using our metro studio and export as ttf?](https://help.syncfusion.com/metro-studio/export-icon-font)
* [How to set font family for the custom fonts in labels?](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/fonts?view=net-maui-7.0#display-font-icons)

## Leading view

A label can be added as a leading icon for the input view by setting the [LeadingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_LeadingView) property. It can be positioned either inside or outside the container by setting the [LeadingViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_LeadingViewPosition) property. By default, it is positioned [Outside](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ViewPosition.html#Syncfusion_Maui_Core_ViewPosition_Outside).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Birth date"
                               LeadingViewPosition="Inside" >
    <Entry />
    <inputLayout:SfTextInputLayout.LeadingView>
       <Label
           Text="&#x1F5D3;">     
       </Label>
    </inputLayout:SfTextInputLayout.LeadingView>
</inputLayout:SfTextInputLayout> 

{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Birth date";
inputLayout.LeadingViewPosition = ViewPosition.Inside;
inputLayout.LeadingView = new Label() { Text = "\U0001F5D3" };
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Leading view position](images/CustomIcons/LeadingView.png)

## Trailing  view

A label can be added as a trailing icon for the input view by setting the [TrailingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_TrailingView) property. It can be positioned either inside or outside the container of the input view by setting the [TrailingViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_TrailingViewPosition) property. By default, it is positioned as [Inside](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ViewPosition.html#Syncfusion_Maui_Core_ViewPosition_Inside).

{% tabs %}

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Birth date"
                               TrailingViewPosition="Outside">
    <Entry  />
    <inputLayout:SfTextInputLayout.TrailingView>
      <Label
         Text="&#x1F5D3;">     
      </Label>
    </inputLayout:SfTextInputLayout.TrailingView>
</inputLayout:SfTextInputLayout> 

{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Birth date";
inputLayout.TrailingViewPosition = ViewPosition.Outside; 
inputLayout. TrailingView = new Label() { Text = "\U0001F5D3" };
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Trailing view position](images/CustomIcons/TrailingView.png)


## Leading and trailing view visibility customization

The [ShowLeadingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowLeadingView) and [ShowTrailingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowTrailingView) properties in the SfTextInputLayout can be used to control the visibility of the leading and trailing views, respectively.

{% tabs %}

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Birth date"
                               ContainerType="Outlined"
                               ShowLeadingView="False"
                               ShowTrailingView="False" >
   <Entry />
   <inputLayout:SfTextInputLayout.LeadingView>
      <Label
         Text="&#x1F5D3;">     
      </Label>
   </inputLayout:SfTextInputLayout.LeadingView>
   <inputLayout:SfTextInputLayout.TrailingView>
   <Label
      Text="&#x1F5D3;">     
   </Label>
   </inputLayout:SfTextInputLayout.TrailingView>
</inputLayout:SfTextInputLayout> 

{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Birth date";
inputLayout.LeadingView = new Label() { Text = "\U0001F5D3" };
inputLayout.TrailingView = new Label() { Text = "\U0001F5D3" };
inputLayout.Content = new Entry();
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.ShowLeadingView = false;
inputLayout.ShowTrailingView = false;

{% endhighlight %}

{% endtabs %}

![Visibility customisation](images/CustomIcons/LeadTrailCust.png)
