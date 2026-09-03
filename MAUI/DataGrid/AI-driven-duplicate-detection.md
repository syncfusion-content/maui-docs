---
layout: post
title: AI-Driven Duplicate Detection in .NET MAUI DataGrid | Syncfusion
description: Learn how to integrate AI-driven duplicate detection with the Syncfusion® .NET MAUI DataGrid using Azure OpenAI to identify and highlight duplicate records.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# AI-Driven Duplicate Detection in .NET MAUI DataGrid

This document provides a comprehensive guide to implementing AI-driven duplicate detection with the Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html). It demonstrates how to integrate Azure OpenAI services to analyze customer records, identify exact and near-duplicate entries, and automatically highlight duplicate rows in real time.

## Integrating AI-Driven Duplicate Detection in .NET MAUI DataGrid

After completing the Azure OpenAI setup, use the `.NET MAUI DataGrid` control to display customer records and visualize duplicate detection results. The AI service analyzes customer information such as name, email, phone number, and address, then classifies potential duplicates as likely duplicates or possible duplicates. The results are displayed directly in the DataGrid with confidence scores and visual indicators.

Before proceeding, review the https://www.syncfusion.com/maui-controls/maui-datagrid.

### Step 1: Create the DataGrid Layout

Create an `SfDataGrid` and bind it to the customer collection. Configure columns to display customer information along with AI-generated duplicate detection results such as confidence score and duplicate status.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid Grid.Row="0"
                       x:Name="CustomerGrid"
                       ItemsSource="{Binding Customers}"
                       AutoGenerateColumnsMode="None"
                       AllowEditing="True"
                       SelectionMode="Single"
                       HeaderRowHeight="60"
                       RowHeight="60"
                       GridLinesVisibility="Horizontal"
                       HorizontalScrollBarVisibility="Always"
                       VerticalScrollBarVisibility="Never"
                       LostFocusBehavior="EndEditCurrentCell"
                       CurrentCellEndEdit="CustomerGrid_CurrentCellEndEdit"
                       BackgroundColor="White">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="Name"
                                       HeaderText="Name"
                                       ColumnWidthMode="Auto"/>
        <syncfusion:DataGridTextColumn MappingName="Email"
                                       HeaderText="Email"
                                       ColumnWidthMode="Auto"/>
        <syncfusion:DataGridTextColumn MappingName="Phone"
                                       HeaderText="Phone"
                                       ColumnWidthMode="Auto"/>
        <syncfusion:DataGridTextColumn MappingName="Address"
                                       HeaderText="Address"
                                       ColumnWidthMode="Auto"/>
        <syncfusion:DataGridTextColumn MappingName="Match"
                                       HeaderText="Match"
                                       ColumnWidthMode="Auto"/>
        <syncfusion:DataGridTemplateColumn MappingName="Status"
                                           HeaderText="Status"
                                           ColumnWidthMode="Auto">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                <DataTemplate x:DataType="models:Customer">
                    <Border BackgroundColor="{Binding Status, Converter={StaticResource StatusPillColor}}"
                            StrokeThickness="0"
                            StrokeShape="RoundRectangle 6"
                            Padding="8,3"
                            HorizontalOptions="Start"
                            VerticalOptions="Center">
                        <Label Text="{Binding Status}"
                               TextColor="{Binding Status, Converter={StaticResource StatusPillTextColor}}"
                               FontSize="12"
                               FontAttributes="Bold"/>
                    </Border>
                </DataTemplate>
            </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>
        <syncfusion:DataGridTemplateColumn HeaderText=""
                                           ColumnWidthMode="Auto"
                                           AllowEditing="False">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                <DataTemplate x:DataType="models:Customer">
                    <Button Text="&#xE70F;"
                            FontFamily="MaterialAssets"
                            Command="{Binding Source={RelativeSource AncestorType={x:Type local:ViewModel}}, Path=DeleteRowCommand}"
                            CommandParameter="{Binding .}"
                            BackgroundColor="Transparent"
                            TextColor="#94A3B8"
                            BorderWidth="0"
                            FontSize="14"
                            FontAttributes="Bold"
                            Padding="0"
                            WidthRequest="32"
                            HeightRequest="32"
                            CornerRadius="16"
                            HorizontalOptions="Center"
                            VerticalOptions="Center"/>
                </DataTemplate>
            </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>

{% endhighlight %}

{% endtabs %}

### Step 2: Enable AI-Powered Duplicate Detection

Create a method in the ViewModel that generates candidate record pairs and sends them to Azure OpenAI for analysis. The AI model evaluates record similarity and returns duplicate classifications along with confidence scores. The results are then applied to the `SfDataGrid`, where duplicate rows are highlighted and status information is updated.

{% tabs %}
{% highlight c# %}

private async Task IdentifyDuplicatesAsync()
{
    if (IsBusy)
        return;

    try
    {
        IsBusy = true;
        StatusMessage = "Building candidate pairs...";
        var pairs = _generator.BuildPairs(Customers);
        StatusMessage = $"Sending {pairs.Count} candidate pairs to Azure OpenAI...";
        var results = await _analyzer.AnalyzeAsync(pairs,CancellationToken.None);
        ApplyResults(results);
        StatusMessage = $"Done. {results.Count} candidate pairs analyzed.";
    }
    catch (Exception ex)
    {
        StatusMessage = "Error: " + ex.Message;
    }
    finally
    {
        IsBusy = false;
    }
}

{% endhighlight %}
{% endtabs %}

### Step 3: Display Duplicate Detection Results

After analysis, the duplicate detection results are applied to the customer records. Each record is assigned a confidence score and a duplicate classification. Rows are visually highlighted based on the detected duplicate severity:

- **Likely Duplicate** – Records with a high similarity score identified by Azure OpenAI.
- **Possible Duplicate** – Records with partial matches or shared identifying information.
- **Unique** – Records that do not match any other record.

The implementation also supports live duplicate detection. Whenever a user edits a row, Azure OpenAI re-evaluates the modified record against the remaining rows and immediately updates the duplicate status and highlighting.

### Step 4: Handle Duplicate Review and Cleanup

Users can review highlighted records and take corrective actions such as deleting redundant entries. When a duplicate row is removed, the remaining records are automatically re-evaluated to ensure stale duplicate indicators are cleared and only valid duplicate relationships remain visible.

![AI driven duplicate detection .NET MAUI DataGrid](Images\smart-ai-solutions\duplicate-detection-datagrid.gif)

You can find the complete sample from this [link](https://github.com/SyncfusionExamples/Duplicate-Detection-in-SfDataGrid-by-using-Azure-AI).