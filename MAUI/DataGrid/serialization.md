---
layout: post
title: Serialization and Deserialization in MAUI DataGrid | Syncfusion®
description: Learn all about column serialization and deserialization support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui serialization and deserialization, maui serialization and deserialization
---

# Serialization and Deserialization in .NET MAUI DataGrid (SfDataGrid)

SfDataGrid allows you to serialize and deserialize the SfDataGrid settings using [DataContractSerializer](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractserializer?view=net-9.0&redirectedfrom=MSDN).

By default, SfDataGrid serializes the following properties: column configurations, sorting, grouping, caption summaries, group summaries, table summaries, stacked headers, DetailsViewDefinition, and unbound rows. You can customize which features are serialized/deserialized using serialization options.

## Serialization

You can serialize the SfDataGrid by using [SfDataGrid.Serialize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Serialize_System_IO_Stream_) method which exports the current DataGrid control properties to an XML file.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    dataGrid.Serialize(file);
}
{% endhighlight %}
{% endtabs %}

### Serialize as stream

You can store the SfDataGrid settings as [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-9.0) using [Serialize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Serialize_System_IO_Stream_Syncfusion_Maui_DataGrid_DataGridSerializationOptions_) method by passing the stream.

{% tabs %}
{% highlight c# %}
string filePath = "DataGrid";
using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
{
    dataGrid.Serialize(stream);
}
{% endhighlight %}
{% endtabs %}

## Serialization options

SfDataGrid serialization can be customized by passing a [DataGridSerializationOptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html) instance to the `Serialize` method. By default, all options are enabled. Disable specific options to exclude certain grid features from serialization.

### Serialize sorting

Disable sorting serialization by setting [DataGridSerializationOptions.SerializeSorting](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeSorting) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeSorting = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Serialize grouping

Disable grouping serialization by setting [DataGridSerializationOptions.SerializeGrouping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeGrouping) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeGrouping = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Serialize columns

Disable column manipulation serialization by setting [DataGridSerializationOptions.SerializeColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeColumns) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeColumns = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Serialize summaries

Disable caption, group, or table summary serialization by setting [DataGridSerializationOptions.SerializeCaptionSummary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeCaptionSummary), [DataGridSerializationOptions.SerializeGroupSummaries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeGroupSummaries), or [DataGridSerializationOptions.SerializeTableSummaries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeTableSummaries) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeCaptionSummary = false;
    options.SerializeGroupSummaries = false;
    options.SerializeTableSummaries = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Serialize stacked headers

Disable stacked headers serialization by setting [DataGridSerializationOptions.SerializeStackedHeaders](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeStackedHeaders) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeStackedHeaders = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Serialize Details View

Disable DetailsViewDefinition serialization by setting [DataGridSerializationOptions.SerializeDetailsViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeDetailsViewDefinition) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeDetailsViewDefinition = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Serialize unbound rows

Disable unbound rows serialization by setting [DataGridSerializationOptions.SerializeUnboundRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationOptions.html#Syncfusion_Maui_DataGrid_DataGridSerializationOptions_SerializeUnboundRows) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeUnboundRows  = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}
{% endtabs %}

## Deserialization

You can deserialize the SfDataGrid by using [SfDataGrid.Deserialize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Deserialize_System_IO_Stream_) method to reconstruct the grid based on settings stored in an XML file.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    dataGrid.Deserialize(file);
}
{% endhighlight %}
{% endtabs %}

### Deserialize from stream

You can deserialize the SfDataGrid settings from [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-9.0) using [Deserialize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Deserialize_System_IO_Stream_Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_) method.

{% tabs %}
{% highlight c# %}
FileStream fileStream = new FileStream("DataGrid", FileMode.Open);
dataGrid.Deserialize(fileStream);
{% endhighlight %}
{% endtabs %}

## Deserialization options

Deserialization can be customized by passing a [DataGridDeserializationOptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html) instance to the `Deserialize` method. By default, all options are enabled. Disable specific options to skip restoring certain grid features.

### Deserialize sorting

Disable sorting restoration by setting [DataGridDeserializationOptions.DeserializeSorting](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeSorting) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeSorting = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Deserialize grouping

Disable grouping restoration by setting [DataGridDeserializationOptions.DeserializeGrouping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeGrouping) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeGrouping = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Deserialize columns

Disable column manipulation restoration by setting [DataGridDeserializationOptions.DeserializeColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeColumns) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeColumns = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Deserialize summaries

Disable caption, group, or table summary restoration by setting [DataGridDeserializationOptions.DeserializeCaptionSummary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeCaptionSummary), [DataGridDeserializationOptions.DeserializeGroupSummaries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeGroupSummaries), or [DataGridDeserializationOptions.DeserializeTableSummaries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeTableSummaries) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeCaptionSummary = false;
    options.DeserializeGroupSummaries = false;
    options.DeserializeTableSummaries = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Deserialize stacked headers

Disable stacked headers restoration by setting [DataGridDeserializationOptions.DeserializeStackedHeaders](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeStackedHeaders) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeStackedHeaders = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Deserialize DetailsViewDefinition

Disable DetailsViewDefinition restoration by setting [DataGridDeserializationOptions.DeserializeDetailsViewDefinition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeDetailsViewDefinition) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeDetailsViewDefinition = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

### Deserialize unbound rows

Disable unbound rows restoration by setting [DataGridDeserializationOptions.DeserializeUnboundRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDeserializationOptions.html#Syncfusion_Maui_DataGrid_DataGridDeserializationOptions_DeserializeUnboundRows) to `false`.

{% tabs %}
{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeUnBoundRows = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}
{% endtabs %}

## Customizing Serialization and Deserialization Operations

SfDataGrid allows you to customize the serialization and deserialization operations by deriving [DataGridSerializationController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationController.html) class and override the necessary virtual methods.

### Serialize custom column

By default, unknown column types are serialized as [DataGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextColumn.html). To serialize custom columns, register them in the serialization controller.

In the below code snippet, `TextImageColumn` is created.

{% tabs %}
{% highlight c# %}
public class TextImageColumn : DataGridColumn
{
    public TextImageColumn()
    {
        var cellType = typeof(DataGridColumn).GetRuntimeProperties()
            .FirstOrDefault(property => property.Name == "CellType");
        cellType?.SetValue(this, "TextImage");
    }

    protected override void SetConverterForDisplayBinding()
    {
        base.SetConverterForDisplayBinding();
        if (DisplayBinding is Binding binding)
        {
            binding.Converter = new CustomTextConverter();
        }
    }

    public class CustomTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
            => value?.ToString();

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
            => value?.ToString();
    }
}
{% endhighlight %}
{% endtabs %}

In the below code snippet, the `TextImageColumn` is defined in SfDataGrid.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        AutoGenerateColumnsMode="None"
                        GridLinesVisibility="Both"
                        HeaderGridLinesVisibility="Both"
                        ItemsSource="{Binding Employees}">
        <syncfusion:SfDataGrid.Columns>
            <local:TextImageColumn HeaderText="Title" 
                                   MappingName="Title" />
        </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

To serialize the above `TextImageColumn`, follow the below steps.

**Step 1:** Create a class derived from [SerializableDataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SerializableDataGridColumn.html) and define the custom column properties in `SerializableCustomGridColumn` class.

{% tabs %}
{% highlight c# %}
[DataContract(Name = "SerializableCustomGridColumn")]
public class SerializableCustomGridColumn : SerializableDataGridColumn
{
    [DataMember]
    public string TextMappingName { get; set; }
}
{% endhighlight %}
{% endtabs %}

**Step 2:** Create a new class named as `SerializationControllerExt` by overriding [DataGridSerializationController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationController.html) class.

{% tabs %}
{% highlight c# %}
dataGrid.SerializationController = new SerializationControllerExt(dataGrid);

public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) 
    {
    }
}
{% endhighlight %}
{% endtabs %}

**Step 3:** You can get the custom column property settings for serialization by overriding the GetSerializableColumn virtual method.

{% tabs %}
{% highlight c# %}
public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) { }

    protected override SerializableDataGridColumn GetSerializableColumn(DataGridColumn column)
    {
        if (column is TextImageColumn)
        {
            return new SerializableCustomGridColumn();
        }
        return base.GetSerializableColumn(column);
    }
}
{% endhighlight %}
{% endtabs %}

**Step 4:** Store the custom column property settings during serialization by overriding the StoreColumnProperties virtual method.

{% tabs %}
{% highlight c# %}
public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) 
    {
    }

    protected override void StoreColumnProperties(DataGridColumn column, SerializableDataGridColumn serializableColumn)
    {
        base.StoreColumnProperties(column, serializableColumn);

        if (column is TextImageColumn textImageColumn && serializableColumn is SerializableCustomGridColumn customColumn)
        {
            customColumn.TextMappingName = textImageColumn.MappingName;
        }
    }
}
{% endhighlight %}
{% endtabs %}

**Step 5:** Add the custom column in to known column types by overriding the [KnownTypes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SerializableDataGridColumn.html#Syncfusion_Maui_DataGrid_SerializableDataGridColumn_KnownTypes) virtual method.

{% tabs %}
{% highlight c# %}
public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) 
    {
    }

    public override Type[] KnownTypes()
    {
        var types = base.KnownTypes().ToList();
        types.Add(typeof(SerializableCustomGridColumn));
        return types.ToArray();
    }
}
{% endhighlight %}
{% endtabs %}

**Step 6:** During deserialization, you can get the custom column settings from [SerializableDataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SerializableDataGridColumn.html) by overriding GetColumn virtual method.

{% tabs %}
{% highlight c# %}
public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) 
    {
    }

    protected override DataGridColumn GetColumn(SerializableDataGridColumn serializableColumn)
    {
        if (serializableColumn is SerializableCustomGridColumn)
        {
            return new TextImageColumn();
        }
        return base.GetColumn(serializableColumn);
    }
}
{% endhighlight %}
{% endtabs %}

