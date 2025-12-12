---
layout: post
title: About Keys for Syncfusion® Controls | Syncfusion®
description: Explore the detailed mappings of the keys to the UI elements for all the controls in this comprehensive section.
platform: MAUI
control: General
documentation: UG
---

# Keys of Syncfusion<sup>®</sup> Controls

This page lists the keys associated with each control and the respective UI elements they map to across all controls.

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
            By merging this key in the application resources, you can customize the appearance of the SfAccordion without merging common theme resource and control style resource dictionaries.
			
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
        <td> Background color of the header in SfAccordion.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHoverHeaderBackground <br/><br/></td> 
        <td> Background color of the header when it is in a hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionFocusedHeaderBackground <br/><br/></td> 
        <td> Background color of the header when it is in a focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHeaderRippleBackground <br/><br/></td> 
        <td> Background color of the header when it is in a pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionNormalHeaderIconColor <br/><br/></td>
        <td> Color of the SfAccordion header icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHoverHeaderIconColor <br/><br/></td> 
        <td> Color of the header icon when it is in a hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionPressedHeaderIconColor <br/><br/></td> 
        <td> Color of the header icon when it is in a pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionFocusedHeaderIconColor <br/><br/></td> 
        <td> Color of the header icon when it is in a focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionExpandedItemStroke <br/><br/></td> 
        <td> Stroke color of an expanded accordion item.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionExpandedItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of an expanded accordion item.<br/><br/>
        </td>
    </tr>
    <tr>
        <td> SfAccordionFocusedItemStroke <br/><br/></td> 
        <td> Stroke color of the header when it is focused during keyboard navigation.<br/><br/></td>
    </tr>
</table>

## SfAIAssistView

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
        <td rowspan="98">
            SfAIAssistViewStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfAIAssistViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAIAssistView
            without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAIAssistViewTheme">CommonTheme</x:String>
                <Color x:Key="SfAIAssistViewRequestItemBackground">Blue</Color>
                <Color x:Key="SfAIAssistViewResponseItemBackground">LightGreen</Color>
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
    <td> SfAIAssistViewBackground <br/><br/></td>
    <td> Background color of the assist view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderTextColor <br/><br/></td>
    <td> Text color of the assist view header.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderFontFamily <br/><br/></td>
    <td> Font family used for the header.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderFontAttributes <br/><br/></td>
    <td> Font attributes used for the header.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderFontSize <br/><br/></td>
    <td> Font size of the header.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemBackground <br/><br/></td>
    <td> Background color of a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemTextColor <br/><br/></td>
    <td> Text color of a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemFontFamily <br/><br/></td>
    <td> Font family used for a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemFontSize <br/><br/></td>
    <td> Font size of a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemFontAttributes <br/><br/></td>
    <td> Font attributes used for a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemAuthorTextColor <br/><br/></td>
    <td> Text color of the author name in a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemAuthorFontFamily <br/><br/></td>
    <td> Font family of the author name in a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemAuthorFontSize <br/><br/></td>
    <td> Font size of the author name in a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemAuthorFontAttributes <br/><br/></td>
    <td> Font attributes of the author name in a request item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestItemEditingBorder <br/><br/></td>
    <td> Border of the request item when editing.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemBackground <br/><br/></td>
    <td> Background color of a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemTextColor <br/><br/></td>
    <td> Text color of a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemFontFamily <br/><br/></td>
    <td> Font family used for a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemFontSize <br/><br/></td>
    <td> Font size of a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemFontAttributes <br/><br/></td>
    <td> Font attributes used for a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemAuthorTextColor <br/><br/></td>
    <td> Text color of the author name in a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemAuthorFontFamily <br/><br/></td>
    <td> Font family of the author name in a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemAuthorFontSize <br/><br/></td>
    <td> Font size of the author name in a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewResponseItemAuthorFontAttributes <br/><br/></td>
    <td> Font attributes of the author name in a response item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewNormalActionViewColor <br/><br/></td>
    <td> Background color of the normal state of an action view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHoverActionViewColor <br/><br/></td>
    <td> Background color of the hover state of an action view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewPressedActionViewColor <br/><br/></td>
    <td> Background color of the pressed state of an action view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewNormalActionViewIconColor <br/><br/></td>
    <td> Icon color of a normal state action view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSelectedLikeIconColor <br/><br/></td>
    <td> Icon color of the like action when selected.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSelectedDisLikeIconColor <br/><br/></td>
    <td> Icon color of the dislike action when selected.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewInputViewBackground <br/><br/></td>
    <td> Background color of the input view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorPlaceholderTextColor <br/><br/></td>
    <td> Placeholder text color of the input editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorTextColor <br/><br/></td>
    <td> Text color of the editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorBackground <br/><br/></td>
    <td> Background color of the editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorStroke <br/><br/></td>
    <td> Stroke color of the editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewFocusedEditorStroke <br/><br/></td>
    <td> Stroke color of the editor when focused.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorFontFamily <br/><br/></td>
    <td> Font family used for the editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorFontSize <br/><br/></td>
    <td> Font size of the editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewEditorFontAttributes <br/><br/></td>
    <td> Font attributes used for the editor.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewDisabledSendButtonColor <br/><br/></td>
    <td> Background color of the disabled state of the send button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewDisabledSendButtonIconColor <br/><br/></td>
    <td> Icon color of the disabled state of the send button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewRequestHyperlinkColor <br/><br/></td>
    <td> Text color of hyperlink in request items.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHyperlinkMetaTitleTextColor <br/><br/></td>
    <td> Meta title text color for hyperlink.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHyperlinkDescriptionTextColor <br/><br/></td>
    <td> Description text color for hyperlink.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHyperlinkDescriptionBackground <br/><br/></td>
    <td> Background color of hyperlink description.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardBackground <br/><br/></td>
    <td> Background color of the card item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardStroke <br/><br/></td>
    <td> Stroke color of the card item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardTitleTextColor <br/><br/></td>
    <td> Text color of the card title.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardTitleFontFamily <br/><br/></td>
    <td> Font family used for the card title.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardTitleFontSize <br/><br/></td>
    <td> Font size of the card title.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardTitleFontAttributes <br/><br/></td>
    <td> Font attributes used for the card title.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardSubtitleTextColor <br/><br/></td>
    <td> Text color of the card subtitle.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardSubtitleFontFamily <br/><br/></td>
    <td> Font family used for the card subtitle.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardSubtitleFontSize <br/><br/></td>
    <td> Font size of the card subtitle.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardSubtitleFontAttributes <br/><br/></td>
    <td> Font attributes used for the card subtitle.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardDescriptionTextColor <br/><br/></td>
    <td> Text color of the card description.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardDescriptionFontFamily <br/><br/></td>
    <td> Font family used for the card description.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardDescriptionFontSize <br/><br/></td>
    <td> Font size of the card description.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardDescriptionFontAttributes <br/><br/></td>
    <td> Font attributes used for the card description.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardButtonBackground <br/><br/></td>
    <td> Background color of the card button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardButtonStroke <br/><br/></td>
    <td> Stroke color of the card button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardButtonTextColor <br/><br/></td>
    <td> Text color of the card button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardButtonFontFamily <br/><br/></td>
    <td> Font family used for the card button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardButtonFontSize <br/><br/></td>
    <td> Font size of the card button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewCardButtonFontAttributes <br/><br/></td>
    <td> Font attributes used for the card button.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSuggestionBackground <br/><br/></td>
    <td> Background color of the suggestion.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSuggestionItemTextColor <br/><br/></td>
    <td> Text color of suggestion list items.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSuggestionItemBackground <br/><br/></td>
    <td> Background color of suggestion list items.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSuggestionItemFontFamily <br/><br/></td>
    <td> Font family used for suggestion list items.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSuggestionItemFontSize <br/><br/></td>
    <td> Font size of suggestion list items.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSuggestionItemFontAttributes <br/><br/></td>
    <td> Font attributes used for suggestion list items.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingBackground <br/><br/></td>
    <td> Background color of the stop responding view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingIconColor <br/><br/></td>
    <td> Icon color for the stop responding view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingTextColor <br/><br/></td>
    <td> Text color for the stop responding view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingFontFamily <br/><br/></td>
    <td> Font family used for the stop responding text.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingFontSize <br/><br/></td>
    <td> Font size of the stop responding text.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingFontAttributes <br/><br/></td>
    <td> Font attributes used for the stop responding text.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingStroke <br/><br/></td>
    <td> Stroke color for the stop responding view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewStopRespondingStrokeThickness <br/><br/></td>
    <td> Stroke thickness for the stop responding view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewSelectionTextHighLightColor<br/><br/></td>
    <td> Color to highlight the selected text. <br/><br/></td>
</tr>
<tr> 
    <td> SfAIAssistViewHeaderSuggestionBackground<br/><br/></td>
    <td> Background color of the common suggestions view.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemStroke<br/><br/></td>
    <td> Stroke color for the common suggestion item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemStrokeThickness<br/><br/></td>
    <td> Stroke thickness for the common suggestion item.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemBackground<br/><br/></td>
    <td> Background color of an item in the common suggestions.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemTextColor<br/><br/></td>
    <td> Text color of an item in the common suggestions.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemFontSize<br/><br/></td>
    <td> Font size of an item in the common suggestions.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemFontFamily<br/><br/></td>
    <td> Font family of an item in the common suggestions.<br/><br/></td>
</tr>
<tr>
    <td> SfAIAssistViewHeaderSuggestionItemFontAttribute<br/><br/></td>
    <td> Font attributes of an item in the common suggestions.<br/><br/></td>
</tr>
<tr>
    <td> ScrollToBottomButtonBackground <br/><br/></td>
    <td> Background color of the scroll to bottom button view. <br/><br/></td>
</tr>
<tr>
    <td> ScrollToBottomButtonIconColor <br/><br/></td>
    <td> Color of the scroll to bottom button. <br/><br/></td>
</tr>
<tr>
    <td> HoveredScrollToBottomButtonBackground <br/><br/></td>
    <td> Background color of scroll to bottom button in hover state. <br/><br/></td>
</tr>
<tr>
    <td> PressedScrollToBottomButtonBackground <br/><br/></td>
    <td> Background color when the scroll to bottom button is pressed. <br/><br/></td>
</tr>
<tr>
    <td> ActionButtonBackground <br/><br/></td>
    <td> Background color of the action button. <br/><br/></td>
</tr>
<tr>
    <td> ActionButtonIconColor <br/><br/></td>
    <td> Color of the action button. <br/><br/></td>
</tr>
<tr>
    <td> ActionButtonTextColor <br/><br/></td>
    <td> Text color of an item in the action button. <br/><br/></td>
</tr>
<tr>
    <td> ActionButtonViewBackground <br/><br/></td>
    <td> Background color of the action buttons view. <br/><br/></td>
</tr>
</table>

## SfAutocomplete

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
        <td rowspan="16">
            SfAutocompleteStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfAutocompleteTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAutocomplete
            without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAutocompleteTheme">CommonTheme</x:String>
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
            SfAutocompleteNormalFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of SfAutocomplete
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
            Color of the clear button icon in normal state.
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
            Color of the SfAutocomplete background in normal state.
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
            Color of the SfAutocomplete stroke in normal state.
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
            Color of the SfAutocomplete text color in normal state.
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
            Color of the SfAutocomplete placeholder text. 
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
            Color of the SfAutocomplete background in focused state.
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
            Color of the SfAutocomplete stroke in focused state.
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
            Color of the SfAutocomplete text color in focused state.
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
            Color of the SfAutocomplete background in disabled state.
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
            Color of the SfAutocomplete stroke in disabled state.
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
            Color of the SfAutocomplete text color in disabled state.
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
            SfAutocompleteHoverBackground
            <br/>
            <br/>
        </td> 
        <td>
            Color of the SfAutocomplete background in hover state.
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
            Color of the SfAutocomplete stroke in hover state.
            <br/>
            <br/>
        </td>
    </tr>
</table>

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
            By merging this key in application resources, you can customize the appearance of SfAvatarView
            without merging common theme resource and control style resource dictionaries.
			
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
            Stroke color of SfAvatarView.
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
            Color for the initials string in SfAvatarView.
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
            By merging this key in application resources, you can customize the appearance of SfBackdrop
            without merging common theme resources and control style resource dictionaries.
			
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
        <td rowspan="2">
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
            By merging this key in application resources, you can customize the appearance of SfBadgeView
            without merging common theme resource and control style resource dictionaries.
			
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
            Color of the SfBadgeView background in normal state.
            <br/>
            <br/>
        </td>
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
            By merging this key in application resources, you can customize the appearance of SfBarcodeGenerator
            without merging common theme resources and control style resource dictionaries.
			
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
        <td rowspan="13">
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
            By merging this key in application resources, you can customize the appearance of SfButton
            without merging common theme resource and control style resource dictionaries.
			
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
            Color of the SfButton background in normal state.
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
            Color of the SfButton text in normal state.
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
            Color of the SfButton stroke in normal state.
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
            Color of the SfButton background in hover state.
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
            Color of the SfButton text in hover state.
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
            Color of the SfButton stroke in hover state.
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
            Color of the SfButton background in pressed state.
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
            Color of the SfButton text in pressed state.
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
            Color of the SfButton stroke in pressed state.
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
            Color of the SfButton background in disabled state.
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
            Color of the SfButton stroke in disabled state.
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
            Color of the SfButton text in disabled state.
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
            By merging this key in application resources, you can customize the appearance of SfBusyIndicator
            without merging common theme resource and control style resource dictionaries.
			
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
            Color of the SfBusyIndicator overlayfill in normal state.
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
            Color of the SfBusyIndicator indicator.
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
            Color of the SfBusyIndicator text.
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
            FontSize of the SfBusyIndicator.
            <br/>
            <br/>
        </td>
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
           SfCalendarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of the SfCalendar
            without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCalendarTheme">CommonTheme</x:String>
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
            Color of the calendar header background.
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
            Color of the calendar view header text.
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
            Color of the calendar week number text.
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
            Color of the week number background.
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
            Color of the month date text.
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
            Color of the month date text background.
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
            Color of trailing and leading text of the month.
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
            Color of trailing and leading text of the month background.
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
            Color of disabled dates in the month.
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
            Color of disabled dates' background in the month.
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
            Color of weekend dates text.
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
            Color of weekend dates text background.
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
            Color of special dates text background.
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
            Color of selected text in the month.
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
            Color of leading dates text in the year.
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
            Color of today's text in the year.
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
            Color of today's background in the year. 
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
            Color of today's highlight.
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
            Color of text when hovering over the header.
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
            By merging this key in application resources, you can customize the appearance of SfCardView
            without merging common theme resources and control style resource dictionaries.
			
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
            Color of the indicator in the card view.
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

## SfCartesian Chart

