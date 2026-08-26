---
layout: post
title: Properties of .NET MAUI AI AssistView control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI AI AssistView (SfAIAssistView) control.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# API Reference for .NET MAUI AI AssistView

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtonIcon" aria-label="View ActionButtonIcon property in API reference">ActionButtonIcon</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
<td>Displays a <code>custom</code> icon image inside the action button displayed in the <code>input view</code>.</td>

</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtonPosition" aria-label="View ActionButtonPosition property in API reference">ActionButtonPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ActionButtonPosition.html" aria-label="View ActionButtonPosition type in API reference">ActionButtonPosition</a></td>
<td>Positions the action button at either the <code>start</code> or <code>end</code> of the input view.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtons" aria-label="View ActionButtons property in API reference">ActionButtons</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ActionButton.html" aria-label="View ActionButton type in API reference">ActionButton</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">&gt;</a></td>
<td>Populates the <code>editor view</code> with the custom <code>action buttons</code> available for user interaction.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ActionButtonType" aria-label="View ActionButtonType property in API reference">ActionButtonType</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ActionButtonType.html" aria-label="View ActionButtonType type in API reference">ActionButtonType</a></td>
<td>Chooses the <code>built-in</code> action button style displayed in the input view.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Agents" aria-label="View Agents property in API reference">Agents</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAgent.html" aria-label="View AssistAgent type in API reference">AssistAgent</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Provides the list of <code>AI agents</code> the user can switch between in the conversation.</td>

