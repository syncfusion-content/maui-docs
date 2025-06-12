---
layout: post
title: Serialization and Deserialization in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about column serialization and deserialization support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui serialization and deserialization, maui serialization and deserialization
---

# Serialization and Deserialization in .NET MAUI DataGrid (SfDataGrid)

SfDataGrid allows you to serialize and deserialize the SfDataGrid settings using [DataContractSerializer]().

## Serialization

You can serialize the SfDataGrid by using [SfDataGrid.Serialize]() method which exports the current DataGrid control properties to an XML file.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    dataGrid.Serialize(file);
}
{% endhighlight %}

### Serialize as Stream

You can store the SfDataGrid settings as [Stream]() using [Serialize]() method by passing the stream.

{% highlight c# %}
string filePath = "DataGrid";
using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
{
    dataGrid.Serialize(stream);
}
{% endhighlight %}

## Serialization options

SfDataGrid serialization operation can be customized by passing [DataGridSerializationOptions]() instance as an argument to `Serialize` method.

### Serialize sorting

By default, SfDataGrid allows you to serialize the sorting operation. You can disable the sorting serialization by setting the [DataGridSerializationOptions.SerializeSorting]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeSorting = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}

### Serialize grouping

By default, SfDataGrid allows you to serialize the grouping operation. You can disable the grouping serialization by setting the [DataGridSerializationOptions.SerializeGrouping]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeGrouping = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}

### Serialize columns

By default, SfDataGrid allows you to serialize the columns manipulation operation. You can disable the columns serialization by setting the [DataGridSerializationOptions.SerializeColumns ]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeColumns = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}

### Serialize summaries

By default, SfDataGrid allows you to serialize the caption summary, group summary and table summary settings in SfDataGrid.

You can disable the summaries serialization by setting [DataGridSerializationOptions.SerializeCaptionSummary]() , [DataGridSerializationOptions.SerializeGroupSummaries]() , [DataGridSerializationOptions.SerializeTableSummaries]() properties to false.

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

### Serialize stacked headers

By default, SfDataGrid allows you to serialize the stack headers operation. You can disable the stack headers serialization by setting the [DataGridSerializationOptions.SerializeStackedHeaders]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeStackHeaders = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}

### Serialize Details View

By default, SfDataGrid allows you to serialize the DetailsViewDefinition. You can disable the DetailsViewDefinition serialization by setting the [DataGridSerializationOptions.SerializeDetailsViewDefinition]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeDetailsViewDefinition = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}

### Serialize unbound rows

By default, SfDataGrid allows you to serialize the unbound rows settings. You can disable the unbound rows serialization by setting the [DataGridSerializationOptions.SerializeUnBoundRows]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Create(localPath))
{
    DataGridSerializationOptions options = new DataGridSerializationOptions();
    options.SerializeUnboundRows  = false;
    dataGrid.Serialize(file, options);
}
{% endhighlight %}

## Deserialization

You can deserialize the SfDataGrid setting by using [SfDataGrid.Deserialize]() method which reconstructs the SfDataGrid based on the setting in the stored XML file.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    dataGrid.Deserialize(file);
}
{% endhighlight %}

### Deserialize from Stream

You can deserialize the SfDataGrid settings from [Stream]() using [Deserialize]() method.

{% highlight c# %}
FileStream fileStream = new FileStream("DataGrid", FileMode.Open);
dataGrid.Deserialize(fileStream);
{% endhighlight %}

## Deserialization options

Deserialization operation can be customized by passing [DataGridDeserializationOptions]() instance as an argument to `Deserialize` method.

### Deserialize sorting

By default, SfDataGrid allows you to deserialize the sorting operation. You can disable the sorting deserialization by setting the [DataGridDeserializationOptions.DeserializeSorting]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeSorting = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}

### Deserialize grouping

By default, SfDataGrid allows you to deserialize the grouping operation. You can disable the grouping deserialization by setting the [DataGridDeserializationOptions.DeserializeGrouping]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeGrouping = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}

### Deserialize columns

By default, SfDataGrid allows you to deserialize the columns manipulation operations. You can disable the columns deserialization by setting the [DataGridDeserializationOptions.DeserializeColumns]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeColumns = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}

### Deserialize summaries

By default, SfDataGrid allows you to deserialize the group summary, caption summary and table summary settings.

