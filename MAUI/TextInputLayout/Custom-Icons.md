---
layout: post
title: Custom Icons in .NET MAUI Text Input Layout Control | Syncfusion®
description: Learn about Custom Icons support in Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui leading icon entry
---

# Custom Icons in .NET MAUI Text Input Layout (SfTextInputLayout)

The .NET MAUI Text Input Layout control allows custom icons to be added to either the leading or trailing edge of the input view. The associated events and commands should be handled at the application level. Unicode or font icons can be displayed as icons in labels.

For more information on font icons, refer to the following:
* [Create font icons using Syncfusion Metro Studio and export as TTF](https://help.syncfusion.com/metro-studio/export-icon-font)
* [Set font family for custom fonts in labels](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/fonts?view=net-maui-7.0#display-font-icons)

## Leading View

A label can be added as a leading icon for the input view by setting the [LeadingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_LeadingView) property. It can be positioned either inside or outside the container by setting the [LeadingViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_LeadingViewPosition) property, with the default position being [Outside](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ViewPosition.html#Syncfusion_Maui_Core_ViewPosition_Outside).

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

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Birth date";
inputLayout.LeadingViewPosition = ViewPosition.Inside;
inputLayout.LeadingView = new Label() { Text = "\U0001F5D3" };
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Leading view position](images/CustomIcons/LeadingView.png)

## Trailing View

A label can be added as a trailing icon for the input view by setting the [TrailingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_TrailingView) property. It can be positioned either inside or outside the container by setting the [TrailingViewPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_TrailingViewPosition) property, with the default position being [Inside](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ViewPosition.html#Syncfusion_Maui_Core_ViewPosition_Inside).

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

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Birth date";
inputLayout.TrailingViewPosition = ViewPosition.Outside; 
inputLayout. TrailingView = new Label() { Text = "\U0001F5D3" };
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Trailing view position](images/CustomIcons/TrailingView.png)

## Leading and Trailing View Visibility Customization

Control the visibility of the leading and trailing views using the [ShowLeadingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowLeadingView) and [ShowTrailingView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowTrailingView) properties in `SfTextInputLayout`.

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

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Birth date";
inputLayout.LeadingView = new Label() { Text = "\U0001F5D3" };
inputLayout.TrailingView = new Label() { Text = "\U0001F5D3" };
inputLayout.Content = new Entry();
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.ShowLeadingView = false;
inputLayout.ShowTrailingView = false;

{% endhighlight %}

{% endtabs %}

![Visibility customization](images/CustomIcons/LeadTrailCust.png)
