---
layout: post
title: Events in .NET MAUI Grid Splitter | Syncfusion®
description: Learn about the events available in the Syncfusion® .NET MAUI Grid Splitter control to monitor resizing and pane state changes.
platform: MAUI
control: SfGridSplitter
documentation: UG
---

# Events in .NET MAUI Grid Splitter

The [.NET MAUI Grid Splitter]() control provides several events that allow you to monitor and respond to pane resizing, collapsing, and expanding operations.

These events can be used to validate user actions, synchronize UI state, update business logic, and customize user interactions.

## ResizeStarted

The `ResizeStarted` event occurs when a user begins dragging a separator to resize adjacent panes.

This event is cancelable and allows you to prevent the resize operation before it starts.

### Event arguments

The `GridSplitterResizeStartedEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
| `Cancel` | Gets or sets a value indicating whether the resize operation should be canceled. |
| `Indexes` | Gets the zero-based indexes of the panes involved in the resize operation. The first value represents the leading pane, and the second value represents the trailing pane. |
| `Panes` | Gets the affected panes involved in the resize operation. The first item is the leading pane, and the second item is the trailing pane. |

### Handle ResizeStarted event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter ResizeStarted="OnResizeStarted">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnResizeStarted(object sender, GridSplitterResizeStartedEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

---

## Resizing

The `Resizing` event occurs continuously while a separator is being dragged.

This event can be used to display live resize information or update related UI elements.

### Event arguments

The `GridSplitterResizingEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
| `Indexes` | Gets the zero-based indexes of the panes involved in the resize operation. The first value represents the leading pane, and the second value represents the trailing pane. |
|`Panes` | Gets the affected panes involved in the resize operation. The first item is the leading pane, and the second item is the trailing pane. |

### Handle Resizing event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Resizing="OnResizing">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnResizing(object sender, GridSplitterResizingEventArgs e)
{
    Debug.WriteLine($"Resizing pane at index {e.Indexes}");
}

{% endhighlight %}
{% endtabs %}

---

## ResizeStopped

The `ResizeStopped` event occurs when a user finishes a resize operation and releases the separator.

This event provides the indexes and references of the affected panes after the resize operation completes. It is useful for saving layout changes or persisting pane sizes.

### Event arguments

The `GridSplitterResizeStoppedEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
| `Indexes` | Gets the zero-based indexes of the panes involved in the resize operation. The first value represents the leading pane, and the second value represents the trailing pane. |
| `Panes` | Gets the affected panes involved in the resize operation. The first item is the leading pane, and the second item is the trailing pane. |

### Handle ResizeStopped event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter ResizeStopped="OnResizeStopped">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnResizeStopped(object sender, GridSplitterResizeStoppedEventArgs e)
{
    Debug.WriteLine($"Resize completed for pane {e.Indexes}");
}

{% endhighlight %}
{% endtabs %}

---

## Collapsing

The `Collapsing` event occurs before a pane is collapsed.

This event is cancelable and allows you to prevent the collapse operation when required.

### Event arguments

The `GridSplitterPaneCollapsingEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
| `Cancel` | Gets or sets a value indicating whether the collapse operation should be canceled. |
| `Indexes` | Gets the zero-based indexes of the panes involved in the collapse operation. The first value represents the pane being collapsed, and the second value represents its adjacent pane. |
| `Panes` | Gets the affected panes involved in the collapse operation. The first item is the pane being collapsed, and the second item is its adjacent pane. |

### Handle Collapsing event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Collapsing="OnCollapsing">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnCollapsing(object sender, GridSplitterPaneCollapsingEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

---

## Collapsed

The `Collapsed` event occurs after a pane has been collapsed.

This event can be used to update the application state or user interface.

### Event arguments

The `GridSplitterPaneCollapsedEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
|`Indexes` | Gets the zero-based indexes of the panes involved in the collapse operation. The first value represents the collapsed pane, and the second value represents its adjacent pane. |
| `Panes` | Gets the affected panes involved in the collapse operation. The first item is the collapsed pane, and the second item is its adjacent pane. |

### Handle Collapsed event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Collapsed="OnCollapsed">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnCollapsed(object sender, GridSplitterPaneCollapsedEventArgs e)
{
    Debug.WriteLine($"Pane {e.Indexes} collapsed.");
}

{% endhighlight %}
{% endtabs %}

---

## Expanding

The `Expanding` event occurs before a collapsed pane is expanded.

This event is cancelable and allows you to control whether the expand operation should proceed.

### Event arguments

The `GridSplitterPaneExpandingEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
| `Cancel` | Gets or sets a value indicating whether the expand operation should be canceled. |
| `Indexes` | Gets the zero-based indexes of the panes involved in the expand operation. The first value represents the pane being expanded, and the second value represents its adjacent pane. |
| `Panes` | Gets the affected panes involved in the expand operation. The first item is the pane being expanded, and the second item is its adjacent pane. |