<table>
    <tr>
        <th>Theme Dictionary <br/> <br/> </th>        
        <th>Keys <br/> <br/> </th>
        <th> Description <br/> <br/> </th>
    </tr>

    <tr>
        <td rowspan="16">
            SfCartesianChartStyles  <br/> <br/>
        </td>
		<td> SfCartesianChartTheme <br/> <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfCartesianChart without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCartesianChartTheme">CommonTheme</x:String>
                <Color x:Key="SfCartesianChartBackground">AliceBlue</Color>
                <Color x:Key="SfCartesianChartMajorGridLineStroke">Black</Color>
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
        <td>SfCartesianChartBackground<br/><br/></td>
        <td>Background color of cartesian chart<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartMajorGridLineStroke<br/><br/></td>
        <td>Stoke of the axis major grid line.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartMinorGridLineStroke<br/><br/></td>
        <td>Stoke of the axis minor grid line.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartMajorTickLineStroke<br/><br/></td>
        <td>Stoke of the axis major tick line.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartMinorTickLineStroke<br/><br/></td>
        <td>Stoke of the axis minor tick line.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartAxisLineStroke<br/><br/></td>
        <td>Stoke of the axis line.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartAxisTitleTextColor<br/><br/></td>
        <td>Color of the axis title.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartAxisTitleBackground<br/><br/></td>
        <td>Background color of the axis title.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartAxisTitleStroke<br/><br/></td>
        <td>Stoke of the axis title<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartAxisTitleTextFontSize<br/><br/></td>
        <td>Font size of the axis title text.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartDataPointSelectionBrush<br/><br/></td>
        <td>Color of the selected segment of the series.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartSeriesSelectionBrush<br/><br/></td>
        <td>Color of the selected series.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartTooltipBackground<br/><br/></td>
        <td>Background of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartTooltipTextColor<br/><br/></td>
        <td>Text color of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfCartesianChartTooltipTextFontSize<br/><br/></td>
        <td>Font size of the tooltip<br/><br/></td>
    </tr>   
 </table>

## SfChat

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
    <td rowspan="113">
            SfChatStyles
            <br/>
            <br/>
        </td>
		<td>
           SfChatTheme 
            <br/>
            <br/>
        </td>
        <td>
            By merging this key in application resources, it is possible to customize the appearance of the SfChat without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfChatheme">CommonTheme</x:String>
                <Color x:Key="SfChatIncomingMessageBackground">Red</Color>
                <Color x:Key="SfChatOutgoingMessageBackground">Green</Color>
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
    <!--Incoming message-->
    <tr>
        <td> SfChatIncomingMessageBackground <br/><br/></td>
        <td> Background color of incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTextColor <br/><br/></td>
        <td> Text color of incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageFontFamily <br/><br/></td>
        <td> Font family of incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageFontAttributes <br/><br/></td>
        <td> Font attributes of incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageFontSize <br/><br/></td>
        <td> Font size of incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageAuthorTextColor <br/><br/></td>
        <td> Text color of the author name in incoming messages.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageAuthorFontFamily <br/><br/></td>
        <td> Font family of the author name in incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageAuthorFontAttributes <br/><br/></td>
        <td> Font attributes of the author name in incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageAuthorFontSize <br/><br/></td>
        <td> Font size of the author name in incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTimestampTextColor <br/><br/></td>
        <td> Text color of the timestamp in incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTimestampFontFamily <br/><br/></td>
        <td> Font family of the timestamp in incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTimestampFontAttributes <br/><br/></td>
        <td> Font attributes of the timestamp in incoming messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTimestampFontSize <br/><br/></td>
        <td> Font size of the timestamp in incoming messages.<br/><br/></td>
    </tr>
    <!--Outgoing message-->
    <tr>
        <td> SfChatOutgoingMessageBackground <br/><br/></td>
        <td> Background color of outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTextColor <br/><br/></td>
        <td> Text color of outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageFontFamily <br/><br/></td>
        <td> Font family of outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageFontAttributes <br/><br/></td>
        <td> Font attributes of outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageFontSize <br/><br/></td>
        <td> Font size of outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageAuthorTextColor <br/><br/></td>
        <td> Text color of the author name in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageAuthorFontFamily <br/><br/></td>
        <td> Font family of the author name in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageAuthorFontAttributes <br/><br/></td>
        <td> Font attributes of the author name in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageAuthorFontSize <br/><br/></td>
        <td> Font size of the author name in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTimestampTextColor <br/><br/></td>
        <td> Text color of the timestamp in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTimestampFontFamily <br/><br/></td>
        <td> Font family of the timestamp in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTimestampFontAttributes <br/><br/></td>
        <td> Font attributes of the timestamp in outgoing messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTimestampFontSize <br/><br/></td>
        <td> Font size of the timestamp in outgoing messages.<br/><br/></td>
    </tr>
    <!--Date picker message-->
    <tr>
        <td> SfChatDatePickerIconColor <br/><br/></td>
        <td> Icon color of date picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDatePickerTextColor <br/><br/></td>
        <td> Text color of date picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDatePickerStroke <br/><br/></td>
        <td> Border color of date picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDatePickerBackground <br/><br/></td>
        <td> Background color of date picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDateTimeInputMessageIconColor <br/><br/></td>
        <td> Icon color for datetime input messsge. <br/><br/></td>
    </tr>
    <tr>
       <td> SfChatDateTimeInputMessageIconBackground <br/><br/></td>
       <td> Icon background color for datetime input messsge. <br/><br/></td>
    </tr>
    <!--Time picker message-->
    <tr>
        <td> SfChatTimePickerIconColor <br/><br/></td>
        <td> Icon color of time picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimePickerTextColor <br/><br/></td>
        <td> Text color of time picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimePickerStroke <br/><br/></td>
        <td> Border color of time picker.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimePickerBackground <br/><br/></td>
        <td> Background color of time picker.<br/><br/></td>
    </tr>
    <!--Hyperlink message-->
    <tr>
        <td> SfChatIncomingHyperlinkColor <br/><br/></td>
        <td> Text color of the URL in an incoming hyperlink message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHyperlinkMetaTitleTextColor <br/><br/></td>
        <td> Text color of the URL's meta title in a hyperlink message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHyperlinkDescriptionTextColor <br/><br/></td>
        <td> Text color of the URL's meta description in a hyperlink message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHyperlinkDescriptionBackground <br/><br/></td>
        <td> Background color of the URL description area in a hyperlink message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingHyperlinkColor <br/><br/></td>
        <td> Text color of the URL in an outgoing hyperlink message.<br/><br/></td>
    </tr>
     <!--Image message-->
    <tr>
        <td> SfChatIncomingImageStroke <br/><br/></td>
        <td> Border color of an image in incoming image messages.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingImageStroke <br/><br/></td>
        <td> Border color of an image in outgoing image messages.<br/><br/></td>
    </tr>
     <!--Calendar message-->
    <tr>
        <td> SfChatCalendarBackground <br/><br/></td>
        <td> Background color of calendar within a calendar message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCalendarStroke <br/><br/></td>
        <td> Border color of calendar in a calendar message.<br/><br/></td>
    </tr>
    <!--Card message-->
    <tr>
        <td> SfChatCardBackground <br/><br/></td>
        <td> Background color of the card in a card message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardStroke <br/><br/></td>
        <td> Border color of the card in a card message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardTitleTextColor <br/><br/></td>
        <td> Text color of the title of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardTitleFontFamily <br/><br/></td>
        <td> Font family of title of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardTitleFontSize <br/><br/></td>
        <td> Font size of title of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardTitleFontAttributes <br/><br/></td>
        <td> Font attribites of title of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardSubtitleTextColor <br/><br/></td>
        <td> Text color of subtitle of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardSubtitleFontFamily <br/><br/></td>
        <td> Font family of subtitle of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardSubtitleFontSize <br/><br/></td>
        <td> Font size of subtitle of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardSubtitleFontAttributes <br/><br/></td>
        <td> Font attributes of subtitle of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardDescriptionTextColor <br/><br/></td>
        <td> Text color of description of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardDescriptionFontFamily <br/><br/></td>
        <td> Font family of description of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardDescriptionFontSize <br/><br/></td>
        <td> Font size of description of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardDescriptionFontAttributes <br/><br/></td>
        <td> Font attributes of description of the card.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonBackground <br/><br/></td>
        <td> Background color of the card button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonStroke <br/><br/></td>
        <td> Border color of the card button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonTextColor <br/><br/></td>
        <td> Text color of card button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonFontFamily <br/><br/></td>
        <td> Font family of card button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonFontSize <br/><br/></td>
        <td> Font size of card button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonFontAttributes <br/><br/></td>
        <td> Font attributes of card button.<br/><br/></td>
    </tr>
    <!--DeliveryStates-->
    <tr>
        <td> SfChatDeliveryStateFailedIconColor <br/><br/></td>
        <td> Color of the Delivery State None. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDeliveryStateSentIconColor <br/><br/></td>
        <td> Color of the Delivery State Sent. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDeliveryStateDeliveredIconColor <br/><br/></td>
        <td> Color of the Delivery State Delivered. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDeliveryStateReadIconColor <br/><br/></td>
        <td> Color of the Delivery State Read. <br/><br/></td>
    </tr>
    <!--Message input view-->
    <tr>
        <td> SfChatMessageInputViewBackground <br/><br/></td>
        <td> Background color of the message input view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorPlaceholderTextColor <br/><br/></td>
        <td> Text color of the editor placeholder.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorTextColor <br/><br/></td>
        <td> Text color of the editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorBackground <br/><br/></td>
        <td> Background color of the editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatFocusedEditorStroke <br/><br/></td>
        <td> Border color of enabled editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorStroke <br/><br/></td>
        <td> Border color of disabled editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorFontFamily <br/><br/></td>
        <td> Font family of the editor text.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorFontSize <br/><br/></td>
        <td> Font size of the editor text.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorFontAttributes <br/><br/></td>
        <td> Font attributes of the editor text.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSendButtonColor <br/><br/></td>
        <td> Color of the send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSendButtonBackground <br/><br/></td>
        <td> Background color of the send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSendButtonDisabledColor <br/><br/></td>
        <td> Color of the send button in a 'Disabled' state. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDisabledSendButtonBackground <br/><br/></td>
        <td> Disabled background color of the send button. <br/><br/></td>
    </tr>
    <tr>
       <td> SfChatHoveredSendButtonBackground <br/><br/></td>
       <td> Hovered background color of the send button. <br/><br/></td>
    </tr>
    <tr>
       <td> SfChatPressedSendButtonBackground <br/><br/></td>
       <td> Pressed background color of the send button. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatAttachmentButtonColor <br/><br/></td>
        <td> Color for the attachment button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatAttachmentBackground <br/><br/></td>
        <td> Background color of the attachment button. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHoveredAttachmentBackground <br/><br/></td>
        <td> Hovered background color of the attachment button. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatPressedAttachmentBackground <br/><br/></td>
        <td> Pressed background color of the attachment button. <br/><br/></td>
    </tr>
        <tr>
        <td> SfChatHoveredAttachmentButtonColor <br/><br/></td>
        <td> Hovered color of the attachment button. <br/><br/></td>
    </tr>
    <!--Time break view-->
    <tr>
        <td> SfChatTimeBreakViewTextColor <br/><br/></td>
        <td> Text color of the time break view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewBackground <br/><br/></td>
        <td> Background color of the time break view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewStroke <br/><br/></td>
        <td> Border color of the time break view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewFontFamily <br/><br/></td>
        <td> Font family of the time break view label.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewFontSize <br/><br/></td>
        <td> Font size of the time break view label.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewFontAttributes <br/><br/></td>
        <td> Font attributes of the time break view label.<br/><br/></td>
    </tr>
    <!--typing indicator-->
    <tr>
        <td> SfChatTypingIndicatorTextColor <br/><br/></td>
        <td> Text Color of the typing indicator.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatTypingIndicatorBackground <br/><br/></td>
        <td> Background Color of the typing indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTypingIndicatorFontFamily <br/><br/></td>
        <td> Font family of the typing indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTypingIndicatorFontSize <br/><br/></td>
        <td> Font size of the typing indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTypingIndicatorFontAttributes <br/><br/></td>
        <td> Font attributes of the typing indicator.<br/><br/></td>
    </tr>
    <!--Suggestions-->
    <tr>
        <td> SfChatSuggestionListItemTextColor <br/><br/></td>
        <td> Text color of an item in the list of suggestions. <br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSuggestionListItemBackground <br/><br/></td>
        <td> Background color of an item in the list of suggestions.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSuggestionListItemStroke <br/><br/></td>
        <td> Border color of an item in the list of suggestions.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSuggestionListItemFontFamily <br/><br/></td>
        <td> Font family of an item in the list of suggestions.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSuggestionListItemFontSize <br/><br/></td>
        <td> Font attributes of an item in the list of suggestions.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatSuggestionListItemFontAttributes <br/><br/></td>
        <td> Font size of an item in the list of suggestions.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSuggestionListBackground <br/><br/></td>
        <td> Background color of the suggestion list view.<br/><br/></td>
    </tr>
    <!--Load more-->
    <tr>
        <td> SfChatLoadMoreIndicatorColor <br/><br/></td>
        <td> Color of the load more indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatLoadMoreTextColor <br/><br/></td>
        <td> Text color of the load more button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatLoadMoreBackground <br/><br/></td>
        <td> Background color of the load more button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatLoadMoreStroke <br/><br/></td>
        <td> Border color of the load more button.<br/><br/></td>
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
        <td rowspan="13">
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
            Color of the SfCheckBox in it's unchecked state.
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
            Color of the SfCheckBox in it's checked state
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
            Color of the SfCheckBox text.
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
            Color of the SfCheckBox tick.
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
            Color of the SfCheckBox in it's checked state while hovering.
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
            Color of the SfCheckBox in its unchecked state while hovering.
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
            Color of the SfCheckBox text in hovered state.
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
            Color of the SfCheckBox in its checked state while pressed.
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
            Color of the SfCheckBox in its unchecked state while pressed.
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
            Color of the SfCheckBox text in pressed state.
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
            Color of the unchecked SfCheckBox in disabled state.
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
            Color of the checked SfCheckBox in disabled state.
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
        <td rowspan="32">
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
            By merging this key in application resources, you can customize the appearance of SfChips without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfChipTheme">CommonTheme</x:String>
                <Color x:Key="SfChipNormalBackground">Purple</Color>
                <Color x:Key="SfChipNormalTextColor">YellowGreen</Color>
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
            SfChipNormalStrokeThickness
            <br/>
            <br/>
        </td>
        <td>
            StrokeThickness of the SfChips.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the SfChips.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipNormalCornerRadius
            <br/>
            <br/>
        </td>
        <td>
            CornerRadius of the SfChips.
            <br/>
            <br/>
        </td>
    </tr>
        <tr>
        <td>
            SfChipNormalBackground 
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips Background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipNormalTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChip TextColor.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipNormalClearButtonIconColor  
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
            SfChipNormalStroke 
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipNormalSelectionIndicatorColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips selection indicator.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipDisabledBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips background in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipDisabledTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips text in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipDisabledClearButtonIconColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the clear button icon in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipDisabledStroke
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips stroke in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfChipDisabledSelectionIndicatorColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfChips selection indicator in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
        <tr>
        <td>
           SfChipGroupTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfChipGroup without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfChipGroupTheme">CommonTheme</x:String>
                <Color x:Key="SfChipGroupNormalSelectionBackground">Purple</Color>
                <Color x:Key="SfChipGroupNormalSelectedTextColor">YellowGreen</Color>
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
            SfChipGroupNormalStrokeThickness
            <br/>
            <br/>
        </td>
        <td>
            StrokeThickness of the SfChipGroup.
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
            CornerRadius of the SfChipGroup.
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
            Color of the SfChipGroup selected text in normal state.
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
            Color of the clear button icon.
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
            Color of the SfChipGroup background.
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
            Color of the SfChipGroup text.
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
            Color of the SfChipGroup stroke in normal state.
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
            Color of the SfChipGroup selection background.
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
            Color of the SfChipGroup selection indicator.
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
            Color of the SfChipGroup stroke in pressed state.
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
            Color of the SfChipGroup background in disabled state.
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
            Color of the SfChipGroup text in disabled state.
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
            Color of the SfChipGroup stroke in disabled state.
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
            Color of the SfChipGroup selected background in disabled state.
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
            Color of the SfChipGroup selected text in disabled state.
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
            Color of the SfChipGroup selection indicator in disabled state.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfCircular Chart
 <table>
     <tr>
         <th>Theme Dictionary <br/> <br/> </th>        
         <th>Keys <br/> <br/> </th>
         <th> Description <br/> <br/> </th>
     </tr>
     <tr>
         <td rowspan="6">
             SfCircularChartStyles  <br/> <br/>
         </td>
         <td> SfCircularChartTheme <br/> <br/>
         </td>
         <td>    
             By merging this key in application resources, you can customize the appearance of SfCircularChart without merging common theme resource and control style resource dictionaries.
             
