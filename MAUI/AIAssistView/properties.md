---
layout: post
title: Properties of .NET MAUI AI AssistView control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI AI AssistView (SfAIAssistView) control.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# .NET MAUI AI AssistView API Reference

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtonIcon">ActionButtonIcon</a></td>
		<td>ImageSource</td>
		<td>Defines the custom icon for the action button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtonPosition">ActionButtonPosition</a></td>
		<td>ActionButtonPosition</td>
		<td>Defines the position of the action button in the input view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtons">ActionButtons</a></td>
		<td>ObservableCollection&lt;ActionButton&gt;</td>
		<td>Defines the collection of action buttons shown in the editor view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtonType">ActionButtonType</a></td>
		<td>ActionButtonType</td>
		<td>Defines the type of the action button displayed in the input view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Agents">Agents</a></td>
		<td>IList&lt;AssistAgent&gt;</td>
		<td>Defines the collection of available agents.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowEditorExpansion">AllowEditorExpansion</a></td>
		<td>bool</td>
		<td>Defines whether full-screen editor mode is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowMultiplePick">AllowMultiplePick</a></td>
		<td>bool</td>
		<td>Defines whether multiple files can be picked.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowTextSelection">AllowTextSelection</a></td>
		<td>bool</td>
		<td>Defines whether text selection is enabled for response and request text.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems">AssistItems</a></td>
		<td>IList&lt;IAssistItem&gt;</td>
		<td>Defines the collection of assist items to display.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistProfile">AssistProfile</a></td>
		<td>Profile</td>
		<td>Defines the profile details associated with the control.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentItemTemplate">AttachmentItemTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to render an attachment item in the input preview.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Attachments">Attachments</a></td>
		<td>IList&lt;IAttachment&gt;</td>
		<td>Defines the attachments selected in the input view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTappedCommand">AttachmentTappedCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when an attachment is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AutoScrollBehavior">AutoScrollBehavior</a></td>
		<td>AssistViewScrollBehavior</td>
		<td>Defines the scroll behavior for the assist view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AutoSuggestionOverlay">AutoSuggestionOverlay</a></td>
		<td>AutoSuggestionOverlay</td>
		<td>Defines the inline autocomplete overlay used by the control.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CanAutoScrollToBottom">CanAutoScrollToBottom</a></td>
		<td>bool</td>
		<td>Defines whether the view automatically scrolls to show new messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTappedCommand">CardTappedCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when a card item is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextPrompt">ContextPrompt</a></td>
		<td>string</td>
		<td>Defines the application context prompt for the current conversation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationEmptyView">ConversationEmptyView</a></td>
		<td>object</td>
		<td>Defines the empty state content when no conversations exist.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationHeaderText">ConversationHeaderText</a></td>
		<td>string</td>
		<td>Defines the header text displayed in the conversation drawer.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemsSource">ConversationItemsSource</a></td>
		<td>IList&lt;AssistConversationItem&gt;</td>
		<td>Defines the conversation collection.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemTappedCommand">ConversationItemTappedCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when a conversation item is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CurrentUser">CurrentUser</a></td>
		<td>Profile</td>
		<td>Defines the profile details for the current user.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_DisclaimerText">DisclaimerText</a></td>
		<td>string</td>
		<td>Defines the footer disclaimer text.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EditorViewTemplate">EditorViewTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display the editor view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EmptyView">EmptyView</a></td>
		<td>object</td>
		<td>Defines the content shown when there are no items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EmptyViewTemplate">EmptyViewTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display the empty view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableConversationHistory">EnableConversationHistory</a></td>
		<td>bool</td>
		<td>Defines whether conversation history is shown.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
		<td>bool</td>
		<td>Defines whether the liquid glass effect is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableStopResponding">EnableStopResponding</a></td>
		<td>bool</td>
		<td>Defines whether the Stop Responding view is shown.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableTemporaryChat">EnableTemporaryChat</a></td>
		<td>bool</td>
		<td>Defines whether temporary chat mode is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableVoiceInput">EnableVoiceInput</a></td>
		<td>bool</td>
		<td>Defines whether voice input is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_FooterSuggestions">FooterSuggestions</a></td>
		<td>IList&lt;ISuggestion&gt;</td>
		<td>Defines the response suggestions shown in the footer view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_FooterSuggestionTemplate">FooterSuggestionTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used for footer suggestions.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderText">HeaderText</a></td>
		<td>string</td>
		<td>Defines the header text displayed at the top of the control.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderTemplate">HeaderTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display the header view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_InputText">InputText</a></td>
		<td>string</td>
		<td>Defines the text of the editor.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemsSource">ItemsSource</a></td>
		<td>IEnumerable</td>
		<td>Defines the source collection used to generate assist items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemsSourceConverter">ItemsSourceConverter</a></td>
		<td>IAssistItemConverter</td>
		<td>Defines the converter used to transform source items into assist items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_MaxAttachmentCount">MaxAttachmentCount</a></td>
		<td>int</td>
		<td>Defines the maximum number of attachments allowed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PreventDuplicateAttachments">PreventDuplicateAttachments</a></td>
		<td>bool</td>
		<td>Defines whether duplicate attachments are prevented.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts">PromptParts</a></td>
		<td>IList&lt;AssistPromptPart&gt;</td>
		<td>Defines the collection of prompt parts used to compose the final prompt.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestButtonIcon">RequestButtonIcon</a></td>
		<td>ImageSource</td>
		<td>Defines the image source used for the request button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestButtonTemplate">RequestButtonTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display the send button view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestCommand">RequestCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command executed when a request is initiated.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestContextMenu">RequestContextMenu</a></td>
		<td>ObservableCollection&lt;AssistContextMenuItem&gt;</td>
		<td>Defines the request-item context menu collection.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestItemTemplate">RequestItemTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display request items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseContextMenu">ResponseContextMenu</a></td>
		<td>IList&lt;AssistContextMenuItem&gt;</td>
		<td>Defines the collection of context menu items for response messages.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseItemTemplate">ResponseItemTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display response items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseSuggestionTemplate">ResponseSuggestionTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display response suggestions.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowActionButtons">ShowActionButtons</a></td>
		<td>bool</td>
		<td>Defines whether action buttons are displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowHeader">ShowHeader</a></td>
		<td>bool</td>
		<td>Defines whether the header view is displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowResponseLoader">ShowResponseLoader</a></td>
		<td>bool</td>
		<td>Defines whether the shimmer view is displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowScrollToBottomButton">ShowScrollToBottomButton</a></td>
		<td>bool</td>
		<td>Defines whether the scroll-to-bottom button is shown.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowSelectedAgent">ShowSelectedAgent</a></td>
		<td>bool</td>
		<td>Defines whether the agent selector UI is displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowTimeBreak">ShowTimeBreak</a></td>
		<td>bool</td>
		<td>Defines whether time-break separators are displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowToolbar">ShowToolbar</a></td>
		<td>bool</td>
		<td>Defines whether the toolbar is displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingCommand">StopRespondingCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command executed when Stop Responding is clicked.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingIcon">StopRespondingIcon</a></td>
		<td>ImageSource</td>
		<td>Defines the image source displayed in the stop responding view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingTemplate">StopRespondingTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display the stop responding view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelectedCommand">SuggestionItemSelectedCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command executed when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Suggestions">Suggestions</a></td>
		<td>IList&lt;ISuggestion&gt;</td>
		<td>Defines the collection of suggestions shown in the header template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionTemplate">SuggestionTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display common suggestions.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SystemPrompt">SystemPrompt</a></td>
		<td>string</td>
		<td>Defines the global system prompt applied to conversations.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TemporaryChatBannerTemplate">TemporaryChatBannerTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the custom template for the temporary chat banner.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TemporaryChatBannerText">TemporaryChatBannerText</a></td>
		<td>string</td>
		<td>Defines the text displayed in the temporary chat banner.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TimeBreakTemplate">TimeBreakTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template used to display custom content in the time break area.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarHeight">ToolbarHeight</a></td>
		<td>double</td>
		<td>Defines the height of the toolbar.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarMenuOptions">ToolbarMenuOptions</a></td>
		<td>IList&lt;ActionButton&gt;</td>
		<td>Defines the collection of menu options displayed in the toolbar menu popup.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarTitle">ToolbarTitle</a></td>
		<td>string</td>
		<td>Defines the title displayed in the header toolbar.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTapped">AttachmentTapped</a></td>
		<td>EventHandler&lt;AttachmentTappedEventArgs&gt;</td>
		<td>Raised when an attachment is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTapped">CardTapped</a></td>
		<td>EventHandler&lt;CardTappedEventArgs&gt;</td>
		<td>Raised when a card item is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ChatModeChanged">ChatModeChanged</a></td>
		<td>EventHandler&lt;ChatModeChangedEventArgs&gt;</td>
		<td>Raised after the chat mode changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ChatModeChanging">ChatModeChanging</a></td>
		<td>EventHandler&lt;ChatModeChangingEventArgs&gt;</td>
		<td>Raised before the chat mode changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextMenuOpening">ContextMenuOpening</a></td>
		<td>EventHandler&lt;ContextMenuOpeningEventArgs&gt;</td>
		<td>Raised when a context menu is about to open.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemTapped">ConversationItemTapped</a></td>
		<td>EventHandler&lt;ConversationItemTappedEventArgs&gt;</td>
		<td>Raised before a conversation item is loaded.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ImageTapped">ImageTapped</a></td>
		<td>EventHandler&lt;ImageTappedEventArgs&gt;</td>
		<td>Raised when an image is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressed">ItemLongPressed</a></td>
		<td>EventHandler&lt;ItemLongPressedEventArgs&gt;</td>
		<td>Raised when an assist item is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTapped">ItemTapped</a></td>
		<td>EventHandler&lt;ItemTappedEventArgs&gt;</td>
		<td>Raised when an assist item is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptComposing">PromptComposing</a></td>
		<td>EventHandler&lt;PromptComposingEventArgs&gt;</td>
		<td>Raised before an AI request is sent.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Request">Request</a></td>
		<td>EventHandler&lt;RequestEventArgs&gt;</td>
		<td>Raised when a request is initiated.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Scrolled">Scrolled</a></td>
		<td>EventHandler&lt;ScrolledEventArgs&gt;</td>
		<td>Raised when the view is scrolled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopResponding">StopResponding</a></td>
		<td>EventHandler&lt;EventArgs&gt;</td>
		<td>Raised when the Stop Responding view is clicked.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelected">SuggestionItemSelected</a></td>
		<td>EventHandler&lt;SuggestionItemSelectedEventArgs&gt;</td>
		<td>Raised when a suggestion item is selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToastOpening">ToastOpening</a></td>
		<td>EventHandler&lt;ToastNotificationEventArgs&gt;</td>
		<td>Raised when a toast notification is about to be displayed.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CreateAssistChat">CreateAssistChat()</a></td>
		<td>AssistViewChat</td>
		<td>Creates the AssistViewChat instance used for customizing chat view functionality.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CreateConversationListView">CreateConversationListView()</a></td>
		<td>ConversationListView</td>
		<td>Creates the ConversationListView instance used for customizing list view functionality.</td>
	</tr>
</table>
