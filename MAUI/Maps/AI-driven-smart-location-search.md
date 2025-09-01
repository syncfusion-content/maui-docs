---
layout: post
title: AI-Driven smart location search in .NET MAUI Maps control | Syncfusion
description: Learn here all about the AI-Driven smart location searching feature of Syncfusion<sup>&reg;</sup> .NET MAUI Maps (SfMaps) control and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# AI-Driven Smart Location Search in .NET MAUI Maps (SfMaps)

This document provides a comprehensive guide to implementing advanced search functionality within the Syncfusion [.NET MAUI Maps](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html) control. By integrating **Azure OpenAI**, this solution enables an intelligent, AI-powered location search experience.

## Integrating Azure OpenAI with the .NET MAUI app

First, open [Visual Studio](https://visualstudio.microsoft.com/) and [create a new .NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-7.0&tabs=vswin&pivots=devices-android).

Before unlocking the power of AI to locate specific places effortlessly, ensure that you have access to [Azure OpenAI](https://azure.microsoft.com/en-in/products/ai-services/openai-service) and have set up a deployment in the Azure portal. You can find the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12) NuGet package in the [NuGet Gallery](https://www.nuget.org/) and install it in the project.

Once you get your key and endpoint, follow these steps:

### Step 1: Set up Azure OpenAI

To configure **Azure OpenAI**, we’ll use the **GPT-4O** model for text and the **DALL-E** model for images. Set up the `OpenAIClient` as shown in the following code example.

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
    this.client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(key)

{% endhighlight %}

{% endtabs %}

This connection allows you to send prompts to the model and **receive responses**, which can be used to generate map markers for .NET MAUI Maps.

### Step 3: Get the result from the AI service

Implement the `GetResultsFromAI` and `GetImageFromAI` methods to retrieve responses from the **OpenAI** API based on user input.

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

public async Task<Uri> GetImageFromAI(string? locationName)
{
    var imageGenerations = await Client!.GetImageGenerationsAsync(
        new ImageGenerationOptions()
        {
            Prompt = $"Share the {locationName} image. If the image is not available share common image based on the location",
            Size = ImageSize.Size1024x1024,
            Quality = ImageGenerationQuality.Standard,
            DeploymentName = imageDeploymentName,
        });
        var imageUrl = imageGenerations.Value.Data[0].Url;
        return new Uri(imageUrl.ToString());
}

{% endhighlight %}

{% endtabs %}

The **AzureOpenAIService** class now offers a convenient way to interact with the **OpenAI** API and retrieve completion results based on the provided **prompt**.

## Integrating AI-powered smart location search in .NET MAUI Autocomplete

To design the AI-powered smart location search UI using the [.NET MAUI Autocomplete](https://www.syncfusion.com/maui-controls/maui-autocomplete) control and then map the selected location into the **.NET MAUI Maps** control. Before proceeding, please refer to the getting started documentation for both Syncfusion .NET MAUI Maps and Autocomplete controls.

### Step 1: Create a custom marker model

Create a custom marker model to define geographic location information for .NET MAUI **Maps tile layer markers**. The model can also include a name, details, address, and image to provide additional information for the **marker tooltip**.

{% tabs %}

{% highlight c# %}

public class CustomMarker : MapMarker
{
     public string? Name { get; set; }

     public string? Details { get; set; }
     
     public Uri? Image { get; set; }

     public string? Address { get; set; }

     public string? ImageName { get; set; }
}

{% endhighlight %}

{% endtabs %}

### Step 2: Add Maps tile layer in .NET MAUI Maps

Now, add a [tile layer](https://help.syncfusion.com/maui/maps/getting-started#add-tile-layer) in the .NET MAUI Maps that can be used to search for and locate landmarks based on user input.

{% tabs %}

{% highlight xaml %}

<maps:SfMaps x:Name="maps">
    <maps:SfMaps.Layer>
        <maps:MapTileLayer x:Name="layer"
                          UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png"
                           CanCacheTiles="True"
                           ShowMarkerTooltip="True">
            <maps:MapTileLayer.Center>
                <maps:MapLatLng x:Name="mapLatLng"
                                Latitude="37.0902"
                                Longitude="-95.7129">
                </maps:MapLatLng>
            </maps:MapTileLayer.Center>
            
            <maps:MapTileLayer.ZoomPanBehavior>
               <maps:MapZoomPanBehavior x:Name="zoomPanBehavior"
                                          ZoomLevel="4"
                                          MinZoomLevel="4"
                                          MaxZoomLevel="18"
                                          EnableDoubleTapZooming="True" />
            </maps:MapTileLayer.ZoomPanBehavior>
        </maps:MapTileLayer>
   </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% endtabs %}

### Step 3: Customizing the .NET MAUI Maps marker and tooltips

In this step, we’ll customize the .NET MAUI Maps markers and tooltips to effectively display relevant information, thereby improving the overall user experience on the map.

{% tabs %}

{% highlight xaml %}

<Grid.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="MarkerTemplate">
            <StackLayout IsClippedToBounds="false"
                         HorizontalOptions="Start"
                         VerticalOptions="Start"
                         HeightRequest="30">
                <Image Source="map_pin.png"
                       Scale="1"
                       Aspect="AspectFit"
                       HorizontalOptions="Start"
                       VerticalOptions="Start"
                       HeightRequest="30"
                       WidthRequest="30" />
            </StackLayout>
        </DataTemplate>
      
        <DataTemplate x:Key="DetailTemplate">
            <Frame HasShadow="True" Margin="0" Padding="0" CornerRadius="10" WidthRequest="250">
                <StackLayout BackgroundColor="Transparent" Orientation="Vertical">
                    <Image Source="{Binding DataItem.Image}" HeightRequest="120" Margin="0" WidthRequest="250" Aspect="AspectFill"/>
                    <Label Grid.Row="1" Text="{Binding DataItem.Name}" FontAttributes="Bold" FontSize="12" LineBreakMode="WordWrap" Padding="10,5,0,0"/>
                    <Label Grid.Row="2" Text="{Binding DataItem.Details}" LineBreakMode="WordWrap" FontSize="10" Padding="10,0,0,0"/>
                    <Label Grid.Row="3" Padding="10,0,0,5">
                        <Label.FormattedText>
                            <FormattedString>
                                <Span Text="&#xe76e;" FontSize="8" FontFamily="MauiSampleFontIcon"/>
                                <Span Text="{Binding DataItem.Address}" FontSize="10"/>
                            </FormattedString>
                        </Label.FormattedText>
                    </Label>
                </StackLayout>
            </Frame>
        </DataTemplate>
      
        <DataTemplate x:Key="NormalTemplate">
            <Frame HasShadow="True" Margin="0" Padding="0" CornerRadius="10" WidthRequest="250">
                <StackLayout BackgroundColor="Transparent" Orientation="Vertical">
                    <Image Source="{Binding DataItem.Image}" HeightRequest="120" Margin="0" WidthRequest="250" Aspect="AspectFill"/>
                    <Label Grid.Row="1" Text="{Binding DataItem.Name}" FontAttributes="Bold" FontSize="12" LineBreakMode="WordWrap" Padding="10,5,0,0"/>
                    <Label Grid.Row="2" Text="{Binding DataItem.Details}" LineBreakMode="WordWrap" FontSize="10" Padding="10,0,0,5"/>
                </StackLayout>
            </Frame>
        </DataTemplate>
        
        <local:MarkerTemplateSelector x:Key="MarkerTemplateSelector"
                       DetailTemplate="{StaticResource DetailTemplate}"
                       NormalTemplate="{StaticResource NormalTemplate}"/>
    </ResourceDictionary>
</Grid.Resources>

<maps:SfMaps x:Name="maps">
    <maps:SfMaps.Layer>
        <maps:MapTileLayer x:Name="layer"
                          UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png"
                           CanCacheTiles="True"
                           ShowMarkerTooltip="True"
                           MarkerTooltipTemplate="{StaticResource MarkerTemplateSelector}"
                           MarkerTemplate="{StaticResource MarkerTemplate}">
          <maps:MapTileLayer.MarkerTooltipSettings>
            <maps:MapTooltipSettings Background="Transparent"/>
          </maps:MapTileLayer.MarkerTooltipSettings>
        </maps:MapTileLayer>
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% endtabs %}

Refer to the following code example to select the marker tooltip data template.

{% tabs %}

{% highlight c# %}

public class MarkerTemplateSelector : DataTemplateSelector
{
        public DataTemplate? NormalTemplate { get; set; }
        public DataTemplate? DetailTemplate { get; set; }
        
        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            var customMarker = (CustomMarker)item;
            return customMarker.Address == null ? NormalTemplate : DetailTemplate;
        }
}

{% endhighlight %}

{% endtabs %}

### Step 4: Integrating .NET MAUI Autocomplete in searching UI

Then, we’ll add the .NET MAUI Autocomplete control to collect the user input, which can then be passed to an AI service to retrieve geometric details.

Refer to the following code example to add the .NET MAUI Autocomplete control and design a search button.

{% tabs %}

{% highlight xaml %}

<HorizontalStackLayout VerticalOptions="Start" IsClippedToBounds="False" HorizontalOptions="Start" WidthRequest="{OnPlatform Default=350, Android=300}" Margin="10" IsVisible="True">
    <!--Get location inputs from users to find a location-->
    <editors:SfAutocomplete x:Name="autoComplete"
                            IsClearButtonVisible="False"
                            HorizontalOptions="Start"
                            WidthRequest="{OnPlatform Default=350, Android=300}"
                            HeightRequest="50"
                            DropDownItemHeight="50" 
                            Text="Hospitals in New York">
    </editors:SfAutocomplete>
    
    <!--Location Search button -->
    <Button x:Name="button" Text=""
            Margin="-55,0,0,0"
            BackgroundColor="Transparent"
            BorderColor="Transparent"
            FontSize="20"
            TextColor="Black"
            FontFamily="MauiSampleFontIcon"
            HeightRequest="50"
            WidthRequest="50"/>
</HorizontalStackLayout>

{% endhighlight %}

{% endtabs %}

### Step 5: Enable AI-powered smart searching in .NET MAUI Maps

Add the **prompt** that requests the AI service to convert the user input into geographic locations in **JSON** format. The **JSON** data is then parsed into custom markers, which are added to the **.NET MAUI Maps** by using its **Markers** property in the **MapTileLayer** class.

{% tabs %}

{% highlight c# %}

private async Task GetRecommendationAsync(string userQuery)
{
    if (this.autoComplete == null || this.mapTileLayer == null || this.zoomPanBehavior == null)
    {
        return;
    }
    
    if (string.IsNullOrWhiteSpace(this.autoComplete.Text))
    {
        return;
    }
    
    if (this.busyIndicator != null)
    {
        this.busyIndicator.IsVisible = true;
        this.busyIndicator.IsRunning = true;
    }
     
    //Prompt that requests the AI service to convert the user input into geographic locations.
    string prompt = $"Given location name: {userQuery}" +
       $"\nSome conditions need to follow:" +
       $"\nCheck the location name is just a state, city, capital or region, then retrieve the following fields: location name, detail, latitude, longitude, and set address value as null" +
       $"\nOtherwise, retrieve minimum 5 to 6 entries with following fields: location's name, details, latitude, longitude, address." +
       $"\nThe return format should be the following JSON format: markercollections[Name, Details, Latitude, Longitude, Address]" +
       $"\nRemove ```json and remove ``` if it is there in the code." +
       $"\nProvide JSON format details only, No need any explanation.";

    var returnMessage = await azureAIHelper.GetResultsFromAI(prompt);
    var jsonObj = new JObject();
    jsonObj = JObject.Parse(returnMessage);

    this.customMarkers?.Clear();
    foreach (var marker in jsonObj["markercollections"])
    {
           CustomMarker customMarker = new CustomMarker();
           customMarker.Name = (string)marker["Name"];
           customMarker.Details = (string)marker["Details"];
           customMarker.Address = (string)marker["Address"];
           customMarker.Latitude = StringToDoubleConverter((string)marker["Latitude"]);
           customMarker.Longitude = StringToDoubleConverter((string)marker["Longitude"]);
           if (this.azureAIHelper.Client != null)
           {
               customMarker.Image = await azureAIHelper.GetImageFromAI(customMarker.Name);
               customMarker.ImageName = string.Empty;
           }
           //JSON data is then parsed into custom markers to add in .NET MAUI Maps.
           this.customMarkers?.Add(customMarker);
    }

    this.mapTileLayer.Markers = this.customMarkers;
    this.mapTileLayer.EnableCenterAnimation = true;
    if (this.customMarkers != null && this.customMarkers.Count > 0)
    {
         var firstMarker = this.customMarkers[0];
         this.mapTileLayer.Center = new MapLatLng
         {
             Latitude = firstMarker.Latitude,
             Longitude = firstMarker.Longitude,
         };

         if (this.azureAIHelper.Client != null)
         {
              this.zoomPanBehavior.ZoomLevel = 10;
         }
    }
}

{% endhighlight %}

{% endtabs %}

You can find the complete sample from this [link](https://github.com/SyncfusionExamples/Integrating-AI-Driven-Location-Search-into-.NET-MAUI-Maps).