You can disable the summaries deserialization by setting [DataGridDeserializationOptions.DeserializeCaptionSummary]() , [DataGridDeserializationOptions.DeserializeGroupSummaries]() , [DataGridDeserializationOptions.DeserializeTableSummaries]() properties to false.

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

### Deserialize stacked headers

By default, SfDataGrid allows you to deserialize the stack headers. You can disable the stacked headers deserialization by setting the [DataGridDeserializationOptions.DeserializeStackedHeaders]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeStackedHeaders = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}

### Deserialize Details View

By default, SfDataGrid allows you to deserialize the DetailsViewDefinition. You can disable the DetailsViewDefinition deserialization by setting the [DataGridDeserializationOptions.DeserializeDetailsViewDefinition]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeDetailsViewDefinition = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}

### Deserialize unbound rows

By default, SfDataGrid allows you to deserialize the unbound rows settings. You can disable the unbound rows deserialization by setting the [DataGridDeserializationOptions.DeserializeUnBoundRows]() to false.

{% highlight c# %}
string localPath = Path.Combine(FileSystem.AppDataDirectory, "DataGrid.xml");
using (var file = File.Open(localPath, FileMode.Open))
{
    DataGridDeserializationOptions options = new DataGridDeserializationOptions();
    options.DeserializeUnBoundRows = false;
    dataGrid.Deserialize(file, options);
}
{% endhighlight %}

## Customizing Serialization and Deserialization Operations

SfDataGrid allows you to customize the serialization and deserialization operations by deriving [DataGridSerializationController]() class and override the necessary virtual methods.

### Serialize custom column

By default, the unknown(custom) column types are serialized as `DataGridTextColumn` type. If you want to serialize the custom column, you have to add custom column type into predefined types.

In the below code snippet, TextImageColumn is created.

{% highlight c# %}
public class TextImageColumn : DataGridColumn
{
    public TextImageColumn()
    {
        var cellType = typeof(DataGridColumn).GetRuntimeProperties().FirstOrDefault(property => property.Name == "CellType");
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
        {
            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString();
        }
    }
}
{% endhighlight %}

In the below code snippet, the TextImageColumn is defined in SfDataGrid.

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

To serialize the above TextImageColumn, follow the below steps.

1. Create a class derived from [SerializableDataGridColumn]() and define the custom column properties in `SerializableCustomGridColumn` class.

{% highlight c# %}
[DataContract(Name = "SerializableCustomGridColumn")]
public class SerializableCustomGridColumn : SerializableDataGridColumn
{
    [DataMember]
    public string TextMappingName { get; set; }
}
{% endhighlight %}

2. Create a new class named as SerializationControllerExt by overriding [DataGridSerializationController]() class.

{% highlight c# %}
dataGrid.SerializationController = new SerializationControllerExt(dataGrid);

public class SerializationControllerExt : DataGridSerializationController
{
    public SerializationControllerExt(SfDataGrid dataGrid) : base(dataGrid) 
    {
    }
}
{% endhighlight %}

3.  You can get the custom column property settings for serialization by overriding the GetSerializableColumn virtual method.

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

4. Store the custom column property settings during serialization by overriding the StoreColumnProperties virtual method.

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

5.  Add the custom column in to known column types by overriding the [KnownTypes]() virtual method.

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

6.  During deserialization, you can get the custom column settings from [SerializableDataGridColumn]() by overriding GetColumn virtual method.

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

7.  Now restore the custom column settings from SerializableDataGridColumn by overriding the [RestoreColumnProperties]() virtual method.

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

You can download the sample demo [here](https://github.com/SyncfusionExamples/How-to-Serialize-custom-column-in-.NET-MAUI-DataGrid-SfDataGrid/tree/master)

### Serializing template column content

By default, you cannot serialize the template content in SfDataGrid. This is the default behavior during Serialization and Deserialization operation.

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

If you want to serialize and deserialize the template content, you have to reconstruct the same template during deserialization in RestoreColumnProperties method.

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
            if (_pageResources.TryGetValue("cellTemplate", out var template) &&
                template is DataTemplate dataTemplate)
            {
                templateColumn.CellTemplate = dataTemplate;
            }
        }
    }
}
{% endhighlight %}

You can download the sample demo [here](https://github.com/SyncfusionExamples/How-to-Serialize-template-column-content-in-.NET-MAUI-DataGrid--SfDataGrid/tree/master)