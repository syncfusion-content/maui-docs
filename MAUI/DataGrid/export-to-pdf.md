---
layout: post
title: Export to PDF in MAUI DataGrid control | Syncfusion®
description: Learn here all about PDF Exporting support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui export to pdf, maui export to pdf
---
# Export To PDF in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) offers comprehensive support for exporting data to PDF, providing a range of customization options to suit your specific needs. This feature allows you to personalize the exported PDF's appearance, exclude specific columns or headers, and even define custom row heights and column widths, among other possibilities.

To quickly get started with export to PDF in .NET MAUI DataGrid, watch this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/h8c_qnnG7iE'></iframe>

If you are utilizing a NuGet package to facilitate the process, please ensure that the following package is installed in order to export the SfDataGrid to a PDF file:

<table>
<tr>
<th> Project </th>
<th> Required package </th>
</tr>
<tr>
<td> .NET MAUI </td>
<td> Syncfusion.Maui.DataGridExport</td>
</tr>
</table>

## Save Service class in portable project.

Add the new class file with name as SaveService to the project and add below code in it. This is the helper class used and view the PDF file in windows, android, iOS and MAc devices.

{% tabs %}
{% highlight c# %}
namespace GettingStarted
{
  public partial class SaveService
  {
    //Method to save document as a file and view the saved document.
    public partial void SaveAndView(string filename, string contentType, MemoryStream stream);
  }
}
{% endhighlight %}
{% endtabs %}

### Save and View the PDF documents in windows

Add the new class file with name SaveWindows file under Project-> Platforms-> Windows directory to save and view the PDF document in the windows machine and use the below code in it.

{% tabs %}
{% highlight c# %}
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;

namespace GettingStarted
{
    public partial class SaveService
    {
        public async partial void SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            StorageFile stFile;
            string extension = Path.GetExtension(filename);
            //Gets process windows handle to open the dialog in application process. 
            IntPtr windowHandle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            if (!Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                //Creates file save picker to save a file. 
                FileSavePicker savePicker = new();
                if (extension == ".pdf")
                {
                    savePicker.DefaultFileExtension = ".pdf";
                    savePicker.SuggestedFileName = filename;
 
                    //Saves the file as Pdf file.
                    savePicker.FileTypeChoices.Add("PDF", new List<string>() { ".pdf" });
                }
                WinRT.Interop.InitializeWithWindow.Initialize(savePicker, windowHandle);
                stFile = await savePicker.PickSaveFileAsync();
            }
            else
            {
                StorageFolder local = ApplicationData.Current.LocalFolder;
                stFile = await local.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            }
            if (stFile != null)
            {
                using (IRandomAccessStream zipStream = await stFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    //Writes compressed data from memory to file.
                    using Stream outstream = zipStream.AsStreamForWrite();
                    outstream.SetLength(0);
                    //Saves the stream as file.
                    byte[] buffer = stream.ToArray();
                    outstream.Write(buffer, 0, buffer.Length);
                    outstream.Flush();
                }
                //Create message dialog box. 
                MessageDialog msgDialog = new("Do you want to view the document?", "File has been created successfully");
                UICommand yesCmd = new("Yes");
                msgDialog.Commands.Add(yesCmd);
                UICommand noCmd = new("No");
                msgDialog.Commands.Add(noCmd);

                WinRT.Interop.InitializeWithWindow.Initialize(msgDialog, windowHandle);

                //Showing a dialog box. 
                IUICommand cmd = await msgDialog.ShowAsync();
                if (cmd.Label == yesCmd.Label)
                {
                    //Launch the saved file. 
                    await Windows.System.Launcher.LaunchFileAsync(stFile);
                }
            }
        }
    }
}
{% endhighlight %}
{% endtabs %}


### Save and View the PDF document in Android

Add the new class file with name SaveAndroid file under Project-> Platforms-> Android directory to save and view the PDF document in the Android Device and use the below in it.

{% tabs %}
{% highlight c# %}
using Android.Content;
using Android.OS;
using Java.IO;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GettingStarted
{
    public partial class SaveService
    {
        public partial void SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            string exception = string.Empty;
            string? root = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            Java.IO.File myDir = new(root + "/Syncfusion");
            myDir.Mkdir();

            Java.IO.File file = new(myDir, filename);

            if (file.Exists())
            {
                file.Delete();
            }

            try
            {
                FileOutputStream outs = new(file);
                outs.Write(stream.ToArray());

                outs.Flush();
                outs.Close();
            }
            catch (Exception e)
            {
                exception = e.ToString();
            }
            if (file.Exists())
            {

                if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.N)
                {
                    var fileUri = AndroidX.Core.Content.FileProvider.GetUriForFile(Android.App.Application.Context, Android.App.Application.Context.PackageName + ".provider", file);
                    var intent = new Intent(Intent.ActionView);
                    intent.SetData(fileUri);
                    intent.AddFlags(ActivityFlags.NewTask);
                    intent.AddFlags(ActivityFlags.GrantReadUriPermission);
                    Android.App.Application.Context.StartActivity(intent);
                }
                else
                {
                    var fileUri = Android.Net.Uri.Parse(file.AbsolutePath);
                    var intent = new Intent(Intent.ActionView);
                    intent.SetDataAndType(fileUri, contentType);
                    intent = Intent.CreateChooser(intent, "Open File");
                    intent!.AddFlags(ActivityFlags.NewTask);
                    Android.App.Application.Context.StartActivity(intent);
                }

            }
        }
    }
}
{% endhighlight %}
{% endtabs %}

