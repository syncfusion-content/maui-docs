---
layout: post
title: Migrate from Syncfusion Xamarin SfPicker to .NET MAUI SfPicker
description: Learn here all about Migrating from Syncfusion Xamarin Picker to Syncfusion .NET MAUI Picker control.
platform: maui
control: SfPicker
documentation: ug
---  

# Migrate from Xamarin.Forms SfPicker to .NET MAUI SfPicker 

To make the migration from the [Xamarin SfPicker](https://www.syncfusion.com/xamarin-ui-controls/xamarin-picker) to [.NET MAUI SfPicker]() easier, most of the APIs from the Xamarin SfPicker were kept in the .NET MAUI SfPicker. However, to maintain the consistency of API naming in the .NET MAUI SfPicker, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th></tr>
<tr>
<td>Syncfusion.XForms.Pickers</td>
<td>Syncfusion.Maui.Picker</td></tr>
</table>

## Initialize control

To initialize the control, import the picker namespace and initialize `SfPicker` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th></tr>
<tr>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

        <picker:SfPicker />

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.XForms.Pickers;
    ...

    SfPicker picker = new SfPicker();
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

        <picker:SfPicker />

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Picker;
    ...

    SfPicker picker = new SfPicker();
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th></tr>
<tr>
<td>{{'[PickerBase](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html)'| markdownify }}</td>
<td>{{'[PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html)'| markdownify }}</td>
<td>Represents a base used to achieve picker custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html)'| markdownify }}</td>
<td>Represents a class which is used to customize all the properties of picker column of the SfPicker.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerColumnHeaderView]()'| markdownify }}</td>
<td>Represents a column header view used to achieve picker column header custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html)'| markdownify }}</td>
<td>Represents a header view used to achieve picker header custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html)'| markdownify }}</td>
<td>Represents a footer view used to achieve picker footer custom view.</td>
</tr>
<tr>
<td>{{'[Nil]'| markdownify }}</td>
<td>{{'[PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html)'| markdownify }}</td>
<td>Represents a selection view used to achieve picker selection custom view.</td>
</tr>
<tr>
<td>{{'[PickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[PickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionChangedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the selection changed event details.</td>
</tr> 
</table>

## Properties

### SfPicker

The following code example, explains how to initialize the properties of the `Xamarin SfPicker` and `.NET MAUI SfPicker` class.

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th></tr>
<tr>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">

        <picker:SfPicker/>
        
    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfPicker.XForms;
    ...

    SfPicker picker = new SfPicker();
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

        <picker:SfPicker/>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Picker;
    ..

    SfPicker picker = new SfPicker();
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[HeaderView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderViewProperty)'| markdownify }}</td>
<td>{{'[HeaderView]https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_HeaderView)'| markdownify }}</td>
<td>Gets or sets the value of header view. This property can be used to customize the of header in SfPicker.</td>
</tr>
<tr>
<td>{{'[FooterView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_FooterViewProperty)'| markdownify }}</td>
<td>{{'[FooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterView)'| markdownify }}</td>
<td>Gets or sets the value of footer view. This property can be used to customize the of Footer in Picker.</td>
</tr>
<tr>
<td>{{'[ItemTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ItemTemplate)'| markdownify }}</td>
<td>{{'[ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_ItemTemplate)'| markdownify }}</td>
<td>Gets or sets the picker item template in SfPicker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_Columns)'| markdownify }}</td>
<td>Gets or sets the value of picker columns. This property can be used to customize the of column in SfPicker.</td>
</tr>
<tr>
<td>{{'[IsOpen](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_IsOpenProperty)'| markdownify }}</td>
<td>{{'[IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the picker is open or not.</td>
</tr>
<tr>
<td>{{'[ItemHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ItemHeightProperty)'| markdownify }}</td>
<td>{{'[ItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ItemHeight) of [PickerBase]()'| markdownify }}</td>
<td>Gets or sets the value to specify the height of picker view on Picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[SelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectionView)'| markdownify }}</td>
<td>Gets or sets the value of selection view. This property can be used to customize the of selection in Picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle)'| markdownify }}</td>
<td>Gets or sets the picker selected text style in Picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle)'| markdownify }}</td>
<td>Gets or sets the picker item text style in Picker.</td>
</tr>
<tr>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_PickerMode)'| markdownify }}</td>
<td>{{'[Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode)'| markdownify }}</td>
<td>Gets or sets the mode of the picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ColumnDividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor)'| markdownify }}</td>
<td>Gets or sets the value of column divider color in SfPicker. This property can be used to customize the of column divider color in Picker.</td>
</tr>
<tr>
<td>{{'[EnableLooping](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_EnableLoopingProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition)'| markdownify }}</td>
<td>Gets or sets the relative position of the picker popup.</td>
</tr>
<tr>
<td>{{'[CommandParameter](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_CommandParameterProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[OkCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_OkCommandProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CancelCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_CancelCommandProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShowHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ShowHeaderProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShowFooter](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ShowFooter)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
</table>

### Picker Base

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_BorderColorProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShowFooter](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ShowFooterProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[PickerHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_PickerHeightProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_BackgroundColorProperty)'| markdownify }}</td>
<td>{{'[Background]()'| markdownify }}</td>
<td>Gets or sets the background color of the picker.</td>
</tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectionBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Background)(From [PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html))]'| markdownify }}</td>
<td>Gets or sets the background color of the selected item.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemTextColorProperty)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) of [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font attribute of the text style.</td>
</tr>
<tr>
<td>{{'[PickerWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_PickerWidthProperty)'| markdownify }}</td>
<td>{{'[[Width]()(From [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_Width))]'| markdownify }}</td>
<td>Gets or sets the width of the column.</td>
</tr>
<tr>
<td>{{'[HeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontAttributeProperty)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font attribute of the text style.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_UnselectedItemFontSizeProperty)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemTextColorProperty)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[ShowColumnHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ShowColumnHeaderProperty)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontSizeProperty)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontFamilyProperty)'| markdownify }}</td>
<td>{{'[[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[SelectedItemFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_SelectedItemFontAttributeProperty)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font attribute of the text style.</td>
</tr>
<tr>
<td>{{'[PickerHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_PickerHeight)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[PickerWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_PickerWidth)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_UnSelectedItemFontAttribute)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font attribute of the text style.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_UnSelectedItemFontFamily)'| markdownify }}</td>
<td>{{'[[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_UnSelectedItemFontSize)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[UnSelectedItemTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_UnSelectedItemTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle) of [PickerBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html))]'| markdownify }}</td>
<td>Gets or sets the font text color of the text style.</td>
</tr>
<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_BorderColor)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
</table>

## Picker Column

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Width]()'| markdownify }}</td>
<td>Gets or sets the value to specify the width of columns on SfPicker.</td>
</tr>
<tr>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ItemsSource)'| markdownify }}</td>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_ItemsSource)'| markdownify }}</td>
<td>Gets or sets the value to specify the text of columns on SfPicker.</td>
</tr>
<tr>
<td>{{'[SelectedIndex](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_SelectedIndex)'| markdownify }}</td>
<td>{{'[SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex)'| markdownify }}</td>
<td>Gets or sets the selected index of the columns on SfPicker.</td>
</tr>
<tr>
<td>{{'[HeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_HeaderText)'| markdownify }}</td>
<td>{{'[HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_HeaderText)'| markdownify }}</td>
<td>Gets or sets the value to specify the header text of the columns on SfPicker.</td>
</tr>
<tr>
<td>{{'[DisplayMemberPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_DisplayMemberPath)'| markdownify }}</td>
<td>{{'[DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_DisplayMemberPath)'| markdownify }}</td>
<td>Gets or sets the value to specify the path value for items source.</td>
</tr>
</table>

