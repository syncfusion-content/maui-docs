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

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfImageEditorTheme">CommonTheme</x:String>
                <Color x:Key="SfImageEditorNormalToolbarBackgroundColor">Red</Color>
                <Color x:Key="SfImageEditorNormalToolbarTextColor">Green</Color>
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
            SfImageEditorNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Background color of image editor.
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
            Color of toolbar background.
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
            Color of toolbar icon in image editor. 
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
            Color of toolbar icon when it is disabled.  
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
            Color of toolbar icon when it is hovered.   
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
            Color of toolbar icon when it is in pressed state. 
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
            Color of toolbar text.   
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
            Color of toolbar text when it is hovered.   
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
            Color of toolbar text when it is pressed.    
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
            Color of toolbar text when it is disabled.    
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
            Color of tooltip.     
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
            Color of tooltip text.      
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
            Color of color palate icon when it is selected.     
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
            Color of crop layer and annotations selection stroke.     
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
            Color of saved message popup background.     
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
            Color of saved message popup text.      
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
            Color of tool bar icons divider line.     
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
            Size of toolbar text.     
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
            Size of tooltip text.      
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

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfSegmentedControlTheme">CommonTheme</x:String>
                <Color x:Key="SfSegmentedControlNormalStroke">Red</Color>
                <Color x:Key="SfSegmentedControlNormalBackground">Green</Color>
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
            Background color of segmented control.
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
            Color of segment when it is disabled. 
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
            Color of segment text when it is disabled.  
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
            Color of segment when it is selected.   
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
            Color of text when it is selected. 
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
            Color of border when it is selected.   
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
            Color of segment when it is hovered.   
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
            Color of border when it is keyboard pressed.    
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
            Size of stroke thickness in segemented control.    
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
            Size of corner radius in segemented control.     
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
            Size of segment corner radius.      
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
            Size of border stroke thickness when it is selected.     
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

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfDataFormTheme">CommonTheme</x:String>
                <Color x:Key="SfDataFormNormalEditorTextColor">Red</Color>
                <Color x:Key="SfDataFormNormalLabelTextColor">Green</Color>
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
            SfDataFormNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Background color of dataform.
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
            Background color of dataform editors.
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
            Disabled editor`s background color. 
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
            Text color of the dataform editors.
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
            Disabled editor`s text color.  
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
            Placeholder color of the editor.   
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
            Border color of the editor.  
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
            Border color of the editor when it is focused.   
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
            Border color of the editor when it is disabled.   
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
            Disabled label`s text color.    
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
            Error label`s text color.     
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
            Valid message label`s text color.      
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
            Color of group header text.     
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
            Background color of group header.     
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
            Background color of group header when it is hovered.     
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
            Color of group header icon.      
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

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfMapsTheme">CommonTheme</x:String>
                <Color x:Key="SfMapsShapeLayerNormalShapeFillColor">Red</Color>
                <Color x:Key="SfMapsShapeLayerNormalShapeStroke">Green</Color>
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
            SfMapsNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Background color of maps.
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
            Color of bubbles in maps.
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
            Color of bubbles border. 
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
            Color of bubble when it is hovered. 
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
            Color of bubble border when it is hovered.  
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
            Color of tooltip in maps.   
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
            Color of tooltip text.  
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
            Color of selected shape.   
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
            Color of selected shape stroke.   
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
            Color of shape layer stroke.     
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
            Color of shape when it is hovered.     
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
            Color of shape stroke when it is hovered.      
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
            Color of sublayer shape when it is selected.      
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
            Color of sublayer shape stroke when it is selected.     
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
            Color of sublayer in maps.     
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
             Color of sublayer stroke.      
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
            Color of sublayer shape when it is hovered.     
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
            Color of sublayer shape stroke when it is hovered.     
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
            Color of arc layer in maps.      
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
            Color of line layer in maps.      
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
            Color of circle layer in maps.      
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
            Color of circle layer stroke.      
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
            Color of marker icon stroke.      
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
            Color of polygon layer in maps.      
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
            Color of polygon layer stroke.      
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
            Color of polyline layer in maps.      
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
            Size of data label text.      
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

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfSchedulerTheme">CommonTheme</x:String> 
                <Color x:Key="SfSchedulerNormalHeaderTextColor">Red</Color>
                <Color x:Key="SfSchedulerNormalViewHeaderDayTextColor">Blue</Color>
                <Color x:Key="SfSchedulerNormalViewHeaderDateTextColor">Blue</Color> 
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
            SfSchedulerHoverColor    
            <br/>
            <br/>
        </td>
        <td>
            Color of scheduler when it is hovered.
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
            Background color of scheduler.
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
            Color of navigation arrow when it is disabled. 
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
            Color of appointment indicator day, week and work week view. 
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
            Color of selected cell in scheduler.  
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
            Color of today hightlight.  
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
            Color of appointment layout while select week and work week view.  
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
            Current date text color of month cell.   
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
            Disabled color of date.  
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
            Disabled color of date text.     
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
            Color of appointment layout in day, week and work week view.    
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
            Color of appointment text in day, week and work week view.      
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
            Color of week number in scheduler.      
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
            Color of week number text.     
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
            Color of view header layout.     
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
            Color of view header day text(Sunday,Monday,etc).     
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
            Color of view header date text(10,11,etc).     
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
            Color of allowed view drop down shadow.      
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
           Color of allowed view button.      
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
            Color of allowed view more icon button.      
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
            Size of disabled date text.     
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
            Size of week number text.      
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
            Size of view header day text.      
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
            Size of view header date text.      
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfTreeMap

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
        <td rowspan="18">
            SfTreeMapStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfTreeMapTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfTreeMap without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfTreeMapTheme">CommonTheme</x:String> 
                <Color x:Key="SfTreeMapNormalBackground">Blue</Color> 
                <Color x:Key="SfTreeMapGroupItemNormalBackground">Green</Color> 
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
            SfTreeMapNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Background color of treemap.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfTreeMapSelectedItemStroke     
            <br/>
            <br/>
        </td>
        <td>
            Color of treemap item when it is selected.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapItemHoverStroke      
            <br/>
            <br/>
        </td>
        <td>
            Color of treemap item when it is hovered. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapSelectedItemHoverStroke       
            <br/>
            <br/>
        </td>
        <td>
            Color of selected item hovered in treemap.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapToolTipNormalBackground        
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip in treemap. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapToolTipNormalStroke         
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip stroke in treemap.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapToolTipNormalTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip text in treemap.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapGroupItemNormalBackground           
            <br/>
            <br/>
        </td>
        <td>
            Color of group item in treemap. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapGroupItemNormalStroke           
            <br/>
            <br/>
        </td>
        <td>
            Color of group item stroke.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapGroupItemNormalTextColor             
            <br/>
            <br/>
        </td>
        <td>
            Color of group item text.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapLegendNormalTextColor              
            <br/>
            <br/>
        </td>
        <td>
            Color of legend text in treemap.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapItemKeyboardFocusedStroke               
            <br/>
            <br/>
        </td>
        <td>
            Color of keyboard focused stroke in treemap.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapSelectedItemStrokeWidth                
            <br/>
            <br/>
        </td>
        <td>
            Size of selected item in treemap.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapGroupItemNormalStrokeWidth                 
            <br/>
            <br/>
        </td>
        <td>
            Size of group item in treemap.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapToolTipNormalFontSize                  
            <br/>
            <br/>
        </td>
        <td>
            Size of tooltip text in treemap.    
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapGroupItemNormalFontSize                   
            <br/>
            <br/>
        </td>
        <td>
            Size of group item text.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfTreeMapLegendNormalFontSize                    
            <br/>
            <br/>
        </td>
        <td>
            Size of legend text in treemap.      
            <br/>
            <br/>
        </td>
    </tr>
</table>