Create a new XML file with the name of provider_path.xml under the Resources-> xml folder of Android project and add the following code in it. Eg: Resources/xml/provider_path.xml

{% tabs %}
{% highlight XAML %}
<?xml version="1.0" encoding="UTF-8" ?>
<paths xmlns:android="http://schemas.android.com/apk/res/android">
   <external-path name="external_files" path="."/>
</paths>
{% endhighlight %}
{% endtabs %}

Add the following code to the AndroidManifest.xml file located under Properties folder.

{% tabs %}
{% highlight XAML %}
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android">
	<application android:allowBackup="true" android:icon="@mipmap/appicon" android:roundIcon="@mipmap/appicon_round" android:supportsRtl="true">
		<provider
        android:name="androidx.core.content.FileProvider"
        android:authorities="${applicationId}.provider"
        android:exported="false"
        android:grantUriPermissions="true">
			<meta-data
				android:name="android.support.FILE_PROVIDER_PATHS"
				android:resource="@xml/file_paths" />
		</provider>
	</application>
	<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
	<uses-permission android:name="android.permission.INTERNET" />
</manifest>
{% endhighlight %}
{% endtabs %}

### Save and View the PDF document in iOS

Add the new class file with name SaveIOS file under Platform-> iOS directory to save and view the PDF document in the iOS device and use the below code in it.

{% tabs %}
{% highlight c# %}
using QuickLook;
using System;
using System.IO;
using System.Threading.Tasks;
using UIKit;

namespace GettingStarted
{
    public partial class SaveService
    {
        public partial void SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            string exception = string.Empty;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filePath = Path.Combine(path, filename);
            try
            {
                FileStream fileStream = File.Open(filePath, FileMode.Create);
                stream.Position = 0;
                stream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
            catch (Exception e)
            {
                exception = e.ToString();
            }
            if (contentType != "application/html" || exception == string.Empty)
            {
                //Added this code to resolve the warning thrown when CI compiles.
                UIViewController? currentController = UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().SelectMany(scene => scene.Windows).FirstOrDefault(window => window.IsKeyWindow)!.RootViewController;
                while (currentController!.PresentedViewController != null)
                    currentController = currentController.PresentedViewController;

                QLPreviewController qlPreview = new();
                QLPreviewItem item = new QLPreviewItemBundle(filename, filePath);
                qlPreview.DataSource = new PreviewControllerDS(item);
                currentController.PresentViewController((UIViewController)qlPreview, true, null);
            }
        }
    }
    public class QLPreviewItemFileSystem : QLPreviewItem
    {
        readonly string _fileName, _filePath;

        public QLPreviewItemFileSystem(string fileName, string filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }

        public override string PreviewItemTitle
        {
            get
            {
                return _fileName;
            }
        }
        public override NSUrl PreviewItemUrl
        {
            get
            {
                return NSUrl.FromFilename(_filePath);
            }
        }
    }

    public class QLPreviewItemBundle : QLPreviewItem
    {
        readonly string _fileName, _filePath;
        public QLPreviewItemBundle(string fileName, string filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }

        public override string PreviewItemTitle
        {
            get
            {
                return _fileName;
            }
        }
        public override NSUrl PreviewItemUrl
        {
            get
            {
                var documents = NSBundle.MainBundle.BundlePath;
                var lib = Path.Combine(documents, _filePath);
                var url = NSUrl.FromFilename(lib);
                return url;
            }
        }
    }


    public class PreviewControllerDS : QLPreviewControllerDataSource
    {
        private readonly QLPreviewItem _item;

        public PreviewControllerDS(QLPreviewItem item)
        {
            _item = item;
        }

        public override nint PreviewItemCount(QLPreviewController controller)
        {
            return (nint)1;
        }

        public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
        {
            return _item;
        }
    }
}
{% endhighlight %}
{% endtabs %}

### Save and View the PDF document in MacCatalyst

Add the new class file with name SaveMAC file under Platforms-> MacCatalyst directory to save and view the PDF document in the MAC Device and use the below code in it.

{% tabs %}
{% highlight c# %}
using Foundation;
using QuickLook;
using System;
using System.IO;
using System.Threading.Tasks;
using UIKit;

namespace GettingStarted
{
    public partial class SaveService
    {
        public partial void SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, filename);
            stream.Position = 0;
            //Saves the document
            using FileStream fileStream = new(filePath, FileMode.Create, FileAccess.ReadWrite);
            stream.CopyTo(fileStream);
            fileStream.Flush();
            fileStream.Dispose();
            //Launch the file
            //Added this code to resolve the warning thrown when CI compiles.
            UIViewController? currentController = UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().SelectMany(scene => scene.Windows).FirstOrDefault(window => window.IsKeyWindow)!.RootViewController;
            while (currentController!.PresentedViewController != null)
                currentController = currentController.PresentedViewController;
            UIView? currentView = currentController.View;

            QLPreviewController qlPreview = new();
            QLPreviewItem item = new QLPreviewItemBundle(filename, filePath);
            qlPreview.DataSource = new PreviewControllerDS(item);
            currentController.PresentViewController((UIViewController)qlPreview, true, null);
        }
    }
}
public class QLPreviewItemFileSystem : QLPreviewItem
{
    readonly string _fileName, _filePath;

