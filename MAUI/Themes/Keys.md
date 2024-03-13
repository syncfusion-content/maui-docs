---
layout: post
title: About Keys for Syncfusion Controls | Syncfusion
description: This section contains the details about the keys which are mapped to the UI elements of all the controls
platform: maui
control: General
documentation: ug
---

# Keys of Syncfusion Controls

This page lists the keys for each control and the element to which it is mapped for all the controls.

## SfAvatarView

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="14">
            SfAvatarViewStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfAvatarViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAvatarView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAvatarViewTheme">CommonTheme</x:String>
                <Color x:Key="SfAvatarViewNormalStroke">Red</Color>
                <Color x:Key="SfAvatarViewNormalBackground">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfAvatarViewNormalStroke  
            <br/>
            <br/>
        </td>
        <td>
            Stroke color of SfAvatarView
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfAvatarViewNormalBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of SfAvatarView
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAvatarViewNormalInitialsColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color for the Initials String
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfAccordion

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="12">
            SfAccordionStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfAccordionTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAccordion without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAccordionTheme">CommonTheme</x:String>
                <Color x:Key="SfAccordionNormalHeaderBackground">Blue</Color>
                <Color x:Key="SfAccordionNormalHeaderIconColor">LightGreen</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfAccordionNormalHeaderBackground <br/><br/></td>
        <td> Background color of header in SfAccordion.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHoverHeaderBackground <br/><br/></td> 
        <td> Background color of header when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionFocusedHeaderBackground <br/><br/></td> 
        <td> Background color of header when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHeaderRippleBackground <br/><br/></td> 
        <td> Background color of header when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionNormalHeaderIconColor <br/><br/></td>
        <td> Color of the SfAccordion Header Icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHoverHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionPressedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionFocusedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionExpandedItemStroke <br/><br/></td> 
        <td> Stroke color of expanded accordion item.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionExpandedItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of expanded accordion item.<br/><br/>
        </td>
    </tr>
    <tr>
        <td> SfAccordionFocusedItemStroke <br/><br/></td> 
        <td> Stroke color of the header when it is in focused state during keyboard navigation.<br/><br/></td>
    </tr>
</table>

## SfExpander

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="7">
            SfExpanderStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfExpanderTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfExpander without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfExpanderTheme">CommonTheme</x:String>
                <Color x:Key="SfExpanderNormalHeaderBackground">Red</Color>
                <Color x:Key="SfExpanderNormalHeaderIconColor">LightBlue</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfExpanderNormalHeaderBackground <br/><br/></td>
        <td> Background color of header in SfExpander.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderHoverHeaderBackground  <br/><br/></td> 
        <td> Background color of header when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderHeaderRippleBackground <br/><br/></td> 
        <td> Background color of header when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderNormalHeaderIconColor <br/><br/></td>
        <td> Color of the SfExpander header icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderHoverHeaderIconColor  <br/><br/></td> 
        <td> Color of header icon when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderPressedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in pressed state.<br/><br/></td>
    </tr>
</table>

## SfShimmer

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfShimmerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfShimmerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfShimmer without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfShimmerTheme">CommonTheme</x:String>
                <Color x:Key="SfShimmerFillColor">Pink</Color>
                <Color x:Key="SfShimmerWaveColor">Purple</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfShimmerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Fill color of the shimmer.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfShimmerWaveColor 
            <br/>
            <br/>
        </td>
        <td>
            Wave color of the shimmer.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfShimmerNormalBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the shimmer.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfLinearProgressBar

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfLinearProgressBarStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfLinearProgressBarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfLinearProgressBar without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfLinearProgressBarTheme">CommonTheme</x:String>
                <Color x:Key="SfLinearProgressBarTrackColor">Red</Color>
                <Color x:Key="SfLinearProgressBarProgressColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfLinearProgressBarTrackColor  
            <br/>
            <br/>
        </td>
        <td>
            Track color of the linear progress bar.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfLinearProgressBarBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of the linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfLinearProgressBarProgressColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the progress in linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfLinearProgressBarSecondaryProgressColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the secondary progress in linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfProgressBarProgressGradientStopColor 
            <br/>
            <br/>
        </td>
        <td>
            Gradient stop color of the linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
