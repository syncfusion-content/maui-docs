---
layout: post
title: Form filling in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about PDF form filling feature of Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control and more.
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

The form data in a PDF can be obtained from the [SfPdfViewer.FormFields](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FormFields) property. The form data will be available when the PDF completes loading and the data can be retrieved from the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) event. The following code snippet illustrates getting the total count of form fields in the PDF document.

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

A text form field can be modified using the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextFormField.html#Syncfusion_Maui_PdfViewer_TextFormField_Text) property. The following code snippet illustrates retrieving a text form field named "name" from PDF Viewer. 

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

By modifying the [IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.CheckboxFormField.html#Syncfusion_Maui_PdfViewer_CheckboxFormField_IsChecked) property, the checkbox field can be checked or unchecked programmatically. The following code snippet illustrates retrieving a checkbox form field named "newsletter" from PDF Viewer. 

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

The [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ComboBoxFormField.html#Syncfusion_Maui_PdfViewer_ComboBoxFormField_SelectedItem) property can be used to programmatically choose an item from the combo box. The [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ComboBoxFormField.html#Syncfusion_Maui_PdfViewer_ComboBoxFormField_SelectedItem) should be one of the values from the [ComboBoxFormField.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ComboBoxFormField.html#Syncfusion_Maui_PdfViewer_ComboBoxFormField_Items) array. The following code snippet illustrates retrieving a combobox form field named "state" from PDF Viewer.  

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

The [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ListBoxFormField.html#Syncfusion_Maui_PdfViewer_ListBoxFormField_SelectedItems) property can be used to programmatically choose an item from the list box. The [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ListBoxFormField.html#Syncfusion_Maui_PdfViewer_ListBoxFormField_SelectedItems) should contain only the values from the [ListBoxFormFields.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ListBoxFormField.html#Syncfusion_Maui_PdfViewer_ListBoxFormField_Items) array. Both one and more selections are supported by the list box. The below code snippet illustrates modifying a single-select list box form field named "courses" from PDF Viewer.

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

Programmatically select an item from the radio buttons using the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.RadioButtonFormField.html#Syncfusion_Maui_PdfViewer_RadioButtonFormField_SelectedItem) property. The [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.RadioButtonFormField.html#Syncfusion_Maui_PdfViewer_RadioButtonFormField_SelectedItem) should be one of the values from the [RadioButtonFormField.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.RadioButtonFormField.html#Syncfusion_Maui_PdfViewer_RadioButtonFormField_Items) array. The following code snippet illustrates retrieving a radio button form field named "gender" from PDF Viewer.

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

Programmatically, add a signature to an unsigned signature field by creating and assigning an ink annotation to the [SignatureFormField.Signature](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SignatureFormField.html#Syncfusion_Maui_PdfViewer_SignatureFormField_Signature) property. The following code snippet illustrates retrieving a signature form field named "signature" from PDF Viewer. 

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

The [Signature](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SignatureFormField.html#Syncfusion_Maui_PdfViewer_SignatureFormField_Signature) property is of type [InkAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotation.html) and it will behave like an ink after signing. If the PDF document is saved, the signature will be preserved as an ink annotation in the saved document. 

#### Supressing the signature modal view

The [Sfpdfviewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to supress the signature modal view and use your own UI in its place. This can be achieved by setting the `FormFieldModalViewAppearingEventArgs.Cancel` property to `true` in the `SignatureModalViewAppearing` event handler. 

The below code snippet illustrates supressing the signature modal view and using a UI implemented in the app in its place. In this illustration, it is assumed that the signature is produced in the form of an image stream when the user completes drawing the signature in the custom dialog. When the signing is completed using the custom dialog, a stamp annotation is created and assigned as the signature of the form field.   

{% tabs %}
{% highlight c# %}

SignatureFormField? signatureFormField;
pdfviewer.SignatureModalViewAppearing += PdfViewer_SignatureModalViewAppearing;

private void PdfViewer_SignatureModalViewAppearing(object? Sender, FormFieldModalViewAppearingEventArgs e)
{
    e.Cancel = true;
    signatureFormField = e.FormField as SignatureFormField;
    
    // Implement your own UI for creating a signature.
    ShowCustomDialog();
}

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the signature in the form of a Stream instance (possibly converted from an image of the user's free hand drawing) 
   signatureImageStream = GetSignatureImageStream();
   
   // Create a stamp annotation. The bounds values are not necessary since the stamp will be automatically fit over the signature form field. 
   StampAnnotation signatureStamp = new StampAnnotation(signatureImageStream, signatureFormField.PageNumber, new RectF(0, 0, 0, 0));
   
   signatureFormField.Signature = signatureStamp;
}

{% endhighlight %} 
{% endtabs %}

### Button form fields

Button form fields will be rendered in the PDF viewer. But the PDF viewer supports only the `GoTo` actions that navigates to a particular location in the PDF document alone. Other types of button actions are not supported.

### Adding custom information to a form field

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to assign custom information to form fields. The [CustomData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FormField.html#Syncfusion_Maui_PdfViewer_FormField_CustomData) property is utilized to store additional information about each form field instance for reference. However, it's essential to note that these data are solely intended for reference purposes and will not be displayed in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) interface.

The following code sample demonstrates how to set the [CustomData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FormField.html#Syncfusion_Maui_PdfViewer_FormField_CustomData) property for a form field. In this code sample, we set the custom data to represent the modification time of the form field.

{% tabs %}
{% highlight C# %}

private void PdfViewer_FormFieldValueChanged(object sender, FormFieldValueChangedEventArgs e)
{
        e.FormField.CustomData="Modified Date is: " +DateTime.Now.ToString();
}

{% endhighlight %}
{% endtabs %}

## Show and Hide form fields 
 
You can manage the visibility of form fields using the `IsHidden` property. It helps you to hide form fields containing confidential data when sharing documents externally or presenting documents, ensuring data privacy and security. Also, it makes it easier to read the documents which are cluttered with more form fields. Like other form fields properties, you can undo and redo the hiding or showing actions. Additionally, when an form field is locked, it cannot be hidden. Form fields that are hidden will remain hidden during import, export, printing and saving.

### Hide form fields

To hide form fields in the document, set the `IsHidden` property of the form fields to `true`.

#### Hide all form fields

While reviewing and presenting documents, all form fields can be hidden to improve the focus on the content and to avoid distraction caused by cluttered form fields. The following example explains how to hide all form fields in a PDF document. 

{% tabs %}
{% highlight C# %} 

foreach(FormField  formfield in PdfViewer.FormFields) 
{ 
    formfield.IsHidden = true;  
}
 
{% endhighlight %}
{% endtabs %}

* Similarly, to show all the form fields, set the `IsHidden` property value to `false`.

### Hide specific form fields 

While collaborating, the `IsHidden` property of form fields can be used to show and hide form fields from specific authors. The following example illustrates how to hide form fields for a TextFormField by accessing the text form field’s `IsHidden` property. 

{% tabs %}
{% highlight C# %}

//The code searches for a form field named "name" in the PDF.
FormField formField = PdfViewer.FormFields.Where(x => x.Name == "name").FirstOrDefault();

//If the form field is a TextFormField, it hides that form field by setting its IsHidden property to true.
if (formField is TextFormField nameTextBox)
{
    // Hide  the Text Box field.
    nameTextBox.IsHidden = true;
}

{% endhighlight %}
{% endtabs %}

* Similarly, to show the form fields, set the `IsHidden` property value to `false`. 

## Customize the form fields programmatically

Customizing form fields allows you to control their appearance and behavior. You can modify properties like background color, border color, border width, and foreground color to adjust how fields such as text boxes, checkboxes, and radio buttons look in the PDF Viewer. These customizations can be undo and redo, but they cannot be changed when a field is locked. The customized colors and border width are preserved during import, export, printing, and saving, ensuring consistency across document operations.

### Customize the background color of the form fields

The BackgroundColor property sets the background color of a form field, letting you customize its appearance. Here's an example of how to use it for a text form field, and it can also be applied to checkboxes and radio buttons by adjusting their properties.


{% tabs %}
{% highlight C# %}
foreach (FormField formField in PdfViewer.FormFields) 
{
    // Check if the current form field is a text form field 
    if (formField is TextFormField textBoxField)
    {
        // Loop through all the widgets associated with the text box field
        foreach (var widget in textBoxField.Widgets)
        {
            // Set the background color of each widget to yellow
            widget.BackgroundColor = Colors.Yellow;
        }
    }
}
 
{% endhighlight %}
{% endtabs %}

### Customize the text color of the form fields

The ForegroundColor property sets the text color within a form field, allowing customization to highlight important fields or messages. Here's an example of how to use it for a text form field, and it can be applied to other form fields like checkboxes and radio buttons by adjusting their properties. 


{% tabs %}
{% highlight C# %} 
foreach (FormField formField in PdfViewer.FormFields)
{
    // Check if the current form field is a text form field 
    if (formField is TextFormField textBoxField)
    {
        // Loop through all the widgets associated with the text box field
        foreach (var widget in textBoxField.Widgets)
        {
            // Set the foreground color of each widget to Red
            widget. ForegroundColor = Colors.Red;
        }
    }
} 
{% endhighlight %}
{% endtabs %}



### Customize the border color of the form fields

The BorderColor property sets the color of the border around a form field, improving visibility, especially for users with color blindness. Here's an example of how to use it for a text form field, and it can be applied to other form fields like checkboxes and radio buttons by adjusting their properties. 
 

{% tabs %}
{% highlight C# %} 
foreach (FormField formField in PdfViewer.FormFields)
{
     // Check if the current form field is a text form field 
    if (formField is TextFormField textBoxField)
    {
         // Loop through all the widgets associated with the text box field
        foreach (var widget in textBoxField.Widgets)
        {
            // Set the border color of each widget to Red
            widget. BorderColor = Colors.Red;
        }
    }
}
{% endhighlight %}
{% endtabs %}

### Customize the border width of the form fields

The BorderWidth property sets the thickness of the border around a form field, improving accessibility for users with visual impairments. Here's an example of how to use it for a text form field, and it can be applied to other form fields like checkboxes and radio buttons by adjusting their properties. 
 

{% tabs %}
{% highlight C# %}
foreach (FormField formField in PdfViewer.FormFields)
{
     // Check if the current form field is a text form field 
    if (formField is TextFormField textBoxField)
    {
        // Loop through all the widgets associated with the text box field
        foreach (var widget in textBoxField.Widgets)
        {
            // Set the border color of each widget to 2.0f
            widget. BorderWidth = 2.0f;
        }
    }
} 
{% endhighlight %}
{% endtabs %}

## Property changed event for Form fields Widgets

The `PropertyChanged` event occurs when a property is changed in the PDF document. It is common for properties such as border color, background color, border width, and foreground color to trigger this event as well. The following example explains how to wire and handle the event.

{% tabs %}
{% highlight C# %}

void FormFieldWidgetPropertyChangedEvent()
{
    // Loop through each FormField in the PdfViewer
    foreach (FormField formField in pdfViewer.FormFields)
    {
        // Loop through each widget within the form field (e.g., text fields, checkboxes, etc.)
        foreach (var widget in formField.Widgets)
        {
            // Subscribe to the PropertyChanged event for each widget
            widget.PropertyChanged += Widget_PropertyChanged;
        }
    }
}
// This event handler is called whenever a property of a widget changes
private void Widget_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
{
    // Ensure that the sender is of type Widget
    if (sender is Widget widget)
    {
        // Check if the property that changed is the BorderWidth property of the widget
        if (e.PropertyName == nameof(widget.BorderWidth))
        {
            // Retrieve the current border width of the widget
            double width=widget.BorderWidth;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Restrict form field editing

The form fields can be prevented from being modified by setting the [ReadOnly](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FormField.html#Syncfusion_Maui_PdfViewer_FormField_ReadOnly) property. The following example illustrates how to make all form fields read-only.

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

The [ClearFormData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ClearFormData_System_Int32_) method will clear the data in all form fields in the PDF.

{% tabs %}
{% highlight C# %}

// Clear all the form field data.
PdfViewer.ClearFormData();

{% endhighlight %}
{% endtabs %}

The [ClearFormData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ClearFormData_System_Int32_) method passed with the page number will clear all the form field data on the mentioned page of a PDF document.

{% tabs %}
{% highlight C# %}

// Clear all the form field data on the 2nd page.
PdfViewer.ClearFormData(2);

{% endhighlight %}
{% endtabs %}

### Events to track form field interaction

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to track form field interactions using events.

### Detecting the value change of form fields

The [FormFieldValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FormFieldValueChanged) event will be raised when the values of the form fields are changed. The below code snippet illustrates detecting the value change of a text form field.

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

Similarly, the value changes of other form field types can also be detected using this event. The [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FormFieldValueChangedEventArgs.html#Syncfusion_Maui_PdfViewer_FormFieldValueChangedEventArgs_OldValue) and [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FormFieldValueChangedEventArgs.html#Syncfusion_Maui_PdfViewer_FormFieldValueChangedEventArgs_NewValue) properties should be cast to the expected type based on the type of the field. e.g. For a check box, they should be typecast to `bool` which indicates the checked state of the checkbox.

### Detecting the focus and unfocus of form fields

The [FormFieldFocusChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FormFieldFocusChanged) event will be raised when text or signature field is focused or unfocused.

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

## Import and Export form data

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to import and export form data to and from PDF documents. The import and export of form data support the following file data formats:

* XFDF
* FDF
* JSON
* XML

The required file format can be chosen from the [DataFormat](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.Parsing.DataFormat.html) enumeration. In the following sections, only the `XFDF` file format is explained for brevity.

N> The XFDF and FDF are the standard file data formats that can be used across global PDF viewers. Whereas, JSON and XML are the custom formats that can only be used across the Syncfusion<sup>®</sup> PDF Viewers supported on other platforms like WPF, Flutter, JavaScript, etc.

### Import form data

The form data can be imported into a PDF document using the [ImportFormData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ImportFormData_System_IO_Stream_Syncfusion_Pdf_Parsing_DataFormat_System_Boolean_) method. The stream of the file to be imported and the data format should be passed as parameters to the method. The following example explains how to import form data from an XFDF file, assuming that the file is in the application’s data directory.

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

### Export form data

The form data can be exported from a PDF document using the [ExportFormData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportFormData_System_IO_Stream_Syncfusion_Pdf_Parsing_DataFormat_) method. The empty stream to write the exported data and the data format should be passed as parameters to the method. The following code explains how to export form field data from a PDF document into an XFDF file in the application’s data directory.

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

In PDF viewer, form validations can be done by obtaining the values from the form fields using the [FormFields](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FormFields) property and comparing them with the expected values. Below is an example that illustrates retrieving form fields by their names and checking whether they meet the expected values, before saving the document. 
 
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