{% highlight xaml %}
 <Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
              ...>
  <Application.Resources>
     <ResourceDictionary>
         <ResourceDictionary.MergedDictionaries>
             <syncTheme:SyncfusionThemeResourceDictionary />
             <ResourceDictionary>
                 <x:String x:Key="SfCircularChartTheme">CommonTheme</x:String>
                 <Color x:Key="SfCircularChartBackground">LightYellow</Color>
                 <Color x:Key="SfCircularChartTooltipBackground">Gray</Color>
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
        <td>SfCircularChartBackground<br/><br/></td>
        <td>Background of the circular chart<br/><br/></td>
    </tr>
    <tr>
        <td>SfCircularChartSelectionBrush<br/><br/></td>
        <td>Color of the selected segment of the series.<br/><br/></td>
    </tr>
    <tr>
        <td>SfCircularChartTooltipBackground<br/><br/></td>
        <td>Background of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfCircularChartTooltipTextColor<br/><br/></td>
        <td>Text color of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfCircularChartTooltipTextFontSize<br/><br/></td>
        <td>Font size of the tooltip text<br/><br/></td>
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
            Color of the progress in the circular progress bar.
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

## SfColorPicker

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
            SfColorPickerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfColorPickerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key into application resources, you can customize the appearance of SfColorPicker
            without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfColorPickerTheme">CommonTheme</x:String>
                <Color x:Key="SfColorPickerPopupBackground">Pink</Color>
                <Color x:Key="SfColorPickerApplyButtonBackground">Blue</Color>
                <Color x:Key="SfColorPickerCancelButtonBackground">Orange</Color>
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
            SfColorPickerPopupBackground
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the Color Picker popup.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfColorPickerApplyButtonBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the apply button.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfColorPickerApplyButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the apply button.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfColorPickerCancelButtonBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the cancel button.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerCancelButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the cancel button.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerSpectrumInputViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the Spectrum's input view.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerInputBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the Color Picker's input.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerInputBorderFocusedColor
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the Color Picker's input when it is in a focused state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerSliderThumbFill
            <br/>
            <br/>
        </td> 
        <td>
            Color of the slider thumb within the Color Picker.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerSliderThumbStroke
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the slider thumb.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerSpectrumSelectionIndicatorStroke
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the spectrum selection indicator.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerModeSwitcherGradientBackground
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the mode switcher.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfColorPickerPaletteSelectionStroke 
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color for the palette selection.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfColorPickerRecentColorsLabelColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the label for recent colors.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerCustomColorsLabelColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the label for custom colors.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerAlphaSliderBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the alpha (transparency) slider.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerDisplayViewBorderStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Border color for the display view.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerDropDownIconColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the dropdown icon.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerDisplayViewBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color for the display view.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerCancelButtonHovered  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the cancel button when hovered.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerApplyButtonHovered  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the apply button when hovered.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfColorPickerApplyButtonPressed  
            <br/>
            <br/>
        </td> 
        <td>
            Color of the apply button when pressed.
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
        <td rowspan="21">
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
            SfComboBoxNormalFontSize
            <br/>
            <br/>
        </td>
        <td>
            FontSize of the SfComboBox.
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
            Color of the SfComboBox background.
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
            Color of the SfComboBox stroke.
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
            Color of the SfComboBox text.
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
            Color of the SfComboBox placeholder text.
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
            SfComboBoxFocusedBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfComboBox background in focused state.
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
            Color of the SfComboBox stroke in focused state.
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
            Color of the SfComboBox dropdown icon in focused state.
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
            Color of the clear button icon in focused state.
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
            Color of the clear button icon in disabled state.
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
            Color of the SfComboBox background in disabled state.
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
            Color of the SfComboBox stroke in disabled state.
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
            Color of the SfComboBox text in disabled state.
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
            Color of the SfComboBox dropdown icon in disabled state.
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
            Color of the SfComboBox placeholder text in disabled state.
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
            Color of the SfComboBox background in hovered state.
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
            Color of the SfComboBox stroke in hovered state.
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
            Color of the SfComboBox text in hovered state.
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
            Color of the SfComboBox dropdown icon.
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
            Font size of editor text in the dataform.
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
            Font size of label in the dataform.     
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
            Font size of error label's in the dataform. 
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
            Font size of valid message label's in the dataform.
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
            Font size of group header text in the dataform.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfDataGrid

<table>
    <tr>
        <th>Theme Dictionary<br/><br/></th>
        <th>Keys<br/><br/></th>
        <th>Description<br/><br/></th>
    </tr>
    <tr>
        <td rowspan="33">SfDataGridStyles<br/><br/></td>
		<td>SfDataGridTheme<br/><br/></td>
        <td>By merging this key in application resources, it is possible to customize the appearance of the SfDataGrid without merging common theme resource and control style resource dictionaries.	
{% highlight xaml %}
<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <syncTheme:SyncfusionThemeResourceDictionary />
                <ResourceDictionary>
                    <x:String x:Key="SfDataGridTheme">CommonTheme</x:String>
                    <Color x:Key="SfDataGridHeaderRowTextColor">Red</Color>
                    <Color x:Key="SfDataGridRowTextColor">LightBlue</Color>
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
        <td>SfDataGridHeaderRowBackground<br/><br/></td>
        <td>Background color of the header row in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridHeaderRowTextColor<br/><br/></td>
        <td>Text color of the header row in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridRowBackground<br/><br/></td>
        <td>Background color of the data rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridRowTextColor<br/><br/></td>
        <td>Text color of the data rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridGridLineColor<br/><br/></td>
        <td>Color for the grid lines in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridSelectionBackground<br/><br/></td>
        <td>Background color of the selected rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>            
        <td>SfDataGridSelectedRowTextColor<br/><br/></td>
        <td>Text color of the selected rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridAlternatingRowBackground<br/><br/></td>
        <td>Background color of the alternate rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridCurrentCellBorderColor<br/><br/></td>
        <td>Border color of the current cell in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridCurrentRowHighlightColor<br/><br/></td>
        <td>Border color of the current row in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridCaptionSummaryRowBackground<br/><br/></td>
        <td>Background color of the caption summary rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridCaptionSummaryRowTextColor<br/><br/></td>
        <td>Text color of the caption summary rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridGroupSummaryRowBackground<br/><br/></td>
        <td>Background color of the group summary rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridGroupSummaryRowTextColor<br/><br/></td>
        <td>Text color of the group summary rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridTableSummaryRowBackground<br/><br/></td>
        <td>Background color of the table summary rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridTableSummaryRowTextColor<br/><br/></td>
        <td>Text color of the table summary rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridFreezePaneLineColor<br/><br/></td>
        <td>Color of the line which indicates the frozen pane in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridStackedHeaderRowBackground<br/><br/></td>
        <td>Background color of the stacked header rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridStackedHeaderRowTextColor<br/><br/></td>
        <td>Text color of the stacked header rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridSortNumberTextColor<br/><br/></td>
        <td>Text color of the sort number in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridSortNumberBackground<br/><br/></td>
        <td>Background color of the sort number in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridGroupIconColor<br/><br/></td>
        <td>Color of the group icon in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridCheckBoxColor<br/><br/></td>
        <td>Color of the check box in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridInputBackgroundColor<br/><br/></td>
        <td>Background color of the input in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridSortIconColor<br/><br/></td>
        <td>Color of the sort icon in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridLoadMoreBackground<br/><br/></td>
        <td>Background color of the load more view in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridLoadMoreButtonTextColor<br/><br/></td>
        <td>Text color of the load more Button in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridLoadMoreButtonBackground<br/><br/></td>
        <td>Background color of the load more Button in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridLoadMoreIndicatorColor<br/><br/></td>
        <td>Color of the load more indicator in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridColumnResizingIndicatorColor<br/><br/></td>
        <td>Color of the column resizing indicator in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridUnboundRowBackground<br/><br/></td>
        <td>Background color of the unbound rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridUnboundRowTextColor<br/><br/></td>
        <td>Text color of the unbound rows in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridColumnDraggingIndicatorLineColor<br/><br/></td>
        <td>Indicator line color of the column drag view in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridColumnDragViewBackgroundColor<br/><br/></td>
        <td>Background color of the column drag view in the SfDataGrid.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataGridColumnDragViewTextColor<br/><br/></td>
        <td>Text color of the column drag view in the SfDataGrid.<br/><br/></td>
    </tr>
</table>

## SfDataPager

<table>
    <tr>
        <th>Theme Dictionary<br/><br/></th>
        <th>Keys<br/><br/></th>
        <th>Description<br/><br/></th>
    </tr>
    <tr>
        <td rowspan="11">SfDataPagerStyles<br/><br/></td>
		<td>SfDataPagerTheme<br/><br/></td>
        <td>By merging this key in application resources, it is possible to customize the appearance of the SfDataPager without merging common theme resource and control style resource dictionaries.
{% highlight xaml %}
<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <syncTheme:SyncfusionThemeResourceDictionary />
                <ResourceDictionary>
                    <x:String x:Key="SfDataPagerTheme">CommonTheme</x:String>
                    <Color x:Key="SfDataPagerNumericButtonTextColor">Red</Color>
                    <Color x:Key="SfDataPagerNumericButtonSelectionTextColor">LightBlue</Color>
                </ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
....
</Application>
{% endhighlight %}
        <br/><br/></td>
	</tr>
    <tr>
        <td>SfDataPagerNavigationButtonIconColor<br/><br/></td>
        <td>Color of the navigation button icon in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerDataPagerBackgroundColor<br/><br/></td>
        <td>Background color of the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNumericButtonSelectionBackgroundColor<br/><br/></td>
        <td>Background color of the selected numeric button in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNavigationButtonBackgroundColor<br/><br/></td>
        <td>Background color of the navigation button in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNumericButtonBackgroundColor<br/><br/></td>
        <td>Background color of the numeric button in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNumericButtonTextColor<br/><br/></td>
        <td>Text color of the numeric button in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNumericButtonSelectionTextColor<br/><br/></td>
        <td>Text color of the selected numeric button in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNavigationButtonDisableBackgroundColor<br/><br/></td>
        <td>Background color of the disable navigation button in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerNavigationButtonDisableIconColor<br/><br/></td>
        <td>Color of the disable navigation button icon in the SfDataPager.<br/><br/></td>
    </tr>
    <tr>
        <td>SfDataPagerHoveredBackgroundColor<br/><br/></td>
        <td>Hovering background color of the numeric and navigation buttons in the SfDataPager.<br/><br/></td>
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
            Color of the SfEffectsView ripple background.
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
            Color of the SfEffectsView selection background
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
            Color of the SfEffectsView highlight background.
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
            Duration of the SfEffectsView ripple animation.
            <br/>
            <br/>
        </td>
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
        <td> Background color of header when it is in hovered state.<br/><br/></td>
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
        <td> Color of header icon when it is in hovered state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderPressedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in pressed state.<br/><br/></td> 
    </tr>
</table>

## SfFunnel Chart

<table>
     <tr>
         <th>Theme Dictionary <br/> <br/> </th>         
         <th>Keys <br/> <br/> </th>
         <th> Description <br/> <br/> </th>
     </tr>
     <tr>
         <td rowspan="6">
             SfFunnelStyles  <br/> <br/>
         </td>
         <td> SfFunnelChartTheme <br/> <br/>
         </td>
         <td>    
             By merging this key in application resources, you can customize the appearance of SfFunnelChart without merging common theme resource and control style resource dictionaries.
             
