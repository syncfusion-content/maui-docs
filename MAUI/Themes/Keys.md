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
        <td rowspan="19">
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
                <x:String x:Key="SfImageEditorTheme">CommonTheme</x:String> 
                <Color x:Key="SfImageEditorNormalToolbarBackgroundColor">Blue</Color> 
                <Color x:Key="SfImageEditorNormalToolbarTextColor">Green</Color> 
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


## SfSegmentedControl

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
            SfSegmentedControlStyles
            <br/>
            <br/>
        </td>
		<td>
           SfSegmentedControlTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfSegmentedControl without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.XForms.Themes;assembly=Syncfusion.Core.XForms"
             ...>
<Application.Resources>
    <syncCore:SyncfusionThemeDictionary>
        <syncCore:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfSegmentedControlTheme">CommonTheme</x:String> 
                <Color x:Key="SfSegmentedControlNormalStroke">Gray</Color> 
                <Color x:Key="SfSegmentedControlNormalBackground">White</Color> 
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
            SfSegmentedControlNormalStroke    
            <br/>
            <br/>
        </td>
        <td>
            Color of border in segmented control.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfSegmentedControlNormalTextColor     
            <br/>
            <br/>
        </td>
        <td>
            Color of text in segmented control.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlNormalBackground      
            <br/>
            <br/>
        </td>
        <td>
            Color of background in segmented control. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlDisabledSegmentBackground       
            <br/>
            <br/>
        </td>
        <td>
            Color of segment background in segmented control when it is disabled. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlDisabledSegmentTextColor        
            <br/>
            <br/>
        </td>
        <td>
            Color of segment text in segmented control when it is disabled.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlSelectionBackground         
            <br/>
            <br/>
        </td>
        <td>
            Color of background in segmented control when it is selected.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlSelectionTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of text in segmented control when it is selected. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlSelectionStroke           
            <br/>
            <br/>
        </td>
        <td>
            Color of border in segmented control when it is selected.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlHoveredBackground            
            <br/>
            <br/>
        </td>
        <td>
            Color of backgtound in segmented control when it is hovered.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlKeyboardFocusStroke             
            <br/>
            <br/>
        </td>
        <td>
            Color of border in segmented control when it is in keyboard pressed.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlNormalStrokeThickness              
            <br/>
            <br/>
        </td>
        <td>
            Size of stroke thickness in segmented control.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlNormalCornerRadius               
            <br/>
            <br/>
        </td>
        <td>
            Size of corner radius in segmented control.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlNormalSegmentCornerRadius                
            <br/>
            <br/>
        </td>
        <td>
            Size of segment corner radius in segmented control.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlNormalFontSize                 
            <br/>
            <br/>
        </td>
        <td>
            Size of text in segmented control.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSegmentedControlBorderSelectionStrokeThickness                  
            <br/>
            <br/>
        </td>
        <td>
            Size of border stroke thickness in segmented control when it is selected.     
            <br/>
            <br/>
        </td>
    </tr>
</table>


## SfDataForm

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
            SfDataFormStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfDataFormTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfDataForm without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.XForms.Themes;assembly=Syncfusion.Core.XForms"
             ...>
