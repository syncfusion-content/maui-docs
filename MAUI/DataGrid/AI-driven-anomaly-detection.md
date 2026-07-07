---
layout: post
title: AI-Driven anomaly detection in .NET MAUI DataGrid | Syncfusion
description: Learn here all about the AI-Driven anomaly detection feature of Syncfusion<sup>&reg;</sup> .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# AI-Driven Anomaly Detection in .NET MAUI DataGrid (SfDataGrid)

This document provides a comprehensive guide to implementing AI-driven anomaly detection with the Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html). It demonstrates how to integrate Azure OpenAI services to analyze dataset patterns and automatically highlight anomalies in real-time.

## Integrating Azure OpenAI with the .NET MAUI App

### Step 1: Set Up Azure OpenAI Service

First, open [Visual Studio](https://visualstudio.microsoft.com/) and [create a new .NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-7.0&tabs=vswin&pivots=devices-android).

**Configure Azure OpenAI:**

1. Log in to the [Azure Portal](https://portal.azure.com/)
2. Create a new OpenAI resource (or use an existing one)
3. Deploy a **GPT-4o** model (or GPT-4 Turbo) for text analysis
4. Copy your deployment name, endpoint URL, and API key from the **Keys and Endpoint** section

**Install NuGet Package:**

Run the following command in the Package Manager Console or terminal:

```
dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.12
```

Alternatively, use the NuGet Package Manager in Visual Studio to install the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/) package.

### Step 2: Create the Azure OpenAI service class

Create a helper class to manage communication with Azure OpenAI. **Important**: Store your API key securely using environment variables or Azure Key Vault, not hard coded strings.

{% tabs %}

{% highlight c# %}

using Azure;
using Azure.AI.OpenAI;
using System;
using System.Threading.Tasks;

internal class AzureOpenAIService
{
    const string endpoint = "https://{YOUR_END_POINT}.openai.azure.com";
    const string deploymentName = "GPT-4O";
    const string imageDeploymentName = "DALL-E";
    string key = "API key";
    
    OpenAIClient? client;
    ChatCompletionsOptions? chatCompletions;
    
    internal AzureOpenAIService()
    {
        
    }
}

{% endhighlight %}

{% endtabs %}

### Step 3: Initialize the OpenAI Client

To set up the connection to Azure OpenAI. Refer to the following code.

{% tabs %}

{% highlight c# %}

// At the time of required.
this.client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(key))

{% endhighlight %}

{% endtabs %}

This connection allows you to send prompts to the model and **receive responses**, which can be used to generates.

### Step 4: Implement the GetResultsFromAI Method

Implement a method to retrieve responses from the Azure OpenAI API based on user prompts.

{% tabs %}

{% highlight c# %}

using Azure;
using Azure.AI.OpenAI;
using System;
using System.Threading.Tasks;

public async Task<string> GetResultsFromAI(string userPrompt)
{
    if (this.Client != null && this.chatCompletions != null)
    {
        // Add the system message and user message to the options.
        this.chatCompletions.Messages.Add(new ChatRequestSystemMessage("You are a predictive analytics assistant."));
        this.chatCompletions.Messages.Add(new ChatRequestUserMessage(userPrompt));
        try
        {
            var response = await Client.GetChatCompletionsAsync(this.chatCompletions);
            return response.Value.Choices[0].Message.Content;
        }
        catch
        {
            return string.Empty;
        }
    }
    return string.Empty;
}

{% endhighlight %}

{% endtabs %}

## Integrating AI-Driven Anomaly Detection in .NET MAUI DataGrid

After completing the Azure OpenAI setup above, use the `.NET MAUI DataGrid` control to display data and visualize anomaly detection results. This section demonstrates how to style cells dynamically based on AI analysis and highlight outliers in real-time.

Before proceeding, review the [.NET MAUI DataGrid getting started guide](https://www.syncfusion.com/maui-controls/maui-datagrid).

### Step 1: Create the DataGrid Layout

{% tabs %}

{% highlight xaml %}
<ContentPage   xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
               xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
               x:Class="SampleBrowser.Maui.SmartDemos.SmartDemos.AnomalyDetection"
               xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">

    <ContentPage.BindingContext>
        <local:MachineDataRepository x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <local:AnomalyDetectionConverter x:Key="converter" />
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background"
                    Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}" />
            <Setter Property="FontSize" Value="14" />
        </Style>
        <Style TargetType="syncfusion:DataGridHeaderCell">
            <Setter Property="FontFamily" Value="Roboto-Medium" />
            <Setter Property="FontSize" Value="14" />
        </Style>
    </ContentPage.Resources>

    <ContentPage.Content>
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="56" />
                <RowDefinition Height="*" />
            </Grid.RowDefinitions>

            <Grid Grid.Row="0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto" />
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="Auto" />
                </Grid.ColumnDefinitions>
                <Label Text="Anomaly Detection"
                       VerticalTextAlignment="Center"
                       Padding="16,0,16,0"
                       FontSize="15"
                       Grid.Column="0"
                       FontAttributes="Bold" />

                <button:SfButton x:Name="button"
                                 Text="&#xe7e1;"
                                 FontFamily="MauiSampleFontIcon"
                                 Grid.Column="2"
                                 Margin="16,0,16,0"
                                 FontAutoScalingEnabled="True"
                                 FontSize="24"
                                 WidthRequest="40"
                                 HeightRequest="40"
                                 FontAttributes="Bold"
                                 CornerRadius="5" />
            </Grid>

            <syncfusion:SfDataGrid x:Name="dataGrid"
                                   Grid.Row="1"
                                   HeaderRowHeight="52"
                                   HorizontalScrollBarVisibility="Always"
                                   VerticalScrollBarVisibility="Always"
                                   ColumnWidthMode="Fill"
                                   AutoGenerateColumnsMode="None"
                                   ItemsSource="{Binding MachineDataCollection}">
                <syncfusion:SfDataGrid.Columns>
                    <syncfusion:DataGridTextColumn HeaderText="Machine ID" MinimumWidth="120" MappingName="MachineID" />
                    <syncfusion:DataGridTextColumn HeaderText="Temperature" MinimumWidth="120" MappingName="Temperature" />
                    <syncfusion:DataGridTextColumn HeaderText="Pressure" MinimumWidth="120" MappingName="Pressure" />
                    <syncfusion:DataGridTextColumn HeaderText="Voltage" MinimumWidth="120" MappingName="Voltage" />
                    <syncfusion:DataGridTextColumn HeaderText="Motor Speed" MinimumWidth="120" MappingName="MotorSpeed" />
                    <syncfusion:DataGridTextColumn HeaderText="Production Rate" MinimumWidth="140" MappingName="ProductionRate" />
                </syncfusion:SfDataGrid.Columns>
            </syncfusion:SfDataGrid>

            <ActivityIndicator IsRunning="False" x:Name="Indicator" Grid.Row="1" VerticalOptions="Center" HorizontalOptions="Center" Color="Black" />
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% endtabs %}

### Step 2: Enable AI-Powered .NET MAUI DataGrid

In your code-behind or ViewModel, create a method that sends the DataGrid data to Azure OpenAI for analysis. The AI service analyzes the dataset and returns anomaly detection results in JSON format, including the row index and anomaly status for each record. This data is then parsed and applied to the SfDataGrid by dynamically updating cell styles using the `AnomalyDetectionConverter` or by setting custom properties in the ViewModel.

{% tabs %}

{% highlight c# %}

private async Task GetAnomalyResponseAsync()
{

    try
    {
        var repo = this.datagrid.BindingContext as MachineDataRepository;
        if (repo == null || repo.MachineDataCollection == null || repo.MachineDataCollection.Count == 0)
            return;

        var gridReport = new GridReport
        {
            DataSource = repo.MachineDataCollection
        };

        var gridReportJson = GetSerializedGridReport(gridReport);

        string userInput = ValidateAndGeneratePrompt(gridReportJson);

        var result = await openAi.GetResponseFromOpenAI(userInput);

        if (string.IsNullOrWhiteSpace(result))
        {
            result = openAi.GetAnomalyDetectionResponse();
        }

        result = result.Replace("```json", "").Replace("```", "").Trim();

        GridReport? deserializeResult = DeserializeResult(result);

        if (deserializeResult?.DataSource != null && gridReport.DataSource != null)
        {

            string[] anomalies = deserializeResult.DataSource
                .Select(x => x.AnomalyDescription)
                .ToArray();

            var colorConverter = new AnomalyDetectionConverter();
            colorConverter.GetString(anomalies);

            var anomalyDescriptionColumn = new DataGridTextColumn() { HeaderText = "Anomaly Description", MappingName = "AnomalyDescription",ColumnWidthMode = ColumnWidthMode.Auto };

            this.datagrid?.Columns.Add(anomalyDescriptionColumn);

            if (gridReport.DataSource != null)
            {
                foreach (var item in gridReport.DataSource)
                {
                    if (generateDataAlone.Contains(item.MachineID))
                    {
                        index++;
                        item.AnomalyDescription = deserializeResult.DataSource[index].AnomalyDescription;
                    }
                }
            }
        }

        this.datagrid.Refresh();
    }
    finally
    {
        this.activityIndicator.IsRunning = false;
        isButtonClicked = false;
    }
}

{% endhighlight %}

{% endtabs %}

![AI driven Smart Anomaly Detection .NET MAUI DataGrid](Images/smart-ai-solutions/anamoly-detection.gif)

You can find the complete sample from this [link](https://github.com/SyncfusionExamples/MAUI-DataGrid-Features/tree/master/AI%20Demos/AnamolyDetection).
