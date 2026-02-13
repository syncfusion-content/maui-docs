---
layout: post
title: AI-Driven predictive data entry in .NET MAUI DataGrid | Syncfusion
description: Learn here all about the AI-Driven predictive data entry feature of Syncfusion<sup>&reg;</sup> .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# AI-Driven Predictive Data Entry in .NET MAUI DataGrid (SfDataGrid)

This document explains how to implement AI-assisted predictive data entry with the Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html). Azure OpenAI is used to generate predicted GPA values and grades.

## Integrating Azure OpenAI with the .NET MAUI app

First, open [Visual Studio](https://visualstudio.microsoft.com/) and [create a new .NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-7.0&tabs=vswin&pivots=devices-android).

Ensure that you have access to [Azure OpenAI](https://azure.microsoft.com/en-in/products/ai-services/openai-service) and have set up a deployment in the Azure portal. Install the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12) NuGet package in the project.

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

This connection allows you to send prompts to the model and **receive responses**, which can then be used to generate outputs.

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

## Integrating AI-driven predictive data entry in .NET MAUI DataGrid

To design an AI-powered predictive data entry experience using the Syncfusion .NET MAUI DataGrid control, you can leverage AI services to suggest or auto-fill values based on historical patterns and user input. Before proceeding, please refer to the getting started documentation for the Syncfusion .NET MAUI DataGrid control.

### Step 1: Create the DataGrid layout

{% tabs %}

{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="SampleBrowser.Maui.SmartDemos.SmartDemos.DataPrediction"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">

    <ContentPage.BindingContext>
        <local:GenerateDataCollection x:Name="generateDataCollection" />
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <local:DataPredictionConverter x:Key="converter" />
        <Style TargetType="syncfusion:DataGridCell">
            <Setter Property="Background" Value="{Binding Source={RelativeSource Mode=Self}, Converter={StaticResource Key=converter}}" />
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

            <Grid Grid.Row="0" >
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto" />
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="Auto" />
                </Grid.ColumnDefinitions>
                <Label Text="Predictive Data Entry" VerticalTextAlignment="Center" Padding="16,0,16,0" FontSize="15" Grid.Column="0" FontAttributes="Bold" />

                <button:SfButton x:Name="button"
                                 Text="&#xe7e1;"
                                 FontFamily="MauiSampleFontIcon"
                                 Grid.Column="2"
                                 FontAutoScalingEnabled="True"
                                 FontSize="24"
                                 Margin="16,0,16,0"
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
                                   ItemsSource="{Binding Predictivedatas}">
                <syncfusion:SfDataGrid.Columns>
                    <syncfusion:DataGridTextColumn MinimumWidth="90" HeaderText="ID" MappingName="StudentID" />
                    <syncfusion:DataGridTextColumn MinimumWidth="130" HeaderText="Name" MappingName="StudentName" />
                    <syncfusion:DataGridNumericColumn MinimumWidth="125" HeaderText="First Year GPA" MappingName="FirstYearGPA" />
                    <syncfusion:DataGridNumericColumn MinimumWidth="145" HeaderText="Second Year GPA" MappingName="SecondYearGPA" />
                    <syncfusion:DataGridNumericColumn MinimumWidth="130" HeaderText="Third Year GPA" MappingName="ThirdYearGPA" />
                </syncfusion:SfDataGrid.Columns>
            </syncfusion:SfDataGrid>

            <ActivityIndicator IsRunning="False" x:Name="Indicator" Grid.Row="1" VerticalOptions="Center" HorizontalOptions="Center" />
        </Grid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}

{% endtabs %}

### Step 2: Enable AI-powered .NET MAUI DataGrid

After deserializing the AI service’s JSON response, dynamically add the Final Year GPA, CGPA, and Total Grade columns to the SfDataGrid, then populate each row with the predicted values.

{% tabs %}

{% highlight c# %}

private async Task GetResponseAsync()
{
    try
    {
        string prompt =
            "Final year GPA column should be updated based on GPA of FirstYearGPA, SecondYearGPA and ThirdYearGPA columns. " +
            "Total GPA (CGPA) should be updated based on the average of all years GPA. " +
            "Total Grade should be updated based on total GPA. " +
            "Updated grade rules: 0 - 2.5 = F, 2.6 - 2.9 = C, 3.0 - 3.4 = B, 3.5 - 3.9 = B+, 4.0 - 4.4 = A, 4.5 - 5 = A+. " +
            "Average value decimals should not exceed 1 digit. " +
            "Return JSON ONLY, no explanation. " +
            "Schema: { \"GenerateDataSource\": [ { \"StudentID\": \"string\", \"FinalYearGPA\": number, \"TotalGPA\": number, \"TotalGrade\": \"string\" } ] }. " +
            "Remove ```json and ``` if they are present.";

        var repo = (this.datagrid.BindingContext as GenerateDataCollection);
        if (repo == null || repo.Predictivedatas == null || repo.Predictivedatas.Count == 0)
            return;

        GenerateGridReport gridReport = new GenerateGridReport()
        {
            GenerateDataSource = repo.Predictivedatas
        };

        var gridReportJson = GetSerializedGridReport(gridReport);
        string userInput = ValidateAndGeneratePrompt(gridReportJson, prompt);

        var result = await openAi.GetResponseFromOpenAI(userInput);

        result = result.Replace("```json", "").Replace("```", "").Trim();

        GenerateGridReport deserializeResult = DeserializeResult(result);

        if (deserializeResult?.GenerateDataSource != null && gridReport.GenerateDataSource != null)
        {
            foreach (var item in gridReport.GenerateDataSource)
            {
                if (item != null)
                {
                    if (item.StudentID == gridReport.GenerateDataSource[index].StudentID)
                    {
                        if (deserializeResult != null && deserializeResult.GenerateDataSource != null)
                        {
                            gridReport.GenerateDataSource[index].FinalYearGPA = deserializeResult.GenerateDataSource[index].FinalYearGPA;
                            gridReport.GenerateDataSource[index].TotalGrade = deserializeResult.GenerateDataSource[index].TotalGrade;
                            gridReport.GenerateDataSource[index].TotalGPA = deserializeResult.GenerateDataSource[index].TotalGPA;
                        }
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