**Step 7:** Now restore the custom column settings from SerializableDataGridColumn by overriding the [RestoreColumnProperties](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSerializationController.html#Syncfusion_Maui_DataGrid_DataGridSerializationController_RestoreColumnProperties_Syncfusion_Maui_DataGrid_SerializableDataGridColumn_Syncfusion_Maui_DataGrid_DataGridColumn_) virtual method.

{% tabs %}
{% highlight c# %}
public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) 
    {
    }

    protected override void RestoreColumnProperties(SerializableDataGridColumn serializableColumn, DataGridColumn column)
    {
        base.RestoreColumnProperties(serializableColumn, column);

        if (column is TextImageColumn textImageColumn && serializableColumn is SerializableCustomGridColumn customColumn)
        {
            textImageColumn.MappingName = customColumn.TextMappingName;
        }
    }
}
{% endhighlight %}
{% endtabs %}

You can download the sample demo [here](https://github.com/SyncfusionExamples/How-to-Serialize-custom-column-in-.NET-MAUI-DataGrid-SfDataGrid/tree/master)

### Serializing template column content

By default, you cannot serialize the template content in SfDataGrid because templates are XAML objects that cannot be serialized to XML. This limitation applies to DataTemplate, ControlTemplate, and other dynamic UI definitions. To work around this, you must reconstruct the templates during deserialization from stored resources or code-defined templates.

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="cellTemplate">
                <Button Text="Test" />
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <syncfusion:SfDataGrid x:Name="dataGrid"
                        AutoGenerateColumnsMode="None"
                        GridLinesVisibility="Both"
                        HeaderGridLinesVisibility="Both"
                        ItemsSource="{Binding Employees}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridTemplateColumn MappingName="Name"
                                                HeaderText="Name"
                                                CellTemplate="{StaticResource cellTemplate}" />
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

If you want to serialize and deserialize the template content, you have to reconstruct the same template during deserialization in `RestoreColumnProperties` method.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.SerializationController = new SerializationControllerExt(this.dataGrid,Resources);
        this.dataGrid1.SerializationController = new SerializationControllerExt(this.dataGrid1,Resources);
    }
}

public class SerializationControllerExt : DataGridSerializationController
{

    private readonly ResourceDictionary _pageResources;

    public SerializationControllerExt(SfDataGrid grid, ResourceDictionary pageResources)
        : base(grid)
    {
        _pageResources = pageResources;
    }

    protected override void RestoreColumnProperties(SerializableDataGridColumn serializableColumn, DataGridColumn column)
    {
        base.RestoreColumnProperties(serializableColumn, column);

        if (column is DataGridTemplateColumn templateColumn &&
            string.Equals(templateColumn.MappingName, "Name", StringComparison.Ordinal))
        {
            if (_pageResources != null && 
                _pageResources.TryGetValue("cellTemplate", out var template) &&
                template is DataTemplate dataTemplate)
            {
                templateColumn.CellTemplate = dataTemplate;
            }
        }
    }
}
{% endhighlight %}
{% endtabs %}

You can download the template serialization sample [here](https://github.com/SyncfusionExamples/How-to-Serialize-template-column-content-in-.NET-MAUI-DataGrid--SfDataGrid/tree/master) to see a complete working example.