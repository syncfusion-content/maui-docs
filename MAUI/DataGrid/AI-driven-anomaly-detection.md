---
layout: post
title: AI-Driven anomaly detection in .NET MAUI DataGrid | Syncfusion
description: Learn here all about the AI-Driven anomaly detection feature of Syncfusion<sup>&reg;</sup> .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# AI-Driven Anomaly Detection in .NET MAUI DataGrid (SfDataGrid)

This document provides a comprehensive guide to implementing AI-driven anomaly detection with the Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html). It uses the provided AnomalyDetection sample and integrates Azure OpenAI via the OpenAi helper service.

## Integrating Azure OpenAI with the .NET MAUI app

First, open [Visual Studio](https://visualstudio.microsoft.com/) and [create a new .NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-7.0&tabs=vswin&pivots=devices-android).

Before enabling AI, ensure that you have access to [Azure OpenAI](https://azure.microsoft.com/en-in/products/ai-services/openai-service) and have set up a deployment in the Azure portal. Install the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12) NuGet package in the project.

### Step 1: Set up Azure OpenAI

To configure **Azure OpenAI**, we’ll use the **GPT-4O** model for text. Set up the `OpenAIClient` as shown in the following code example.

{% tabs %}

{% highlight c# %}

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

### Step 2: Connect to the Azure OpenAI

To set up the connection to Azure OpenAI. Refer to the following code.

{% tabs %}

{% highlight c# %}

	// At the time of required.
    this.client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(key))

{% endhighlight %}

{% endtabs %}

This connection allows you to send prompts to the model and **receive responses**, which can be used to generates.

### Step 3: Get the result from the AI service

Implement the `GetResultsFromAI` methods to retrieve responses from the **OpenAI** API based on user input.

{% tabs %}

{% highlight c# %}

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

The **AzureOpenAIService** class now offers a convenient way to interact with the **OpenAI** API and retrieve completion results based on the provided **prompt**.

## Integrating AI-driven anomaly detection in .NET MAUI DataGrid

To design an AI-powered anomaly detection UI using the `.NET MAUI DataGrid` control, you can style cells dynamically based on anomaly detection logic and visualize outliers in real-time. Before proceeding, please refer to the getting started documentation for the Syncfusion .NET MAUI DataGrid control.

### Step 1: Create the DataGrid layout

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
        <local:AnomalyDetetcionConverter x:Key="converter" />
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

### Step 2: Enable AI-powered .NET MAUI DataGrid

Add the prompt that requests the AI service to analyze the bound dataset and return anomaly detection results in JSON format. The JSON response should include the row index and anomaly status for each record. This data is then parsed and applied to the SfDataGrid by dynamically updating cell styles using the AnomalyDetectionConverter or by setting custom properties in the ViewModel.

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
            result = openAi.GetAnomalyyDetectionResponse();
        }

        result = result.Replace("```json", "").Replace("```", "").Trim();

        GridReport? deserializeResult = DeserializeResult(result);

        if (deserializeResult?.DataSource != null && gridReport.DataSource != null)
        {

            string[] anomalies = deserializeResult.DataSource
                .Select(x => x.AnomalyDescription)
                .ToArray();

            var colorConverter = new AnomalyDetetcionConverter();
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