{% highlight xaml %}
 <Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
              ...>
  <Application.Resources>
     <ResourceDictionary>
         <ResourceDictionary.MergedDictionaries>
             <syncTheme:SyncfusionThemeResourceDictionary />
             <ResourceDictionary>
                 <x:String x:Key="SfFunnelChartTheme">CommonTheme</x:String>
                 <Color x:Key="SfFunnelChartBackground">LightYellow</Color>
                 <Color x:Key="SfFunnelChartTooltipBackground">Gray</Color>
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
        <td>SfFunnelChartBackground<br/><br/></td>
        <td>Background of funnel chart<br/><br/></td>
    </tr>
    <tr>
        <td>SfFunnelChartSelectionBrush<br/><br/></td>
        <td>Color of the selected segment.<br/><br/></td>
    </tr>
    <tr>
        <td>SfFunnelChartTooltipBackground<br/><br/></td>
        <td>Background of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfFunnelChartTooltipTextColor<br/><br/></td>
        <td>Text color of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfFunnelChartTooltipTextFontSize<br/><br/></td>
        <td>Font size of the tooltip text<br/><br/></td>
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
        <td rowspan="21">
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
            Background Color of tooltip in Image editor toolbar.   
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
            Color of the tool bar icons divider line.     
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
            Font size of the toolbar text in image editor.    
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
            Font size of the tooltip text in image editor      
            <br/>
            <br/>
        </td>
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
            Color of the progress in the linear progress bar.
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
            Color of the secondary progress in the linear progress bar.
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
        <td> Background color of the ListViewItem. <br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewHoverListViewItemBackground <br/><br/></td>
        <td> Background color of the ListViewItem when it is in hovered state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemBackground <br/><br/></td>
        <td> Background color of the ListViewItem when it is in focused state.<br/><br/></td>
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
    <tr>
        <td> SfListViewNormalLoadMoreItemTextColor <br/><br/></td> 
        <td> Text color of the load more button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreIndicatorIconColor <br/><br/></td> 
        <td> Color of the Load More Indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemBackground <br/><br/></td> 
        <td> Background color of the EmptyViewItem.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemTextColor <br/><br/></td> 
        <td> Text color of the EmptyViewItem.<br/><br/></td>
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
            Color of bubble in maps.
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
            Background color of tooltip in maps.   
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
            Color of shape layer shape when it is selected.   
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
            Color of shape layer shape stroke when it is selected.   
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
            Color of shape layer shape when it is hovered.    
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
            Color of shape layer shape stroke when it is hovered.      
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
            Color of shape sublayer in maps.     
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
             Color of shape sublayer stroke in maps.      
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
            Font size of tooltip text in maps.      
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
            Font size of data label in maps.      
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
        <td rowspan="14">
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
            Color of the SfMaskedEntry text.
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
            Color of the SfMaskedEntry background.
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
            Color of the SfMaskedEntry placeholder text.
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
            Color of the SfMaskedEntry stroke.
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
            Color of the SfMaskedEntry text in the disabled state.
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
            Color of the SfMaskedEntry background in the disabled state.
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
            Color of the SfMaskedEntry stroke in the disabled state.
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
            Color of the SfMaskedEntry text in hovered state.
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
            Color of the SfMaskedEntry background in hovered state.
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
            Color of the SfMaskedEntry stroke in hovered state.
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
            Color of the SfMaskedEntry text in focused state.
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
            Color of the SfMaskedEntry background in focused state.
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
            Color of the SfMaskedEntry stroke in focused state.
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
                <Color x:Key="SfNavigationDrawerContentBackground">Yellow</Color>
                <Color x:Key="SfNavigationDrawerGreyLayoutBackground">Red</Color>
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
            Color of the SfNavigationDrawer background.
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
            Color of the SfNavigationDrawer layout background.
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
        <td rowspan="21">
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
            Color of the SfNumericEntry text.
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
            Color of the SfNumericEntry background.
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
            Color of the SfNumericEntry stroke.
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
            Color of the SfNumericEntry text in disabled state.
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
            Color of the SfNumericEntry background in disabled state.
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
            Color of the SfNumericEntry clear button in disabled state.
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
            Color of the SfNumericEntry stroke in disabled state.
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
            Color of the SfNumericEntry arrow in disabled state.
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
            Color of the SfNumericEntry text in hovered state.
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
            Color of the SfNumericEntry background in hovered state.
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
            Color of the SfNumericEntry stroke in hovered state.
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
            Color of the SfNumericEntry clear button.
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
            Color of the SfNumericEntry arrow in hovered state.
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
            Color of the SfNumericEntry text in focused state.
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
            Color of the SfNumericEntry background in focused state.
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
            Color of the SfNumericEntry stroke in focused state.
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
            Color of the SfNumericEntry clear button in pressed state.
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
            Color of the SfNumericEntry arrow.
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
            Color of the SfNumericEntry arrow in pressed state. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfNumericEntryPlaceholderTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfNumericEntry placeholder text.
            <br/>
            <br/>
        </td>
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
        <td rowspan="430">
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
            Background colour of the tabview container in the outline view of the SfPdfViewer.
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
            Text colour of the No Bookmark label in the outline view of the SfPdfViewer.
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
            Background color of the 'OK' button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'OK' button while hovering over the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'OK' button while pressing the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'OK' button while focusing the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'OK' button after disabled the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Stroke color of the 'OK' button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Stroke color of the 'OK' button while hovering over the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Stroke color of the 'OK' button while pressing the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Stroke color of the 'OK' button while focusing the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Stroke color of the 'OK' button after disabled the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'OK' button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'OK' button while hovering over the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'OK' button while focusing the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'OK' button while pressing the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'OK' button after disabled the button in the password, message, combobox form field list, listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the title in the password, message and hyperlink dialogs of the SfPdfViewer.
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
            Text color of the description in the password, message and hyperlink dialogs of the SfPdfViewer.
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
            Background color of the 'close' button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Background color of the 'close' button while hovering over the button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Background color of the 'close' button while pressing the button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Background color of the 'close' button while focusing the button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Text color of the 'close' button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Text color of the 'close' button while hovering over the in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Text color of the 'close' button while focusing the in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Text color of the 'close' button while pressing the in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Border color of the 'close' button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Border color of the 'close' button while hovering over the button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Border color of the 'close' button while focusing the button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Border color of the 'close' button while pressing the button in the password, message, hyperlink and free text dialogs of the SfPdfViewer.
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
            Background color of the password, message, hyperlink, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
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
            Border color of the password, message and hyperlink dialogs in the SfPdfViewer.
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
            Background color of the 'cancel' button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'cancel' button while hovering over the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'cancel' button while pressing the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'cancel' button while focusing the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'cancel' button after disabled the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Border color of the 'cancel' button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Border color of the 'cancel' button while hovering over the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Border color of the 'cancel' button while pressing the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Border color of the 'cancel' button while focusing the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Border color of the 'cancel' button after disabled the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'cancel' button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'cancel' button while hovering over the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'cancel' button while focusing the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'cancel' button while pressing the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Text color of the 'cancel' button after disabled the button in the password, message, hyperlink, combobox form field list and listbox form field list dialogs of the SfPdfViewer.
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
            Background color of the 'open' button in the hyperlink dialog of the SfPdfViewer.
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
            Background color of the 'open' button while hovering over the button in the hyperlink dialog of the SfPdfViewer.
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
            Background color of the 'open' button while pressing the button in the hyperlink dialog of the SfPdfViewer.
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
            Background color of the 'open' button while focusing the button in the hyperlink dialog of the SfPdfViewer.
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
            Background color of the 'open' button after disabled the button in the hyperlink dialog of the SfPdfViewer.
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
            Border color of the 'open' button in the hyperlink dialog of the SfPdfViewer.
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
            Border color of the 'open' button while hovering over the button in the hyperlink dialog of the SfPdfViewer.
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
            Border color of the 'open' button while pressing the button in the hyperlink dialog of the SfPdfViewer.
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
            Border color of the 'open' button while focusing the button in the hyperlink dialog of the SfPdfViewer.
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
            Border color of the 'open' button after disabled the button in the hyperlink dialog of the SfPdfViewer.
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
            Text color of the 'open' button in the hyperlink dialog of the SfPdfViewer.
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
            Text color of the 'open' button while hovering over the button in the hyperlink dialog of the SfPdfViewer.
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
            Text color of the 'open' button while focusing the button in the hyperlink dialog of the SfPdfViewer.
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
            Text color of the 'open' button while pressing the button in the hyperlink dialog of the SfPdfViewer.
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
            Text color of the 'open' button after disabled the button in the hyperlink dialog of the SfPdfViewer.
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
            Text color of the title of the outline view in the SfPdfViewer.
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
            Text color of the expander of the outline view in the SfPdfViewer.
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
            Background color of the expander of the outline view in the SfPdfViewer.
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
            Hovering background color of the expander of the outline view in the SfPdfViewer.
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
            Pressed background color of the expander of the outline view in the SfPdfViewer.
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
            Focused background color of the expander of the outline view in the SfPdfViewer.
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
             Border color of the expander button of the outline view in the SfPdfViewer.
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
             Hovering border color of the expander button of the outline view in the SfPdfViewer.
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
            Pressed border color of the expander button of the outline view in the SfPdfViewer.
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
            Focused border color of the expander button of the outline view in the SfPdfViewer.
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
            Text color of the expander button of the outline view in the SfPdfViewer.
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
            Hovering text color of the expander button of the outline view in the SfPdfViewer.
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
            Focused text color of the expander button of the outline view in the SfPdfViewer.
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
            Pressed text color of the expander button of the outline view in the SfPdfViewer.
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
            Separator color of outline view in the SfPdfViewer.
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
            Text color of the title of outline view in the SfPdfViewer.
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
            Background color of the outline view container in the SfPdfViewer.
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
            Background color of the close button of the outline view in the SfPdfViewer.
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
            Hovering background color of the close button of the outline view in the SfPdfViewer.
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
            Focused background color of the close button in the outline view of the SfPdfViewer.
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
            Pressed background color of the close button in the outline view of the SfPdfViewer.
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
            Border color of the close button in the outline view of the SfPdfViewer.
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
            Hovering border color of the close button in the outline view of the SfPdfViewer.
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
            Pressed border color of the close button in the outline view of the SfPdfViewer.
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
            Focused border color of the close button in the outline view of the SfPdfViewer.
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
            Focused border color of the close button in the outline view of the SfPdfViewer.
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
            Text color of the close button in the outline view of the SfPdfViewer.
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
            Hovering text color of the close button in the outline view of the SfPdfViewer.
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
            Focused text color of the close button in the outline view of the SfPdfViewer.
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
            Pressed text color of the close button in the outline view of the SfPdfViewer.
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
            Text color of the 'Save' button in the free text dialog of the SfPdfViewer.
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
            Hovering text color of the 'Save' button in the free text dialog of the SfPdfViewer.
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
            Pressed text color of the 'Save' button in the free text dialog of the SfPdfViewer.
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
            Text color of the 'Save' button after disabled the button in the free text dialog of the SfPdfViewer.
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
            Background color of the 'Save' button in the free text dialog of the SfPdfViewer.
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
            Hovering background color of the 'Save' button in the free text dialog of the SfPdfViewer.
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
            Pressed background color of the 'Save' button in the free text dialog of the SfPdfViewer.
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
            Background color of the 'Save' button after disabled the button in the free text dialog of the SfPdfViewer.
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
            Hovering background color of the signature pad's 'Close' button in the SfPdfViewer.
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
            Pressed background color of the signature pad's 'Close' button in the SfPdfViewer.
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
            Text color of the signature pad's 'Create' button in the SfPdfViewer.
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
            Border color of signature list view's items in the SfPdfViewer.
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
            Background color of signature list view's items while long press in the SfPdfViewer.
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
            Border color of signature list view's items while long pressing on item in the SfPdfViewer.
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
            Background color of signature list view's items while tapping on the item in the SfPdfViewer.
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
            Background color of signature list view in the SfPdfViewer.
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
            Text color of the signature list view container's create button in the SfPdfViewer.
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
            Stroke color of the signature list view container's create button in the SfPdfViewer.
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
            Text color of the signature list view container's delete button in the SfPdfViewer.
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
            Text color of the signature list view container's header in the SfPdfViewer.
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
            Text color of the signature list view delete button in the SfPdfViewer.
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
            Text color of the signature list view create button in the SfPdfViewer.
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
    <tr>
        <td>
           SfPdfViewerPageCountLabelBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the page count label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
           SfPdfViewerPageCountLabelTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the page count label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
           SfPdfViewerPageNavigationDialogTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
           SfPdfViewerPageNavigationDialogPageBoxNormalStateColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the page navigation(Go to page) dialog entry's normal state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
           SfPdfViewerPageNavigationDialogPageBoxFocusedStateColor
            <br/>
            <br/>
        </td> 
        <td>
            Focused color of the page navigation(Go to page) dialog entry in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
           SfPdfViewerPageNavigationDialogPageBoxErrorStateColor
            <br/>
            <br/>
        </td> 
        <td>
            Error state color of the page navigation(Go to page) dialog entry in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
           SfPdfViewerPageNavigationDialogBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the page navigation(Go to page) dialog in the SfPdfViewer.    
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogTitleTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the page navigation(Go to page) dialog's Title in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the page navigation(Go to page) dialog's close button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the page navigation(Go to page) dialog's ok button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the page navigation(Go to page) dialog's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampListViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the stamp list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampListViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the stamp list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampListDeleteButtonColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the stamp list view's delete button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampListItemPressedColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed color of the stamp list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampListItemMouseHoverColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering color of the stamp list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogPlaceholderColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the custom stamp dialog's place holder in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCreateStampLabelTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the custom stamp dialog's create stamp label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the custom stamp dialog's close button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampStackLayoutBorderColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the custom stamp dialog's stack layout border in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampSelectedColorButtonHighlightColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the custom stamp dialog's selected color button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampInputLayoutBorderNormalStateColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the custom stamp dialog's input layout border's normal state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampInputLayoutBorderFocusedStateColor
            <br/>
            <br/>
        </td> 
        <td>
           Focused color of the custom stamp dialog's input layout border in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>     
    <tr>
        <td>
          SfPdfViewerCreateStampButtonBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the create stamp button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateStampButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the create stamp button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCreateStampButtonLongPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Long pressed background color of the create stamp button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampListViewSelectedItemBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the stamp list view's selected item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampViewTabViewNormalTabTextColor
            <br/>
            <br/>
        </td> 
        <td>
          Text color of the stamp view tab in its normal state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampViewTabViewSelectedTabTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the stamp view tab in its selected state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogTitleTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's title in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogTextEntryNormalColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the search dialog's entry in its normal state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogTextEntryFocusedColor
            <br/>
            <br/>
        </td> 
        <td>
           Focused color of the search dialog's entry in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCheckboxUncheckedColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the search dialog's checkbox in its unchecked state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogTextEntryTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's entry in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogErrorTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's error text in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's close button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's clear button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's search button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's previous search button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's next search button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's search button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogMatchCaseLabelTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's match case label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogStatusLabelTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the search dialog's status label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSeparatorRectangleColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the search dialog's separator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchBusyIndicatorColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the search dialog's search busy indicator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchBusyIndicatorBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the search dialog's search busy indicator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerFileOperationListViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the file operation list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerFileOperationListViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the file operation list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerFileOperationListViewItemMouseHoverColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering color of the file operation list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerFileOperationListViewItemPressedColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed color of the file operation list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerViewModeOptionsListViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the view mode options list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerViewModeOptionsListViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the view mode options list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerViewModeOptionsListViewItemMouseHoverColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering color of the view mode options list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerViewModeOptionsListViewItemPressedColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed color of the view mode options list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerTextMarkupListViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the text markup list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerTextMarkupListViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the text markup list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerTextMarkupListViewItemMouseHoverColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering color of the text markup list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerTextMarkupListViewItemPressedColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed color of the text markup list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerShapeListViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the shape list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerShapeListViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the shape list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerShapeListViewItemMouseHoverColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering color of the shape list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerShapeListViewItemPressedColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed color of the shape list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerTabViewHeaderTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the tab view header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSelectedTabViewHeaderTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the selected tab view header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerColorPaletteSeparatorColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the color palette's separator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerColorPaletteDialogBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the color palette in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerColorPaletteDialogNoColorLabelTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the color palette's no color label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerColorPaletteDialogTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the color palette in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSliderTrackStyleActiveFillColor
            <br/>
            <br/>
        </td> 
        <td>
           Active fill color of the slider track style in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSliderTrackStyleInActiveFillColor
            <br/>
            <br/>
        </td> 
        <td>
           Inactive fill color of the slider track style in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSliderThumbStyleColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the slider thumb style in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSliderThumbOverlayStyleColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the slider thumbover style in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerColorPaletteSelectedButtonStrokeColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the color palette's selected button stroke in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerToolbarBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Bcakground color of the toolbar in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerToolbarTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the toolbar in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerToolbarIconColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the toolbar's icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerToolbarIconIsPressedColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed color of the toolbar's icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerToolbarIconIsHoveredColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering color of the toolbar's icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerMoreOptionToolbarLayoutBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the more option toolbar layout in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNumberEntryViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the page number entry view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNumberEntryViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the page number entry view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNumberEntryViewFocusedStrokeColor
            <br/>
            <br/>
        </td> 
        <td>
           Focused color of the page number entry view's stroke in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNumberEntryViewUnFocusedStrokeColor
            <br/>
            <br/>
        </td> 
        <td>
           Unfocused color of the page number entry view's stroke in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampContextMenuBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the stamp context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampContextMenuTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the stamp context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampContextMenuItemIsPressedColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed color of the stamp context menu's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerStampContextMenuItemIsHoveredColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering color of the stamp context menu's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerMatchcaseLabelTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the match case label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerMatchcaseLabelCheckBoxNormalColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal color of the match case label checkboxx in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerMatchcaseToolbarBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the match case toolbar in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerMatchcaseLabelCheckboxIsCheckedColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the match case label's checkbox in it's checked state in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPageLayoutModeSelectionColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the page layout mode's selection in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPageLayoutViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the page layout view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSeparatorColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the separator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerToastBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the toast in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerToastTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the toast in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerScrollableIndicatorColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the scrollable indicator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerStickyNoteIconListViewBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the stickynote icon list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerStickyNoteIconListViewTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Text color of the stickynote icon list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerStickyNoteIconListViewHoverColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering color of the stickynote icon list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerStickyNoteIconListViewPressedColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed color of the stickynote icon list view's item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerStampViewEditableStampSelectionBorderColor
            <br/>
            <br/>
        </td> 
        <td>
           Color of the stamp view's editable stamp selection border in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkButtonBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal background color of the bookmark button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkButtonForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal foreground color of the bookmark button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerDisableBookmarkButtonBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the bookmark button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerDisableBookmarkButtonForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Foreground color of the bookmark button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkEditMenuItemBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
          Normal background color of the bookmark's edit menu item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkEditMenuItemIconColor
            <br/>
            <br/>
        </td> 
        <td>
          Normal color of the bookmark's edit menu item's icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkEditMenuItemTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal text color of the bookmark's edit menu item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkMoreIconBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal background color of the bookmark's more icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverBookmarkMoreIconBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering background color of the bookmark's more icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedBookmarkMoreIconBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed background color of the bookmark's more icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkMoreIconForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal foreground color of the bookmark's more icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverBookmarkMoreIconForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering foreground color of the bookmark's more icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedBookmarkMoreIconForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed foreground color of the bookmark's more icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkRenameCloseIconBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
          Normal background color of the bookmark's rename's close icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverBookmarkRenameCloseIconBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering background color of the bookmark's rename's close icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedBookmarkRenameCloseIconBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
          Pressed background color of the bookmark's rename's close icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalBookmarkRenameCloseIconForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal foreground color of the bookmark's rename's close icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverBookmarkRenameCloseIconForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering foreground color of the bookmark's rename's close icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedBookmarkRenameCloseIconForegroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Pressed foreground color of the bookmark's rename's close icon in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerOutlineNoOutlineNormalTextColor
            <br/>
            <br/>
        </td> 
        <td>
           Normal text color of the outline's no outline in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineMenuItemHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Hovering background color of the outline's menu item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerBookmarkTextInputFocusedStrokeColor
            <br/>
            <br/>
        </td> 
        <td>
           Focused color of the bookmark's text input stroke in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>   
     <tr>
        <td>
          SfPdfViewerControlBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
           Background color of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>   
     <tr>
        <td>
          SfPdfViewerLoadingIndicatorColor
            <br/>
            <br/>
        </td> 
        <td>
            Color of the document loading and page loading busy indicator in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>   
    <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
         SfPdfViewerCustomStampDialogApplyButtonNormalBackgroundColor 
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogApplyButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the apply button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerCustomStampDialogCloseButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the close button in the custom stamp dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>    
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogOkButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the ok button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCancelButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the cancel button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerPageNavigationDialogCloseButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the close button in the page navigation(Go to page) dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogCloseButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the close button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogClearButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the clear button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogSearchButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogPreviousSearchButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the previous search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonNormalBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonDisabledTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled text color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSearchDialogNextSearchButtonDisabledBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border color of the next search button in the search dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerOpacityDialogBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the opacity dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerThicknessDialogBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the thickness dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureListViewCreateButtonSeparatorColor 
            <br/>
            <br/>
        </td> 
        <td>
            Separator color of the signature list view's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerCreateSignatureButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the create signature button in the signature list view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignaturePadCreateButtonNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the create button in the signature pad dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignaturePadCreateButtonDisabledBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Disabled background color of the create button in the signature pad dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewUploadTabButtonHoverTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the upload button in the signature view's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewUploadTabButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the upload button in the signature view's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewUploadTabButtonHoverBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the upload button in the signature view's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewUploadTabButtonPressedBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the upload button in the signature view's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewUploadTabButtonHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the upload button in the signature view's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewUploadTabButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the upload button in the signature view's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewBackButtonNormalTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal text color of the back button in the signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewOkButtonNormalTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal text color of the ok button in the signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewBackButtonPressedTextColor          
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the back button in the signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewOkButtonPressedTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the ok button in the signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewBackButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the back button in the signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewOkButtonPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the ok button in the signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>    
    <tr>
        <td>
          SfPdfViewerSignatureListViewItemHoverBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature list view item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureListViewItemNormalBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal background color of the signature list view item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureListViewItemPressedBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature list view item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureViewTextLayoutTextColor
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the text layout in the signature view's type tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerSignatureTypeTabVariantsBackgroundColor
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the text layout in the signature view's type tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineTitleFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the title of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>  
    <tr>
        <td>
          SfPdfViewerNormalOutlineExpanderFontSize 
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the expander of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineExpanderCornerRadius
            <br/>
            <br/>
        </td> 
        <td>
            Corner radius of the expander of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineExpanderButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Normal border thickness of the expander button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverOutlineExpanderButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border thickness of the expander button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedOutlineExpanderButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border thickness of the expander button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineTitleLabelFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the outline view title label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineCloseButtonFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the close button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalOutlineCloseButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Normal border thickness of the close button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverOutlineCloseButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border thickness of the close button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedOutlineCloseButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border thickness of the close button of the outline view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogCornerRadius
            <br/>
            <br/>
        </td> 
        <td>
            Corner radius of the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogOkButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Normal border thickness of the ok button in the password, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverDialogOkButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border thickness of the ok button in the password, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedDialogOkButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border thickness of the ok button in the password, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerDisabledDialogOkButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border thickness of the ok button in the password, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogOkButtonFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the ok button in the password, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogOkButtonCornerRadius
            <br/>
            <br/>
        </td> 
        <td>
            Corner radius of the ok button in the password, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogCancelButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Normal border thickness of the cancel button in the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverDialogCancelButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border thickness of the cancel button in the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedDialogCancelButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border thickness of the cancel button in the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerDisabledDialogCancelButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Disabled border thickness of the cancel button in the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogCancelButtonFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the cancel button in the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogCancelButtonCornerRadius
            <br/>
            <br/>
        </td> 
        <td>
            Corner radius of the cancel button in the password, hyperlink, message, combobox form field list and listbox form field list dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogSaveButtonBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Normal border color of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverDialogSaveButtonBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedDialogSaveButtonBorderColor
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogSaveButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Normal border thickness of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverDialogSaveButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border thickness of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedDialogSaveButtonBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border thickness of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogSaveButtonFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the save button in the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogCloseButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Normal border thickness of the close button in the password, hyperlink, message and free text dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerHoverDialogCloseButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border thickness of the close button in the password, hyperlink, message and free text dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerPressedDialogCloseButtonIconBorderThickness
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border thickness of the close button in the password, hyperlink, message and free text dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
          SfPdfViewerNormalDialogCloseButtonFontSize
            <br/>
            <br/>
        </td> 
        <td>
            Font size of the close button in the password, hyperlink, message and free text dialogs in the SfPdfViewer.
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

