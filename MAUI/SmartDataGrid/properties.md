---
layout: post
title: Properties in .NET MAUI Smart Data Grid | Syncfusion®
description: Reference for properties, methods, and events of the Syncfusion® .NET MAUI SmartDataGrid.
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
		<td>Defines a custom template for the icon displayed in the AI assistant button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_AssistButtonTemplate" aria-label="View AssistButtonTemplate property in API reference">AssistButtonTemplate</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
		<td>Defines a custom template for the AI assistant button.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_AssistViewSettings" aria-label="View AssistViewSettings property in API reference">AssistViewSettings</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.DataGridAssistViewSettings.html" aria-label="View DataGridAssistViewSettings type in API reference">DataGridAssistViewSettings</a></td>
		<td>Configures the settings used by the integrated AI AssistView.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ShowAssistButton" aria-label="View ShowAssistButton property in API reference">ShowAssistButton</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Determines whether the AI assistant button is displayed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ShowAssistButtonIcon" aria-label="View ShowAssistButtonIcon property in API reference">ShowAssistButtonIcon</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
		<td>Determines whether the icon is displayed within the AI assistant button.</td>
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
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_CloseAssistView" aria-label="View CloseAssistView method in API reference">CloseAssistView</a>
		</td>
		<td>void</td>
		<td>Closes the AI AssistView if it is currently open.</td>
	</tr>
	<tr valign="top">
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_GetResponseAsync_System_String_" aria-label="View GetResponseAsync method in API reference">GetResponseAsync</a>
		</td>
		<td>
			<a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a>
		</td>
		<td>Sends a query to the AI assistant and returns the generated response asynchronously.</td>
	</tr>
	<tr valign="top">
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartDataGrid.SfSmartDataGrid.html#Syncfusion_Maui_SmartDataGrid_SfSmartDataGrid_ShowAssistView_Microsoft_Maui_Controls_View_" aria-label="View ShowAssistView method in API reference">ShowAssistView</a>
		</td>
		<td>void</td>
		<td>Displays the AI AssistView for interacting with the smart data grid.</td>
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
			Occurs when a request is submitted through the AI AssistView, allowing custom processing and response generation.
		</td>
	</tr>
</table>