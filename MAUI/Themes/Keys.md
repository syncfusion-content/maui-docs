---
layout: post
title: About Keys for Syncfusion Controls | Syncfusion
description: This section provides an extensive overview of the specific keys mapped to the UI elements of all the Syncfusion Maui controls.
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
        <td rowspan="4">
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
 </Application>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
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

## SfAutoComplete

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
        <td rowspan="38">
            SfAutoCompleteStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfAutoCompleteTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAutoComplete without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAutoCompleteTheme">CommonTheme</x:String>
                <Color x:Key="SfAutocompleteNormalTextColor">Pink</Color>
                <Color x:Key="SfAutocompletePlaceholderTextColor">Blue</Color>
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
            SfAutocompletePressedClearButtonIconColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in pressed state
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfAutocompletePressedClearButtonBorder 
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button border in pressed state
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompletePressedClearButtonBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button Background in pressed state
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteNormalStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete Background in normal state
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteNormalClearButtonIconColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button icon in normal state
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteNormalClearButtonBorder  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button border in normal state
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteNormalClearButtonBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button background in normal state
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteNormalBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete background in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteHoverStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteHoverClearButtonIconColor 
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button icon in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteHoverClearButtonBorder 
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button icon in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteHoverClearButtonBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteHoverBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteFocusedStroke
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete stroke in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteFocusedBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete background in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDisabledStroke
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDisabledClearButtonIconColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button icon in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDisabledClearButtonBorder
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button border in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDisabledClearButtonBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the clear button background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDisabledBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete text color in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteFocusTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete text color in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete text color in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteReadOnlyTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete readonly text. 
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfAutocompleteSelectionTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete selection text. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteSelectionBackgroundTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete selection background text. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDropdownBorder
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown border. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteDropdownBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown background. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompletePlaceholderTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete placeholder text. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalDropdownItemsTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown item text in normal state. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalDropdownStroke
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown stroke in normal state. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalDropdownSelectionBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown selection background in normal state. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteHoverDropdownSelectionBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown selection background in hover state. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompletePressedDropdownSelectionBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the AutoComplete dropdown selection background in pressed state. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of AutoComplete
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalDropdownCornerRadius
            <br/>
            <br/>
        </td> 
        <td>
            CornerRadius of AutoComplete
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalDropdownStrokeThickness
            <br/>
            <br/>
        </td> 
        <td>
            Stroke thickness of the AutoComplete dropdown.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAutocompleteNormalDropdownItemsFontSize
            <br/>
            <br/>
        </td> 
        <td>
            FontSize of the AutoComplete
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfBadgeView

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
        <td rowspan="23">
            SfBadgeViewStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfBadgeViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfBadgeView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBadgeViewTheme">CommonTheme</x:String>
                <Color x:Key="SfBadgeViewNormalBackground">LimeGreen</Color>
                <Color x:Key="SfBadgeViewNormalStroke">Yellow</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfBadgeViewNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the BadgeView background in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewNormalStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the BadgeView stroke in normal state.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewNormalTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView text in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewErrorBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView error background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewErrorStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView error stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewSuccessBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView success background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewSuccessStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView success stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewDarkBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView dark background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewDarkStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView dark stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewLightStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView light stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewLightBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView light background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewLightTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView light text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewInfoBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView info background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewInfoStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView info stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewSecondaryBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView secondary background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewSecondaryTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView secondary text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewSecondaryStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView secondary stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewWarningBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView warning background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewWarningStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the BadgeView warning stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewNormalFontSize  
            <br/>
            <br/>
        </td> 
        <td>
            FontSize of the BadgeView in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewNormalStrokeThickness  
            <br/>
            <br/>
        </td> 
        <td>
            StrokeThickness of the BadgeView in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBadgeViewNormalCornerRadius  
            <br/>
            <br/>
        </td> 
        <td>
            CornerRadius of the BadgeView in normal state.
            <br/>
            <br/>
        </td>
    </tr>

 ## SfButton

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
            SfButtonStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfButtonTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfButton without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfButtonTheme">CommonTheme</x:String>
                <Color x:Key="SfButtonNormalBackground">Grey</Color>
                <Color x:Key="SfButtonNormalTextColor">White</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfButtonNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Button background in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonPressedBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the Button background in pressed state.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonHoverBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonHoverStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonPressedStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button stroke in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonNormalStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button stroke in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonDisabledBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonDisabledStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonNormalTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button text in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button text in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonFocusedBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button background in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonFocusedStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button stroke in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonFocusedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the Button text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonNormalStrokeThickness  
            <br/>
            <br/>
        </td> 
        <td>
            StrokeThickness of the Button in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfButtonTextNormalFontSize  
            <br/>
            <br/>
        </td> 
        <td>
            FontSize of the Button in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

 ## SfBusyIndicator

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
        <td rowspan="5">
            SfBusyIndicatorStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfBusyIndicatorTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfBusyIndicator without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBusyIndicatorTheme">CommonTheme</x:String>
                <Color x:Key="SfBusyIndicatorNormalIndicatorColor">Blue</Color>
                <Color x:Key="SfBusyIndicatorNormalTextColor">Black</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfBusyIndicatorNormalOverlayFill  
            <br/>
            <br/>
        </td>
        <td>
            Color of the BusyIndicator overlayfill in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBusyIndicatorNormalIndicatorColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the BusyIndicator indicator.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBusyIndicatorNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the BusyIndicator text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfBusyIndicatorNormalFontSize  
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the BusyIndicator.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfCheckBox

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
            SfCheckBoxStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfCheckBoxTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfCheckBox without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCheckBoxTheme">CommonTheme</x:String>
                <Color x:Key="SfCheckBoxNormalUncheckedColor">Gold</Color>
                <Color x:Key="SfCheckBoxNormalTextColor">DarkBlue</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfCheckBoxNormalUncheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox in it's uncheck state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxHoverUncheckedColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox in its unchecked state while hovering.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxPressedUncheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox in it's unchecked state while pressed.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxNormalCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox in it's check state
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfCheckBoxHoverCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox in it's check state while hovering.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxPressedCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox in it's check state while pressed.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxHoverTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxPressedTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox text in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxNormalBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox background in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxTickColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the CheckBox tick.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxDisabledUncheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unchecked CheckBox in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfCheckBoxDisabledCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the checked CheckBox in disable state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfCheckBoxNormalFontSize  
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the CheckBox.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfChips

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
        <td rowspan="38">
            SfChipStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfChipTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfCheckBox without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfChipTheme">CommonTheme</x:String>
                <Color x:Key="SfChipGroupNormalSelectionBackground">Purple</Color>
                <Color x:Key="SfChipGroupPressedBackground">YellowGreen</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfChipGroupDisabledSelectedTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the ChipGroup selected text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupHoverSelectedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the ChipGroup selected text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedSelectedTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the ChipGroup selected text in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalSelectedTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the ChipGroup selected text in normal state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfChipGroupPressedClearButtonBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupHoverClearButtonBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedClearButtonIconColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupHoverClearButtonIconColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalClearButtonIconColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalClearButtonBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip background in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupHoverBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfChipGroupHoverStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip stroke in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip stroke in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupChoiceBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the ChipGroup choice background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledChoiceBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ChipGroup choice background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledClearButtonBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledClearButtonIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip text in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupHoverTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupSelectedDisabledTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selected text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupSelectedDisabledBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selected background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalSelectionIndicatorColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection indicator.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedSelectionIndicatorColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection indicator in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledSelectionIndicatorColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection indicator in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupHoverSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupPressedSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection background in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupDisabledSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the Chip selection background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the Chip.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalStrokeThickness
            <br/>
            <br/>
        </td>
        <td>
            StrokeThickness of the Chip.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipGroupNormalCornerRadius
            <br/>
            <br/>
        </td>
        <td>
            CornerRadius of the Chip.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfComboBox

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
        <td rowspan="46">
            SfComboBoxStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfComboBoxTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfComboBox without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfComboBoxTheme">CommonTheme</x:String>
                <Color x:Key="SfComboBoxNormalStroke">Magenta</Color>
                <Color x:Key="SfComboBoxFocusTextColor">Lime</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfComboBoxPressedClearButtonIconColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxPressedClearButtonBorder  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button border in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxPressedClearButtonBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalClearButtonIconColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalClearButtonBorder 
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button border.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalClearButtonBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverClearButtonIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverClearButtonBorder
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button border in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverClearButtonBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxFocusedStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox stroke in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxFocusedBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox background in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxFocusedTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledClearButtonIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledClearButtonBorder
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button border in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledClearButtonBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxFocusTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxReadOnlyTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox readonly text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxSelectionTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox selection text.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfComboBoxSelectionBackgroundTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox selection background text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDropdownBorder
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown border.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDropdownBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxPlaceholderTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox placeholder text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropdownItemsTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown item text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropdownStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropdownSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown selection background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverDropdownSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown selection background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxPressedDropdownSelectionBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown selection background in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfComboBoxDisabledDropDownIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown icon in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropDownIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown icon.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxFocusedDropDownIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox dropdown icon in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxFocusedClearButtonIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxDisabledPlaceholderTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox placeholder text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxHoverTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the ComboBox text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the ComboBox.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropdownCornerRadius
            <br/>
            <br/>
        </td>
        <td>
            CornerRadius of the ComboBox dropdown.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropdownStrokeThickness
            <br/>
            <br/>
        </td>
        <td>
            StrokeThickness of the ComboBox dropdown.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfComboBoxNormalDropdownItemsFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the ComboBox dropdown item.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfEffectsView

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
        <td rowspan="5">
            SfEffectsViewStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfEffectsViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfEffectsView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfEffectsViewTheme">CommonTheme</x:String>
                <Color x:Key="SfEffectsViewRippleBackground">Yellow</Color>
                <Color x:Key="SfEffectsViewHighlightBackground">Red</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfEffectsViewRippleBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the EffectsView ripple background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfEffectsViewSelectionBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the EffectsView selection background
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfEffectsViewHighlightBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the EffectsView highlight background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfEffectsViewRippleAnimationDuration  
            <br/>
            <br/>
        </td>
        <td>
            Duration of the EffectsView ripple animation.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfMaskedEntry

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
        <td rowspan="17">
            SfMaskedEntryStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfMaskedEntryTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfMaskedEntry without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfMaskedEntryTheme">CommonTheme</x:String>
                <Color x:Key="SfMaskedEntryNormalBackground">Grey</Color>
                <Color x:Key="SfMaskedEntryNormalTextColor">Gold</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfMaskedEntryNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryPlaceholderTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry placeholder text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryFocusedTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryDisabledTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryMouseHoveredTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryNormalBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryDisabledBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryFocusedBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry background in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryMouseHoveredBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryMouseHoveredStroke 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryNormalStroke 
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryFocusedStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry stroke in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryDisabledStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntrySelectedTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry selected text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntrySelectedBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the MaskedEntry selected background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfMaskedEntryNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the MaskedEntry.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

   ## SfNavigationDrawer

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
        <td rowspan="3">
            SfNavigationDrawerStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfNavigationDrawerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfNavigationDrawer without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfNavigationDrawerTheme">CommonTheme</x:String>
                <Color x:Key="SfEffectsViewRippleBackground">Yellow</Color>
                <Color x:Key="SfEffectsViewHighlightBackground">Red</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfNavigationDrawerContentBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the NavigationDrawer background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNavigationDrawerGreyLayoutBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NavigationDrawer layout background.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfNumericEntry

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
            SfNumericEntryStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfNumericEntryTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfNumericEntry without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfNumericEntryTheme">CommonTheme</x:String>
                <Color x:Key="SfNumericEntryNormalBackground">Purple</Color>
                <Color x:Key="SfNumericEntryNormalStroke">Black</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfNumericEntryNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryDisabledTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryFocusedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryMouseHoveredTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryNormalBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryDisabledBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryMouseHoveredBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry background in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryFocusedBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry background in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryNormalArrowColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry arrow.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryDisabledArrowColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry arrow in disable state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfNumericEntryPressedArrowColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry arrow in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryMouseHoveredArrowColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry arrow in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryNormalClearButtonColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry clear button.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryDisabledClearButtonColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry clear button in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryPressedClearButtonColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry clear button in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryMouseHoveredClearButtonColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry clear button in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryNormalStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryFocusedStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry stroke in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryDisabledStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryMouseHoveredStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the NumericEntry stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the NumericEntry.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfRadioButton

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
        <td rowspan="15">
            SfRadioButtonStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfRadioButtonTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfRadioButton without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfRadioButtonTheme">CommonTheme</x:String>
                <Color x:Key="SfRadioButtonNormalUncheckedColor">Orange</Color>
                <Color x:Key="SfRadioButtonNormalTextColor">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfRadioButtonNormalUncheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the Unchecked RadioButton.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonHoverUncheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unchecked RadioButton in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonPressedUncheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unchecked RadioButton in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonNormalCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the checked RadioButton.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonHoverCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the checked RadioButton in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonPressedCheckedColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the checked RadioButton in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfRadioButtonNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the RadioButton text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonHoverTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the RadioButton text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonPressedTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the RadioButton text in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonNormalBackgroundColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the RadioButton background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonDisabledUncheckedColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the unchecked RadioButton in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonDisabledCheckedColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the checked RadioButton in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonDisabledTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the RadioButton text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadioButtonNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the RadioButton.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfRating

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
        <td rowspan="13">
            SfRatingStyles 
            <br/>
            <br/>
        </td>
		<td>
            SfRatingTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfRating without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfRatingTheme">CommonTheme</x:String>
                <Color x:Key="SfRatingNormalRatedFill">Pink</Color>
                <Color x:Key="SfRatingHoverUnratedFill">SkyBlue</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfRatingNormalRatedFill  
            <br/>
            <br/>
        </td>
        <td>
            Color of the rated portion of a Rating.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingNormalRatedStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the rated portion of a Rating stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingDisabledRatedFill  
            <br/>
            <br/>
        </td>
        <td>
            Color of the rated portion of a Rating in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingDisabledRatedStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the rated portion of a Rating stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingHoverRatedFill  
            <br/>
            <br/>
        </td>
        <td>
            Color of the rated portion of a Rating in hover state.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfRatingHoverRatedStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the rated portion of a Rating stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingNormalUnratedFill  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unrated portion of a Rating.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingNormalUnratedStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unrated portion of a Rating stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingDisabledUnratedFill  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unrated portion of a Rating in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingDisabledUnratedStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unrated portion of a Rating stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingHoverUnratedFill 
            <br/>
            <br/>
        </td>
        <td>
            Color of the unrated portion of a Rating in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRatingHoverUnratedStroke 
            <br/>
            <br/>
        </td>
        <td>
            Color of the unrated portion of a Rating stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

   ## SfSignaturePad

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
        <td rowspan="5">
            SfSignaturePadStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfSignaturePadTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfSignaturePad without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfSignaturePadTheme">CommonTheme</x:String>
                <Color x:Key="SfSignaturePadNormalStrokeColor">Orange</Color>
                <Color x:Key="SfSignaturePadNormalBackground">Grey</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfSignaturePadNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SignaturePad background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSignaturePadNormalStrokeColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SignaturePad stroke.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

  ## SfSwitch

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
            SfSwitchStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfSwitchTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfSwitch without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfSwitchTheme">CommonTheme</x:String>
                <Color x:Key="SfSwitchOffThumbBackground">LimeGreen</Color>
                <Color x:Key="SfSwitchOffTrackStroke">Orange</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfSwitchOffThumbBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color for the thumb of a Switch control in the off state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffTrackStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color for the track stroke of a Switch control in the off state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffThumbStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color for the thumb stroke of a Switch control in the off state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchTrackBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the track of a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchThumbBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the thumb of a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchTrackStroke  
            <br/>
            <br/>
        </td>
        <td>
             Color for the track stroke of a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchThumbStroke  
            <br/>
            <br/>
        </td>
        <td>
             Color for the thumb stroke of a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnIconColor  
            <br/>
            <br/>
        </td>
        <td>
             Color for the icon of a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffHoveredThumbBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the thumb of a Switch control in the off state when hovered.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffHoveredThumbStroke  
            <br/>
            <br/>
        </td>
        <td>
             Stroke color for the thumb of a Switch control in the off state when hovered.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfSwitchOnHoveredThumbBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the thumb of a Switch control in the on state when hovered.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnHoveredThumbStroke  
            <br/>
            <br/>
        </td>
        <td>
             Stroke color for the thumb of a Switch control in the on state when hovered.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffDisabledTrackBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the track of a Switch control in the off state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffDisabledThumbBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the thumb of a Switch control in the off state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffDisabledTrackStroke  
            <br/>
            <br/>
        </td>
        <td>
             Stroke color for the track of a Switch control in the off state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffDisabledThumbStroke  
            <br/>
            <br/>
        </td>
        <td>
             Stroke color for the thumb of a Switch control in the off state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnDisabledTrackBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the track of a Switch control in the on state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnDisabledThumbBackground 
            <br/>
            <br/>
        </td>
        <td>
             Background color for the thumb of a Switch control in the on state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnDisabledTrackStroke
            <br/>
            <br/>
        </td>
        <td>
             Stroke color for the track of a Switch control in the on state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnDisabledThumbStroke
            <br/>
            <br/>
        </td>
        <td>
             Stroke color for the thumb of a Switch control in the on state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnDisabledIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color for the icon of a Switch control in the on state when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffTrackBackground
            <br/>
            <br/>
        </td>
        <td>
            Background color for the track of a Switch control in the off state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffThumbWidthRequest
            <br/>
            <br/>
        </td>
        <td>
            Width of the thumb for a Switch control in the off state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOffThumbHeightRequest
            <br/>
            <br/>
        </td>
        <td>
            Height of the thumb for a Switch control in the off state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchTrackStrokeThickness
            <br/>
            <br/>
        </td>
        <td>
            StrokeThickness of the track for a Switch control.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchPressedThumbWidthRequest
            <br/>
            <br/>
        </td>
        <td>
            Width of the thumb for a Switch control in the pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchPressedThumbHeightRequest
            <br/>
            <br/>
        </td>
        <td>
            Height of the thumb for a Switch control in the pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnThumbWidthRequest
            <br/>
            <br/>
        </td>
        <td>
            Width of the thumb for a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfSwitchOnThumbHeightRequest
            <br/>
            <br/>
        </td>
        <td>
            Height of the thumb for a Switch control in the on state.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