    public QLPreviewItemFileSystem(string fileName, string filePath)
    {
        _fileName = fileName;
        _filePath = filePath;
    }

    public override string PreviewItemTitle
    {
        get
        {
            return _fileName;
        }
    }
    public override NSUrl PreviewItemUrl
    {
        get
        {
            return NSUrl.FromFilename(_filePath);
        }
    }
}

public class QLPreviewItemBundle : QLPreviewItem
{
    readonly string _fileName, _filePath;
    public QLPreviewItemBundle(string fileName, string filePath)
    {
        _fileName = fileName;
        _filePath = filePath;
    }

    public override string PreviewItemTitle
    {
        get
        {
            return _fileName;
        }
    }
    public override NSUrl PreviewItemUrl
    {
        get
        {
            var documents = NSBundle.MainBundle.BundlePath;
            var lib = Path.Combine(documents, _filePath);
            var url = NSUrl.FromFilename(lib);
            return url;
        }
    }
}

public class PreviewControllerDS : QLPreviewControllerDataSource
{
    private readonly QLPreviewItem _item;

    public PreviewControllerDS(QLPreviewItem item)
    {
        _item = item;
    }

    public override nint PreviewItemCount(QLPreviewController controller)
    {
        return (nint)1;
    }

    public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
    {
        return _item;
    }
}
{% endhighlight %}
{% endtabs %}

You can export the SfDataGrid to PDF by using the extension methods provided in the Syncfusion.Maui.DataGrid.Exporting namespace.

* `ExportToPdf`
* `ExportToPdfGrid`

The following code illustrates how to create and display a SfDataGrid in view.

{% tabs %}
{% highlight xaml %}
<StackLayout>
    <Button Text="Export" Clicked="ExportToPDF_Clicked"/>
    <syncfusion:SfDataGrid  x:Name="dataGrid"
                            AutoGenerateColumnsMode="None"
                            VerticalOptions="FillAndExpand"
                            ColumnWidthMode="Auto"
                            ItemsSource="{Binding OrderInfoCollection}" >
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID" Format="d"/>
            <syncfusion:DataGridTextColumn MappingName="CustomerID" HeaderText="Customer ID"/>
            <syncfusion:DataGridTextColumn MappingName="Customer" HeaderText="Customer"/>
            <syncfusion:DataGridTextColumn MappingName="ShipCountry" HeaderText="Ship Country"/>
            <syncfusion:DataGridTextColumn MappingName="ShipCity" HeaderText="Ship City"/>
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
</StackLayout>
{% endhighlight %}
{% endtabs %}

## ExportToPdf

To export the data to PDF, you can use the [DataGridPdfExportingController.ExportToPdf](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingController.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingController_ExportToPdf_Syncfusion_Maui_DataGrid_SfDataGrid_) method, which requires passing the SfDataGrid as an argument.

{% tabs %}
{% highlight c# %}

private void ExportToPDF_Clicked(object sender, EventArgs e)
{
    MemoryStream stream = new MemoryStream();
    DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
    DataGridPdfExportingOption option = new DataGridPdfExportingOption();
    var pdfDoc = new PdfDocument();
    pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
    pdfDoc.Save(stream);
    pdfDoc.Close(true);
    SaveService saveService = new();
    saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
}

{% endhighlight %}
{% endtabs %}

## ExportToPdfGrid

To export the data to PDF, you can also use the [DataGridPdfExportingController.ExportToPdfGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingController.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingController_ExportToPdfGrid_Syncfusion_Maui_DataGrid_SfDataGrid_Syncfusion_Maui_Data_ICollectionViewAdv_Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_Syncfusion_Pdf_PdfDocument_) method, which requires passing the SfDataGrid as an argument.

{% tabs %}
{% highlight c# %}
private void ExportToPDF_Clicked(object sender, EventArgs e)
{
    DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
    MemoryStream stream = new MemoryStream();
    var pdfDoc = new PdfDocument();
    PdfPage page = pdfDoc.Pages.Add();
    var exportToPdfGrid = pdfExport.ExportToPdfGrid(this.dataGrid, this.dataGrid.View, new DataGridPdfExportingOption()
    {
        CanFitAllColumnsInOnePage = false,

    }, pdfDoc);
    exportToPdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));
    pdfDoc.Save(stream);
    pdfDoc.Close(true);
    SaveService saveService = new();
    saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
}
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format" src="Images\export-to-pdf\maui-datagrid-export-datagrid-to-pdf.png" width="689"/>

N> SfDataGrid cannot export the DataGridTemplateColumn to PDF or Excel due to the inability to access the loaded views and accurately capture their content and layout in a specific range and value from the DataGridTemplateColumn.

## Exporting options

