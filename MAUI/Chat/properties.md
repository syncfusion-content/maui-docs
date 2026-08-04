---
layout: post
title: Properties of .NET MAUI Chat control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® MAUI Chat (SfChat) control and more.
platform: maui
control: SfChat
documentation: ug
---

# .NET MAUI Chat API Reference

## Properties

<table>
	<tr>
		<th>
			Name<br/>
		</th>
		<th>
			Type<br/>
		</th>
		<th>
			Description<br/>
		</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowMultilineInput">AllowMultilineInput</a></td>
		<td>bool</td>
		<td>Enables multiline text in the input editor.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowPinning">AllowPinning</a></td>
		<td>bool</td>
		<td>Enables pinning for chat messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowSwiping">AllowSwiping</a></td>
		<td>bool</td>
		<td>Enables swipe actions on chat messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommand">AttachmentButtonCommand</a></td>
		<td>ICommand</td>
		<td>Runs when the attachment button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommandParameter">AttachmentButtonCommandParameter</a></td>
		<td>object</td>
		<td>Provides the attachment button command parameter.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonTemplate">AttachmentButtonTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes the attachment button area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CanAutoScrollToBottom">CanAutoScrollToBottom</a></td>
		<td>bool</td>
		<td>Automatically scrolls to the latest message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CardCommand">CardCommand</a></td>
		<td>ICommand</td>
		<td>Runs when a card or card action is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CurrentUser">CurrentUser</a></td>
		<td>Author</td>
		<td>Sets the author for outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_DeliveredIcon">DeliveredIcon</a></td>
		<td>ImageSource</td>
		<td>Displays the delivered status icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
		<td>bool</td>
		<td>Enables the liquid glass effect in the chat.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_FailedIcon">FailedIcon</a></td>
		<td>ImageSource</td>
		<td>Displays the failed status icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ImageTappedCommand">ImageTappedCommand</a></td>
		<td>ICommand</td>
		<td>Runs when an image message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IncomingMessageTimestampFormat">IncomingMessageTimestampFormat</a></td>
		<td>string</td>
		<td>Formats incoming message timestamps.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IsLazyLoading">IsLazyLoading</a></td>
		<td>bool</td>
		<td>Enables lazy loading while loading more messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSource">ItemsSource</a></td>
		<td>IEnumerable</td>
		<td>Provides the message collection displayed in the chat.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSourceConverter">ItemsSourceConverter</a></td>
		<td>IChatMessageConverter</td>
		<td>Converts data objects to chat messages and back.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreBehavior">LoadMoreBehavior</a></td>
		<td>LoadMoreOption</td>
		<td>Controls how the chat loads more items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommand">LoadMoreCommand</a></td>
		<td>ICommand</td>
		<td>Runs when load more is triggered.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommandParameter">LoadMoreCommandParameter</a></td>
		<td>object</td>
		<td>Provides the load more command parameter.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreTemplate">LoadMoreTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes the load more view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MaxSwipeOffset">MaxSwipeOffset</a></td>
		<td>double</td>
		<td>Sets the maximum swipe distance in pixels.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTappedCommand">MessageDoubleTappedCommand</a></td>
		<td>ICommand</td>
		<td>Runs when a message is double tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressedCommand">MessageLongPressedCommand</a></td>
		<td>ICommand</td>
		<td>Runs when a message is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageShape">MessageShape</a></td>
		<td>MessageShape</td>
		<td>Sets the shape of message views.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageSpacing">MessageSpacing</a></td>
		<td>double</td>
		<td>Sets the spacing between messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTappedCommand">MessageTappedCommand</a></td>
		<td>ICommand</td>
		<td>Runs when a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTemplate">MessageTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes how messages and related details appear.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_OutgoingMessageTimestampFormat">OutgoingMessageTimestampFormat</a></td>
		<td>string</td>
		<td>Formats outgoing message timestamps.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedContainerHeight">PinnedContainerHeight</a></td>
		<td>double</td>
		<td>Sets the maximum height of the pinned messages container.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedMessageTemplate">PinnedMessageTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes pinned messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ReadIcon">ReadIcon</a></td>
		<td>ImageSource</td>
		<td>Displays the read status icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToBottomButtonTemplate">ScrollToBottomButtonTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes the scroll-to-bottom button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SendMessageCommand">SendMessageCommand</a></td>
		<td>ICommand</td>
		<td>Runs when a message is sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SentIcon">SentIcon</a></td>
		<td>ImageSource</td>
		<td>Displays the sent status icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowAttachmentButton">ShowAttachmentButton</a></td>
		<td>bool</td>
		<td>Shows the attachment button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowDeliveryState">ShowDeliveryState</a></td>
		<td>bool</td>
		<td>Shows delivery state for outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageAuthorName">ShowIncomingMessageAuthorName</a></td>
		<td>bool</td>
		<td>Shows incoming message author names.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageAvatar">ShowIncomingMessageAvatar</a></td>
		<td>bool</td>
		<td>Shows incoming message avatars.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageTimestamp">ShowIncomingMessageTimestamp</a></td>
		<td>bool</td>
		<td>Shows incoming message timestamps.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowKeyboardAlways">ShowKeyboardAlways</a></td>
		<td>bool</td>
		<td>Keeps the keyboard open after sending a message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowMessageInputView">ShowMessageInputView</a></td>
		<td>bool</td>
		<td>Shows the message input area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageAuthorName">ShowOutgoingMessageAuthorName</a></td>
		<td>bool</td>
		<td>Shows outgoing message author names.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageAvatar">ShowOutgoingMessageAvatar</a></td>
		<td>bool</td>
		<td>Shows outgoing message avatars.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageTimestamp">ShowOutgoingMessageTimestamp</a></td>
		<td>bool</td>
		<td>Shows outgoing message timestamps.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowPinnedMessagesContainer">ShowPinnedMessagesContainer</a></td>
		<td>bool</td>
		<td>Shows the pinned messages container.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowScrollToBottomButton">ShowScrollToBottomButton</a></td>
		<td>bool</td>
		<td>Shows the scroll-to-bottom button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTimeBreak">ShowTimeBreak</a></td>
		<td>bool</td>
		<td>Shows time break separators.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTypingIndicator">ShowTypingIndicator</a></td>
		<td>bool</td>
		<td>Shows the typing indicator.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StartSwipeTemplate">StartSwipeTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes the left-to-right swipe view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StickyTimeBreak">StickyTimeBreak</a></td>
		<td>bool</td>
		<td>Keeps time breaks sticky while scrolling.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SuggestionItemSelectedCommand">SuggestionItemSelectedCommand</a></td>
		<td>ICommand</td>
		<td>Runs when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Suggestions">Suggestions</a></td>
		<td>ChatSuggestions</td>
		<td>Displays suggestions above the message input area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TimeBreakTemplate">TimeBreakTemplate</a></td>
		<td>DataTemplate</td>
		<td>Customizes time break content.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicator">TypingIndicator</a></td>
		<td>ChatTypingIndicator</td>
		<td>Configures the typing indicator.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicatorViewHeight">TypingIndicatorViewHeight</a></td>
		<td>double</td>
		<td>Sets the typing indicator height.</td>
	</tr>
