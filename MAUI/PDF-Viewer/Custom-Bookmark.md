---
layout: post
title: Custom Bookmarks in .NET MAUI PDF Viewer Control | Syncfusion
description: Discover how to navigate using custom bookmark navigation in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Custom Bookmarks in .NET MAUI PDF Viewer

PDF documents can include custom bookmarks that allow the user to bookmark pages and navigate to them. The PDF viewer control displays these custom bookmarks in outline view.

## Showing/Hiding the Custom Bookmarks Pane

The built-in custom bookmark view of the PDF Viewer displays the custom bookmarks, can be shown or hidden using the [IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible) property. The default value of this property is `false`.

{% tabs %}
{% highlight XAML %}

<pdfViewer:SfPdfViewer x:Name="pdfViewer" IsOutlineViewVisible="{Binding OutlineViewVisible}" />

{% endhighlight %}
{% highlight c# %}

pdfViewer.IsOutlineViewVisible = true;

{% endhighlight %}
{% endtabs %}

## Accessing the Custom Bookmarks Collection

To retrieve the list of custom bookmarks in a PDF document, use the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) property.

{% tabs %}
{% highlight c# %}

var customBookmarks = pdfViewer.CustomBookmarks;

{% endhighlight %}
{% endtabs %}

## Add, Edit, and Remove Custom Bookmarks

You can manage custom bookmarks in the PDF viewer using the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection. This property allows you to add, edit, or remove bookmarks that appear in the viewer’s bookmark pane.

### Add Custom Bookmarks

You can add custom bookmarks either through the UI or programmatically. You can also track additions using event handlers.

#### Add via UI

Use the floating action button in the bookmark pane to add a custom bookmark.

![Custom bookmark floating button](Images\custom-bookmark.png)

#### Add Programmatically

Create a new instance of the Bookmark class and add it to the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection:

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

#### Track Bookmark Additions

To track when a custom bookmark is added, subscribe to the [CollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1.collectionchanged?view=net-9.0) event of the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection inside the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) event handler. 
Within the [CollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1.collectionchanged?view=net-9.0) event handler, use the [NotifyCollectionChangedAction](https://learn.microsoft.com/en-us/dotnet/api/system.collections.specialized.notifycollectionchangedaction?view=net-9.0) enumeration to determine the type of change. If the action is `Add`, iterate through `e.NewItems` to access the newly added bookmarks and perform any necessary tracking or logging.

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
    Check if the change action is 'Add'
    if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems != null)
    {
        // Iterate through newly added bookmarks
        foreach (Bookmark bookmark in e.NewItems)
        {
            Debug.WriteLine($"Added bookmark: {bookmark.Name} at page {bookmark.PageNumber}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Rename Custom Bookmarks

You can rename custom bookmarks either through the UI or programmatically. You can also track rename changes using event handlers.

#### Rename via Context Menu

To rename a custom bookmark from the UI:
1. Tap the context menu button on the desired custom bookmark.
2. Select **Rename**.
3. Enter the new name.

![Custom bookmark context menu](Images\custom-bookmark-contextmenu.png)

#### Rename Programmatically

To rename an existing custom bookmark, retrieve it from the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection and update its Name property:

{% tabs %}
{% highlight c# %}

Bookmark bookmarkToEdit = pdfViewer.CustomBookmarks.FirstOrDefault(b => b.Title == "Chapter 2");
if (bookmarkToEdit != null)
{
    bookmarkToEdit.Name = "Edited Bookmark Title";
}

{% endhighlight %}
{% endtabs %}

#### Track Bookmark Rename Changes

To track when a bookmark is renamed, you need to handle the [PropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged?view=net-9.0#system-componentmodel-inotifypropertychanged-propertychanged) event of each bookmark. 

##### For Newly Added Bookmarks

Subscribe to the `PropertyChanged` event inside the [CollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1.collectionchanged?view=net-9.0) event handler when the action is **Add**:

{% tabs %}
{% highlight c# %}

private void Bookmarks_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    // Handle addition of new bookmarks
    if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems != null)
    {
        foreach (Bookmark bookmark in e.NewItems)
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

##### For Existing Bookmarks

To track rename changes for bookmarks that already exist when the document is loaded, wire the [PropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged?view=net-9.0#system-componentmodel-inotifypropertychanged-propertychanged) event for each bookmark in the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) event handler:

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

### Remove Custom Bookmarks

You can remove custom bookmarks either through the UI or programmatically. You can also track bookmark removal using event handlers.

#### Remove via Context Menu

To remove a custom bookmark from the UI:
1. Tap the context menu button on the custom bookmark you want to delete.
2. Select Delete.

#### Remove Programmatically

To remove a custom bookmark programmatically, retrieve it from the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection and remove it:

{% tabs %}
{% highlight c# %}

Bookmark bookmarkToRemove = pdfViewer.CustomBookmarks.FirstOrDefault(b => b.Title == "Chapter 2");
if (bookmarkToRemove != null)
{
    pdfViewer.CustomBookmarks.Remove(bookmarkToRemove);
}

{% endhighlight %}
{% endtabs %}

#### Track Bookmark Removal

To track when a custom bookmark is removed, handle the [CollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1.collectionchanged?view=net-9.0) event of the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection. Use the [NotifyCollectionChangedAction](https://learn.microsoft.com/en-us/dotnet/api/system.collections.specialized.notifycollectionchangedaction?view=net-9.0) enum to check if the action is `Remove`. If so, iterate through `e.OldItems` to access the removed bookmarks:

{% tabs %}
{% highlight c# %}

// Event handler for changes in the bookmarks collection
private void Bookmarks_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    // Handle removal of new bookmarks
    else if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems != null)
    {
        foreach (Bookmark bookmark in e.OldItems)
        {
            Debug.WriteLine($"Removed bookmark: {bookmark.Name} at page {bookmark.PageNumber}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Navigate to a Custom Bookmark

You can navigate to custom bookmarks either through the UI or programmatically using the PDF viewer's built-in features.

### Navigate Using UI

To navigate using the UI:
1. Ensure the outline view is visible by setting the [IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible) property to `true`.
2. Once the outline view is displayed, tap on any custom bookmark to navigate to the corresponding page. 

![Custom bookmark in .NET MAUI PDF Viewer](Images\custom-bookmark.png)

### Navigate Programmatically

To navigate to a custom bookmark programmatically, use the [GoToBookmark](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToBookmark_Syncfusion_Maui_PdfViewer_Bookmark_) method. This method accepts a `Bookmark` object and navigates to the page associated with it.

{% tabs %}
{% highlight c# %}

//Get the required custom bookmark
Bookmark customBookmark = pdfViewer.CustomBookmarks.Where(x => x.Name.Contains("Chapter 2")).FirstOrDefault();

if (customBookmark != null)
   pdfViewer.GoToBookmark(customBookmark);

{% endhighlight %}
{% endtabs %}
