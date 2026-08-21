---
layout: post
title: Properties of .NET MAUI Chat control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Chat (SfChat) control.
platform: MAUI
control: SfChat
documentation: ug
---

# API Reference for .NET MAUI Chat

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowMultilineInput" aria-label="View AllowMultilineInput property in API reference">AllowMultilineInput</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Allows the message editor to expand across multiple lines so users can compose longer messages without sending immediately</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowPinning" aria-label="View AllowPinning property in API reference">AllowPinning</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Allows users to pin messages so important conversations remain easy to find.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowSwiping" aria-label="View AllowSwiping property in API reference">AllowSwiping</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Enables swipe gestures on chat messages for supported message actions.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommand" aria-label="View AttachmentButtonCommand property in API reference">AttachmentButtonCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when the attachment button in the message input area is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommandParameter" aria-label="View AttachmentButtonCommandParameter property in API reference">AttachmentButtonCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
		<td>Supplies additional data to the command executed by the attachment button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonTemplate" aria-label="View AttachmentButtonTemplate property in API reference">AttachmentButtonTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Customizes the appearance and content of the attachment button area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CanAutoScrollToBottom" aria-label="View CanAutoScrollToBottom property in API reference">CanAutoScrollToBottom</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Automatically keeps the conversation scrolled to the latest message as new messages are added.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CardCommand" aria-label="View CardCommand property in API reference">CardCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when a card or card action within a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CurrentUser" aria-label="View CurrentUser property in API reference">CurrentUser</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.Author.html" aria-label="View Author type in API reference">Author</a></td>
		<td>Identifies the local participant in the conversation so outgoing and incoming messages can be displayed with different visual styles and alignment.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_DeliveredIcon" aria-label="View DeliveredIcon property in API reference">DeliveredIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
		<td>Defines the icon shown for messages that have reached the delivered state.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Applies the Liquid Glass visual effect to the chat surface when supported by the platform and hosting environment.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_EndSwipeTemplate" aria-label="View EndSwipeTemplate property in API reference">EndSwipeTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Defines the content displayed when a message is swiped from right to left.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_FailedIcon" aria-label="View FailedIcon property in API reference">FailedIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
		<td>Defines the icon shown for messages that could not be delivered.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ImageTappedCommand" aria-label="View ImageTappedCommand property in API reference">ImageTappedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when an image message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IncomingMessageTimestampFormat" aria-label="View IncomingMessageTimestampFormat property in API reference">IncomingMessageTimestampFormat</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
		<td>Controls how timestamps are formatted for incoming messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IsLazyLoading" aria-label="View IsLazyLoading property in API reference">IsLazyLoading</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Enables incremental loading behavior while older or additional messages are being retrieved.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
		<td>Supplies the collection of messages displayed in the conversation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSourceConverter" aria-label="View ItemsSourceConverter property in API reference">ItemsSourceConverter</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.IChatMessageConverter.html" aria-label="View IChatMessageConverter type in API reference">IChatMessageConverter</a></td>
		<td>Converts data objects to chat messages and converts chat messages back to the underlying data format when needed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreBehavior" aria-label="View LoadMoreBehavior property in API reference">LoadMoreBehavior</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.LoadMoreOption.html" aria-label="View LoadMoreOption type in API reference">LoadMoreOption</a></td>
		<td>Controls how additional messages are loaded when more conversation history becomes available.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommand" aria-label="View LoadMoreCommand property in API reference">LoadMoreCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when the chat requests additional messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommandParameter" aria-label="View LoadMoreCommandParameter property in API reference">LoadMoreCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
		<td>Supplies custom data to LoadMoreCommand when a load-more operation is triggered.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreTemplate" aria-label="View LoadMoreTemplate property in API reference">LoadMoreTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Customizes the appearance of the load-more view shown while accessing additional messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MaxSwipeOffset" aria-label="View MaxSwipeOffset property in API reference">MaxSwipeOffset</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Limits how far a message can move horizontally during a swipe interaction.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTappedCommand" aria-label="View MessageDoubleTappedCommand property in API reference">MessageDoubleTappedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when a message is double-tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressedCommand" aria-label="View MessageLongPressedCommand property in API reference">MessageLongPressedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when a message bubble is pressed and held. Verification of the exact API name and availability is recommended from the API reference.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageShape" aria-label="View MessageShape property in API reference">MessageShape</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageShape.html" aria-label="View MessageShape type in API reference">MessageShape</a></td>
		<td>Controls the visual shape of message bubbles, such as rectangular, rounded, or tear-drop styles.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageSpacing" aria-label="View MessageSpacing property in API reference">MessageSpacing</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Controls the vertical spacing between adjacent messages in the conversation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTappedCommand" aria-label="View MessageTappedCommand property in API reference">MessageTappedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTemplate" aria-label="View MessageTemplate property in API reference">MessageTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Customizes how messages and their associated content are rendered.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_OutgoingMessageTimestampFormat" aria-label="View OutgoingMessageTimestampFormat property in API reference">OutgoingMessageTimestampFormat</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
		<td>Controls how timestamps are formatted for outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedContainerHeight" aria-label="View PinnedContainerHeight property in API reference">PinnedContainerHeight</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Limits the height available for displaying pinned messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedMessages" aria-label="View PinnedMessages property in API reference">PinnedMessages</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
		<td>Provides the collection of messages displayed in the pinned messages area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedMessageTemplate" aria-label="View PinnedMessageTemplate property in API reference">PinnedMessageTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Customizes the appearance of messages displayed in the pinned messages area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ReadIcon" aria-label="View ReadIcon property in API reference">ReadIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
		<td>Defines the icon shown for messages that have been read by the recipient.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToBottomButtonTemplate" aria-label="View ScrollToBottomButtonTemplate property in API reference">ScrollToBottomButtonTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Customizes the appearance and content of the scroll-to-bottom button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SendMessageCommand" aria-label="View SendMessageCommand property in API reference">SendMessageCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when a message is sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SentIcon" aria-label="View SentIcon property in API reference">SentIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
		<td>Defines the image displayed for sent messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowAttachmentButton" aria-label="View ShowAttachmentButton property in API reference">ShowAttachmentButton</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether the attachment button is displayed in the message input area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowDeliveryState" aria-label="View ShowDeliveryState property in API reference">ShowDeliveryState</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether delivery status indicators are displayed for outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageAuthorName" aria-label="View ShowIncomingMessageAuthorName property in API reference">ShowIncomingMessageAuthorName</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether author names are displayed for incoming messages. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageAvatar" aria-label="View ShowIncomingMessageAvatar property in API reference">ShowIncomingMessageAvatar</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether avatars are displayed for incoming messages. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageTimestamp" aria-label="View ShowIncomingMessageTimestamp property in API reference">ShowIncomingMessageTimestamp</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether timestamps are displayed for incoming messages. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowKeyboardAlways" aria-label="View ShowKeyboardAlways property in API reference">ShowKeyboardAlways</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Keeps the keyboard open after a message is sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowMessageInputView" aria-label="View ShowMessageInputView property in API reference">ShowMessageInputView</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether the message input area is displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageAuthorName" aria-label="View ShowOutgoingMessageAuthorName property in API reference">ShowOutgoingMessageAuthorName</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether author names are displayed for outgoing messages. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageAvatar" aria-label="View ShowOutgoingMessageAvatar property in API reference">ShowOutgoingMessageAvatar</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether avatars are displayed for outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageTimestamp" aria-label="View ShowOutgoingMessageTimestamp property in API reference">ShowOutgoingMessageTimestamp</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether timestamps are displayed for outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowPinnedMessagesContainer" aria-label="View ShowPinnedMessagesContainer property in API reference">ShowPinnedMessagesContainer</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether the pinned messages area is displayed. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowScrollToBottomButton" aria-label="View ShowScrollToBottomButton property in API reference">ShowScrollToBottomButton</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether the scroll-to-bottom button is available in the chat view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTimeBreak" aria-label="View ShowTimeBreak property in API reference">ShowTimeBreak</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Displays date-based separators between messages from different time periods.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTypingIndicator" aria-label="View ShowTypingIndicator property in API reference">ShowTypingIndicator</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Controls whether the typing indicator is displayed in the conversation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StartSwipeTemplate" aria-label="View StartSwipeTemplate property in API reference">StartSwipeTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Defines the content displayed when a message is swiped from left to right.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StickyTimeBreak" aria-label="View StickyTimeBreak property in API reference">StickyTimeBreak</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Keeps the current time-break header visible while scrolling through messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SuggestionItemSelectedCommand" aria-label="View SuggestionItemSelectedCommand property in API reference">SuggestionItemSelectedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes an action when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Suggestions" aria-label="View Suggestions property in API reference">Suggestions</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatSuggestions.html" aria-label="View ChatSuggestions type in API reference">ChatSuggestions</a></td>
		<td>Displays a list of suggested responses above the message input area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TimeBreakTemplate" aria-label="View TimeBreakTemplate property in API reference">TimeBreakTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Customizes the appearance of time-break separators shown between messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicator" aria-label="View TypingIndicator property in API reference">TypingIndicator</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatTypingIndicator.html" aria-label="View ChatTypingIndicator type in API reference">ChatTypingIndicator</a></td>
		<td>Configures the content and appearance of the typing indicator shown in the conversation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicatorViewHeight" aria-label="View TypingIndicatorViewHeight property in API reference">TypingIndicatorViewHeight</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Controls the height of the typing indicator area. Set the value to 0 to hide the typing indicator area.</td>
	</tr>