</table>

## SfCircularProgressBar

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfCircularProgressBarStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfCircularProgressBarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfCircularProgressBar without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCircularProgressBarTheme">CommonTheme</x:String>
                <Color x:Key="SfCircularProgressBarTrackColor">Yellow</Color>
                <Color x:Key="SfCircularProgressBarProgressColor">Orange</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfCircularProgressBarTrackColor  
            <br/>
            <br/>
        </td>
        <td>
            Track color of the circular progress bar.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfCircularProgressBarProgressColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the progress in circular progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCircularProgressBarBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of the circular progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfProgressBarProgressGradientStopColor 
            <br/>
            <br/>
        </td>
        <td>
            Gradient stop color of the circular progress bar.
        <br/>
        <br/>
        </td>
    </tr>
</table>

## SfPicker

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
            SfPickerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfPickerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfPicker without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfPickerTheme">CommonTheme</x:String>
                <Color x:Key="SfPickerNormalHeaderTextColor">Purple</Color>
                <Color x:Key="SfPickerNormalHeaderBackground">Blue</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfPickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the picker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfPickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stoke color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header background color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected text color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color of the picker.
        <br/>
        <br/>
        </td>
    </tr>
</table>

## SfDatePicker

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
            SfDatePickerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfDatePickerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfDatePicker without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfDatePickerTheme">CommonTheme</x:String>
                <Color x:Key="SfDatePickerNormalHeaderTextColor">Green</Color>
                <Color x:Key="SfDatePickerNormalHeaderBackground">Yellow</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfDatePickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the date picker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfDatePickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header background color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected text color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stroke color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDatePickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color of the date picker.
        <br/>
        <br/>
        </td>
    </tr>
</table>

## SfTimePicker

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
            SfTimePickerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfTimePickerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfTimePicker without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfTimePickerTheme">CommonTheme</x:String>
                <Color x:Key="SfTimePickerNormalHeaderTextColor">Blue</Color>
                <Color x:Key="SfTimePickerNormalHeaderBackground">Orange</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfTimePickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the time picker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfTimePickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header background color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected text color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stroke color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTimePickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color of the time picker.
        <br/>
        <br/>
        </td>
    </tr>
</table>

## SfDateTimePicker

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
            SfDateTimePickerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfDateTimePickerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfDateTimePicker without merging common theme resource and control style resource dictionaries.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfDateTimePickerTheme">CommonTheme</x:String>
                <Color x:Key="SfDateTimePickerNormalHeaderTextColor">White</Color>
                <Color x:Key="SfDateTimePickerNormalHeaderBackground">Blue</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfDateTimePickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the date time picker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfDateTimePickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerHeaderSelectionTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected header text color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header background color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selection text color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stroke color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfDateTimePickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color of the date time picker.
        <br/>
        <br/>
        </td>
    </tr>
</table>

## SfListView

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="14">
            SfListViewStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfListViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfListView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfListViewTheme">CommonTheme</x:String>
                <Color x:Key="SfListViewNormalListViewItemBackground">LightBlue</Color>
                <Color x:Key="SfListViewHoverListViewItemBackground">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfListViewNormalListViewItemBackground <br/><br/></td>
        <td> Background color of ListViewItem. <br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewHoverListViewItemBackground <br/><br/></td>
        <td> Background color of ListViewItem when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemBackground <br/><br/></td>
        <td> Background color of ListViewItem when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemStroke <br/><br/></td> 
        <td> Stroke color of the ListViewItem when it is in focused state during key navigation.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of the ListViewItem when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalListViewItemTextColor <br/><br/></td> 
        <td> Text color of the ListViewItem when it is in default state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalGroupHeaderItemBackground <br/><br/></td> 
        <td> Backgroundcolor of the group header.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalGroupHeaderItemTextColor <br/><br/></td> 
        <td> Text color of the group header.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreButtonBackground <br/><br/></td> 
        <td> Background color of the load more button when it is in the default state.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreItemTextColor <br/><br/></td> 
        <td> Text color of the load more button.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreIndicatorIconColor <br/><br/></td> 
        <td> Color of the Load More Indicator.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemBackground <br/><br/></td> 
        <td> Background color of the EmptyViewItem.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemTextColor <br/><br/></td> 
        <td> Text color of the EmptyViewItem.<br/><br/></td>
    </tr>