</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowEditorExpansion" aria-label="View AllowEditorExpansion property in API reference">AllowEditorExpansion</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Enables the editor to expand into a <code>full-screen</code> mode for larger text input.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowMultiplePick" aria-label="View AllowMultiplePick property in API reference">AllowMultiplePick</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Allows users to select <code>multiple</code> files at once when picking attachments.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AllowTextSelection" aria-label="View AllowTextSelection property in API reference">AllowTextSelection</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Enables users to <code>select and copy</code> text from both request and response messages.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistItems" aria-label="View AssistItems property in API reference">AssistItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.IAssistItem.html" aria-label="View IAssistItem type in API reference">IAssistItem</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Displays the collection of <code>request</code> and <code>response</code> items shown in the conversation.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AssistProfile" aria-label="View AssistProfile property in API reference">AssistProfile</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Profile.html" aria-label="View Profile type in API reference">Profile</a></td>
<td>Shows the <code>assistant's profile</code> details, such as name and avatar, in the response messages.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentItemTemplate" aria-label="View AttachmentItemTemplate property in API reference">AttachmentItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the appearance of each <code>attachment chip</code> shown in the input preview area.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Attachments" aria-label="View Attachments property in API reference">Attachments</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.IAttachment.html" aria-label="View IAttachment type in API reference">IAttachment</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Holds the <code>files</code> users have selected and attached to the current request.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTappedCommand" aria-label="View AttachmentTappedCommand property in API reference">AttachmentTappedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes a <code>custom action</code> when a user taps an attachment chip.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AutoScrollBehavior" aria-label="View AutoScrollBehavior property in API reference">AutoScrollBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistViewScrollBehavior.html" aria-label="View AssistViewScrollBehavior type in API reference">AssistViewScrollBehavior</a></td>
<td>Determines whether the conversation <code>scrolls automatically</code> when new messages arrive, and under what conditions.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AutoSuggestionOverlay" aria-label="View AutoSuggestionOverlay property in API reference">AutoSuggestionOverlay</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AutoSuggestionOverlay.html" aria-label="View AutoSuggestionOverlay type in API reference">AutoSuggestionOverlay</a></td>
<td>Configures the inline <code>autocomplete overlay</code> that suggests text as the user types in the editor.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CanAutoScrollToBottom" aria-label="View CanAutoScrollToBottom property in API reference">CanAutoScrollToBottom</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Keeps the conversation scrolled to the <code>latest message</code> whenever new content is added.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTappedCommand" aria-label="View CardTappedCommand property in API reference">CardTappedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes a <code>custom action</code> when a user taps a card rendered within a message.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextPrompt" aria-label="View ContextPrompt property in API reference">ContextPrompt</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Supplies <code>application-specific</code> context to the AI for the current conversation.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationEmptyView" aria-label="View ConversationEmptyView property in API reference">ConversationEmptyView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
<td>Displays <code>custom content</code> in the conversation history drawer when no previous conversations exist.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationHeaderText" aria-label="View ConversationHeaderText property in API reference">ConversationHeaderText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Shows the <code>title text</code> at the top of the conversation history drawer.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemsSource" aria-label="View ConversationItemsSource property in API reference">ConversationItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistConversationItem.html" aria-label="View AssistConversationItem type in API reference">AssistConversationItem</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Binds the collection of <code>past conversations</code> displayed in the conversation history drawer.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemTappedCommand" aria-label="View ConversationItemTappedCommand property in API reference">ConversationItemTappedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes a <code>custom action</code> when a user taps a conversation in the history drawer.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CurrentUser" aria-label="View CurrentUser property in API reference">CurrentUser</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Profile.html" aria-label="View Profile type in API reference">Profile</a></td>
<td>Shows the <code>signed-in user's</code> profile details, such as name and avatar, alongside their request messages.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_DisclaimerText" aria-label="View DisclaimerText property in API reference">DisclaimerText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Displays a <code>footer note</code> that informs users about AI-generated content limitations.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EditorViewTemplate" aria-label="View EditorViewTemplate property in API reference">EditorViewTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>entire</code> editor view layout with a custom template.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
<td>Displays <code>custom content</code> in the message area when no assist items are present.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Uses a data template to display <code>custom content</code> when the message area is empty.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableConversationHistory" aria-label="View EnableConversationHistory property in API reference">EnableConversationHistory</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows the drawer that lists <code>previous conversations</code> for easy navigation.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Applies the <code>Liquid Glass</code> effect to the AIAssistView. Supported on <code>iOS 26 or later</code> and <code>macOS 26 or later</code> with <code>.NET 10 or later</code>; unsupported configurations use the standard background.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableStopResponding" aria-label="View EnableStopResponding property in API reference">EnableStopResponding</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows the <code>Stop Responding</code> control while the AI is generating a response.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableTemporaryChat" aria-label="View EnableTemporaryChat property in API reference">EnableTemporaryChat</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Activates <code>temporary chat</code> mode, where the conversation is not saved to history.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_EnableVoiceInput" aria-label="View EnableVoiceInput property in API reference">EnableVoiceInput</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows a <code>microphone</code> button in the input view that lets users send prompts by voice.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_FooterSuggestions" aria-label="View FooterSuggestions property in API reference">FooterSuggestions</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ISuggestion.html" aria-label="View ISuggestion type in API reference">ISuggestion</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Displays the <code>suggested response prompts</code> shown below the message area.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_FooterSuggestionTemplate" aria-label="View FooterSuggestionTemplate property in API reference">FooterSuggestionTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the appearance of each <code>suggestion</code> shown in the footer view.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderText" aria-label="View HeaderText property in API reference">HeaderText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Displays the <code>title text</code> at the top of the control.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the default <code>header layout</code> with a custom template.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_InputText" aria-label="View InputText property in API reference">InputText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Holds the <code>text</code> currently entered in the editor.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Binds a <code>raw collection</code> of data that is converted into assist items for display.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemsSourceConverter" aria-label="View ItemsSourceConverter property in API reference">ItemsSourceConverter</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.IAssistItemConverter.html" aria-label="View IAssistItemConverter type in API reference">IAssistItemConverter</a></td>
<td>Transforms bound source data into <code>IAssistItem</code> objects the control can render.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_MaxAttachmentCount" aria-label="View MaxAttachmentCount property in API reference">MaxAttachmentCount</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
<td>Limits how many <code>files</code> a user can attach to a single request.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PreventDuplicateAttachments" aria-label="View PreventDuplicateAttachments property in API reference">PreventDuplicateAttachments</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Blocks users from attaching the <code>same file</code> more than once.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts" aria-label="View PromptParts property in API reference">PromptParts</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html" aria-label="View AssistPromptPart type in API reference">AssistPromptPart</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Holds the <code>structured components</code> that compose the final prompt sent to the AI.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestButtonIcon" aria-label="View RequestButtonIcon property in API reference">RequestButtonIcon</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
<td>Displays a <code>custom icon</code> image inside the send button.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestButtonTemplate" aria-label="View RequestButtonTemplate property in API reference">RequestButtonTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the default <code>send button</code> layout with a custom template.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestCommand" aria-label="View RequestCommand property in API reference">RequestCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes a <code>custom action</code> when the user submits a request.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestContextMenu" aria-label="View RequestContextMenu property in API reference">RequestContextMenu</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistContextMenuItem.html" aria-label="View AssistContextMenuItem type in API reference">AssistContextMenuItem</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">&gt;</a></td>
<td>Populates the <code>context menu</code> shown for request messages.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_RequestItemTemplate" aria-label="View RequestItemTemplate property in API reference">RequestItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the appearance of <code>request messages</code> sent by the user.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseContextMenu" aria-label="View ResponseContextMenu property in API reference">ResponseContextMenu</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistContextMenuItem.html" aria-label="View AssistContextMenuItem type in API reference">AssistContextMenuItem</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Populates the <code>context menu</code> shown for AI response messages.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseItemTemplate" aria-label="View ResponseItemTemplate property in API reference">ResponseItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the appearance of <code>response messages</code> generated by the AI.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ResponseSuggestionTemplate" aria-label="View ResponseSuggestionTemplate property in API reference">ResponseSuggestionTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the appearance of <code>suggested prompts</code> shown after a response.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowActionButtons" aria-label="View ShowActionButtons property in API reference">ShowActionButtons</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows or hides the <code>action buttons</code> in the editor view.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowHeader" aria-label="View ShowHeader property in API reference">ShowHeader</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows or hides the <code>header area</code> at the top of the control.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowResponseLoader" aria-label="View ShowResponseLoader property in API reference">ShowResponseLoader</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Displays a <code>shimmer animation</code> while waiting for an AI response.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowScrollToBottomButton" aria-label="View ShowScrollToBottomButton property in API reference">ShowScrollToBottomButton</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows a <code>button</code> that jumps the conversation to the latest message when the view is scrolled away from the bottom.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowSelectedAgent" aria-label="View ShowSelectedAgent property in API reference">ShowSelectedAgent</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Displays the <code>agent selector</code> so users can switch between available AI agents.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowTimeBreak" aria-label="View ShowTimeBreak property in API reference">ShowTimeBreak</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Inserts <code>separators</code> between messages sent at different times.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowToolbar" aria-label="View ShowToolbar property in API reference">ShowToolbar</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Shows or hides the <code>toolbar</code> at the top of the control.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingCommand" aria-label="View StopRespondingCommand property in API reference">StopRespondingCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes a <code>custom action</code> when the user taps the Stop Responding control.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingIcon" aria-label="View StopRespondingIcon property in API reference">StopRespondingIcon</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
<td>Displays a <code>custom icon</code> image inside the Stop Responding view.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopRespondingTemplate" aria-label="View StopRespondingTemplate property in API reference">StopRespondingTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>

