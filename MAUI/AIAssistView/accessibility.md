---
layout: post
title: Accessibility in .NET MAUI AI AssistView control | Syncfusion®
description: Learn here all about Accessibility support in Syncfusion® .NET MAUI AI AssistView control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Accessibility in .NET MAUI AI AssistView

The .NET MAUI AI AssistView (`SfAIAssistView`) provides accessibility information for its request and response content, input controls, suggestions, and several actions. It includes semantic descriptions, interaction hints on selected elements, platform-specific keyboard handling, and `AutomationId` values for UI test automation.

The following tables list the accessibility values assigned to each supported element and describe its interaction behavior.

## Enable Accessibility

To enable screen reader support on your device:

<table>
<tr><th>Platform</th><th>Steps</th></tr>
<tr><td>Android</td><td>Settings → Accessibility → TalkBack → Turn on TalkBack</td></tr>
<tr><td>Windows</td><td>Settings → Accessibility → Narrator → Turn on Narrator</td></tr>
<tr><td>iOS</td><td>Settings → Accessibility → VoiceOver → Turn on VoiceOver</td></tr>
<tr><td>macOS (Mac Catalyst)</td><td>System Settings → Accessibility → VoiceOver → Turn on VoiceOver</td></tr>
</table>

Settings names can vary by operating-system version and device.

## Keyboard Navigation

AI AssistView implements the following editor and autocomplete interactions. These do not establish complete keyboard access to every element.

<table>
<tr><th>Platform / Context</th><th>Key / Action</th><th>Description</th></tr>
<tr><td>Windows default editor</td><td><kbd>Enter</kbd> without Shift</td><td>Requests submission. The input path submits non blank text and refocuses the editor.</td></tr>
<tr><td>Windows default editor</td><td><kbd>Shift</kbd> + <kbd>Enter</kbd></td><td>Leaves the key unhandled for native multiline processing when multiline input is enabled.</td></tr>
<tr><td>Mac Catalyst default editor</td><td><kbd>Return</kbd></td><td>Native newline handling marks the input for submission and unfocus the editor.</td></tr>
<tr><td>Android/iOS editor with multiline input disabled</td><td>Soft-keyboard Send</td><td>Configures the native Send action to initiate submission.</td></tr>
<tr><td>Autocomplete</td><td><kbd>Up Arrow</kbd> / <kbd>Down Arrow</kbd></td><td>Registers navigation between the editor and suggestion list. Movement depends on the underlying list control.</td></tr>
<tr><td>Autocomplete</td><td><kbd>Escape</kbd></td><td>Dismisses the autocomplete overlay.</td></tr>
<tr><td>Mac Catalyst autocomplete</td><td><kbd>Enter</kbd></td><td>Includes an explicit handler to commit the highlighted suggestion.</td></tr>
<tr><td>Agent autocomplete during submission</td><td><kbd>Enter</kbd> / submission</td><td>Can commit the highlighted agent instead of sending the raw agent trigger text.</td></tr>
</table>

On Mac Catalyst, the autocomplete overlay can focus the list when displayed. A Down-arrow focus-transfer handler also exists. Do not assume focus remains in the editor until Down is pressed.

## Semantic Properties in Templates

Use .NET MAUI semantic properties on application-owned template elements to provide meaningful descriptions, hints, and headings. The following example customizes the header without replacing editor submission handling.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:assist="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">
    <assist:SfAIAssistView AutomationId="SupportAssistant">
        <assist:SfAIAssistView.HeaderTemplate>
            <DataTemplate>
                <VerticalStackLayout Padding="12">
                    <Label Text="Support assistant"
                           AutomationId="SupportAssistantHeading"
                           SemanticProperties.HeadingLevel="Level1" />
                    <Label Text="Ask a question to get started"
                           SemanticProperties.Description="Ask a question to get started" />
                    <BoxView HeightRequest="1"
                             AutomationProperties.IsInAccessibleTree="False" />
                </VerticalStackLayout>
            </DataTemplate>
        </assist:SfAIAssistView.HeaderTemplate>
    </assist:SfAIAssistView>
</ContentPage>
{% endhighlight %}
{% endtabs %}

<table>
<tr><th>Property</th><th>Usage in AI AssistView Templates</th></tr>
<tr><td>SemanticProperties.Description</td><td>Provides meaningful text for application-owned images, icons, and other content.</td></tr>
<tr><td>SemanticProperties.Hint</td><td>Provides additional guidance for an application-owned action.</td></tr>
<tr><td>SemanticProperties.HeadingLevel</td><td>Marks template labels that act as headings.</td></tr>
<tr><td>AutomationProperties.IsInAccessibleTree</td><td>Set to false for decorative descendants that should be skipped.</td></tr>
<tr><td>AutomationId</td><td>Identifies an application-owned view for UI automation; it is not an accessible name.</td></tr>
</table>

