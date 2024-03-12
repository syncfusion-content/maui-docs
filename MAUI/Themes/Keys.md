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
        </td>
        <td>
            SfShimmerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Fill color of SfShimmer
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfShimmerWaveColor 
            <br/>
            <br/>
        </td>
        <td>
            Wave color of SfShimmer
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfShimmerNormalBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color for the SfShimmer
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
                <Color x:Key="SfLinearProgressBarTrackColor">Pink</Color>
                <Color x:Key="SfLinearProgressBarProgressColor">Purple</Color>
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
        </td>
        <td>
            SfLinearProgressBarTrackColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the track in the linear progress bar.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfLinearProgressBarBackground 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar background in the linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfLinearProgressBarProgressColor 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar color in the linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfLinearProgressBarSecondaryProgressColor 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar secondary progress color in the linear progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfProgressBarProgressGradientStopColor 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar gradient stop color in the linear progress bar.
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
                <Color x:Key="SfCircularProgressBarTrackColor">Pink</Color>
                <Color x:Key="SfCircularProgressBarProgressColor">Purple</Color>
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
        </td>
        <td>
            SfCircularProgressBarTrackColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the track in the circular progress bar.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfCircularProgressBarProgressColor 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar background in the circular progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfCircularProgressBarBackground 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar background in the circular progress bar.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfProgressBarProgressGradientStopColor 
            <br/>
            <br/>
        </td>
        <td>
            Progress bar gradient stop color in the linear progress bar.
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
        <td rowspan="14">
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
                <Color x:Key="SfPickerNormalHeaderBackground">Pink</Color>
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
        </td>
        <td>
            SfPickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color for the SfPicker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stoke color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header background color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected text color for the SfPicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfPickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color for the SfPicker.
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
        <td rowspan="14">
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
                <Color x:Key="SfDatePickerNormalHeaderTextColor">Purple</Color>
                <Color x:Key="SfDatePickerNormalHeaderBackground">Pink</Color>
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
        </td>
        <td>
            SfDatePickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color for the SfDatePicker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected text color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stroke color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color for the SfDatePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDatePickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color for the SfDatePicker.
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
        <td rowspan="14">
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
                <Color x:Key="SfTimePickerNormalHeaderTextColor">Purple</Color>
                <Color x:Key="SfTimePickerNormalHeaderBackground">Pink</Color>
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
        </td>
        <td>
            SfTimePickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color for the SfTimePicker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selected text color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stroke color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color for the SfTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfTimePickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color for the SfTimePicker.
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
        <td rowspan="14">
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
                <Color x:Key="SfDateTimePickerNormalHeaderTextColor">Purple</Color>
                <Color x:Key="SfDateTimePickerNormalHeaderBackground">Pink</Color>
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
        </td>
        <td>
            SfDateTimePickerNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color for the SfDateTimePicker.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header text color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Header background for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Header divider color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerHeaderSelectionTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Header selection text color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalFooterTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer text color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalFooterBackground 
            <br/>
            <br/>
        </td>
        <td>
            Footer background color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalFooterDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Footer divider color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalColumnHeaderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header text color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalColumnHeaderBackground 
            <br/>
            <br/>
        </td>
        <td>
            Column header background color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalColumnHeaderDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column header divider color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Selection text color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerSelectionBackground 
            <br/>
            <br/>
        </td>
        <td>
            Selection background color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerSelectionStroke 
            <br/>
            <br/>
        </td>
        <td>
            Selection stroke color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalColumnDividerColor 
            <br/>
            <br/>
        </td>
        <td>
            Column divider color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
    <td>
        </td>
        <td>
            SfDateTimePickerNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Normal text color for the SfDateTimePicker.
        <br/>
        <br/>
        </td>
    </tr>
</table>