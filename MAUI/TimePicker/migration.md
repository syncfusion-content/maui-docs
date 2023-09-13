---
layout: post
title: Migrate from Syncfusion Xamarin SfTimePicker to .NET MAUI SfTimePicker
description: Learn about migrating from Syncfusion Xamarin TimePicker to Syncfusion .NET MAUI TimePicker control.
platform: maui
control: SfTimePicker
documentation: ug
---  

# Migrate from Xamarin.Forms SfTimePicker to .NET MAUI SfTimePicker 

To make the migration from the [Xamarin SfTimePicker](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html) to [.NET MAUI SfTimePicker] easier, most of the APIs from the Xamarin SfTimePicker were kept in the .NET MAUI SfTimePicker. However, to maintain the consistency of API naming in the .NET MAUI SfTimePicker, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>Syncfusion.XForms.Pickers</td>
<td>Syncfusion.Maui.Picker</td></tr>
</table>

## Initialize control

To initialize the control, import the time picker namespace and initialize `SfTimePicker` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:timePicker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <timePicker:SfTimePicker />

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.XForms.Pickers;
...

SfTimePicker timePicker = new SfTimePicker();
this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:timePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <timePicker:SfTimePicker />

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfTimePicker timePicker = new SfTimePicker();
this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th></tr>
<tr>
<td>{{'[PickerBase](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html)'| markdownify }}</td>
<td>{{'[PickerBase]'| markdownify }}</td>
<td>Represents a base used to achieve time picker custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[TimePickerColumnHeaderView]'| markdownify }}</td>
<td>Represents a column header view used to achieve time picker header custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[PickerHeaderView]'| markdownify }}</td>
<td>Represents a header view used to achieve time picker header custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[PickerFooterView]'| markdownify }}</td>
<td>Represents a footer view used to achieve time picker footer custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[PickerSelectionView]'| markdownify }}</td>
<td>Represents a selection view used to achieve time picker selection custom view.</td>
</tr>
<tr>
<td>{{'[TimeChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.TimeChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[TimePickerSelectionChangedEventArgs]' | markdownify }}</td>
<td>Represents a class which is used to hold the selection changed event details.</td>
</tr> 
</table>

## Properties

### SfTimePicker

The following code example, explains how to initialize the properties of the `Xamarin SfTimePicker` and `.NET MAUI SfTimePicker` class.

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:timePicker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">
    
    <timePicker:SfTimePicker Format="HH_mm_ss"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfTimePicker timePicker = new SfTimePicker();