## PickerSelectionView

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th></tr>
<tr>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">
        
        <picker:SfPicker SelectionBackgroundColor="Red"/>

    </ContentPage>
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfPicker.XForms;
    ...

    SfPicker picker = new SfPicker();
    picker.SelectionBackgroundColor = Colors.Red; 
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

        <picker:SfPicker>
            <picker:SfPicker.SelectionView>
                <picker:PickerSelectionView Background="Red"/>
            </picker:SfPicker.SelectionView>
        </picker:SfPicker>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Picker;
    ...

    SfPicker picker = new SfPicker();
    picker.SelectionView.Background = Brush.Red;
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_SelectionBackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Background) '| markdownify }}</td>
<td>Gets or sets the background of the selection view in SfPicker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color of the selection view in SfPicker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_CornerRadius)'| markdownify }}</td>
<td>Gets or sets the corner radius of the selection view in SfPicker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Padding)'| markdownify }}</td>
<td>Gets or sets the padding value of the selection view in SfPicker.</td>
</tr>
</table>

## Picker Header View

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
</tr>
<tr>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">
        
        <picker:SfPicker HeaderHeight="50"/>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfPicker.XForms;
    ...

    SfPicker picker = new SfPicker();
    picker.HeaderHeight = 50; 
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

        <picker:SfPicker>
            <picker:SfPicker.HeaderView>
                <picker:PickerHeaderView Height="50"/>
            </picker:SfPicker.HeaderView>
        </picker:SfPicker>
    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Picker;
    ...

    SfPicker picker = new SfPicker();
    picker.HeaderView.Heigt = 50;
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th></tr>
<tr>
<td>{{'[HeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_HeaderTextProperty)'| markdownify }}</td>
<td>{{'[[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text) '| markdownify }}</td>
<td>Gets or sets the value to specify the text of header view on picker.</td>
</tr>
<tr>
<td>{{'[HeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderFontAttributeProperty)'| markdownify }}</td>
<td>{{'[[FontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font attribute of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderHeightProperty)'| markdownify }}</td>
<td>{{'[[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height) '| markdownify }}</td>
<td>Gets or sets the value to specify the height of header view on picker.</td>
</tr>
<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Background) '| markdownify }}</td>
<td>Gets or sets the background of the header view in picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor)'| markdownify }}</td>
<td>Gets or sets the color of the header separator line in picker.</td>
</tr>
</table>