## SfTabView

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
            SfTabViewStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfTabViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfTabView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfTabViewTheme">CommonTheme</x:String>
                <Color x:Key="SfTabViewNormalTextColor">DarkBlue</Color>
                <Color x:Key="SfTabViewNormalTabBarBackground">Gold</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfTabViewNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TabView text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewSelectedTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TabView selected text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TabView active text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewDisabledTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TabView text in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewNormalTabBarBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TabView tabbar background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewDisabledTabBarBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TabView tabbar background in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveIndicatorBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active indicator in a TabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveMouseHoveredIndicatorBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active indicator in a TabView when hovered.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveDisabledIndicatorBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active indicator in a TabView when disabled.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active TabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveFocusedBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active TabView in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActivePressedBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active TabView in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveDisabledBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active TabView in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveHoveredBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of the active TabView in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveNormalBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of the inactive TabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveFocusedBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of the inactive TabView in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActivePressedBackground
            <br/>
            <br/>
        </td>
        <td>
            Background color of the inactive TabView in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveDisabledBackground
            <br/>
            <br/>
        </td>
        <td>
            Background color of the inactive TabView in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveHoveredBackground
            <br/>
            <br/>
        </td>
        <td>
            Background color of the inactive TabView in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveTextColor
            <br/>
            <br/>
        </td>
        <td>
            Text color of the inactive TabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the TabView.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