</table>

## SfCalendar

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
            SfCalendarStyles
            <br/>
            <br/>
        </td>
		<td>
           SfCalendarViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfCalendarTheme without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCalendarViewTheme">CommonTheme</x:String>
                <Color x:Key="SfCalendarHeaderTextColor">Red</Color>
                <Color x:Key="SfCalendarHeaderBackgroundColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 
....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
	</tr>
    <tr>
    <td>
            SfCalendarHeaderTextColor    
            <br/>
            <br/>
        </td>
        <td>
            Color of the calendar header text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarHeaderBackgroundColor     
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar header background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarViewHeaderTextColor      
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar view header text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarWeekNumberTextColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar week number text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarWeekNumberBackgroundColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of week number background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarMonthDatesTextColor        
            <br/>
            <br/>
        </td>
        <td>
            Color of month date text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarMonthDatesBackgroundColor         
            <br/>
            <br/>
        </td>
        <td>
            Color of month date text background. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarMonthTodayTextColor          
            <br/>
            <br/>
        </td>
        <td>
           The color of today's text for the month.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarMonthTodayBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today background for the month.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfCalendarMonthTrailingLeadingDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of trailing and leading text of month.
            <br/>
            <br/>
        </td>
    </tr>      
    <tr>
    <td>
            SfCalendarMonthTrailingLeadingDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of trailing and leading text of month background.
            <br/>
            <br/>
        </td>
    </tr>      
    <tr>
    <td>
            SfCalendarMonthDisabledDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled date in month.
            <br/>
            <br/>
        </td>
    </tr>    
     <tr>
    <td>
            SfCalendarMonthDisabledDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled date in month background.
            <br/>
            <br/>
        </td>
    </tr>    	
	<tr>
    <td>
            SfCalendarWeekendDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of weekend date text.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarWeekendDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of weekend date text background.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarSpecialDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of special dates text.
            <br/>
            <br/>
        </td>
    </tr>    
    <tr>
    <td>
            SfCalendarSpecialDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of special date text background
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarMonthRangeTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of range text.
            <br/>
            <br/>
        </td>
    </tr>    
    <tr>
    <td>
            SfCalendarMonthSelectionTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of selected text in month.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of date text in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of year dates in the background.
            <br/>
            <br/>
        </td>
    </tr>    
   <tr>
    <td>
            SfCalendarYearDisabledDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled text in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearDisabledDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled dates background in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearLeadingDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of leading dates text in the year
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearLeadingDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of leading dates text background in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearTodayTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today text in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearTodayBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today background in the year. 
            <br/>
            <br/>
        </td>
    </tr>    
    <tr>
    <td>
            SfCalendarYearRangeTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of year range text.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarYearSelectionTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of year selection text.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarTodayHighlightColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today highlight.
            <br/>
            <br/>
        </td>
    </tr>    
	<tr>
    <td>
            SfCalendarSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of selection.
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarStartRangeSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of start range selection.
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarEndRangeSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of end range selection.
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarRangeSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of range selection.
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarHeaderHoverTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of text when hovering over the header
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarButtonTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of button text.
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarDisabledNavigationArrowColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled navigation arrow.
            <br/>
            <br/>
        </td>
    </tr>  
	<tr>
    <td>
            SfCalendarHoverColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of hover.
            <br/>
            <br/>
        </td>
    </tr>  
    <tr>
    <td>
            SfCalendarSpecialDayIconColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of special day icon.
            <br/>
            <br/>
        </td>
    </tr>  	
    <tr>
    <td>
            SfCalendarNormalBackground          
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar normal background.
            <br/>
            <br/>
        </td>
    </tr>  	
