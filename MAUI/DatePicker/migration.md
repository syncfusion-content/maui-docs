---
layout: post
title: Migrate from Syncfusion Xamarin SfDatePicker to .NET MAUI SfDatePicker
description: Learn about migrating from Syncfusion Xamarin DatePicker to Syncfusion .NET MAUI DatePicker control.
platform: maui
control: SfDatePicker
documentation: ug
---  

# Migrate from Xamarin.Forms SfDatePicker to .NET MAUI SfDatePicker 

To make the migration from the [Xamarin SfDatePicker](https://www.syncfusion.com/xamarin-ui-controls/xamarin-datepicker) to [.NET MAUI SfDatePicker] easier, most of the APIs from the Xamarin SfDatePicker are kept in the .NET MAUI SfDatePicker. However, to maintain the consistency of API naming in the .NET MAUI SfDatePicker, some of the APIs have been renamed. Please find the difference in the following topics.

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
<td>{{'[PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html)'| markdownify }}</td>
<td>Represents a base used to achieve the date picker custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html)'| markdownify }}</td>
<td>Represents a column header view used to achieve the date picker column header custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html)'| markdownify }}</td>
<td>Represents a header view used to achieve the date picker header custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html)'| markdownify }}</td>
<td>Represents a footer view used to achieve the date picker footer custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html)'| markdownify }}</td>
<td>Represents a selection view used to achieve the date picker selection custom view.</td>
</tr>
<tr>
<td>{{'[DateChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.DateChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[DatePickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerSelectionChangedEventArgs.html)' | markdownify }}</td>
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
<td>{{'[SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate)'| markdownify }}</td>
<td>Gets or sets the selected date to select the particular date of the date picker.</td>
</tr>
<tr>
<td>{{'[DayHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DayHeaderTextProperty)'| markdownify }}</td>
<td>{{'[DayHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DayHeaderText)(From [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the day header text to change the day column header.</td>
</tr>
<tr>
<td>{{'[DayInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DayIntervalProperty)'| markdownify }}</td>
<td>{{'[DayInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_DayInterval)'| markdownify }}</td>
<td>Gets or sets the day interval to restrict the visible days.</td>
</tr>
<tr>
<td>{{'[Format](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_FormatProperty)'| markdownify }}</td>
<td>{{'[Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_Format)'| markdownify }}</td>
<td>Gets or set the format that is used to change the format of SfDatePicker.</td>
</tr>
<tr>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MaximumDateProperty)'| markdownify }}</td>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MaximumDate)'| markdownify }}</td>
<td>Gets or sets the maximum date to restrict the visible dates in the SfDatePicker.</td>
</tr>
<tr>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MinimumDateProperty)'| markdownify }}</td>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MinimumDate)'| markdownify }}</td>
<td>Gets or sets the minimum date to restrict the visible dates in the SfDatePicker.</td>
</tr>
<tr>
<td>{{'[MonthHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MonthHeaderTextProperty)'| markdownify }}</td>
<td>{{'[MonthHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_MonthHeaderText)(From [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the month header text to change the month column header.</td>
</tr>
<tr>
<td>{{'[MonthInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_MonthIntervalProperty)'| markdownify }}</td>
<td>{{'[MonthInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MonthInterval)'| markdownify }}</td>
<td>Gets or sets the month interval to restrict the visible months.</td>
</tr>
<tr>
<td>{{'[OkCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_OkCommandProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[YearInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_YearIntervalProperty)'| markdownify }}</td>
<td>{{'[YearInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_YearInterval)'| markdownify }}</td>
<td>Gets or sets the year interval to restrict the visible years.</td>
</tr>
<tr>
<td>{{'[YearHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_YearHeaderTextProperty)'| markdownify }}</td>
<td>{{'[YearHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_YearHeaderText)(From [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
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
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html)'| markdownify }}</td>
<td>Gets or sets the background color of the datepicker.</td>
</tr>
<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_BorderColorProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CancelButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background)(From [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html))'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[CancelButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) of [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html))'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_Background)(From [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the background color of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle) of [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the font attribute of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle) of [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the font family of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle) of [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the font size of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_Height)(From [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the height of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle) of [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the text color of the column header text style.</td>
</tr>
<tr>
<td>{{'[EnableLooping](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_EnableLoopingProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[FooterHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterHeightProperty)'| markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height)(From [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html))'| markdownify }}</td>
<td>Gets or sets the height of the footer view.</td>
</tr>
<tr>
<td>{{'[FooterView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterViewProperty)'| markdownify }}</td>
<td>{{'[FooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html)'| markdownify }}</td>
<td>Gets or sets the value of footer view. This property can be used to customize the Footer in DatePicker.</td>
</tr>
<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Background)(From [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the background color of the header.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the font attribute of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the font family of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the font size of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height)(From [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the height of the header.</td>
</tr>
<tr>
<td>{{'[HeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))'| markdownify }}</td>
<td>Gets or sets the text color of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderViewProperty)'| markdownify }}</td>
<td>{{'[HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html)'| markdownify }}</td>
<td>Gets or sets the value of header view. This property can be used to customize the header in DatePicker.</td>
</tr>
<tr>
<td>{{'[IsOpen](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_IsOpenProperty)'| markdownify }}</td>
<td>{{'[IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen)'| markdownify }}</td>
<td>Gets or sets the open to allow the dialog mode.</td>
</tr>
<tr>
<td>{{'[ItemHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ItemHeightProperty)'| markdownify }}</td>
<td>{{'[ItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ItemHeight)'| markdownify }}</td>
<td>Gets or sets the item height of each item source.</td>
</tr>
<tr>
<td>{{'[OkButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background)(From [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html))'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[OkButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) of [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html))'| markdownify }}</td>
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
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Background)(From [PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html))'| markdownify }}</td>
<td>Gets or sets the background color of the selected item.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the font attribute of the selected text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the font family of the selected text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the font size of the selected text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
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
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the font attributes of the unselected text style..</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the font family of the unselected text style..</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the font size of the unselected text style..</td>
</tr>
<tr>
<td>{{'[UnSelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))'| markdownify }}</td>
<td>Gets or sets the text color of the unselected text style..</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ColumnDividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor)'| markdownify }}</td>
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
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_Background)'| markdownify }}</td>
<td>Gets or sets the background color of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the font attribute of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the font family of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the font size of the column header text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_Height)'| markdownify }}</td>
<td>Gets or sets the height of the column header.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the text color of the column header text style.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DividerColor)'| markdownify }}</td>
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
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Background)'| markdownify }}</td>
<td>Gets or sets the background color of the header.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[FontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the font attribute of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the font family of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the font size of the header text style.</td>
</tr>
<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderHeightProperty)'| markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height)'| markdownify }}</td>
<td>Gets or sets the height of the header.</td>
</tr>
<tr>
<td>{{'[HeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle))'| markdownify }}</td>
<td>Gets or sets the text color of the header text style.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text)'| markdownify }}</td>
<td>Defines the text for the header.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor)'| markdownify }}</td>
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
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background)'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[FooterHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterHeightProperty)'| markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height)'| markdownify }}</td>
<td>Gets or sets the height of the footer view.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_DividerColor)'| markdownify }}</td>
<td>Defines the divider color for the footer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText)'| markdownify }}</td>
<td>Defines the ok button text of the footer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText)'| markdownify }}</td>
<td>Defines the cancel button text for the footer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton)'| markdownify }}</td>
<td>Defines the show ok button for the footer.</td>
</tr>
<tr>
<td>{{'[OkButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background)'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td>
</tr>
<tr>
<td>{{'[OkButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_OKButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle))'| markdownify }}</td>
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
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Stroke)'| markdownify }}</td>
<td>Defines the stroke color for the selection.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_CornerRadius)'| markdownify }}</td>
<td>Defines the corner radius of the selection.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Padding)'| markdownify }}</td>
<td>Defines the padding for the selection.</td>
</tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectionBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Background)'| markdownify }}</td>
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
<td>{{'[PickerDateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html)'| markdownify }}</td>
<td>Defines the date format for the date picker.</td>
</tr>
<tr>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerMode.html)'| markdownify }}</td>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html)'| markdownify }}</td>
<td>Defines the mode of the date picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[PickerRelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerRelativePosition.html)'| markdownify }}</td>
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
<td>{{'[Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)'| markdownify }}</td>
<td>Occurs whenever opened on the date picker. </td>
</tr>
<tr>
<td>{{'[Closed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_Closed)'| markdownify }}</td>
<td>{{'[Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)'| markdownify }}</td>
<td>Occurs whenever closed on the date picker.</td>
</tr>
<tr>
<td>{{'[Closing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_Closing)'| markdownify }}</td>
<td>{{'[Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)'| markdownify }}</td>
<td>Occurs whenever closing on the date picker.</td>
</tr>
<tr>
<td>{{'[DateSelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_DateSelected)'| markdownify }}</td>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChanged)'| markdownify }}</td>
<td>Occurs whenever selection changed on the the date picker. </td>
</tr>
<tr>
<td>{{'[OkButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_OkButtonClicked)'| markdownify }}</td>
<td>{{'[OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked)'| markdownify }}</td>
<td>Occurs whenever footer ok button is clicked in the date picker.</td>
</tr>
<tr>
<td>{{'[CancelButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfDatePicker.html#Syncfusion_XForms_Pickers_SfDatePicker_CancelButtonClicked)'| markdownify }}</td>
<td>{{'[CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked)'| markdownify }}</td>
<td>Occurs whenever footer cancel button is clicked in the date picker.</td>
</tr>
</table>