## SfPopup

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
        <td rowspan="21">
            SfPopupStyles
            <br/>
            <br/>
        </td>
        <td>
           SfPopupTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfPopup without merging common theme resource and control style resource dictionaries.
            
{% highlight xaml %}
<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfPopupTheme">CommonTheme</x:String>
                <Color x:Key="SfPopupNormalHeaderBackground">Yellow</Color>
                <Color x:Key="SfPopupNormalFooterBackground">LightBlue</Color>
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
        <td> SfPopupNormalBackground <br/><br/></td>
        <td> Background color of the popup view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalStroke <br/><br/></td>
        <td> Border color of the popup view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalStrokeThickness <br/><br/></td>
        <td> Border width of the popup view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalHeaderBackground <br/><br/></td>
        <td> Background color of the header view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalHeaderTextColor  <br/><br/></td> 
        <td> Text Color of the header view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalHeaderFontSize  <br/><br/></td> 
        <td> Font size of the header view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalMessageBackground <br/><br/></td> 
        <td> Background color of message view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalMessageTextColor <br/><br/></td>
        <td> Text color of the message view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalMessageFontSize <br/><br/></td>
        <td> Font size of the message view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalFooterBackground  <br/><br/></td> 
        <td> Background color of the footer view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalFooterFontSize  <br/><br/></td> 
        <td> Font size of the footer view in Popup.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalAcceptButtonBackground <br/><br/></td> 
        <td> Background color of the accept button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalAcceptButtonTextColor <br/><br/></td> 
        <td> Text color of the accept button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalDeclineButtonBackground <br/><br/></td> 
        <td> Background color of the decline button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalDeclineButtonTextColor <br/><br/></td> 
        <td> Text color of the decline button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalCloseButtonIconStroke <br/><br/></td> 
        <td> Color of the close button icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalCloseButtonIconStrokeThickness <br/><br/></td> 
        <td> Thickness of the close button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupHoverCloseButtonIconBackground <br/><br/></td> 
        <td> Color of the close button icon when it is in hovered state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupPressedCloseButtonIconBackground <br/><br/></td> 
        <td> Color of the close button icon when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfPopupNormalOverlayBackground <br/><br/></td> 
        <td> Background color of the popup overlay.<br/><br/></td>
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

## SfPyramid Chart
  <table>
      <tr>
          <th>Theme Dictionary <br/> <br/> </th>        
          <th>Keys <br/> <br/> </th>
          <th> Description <br/> <br/> </th>
      </tr>
      <tr>
          <td rowspan="6">
              SfPyramidChartStyles  <br/> <br/>
          </td>
          <td> SfPyramidChartTheme <br/> <br/>
          </td>
          <td>    
              By merging this key in application resources, you can customize the appearance of SfPyramidChart without merging common theme resource and control style resource dictionaries.
              
{% highlight xaml %}
  <Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
               ...>
   <Application.Resources>
      <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <syncTheme:SyncfusionThemeResourceDictionary />
              <ResourceDictionary>
                  <x:String x:Key="SfPyramidChartTheme">CommonTheme</x:String>
                  <Color x:Key="SfPyramidChartBackground">LightYellow</Color>
                  <Color x:Key="SfPyramidChartTooltipBackgrounds">Gray</Color>
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
        <td>SfPyramidChartBackground<br/><br/></td>
        <td>Background color of pyramid chart<br/><br/></td>
    </tr>
    <tr>
        <td>SfPyramidChartSelectionBrush<br/><br/></td>
        <td>Color of the selected segment of the series.<br/><br/></td>
    </tr>
    <tr>
        <td>SfPyramidChartTooltipBackgrounds<br/><br/></td>
        <td>Background of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfPyramidChartTooltipTextColor<br/><br/></td>
        <td>Text color of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfPyramidChartTooltipTextFontSize<br/><br/></td>
        <td>Font size of the tooltip text<br/><br/></td>
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
        <td rowspan="13">
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
            Color of the Unchecked SfRadioButton.
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
            Color of the checked SfRadioButton.
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
            Color of the SfRadioButton text.
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
            Color of the unchecked SfRadioButton in hovered state.
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
            Color of the checked SfRadioButton in hovered state.
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
            Color of the SfRadioButton text in hovered state.
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
            Color of the unchecked SfRadioButton in pressed state.
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
            Color of the checked SfRadioButton in pressed state.
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
            Color of the SfRadioButton text in pressed state.
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
            Color of the unchecked SfRadioButton in disabled state.
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
            Color of the checked SfRadioButton in disabled state.
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
            Color of the SfRadioButton text in disabled state.
            <br/>
            <br/>
        </td>
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
            Color of axis label text in the radial gauge.
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
            Color of axis line fill in the radial gauge.
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

## SfRadialMenu

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
            SfRadialMenuStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfRadialMenuTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfRadialMenu without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfRadialMenuTheme">CommonTheme</x:String>
                <Color x:Key="SfRadialMenuCenterButtonPrimaryBackground">Blue</Color>
                <Color x:Key="SfRadialMenuBackgroundColor">Black</Color>
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
            SfRadialMenuCenterButtonPrimaryBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRadialMenu center button primary background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadialMenuItemTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRadialMenu item Text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadialMenuCenterButtonBackgroundColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRadialMenu center button background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadialMenuRimColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRadialMenu rim.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRadialMenuBackgroundColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRadialMenu background.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfRadialMenuSeparatorColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRadialMenu separator.
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
            Color of the rated portion of a SfRating.
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
            Color of the rated portion of a SfRating stroke.
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
            Color of the rated portion of a SfRating in disabled state.
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
            Color of the rated portion of a SfRating stroke in disabled state.
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
            Color of the rated portion of a SfRating in hovered state.
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
            Color of the rated portion of a SfRating stroke in hovered state.
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
            Color of the unrated portion of a SfRating.
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
            Color of the unrated portion of a SfRating stroke.
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
            Color of the unrated portion of a SfRating in disabled state.
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
            Color of the unrated portion of a SfRating stroke in disabled state.
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
            Color of the unrated portion of a SfRating in hovered state.
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
            Color of the unrated portion of a SfRating stroke in hovered state.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

