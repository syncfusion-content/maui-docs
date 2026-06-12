---
layout: post
title: Items in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Items support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Work with Items in .NET MAUI SfAIAssistView?

Learn how to work with different item types in Syncfusion .NET MAUI [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html), including text, image, card, hyperlink, and attachment items.

## Configuring common settings for the AssistItem

<table>
<tr>
<td>{{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Text)'| markdownify }}</td>
<td>Displays the content of the assist item in the AI Assist view.</td>
</tr>
<tr>
<td>{{'[Profile](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Profile)'| markdownify }}</td>
<td>Specify the avatar and name of the user using {{'[Profile.Avatar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Profile.html#Syncfusion_Maui_AIAssistView_Profile_Avatar)'| markdownify }} and {{'[Profile.Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Profile.html#Syncfusion_Maui_AIAssistView_Profile_Name)'| markdownify }} properties respectively.</td>
</tr>
<tr>
<td>{{'[Data](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Data)'| markdownify }}</td>
<td>Stores the original data of the item.</td>
</tr>
<tr>
<td>{{'[DateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_DateTime)'| markdownify }}</td>
<td>Displays the time when the item was sent or received.</td>
</tr>
<tr>
<td>{{'[IsLiked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsLiked)'| markdownify }}</td>
<td>Gets or sets the rating associated with the request item.</td>
</tr>
<tr>
<td>{{'[IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested)'| markdownify }}</td>
<td>Determines whether the assist item is a request or a response.</td>
</tr>
<tr>
<td>{{'[RequestItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_RequestItem)'| markdownify }}</td>
<td>Gets the data associated with the request sent by the user for which the response is generated.</td>
</tr>
<tr>
<td>{{'[ErrorMessage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_ErrorMessage)'| markdownify }}</td>
<td>Displays the error message for the assist item</td>
</tr>
<tr>
<td>{{'[Suggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Suggestion)'| markdownify }}</td>
<td>Displays list of {{'[AssistSuggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistSuggestion.html)'| markdownify }} as a response to a request.</td>
</tr>
<tr>
<td>{{'[SuggestionHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_SuggestionHeaderText)'| markdownify }}</td>
<td>Displays the header text above the suggestions list.</td>
</tr>
<tr>
<td>{{'[ShowAssistItemFooter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_ShowAssistItemFooter)'| markdownify }}</td>
<td>Determines whether the footer, which includes Copy, Retry, Like, Dislike, should be displayed for the assist item.</td>
</tr>
<tr>
<td>{{'[Sources]()'| markdownify }}</td>
<td>Determines whether the footer, which includes Copy, Retry, Like, Dislike, should be displayed for the assist item.</td>
</tr>
</table>


## Text item

The [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) is used to display plain text as a item, which is used to represent text-based content.

{% tabs %}
{% highlight xaml %}
    
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<ContentPage.Content>
    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               AssistItems="{Binding AssistItems}"/>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.AIAssistView;

    SfAiAssistView sfAIAssistView = new SfAIAssistView();
    ViewModel viewModel = new ViewModel();
    this.sfAIAssistView.AssistItems = viewModel.AssistItems;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="6" %}
    
    public class ViewModel : INotifyPropertyChanged
    {

        private void GenerateAssistItems()
        {
            AssistItem requestItem = new AssistItem()
            {
               // Adding a user request as a text item
               Text = "Hey AI, can you tell me what MAUI is? Could you provide a link to learn more about .NET MAUI?",
               IsRequested = true
            };

            this.AssistItems.Add(requestItem);

            // Generating response item
            await GetResult(requestItem);
        }
           
        private async Task GetResult(AssistItem requestItem)
        {
           await Task.Delay(1000).ConfigureAwait(true);
 
           AssistItem responseItem = new AssistItem()
           {
             // Adding a text item as a response from the AI service
             Text = "Sure! MAUI stands for .NET Multi-platform App UI. It’s a framework that allows you to create cross-platform applications using a single codebase.This powerful framework is an evolution of Xamarin.Forms and is designed to streamline the development process by allowing you to write code once and deploy it across multiple platforms.",
,
           };
 
           // Add the response item to the collection
           this.AssistItems.Add(responseItem);

        }
    }
    
{% endhighlight %}
{% endtabs %}

## Hyperlink item