### Exclude columns when exporting

By default, all columns, including hidden columns, are exported to PDF in the SfDataGrid. If you want to exclude specific columns during PDF export, you can add those columns to the [DataGridPdfExportingOption.ExcludeColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_ExcludeColumns) list.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
var list = new List<string>();
list.Add("OrderID");
list.Add("CustomerID");
option.ExcludedColumns = list;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with certain columns excluded" src="Images\export-to-pdf\maui-datagrid-exclude-columns.png" width="689"/>


### Obtaining a PDF document

The [DataGridPdfExportingOption.PdfDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_PdfDocument) enables the export of the SfDataGrid to either an existing or a new PDF document.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
PdfDocument pdfDocument = new PdfDocument();
pdfDocument.Pages.Add();
pdfDocument.Pages.Add();
pdfDocument.Pages.Add();
option.StartPageIndex = 1;
option.PdfDocument = pdfDocument;
{% endhighlight %}
{% endtabs %}

### Obtaining columns for customization

By utilizing the property `Columns`, you can retrieve or modify the `System.Collections.IEnumerable columns` collection, which includes all the columns intended for export. Any columns listed in the ExcludedColumns List will not be included in the Columns collection.

### Column header on each page

To display or conceal the column headers on every page of the exported PDF document, you can use the [DataGridPdfExportingOption.CanRepeatHeaders](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanRepeatHeaders) property. By default, its value is set to true.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanRepeatHeaders = true;
{% endhighlight %}
{% endtabs %}


### Customize header, stacked header, groups, table summary and unbound row when exporting

#### Export groups

By default, all the groups in the data grid will be exported to PDF document. To export the data grid without groups, set the [DataGridPdfExportingOption.CanExportGroups](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportGroups) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportGroups = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid with groups to PDF format" src="Images\export-to-pdf\maui-datagrid-export-groups.png" width="689"/>


#### Exclude column header while exporting

By default, the column headers will be exported to PDF document. To export the SfDataGrid without the column headers, set the [DataGridPdfExportingOption.CanExportHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportHeader) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportHeader = false;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format without column header cells" src="Images\export-to-pdf\maui-datagrid-exclude-header.png" width="689"/>

#### Export stacked header 

By default, the column headers will not be exported to PDF document. To export the SfDataGrid with the column headers, set the [DataGridPdfExportingOption.CanExportStackedHeaders](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportStackedHeaders) property to `true`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportStackedHeaders = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format without column header cells" src="Images\export-to-pdf\maui-datagrid-stacked-header.png" width="689"/>

#### Export table summaries 

By default, table summaries in the data grid will be exported to PDF. To export the SfDataGrid without table summaries, set the [DataGridPdfExportingOption.CanExportTableSummary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportTableSummary) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportTableSummary = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with table summary rows" src="Images\export-to-pdf\maui-datagrid-export-table-summary.png" width="689"/>

#### Export group summaries 

By default, the GroupSummary rows in the data grid will be exported to PDF. To export the `SfDataGrid` without group summaries, set the [DataGridPdfExportingOption.CanExportGroupSummary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportGroupSummary) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportGroupSummary = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with group summaries" src="Images\export-to-pdf\maui-datagrid-export-group-summary.png" width="689"/>

#### Export unbound row 

By default, the unbound rows in the data grid will not be exported to PDF. To export the `SfDataGrid` with unbound rows, set the [DataGridPdfExportingOption.CanExportUnboundRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportUnboundRows) property to `true`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportUnboundRow = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with unbound row" src="Images\export-to-pdf\maui-datagrid-unbound-row.png" width="689"/>

#### Exporting the selected rows of SfDataGrid

The SfDataGrid allows you to export only the currently selected rows in the grid to a document using the `DataGridPdfExportingController.ExportToPdf` method. To achieve this, you need to pass the instance of the SfDataGrid and the [SfDataGrid.SelectedRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRowsProperty) collection as arguments to the method.

Please refer to the code below for exporting only the selected rows to a PDF document:

{% tabs %}
{% highlight c# %}
ObservableCollection<object> selectedItems = dataGrid.SelectedRows;
var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, selectedItems);
{% endhighlight %}
{% endtabs %}

### Export all columns in one page

Gets or sets a value indicating whether all the columns should be fitted on a page. To export all the columns in one page, set the [DataGridPdfExportingOption.CanFitAllColumnsInOnePage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanFitAllColumnsInOnePage) property to `true`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanFitAllColumnsInOnePage = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with all columns fit in view" src="Images\export-to-pdf\maui-datagrid-fit-all-columns-in-one-page.png" width="689"/>


### Exporting the grid from a specified page and point

The SfDataGrid allows exporting data to a specific starting position on a particular PDF page using the following options:

* StartPageIndex
* StartPoint 

#### StartPageIndex 

The SfDataGrid allows you to export data to a specific page in a PDF document by using the [DataGridPdfExportingOption.StartPageIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_StartPageIndex) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.StartPageIndex = 2;
{% endhighlight %}
{% endtabs %}

#### StartPoint

