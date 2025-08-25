---
layout: post
title: AI-powered Smart .NET MAUI Dataform for Data Entry | Syncfusion®
description: This guide explores how to build an AI powered smart data entry in .NET MAUI SfDataForm by integrating Azure OpenAI.

platform: maui
control: SfDataForm
documentation: ug
---

# AI-powered Smart .NET MAUI Dataform for Data Entry

This guide explains how to implement AI-powered smart data forms in a .NET MAUI application using Syncfusion® DataForm and AIAssistView controls. These forms automatically generate fields, validate input, and guide users interactively using AI logic from Azure OpenAI Services.

## Integrating Azure OpenAI with the .NET MAUI app

### Step 1: Set Up the .NET MAUI Project

Create a .NET MAUI project in Visual Studio and install the following NuGet packages: `Syncfusion.Maui.DataForm`,  `Syncfusion.Maui.AIAssistView`, `Azure.AI.OpenAI`, `Microsoft.Extensions.AI.OpenAI` and `Azure.Identity` from [NuGet Gallery](https://www.nuget.org/)

### Step 2: Set up Azure OpenAI

To enable AI functionality in your .NET MAUI DataForm, you need to set up Azure OpenAI. This service allows your application to process natural language prompts and generate intelligent responses for scheduling tasks.

Start by creating an Azure OpenAI resource in the Azure portal. Once the resource is created, deploy a model such as GPT-35 model, which will be used to interpret user input. Assign a deployment name to the model, which you’ll reference in your application code.

Next, retrieve the API key and endpoint URL from the resource settings. These credentials are required to authenticate and communicate with the OpenAI service from your app.

### Step 3: Connect to the Azure OpenAI
To connect your .NET MAUI app to Azure OpenAI, create a service class that handles communication with the AI model. Start by initializing the OpenAIClient using your Azure endpoint and API key.

In this service, define a method called **GetAnswerFromGPT**. This method takes a user prompt as input, sends it to the deployed model, and returns the AI-generated response. 

```
internal class DataFormAIService : AzureBaseService
{
    /// <summary>
    /// Retrieves an answer from the deployment name model using the provided user prompt.
    /// </summary>
    /// <param name="userPrompt">The user prompt.</param>
    /// <returns>The AI response.</returns>
    internal async Task<string> GetAnswerFromGPT(string userPrompt)
    {
        ChatHistory = string.Empty;
        if (IsCredentialValid && Client != null && ChatHistory != null)
        {
            // Add the user's prompt as a user message to the conversation.
            ChatHistory = ChatHistory + "You are a predictive analytics assistant.";
            // Add the user's prompt as a user message to the conversation.
            ChatHistory = ChatHistory + userPrompt;
            try
            {
                //// Send the chat completion request to the OpenAI API and await the response.
                var response = await Client.CompleteAsync(ChatHistory);
                return response.ToString();
            }
            catch
            {
                // If an exception occurs (e.g., network issues, API errors), return an empty string.
                return "";
            }
        }

        return "";
    }
}
```

## Integrating AI-powered smart DataForm Generation in .NET MAUI DataForm

### Step 1: Designing the User Interface

####  Editor and Button - Capturing the User Prompt

The first step in designing the user interface for AI-powered smart data forms is to provide a way for users to describe the form they want to generate. This is accomplished using a combination of an Editor and a Button. The Editor serves as a multi-line text input field where users can type natural language prompts. This prompt is then sent to Azure OpenAI for processing. The Button acts as a trigger for this action. When clicked, it initiates the backend logic that sends the prompt to the AI service, receives the response, and begins the process of generating the form. 

```
                <VerticalStackLayout Margin="20" VerticalOptions="Center" HorizontalOptions="Center">
                    <Label x:Name="describeLabel" 
                   Text="Create AI-Powered Smart Forms in .NET MAUI for Efficient Productivity."
                   LineBreakMode="WordWrap" FontSize="Small" FontAttributes="Bold" />
                    <Grid ColumnDefinitions="0.7*,0.3*" Margin="10" ColumnSpacing="5">
                        
                            <Editor AutoSize="TextChanges" x:Name="entry" 
                            PlaceholderColor="Gray" 
                            VerticalOptions="Center" 
                            HorizontalOptions="Fill" 
                            Placeholder="Create your own data form" />
                        <Button x:Name="createButton" 
                        Grid.Column="1" CornerRadius="10" 
                        HeightRequest="35" Text="&#xe784;"  
                        FontSize="Small"
                        FontFamily="MauiMaterialAssets" 
                        VerticalOptions="Center" HorizontalOptions="Start" />
                    </Grid>
                </VerticalStackLayout>
```

#### Busy Indicator - Enhancing Visual Feedback During Form Generation
The Busy Indicator (SfBusyIndicator) provides visual feedback to users while the application is performing background operations, such as generating a smart data form based on a user prompt. It helps maintain a smooth and engaging user experience by clearly indicating that the system is actively working. The indicator typically appears as a spinning animation or progress ring and is shown only while the AI is processing the prompt. Once the response is received and the form is ready to be displayed, the indicator is hidden.

```
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"

        <core:SfBusyIndicator IsVisible="False"
                              x:Name="busyIndicator"
                              IsRunning="False"
                              AnimationType="Cupertino" />
```

####  DataForm - Displaying the Generated Form

Once the AI processes the user’s prompt and returns a structured response, the application uses SfDataForm control to render the form dynamically. The form is bound to a model class that is either predefined or dynamically generated based on the AI’s output. This approach allows for rapid prototyping and deployment of forms tailored to specific data collection needs.

```
xmlns:dataform="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"

                    <dataform:SfDataForm x:Name="dataForm"
                                           Grid.RowSpan="1"
                                           Grid.Row="1" AutoGenerateItems="False"
                                           ValidationMode="PropertyChanged"
                                           LayoutType="TextInputLayout"
                                           HorizontalOptions="Center">
                        <dataform:SfDataForm.TextInputLayoutSettings>
                            <dataform:TextInputLayoutSettings ShowHelperText="True"/>
                        </dataform:SfDataForm.TextInputLayoutSettings>
                    </dataform:SfDataForm>
```

#### AI AssistView – Providing Contextual Help

The SfAIAssistView enhances the user experience by offering real-time suggestions. It acts like a chatbot embedded within the form interface. The AssistView is typically placed below the form or in a sidebar, depending on the layout, and is bound to a collection of messages or suggestions managed by the ViewModel. These messages can be updated dynamically based on user interaction or AI feedback.

```
    <aiassistview:SfAIAssistView x:Name="aiAssistView" 
                                 Grid.Row="1"                      HorizontalOptions="Fill"
                                 ShowHeader="False" 
                                 AssistItems="{Binding Messages}">
                        <aiassistview:SfAIAssistView.Behaviors>
                            <local:DataFormAssistViewBehavior x:Name="dataFormAssistViewModel" AIActionButton="{x:Reference aiActionButton}"  RefreshButton="{x:Reference refreshButton}" CloseButton="{x:Reference close}" 
                                                               DataFormNameLabel="{x:Reference dataFormNameLabel}" BusyIndicator="{x:Reference busyIndicator}"  DataForm="{x:Reference dataForm}"  DataFormGeneratorModel="{x:Reference dataFormGeneratorModel}" Entry="{x:Reference entry}" CreateButton="{x:Reference createButton}"/>
                        </aiassistview:SfAIAssistView.Behaviors>
                    </aiassistview:SfAIAssistView>
```
### Step 2: Create and Edit Data Form Items using Azure OpenAI

#### Creating Data Form Items

We first create a button click event that triggers the AI-powered form item generation process.

```
        private async void OnCreateButtonClicked(object? sender, EventArgs e)
        {
            UpdateBusyIndicator(true);

            if (AzureBaseService.IsCredentialValid && Entry?.Text is string text && !string.IsNullOrEmpty(text))
            {
                GetDataFormFromAI(text);
            }
            else if (!string.IsNullOrEmpty(DataFormGeneratorModel?.FormTitle))
            {
                await CreateOfflineDataForm(DataFormGeneratorModel.FormTitle);
                DataFormGeneratorModel.ShowInputView = false;
                DataFormGeneratorModel.ShowDataForm = true;
            }

        }
```

#### Generate Items from User Prompts

The following method sends the user’s prompt to Azure OpenAI and processes the response to generate actions such as **New Form, Change Title, Add, Remove, or Replace**.

```
internal async void GetDataFormFromAI(string userPrompt)
{
    string prompt = $"Given the user's input: {userPrompt}, determine the most appropriate single action to take. " +
        $"The options are 'Add', 'Add Values','PlaceholderText' ,'Remove', 'Replace', 'Insert', 'New Form', 'Change Title', or 'No Change'" +
        " Without additional formatting and special characters like backticks, newlines, or extra spaces.";

    var response = await this.semanticKernelService.GetAnswerFromGPT(prompt);

    if (string.IsNullOrEmpty(response))
    {
        AssistItem subjectMessage = new AssistItem() { Text = "Please try again...", ShowAssistItemFooter = false };
        this.DataFormGeneratorModel?.Messages.Add(subjectMessage);
        UpdateCreateVisibility();
        UpdateBusyIndicator(false);
    }
    else
    {
        if (response == string.Empty)
        {
            UpdateBusyIndicator(false);
            if (Application.Current != null)
            {
                var mainWindow = Application.Current.Windows.FirstOrDefault();
                if (mainWindow != null && mainWindow.Page != null)
                {
                    await mainWindow.Page.DisplayAlert("", "Please enter valid inputs.", "OK");
                }
            }
        }
        else if (response == "New Form")
        {
            if (this.DataFormGeneratorModel != null)
                this.DataFormGeneratorModel.ShowOfflineLabel = false;
            this.GenerateAIDataForm(userPrompt);
        }
        else if (response == "Change Title")
        {
            string dataFormNamePrompt = $"Change the title for data form based on user prompt: {userPrompt}. Provide only the title, with no additional explanation";
            string getDataFormName = await this.semanticKernelService.GetAnswerFromGPT(dataFormNamePrompt);
            this.DataFormNameLabel!.Text = getDataFormName;
            AssistItem subjectMessage = new AssistItem() { Text = "The Data Form title changed successfully...", ShowAssistItemFooter = false };
            this.DataFormGeneratorModel?.Messages.Add(subjectMessage);
        }
        else
        {
            this.EditDataForm(userPrompt, response);
        }
    }
}
```

```
private async void GenerateAIDataForm(string userPrompt)
{
    string dataFormNamePrompt = $"Generate a title for a data form based on the following string: {userPrompt}. The title should clearly reflect the purpose of the data form in general term. Provide only the title, with no additional explanation";
    string getDataFormName = await this.semanticKernelService.GetAnswerFromGPT(dataFormNamePrompt);
    this.DataFormNameLabel!.Text = getDataFormName;

    string prompt = $"Generate a data form based on the user prompt: {userPrompt}.";
    string condition = "Property names must be in PascalCase. " +
        "Must be property names and its value " +
        "Without additional formatting characters like backticks, newlines, or extra spaces. " +
        "and map each property to the most appropriate DataForm available item type includes: DataFormTextItem , DataFormMultiLineTextItem, DataFormPasswordItem, DataFormNumericItem, DataFormMaskedTextItem, DataFormDateItem, DataFormTimeItem, DataFormCheckBoxItem, DataFormSwitchItem, DataFormPickerItem, DataFormComboBoxItem, DataFormAutoCompleteItem, DataFormRadioGroupItem, DataFormSegmentItem" +
        "The result must be in JSON format" +
        "Without additional formatting characters like backticks, newlines, or extra spaces.";

    var typeResponse = await this.semanticKernelService.GetAnswerFromGPT(prompt + condition);

    var dataFormTypes = JsonConvert.DeserializeObject<Dictionary<string, object>>(typeResponse);

    if (this.DataForm != null && dataFormTypes != null)
    {
        var items = new ObservableCollection<DataFormViewItem>();
        foreach (var data in dataFormTypes)
        {
            DataFormItem? dataFormItem = GenerateDataFormItems(data.Value.ToString(), data.Key);
            if (dataFormItem != null)
                items.Add(dataFormItem);
        }

        this.DataForm.Items = items;
    }

    AssistItem subjectMessage = new AssistItem() { Text = "As per your comment data form created successfully...", ShowAssistItemFooter = false };
    this.DataFormGeneratorModel?.Messages.Add(subjectMessage);

    UpdateCreateVisibility();
    UpdateBusyIndicator(false);
}
```

#### Generating a New Data Form

When the user request is identified as `"New Form"`, a complete form can be created dynamically.

#### Editing Data Form Items

Azure OpenAI also allows editing an existing form. The following operations are supported:
 
(a) Add a New Item
 
* Generates a new property and maps it to the best fitting DataForm item type.
 
(b) Remove an Item
 
* Finds and removes an existing property from the DataForm.
 
(c) Replace an Item
 
* Replaces one form field with another.
 
(d) Add Values to a Field
 
* Populates additional values into picker or combo-box style items.

#### Handling Requests via AIAssistView
 
Finally, the **AIAssistView.Request** event listens to user inputs and invokes the data form generation or edit methods.

With these implementations, the DataForm becomes AI-powered, enabling users to create and modify form structures dynamically via Azure OpenAI.

```
        private async void OnAssistViewRequest(object? sender, RequestEventArgs e)
        {
            string requestText = e.RequestItem.Text;
            if (AzureBaseService.IsCredentialValid && this.DataFormGeneratorModel != null)
            {
                this.DataFormGeneratorModel.ShowOfflineLabel = false;
                this.GetDataFormFromAI(requestText);
                return;
            }

            await CreateOfflineDataForm(requestText);
        }

```

![AI powered Smart .NET MAUI Dataform](Create-Data-Form-with-AI-technology-in-.NET-MAUI.gif)

You can download the complete sample from this [link](https://www.syncfusion.com/blogs/post/ai-powered-smart-net-maui-data-forms/amp).