The [AssistHyperlinkItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistHyperlinkItem.html) is used to send a [URL](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistHyperlinkItem.html#Syncfusion_Maui_AIAssistView_AssistHyperlinkItem_Url) as a item. Along with the link, the thumbnail, title, and description of the URL are automatically fetched and displayed.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="22" %}

    public class ViewModel : INotifyPropertyChanged
    {

        private void GenerateAssistItems()
        {
            AssistItem requestItem = new AssistItem()
            {
               Text = "Hey AI, can you tell me what MAUI is? Could you provide a link to learn more about .NET MAUI?",
               IsRequested = true
            };

            this.AssistItems.Add(requestItem);
        
            // Generating response item
            await GetResult(requestItem);
        }

        private async Task GetResult(AssistItem requestItem)
        {
           await Task.Delay(1000).ConfigureAwait(true);

            AssistItem responseItem = new AssistHyperlinkItem()
            {
                // Adding a hyperlink item as a response from the AI service.
                Text = "MAUI stands for .NET Multi-platform App UI. It's a .NET framework for building cross-platform apps with a single C# codebase for iOS, Android, macOS, and Windows. Sure! Here's a link to learn more about .NET MAUI",
                Url = "https://dotnet.microsoft.com/en-us/apps/maui",
            };

           // Add the response item to the collection
           this.AssistItems.Add(responseItem);
        }

    } 

{% endhighlight %}
{% endtabs %}

## Image item

The [AssistImageItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html) is used to display an image as a item. Using the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html#Syncfusion_Maui_AIAssistView_AssistImageItem_Source), [Size](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html#Syncfusion_Maui_AIAssistView_AssistImageItem_Size), and [Aspect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html#Syncfusion_Maui_AIAssistView_AssistImageItem_Aspect) properties, you can display the desired image in the desired height and width as a item in the AI AssistView control.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="23" %}

    public class ViewModel : INotifyPropertyChanged
    {

        private void GenerateAssistItems()
        {
            AssistItem requestItem = new AssistItem()
            {
                 Text = "Hey AI, Please share an image of bird.",
                 IsRequested = true
            };

            this.AssistItems.Add(requestItem);
            
            // Generating response item
            await GetResult(requestItem);
        }
        
        private async Task GetResult(AssistItem requestItem)
        {
            await Task.Delay(1000).ConfigureAwait(true);
            
            // Adding image item as a response from the AI service.
            AssistItem responseItem = newnew AssistImageItem()
            {
                  Aspect = Aspect.AspectFit,
                  Text = "Here's an image of a bird.",
                  Source = "bird01.png"          
            };

            // Add the response item to the collection
           this.AssistItems.Add(responseItem);
        }

    }

{% endhighlight %}
{% endtabs %}

## Card item

In AI AssistView, to display a list of interactive cards, each card can contain an image, a list of buttons, and text (title, subtitle, and description) that align with the design used in popular bot frameworks. The [Card.Image](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Image), [Card.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Title), [Card.Subtitle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Subtitle), and [Card.Description](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Description) properties are used to define and display the image, title, subtitle, and description within each card.
 
{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="57" %}

    public class ViewModel : INotifyPropertyChanged
    {

        public ViewModel()
        {
            this.assistItems = new ObservableCollection<IAssistItem>();

            //Generate card items
            this.GenerateCards();

            //Generate assist items with card responses
            this.GenerateAssistItems();
        }

        private void GenerateCards()
        {
            cardsCollection = new ObservableCollection<Card>();
            Card card1 = new Card()
            {
                Title = "Miami",
                Description = "Miami, officially the City of Miami, is the seat of Miami-Dade County and the cultural, economic and financial center of South Florida in the United States. The city covers an area of about 56 square miles between the Everglades to the west and Biscayne Bay to the east.",
                Image = "miami.png",
            };
            card1.Buttons.Add(new CardButton() { Title = "Choose", Value = "Miammi" });

            Card card2 = new Card()
            {
                Title = "A popular tourist destination, San Francisco is known for its cool summers, fog, steep rolling hills, eclectic mix of architecture, and landmarks, including the Golden Gate Bridge, cable cars, the former Alcatraz Federal Penitentiary, Fisherman's Wharf, and its Chinatown district.",
                Image = "sanfrancisco.png",
            };
            card2.Buttons.Add(new CardButton() { Title = "Choose", Value = "San Francisco" });

            Card card3 = new Card()
            {
                Title = "Las Vegas",
                Description = "Las Vegas is an internationally renowned major resort city, known primarily for its gambling, shopping, fine dining, entertainment, and nightlife. The Las Vegas Valley as a whole serves as the leading financial, commercial, and cultural center for Nevada.",
                Image = "lasvegas.png",
            };
            card3.Buttons.Add(new CardButton() { Title = "Choose", Value = "Las Vegas" });

            Card card4 = new Card()
            {
                Title = "Dallas",
                Description = "Dallas, a modern metropolis in north Texas, is a commercial and cultural hub of the region. The Downtown Sixth Floor Museum at Dealey Plaza commemorates the site of President John F. Kennedy's assassination in 1963. In the Arts District, the Dallas Museum of Art and the Crow Collection of Asian Art cover thousands of years of art. The sleek Nasher Sculpture Center showcases contemporary sculpture.",
                Image = "dallas.png",
            };
            card4.Buttons.Add(new CardButton() { Title = "Choose", Value = "Dallas" });

            this.CardsCollection.Add(card1);
            this.CardsCollection.Add(card2);
            this.CardsCollection.Add(card3);
            this.CardsCollection.Add(card4);
        }   
        
        private void GenerateAssistItems()
        {
            AssistItems.Add(new AssistCardItem()
            {
                Cards = CardsCollection,
            });
        }
    }

{% endhighlight %}
{% endtabs %}

## Attachment item

The [AssistAttachmentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachmentItem.html) is used to display the preview for a file or an image as a item. Using the [Attachments](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Attachments) property, you can display the desired attachments as item in the AI AssistView control.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="8" %}