## AutomationId

AI AssistView assigns fixed or content-derived identifiers to the following built-in elements. You can also set the inherited `AutomationId` on the root control and application-owned template elements.

### Input and Navigation Elements

<table>
<tr><th>Element</th><th>AutomationId Support / Value</th><th>Purpose / Usage</th></tr>
<tr><td>SfAIAssistView</td><td>Yes — application-assigned</td><td>Locate a specific control instance; the example above uses SupportAssistant.</td></tr>
<tr><td>Request editor</td><td>Yes — RequestEditor</td><td>Locate prompt text input.</td></tr>
<tr><td>Send view</td><td>Yes — SendRequest</td><td>Locate the send action.</td></tr>
<tr><td>Attachment action view</td><td>Yes — ActionButton</td><td>Locate the attachment/action chooser.</td></tr>
<tr><td>Stop-responding view</td><td>Yes — Stop responding</td><td>Locate the stop action; preserve the embedded space.</td></tr>
<tr><td>Banner/default input editor</td><td>Yes — BannerRequestEditor</td><td>Locate input in the banner/default-input path.</td></tr>
<tr><td>Banner/default input send view</td><td>Yes — BannerSendRequest</td><td>Locate that input's send action.</td></tr>
<tr><td>Scroll-to-bottom view</td><td>Yes — ScrollToBottomButton</td><td>Locate the conversation scroll action; its semantic description is also ScrollToBottomButton.</td></tr>
</table>

### Request and Response Actions

<table>
<tr><th>Element</th><th>AutomationId Support / Value</th><th>Purpose / Usage</th></tr>
<tr><td>Request edit action</td><td>Yes — Edit</td><td>Edit a request.</td></tr>
<tr><td>Request more-options action</td><td>Yes — RequestMoreOption</td><td>Open request options.</td></tr>
<tr><td>Request copy action</td><td>Yes — CopyRequest</td><td>Copy a request.</td></tr>
<tr><td>Response copy action</td><td>Yes — Copy</td><td>Copy a response.</td></tr>
<tr><td>Response retry action</td><td>Yes — Retry</td><td>Retry a response.</td></tr>
<tr><td>Response like action</td><td>Yes — Like</td><td>Provide positive feedback.</td></tr>
<tr><td>Response dislike action</td><td>Yes — DisLike</td><td>Provide negative feedback; preserve capitalization.</td></tr>
<tr><td>Response more-options action</td><td>Yes — MoreOptions</td><td>Open response options.</td></tr>
<tr><td>Response speaker action</td><td>Yes — Speaker</td><td>Locate response audio playback.</td></tr>
</table>

### Content-Derived Identifiers

<table>
<tr><th>Element</th><th>AutomationId Support / Value</th><th>Purpose / Usage</th></tr>
<tr><td>Request text view</td><td>Yes — AssistItem.Text</td><td>Locate a request by text.</td></tr>
<tr><td>Response text view</td><td>Yes — AssistItem.Text</td><td>Locate a response by text.</td></tr>
<tr><td>Image content border</td><td>Yes — AssistImageItem.Source binding</td><td>Locate the image container; do not assume a fixed native string format.</td></tr>
<tr><td>Hyperlink URL label</td><td>Yes — AssistHyperlinkItem.Url</td><td>Locate the URL label.</td></tr>
<tr><td>Response card container</td><td>Yes — Card.Title</td><td>Locate a card by title.</td></tr>
<tr><td>Response card button</td><td>Yes — CardButton.Title</td><td>Locate a card action by title.</td></tr>
<tr><td>Main/header suggestion border</td><td>Yes — AssistSuggestion.Text</td><td>Locate a main suggestion.</td></tr>
<tr><td>Footer suggestion border</td><td>Yes — AssistSuggestion.Text</td><td>Locate a footer suggestion.</td></tr>
<tr><td>Response suggestion border</td><td>Yes — AssistSuggestion.Text</td><td>Locate a response suggestion.</td></tr>
<tr><td>Main action-button template chip group</td><td>Yes — ActionButton.Text</td><td>Locate a main action group.</td></tr>
<tr><td>Attachment action-button template chip group</td><td>Yes — ActionButton.Text</td><td>Locate an attachment action group.</td></tr>
</table>

### Right-to-Left (RTL) Content

Validate layout, reading order, and keyboard behavior in your application's RTL configuration. RTL layout does not establish directional-key inversion or localization of accessibility strings. Several descriptions and hints shown above are literal English strings