</table>

## SfBackdrop

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfBackdropStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfBackdropPageTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfBackdrop without merging common theme resources and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBackdropPageTheme">CommonTheme</x:String>
                <Color x:Key="SfBackdropPageFrontLayerBackgroundColor">Red</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfBackdropPageFrontLayerBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
		   The background color of the foreground layer on the backdrop page.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>

## SfBarcodeGenerator

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfBarcodeGeneratorStyles
            <br/>
            <br/>
        </td>
		<td>
           SfBarcodeGeneratorTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfBarcodeGenerator without merging common theme resources and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBarcodeGeneratorTheme">CommonTheme</x:String>
                <Color x:Key="SfBarcodeGeneratorBackgroundColor">Red</Color>
				 <Color x:Key="SfBarcodeGeneratorForegroundColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfBarcodeGeneratorBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the background in the barcode generator.
            <br/>
            <br/>
        </td>
    </tr>
	  <tr>
        <td>
            SfBarcodeGeneratorForegroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the foreground in the barcode generator.
            <br/>
            <br/>
        </td>
    </tr>
	       <tr>
        <td>
            SfBarcodeGeneratorTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the text in the barcode generator.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>

## SfCards

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfCardViewStyles
            <br/>
            <br/>
        </td>
		<td>
           SfCardViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfCardView without merging common theme resources and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCardViewTheme">CommonTheme</x:String>
                <Color x:Key="SfCardViewBorderColor">Red</Color>
				 <Color x:Key="SfCardViewIndicatorColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfCardViewBorderColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the border in the card view.
            <br/>
            <br/>
        </td>
    </tr>
	  <tr>
        <td>
            SfCardViewIndicatorColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the indicator of the card view.
            <br/>
            <br/>
        </td>
    </tr>
	       <tr>
        <td>
            SfCardViewNormalBackround  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the card.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>

## SfRadialGauge

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
            SfRadialGaugeStyles
            <br/>
            <br/>
        </td>
		<td>
            SfRadialGaugeTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfRadialGauge without merging common theme resources and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfRadialGaugeTheme">CommonTheme</x:String>
                <Color x:Key="SfRadialGaugeAxisLabelTextColor">Red</Color>
				 <Color x:Key="SfRadialGaugeAxisLineFillColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfRadialGaugeAxisLabelTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of axis label text in radial gauge.
            <br/>
            <br/>
        </td>
    </tr>
	  <tr>
        <td>
            SfRadialGaugeAxisLineFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of axis line fill in radial gauge.
            <br/>
            <br/>
        </td>
    </tr>
	       <tr>
        <td>
            SfRadialGaugeAxisLineGradientColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gradient in the axis line.
            <br/>
            <br/>
        </td>
    </tr>
		    <tr>
        <td>
            SfRadialGaugeMajorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the major tick stroke. 
            <br/>
            <br/>
        </td>
    </tr>
		 <tr>
        <td>
            SfRadialGaugeMinorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the minor tick stroke.
            <br/>
            <br/>
        </td>
    </tr>
	 <tr>
        <td>
            SfRadialGaugeShapePointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfRadialGaugeShapePointerOverlayFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape pointer overlayfill.
            <br/>
            <br/>
        </td>
    </tr>
	 <tr>
        <td>
            SfRadialGaugeShapePointerStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the pointer stroke of the shape. 
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfRadialGaugeNeedlePointerKnobFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the knobfill of the needle pointer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadialGaugeNeedlePointerKnobStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the stroke of needle pointer knob.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadialGaugeNeedlePointerNeedleFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the needle pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeNeedlePointerTailFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the tail pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeRangePointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the need pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeRangePointerGradientColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the range point gradient in the radial gauge.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeRadialRangeFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of radial range fill.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeRadialRangeGradientColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gradient of gauge.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeRadialRangeLabelTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the radial range label text color.
            <br/>
            <br/>
        </td>
    </tr>
	    <tr>
        <td>
            SfRadialGaugeShapeShadowColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape shadow.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>