public class ViewModel : INotifyPropertyChanged
{
    private async void GenerateAssistItems()
    {
        // Adding a user request as attachments 
        var requestItem = new AssistAttachmentItem()
        {
            Text = "Read the following documents",
            IsRequested = true,
            Attachments = new List<IAttachment> { staticAttachment1, staticAttachment2, staticAttachment3 }
        };

        AssistItems.Add(requestItem);

        // Generating response item
        await GetResult(requestItem);
    }

    private async Task GetResult(AssistItem requestItem)
    {
        await Task.Delay(1000).ConfigureAwait(true);

        AssistItem responseItem = new AssistItem()
        {
            // Adding a text item as a response from the AI service
            Text = "Thank you for sharing the documents. I will review the text file, the Excel sheet, and the PDF to provide you with a summary or any insights you need. Please let me know if you have any specific questions about these files.",
            IsRequested = false,
        };

        // Add the response item to the collection
        this.AssistItems.Add(responseItem);
    }
}

{% endhighlight %}
{% endtabs %}

## Show error response

The `SfAIAssistView` allows to display error responses by setting the error text to the [AssistItem.ErrorMessage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.IAssistItem.html#Syncfusion_Maui_AIAssistView_IAssistItem_ErrorMessage) property, ensuring clear notification when an error occurs during AI interactions.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="34" %}
    
public class ViewModel : INotifyPropertyChanged
{

    private async void GenerateAssistItems()
    {
        AssistItem requestItem = new AssistItem()
        {
            Text = "Types of listening",
            IsRequested = true
        };

        this.AssistItems.Add(requestItem);

        await GetResultAsync(requestItem);
    }
        
    private async Task GetResultAsync(AssistItem requestItem)
    {
       try
       {
           await Task.Delay(1000);
           // If successful, add the normal response
           AssistItem responseItem = new AssistItem()
           {
              Text = "Active Listening – Fully focusing and responding to the speaker with attention and empathy. Passive Listening – Hearing without reacting or engaging with the speaker. Empathetic Listening – Understanding the speaker’s emotions and feelings deeply.",
              IsRequested = false,
           };
           this.AssistItems.Add(responseItem);
        }
        catch (Exception ex)
        {
            AssistItem errorItem = new AssistItem()
            {
               ErrorMessage = "An error occurred. Either the engine you requested does not exist or there was another issue processing your request.",
               IsRequested = false,
            };
            this.AssistItems.Add(errorItem);
        }
    }
}
    
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI SfAIAssistView error message display](images/maui-aiassistview-error-message.png)

## Request and response item
 
The [IsRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_IsRequested) property is used to determine whether a item is a Request or a Response. If `IsRequested` property is set to `true`, the item is a Request item.
 
### Request item

These are the items sent by the user. They typically appear aligned to the right side of the window to visually differentiate them as user inputs.
 
{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="4" %}
 
  AssistItem requestItem = new AssistItem()
  {
      Text = "listening",
      IsRequested = true
  };
 
{% endhighlight %}
{% endtabs %}
 
### Response item

These are messages generated by the AI in reply to a request. They are usually aligned to the left side of the window to indicate that they are responses.
 
{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="4" %}
 
  AssistItem responseItem = new AssistItem()
  {
      Text ="Types of Listening : For a good communication, it is not only enough to convey the information efficiently, but it also needs to include good listening skill. Common types of Listening are Active listening and Passive listening.",
      IsRequested = false,
  };
 
{% endhighlight %}
{% endtabs %}