<Application.Resources>
    <syncCore:SyncfusionThemeDictionary>
        <syncCore:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfDataFormTheme">CommonTheme</x:String>
                <Color x:Key="SfDataFormNormalEditorTextColor">Red</Color>
                <Color x:Key="SfDataFormNormalLabelTextColor">Pink</Color>
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
            SfDataFormNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Background color of the dataform.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfDataFormNormalEditorBackground     
            <br/>
            <br/>
        </td>
        <td>
            Background color of the dataform editors.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormDisabledEditorBackground      
            <br/>
            <br/>
        </td>
        <td>
            Disabled editor`s background color in dataform. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalEditorTextColor       
            <br/>
            <br/>
        </td>
        <td>
            Text color of the dataform editors 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormDisabledEditorTextColor        
            <br/>
            <br/>
        </td>
        <td>
            Disabled editor`s text color in dataform.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalEditorPlaceholderColor         
            <br/>
            <br/>
        </td>
        <td>
            Placeholder color of the editor in dataform.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalEditorStroke          
            <br/>
            <br/>
        </td>
        <td>
            Border color of the editor in dataform.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormFocusedEditorStroke           
            <br/>
            <br/>
        </td>
        <td>
            Border color of the editor in dataform when it is focused.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormDisabledEditorStroke            
            <br/>
            <br/>
        </td>
        <td>
            Border color of the editor in dataform when it is disabled.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalLabelTextColor             
            <br/>
            <br/>
        </td>
        <td>
            Text color of the dataform labels.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormDisabledLabelTextColor              
            <br/>
            <br/>
        </td>
        <td>
            Disabled label`s text color in dataform.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalErrorLabelTextColor               
            <br/>
            <br/>
        </td>
        <td>
            Error label`s text color in dataform.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalValidMessageLabelTextColor                
            <br/>
            <br/>
        </td>
        <td>
            Valid message label`s text color in dataform.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalGroupHeaderTextColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of group header text in dataform.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalGroupHeaderBackground                  
            <br/>
            <br/>
        </td>
        <td>
            Background color of group header in dataform.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormHoverGroupHeaderBackground                   
            <br/>
            <br/>
        </td>
        <td>
            Background color of group header in dataform when it is hovered.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalGroupHeaderIconColor                    
            <br/>
            <br/>
        </td>
        <td>
            Color of group header icon in dataform.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalEditorTextFontSize                     
            <br/>
            <br/>
        </td>
        <td>
            Size of editor text in dataform.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalLabelFontSize                      
            <br/>
            <br/>
        </td>
        <td>
            Size of label's in dataform.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfDataFormNormalErrorLabelFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of error label's in dataform.      
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfDataFormNormalValidMessageLabelFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of valid message label's in dataform.      
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfDataFormNormalGroupHeaderTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of group header text in dataform.      
            <br/>
            <br/>
        </td>
    </tr>
</table>


## SfMaps

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
        <td rowspan="32">
            SfMapsStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfMapsTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfMaps without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.XForms.Themes;assembly=Syncfusion.Core.XForms"
             ...>
<Application.Resources>
    <syncCore:SyncfusionThemeDictionary>
        <syncCore:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfMapsTheme">CommonTheme</x:String> 
                <Color x:Key="SfMapsShapeLayerNormalShapeFillColor">Blue</Color> 
                <Color x:Key="SfMapsShapeLayerNormalShapeStroke">Green</Color> 
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
            SfMapsNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Color of maps background.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfMapsBubbleNormalFillColor     
            <br/>
            <br/>
        </td>
        <td>
            Color of bubble fill in maps.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsBubbleNormalStroke      
            <br/>
            <br/>
        </td>
        <td>
            Color of bubble border in maps. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsBubbleHoverFillColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of bubble fill in maps when it is hovered. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsBubbleHoverStroke        
            <br/>
            <br/>
        </td>
        <td>
            Color of bubble border in maps when it is hovered.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsTooltipBackground         
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip background in maps.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsTooltipTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip text in maps.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeLayerSelectedShapeFillColor           
            <br/>
            <br/>
        </td>
        <td>
            Color of selected shape in maps.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeLayerSelectedShapeStroke            
            <br/>
            <br/>
        </td>
        <td>
            Color of selected shape stroke color in maps.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeLayerNormalShapeFillColor             
            <br/>
            <br/>
        </td>
        <td>
            Color of shape layer in maps.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeLayerNormalShapeStroke              
            <br/>
            <br/>
        </td>
        <td>
            Color of shape layer stroke color in maps.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeLayerShapeHoverFillColor               
            <br/>
            <br/>
        </td>
        <td>
            Color of hovered shape color in maps.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeLayerShapeHoverStroke                
            <br/>
            <br/>
        </td>
        <td>
            Color of hovered shape stroke color in maps.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeSubLayerSelectedShapeFillColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of sublayer selected shape color in maps.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeSubLayerSelectedShapeStroke                  
            <br/>
            <br/>
        </td>
        <td>
            Color of sublayer selected shape border color in maps.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeSubLayerNormalShapeFillColor                   
            <br/>
            <br/>
        </td>
        <td>
            Color of sublayer color in maps.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeSubLayerNormalShapeStroke                    
            <br/>
            <br/>
        </td>
        <td>
             Color of sublayer stroke color in maps.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeSubLayerShapeHoverFillColor                     
            <br/>
            <br/>
        </td>
        <td>
            Color of sublayer hovered shape color in maps.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsShapeSubLayerShapeHoverStroke                      
            <br/>
            <br/>
        </td>
        <td>
            Color of sublayer hovered shape border color in maps.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfMapsArcStroke                       
            <br/>
            <br/>
        </td>
        <td>
            Color of arc layer color in maps.      
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfMapsLineStroke                       
            <br/>
            <br/>
        </td>
        <td>
            Color of line layer color in maps.      
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfMapsCircleFillColor                       
            <br/>
            <br/>
        </td>
        <td>
            Color of circle layer color in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsCircleStroke                       
            <br/>
            <br/>
        </td>
        <td>
            Color of circle layer stroke color in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsMarkerIconFillColor                       
            <br/>
            <br/>
        </td>
        <td>
            Color of marker icon in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsMarkerIconStroke                       
            <br/>
            <br/>
        </td>
        <td>
            Color of marker icon stroke color in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsPolygonFillColor                       
            <br/>
            <br/>
        </td>
        <td>
            Color of polygon layer color in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsPolygonStroke                       
            <br/>
            <br/>
        </td>
        <td>
            Color of polygon layer stroke color in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsPolyLineStroke                       
            <br/>
            <br/>
        </td>
        <td>
            Color of polyline layer color in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsTooltipTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of tooltip text in maps.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfMapsDataLabelTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of data label text in maps.      
            <br/>
            <br/>
        </td>
    </tr>
</table>




## SfSchedule

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
        <td rowspan="30">
            SfSchedulerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfSchedulerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfScheduler without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.XForms.Themes;assembly=Syncfusion.Core.XForms"
             ...>
<Application.Resources>
    <syncCore:SyncfusionThemeDictionary>
        <syncCore:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfSchedulerTheme">CommonTheme</x:String> 
                <Color x:Key="SfSchedulerNormalHeaderTextColor">Red</Color>
                <Color x:Key="SfSchedulerNormalViewHeaderDayTextColor">Blue</Color>
                <Color x:Key="SfSchedulerNormalViewHeaderDateTextColor">Blue</Color> 
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
            SfSchedulerHoverColor    
            <br/>
            <br/>
        </td>
        <td>
            Color of hover background at scheduler.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfSchedulerNormalBackground     
            <br/>
            <br/>
        </td>
        <td>
            Color of scheduler background.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerDisabledNavigationArrowColor      
            <br/>
            <br/>
        </td>
        <td>
            Color of navigation arrow in scheduler when it is disabled. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalMoreAppointmentIndicatorColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of appointment indicator in scheduler day, week and work week view. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalSelectedCellBackground        
            <br/>
            <br/>
        </td>
        <td>
            Color of selected cell background in scheduler.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalTodayHighlightBrush         
            <br/>
            <br/>
        </td>
        <td>
            Color of today hightlight in scheduler.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalSelectedAppointmentBackground          
            <br/>
            <br/>
        </td>
        <td>
            Color of appointment layout while select in scheduler day, week and work week view.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalCellBorderBrush           
            <br/>
            <br/>
        </td>
        <td>
            Color of cell border in scheduler.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalTodayTextColor            
            <br/>
            <br/>
        </td>
        <td>
            Current date text color of month cell in schedule month view.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerDisabledDateBackground             
            <br/>
            <br/>
        </td>
        <td>
            Disabled color of date in scheduler.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerDisabledDateTextColor              
            <br/>
            <br/>
        </td>
        <td>
            Disabled color of date text in scheduler.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalAppointmentBackground               
            <br/>
            <br/>
        </td>
        <td>
            Color of appointment layout in scheduler day, week and work week view.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalAppointmentTextColor                
            <br/>
            <br/>
        </td>
        <td>
            Color of appointment text in scheduler day, week and work week view.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalWeekNumberBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Color of week number color in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalWeekNumberTextColor                  
            <br/>
            <br/>
        </td>
        <td>
            Color of week number text in scheduler.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalHeaderBackground                   
            <br/>
            <br/>
        </td>
        <td>
            Color of header layout in scheduler.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalHeaderTextColor                    
            <br/>
            <br/>
        </td>
        <td>
             Color of header text in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalViewHeaderBackground                     
            <br/>
            <br/>
        </td>
        <td>
            Color of view header layout in schedule.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalViewHeaderDayTextColor                      
            <br/>
            <br/>
        </td>
        <td>
            Color of view header day text(Sunday,Monday,etc) in scheduler.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfSchedulerNormalViewHeaderDateTextColor                       
            <br/>
            <br/>
        </td>
        <td>
            Color of view header date text(10,11,etc) in scheduler.     
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfSchedulerNormalAllowedViewDropDownShadowBrush                       
            <br/>
            <br/>
        </td>
        <td>
            Color of allowed view drop down shadow in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfSchedulerHoverHeaderAllowedViewButtonBackground                       
            <br/>
            <br/>
        </td>
        <td>
           Color of allowed view button in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerPressedAllowedViewMoreIconButtonBackground                       
            <br/>
            <br/>
        </td>
        <td>
            Color of allowed view more icon button in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerNormalTodayTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of today text in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerDisabledDateTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of disabled date text in scheduler.     
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerNormalAppointmentTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of appointment text in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerNormalWeekNumberTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of week number text in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerNormalHeaderFontSize                       
            <br/>
            <br/>
        </td>
        <td>
             Size of header text in scheduler.                 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerNormalViewHeaderDayTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of view header day text in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
    <td>
            SfSchedulerNormalViewHeaderDateTextFontSize                       
            <br/>
            <br/>
        </td>
        <td>
            Size of view header date text in scheduler.      
            <br/>
            <br/>
        </td>
    </tr>
</table>