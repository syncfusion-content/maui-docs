---
layout: post
title: AI-Powered Smart Cropping in .NET MAUI Image Editor
description: Learn how to use Syncfusion® .NET MAUI Image Editor with Azure AI Vision to suggest a smart crop region based on the important content in an image.
platform: MAUI
control: SfImageEditor
documentation: ug
keywords: .net maui image editor, smart cropping, ai vision, crop suggestion, image editing
---

# AI-Powered Smart Cropping in .NET MAUI Image Editor

## Applies To

This document explains how to build the Smart Cropping sample for **Syncfusion® .NET MAUI Image Editor** by combining **SfImageEditor** with **Azure AI Vision Image Analysis**. The sample analyzes the selected image, identifies the primary subject, and suggests a crop region that matches the chosen intent, such as product image, pet portrait, food photography, hero banner, or object focus.

## Overview

The Smart Cropping sample helps users crop images more accurately by using AI to detect the most important visual content in an image. Instead of manually estimating the crop area, the sample sends the image to Azure AI Vision and receives a suggested crop rectangle that can be previewed inside the Image Editor.

The sample demonstrates the following workflow:

- Load an image into **SfImageEditor**.
- Let the user choose a crop intent.
- Send the image to Azure AI Vision Image Analysis.
- Receive a suggested crop region and a short framing explanation.
- Preview the crop overlay in the editor.
- Apply, reset, or save the cropped image.

## Integrating Smart Cropping with SfImageEditor

Before proceeding, ensure that Azure AI Vision is configured in your .NET MAUI application. Refer to the AI solution prerequisites and complete the required setup steps.

The sample uses a view model to coordinate the editor, the crop overlay, and the AI service. When the user requests a smart crop, the image bytes are sent to the AI service together with the selected crop intent. The response is parsed into a crop region and displayed on top of the editor.

### Image Editor layout

The page hosts **SfImageEditor** and a custom crop overlay. The editor is configured without the built-in toolbar because the sample uses its own action buttons for open, smart crop, apply, reset, and save.

{% tabs %}

{% highlight xaml %}
<sf:SfImageEditor x:Name="ImageEditor"
                  BackgroundColor="#F8FAFC"
                  ShowToolbar="False"
                  AutoGenerateToolbarItems="False" />

<helpers:CropOverlayView x:Name="CropOverlay"
                         IsOverlayVisible="{Binding IsOverlayVisible}"
                         OverlayX="{Binding OverlayX, Mode=OneWay}"
                         OverlayY="{Binding OverlayY, Mode=OneWay}"
                         OverlayWidth="{Binding OverlayWidth, Mode=OneWay}"
                         OverlayHeight="{Binding OverlayHeight, Mode=OneWay}" />
{% endhighlight %}

{% endtabs %}

The UI also includes a combo box to choose the crop intent and action buttons to drive the workflow.

### Smart crop request

The view model sends the loaded image to the AI service and waits for a crop response. The service prompt is tailored to the selected intent so the crop result stays focused on the correct framing style.

{% tabs %}

{% highlight c# %}
[RelayCommand(CanExecute = nameof(CanSmartCrop))]
public async Task SmartCropAsync()
{
    if (IsBusy || editorController is null || originalImageBytes is null || string.IsNullOrWhiteSpace(SelectedIntent))
    {
        return;
    }

    IsBusy = true;
    IsError = false;
    StatusMessage = "Analyzing image and generating crop suggestion...";

    try
    {
        SmartCropResponse? response = await aiService.GetSmartCropAsync(originalImageBytes, SelectedIntent);
        if (response is null)
        {
            ShowError("Unable to generate a smart crop suggestion.");
            return;
        }

        suggestedRegion = response.CropRegion;
        SuggestionReason = response.Framing;
        StatusMessage = "Smart crop suggestion is ready.";
        IsSuggestionAvailable = true;
        IsOverlayVisible = true;
        UpdateOverlayFromSuggestedRegion();
    }
    catch
    {
        ShowError("Unable to generate a smart crop suggestion.");
    }
    finally
    {
        IsBusy = false;
    }
}
{% endhighlight %}

{% endtabs %}

## AI Service used in the sample

The sample uses a dedicated AI service to build the crop prompt, send the image to Azure OpenAI Vision, and convert the response into a strongly typed crop model. The service returns both the crop rectangle and the framing explanation shown in the UI.

{% tabs %}

{% highlight c# %}
private const string SystemPrompt =
"""
You are an image cropping assistant. The user will tell you how the image
will be used (the crop intent) and you must let that intent drive how
tight or wide the crop is.

Rules that always apply:

1. Suggest exactly ONE rectangular crop region.
2. Use the original image's pixel dimensions (top-left origin).
3. Stay strictly inside the image boundary on every side.
4. Never cut through the main subject the intent refers to.

Return ONLY valid JSON with no commentary, no markdown fences, and no
extra keys.
""";

private static readonly Dictionary<string, string> IntentPrompts = new()
{
    ["Product Image"] = "The image will be used as a product showcase.",
    ["Pet Portrait"] = "The image will be used as a pet portrait.",
    ["Food Photography"] = "The image will be used for food photography.",
    ["Hero Banner"] = "The image will be used as a website hero banner.",
    ["Object Focus"] = "The image will be used to emphasize the primary subject."
};
{% endhighlight %}

{% endtabs %}

The AI response is then validated and used to position the crop overlay in the editor.

## Step-by-Step Workflow

### Step 1: Open an image

The user opens an image from the device. The sample stores the original image bytes so the same image can be sent to the AI service without losing fidelity.

### Step 2: Select a crop intent

The user chooses how the image will be used. The selected intent changes the prompt sent to Azure AI Vision so the crop suggestion matches the expected framing style.

### Step 3: Generate the crop suggestion

The sample sends the image bytes and intent to the AI service. The service returns a JSON response that contains:

- the crop rectangle
- a short explanation of the framing decision

### Step 4: Preview the crop in SfImageEditor

The crop rectangle is displayed as an overlay on top of **SfImageEditor**. The user can review the suggestion before applying it.

### Step 5: Apply, reset, or save

After reviewing the suggestion, the user can:

- apply the suggested crop
- reset to the original image
- save the final result

## Controls Used

- **SfImageEditor** — displays and edits the selected image.
- **SfComboBox** — lets the user choose the crop intent.
- **Button** — triggers open, smart crop, apply, reset, and save actions.
- **Border**, **Grid**, and **VerticalStackLayout** — arrange the editor, status area, and action controls.

## Output

The final UI shows an Image Editor with an AI-generated crop preview, intent selection, and actions for applying or resetting the crop.

## See Also

- [Syncfusion® .NET MAUI Image Editor Overview](/maui/ImageEditor/overview)
- [Syncfusion® Smart AI Solutions for .NET MAUI](/maui/SmartAISolutions/Overview)
- [Prerequisites for the AI solution samples](/maui/SmartAISolutions/Prerequisites)