## SfTextInputLayout

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
        <td rowspan="23">
            SfTextInputLayoutStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfTextInputLayoutTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfTextInputLayout without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfTextInputLayoutTheme">CommonTheme</x:String>
                <Color x:Key="SfTextInputLayoutStroke">Yellow</Color>
                <Color x:Key="SfTextInputLayoutContainerBackground">Pink</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>
 </Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        </tr>
        <tr>
        <td>
            SfTextInputLayoutStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutNormalContainerBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout background in normal state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutContainerBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutNormalErrorTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout error text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutHintTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout hint text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutHelperTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout helper text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutFocusedHintTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout hint text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutCommonStroke 
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout common stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutFocusedContainerBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout background in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutDisabledStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout stroke in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutDisabledContainerBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout background in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutDisabledErrorTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout error text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutDisabledHintTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout hint text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutDisabledHelperTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout helper text in disable state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutMouseHoveredContainerBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout background text in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutHoveredStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutPressedHintTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout hint text in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutErrorStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the TextInputLayout error stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutNormalHintFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the TextInputLayout hint text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutFocusedHintFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the TextInputLayout text in focus state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutNormalHelperFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the TextInputLayout helper text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTextInputLayoutNormalErrorFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the TextInputLayout error text.
            <br/>
            <br/>
        </td>
    </tr>
    </table>