### Handle Expanding event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Expanding="OnExpanding">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnExpanding(object sender, GridSplitterPaneExpandingEventArgs e)
{
    Debug.WriteLine($"Expanding pane {e.Indexes}");
}

{% endhighlight %}
{% endtabs %}

---

## Expanded

The `Expanded` event occurs after a pane has been expanded.

This event can be used to refresh layouts or update application state after expansion.

### Event arguments

The `GridSplitterPaneExpandedEventArgs` class contains the following members:

| Property | Description |
|-----------|-------------|
| `Indexes` | Gets the zero-based indexes of the panes involved in the expand operation. The first value represents the expanded pane, and the second value represents its adjacent pane. |
| `Panes` | Gets the affected panes involved in the expand operation. The first item is the expanded pane, and the second item is its adjacent pane. |

### Handle Expanded event

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter Expanded="OnExpanded">

    <gridSplitter:SplitterPane>
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

private void OnExpanded(object sender, GridSplitterPaneExpandedEventArgs e)
{
    Debug.WriteLine($"Pane {e.Indexes} expanded.");
}

{% endhighlight %}
{% endtabs %}

---

## Working with multiple events

The following example registers all available Grid Splitter events.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter
    ResizeStarted="GridSplitter_ResizeStarted"
    Resizing="GridSplitter_Resizing"
    ResizeStopped="GridSplitter_ResizeStopped"
    Collapsing="GridSplitter_Collapsing"
    Collapsed="GridSplitter_Collapsed"
    Expanding="GridSplitter_Expanding"
    Expanded="GridSplitter_Expanded">

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Pane 1" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane IsCollapsible="True">
        <Label Text="Pane 2" HorizontalTextAlignment="Center"
               VerticalTextAlignment="Center" />
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}
{% highlight c# %}

private void GridSplitter_ResizeStarted(object sender, GridSplitterResizeStartedEventArgs e)
{
    e.Cancel = true;
}

private void GridSplitter_Resizing(object sender, GridSplitterResizingEventArgs e)
{
    Debug.WriteLine($"Resizing pane at index {e.Indexes}");
}

private void GridSplitter_ResizeStopped(object sender, GridSplitterResizeStoppedEventArgs e)
{
    Debug.WriteLine($"Resize completed for pane {e.Indexes}");
}

private void GridSplitter_Collapsing(object sender, GridSplitterPaneCollapsingEventArgs e)
{
    e.Cancel = true;
}

private void GridSplitter_Collapsed(object sender, GridSplitterPaneCollapsedEventArgs e)
{
    Debug.WriteLine($"Pane {e.Indexes} collapsed.");
}

private void GridSplitter_Expanding(object sender, GridSplitterPaneExpandingEventArgs e)
{
    Debug.WriteLine($"Expanding pane {e.Indexes}");
}

private void GridSplitter_Expanded(object sender, GridSplitterPaneExpandedEventArgs e)
{
    Debug.WriteLine($"Pane {e.Indexes} expanded.");
}

{% endhighlight %}
{% endtabs %}

## Event sequence

### Resize operation

The following sequence occurs when a user resizes a pane:

```text
ResizeStarted
      ↓
   Resizing
      ↓
   Resizing
      ↓
   Resizing
      ↓
 ResizeStopped
```

### Collapse operation

The following sequence occurs when a pane is collapsed:

```text
Collapsing
     ↓
 Collapsed
```

### Expand operation

The following sequence occurs when a pane is expanded:

```text
Expanding
     ↓
 Expanded
```

## Use cases

The Grid Splitter events are commonly used for the following scenarios:

* Restrict resizing based on application logic.
* Save and restore user-defined pane layouts.
* Track pane size changes.
* Display resize status information.
* Prevent pane collapse for critical content.
* Synchronize pane states with view models.
* Log user interactions for analytics or diagnostics.

These events provide complete control over resizing and pane state management within the Grid Splitter control.