## SfRotator

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
            SfRotatorStyles 
            <br/>
            <br/>
        </td>
		<td>
           SfRotatorTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfRotator without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfRotatorTheme">CommonTheme</x:String>
                <Color x:Key="SfRotatorSelectedDotColor">Grey</Color>
                <Color x:Key="SfRotatorNavigationButtonBackgroundColor">Red</Color>
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
            SfRotatorSelectedDotColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the selected SfRotator dot.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRotatorUnselectedDotColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unselected SfRotator dot.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRotatorSelectedThumbnailStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the selected Thumbnail stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRotatorUnselectedThumbnailStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the unselected Thumbnail stroke.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRotatorNavigationButtonBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRotator navigation button background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfRotatorNavigationButtonIconColor 
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfRotator navigation button icon.
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
            Color of scheduler cells when it is hovered.
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
            Color of the more appointment indicator icons. 
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
            Background Color of selected cell in scheduler.  
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
            Color of today highlight circle.  
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
            Color of appointment border when it is selected.
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
            Color of today text in scheduler.   
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
            Background color of appointment layout in day, week and work week view.  
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
            Background color of week number in scheduler.      
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
            Background color of header in scheduler.     
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
            Background color of view header.
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
            Color of view header day text.     
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
            Color of view header date text.     
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
            Color of allowed view drop-down shadow.      
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
           Background color of allowed view button.
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
            Background color of allowed view more icon button when it is selected.   
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
            Font size of today text in scheduler.      
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
            Font size of disabled date text.     
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
            Font size of appointment text in scheduler.      
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
            Font size of week number text.      
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
             Font size of header text in scheduler.                 
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
            Font size of view header day text.      
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
            Font size of view header date text.      
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
        <td rowspan="16">
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
            Background color of segment when it is disabled.
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
            Color of segment item text when it is disabled.  
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
            Background color of segment when it is selected.   
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
            Color of segmented items text when it is selected. 
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
            Color of segmented item border when it is selected.   
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
            Background color of segment when it is hovered.   
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
            Segmented controls border color when it is focused using the keyboard navigation keys.
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
            Thickness of the border stroke in the segmented control.    
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
            Corner radius of the segmented control.     
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
            Corner radius of segment in the segmented control.
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
            Font size of the segment item in the segmented control.
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
            Thickness of the border stroke in the segmented control, when it is selected.
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfRangeSelector
 <table>
     <tr>
         <th>Theme Dictionary <br/> <br/> </th>        
         <th>Keys <br/> <br/> </th>
         <th> Description <br/> <br/> </th>
     </tr>
     <tr>
         <td rowspan="205">
             SfRangeSelectorThemeStyles  <br/> <br/>
         </td>
         <td> SfRangeSelectorTheme <br/> <br/>
         </td>
         <td>    
             By merging this key in application resources, you can customize the appearance of SfRangeSelector without merging common theme resource and control style resource dictionaries.
             
{% highlight xaml %}
 <Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
              ...>
  <Application.Resources>
     <ResourceDictionary>
         <ResourceDictionary.MergedDictionaries>
             <syncTheme:SyncfusionThemeResourceDictionary />
             <ResourceDictionary>
                 <x:String x:Key="SfRangeSelectorTheme">CommonTheme</x:String>
                 <Color x:Key="SfRangeSelectorNormalActiveRegionFillBrush">Black</Color>
                 <Color x:Key="SfRangeSelectorNormalInactiveRegionFillBrush">LightGray</Color>
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
        <td>SfRangeSelectorNormalActiveRegionFillBrush<br/><br/></td>
        <td>Active region color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveRegionFillBrush<br/><br/></td>
        <td>Inactive region color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveRegionFillBrush<br/><br/></td>
        <td>Active region color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveRegionFillBrush<br/><br/></td>
        <td>Inactive region color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveRegionFillBrush<br/><br/></td>
        <td>Active region color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveRegionFillBrush<br/><br/></td>
        <td>Inactive region color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveRegionFillBrush<br/><br/></td>
        <td>Active region color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveRegionFillBrush<br/><br/></td>
        <td>Inactive region color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveRegionFillBrush<br/><br/></td>
        <td>Active region color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveRegionFillBrush<br/><br/></td>
        <td>Inactive region color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveRegionStrokeBrush<br/><br/></td>
        <td>Active region stroke color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveRegionStrokeBrush<br/><br/></td>
        <td>Inactive region stroke color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveRegionStrokeBrush<br/><br/></td>
        <td>Active region stroke color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveRegionStrokeBrush<br/><br/></td>
        <td>Inactive region stroke color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveRegionStrokeBrush<br/><br/></td>
        <td>Active region stroke color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveRegionStrokeBrush<br/><br/></td>
        <td>Inactive region stroke color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveRegionStrokeBrush<br/><br/></td>
        <td>Active region stroke color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveRegionStrokeBrush<br/><br/></td>
        <td>Inactive region stroke color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveRegionStrokeBrush<br/><br/></td>
        <td>Active region stroke color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveRegionStrokeBrush<br/><br/></td>
        <td>Inactive region stroke color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveRegionStrokeThickness<br/><br/></td>
        <td>Active region stroke thickness for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveRegionStrokeThickness<br/><br/></td>
        <td>Inactive region stroke thickness for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveRegionStrokeThickness<br/><br/></td>
        <td>Active region stroke thickness for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveRegionStrokeThickness<br/><br/></td>
        <td>Inactive region stroke thickness for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveRegionStrokeThickness<br/><br/></td>
        <td>Active region stroke thickness while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveRegionStrokeThickness<br/><br/></td>
        <td>Inactive region stroke thickness while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveRegionStrokeThickness<br/><br/></td>
        <td>Active region stroke thickness while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveRegionStrokeThickness<br/><br/></td>
        <td>Inactive region stroke thickness while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveRegionStrokeThickness<br/><br/></td>
        <td>Active region stroke thickness while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveRegionStrokeThickness<br/><br/></td>
        <td>Inactive region stroke thickness while drag the range selector<br/><br/></td>
    </tr>
     <tr>
        <td>SfRangeSelectorNormalActiveTrackFillBrush<br/><br/></td>
        <td>Active track color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveTrackFillBrush<br/><br/></td>
        <td>Inactive track color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveTrackFillBrush<br/><br/></td>
        <td>Active track color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveTrackFillBrush<br/><br/></td>
        <td>Inactive track color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveTrackFillBrush<br/><br/></td>
        <td>Active track color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveTrackFillBrush<br/><br/></td>
        <td>Inactive track color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorrPressedActiveTrackFillBrush<br/><br/></td>
        <td>Active track color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveTrackFillBrush<br/><br/></td>
        <td>Inactive track color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveTrackFillBrush<br/><br/></td>
        <td>Active track color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveTrackFillBrush<br/><br/></td>
        <td>Inactive track color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveTrackSize<br/><br/></td>
        <td>Active track size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveTrackSize<br/><br/></td>
        <td>Inactive track size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveTrackSize<br/><br/></td>
        <td>Active track size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveTrackSize<br/><br/></td>
        <td>Inactive track size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveTrackSize<br/><br/></td>
        <td>Active track size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveTrackSize<br/><br/></td>
        <td>Inactive track size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveTrackSize<br/><br/></td>
        <td>Active track size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveTrackSize<br/><br/></td>
        <td>Inactive track size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveTrackSize<br/><br/></td>
        <td>Active track size while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveTrackSize<br/><br/></td>
        <td>Inactive track size while drag the range selector<br/><br/></td>
    </tr>
     <tr>
        <td>SfRangeSelectorNormalThumbFillBrush<br/><br/></td>
        <td>Thumb color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledThumbFillBrush<br/><br/></td>
        <td>Thumb color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverThumbFillBrush<br/><br/></td>
        <td>Thumb color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedThumbFillBrush<br/><br/></td>
        <td>Thumb color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedThumbFillBrush<br/><br/></td>
        <td>Thumb color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalThumbStrokeBrush<br/><br/></td>
        <td>Thumb stroke for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledThumbStrokeBrush<br/><br/></td>
        <td>Thumb stroke for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverThumbStrokeBrush<br/><br/></td>
        <td>Thumb stroke while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedThumbStrokeBrush<br/><br/></td>
        <td>Thumb stroke while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedThumbStrokeBrush<br/><br/></td>
        <td>Thumb stroke while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalThumbOverlapStrokeBrush<br/><br/></td>
        <td>Thumb overlap stroke for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledThumbOverlapStrokeBrush<br/><br/></td>
        <td>Thumb overlap stroke for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverThumbOverlapStrokeBrush<br/><br/></td>
        <td>Thumb overlap stroke while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedThumbOverlapStrokeBrush<br/><br/></td>
        <td>Thumb overlap stroke while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedThumbOverlapStrokeBrush<br/><br/></td>
        <td>Thumb overlap stroke while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalThumbRadius<br/><br/></td>
        <td>Thumb radius for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledThumbRadius<br/><br/></td>
        <td>Thumb radius for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverThumbRadius<br/><br/></td>
        <td>Thumb radius while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedThumbRadius<br/><br/></td>
        <td>Thumb radius while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedThumbRadius<br/><br/></td>
        <td>Thumb radius while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalThumbStrokeThickness<br/><br/></td>
        <td>Thumb stroke thickness for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledThumbStrokeThickness<br/><br/></td>
        <td>Thumb stroke thickness for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverThumbStrokeThickness<br/><br/></td>
        <td>Thumb stroke thickness while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedThumbStrokeThickness<br/><br/></td>
        <td>Thumb stroke thickness while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedThumbStrokeThickness<br/><br/></td>
        <td>Thumb stroke thickness while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorThumbOverlayBrush<br/><br/></td>
        <td>Thumb overlay color for range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorThumbOverlayRadius<br/><br/></td>
        <td>Thumb overlay radius for range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveDividerFillBrush<br/><br/></td>
        <td>Active divider color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveDividerFillBrush<br/><br/></td>
        <td>Inactive divider color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveDividerFillBrush<br/><br/></td>
        <td>Active divider color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveDividerFillBrush<br/><br/></td>
        <td>Inactive divider color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveDividerFillBrush<br/><br/></td>
        <td>Active divider color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveDividerFillBrush<br/><br/></td>
        <td>Inactive divider color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveDividerFillBrush<br/><br/></td>
        <td>Active divider color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveDividerFillBrush<br/><br/></td>
        <td>Inactive divider color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveDividerFillBrush<br/><br/></td>
        <td>Active divider color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveDividerFillBrush<br/><br/></td>
        <td>Inactive divider color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveDividerStrokeBrush<br/><br/></td>
        <td>Active divider stroke for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveDividerStrokeBrush<br/><br/></td>
        <td>Inactive divider stroke for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveDividerStrokeBrush<br/><br/></td>
        <td>Active divider stroke for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveDividerStrokeBrush<br/><br/></td>
        <td>Inactive divider stroke for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveDividerStrokeBrush<br/><br/></td>
        <td>Active divider stroke while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveDividerStrokeBrush<br/><br/></td>
        <td>Inactive divider stroke while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveDividerStrokeBrush<br/><br/></td>
        <td>Active divider stroke while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveDividerStrokeBrush<br/><br/></td>
        <td>Inactive divider stroke while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveDividerStrokeBrush<br/><br/></td>
        <td>Active divider stroke while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveDividerStrokeBrush<br/><br/></td>
        <td>Inactive divider stroke while drag the range selector<br/><br/></td>
    </tr>
     <tr>
        <td>SfRangeSelectorNormalActiveDividerRadius<br/><br/></td>
        <td>Active divider radius for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveDividerRadius<br/><br/></td>
        <td>Inactive divider radius for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveDividerRadius<br/><br/></td>
        <td>Active divider radius for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveDividerRadius<br/><br/></td>
        <td>Inactive divider radius for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveDividerRadius<br/><br/></td>
        <td>Active divider radius while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveDividerRadius<br/><br/></td>
        <td>Inactive divider radius while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveDividerRadius<br/><br/></td>
        <td>Active divider radius while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveDividerRadius<br/><br/></td>
        <td>Inactive divider radius while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveDividerRadius<br/><br/></td>
        <td>Active divider radius while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveDividerRadius<br/><br/></td>
        <td>Inactive divider radius while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveDividerStrokeThickness<br/><br/></td>
        <td>Active divider stroke thickness for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveDividerStrokeThickness<br/><br/></td>
        <td>Inactive divider stroke thickness for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveDividerStrokeThickness<br/><br/></td>
        <td>Active divider stroke thickness for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveDividerStrokeThickness<br/><br/></td>
        <td>Inactive divider stroke thickness for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveDividerStrokeThickness<br/><br/></td>
        <td>Active divider stroke thickness while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveDividerStrokeThickness<br/><br/></td>
        <td>Inactive divider stroke thickness while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveDividerStrokeThickness<br/><br/></td>
        <td>Active divider stroke thickness while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveDividerStrokeThickness<br/><br/></td>
        <td>Inactive divider stroke thickness while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveDividerStrokeThickness<br/><br/></td>
        <td>Active divider stroke thickness while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveDividerStrokeThickness<br/><br/></td>
        <td>Inactive divider stroke thickness while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveMajorTickFillBrush<br/><br/></td>
        <td>Active major tick color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveMajorTickFillBrush<br/><br/></td>
        <td>Inactive major tick color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveMajorTickFillBrush<br/><br/></td>
        <td>Active major tick color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveMajorTickFillBrush<br/><br/></td>
        <td>Inactive major tick color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveMajorTickFillBrush<br/><br/></td>
        <td>Active major tick color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveMajorTickFillBrush<br/><br/></td>
        <td>Inactive major tick color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveMajorTickFillBrush<br/><br/></td>
        <td>Active major tick color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveMajorTickFillBrush<br/><br/></td>
        <td>Inactive major tick color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveMajorTickFillBrush<br/><br/></td>
        <td>Active major tick color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveMajorTickFillBrush<br/><br/></td>
        <td>Inactive major tick color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveMajorTickSize<br/><br/></td>
        <td>Active major tick size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveMajorTickSize<br/><br/></td>
        <td>Inactive major tick size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveMajorTickSize<br/><br/></td>
        <td>Active major tick size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveMajorTickSize<br/><br/></td>
        <td>Inactive major tick size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveMajorTickSize<br/><br/></td>
        <td>Active major tick size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveMajorTickSize<br/><br/></td>
        <td>Inactive major tick size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveMajorTickSize<br/><br/></td>
        <td>Active major tick size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveMajorTickSize<br/><br/></td>
        <td>Inactive major tick size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveMajorTickSize<br/><br/></td>
        <td>Active major tick size while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveMajorTickSize<br/><br/></td>
        <td>Inactive major tick size while drag the range selector<br/><br/></td>
    </tr>
     <tr>
        <td>SfRangeSelectorrNormalActiveMinorTickFillBrush<br/><br/></td>
        <td>Active minor tick color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveMinorTickFillBrush<br/><br/></td>
        <td>Inactive minor tick color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveMinorTickFillBrush<br/><br/></td>
        <td>Active minor tick color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveMinorTickFillBrush<br/><br/></td>
        <td>Inactive minor tick color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveMinorTickFillBrush<br/><br/></td>
        <td>Active minor tick color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveMinorTickFillBrush<br/><br/></td>
        <td>Inactive minor tick color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveMinorTickFillBrush<br/><br/></td>
        <td>Active minor tick color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveMinorTickFillBrush<br/><br/></td>
        <td>Inactive minor tick color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveMinorTickFillBrush<br/><br/></td>
        <td>Active minor tick color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveMinorTickFillBrush<br/><br/></td>
        <td>Inactive minor tick color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveMinorTickSize<br/><br/></td>
        <td>Active minor tick size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveMinorTickSize<br/><br/></td>
        <td>Inactive minor tick size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveMinorTickSize<br/><br/></td>
        <td>Active minor tick size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveMinorTickSize<br/><br/></td>
        <td>Inactive minor tick size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveMinorTickSize<br/><br/></td>
        <td>Active minor tick size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveMinorTickSize<br/><br/></td>
        <td>Inactive minor tick size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveMinorTickSize<br/><br/></td>
        <td>Active minor tick size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveMinorTickSize<br/><br/></td>
        <td>Inactive minor tick size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveMinorTickSize<br/><br/></td>
        <td>Active minor tick size while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveMinorTickSize<br/><br/></td>
        <td>Inactive minor tick size while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveLabelTextColor<br/><br/></td>
        <td>Active label color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveLabelTextColor<br/><br/></td>
        <td>Inactive label color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveLabelTextColor<br/><br/></td>
        <td>Active label color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveLabelTextColor<br/><br/></td>
        <td>Inactive label color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveLabelTextColor<br/><br/></td>
        <td>Active label color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveLabelTextColor<br/><br/></td>
        <td>Inactive label color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveLabelTextColor<br/><br/></td>
        <td>Active label color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveLabelTextColor<br/><br/></td>
        <td>Inactive label color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveLabelTextColor<br/><br/></td>
        <td>Active label color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveLabelTextColor<br/><br/></td>
        <td>Inactive label color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalActiveLabelFontSize<br/><br/></td>
        <td>Active label size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalInactiveLabelFontSize<br/><br/></td>
        <td>Inactive label size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledActiveLabelFontSize<br/><br/></td>
        <td>Active label size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledInactiveLabelFontSize<br/><br/></td>
        <td>Inactive label size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverActiveLabelFontSize<br/><br/></td>
        <td>Active label size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverInactiveLabelFontSize<br/><br/></td>
        <td>Inactive label size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedActiveLabelFontSize<br/><br/></td>
        <td>Active label size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedInactiveLabelFontSize<br/><br/></td>
        <td>Inactive label size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedActiveLabelFontSize<br/><br/></td>
        <td>Active label size while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedInactiveLabelFontSize<br/><br/></td>
        <td>Inactive label size while drag the range selector<br/><br/></td>
    </tr>
     <tr>
        <td>SfRangeSelectorNormalTooltipFillBrush<br/><br/></td>
        <td>Tooltip color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledTooltipFillBrush<br/><br/></td>
        <td>Tooltip color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverTooltipFillBrush<br/><br/></td>
        <td>Tooltip color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedTooltipFillBrush<br/><br/></td>
        <td>Tooltip color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedTooltipFillBrush<br/><br/></td>
        <td>Tooltip color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalTooltipStrokeBrush<br/><br/></td>
        <td>Tooltip stroke color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledTooltipStrokeBrush<br/><br/></td>
        <td>Tooltip stroke color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverTooltipStrokeBrush<br/><br/></td>
        <td>Tooltip stroke color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedTooltipStrokeBrush<br/><br/></td>
        <td>Tooltip stroke color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedTooltipStrokeBrush<br/><br/></td>
        <td>Tooltip stroke color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalTooltipStrokeThickness<br/><br/></td>
        <td>Tooltip stroke thickness for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledTooltipStrokeThickness<br/><br/></td>
        <td>Tooltip stroke thickness for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverTooltipStrokeThickness<br/><br/></td>
        <td>Tooltip stroke thickness while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedTooltipStrokeThickness<br/><br/></td>
        <td>Tooltip stroke thickness while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedTooltipStrokeThickness<br/><br/></td>
        <td>Tooltip stroke thickness while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalTooltipTextColor<br/><br/></td>
        <td>Tooltip text color for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledTooltipTextColor<br/><br/></td>
        <td>Tooltip text color for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverTooltipTextColor<br/><br/></td>
        <td>Tooltip text color while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedTooltipTextColor<br/><br/></td>
        <td>Tooltip text color while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedTooltipTextColor<br/><br/></td>
        <td>Tooltip text color while drag the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorNormalTooltipFontSize<br/><br/></td>
        <td>Tooltip font size for normal range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDisabledTooltipFontSize<br/><br/></td>
        <td>Tooltip font size for disabled range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorHoverTooltipFontSize<br/><br/></td>
        <td>Tooltip font size while hover the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorPressedTooltipFontSize<br/><br/></td>
        <td>Tooltip font size while pressed the range selector<br/><br/></td>
    </tr>
    <tr>
        <td>SfRangeSelectorDraggedTooltipFontSize<br/><br/></td>
        <td>Tooltip font size while drag the range selector<br/><br/></td>
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
            Color of the SfSignaturePad background.
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
            Color of the SfSignaturePad stroke.
            <br/>
            <br/>
        </td>
    </tr>
    </table>