## SfLinearGauge

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="14">
            SfLinearGaugeThemeStyles
            <br/>
            <br/>
        </td>
		<td>
           SfLinearGaugeTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfLinearGauge without merging common theme resources and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfLinearGaugeTheme">CommonTheme</x:String>
                <Color x:Key="SfLinearGaugeBarPointerFillColor">Red</Color>
				 <Color x:Key="SfLinearGaugeLabelTextColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfLinearGaugeBarPointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the pointer fill of the linear gauge.
            <br/>
            <br/>
        </td>
    </tr>
	  <tr>
        <td>
            SfLinearGaugeLabelTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the label text.
            <br/>
            <br/>
        </td>
    </tr>
	       <tr>
        <td>
            SfLinearGaugeMajorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the major tick stroke.
            <br/>
            <br/>
        </td>
    </tr>
		       <tr>
        <td>
            SfLinearGaugeMinorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the minor tick stroke.
            <br/>
            <br/>
        </td>
    </tr>
		       <tr>
        <td>
            SfLinearGaugeAxisLineFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the axis line fill.
            <br/>
            <br/>
        </td>
    </tr>
		       <tr>
        <td>
            SfLinearGaugeRangeFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the range fill.
            <br/>
            <br/>
        </td>
    </tr>
		       <tr>
        <td>
            SfLinearGaugeShapePointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape pointer of the gauge.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfLinearGaugeShapePointerStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the pointer stroke
            <br/>
            <br/>
        </td>
    </tr>
	 <tr>
        <td>
            SfLinearGaugeNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gauge background.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>


## SfStepProgressBar

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="55">
           SfStepProgressBarThemeStyles
            <br/>
            <br/>
        </td>
		<td>
           SfStepProgressBarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfStepProgressBar without merging common theme resources and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfStepProgressBarTheme">CommonTheme</x:String>
                <Color x:Key="SfStepProgressBarNormalBackground">Red</Color>
				 <Color x:Key="SfStepProgressBarNormalProgressBarBackground">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfStepProgressBarNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the step progressbar background.
            <br/>
            <br/>
        </td>
    </tr>
	  <tr>
        <td>
            SfStepProgressBarNormalProgressBarBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the normal step progressbar background.
            <br/>
            <br/>
        </td>
    </tr>
	 <tr>
        <td>
            SfStepProgressBarNormalCompletedStepContentFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Completed step content fill color in the progressbar.
            <br/>
            <br/>
        </td>
    </tr>
   <tr>
        <td>
            SfStepProgressBarNormalCompletedStepBackground  
            <br/>
            <br/>
        </td>
        <td>
            Completed step background color in the progressbar.
            <br/>
            <br/>
        </td>
    </tr>
   <tr>
        <td>
            SfStepProgressBarNormalCompletedStepStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the step stroke in progressbar.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfStepProgressBarNormalCompletedStepProgressColor  
            <br/>
            <br/>
        </td>
        <td>
            Progress color in the completed step.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfStepProgressBarNormalCompletedStepTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Text color of the completed step.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfStepProgressBarNormalInProgressStepContentFillColor  
            <br/>
            <br/>
        </td>
        <td>
			Fill color of the in-progress step.
            <br/>
            <br/>
        </td>
    </tr>
	 <tr>
        <td>
            SfStepProgressBarNormalInProgressStepBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background of the in-progress step.
            <br/>
            <br/>
        </td>
    </tr>
		 <tr>
        <td>
            SfStepProgressBarNormalInProgressStepProgressColor  
            <br/>
            <br/>
        </td>
        <td>
            Step progress color of the in-progress step.
            <br/>
            <br/>
        </td>
    </tr>
		 <tr>
        <td>
            SfStepProgressBarNormalInProgressStepTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Text color of the in-progress step.
            <br/>
            <br/>
        </td>
    </tr>
		 <tr>
        <td>
            SfStepProgressBarNormalNotStartedStepContentFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Fill color of the not started step.
            <br/>
            <br/>
        </td>
    </tr>
		 <tr>
        <td>
            SfStepProgressBarNormalNotStartedStepBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background of the not started step.
            <br/>
            <br/>
        </td>
    </tr>
			 <tr>
        <td>
            SfStepProgressBarNormalNotStartedStepStroke  
            <br/>
            <br/>
        </td>
        <td>
            Stroke of the not started step in step progress bar.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfStepProgressBarNormalNotStartedStepProgressColor  
            <br/>
            <br/>
        </td>
        <td>
              Color of the progress in the not started step.
            <br/>
            <br/>
        </td>
    </tr>
		<tr>
        <td>
            SfStepProgressBarNormalNotStartedStepTextColor  
            <br/>
            <br/>
        </td>
        <td>
              Color of the not started step text in step progress bar.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>

