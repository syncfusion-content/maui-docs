---
layout: post
title: Custom Bookmark in .NET MAUI PDF Viewer control | Syncfusion®
description: Learn here about the custom bookmark navigation in Syncfusion® .NET MAUI PDF Viewer (SfPdfViewer) control.
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

## Accessing custom bookmarks collection

To access the custom bookmarks, you can use the [CustomBookmarks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_CustomBookmarks) collection. This property provides the list of custom bookmarks in the PDF. 

{% tabs %}
{% highlight c# %}

var customBookmarks = pdfViewer.CustomBookmarks;

{% endhighlight %}
{% endtabs %}

## Add , Edit and Remove custom bookmark

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
    PageNumber = 1, // Page number where the bookmark should to navigate
};

pdfViewer.CustomBookmarks.Add(newBookmark);


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

## Navigating to custom bookmark

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