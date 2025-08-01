---
layout: post
title: Custom Bookmark in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about the custom bookmark navigation in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Custom bookmark in .NET MAUI PDF Viewer

A PDF document may optionally have custom bookmarks that allow the user to bookmark pages and navigate to them. The PDF viewer control displays these custom bookmarks in outline view.

## Showing/hiding the custom bookmark

The PDF viewer's built-in custom bookmark view, which displays the custom bookmarks, can be shown or hidden using the [IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible) property. Its default value is `false`.

{% tabs %}
{% highlight XAML %}

<pdfViewer:SfPdfViewer x:Name="pdfViewer" IsOutlineViewVisible="{Binding OutlineViewVisible}" />

{% endhighlight %}
{% highlight c# %}

pdfViewer.IsOutlineViewVisible = true;

{% endhighlight %}
{% endtabs %}

## Accessing the custom bookmarks collection

To access the custom bookmarks, you can use the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection. This property provides the list of custom bookmarks in the PDF. 

{% tabs %}
{% highlight c# %}

var customBookmarks = pdfViewer.CustomBookmarks;

{% endhighlight %}
{% endtabs %}

## Add, edit, and remove custom bookmarks

To add, edit, or remove custom bookmarks in a PDF viewer, you can use the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection. This property provides access to the collection of custom bookmarks that can be manipulated to modify the bookmarks displayed in the viewer's bookmark view.

### Add custom bookmarks using the bookmark pane

Custom bookmarks can be added using the floating button in the bookmark pane.

![Custom bookmark floating button](Images\custom-bookmark.png)

### Adding a Custom Bookmark programmatically

To add a custom bookmark, you can create a new instance of Bookmark and add it to the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection:

{% tabs %}
{% highlight c# %}

Bookmark newBookmark = new Bookmark()
{
    Name = "New Bookmark",
    PageNumber = 1, // Page number where the bookmark should navigate
};

pdfViewer.CustomBookmarks.Add(newBookmark);


{% endhighlight %}
{% endtabs %}

### Tracking Addition of bookmark:

In the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) event handler, subscribe to the `CollectionChanged` event of the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection to track changes while addition of custom bookmark in it. Within the `CollectionChanged` event handler, you use the `NotifyCollectionChangedAction` enum to determine if the action is `Add`. If so, you iterate through all items in e.NewItems and log each entry to the debug console using **Debug.WriteLine**.

{% tabs %}
{% highlight c# %}

// Event handler for when the PDF document is loaded
private void PdfViewer_DocumentLoaded(object? sender, EventArgs? e)
{
    // Obtain the collection of custom bookmarks from the PDF viewer
    ObservableCollection<Bookmark> bookmarks = pdfViewer.CustomBookmarks;

    // Subscribe to collection change events on the bookmarks
    bookmarks.CollectionChanged += Bookmarks_CollectionChanged;
}

// Event handler for changes in the bookmarks collection
private void Bookmarks_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    // Handle addition of new bookmarks
    if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems != null)
    {
        foreach (Bookmark newBookmark in e.NewItems)
        {
            Debug.WriteLine($"Added bookmark: {newBookmark.Name} at page {newBookmark.PageNumber}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Rename custom bookmarks using the bookmark context menu

Tap the context menu button on the custom bookmark to be edited and choose Rename and enter the desired name.

![Custom bookmark context menu](Images\custom-bookmark-contextmenu.png)

### Rename a Custom Bookmark programmatically

To rename an existing custom bookmark, you can retrieve the bookmark from the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection and modify its properties:

{% tabs %}
{% highlight c# %}

Bookmark bookmarkToEdit = pdfViewer.CustomBookmarks.FirstOrDefault(b => b.Title == "Chapter 2");
if (bookmarkToEdit != null)
{
    bookmarkToEdit.Name = "Edited Bookmark Title";
}


{% endhighlight %}
{% endtabs %}

### Tracking custom bookmarks rename changes

For the newly added custom bookmarks, you need to wire the `PropertyChanged` event in the `CollectionChanged` event handler after checking whether the action is `Add` using the `NotifyCollectionChangedAction` enum.

{% tabs %}
{% highlight c# %}

private void Bookmarks_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    // Handle addition of new bookmarks
    if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems != null)
    {
        foreach (Bookmark newBookmark in e.NewItems)
        {
            bookmark.PropertyChanged += Bookmark_PropertyChanged;
        }
    }
}

private void Bookmark_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    if (sender is Bookmark changedBookmark)
    {
        if (e.PropertyName == nameof(Bookmark.Name))
        {
            Debug.WriteLine($"Bookmark updated: {e.PropertyName} changed to: " +
            $"{changedBookmark.Name}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

For the existing custom bookmark, you can track the bookmark rename changes by wiring the `PropertyChanged` event using the event handler in the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) event handler for all existing custom bookmarks in the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks)  collection, where you can log each custom bookmark rename entry to the debug console using **Debug.WriteLine**. 

{% tabs %}
{% highlight c# %}

private void PdfViewer_DocumentLoaded(object? sender, EventArgs? e)
{
    // Obtain the collection of custom bookmarks from the PDF viewer
    ObservableCollection<Bookmark> bookmarks = pdfViewer.CustomBookmarks;
    // Attach event handlers to existing bookmarks in the collection
   foreach (var bookmark in bookmarks)
   {
       bookmark.PropertyChanged += Bookmark_PropertyChanged;
   }
}

private void Bookmark_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    if (sender is Bookmark changedBookmark)
    {
        if (e.PropertyName == nameof(Bookmark.Name))
        {
            Debug.WriteLine($"Bookmark updated: {e.PropertyName} changed to: " +
            $"{changedBookmark.Name}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Remove custom bookmarks using the bookmark context menu

Tap the context menu button on the custom bookmark to be removed and tap `Delete`.

### Removing a Custom Bookmark programmatically

To remove a custom bookmark, you can remove it directly from the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection:

{% tabs %}
{% highlight c# %}

Bookmark bookmarkToRemove = pdfViewer.CustomBookmarks.FirstOrDefault(b => b.Title == "Chapter 2");
if (bookmarkToRemove != null)
{
    pdfViewer.CustomBookmarks.Remove(bookmarkToRemove);
}


{% endhighlight %}
{% endtabs %}

### Tracking Removal of custom bookmark:

In the `CollectionChanged` event handler, you can use the `NotifyCollectionChangedAction` enum to determine if the action is `Remove`. If it is, you iterate through all items in e.NewItems and log each entry to the debug console using **Debug.WriteLine**.

{% tabs %}
{% highlight c# %}

// Event handler for changes in the bookmarks collection
private void Bookmarks_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    // Handle Removal of new bookmarks
    else if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems != null)
    {
        foreach (Bookmark oldBookmark in e.OldItems)
        {
            Debug.WriteLine($"Removed bookmark: {oldBookmark.Name} at page {oldBookmark.PageNumber}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Navigating to a custom bookmark

### Navigating using UI

As mentioned above, you can show the outline view by setting the [IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible) property to `true`. When the outline view is showing, you can tap on any bookmark to navigate to the destination pointed to that bookmark. 

![Custom bookmark in .NET MAUI PDF Viewer](Images\custom-bookmark.png)

### Navigating programmatically

The PDF viewer allows the users to navigate to an custom bookmark using the [GoToBookmark](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToBookmark_Syncfusion_Maui_PdfViewer_Bookmark_) method. The below code snippet illustrates the same.

{% tabs %}
{% highlight c# %}

//Get the required custom bookmark
Bookmark customBookmark = pdfViewer.CustomBookmarks.Where(x => x.Name.Contains("Chapter 2")).FirstOrDefault();

if (customBookmark != null)
   pdfViewer.GoToBookmark(customBookmark);

{% endhighlight %}
{% endtabs %}