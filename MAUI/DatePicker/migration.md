---
layout: post
title: Migrate from Syncfusion Xamarin SfDatePicker to .NET MAUI SfDatePicker
description: Learn about migrating from Syncfusion Xamarin DatePicker to Syncfusion .NET MAUI DatePicker control.
platform: maui
control: SfDatePicker
documentation: ug
---  

# Migrate from Xamarin.Forms SfDatePicker to .NET MAUI SfDatePicker 

To make the migration from the [Xamarin SfDatePicker](https://www.syncfusion.com/xamarin-ui-controls/xamarin-datepicker) to [.NET MAUI SfDatePicker] easier, most of the APIs from the Xamarin SfDatePicker were kept in the .NET MAUI SfDatePicker. However, to maintain the consistency of API naming in the .NET MAUI SfDatePicker, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>Syncfusion.XForms.Pickers</td>
<td>Syncfusion.Maui.Picker</td></tr>
</table>

## Initialize control

To initialize the control, import the date picker namespace and initialize `SfDatePicker` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:datePicker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <datePicker:SfDatePicker />

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.XForms.Pickers;
...

SfDatePicker datePicker = new SfDatePicker();
this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:datePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <datePicker:SfDatePicker />

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfDatePicker datePicker = new SfDatePicker();
this.Content = datePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
<th>Description</th></tr>
<tr>
<td>{{'[PickerBase](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html)'| markdownify }}</td>
<td>{{'[PickerBase]'| markdownify }}</td>
<td>Represents a base used to achieve date picker custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[DatePickerColumnHeaderView]'| markdownify }}</td>
<td>Represents a column header view used to achieve date picker column header custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[PickerHeaderView]'| markdownify }}</td>
<td>Represents a header view used to achieve date picker header custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[PickerFooterView]'| markdownify }}</td>
<td>Represents a footer view used to achieve date picker footer custom view.</td>
</tr>
<tr>
<td>{{'[Nill]'| markdownify }}</td>
<td>{{'[PickerSelectionView]'| markdownify }}</td>
<td>Represents a selection view used to achieve date picker selection custom view.</td>
</tr>
<tr>
<td>{{'[DateChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.DateChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[DatePickerSelectionChangedEventArgs]' | markdownify }}</td>
<td>Represents a class which is used to hold the selection changed event details.</td>
</tr> 
</table>

## Properties

### SfDatePicker

The following code example, explains how to initialize the properties of the `Xamarin SfDatePicker` and `.NET MAUI SfDatePicker` class.

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:datePicker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">
    
    <datePicker:SfDatePicker Format="yyyy_MM_dd"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfDatePicker datePicker = new SfDatePicker();
this.Content = datePicker;
datePicker.Format = DateFormat.yyyy_MM_dd;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:datePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <datePicker:SfDatePicker Format="MM_dd_yyyy"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfDatePicker datePicker = new SfDatePicker();
this.Content = datePicker;
datePicker.Format = PickerDateFormat.MM_dd_yyyy;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CommandParameter](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_CommandParameterProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CancelCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_CancelCommandProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[Date](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DateProperty)'| markdownify }}</td>
<td>{{'[SelectedDate]'| markdownify }}</td>
<td>Gets or sets the selected date to select the particular date of the date picker.</td>
</tr>
<tr>
<td>{{'[DayHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DayHeaderTextProperty)'| markdownify }}</td>
<td>{{'[DayHeaderText](From [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the day header text to change the day column header.</td>
</tr>
<tr>
<td>{{'[DayInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DayIntervalProperty)'| markdownify }}</td>
<td>{{'[DayInterval]'| markdownify }}</td>
<td>Gets or sets the day interval to restrict the visible days.</td>
</tr>
<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_FormatProperty)'| markdownify }}</td>
<td>{{'[Format]'| markdownify }}</td>
<td>Get or set the format that is used to change the format of SfDatePicker.</td>
</tr>
<tr>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MaximumDateProperty)'| markdownify }}</td>
<td>{{'[MaximumDate]'| markdownify }}</td>
<td>Gets or sets the maximum date to restrict the visible dates in the SfDatePicker.</td>
</tr>
<tr>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MinimumDateProperty)'| markdownify }}</td>
<td>{{'[MinimumDate]'| markdownify }}</td>
<td>Gets or sets the minimum date to restrict the visible dates in the SfDatePicker.</td>
</tr>
<tr>
<td>{{'[MonthHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MonthHeaderTextProperty)'| markdownify }}</td>
<td>{{'[MonthHeaderText](From [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the month header text to change the month column header.</td>
</tr>
<tr>
<td>{{'[MonthInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MonthIntervalProperty)'| markdownify }}</td>
<td>{{'[MonthInterval]'| markdownify }}</td>
<td>Gets or sets the month interval to restrict the visible months.</td>
</tr>
<tr>
<td>{{'[OkCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_OkCommandProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[YearInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_YearIntervalProperty)'| markdownify }}</td>
<td>{{'[YearInterval]'| markdownify }}</td>
<td>Gets or sets the year interval to restrict the visible years.</td>
</tr>
<tr>
<td>{{'[YearHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_YearHeaderTextProperty)'| markdownify }}</td>
<td>{{'[YearHeaderText](From [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the year header text to change the year column header.</td>
</tr>
</table>

### PickerBase

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_BackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Gets or sets the background color of the datepicker.</td>
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
<td>{{'[BackgroundColor](From [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the background color of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](From [TextStyle] of [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the font attribute of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](From [TextStyle] of [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the font family of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](From [TextStyle] of [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the font size of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](From [DatePickerColumnHeaderView])'| markdownify }}</td>
<td>Gets or sets the height of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](From [TextStyle] of [DatePickerColumnHeaderView])'| markdownify }}</td>
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
<td>Gets or sets the value of footer view. This property can be used to customize the of Footer in DatePicker.</td>
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
<td>Gets or sets the value of header view. This property can be used to customize the of header in DatePicker.</td>
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

### DatePickerColumnHeaderView

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfDatePicker ShowColumnHeader="True"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfDatePicker datePicker = new SfDatePicker();
datePicker.ShowColumnHeader = true;
this.Content = datePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfDatePicker>
        <syncfusion:SfDatePicker.ColumnHeaderView>
            <syncfusion:DatePickerColumnHeaderView Height="50"/>
        </syncfusion:SfDatePicker.ColumnHeaderView>
    </syncfusion:SfDatePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfDatePicker datePicker = new SfDatePicker();
datePicker.ColumnHeaderView.Height = 50;
this.Content = datePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
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
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfDatePicker ShowHeader="True"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfDatePicker datePicker = new SfDatePicker();
datePicker.ShowHeader = true; 
this.Content = datePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfDatePicker>
        <syncfusion:SfDatePicker.HeaderView>
            <syncfusion:PickerHeaderView Height="50"/>
        </syncfusion:SfDatePicker.HeaderView>
    </syncfusion:SfDatePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfDatePicker datePicker = new SfDatePicker();
datePicker.HeaderView.Height = 50;
this.Content = datePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
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
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfDatePicker ShowFooter="True"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfDatePicker datepicker = new SfDatePicker();
datepicker.ShowFooter = true; 
this.Content = datepicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfDatePicker>
        <syncfusion:SfDatePicker.FooterView>
            <syncfusion:PickerFooterView Height="50"/>
        </syncfusion:SfDatePicker.FooterView>
    </syncfusion:SfDatePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfDatePicker datepicker = new SfDatePicker();
datepicker.FooterView.Height = 50;
this.Content = datepicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
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
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml%}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

    <syncfusion:SfDatePicker SelectionBackgroundColor="Red"/>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfPicker.XForms;
...

SfDatePicker datePicker = new SfDatePicker();
datePicker.SelectionBackgroundColor = Colors.Red; 
this.Content = datePicker;
{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfDatePicker>
        <syncfusion:SfDatePicker.SelectionView>
            <syncfusion:PickerSelectionView Background="Red"/>
        </syncfusion:SfDatePicker.SelectionView>
    </syncfusion:SfDatePicker>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;
...

SfDatePicker datePicker = new SfDatePicker();
datePicker.SelectionView.Background = Brush.Red;
this.Content = datePicker;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
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
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.DateFormat.html)'| markdownify }}</td>
<td>{{'[PickerDateFormat]'| markdownify }}</td>
<td>Defines the date format for the date picker.</td>
</tr>
<tr>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerMode.html)'| markdownify }}</td>
<td>{{'[PickerMode]'| markdownify }}</td>
<td>Defines the mode of the date picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[PickerRelativePosition]'| markdownify }}</td>
<td>Defines the relative position for the date picker.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfDatePicker</th>
<th>.NET MAUI SfDatePicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[Opened](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_Opened)'| markdownify }}</td>
<td>{{'[Opened]'| markdownify }}</td>
<td>Occurs whenever opened the date picker. </td>
</tr>
<tr>
<td>{{'[Closed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_Closed)'| markdownify }}</td>
<td>{{'[Closed]'| markdownify }}</td>
<td>Occurs whenever closed the date picker.</td>
</tr>
<tr>
<td>{{'[Closing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_Closing)'| markdownify }}</td>
<td>{{'[Closing]'| markdownify }}</td>
<td>Occurs whenever closing the date picker.</td>
</tr>
<tr>
<td>{{'[DateSelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DateSelected)'| markdownify }}</td>
<td>{{'[SelectionChanged]'| markdownify }}</td>
<td>Occurs whenever selection changed the date picker. </td>
</tr>
<tr>
<td>{{'[OkButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_OkButtonClicked)'| markdownify }}</td>
<td>{{'[OkButtonClicked]'| markdownify }}</td>
<td>Occurs whenever footer ok button is clicked in date picker.</td>
</tr>
<tr>
<td>{{'[CancelButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_CancelButtonClicked)'| markdownify }}</td>
<td>{{'[CancelButtonClicked]'| markdownify }}</td>
<td>Occurs whenever footer cancel button is clicked in date picker.</td>
</tr>
</table>