</table>

## Methods

<table>
	<tr>
		<th>
			Name<br/>
		</th>
		<th>
			Type<br/>
		</th>
		<th>
			Description<br/>
		</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ResetSwipeOffset">ResetSwipeOffset()</a></td>
		<td>void</td>
		<td>Resets the last swipe offset.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToMessage_System_Object_">ScrollToMessage(object)</a></td>
		<td>void</td>
		<td>Scrolls to the specified message.</td>
	</tr>
</table>

## Events

<table>
	<tr>
		<th>
			Name<br/>
		</th>
		<th>
			Type<br/>
		</th>
		<th>
			Description<br/>
		</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonClicked">AttachmentButtonClicked</a></td>
		<td>EventHandler</td>
		<td>Triggers when the attachment button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CardTapped">CardTapped</a></td>
		<td>EventHandler&lt;CardTappedEventArgs&gt;</td>
		<td>Triggers when a card or card action button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ImageTapped">ImageTapped</a></td>
		<td>EventHandler&lt;ImageTappedEventArgs&gt;</td>
		<td>Triggers when an image message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTapped">MessageDoubleTapped</a></td>
		<td>EventHandler&lt;MessageDoubleTappedEventArgs&gt;</td>
		<td>Triggers when a message is double tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressed">MessageLongPressed</a></td>
		<td>EventHandler&lt;MessageLongPressedEventArgs&gt;</td>
		<td>Triggers when a message is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessagePinned">MessagePinned</a></td>
		<td>EventHandler&lt;MessagePinnedEventArgs&gt;</td>
		<td>Triggers when a message is pinned.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTapped">MessageTapped</a></td>
		<td>EventHandler&lt;MessageTappedEventArgs&gt;</td>
		<td>Triggers when a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageUnpinned">MessageUnpinned</a></td>
		<td>EventHandler&lt;MessageUnpinnedEventArgs&gt;</td>
		<td>Triggers when a message is unpinned.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Scrolled">Scrolled</a></td>
		<td>EventHandler&lt;ChatScrolledEventArgs&gt;</td>
		<td>Triggers when the chat is scrolled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SendMessage">SendMessage</a></td>
		<td>EventHandler&lt;SendMessageEventArgs&gt;</td>
		<td>Triggers when a message is sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SuggestionItemSelected">SuggestionItemSelected</a></td>
		<td>EventHandler&lt;SuggestionItemSelectedEventArgs&gt;</td>
		<td>Triggers when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SwipeEnded">SwipeEnded</a></td>
		<td>EventHandler&lt;MessageSwipeEndedEventArgs&gt;</td>
		<td>Triggers when a swipe action completes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SwipeStarted">SwipeStarted</a></td>
		<td>EventHandler&lt;MessageSwipeStartedEventArgs&gt;</td>
		<td>Triggers when a message swipe starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Swiping">Swiping</a></td>
		<td>EventHandler&lt;MessageSwipingEventArgs&gt;</td>
		<td>Updates while a message is being swiped.</td>
	</tr>
</table>