## Picker Column Header View

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th></tr>
<tr>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">
        
        <picker:SfPicker ColumnHeaderHeight="50"/>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfPicker.XForms;
    ...

    SfPicker picker = new SfPicker();
    picker.ColumnHeaderHeight = 50; 
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

        <picker:SfPicker>
            <picker:SfPicker.ColumnHeaderView>
                <picker:PickerColumnHeaderView Height="50"/>
            </picker:SfPicker.ColumnHeaderView>
        </picker:SfPicker>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Picker;
    ...

    SfPicker picker = new SfPicker();
    picker.ColumnHeaderView.Heigt = 50;
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th></tr>
<tr>
<td>{{'[ColumnHeaderText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_HeaderText)(From [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_HeaderTextColorProperty)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) of [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontFamilyProperty)'| markdownify }}</td>
<td>{{'[[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) of [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ColumnHeaderFontAttribute)'| markdownify }}</td>
<td>{{'[[FontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) of [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ColumnHeaderFontSize)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) of [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ColumnHeaderHeight)'| markdownify }}</td>
<td>{{'[[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_Height) '| markdownify }}</td>
<td>Gets or sets the value to specify the height of column header view on SfPicker.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_ColumnHeaderBackgroundColor)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_Background) '| markdownify }}</td>
<td>Gets or sets the background of the column header view in SfPicker.</td>
</tr>
<tr>
<td>{{'[ColumnHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_ColumnHeaderFontSizeProperty)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) of [PickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_DividerColor)'| markdownify }}</td>
<td>Gets or sets the background of the column header separator line background in SfPicker.</td>
</tr>
</table>

## Picker Footer View

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th></tr>
<tr>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.XForms.Pickers;assembly=Syncfusion.SfPicker.XForms">
        
        <picker:SfPicker FooterHeight="50"/>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfPicker.XForms;
    ...

    SfPicker picker = new SfPicker();
    picker.FooterHeight = 50; 
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml %}

    <ContentPage
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

        <picker:SfPicker>
            <picker:SfPicker.FooterView>
                <picker:PickerFooterView Height="50"/>
            </picker:SfPicker.FooterView>
        </picker:SfPicker>

    </ContentPage>

{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.Picker;
    ...

    SfPicker picker = new SfPicker();
    picker.FooterView.Heigt = 50;
    this.Content = picker;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CancelButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonBackgroundColorProperty)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background) '| markdownify }}</td>
<td>Gets or sets the background of the footer view in SfPicker.</td>
</tr>
<tr>
<td>{{'[CancelButtonTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerHelper.PickerBase.html#Syncfusion_XForms_Pickers_PickerHelper_PickerBase_CancelButtonTextColorProperty)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html#Syncfusion_Maui_Picker_PickerTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) of [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[OKButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_OKButtonBackgroundColor)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background) '| markdownify }}</td>
<td>Gets or sets the background of the footer view in SfPicker.</td>
</tr>
<tr>
<td>{{'[FooterHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_FooterHeight)'| markdownify }}</td>
<td>{{'[[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) '| markdownify }}</td>
<td>Gets or sets the value to specify the height of footer view on SfPicker.</td>
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
<td>Gets or sets a value indicating whether to show the cancel button in the footer view of SfPicker.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.PickerMode.html)'| markdownify }}</td>
<td>{{'[PickerMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html)'| markdownify }}</td>
<td>Defines the mode of the Picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[PickerRelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerRelativePosition.html)'| markdownify }}</td>
<td>Defines the relative position for the Picker.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfPicker</th>
<th>.NET MAUI SfPicker</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPicker.XForms.SfPicker.html#Syncfusion_SfPicker_XForms_SfPicker_SelectionChanged)'| markdownify }}</td>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_SelectionChanged)'| markdownify }}</td>
<td>Occurs after the selected index changed on SfPicker.</td>
</tr>
<tr>
<td>{{'[Opened](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_Opened)'| markdownify }}</td>
<td>{{'[Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)'| markdownify }}</td>
<td>Occurs whenever the opened on Picker. </td>
</tr>
<tr>
<td>{{'[Closed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_Closed)'| markdownify }}</td>
<td>{{'[Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)'| markdownify }}</td>
<td>Occurs whenever the closed on Picker.</td>
</tr>
<tr>
<td>{{'[Closing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_Closing)'| markdownify }}</td>
<td>{{'[Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)'| markdownify }}</td>
<td>Occurs whenever the closing on Picker.</td>
</tr>
<tr>
<td>{{'[OkButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_OkButtonClicked)'| markdownify }}</td>
<td>{{'[OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked)'| markdownify }}</td>
<td>Occurs whenever the footer ok button is clicked in Picker.</td>
</tr>
<tr>
<td>{{'[CancelButtonClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Pickers.SfPicker.html#Syncfusion_XForms_Pickers_SfPicker_CancelButtonClicked)'| markdownify }}</td>
<td>{{'[CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked)'| markdownify }}</td>
<td>Occurs whenever the footer cancel button is clicked in Picker.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[PickerItemDetails](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerItemDetails.html)'| markdownify }}</td>
<td>Represents a class which contains picker item info.</td>
</tr>
</table>