The SfDataGrid allows exporting data to a specific starting point (x, y coordinates) on a PDF page using the [DataGridPdfExportingOption.StartPoint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_StartPoint) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.StartPoint = new Syncfusion.Drawing.PointF(0, 500);
{% endhighlight %}
{% endtabs %}


### Applying styles while exporting

The SfDataGrid allows exporting data with the applied `DefaultStyle` by setting the [DataGridPdfExportingOption.CanApplyGridStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanApplyGridStyle) property to `true`. By default, the data will be exported without the `DefaultStyle`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanApplyGridStyle = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with style applied" src="Images\export-to-pdf\maui-datagrid-export-with-defaultstyle.png" width="689"/>

The SfDataGrid also allows exporting the data with alternate row color by setting [AlternateRowBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_AlternateRowBackground) in `SfDataGrid.DefaultStyle` and [DataGridPdfExportingOption.CanApplyGridStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanApplyGridStyle) property to `true`.

<img alt="Export DataGrid to PDF format with alternate row background applied" src="Images\export-to-pdf\maui-datagrid-alternate-row-background.png" width="689"/>

You can customize the following styles when exporting to PDF as well:

* HeaderStyle
* RecordStyle 
* TopTableSummaryStyle
* BottomTableSummaryStyle 
* GroupCaptionStyle
* GroupSummaryStyle

#### HeaderStyle

The SfDataGrid allows exporting the column headers with custom style by using the [DataGridPdfExportingOption.HeaderStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_HeaderStyle) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.HeaderStyle = new PdfGridCellStyle()
{
    BackgroundBrush = PdfBrushes.Yellow,
    Borders = new PdfBorders() { Bottom = PdfPens.Aqua, Left = PdfPens.AliceBlue, Right = PdfPens.Red, Top = PdfPens.RoyalBlue },
    CellPadding = new PdfPaddings(2, 2, 2, 2),
    TextBrush = PdfBrushes.Red,
    TextPen = PdfPens.Green,
    StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Right, CharacterSpacing = 3f, WordSpacing = 10f }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with style applied for header cells" src="Images\export-to-pdf\maui-datagrid-header-style.png" width="689"/>

#### RecordStyle 

The SfDataGrid allows exporting the records with custom style by using the [DataGridPdfExportingOption.RecordStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_RecordStyle) property.


{% tabs %}
{% highlight c# %}
 DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.RecordStyle = new PdfGridCellStyle()
{
    BackgroundBrush = PdfBrushes.Red,
    Borders = new PdfBorders() { Bottom = PdfPens.Aqua, Left = PdfPens.AliceBlue, Right = PdfPens.Red, Top = PdfPens.RoyalBlue },
    CellPadding = new PdfPaddings(2, 2, 2, 2),
    TextBrush = PdfBrushes.White,
    TextPen = PdfPens.Green,
    StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Right, CharacterSpacing = 3f, WordSpacing = 10f }
};
{% endhighlight %}
{% endtabs %}

#### TopTableSummaryStyle

The SfDataGrid supports exporting the top table summary with custom style by using the [DataGridPdfExportingOption.TopTableSummaryStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_TopTableSummaryStyle) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
 option.TopTableSummaryStyle = new PdfGridCellStyle()
{
    BackgroundBrush = PdfBrushes.Gray,
    Borders = new PdfBorders() { Bottom = PdfPens.AliceBlue, Left = PdfPens.AliceBlue, Right = PdfPens.AliceBlue, Top = PdfPens.AliceBlue },
    CellPadding = new PdfPaddings(5,5,5,5),
    TextBrush = PdfBrushes.White,
    TextPen = PdfPens.White,
    StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Center, CharacterSpacing = 3f, WordSpacing = 10f }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with style applied for table summary rows at the Top" src="Images\export-to-pdf\maui-datagrid-top-table-summary-style.png" width="689"/>

#### BottomTableSummaryStyle

The SfDataGrid supports exporting the bottom table summary with custom style by using the [DataGridPdfExportingOption.BottomTableSummaryStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_BottomTableSummaryStyle) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.BottomTableSummaryStyle = new PdfGridCellStyle()
{
    BackgroundBrush = PdfBrushes.Gray,
    Borders = new PdfBorders() { Bottom = PdfPens.AliceBlue, Left = PdfPens.AliceBlue, Right = PdfPens.AliceBlue, Top = PdfPens.AliceBlue },
    CellPadding = new PdfPaddings(5,5,5,5),
    TextBrush = PdfBrushes.White,
    TextPen = PdfPens.White,
    StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.    Center, CharacterSpacing = 3f, WordSpacing = 10f }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with style applied for table summary rows at the bottom" src="Images\export-to-pdf\maui-datagrid-bottom-table-summary-style.png" width="689"/>



#### GroupCaptionStyle

The SfDataGrid supports exporting the group caption summaries with custom style by using the [DataGridPdfExportingOption.GroupCaptionStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_GroupCaptionStyle) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.GroupCaptionStyle = new PdfGridCellStyle()
{
    BackgroundBrush = PdfBrushes.Gray,
    Borders = new PdfBorders() { Bottom = PdfPens.AliceBlue, Left = PdfPens.AliceBlue, Right = PdfPens.AliceBlue, Top = PdfPens.AliceBlue },
    CellPadding = new PdfPaddings(5,5,5,5),
    TextBrush = PdfBrushes.White,
    TextPen = PdfPens.White,
    StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Center, CharacterSpacing = 10f, WordSpacing = 10f }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with style applied for group caption style" src="Images\export-to-pdf\maui-datagrid-group-caption-style.png" width="689"/>

