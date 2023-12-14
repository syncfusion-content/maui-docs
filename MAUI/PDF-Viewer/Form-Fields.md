---
layout: post
title: Form filling in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about PDF form filling using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer).
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Form Filling in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to fill, edit, save, export, and import Acroform fields in a PDF document.

## Supported form fields

You can load and fill in the following form fields in a PDF document using the PDF viewer.

* Text box
* Checkbox
* Radio button
* Combo box
* Signature
* List box
* Button

### Loading PDFs with XFA forms

The PDF viewer supports only Acroforms. PDF documents that contain XFA form cannot be viewed in the PDF Viewer. When a PDF with XFA form is attempted to be loaded, the PDF will not be loaded and the [DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) event will be raised. Refer this [page](https://help.syncfusion.com/maui/pdf-viewer/documentloadnotifications#handling-document-load-failures) to know more about handling document load failure.

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

### Retrieve form data from the PDF

The form data in a PDF can be obtained from the `SfPdfViewer.FormFields` property. The form data will be available when the PDF completes loading and the data can be retrieved from the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) event. The following code snippet illustrates getting the total count of form fields in the PDF document.

{% tabs %}
{% highlight C# %}

public void WireDocumentLoadedEvent()
{
    // Wire the document loaded event of the "SfPdfViewer" to occur when a PDF document is loaded.
    PdfViewer.DocumentLoaded += OnDocumentLoaded;
}

private void OnDocumentLoaded(object? sender, EventArgs? e)
{
    // Get the form field count.
    int fieldCount = PdfViewer.FormFields.Count;
}

{% endhighlight %}
{% endtabs %}

## Editing form fields programmatically

### Editing text form fields

A text form field can be modified using the `Text` property. The following code snippet illustrates retrieving a text form field named "name" from PDF Viewer. 

{% tabs %}
{% highlight C# %}

FormField formField = pdfViewer.FormFields.Where(x => x.Name == "name").FirstOrDefault();

if (formField is TextFormField nameTextBox)
{
    // Modify the text entered in the Text Box field.
    nameTextBox.Text = "Jonathan";
}

{% endhighlight %}
{% endtabs %}

### Editing checkbox form fields

By modifying the `IsChecked` property, the checkbox field can be checked or unchecked programmatically. The following code snippet illustrates retrieving a checkbox form field named "newsletter" from PDF Viewer. 

{% tabs %}
{% highlight C# %}

FormField formField = PdfViewer.FormFields.Where(x => x.Name == "newsletter").FirstOrDefault();

if (formField is CheckboxFormField checkBox)
{
    // Mark the checkbox as checked.
    checkBox.IsChecked = true;
}

{% endhighlight %}
{% endtabs %}

### Editing combo box form fields

The `SelectedItem` property can be used to programmatically choose an item from the combo box. The `SelectedItem` should be one of the values from the `ComboBoxFormField.Items` array. The following code snippet illustrates retrieving a combobox form field named "state" from PDF Viewer.  

{% tabs %}
{% highlight C# %}

FormField formField = PdfViewer.FormFields.Where(x => x.Name == "state").FirstOrDefault();

if (formField is ComboBoxFormField comboBox)
{
    // Select the desire item from the combo box.
    comboBox.SelectedItem = comboBox.Items[4];
}

{% endhighlight %}
{% endtabs %}

### Editing list box form fields

The `SelectedItems` property can be used to programmatically choose an item from the list box. The `SelectedItems` should contain only the values from the `ListBoxFormFields.Items` array. Both one and more selections are supported by the list box. The below code snippet illustrates modifying a single-select list box form field named "courses" from PDF Viewer.

{% tabs %}
{% highlight C# %}

FormField formField = PdfViewer.FormFields.Where(x => x.Name == "courses").FirstOrDefault();

if (formField is ListBoxFormField listBox)
{
    // Select the desire item from the list box.
    listBox.SelectedItems = new ObservableCollection<string> { listBox.Items[0] };
}

{% endhighlight %}
{% endtabs %}

The below code snippet illustrates modifying a multi-select list box form field named "courses" from PDF Viewer.

{% tabs %}
{% highlight C# %}

FormField formField = PdfViewer.FormFields.Where(x => x.Name == "courses").FirstOrDefault();

if (formField is ListBoxFormField listBox)
{
    // Select the desire item from the list box.
    listBox.SelectedItems = new System.Collections.ObjectModel.ObservableCollection<string> { listBox.Items[1], listBox.Items[2], listBox.Items[3] };
}

{% endhighlight %}
{% endtabs %}


### Editing radio button form fields

Programmatically select an item from the radio buttons using the `SelectedItem` property. The `SelectedItem` should be one of the values from the `RadioButtonFormField.Items` array. The following code snippet illustrates retrieving a radio button form field named "gender" from PDF Viewer.

{% tabs %}
{% highlight C# %}

FormField formField = PdfViewer.FormFields.Where(x => x.Name == "gender").FirstOrDefault();

if (formField is RadioButtonFormField radioButton)
{
    // Select the desired item from the radio buttons.
    radioButton.SelectedItem = radioButton.Items[0];
}

{% endhighlight %}
{% endtabs %}

### Editing signature form fields

Programmatically, add a signature to an unsigned signature field by creating and assigning an ink annotation to the `SignatureFormField.Signature` property. The following code snippet illustrates retrieving a signature form field named "signature" from PDF Viewer. 

{% tabs %}
{% highlight C# %}

SignatureFormField? signature = PdfViewer.FormFields.Where(x => x.Name == "signature").FirstOrDefault() as SignatureFormField;
if (signature != null)
{
    List<List<float>> inkPointsCollection = new();
    inkPointsCollection.Add(new List<float> { 10f, 10f, 10f, 20f, 20f, 20f, 30f, 30f, 30f, 40f, 40f, 40f, 50f, 60f });
    InkAnnotation inkSignature = new InkAnnotation(inkPointsCollection, signature.PageNumber);
    inkSignature.Color = Colors.Red;
    // Add the created handwritten signature to the signature form field.
    signature.Signature = inkSignature;
}

{% endhighlight %}
{% endtabs %}

The `Signature` property is of type [InkAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotation.html) and it will behave like an ink after signing. If the PDF document is saved, the signature will be preserved as an ink annotation in the saved document. 

### Button form fields

Button form fields will be rendered in the PDF viewer. But the PDF viewer supports only the `GoTo` actions that navigates to a particular location in the PDF document alone. Other types of button actions are not supported.

## Restrict form field editing

The form fields can be prevented from being modified by setting the `ReadOnly` property. The following example illustrates how to make all form fields read-only.

{% tabs %}
{% highlight C# %}

// Restrict the editing of all the form fields.
foreach (FormField formField in PdfViewer.FormFields)
{
    formField.ReadOnly = true;
}

{% endhighlight %}
{% endtabs %}

## Clearing form data

The `ClearFormData` method will clear the data in all form fields in the PDF.

{% tabs %}
{% highlight C# %}

// Clear all the form field data.
PdfViewer.ClearFormData();

{% endhighlight %}
{% endtabs %}

The `ClearFormData` method passed with the page number will clear all the form field data on the mentioned page of a PDF document.

{% tabs %}
{% highlight C# %}

// Clear all the form field data on the 2nd page.
PdfViewer.ClearFormData(2);

{% endhighlight %}
{% endtabs %}

### Events to track form field interaction

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to track form field interactions using events.

### Detecting the value change of form fields

The `FormFieldValueChanged` event will be raised when the values of the form fields are changed. The below code snippet illustrates detecting the value change of a text form field.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfPdfViewer x:Name="pdfViewer" FormFieldValueChanged="PdfViewer_FormFieldValueChanged"/>
			
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

private void PdfViewer_FormFieldValueChanged(object? sender, FormFieldValueChangedEventArgs? e)
{
    // Check whether the form field is a text field.
    if (e != null && e.FormField is TextFormField textFormField)
    {
        //Get the value of the form field after the event occurs.    
        string? newText = e.NewValue.ToString();

        //Get the value of the form field before the event occurs.
        string? oldText = e.OldValue.ToString();
    }
}

{% endhighlight %}
{% endtabs %}

Similarly, the value changes of other form field types can also be detected using this event. The `OldValue` and `NewValue` properties should be cast to the expected type based on the type of the field. e.g. For a check box, they should be typecast to `bool` which indicates the checked state of the checkbox.

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

N> * This event will be raised only for the text and signature form fields.

## Import and export form data

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows importing and exporting form data in the below file formats. 

* XFDF
* FDF
* JSON
* XML

### Importing

The form data can be imported into a PDF document using the `ImportFormData` method. The stream of the file to be imported and the data format should be passed as parameters to the method. The following example explains how to import form data from an XFDF file, assuming that the file is in the application’s data directory.

{% tabs %}
{% highlight C# %}

void ImportFormData()
{
    string fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "FormDataInfo.xfdf");
    Stream inputFileStream = File.OpenRead(fileName);
    inputFileStream.Position = 0;

    pdfViewer.ImportFormData(inputFileStream, Syncfusion.Pdf.Parsing.DataFormat.XFdf);
}
	
{% endhighlight %}
{% endtabs %}

To ignore errors while importing a faulty file, you can pass the value `true` for the `continueImportOnError` parameter.

{% tabs %}
{% highlight C# %}

PdfViewer.ImportFormData(inputFileStream, Syncfusion.Pdf.Parsing.DataFormat.XFdf, true);
	
{% endhighlight %}
{% endtabs %}

### Exporting

The form data can be exported from a PDF document using the `ExportFormData` method. The empty stream to write the exported data and the data format should be passed as parameters to the method. The following code explains how to export form field data from a PDF document into an XFDF file in the application’s data directory.

{% tabs %}
{% highlight C# %}

void ExportFormData()
{
    // Create the target file
    string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, "ExportedFormFile.xfdf");
    FileStream fileStream = File.Create(targetFile);

    pdfViewer.ExportFormData(fileStream, Syncfusion.Pdf.Parsing.DataFormat.XFdf);
}

{% endhighlight %}
{% endtabs %}

### How to perform validation over the form field data?

In PDF viewer, form validations can be done by obtaining the values from the form fields using the `FormFields` property and comparing them with the expected values. Below is an example that illustrates retrieving form fields by their names and checking whether they meet the expected values, before saving the document. 
 
In this example, the form field values are checked whether they meet the below criteria. If the criteria are satisfied, the PDF will be saved along with the form data. Otherwise, an error dialogue will be shown.

<table>
<tr>
<td>
<b>Field name</b>
</td>
<td>
<b>Validation messages</b>
</td>
</tr>
<tr>
<td>
Name
</td>
<td>
* Name is required.<br>
* Name should have at least 3 characters.<br>
* Name should not exceed 30 characters.<br>
* Name should not contain numbers.<br>
* Name should not contain special characters.<br>
</td>
</tr>
<tr>
<td>
Email
</td>
<td>
* Email is required.<br>
* Email should be in correct format.<br>
</td>
</tr>
<tr>
<td>
Date of birth
</td>
<td>
* Date of birth is required.<br>
* Date of birth should be in dd/mm/yyyy format.<br>
</td>
</tr>
<tr>
<td>
Course
</td>
<td>
* Atleast one course should be selected.
</td>
</tr>
<tr>
<td>
Signature
</td>
<td>
* Signature is required.
</td>
</tr>
</table>

{% tabs %}
{% highlight C# %}

async void ValidateAndSaveForm()
{
    ReadOnlyObservableCollection<FormField> _formFields = PdfViewer.FormFields;

    if (_formFields == null || _formFields.Count == 0)
    {
        return;
    }

    List<string> errors = new List<string>();

    foreach (FormField formField in _formFields)
    {
        if (formField is TextFormField textFormField)
        {
            // Handle text form fields
            if (textFormField.Name == "Name")
            {
                // Validation for the 'name' field
                if (string.IsNullOrEmpty(textFormField.Text))
                {
                    errors.Add("Name is required.");
                }
                else if (textFormField.Text.Length < 3)
                {
                    errors.Add("Name should have at least 3 characters.");
                }
                else if (textFormField.Text.Length > 30)
                {
                    errors.Add("Name should not exceed 30 characters.");
                }
                else if (Regex.IsMatch(textFormField.Text, @"[0-9]"))
                {
                    errors.Add("Name should not contain numbers.");
                }
                else if (Regex.IsMatch(textFormField.Text, @"[!@#$%^&*(),.?""{}|<>]"))
                {
                    errors.Add("Name should not contain special characters.");
                }
            }
            else if (textFormField.Name == "dob")
            {
                // Validation for the 'dob' field
                if (string.IsNullOrEmpty(textFormField.Text))
                {
                    errors.Add("Date of birth is required.");
                }
                else if (!DateTime.TryParseExact(textFormField.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    errors.Add("Date of birth should be in dd/mm/yyyy format.");
                }
            }
            else if (textFormField.Name == "email")
            {
                if (string.IsNullOrEmpty(textFormField.Text))
                {
                    errors.Add("Email is required.");
                }
                else if (!Regex.IsMatch(textFormField.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    errors.Add("Email should be in correct format.");
                }
            }
        }
        else if (formField is ListBoxFormField listBoxFormField)
        {
            if (listBoxFormField.SelectedItems.Count == 0)
            {
                errors.Add("Please select at least one item from the list.");
            }
        }
        else if (formField is SignatureFormField signatureFormField)
        {
            if (signatureFormField.Signature == null)
            {
                errors.Add("Please sign in the signature field.");
            }
        }
    }

    if (errors.Count > 0)
    {
        await DisplayAlert("Errors", string.Join("\n", errors), "Try Again");
    }
    else
    {
        string fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "FilledForm.pdf");
        using FileStream fileStream = File.Create(fileName);
        pdfViewer.SaveDocument(fileStream);
        await DisplayAlert("Success", "Form submitted successfully.", "OK");
    }
}

{% endhighlight %}
{% endtabs %}