## SfPullToRefresh

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="4">
            SfPullToRefreshStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfPullToRefreshTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfPullToRefresh without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfPullToRefreshTheme">CommonTheme</x:String>
                <Color x:Key="SfPullToRefreshProgressBackground">Black</Color>
                <Color x:Key="SfPullToRefreshProgressColor">White</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfPullToRefreshProgressBackground <br/><br/></td>
        <td> Background color of the progress circle view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPullToRefreshProgressColor <br/><br/></td>
        <td> Color of the progress indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPullToRefreshProgressThickness <br/><br/></td>
        <td> Thickness of the progress indicator.<br/><br/></td>
    </tr>
</table>

## SfPdfViewer

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="290">
            SfPdfViewerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfPdfViewerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfPdfViewer without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:SyncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <SyncTheme:SyncfusionThemeDictionary>
        <SyncTheme:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfPdfViewerTheme">Custom Theme</x:String>
                <Color x:Key="SfPdfViewerNormalDialogSaveButtonBackgroundColor">aqua</Color>
                <Color x:Key="SfPdfViewerNormalScrollHeadBackgroundColor">red</Color>
                <Color x:Key="SfPdfViewerNormalScrollHeadBorderColor">Blue</Color>
                <Color x:Key="SfPdfViewerNormalScrollHeadTextColor">green</Color>
                <Color x:Key="SfPdfViewerNormalContextMenuBackGroundColor">yellow</Color>
            </ResourceDictionary>
        </SyncTheme:SyncfusionThemeDictionary.MergedDictionaries>
    </SyncTheme:SyncfusionThemeDictionary>
</Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfPdfViewerOutlineTabViewContainerBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Background colour of the tabview container in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfPdfViewerOutlineNoBookMarkTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Text colour of the No Bookmark label in the outlineview of the SfPdfViewer.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPdfViewerNormalScrollHeadBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the scroll head in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalScrollHeadTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the scroll head in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalScrollHeadBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the scroll head in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the password entry of the password dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryErrorTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the password entry while entering the wrong password in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryContainerBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the password entry of the password dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Normal text color of the password entry of the password dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogTitleTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the title in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogDescriptionTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the description in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button while hovering over the in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button while focusing the in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button while pressing the in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOpenBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineTitleTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the title of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
             Border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
             Hovering border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineSeparatorBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Separator color of outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineTitleLabelTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the title of outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineContainerBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the outlineview container in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the close button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the close button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused background color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogListTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the dialog list in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'Save' button after disabled the button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'Save' button after disabled the button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditTopPanelBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Header background color of the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the free Text editor in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditPlaceHolderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Place holder color of the free Text editor in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogNormalListCheckBoxColor  
            <br/>
            <br/>
        </td> 
        <td>
            Check box color of the list box form field in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogSelectedListCheckBoxColor  
            <br/>
            <br/>
        </td> 
        <td>
            Selected check box color of the list box form field in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalSeparatorBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Separator color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuBorderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalMoreOptionsBorderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the text more options menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuHoverColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the items in the text selection context menu of SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuPressedColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the items in the text selection context menu of SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the hovered item in the text selection context menu of SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the pressed item in the text selection context menu of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadHeaderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Header text color of the signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's main container in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the draw signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonBackGroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering Background color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed Background color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's 'Clear' button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's 'Crete' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewColorSelectorColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color selector color of the signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewDrawTabBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's draw tab  in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabButtonColor  
            <br/>
            <br/>
        </td> 
        <td>
            Upload button color of the signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the signature pad's upload button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabDragandDropTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Drag and drop text color of the signature pad's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewHeaderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of integrated signature view's header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewBackButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of signature pad's back button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of signature pad's OK button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewHeaderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of integrated signature view's header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewSaveTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of integrated signature view's save button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewSaveCheckboxColor  
            <br/>
            <br/>
        </td> 
        <td>
            Checkbox color of signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewClearTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's clear button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewSaveLayoutBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's save layout in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewColorBarBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature pad's color bar in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewItemBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of signature listview's items in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewItemBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview's items in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewLongPressedItemBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview's items while long press in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewLongPressedSItemBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of signature listview's items while long pressing on item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewTappedItemBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview's items while tapping on the item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureCreateButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview container's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureCreateButtonStrokeColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the signature listview container's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListDeleteButtonColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview container's delete button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewHeaderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview container's header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewDeleteButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview delete button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewCreateButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureTextNormalStrokeColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the text signature views in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureTextSelectedStrokeColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the selected text signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDesktopSignatureTextSelectedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the selected text signature view (Desktop) in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerMobileSignatureTextSelectedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the selected text signature view (Mobile) in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature swipe up view (Mobile) in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewTypeTabBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature type tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewTypeTabTextEntryBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the signature type tab's entry in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewTypeTabSignatureLabelBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the signature type tab's label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's create button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's close button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's cancel button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfTreeView

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="12">
            SfTreeViewStyles
            <br/>
            <br/>
        </td>
        <td>
           SfTreeViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfTreeView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfTreeViewTheme">CommonTheme</x:String>
                <Color x:Key="SfTreeViewNormalTreeViewItemBackground">LightBlue</Color>
                <Color x:Key="SfTreeViewHoverTreeViewItemBackground">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfTreeViewNormalTreeViewItemBackground <br/><br/></td>
        <td> Background color of TreeViewItem.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewHoverTreeViewItemBackground  <br/><br/></td> 
        <td> Background color of TreeViewItem when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewFocusedTreeViewItemBackground <br/><br/></td> 
        <td> Background color of TreeViewItem when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewPressedTreeViewItemBackground <br/><br/></td>
        <td> Background color of TreeViewItem when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewFocusedTreeViewItemTextColor <br/><br/></td>
        <td> Text color of the TreeViewItem when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewNormalTreeViewItemTextColor  <br/><br/></td> 
        <td> Text color of the TreeViewItem.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewNormalExpanderBackground  <br/><br/></td> 
        <td> Background color of Expander View.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewNormalExpanderColor  <br/><br/></td> 
        <td> Color of the expander icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewFocusedTreeViewItemStroke <br/><br/></td> 
        <td> Stroke color of the TreeViewItem when it is in focused state during key navigation.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewFocusedTreeViewItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of the TreeViewItem when it is in focused state during key navigation.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewNormalLoadMoreIndicatorColor <br/><br/></td> 
        <td> Color of the load more indicator.<br/><br/></td>
    </tr>
</table>