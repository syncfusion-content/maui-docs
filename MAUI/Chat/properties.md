---
layout: post
title: Properties of .NET MAUI Chat control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Chat (SfChat) control.
platform: MAUI
control: SfChat
documentation: ug
---

# .NET MAUI Chat API Reference

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowMultilineInput">AllowMultilineInput</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the input editor accepts multiline text. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowPinning">AllowPinning</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether pinned messages are enabled. When enabled, pinned messages appear in a dedicated container at the top of the chat interface.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AllowSwiping">AllowSwiping</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether messages can be swiped to reveal action views.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommand">AttachmentButtonCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when the attachment button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommandParameter">AttachmentButtonCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.object">object</a></td>
		<td>Gets or sets the parameter passed to <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonCommand">AttachmentButtonCommand</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonTemplate">AttachmentButtonTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template used to customize the attachment button area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CanAutoScrollToBottom">CanAutoScrollToBottom</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the control automatically scrolls to the newest message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CardCommand">CardCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when a card or card action is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CurrentUser">CurrentUser</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.Author.html">Author</a></td>
		<td>Gets or sets the current user that represents outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_DeliveredIcon">DeliveredIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a></td>
		<td>Gets or sets the image displayed for delivered messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the liquid glass effect is enabled for the chat surface.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_EndSwipeTemplate">EndSwipeTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template displayed when a message is swiped from right to left.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_FailedIcon">FailedIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a></td>
		<td>Gets or sets the image displayed for failed messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ImageTappedCommand">ImageTappedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when an image message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IncomingMessageTimestampFormat">IncomingMessageTimestampFormat</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.string">string</a></td>
		<td>Gets or sets the timestamp format applied to incoming messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IsLazyLoading">IsLazyLoading</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the control is in a lazy-loading state while loading more messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSource">ItemsSource</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable">IEnumerable</a></td>
		<td>Gets or sets the source collection used to generate chat messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ItemsSourceConverter">ItemsSourceConverter</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.IChatMessageConverter.html">IChatMessageConverter</a></td>
		<td>Gets or sets the converter used to transform data objects to chat messages and back.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreBehavior">LoadMoreBehavior</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.LoadMoreOption.html">LoadMoreOption</a></td>
		<td>Gets or sets the load-more behavior used by the chat control.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommand">LoadMoreCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when the load-more operation is triggered.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommandParameter">LoadMoreCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.object">object</a></td>
		<td>Gets or sets the parameter passed to <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreCommand">LoadMoreCommand</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_LoadMoreTemplate">LoadMoreTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template used for the load-more view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MaxSwipeOffset">MaxSwipeOffset</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double">double</a></td>
		<td>Gets or sets the maximum distance a message can move while swiping.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTappedCommand">MessageDoubleTappedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when a message is double tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressedCommand">MessageLongPressedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when a message is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageShape">MessageShape</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageShape.html">MessageShape</a></td>
		<td>Gets or sets the shape of chat messages. Available values include Rectangle, RoundedRectangle, TearDrop, and DualTearDrop.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageSpacing">MessageSpacing</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double">double</a></td>
		<td>Gets or sets the spacing between messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTappedCommand">MessageTappedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTemplate">MessageTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template used to display messages and related details.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_OutgoingMessageTimestampFormat">OutgoingMessageTimestampFormat</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.string">string</a></td>
		<td>Gets or sets the timestamp format applied to outgoing messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedContainerHeight">PinnedContainerHeight</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double">double</a></td>
		<td>Gets or sets the maximum height of the pinned messages container.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedMessages">PinnedMessages</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1">ObservableCollection&lt;object&gt;</a></td>
		<td>Gets the collection of messages currently pinned in the chat.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_PinnedMessageTemplate">PinnedMessageTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template used to customize pinned messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ReadIcon">ReadIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a></td>
		<td>Gets or sets the image displayed for read messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToBottomButtonTemplate">ScrollToBottomButtonTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template used to customize the scroll-to-bottom button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SendMessageCommand">SendMessageCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when a message is sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SentIcon">SentIcon</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a></td>
		<td>Gets or sets the image displayed for sent messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowAttachmentButton">ShowAttachmentButton</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the attachment button is visible.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowDeliveryState">ShowDeliveryState</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether delivery status is shown for outgoing messages. Delivery states include Sent, Delivered, Read, Failed, and None.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageAuthorName">ShowIncomingMessageAuthorName</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether incoming message author names are visible. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageAvatar">ShowIncomingMessageAvatar</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether incoming message avatars are visible. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowIncomingMessageTimestamp">ShowIncomingMessageTimestamp</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether incoming message timestamps are visible. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowKeyboardAlways">ShowKeyboardAlways</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the keyboard remains open after sending a message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowMessageInputView">ShowMessageInputView</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the message input view is visible.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageAuthorName">ShowOutgoingMessageAuthorName</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether outgoing message author names are visible. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageAvatar">ShowOutgoingMessageAvatar</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether outgoing message avatars are visible.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowOutgoingMessageTimestamp">ShowOutgoingMessageTimestamp</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether outgoing message timestamps are visible. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowPinnedMessagesContainer">ShowPinnedMessagesContainer</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the pinned messages container is visible. The default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowScrollToBottomButton">ShowScrollToBottomButton</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the scroll-to-bottom button is visible.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTimeBreak">ShowTimeBreak</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether date-based time breaks are shown between messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ShowTypingIndicator">ShowTypingIndicator</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the typing indicator is visible.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StartSwipeTemplate">StartSwipeTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template displayed when a message is swiped from left to right.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StickyTimeBreak">StickyTimeBreak</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
		<td>Gets or sets a value indicating whether the time break remains sticky while scrolling.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SuggestionItemSelectedCommand">SuggestionItemSelectedCommand</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Gets or sets the command executed when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Suggestions">Suggestions</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatSuggestions.html">ChatSuggestions</a></td>
		<td>Gets or sets the suggestion list displayed above the message input area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TimeBreakTemplate">TimeBreakTemplate</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate">DataTemplate</a></td>
		<td>Gets or sets the template used to customize the time break view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicator">TypingIndicator</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatTypingIndicator.html">ChatTypingIndicator</a></td>
		<td>Gets or sets the typing indicator settings used by the chat control.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_TypingIndicatorViewHeight">TypingIndicatorViewHeight</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.double">double</a></td>
		<td>Gets or sets the height of the typing indicator view. Set the value to 0 to hide the typing indicator area.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_AttachmentButtonClicked">AttachmentButtonClicked</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler">EventHandler</a></td>
		<td>Raised when the attachment button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_CardTapped">CardTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;CardTappedEventArgs&gt;</a></td>
		<td>Raised when a card or card action button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ImageTapped">ImageTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;ImageTappedEventArgs&gt;</a></td>
		<td>Raised when an image message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageDoubleTapped">MessageDoubleTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;MessageDoubleTappedEventArgs&gt;</a></td>
		<td>Raised when a message is double tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageLongPressed">MessageLongPressed</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;MessageLongPressedEventArgs&gt;</a></td>
		<td>Raised when a message is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessagePinned">MessagePinned</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;MessagePinnedEventArgs&gt;</a></td>
		<td>Raised when a message is pinned.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageTapped">MessageTapped</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;MessageTappedEventArgs&gt;</a></td>
		<td>Raised when a message is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_MessageUnpinned">MessageUnpinned</a></td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;MessageUnpinnedEventArgs&gt;</a></td>
		<td>Raised when a message is unpinned.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Scrolled">Scrolled</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.ChatScrolledEventArgs.html">ChatScrolledEventArgs</a></td>
		<td>Raised when the chat control is scrolled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SendMessage">SendMessage</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SendMessageEventArgs.html">SendMessageEventArgs</a></td>
		<td>Raised when a message is being sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SuggestionItemSelected">SuggestionItemSelected</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SuggestionItemSelectedEventArgs.html">SuggestionItemSelectedEventArgs</a></td>
		<td>Raised when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SwipeEnded">SwipeEnded</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageSwipeEndedEventArgs.html">MessageSwipeEndedEventArgs</a></td>
		<td>Raised when a swipe action ends for a message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_SwipeStarted">SwipeStarted</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageSwipeStartedEventArgs.html">MessageSwipeStartedEventArgs</a></td>
		<td>Raised when the user starts swiping a message.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_Swiping">Swiping</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.MessageSwipingEventArgs.html">MessageSwipingEventArgs</a></td>
		<td>Raised while a message is being swiped.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ResetSwipeOffset">ResetSwipeOffset()</a></td>
		<td>void</td>
		<td>Resets the swipe offset of the last swiped message and returns it to its default position.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_ScrollToMessage_System_Object_">ScrollToMessage(object)</a></td>
		<td>void</td>
		<td>Scrolls the chat to the specified message.</td>
	</tr>
</table>
