--- 
layout: post
title: Anomaly Detection Sample in .NET MAUI DataGrid Control | Syncfusion®
description: Learn how to detect anomalies using AI in the Syncfusion® .NET MAUI DataGrid (SfDataGrid) control.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords: maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, anomaly detection, maui datagrid ai
---

# AI-Powered Anomaly Detection in .NET MAUI SfDataGrid

This sample demonstrates how to integrate AI-powered anomaly detection within the Syncfusion .NET MAUI [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control. It showcases a collection of machine metrics—such as temperature, pressure, voltage, motor speed, and production rate—and uses AI to identify anomalies directly within the grid.

The anomaly detection results are displayed in a new column titled **Anomaly Description**, which is dynamically added to the grid.

## How It Works

The AI analyzes the machine data and provides descriptive feedback on any detected anomalies. This feedback is shown inline in the DataGrid, making it easy to visualize and interpret the results.

## Steps to Run and Explore the Sample

1. **Download the Sample**
   Clone or download the [SampleBrowser.Maui.SmartComponents](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartComponents/SampleBrowser.Maui.SmartComponents) the solution in Visual Studio and run the project.

3. **Navigate to Smart Components**
   Click the `Smart Components` button on the home page.

4. **Open the Anomaly Detection Sample**
   Under the `DataGrid` category, select the **Anomaly Detection** sample.

5. **Trigger AI Analysis**
   Click the blinking **AI** button in the top-right corner to generate anomaly descriptions. The results will appear in the **Anomaly Description** column.

6. **Configure Azure AI Service**
   To enable live AI responses, configure the required Azure AI service credentials in the [`AzureBaseService`](https://github.com/syncfusion/maui-demos/blob/master/MAUI/SmartComponents/SampleBrowser.Maui.SmartComponents/Samples/SmartComponents/AzureBaseService/AzureBaseService.cs)