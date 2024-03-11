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

## SfImageEditor

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
        <td rowspan="22">
            SfImageEditorStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfImageEditorTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfImageEditor without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.XForms.Themes;assembly=Syncfusion.Core.XForms"
             ...>
<Application.Resources>
    <syncCore:SyncfusionThemeDictionary>
        <syncCore:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfImageEditorTheme">CustomTheme</x:String> 
                <Color x:Key="SfImageEditorToolbarBackgroundColor">Blue</Color> 
                <Color x:Key="SfImageEditorToolbarTextColor">Green</Color> 
            </ResourceDictionary>
        </syncCore:SyncfusionThemeDictionary.MergedDictionaries>
    </syncCore:SyncfusionThemeDictionary>
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
            SfImageEditorNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Color of image Editor control background.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfImageEditorNormalToolbarBackgroundColor     
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar background in image editor.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorNormalToolbarBorderColor      
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar border in image editor. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorNormalToolbarIconColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar icon background in image editor. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorDisabledToolbarIconColor        
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar icon background in image editor when it is disabled.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorHoverToolbarIconBackground         
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar icon background in image editor when it is hovered.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorPressedToolbarIconBackground          
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar icon background in image editor when it is in pressed state. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorNormalToolbarTextColor           
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar text in image editor.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorHoverToolbarTextColor            
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar text in image editor when it is hovered.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorPressedToolbarTextColor             
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar text in image editor when it is in pressed state.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorDisabledToolbarTextColor              
            <br/>
            <br/>
        </td>
        <td>
            Color of toolbar text in image editor when it is disabled.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorTooltipBackground               
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip background in image editor.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorTooltipTextColor                
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip text in image editor.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorFocusedColorPaletteColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of color palate in image editor.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorSelectionStroke                  
            <br/>
            <br/>
        </td>
        <td>
            Color of selection stroke in image editor.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorNormalSavePopupBackground                   
            <br/>
            <br/>
        </td>
        <td>
            Color of save popup background in image editor.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorNormalSavePopupTextColor                    
            <br/>
            <br/>
        </td>
        <td>
            Color of save popup text in image editor.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorToolbarIconSeparatorColor                     
            <br/>
            <br/>
        </td>
        <td>
            Color of tool bar line separator in image editor.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorNormalToolbarTextFontSize                      
            <br/>
            <br/>
        </td>
        <td>
            Size of toolbar text in image editor.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfImageEditorTooltipTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of tooltip text in image editor.      
            <br/>
            <br/>
        </td>
    </tr>
</table>