#### GroupSummaryStyle 

`SfDataGrid` supports exporting the `GroupSummary` rows with custom style by using the [DataGridPdfExportingOption.GroupSummaryStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_GroupSummaryStyle) property.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.GroupSummaryStyle = new PdfGridCellStyle()
{
    BackgroundBrush = PdfBrushes.Green,
    TextBrush = PdfBrushes.Yellow,
    TextPen = PdfPens.White,
    StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Right, CharacterSpacing = 3f, WordSpacing = 10f }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with style applied for table summary rows at the Top" src="Images\export-to-pdf\maui-datagrid-group-summary-style.png" width="689"/>

### Customizing borders

The SfDataGrid provides the ability to customize grid borders by utilizing the [DataGridPdfExportingOption.GridLineType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_GridLineType) property.

* Both
* Horizontal
* Vertical
* None

#### Both

Set the `DataGridPdfExportingOption.GridLineType` as `GridLineType.Both` to export the data grid with both horizontal and vertical borders.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.GridLineType = GridLineType.Both;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with both vertical and horizontal borders" src="Images\export-to-pdf\maui-datagrid-gridlinetype-both.png" width="689"/>

#### Horizontal

Set the `DataGridPdfExportingOption.GridLineType` as `GridLineType.Horizontal` to export the data grid with horizontal border.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.GridLineType = GridLineType.Horizontal;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with horizonatal border lines alone" src="Images\export-to-pdf\maui-datagrid-gridlinetype-horizontal.png" width="689"/>

#### Vertical

Set the `DataGridPdfExportingOption.GridLineType` to `GridLineType.Vertical` to export the data grid with vertical border.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.GridLineType = GridLineType.Vertical;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with vertical border lines alone" src="Images\export-to-pdf\maui-datagrid-gridlinetype-vertical.png" width="689"/>

#### None

Set the `DataGridPdfExportingOption.GridLineType` to `GridLineType.None` to export the data grid without borders.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.GridLineType = GridLineType.None;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format without border lines" src="Images\export-to-pdf\maui-datagrid-gridlinetype-none.png" width="689"/>

## Setting header and footer

The SfDataGrid offers a way to include additional content at the top (header) or bottom (footer) of the page when exporting to PDF. This can be achieved by handling the [DataGridPdfExportingController.HeaderAndFooterExporting](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingController.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingController_HeaderAndFooterExporting) event.

To insert a string in the header or footer, you need to use the `PdfHeaderFooterEventHandler`. By setting the `PdfPageTemplateElement` as `PdfHeaderFooterEventArgs.PdfDocumentTemplate.Top`, you can load the content at the top of the page. Similarly, setting the `PdfPageTemplateElement` as `PdfHeaderFooterEventArgs.PdfDocumentTemplate.Bottom` will load the content at the bottom of the page.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
pdfExport.HeaderAndFooterExporting += PdfExport_HeaderAndFooterExporting;
private void PdfExport_HeaderAndFooterExporting(object sender, DataGridPdfHeaderFooterEventArgs e)
{
    PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20f, PdfFontStyle.Bold);
    var width = e.PdfPage.GetClientSize().Width;
    PdfPageTemplateElement header = new PdfPageTemplateElement(width, 38);
    header.Graphics.DrawString("Order Details", font, PdfPens.Black, 70, 3);
    e.PdfDocumentTemplate.Top = header;

    PdfPageTemplateElement footer = new PdfPageTemplateElement(width, 38);
    footer.Graphics.DrawString("Order Details", font, PdfPens.Black, 70, 3);
    e.PdfDocumentTemplate.Bottom = footer;
}
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with header and footer" src="Images\export-to-pdf\maui-datagrid-header-footer-event.png" width="689"/>

## Change PDF page orientation

You have the option to change the page orientation of a PDF document during the export process. The default page orientation is `portrait`.

To modify the page orientation, you can export the PDF grid value using the ExportToPdfGrid method. Afterwards, you can draw the PDF grid into a PDF document by adjusting the `PageSettings.Orientation` property of the PDF document.

