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
                <x:String x:Key="SfLinearProgressBarStyles">CommonTheme</x:String>
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
</table>