## SfSlider
 <table>
        <tr>
            <th>Theme Dictionary <br/> <br/> </th>        
            <th>Keys <br/> <br/> </th>
            <th> Description <br/> <br/> </th>
        </tr>
        <tr>
            <td rowspan="175">
                SfSliderStyles  <br/> <br/>
            </td>
            <td> SfSliderTheme <br/> <br/>
            </td>
            <td>    
                By merging this key in application resources, you can customize the appearance of SfSlider without merging common theme resource and control style resource dictionaries.
                
{% highlight xaml %}
    <Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
                 ...>
     <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <syncTheme:SyncfusionThemeResourceDictionary />
                <ResourceDictionary>
                    <x:String x:Key="SfSliderTheme">CommonTheme</x:String>
                    <Color x:Key="SfSliderNormalActiveTrackFillBrush">Black</Color>
                    <Color x:Key="SfSliderNormalInactiveTrackFillBrush">LightGray</Color>
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
            <td>SfSliderNormalActiveTrackFillBrush<br/><br/></td>
            <td>Active track color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveTrackFillBrush<br/><br/></td>
            <td>Inactive track color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveTrackFillBrush<br/><br/></td>
            <td>Active track color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveTrackFillBrush<br/><br/></td>
            <td>Inactive track color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveTrackFillBrush<br/><br/></td>
            <td>Active track color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveTrackFillBrush<br/><br/></td>
            <td>Inactive track color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveTrackFillBrush<br/><br/></td>
            <td>Active track color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveTrackFillBrush<br/><br/></td>
            <td>Inactive track color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveTrackFillBrush<br/><br/></td>
            <td>Active track color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveTrackFillBrush<br/><br/></td>
            <td>Inactive track color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveTrackSize<br/><br/></td>
            <td>Active track size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveTrackSize<br/><br/></td>
            <td>Inactive track size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveTrackSize<br/><br/></td>
            <td>Active track size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveTrackSize<br/><br/></td>
            <td>Inactive track size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveTrackSizes<br/><br/></td>
            <td>Active track size while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveTrackSize<br/><br/></td>
            <td>Inactive track size while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveTrackSize<br/><br/></td>
            <td>Active track size while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveTrackSize<br/><br/></td>
            <td>Inactive track size while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveTrackSize<br/><br/></td>
            <td>Active track size while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveTrackSize<br/><br/></td>
            <td>Inactive track size while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalThumbFillBrush<br/><br/></td>
            <td>Thumb color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledThumbFillBrush<br/><br/></td>
            <td>Thumb color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverThumbFillBrush<br/><br/></td>
            <td>Thumb color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedThumbFillBrushs<br/><br/></td>
            <td>Thumb color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedThumbFillBrush<br/><br/></td>
            <td>Thumb color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalThumbStrokeBrush<br/><br/></td>
            <td>Thumb stroke for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledThumbStrokeBrush<br/><br/></td>
            <td>Thumb stroke for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverThumbStrokeBrush<br/><br/></td>
            <td>Thumb stroke while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedThumbStrokeBrush<br/><br/></td>
            <td>Thumb stroke while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedThumbStrokeBrush<br/><br/></td>
            <td>Thumb stroke while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalThumbOverlapStrokeBrush<br/><br/></td>
            <td>Thumb overlap stroke for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledThumbOverlapStrokeBrush<br/><br/></td>
            <td>Thumb overlap stroke for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverThumbOverlapStrokeBrush<br/><br/></td>
            <td>Thumb overlap stroke while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedThumbOverlapStrokeBrush<br/><br/></td>
            <td>Thumb overlap stroke while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedThumbOverlapStrokeBrush<br/><br/></td>
            <td>Thumb overlap stroke while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalThumbRadius<br/><br/></td>
            <td>Thumb radius for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledThumbRadius<br/><br/></td>
            <td>Thumb radius for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverThumbRadius<br/><br/></td>
            <td>Thumb radius while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedThumbRadius<br/><br/></td>
            <td>Thumb radius while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedThumbRadius<br/><br/></td>
            <td>Thumb radius while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalThumbStrokeThickness<br/><br/></td>
            <td>Thumb stroke thickness for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledThumbStrokeThickness<br/><br/></td>
            <td>Thumb stroke thickness for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverThumbStrokeThickness<br/><br/></td>
            <td>Thumb stroke thickness while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedThumbStrokeThickness<br/><br/></td>
            <td>Thumb stroke thickness while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedThumbStrokeThickness<br/><br/></td>
            <td>Thumb stroke thickness while drag the slider<br/><br/></td>
        </tr>    
        <tr>
            <td>SfSliderThumbOverlayBrush<br/><br/></td>
            <td>Thumb overlay color for slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderThumbOverlayRadius<br/><br/></td>
            <td>Thumb overlay radius for slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveDividerFillBrush<br/><br/></td>
            <td>Active divider color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveDividerFillBrush<br/><br/></td>
            <td>Inactive divider color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveDividerFillBrush<br/><br/></td>
            <td>Active divider color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveDividerFillBrush<br/><br/></td>
            <td>Inactive divider color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveDividerFillBrush<br/><br/></td>
            <td>Active divider color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveDividerFillBrush<br/><br/></td>
            <td>Inactive divider color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveDividerFillBrush<br/><br/></td>
            <td>Active divider color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveDividerFillBrush<br/><br/></td>
            <td>Inactive divider color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveDividerFillBrush<br/><br/></td>
            <td>Active divider color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveDividerFillBrush<br/><br/></td>
            <td>Inactive divider color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveDividerStrokeBrush<br/><br/></td>
            <td>Active divider stroke for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveDividerStrokeBrush<br/><br/></td>
            <td>Inactive divider stroke for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveDividerStrokeBrush<br/><br/></td>
            <td>Active divider stroke for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveDividerStrokeBrush<br/><br/></td>
            <td>Inactive divider stroke for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveDividerStrokeBrush<br/><br/></td>
            <td>Active divider stroke while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveDividerStrokeBrush<br/><br/></td>
            <td>Inactive divider stroke while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveDividerStrokeBrush<br/><br/></td>
            <td>Active divider stroke while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveDividerStrokeBrush<br/><br/></td>
            <td>Inactive divider stroke while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveDividerStrokeBrush<br/><br/></td>
            <td>Active divider stroke while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveDividerStrokeBrush<br/><br/></td>
            <td>Inactive divider stroke while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveDividerRadius<br/><br/></td>
            <td>Active divider radius for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveDividerRadius<br/><br/></td>
            <td>Inactive divider radius for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveDividerRadius<br/><br/></td>
            <td>Active divider radius for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveDividerRadius<br/><br/></td>
            <td>Inactive divider radius for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveDividerRadius<br/><br/></td>
            <td>Active divider radius while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveDividerRadius<br/><br/></td>
            <td>Inactive divider radius while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveDividerRadius<br/><br/></td>
            <td>Active divider radius while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveDividerRadius<br/><br/></td>
            <td>Inactive divider radius while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveDividerRadius<br/><br/></td>
            <td>Active divider radius while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveDividerRadius<br/><br/></td>
            <td>Inactive divider radius while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveDividerStrokeThickness<br/><br/></td>
            <td>Active divider stroke thickness for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveDividerStrokeThickness<br/><br/></td>
            <td>Inactive divider stroke thickness for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveDividerStrokeThickness<br/><br/></td>
            <td>Active divider stroke thickness for disabled slider<br/><br/></td>
        </tr>
       <tr>
            <td>SfSliderDisabledInactiveDividerStrokeThickness<br/><br/></td>
            <td>Inactive divider stroke thickness for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveDividerStrokeThickness<br/><br/></td>
            <td>Active divider stroke thickness while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveDividerStrokeThickness<br/><br/></td>
            <td>Inactive divider stroke thickness while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveDividerStrokeThickness<br/><br/></td>
            <td>Active divider stroke thickness while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveDividerStrokeThickness<br/><br/></td>
            <td>Inactive divider stroke thickness while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveDividerStrokeThickness<br/><br/></td>
            <td>Active divider stroke thickness while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveDividerStrokeThickness<br/><br/></td>
            <td>Inactive divider stroke thickness while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveMajorTickFillBrush<br/><br/></td>
            <td>Active major tick color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveMajorTickFillBrush<br/><br/></td>
            <td>Inactive major tick color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveMajorTickFillBrush<br/><br/></td>
            <td>Active major tick color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveMajorTickFillBrush<br/><br/></td>
            <td>Inactive major tick color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveMajorTickFillBrush<br/><br/></td>
            <td>Active major tick color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveMajorTickFillBrush<br/><br/></td>
            <td>Inactive major tick color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveMajorTickFillBrush<br/><br/></td>
            <td>Active major tick color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveMajorTickFillBrush<br/><br/></td>
            <td>Inactive major tick color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveMajorTickFillBrush<br/><br/></td>
            <td>Active major tick color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveMajorTickFillBrush<br/><br/></td>
            <td>Inactive major tick color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveMajorTickSize<br/><br/></td>
            <td>Active major tick size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveMajorTickSize<br/><br/></td>
            <td>Inactive major tick size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveMajorTickSize<br/><br/></td>
            <td>Active major tick size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveMajorTickSize<br/><br/></td>
            <td>Inactive major tick size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveMajorTickSize<br/><br/></td>
            <td>Active major tick size while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveMajorTickSize<br/><br/></td>
            <td>Inactive major tick size while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveMajorTickSize<br/><br/></td>
            <td>Active major tick size while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveMajorTickSize<br/><br/></td>
            <td>Inactive major tick size while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveMajorTickSize<br/><br/></td>
            <td>Active major tick size while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveMajorTickSize<br/><br/></td>
            <td>Inactive major tick size while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveMinorTickFillBrush<br/><br/></td>
            <td>Active minor tick color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveMinorTickFillBrush<br/><br/></td>
            <td>Inactive minor tick color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveMinorTickFillBrush<br/><br/></td>
            <td>Active minor tick color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveMinorTickFillBrush<br/><br/></td>
            <td>Inactive minor tick color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveMinorTickFillBrush<br/><br/></td>
            <td>Active minor tick color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveMinorTickFillBrush<br/><br/></td>
            <td>Inactive minor tick color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveMinorTickFillBrush<br/><br/></td>
            <td>Active minor tick color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveMinorTickFillBrush<br/><br/></td>
            <td>Inactive minor tick color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveMinorTickFillBrush<br/><br/></td>
            <td>Active minor tick color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveMinorTickFillBrush<br/><br/></td>
            <td>Inactive minor tick color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveMinorTickSize<br/><br/></td>
            <td>Active minor tick size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveMinorTickSize<br/><br/></td>
            <td>Inactive minor tick size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveMinorTickSize<br/><br/></td>
            <td>Active minor tick size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveMinorTickSize<br/><br/></td>
            <td>Inactive minor tick size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveMinorTickSize<br/><br/></td>
            <td>Active minor tick size while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveMinorTickSize<br/><br/></td>
            <td>Inactive minor tick size while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveMinorTickSize<br/><br/></td>
            <td>Active minor tick size while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveMinorTickSize<br/><br/></td>
            <td>Inactive minor tick size while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveMinorTickSize<br/><br/></td>
            <td>Active minor tick size while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveMinorTickSize<br/><br/></td>
            <td>Inactive minor tick size while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveLabelTextColor<br/><br/></td>
            <td>Active label color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveLabelTextColor<br/><br/></td>
            <td>Inactive label color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveLabelTextColor<br/><br/></td>
            <td>Active label color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveLabelTextColor<br/><br/></td>
            <td>Inactive label color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveLabelTextColor<br/><br/></td>
            <td>Active label color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveLabelTextColor<br/><br/></td>
            <td>Inactive label color while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveLabelTextColor<br/><br/></td>
            <td>Active label color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveLabelTextColor<br/><br/></td>
            <td>Inactive label color while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveLabelTextColor<br/><br/></td>
            <td>Active label color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveLabelTextColor<br/><br/></td>
            <td>Inactive label color while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalActiveLabelFontSize<br/><br/></td>
            <td>Active label size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalInactiveLabelFontSize<br/><br/></td>
            <td>Inactive label size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledActiveLabelFontSize<br/><br/></td>
            <td>Active label size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledInactiveLabelFontSize<br/><br/></td>
            <td>Inactive label size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverActiveLabelFontSize<br/><br/></td>
            <td>Active label size while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverInactiveLabelFontSize<br/><br/></td>
            <td>Inactive label size while hover the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedActiveLabelFontSize<br/><br/></td>
            <td>Active label size while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedInactiveLabelFontSize<br/><br/></td>
            <td>Inactive label size while pressed the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedActiveLabelFontSize<br/><br/></td>
            <td>Active label size while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedInactiveLabelFontSize<br/><br/></td>
            <td>Inactive label size while drag the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalTooltipFillBrush<br/><br/></td>
            <td>Tooltip color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledTooltipFillBrush<br/><br/></td>
            <td>Tooltip color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverTooltipFillBrush<br/><br/></td>
            <td>Tooltip color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedTooltipFillBrush<br/><br/></td>
            <td>Tooltip color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedTooltipFillBrush<br/><br/></td>
            <td>Tooltip color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalTooltipStrokeBrush<br/><br/></td>
            <td>Tooltip stroke color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledTooltipStrokeBrush<br/><br/></td>
            <td>Tooltip stroke color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverTooltipStrokeBrush<br/><br/></td>
            <td>Tooltip stroke color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedTooltipStrokeBrush<br/><br/></td>
            <td>Tooltip stroke color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedTooltipStrokeBrush<br/><br/></td>
            <td>Tooltip stroke color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalTooltipStrokeThickness<br/><br/></td>
            <td>Tooltip stroke thickness for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledTooltipStrokeThickness<br/><br/></td>
            <td>Tooltip stroke thickness for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverTooltipStrokeThickness<br/><br/></td>
            <td>Tooltip stroke thickness while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedTooltipStrokeThickness<br/><br/></td>
            <td>Tooltip stroke thickness while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedTooltipStrokeThickness<br/><br/></td>
            <td>Tooltip stroke thickness while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalTooltipTextColor<br/><br/></td>
            <td>Tooltip text color for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledTooltipTextColor<br/><br/></td>
            <td>Tooltip text color for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverTooltipTextColor<br/><br/></td>
            <td>Tooltip text color while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedTooltipTextColor<br/><br/></td>
            <td>Tooltip text color while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedTooltipTextColor<br/><br/></td>
            <td>Tooltip text color while dragging the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderNormalTooltipFontSize<br/><br/></td>
            <td>Tooltip font size for normal slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDisabledTooltipFontSize<br/><br/></td>
            <td>Tooltip font size for disabled slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderHoverTooltipFontSize<br/><br/></td>
            <td>Tooltip font size while hovering the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderPressedTooltipFontSize<br/><br/></td>
            <td>Tooltip font size while pressing the slider<br/><br/></td>
        </tr>
        <tr>
            <td>SfSliderDraggedTooltipFontSize<br/><br/></td>
            <td>Tooltip font size while dragging the slider<br/><br/></td>
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