<td>Replaces the default <code>Stop Responding</code> view layout with a custom template.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelectedCommand" aria-label="View SuggestionItemSelectedCommand property in API reference">SuggestionItemSelectedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes a <code>custom action</code> when a user selects a suggested prompt.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Suggestions" aria-label="View Suggestions property in API reference">Suggestions</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ISuggestion.html" aria-label="View ISuggestion type in API reference">ISuggestion</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Provides the list of <code>suggested prompts</code> shown in the header area.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionTemplate" aria-label="View SuggestionTemplate property in API reference">SuggestionTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the appearance of <code>suggested prompts</code>.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SystemPrompt" aria-label="View SystemPrompt property in API reference">SystemPrompt</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Applies a <code>global instruction</code> that shapes AI behavior across all conversations.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TemporaryChatBannerTemplate" aria-label="View TemporaryChatBannerTemplate property in API reference">TemporaryChatBannerTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the default <code>temporary chat banner</code> with a custom template.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TemporaryChatBannerText" aria-label="View TemporaryChatBannerText property in API reference">TemporaryChatBannerText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Displays the <code>message</code> shown in the banner that appears during temporary chat mode.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_TimeBreakTemplate" aria-label="View TimeBreakTemplate property in API reference">TimeBreakTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Customizes the content shown in the <code>time-break separators</code> between message groups.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarHeight" aria-label="View ToolbarHeight property in API reference">ToolbarHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Sets the <code>height</code> of the toolbar in device-independent units.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarMenuOptions" aria-label="View ToolbarMenuOptions property in API reference">ToolbarMenuOptions</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ActionButton.html" aria-label="View ActionButton type in API reference">ActionButton</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
<td>Populates the <code>popup menu</code> displayed from the toolbar overflow button.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToolbarTitle" aria-label="View ToolbarTitle property in API reference">ToolbarTitle</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Shows the <code>title text</code> inside the header toolbar.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentTapped" aria-label="View AttachmentTapped event in API reference">AttachmentTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AttachmentTappedEventArgs.html" aria-label="View AttachmentTappedEventArgs type in API reference">AttachmentTappedEventArgs&gt;</a></a></td>
<td>Triggered when a user taps an <code>attachment chip</code>.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTapped" aria-label="View CardTapped event in API reference">CardTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html" aria-label="View CardTappedEventArgs type in API reference">CardTappedEventArgs&gt;</a></a></td>
<td>Triggered when a user taps a <code>card</code> inside a message.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ChatModeChanged" aria-label="View ChatModeChanged event in API reference">ChatModeChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangedEventArgs.html" aria-label="View ChatModeChangedEventArgs type in API reference">ChatModeChangedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> the chat mode changes, allowing the app to react to the new mode.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ChatModeChanging" aria-label="View ChatModeChanging event in API reference">ChatModeChanging</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ChatModeChangingEventArgs.html" aria-label="View ChatModeChangingEventArgs type in API reference">ChatModeChangingEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> the chat mode changes, allowing the change to be canceled. *Whether this event can cancel the action requires verification against the user guide.*</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextMenuOpening" aria-label="View ContextMenuOpening event in API reference">ContextMenuOpening</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ContextMenuOpeningEventArgs.html" aria-label="View ContextMenuOpeningEventArgs type in API reference">ContextMenuOpeningEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> a context menu opens, allowing customization or cancellation of the menu. *Whether cancellation is supported requires verification.*</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ConversationItemTapped" aria-label="View ConversationItemTapped event in API reference">ConversationItemTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ConversationItemTappedEventArgs.html" aria-label="View ConversationItemTappedEventArgs type in API reference">ConversationItemTappedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> a user taps a conversation item in the history drawer.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ImageTapped" aria-label="View ImageTapped event in API reference">ImageTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ImageTappedEventArgs.html" aria-label="View ImageTappedEventArgs type in API reference">ImageTappedEventArgs&gt;</a></a></td>
<td>Triggered when a user taps an <code>image</code> inside a message.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemLongPressed" aria-label="View ItemLongPressed event in API reference">ItemLongPressed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemLongPressedEventArgs.html" aria-label="View ItemLongPressedEventArgs type in API reference">ItemLongPressedEventArgs&gt;</a></a></td>
<td>Triggered when a user presses and holds an <code>assist item</code>.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs&gt;</a></a></td>
<td>Triggered when a user taps an <code>assist item</code>.</td>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptComposing" aria-label="View PromptComposing event in API reference">PromptComposing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html" aria-label="View PromptComposingEventArgs type in API reference">PromptComposingEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> a request is sent to the AI, allowing the prompt to be inspected or modified.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Request" aria-label="View Request event in API reference">Request</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestEventArgs.html" aria-label="View RequestEventArgs type in API reference">RequestEventArgs&gt;</a></a></td>
<td>Triggered when the user submits a <code>request</code>, allowing the app to generate the AI response.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Scrolled" aria-label="View Scrolled event in API reference">Scrolled</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ScrolledEventArgs.html" aria-label="View ScrolledEventArgs type in API reference">ScrolledEventArgs&gt;</a></a></td>
<td>Triggered when the <code>conversation list</code> is scrolled, reporting the new scroll position.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_StopResponding" aria-label="View StopResponding event in API reference">StopResponding</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/system.eventargs" aria-label="View EventArgs type in API reference">EventArgs&gt;</a></a></td>
<td>Triggered when the user taps the <code>Stop Responding</code> control to halt AI output.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SuggestionItemSelected" aria-label="View SuggestionItemSelected event in API reference">SuggestionItemSelected</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SuggestionItemSelectedEventArgs.html" aria-label="View SuggestionItemSelectedEventArgs type in API reference">SuggestionItemSelectedEventArgs&gt;</a></a></td>
<td>Triggered when a user selects a <code>suggested prompt</code>, either in the header or footer.</td>
</tr>
<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ToastOpening" aria-label="View ToastOpening event in API reference">ToastOpening</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ToastNotificationEventArgs.html" aria-label="View ToastNotificationEventArgs type in API reference">ToastNotificationEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> a toast notification is displayed, allowing the toast content or visibility to be customized. *Whether customization or cancellation is supported requires verification.*</td>
</tr>
</table>