this.Content = timePicker;
timePicker.Format = TimeFormat.HH_mm_ss;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:timePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <timePicker:SfTimePicker Format="h_mm_ss_tt"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfTimePicker timePicker = new SfTimePicker();
this.Content = timePicker;
timePicker.Format = PickerTimeFormat.h_mm_ss_tt;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CancelCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_CancelCommand)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CommandParameter](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_CommandParameter)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_Format)'| markdownify }}</td>
<td>{{'[Format]'| markdownify }}</td>
<td>Get or set the format that is used to change the format of SfTimePicker.</td>
</tr>
<tr>
<td>{{'[HeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_HeaderText)'| markdownify }}</td>
<td>{{'[Text](From [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the header text to change the text of the header.</td>
</tr>
<tr>
<td>{{'[HourHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_HourHeaderText)'| markdownify }}</td>
<td>{{'[HourHeaderText](From [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the hour header text to change the hour column header.</td>
</tr>
<tr>
<td>{{'[HourInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_HourInterval)'| markdownify }}</td>
<td>{{'[HourInterval]'| markdownify }}</td>
<td>Gets or sets the hour interval to restrict the visible hours.</td>
</tr>
<tr>
<td>{{'[MeridiemHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_MeridiemHeaderText)'| markdownify }}</td>
<td>{{'[MeridiemHeaderText](From [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the meridiem header text to change the meridiem column header.</td>
</tr>
<tr>
<td>{{'[MinuteInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_MinuteInterval)'| markdownify }}</td>
<td>{{'[MinuteInterval]'| markdownify }}</td>
<td>Gets or sets the minute interval to restrict the visible minutes.</td>
</tr>
<tr>
<td>{{'[MinutesHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_MinutesHeaderText)'| markdownify }}</td>
<td>{{'[MinuteHeaderText](From [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the hour header text to change the hour column header.</td>
</tr>
<tr>
<td>{{'[OkCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_OkCommand)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[SecondInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_SecondInterval)'| markdownify }}</td>
<td>{{'[SecondInterval]'| markdownify }}</td>
<td>Gets or sets the second interval to restrict the visible seconds.</td>
</tr>
<tr>
<td>{{'[SecondHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_SecondsHeaderText)'| markdownify }}</td>
<td>{{'[SecondHeaderText](From [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the hour header text to change the hour column header.</td>
</tr>
<tr>
<td>{{'[Time](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_Time)'| markdownify }}</td>
<td>{{'[SelectedTime]'| markdownify }}</td>
<td>Gets or sets the selected time to select the particular time of the time picker.</td>
</tr>
</table>

### PickerBase

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_BackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the timePicker.</td>
</tr>
<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_BorderColorProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CancelButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](From [PickerFooterView])'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[CancelButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle] of [PickerFooterView])'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](From [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the background color of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](From [TextStyle] of [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the font attribute of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [TextStyle] of [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the font family of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [TextStyle] of [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the font size of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](From [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the height of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle] of [TimePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the text color of the column header text style.</td>
</tr>
<tr>
<td>{{'[EnableLooping](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_EnableLoopingProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[FooterHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterHeightProperty)'| markdownify }}</td>
<td>{{'[Height](From [PickerFooterView])'| markdownify }}</td>
<td>Gets or sets the height of the footer view.</td>
</tr>
<tr>
<td>{{'[FooterView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterViewProperty)'| markdownify }}</td>
<td>{{'[FooterView]'| markdownify }}</td>
<td>Gets or sets the value of footer view. This property can be used to customize the of Footer in TimePicker.</td>
</tr>
<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](From [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the background color of the header.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttribute](From [TextStyle] of [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the font attribute of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [TextStyle] of [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the font family of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [TextStyle] of [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the font size of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](From [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the height of the header.</td>
</tr>
<tr>
<td>{{'[HeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle] of [PickerHeaderView])'| markdownify }}</td>
<td>Gets or sets the text color of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderViewProperty)'| markdownify }}</td>
<td>{{'[HeaderView]'| markdownify }}</td>
<td>Gets or sets the value of header view. This property can be used to customize the of header in Time Picker.</td>
</tr>
<tr>
<td>{{'[IsOpen](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_IsOpenProperty)'| markdownify }}</td>
<td>{{'[IsOpen]'| markdownify }}</td>
<td>Gets or sets the open to allow the dialog mode.</td>
</tr>
<tr>
<td>{{'[ItemHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ItemHeightProperty)'| markdownify }}</td>
<td>{{'[ItemHeight]'| markdownify }}</td>
<td>Gets or sets the item height of the each item source.</td>
</tr>
<tr>
<td>{{'[OkButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](From [PickerFooterView])'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[OkButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle] of [PickerFooterView])'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[PickerHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_PickerHeightProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[PickerWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_PickerWidthProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectionBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](From [PickerSelectionView])'| markdownify }}</td>
<td>Gets or sets the background color of the selected item.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](From [SelectedTextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the font attribute of the selected text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [SelectedTextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the font family of the selected text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [SelectedTextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the font size of the selected text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [SelectedTextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the text color of the selected text style.</td>
</tr>
<tr>
<td>{{'[ShowColumnHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ShowColumnHeaderProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShowFooter](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ShowFooterProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShowHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ShowHeaderProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](From [TextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the font attributes of the unselected text style..</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [TextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the font family of the unselected text style..</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [TextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the font size of the unselected text style..</td>
</tr>
<tr>
<td>{{'[UnSelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle] of [PickerBase])'| markdownify }}</td>
<td>Gets or sets the text color of the unselected text style..</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ColumnDividerColor]'| markdownify }}</td>
<td>Gets or sets the divider color of the columns.</td>
</tr>
</table>

### TimePickerColumnHeaderView

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfTimePicker ShowColumnHeader="True"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.ShowColumnHeader = true;
this.Content = timePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfTimePicker>
        <syncfusion:SfTimePicker.ColumnHeaderView>
            <syncfusion:TimePickerColumnHeaderView Height="50"/>
        </syncfusion:SfTimePicker.ColumnHeaderView>
    </syncfusion:SfTimePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.TimePickerColumnHeaderView.Height = 50;
this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[ColumnHeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the font attribute of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the font family of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the font size of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height]'| markdownify }}</td>
<td>Gets or sets the height of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the text color of the column header text style.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor]'| markdownify }}</td>
<td>Defines the divider color for the column header.</td>
</tr>
</table>

### PickerHeaderView

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfTimePicker ShowHeader="True"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.ShowHeader = true; 
this.Content = timePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfTimePicker>
        <syncfusion:SfTimePicker.HeaderView>
            <syncfusion:PickerHeaderView Height="50"/>
        </syncfusion:SfTimePicker.HeaderView>
    </syncfusion:SfTimePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.HeaderView.Height = 50;
this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the header.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttribute](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the font attribute of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the font family of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the font size of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height]'| markdownify }}</td>
<td>Gets or sets the height of the header.</td>
</tr>
<tr>
<td>{{'[HeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the text color of the header text style.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Text]'| markdownify }}</td>
<td>Defines the text for the header.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor]'| markdownify }}</td>
<td>Defines the divider color for the column header.</td>
</tr>
</table>

### PickerFooterView

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfTimePicker ShowFooter="True"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.ShowFooter = true; 
this.Content = timePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfTimePicker>
        <syncfusion:SfTimePicker.FooterView>
            <syncfusion:PickerFooterView Height="50"/>
        </syncfusion:SfTimePicker.FooterView>
    </syncfusion:SfTimePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.FooterView.Height = 50;
this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CancelButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[FooterHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterHeightProperty)'| markdownify }}</td>
<td>{{'[Height]'| markdownify }}</td>
<td>Gets or sets the height of the footer view.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor]'| markdownify }}</td>
<td>Defines the divider color for the footer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[OkButtonText]'| markdownify }}</td>
<td>Defines the ok button text of the footer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[CancelButtonText]'| markdownify }}</td>
<td>Defines the cancel button text for the footer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ShowOkButton]'| markdownify }}</td>
<td>Defines the show ok button for the footer.</td>
</tr>
<tr>
<td>{{'[OkButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[OkButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle])'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
</table>

### PickerSelectionView

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfTimePicker SelectionBackgroundColor="Red"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.SelectionBackgroundColor = Colors.Red; 
this.Content = timePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfTimePicker>
        <syncfusion:SfTimePicker.SelectionView>
            <syncfusion:PickerSelectionView Background="Red"/>
        </syncfusion:SfTimePicker.SelectionView>
    </syncfusion:SfTimePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfTimePicker timePicker = new SfTimePicker();
timePicker.SelectionView.Background = Brush.Red;
this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Stroke]'| markdownify }}</td>
<td>Defines the stroke color for the selection.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[CornerRadius]'| markdownify }}</td>
<td>Defines the corner radius of the selection.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Padding]'| markdownify }}</td>
<td>Defines the padding for the selection.</td>
</tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectionBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the selected item.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[TimeFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.TimeFormat.html)'| markdownify }}</td>
<td>{{'[PickerTimeFormat]'| markdownify }}</td>
<td>Defines the time format for the time picker.</td>
</tr>
<tr>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerMode.html)'| markdownify }}</td>
<td>{{'[PickerMode]'| markdownify }}</td>
<td>Defines the mode of the time picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[PickerRelativePosition]'| markdownify }}</td>
<td>Defines the relative position for the time picker.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfTimePicker</th>
<th>.NET MAUI SfTimePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[Opened](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_Opened)'| markdownify }}</td>
<td>{{'[Opened]'| markdownify }}</td>
<td>Occurs whenever the opened on time picker. </td>
</tr>
<tr>
<td>{{'[Closed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_Closed)'| markdownify }}</td>
<td>{{'[Closed]'| markdownify }}</td>
<td>Occurs whenever the closed on time picker.</td>
</tr>
<tr>
<td>{{'[Closing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_Closing)'| markdownify }}</td>
<td>{{'[Closing]'| markdownify }}</td>
<td>Occurs whenever the closing on time picker.</td>
</tr>
<tr>
<td>{{'[TimeSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_TimeSelected)'| markdownify }}</td>
<td>{{'[SelectionChanged]'| markdownify }}</td>
<td>Occurs whenever the selection changed on time picker. </td>
</tr>
<tr>
<td>{{'[OkButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_OkButtonClicked)'| markdownify }}</td>
<td>{{'[OkButtonClicked]'| markdownify }}</td>
<td>Occurs whenever the footer ok button is clicked in time picker.</td>
</tr>
<tr>
<td>{{'[CancelButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfTimePicker.html#Syncfusion_XForms_Pickers_SfTimePicker_CancelButtonClicked)'| markdownify }}</td>
<td>{{'[CancelButtonClicked]'| markdownify }}</td>
<td>Occurs whenever the footer cancel button is clicked in time picker.</td>
</tr>
</table>