</table>

## Methods

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ResetSwipeOffset" aria-label="View ResetSwipeOffset method in API reference">ResetSwipeOffset()</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/System.Void.html" aria-label="View void type in API reference">void</a></td>
		<td>Resets the swipe offset of the last swiped message and returns it to its default position.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToMessage_System_Object_" aria-label="View ScrollToMessage method in API reference">ScrollToMessage(object)</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/System.Void.html" aria-label="View void type in API reference">void</a></td>
		<td>Scrolls the chat to the specified message.</td>
	</tr>
</table>

## Events

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonClicked" aria-label="View AttachmentButtonClicked event in API reference">AttachmentButtonClicked</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
		<td>Triggered when the attachment button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CardTapped" aria-label="View CardTapped event in API reference">CardTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.CardTappedEventArgs.html" aria-label="View CardTappedEventArgs type in API reference">CardTappedEventArgs&gt;</a></a></td>
		<td>Triggered when a card or a card action within a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ImageTapped" aria-label="View ImageTapped event in API reference">ImageTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ImageTappedEventArgs.html" aria-label="View ImageTappedEventArgs type in API reference">ImageTappedEventArgs&gt;</a></a></td>
		<td>Triggered when an image message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTapped" aria-label="View MessageDoubleTapped event in API reference">MessageDoubleTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageDoubleTappedEventArgs.html" aria-label="View MessageDoubleTappedEventArgs type in API reference">MessageDoubleTappedEventArgs&gt;</a></a></td>
		<td>Triggered when a message is double-tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressed" aria-label="View MessageLongPressed event in API reference">MessageLongPressed</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageLongPressedEventArgs.html" aria-label="View MessageLongPressedEventArgs type in API reference">MessageLongPressedEventArgs&gt;</a></a></td>
		<td>Triggered when a message is pressed and held.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessagePinned" aria-label="View MessagePinned event in API reference">MessagePinned</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessagePinnedEventArgs.html" aria-label="View MessagePinnedEventArgs type in API reference">MessagePinnedEventArgs&gt;</a></a></td>
		<td>Triggered when a message is added to the pinned messages collection</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTapped" aria-label="View MessageTapped event in API reference">MessageTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageTappedEventArgs.html" aria-label="View MessageTappedEventArgs type in API reference">MessageTappedEventArgs&gt;</a></a></td>
		<td>Triggered when a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageUnpinned" aria-label="View MessageUnpinned event in API reference">MessageUnpinned</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageUnpinnedEventArgs.html" aria-label="View MessageUnpinnedEventArgs type in API reference">MessageUnpinnedEventArgs&gt;</a></a></td>
		<td>Triggered when a message is removed from the pinned messages collection.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Scrolled" aria-label="View Scrolled event in API reference">Scrolled</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatScrolledEventArgs.html" aria-label="View ChatScrolledEventArgs type in API reference">ChatScrolledEventArgs&gt;</a></a></td>
		<td>Triggered when the chat view is scrolled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SendMessage" aria-label="View SendMessage event in API reference">SendMessage</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SendMessageEventArgs.html" aria-label="View SendMessageEventArgs type in API reference">SendMessageEventArgs&gt;</a></a></td>
		<td>Triggered when a message is being sent, allowing the send operation to be handled before the message appears in the conversation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SuggestionItemSelected" aria-label="View SuggestionItemSelected event in API reference">SuggestionItemSelected</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SuggestionItemSelectedEventArgs.html" aria-label="View SuggestionItemSelectedEventArgs type in API reference">SuggestionItemSelectedEventArgs&gt;</a></a></td>
		<td>Triggered when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SwipeEnded" aria-label="View SwipeEnded event in API reference">SwipeEnded</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageSwipeEndedEventArgs.html" aria-label="View MessageSwipeEndedEventArgs type in API reference">MessageSwipeEndedEventArgs&gt;</a></a></td>
		<td>Triggered when a message swipe interaction completes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SwipeStarted" aria-label="View SwipeStarted event in API reference">SwipeStarted</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageSwipeStartedEventArgs.html" aria-label="View MessageSwipeStartedEventArgs type in API reference">MessageSwipeStartedEventArgs&gt;</a></a></td>
		<td>Triggered when a user begins swiping a message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Swiping" aria-label="View Swiping event in API reference">Swiping</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageSwipingEventArgs.html" aria-label="View MessageSwipingEventArgs type in API reference">MessageSwipingEventArgs&gt;</a></a></td>
		<td>Triggered continuously while a message is being swiped.</td>
	</tr>
</table>
