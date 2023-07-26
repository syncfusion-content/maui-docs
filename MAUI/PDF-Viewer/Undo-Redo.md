---
layout: post
title: Undo and Redo actions on the annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Undo and Redo actions on the annotations using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Undo and Redo

If you performed any undesired actions when on adding, removing, moving, resizing or editing annotations, you can undo and redo the action to restore the previous state. This section will go through how to perform the undo and redo the changes made on the annotations.

For desktop platforms such as Windows and macOS, you can also use the following shortcut keys to perform the actions.

<table>
<tr>
<th>Action & Shortcut keys</th>
<th>Windows</th>
<th>macOS</th>
</tr>
<tr>
<th>Undo</th>
<td><code>Ctrl</code> + <code>z</code></td>
<td><code>Command</code> + <code>z</code></td>
</tr>
<tr>
<th>Redo</th>
<td><code>Ctrl</code> + <code>y</code></td>
<td><code>Command</code> + <code>y</code></td>
</tr>
</table>

## Undo

You can perform undo to reverse the most recent action performed on the annotations using the `UndoCommand` of the `SfPdfViewer`. The following code explains how to execute the command to perform the action.

{% tabs %}
{% highlight XAML %}

        <syncfusion:SfPdfViewer x:Name="PdfViewer"/>
        <Button x:Name="Undo" Command="{Binding Path=UndoCommand,Source={x:Reference PdfViewer}}"/>

{% endhighlight %}
{% highlight C# %}

        void PerformUndo()
        {
            PdfViewer.UndoCommand.Execute(true);
        }

{% endhighlight %}
{% endtabs %}

## Redo

You can perform redo to restore the last undone function using the `RedoCommand` of the `SfPdfViewer`. The following code explains how to execute the command to perform the action.

{% tabs %}
{% highlight XAML %}

        <syncfusion:SfPdfViewer x:Name="PdfViewer"/>
        <Button x:Name="Redo" Command="{Binding Path=RedoCommand,Source={x:Reference PdfViewer}}"/>

{% endhighlight %}
{% highlight C# %}

        void PerformRedo()
        {
            PdfViewer.RedoCommand.Execute(true);
        }

{% endhighlight %}
{% endtabs %}