{% tabs %}
{% highlight c# %}
var pdfDoc = new PdfDocument();
option.PdfDocument = pdfDoc;
pdfDoc.PageSettings.Orientation = PdfPageOrientation.Landscape;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format in Landscape orientation" src="Images\export-to-pdf\maui-datagrid-orientation.png" width="689"/>

## Row height and column width customization

### ExportColumnWidth

By default, the columns of the data grid will be exported to PDF using the [DataGridPdfExportingOption.DefaultColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_DefaultColumnWidth) value. If you want to export the data grid to PDF with precise column widths, you can set the `[DataGridPdfExportingOption.CanExportColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportColumnWidth) to true.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportColumnWidth = true;
{% endhighlight %}
{% endtabs %}

### ExportRowHeight

By default, the data grid rows will be exported to PDF using the [DataGridPdfExportingOption.DefaultRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_DefaultRowHeight) value. If you want to export the data grid to PDF with the exact row heights, you can set the `DataGridPdfExportingOption.CanExportRowHeight` to `true`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportRowHeight = true;
{% endhighlight %}
{% endtabs %}

### DefaultColumnWidth

The SfDataGrid allows customizing column width in the PDF document using the `DataGridPdfExportingOption.DefaultColumnWidth` property. The `DefaultColumnWidth` value will be applied to all the columns in the document.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.DefaultColumnWidth = 150;
option.CanExportColumnWidth = false;
{% endhighlight %}
{% endtabs %}

### DefaultRowHeight

The SfDataGrid allows customizing row height in the PDF document using the `DataGridPdfExportingOption.DefaultRowHeight` property. The `DefaultRowHeight` value will be applied to all the rows in the document.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.DefaultRowHeight = 80;
option.CanExportRowHeight = true;
{% endhighlight %}
{% endtabs %}

## Events

The SfDataGrid provides the following events for exporting:

* `RowExporting` : This event is raised when exporting a row during execution.
* `CellExporting` : This event is raised when exporting a cell during execution.

### RowExporting

The `DataGridRowPdfExportingEventHandler` delegate allows for customizing the styles of record rows and group caption rows. The RowExporting event is triggered with [DataGridRowPdfExportingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridRowPdfExportingEventArgs.html), which contains the following properties:

* [PdfGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridRowPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridRowPdfExportingEventArgs_PdfGrid): Customizes the properties of the pdfGrid, such as `Background`, `CellPadding`, `CellSpacing`, and more.
* [PdfRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridRowPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridRowPdfExportingEventArgs_PdfRow): Specifies the `PDFGridRow` to be exported and allows customization of the properties of a particular row.
* [Record](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridRowPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridRowPdfExportingEventArgs_Record): Retrieves the collection of exported underlying data objects.
* [RowType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridRowPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridRowPdfExportingEventArgs_RowType): Specifies the row type using the `ExportRowType` enum. It checks the row type and applies different styles based on the type.

You can use this event to customize the properties of the grid rows that are exported to PDF. The following code example demonstrates how to change the background color of the record rows and caption summary rows during the export process.

{% tabs %}
{% highlight c# %}
pdfExport.RowExporting += pdfExport_RowExporting; 
void pdfExport_RowExporting (object sender, DataGridRowPdfExportingEventArgs e)
{
    if (e.RowType == ExportRowType.Record) {
        if ((e.Record.Data as OrderInfo).IsClosed)
            e.PdfRow.Style.BackgroundBrush = PdfBrushes.Yellow;
        else
        e.PdfRow.Style.BackgroundBrush = PdfBrushes.LightGreen;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Customize the grid rows while exporting using the RowExporting event" src="Images\export-to-pdf\maui-datagrid-row-exporting.png" width="689"/>

### CellExporting

The `DataGridCellPdfExportingEventHandler` delegate allows for customizing the styles of header cells, record cells, and group caption cells. The CellExporting event is triggered with [DataGridCellPdfExportingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html), which contains the following properties:

* [CellType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_CellType): Specifies the cell type using the `ExportCellType` enum. It checks the cell type and applies different cell styles based on the type.

* [CellValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_CellType): Contains the actual exported value used to format the PDF using the `Range` property.

* [ColumnName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_ColumnName): Specifies the column name (MappingName) of the exporting cell. It applies formatting for a particular column by checking the `ColumnName`.

* [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_Handled): Determines whether the cell is exported to PDF or not.

* [PdfGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_PdfGridCell): Specifies the `PDFGridCell` to be exported. It customizes properties such as `Background`, `Foreground`, `Font`, `Alignment`, etc., for a particular cell.

* [Record](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_Record):  Retrieves the collection of underlying data objects being exported.

You can use this event to customize the properties of grid cells that are exported to PDF. The code example below demonstrates how to customize the background color, Text color, and cell value of header cells, record cells, and caption summary cells during the export process.

{% tabs %}
{% highlight c# %}
pdfExport.CellExporting += pdfExport_CellExporting;  
void pdfExport_CellExporting(object sender, DataGridCellPdfExportingEventArgs e)
{
    if (e.CellType == ExportCellType.HeaderCell)
    {
        e.PdfGridCell.Style.BackgroundBrush = PdfBrushes.Navy;
        e.PdfGridCell.Style.TextBrush = PdfBrushes.White;
        
    }

    if (e.CellType == ExportCellType.RecordCell)
    {
        e.PdfGridCell.Style.BackgroundBrush = PdfBrushes.LightBlue;
        e.PdfGridCell.Style.TextBrush = PdfBrushes.Black;
    }        
}
{% endhighlight %}
{% endtabs %}

<img alt="Customize the cells in a DataGrid while exporting using the CellExporting event" src="Images\export-to-pdf\maui-datagrid-cell-exporting.png" width="689"/>

## Cell customization

### Customize the cells based on column name

You can customize the record cell style in a specific column based on the column name when exporting to PDF by handling the `CellExporting` event.

{% tabs %}
{% highlight c# %}
pdfExport.CellExporting += PdfExport_CellExporting;
private void PdfExport_CellExporting(object sender, DataGridCellPdfExportingEventArgs e)
{
    if (e.CellType == ExportCellType.RecordCell && e.ColumnName == "OrderID")
    {
        e.PdfGridCell.Style.TextBrush = PdfBrushes.LightBlue;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to PDF format with customized cell style" src="Images\export-to-pdf\maui-datagrid-style-based-on-column-name.png" width="689"/>

## Exporting DetailsView

By default, [DetailsViewDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DetailsViewDataGrid.html) will not be exported to PDF. You can export `DetailsViewDataGrid` by setting [CanExportDetailsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportDetailsView) property as true.

```csharp
MemoryStream stream = new MemoryStream();
DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportDetailsView = true;
var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
pdfDoc.Save(stream);
pdfDoc.Close(true);
SaveService saveService = new();
saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
```
<img src="Images\export-to-pdf\maui-datagrid-exportdetailsview.png" alt="Maui DataGrid displays Nested dataGrid exported to PDF" width="404"/>

By default, only expanded DetailsViewDataGrids will be exported to the PDF document. If you want to export all the DetailsViewDataGrids, you need to set [CanExportAllDetails](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanExportAllDetails) to true.

```csharp
MemoryStream stream = new MemoryStream();
DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
option.CanExportDetailsView = true;
option.CanExportAllDetails = true;
var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
pdfDoc.Save(stream);
pdfDoc.Close(true);
SaveService saveService = new();
saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
```
<img src="Images\export-to-pdf\maui-datagrid-exportalldetails.png" alt="Nested dataGrid exported to PDF" width="404"/>

Here, first record only expanded in SfDataGrid. But all the DetailsViewDataGrid’s are shown in exported PDF document.

You can customize its exporting operation by using [DataGridChildPdfExportingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridChildPdfExportingEventArgs.html).

N> While exporting DetailsViewDataGrid, [CanFitAllColumnInOnePage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridPdfExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridPdfExportingOption_CanFitAllColumnsInOnePage) is set to true internally as horizontal pagination is not supported for DetailsViewDataGrid.

### Excluding DetailsViewDataGrid while exporting

You can exclude particular DetailsViewDataGrid while exporting, by using the `DataGridChildPdfExportingEventArgs.Cancel`.

```csharp
private void Button_Clicked(object sender, EventArgs e)
{
    MemoryStream stream = new MemoryStream();
    DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
    DataGridPdfExportingOption option = new DataGridPdfExportingOption();
    pdfExport.DataGridChildPdfExporting += PdfExport_DataGridChildPdfExporting;
    option.CanExportDetailsView = true;
    var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
    pdfDoc.Save(stream);
    pdfDoc.Close(true);
    SaveService saveService = new();
    saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
}

private void PdfExport_DataGridChildPdfExporting(object? sender, DataGridChildPdfExportingEventArgs e)
{
    var recordEntry = e.NodeEntry as RecordEntry;

    if ((recordEntry?.Data as Orders)?.OrderID == 1002)
        e.Cancel = true;
}
```
<img alt="Excluding specific DetailsView while exporting to PDF in DataGrid " src="Images/export-to-pdf/maui-datagrid-excluderows.png" Width="404"/>

Here, `DetailsViewDataGrid` is not exported for the parent record having OrderID as 1002.

### Customizing DetailsViewDataGrid cells

Similar to the parent DataGrid, you can also customize the cells of the DetailsViewDataGrid by using the DataGridCellPdfExportingEventArgs. By utilizing the [DataGridCellPdfExportingEventArgs.DetailsViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellPdfExportingEventArgs.html#Syncfusion_Maui_DataGrid_Exporting_DataGridCellPdfExportingEventArgs_DetailsViewDefinition) property, you can identify the specific DetailsViewDataGrid and customize it accordingly.

```csharp
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        MemoryStream stream = new MemoryStream();
        DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
        DataGridPdfExportingOption option = new DataGridPdfExportingOption();
        pdfExport.DataGridChildPdfExporting += PdfExport_DataGridChildPdfExporting;
        pdfExport.CellExporting += PdfExport_CellExporting;
        option.CanExportDetailsView = true;
        var pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
        pdfDoc.Save(stream);
        pdfDoc.Close(true);
        SaveService saveService = new();
        saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
    }

    private void PdfExport_CellExporting(object? sender, DataGridCellPdfExportingEventArgs e)
    {
        if (e.DetailsViewDefinition == null && e.DetailsViewDefinition?.RelationalColumn != "OrdersList")
        {
            return;
        }

        if (e.ColumnName == "OrderID")
        {
            var cellStyle = new PdfGridCellStyle();
            cellStyle.BackgroundBrush = PdfBrushes.Wheat;
            cellStyle.Borders.All = new PdfPen(PdfBrushes.DarkGray, 0.2f);
            e.PdfGridCell.Style = cellStyle;
        }
    }
```
<img alt="Customizing DetailsViewDataGrid while exporting to PDF in DataGrid" src="Images/export-to-pdf/maui-datagrid-customize-detailsview.png" Width="404"/>