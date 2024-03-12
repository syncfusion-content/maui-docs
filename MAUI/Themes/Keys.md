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
</table>## SfPullToRefresh

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