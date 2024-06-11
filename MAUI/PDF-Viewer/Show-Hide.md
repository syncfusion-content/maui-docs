---
layout: post
title: Show and Hide annotations in .NET MAUI PDF Viewer | Syncfusion
description: Learn here about showing and hiding annotations in a document in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---
# Show and Hide annotations in .NET MAUI PDF Viewer (SfPdfViewer)
 
You can manage the visibility of annotations using the `Hidden` property. It helps you to hide annotations containing confidential data when sharing documents externally or presenting documents, ensuring data privacy and security. Also, it makes it easier to read the documents which are cluttered with more annotations. Like other annotation properties, you can undo and redo the hiding or showing actions. Additionally, when an annotation is locked, it cannot be hidden. Annotations that are hidden will remain hidden during import, export, printing and saving.

## Hide annotations

To hide annotations in the document, set the `Hidden` property of the annotations to `true`.

### Hide all annotations 

While reviewing and presenting documents, all annotations can be hidden to improve the focus on the content and to avoid distraction caused by cluttered annotations. The following example explains how to hide all annotations in a PDF document. 

{% tabs %}
{% highlight xaml %}
<Grid> 
    <Grid.RowDefinitions> 
        <RowDefinition Height="Auto" /> 
        <RowDefinition Height="*" /> 
    </Grid.RowDefinitions> 
    <Button Text="HideAllAnnotations" Clicked="HideAllAnnotationButton_Clicked" VerticalOptions="Center" HorizontalOptions="Center" Grid.Row="0"/> 
    <syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}" Grid.Row="1" /> 
</Grid> 
{% endhighlight %}

{% highlight C# %}
private void HideAllAnnotationsButton_Clicked(object sender, EventArgs e) 
{ 
    ReadOnlyObservableCollection<Annotation> annotations=PdfViewer.Annotations; 
    foreach(Annotation annotation in annotations) 
    { 
        annotation.Hidden = true; 
    } 
} 
{% endhighlight %}
{% endtabs %}

* Similarly, to show all the annotations, set the Hidden property value to `false`.

### Hide specific annotation 

While collaborating, the `Hidden` property of annotations can be used to show and hide annotations from specific authors. The following example illustrates how to hide annotations from a specific author by accessing the annotation's 'Hidden' property. 

{% tabs %}
{% highlight xaml %}
<Grid> 
    <Grid.RowDefinitions> 
        <RowDefinition Height="Auto" /> 
        <RowDefinition Height="*" /> 
    </Grid.RowDefinitions> 
    <Button Text="HideAnnotation" Clicked="HideAnnotationButton_Clicked" VerticalOptions="Center" HorizontalOptions="Center" Grid.Row="0"/> 
    <syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}" Grid.Row="1" /> 
</Grid> 
{% endhighlight %}

{% highlight C# %}
private void HideAnnotationButton_Clicked(object sender, EventArgs e) 
{ 
  ReadOnlyObservableCollection<Annotation> annotationList = PdfViewer.Annotations; 
  foreach (Annotation annotation in annotationList) 
  { 
     if (annotation.Author == "John") 
        { 
            annotation.Hidden = true; 
        } 
  }            
}
{% endhighlight %}
{% endtabs %}

* Similarly, to show the annotation, set the `Hidden` property value to `false`. 

## Note:
* On iOS and Mac, while printing a document containing hidden annotations, the hidden annotations will be visible in the print preview or the printed document. 
* When a document containing hidden annotations is loaded, it will not only disappear in the UI but will not be added to the [SfPdfViewer.Annotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_Annotations) collection as well. 