## SfSunburst Chart
 <table>
     <tr>
         <th>Theme Dictionary <br/> <br/> </th>        
         <th>Keys <br/> <br/> </th>
         <th> Description <br/> <br/> </th>
     </tr>
     <tr>
         <td rowspan="7">
             SfSunburstChartStyles  <br/> <br/>
         </td>
         <td> SfSunburstChartTheme <br/> <br/>
         </td>
         <td>    
             By merging this key in application resources, you can customize the appearance of SfSunburstChart without merging common theme resource and control style resource dictionaries.
             
{% highlight xaml %}
 <Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
              ...>
  <Application.Resources>
     <ResourceDictionary>
         <ResourceDictionary.MergedDictionaries>
             <syncTheme:SyncfusionThemeResourceDictionary />
             <ResourceDictionary>
                 <x:String x:Key="SfSunburstChartTheme">CommonTheme</x:String>
                 <Color x:Key="SfSunburstChartBackground">LightGreen</Color>
                 <Color x:Key="SfSunburstChartTooltipBackground">LightYellow</Color>
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
        <td>SfSunburstChartBackground<br/><br/></td>
        <td>Background color of the sunburst chart<br/><br/></td>
    </tr>
    <tr>
        <td>SfSunburstChartTooltipBackground<br/><br/></td>
        <td>Background of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfSunburstChartTooltipTextColor<br/><br/></td>
        <td>Text color of the tooltip<br/><br/></td>
    </tr>
    <tr>
        <td>SfSunburstChartTooltipTextFontSize<br/><br/></td>
        <td>Font size of the tooltip text<br/><br/></td>
    </tr>
    <tr>
        <td>SfSunburstChartLegendTextColor<br/><br/></td>
        <td>Text color of the legend<br/><br/></td>
    </tr>
    <tr>
        <td>SfSunburstChartLegendFontSize<br/><br/></td>
        <td>Font size of the legend<br/><br/></td>
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
        <td rowspan="15">
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
            SfSwitchTrackBackground  
            <br/>
            <br/>
        </td>
        <td>
             Background color for the track of a SfSwitch control in the on state.
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
             Background color for the thumb of a SfSwitch control in the on state.
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
             Color for the icon of a SfSwitch control in the on state.
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
             Color for the track stroke of a SfSwitch control in the on state.
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
             Color for the thumb stroke of a SfSwitch control in the on state.
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
            Width of the thumb for a SfSwitch control in the on state.
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
            Height of the thumb for a SfSwitch control in the on state.
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
            Background color for the track of a SfSwitch control in the off state.
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
            Background color for the thumb of a SfSwitch control in the off state.
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
            Color for the track stroke of a SfSwitch control in the off state.
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
            Color for the thumb stroke of a SfSwitch control in the off state.
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
            Width of the thumb for a SfSwitch control in the off state.
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
            Height of the thumb for a SfSwitch control in the off state.
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
            StrokeThickness of the track for a SfSwitch control.
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
        <td rowspan="33">
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
                <Color x:Key="SfTabViewActiveMouseHoveredIndicatorBackground">DarkBlue</Color>
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
            SfTabViewDisabledTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfTabView text in disabled state.
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
            BackgroundColor of the active indicator in a SfTabView.
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
            BackgroundColor of the active indicator in a SfTabView when hovered.
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
            BackgroundColor of the active indicator in a SfTabView when disabled. 
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
            Color of the SfTabView text.
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
            BackgroundColor of the active SfTabView. 
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveNormalTextColor 
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the inactive SfTabView. 
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
            BackgroundColor of the active SfTabView in pressed state.
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
            TextColor of the inactive SfTabView.
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
            BackgroundColor of the inactive SfTabView in pressed state.
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
            TextColor of the active SfTabView. 
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
            BackgroundColor of the inactive SfTabView.
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
            TextColor of the selected SfTabView.
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
            BackgroundColor of the inactive SfTabView in disabled state.
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
            BackgroundColor of the inactive SfTabView in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewNormalFilledTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the filled SfTabView text.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveFilledNormalBackground
            <br/>
            <br/>
        </td>
        <td>
            Color of the active fill SfTabView background.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveHoveredFilledTextColor
            <br/>
            <br/>
        </td>
        <td>
            Color of the active hovered fill SfTabView text.
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
            BackgroundColor of the active SfTabView in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveHoveredFilledTextColor 
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the inactive SfTabView in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActiveHoveredFilledBackground 
            <br/>
            <br/>
        </td>
        <td>
            BackgroundColor of the inactive fill SfTabView in hover state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActivePressedFilledTextColor 
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the active filled SfTabView in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActivePressedFilledBackground
            <br/>
            <br/>
        </td>
        <td>
            BackgroundColor of the active filled SfTabView in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActivePressedFilledTextColor
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the inactive filled SfTabView in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewInActivePressedFilledBackground
            <br/>
            <br/>
        </td>
        <td>
            BackgroundColor of the inactive filled SfTabView in pressed state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveFocusedFilledTextColor
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the active filled SfTabView in focused state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewActiveFocusedFilledBackground
            <br/>
            <br/>
        </td>
        <td>
            BackgroundColor of the active filled SfTabView in focused state.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewSelectedFilledTextColor
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the selected filled SfTabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewSelectedFilledBackground
            <br/>
            <br/>
        </td>
        <td>
            BackgroundColor of the selected filled SfTabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewDisabledFilledTextColor
            <br/>
            <br/>
        </td>
        <td>
            TextColor of the disabled filled SfTabView.
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            SfTabViewDisabledFilledBackground
            <br/>
            <br/>
        </td>
        <td>
            BackgroundColor of the disabled filled SfTabView.
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfTabViewHoverBackground
            <br/>
            <br/>
        </td>
        <td>
            Hover BackgroundColor of the SfTabItem.
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
        <td rowspan="11">
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
            SfTextInputLayoutNormalContainerBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the SfTextInputLayout background in normal state.
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
            Color of the SfTextInputLayout stroke.
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
            Color of the SfTextInputLayout background text in hover state.
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
            Color of the SfTextInputLayout background.
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
            Color of the SfTextInputLayout stroke in hover state.
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
            Color of the SfTextInputLayout background in focused state.
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
            Color of the SfTextInputLayout common stroke.
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
            Color of the SfTextInputLayout background in disabled state.
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
            Color of the SfTextInputLayout stroke in disabled state.
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
            Color of the SfTextInputLayout error stroke.
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

## SfToolbar

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
        <td rowspan="35">
            SfToolbarStyles
            <br/>
            <br/>
        </td>
		<td>
           SfToolbarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfToolbar without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfToolbarTheme">CommonTheme</x:String>
                <Color x:Key="SfToolbarNormalBackground">LightBlue</Color>
                <Color x:Key="SfToolbarItemNormalIconColor">Red</Color>
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
            SfToolbarNormalBackground    
            <br/>
            <br/>
        </td>
        <td>
            Background color of toolbar.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarItemNormalBackground     
            <br/>
            <br/>
        </td>
        <td>
            Background color of toolbaritem in toolbar.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemHoverBackground      
            <br/>
            <br/>
        </td>
        <td>
            Hover background color of toolbaritem in toolbar.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemSelectionBackground       
            <br/>
            <br/>
        </td>
        <td>
            Selected background color of toolbaritem in toolbar. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemNormalTextColor        
            <br/>
            <br/>
        </td>
        <td>
            Color of text in toolbaritem.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemHoverTextColor         
            <br/>
            <br/>
        </td>
        <td>
            Color of text in toolbaritem when hovered.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemSelectionTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of text in toolbaritem when selected.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemDisabledTextColor           
            <br/>
            <br/>
        </td>
        <td>
            Color of text in toolbaritem when disabled. 
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemNormalIconColor            
            <br/>
            <br/>
        </td>
        <td>
            Color of icon in toolbaritem.
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemHoverIconColor             
            <br/>
            <br/>
        </td>
        <td>
            Color of icon in toolbaritem when hovered.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemSelectionIconColor              
            <br/>
            <br/>
        </td>
        <td>
            Color of icon in toolbaritem when selected.   
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarItemDisabledIconColor               
            <br/>
            <br/>
        </td>
        <td>
            Color of icon in toolbaritem when disabled.     
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarForwardButtonIconColor                
            <br/>
            <br/>
        </td>
        <td>
            Color of forward icon button in toolbar.      
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarForwardButtonHoverIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of forward icon button in toolbar when hovered.  
            <br/>
            <br/>
        </td>
    </tr>

	<tr>
    <td>
            SfToolbarForwardButtonSelectionIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of forward icon button in toolbar when selected.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarForwardButtonBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of forward icon button in toolbar.  
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarForwardButtonHoverBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of forward icon button in toolbar when hovered.  
            <br/>
            <br/>
        </td>
    </tr>   

    <tr>
    <td>
            SfToolbarForwardButtonSelectionBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of forward icon button in toolbar when selected.  
            <br/>
            <br/>
        </td>
    </tr>   

    <tr>
    <td>
            SfToolbarBackwardButtonIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of backward icon button in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarBackwardButtonHoverIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of backward icon button in toolbar when hovered.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarBackwardButtonSelectionIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of backward icon button in toolbar when selected.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarBackwardButtonBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of backward icon button in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarBackwardButtonHoverBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of backward icon button in toolbar when hovered.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarBackwardButtonSelectionBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of backward icon button in toolbar when selected.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarMoreButtonIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of more items button in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarMoreButtonHoverIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of more items button in toolbar when hovered.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarMoreButtonSelectionIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of more items button in toolbar when selected.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarMoreButtonBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of more items button in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarMoreButtonHoverBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of more items button in toolbar when hovered.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarMoreButtonSelectionBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of more items button in toolbar when selected.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarBackIconColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of back icon in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarSeparatorStroke                 
            <br/>
            <br/>
        </td>
        <td>
            Color of separator item in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarToolTipBackground                 
            <br/>
            <br/>
        </td>
        <td>
            Background color of tooltip in toolbar.   
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
            SfToolbarToolTipTextColor                 
            <br/>
            <br/>
        </td>
        <td>
            Color of tooltip text in toolbar.   
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
            Color of a treemap item's border when it is selected.
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
            Color of a treemap item's border when it is hovered. 
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
            Color of a treemap selected item when it is hovered.
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
            Background color of tooltip in treemap. 
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
            Background color of group item in treemap. 
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
            Size of selected item border in treemap.      
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
            Stroke width of group item in treemap.     
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
            Font size of tooltip text in treemap.    
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
            Font size of group item text.     
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
            Font size of legend text in treemap.      
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
        <td> Stroke color of the TreeViewItem when it is in focused state during keyboard navigation.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewFocusedTreeViewItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of the TreeViewItem when it is in focused state during keyboard navigation.<br/><br/></td>
    </tr>
    <tr>
        <td> SfTreeViewNormalLoadMoreIndicatorColor <br/><br/></td> 
        <td> Color of the load more indicator.<br/><br/></td>
    </tr>
</table>