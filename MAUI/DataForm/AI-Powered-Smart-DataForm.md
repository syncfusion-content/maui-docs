---
layout: post
title: AI-Powered Smart Data Entry in .NET MAUI DataForm | Syncfusion®
description: Learn how to build AI-powered smart data entry forms in .NET MAUI DataForm by integrating Azure OpenAI services for intelligent field handling.
platform: maui
control: SfDataForm
documentation: ug
---

# AI-Powered Smart Data Entry in .NET MAUI DataForm

This guide explains how to implement AI-powered smart data forms in a .NET MAUI application using Syncfusion® DataForm ([SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html)) and AIAssistView ([SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html)) controls. These forms automatically generate fields, validate input, and guide users interactively using AI logic from Azure OpenAI Services.

## Integrating AI-powered smart DataForm Generation in .NET MAUI DataForm

### Step 1: Designing the User Interface

#### Editor and Button - Capturing User Prompts

Use an Editor to collect natural language prompts and a Button to send the prompt to Azure OpenAI. The Editor allows users to describe the form they want, while the Button triggers the logic to process the prompt and generate the form.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout Margin="20" 
                     VerticalOptions="Center" 
                     HorizontalOptions="Center">
    <Label x:Name="describeLabel" 
           Text="Create AI-Powered Smart Forms in .NET MAUI for Efficient Productivity."
           LineBreakMode="WordWrap" 
           FontSize="Small" 
           FontAttributes="Bold" />
    <Grid ColumnDefinitions="0.7*,0.3*" 
          Margin="10" 
          ColumnSpacing="5">        
        <Editor x:Name="entry" 
                AutoSize="TextChanges"  
                PlaceholderColor="Gray" 
                VerticalOptions="Center" 
                HorizontalOptions="Fill" 
                Placeholder="Create your own data form" />
        <Button x:Name="createButton" 
                Grid.Column="1" 
                CornerRadius="10" 
                HeightRequest="35" 
                Text="&#xe784;"  
                FontSize="Small"
                FontFamily="MauiMaterialAssets" 
                VerticalOptions="Center" 
                HorizontalOptions="Start" />
    </Grid>
</VerticalStackLayout>

{% endhighlight %}

{% endtabs %}

#### Busy Indicator - Showing Processing Status
 
The SfBusyIndicator provides visual feedback while the AI processes the prompt. It is shown during form generation and hidden once the form is ready.

{% tabs %}

{% highlight xaml %}

xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"

        <core:SfBusyIndicator IsVisible="False"
                              x:Name="busyIndicator"
                              IsRunning="False"
                              AnimationType="Cupertino" />

{% endhighlight %}

{% endtabs %}

#### DataForm - Displaying the Generated Form

The SfDataForm renders the generated form dynamically based on the AI response. 

{% tabs %}

{% highlight xaml %}

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

{% endhighlight %}

{% endtabs %}

#### AI AssistView - Providing Suggestions
 
The SfAIAssistView offers contextual help, such as real-time suggestions or chatbot-style assistance. 

{% tabs %}

{% highlight xaml %}

<aiassistview:SfAIAssistView x:Name="aiAssistView" 
                             Grid.Row="1"                      HorizontalOptions="Fill"
                             ShowHeader="False" 
                             AssistItems="{Binding Messages}">
    <aiassistview:SfAIAssistView.Behaviors>
        <local:DataFormAssistViewBehavior x:Name="dataFormAssistViewModel"  AIActionButton="{x:Reference aiActionButton}"  
        RefreshButton="{x:Reference refreshButton}" 
        CloseButton="{x:Reference close}" 
        DataFormNameLabel="{x:Reference dataFormNameLabel}" 
        BusyIndicator="{x:Reference busyIndicator}"  
        DataForm="{x:Reference dataForm}"  
        DataFormGeneratorModel="{x:Reference dataFormGeneratorModel}" Entry="{x:Reference entry}" 
        CreateButton="{x:Reference createButton}"/>
    </aiassistview:SfAIAssistView.Behaviors>
</aiassistview:SfAIAssistView>

{% endhighlight %}

{% endtabs %}

### Step 2: Create and Edit DataForm Items using Azure OpenAI

#### Creating DataForm Items

We first create a button click event that triggers the AI-powered form item generation process.

{% tabs %}

{% highlight c# %}

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

{% endhighlight %}

{% endtabs %}

#### Generate Items from User Prompts

The following method sends the user’s prompt to Azure OpenAI and processes the response to generate actions such as New Form, Change Title, Add, Remove, or Replace.

{% tabs %}

{% highlight c# %}

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

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}

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

{% endhighlight %}

{% endtabs %}

#### Generating a New DataForm

When the user request is identified as "New Form", a complete form can be created dynamically.

#### Editing DataForm Items

Azure OpenAI also allows editing an existing form. The following operations are supported:
 
(a) Add a New Item
 
* Generates a new property and maps it to the best fitting DataForm item type.
 
(b) Remove an Item
 
* Finds and removes an existing property from the DataForm.
 
(c) Replace an Item
 
* Replaces one form field with another.
 
(d) Add Values to a Field
 
* Populates additional values into picker or combo-box items.

#### Handling Requests via AIAssistView
 
Finally, the `Request` event in AIAssistView listens to user inputs and invokes the DataForm generation or edit methods.

With these implementations, the DataForm becomes AI-powered, enabling users to create and modify form structures dynamically via Azure OpenAI.

{% tabs %}

{% highlight c# %}

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

{% endhighlight %}

{% endtabs %}

![AI powered Smart .NET MAUI Dataform](images/smart-ai-samples/Create-Data-Form-with-AI-technology-in-.NET-MAUI.gif)

You can download the complete sample from this [link](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartDemos/SampleBrowser.Maui.SmartDemos/Samples/SmartDemos/SmartDataForm).
