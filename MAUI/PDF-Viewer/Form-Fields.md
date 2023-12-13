---
layout: post
title: Form fields in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about form fields in the PDF documents using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer).
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Form Filling in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) supports adding/modifying the existing forms fields content present in the PDF document. By default, it detects the form fields present in the PDF document and easily modifying or filling the values.

N> * PDF Viewer supports only Acroform. PDF documents with XFA form fields cannot be viewed in PDF Viewer.

## Loading PDFs with XFA forms

PDF documents that contain XFA form fields cannot be viewed in PDF Viewer since they can be viewed only in Adobe reader. When a PDF with XFA form is loaded, the [DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) event will be raised.

{% tabs %}
{% highlight C# %}

private void PdfViewer_DocumentLoadFailed(object sender, DocumentLoadFailedEventArgs e)
{
    if (e.Message == "This PDF cannot be loaded because it contains XFA form.")
    {
        // Handle XFA loading failure.
    }
}

{% endhighlight %}
{% endtabs %}

### How to get form fields collection in loaded PDF document

The form fields in a PDF document can be accessed using the FormFields property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). This read only property will have the form fields collection information as soon as the document is loaded into the PDF Viewer. The following example explains how to use the property to obtain information about a signature form field from that form field collection.

{% tabs %}
{% highlight C# %}

public void WireDocumentLoadedEvent()
{
    // Wire the document loaded event of the "SfPdfViewer" to occur when a PDF document is loaded.
    PdfViewer.DocumentLoaded += OnDocumentLoaded;
}

private void OnDocumentLoaded(object? sender, EventArgs? e)
{
    // To get the form fields collection.
    ReadOnlyObservableCollection<FormField> formFields = PdfViewer.FormFields;

    SignatureFormField? signatureField = formFields.Where(x => x.Name == "signature") as SignatureFormField;
    if (signatureField != null)
    {
        bool isSigned = signatureField.Signature != null;
    }
}

{% endhighlight %}
{% endtabs %}

## Editing the Form Field Values Programmatically

Programmatically edit the form fields in the document using the `FormFields` collection in the PdfViewer.

### Editing the Text Box form field

Programmatically edit the text of the text form field by changing the Text property.

{% tabs %}
{% highlight C# %}

if (PdfViewer.FormFields.Where(x => x.Name == "name") is TextFormField nameTextBox)
{
    // Modify the text entered in the Text Box field.
    nameTextBox.Text = "Jonathan";
}

{% endhighlight %}
{% endtabs %}

### Editing the Checkbox form field

By modifying the `IsChecked` property, the checkbox field can be checked or unchecked programmatically.

{% tabs %}
{% highlight C# %}

if (PdfViewer.FormFields.Where(x => x.Name == "newsletter") is CheckboxFormField checkBox)
{
    // Mark the checkbox as checked.
    checkBox.IsChecked = true;
}

{% endhighlight %}
{% endtabs %}

### Editing the Combobox form field

The `SelectedItem` property can be used to programmatically choose an item from the Combo box.

{% tabs %}
{% highlight C# %}

if (PdfViewer.FormFields.Where(x => x.Name == "state") is ComboBoxFormField comboBox)
{
    // Select the desire item from the combo box.
    comboBox.SelectedItem = comboBox.Items[4];
}

{% endhighlight %}
{% endtabs %}

### Editing the Listbox form field

The `SelectedItems` property can be used to programmatically choose an item from the list box. Both one and more selections are supported by the list box. For a list box with a single selection,

{% tabs %}
{% highlight C# %}

if (PdfViewer.FormFields.Where(x => x.Name == "state") is ListBoxFormField listBox)
{
    // Select the desire item from the list box.
    listBox.SelectedItems = new ObservableCollection<string> { listBox.Items[0] };
}

{% endhighlight %}
{% endtabs %}

For a list box with a multiple selection,

{% tabs %}
{% highlight C# %}

if (PdfViewer.FormFields.Where(x => x.Name == "state") is ListBoxFormField listBox)
{
    // Select the desire item from the list box.
    listBox.SelectedItems = new System.Collections.ObjectModel.ObservableCollection<string> { listBox.Items[1] , listBox.Items[2] , listBox.Items[3] };
}

{% endhighlight %}
{% endtabs %}

### Button form field

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) displays the button fields and facilitates actions that lead to specific locations inside the active document.

### Editing the Radio button form field

Programmatically select an item from the radio buttons using the `SelectedItem` property.

{% tabs %}
{% highlight C# %}

if (PdfViewer.FormFields.Where(x => x.Name == "gender") is RadioButtonFormField radioButton)
{
    // Select the desired item from the radio buttons.
    radioButton.SelectedItem = radioButton.Items[0];
}

{% endhighlight %}
{% endtabs %}

### Editing the Signature form field

Programmatically, add a signature to the signature form field by creating and assigning an ink annotation to the `Signature` property.

{% tabs %}
{% highlight C# %}

SignatureFormField? signature = PdfViewer.FormFields.Where(x => x.Name == "signature") as SignatureFormField;
if (signature != null)
{
    List<List<float>> inkPointsCollection = new();
    inkPointsCollection.Add(new List<float> { 10f, 10f, 10f, 20f, 20f, 20f, 30f, 30f, 30f, 40f, 40f, 40f, 50f, 60f });
    InkAnnotation inkSignature = new InkAnnotation(inkPointsCollection,1);
    inkSignature.Color = Colors.Red;
    // Add the created handwritten signature to the signature form field.
    signature.Signature = inkSignature;
}

{% endhighlight %}
{% endtabs %}

## How to restrict form field editing?

You can avoid editing the values of form fields. The following example explains how to use the property to restrict all form fields.

{% tabs %}
{% highlight C# %}

// Restrict the editing of all the form fields.
foreach (FormField formField in PdfViewer.FormFields)
{
    formField.ReadOnly = true;
}

{% endhighlight %}
{% endtabs %}

## How to clear form field data?

The `ClearFormData` method can remove or clear all the form field data in a PDF document.

{% tabs %}
{% highlight C# %}

// Clear all the form field data.
PdfViewer.ClearFormData();

{% endhighlight %}
{% endtabs %}

The `ClearFormData` method passed with the page number can remove or clear all the form field data on the mentioned page of a PDF document.

{% tabs %}
{% highlight C# %}

// Clear all the form field data on the 2nd page.
PdfViewer.ClearFormData(2);

{% endhighlight %}
{% endtabs %}

### Events to track form field interaction

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to track form field interactions using events. The interactions on the following types of form fields can be tracked using the following events:
* Text
* Check Box
* Radio button
* Combo Box
* List box
* Signature

### Detecting the value change of form fields

The `FormFieldValueChanged` event will be raised when the values of the form fields are changed.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfPdfViewer x:Name="pdfViewer" FormFieldValueChanged="PdfViewer_FormFieldValueChanged"/>
			
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void PdfViewer_FormFieldValueChanged(object? sender, FormFieldValueChangedEventArgs? e)
{
    if (e != null)
    {
        //Get the occurring form field.        
        FormField? field = e.FormField;
        //Get the value of the form field after the event occurs.    
        object? newValue = e.NewValue;
        //Get the value of the form field before the event occurs.
        object? oldValue = e.OldValue;
    }
}

{% endhighlight %}
{% endtabs %}

### Detecting the focus and unfocus of form fields

The `FormFieldFocusChanged` event will be raised when text or signature field is focused or unfocused.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfPdfViewer x:Name="pdfViewer" FormFieldFocusChanged="PdfViewer_FormFieldFocusChanged"/>
			
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void PdfViewer_FormFieldFocusChanged(object? sender, FormFieldFocusChangedEvenArgs? e)
{
    if (e != null)
    {
        //Get the occurring form field.             
        FormField? field = e.FormField;
        //Get the hasFocus value of the form field.            
        bool hasFocus = e.HasFocus;
    }
}

{% endhighlight %}
{% endtabs %}

N> * This event will be raised only for the text and signature form fields

## Imports and Exports the form data

### Imports form data

You can add values of form fields to a PDF document by importing by using the `ImportFormData` method. You need to provide the stream of the file containing the form values and the data format information as parameters to the method. The following example explains how to import form data from an XFDF file, assuming that the file is in the application’s data directory.

{% tabs %}
{% highlight C# %}

void ImportFormData()
{
    string fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "FormDataInfo.xfdf");
    Stream inputFileStream = File.OpenRead(fileName);
    inputFileStream.Position = 0;

    // Provide the file stream and the data format information as parameters to the `ImportFormData` method of `SfPdfViewer` instance to import the form data's.
    PdfViewer.ImportFormData(inputFileStream, Syncfusion.Pdf.Parsing.DataFormat.XFdf);
}
	
{% endhighlight %}
{% endtabs %}

You can continue the import process even if errors are encountered by passing the “continueImportOnError” boolean parameter in ImportFormData.

{% tabs %}
{% highlight C# %}

PdfViewer.ImportFormData(inputFileStream, Syncfusion.Pdf.Parsing.DataFormat.XFdf,true);
	
{% endhighlight %}
{% endtabs %}

* Similarly, you may import form fields from an FDF file also.
* To import the form data’s asynchronously, you may use the `ImportFormDataAsync` method.

### Exports form data

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to export form data from a PDF document. This will help you to save the form field information in a separate file rather than the complete PDF file. You need to provide the supported file stream as a parameter to the ExportFormData method to achieve the same. The form fields information will be exported to the given file stream. The following code explains how to export form field data from a PDF document into an XFDF file in the application’s data directory.

{% tabs %}
{% highlight C# %}

void ExportFormData()
{
    string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, "ExportedFormFile.xfdf");
    FileStream fileStream = File.Create(targetFile);

    // Export the form data’s to the file stream by passing stream to the ` ExportFormData ` method of `SfPdfViewer` instance.
    PdfViewer.ExportFormData(fileStream, Syncfusion.Pdf.Parsing.DataFormat.XFdf);
}
	
{% endhighlight %}
{% endtabs %}

* Similarly, you may export form field data into an FDF file also. To export the form fields asynchronously, you may use the `ExportFormDataAsync` method.

### Supported file type for imports and exports

* XFDF
* FDF
* JSON
* XML
