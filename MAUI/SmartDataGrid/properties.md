---
layout: post
title: Properties in .NET MAUI Smart Data Grid | Syncfusion®
description: Reference for properties, methods, and events of the Syncfusion® .NET MAUI SmartDataGrid, including assist button, assist view settings, toolbar, and AI command configuration.
platform: maui
control: SfSmartDataGrid
documentation: ug
---

# API Reference for .NET MAUI SmartDataGrid

## Properties

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_AssistButtonIconTemplate" aria-label="View AssistButtonIconTemplate property in API reference">AssistButtonIconTemplate</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Replaces only the icon shown inside the toolbar's AI assist button with a custom DataTemplate; use AssistButtonTemplate to replace the entire button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_AssistButtonTemplate" aria-label="View AssistButtonTemplate property in API reference">AssistButtonTemplate</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Replaces the entire AI assist button in the toolbar with a custom DataTemplate layout, overriding the default button visuals and tap behavior.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_AssistViewSettings" aria-label="View AssistViewSettings property in API reference">AssistViewSettings</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.DataGridAssistViewSettings.html" aria-label="View DataGridAssistViewSettings type in API reference">DataGridAssistViewSettings</a></td>
		<td>Holds the DataGridAssistViewSettings used to configure the integrated AI AssistView, including suggested prompts, the initial prompt, smart-action enablement, styling, and AssistView life-cycle events.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ShowAssistButtonIcon" aria-label="View ShowAssistButtonIcon property in API reference">ShowAssistButtonIcon</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Shows or hides the icon inside the AI assist button. When set to false, the button still appears but with no icon; the default value is true.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ToolbarHeight" aria-label="View ToolbarHeight property in API reference">ToolbarHeight</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Specifies the height of the toolbar displayed above the data grid.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ToolbarTemplate" aria-label="View ToolbarTemplate property in API reference">ToolbarTemplate</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Defines a custom template for the toolbar shown above the smart data grid.</td>
	</tr>
</table>

## Methods

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_CloseAssistView" aria-label="View CloseAssistView method in API reference">CloseAssistView()</a>
		</td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
		<td>Closes the AI AssistView popup if it is currently open on the Smart DataGrid.</td>
	</tr>
	<tr valign="top">
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_GetResponseAsync_System_String_" aria-label="View GetResponseAsync method in API reference">GetResponseAsync(String)</a>
		</td>
		<td>
			<a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a>
		</td>
		<td>Executes the given natural-language command programmatically, applying sorting, grouping, filtering, or highlighting to the grid without opening the AssistView UI. Returns true when the command runs successfully and false when the command is invalid or unsupported.</td>
	</tr>
	<tr valign="top">
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ShowAssistView_Microsoft_Maui_Controls_View_" aria-label="View ShowAssistView method in API reference">ShowAssistView(View)</a>
		</td>
		<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
		<td>Opens the AssistView popup anchored to the default assist button. Pass a View to anchor the popup against a different UI element, such as a custom button.</td>
	</tr>
</table>

## Events

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_AssistViewRequest" aria-label="View AssistViewRequest event in API reference">AssistViewRequest</a>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.AssistViewRequestEventArgs.html" aria-label="View AssistViewRequestEventArgs type in API reference">EventHandler&lt;AssistViewRequestEventArgs&gt;</a>
		</td>
		<td>
			Triggered when a user submits a natural-language command through the AssistView or when code invokes GetResponseAsync. The event args expose the Prompt text and support cancellation, so handlers can inspect or block a command before it modifies the grid.
		</td>
	</tr>
</table>