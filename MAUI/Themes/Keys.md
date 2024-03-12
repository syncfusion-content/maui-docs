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
    <td rowspan="106">
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
                <x:String x:Key="SfChatheme">CustomTheme</x:String>
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
        <td> Background color of the incoming message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTextColor <br/><br/></td>
        <td> Text color of the incoming message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageFontFamily <br/><br/></td>
        <td> Font family of the incoming message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageFontAttributes <br/><br/></td>
        <td> Font attributes of the incoming message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageFontSize <br/><br/></td>
        <td> Font size of the incoming message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageAuthorTextColor <br/><br/></td>
        <td> Text color of the author name in an incoming message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageAuthorFontFamily <br/><br/></td>
        <td> Font family of the author name in an incoming message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageAuthorFontAttributes <br/><br/></td>
        <td> Font attributes of the author name in an incoming message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageAuthorFontSize <br/><br/></td>
        <td> Font size of the author name in an incoming message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTimestampTextColor <br/><br/></td>
        <td> Text color of the timestamp in an incoming message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageTimestampFontFamily <br/><br/></td>
        <td> Font family of the timestamp in an incoming message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatIncomingMessageTimestampFontAttributes <br/><br/></td>
        <td> Font attributes of the timestamp in an incoming message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatIncomingMessageTimestampFontSize <br/><br/></td>
        <td> Font size of the timestamp in an incoming message.<br/><br/></td>
    </tr>
    <!--Outgoing message-->
    <tr>
        <td> SfChatOutgoingMessageBackground <br/><br/></td>
        <td> Background color of the outgoing message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTextColor <br/><br/></td>
        <td> Text color of the outgoing message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingMessageFontFamily <br/><br/></td>
        <td> Font family of the outgoing message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingMessageFontAttributes <br/><br/></td>
        <td> Font attributes of the outgoing message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageFontSize <br/><br/></td>
        <td> Font size of the outgoing message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageAuthorTextColor <br/><br/></td>
        <td> Text color of the author name in an outgoing message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingMessageAuthorFontFamily <br/><br/></td>
        <td> Font family of the author name in an outgoing message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingMessageAuthorFontAttributes <br/><br/></td>
        <td> Font attributes of the author name in an outgoing message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageAuthorFontSize <br/><br/></td>
        <td> Font size of the author name in an outgoing message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTimestampTextColor <br/><br/></td>
        <td> Text color of the timestamp in an outgoing message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingMessageTimestampFontFamily <br/><br/></td>
        <td> Font family of the timestamp in an outgoing message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingMessageTimestampFontAttributes <br/><br/></td>
        <td> Font attributes of the timestamp in an outgoing message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingMessageTimestampFontSize <br/><br/></td>
        <td> Font size of the timestamp in an outgoing message.<br/><br/></td>
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
    <!--Hyper link message-->
    <tr>
        <td> SfChatIncomingHyperlinkColor <br/><br/></td>
        <td> Text color of the URL in an incoming hyper link message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHyperlinkMetaTitleTextColor <br/><br/></td>
        <td> Text color of the URL's meta title in a hyper link message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatHyperlinkDescriptionTextColor <br/><br/></td>
        <td> Text color of the URL's meta description in a hyper link message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatHyperlinkDescriptionBackground <br/><br/></td>
        <td> Background color of the URL description area in a hyper link message.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatOutgoingHyperlinkColor <br/><br/></td>
        <td> Text color of the URL in an outgoing hyper link message.<br/><br/></td>
    </tr>
     <!--Image message-->
    <tr>
        <td> SfChatIncomingImageStroke <br/><br/></td>
        <td> Border color of an image in an incoming image message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatOutgoingImageStroke <br/><br/></td>
        <td> Border color of an image in an outgoing image message.<br/><br/></td>
    </tr>
     <!--Calendar message-->
    <tr>
        <td> SfChatCalendarBackground <br/><br/></td>
        <td> Background color of calendar in a calendar message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCalendarStroke <br/><br/></td>
        <td> Border color of calendar in a calendar message.<br/><br/></td>
    </tr>
    <!--Card message-->
    <tr>
        <td> SfChatCardBackground <br/><br/></td>
        <td> Background color of card in a card message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardStroke <br/><br/></td>
        <td> Border color of card in a card message.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardTitleTextColor <br/><br/></td>
        <td> Text color of title of the card.<br/><br/></td>
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
        <td> Background color of card button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatCardButtonStroke <br/><br/></td>
        <td> Border color of card button.<br/><br/></td>
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
    <!--Message input view-->
    <tr>
        <td> SfChatMessageInputViewBackground <br/><br/></td>
        <td> Background color of message input view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorPlaceholderTextColor <br/><br/></td>
        <td> Text color of editor place holder.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorTextColor <br/><br/></td>
        <td> Text color of editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorBackground <br/><br/></td>
        <td> Background color of editor.<br/><br/></td>
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
        <td> Font family of editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorFontSize <br/><br/></td>
        <td> Font size of editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatEditorFontAttributes <br/><br/></td>
        <td> Font attributes of editor.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSendButtonColor <br/><br/></td>
        <td> Color of enabled send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSendButtonDisabledColor <br/><br/></td>
        <td> Color of disabled send button..<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatSendButtonBackground <br/><br/></td>
        <td> Background Color of enabled send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatDisabledSendButtonBackground <br/><br/></td>
        <td> Background Color of disabled send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHoveredSendButtonBackground <br/><br/></td>
        <td> Background Color of hovered send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatPressedSendButtonBackground <br/><br/></td>
        <td> Background Color of pressed send button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatAttachmentButtonColor <br/><br/></td>
        <td> Color for attachment button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHoveredAttachmentButtonColor <br/><br/></td>
        <td> Color for hovered attachment button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatAttachmentBackground <br/><br/></td>
        <td> Background Color for attachment button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatHoveredAttachmentBackground <br/><br/></td>
        <td> Background Color for hovered attachment button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatPressedAttachmentBackground <br/><br/></td>
        <td> Background Color for pressed attachment button.<br/><br/></td>
    </tr>
    <!--Time break view-->
    <tr>
        <td> SfChatTimeBreakViewTextColor <br/><br/></td>
        <td> Text Color of time break view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewBackground <br/><br/></td>
        <td> Background Color of time break view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewStroke <br/><br/></td>
        <td> Border Color of time break view.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewFontFamily <br/><br/></td>
        <td> Font family of time break view label.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewFontSize <br/><br/></td>
        <td> Font size of time break view label.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatTimeBreakViewFontAttributes <br/><br/></td>
        <td> Font attributes of time break view label.<br/><br/></td>
    </tr>
    <!--typing indicator-->
    <tr>
        <td> SfChatTypingIndicatorTextColor <br/><br/></td>
        <td> Text Color of typing indicator.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatTypingIndicatorBackground <br/><br/></td>
        <td> Background Color of typing indicator.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatTypingIndicatorFontFamily <br/><br/></td>
        <td> Font family of typing indicator.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatTypingIndicatorFontSize <br/><br/></td>
        <td> Font size of typing indicator.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatTypingIndicatorFontAttributes <br/><br/></td>
        <td> Font attributes of typing indicator.<br/><br/></td>
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
        <td> Background color of suggestion list view.<br/><br/></td>
    </tr>
    <!--Load more-->
    <tr>
        <td> SfChatLoadMoreIndicatorColor <br/><br/></td>
        <td> Color of the load more indicator.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatLoadMoreTextColor <br/><br/></td>
        <td> Text color of the load more.<br/><br/></td>
    </tr>
     <tr>
        <td> SfChatLoadMoreBackground <br/><br/></td>
        <td> Background color of the load more.<br/><br/></td>
    </tr>
    <tr>
        <td> SfChatLoadMoreStroke <br/><br/></td>
        <td> Border color of the load more.<br/><br/></td>
    </tr>
</table>
