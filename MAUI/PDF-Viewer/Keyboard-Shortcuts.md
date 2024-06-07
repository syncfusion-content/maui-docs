---
layout: post
title: Keyboard shortcuts in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about performing actions using keyboard shortcuts in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Keyboard shortcuts in .NET MAUI PDF Viewer (SfPdfViewer)

The [.NET MAUI PDF viewer](https://www.syncfusion.com/maui-controls/maui-pdf-viewer) allows the users to perform certain operations such as page navigation using keyboard shortcuts in Windows and macOS platforms. The below table lists the available shortcuts and the corresponding operations.

<table>
<tr>
<th>Key combination</th>
<th>Operation</th>
</tr>
<tr>
<td>Mouse wheel scroll up</td>
<td>Vertically scrolls towards top</td>
</tr>
<tr>
<td>Mouse wheel scroll down</td>
<td>Vertically scrolls towards bottom</td>
</tr>
<tr>
<td>Mouse left button down + drag</td>
<td>Omni directional dragging (pan)</td>
</tr>
<tr>
<td><code>Shift</code> + Mouse wheel scroll up</td>
<td>Horizontally scrolls towards left</td>
</tr>
<tr>
<td><code>Shift</code> + Mouse wheel scroll down</td>
<td>Horizontally scrolls towards right</td>
</tr>
<tr>
<td><code>Ctrl</code> + Mouse wheel scroll up</td>
<td>Zoom in</td>
</tr>
<tr>
<td><code>Ctrl</code> + Mouse wheel scroll down</td>
<td>Zoom out</td>
</tr>
<tr>
<td>Down arrow</td>
<td>Step scrolling from top to bottom</td>
</tr>
<tr>
<td>Up arrow</td>
<td>Step scrolling from bottom to top</td>
</tr>
<tr>
<td>Right arrow</td>
<td>Step scrolling from left to right</td>
</tr>
<tr>
<td>Left arrow</td>
<td>Step scrolling from right to left</td>
</tr>
<tr>
<td><code>Page up</code></td>
<td>Scrolls up the current View</td>
</tr>
<tr>
<td><code>Page down</code></td>
<td>Scrolls down the current view</td>
</tr>
<tr>
<td><code>Enter</code></td>
<td>Submits the password entered in the built-in password dialog. Ignored if the password dialog is not showing</td>
</tr>
<tr>
<td><code>Home</code></td>
<td>Scrolls to the top.</td>
</tr>
<tr>
<td><code>End</code></td>
<td>Scrolls to the bottom.</td>
</tr>
<tr>
<td><code>Shift</code> + <code>Home</code></td>
<td>Scrolls to the left end</td>
</tr>
<tr>
<td><code>Shift</code> + <code>End</code></td>
<td>Scrolls to the right end</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>+</code></td>
<td>Zooms in</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>-</code></td>
<td>Zooms out</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>Page down</code></td>
<td>Goes to next page</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>Page up</code></td>
<td>Goes to previous page</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>Home</code></td>
<td>Goes to first page</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>End</code></td>
<td>Goes to last page</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>C</code></td>
<td>Copies the selected text to the clipboard</td>
</tr>
<tr>
<td><code>Delete</code></td>
<td>Removes the selected annotation from a PDF document</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>z</code></td>
<td>Undo - Reverse the most recent action performed on the annotations</td>
</tr>
<tr>
<td><code>Ctrl</code> + <code>y</code></td>
<td>Redo – Restores the last undone action</td>
</tr>
<tr>
<td><code>Esc</code></td>
<td>
   <ul>
    <li>Resets the `AnnotationMode` to `None`.</li>   
    <li>Closes the currently showing built-in dialog.</li>
    <li>Deselects the currently selected annotation.</li>
    <li>Unfocus the built-in page entry dailog.</li>
   </ul>
</td>
</tr>
</table>

### Limitations

* The `Ctrl` + mouse wheel combinations for zooming are applicable only for Windows. There is no support for this combination in macOS.
* In Windows, it is the default behavior of UI elements to receive notification of the key pressed event only when they are focused. So, while using keyboard shortcuts in Windows, please make sure that the PDF viewer control is focused by either tapping or clicking on it. 

N> Use the `Command` key instead of the `Ctrl` key in macOS.
